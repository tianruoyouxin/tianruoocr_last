using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace 天若OCR文字识别
{
	// Token: 0x02000014 RID: 20
	public partial class FmScreenPaste : Form
	{
		// Token: 0x0600017A RID: 378 RVA: 0x000158B4 File Offset: 0x00013AB4
		public FmScreenPaste(Image img, Point LocationPoint)
		{
			this.m_aeroEnabled = false;
			this.InitializeComponent();
			this.BackgroundImage = img;
			base.Location = LocationPoint;
			base.FormBorderStyle = FormBorderStyle.None;
			base.MouseDown += this.Form1_MouseDown;
			base.MouseMove += this.Form1_MouseMove;
			base.MouseUp += this.Form1_MouseUp;
			Size size = img.Size;
			this.MaximumSize = (this.MinimumSize = size);
			base.Size = size;
			base.MouseDoubleClick += this.双击_MouseDoubleClick;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000237B File Offset: 0x0000057B
		private void Form_MouseWheel(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0001595C File Offset: 0x00013B5C
		private void RightCMS_Opening(object sender, CancelEventArgs e)
		{
			bool topMost = base.TopMost;
			if (topMost)
			{
				this.置顶ToolStripMenuItem.Text = "取消置顶";
			}
			else
			{
				this.置顶ToolStripMenuItem.Text = "置顶窗体";
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002BB1 File Offset: 0x00000DB1
		private void 置顶ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			base.TopMost = !base.TopMost;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002BC4 File Offset: 0x00000DC4
		private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.BackgroundImage.Dispose();
			GC.Collect();
			base.Close();
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002BDC File Offset: 0x00000DDC
		private void 复制toolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetImage(this.BackgroundImage);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0001599C File Offset: 0x00013B9C
		private void 保存toolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "jpg图片(*.jpg)|*.jpg|png图片(*.png)|*.jpg|bmp图片(*.bmp)|*.bmp";
			saveFileDialog.AddExtension = false;
			saveFileDialog.FileName = string.Concat(new string[]
			{
				"tianruo_",
				DateTime.Now.Year.ToString(),
				"-",
				DateTime.Now.Month.ToString(),
				"-",
				DateTime.Now.Day.ToString(),
				"-",
				DateTime.Now.Ticks.ToString()
			});
			saveFileDialog.Title = "保存图片";
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.RestoreDirectory = true;
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				string extension = Path.GetExtension(saveFileDialog.FileName);
				bool flag2 = extension.Equals(".jpg");
				if (flag2)
				{
					this.BackgroundImage.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
				}
				bool flag3 = extension.Equals(".png");
				if (flag3)
				{
					this.BackgroundImage.Save(saveFileDialog.FileName, ImageFormat.Png);
				}
				bool flag4 = extension.Equals(".bmp");
				if (flag4)
				{
					this.BackgroundImage.Save(saveFileDialog.FileName, ImageFormat.Bmp);
				}
			}
		}

		// Token: 0x06000181 RID: 385
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000182 RID: 386
		[DllImport("user32.dll")]
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

		// Token: 0x06000183 RID: 387 RVA: 0x00015B14 File Offset: 0x00013D14
		private void Form_MouseDown(object sender, MouseEventArgs e)
		{
			int wMsg = 274;
			int num = 61456;
			int num2 = 2;
			FmScreenPaste.ReleaseCapture();
			FmScreenPaste.SendMessage(base.Handle, wMsg, num + num2, 0);
		}

		// Token: 0x06000184 RID: 388
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000185 RID: 389
		[DllImport("dwmapi.dll")]
		public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref FmScreenPaste.MARGINS pMarInset);

		// Token: 0x06000186 RID: 390
		[DllImport("dwmapi.dll")]
		public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

		// Token: 0x06000187 RID: 391
		[DllImport("dwmapi.dll")]
		public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

		// Token: 0x06000188 RID: 392 RVA: 0x00015B48 File Offset: 0x00013D48
		private bool CheckAeroEnabled()
		{
			bool flag = Environment.OSVersion.Version.Major >= 6;
			bool result;
			if (flag)
			{
				int num = 0;
				FmScreenPaste.DwmIsCompositionEnabled(ref num);
				result = (num == 1);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00015B88 File Offset: 0x00013D88
		protected override void WndProc(ref Message m)
		{
			int msg = m.Msg;
			bool flag = m.Msg == 132 && (int)m.Result == 1;
			if (flag)
			{
				m.Result = (IntPtr)2;
			}
			bool flag2 = msg == 133 && this.m_aeroEnabled;
			if (flag2)
			{
				int num = 2;
				FmScreenPaste.DwmSetWindowAttribute(base.Handle, 2, ref num, 4);
				FmScreenPaste.MARGINS margins = new FmScreenPaste.MARGINS
				{
					bottomHeight = 1,
					leftWidth = 1,
					rightWidth = 1,
					topHeight = 1
				};
				FmScreenPaste.DwmExtendFrameIntoClientArea(base.Handle, ref margins);
			}
			base.WndProc(ref m);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00015C3C File Offset: 0x00013E3C
		protected override CreateParams CreateParams
		{
			get
			{
				this.m_aeroEnabled = this.CheckAeroEnabled();
				CreateParams createParams = base.CreateParams;
				bool flag = !this.m_aeroEnabled;
				if (flag)
				{
					createParams.ClassStyle |= 131072;
				}
				return createParams;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002BC4 File Offset: 0x00000DC4
		private void 双击_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.BackgroundImage.Dispose();
			GC.Collect();
			base.Close();
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00015C84 File Offset: 0x00013E84
		public void AdjustSize()
		{
			Size size = new Size(10, 25);
			this.MaximumSize = (this.MinimumSize = size);
			base.Size = size;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00015CB8 File Offset: 0x00013EB8
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				this.mouseOff = new Point(-e.X, -e.Y);
				this.leftFlag = true;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00015CFC File Offset: 0x00013EFC
		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this.leftFlag;
			if (flag)
			{
				Point mousePosition = Control.MousePosition;
				mousePosition.Offset(this.mouseOff.X, this.mouseOff.Y);
				base.Location = mousePosition;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00015D44 File Offset: 0x00013F44
		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.leftFlag;
			if (flag)
			{
				this.leftFlag = false;
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00015D68 File Offset: 0x00013F68
		protected override void OnPaint(PaintEventArgs e)
		{
			this.DoubleBuffered = true;
			bool flag = this.BackgroundImage != null;
			if (flag)
			{
				e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
				e.Graphics.DrawImage(this.BackgroundImage, new Rectangle(0, 0, base.Width, base.Height), 0, 0, this.BackgroundImage.Width, this.BackgroundImage.Height, GraphicsUnit.Pixel);
			}
			base.OnPaint(e);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000237B File Offset: 0x0000057B
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x0400010C RID: 268
		private int zoomLevel;

		// Token: 0x0400010D RID: 269
		private string ScreenshotLastSavePath;

		// Token: 0x0400010E RID: 270
		private bool m_aeroEnabled;

		// Token: 0x0400010F RID: 271
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000110 RID: 272
		private const int WM_NCPAINT = 133;

		// Token: 0x04000111 RID: 273
		private const int WM_ACTIVATEAPP = 28;

		// Token: 0x04000112 RID: 274
		private const int WM_NCHITTEST = 132;

		// Token: 0x04000113 RID: 275
		private const int HTCLIENT = 1;

		// Token: 0x04000114 RID: 276
		private const int HTCAPTION = 2;

		// Token: 0x04000115 RID: 277
		private Point mouseOff;

		// Token: 0x04000116 RID: 278
		private bool leftFlag;

		// Token: 0x02000015 RID: 21
		public struct MARGINS
		{
			// Token: 0x0400011F RID: 287
			public int leftWidth;

			// Token: 0x04000120 RID: 288
			public int rightWidth;

			// Token: 0x04000121 RID: 289
			public int topHeight;

			// Token: 0x04000122 RID: 290
			public int bottomHeight;
		}
	}
}
