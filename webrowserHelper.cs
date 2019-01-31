using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using mshtml;

namespace 天若OCR文字识别
{
	// Token: 0x02000035 RID: 53
	internal class webrowserHelper
	{
		// Token: 0x060002BD RID: 701 RVA: 0x00020264 File Offset: 0x0001E464
		public static IHTMLDocument3 GetDocumentFromWindow(IHTMLWindow2 htmlWindow)
		{
			if (htmlWindow != null)
			{
				try
				{
					return (IHTMLDocument3)htmlWindow.document;
				}
				catch (COMException)
				{
				}
				catch (UnauthorizedAccessException)
				{
				}
				catch (Exception)
				{
					return null;
				}
				try
				{
					webrowserHelper.IServiceProvider serviceProvider = (webrowserHelper.IServiceProvider)htmlWindow;
					object obj = null;
					serviceProvider.QueryService(ref webrowserHelper.IID_IWebBrowserApp, ref webrowserHelper.IID_IWebBrowser2, out obj);
					return (IHTMLDocument3)((webrowserHelper.IWebBrowser2)obj).Document;
				}
				catch (Exception value)
				{
					Console.WriteLine(value);
				}
				return null;
			}
			return null;
		}

		// Token: 0x04000237 RID: 567
		private static Guid IID_IWebBrowserApp = new Guid("0002DF05-0000-0000-C000-000000000046");

		// Token: 0x04000238 RID: 568
		private static Guid IID_IWebBrowser2 = new Guid("D30C1661-CDAF-11D0-8A3E-00C04FC9E26E");

		// Token: 0x02000036 RID: 54
		[ComVisible(true)]
		[Guid("6D5140C1-7436-11CE-8034-00AA006009FA")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		public interface IServiceProvider
		{
			// Token: 0x060002C0 RID: 704
			[PreserveSig]
			[return: MarshalAs(UnmanagedType.I4)]
			int QueryService(ref Guid guidService, ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppvObject);
		}

		// Token: 0x02000037 RID: 55
		[Guid("D30C1661-CDAF-11d0-8A3E-00C04FC9E26E")]
		[TypeLibType(TypeLibTypeFlags.FHidden | TypeLibTypeFlags.FDual | TypeLibTypeFlags.FOleAutomation)]
		[ComImport]
		public interface IWebBrowser2
		{
			// Token: 0x060002C1 RID: 705
			[DispId(100)]
			void GoBack();

			// Token: 0x060002C2 RID: 706
			[DispId(101)]
			void GoForward();

			// Token: 0x060002C3 RID: 707
			[DispId(102)]
			void GoHome();

			// Token: 0x060002C4 RID: 708
			[DispId(103)]
			void GoSearch();

			// Token: 0x060002C5 RID: 709
			[DispId(104)]
			void Navigate([In] string Url, [In] ref object flags, [In] ref object targetFrameName, [In] ref object postData, [In] ref object headers);

			// Token: 0x060002C6 RID: 710
			[DispId(-550)]
			void Refresh();

			// Token: 0x060002C7 RID: 711
			[DispId(105)]
			void Refresh2([In] ref object level);

			// Token: 0x060002C8 RID: 712
			[DispId(106)]
			void Stop();

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060002C9 RID: 713
			[DispId(200)]
			object Application { [return: MarshalAs(UnmanagedType.IDispatch)] get; }

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060002CA RID: 714
			[DispId(201)]
			object Parent { [return: MarshalAs(UnmanagedType.IDispatch)] get; }

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060002CB RID: 715
			[DispId(202)]
			object Container { [return: MarshalAs(UnmanagedType.IDispatch)] get; }

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060002CC RID: 716
			[DispId(203)]
			object Document { [return: MarshalAs(UnmanagedType.IDispatch)] get; }

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060002CD RID: 717
			[DispId(204)]
			bool TopLevelContainer { get; }

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060002CE RID: 718
			[DispId(205)]
			string Type { get; }

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060002CF RID: 719
			// (set) Token: 0x060002D0 RID: 720
			[DispId(206)]
			int Left { get; set; }

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060002D1 RID: 721
			// (set) Token: 0x060002D2 RID: 722
			[DispId(207)]
			int Top { get; set; }

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060002D3 RID: 723
			// (set) Token: 0x060002D4 RID: 724
			[DispId(208)]
			int Width { get; set; }

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060002D5 RID: 725
			// (set) Token: 0x060002D6 RID: 726
			[DispId(209)]
			int Height { get; set; }

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060002D7 RID: 727
			[DispId(210)]
			string LocationName { get; }

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060002D8 RID: 728
			[DispId(211)]
			string LocationURL { get; }

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060002D9 RID: 729
			[DispId(212)]
			bool Busy { get; }

			// Token: 0x060002DA RID: 730
			[DispId(300)]
			void Quit();

			// Token: 0x060002DB RID: 731
			[DispId(301)]
			void ClientToWindow(out int pcx, out int pcy);

			// Token: 0x060002DC RID: 732
			[DispId(302)]
			void PutProperty([In] string property, [In] object vtValue);

			// Token: 0x060002DD RID: 733
			[DispId(303)]
			object GetProperty([In] string property);

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060002DE RID: 734
			[DispId(0)]
			string Name { get; }

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060002DF RID: 735
			[DispId(-515)]
			int HWND { get; }

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060002E0 RID: 736
			[DispId(400)]
			string FullName { get; }

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x060002E1 RID: 737
			[DispId(401)]
			string Path { get; }

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x060002E2 RID: 738
			// (set) Token: 0x060002E3 RID: 739
			[DispId(402)]
			bool Visible { get; set; }

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x060002E4 RID: 740
			// (set) Token: 0x060002E5 RID: 741
			[DispId(403)]
			bool StatusBar { get; set; }

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x060002E6 RID: 742
			// (set) Token: 0x060002E7 RID: 743
			[DispId(404)]
			string StatusText { get; set; }

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x060002E8 RID: 744
			// (set) Token: 0x060002E9 RID: 745
			[DispId(405)]
			int ToolBar { get; set; }

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x060002EA RID: 746
			// (set) Token: 0x060002EB RID: 747
			[DispId(406)]
			bool MenuBar { get; set; }

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x060002EC RID: 748
			// (set) Token: 0x060002ED RID: 749
			[DispId(407)]
			bool FullScreen { get; set; }

			// Token: 0x060002EE RID: 750
			[DispId(500)]
			void Navigate2([In] ref object URL, [In] ref object flags, [In] ref object targetFrameName, [In] ref object postData, [In] ref object headers);

			// Token: 0x060002EF RID: 751
			[DispId(501)]
			webrowserHelper.OLECMDF QueryStatusWB([In] webrowserHelper.OLECMDID cmdID);

			// Token: 0x060002F0 RID: 752
			[DispId(502)]
			void ExecWB([In] webrowserHelper.OLECMDID cmdID, [In] webrowserHelper.OLECMDEXECOPT cmdexecopt, ref object pvaIn, IntPtr pvaOut);

			// Token: 0x060002F1 RID: 753
			[DispId(503)]
			void ShowBrowserBar([In] ref object pvaClsid, [In] ref object pvarShow, [In] ref object pvarSize);

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x060002F2 RID: 754
			[DispId(-525)]
			WebBrowserReadyState ReadyState { get; }

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x060002F3 RID: 755
			// (set) Token: 0x060002F4 RID: 756
			[DispId(550)]
			bool Offline { get; set; }

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x060002F5 RID: 757
			// (set) Token: 0x060002F6 RID: 758
			[DispId(551)]
			bool Silent { get; set; }

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x060002F7 RID: 759
			// (set) Token: 0x060002F8 RID: 760
			[DispId(552)]
			bool RegisterAsBrowser { get; set; }

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x060002F9 RID: 761
			// (set) Token: 0x060002FA RID: 762
			[DispId(553)]
			bool RegisterAsDropTarget { get; set; }

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x060002FB RID: 763
			// (set) Token: 0x060002FC RID: 764
			[DispId(554)]
			bool TheaterMode { get; set; }

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x060002FD RID: 765
			// (set) Token: 0x060002FE RID: 766
			[DispId(555)]
			bool AddressBar { get; set; }

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x060002FF RID: 767
			// (set) Token: 0x06000300 RID: 768
			[DispId(556)]
			bool Resizable { get; set; }
		}

		// Token: 0x02000038 RID: 56
		public enum OLECMDEXECOPT
		{
			// Token: 0x0400023A RID: 570
			OLECMDEXECOPT_DODEFAULT,
			// Token: 0x0400023B RID: 571
			OLECMDEXECOPT_PROMPTUSER,
			// Token: 0x0400023C RID: 572
			OLECMDEXECOPT_DONTPROMPTUSER,
			// Token: 0x0400023D RID: 573
			OLECMDEXECOPT_SHOWHELP
		}

		// Token: 0x02000039 RID: 57
		public enum OLECMDF
		{
			// Token: 0x0400023F RID: 575
			OLECMDF_DEFHIDEONCTXTMENU = 32,
			// Token: 0x04000240 RID: 576
			OLECMDF_ENABLED = 2,
			// Token: 0x04000241 RID: 577
			OLECMDF_INVISIBLE = 16,
			// Token: 0x04000242 RID: 578
			OLECMDF_LATCHED = 4,
			// Token: 0x04000243 RID: 579
			OLECMDF_NINCHED = 8,
			// Token: 0x04000244 RID: 580
			OLECMDF_SUPPORTED = 1
		}

		// Token: 0x0200003A RID: 58
		public enum OLECMDID
		{
			// Token: 0x04000246 RID: 582
			OLECMDID_PAGESETUP = 8,
			// Token: 0x04000247 RID: 583
			OLECMDID_PRINT = 6,
			// Token: 0x04000248 RID: 584
			OLECMDID_PRINTPREVIEW,
			// Token: 0x04000249 RID: 585
			OLECMDID_PROPERTIES = 10,
			// Token: 0x0400024A RID: 586
			OLECMDID_SAVEAS = 4
		}
	}
}
