// Copyright (c) 2006, Christopher Tan
// All rights reserved.
//
// While you are not strictly required to, 
// please send me any changes or improvements you make
// to this code.
//
// Email: Christopher Tan <cabbage.ph@gmail.com>
using System;

namespace NativeResource
{
	/// <summary>
	/// system class names that are available for use by all processes. 
	/// </summary>
	internal class  WndType
	{
		public const string LABEL		= "static";		// The class for a static control. 
		public const string BUTTON		= "button";		// The class for a button. 
		public const string EDITBOX		= "edit";		// The class for an edit control. 
		public const string COMBOBOX	= "combobox";	// The class for a combo box. 
		public const string LISTBOX		= "listbox";	// The class for a list box. 
		public const string ScrollBar	= "scrollbar";	// The class for a scroll bar. 
	};

	/// <summary>
	/// Defines the constants for Windows messages.
	/// A small subset of the window messages that can be sent to the PrintDlg
	/// These are just the ones that this implementation is interested in
	/// </summary>
	internal class WndMsg
	{
		public const UInt16 WM_INITDIALOG	= 0x0110;
		public const UInt16 WM_DESTROY		= 0x0002;
		public const UInt16 WM_SIZE			= 0x0005;
		public const UInt16 WM_NOTIFY		= 0x004E;
		public const UInt16 WM_SETFOCUS		= 0x0007;
		public const UInt16 WM_LBUTTONDOWN	= 0x0201;
		public const UInt16 WM_RBUTTONDOWN	= 0x0204;
		public const UInt16 WM_MOVE			= 0x0003;
		public const UInt16 WM_SETFONT		= 0x0030;
		public const UInt16 WM_GETFONT		= 0x0031;
	};

	internal class WndZOrder
	{
		public const UInt32 HWND_TOP        = 0x00000000;
		public const UInt32 HWND_BOTTOM     = 0x00000001;
		public const UInt32 HWND_TOPMOST    = 0xFFFFFFFF;
		public const UInt32 HWND_NOTOPMOST  = 0xFFFFFFFE;
	};

	/*
	 * ShowWindow() Commands
	 */
	internal class ShowWnd
	{
		public const UInt16 SW_HIDE             = 0x0000;
		public const UInt16 SW_SHOWNORMAL       = 0x0001;
		public const UInt16 SW_NORMAL           = 0x0001;
		public const UInt16 SW_SHOWMINIMIZED    = 0x0002;
		public const UInt16 SW_SHOWMAXIMIZED    = 0x0003;
		public const UInt16 SW_MAXIMIZE         = 0x0003;
		public const UInt16 SW_SHOWNOACTIVATE   = 0x0004;
		public const UInt16 SW_SHOW             = 0x0005;
		public const UInt16 SW_MINIMIZE         = 0x0006;
		public const UInt16 SW_SHOWMINNOACTIVE  = 0x0007;
		public const UInt16 SW_SHOWNA           = 0x0008;
		public const UInt16 SW_RESTORE          = 0x0009;
		public const UInt16 SW_SHOWDEFAULT      = 0x0010;
		public const UInt16 SW_FORCEMINIMIZE    = 0x0011;
		public const UInt16 SW_MAX              = 0x0011;
	};

	/*
	* SetWindowPos Flags
	*/
	internal class WndPos
	{
		static public UInt16 SWP_NOSIZE          = 0x0001;
		static public UInt16 SWP_NOMOVE          = 0x0002;
		static public UInt16 SWP_NOZORDER        = 0x0004;
		static public UInt16 SWP_NOREDRAW        = 0x0008;
		static public UInt16 SWP_NOACTIVATE      = 0x0010;
		static public UInt16 SWP_FRAMECHANGED    = 0x0020;  /* The frame changed: send WM_NCCALCSIZE */
		static public UInt16 SWP_SHOWWINDOW      = 0x0040;
		static public UInt16 SWP_HIDEWINDOW      = 0x0080;
		static public UInt16 SWP_NOCOPYBITS      = 0x0100;
		static public UInt16 SWP_NOOWNERZORDER   = 0x0200;  /* Don't do owner Z ordering */
		static public UInt16 SWP_NOSENDCHANGING  = 0x0400;  /* Don't send WM_WINDOWPOSCHANGING */
	};

	/// <summary>
	/// Win32 window style constants
	/// We use them to set up our child window
	/// </summary>
	internal class WndStyles
	{
		public const UInt32		WS_VISIBLE		= 0x10000000;
		public const UInt32		WS_CHILD		= 0x40000000;
		public const UInt32		WS_TABSTOP		= 0x00010000;
		public const UInt32		DsSetFont		= 0x00000040;
		public const UInt32		Ds3dLook		= 0x00000004;
		public const UInt32		DsControl		= 0x00000400;
		public const UInt32		WsClipSiblings	= 0x04000000;
		public const UInt32		WsGroup			= 0x00020000;
		public const UInt32		SsNotify		= 0x00000100;
	};

	/// <summary>
	/// Win32 "extended" window style constants
	/// </summary>
	internal class ExStyle
	{
		public const Int32 WsExNoParentNotify =	0x00000004;
		public const Int32 WsExControlParent =	0x00010000;
	};


	/// <summary>
	/// Button Control Styles
	/// </summary>
	internal class BtnStyle
	{
		public const Int32 BS_PUSHBUTTON       = 0x00000000;
		public const Int32 BS_DEFPUSHBUTTON    = 0x00000001;
		public const Int32 BS_CHECKBOX         = 0x00000002;
		public const Int32 BS_AUTOCHECKBOX     = 0x00000003;
		public const Int32 BS_RADIOBUTTON      = 0x00000004;
		public const Int32 BS_3STATE           = 0x00000005;
		public const Int32 BS_AUTO3STATE       = 0x00000006;
		public const Int32 BS_GROUPBOX         = 0x00000007;
		public const Int32 BS_USERBUTTON       = 0x00000008;
		public const Int32 BS_AUTORADIOBUTTON  = 0x00000009;
		public const Int32 BS_PUSHBOX          = 0x0000000A;
		public const Int32 BS_OWNERDRAW        = 0x0000000B;
		public const Int32 BS_TYPEMASK         = 0x0000000F;
		public const Int32 BS_LEFTTEXT         = 0x00000020;
	}
}