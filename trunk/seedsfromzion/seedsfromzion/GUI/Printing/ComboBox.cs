using System;

namespace NativeResource
{
	/// <summary>
	/// Combo Box Notification Codes
	/// </summary>
	internal class  ComboBoxSNotif
	{
		public const UInt16 CBN_ERRSPACE        = 0xFFFF;
		public const UInt16 CBN_SELCHANGE       = 1;
		public const UInt16 CBN_DBLCLK          = 2;
		public const UInt16 CBN_SETFOCUS        = 3;
		public const UInt16 CBN_KILLFOCUS       = 4;
		public const UInt16 CBN_EDITCHANGE      = 5;
		public const UInt16 CBN_EDITUPDATE      = 6;
		public const UInt16 CBN_DROPDOWN        = 7;
		public const UInt16 CBN_CLOSEUP         = 8;
		public const UInt16 CBN_SELENDOK        = 9;
		public const UInt16 CBN_SELENDCANCEL    = 10;
	};

	/// <summary>
	/// Combo Box styles
	/// </summary>
	internal class  ComboBoxStyles
	{
		public const UInt16 CBS_SIMPLE            = 0x0001;
		public const UInt16 CBS_DROPDOWN          = 0x0002;
		public const UInt16 CBS_DROPDOWNLIST      = 0x0003;
		public const UInt16 CBS_OWNERDRAWFIXED    = 0x0010;
		public const UInt16 CBS_OWNERDRAWVARIABLE = 0x0020;
		public const UInt16 CBS_AUTOHSCROLL       = 0x0040;
		public const UInt16 CBS_OEMCONVERT        = 0x0080;
		public const UInt16 CBS_SORT              = 0x0100;
		public const UInt16 CBS_HASSTRINGS        = 0x0200;
		public const UInt16 CBS_NOINTEGRALHEIGHT  = 0x0400;
		public const UInt16 CBS_DISABLENOSCROLL   = 0x0800;
	}


	/// <summary>
	/// Combo Box messages
	/// </summary>
	internal class  ComboBoxMsg
	{
		public const UInt32 CB_GETEDITSEL               = 0x0140;
		public const UInt32 CB_LIMITTEXT                = 0x0141;
		public const UInt32 CB_SETEDITSEL               = 0x0142;
		public const UInt32 CB_ADDSTRING                = 0x0143;
		public const UInt32 CB_DELETESTRING             = 0x0144;
		public const UInt32 CB_DIR                      = 0x0145;
		public const UInt32 CB_GETCOUNT                 = 0x0146;
		public const UInt32 CB_GETCURSEL                = 0x0147;
		public const UInt32 CB_GETLBTEXT                = 0x0148;
		public const UInt32 CB_GETLBTEXTLEN             = 0x0149;
		public const UInt32 CB_INSERTSTRING             = 0x014A;
		public const UInt32 CB_RESETCONTENT             = 0x014B;
		public const UInt32 CB_FINDSTRING               = 0x014C;
		public const UInt32 CB_SELECTSTRING             = 0x014D;
		public const UInt32 CB_SETCURSEL                = 0x014E;
		public const UInt32 CB_SHOWDROPDOWN             = 0x014F;
		public const UInt32 CB_GETITEMDATA              = 0x0150;
		public const UInt32 CB_SETITEMDATA              = 0x0151;
		public const UInt32 CB_GETDROPPEDCONTROLRECT    = 0x0152;
		public const UInt32 CB_SETITEMHEIGHT            = 0x0153;
		public const UInt32 CB_GETITEMHEIGHT            = 0x0154;
		public const UInt32 CB_SETEXTENDEDUI            = 0x0155;
		public const UInt32 CB_GETEXTENDEDUI            = 0x0156;
		public const UInt32 CB_GETDROPPEDSTATE          = 0x0157;
		public const UInt32 CB_FINDSTRINGEXACT          = 0x0158;
		public const UInt32 CB_SETLOCALE                = 0x0159;
		public const UInt32 CB_GETLOCALE                = 0x015A;
	}


}