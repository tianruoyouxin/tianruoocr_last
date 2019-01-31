namespace 天若OCR文字识别
{
	// Token: 0x02000007 RID: 7
	public partial class FmMain : global::System.Windows.Forms.Form
	{
		// Token: 0x060000FA RID: 250 RVA: 0x000028D0 File Offset: 0x00000AD0
		protected override void Dispose(bool disposing)
		{
			global::天若OCR文字识别.HelpWin32.ChangeClipboardChain(base.Handle, this.nextClipboardViewer);
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000107C8 File Offset: 0x0000E9C8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::天若OCR文字识别.FmMain));
			this.minico = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStrip = new global::System.Windows.Forms.ToolStripMenuItem();
			this.trans_input = new global::System.Windows.Forms.ToolStripMenuItem();
			this.trans_google = new global::System.Windows.Forms.ToolStripMenuItem();
			this.trans_baidu = new global::System.Windows.Forms.ToolStripMenuItem();
			this.trans_tencent = new global::System.Windows.Forms.ToolStripMenuItem();
			this.baidu_table = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ali_table = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ocr_table = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menu = new global::System.Windows.Forms.ContextMenuStrip();
			this.menu.Renderer = new global::天若OCR文字识别.HelpRepaint.MenuItemRendererT();
			this.ch_en = new global::System.Windows.Forms.ToolStripMenuItem();
			this.jap = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kor = new global::System.Windows.Forms.ToolStripMenuItem();
			this.pinyin = new global::System.Windows.Forms.ToolStripMenuItem();
			this.customize_Proxy = new global::System.Windows.Forms.ToolStripMenuItem();
			this.null_Proxy = new global::System.Windows.Forms.ToolStripMenuItem();
			this.system_Proxy = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Proxy = new global::System.Windows.Forms.ToolStripMenuItem();
			this.left_right = new global::System.Windows.Forms.ToolStripMenuItem();
			this.righ_left = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Main_copy = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Main_paste = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Main_selectall = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Main_jiekou = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Main_exit = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Main_change = new global::System.Windows.Forms.ToolStripMenuItem();
			this.zh_tra = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tra_zh = new global::System.Windows.Forms.ToolStripMenuItem();
			this.str_Upper = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Upper_str = new global::System.Windows.Forms.ToolStripMenuItem();
			this.speak = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Trans_copy = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Trans_paste = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Trans_SelectAll = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Trans_close = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Trans_Voice = new global::System.Windows.Forms.ToolStripMenuItem();
			this.sougou = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Mathfuntion = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tencent = new global::System.Windows.Forms.ToolStripMenuItem();
			this.baidu = new global::System.Windows.Forms.ToolStripMenuItem();
			this.shupai = new global::System.Windows.Forms.ToolStripMenuItem();
			this.write = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tencent_v = new global::System.Windows.Forms.ToolStripMenuItem();
			this.baidu_s = new global::System.Windows.Forms.ToolStripMenuItem();
			this.baidu_v = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tencent = new global::System.Windows.Forms.ToolStripMenuItem();
			this.baidu = new global::System.Windows.Forms.ToolStripMenuItem();
			this.youdao = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Chinese = new global::System.Windows.Forms.ToolStripMenuItem();
			this.English = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Split = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Restore = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menu_copy = new global::System.Windows.Forms.ContextMenuStrip();
			this.menu_copy.Renderer = new global::天若OCR文字识别.HelpRepaint.MenuItemRendererT();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.RichBoxBody = new global::天若OCR文字识别.AdvRichTextBox();
			this.RichBoxBody_T = new global::天若OCR文字识别.AdvRichTextBox();
			this.minico.BalloonTipIcon = global::System.Windows.Forms.ToolTipIcon.Info;
			this.minico.BalloonTipText = "最小化到任务栏";
			this.minico.BalloonTipTitle = "提示";
			this.minico.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("minico.Icon");
			this.minico.Text = "双击开始截图识别";
			this.minico.Visible = true;
			this.minico.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.tray_double_Click);
			this.font_base.Width = 18f * this.F_factor;
			this.font_base.Height = 17f * this.F_factor;
			this.RichBoxBody_T.Visible = false;
			this.RichBoxBody.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.RichBoxBody.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.RichBoxBody.Location = new global::System.Drawing.Point(0, 0);
			this.RichBoxBody.Name = "htmlTextBoxBody";
			this.RichBoxBody.ImeMode = global::System.Windows.Forms.ImeMode.HangulFull;
			this.RichBoxBody.TabIndex = 200;
			this.RichBoxBody.Text_flag = "天若幽心";
			this.RichBoxBody_T.ImeMode = global::System.Windows.Forms.ImeMode.HangulFull;
			this.Trans_copy.Text = "复制";
			this.Trans_copy.Click += new global::System.EventHandler(this.Trans_copy_Click);
			this.Trans_paste.Text = "粘贴";
			this.Trans_paste.Click += new global::System.EventHandler(this.Trans_paste_Click);
			this.Trans_SelectAll.Text = "全选";
			this.Trans_SelectAll.Click += new global::System.EventHandler(this.Trans_SelectAll_Click);
			this.Trans_close.Text = "关闭";
			this.Trans_close.Click += new global::System.EventHandler(this.Trans_close_Click);
			this.Trans_Voice.Text = "朗读";
			this.Trans_Voice.Click += new global::System.EventHandler(this.Trans_Voice_Click);
			this.trans_input.Text = "接口";
			this.trans_input.Click += new global::System.EventHandler(this.Trans_SelectAll_Click);
			this.trans_google.Text = "谷歌√";
			this.trans_google.Click += new global::System.EventHandler(this.Trans_google_Click);
			this.trans_baidu.Text = "百度";
			this.trans_baidu.Click += new global::System.EventHandler(this.Trans_baidu_Click);
			this.trans_tencent.Text = "腾讯";
			this.trans_tencent.Click += new global::System.EventHandler(this.Trans_tencent_Click);
			this.menu_copy.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.Trans_copy,
				this.Trans_paste,
				this.Trans_SelectAll,
				this.Trans_Voice,
				this.trans_input,
				this.Trans_close
			});
			this.trans_input.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.trans_google,
				this.trans_baidu,
				this.trans_tencent
			});
			this.menu_copy.Font = new global::System.Drawing.Font("微软雅黑", 9f / global::天若OCR文字识别.StaticValue.Dpifactor, global::System.Drawing.FontStyle.Regular);
			this.Main_copy.Text = "复制";
			this.Main_copy.Click += new global::System.EventHandler(this.Main_copy_Click);
			this.Main_paste.Text = "粘贴";
			this.Main_paste.Click += new global::System.EventHandler(this.Main_paste_Click);
			this.Main_selectall.Text = "全选";
			this.Main_selectall.Click += new global::System.EventHandler(this.Main_SelectAll_Click);
			this.speak.Text = "朗读";
			this.speak.Click += new global::System.EventHandler(this.Main_Voice_Click);
			this.baidu_s.Text = "搜索";
			this.baidu_s.Click += new global::System.EventHandler(this.Main_baidu_search);
			this.Main_change.Text = "转换";
			this.Main_jiekou.Text = "接口";
			this.Main_exit.Text = "退出";
			this.Main_exit.Click += new global::System.EventHandler(this.tray_exit_Click);
			this.menu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.Main_copy,
				this.Main_paste,
				this.Main_selectall,
				this.speak,
				this.baidu_s,
				this.Main_change,
				this.Main_jiekou,
				this.Main_exit
			});
			this.menu.Font = new global::System.Drawing.Font("微软雅黑", 9f / global::天若OCR文字识别.StaticValue.Dpifactor, global::System.Drawing.FontStyle.Regular);
			this.sougou.Text = "搜狗√";
			this.sougou.Click += new global::System.EventHandler(this.OCR_sougou_Click);
			this.Mathfuntion.Text = "公式";
			this.Mathfuntion.Click += new global::System.EventHandler(this.OCR_Mathfuntion_Click);
			this.tencent.Text = "腾讯";
			this.tencent.Click += new global::System.EventHandler(this.OCR_tencent_Click);
			this.baidu.Text = "百度";
			this.baidu.Click += new global::System.EventHandler(this.OCR_baidu_Click);
			this.youdao.Text = "有道";
			this.youdao.Click += new global::System.EventHandler(this.OCR_youdao_Click);
			this.ocr_table.Text = "表格";
			this.baidu_table.Text = "百度";
			this.baidu_table.Click += new global::System.EventHandler(this.OCR_baidutable_Click);
			this.ali_table.Text = "阿里";
			this.ali_table.Click += new global::System.EventHandler(this.OCR_ailitable_Click);
			this.ocr_table.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.baidu_table,
				this.ali_table
			});
			this.shupai.Text = "竖排";
			this.shupai.Click += new global::System.EventHandler(this.OCR_shupai_Click);
			this.write.Text = "手写";
			this.write.Click += new global::System.EventHandler(this.OCR_write_Click);
			this.Chinese.Text = "中文标点";
			this.Chinese.Click += new global::System.EventHandler(this.change_Chinese_Click);
			this.English.Text = "英文标点";
			this.English.Click += new global::System.EventHandler(this.change_English_Click);
			this.zh_tra.Text = "中文繁体";
			this.zh_tra.Click += new global::System.EventHandler(this.change_zh_tra_Click);
			this.tra_zh.Text = "中文简体";
			this.tra_zh.Click += new global::System.EventHandler(this.change_tra_zh_Click);
			this.str_Upper.Text = "英文大写";
			this.str_Upper.Click += new global::System.EventHandler(this.change_str_Upper_Click);
			this.Upper_str.Text = "英文小写";
			this.Upper_str.Click += new global::System.EventHandler(this.change_Upper_str_Click);
			this.pinyin.Text = "汉语拼音";
			this.pinyin.Click += new global::System.EventHandler(this.change_pinyin_Click);
			this.change_button = this.Main_change;
			this.change_button.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.Chinese,
				this.English,
				this.zh_tra,
				this.tra_zh,
				this.str_Upper,
				this.Upper_str,
				this.pinyin
			});
			this.interface_button = this.Main_jiekou;
			this.interface_button.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.sougou,
				this.tencent,
				this.youdao,
				this.baidu,
				this.toolStripSeparator1,
				this.Mathfuntion,
				this.ocr_table,
				this.shupai
			});
			if (global::天若OCR文字识别.inihelp.GetValue("配置", "接口") == "百度")
			{
				this.ch_en.Text = "中英√";
			}
			else
			{
				this.ch_en.Text = "中英";
			}
			this.ch_en.Click += new global::System.EventHandler(this.OCR_baidu_Ch_and_En_Click);
			this.jap.Text = "日语";
			this.jap.Click += new global::System.EventHandler(this.OCR_baidu_Jap_Click);
			this.kor.Text = "韩语";
			this.kor.Click += new global::System.EventHandler(this.OCR_baidu_Kor_Click);
			((global::System.Windows.Forms.ToolStripDropDownItem)this.baidu).DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ch_en,
				this.jap,
				this.kor
			});
			this.left_right.Text = "从左向右";
			this.left_right.Click += new global::System.EventHandler(this.OCR_lefttoright_Click);
			this.righ_left.Text = "从右向左";
			this.righ_left.Click += new global::System.EventHandler(this.OCR_righttoleft_Click);
			((global::System.Windows.Forms.ToolStripDropDownItem)this.shupai).DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.left_right,
				this.righ_left
			});
			this.RichBoxBody.ContextMenuStrip1 = this.menu;
			this.RichBoxBody_T.ContextMenuStrip1 = this.menu_copy;
			this.PictureBox1.Image = (global::System.Drawing.Image)new global::System.ComponentModel.ComponentResourceManager(typeof(global::天若OCR文字识别.FmMain)).GetObject("loadcat.gif");
			this.PictureBox1.Size = new global::System.Drawing.Size(85, 85);
			this.PictureBox1.Location = (global::System.Drawing.Point)new global::System.Drawing.Size((int)this.font_base.Width * 34 - this.PictureBox1.Size.Width / 2, (int)(110f * this.F_factor));
			this.PictureBox1.BackColor = global::System.Drawing.Color.White;
			this.PictureBox1.Visible = false;
			base.SuspendLayout();
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			base.Location = (global::System.Drawing.Point)new global::System.Drawing.Size(global::System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 2 - global::System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width / 10, global::System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 2 - global::System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height / 6);
			base.Size = new global::System.Drawing.Size((int)this.font_base.Width * 23, (int)this.font_base.Height * 24);
			base.Controls.Add(this.RichBoxBody_T);
			base.Controls.Add(this.PictureBox1);
			base.Controls.Add(this.RichBoxBody);
			base.Load += new global::System.EventHandler(this.Load_Click);
			base.Resize += new global::System.EventHandler(this.Form_Resize);
			base.Name = "Form1";
			this.Text = "耗时：";
			if (global::天若OCR文字识别.inihelp.GetValue("工具栏", "顶置") == "True")
			{
				base.TopMost = true;
			}
			else
			{
				base.TopMost = false;
			}
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("minico.Icon");
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400008F RID: 143
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000090 RID: 144
		public global::System.Windows.Forms.NotifyIcon minico;

		// Token: 0x04000091 RID: 145
		public global::System.Windows.Forms.ContextMenuStrip menu;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.ToolStripMenuItem toolStrip;

		// Token: 0x04000093 RID: 147
		public global::System.Windows.Forms.ToolStripMenuItem Main_copy;

		// Token: 0x04000094 RID: 148
		public global::System.Windows.Forms.ToolStripMenuItem Main_paste;

		// Token: 0x04000095 RID: 149
		public global::System.Windows.Forms.ToolStripMenuItem Main_selectall;

		// Token: 0x04000096 RID: 150
		public global::System.Windows.Forms.ToolStripMenuItem Main_exit;

		// Token: 0x04000097 RID: 151
		public global::System.Windows.Forms.ToolStripMenuItem Main_jiekou;

		// Token: 0x04000098 RID: 152
		public global::System.Windows.Forms.ToolStripItem sougou;

		// Token: 0x04000099 RID: 153
		public global::System.Windows.Forms.ToolStripItem tencent;

		// Token: 0x0400009A RID: 154
		public global::System.Windows.Forms.ToolStripItem baidu;

		// Token: 0x0400009B RID: 155
		public global::System.Windows.Forms.ToolStripItem youdao;

		// Token: 0x0400009C RID: 156
		public global::System.Windows.Forms.ToolStripDropDownItem interface_button;

		// Token: 0x0400009D RID: 157
		public global::System.Windows.Forms.ToolStripMenuItem Main_change;

		// Token: 0x0400009E RID: 158
		public global::System.Windows.Forms.ToolStripDropDownItem change_button;

		// Token: 0x0400009F RID: 159
		public global::System.Windows.Forms.ToolStripMenuItem Chinese;

		// Token: 0x040000A0 RID: 160
		public global::System.Windows.Forms.ToolStripMenuItem English;

		// Token: 0x040000A1 RID: 161
		public global::天若OCR文字识别.AdvRichTextBox RichBoxBody_T;

		// Token: 0x040000A2 RID: 162
		public global::System.Windows.Forms.ContextMenuStrip menu_copy;

		// Token: 0x040000A3 RID: 163
		public global::System.Windows.Forms.ToolStripMenuItem Trans_copy;

		// Token: 0x040000A4 RID: 164
		public global::System.Windows.Forms.ToolStripMenuItem Trans_paste;

		// Token: 0x040000A5 RID: 165
		public global::System.Windows.Forms.ToolStripMenuItem Trans_SelectAll;

		// Token: 0x040000A6 RID: 166
		public global::System.Windows.Forms.ToolStripMenuItem Trans_close;

		// Token: 0x040000A7 RID: 167
		public global::System.Drawing.SizeF font_base;

		// Token: 0x040000A8 RID: 168
		public global::System.Windows.Forms.PictureBox PictureBox1;

		// Token: 0x040000A9 RID: 169
		public global::System.Windows.Forms.ToolStripMenuItem Split;

		// Token: 0x040000AA RID: 170
		public global::System.Windows.Forms.ToolStripMenuItem Restore;

		// Token: 0x040000AB RID: 171
		public float F_factor;

		// Token: 0x040000AC RID: 172
		private global::天若OCR文字识别.AdvRichTextBox RichBoxBody;

		// Token: 0x040000AD RID: 173
		private global::System.IntPtr nextClipboardViewer;

		// Token: 0x040000AE RID: 174
		public global::System.Windows.Forms.ToolStripMenuItem baidu_v;

		// Token: 0x040000AF RID: 175
		public global::System.Windows.Forms.ToolStripMenuItem tencent_v;

		// Token: 0x040000B0 RID: 176
		public global::System.Windows.Forms.ToolStripMenuItem baidu_s;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.ToolStripMenuItem speak;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.ToolStripMenuItem Trans_Voice;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.ToolStripMenuItem zh_tra;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.ToolStripMenuItem tra_zh;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.ToolStripMenuItem str_Upper;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.ToolStripMenuItem Upper_str;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.ToolStripMenuItem ch_en;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.ToolStripMenuItem jap;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.ToolStripMenuItem kor;

		// Token: 0x040000BA RID: 186
		public global::System.Windows.Forms.ToolStripItem shupai;

		// Token: 0x040000BB RID: 187
		public global::System.Windows.Forms.ToolStripItem write;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.ToolStripMenuItem left_right;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.ToolStripMenuItem righ_left;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.ToolStripMenuItem customize_Proxy;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.ToolStripMenuItem null_Proxy;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.ToolStripMenuItem system_Proxy;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.ToolStripMenuItem Proxy;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.ToolStripMenuItem pinyin;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.ToolStripMenuItem trans_input;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.ToolStripMenuItem trans_google;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.ToolStripMenuItem trans_baidu;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.ToolStripMenuItem trans_tencent;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.ToolStripMenuItem ocr_table;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.ToolStripMenuItem baidu_table;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.ToolStripMenuItem ali_table;

		// Token: 0x040000D1 RID: 209
		public global::System.Windows.Forms.ToolStripItem Mathfuntion;
	}
}
