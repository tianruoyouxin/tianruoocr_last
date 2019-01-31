using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Microsoft.Win32;
using 天若OCR文字识别.Properties;

namespace 天若OCR文字识别
{
	// Token: 0x02000016 RID: 22
	public partial class FmSetting : Form
	{
		// Token: 0x06000194 RID: 404 RVA: 0x000160E0 File Offset: 0x000142E0
		public FmSetting()
		{
			this.Font = new Font(this.Font.Name, 9f / StaticValue.Dpifactor, this.Font.Style, this.Font.Unit, this.Font.GdiCharSet, this.Font.GdiVerticalFont);
			this.InitializeComponent();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00016148 File Offset: 0x00014348
		public void readIniFile()
		{
			string value = inihelp.GetValue("配置", "开机自启");
			if (value == "发生错误")
			{
				this.cbBox_开机.Checked = true;
			}
			try
			{
				this.cbBox_开机.Checked = Convert.ToBoolean(value);
			}
			catch
			{
				this.cbBox_开机.Checked = true;
			}
			string value2 = inihelp.GetValue("配置", "快速翻译");
			if (value2 == "发生错误")
			{
				this.cbBox_翻译.Checked = true;
			}
			try
			{
				this.cbBox_翻译.Checked = Convert.ToBoolean(value2);
			}
			catch
			{
				this.cbBox_翻译.Checked = true;
			}
			string value3 = inihelp.GetValue("配置", "识别弹窗");
			if (value3 == "发生错误")
			{
				this.cbBox_弹窗.Checked = true;
			}
			try
			{
				this.cbBox_弹窗.Checked = Convert.ToBoolean(value3);
			}
			catch
			{
				this.cbBox_弹窗.Checked = true;
			}
			string value4 = inihelp.GetValue("配置", "窗体动画");
			this.cobBox_动画.Text = value4;
			if (value4 == "发生错误")
			{
				this.cobBox_动画.Text = "窗体";
			}
			string value5 = inihelp.GetValue("配置", "记录数目");
			this.numbox_记录.Value = Convert.ToInt32(value5);
			if (value5 == "发生错误")
			{
				this.numbox_记录.Value = 20m;
			}
			string value6 = inihelp.GetValue("配置", "自动保存");
			if (value6 == "发生错误")
			{
				this.cbBox_保存.Checked = false;
			}
			try
			{
				this.cbBox_保存.Checked = Convert.ToBoolean(value6);
			}
			catch
			{
				this.cbBox_保存.Checked = false;
			}
			if (this.cbBox_保存.Checked)
			{
				this.textBox_path.Enabled = true;
				this.btn_浏览.Enabled = true;
			}
			if (!this.cbBox_保存.Checked)
			{
				this.textBox_path.Enabled = false;
				this.btn_浏览.Enabled = false;
			}
			string value7 = inihelp.GetValue("配置", "截图位置");
			this.textBox_path.Text = value7;
			if (value7 == "发生错误")
			{
				this.textBox_path.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			}
			string value8 = inihelp.GetValue("快捷键", "文字识别");
			this.txtBox_文字识别.Text = value8;
			if (value8 == "发生错误")
			{
				this.txtBox_文字识别.Text = "F4";
			}
			string value9 = inihelp.GetValue("快捷键", "翻译文本");
			this.txtBox_翻译文本.Text = value9;
			if (value9 == "发生错误")
			{
				this.txtBox_翻译文本.Text = "F9";
			}
			string value10 = inihelp.GetValue("快捷键", "记录界面");
			this.txtBox_记录界面.Text = value10;
			if (value10 == "发生错误")
			{
				this.txtBox_记录界面.Text = "请按下快捷键";
			}
			string value11 = inihelp.GetValue("快捷键", "识别界面");
			this.txtBox_识别界面.Text = value11;
			if (value11 == "发生错误")
			{
				this.txtBox_识别界面.Text = "请按下快捷键";
			}
			if (this.txtBox_文字识别.Text == "请按下快捷键")
			{
				this.pictureBox_文字识别.Image = Resources.快捷键_0;
			}
			else
			{
				this.pictureBox_文字识别.Image = Resources.快捷键_1;
			}
			if (this.txtBox_翻译文本.Text == "请按下快捷键")
			{
				this.pictureBox_翻译文本.Image = Resources.快捷键_0;
			}
			else
			{
				this.pictureBox_翻译文本.Image = Resources.快捷键_1;
			}
			if (this.txtBox_记录界面.Text == "请按下快捷键")
			{
				this.pictureBox_记录界面.Image = Resources.快捷键_0;
			}
			else
			{
				this.pictureBox_记录界面.Image = Resources.快捷键_1;
			}
			if (this.txtBox_识别界面.Text == "请按下快捷键")
			{
				this.pictureBox_识别界面.Image = Resources.快捷键_0;
			}
			else
			{
				this.pictureBox_识别界面.Image = Resources.快捷键_1;
			}
			string value12 = inihelp.GetValue("密钥_百度", "secret_id");
			this.text_baiduaccount.Text = value12;
			if (value12 == "发生错误")
			{
				this.text_baiduaccount.Text = "YsZKG1wha34PlDOPYaIrIIKO";
			}
			string value13 = inihelp.GetValue("密钥_百度", "secret_key");
			this.text_baidupassword.Text = value13;
			if (value13 == "发生错误")
			{
				this.text_baidupassword.Text = "HPRZtdOHrdnnETVsZM2Nx7vbDkMfxrkD";
			}
			string value14 = inihelp.GetValue("代理", "代理类型");
			this.combox_代理.Text = value14;
			if (value14 == "发生错误")
			{
				this.combox_代理.Text = "系统代理";
			}
			if (this.combox_代理.Text == "不使用代理" || this.combox_代理.Text == "系统代理")
			{
				this.text_账号.Enabled = false;
				this.text_密码.Enabled = false;
				this.chbox_代理服务器.Enabled = false;
				this.text_端口.Enabled = false;
				this.text_服务器.Enabled = false;
			}
			if (this.combox_代理.Text == "自定义代理")
			{
				this.text_端口.Enabled = true;
				this.text_服务器.Enabled = true;
			}
			string value15 = inihelp.GetValue("代理", "服务器");
			this.text_服务器.Text = value15;
			if (value15 == "发生错误")
			{
				this.text_服务器.Text = "127.0.0.1";
			}
			string value16 = inihelp.GetValue("代理", "端口");
			this.text_端口.Text = value16;
			if (value16 == "发生错误")
			{
				this.text_端口.Text = "1080";
			}
			string value17 = inihelp.GetValue("代理", "需要密码");
			if (value17 == "发生错误")
			{
				this.chbox_代理服务器.Checked = false;
			}
			try
			{
				this.chbox_代理服务器.Checked = Convert.ToBoolean(value17);
			}
			catch
			{
				this.chbox_代理服务器.Checked = false;
			}
			string value18 = inihelp.GetValue("代理", "服务器账号");
			this.text_账号.Text = value18;
			if (value18 == "发生错误")
			{
				this.text_账号.Text = "";
			}
			string value19 = inihelp.GetValue("代理", "服务器密码");
			this.text_密码.Text = value19;
			if (value19 == "发生错误")
			{
				this.text_密码.Text = "";
			}
			if (this.chbox_代理服务器.Checked)
			{
				this.text_账号.Enabled = true;
				this.text_密码.Enabled = true;
			}
			if (!this.chbox_代理服务器.Checked)
			{
				this.text_账号.Enabled = false;
				this.text_密码.Enabled = false;
			}
			string value20 = inihelp.GetValue("更新", "检测更新");
			if (value20 == "发生错误")
			{
				this.check_检查更新.Checked = false;
			}
			try
			{
				this.check_检查更新.Checked = Convert.ToBoolean(value20);
			}
			catch
			{
				this.check_检查更新.Checked = false;
			}
			if (this.check_检查更新.Checked)
			{
				this.checkBox_更新间隔.Enabled = true;
			}
			if (!this.check_检查更新.Checked)
			{
				this.checkBox_更新间隔.Enabled = false;
				this.numbox_间隔时间.Enabled = false;
			}
			string value21 = inihelp.GetValue("更新", "更新间隔");
			if (value21 == "发生错误")
			{
				this.checkBox_更新间隔.Checked = false;
			}
			try
			{
				this.checkBox_更新间隔.Checked = Convert.ToBoolean(value21);
			}
			catch
			{
				this.checkBox_更新间隔.Checked = false;
			}
			if (this.checkBox_更新间隔.Checked)
			{
				this.numbox_间隔时间.Enabled = true;
			}
			if (!this.checkBox_更新间隔.Checked)
			{
				this.numbox_间隔时间.Enabled = false;
			}
			string value22 = inihelp.GetValue("更新", "间隔时间");
			this.numbox_间隔时间.Value = Convert.ToInt32(value22);
			if (value5 == "发生错误")
			{
				this.numbox_间隔时间.Value = 24m;
			}
			string value23 = inihelp.GetValue("截图音效", "粘贴板");
			if (value23 == "发生错误")
			{
				this.chbox_copy.Checked = false;
			}
			try
			{
				this.chbox_copy.Checked = Convert.ToBoolean(value23);
			}
			catch
			{
				this.chbox_copy.Checked = false;
			}
			string value24 = inihelp.GetValue("截图音效", "自动保存");
			if (value24 == "发生错误")
			{
				this.chbox_save.Checked = true;
			}
			try
			{
				this.chbox_save.Checked = Convert.ToBoolean(value24);
			}
			catch
			{
				this.chbox_save.Checked = true;
			}
			string value25 = inihelp.GetValue("截图音效", "音效路径");
			this.text_音效path.Text = value25;
			if (value25 == "发生错误")
			{
				this.text_音效path.Text = "Data\\screenshot.wav";
			}
			string value26 = inihelp.GetValue("取色器", "类型");
			if (value26 == "发生错误")
			{
				this.chbox_取色.Checked = false;
			}
			if (value26 == "RGB")
			{
				this.chbox_取色.Checked = false;
			}
			if (value26 == "HEX")
			{
				this.chbox_取色.Checked = true;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00016B34 File Offset: 0x00014D34
		private void Form1_Load(object sender, EventArgs e)
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FmMain));
			base.Icon = (Icon)componentResourceManager.GetObject("minico.Icon");
			NumericUpDown numericUpDown = this.numbox_记录;
			int[] array = new int[4];
			array[0] = 99;
			numericUpDown.Maximum = new decimal(array);
			NumericUpDown numericUpDown2 = this.numbox_记录;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			NumericUpDown numericUpDown3 = this.numbox_记录;
			int[] array3 = new int[4];
			array3[0] = 1;
			numericUpDown3.Value = new decimal(array3);
			NumericUpDown numericUpDown4 = this.numbox_间隔时间;
			int[] array4 = new int[4];
			array4[0] = 24;
			numericUpDown4.Maximum = new decimal(array4);
			NumericUpDown numericUpDown5 = this.numbox_间隔时间;
			int[] array5 = new int[4];
			array5[0] = 1;
			numericUpDown5.Minimum = new decimal(array5);
			NumericUpDown numericUpDown6 = this.numbox_间隔时间;
			int[] array6 = new int[4];
			array6[0] = 1;
			numericUpDown6.Value = new decimal(array6);
			this.tab_标签.Height = (int)(350.0 * (double)Program.factor);
			base.Height = this.tab_标签.Height + 50;
			this.readIniFile();
			this.chbox_代理服务器.CheckedChanged += this.chbox_代理服务器_CheckedChanged;
			this.更新Button_check.Click += this.更新Button_check_Click;
			this.label_更新日期.Text = "更新时间：" + StaticValue.v_date;
			this.label_版本号.Text = "当前版本：" + StaticValue.current_v;
			this.txt_更新说明.Text = (string)componentResourceManager.GetObject("更新说明");
			this.txt_更新说明.ReadOnly = true;
			this.txt_更新说明.WordWrap = true;
			this.txt_更新说明.ScrollBars = ScrollBars.Vertical;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002BEB File Offset: 0x00000DEB
		private void 百度申请_Click(object sender, EventArgs e)
		{
			Process.Start("https://console.bce.baidu.com/ai/");
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000AE00 File Offset: 0x00009000
		public static string Get_html(string url)
		{
			string result = "";
			HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			try
			{
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8))
					{
						result = streamReader.ReadToEnd();
						streamReader.Close();
						httpWebResponse.Close();
					}
				}
				httpWebRequest.Abort();
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00016CF4 File Offset: 0x00014EF4
		private void tab_标签_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.tab_标签.SelectedTab == this.page_常规)
			{
				this.tab_标签.Height = (int)(350.0 * (double)Program.factor);
				base.Height = this.tab_标签.Height + 50;
			}
			if (this.tab_标签.SelectedTab == this.Page_快捷键)
			{
				this.tab_标签.Height = (int)(225.0 * (double)Program.factor);
				base.Height = this.tab_标签.Height + 50;
			}
			if (this.tab_标签.SelectedTab == this.Page_密钥)
			{
				this.tab_标签.Height = (int)(190.0 * (double)Program.factor);
				base.Height = this.tab_标签.Height + 50;
			}
			if (this.tab_标签.SelectedTab == this.Page_代理)
			{
				this.tab_标签.Height = (int)(245.0 * (double)Program.factor);
				base.Height = this.tab_标签.Height + 50;
			}
			if (this.tab_标签.SelectedTab == this.Page_更新)
			{
				this.tab_标签.Height = (int)(135.0 * (double)Program.factor);
				base.Height = this.tab_标签.Height + 50;
			}
			if (this.tab_标签.SelectedTab == this.Page_关于)
			{
				this.tab_标签.Height = (int)(340.0 * (double)Program.factor);
				base.Height = this.tab_标签.Height + 50;
			}
			if (this.tab_标签.SelectedTab == this.Page_赞助)
			{
				this.tab_标签.Height = (int)(225.0 * (double)Program.factor);
				base.Height = this.tab_标签.Height + 50;
			}
			if (this.tab_标签.SelectedTab == this.Page_反馈)
			{
				this.tab_标签.Height = (int)(200.0 * (double)Program.factor);
				base.Height = this.tab_标签.Height + 50;
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002BF8 File Offset: 0x00000DF8
		private void pic_help_Click(object sender, EventArgs e)
		{
			new FmHelp().Show();
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002C04 File Offset: 0x00000E04
		private void cbBox_开机_CheckedChanged(object sender, EventArgs e)
		{
			FmSetting.AutoStart(this.cbBox_开机.Checked);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000207C File Offset: 0x0000027C
		private void cbBox_翻译_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000207C File Offset: 0x0000027C
		private void cbBox_弹窗_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000207C File Offset: 0x0000027C
		private void cobBox_动画_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000207C File Offset: 0x0000027C
		private void numbox_记录_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00016F2C File Offset: 0x0001512C
		private void cbBox_保存_CheckedChanged(object sender, EventArgs e)
		{
			if (this.cbBox_保存.Checked)
			{
				this.textBox_path.Enabled = true;
				this.btn_浏览.Enabled = true;
			}
			if (!this.cbBox_保存.Checked)
			{
				this.textBox_path.Enabled = false;
				this.btn_浏览.Enabled = false;
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00016F88 File Offset: 0x00015188
		private void btn_浏览_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				this.textBox_path.Text = folderBrowserDialog.SelectedPath;
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002C16 File Offset: 0x00000E16
		private void 密钥Button_Click(object sender, EventArgs e)
		{
			this.text_baiduaccount.Text = "YsZKG1wha34PlDOPYaIrIIKO";
			this.text_baidupassword.Text = "HPRZtdOHrdnnETVsZM2Nx7vbDkMfxrkD";
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000207C File Offset: 0x0000027C
		private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00016FB8 File Offset: 0x000151B8
		private void 常规Button_Click(object sender, EventArgs e)
		{
			this.cbBox_开机.Checked = true;
			this.cbBox_翻译.Checked = true;
			this.cbBox_弹窗.Checked = true;
			this.cobBox_动画.SelectedIndex = 0;
			this.numbox_记录.Value = 20m;
			this.cbBox_保存.Checked = true;
			this.textBox_path.Enabled = true;
			this.textBox_path.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			this.btn_浏览.Enabled = true;
			this.chbox_save.Checked = true;
			this.text_音效path.Text = "Data\\screenshot.wav";
			this.chbox_copy.Checked = false;
			this.chbox_取色.Checked = false;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00017074 File Offset: 0x00015274
		private void txtBox_KeyUp(object sender, KeyEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			Regex regex = new Regex("[一-龥]+");
			string str = "";
			foreach (object obj in regex.Matches(textBox.Name))
			{
				str = ((Match)obj).ToString();
			}
			string key = "pictureBox_" + str;
			PictureBox pictureBox = (PictureBox)base.Controls.Find(key, true)[0];
			new ComponentResourceManager(typeof(FmSetting));
			if (e.KeyData == Keys.Back)
			{
				textBox.Text = "请按下快捷键";
				pictureBox.Image = Resources.快捷键_0;
				if (textBox.Name.Contains("文字识别"))
				{
					inihelp.SetValue("快捷键", "文字识别", this.txtBox_文字识别.Text);
				}
				if (textBox.Name.Contains("翻译文本"))
				{
					inihelp.SetValue("快捷键", "翻译文本", this.txtBox_翻译文本.Text);
				}
				if (textBox.Name.Contains("记录界面"))
				{
					inihelp.SetValue("快捷键", "记录界面", this.txtBox_记录界面.Text);
				}
				if (textBox.Name.Contains("识别界面"))
				{
					inihelp.SetValue("快捷键", "识别界面", this.txtBox_识别界面.Text);
					return;
				}
			}
			else if (e.KeyValue != 16 && e.KeyValue != 17 && e.KeyValue != 18)
			{
				string[] array = e.KeyData.ToString().Replace(" ", "").Replace("Control", "Ctrl").Split(new char[]
				{
					','
				});
				pictureBox.Image = Resources.快捷键_1;
				if (array.Length == 1)
				{
					textBox.Text = array[0];
				}
				if (array.Length == 2)
				{
					textBox.Text = array[1] + "+" + array[0];
				}
				if (array.Length <= 2)
				{
					if (textBox.Name.Contains("文字识别"))
					{
						inihelp.SetValue("快捷键", "文字识别", this.txtBox_文字识别.Text);
					}
					if (textBox.Name.Contains("翻译文本"))
					{
						inihelp.SetValue("快捷键", "翻译文本", this.txtBox_翻译文本.Text);
					}
					if (textBox.Name.Contains("记录界面"))
					{
						inihelp.SetValue("快捷键", "记录界面", this.txtBox_记录界面.Text);
					}
					if (textBox.Name.Contains("识别界面"))
					{
						inihelp.SetValue("快捷键", "识别界面", this.txtBox_识别界面.Text);
					}
				}
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00017360 File Offset: 0x00015560
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			return (keyData == Keys.Tab && this.txtBox_文字识别.Focused) || (keyData == Keys.Tab && this.txtBox_翻译文本.Focused) || (keyData == Keys.Tab && this.txtBox_记录界面.Focused) || (keyData == Keys.Tab && this.txtBox_识别界面.Focused);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002C38 File Offset: 0x00000E38
		private void txtBox_KeyDown(object sender, KeyEventArgs e)
		{
			e.SuppressKeyPress = true;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000173B8 File Offset: 0x000155B8
		private void 快捷键Button_Click(object sender, EventArgs e)
		{
			new ComponentResourceManager(typeof(FmSetting));
			this.txtBox_文字识别.Text = "F4";
			this.pictureBox_文字识别.Image = Resources.快捷键_1;
			this.txtBox_翻译文本.Text = "F9";
			this.pictureBox_翻译文本.Image = Resources.快捷键_1;
			this.txtBox_记录界面.Text = "请按下快捷键";
			this.pictureBox_记录界面.Image = Resources.快捷键_0;
			this.txtBox_识别界面.Text = "请按下快捷键";
			this.pictureBox_识别界面.Image = Resources.快捷键_0;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00017458 File Offset: 0x00015658
		private void 百度_btn_Click(object sender, EventArgs e)
		{
			if (FmSetting.Get_html(string.Format("{0}?{1}", "https://aip.baidubce.com/oauth/2.0/token", "grant_type=client_credentials&client_id=" + this.text_baiduaccount.Text + "&client_secret=" + this.text_baidupassword.Text)) != "")
			{
				MessageBox.Show("密钥正确!", "提醒");
				return;
			}
			MessageBox.Show("请确保密钥正确!", "提醒");
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000174CC File Offset: 0x000156CC
		private void combox_代理_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.combox_代理.Text == "不使用代理" || this.combox_代理.Text == "系统代理")
			{
				this.text_账号.Enabled = false;
				this.text_密码.Enabled = false;
				this.chbox_代理服务器.Enabled = false;
				this.text_端口.Enabled = false;
				this.chbox_代理服务器.Checked = false;
				this.text_服务器.Enabled = false;
				this.text_服务器.Text = "";
				this.text_端口.Text = "";
				this.text_服务器.Text = "";
				this.text_账号.Text = "";
				this.text_密码.Text = "";
			}
			if (this.combox_代理.Text == "自定义代理")
			{
				this.text_端口.Enabled = true;
				this.text_服务器.Enabled = true;
				this.chbox_代理服务器.Enabled = true;
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000207C File Offset: 0x0000027C
		private void text_端口_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000207C File Offset: 0x0000027C
		private void text_baiduaccount_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000207C File Offset: 0x0000027C
		private void text_baidupassword_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000207C File Offset: 0x0000027C
		private void text_服务器_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000207C File Offset: 0x0000027C
		private void text_端口_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000175E0 File Offset: 0x000157E0
		private void chbox_代理服务器_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chbox_代理服务器.Checked)
			{
				this.text_账号.Enabled = true;
				this.text_密码.Enabled = true;
			}
			if (!this.chbox_代理服务器.Checked)
			{
				this.text_账号.Enabled = false;
				this.text_密码.Enabled = false;
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000207C File Offset: 0x0000027C
		private void text_账号_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000207C File Offset: 0x0000027C
		private void text_密码_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0001763C File Offset: 0x0001583C
		private void 代理Button_Click(object sender, EventArgs e)
		{
			this.combox_代理.Text = "系统代理";
			this.text_账号.Enabled = false;
			this.text_密码.Enabled = false;
			this.chbox_代理服务器.Enabled = false;
			this.text_端口.Enabled = false;
			this.text_服务器.Enabled = false;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00017698 File Offset: 0x00015898
		private void check_检查更新_CheckedChanged(object sender, EventArgs e)
		{
			if (this.check_检查更新.Checked)
			{
				this.checkBox_更新间隔.Enabled = true;
				this.checkBox_更新间隔.Checked = true;
				this.numbox_间隔时间.Enabled = true;
			}
			if (!this.check_检查更新.Checked)
			{
				this.checkBox_更新间隔.Checked = false;
				this.checkBox_更新间隔.Enabled = false;
				this.numbox_间隔时间.Enabled = false;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002C41 File Offset: 0x00000E41
		private void checkBox_更新间隔_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox_更新间隔.Checked)
			{
				this.numbox_间隔时间.Enabled = true;
			}
			if (!this.checkBox_更新间隔.Checked)
			{
				this.numbox_间隔时间.Enabled = false;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000207C File Offset: 0x0000027C
		private void numbox_间隔时间_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002C78 File Offset: 0x00000E78
		private void 更新Button_Click(object sender, EventArgs e)
		{
			this.numbox_间隔时间.Value = 24m;
			this.check_检查更新.Checked = true;
			this.checkBox_更新间隔.Checked = true;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002CA4 File Offset: 0x00000EA4
		private void 更新Button_check_Click(object sender, EventArgs e)
		{
			new Thread(new ThreadStart(Program.check_update_cc)).Start();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002CBC File Offset: 0x00000EBC
		private void 反馈Button_Click(object sender, EventArgs e)
		{
			new Thread(new ThreadStart(this.反馈send)).Start();
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0001770C File Offset: 0x0001590C
		public string Post_Html(string url, string post_str)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(post_str);
			string result = "";
			HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.Method = "POST";
			httpWebRequest.Timeout = 6000;
			httpWebRequest.Proxy = null;
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			try
			{
				using (Stream requestStream = httpWebRequest.GetRequestStream())
				{
					requestStream.Write(bytes, 0, bytes.Length);
				}
				Stream responseStream = ((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
				result = streamReader.ReadToEnd();
				responseStream.Close();
				streamReader.Close();
				httpWebRequest.Abort();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000177DC File Offset: 0x000159DC
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			inihelp.SetValue("配置", "开机自启", this.cbBox_开机.Checked.ToString());
			inihelp.SetValue("配置", "快速翻译", this.cbBox_翻译.Checked.ToString());
			inihelp.SetValue("配置", "识别弹窗", this.cbBox_弹窗.Checked.ToString());
			inihelp.SetValue("配置", "窗体动画", this.cobBox_动画.Text);
			inihelp.SetValue("配置", "记录数目", this.numbox_记录.Text);
			inihelp.SetValue("配置", "自动保存", this.cbBox_保存.Checked.ToString());
			inihelp.SetValue("配置", "截图位置", this.textBox_path.Text);
			inihelp.SetValue("快捷键", "文字识别", this.txtBox_文字识别.Text);
			inihelp.SetValue("快捷键", "翻译文本", this.txtBox_翻译文本.Text);
			inihelp.SetValue("快捷键", "记录界面", this.txtBox_记录界面.Text);
			inihelp.SetValue("快捷键", "识别界面", this.txtBox_识别界面.Text);
			inihelp.SetValue("密钥_百度", "secret_id", this.text_baiduaccount.Text);
			inihelp.SetValue("密钥_百度", "secret_key", this.text_baidupassword.Text);
			inihelp.SetValue("代理", "代理类型", this.combox_代理.Text);
			inihelp.SetValue("代理", "服务器", this.text_服务器.Text);
			inihelp.SetValue("代理", "端口", this.text_端口.Text);
			inihelp.SetValue("代理", "需要密码", this.chbox_代理服务器.Checked.ToString());
			inihelp.SetValue("代理", "服务器账号", this.text_账号.Text);
			inihelp.SetValue("代理", "服务器密码", this.text_密码.Text);
			inihelp.SetValue("更新", "检测更新", this.check_检查更新.Checked.ToString());
			inihelp.SetValue("更新", "更新间隔", this.checkBox_更新间隔.Checked.ToString());
			inihelp.SetValue("更新", "间隔时间", this.numbox_间隔时间.Value.ToString());
			inihelp.SetValue("截图音效", "自动保存", this.chbox_save.Checked.ToString());
			inihelp.SetValue("截图音效", "音效路径", this.text_音效path.Text);
			inihelp.SetValue("截图音效", "粘贴板", this.chbox_copy.Checked.ToString());
			if (!this.chbox_取色.Checked)
			{
				inihelp.SetValue("取色器", "类型", "RGB");
			}
			if (this.chbox_取色.Checked)
			{
				inihelp.SetValue("取色器", "类型", "HEX");
			}
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00017B2C File Offset: 0x00015D2C
		public static void AutoStart(bool isAuto)
		{
			try
			{
				string value = Application.ExecutablePath.Replace("/", "\\");
				if (isAuto)
				{
					RegistryKey currentUser = Registry.CurrentUser;
					RegistryKey registryKey = currentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
					registryKey.SetValue("tianruoOCR", value);
					registryKey.Close();
					currentUser.Close();
				}
				else
				{
					RegistryKey currentUser2 = Registry.CurrentUser;
					RegistryKey registryKey2 = currentUser2.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
					registryKey2.DeleteValue("tianruoOCR", false);
					registryKey2.Close();
					currentUser2.Close();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("您需要管理员权限修改", "提示");
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00017BC4 File Offset: 0x00015DC4
		private void 反馈send()
		{
			if (this.txt_问题反馈.Text != "")
			{
				string str = "sm=%E5%A4%A9%E8%8B%A5OCR%E6%96%87%E5%AD%97%E8%AF%86%E5%88%AB" + StaticValue.current_v + "&nr=";
				this.Post_Html("http://cd.ys168.com/f_ht/ajcx/lyd.aspx?cz=lytj&pdgk=1&pdgly=0&pdzd=0&tou=1&yzm=undefined&_dlmc=tianruoyouxin&_dlmm=", str + HttpUtility.UrlEncode(this.txt_问题反馈.Text));
				this.txt_问题反馈.Text = "";
				Fmflags fmflags = new Fmflags();
				fmflags.Show();
				fmflags.DrawStr("感谢您的反馈！");
				return;
			}
			Fmflags fmflags2 = new Fmflags();
			fmflags2.Show();
			fmflags2.DrawStr("反馈文本不能为空");
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000A978 File Offset: 0x00008B78
		public void PlaySong(string file)
		{
			HelpWin32.mciSendString("close media", null, 0, IntPtr.Zero);
			HelpWin32.mciSendString("open \"" + file + "\" type mpegvideo alias media", null, 0, IntPtr.Zero);
			HelpWin32.mciSendString("play media notify", null, 0, base.Handle);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002CD4 File Offset: 0x00000ED4
		private void btn_音效_Click(object sender, EventArgs e)
		{
			this.PlaySong(this.text_音效path.Text);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00017C5C File Offset: 0x00015E5C
		private void btn_音效路径_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "请选择音效文件";
			openFileDialog.Filter = "All files（*.*）|*.*|All files(*.*)|*.* ";
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.text_音效path.Text = Path.GetFullPath(openFileDialog.FileName);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000207C File Offset: 0x0000027C
		private void chbox_copy_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000207C File Offset: 0x0000027C
		private void chbox_save_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000207C File Offset: 0x0000027C
		private void chbox_取色_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x17000019 RID: 25
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002CE7 File Offset: 0x00000EE7
		public string Start_set
		{
			set
			{
				this.tab_标签.SelectedIndex = 5;
			}
		}
	}
}
