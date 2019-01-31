using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace 天若OCR文字识别
{
	// Token: 0x02000027 RID: 39
	public class HelpWin32
	{
		// Token: 0x06000248 RID: 584
		[DllImport("User32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetWindowDC(IntPtr handle);

		// Token: 0x06000249 RID: 585
		[DllImport("user32")]
		public static extern bool AnimateWindow(IntPtr whnd, int dwtime, int dwflag);

		// Token: 0x0600024A RID: 586
		[DllImport("User32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessageA(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600024B RID: 587
		[DllImport("User32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600024C RID: 588
		[DllImport("user32")]
		public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

		// Token: 0x0600024D RID: 589
		[DllImport("gdi32.dll")]
		public static extern int CreateRoundRectRgn(int x1, int y1, int x2, int y2, int x3, int y3);

		// Token: 0x0600024E RID: 590
		[DllImport("User32.dll")]
		public static extern int SetWindowRgn(IntPtr hwnd, int hRgn, bool bRedraw);

		// Token: 0x0600024F RID: 591
		[DllImport("user32")]
		public static extern int GetWindowLong(IntPtr hwnd, int nIndex);

		// Token: 0x06000250 RID: 592
		[DllImport("User32.dll")]
		public static extern int SetWindowLong(IntPtr hwnd, int nIndex, int dwNewLong);

		// Token: 0x06000251 RID: 593
		[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

		// Token: 0x06000252 RID: 594
		[DllImport("User32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetDC(IntPtr hWnd);

		// Token: 0x06000253 RID: 595
		[DllImport("gdi32.dll", ExactSpelling = true)]
		public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObj);

		// Token: 0x06000254 RID: 596
		[DllImport("User32.dll", ExactSpelling = true)]
		public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

		// Token: 0x06000255 RID: 597
		[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern int DeleteDC(IntPtr hDC);

		// Token: 0x06000256 RID: 598
		[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern int DeleteObject(IntPtr hObj);

		// Token: 0x06000257 RID: 599
		[DllImport("User32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern int UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref HelpWin32.Point pptDst, ref HelpWin32.Size psize, IntPtr hdcSrc, ref HelpWin32.Point pptSrc, int crKey, ref HelpWin32.BLENDFUNCTION pblend, int dwFlags);

		// Token: 0x06000258 RID: 600
		[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr ExtCreateRegion(IntPtr lpXform, uint nCount, IntPtr rgnData);

		// Token: 0x06000259 RID: 601
		[DllImport("User32.dll")]
		public static extern int CreateCaret(IntPtr hwnd, int hBitmap, int nWidth, int nHeight);

		// Token: 0x0600025A RID: 602
		[DllImport("User32.dll")]
		public static extern bool ShowCaret(IntPtr hWnd);

		// Token: 0x0600025B RID: 603
		[DllImport("User32.dll")]
		public static extern bool SetCaretPos(int x, int y);

		// Token: 0x0600025C RID: 604
		[DllImport("User32.dll")]
		public static extern bool PostMessage(IntPtr hwnd, uint msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x0600025D RID: 605
		[DllImport("User32.dll")]
		public static extern int SendMessage(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x0600025E RID: 606
		[DllImport("User32.dll")]
		public static extern uint GetCaretBlinkTime();

		// Token: 0x0600025F RID: 607 RVA: 0x0001D7E4 File Offset: 0x0001B9E4
		public static bool CaptureWindow(Control control, ref Bitmap bitmap)
		{
			Graphics graphics = Graphics.FromImage(bitmap);
			IntPtr lParam = new IntPtr(12);
			IntPtr hdc = graphics.GetHdc();
			HelpWin32.SendMessage(control.Handle, 791, hdc, lParam);
			graphics.ReleaseHdc(hdc);
			graphics.Dispose();
			return true;
		}

		// Token: 0x06000260 RID: 608
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x06000261 RID: 609
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		public static extern IntPtr GetForegroundWindow();

		// Token: 0x06000262 RID: 610
		[DllImport("User32.dll")]
		public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam);

		// Token: 0x06000263 RID: 611
		[DllImport("user32.dll", SetLastError = true)]
		public static extern void keybd_event(Keys bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

		// Token: 0x06000264 RID: 612
		[DllImport("gdi32.dll")]
		public static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

		// Token: 0x06000265 RID: 613
		[DllImport("User32.dll")]
		public static extern int SetClipboardViewer(int hWndNewViewer);

		// Token: 0x06000266 RID: 614
		[DllImport("User32.dll", CharSet = CharSet.Auto)]
		public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

		// Token: 0x06000267 RID: 615
		[DllImport("user32.dll")]
		public static extern IntPtr GetActiveWindow();

		// Token: 0x06000268 RID: 616
		[DllImport("user32", SetLastError = true)]
		public static extern IntPtr PostMessage(IntPtr hWnd, int Msg, int wParam);

		// Token: 0x06000269 RID: 617
		[DllImport("winmm.dll")]
		public static extern long mciSendString(string command, StringBuilder returnString, int returnSize, IntPtr hwndCallback);

		// Token: 0x0600026A RID: 618
		[DllImport("user32.dll")]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		// Token: 0x0600026B RID: 619
		[DllImport("user32.dll")]
		public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

		// Token: 0x0600026C RID: 620
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern int SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int Width, int Height, int flags);

		// Token: 0x0600026D RID: 621
		[DllImport("user32.dll ", SetLastError = true)]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Token: 0x0600026E RID: 622
		[DllImport("user32.dll ", SetLastError = true)]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, HelpWin32.KeyModifiers fsModifiers, Keys vk);

		// Token: 0x0600026F RID: 623
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);

		// Token: 0x06000270 RID: 624
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern int GetClassLong(IntPtr hwnd, int nIndex);

		// Token: 0x06000271 RID: 625
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int LCMapString(int Locale, int dwMapFlags, string lpSrcStr, int cchSrc, [Out] string lpDestStr, int cchDest);

		// Token: 0x06000272 RID: 626
		[DllImport("kernel32.dll")]
		public static extern uint GetTickCount();

		// Token: 0x06000273 RID: 627
		[DllImport("kernel32.dll")]
		public static extern uint WinExec(string lpCmdLine, uint uCmdShow);

		// Token: 0x040001C8 RID: 456
		public const int WM_CONTEXTMENU = 123;

		// Token: 0x040001C9 RID: 457
		public const int GWL_EXSTYLE = -20;

		// Token: 0x040001CA RID: 458
		public const int WS_EX_TRANSPARENT = 32;

		// Token: 0x040001CB RID: 459
		public const int WS_EX_LAYERED = 524288;

		// Token: 0x040001CC RID: 460
		public const byte AC_SRC_OVER = 0;

		// Token: 0x040001CD RID: 461
		public const int ULW_ALPHA = 2;

		// Token: 0x040001CE RID: 462
		public const byte AC_SRC_ALPHA = 1;

		// Token: 0x040001CF RID: 463
		public const int AW_HOR_POSITIVE = 1;

		// Token: 0x040001D0 RID: 464
		public const int AW_HOR_NEGATIVE = 2;

		// Token: 0x040001D1 RID: 465
		public const int AW_VER_POSITIVE = 4;

		// Token: 0x040001D2 RID: 466
		public const int AW_VER_NEGATIVE = 8;

		// Token: 0x040001D3 RID: 467
		public const int AW_CENTER = 16;

		// Token: 0x040001D4 RID: 468
		public const int AW_HIDE = 65536;

		// Token: 0x040001D5 RID: 469
		public const int AW_ACTIVATE = 131072;

		// Token: 0x040001D6 RID: 470
		public const int AW_SLIDE = 262144;

		// Token: 0x040001D7 RID: 471
		public const int AW_BLEND = 524288;

		// Token: 0x040001D8 RID: 472
		public const int WM_MOUSEMOVE = 512;

		// Token: 0x040001D9 RID: 473
		public const int WM_LBUTTONDOWN = 513;

		// Token: 0x040001DA RID: 474
		public const int WM_LBUTTONUP = 514;

		// Token: 0x040001DB RID: 475
		public const int WM_RBUTTONDOWN = 516;

		// Token: 0x040001DC RID: 476
		public const int WM_LBUTTONDBLCLK = 515;

		// Token: 0x040001DD RID: 477
		public const int WM_MOUSELEAVE = 675;

		// Token: 0x040001DE RID: 478
		public const int WM_PAINT = 15;

		// Token: 0x040001DF RID: 479
		public const int WM_ERASEBKGND = 20;

		// Token: 0x040001E0 RID: 480
		public const int WM_PRINT = 791;

		// Token: 0x040001E1 RID: 481
		public const int WM_HSCROLL = 276;

		// Token: 0x040001E2 RID: 482
		public const int WM_VSCROLL = 277;

		// Token: 0x040001E3 RID: 483
		public const int EM_GETSEL = 176;

		// Token: 0x040001E4 RID: 484
		public const int EM_LINEINDEX = 187;

		// Token: 0x040001E5 RID: 485
		public const int EM_LINEFROMCHAR = 201;

		// Token: 0x040001E6 RID: 486
		public const int EM_POSFROMCHAR = 214;

		// Token: 0x040001E7 RID: 487
		public const int WM_PRINTCLIENT = 792;

		// Token: 0x040001E8 RID: 488
		public const long PRF_CHECKVISIBLE = 1L;

		// Token: 0x040001E9 RID: 489
		public const long PRF_NONCLIENT = 2L;

		// Token: 0x040001EA RID: 490
		public const long PRF_CLIENT = 4L;

		// Token: 0x040001EB RID: 491
		public const long PRF_ERASEBKGND = 8L;

		// Token: 0x040001EC RID: 492
		public const long PRF_CHILDREN = 16L;

		// Token: 0x040001ED RID: 493
		public const long PRF_OWNED = 32L;

		// Token: 0x040001EE RID: 494
		private const int CS_DropSHADOW = 131072;

		// Token: 0x040001EF RID: 495
		private const int GCL_STYLE = -26;

		// Token: 0x02000028 RID: 40
		public struct Size
		{
			// Token: 0x06000275 RID: 629 RVA: 0x00002E89 File Offset: 0x00001089
			public Size(int x, int y)
			{
				this.cx = x;
				this.cy = y;
			}

			// Token: 0x040001F0 RID: 496
			public int cx;

			// Token: 0x040001F1 RID: 497
			public int cy;
		}

		// Token: 0x02000029 RID: 41
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct BLENDFUNCTION
		{
			// Token: 0x040001F2 RID: 498
			public byte BlendOp;

			// Token: 0x040001F3 RID: 499
			public byte BlendFlags;

			// Token: 0x040001F4 RID: 500
			public byte SourceConstantAlpha;

			// Token: 0x040001F5 RID: 501
			public byte AlphaFormat;
		}

		// Token: 0x0200002A RID: 42
		public struct Point
		{
			// Token: 0x06000276 RID: 630 RVA: 0x00002E9A File Offset: 0x0000109A
			public Point(int x, int y)
			{
				this.x = x;
				this.y = y;
			}

			// Token: 0x040001F6 RID: 502
			public int x;

			// Token: 0x040001F7 RID: 503
			public int y;
		}

		// Token: 0x0200002B RID: 43
		[Flags]
		public enum KeyModifiers
		{
			// Token: 0x040001F9 RID: 505
			None = 0,
			// Token: 0x040001FA RID: 506
			Alt = 1,
			// Token: 0x040001FB RID: 507
			Ctrl = 2,
			// Token: 0x040001FC RID: 508
			Shift = 4,
			// Token: 0x040001FD RID: 509
			WindowsKey = 8
		}

		// Token: 0x0200002C RID: 44
		public class IniFileHelper
		{
			// Token: 0x06000277 RID: 631
			[DllImport("kernel32")]
			public static extern int GetPrivateProfileString(string sectionName, string key, string defaultValue, byte[] returnBuffer, int size, string filePath);

			// Token: 0x06000278 RID: 632
			[DllImport("kernel32")]
			public static extern long WritePrivateProfileString(string sectionName, string key, string value, string filePath);

			// Token: 0x06000279 RID: 633 RVA: 0x0001D834 File Offset: 0x0001BA34
			public static string GetValue(string sectionName, string key, string filePath)
			{
				byte[] array = new byte[2048];
				int privateProfileString = HelpWin32.IniFileHelper.GetPrivateProfileString(sectionName, key, "发生错误", array, 999, filePath);
				return Encoding.Default.GetString(array, 0, privateProfileString);
			}

			// Token: 0x0600027A RID: 634 RVA: 0x0001D874 File Offset: 0x0001BA74
			public static bool SetValue(string sectionName, string key, string value, string filePath)
			{
				bool result;
				try
				{
					result = ((int)HelpWin32.IniFileHelper.WritePrivateProfileString(sectionName, key, value, filePath) > 0);
				}
				catch (Exception ex)
				{
					throw ex;
				}
				return result;
			}

			// Token: 0x0600027B RID: 635 RVA: 0x0001D8B0 File Offset: 0x0001BAB0
			public static bool RemoveSection(string sectionName, string filePath)
			{
				bool result;
				try
				{
					result = ((int)HelpWin32.IniFileHelper.WritePrivateProfileString(sectionName, null, "", filePath) > 0);
				}
				catch (Exception ex)
				{
					throw ex;
				}
				return result;
			}

			// Token: 0x0600027C RID: 636 RVA: 0x0001D8F0 File Offset: 0x0001BAF0
			public static bool Removekey(string sectionName, string key, string filePath)
			{
				bool result;
				try
				{
					result = ((int)HelpWin32.IniFileHelper.WritePrivateProfileString(sectionName, key, null, filePath) > 0);
				}
				catch (Exception ex)
				{
					throw ex;
				}
				return result;
			}
		}
	}
}
