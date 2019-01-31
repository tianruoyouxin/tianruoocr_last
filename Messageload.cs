using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace 天若OCR文字识别
{
	// Token: 0x0200002E RID: 46
	public partial class Messageload : Form
	{
		// Token: 0x06000284 RID: 644 RVA: 0x00002EAB File Offset: 0x000010AB
		public Messageload()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002EBC File Offset: 0x000010BC
		public void Form1_Load(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0001DAE8 File Offset: 0x0001BCE8
		public void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.FormBorderStyle = FormBorderStyle.None;
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new Size(0, 0);
			this.ForeColor = Color.Black;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Form1";
			this.Text = "弹窗";
			base.Load += this.Form1_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
