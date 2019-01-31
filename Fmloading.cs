using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace 天若OCR文字识别
{
	// Token: 0x02000006 RID: 6
	public partial class Fmloading : Form
	{
		// Token: 0x06000057 RID: 87 RVA: 0x0000237E File Offset: 0x0000057E
		public Fmloading()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00006FA8 File Offset: 0x000051A8
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
				bool flag9 = flag8;
				if (flag9)
				{
					createParams.ExStyle |= 524288;
				}
				return createParams;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00007018 File Offset: 0x00005218
		public void SetBits(Bitmap bitmap)
		{
			bool flag = Image.IsCanonicalPixelFormat(bitmap.PixelFormat) && Image.IsAlphaPixelFormat(bitmap.PixelFormat);
			bool flag2 = flag;
			bool flag3 = flag2;
			bool flag4 = flag3;
			bool flag5 = flag4;
			bool flag6 = flag5;
			bool flag7 = flag6;
			bool flag8 = flag7;
			bool flag9 = flag8;
			if (flag9)
			{
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
					return;
				}
				finally
				{
					bool flag10 = intPtr != IntPtr.Zero;
					bool flag11 = flag10;
					bool flag12 = flag11;
					bool flag13 = flag12;
					bool flag14 = flag13;
					bool flag15 = flag14;
					bool flag16 = flag15;
					bool flag17 = flag16;
					bool flag18 = flag17;
					if (flag18)
					{
						HelpWin32.SelectObject(intPtr2, hObj);
						HelpWin32.DeleteObject(intPtr);
					}
					HelpWin32.ReleaseDC(IntPtr.Zero, dc);
					HelpWin32.DeleteDC(intPtr2);
				}
			}
			throw new ApplicationException("图片必须是32位带Alhpa通道的图片。");
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00007190 File Offset: 0x00005390
		public void InitializeComponent()
		{
			this.timer = new Timer();
			this.fm_close = "窗体已开启";
			base.SuspendLayout();
			base.ShowInTaskbar = false;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.ForeColor = Color.Aqua;
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "Form1";
			this.Text = "Form1";
			base.TopMost = true;
			base.ClientSize = new Size(120, 120);
			base.Location = (Point)new Size(500, 500);
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Set_png();
			base.ResumeLayout(false);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00007258 File Offset: 0x00005458
		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.fm_close != "窗体已开启";
				bool flag2 = flag;
				bool flag3 = flag2;
				bool flag4 = flag3;
				bool flag5 = flag4;
				bool flag6 = flag5;
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				if (flag9)
				{
					base.Close();
				}
				bool flag10 = this.i_c >= this.fla_1;
				bool flag11 = flag10;
				bool flag12 = flag11;
				bool flag13 = flag12;
				bool flag14 = flag13;
				bool flag15 = flag14;
				bool flag16 = flag15;
				bool flag17 = flag16;
				bool flag18 = flag17;
				if (flag18)
				{
					this.i_c = 0;
				}
				this.bgImg = (Image)new ComponentResourceManager(typeof(Fmloading)).GetObject(this.i_c.ToString() + this.fla_2 + ".png");
				this.SetBits((Bitmap)this.bgImg);
				this.i_c++;
			}
			catch
			{
				MessageBox.Show("加载窗体关闭报错");
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000735C File Offset: 0x0000555C
		public void Set_png()
		{
			string a;
			try
			{
				a = inihelp.GetValue("配置", "窗体动画");
			}
			catch
			{
				a = "窗体";
			}
			bool flag = a == "少女";
			bool flag2 = flag;
			bool flag3 = flag2;
			bool flag4 = flag3;
			bool flag5 = flag4;
			bool flag6 = flag5;
			if (flag6)
			{
				this.timer.Interval = 50;
				this.fla_1 = 27;
				this.fla_2 = "";
			}
			else
			{
				bool flag7 = a == "罗小黑";
				bool flag8 = flag7;
				bool flag9 = flag8;
				bool flag10 = flag9;
				bool flag11 = flag10;
				bool flag12 = flag11;
				if (flag12)
				{
					this.timer.Interval = 18;
					this.fla_1 = 46;
					this.fla_2 = "_luo";
				}
				else
				{
					this.timer.Interval = 80;
					this.fla_1 = 4;
					this.fla_2 = "_load";
				}
			}
			this.bgImg = null;
			this.i_c = 0;
			this.timer.Tick += this.timer1_Tick;
			this.timer.Start();
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00007480 File Offset: 0x00005680
		// (set) Token: 0x0600005E RID: 94 RVA: 0x0000238F File Offset: 0x0000058F
		public string fml_close
		{
			get
			{
				return this.fm_close;
			}
			set
			{
				this.fm_close = value;
			}
		}

		// Token: 0x04000045 RID: 69
		public int i_c;

		// Token: 0x04000046 RID: 70
		private Image bgImg;

		// Token: 0x04000047 RID: 71
		public Timer timer;

		// Token: 0x04000048 RID: 72
		public int fla_1;

		// Token: 0x04000049 RID: 73
		public string fla_2;

		// Token: 0x0400004A RID: 74
		public string str;

		// Token: 0x0400004B RID: 75
		public string fm_close;
	}
}
