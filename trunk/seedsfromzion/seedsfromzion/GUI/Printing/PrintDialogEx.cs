// Copyright (c) 2006, Christopher Tan
// All rights reserved.
//
// While you are not strictly required to, 
// please send me any changes or improvements you make
// to this code.
//
// Email: Christopher Tan <cabbage.ph@gmail.com>

using System;

using System.Text;
using System.Resources;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using Microsoft.Win32;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace seedsfromzion.GUI.Printing
{
    using System.Drawing.Printing;
    using NativeResource;

    /// <summary>
    /// Customized print dialog control which provides the following features:
    /// - Topmost attribute
    /// - Persistent Window Location
    /// - Background printing
    /// - Show/Hides print status dialog
    /// TO DO:
    ///		- internationalization support.
    ///		- extended functionalities
    /// </summary>
    public sealed class PrintDialogEx : IDisposable
    {
        public static readonly string TITLE = "Print";

        /// <summary>
        /// Default PrintDlg width
        /// </summary>
        private const int DEFAULT_WIDTH = 510;
        /// <summary>
        /// Default PrintDlg height
        /// </summary>
        private const int DEFAULT_HEIGHT = 315;

        /// <summary>
        /// Padding space sdded in the bottom of this dialog
        /// </summary>
        private const int EXT_DIALOG_PADDING = 80;

        /// <summary>
        /// print event is fired whenever the user clicks the OK button.
        /// </summary>
        public event EventHandler m_oPrintEventHandler;

        #region Defines the shape of hook procedures that can be called by the PrintDlg
        /// <summary>
        /// Defines the shape of hook procedures that can be called by the PrintDlg
        /// </summary>
        internal delegate IntPtr PrintHookProc(IntPtr hWnd, UInt16 msg, Int32 wParam, Int32 lParam);

        [DllImport("comdlg32.dll", CharSet = CharSet.Auto)]
        static extern bool PrintDlg([In, Out] PRINTDLG lppd);

        /// <summary>
        /// Values that can be placed in the PRINTDLG structure, we don't use all of them
        /// </summary>
        internal class PrintFlag
        {
            public const Int32 PD_ALLPAGES = 0x00000000;
            public const Int32 PD_SELECTION = 0x00000001;
            public const Int32 PD_PAGENUMS = 0x00000002;
            public const Int32 PD_NOSELECTION = 0x00000004;
            public const Int32 PD_NOPAGENUMS = 0x00000008;
            public const Int32 PD_COLLATE = 0x00000010;
            public const Int32 PD_PRINTTOFILE = 0x00000020;
            public const Int32 PD_PRINTSETUP = 0x00000040;
            public const Int32 PD_NOWARNING = 0x00000080;
            public const Int32 PD_RETURNDC = 0x00000100;
            public const Int32 PD_RETURNIC = 0x00000200;
            public const Int32 PD_RETURNDEFAULT = 0x00000400;
            public const Int32 PD_SHOWHELP = 0x00000800;
            public const Int32 PD_ENABLEPRINTHOOK = 0x00001000;
            public const Int32 PD_ENABLESETUPHOOK = 0x00002000;
            public const Int32 PD_ENABLEPRINTTEMPLATE = 0x00004000;
            public const Int32 PD_ENABLESETUPTEMPLATE = 0x00008000;
            public const Int32 PD_ENABLEPRINTTEMPLATEHANDLE = 0x00010000;
            public const Int32 PD_ENABLESETUPTEMPLATEHANDLE = 0x00020000;
            public const Int32 PD_USEDEVMODECOPIES = 0x00040000;
            public const Int32 PD_USEDEVMODECOPIESANDCOLLATE = 0x00040000;
            public const Int32 PD_DISABLEPRINTTOFILE = 0x00080000;
            public const Int32 PD_HIDEPRINTTOFILE = 0x00100000;
            public const Int32 PD_NONETWORKBUTTON = 0x00200000;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 1)]
        [System.Runtime.InteropServices.ComVisible(false)]
        internal class PRINTPAGERANGE
        {
            public Int32 nFromPage = 0;
            public Int32 nToPage = 0;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto, Pack = 1)]
        [System.Runtime.InteropServices.ComVisible(false)]
        internal class PRINTDLG
        {
            public Int32 lStructSize;
            public IntPtr hwndOwner;
            public IntPtr hDevMode;
            public IntPtr hDevNames;
            public IntPtr hDC = IntPtr.Zero;
            public Int32 Flags;
            public Int16 FromPage = 0;
            public Int16 ToPage = 0;
            public Int16 MinPage = 0;
            public Int16 MaxPage = 0;
            public Int16 Copies = 0;
            public IntPtr hInstance = IntPtr.Zero;
            public IntPtr lCustData = IntPtr.Zero;
            public PrintHookProc lpfnPrintHook;
            public IntPtr lpfnSetupHook = IntPtr.Zero;
            public IntPtr lpPrintTemplateName = IntPtr.Zero;
            public IntPtr lpSetupTemplateName = IntPtr.Zero;
            public IntPtr hPrintTemplate = IntPtr.Zero;
            public IntPtr hSetupTemplate = IntPtr.Zero;
        }

        // The "control ID" of the content window inside the PrintDlg
        // See the accompanying article to learn how I discovered it
        private const int _CONTENT_PANEL_ID = 0x0430;

        // OK button
        private const int IDOK = 0x0001;

        // Cancel button
        private const int ID_CANCEL = 0x0002;

        // Property button
        private const int ID_PROPERTY = 0x0401;

        // A constant that determines the spacing between panels inside the PrintDlg
        private const int _PANEL_GAP_FACTOR = 3;

        // user-supplied control that gets placed inside the PrintDlg
        private System.Windows.Forms.Control _userControl = null;

        // unmanaged memory buffer that holds the Win32 dialog template
        private IntPtr _ipTemplate = IntPtr.Zero;

        // resource object list
        private ArrayList m_oResourceList;

        #endregion

        /// <summary>
        /// Default constructor.
        /// </summary>
        public PrintDialogEx()
        {
            this.m_oResourceList = new ArrayList();
            //this.m_oDefaultArea = new Rectangle(500, 70, DEFAULT_WIDTH, DEFAULT_HEIGHT);
            this.m_sRegistryPath = @"Software\CTSoft\PrintDialogEx";
            this.HandlePrintEvent = new EventHandler(this.PrintEventHandler);

            this.AllowPrintToFile = true;
        }

        /// <summary>
        /// Copy constructor.
        /// given print dialog properties are copied to
        /// this new print dialog.
        /// </summary>
        /// <param name="oPrintDlg"></param>
        public PrintDialogEx(PrintDialogEx oPrintDlg)
            : this()
        {
            this.ShowNetwork = oPrintDlg.ShowNetwork;
            this.TopMost = oPrintDlg.TopMost;
            this.AllowPrintToFile = oPrintDlg.AllowPrintToFile;
            this.ShowHelp = oPrintDlg.ShowHelp;
            this.ShowStatusDialog = oPrintDlg.ShowStatusDialog;
            this.Parent = oPrintDlg.Parent;
            this.HandlePrintEvent = oPrintDlg.HandlePrintEvent;
        }

        /// <summary>
        /// The finalizer will release the unmanaged memory.
        /// </summary>
        ~PrintDialogEx()
        {
            Dispose(false);
        }

        #region "PrintDialog extension properties"
        private IntPtr m_nHandle;
        /// <summary>
        /// Return this print dialog window handle.
        /// </summary>
        public IntPtr Handle
        {
            get { return this.m_nHandle; }
            set { this.m_nHandle = value; }
        }

        private IntPtr m_hParent;
        /// <summary>
        /// Returns this dialogs parent window handle.
        /// </summary>
        public IntPtr Parent
        {
            get { return this.m_hParent; }
            set { this.m_hParent = value; }
        }

        /// <summary>
        /// Print document
        /// </summary>
        private PrintDocument m_oPrintDoc = null;
        public PrintDocument Document
        {
            get { return this.m_oPrintDoc; }
            set { this.m_oPrintDoc = value; }
        }

        private bool m_bAllowPrintToFile = false;
        /// <summary>
        /// Hides/Show the Print to File check box.
        /// </summary>
        public bool AllowPrintToFile
        {
            get { return this.m_bAllowPrintToFile; }
            set { this.m_bAllowPrintToFile = value; }
        }

        private bool m_bAllowSomePages = false;
        /// <summary>
        /// [page setting]
        /// If this flag is set, the Pages radio button is selected.  
        /// </summary>
        public bool AllowSomePages
        {
            get { return this.m_bAllowSomePages; }
            set { this.m_bAllowSomePages = value; }
        }

        private bool m_bAllowSelection = false;
        /// <summary>
        /// [... From Page ... To Page] 
        /// If this flag is set, From/To page edit box is enabled.  
        /// </summary>
        public bool AllowSelection
        {
            get { return this.m_bAllowSelection; }
            set { this.m_bAllowSelection = value; }
        }

        private bool m_bShowHelp = false;
        /// <summary>
        /// Causes the dialog box to display the Help button. 
        /// The hwndOwner member must specify the window to receive the 
        /// HELPMSGSTRING registered messages that the dialog box sends when 
        /// the user clicks the Help button.
        /// </summary>
        public bool ShowHelp
        {
            get { return this.m_bShowHelp; }
            set { this.m_bShowHelp = value; }
        }

        private bool m_bShowNetwork = false;
        /// <summary>
        /// Hides/Show and disables the Network button.
        /// </summary>
        public bool ShowNetwork
        {
            get { return this.m_bShowNetwork; }
            set { this.m_bShowNetwork = value; }
        }

        private bool m_bTopMost = false;
        public bool TopMost
        {
            get { return this.m_bTopMost; }
            set { this.m_bTopMost = value; }
        }

        private Rectangle m_oDefaultArea;
        public Rectangle DefaultArea
        {
            get { return this.m_oDefaultArea; }
            set { this.m_oDefaultArea = value; }
        }

        private bool m_bShowStatusDialog = false;
        /// <summary>
        /// The progress of the print job is shown in a status dialog.
        /// Default is true.
        /// When true, the PrintControllerWithStatusDialog is used.  Otherwise,
        /// a StandardPrintController is used for printing.
        /// </summary>
        public bool ShowStatusDialog
        {
            get { return this.m_bShowStatusDialog; }
            set { this.m_bShowStatusDialog = value; }
        }
        #endregion

        /// <summary>
        /// Use to set/get the print event handler.
        /// </summary>
        public EventHandler HandlePrintEvent
        {
            get { return this.m_oPrintEventHandler; }
            set { this.m_oPrintEventHandler = value; }
        }

        /// <summary>
        /// Displays print dialog.
        /// </summary>
        /// <returns>DialogResult.OK or DialogResult.Cancel value.</returns>
        public DialogResult ShowDialog()
        {
            DialogResult nRet = DialogResult.Cancel;
            PrinterSettings oSettings = this.Document.PrinterSettings;

            // below code is expected to throw an exception if no printer driver 
            // is installed on this machine.
            PrinterResolution resolution = oSettings.DefaultPageSettings.PrinterResolution;
            nRet = InvokePrintDlg(oSettings);
            if (nRet == DialogResult.OK && this.HandlePrintEvent != null)
            {
                // fire print document event
                this.HandlePrintEvent(this, null);
            }
            return nRet;
        }

        #region "Print event handlers"
        bool m_bBackgroundPrint;
        /// <summary>
        /// Indicates that printing will be done 
        /// as a background process.
        /// </summary>
        public bool BackgroundPrint
        {
            get { return this.m_bBackgroundPrint; }
            set { this.m_bBackgroundPrint = value; }
        }
        /// <summary>
        /// built-in print handler.
        /// </summary>
        /// <param name="sender">source control</param>
        /// <param name="e">not use</param>
        private void PrintEventHandler(object sender, System.EventArgs e)
        {
            PrintController oPrintCtrl = new StandardPrintController();

            if (this.ShowStatusDialog)
            {
                this.Document.PrintController = new PrintControllerWithStatusDialog(
                    oPrintCtrl, TITLE);
            }
            else
            {
                this.Document.PrintController = oPrintCtrl;
            }
            if (this.BackgroundPrint)
            {
                EventHandler d = new EventHandler(this.OnPrint);
                d.BeginInvoke(this, null, new AsyncCallback(this.OnPrintComplete), null);
            }
            else
            {
                this.OnPrint(this, null);
            }
        }

        /// <summary>
        /// Do actual printing job.
        /// </summary>
        /// <param name="sender">source control</param>
        /// <param name="e">print job parameter</param>
        private void OnPrint(object sender, System.EventArgs e)
        {
            try
            {
                this.Document.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// background print complete handler
        /// </summary>
        private void OnPrintComplete(IAsyncResult r)
        {
            Debug.WriteLine("OnPrintComplete");
        }
        #endregion

        #region Customized PrintDlg implementation

        /// <summary>
        /// Setup native print dialog resources and display it.
        /// </summary>
        /// <param name="printerSettings">printer settings</param>
        /// <returns>DialogResult: OK or Cancel</returns>
        internal DialogResult InvokePrintDlg(PrinterSettings printerSettings)
        {
            // PRINTDLG that will be passed to PrintDialogEx API function.
            PRINTDLG _pd = new PRINTDLG();

            _pd.lStructSize = Marshal.SizeOf(_pd);
            _pd.hwndOwner = this.Parent;
            // Pass the handles to the DEVMODE and DEVNAMES structures from the 
            // printer settings object to the PRINTDLG so that the current
            // printsettings are displayed in the print setup dialog.
            _pd.hDevMode = printerSettings.GetHdevmode();
            _pd.hDevNames = printerSettings.GetHdevnames();

            // indicates that only the print setup dialog should be shown.
            _pd.Flags = PrintFlag.PD_ENABLEPRINTHOOK | PrintFlag.PD_NOPAGENUMS;
            // set print to file checkbox visible/not visible
            setFlag(ref _pd.Flags, PrintFlag.PD_HIDEPRINTTOFILE, !this.AllowPrintToFile);
            // set help button visible/not visible
            setFlag(ref _pd.Flags, PrintFlag.PD_SHOWHELP, this.ShowHelp);
            // Hides and disables the Network button.
            setFlag(ref _pd.Flags, PrintFlag.PD_NONETWORKBUTTON, !this.ShowNetwork);
            // Enable/Disables the Selection radio button.
            setFlag(ref _pd.Flags, PrintFlag.PD_NOSELECTION, !this.AllowSelection);
            // Enables/Disables and select Pages radio button. 
            setFlag(ref _pd.Flags, PrintFlag.PD_PAGENUMS, !this.AllowSomePages);

            // Create an in-memory Win32 dialog template; this will be a "child" window inside the PrintDlg
            // We have no use for this child window, except that its presence allows us to capture events when
            // the user interacts with the PrintDlg
            //_ipTemplate = BuildDialogTemplate();
            //_pd.hInstance = _ipTemplate;

            _pd.lpfnPrintHook = new PrintHookProc(PrintHookProcImpl);

            // Invoke the dialog.
            this.OnLoad(null, null);
            bool bRet = PrintDlg(_pd);
            // Pass the resulting DEVMODE and DEVNAMES structs back to the 
            // caller via the PrinterSettings object that was passed in.
            printerSettings.SetHdevmode(_pd.hDevMode);
            printerSettings.SetHdevnames(_pd.hDevNames);

            this.OnClosing(null, null);
            return (bRet == true) ? DialogResult.OK : DialogResult.Cancel;
        }

        /// <summary>
        /// Add/remove a flag from the given nFlag argument.
        /// </summary>
        /// <param name="nFlag">source flag</param>
        /// <param name="nValue">flag to add/remove</param>
        /// <param name="bSet">true:set, false:unset</param>
        /// <returns>true no error. otherwise, false.</returns>
        private bool setFlag(ref Int32 nFlag, Int32 nValue, bool bSet)
        {
            bool bRet = true;
            try
            {
                if (bSet)
                {
                    nFlag |= nValue;
                }
                else
                {
                    nFlag &= ~nValue;
                }
            }
            catch (Exception)
            {
                bRet = false;
            }

            return bRet;
        }

        /// <summary>
        /// The hook procedure for window messages generated by the PrintDlg
        /// </summary>
        /// <param name="hWnd">the handle of the window at which this message is targeted</param>
        /// <param name="msg">the message identifier</param>
        /// <param name="wParam">message-specific parameter data</param>
        /// <param name="lParam">mess-specific parameter data</param>
        /// <returns></returns>
        internal IntPtr PrintHookProcImpl(IntPtr hPrintDlgWnd, UInt16 msg, Int32 wParam, Int32 lParam)
        {
            // Evaluates the message parameter to determine the user action.
            switch (msg)
            {
                // WM_INITDIALOG -  pull the user-supplied control into the PrintDlg now, using the SetParent API.
                case WndMsg.WM_INITDIALOG:
                    {
                        this.Handle = hPrintDlgWnd;

                        //System.Diagnostics.Trace.WriteLine("The WM_INITDIALOG message was received.");

                        // window z-order position
                        UInt32 nZOrder = (this.TopMost) ? WndZOrder.HWND_TOPMOST : WndZOrder.HWND_TOP;

                        // set default location
                        UInt16 nDispStatus = (UInt16)WndPos.SWP_SHOWWINDOW;
                        //((this.DefaultArea.IsEmpty) ? (WndPos.SWP_NOSIZE | WndPos.SWP_NOMOVE) : WndPos.SWP_SHOWWINDOW);
                        Rectangle defaultRect = this.DefaultArea;
                        if (!defaultRect.IsEmpty)
                        {	// reset window location
                            this.m_normalLeft = defaultRect.Left;
                            this.m_normalTop = defaultRect.Top;
                            this.m_normalWidth = defaultRect.Width;
                            this.m_normalHeight = defaultRect.Height;
                        }

                        // check for invalid print dialog dimension
                        if (this.m_normalWidth < 1 || this.m_normalHeight < 1)
                        {
                            // get the default common printdlg size
                            this.GetWindowRect(this.Handle, ref defaultRect);
                            this.m_normalLeft = defaultRect.Left;
                            this.m_normalTop = defaultRect.Top;
                            this.m_normalWidth = defaultRect.Width;
                            this.m_normalHeight = defaultRect.Height;
                        }

                        // set this dialog z-order to topmost.
                        Win32.SetWindowPos(this.Handle,
                            nZOrder,
                            this.m_normalLeft,
                            this.m_normalTop,
                            this.m_normalWidth,
                            this.m_normalHeight,
                            nDispStatus);

                        break;
                    }
                case WndMsg.WM_DESTROY:
                    //destroy the handles we have created
                    Dispose(true);
                    break;
                // WM_MOVE - the PrintDlg has been moved, so we'll resize the content and user-supplied
                // panel to fit nicely
                case WndMsg.WM_MOVE:
                    {
                        if (this.DefaultArea.IsEmpty)
                        {
                            this.OnMove(null, null);
                        }
                        return IntPtr.Zero;
                    }

                // WM_NOTIFY - we're only interested in the CDN_SELCHANGE notification message:
                // we grab the currently-selected filename and fire our event
                case WndMsg.WM_NOTIFY:
                    {
                        IntPtr ipNotify = new IntPtr(lParam);
                        OfNotify ofNot = (OfNotify)Marshal.PtrToStructure(ipNotify, typeof(OfNotify));
                        UInt16 code = ofNot.hdr.code;
                        if (code == ComboBoxSNotif.CBN_SELCHANGE)
                        {
                        }
                        return IntPtr.Zero;
                    }
            }
            return IntPtr.Zero;

        }

        /// <summary>
        /// Layout the content of the PrintDlg, according to the overall size of the dialog
        /// </summary>
        /// <param name="hWnd">handle of window that received the WM_SIZE message</param>
        private void InitExtendedControls(IntPtr hPrintDlgWnd)
        {
            Rectangle oPosition = new Rectangle();

            // adjust OK and CANCEL button positions
            IntPtr hOKBtn = Win32.GetDlgItem(hPrintDlgWnd, IDOK);
            if (GetWindowRect(hOKBtn, ref oPosition))
            {
                Win32.MoveWindow(
                    hOKBtn,
                    oPosition.X,
                    oPosition.Y + EXT_DIALOG_PADDING,
                    oPosition.Width,	// Width
                    oPosition.Height,	// Height
                    true);
            }

            IntPtr hCancelBtn = Win32.GetDlgItem(hPrintDlgWnd, ID_CANCEL);
            if (GetWindowRect(hCancelBtn, ref oPosition))
            {
                Win32.MoveWindow(
                    hCancelBtn,
                    oPosition.X,
                    oPosition.Y + EXT_DIALOG_PADDING,
                    oPosition.Width,	// Width
                    oPosition.Height,	// Height
                    true);
            }

            // Print group box 0x0430 group box.
            Rectangle rcUser = new Rectangle();
            IntPtr hGroupBox = Win32.GetDlgItem(hPrintDlgWnd, 0x0433);
            GetWindowRect(hGroupBox, ref rcUser);

            //rcUser.Y += rcUser.Bottom + 10;

            Win32.MoveWindow(_userControl.Handle,
                rcUser.X,
                rcUser.Y + (rcUser.Height * 2) + 5,
                rcUser.Width,		// Width
                EXT_DIALOG_PADDING,	// Height
                true);
        }

        /// <summary>
        /// The GetWindowRect function retrieves the dimensions of the bounding rectangle of the 
        /// specified window. 
        /// The dimensions are given in screen coordinates that are relative to the upper-left 
        /// corner of the screen. 
        /// </summary>
        /// <param name="hWnd">handle to window</param>
        /// <param name="lpRect">window coordinates</param>
        /// <returns>true if there is no error. otherwise, false.</returns>
        private bool GetWindowRect(IntPtr hWnd, ref Rectangle lpRect)
        {
            bool bRet = false;
            try
            {
                // convert the wnd screen co-ordinates to client co-ordinates
                RECT rc = new RECT();
                // Find the dimensions of the content panel
                Win32.GetWindowRect(hWnd, ref rc);

                IntPtr hHandle = (hWnd != this.Handle) ? this.Handle : this.Parent;
                // Translate these dimensions into the dialog's coordinate system
                POINT topLeft;
                topLeft.X = rc.left;
                topLeft.Y = rc.top;
                Win32.ScreenToClient(hHandle, ref topLeft);
                POINT bottomRight;
                bottomRight.X = rc.right;
                bottomRight.Y = rc.bottom;
                Win32.ScreenToClient(hHandle, ref bottomRight);
                lpRect.X = topLeft.X;
                lpRect.Width = bottomRight.X - topLeft.X;
                lpRect.Y = topLeft.Y;
                lpRect.Height = bottomRight.Y - topLeft.Y;

                bRet = true;
            }
            catch
            {
            }

            return bRet;
        }

        UInt32 m_hDialogFont;
        /// <summary>
        /// Use dialog font
        /// </summary>
        public UInt32 DlgFont
        {
            get { return this.m_hDialogFont; }
            set { this.m_hDialogFont = value; }
        }

        #endregion

        #region Persist extra window state
        // event info that allows form to persist extra window state data
        public delegate void WindowStateDelegate(object sender, RegistryKey key);
        public event WindowStateDelegate LoadStateEvent;
        public event WindowStateDelegate SaveStateEvent;

        private int m_normalLeft;
        private int m_normalTop;
        private int m_normalWidth;
        private int m_normalHeight;

        // window state store
        private string m_sRegistryPath;

        private void OnLoad(object sender, System.EventArgs e)
        {
            // attempt to read state from registry
            RegistryKey key = Registry.CurrentUser.OpenSubKey(m_sRegistryPath);
            if (key != null)
            {
                Rectangle defaultRect = this.DefaultArea;
                if (defaultRect.IsEmpty)
                {
                    this.m_normalLeft = (int)key.GetValue("Left", 0);
                    this.m_normalTop = (int)key.GetValue("Top", 0);
                    this.m_normalWidth = (int)key.GetValue("Width", 0);
                    this.m_normalHeight = (int)key.GetValue("Height", 0);
                }
                else
                {
                    this.m_normalLeft = defaultRect.Left;
                    this.m_normalTop = defaultRect.Top;
                    this.m_normalWidth = defaultRect.Width;
                    this.m_normalHeight = defaultRect.Height;
                }

                // fire LoadState event
                if (LoadStateEvent != null)
                    LoadStateEvent(this, key);
            }
        }

        private void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // save position, size and state
            RegistryKey key = Registry.CurrentUser.CreateSubKey(m_sRegistryPath);
            key.SetValue("Left", m_normalLeft);
            key.SetValue("Top", m_normalTop);
            key.SetValue("Width", m_normalWidth);
            key.SetValue("Height", m_normalHeight);

            // fire SaveState event
            if (SaveStateEvent != null)
                SaveStateEvent(this, key);

            //Debug.WriteLine("pos("+m_normalLeft+","+m_normalTop+","+m_normalWidth+","+m_normalHeight+") ");

        }

        private void OnMove(object sender, System.EventArgs e)
        {
            RECT rect = new RECT();
            if (Win32.GetWindowRect(this.Handle, ref rect))
            {
                // save position			
                m_normalLeft = rect.left;
                m_normalTop = rect.top;
            }

        }
        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if called by Dispose, false otherwise</param>
        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                GC.SuppressFinalize(this);
            }
            Marshal.FreeCoTaskMem(_ipTemplate);
            for (int nIndex = 0; nIndex < this.m_oResourceList.Count; nIndex++)
            {
                IntPtr nHandle = (IntPtr)this.m_oResourceList[nIndex];
                Win32.DestroyWindow(nHandle);
            }

            this.m_oResourceList.Clear();
        }

        #endregion
    }
}
