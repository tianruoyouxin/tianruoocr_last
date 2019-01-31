namespace 天若OCR文字识别
{
	// Token: 0x0200003B RID: 59
	public partial class aliFMtable : global::System.Windows.Forms.Form
	{
		// Token: 0x06000308 RID: 776 RVA: 0x0000301E File Offset: 0x0000121E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00020578 File Offset: 0x0001E778
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.webBrowser1 = new global::System.Windows.Forms.WebBrowser();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.webBrowser1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new global::System.Drawing.Point(0, 0);
			this.webBrowser1.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new global::System.Drawing.Size(399, 422);
			this.webBrowser1.TabIndex = 0;
			this.webBrowser1.ScriptErrorsSuppressed = true;
			this.webBrowser1.DocumentCompleted += new global::System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
			this.textBox1.Location = new global::System.Drawing.Point(121, 87);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(100, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(399, 422);
			base.Controls.Add(this.webBrowser1);
			base.Controls.Add(this.textBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.Name = "aliFMtable";
			this.Text = "阿里表格";
			base.Load += new global::System.EventHandler(this.Form2_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400024C RID: 588
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400024D RID: 589
		private global::System.Windows.Forms.WebBrowser webBrowser1;

		// Token: 0x0400024E RID: 590
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400024F RID: 591
		private global::System.Windows.Forms.Timer timer1;
	}
}
