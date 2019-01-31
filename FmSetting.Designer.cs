namespace 天若OCR文字识别
{
	// Token: 0x02000016 RID: 22
	public partial class FmSetting : global::System.Windows.Forms.Form
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00002CF5 File Offset: 0x00000EF5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00017CB0 File Offset: 0x00015EB0
		private void InitializeComponent()
		{
			this.Page_代理 = new global::System.Windows.Forms.TabPage();
			this.代理Button = new global::System.Windows.Forms.Button();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.chbox_代理服务器 = new global::System.Windows.Forms.CheckBox();
			this.text_密码 = new global::System.Windows.Forms.TextBox();
			this.text_端口 = new global::System.Windows.Forms.TextBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.text_账号 = new global::System.Windows.Forms.TextBox();
			this.text_服务器 = new global::System.Windows.Forms.TextBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.combox_代理 = new global::System.Windows.Forms.ComboBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.Page_密钥 = new global::System.Windows.Forms.TabPage();
			this.百度_btn = new global::System.Windows.Forms.Button();
			this.密钥Button_apply = new global::System.Windows.Forms.Button();
			this.密钥Button = new global::System.Windows.Forms.Button();
			this.tabControl2 = new global::System.Windows.Forms.TabControl();
			this.inPage_百度接口 = new global::System.Windows.Forms.TabPage();
			this.text_baidupassword = new global::System.Windows.Forms.TextBox();
			this.text_baiduaccount = new global::System.Windows.Forms.TextBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.Page_快捷键 = new global::System.Windows.Forms.TabPage();
			this.快捷键Button = new global::System.Windows.Forms.Button();
			this.label8 = new global::System.Windows.Forms.Label();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.pictureBox_识别界面 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox_记录界面 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox_翻译文本 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox_文字识别 = new global::System.Windows.Forms.PictureBox();
			this.txtBox_识别界面 = new global::System.Windows.Forms.TextBox();
			this.txtBox_记录界面 = new global::System.Windows.Forms.TextBox();
			this.txtBox_翻译文本 = new global::System.Windows.Forms.TextBox();
			this.txtBox_文字识别 = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.page_常规 = new global::System.Windows.Forms.TabPage();
			this.groupBox10 = new global::System.Windows.Forms.GroupBox();
			this.chbox_save = new global::System.Windows.Forms.CheckBox();
			this.chbox_copy = new global::System.Windows.Forms.CheckBox();
			this.label20 = new global::System.Windows.Forms.Label();
			this.btn_音效路径 = new global::System.Windows.Forms.Button();
			this.btn_音效 = new global::System.Windows.Forms.Button();
			this.text_音效path = new global::System.Windows.Forms.TextBox();
			this.label18 = new global::System.Windows.Forms.Label();
			this.groupBox6 = new global::System.Windows.Forms.GroupBox();
			this.btn_浏览 = new global::System.Windows.Forms.Button();
			this.textBox_path = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.cbBox_保存 = new global::System.Windows.Forms.CheckBox();
			this.pic_help = new global::System.Windows.Forms.PictureBox();
			this.常规Button = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.numbox_记录 = new global::System.Windows.Forms.NumericUpDown();
			this.label3 = new global::System.Windows.Forms.Label();
			this.cobBox_动画 = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chbox_取色 = new global::System.Windows.Forms.CheckBox();
			this.cbBox_弹窗 = new global::System.Windows.Forms.CheckBox();
			this.cbBox_翻译 = new global::System.Windows.Forms.CheckBox();
			this.cbBox_开机 = new global::System.Windows.Forms.CheckBox();
			this.tab_标签 = new global::System.Windows.Forms.TabControl();
			this.Page_更新 = new global::System.Windows.Forms.TabPage();
			this.更新Button_check = new global::System.Windows.Forms.Button();
			this.更新Button = new global::System.Windows.Forms.Button();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.label16 = new global::System.Windows.Forms.Label();
			this.numbox_间隔时间 = new global::System.Windows.Forms.NumericUpDown();
			this.checkBox_更新间隔 = new global::System.Windows.Forms.CheckBox();
			this.check_检查更新 = new global::System.Windows.Forms.CheckBox();
			this.Page_关于 = new global::System.Windows.Forms.TabPage();
			this.groupBox9 = new global::System.Windows.Forms.GroupBox();
			this.txt_更新说明 = new global::System.Windows.Forms.TextBox();
			this.groupBox7 = new global::System.Windows.Forms.GroupBox();
			this.pictureBox6 = new global::System.Windows.Forms.PictureBox();
			this.groupBox8 = new global::System.Windows.Forms.GroupBox();
			this.label_更新日期 = new global::System.Windows.Forms.Label();
			this.label_版本号 = new global::System.Windows.Forms.Label();
			this.label19 = new global::System.Windows.Forms.Label();
			this.label17 = new global::System.Windows.Forms.Label();
			this.Page_赞助 = new global::System.Windows.Forms.TabPage();
			this.pictureBox7 = new global::System.Windows.Forms.PictureBox();
			this.Page_反馈 = new global::System.Windows.Forms.TabPage();
			this.label21 = new global::System.Windows.Forms.Label();
			this.反馈Button = new global::System.Windows.Forms.Button();
			this.txt_问题反馈 = new global::System.Windows.Forms.TextBox();
			this.Page_代理.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.Page_密钥.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.inPage_百度接口.SuspendLayout();
			this.Page_快捷键.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_识别界面).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_记录界面).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_翻译文本).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_文字识别).BeginInit();
			this.page_常规.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pic_help).BeginInit();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numbox_记录).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tab_标签.SuspendLayout();
			this.Page_更新.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numbox_间隔时间).BeginInit();
			this.Page_关于.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox7.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox6).BeginInit();
			this.groupBox8.SuspendLayout();
			this.Page_赞助.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox7).BeginInit();
			this.Page_反馈.SuspendLayout();
			base.SuspendLayout();
			this.Page_代理.BackColor = global::System.Drawing.Color.White;
			this.Page_代理.Controls.Add(this.代理Button);
			this.Page_代理.Controls.Add(this.groupBox4);
			this.Page_代理.Location = new global::System.Drawing.Point(4, 22);
			this.Page_代理.Name = "Page_代理";
			this.Page_代理.Padding = new global::System.Windows.Forms.Padding(3);
			this.Page_代理.Size = new global::System.Drawing.Size(390, 329);
			this.Page_代理.TabIndex = 4;
			this.Page_代理.Text = "代理";
			this.代理Button.BackColor = global::System.Drawing.Color.White;
			this.代理Button.Location = new global::System.Drawing.Point(309, 193);
			this.代理Button.Name = "代理Button";
			this.代理Button.Size = new global::System.Drawing.Size(75, 23);
			this.代理Button.TabIndex = 9;
			this.代理Button.Text = "恢复默认";
			this.代理Button.UseVisualStyleBackColor = false;
			this.代理Button.Click += new global::System.EventHandler(this.代理Button_Click);
			this.groupBox4.Controls.Add(this.chbox_代理服务器);
			this.groupBox4.Controls.Add(this.text_密码);
			this.groupBox4.Controls.Add(this.text_端口);
			this.groupBox4.Controls.Add(this.label15);
			this.groupBox4.Controls.Add(this.text_账号);
			this.groupBox4.Controls.Add(this.text_服务器);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.combox_代理);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Location = new global::System.Drawing.Point(3, 6);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(381, 183);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "代理";
			this.chbox_代理服务器.AutoSize = true;
			this.chbox_代理服务器.Location = new global::System.Drawing.Point(78, 84);
			this.chbox_代理服务器.Name = "chbox_代理服务器";
			this.chbox_代理服务器.Size = new global::System.Drawing.Size(132, 16);
			this.chbox_代理服务器.TabIndex = 12;
			this.chbox_代理服务器.Text = "代理服务器需要密码";
			this.chbox_代理服务器.UseVisualStyleBackColor = true;
			this.text_密码.Location = new global::System.Drawing.Point(78, 144);
			this.text_密码.Name = "text_密码";
			this.text_密码.Size = new global::System.Drawing.Size(128, 21);
			this.text_密码.TabIndex = 11;
			this.text_密码.TextChanged += new global::System.EventHandler(this.text_密码_TextChanged);
			this.text_端口.Location = new global::System.Drawing.Point(248, 52);
			this.text_端口.Name = "text_端口";
			this.text_端口.Size = new global::System.Drawing.Size(55, 21);
			this.text_端口.TabIndex = 10;
			this.text_端口.Text = " ";
			this.text_端口.TextChanged += new global::System.EventHandler(this.text_端口_TextChanged);
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(212, 57);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(41, 12);
			this.label15.TabIndex = 9;
			this.label15.Text = "端口：";
			this.text_账号.Location = new global::System.Drawing.Point(78, 110);
			this.text_账号.Name = "text_账号";
			this.text_账号.Size = new global::System.Drawing.Size(128, 21);
			this.text_账号.TabIndex = 8;
			this.text_账号.TextChanged += new global::System.EventHandler(this.text_账号_TextChanged);
			this.text_服务器.Location = new global::System.Drawing.Point(78, 52);
			this.text_服务器.Name = "text_服务器";
			this.text_服务器.Size = new global::System.Drawing.Size(128, 21);
			this.text_服务器.TabIndex = 7;
			this.text_服务器.TextChanged += new global::System.EventHandler(this.text_服务器_TextChanged);
			this.label14.AutoSize = true;
			this.label14.Location = new global::System.Drawing.Point(9, 147);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(41, 12);
			this.label14.TabIndex = 6;
			this.label14.Text = "密码：";
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(9, 114);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(53, 12);
			this.label13.TabIndex = 5;
			this.label13.Text = "用户名：";
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(9, 57);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(53, 12);
			this.label12.TabIndex = 4;
			this.label12.Text = "服务器：";
			this.combox_代理.BackColor = global::System.Drawing.Color.White;
			this.combox_代理.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combox_代理.FormattingEnabled = true;
			this.combox_代理.Items.AddRange(new object[]
			{
				"不使用代理",
				"系统代理",
				"自定义代理"
			});
			this.combox_代理.Location = new global::System.Drawing.Point(78, 18);
			this.combox_代理.Name = "combox_代理";
			this.combox_代理.Size = new global::System.Drawing.Size(95, 20);
			this.combox_代理.TabIndex = 3;
			this.combox_代理.SelectedIndexChanged += new global::System.EventHandler(this.combox_代理_SelectedIndexChanged);
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(7, 22);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(65, 12);
			this.label11.TabIndex = 0;
			this.label11.Text = "代理类型：";
			this.Page_密钥.BackColor = global::System.Drawing.Color.White;
			this.Page_密钥.Controls.Add(this.百度_btn);
			this.Page_密钥.Controls.Add(this.密钥Button_apply);
			this.Page_密钥.Controls.Add(this.密钥Button);
			this.Page_密钥.Controls.Add(this.tabControl2);
			this.Page_密钥.Location = new global::System.Drawing.Point(4, 22);
			this.Page_密钥.Name = "Page_密钥";
			this.Page_密钥.Padding = new global::System.Windows.Forms.Padding(3);
			this.Page_密钥.Size = new global::System.Drawing.Size(390, 329);
			this.Page_密钥.TabIndex = 3;
			this.Page_密钥.Text = "密钥";
			this.百度_btn.BackColor = global::System.Drawing.Color.White;
			this.百度_btn.Location = new global::System.Drawing.Point(152, 136);
			this.百度_btn.Name = "百度_btn";
			this.百度_btn.Size = new global::System.Drawing.Size(75, 23);
			this.百度_btn.TabIndex = 10;
			this.百度_btn.Text = "密钥测试";
			this.百度_btn.UseVisualStyleBackColor = false;
			this.百度_btn.Click += new global::System.EventHandler(this.百度_btn_Click);
			this.密钥Button_apply.BackColor = global::System.Drawing.Color.White;
			this.密钥Button_apply.Location = new global::System.Drawing.Point(6, 136);
			this.密钥Button_apply.Name = "密钥Button_apply";
			this.密钥Button_apply.Size = new global::System.Drawing.Size(75, 23);
			this.密钥Button_apply.TabIndex = 9;
			this.密钥Button_apply.Text = "接口申请";
			this.密钥Button_apply.UseVisualStyleBackColor = false;
			this.密钥Button_apply.Click += new global::System.EventHandler(this.百度申请_Click);
			this.密钥Button.BackColor = global::System.Drawing.Color.White;
			this.密钥Button.Location = new global::System.Drawing.Point(309, 136);
			this.密钥Button.Name = "密钥Button";
			this.密钥Button.Size = new global::System.Drawing.Size(75, 23);
			this.密钥Button.TabIndex = 8;
			this.密钥Button.Text = "恢复默认";
			this.密钥Button.UseVisualStyleBackColor = false;
			this.密钥Button.Click += new global::System.EventHandler(this.密钥Button_Click);
			this.tabControl2.Controls.Add(this.inPage_百度接口);
			this.tabControl2.Location = new global::System.Drawing.Point(6, 6);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new global::System.Drawing.Size(378, 124);
			this.tabControl2.TabIndex = 0;
			this.inPage_百度接口.BackColor = global::System.Drawing.Color.White;
			this.inPage_百度接口.Controls.Add(this.text_baidupassword);
			this.inPage_百度接口.Controls.Add(this.text_baiduaccount);
			this.inPage_百度接口.Controls.Add(this.label10);
			this.inPage_百度接口.Controls.Add(this.label9);
			this.inPage_百度接口.Location = new global::System.Drawing.Point(4, 22);
			this.inPage_百度接口.Name = "inPage_百度接口";
			this.inPage_百度接口.Padding = new global::System.Windows.Forms.Padding(3);
			this.inPage_百度接口.Size = new global::System.Drawing.Size(370, 98);
			this.inPage_百度接口.TabIndex = 0;
			this.inPage_百度接口.Text = "百度识别接口";
			this.text_baidupassword.BackColor = global::System.Drawing.Color.White;
			this.text_baidupassword.Location = new global::System.Drawing.Point(56, 55);
			this.text_baidupassword.Name = "text_baidupassword";
			this.text_baidupassword.Size = new global::System.Drawing.Size(260, 21);
			this.text_baidupassword.TabIndex = 3;
			this.text_baidupassword.TextChanged += new global::System.EventHandler(this.text_baidupassword_TextChanged);
			this.text_baiduaccount.BackColor = global::System.Drawing.Color.White;
			this.text_baiduaccount.Location = new global::System.Drawing.Point(56, 20);
			this.text_baiduaccount.Name = "text_baiduaccount";
			this.text_baiduaccount.Size = new global::System.Drawing.Size(260, 21);
			this.text_baiduaccount.TabIndex = 2;
			this.text_baiduaccount.TextChanged += new global::System.EventHandler(this.text_baiduaccount_TextChanged);
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(18, 58);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(41, 12);
			this.label10.TabIndex = 1;
			this.label10.Text = "密码：";
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(18, 23);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(41, 12);
			this.label9.TabIndex = 0;
			this.label9.Text = "账号：";
			this.Page_快捷键.BackColor = global::System.Drawing.Color.White;
			this.Page_快捷键.Controls.Add(this.快捷键Button);
			this.Page_快捷键.Controls.Add(this.label8);
			this.Page_快捷键.Controls.Add(this.groupBox3);
			this.Page_快捷键.Location = new global::System.Drawing.Point(4, 22);
			this.Page_快捷键.Name = "Page_快捷键";
			this.Page_快捷键.Padding = new global::System.Windows.Forms.Padding(3);
			this.Page_快捷键.Size = new global::System.Drawing.Size(390, 329);
			this.Page_快捷键.TabIndex = 2;
			this.Page_快捷键.Text = "快捷键";
			this.快捷键Button.BackColor = global::System.Drawing.Color.White;
			this.快捷键Button.Location = new global::System.Drawing.Point(309, 175);
			this.快捷键Button.Name = "快捷键Button";
			this.快捷键Button.Size = new global::System.Drawing.Size(75, 23);
			this.快捷键Button.TabIndex = 7;
			this.快捷键Button.Text = "恢复默认";
			this.快捷键Button.UseVisualStyleBackColor = false;
			this.快捷键Button.Click += new global::System.EventHandler(this.快捷键Button_Click);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(6, 180);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(209, 12);
			this.label8.TabIndex = 1;
			this.label8.Text = "说明：按Backspace键可清除当前快捷键";
			this.groupBox3.Controls.Add(this.pictureBox_识别界面);
			this.groupBox3.Controls.Add(this.pictureBox_记录界面);
			this.groupBox3.Controls.Add(this.pictureBox_翻译文本);
			this.groupBox3.Controls.Add(this.pictureBox_文字识别);
			this.groupBox3.Controls.Add(this.txtBox_识别界面);
			this.groupBox3.Controls.Add(this.txtBox_记录界面);
			this.groupBox3.Controls.Add(this.txtBox_翻译文本);
			this.groupBox3.Controls.Add(this.txtBox_文字识别);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Location = new global::System.Drawing.Point(6, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(378, 163);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "全局快捷键";
			this.pictureBox_识别界面.Image = global::天若OCR文字识别.Properties.Resources.快捷键_1;
			this.pictureBox_识别界面.Location = new global::System.Drawing.Point(351, 122);
			this.pictureBox_识别界面.Name = "pictureBox_识别界面";
			this.pictureBox_识别界面.Size = new global::System.Drawing.Size(21, 21);
			this.pictureBox_识别界面.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox_识别界面.TabIndex = 11;
			this.pictureBox_识别界面.TabStop = false;
			this.pictureBox_记录界面.Image = global::天若OCR文字识别.Properties.Resources.快捷键_1;
			this.pictureBox_记录界面.Location = new global::System.Drawing.Point(351, 89);
			this.pictureBox_记录界面.Name = "pictureBox_记录界面";
			this.pictureBox_记录界面.Size = new global::System.Drawing.Size(21, 21);
			this.pictureBox_记录界面.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox_记录界面.TabIndex = 10;
			this.pictureBox_记录界面.TabStop = false;
			this.pictureBox_翻译文本.Image = global::天若OCR文字识别.Properties.Resources.快捷键_1;
			this.pictureBox_翻译文本.Location = new global::System.Drawing.Point(351, 52);
			this.pictureBox_翻译文本.Name = "pictureBox_翻译文本";
			this.pictureBox_翻译文本.Size = new global::System.Drawing.Size(21, 21);
			this.pictureBox_翻译文本.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox_翻译文本.TabIndex = 9;
			this.pictureBox_翻译文本.TabStop = false;
			this.pictureBox_文字识别.Image = global::天若OCR文字识别.Properties.Resources.快捷键_1;
			this.pictureBox_文字识别.Location = new global::System.Drawing.Point(351, 19);
			this.pictureBox_文字识别.Name = "pictureBox_文字识别";
			this.pictureBox_文字识别.Size = new global::System.Drawing.Size(21, 21);
			this.pictureBox_文字识别.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox_文字识别.TabIndex = 8;
			this.pictureBox_文字识别.TabStop = false;
			this.txtBox_识别界面.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.txtBox_识别界面.Location = new global::System.Drawing.Point(78, 122);
			this.txtBox_识别界面.Name = "txtBox_识别界面";
			this.txtBox_识别界面.Size = new global::System.Drawing.Size(260, 23);
			this.txtBox_识别界面.TabIndex = 7;
			this.txtBox_识别界面.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBox_识别界面.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
			this.txtBox_识别界面.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyUp);
			this.txtBox_记录界面.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.txtBox_记录界面.Location = new global::System.Drawing.Point(78, 89);
			this.txtBox_记录界面.Name = "txtBox_记录界面";
			this.txtBox_记录界面.Size = new global::System.Drawing.Size(260, 23);
			this.txtBox_记录界面.TabIndex = 6;
			this.txtBox_记录界面.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBox_记录界面.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
			this.txtBox_记录界面.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyUp);
			this.txtBox_翻译文本.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.txtBox_翻译文本.Location = new global::System.Drawing.Point(78, 52);
			this.txtBox_翻译文本.Name = "txtBox_翻译文本";
			this.txtBox_翻译文本.Size = new global::System.Drawing.Size(260, 23);
			this.txtBox_翻译文本.TabIndex = 5;
			this.txtBox_翻译文本.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBox_翻译文本.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
			this.txtBox_翻译文本.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyUp);
			this.txtBox_文字识别.Font = new global::System.Drawing.Font("微软雅黑", 9f);
			this.txtBox_文字识别.Location = new global::System.Drawing.Point(78, 19);
			this.txtBox_文字识别.Name = "txtBox_文字识别";
			this.txtBox_文字识别.Size = new global::System.Drawing.Size(260, 23);
			this.txtBox_文字识别.TabIndex = 4;
			this.txtBox_文字识别.TabStop = false;
			this.txtBox_文字识别.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.txtBox_文字识别.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
			this.txtBox_文字识别.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.txtBox_KeyUp);
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(6, 125);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(65, 12);
			this.label7.TabIndex = 3;
			this.label7.Text = "识别界面：";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(7, 92);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(65, 12);
			this.label6.TabIndex = 2;
			this.label6.Text = "记录界面：";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(6, 58);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(65, 12);
			this.label5.TabIndex = 1;
			this.label5.Text = "翻译文本：";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(7, 24);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(65, 12);
			this.label4.TabIndex = 0;
			this.label4.Text = "文字识别：";
			this.page_常规.BackColor = global::System.Drawing.Color.White;
			this.page_常规.Controls.Add(this.groupBox10);
			this.page_常规.Controls.Add(this.groupBox6);
			this.page_常规.Controls.Add(this.pic_help);
			this.page_常规.Controls.Add(this.常规Button);
			this.page_常规.Controls.Add(this.groupBox2);
			this.page_常规.Controls.Add(this.groupBox1);
			this.page_常规.Location = new global::System.Drawing.Point(4, 22);
			this.page_常规.Name = "page_常规";
			this.page_常规.Padding = new global::System.Windows.Forms.Padding(3);
			this.page_常规.Size = new global::System.Drawing.Size(390, 329);
			this.page_常规.TabIndex = 0;
			this.page_常规.Text = "常规";
			this.groupBox10.Controls.Add(this.chbox_save);
			this.groupBox10.Controls.Add(this.chbox_copy);
			this.groupBox10.Controls.Add(this.label20);
			this.groupBox10.Controls.Add(this.btn_音效路径);
			this.groupBox10.Controls.Add(this.btn_音效);
			this.groupBox10.Controls.Add(this.text_音效path);
			this.groupBox10.Controls.Add(this.label18);
			this.groupBox10.Location = new global::System.Drawing.Point(6, 136);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new global::System.Drawing.Size(378, 86);
			this.groupBox10.TabIndex = 8;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "音效";
			this.chbox_save.AutoSize = true;
			this.chbox_save.Checked = true;
			this.chbox_save.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chbox_save.Location = new global::System.Drawing.Point(167, 54);
			this.chbox_save.Name = "chbox_save";
			this.chbox_save.Size = new global::System.Drawing.Size(96, 16);
			this.chbox_save.TabIndex = 10;
			this.chbox_save.Text = "快速保存图片";
			this.chbox_save.UseVisualStyleBackColor = true;
			this.chbox_save.CheckedChanged += new global::System.EventHandler(this.chbox_save_CheckedChanged);
			this.chbox_copy.AutoSize = true;
			this.chbox_copy.Location = new global::System.Drawing.Point(53, 54);
			this.chbox_copy.Name = "chbox_copy";
			this.chbox_copy.Size = new global::System.Drawing.Size(96, 16);
			this.chbox_copy.TabIndex = 6;
			this.chbox_copy.Text = "复制到粘贴板";
			this.chbox_copy.UseVisualStyleBackColor = true;
			this.chbox_copy.CheckedChanged += new global::System.EventHandler(this.chbox_copy_CheckedChanged);
			this.label20.AutoSize = true;
			this.label20.Location = new global::System.Drawing.Point(14, 55);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(41, 12);
			this.label20.TabIndex = 9;
			this.label20.Text = "何时：";
			this.btn_音效路径.BackColor = global::System.Drawing.Color.White;
			this.btn_音效路径.Location = new global::System.Drawing.Point(332, 49);
			this.btn_音效路径.Name = "btn_音效路径";
			this.btn_音效路径.Size = new global::System.Drawing.Size(40, 23);
			this.btn_音效路径.TabIndex = 8;
			this.btn_音效路径.Text = "更改";
			this.btn_音效路径.UseVisualStyleBackColor = false;
			this.btn_音效路径.Click += new global::System.EventHandler(this.btn_音效路径_Click);
			this.btn_音效.BackColor = global::System.Drawing.Color.White;
			this.btn_音效.Image = global::天若OCR文字识别.Properties.Resources.语音按钮;
			this.btn_音效.Location = new global::System.Drawing.Point(344, 17);
			this.btn_音效.Name = "btn_音效";
			this.btn_音效.Size = new global::System.Drawing.Size(26, 23);
			this.btn_音效.TabIndex = 7;
			this.btn_音效.UseVisualStyleBackColor = false;
			this.btn_音效.Click += new global::System.EventHandler(this.btn_音效_Click);
			this.text_音效path.BackColor = global::System.Drawing.Color.White;
			this.text_音效path.Location = new global::System.Drawing.Point(51, 19);
			this.text_音效path.Name = "text_音效path";
			this.text_音效path.ReadOnly = true;
			this.text_音效path.Size = new global::System.Drawing.Size(288, 21);
			this.text_音效path.TabIndex = 4;
			this.text_音效path.Text = "Data\\screenshot.wav";
			this.label18.AutoSize = true;
			this.label18.Location = new global::System.Drawing.Point(13, 22);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(41, 12);
			this.label18.TabIndex = 3;
			this.label18.Text = "文件：";
			this.groupBox6.Controls.Add(this.btn_浏览);
			this.groupBox6.Controls.Add(this.textBox_path);
			this.groupBox6.Controls.Add(this.label1);
			this.groupBox6.Controls.Add(this.cbBox_保存);
			this.groupBox6.Location = new global::System.Drawing.Point(6, 227);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new global::System.Drawing.Size(378, 63);
			this.groupBox6.TabIndex = 6;
			this.groupBox6.TabStop = false;
			this.btn_浏览.BackColor = global::System.Drawing.Color.White;
			this.btn_浏览.Location = new global::System.Drawing.Point(332, 24);
			this.btn_浏览.Name = "btn_浏览";
			this.btn_浏览.Size = new global::System.Drawing.Size(40, 23);
			this.btn_浏览.TabIndex = 7;
			this.btn_浏览.Text = "浏览";
			this.btn_浏览.UseVisualStyleBackColor = false;
			this.btn_浏览.Click += new global::System.EventHandler(this.btn_浏览_Click);
			this.textBox_path.BackColor = global::System.Drawing.Color.White;
			this.textBox_path.Location = new global::System.Drawing.Point(51, 26);
			this.textBox_path.Name = "textBox_path";
			this.textBox_path.ReadOnly = true;
			this.textBox_path.Size = new global::System.Drawing.Size(275, 21);
			this.textBox_path.TabIndex = 4;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(15, 29);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(41, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "目录：";
			this.cbBox_保存.AutoSize = true;
			this.cbBox_保存.BackColor = global::System.Drawing.Color.White;
			this.cbBox_保存.Location = new global::System.Drawing.Point(6, 0);
			this.cbBox_保存.Name = "cbBox_保存";
			this.cbBox_保存.Size = new global::System.Drawing.Size(72, 16);
			this.cbBox_保存.TabIndex = 2;
			this.cbBox_保存.Text = "自动保存";
			this.cbBox_保存.UseVisualStyleBackColor = false;
			this.cbBox_保存.CheckedChanged += new global::System.EventHandler(this.cbBox_保存_CheckedChanged);
			this.pic_help.Image = global::天若OCR文字识别.Properties.Resources.帮助;
			this.pic_help.Location = new global::System.Drawing.Point(7, 296);
			this.pic_help.Name = "pic_help";
			this.pic_help.Size = new global::System.Drawing.Size(27, 23);
			this.pic_help.TabIndex = 7;
			this.pic_help.TabStop = false;
			this.pic_help.Click += new global::System.EventHandler(this.pic_help_Click);
			this.常规Button.BackColor = global::System.Drawing.Color.White;
			this.常规Button.Location = new global::System.Drawing.Point(310, 297);
			this.常规Button.Name = "常规Button";
			this.常规Button.Size = new global::System.Drawing.Size(75, 23);
			this.常规Button.TabIndex = 6;
			this.常规Button.Text = "恢复默认";
			this.常规Button.UseVisualStyleBackColor = false;
			this.常规Button.Click += new global::System.EventHandler(this.常规Button_Click);
			this.groupBox2.Controls.Add(this.numbox_记录);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.cobBox_动画);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new global::System.Drawing.Point(6, 60);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(378, 70);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "界面";
			this.numbox_记录.Location = new global::System.Drawing.Point(276, 28);
			this.numbox_记录.Name = "numbox_记录";
			this.numbox_记录.Size = new global::System.Drawing.Size(63, 21);
			this.numbox_记录.TabIndex = 5;
			this.numbox_记录.ValueChanged += new global::System.EventHandler(this.numbox_记录_ValueChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(205, 32);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(65, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "记录数目：";
			this.cobBox_动画.BackColor = global::System.Drawing.Color.White;
			this.cobBox_动画.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cobBox_动画.FormattingEnabled = true;
			this.cobBox_动画.Items.AddRange(new object[]
			{
				"窗体",
				"少女",
				"罗小黑"
			});
			this.cobBox_动画.Location = new global::System.Drawing.Point(84, 30);
			this.cobBox_动画.Name = "cobBox_动画";
			this.cobBox_动画.Size = new global::System.Drawing.Size(63, 20);
			this.cobBox_动画.TabIndex = 3;
			this.cobBox_动画.SelectedIndexChanged += new global::System.EventHandler(this.cobBox_动画_SelectedIndexChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(13, 33);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(65, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "窗体动画：";
			this.groupBox1.Controls.Add(this.chbox_取色);
			this.groupBox1.Controls.Add(this.cbBox_弹窗);
			this.groupBox1.Controls.Add(this.cbBox_翻译);
			this.groupBox1.Controls.Add(this.cbBox_开机);
			this.groupBox1.Location = new global::System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(378, 48);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "设置";
			this.chbox_取色.AutoSize = true;
			this.chbox_取色.Location = new global::System.Drawing.Point(298, 20);
			this.chbox_取色.Name = "chbox_取色";
			this.chbox_取色.Size = new global::System.Drawing.Size(66, 16);
			this.chbox_取色.TabIndex = 6;
			this.chbox_取色.Text = "取色HEX";
			this.chbox_取色.UseVisualStyleBackColor = true;
			this.chbox_取色.CheckedChanged += new global::System.EventHandler(this.chbox_取色_CheckedChanged);
			this.cbBox_弹窗.AutoSize = true;
			this.cbBox_弹窗.Location = new global::System.Drawing.Point(204, 20);
			this.cbBox_弹窗.Name = "cbBox_弹窗";
			this.cbBox_弹窗.Size = new global::System.Drawing.Size(72, 16);
			this.cbBox_弹窗.TabIndex = 5;
			this.cbBox_弹窗.Text = "识别弹窗";
			this.cbBox_弹窗.UseVisualStyleBackColor = true;
			this.cbBox_弹窗.CheckedChanged += new global::System.EventHandler(this.cbBox_弹窗_CheckedChanged);
			this.cbBox_翻译.AutoSize = true;
			this.cbBox_翻译.Location = new global::System.Drawing.Point(107, 20);
			this.cbBox_翻译.Name = "cbBox_翻译";
			this.cbBox_翻译.Size = new global::System.Drawing.Size(72, 16);
			this.cbBox_翻译.TabIndex = 4;
			this.cbBox_翻译.Text = "快速翻译";
			this.cbBox_翻译.UseVisualStyleBackColor = true;
			this.cbBox_翻译.CheckedChanged += new global::System.EventHandler(this.cbBox_翻译_CheckedChanged);
			this.cbBox_开机.AutoSize = true;
			this.cbBox_开机.Location = new global::System.Drawing.Point(17, 20);
			this.cbBox_开机.Name = "cbBox_开机";
			this.cbBox_开机.Size = new global::System.Drawing.Size(72, 16);
			this.cbBox_开机.TabIndex = 2;
			this.cbBox_开机.Text = "开机启动";
			this.cbBox_开机.UseVisualStyleBackColor = true;
			this.cbBox_开机.CheckedChanged += new global::System.EventHandler(this.cbBox_开机_CheckedChanged);
			this.tab_标签.Controls.Add(this.page_常规);
			this.tab_标签.Controls.Add(this.Page_快捷键);
			this.tab_标签.Controls.Add(this.Page_密钥);
			this.tab_标签.Controls.Add(this.Page_代理);
			this.tab_标签.Controls.Add(this.Page_更新);
			this.tab_标签.Controls.Add(this.Page_关于);
			this.tab_标签.Controls.Add(this.Page_赞助);
			this.tab_标签.Controls.Add(this.Page_反馈);
			this.tab_标签.Location = new global::System.Drawing.Point(10, 2);
			this.tab_标签.Name = "tab_标签";
			this.tab_标签.SelectedIndex = 0;
			this.tab_标签.Size = new global::System.Drawing.Size(398, 355);
			this.tab_标签.TabIndex = 0;
			this.tab_标签.SelectedIndexChanged += new global::System.EventHandler(this.tab_标签_SelectedIndexChanged);
			this.Page_更新.Controls.Add(this.更新Button_check);
			this.Page_更新.Controls.Add(this.更新Button);
			this.Page_更新.Controls.Add(this.groupBox5);
			this.Page_更新.Location = new global::System.Drawing.Point(4, 22);
			this.Page_更新.Name = "Page_更新";
			this.Page_更新.Padding = new global::System.Windows.Forms.Padding(3);
			this.Page_更新.Size = new global::System.Drawing.Size(390, 329);
			this.Page_更新.TabIndex = 5;
			this.Page_更新.Text = "更新";
			this.Page_更新.BackColor = global::System.Drawing.Color.White;
			this.Page_更新.UseVisualStyleBackColor = true;
			this.更新Button_check.BackColor = global::System.Drawing.Color.White;
			this.更新Button_check.Location = new global::System.Drawing.Point(6, 83);
			this.更新Button_check.Name = "更新Button_check";
			this.更新Button_check.Size = new global::System.Drawing.Size(75, 23);
			this.更新Button_check.TabIndex = 11;
			this.更新Button_check.Text = "检查更新";
			this.更新Button_check.UseVisualStyleBackColor = false;
			this.更新Button.BackColor = global::System.Drawing.Color.White;
			this.更新Button.Location = new global::System.Drawing.Point(309, 83);
			this.更新Button.Name = "更新Button";
			this.更新Button.Size = new global::System.Drawing.Size(75, 23);
			this.更新Button.TabIndex = 10;
			this.更新Button.Text = "恢复默认";
			this.更新Button.UseVisualStyleBackColor = false;
			this.更新Button.Click += new global::System.EventHandler(this.更新Button_Click);
			this.groupBox5.Controls.Add(this.label16);
			this.groupBox5.Controls.Add(this.numbox_间隔时间);
			this.groupBox5.Controls.Add(this.checkBox_更新间隔);
			this.groupBox5.Controls.Add(this.check_检查更新);
			this.groupBox5.Location = new global::System.Drawing.Point(6, 14);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new global::System.Drawing.Size(378, 65);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			this.label16.AutoSize = true;
			this.label16.Location = new global::System.Drawing.Point(98, 31);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(29, 12);
			this.label16.TabIndex = 3;
			this.label16.Text = "小时";
			this.numbox_间隔时间.Location = new global::System.Drawing.Point(54, 27);
			this.numbox_间隔时间.Name = "numbox_间隔时间";
			this.numbox_间隔时间.Size = new global::System.Drawing.Size(37, 21);
			this.numbox_间隔时间.TabIndex = 2;
			this.numbox_间隔时间.ValueChanged += new global::System.EventHandler(this.numbox_间隔时间_ValueChanged);
			this.checkBox_更新间隔.AutoSize = true;
			this.checkBox_更新间隔.Location = new global::System.Drawing.Point(6, 31);
			this.checkBox_更新间隔.Name = "checkBox_更新间隔";
			this.checkBox_更新间隔.Size = new global::System.Drawing.Size(48, 16);
			this.checkBox_更新间隔.TabIndex = 1;
			this.checkBox_更新间隔.Text = "每隔";
			this.checkBox_更新间隔.UseVisualStyleBackColor = true;
			this.checkBox_更新间隔.CheckedChanged += new global::System.EventHandler(this.checkBox_更新间隔_CheckedChanged);
			this.check_检查更新.AutoSize = true;
			this.check_检查更新.BackColor = global::System.Drawing.Color.White;
			this.check_检查更新.Location = new global::System.Drawing.Point(6, 0);
			this.check_检查更新.Name = "check_检查更新";
			this.check_检查更新.Size = new global::System.Drawing.Size(108, 16);
			this.check_检查更新.TabIndex = 0;
			this.check_检查更新.Text = "启动时检查更新";
			this.check_检查更新.UseVisualStyleBackColor = false;
			this.check_检查更新.CheckedChanged += new global::System.EventHandler(this.check_检查更新_CheckedChanged);
			this.Page_关于.BackColor = global::System.Drawing.Color.White;
			this.Page_关于.Controls.Add(this.groupBox9);
			this.Page_关于.Controls.Add(this.groupBox7);
			this.Page_关于.Controls.Add(this.label17);
			this.Page_关于.Location = new global::System.Drawing.Point(4, 22);
			this.Page_关于.Name = "Page_关于";
			this.Page_关于.Padding = new global::System.Windows.Forms.Padding(3);
			this.Page_关于.Size = new global::System.Drawing.Size(390, 329);
			this.Page_关于.TabIndex = 6;
			this.Page_关于.Text = "关于";
			this.groupBox9.Controls.Add(this.txt_更新说明);
			this.groupBox9.Location = new global::System.Drawing.Point(6, 122);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new global::System.Drawing.Size(378, 186);
			this.groupBox9.TabIndex = 5;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "更新说明";
			this.txt_更新说明.BackColor = global::System.Drawing.Color.White;
			this.txt_更新说明.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_更新说明.Location = new global::System.Drawing.Point(6, 20);
			this.txt_更新说明.Multiline = true;
			this.txt_更新说明.Name = "txt_更新说明";
			this.txt_更新说明.Size = new global::System.Drawing.Size(366, 155);
			this.txt_更新说明.TabIndex = 4;
			this.groupBox7.Controls.Add(this.pictureBox6);
			this.groupBox7.Controls.Add(this.groupBox8);
			this.groupBox7.Location = new global::System.Drawing.Point(6, 8);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new global::System.Drawing.Size(378, 108);
			this.groupBox7.TabIndex = 3;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "软件信息";
			this.pictureBox6.BackColor = global::System.Drawing.Color.White;
			this.pictureBox6.Image = global::天若OCR文字识别.Properties.Resources.头像;
			this.pictureBox6.Location = new global::System.Drawing.Point(12, 15);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new global::System.Drawing.Size(84, 82);
			this.pictureBox6.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 5;
			this.pictureBox6.TabStop = false;
			this.groupBox8.Controls.Add(this.label_更新日期);
			this.groupBox8.Controls.Add(this.label_版本号);
			this.groupBox8.Controls.Add(this.label19);
			this.groupBox8.Location = new global::System.Drawing.Point(117, 14);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new global::System.Drawing.Size(255, 83);
			this.groupBox8.TabIndex = 4;
			this.groupBox8.TabStop = false;
			this.label_更新日期.AutoSize = true;
			this.label_更新日期.Location = new global::System.Drawing.Point(13, 34);
			this.label_更新日期.Name = "label_更新日期";
			this.label_更新日期.Size = new global::System.Drawing.Size(125, 12);
			this.label_更新日期.TabIndex = 6;
			this.label_更新日期.Text = "更新时间：2018-06-29";
			this.label_版本号.AutoSize = true;
			this.label_版本号.Location = new global::System.Drawing.Point(13, 13);
			this.label_版本号.Name = "label_版本号";
			this.label_版本号.Size = new global::System.Drawing.Size(89, 12);
			this.label_版本号.TabIndex = 4;
			this.label_版本号.Text = "当前版本：4.34";
			this.label19.AutoSize = true;
			this.label19.Location = new global::System.Drawing.Point(13, 56);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(113, 12);
			this.label19.TabIndex = 5;
			this.label19.Text = "版权所有：天若幽心";
			this.label17.AutoSize = true;
			this.label17.Font = new global::System.Drawing.Font("微软雅黑", 12f);
			this.label17.Location = new global::System.Drawing.Point(7, 8);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(0, 21);
			this.label17.TabIndex = 0;
			this.Page_赞助.BackColor = global::System.Drawing.Color.White;
			this.Page_赞助.Controls.Add(this.pictureBox7);
			this.Page_赞助.Location = new global::System.Drawing.Point(4, 22);
			this.Page_赞助.Name = "Page_赞助";
			this.Page_赞助.Padding = new global::System.Windows.Forms.Padding(3);
			this.Page_赞助.Size = new global::System.Drawing.Size(390, 329);
			this.Page_赞助.TabIndex = 7;
			this.Page_赞助.Text = "赞助";
			this.pictureBox7.Image = global::天若OCR文字识别.Properties.Resources.二维码;
			this.pictureBox7.Location = new global::System.Drawing.Point(-3, -4);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new global::System.Drawing.Size(392, 208);
			this.pictureBox7.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox7.TabIndex = 0;
			this.pictureBox7.TabStop = false;
			this.Page_反馈.BackColor = global::System.Drawing.Color.White;
			this.Page_反馈.Controls.Add(this.label21);
			this.Page_反馈.Controls.Add(this.反馈Button);
			this.Page_反馈.Controls.Add(this.txt_问题反馈);
			this.Page_反馈.Location = new global::System.Drawing.Point(4, 22);
			this.Page_反馈.Name = "Page_反馈";
			this.Page_反馈.Padding = new global::System.Windows.Forms.Padding(3);
			this.Page_反馈.Size = new global::System.Drawing.Size(390, 329);
			this.Page_反馈.TabIndex = 8;
			this.Page_反馈.Text = "反馈";
			this.label21.AutoSize = true;
			this.label21.Location = new global::System.Drawing.Point(7, 151);
			this.label21.Name = "label21";
			this.label21.Size = new global::System.Drawing.Size(293, 12);
			this.label21.TabIndex = 12;
			this.label21.Text = "如果想要更好的获得更新信息，请备注您的联系方式！";
			this.反馈Button.BackColor = global::System.Drawing.Color.White;
			this.反馈Button.Location = new global::System.Drawing.Point(309, 146);
			this.反馈Button.Name = "反馈Button";
			this.反馈Button.Size = new global::System.Drawing.Size(75, 23);
			this.反馈Button.TabIndex = 11;
			this.反馈Button.Text = "提交";
			this.反馈Button.UseVisualStyleBackColor = false;
			this.反馈Button.Click += new global::System.EventHandler(this.反馈Button_Click);
			this.txt_问题反馈.BackColor = global::System.Drawing.Color.White;
			this.txt_问题反馈.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_问题反馈.ImeMode = global::System.Windows.Forms.ImeMode.HangulFull;
			this.txt_问题反馈.Location = new global::System.Drawing.Point(6, 6);
			this.txt_问题反馈.Multiline = true;
			this.txt_问题反馈.Name = "txt_问题反馈";
			this.txt_问题反馈.Size = new global::System.Drawing.Size(378, 134);
			this.txt_问题反馈.TabIndex = 5;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(417, 368);
			base.Controls.Add(this.tab_标签);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FmSetting";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "设置";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.Page_代理.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.Page_密钥.ResumeLayout(false);
			this.tabControl2.ResumeLayout(false);
			this.inPage_百度接口.ResumeLayout(false);
			this.inPage_百度接口.PerformLayout();
			this.Page_快捷键.ResumeLayout(false);
			this.Page_快捷键.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_识别界面).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_记录界面).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_翻译文本).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox_文字识别).EndInit();
			this.page_常规.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox10.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pic_help).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numbox_记录).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tab_标签.ResumeLayout(false);
			this.Page_更新.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numbox_间隔时间).EndInit();
			this.Page_关于.ResumeLayout(false);
			this.Page_关于.PerformLayout();
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox6).EndInit();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.Page_赞助.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox7).EndInit();
			this.Page_反馈.ResumeLayout(false);
			this.Page_反馈.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000123 RID: 291
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000124 RID: 292
		private global::System.Windows.Forms.TabPage Page_代理;

		// Token: 0x04000125 RID: 293
		private global::System.Windows.Forms.TabPage Page_密钥;

		// Token: 0x04000126 RID: 294
		private global::System.Windows.Forms.TabPage Page_快捷键;

		// Token: 0x04000127 RID: 295
		private global::System.Windows.Forms.TabPage page_常规;

		// Token: 0x04000128 RID: 296
		private global::System.Windows.Forms.PictureBox pic_help;

		// Token: 0x04000129 RID: 297
		private global::System.Windows.Forms.Button 常规Button;

		// Token: 0x0400012A RID: 298
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400012B RID: 299
		private global::System.Windows.Forms.NumericUpDown numbox_记录;

		// Token: 0x0400012C RID: 300
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400012D RID: 301
		private global::System.Windows.Forms.ComboBox cobBox_动画;

		// Token: 0x0400012E RID: 302
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400012F RID: 303
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000130 RID: 304
		private global::System.Windows.Forms.CheckBox cbBox_开机;

		// Token: 0x04000131 RID: 305
		private global::System.Windows.Forms.TabControl tab_标签;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Forms.TabPage Page_更新;

		// Token: 0x04000133 RID: 307
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x04000134 RID: 308
		private global::System.Windows.Forms.PictureBox pictureBox_翻译文本;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Forms.PictureBox pictureBox_文字识别;

		// Token: 0x04000136 RID: 310
		private global::System.Windows.Forms.TextBox txtBox_识别界面;

		// Token: 0x04000137 RID: 311
		private global::System.Windows.Forms.TextBox txtBox_记录界面;

		// Token: 0x04000138 RID: 312
		private global::System.Windows.Forms.TextBox txtBox_翻译文本;

		// Token: 0x04000139 RID: 313
		private global::System.Windows.Forms.TextBox txtBox_文字识别;

		// Token: 0x0400013A RID: 314
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400013B RID: 315
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400013C RID: 316
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400013D RID: 317
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400013E RID: 318
		private global::System.Windows.Forms.PictureBox pictureBox_识别界面;

		// Token: 0x0400013F RID: 319
		private global::System.Windows.Forms.PictureBox pictureBox_记录界面;

		// Token: 0x04000140 RID: 320
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000141 RID: 321
		private global::System.Windows.Forms.CheckBox cbBox_翻译;

		// Token: 0x04000142 RID: 322
		private global::System.Windows.Forms.TabControl tabControl2;

		// Token: 0x04000143 RID: 323
		private global::System.Windows.Forms.TabPage inPage_百度接口;

		// Token: 0x04000144 RID: 324
		private global::System.Windows.Forms.TextBox text_baidupassword;

		// Token: 0x04000145 RID: 325
		private global::System.Windows.Forms.TextBox text_baiduaccount;

		// Token: 0x04000146 RID: 326
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000147 RID: 327
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000148 RID: 328
		private global::System.Windows.Forms.Button 快捷键Button;

		// Token: 0x04000149 RID: 329
		private global::System.Windows.Forms.Button 密钥Button_apply;

		// Token: 0x0400014A RID: 330
		private global::System.Windows.Forms.Button 密钥Button;

		// Token: 0x0400014B RID: 331
		private global::System.Windows.Forms.TabPage Page_关于;

		// Token: 0x0400014C RID: 332
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x0400014D RID: 333
		private global::System.Windows.Forms.ComboBox combox_代理;

		// Token: 0x0400014E RID: 334
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400014F RID: 335
		private global::System.Windows.Forms.Button 代理Button;

		// Token: 0x04000150 RID: 336
		private global::System.Windows.Forms.CheckBox chbox_代理服务器;

		// Token: 0x04000151 RID: 337
		private global::System.Windows.Forms.TextBox text_密码;

		// Token: 0x04000152 RID: 338
		private global::System.Windows.Forms.TextBox text_端口;

		// Token: 0x04000153 RID: 339
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04000154 RID: 340
		private global::System.Windows.Forms.TextBox text_账号;

		// Token: 0x04000155 RID: 341
		private global::System.Windows.Forms.TextBox text_服务器;

		// Token: 0x04000156 RID: 342
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000157 RID: 343
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000158 RID: 344
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000159 RID: 345
		private global::System.Windows.Forms.Button 更新Button_check;

		// Token: 0x0400015A RID: 346
		private global::System.Windows.Forms.Button 更新Button;

		// Token: 0x0400015B RID: 347
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x0400015C RID: 348
		private global::System.Windows.Forms.Label label16;

		// Token: 0x0400015D RID: 349
		private global::System.Windows.Forms.NumericUpDown numbox_间隔时间;

		// Token: 0x0400015E RID: 350
		private global::System.Windows.Forms.CheckBox checkBox_更新间隔;

		// Token: 0x0400015F RID: 351
		private global::System.Windows.Forms.CheckBox check_检查更新;

		// Token: 0x04000160 RID: 352
		private global::System.Windows.Forms.CheckBox cbBox_弹窗;

		// Token: 0x04000161 RID: 353
		private global::System.Windows.Forms.GroupBox groupBox6;

		// Token: 0x04000162 RID: 354
		private global::System.Windows.Forms.TextBox textBox_path;

		// Token: 0x04000163 RID: 355
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000164 RID: 356
		private global::System.Windows.Forms.CheckBox cbBox_保存;

		// Token: 0x04000165 RID: 357
		private global::System.Windows.Forms.GroupBox groupBox7;

		// Token: 0x04000166 RID: 358
		private global::System.Windows.Forms.PictureBox pictureBox6;

		// Token: 0x04000167 RID: 359
		private global::System.Windows.Forms.GroupBox groupBox8;

		// Token: 0x04000168 RID: 360
		private global::System.Windows.Forms.Label label_更新日期;

		// Token: 0x04000169 RID: 361
		private global::System.Windows.Forms.Label label_版本号;

		// Token: 0x0400016A RID: 362
		private global::System.Windows.Forms.Label label19;

		// Token: 0x0400016B RID: 363
		private global::System.Windows.Forms.Label label17;

		// Token: 0x0400016C RID: 364
		private global::System.Windows.Forms.GroupBox groupBox9;

		// Token: 0x0400016D RID: 365
		private global::System.Windows.Forms.TextBox txt_更新说明;

		// Token: 0x0400016E RID: 366
		private global::System.Windows.Forms.TabPage Page_赞助;

		// Token: 0x0400016F RID: 367
		private global::System.Windows.Forms.PictureBox pictureBox7;

		// Token: 0x04000170 RID: 368
		private global::System.Windows.Forms.TabPage Page_反馈;

		// Token: 0x04000171 RID: 369
		private global::System.Windows.Forms.Label label21;

		// Token: 0x04000172 RID: 370
		private global::System.Windows.Forms.Button 反馈Button;

		// Token: 0x04000173 RID: 371
		private global::System.Windows.Forms.TextBox txt_问题反馈;

		// Token: 0x04000174 RID: 372
		private global::System.Windows.Forms.Button btn_浏览;

		// Token: 0x04000175 RID: 373
		private global::System.Windows.Forms.Button 百度_btn;

		// Token: 0x04000176 RID: 374
		private global::System.Windows.Forms.GroupBox groupBox10;

		// Token: 0x04000177 RID: 375
		private global::System.Windows.Forms.Button btn_音效;

		// Token: 0x04000178 RID: 376
		private global::System.Windows.Forms.TextBox text_音效path;

		// Token: 0x04000179 RID: 377
		private global::System.Windows.Forms.Label label18;

		// Token: 0x0400017A RID: 378
		private global::System.Windows.Forms.CheckBox chbox_save;

		// Token: 0x0400017B RID: 379
		private global::System.Windows.Forms.CheckBox chbox_copy;

		// Token: 0x0400017C RID: 380
		private global::System.Windows.Forms.Label label20;

		// Token: 0x0400017D RID: 381
		private global::System.Windows.Forms.Button btn_音效路径;

		// Token: 0x0400017E RID: 382
		private global::System.Windows.Forms.CheckBox chbox_取色;
	}
}
