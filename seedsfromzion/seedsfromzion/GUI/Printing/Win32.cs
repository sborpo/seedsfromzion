// Copyright (c) 2006, Christopher Tan
// All rights reserved.
//
// While you are not strictly required to, 
// please send me any changes or improvements you make
// to this code.
//
// Email: Christopher Tan <cabbage.ph@gmail.com>

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace NativeResource
{
	/// <summary>
	/// Defines the shape of hook procedures that can be called by the PrintDlg
	/// </summary>
	internal delegate IntPtr OfnHookProc( IntPtr hWnd, UInt16 msg, Int32 wParam, Int32 lParam );

	internal delegate bool CallBack(int hwnd, int lParam);


	/// <summary>
	/// Part of the notification messages sent by the common dialogs
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	internal struct NMHDR
	{
		[FieldOffset(0)]	public IntPtr	hWndFrom;
		[FieldOffset(4)]	public UInt16	idFrom;
		[FieldOffset(8)]	public UInt16	code;
	};

	/// <summary>
	/// Part of the notification messages sent by the common dialogs
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	internal struct OfNotify
	{
		[FieldOffset(0)]	public NMHDR	hdr;
		[FieldOffset(12)]	public IntPtr	ipOfn;
		[FieldOffset(16)]	public IntPtr	ipFile;
	};

	/// <summary>
	/// An in-memory Win32 dialog template
	/// Note: this has a very specific structure with a single static "label" control
	/// See documentation for DLGTEMPLATE and DLGITEMTEMPLATE
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	internal class DlgTemplate
	{
		// The dialog template - see documentation for DLGTEMPLATE
		public UInt32 style =			WndStyles.Ds3dLook | WndStyles.DsControl | WndStyles.WS_CHILD | WndStyles.WsClipSiblings | WndStyles.SsNotify;
		public Int32 extendedStyle =	ExStyle.WsExControlParent;
		public Int16 numItems =			1;
		public Int16 x =				0;
		public Int16 y =				0;
		public Int16 cx =				0;
		public Int16 cy =				0;
		public Int16 reservedMenu =		0;
		public Int16 reservedClass =	0;
		public Int16 reservedTitle =	0;

		// Single dlg item, must be dword-aligned - see documentation for DLGITEMTEMPLATE
		public UInt32 itemStyle =			WndStyles.WS_CHILD;
		public Int32 itemExtendedStyle =	ExStyle.WsExNoParentNotify;
		public Int16 itemX =				0;
		public Int16 itemY =				0;
		public Int16 itemCx =				0;
		public Int16 itemCy =				0;
		public Int16 itemId =				0;
		public UInt16 itemClassHdr =		0xffff;	// we supply a constant to indicate the class of this control
		public Int16 itemClass =			0x0082;	// static label control
		public Int16 itemText =				0x0000;	// no text for this control
		public Int16 itemData =				0x0000;	// no creation data for this control
	};

	/// <summary>
	/// The rectangle structure used in Win32 API calls
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	internal struct RECT 
	{
		public int left;
		public int top;
		public int right;
		public int bottom;
	};

	/// <summary>
	/// The point structure used in Win32 API calls
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	internal struct POINT
	{
		public int X;
		public int Y;
	};
	
	/// <summary>
	/// Contains all of the p/invoke declarations for the Win32 APIs.
	/// </summary>
	public class Win32
	{
		[DllImport("User32.dll", CharSet = CharSet.Unicode)]
		internal static extern IntPtr GetDlgItem( IntPtr hWndDlg, Int16 Id );

		[DllImport("User32.dll", CharSet = CharSet.Unicode)]
		internal static extern IntPtr GetParent( IntPtr hWnd );

		[DllImport("User32.dll", CharSet = CharSet.Unicode)]
		internal static extern IntPtr SetParent( IntPtr hWndChild, IntPtr hWndNewParent );
		
		[DllImport("User32.dll", CharSet = CharSet.Unicode)]
		internal static extern UInt32 SendMessage( IntPtr hWnd, UInt32 msg, UInt32 wParam, StringBuilder buffer );

		[DllImport("user32.dll")]
		internal static extern UInt32 SendMessage(IntPtr hWnd, UInt32 Msg, UInt32 wParam, UInt32 lParam);

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		internal static extern bool GetWindowRect( IntPtr hWnd, ref RECT rc );

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		internal static extern int GetClientRect( IntPtr hWnd, ref RECT rc );

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		internal static extern bool ScreenToClient( IntPtr hWnd, ref POINT pt );

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		internal static extern bool MoveWindow( IntPtr hWnd, int X, int Y, int Width, int Height, bool repaint );

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		internal static extern bool SetWindowPos( IntPtr hWnd, UInt32 hWndInsertAfter, int X, int Y, int Width, int Height, UInt16 uFlags );

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		internal static extern bool ShowWindow( IntPtr hWnd, int nCmdShow );

		[DllImport("ComDlg32.dll", CharSet = CharSet.Unicode)]
		internal static extern Int32 CommDlgExtendedError();

		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		internal static extern IntPtr CreateWindowEx(uint dwExStyle, string lpClassName, string lpWindowName, uint dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, int hMenu, int hInstance, int lpParam);
		
		[DllImport("user32.dll")]
		internal static extern bool DestroyWindow(IntPtr hwnd);

		[DllImport("user32.Dll")]
		internal static extern int EnumWindows(CallBack x, int y); 

		[DllImport("user32.Dll")]
		internal static extern int EnumChildWindows(IntPtr hWndParent, CallBack lpEnumFunc, int lParam);

		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		internal static extern bool SetWindowText(IntPtr hWnd, string lpString);

		[DllImport("User32.Dll")]
		internal static extern void GetWindowText(int h, StringBuilder s, int nMaxCount);
		[DllImport("User32.Dll")]
		internal static extern void GetClassName(int h, StringBuilder s, int nMaxCount);
		[DllImport("User32.Dll")]
		internal static extern IntPtr PostMessage(IntPtr hWnd, int msg, int wParam, int lParam);
	}
}
