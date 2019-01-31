using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace 天若OCR文字识别
{
	// Token: 0x02000033 RID: 51
	public partial class ReplaceForm : Form
	{
		// Token: 0x060002AE RID: 686 RVA: 0x0001FA0C File Offset: 0x0001DC0C
		public ReplaceForm(AdvRichTextBox mm)
		{
			this.InitializeComponent();
			this.Fmok = mm;
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FmMain));
			base.Icon = (Icon)componentResourceManager.GetObject("minico.Icon");
			base.StartPosition = FormStartPosition.Manual;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000207C File Offset: 0x0000027C
		private void Form2_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0001FA5C File Offset: 0x0001DC5C
		private void findbutton_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.Fmok.richTextBox1.Text != "")
				{
					this.p = this.Fmok.richTextBox1.Text.IndexOf(this.findtextbox.Text, this.p);
					if (this.p != -1)
					{
						this.Fmok.richTextBox1.Select(this.p, this.findtextbox.Text.Length);
						this.p++;
					}
					else
					{
						MessageBox.Show("已查找到文档尾！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						this.p = 0;
					}
				}
			}
			catch
			{
				this.p = 0;
				MessageBox.Show("已查找到文档尾！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0001FB3C File Offset: 0x0001DD3C
		private void replacebutton_Click(object sender, EventArgs e)
		{
			if (this.Fmok.richTextBox1.Text != "")
			{
				this.p = 0;
				this.p = this.Fmok.richTextBox1.Text.IndexOf(this.findtextbox.Text, this.p);
				if (this.p != -1)
				{
					this.Fmok.richTextBox1.Select(this.p, this.findtextbox.Text.Length);
					this.Fmok.richTextBox1.SelectedText = this.replacetextBox.Text;
					this.p++;
					return;
				}
				MessageBox.Show("已替换完！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.p = 0;
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0001FC10 File Offset: 0x0001DE10
		private void replaceallbutton_Click(object sender, EventArgs e)
		{
			if (this.Fmok.richTextBox1.Text != "" && this.findtextbox.Text != "")
			{
				this.p = 0;
				this.p = this.Fmok.richTextBox1.Text.IndexOf(this.findtextbox.Text, this.p);
				while (this.p != -1)
				{
					this.Fmok.richTextBox1.Select(this.p, this.findtextbox.Text.Length);
					this.Fmok.richTextBox1.SelectedText = this.replacetextBox.Text;
					this.p = this.Fmok.richTextBox1.Text.IndexOf(this.findtextbox.Text, this.p);
					this.flag = true;
				}
				if (this.flag)
				{
					MessageBox.Show("替换完毕！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (MessageBox.Show("替换内容不存在，请重新输入！", "提醒") == DialogResult.OK)
				{
					this.findtextbox.Text = "";
				}
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002F69 File Offset: 0x00001169
		private void canclebutton_Click(object sender, EventArgs e)
		{
			base.Hide();
			this.Fmok.Focus();
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002F69 File Offset: 0x00001169
		private void ReplaceForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.Hide();
			this.Fmok.Focus();
		}

		// Token: 0x04000229 RID: 553
		public AdvRichTextBox Fmok;

		// Token: 0x0400022A RID: 554
		private int p;

		// Token: 0x0400022B RID: 555
		private bool flag;
	}
}
