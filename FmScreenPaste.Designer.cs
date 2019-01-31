namespace 天若OCR文字识别
{
	// Token: 0x02000014 RID: 20
	public partial class FmScreenPaste : global::System.Windows.Forms.Form
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00015DE0 File Offset: 0x00013FE0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00015E18 File Offset: 0x00014018
		private void InitializeComponent()
		{
			this.RightMenu = new global::System.Windows.Forms.ContextMenuStrip();
			this.关闭ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem6 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.置顶ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RightMenu.SuspendLayout();
			base.SuspendLayout();
			this.RightMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.关闭ToolStripMenuItem,
				this.toolStripSeparator1,
				this.toolStripMenuItem6,
				this.toolStripMenuItem8,
				this.toolStripSeparator2,
				this.置顶ToolStripMenuItem
			});
			this.RightMenu.Name = "dSkinContextMenuStrip2";
			this.RightMenu.ShowImageMargin = false;
			this.RightMenu.Size = new global::System.Drawing.Size(124, 126);
			this.RightMenu.Opening += new global::System.ComponentModel.CancelEventHandler(this.RightCMS_Opening);
			this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
			this.关闭ToolStripMenuItem.Size = new global::System.Drawing.Size(123, 22);
			this.关闭ToolStripMenuItem.Text = "关闭";
			this.关闭ToolStripMenuItem.Click += new global::System.EventHandler(this.关闭ToolStripMenuItem_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(120, 6);
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new global::System.Drawing.Size(123, 22);
			this.toolStripMenuItem6.Text = "复制图像";
			this.toolStripMenuItem6.Click += new global::System.EventHandler(this.复制toolStripMenuItem_Click);
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new global::System.Drawing.Size(123, 22);
			this.toolStripMenuItem8.Text = "图像另存为";
			this.toolStripMenuItem8.Click += new global::System.EventHandler(this.保存toolStripMenuItem_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(120, 6);
			this.置顶ToolStripMenuItem.Name = "置顶窗体ToolStripMenuItem";
			this.置顶ToolStripMenuItem.Size = new global::System.Drawing.Size(123, 22);
			this.置顶ToolStripMenuItem.Text = "置顶窗体";
			this.置顶ToolStripMenuItem.Click += new global::System.EventHandler(this.置顶ToolStripMenuItem_Click);
			this.ContextMenuStrip = this.RightMenu;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			base.TopMost = true;
			base.ShowInTaskbar = false;
			this.RightMenu.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000117 RID: 279
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000118 RID: 280
		private global::System.Windows.Forms.ContextMenuStrip RightMenu;

		// Token: 0x04000119 RID: 281
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;

		// Token: 0x0400011A RID: 282
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;

		// Token: 0x0400011B RID: 283
		private global::System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;

		// Token: 0x0400011C RID: 284
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x0400011D RID: 285
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x0400011E RID: 286
		private global::System.Windows.Forms.ToolStripMenuItem 置顶ToolStripMenuItem;
	}
}
