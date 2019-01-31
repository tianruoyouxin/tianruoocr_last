namespace 天若OCR文字识别
{
	// Token: 0x02000005 RID: 5
	public partial class FmHelp : global::System.Windows.Forms.Form
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00006A34 File Offset: 0x00004C34
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			bool flag2 = flag;
			bool flag3 = flag2;
			bool flag4 = flag3;
			bool flag5 = flag4;
			bool flag6 = flag5;
			bool flag7 = flag6;
			if (flag7)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006A80 File Offset: 0x00004C80
		private void InitializeComponent()
		{
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.panel_快捷键 = new global::System.Windows.Forms.Panel();
			this.panel_常见问题 = new global::System.Windows.Forms.Panel();
			this.webBrowser1 = new global::System.Windows.Forms.WebBrowser();
			this.panel_识别说明 = new global::System.Windows.Forms.Panel();
			this.webBrowser2 = new global::System.Windows.Forms.WebBrowser();
			this.webBrowser3 = new global::System.Windows.Forms.WebBrowser();
			this.panel_快捷键.SuspendLayout();
			this.panel_常见问题.SuspendLayout();
			this.panel_识别说明.SuspendLayout();
			base.SuspendLayout();
			this.listBox1.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 25;
			this.listBox1.Items.AddRange(new object[]
			{
				"使用说明",
				"快捷键",
				"常见问题"
			});
			this.listBox1.Location = new global::System.Drawing.Point(10, 5);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(87, 454);
			this.listBox1.TabIndex = 1;
			this.listBox1.DrawItem += new global::System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
			this.listBox1.SelectedIndexChanged += new global::System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.panel_快捷键.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_快捷键.Controls.Add(this.webBrowser3);
			this.panel_快捷键.Location = new global::System.Drawing.Point(30, 186);
			this.panel_快捷键.Name = "panel_快捷键";
			this.panel_快捷键.Size = new global::System.Drawing.Size(486, 454);
			this.panel_快捷键.TabIndex = 5;
			this.panel_常见问题.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_常见问题.Controls.Add(this.webBrowser2);
			this.panel_常见问题.Location = new global::System.Drawing.Point(103, 4);
			this.panel_常见问题.Name = "panel_常见问题";
			this.panel_常见问题.Size = new global::System.Drawing.Size(486, 454);
			this.panel_常见问题.TabIndex = 6;
			this.webBrowser1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new global::System.Drawing.Point(0, 0);
			this.webBrowser1.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new global::System.Drawing.Size(484, 452);
			this.webBrowser1.TabIndex = 3;
			this.webBrowser1.DocumentCompleted += new global::System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
			this.panel_识别说明.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_识别说明.Controls.Add(this.webBrowser1);
			this.panel_识别说明.Location = new global::System.Drawing.Point(507, 5);
			this.panel_识别说明.Name = "panel_识别说明";
			this.panel_识别说明.Size = new global::System.Drawing.Size(486, 454);
			this.panel_识别说明.TabIndex = 4;
			this.webBrowser2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.webBrowser2.Location = new global::System.Drawing.Point(0, 0);
			this.webBrowser2.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowser2.Name = "webBrowser2";
			this.webBrowser2.Size = new global::System.Drawing.Size(484, 452);
			this.webBrowser2.TabIndex = 4;
			this.webBrowser2.NewWindow += new global::System.ComponentModel.CancelEventHandler(this.webBrowser_NewWindow);
			this.webBrowser3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.webBrowser3.Location = new global::System.Drawing.Point(0, 0);
			this.webBrowser3.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowser3.Name = "webBrowser3";
			this.webBrowser3.Size = new global::System.Drawing.Size(484, 452);
			this.webBrowser3.TabIndex = 5;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(606, 472);
			base.Controls.Add(this.panel_识别说明);
			base.Controls.Add(this.panel_快捷键);
			base.Controls.Add(this.panel_常见问题);
			base.Controls.Add(this.listBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FmHelp";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "帮助";
			base.TopMost = true;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			base.Load += new global::System.EventHandler(this.FmHelp_Load);
			this.panel_快捷键.ResumeLayout(false);
			this.panel_常见问题.ResumeLayout(false);
			this.panel_识别说明.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400003D RID: 61
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Panel panel_快捷键;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Panel panel_常见问题;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.WebBrowser webBrowser1;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Panel panel_识别说明;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.WebBrowser webBrowser2;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.WebBrowser webBrowser3;
	}
}
