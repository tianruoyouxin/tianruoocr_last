using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;

namespace 天若OCR文字识别
{
	// Token: 0x02000004 RID: 4
	public partial class Fmflags : Form
	{
		// Token: 0x06000044 RID: 68 RVA: 0x0000236A File Offset: 0x0000056A
		public Fmflags()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00005EC8 File Offset: 0x000040C8
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.Style |= 131072;
				bool flag = !base.DesignMode;
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				if (flag8)
				{
					createParams.ExStyle |= 524288;
				}
				return createParams;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005F34 File Offset: 0x00004134
		public void SetBits(Bitmap bitmap)
		{
			bool flag = !Image.IsCanonicalPixelFormat(bitmap.PixelFormat) || !Image.IsAlphaPixelFormat(bitmap.PixelFormat);
			bool flag2 = flag;
			bool flag3 = flag2;
			bool flag4 = flag3;
			bool flag5 = flag4;
			bool flag6 = flag5;
			bool flag7 = flag6;
			if (flag7)
			{
				throw new ApplicationException("图片必须是32位带Alhpa通道的图片。");
			}
			IntPtr hObj = IntPtr.Zero;
			IntPtr dc = HelpWin32.GetDC(IntPtr.Zero);
			IntPtr intPtr = IntPtr.Zero;
			IntPtr intPtr2 = HelpWin32.CreateCompatibleDC(dc);
			try
			{
				HelpWin32.Point point = new HelpWin32.Point(base.Left, base.Top);
				HelpWin32.Size size = new HelpWin32.Size(bitmap.Width, bitmap.Height);
				HelpWin32.BLENDFUNCTION blendfunction = default(HelpWin32.BLENDFUNCTION);
				HelpWin32.Point point2 = new HelpWin32.Point(0, 0);
				intPtr = bitmap.GetHbitmap(Color.FromArgb(0));
				hObj = HelpWin32.SelectObject(intPtr2, intPtr);
				blendfunction.BlendOp = 0;
				blendfunction.SourceConstantAlpha = byte.MaxValue;
				blendfunction.AlphaFormat = 1;
				blendfunction.BlendFlags = 0;
				HelpWin32.UpdateLayeredWindow(base.Handle, dc, ref point, ref size, intPtr2, ref point2, 0, ref blendfunction, 2);
			}
			finally
			{
				bool flag8 = intPtr != IntPtr.Zero;
				bool flag9 = flag8;
				bool flag10 = flag9;
				bool flag11 = flag10;
				bool flag12 = flag11;
				bool flag13 = flag12;
				bool flag14 = flag13;
				if (flag14)
				{
					HelpWin32.SelectObject(intPtr2, hObj);
					HelpWin32.DeleteObject(intPtr);
				}
				HelpWin32.ReleaseDC(IntPtr.Zero, dc);
				HelpWin32.DeleteDC(intPtr2);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000060A0 File Offset: 0x000042A0
		public void DrawStr(string str)
		{
			this.宽度 = 50 * str.Length;
			base.ClientSize = new Size(this.宽度, 50);
			base.Location = new Point((Screen.PrimaryScreen.Bounds.Width - base.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - base.Height) / 2 / 3 * 5);
			this.bmp = new Bitmap(this.宽度, 50);
			this.g = Graphics.FromImage(this.bmp);
			this.g.InterpolationMode = InterpolationMode.Bilinear;
			this.g.SmoothingMode = SmoothingMode.HighQuality;
			this.g.TextRenderingHint = TextRenderingHint.AntiAlias;
			this.g.Clear(Color.Transparent);
			this.g.FillRectangle(new SolidBrush(Color.FromArgb(1, 255, 255, 255)), base.ClientRectangle);
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			Rectangle r = new Rectangle(0, 3, this.宽度, 50);
			this.g.FillRectangle(new SolidBrush(Color.FromArgb(120, Color.Black)), 1, 1, this.宽度 - 2, 48);
			this.g.DrawRectangle(new Pen(Color.FromArgb(224, 224, 224)), 2, 2, this.宽度 - 2 - 2, 46);
			this.g.DrawString(str, new Font("微软雅黑", 24f / Program.factor), new SolidBrush(Color.FromArgb(255, Color.White)), r, stringFormat);
			this.SetBits(this.bmp);
			this.g.Dispose();
			this.bmp.Dispose();
			this.Delay(600u);
			base.Hide();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006290 File Offset: 0x00004490
		private void Delay(uint ms)
		{
			uint tickCount = HelpWin32.GetTickCount();
			while (HelpWin32.GetTickCount() - tickCount < ms)
			{
				Thread.Sleep(1);
				Application.DoEvents();
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000062C4 File Offset: 0x000044C4
		public void DrawStr_update(string str)
		{
			this.宽度 = 28 * str.Length;
			base.ClientSize = new Size(this.宽度, 50);
			this.bmp = new Bitmap(this.宽度, 50);
			this.g = Graphics.FromImage(this.bmp);
			this.g.InterpolationMode = InterpolationMode.Bilinear;
			this.g.SmoothingMode = SmoothingMode.HighQuality;
			this.g.TextRenderingHint = TextRenderingHint.AntiAlias;
			this.g.Clear(Color.Transparent);
			this.g.FillRectangle(new SolidBrush(Color.FromArgb(1, 255, 255, 255)), base.ClientRectangle);
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			Rectangle r = new Rectangle(0, 10, this.宽度, 48);
			this.g.FillRectangle(new SolidBrush(Color.FromArgb(120, Color.Black)), 1, 1, this.宽度 - 2, 48);
			this.g.DrawRectangle(new Pen(Color.FromArgb(224, 224, 224)), 1, 1, this.宽度 - 2, 48);
			this.g.DrawString(str, new Font("微软雅黑", 18f), new SolidBrush(Color.FromArgb(255, Color.White)), r, stringFormat);
			this.SetBits_update(this.bmp);
			this.Delay(2000u);
			base.Hide();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006450 File Offset: 0x00004650
		public void SetBits_update(Bitmap bitmap)
		{
			bool flag = !Image.IsCanonicalPixelFormat(bitmap.PixelFormat) || !Image.IsAlphaPixelFormat(bitmap.PixelFormat);
			bool flag2 = flag;
			bool flag3 = flag2;
			bool flag4 = flag3;
			bool flag5 = flag4;
			bool flag6 = flag5;
			bool flag7 = flag6;
			if (flag7)
			{
				throw new ApplicationException("图片必须是32位带Alhpa通道的图片。");
			}
			IntPtr hObj = IntPtr.Zero;
			IntPtr dc = HelpWin32.GetDC(IntPtr.Zero);
			IntPtr intPtr = IntPtr.Zero;
			IntPtr intPtr2 = HelpWin32.CreateCompatibleDC(dc);
			try
			{
				HelpWin32.Point point = new HelpWin32.Point(Screen.PrimaryScreen.Bounds.Width - base.Width, Screen.PrimaryScreen.WorkingArea.Height - 50);
				HelpWin32.Size size = new HelpWin32.Size(bitmap.Width, bitmap.Height);
				HelpWin32.BLENDFUNCTION blendfunction = default(HelpWin32.BLENDFUNCTION);
				HelpWin32.Point point2 = new HelpWin32.Point(0, 0);
				intPtr = bitmap.GetHbitmap(Color.FromArgb(0));
				hObj = HelpWin32.SelectObject(intPtr2, intPtr);
				blendfunction.BlendOp = 0;
				blendfunction.SourceConstantAlpha = byte.MaxValue;
				blendfunction.AlphaFormat = 1;
				blendfunction.BlendFlags = 0;
				HelpWin32.UpdateLayeredWindow(base.Handle, dc, ref point, ref size, intPtr2, ref point2, 0, ref blendfunction, 2);
			}
			finally
			{
				bool flag8 = intPtr != IntPtr.Zero;
				bool flag9 = flag8;
				bool flag10 = flag9;
				bool flag11 = flag10;
				bool flag12 = flag11;
				bool flag13 = flag12;
				bool flag14 = flag13;
				if (flag14)
				{
					HelpWin32.SelectObject(intPtr2, hObj);
					HelpWin32.DeleteObject(intPtr);
				}
				HelpWin32.ReleaseDC(IntPtr.Zero, dc);
				HelpWin32.DeleteDC(intPtr2);
			}
		}

		// Token: 0x04000039 RID: 57
		private Bitmap bmp;

		// Token: 0x0400003A RID: 58
		private Graphics g;

		// Token: 0x0400003B RID: 59
		public int 宽度;
	}
}
