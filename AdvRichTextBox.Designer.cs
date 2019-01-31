using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace 天若OCR文字识别
{
	// Token: 0x02000002 RID: 2
	[Description("Provides a user control that allows the user to edit HTML page.")]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	public class AdvRichTextBox : UserControl
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00003078 File Offset: 0x00001278
		public void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AdvRichTextBox));
			this.font_宋体 = new ToolStripMenuItem();
			this.font_楷体 = new ToolStripMenuItem();
			this.font_黑体 = new ToolStripMenuItem();
			this.font_微软雅黑 = new ToolStripMenuItem();
			this.font_新罗马 = new ToolStripMenuItem();
			this.zh_jp = new ToolStripMenuItem();
			this.zh_ko = new ToolStripMenuItem();
			this.zh_en = new ToolStripMenuItem();
			this.mode_顶置 = new ToolStripMenuItem();
			this.mode_正常 = new ToolStripMenuItem();
			this.mode_合并 = new ToolStripMenuItem();
			this.topmost = new ToolStripButton();
			this.languagle = new ToolStripDropDownButton();
			this.mode = new ToolStripDropDownButton();
			this.Fontstyle = new ToolStripDropDownButton();
			this.toolStripToolBar = new HelpRepaint.ToolStripEx();
			this.toolStripButtonclose = new ToolStripButton();
			this.toolStripButtonBold = new ToolStripButton();
			this.toolStripButtonParagraph = new ToolStripButton();
			this.toolStripButtonFind = new ToolStripButton();
			this.toolStripButtonColor = new HelpRepaint.ColorPicker();
			this.toolStripSeparatorFont = new ToolStripSeparator();
			this.toolStripButtonFence = new ToolStripButton();
			this.toolStripButtonSplit = new ToolStripButton();
			this.toolStripButtoncheck = new ToolStripButton();
			this.toolStripButtonIndent = new ToolStripButton();
			this.toolStripSeparatorFormat = new ToolStripSeparator();
			this.toolStripButtonLeft = new ToolStripButton();
			this.toolStripButtonMerge = new ToolStripButton();
			this.toolStripButtonVoice = new ToolStripButton();
			this.toolStripButtonFull = new ToolStripButton();
			this.toolStripSeparatorAlign = new ToolStripSeparator();
			this.toolStripButtonspace = new ToolStripButton();
			this.toolStripButtonR_arow = new ToolStripButton();
			this.toolStripButtonSend = new ToolStripButton();
			this.toolStripButtonTrans = new ToolStripButton();
			this.toolStripButtonNote = new ToolStripButton();
			this.richTextBox1 = new RichTextBoxEx();
			this.toolStripToolBar.SuspendLayout();
			base.SuspendLayout();
			this.toolStripSeparatorFont.ForeColor = Color.White;
			this.toolStripToolBar.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStripToolBar.Location = new Point(0, 0);
			this.toolStripToolBar.Name = "toolStripToolBar";
			this.toolStripToolBar.RenderMode = ToolStripRenderMode.System;
			this.toolStripToolBar.Size = new Size(600, 25);
			this.toolStripToolBar.TabIndex = 1;
			this.toolStripToolBar.Click += this.toolStripToolBar_Click;
			this.toolStripToolBar.Text = "Tool Bar";
			this.toolStripToolBar.BackColor = Color.White;
			this.toolStripToolBar.Renderer = new HelpRepaint.MenuItemRenderer();
			this.toolStripButtonBold.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonBold.Image = (Image)componentResourceManager.GetObject("toolStripButtonBold.Image");
			this.toolStripButtonBold.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonBold.Name = "toolStripButtonBold";
			this.toolStripButtonBold.Size = new Size(23, 22);
			this.toolStripButtonBold.Text = "加粗";
			this.toolStripButtonBold.Click += this.toolStripButtonBold_Click;
			this.toolStripButtonParagraph.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonParagraph.Image = (Image)componentResourceManager.GetObject("toolStripButtonParagraph.Image");
			this.toolStripButtonParagraph.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonParagraph.Name = "toolStripButtonParagraph";
			this.toolStripButtonParagraph.Size = new Size(23, 22);
			this.toolStripButtonParagraph.Text = "依据位置自动分段\r\n仅支持搜狗接口\r\n适合段落识别\r\n图片越清晰越准确\r\n准确度98%以上";
			this.toolStripButtonParagraph.Click += this.toolStripButtonParagraph_Click;
			this.toolStripButtonParagraph.MouseDown += this.toolStripButtonParagraph_keydown;
			this.toolStripButtonFind.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFind.Image = (Image)componentResourceManager.GetObject("toolStripButtonFind.Image");
			this.toolStripButtonFind.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonFind.Name = "toolStripButtonFind";
			this.toolStripButtonFind.Size = new Size(23, 22);
			this.toolStripButtonFind.Text = "查找\\替换";
			this.toolStripButtonFind.Click += this.toolStripButtonFind_Click;
			this.toolStripButtonColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonColor.Image = (Image)componentResourceManager.GetObject("toolStripButtonColor.Image");
			this.toolStripButtonColor.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonColor.Name = "toolStripButtonColor";
			this.toolStripButtonColor.Size = new Size(23, 22);
			this.toolStripButtonColor.Text = "字体颜色";
			this.toolStripButtonColor.Click += this.toolStripButtonColor_Click;
			this.toolStripButtonLeft.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonLeft.Image = (Image)componentResourceManager.GetObject("toolStripButtonLeft.Image");
			this.toolStripButtonLeft.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonLeft.Name = "toolStripButtonLeft";
			this.toolStripButtonLeft.Size = new Size(23, 22);
			this.toolStripButtonLeft.Text = "左对齐";
			this.toolStripButtonLeft.Click += this.toolStripButtonLeft_Click;
			this.toolStripButtonMerge.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonMerge.Image = (Image)componentResourceManager.GetObject("toolStripButtonMerge.Image");
			this.toolStripButtonMerge.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonMerge.Name = "toolStripButtonMerge";
			this.toolStripButtonMerge.Size = new Size(23, 22);
			this.toolStripButtonMerge.Text = "将文本合并成一段";
			this.toolStripButtonMerge.Click += this.toolStripButtonMerge_Click;
			this.toolStripButtonMerge.MouseDown += this.toolStripButtonMerge_keydown;
			this.toolStripButtonVoice.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonVoice.Image = (Image)componentResourceManager.GetObject("toolStripButtonVoice.Image");
			this.toolStripButtonVoice.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonVoice.Name = "toolStripButtonVoice";
			this.toolStripButtonVoice.Size = new Size(23, 22);
			this.toolStripButtonVoice.Text = "朗读";
			this.toolStripButtonVoice.Click += this.toolStripButtonVoice_Click;
			this.toolStripButtonFull.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFull.Image = (Image)componentResourceManager.GetObject("toolStripButtonFull.Image");
			this.toolStripButtonFull.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonFull.Name = "toolStripButtonFull";
			this.toolStripButtonFull.Size = new Size(23, 22);
			this.toolStripButtonFull.Text = "两端对齐";
			this.toolStripButtonFull.Click += this.toolStripButtonFull_Click;
			this.toolStripButtonspace.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonspace.Image = (Image)componentResourceManager.GetObject("toolStripButtonspace.Image");
			this.toolStripButtonspace.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonspace.Name = "toolStripButtonLine";
			this.toolStripButtonspace.Size = new Size(23, 22);
			this.toolStripButtonspace.Text = "首行缩进";
			this.toolStripButtonspace.Click += this.toolStripButtonspace_Click;
			this.toolStripButtonFence.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFence.Image = (Image)componentResourceManager.GetObject("toolStripButtonFence.Image");
			this.toolStripButtonFence.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonFence.Name = "toolStripButtonformat";
			this.toolStripButtonFence.Size = new Size(23, 22);
			this.toolStripButtonFence.Text = "截图时自动分栏\r\n多选区时无效\r\n单击显示分栏示意图";
			this.toolStripButtonFence.Click += this.toolStripButtonFence_Click;
			this.toolStripButtonFence.MouseDown += this.toolStripButtonFence_keydown;
			this.toolStripButtonSend.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSend.Image = (Image)componentResourceManager.GetObject("toolStripButtonSend.Image");
			this.toolStripButtonSend.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonSend.Name = "toolStripButtonSend";
			this.toolStripButtonSend.Size = new Size(23, 22);
			this.toolStripButtonSend.Text = "复制/发送";
			this.toolStripButtonSend.Click += this.toolStripButtonSend_Click;
			this.toolStripButtonSplit.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSplit.Image = (Image)componentResourceManager.GetObject("toolStripButtonSplit.Image");
			this.toolStripButtonSplit.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonSplit.Name = "toolStripButtonSplit";
			this.toolStripButtonSplit.Size = new Size(23, 22);
			this.toolStripButtonSplit.Text = "按图片中的行进行拆分";
			this.toolStripButtonSplit.Click += this.toolStripButtonSplit_Click;
			this.toolStripButtonSplit.MouseDown += this.toolStripButtonSplit_keydown;
			this.toolStripButtoncheck.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtoncheck.Image = (Image)componentResourceManager.GetObject("toolStripButtoncheck.Image");
			this.toolStripButtoncheck.ImageTransparentColor = Color.Magenta;
			this.toolStripButtoncheck.Name = "toolStripButtoncheck";
			this.toolStripButtoncheck.Size = new Size(23, 22);
			this.toolStripButtoncheck.Text = "检查文本是否有错别字";
			this.toolStripButtoncheck.Click += this.toolStripButtoncheck_Click;
			this.toolStripButtoncheck.MouseDown += this.toolStripButtoncheck_keydown;
			this.toolStripButtonTrans.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonTrans.Image = (Image)componentResourceManager.GetObject("toolStripButtonTrans.Image");
			this.toolStripButtonTrans.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonTrans.Name = "toolStripButtonTrans";
			this.toolStripButtonTrans.Size = new Size(23, 22);
			this.toolStripButtonTrans.Text = "翻译";
			this.toolStripButtonTrans.Click += this.toolStripButtonTrans_Click;
			this.toolStripButtonTrans.MouseDown += this.toolStripButtontrans_keydown;
			this.toolStripButtonNote.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonNote.Image = (Image)componentResourceManager.GetObject("toolStripButtonNote.Image");
			this.toolStripButtonNote.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonNote.Name = "toolStripButtonTrans";
			this.toolStripButtonNote.Size = new Size(23, 22);
			this.toolStripButtonNote.Text = "记录窗体";
			this.toolStripButtonNote.Click += this.toolStripButtonNote_Click;
			this.toolStripButtonclose.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButtonclose.Image = (Image)componentResourceManager.GetObject("toolStripButtonclose.Image");
			this.toolStripButtonclose.ImageTransparentColor = Color.Magenta;
			this.toolStripButtonclose.Name = "toolStripButtonclose";
			this.toolStripButtonclose.Size = new Size(23, 22);
			this.toolStripButtonclose.Text = "关闭";
			this.toolStripButtonclose.Click += this.toolStripButtonclose_Click;
			this.languagle.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.languagle.Image = (Image)componentResourceManager.GetObject("languagle.Image");
			this.languagle.ImageTransparentColor = Color.Magenta;
			this.languagle.Name = "toolStripButtonclose";
			this.languagle.Size = new Size(23, 22);
			this.languagle.Text = "选择翻译语言\r\n支持自动检测\r\n可以双向翻译";
			this.zh_en.Text = "中⇆英";
			this.zh_en.ForeColor = Color.Red;
			this.zh_en.Click += this.zh_en_Click;
			this.zh_jp.Text = "中⇆日";
			this.zh_jp.ForeColor = Color.Black;
			this.zh_jp.Click += this.zh_jp_Click;
			this.zh_ko.Text = "中⇆韩";
			this.zh_ko.ForeColor = Color.Black;
			this.zh_ko.Click += this.zh_ko_Click;
			this.languagle.DropDownItems.Add(this.zh_en);
			this.languagle.DropDownItems.Add(this.zh_jp);
			this.languagle.DropDownItems.Add(this.zh_ko);
			this.languagle.AutoSize = false;
			((ToolStripDropDownMenu)this.languagle.DropDown).ShowImageMargin = false;
			this.languagle.DropDown.BackColor = Color.White;
			this.languagle.DropDown.AutoSize = false;
			if (Program.factor == 1f)
			{
				this.languagle.DropDown.AutoSize = false;
			}
			else
			{
				this.languagle.DropDown.AutoSize = true;
			}
			this.languagle.DropDown.Width = Convert.ToInt32(55f);
			this.languagle.DropDown.Height = Convert.ToInt32(70f);
			this.languagle.ShowDropDownArrow = false;
			this.topmost.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.topmost.Image = (Image)componentResourceManager.GetObject("mode.Image");
			this.topmost.ImageTransparentColor = Color.Magenta;
			this.topmost.Name = "toolStripButtonclose";
			this.topmost.Size = new Size(23, 22);
			this.topmost.Text = "顶置";
			this.topmost.MouseDown += this.topmost_keydown;
			this.Fontstyle.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.Fontstyle.Image = (Image)componentResourceManager.GetObject("Fontstyle.Image");
			this.Fontstyle.ImageTransparentColor = Color.Magenta;
			this.Fontstyle.Name = "toolStripButtonclose";
			this.Fontstyle.Size = new Size(23, 22);
			this.Fontstyle.Text = "字体";
			this.Fontstyle.AutoSize = false;
			((ToolStripDropDownMenu)this.Fontstyle.DropDown).ShowImageMargin = false;
			this.Fontstyle.DropDown.BackColor = Color.White;
			this.Fontstyle.DropDown.AutoSize = false;
			if (Program.factor == 1f)
			{
				this.Fontstyle.DropDown.AutoSize = false;
			}
			else
			{
				this.Fontstyle.DropDown.AutoSize = true;
			}
			this.Fontstyle.DropDown.Width = Convert.ToInt32(123f);
			this.Fontstyle.DropDown.Height = Convert.ToInt32(115f);
			this.Fontstyle.ShowDropDownArrow = false;
			this.font_宋体.Text = "宋体";
			this.font_宋体.ForeColor = Color.Black;
			this.font_宋体.Click += this.font_宋体c;
			this.font_黑体.Text = "黑体";
			this.font_黑体.ForeColor = Color.Black;
			this.font_黑体.Click += this.font_黑体c;
			this.font_楷体.Text = "楷体";
			this.font_楷体.ForeColor = Color.Black;
			this.font_楷体.Click += this.font_楷体c;
			this.font_微软雅黑.Text = "微软雅黑";
			this.font_微软雅黑.ForeColor = Color.Black;
			this.font_微软雅黑.Click += this.font_微软雅黑c;
			this.font_新罗马.Text = "Time New Roman";
			this.font_新罗马.ForeColor = Color.Red;
			this.font_新罗马.Click += this.font_新罗马c;
			this.Fontstyle.DropDownItems.Add(this.font_宋体);
			this.Fontstyle.DropDownItems.Add(this.font_黑体);
			this.Fontstyle.DropDownItems.Add(this.font_楷体);
			this.Fontstyle.DropDownItems.Add(this.font_微软雅黑);
			this.Fontstyle.DropDownItems.Add(this.font_新罗马);
			this.richTextBox1.Location = new Point(32, 13);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new Size(603, 457);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.DetectUrls = true;
			this.richTextBox1.HideSelection = false;
			this.richTextBox1.Text = "";
			this.richTextBox1.BorderStyle = BorderStyle.None;
			this.richTextBox1.Dock = DockStyle.Fill;
			this.richTextBox1.Multiline = true;
			this.richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
			this.richTextBox1.KeyDown += this.richTextBox1_KeyDown;
			this.richTextBox1.LinkClicked += this.richTextBox1_LinkClicked;
			this.richTextBox1.MouseDown += this.richtextbox1_MouseDown;
			this.richTextBox1.AllowDrop = true;
			this.richTextBox1.MouseEnter += this.Form1_MouseEnter;
			this.richTextBox1.DragEnter += this.Form1_DragEnter;
			this.richTextBox1.DragDrop += this.Form1_DragDrop;
			this.richTextBox1.SelectionAlignment = HelpRepaint.TextAlign.Justify;
			this.richTextBox1.SetLine = "行高";
			this.richTextBox1.Font = new Font("Times New Roman", 16f * Program.factor, GraphicsUnit.Pixel);
			this.richTextBox1.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
			this.richTextBox1.TextChanged += this.richeditbox_TextChanged;
			this.richTextBox1.Cursor = Cursors.IBeam;
			this.indent_two(1);
			this.mode.Font = new Font("微软雅黑", 9f * Program.factor, FontStyle.Regular);
			this.languagle.Font = new Font("微软雅黑", 9f * Program.factor, FontStyle.Regular);
			this.Fontstyle.Font = new Font("微软雅黑", 9f * Program.factor, FontStyle.Regular);
			base.AutoScaleMode = AutoScaleMode.None;
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.toolStripToolBar);
			base.Name = "richTextBox";
			base.Text = "richTextBox";
			base.Size = new Size(600, 300);
			this.toolStripToolBar.ResumeLayout(false);
			this.toolStripToolBar.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000436C File Offset: 0x0000256C
		public AdvRichTextBox()
		{
			this.toolspace = true;
			this.toolFull = true;
			this.c = new AdvRichTextBox.cmd(50);
			this.Font = new Font(this.Font.Name, 9f / StaticValue.Dpifactor, this.Font.Style, this.Font.Unit, this.Font.GdiCharSet, this.Font.GdiVerticalFont);
			this.InitializeComponent();
			this.readIniFile();
			this.richTextBox1.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000206F File Offset: 0x0000026F
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00004400 File Offset: 0x00002600
		public override string Text
		{
			get
			{
				return this.richTextBox1.Text;
			}
			set
			{
				this.richTextBox1.Font = new Font("Times New Roman", 16f * Program.factor, GraphicsUnit.Pixel);
				this.richTextBox1.Text = value;
				this.richTextBox1.Font = new Font("Times New Roman", 16f * Program.factor, GraphicsUnit.Pixel);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000445C File Offset: 0x0000265C
		public void toolStripButtonBold_Click(object sender, EventArgs e)
		{
			Font selectionFont = this.richTextBox1.SelectionFont;
			if (selectionFont.Bold)
			{
				Font selectionFont2 = new Font(selectionFont, selectionFont.Style & ~FontStyle.Bold);
				this.richTextBox1.SelectionFont = selectionFont2;
			}
			else
			{
				Font selectionFont3 = new Font(selectionFont, selectionFont.Style | FontStyle.Bold);
				this.richTextBox1.SelectionFont = selectionFont3;
			}
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000207C File Offset: 0x0000027C
		public void toolStripButtonParagraph_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000044C4 File Offset: 0x000026C4
		public void toolStripButtonFind_Click(object sender, EventArgs e)
		{
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
			ReplaceForm replaceForm = new ReplaceForm(this);
			if (this.txt_flag == "天若幽心")
			{
				replaceForm.Text = "识别替换";
				replaceForm.Location = base.PointToScreen(new Point((base.Width - replaceForm.Width) / 2, (base.Height - replaceForm.Height) / 2));
			}
			else
			{
				replaceForm.Text = "翻译替换";
				replaceForm.Location = base.PointToScreen(new Point((base.Width - replaceForm.Width) / 2, (base.Height - replaceForm.Height) / 2));
			}
			replaceForm.Show(this);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000207E File Offset: 0x0000027E
		public void toolStripButtonColor_Click(object sender, EventArgs e)
		{
			this.richTextBox1.SelectionColor = this.toolStripButtonColor.SelectedColor;
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00004574 File Offset: 0x00002774
		public void toolStripButtonFence_Click(object sender, EventArgs e)
		{
			if (!File.Exists("cvextern.dll"))
			{
				MessageBox.Show("请从蓝奏网盘中下载cvextern.dll大小约25m，点击确定自动弹出网页。\r\n将下载后的文件与 天若OCR文字识别.exe 这个文件放在一起。");
				Process.Start("https://www.lanzous.com/i1ab3vg");
				return;
			}
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
			if (File.Exists("Data\\分栏预览图.jpg"))
			{
				Process process = new Process();
				process.StartInfo.FileName = "Data\\分栏预览图.jpg";
				process.StartInfo.Arguments = "rundl132.exe C://WINDOWS//system32//shimgvw.dll,ImageView";
				process.Start();
				process.Close();
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020A1 File Offset: 0x000002A1
		public void toolStripButtonSplit_Click(object sender, EventArgs e)
		{
			this.richTextBox1.Text = StaticValue.v_Split;
			Application.DoEvents();
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020C3 File Offset: 0x000002C3
		public void toolStripButtoncheck_Click(object sender, EventArgs e)
		{
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
			new Thread(new ThreadStart(this.错别字检查API)).Start();
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020F1 File Offset: 0x000002F1
		public void toolStripButtonIndent_Click(object sender, EventArgs e)
		{
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020FE File Offset: 0x000002FE
		public void toolStripButtonLeft_Click(object sender, EventArgs e)
		{
			this.richTextBox1.SelectAll();
			this.richTextBox1.SelectionAlignment = HelpRepaint.TextAlign.Left;
			this.richTextBox1.Select(0, 0);
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000045EC File Offset: 0x000027EC
		public void toolStripButtonMerge_Click(object sender, EventArgs e)
		{
			string text = this.richTextBox1.Text.TrimEnd(new char[]
			{
				'\n'
			}).TrimEnd(new char[]
			{
				'\r'
			}).TrimEnd(new char[]
			{
				'\n'
			});
			if (text.Split(Environment.NewLine.ToCharArray()).Length > 1)
			{
				string[] array = text.Split(Environment.NewLine.ToCharArray());
				string text2 = "";
				for (int i = 0; i < array.Length - 1; i++)
				{
					string str = array[i].Substring(array[i].Length - 1, 1);
					string str2 = array[i + 1].Substring(0, 1);
					if (AdvRichTextBox.contain_en(str) && AdvRichTextBox.contain_en(str2))
					{
						text2 = text2 + array[i] + " ";
					}
					else
					{
						text2 += array[i];
					}
				}
				string str3 = text2.Substring(text2.Length - 1, 1);
				string str4 = array[array.Length - 1].Substring(0, 1);
				if (AdvRichTextBox.contain_en(str3) && AdvRichTextBox.contain_en(str4))
				{
					text2 = text2 + array[array.Length - 1] + " ";
				}
				else
				{
					text2 += array[array.Length - 1];
				}
				this.richTextBox1.Text = text2;
			}
			Application.DoEvents();
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000212F File Offset: 0x0000032F
		public void toolStripButtonVoice_Click(object sender, EventArgs e)
		{
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
			HelpWin32.SendMessage(StaticValue.mainhandle, 786, 518);
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000215C File Offset: 0x0000035C
		public void toolStripButtonFull_Click(object sender, EventArgs e)
		{
			this.richTextBox1.SelectAll();
			this.richTextBox1.SelectionAlignment = HelpRepaint.TextAlign.Justify;
			this.richTextBox1.Select(0, 0);
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00004738 File Offset: 0x00002938
		public void toolStripButtonspace_Click(object sender, EventArgs e)
		{
			if (this.toolspace)
			{
				this.richTextBox1.SelectAll();
				this.indent_two(0);
				this.richTextBox1.Select(0, 0);
				this.toolspace = false;
			}
			else
			{
				this.richTextBox1.SelectAll();
				this.indent_two(1);
				this.richTextBox1.Select(0, 0);
				this.toolspace = true;
			}
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000047A8 File Offset: 0x000029A8
		public void toolStripButtonSend_Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(this.richTextBox1.Text);
			HelpWin32.SendMessage(HelpWin32.GetForegroundWindow(), 786, 530);
			HelpWin32.keybd_event(Keys.ControlKey, 0, 0u, 0u);
			HelpWin32.keybd_event(Keys.V, 0, 0u, 0u);
			HelpWin32.keybd_event(Keys.V, 0, 2u, 0u);
			HelpWin32.keybd_event(Keys.ControlKey, 0, 2u, 0u);
			Fmflags fmflags = new Fmflags();
			fmflags.Show();
			fmflags.DrawStr("已复制");
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000218D File Offset: 0x0000038D
		// (set) Token: 0x06000015 RID: 21 RVA: 0x0000219A File Offset: 0x0000039A
		public ContextMenuStrip ContextMenuStrip1
		{
			get
			{
				return this.richTextBox1.ContextMenuStrip;
			}
			set
			{
				this.richTextBox1.ContextMenuStrip = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00004818 File Offset: 0x00002A18
		public string Text_flag
		{
			set
			{
				this.txt_flag = value;
				if (this.txt_flag == "天若幽心")
				{
					this.toolStripToolBar.Items.AddRange(new ToolStripItem[]
					{
						this.topmost,
						this.Fontstyle,
						this.toolStripButtonBold,
						this.toolStripButtonColor,
						this.toolStripButtonLeft,
						this.toolStripButtonFull,
						this.toolStripButtonspace,
						this.toolStripButtonVoice,
						this.toolStripButtonFind,
						this.toolStripButtonSend,
						this.toolStripButtonNote,
						this.toolStripButtonParagraph,
						this.toolStripButtonFence,
						this.toolStripButtonSplit,
						this.toolStripButtonMerge,
						this.toolStripButtoncheck,
						this.toolStripButtonTrans
					});
					return;
				}
				this.toolStripToolBar.Items.AddRange(new ToolStripItem[]
				{
					this.languagle,
					this.Fontstyle,
					this.toolStripButtonBold,
					this.toolStripButtonColor,
					this.toolStripButtonLeft,
					this.toolStripButtonFull,
					this.toolStripButtonspace,
					this.toolStripButtonVoice,
					this.toolStripButtonFind,
					this.toolStripButtonSend,
					this.toolStripButtonclose
				});
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021A8 File Offset: 0x000003A8
		public void toolStripButtonclose_Click(object sender, EventArgs e)
		{
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
			HelpWin32.SendMessage(HelpWin32.GetForegroundWindow(), 786, 511);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000021CA File Offset: 0x000003CA
		public void toolStripButtonTrans_Click(object sender, EventArgs e)
		{
			HelpWin32.SendMessage(StaticValue.mainhandle, 786, 512);
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000207C File Offset: 0x0000027C
		public void toolStripToolBar_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004978 File Offset: 0x00002B78
		private void zh_en_Click(object sender, EventArgs e)
		{
			this.zh_en.ForeColor = Color.Red;
			this.zh_jp.ForeColor = Color.Black;
			this.zh_ko.ForeColor = Color.Black;
			StaticValue.zh_en = true;
			StaticValue.zh_jp = false;
			StaticValue.zh_ko = false;
			HelpWin32.SendMessage(StaticValue.mainhandle, 786, 512);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000049DC File Offset: 0x00002BDC
		private void zh_jp_Click(object sender, EventArgs e)
		{
			this.zh_en.ForeColor = Color.Black;
			this.zh_jp.ForeColor = Color.Red;
			this.zh_ko.ForeColor = Color.Black;
			StaticValue.zh_en = false;
			StaticValue.zh_jp = true;
			StaticValue.zh_ko = false;
			HelpWin32.SendMessage(StaticValue.mainhandle, 786, 512);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00004A40 File Offset: 0x00002C40
		private void zh_ko_Click(object sender, EventArgs e)
		{
			this.zh_en.ForeColor = Color.Black;
			this.zh_jp.ForeColor = Color.Black;
			this.zh_ko.ForeColor = Color.Red;
			StaticValue.zh_en = false;
			StaticValue.zh_jp = false;
			StaticValue.zh_ko = true;
			HelpWin32.SendMessage(StaticValue.mainhandle, 786, 512);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004AA4 File Offset: 0x00002CA4
		public void font_宋体c(object sender, EventArgs e)
		{
			this.font_宋体.ForeColor = Color.Red;
			this.font_黑体.ForeColor = Color.Black;
			this.font_楷体.ForeColor = Color.Black;
			this.font_微软雅黑.ForeColor = Color.Black;
			this.font_新罗马.ForeColor = Color.Black;
			string text = this.richTextBox1.Text;
			this.richTextBox1.Text = "";
			Font font = new Font("宋体", 16f * Program.factor, GraphicsUnit.Pixel);
			this.richTextBox1.Font = font;
			this.richTextBox1.Text = text;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004B4C File Offset: 0x00002D4C
		public void font_黑体c(object sender, EventArgs e)
		{
			this.font_宋体.ForeColor = Color.Black;
			this.font_黑体.ForeColor = Color.Red;
			this.font_楷体.ForeColor = Color.Black;
			this.font_微软雅黑.ForeColor = Color.Black;
			this.font_新罗马.ForeColor = Color.Black;
			string text = this.richTextBox1.Text;
			this.richTextBox1.Text = "";
			Font font = new Font("黑体", 16f * Program.factor, GraphicsUnit.Pixel);
			this.richTextBox1.Font = font;
			this.richTextBox1.Text = text;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004BF4 File Offset: 0x00002DF4
		public void font_楷体c(object sender, EventArgs e)
		{
			this.font_宋体.ForeColor = Color.Black;
			this.font_黑体.ForeColor = Color.Black;
			this.font_楷体.ForeColor = Color.Red;
			this.font_微软雅黑.ForeColor = Color.Black;
			this.font_新罗马.ForeColor = Color.Black;
			string text = this.richTextBox1.Text;
			this.richTextBox1.Text = "";
			Font font = new Font("STKaiti", 16f * Program.factor, GraphicsUnit.Pixel);
			this.richTextBox1.Font = font;
			this.richTextBox1.Text = text;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004C9C File Offset: 0x00002E9C
		public void font_微软雅黑c(object sender, EventArgs e)
		{
			this.font_宋体.ForeColor = Color.Black;
			this.font_黑体.ForeColor = Color.Black;
			this.font_楷体.ForeColor = Color.Black;
			this.font_微软雅黑.ForeColor = Color.Red;
			this.font_新罗马.ForeColor = Color.Black;
			string text = this.richTextBox1.Text;
			this.richTextBox1.Text = "";
			Font font = new Font("微软雅黑", 16f * Program.factor, GraphicsUnit.Pixel);
			this.richTextBox1.Font = font;
			this.richTextBox1.Text = text;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004D44 File Offset: 0x00002F44
		public void font_新罗马c(object sender, EventArgs e)
		{
			this.font_宋体.ForeColor = Color.Black;
			this.font_黑体.ForeColor = Color.Black;
			this.font_楷体.ForeColor = Color.Black;
			this.font_微软雅黑.ForeColor = Color.Black;
			this.font_新罗马.ForeColor = Color.Red;
			string text = this.richTextBox1.Text;
			this.richTextBox1.Text = "";
			Font font = new Font("Times New Roman", 16f * Program.factor, GraphicsUnit.Pixel);
			this.richTextBox1.Font = font;
			this.richTextBox1.Text = text;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004DEC File Offset: 0x00002FEC
		public void indent_two(int fla)
		{
			Font font = new Font(this.Font.Name, 9f * Program.factor, this.Font.Style, this.Font.Unit, this.Font.GdiCharSet, this.Font.GdiVerticalFont);
			Graphics graphics = base.CreateGraphics();
			SizeF sizeF = graphics.MeasureString("中", font);
			this.richTextBox1.SelectionIndent = (int)sizeF.Width * 2 * fla;
			this.richTextBox1.SelectionHangingIndent = -(int)sizeF.Width * 2 * fla;
			graphics.Dispose();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000021EC File Offset: 0x000003EC
		private void richeditbox_TextChanged(object sender, EventArgs e)
		{
			this.c.execute(this.richTextBox1.Text);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002204 File Offset: 0x00000404
		private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			Process.Start(e.LinkText);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002212 File Offset: 0x00000412
		public string SelectText
		{
			get
			{
				return this.richTextBox1.SelectedText;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004E88 File Offset: 0x00003088
		private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
			if (e.Control && e.KeyCode == Keys.V)
			{
				e.SuppressKeyPress = true;
				this.richTextBox1.Paste(DataFormats.GetFormat(DataFormats.Text));
			}
			if (e.Control && e.KeyCode == Keys.Z)
			{
				this.c.undo();
				this.richTextBox1.Text = this.c.Record;
			}
			if (e.Control && e.KeyCode == Keys.Y)
			{
				this.c.redo();
				this.richTextBox1.Text = this.c.Record;
			}
			if (e.Control && e.KeyCode == Keys.F)
			{
				ReplaceForm replaceForm = new ReplaceForm(this);
				if (this.txt_flag == "天若幽心")
				{
					replaceForm.Text = "识别替换";
					replaceForm.Location = base.PointToScreen(new Point((base.Width - replaceForm.Width) / 2, (base.Height - replaceForm.Height) / 2));
				}
				else
				{
					replaceForm.Text = "翻译替换";
					replaceForm.Location = base.PointToScreen(new Point((base.Width - replaceForm.Width) / 2, (base.Height - replaceForm.Height) / 2));
				}
				replaceForm.Show(this);
			}
		}

		// Token: 0x17000005 RID: 5
		// (set) Token: 0x06000027 RID: 39 RVA: 0x0000221F File Offset: 0x0000041F
		public string Find
		{
			set
			{
				new Thread(new ThreadStart(this.错别字检查API)).Start();
				HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004FE4 File Offset: 0x000031E4
		public void 错别字检查API()
		{
			this.richTextBox1.SelectAll();
			this.richTextBox1.SelectionColor = Color.Black;
			this.richTextBox1.Select(0, 0);
			try
			{
				JArray jarray = JArray.Parse(((JObject)JsonConvert.DeserializeObject(this.Post_Html("http://www.cuobiezi.net/api/v1/zh_spellcheck/client/pos/json", "{\"check_mode\": \"value2\",\"content\": \"" + this.richTextBox1.Text + "\", \"content2\": \"value1\",  \"doc_type\": \"value2\",\"method\": \"value2\",\"return_format\": \"value2\",\"username\": \"tianruoyouxin\"}")))["Cases"].ToString());
				for (int i = 0; i < jarray.Count; i++)
				{
					JObject jobject = JObject.Parse(jarray[i].ToString());
					int start = 0;
					int length = this.richTextBox1.Text.Length;
					for (int num = this.richTextBox1.Find(jobject["Error"].ToString(), start, length, RichTextBoxFinds.None); num != -1; num = this.richTextBox1.Find(jobject["Error"].ToString(), start, length, RichTextBoxFinds.None))
					{
						this.richTextBox1.SelectionColor = Color.Red;
						start = num + jobject["Error"].ToString().Length;
					}
				}
				this.richTextBox1.Select(0, 0);
			}
			catch
			{
				this.richTextBox1.Select(0, 0);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005148 File Offset: 0x00003348
		public string Post_Html(string url, string post_str)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(post_str);
			string result = "";
			HttpWebRequest httpWebRequest = WebRequest.Create(url) as HttpWebRequest;
			httpWebRequest.Method = "POST";
			httpWebRequest.Timeout = 3000;
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.Headers.Add("Accept-Encoding: gzip, deflate");
			httpWebRequest.Headers.Add("Accept-Language: zh-CN,en,*");
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

		// Token: 0x0600002A RID: 42 RVA: 0x00002242 File Offset: 0x00000442
		public void richtextbox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000225C File Offset: 0x0000045C
		public void toolStripButtonNote_Click(object sender, EventArgs e)
		{
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
			HelpWin32.SendMessage(StaticValue.mainhandle, 786, 520);
			HelpWin32.SetForegroundWindow(StaticValue.mainhandle);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000207C File Offset: 0x0000027C
		private void Form1_MouseEnter(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002289 File Offset: 0x00000489
		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
				return;
			}
			e.Effect = DragDropEffects.None;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00005234 File Offset: 0x00003434
		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				StaticValue.image_OCR = Image.FromFile((e.Data.GetData(DataFormats.FileDrop, false) as string[])[0]);
				HelpWin32.SendMessage(StaticValue.mainhandle, 786, 580);
			}
			catch (Exception)
			{
				MessageBox.Show("文件格式不正确！", "提醒");
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000022B0 File Offset: 0x000004B0
		public static bool contain_en(string str)
		{
			return Regex.IsMatch(str, "[a-zA-Z]");
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000021EC File Offset: 0x000003EC
		public void TextBox1TextChanged(object sender, EventArgs e)
		{
			this.c.execute(this.richTextBox1.Text);
		}

		// Token: 0x17000006 RID: 6
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000022BD File Offset: 0x000004BD
		public new string Hide
		{
			set
			{
				this.richTextBox1.Focus();
				this.mode.HideDropDown();
				this.Fontstyle.HideDropDown();
				this.languagle.HideDropDown();
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000052A0 File Offset: 0x000034A0
		public void toolStripButtonSplit_keydown(object sender, MouseEventArgs e)
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AdvRichTextBox));
			if (e.Button == MouseButtons.Right)
			{
				if (!this.splitcolor)
				{
					this.toolStripButtonSplit.Image = (Image)componentResourceManager.GetObject("toolStripButtonSplit_2.Image");
					this.toolStripButtonMerge.Image = (Image)componentResourceManager.GetObject("toolStripButtonMerge.Image");
					this.splitcolor = true;
					this.mergecolor = false;
					StaticValue.set_拆分 = true;
					StaticValue.set_合并 = false;
					inihelp.SetValue("工具栏", "拆分", "True");
					inihelp.SetValue("工具栏", "合并", "False");
					return;
				}
				if (this.splitcolor)
				{
					this.toolStripButtonMerge.Image = (Image)componentResourceManager.GetObject("toolStripButtonMerge.Image");
					this.toolStripButtonSplit.Image = (Image)componentResourceManager.GetObject("toolStripButtonSplit.Image");
					this.splitcolor = false;
					this.mergecolor = false;
					StaticValue.set_拆分 = false;
					StaticValue.set_合并 = false;
					inihelp.SetValue("工具栏", "合并", "False");
					inihelp.SetValue("工具栏", "拆分", "False");
				}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000053D4 File Offset: 0x000035D4
		public void toolStripButtonMerge_keydown(object sender, MouseEventArgs e)
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AdvRichTextBox));
			if (e.Button == MouseButtons.Right)
			{
				if (!this.mergecolor)
				{
					this.toolStripButtonMerge.Image = (Image)componentResourceManager.GetObject("toolStripButtonMerge_2.Image");
					this.toolStripButtonSplit.Image = (Image)componentResourceManager.GetObject("toolStripButtonSplit.Image");
					this.splitcolor = false;
					this.mergecolor = true;
					StaticValue.set_拆分 = false;
					StaticValue.set_合并 = true;
					inihelp.SetValue("工具栏", "合并", "True");
					inihelp.SetValue("工具栏", "拆分", "False");
					return;
				}
				if (this.mergecolor)
				{
					this.toolStripButtonMerge.Image = (Image)componentResourceManager.GetObject("toolStripButtonMerge.Image");
					this.toolStripButtonSplit.Image = (Image)componentResourceManager.GetObject("toolStripButtonSplit.Image");
					this.splitcolor = false;
					this.mergecolor = false;
					StaticValue.set_拆分 = false;
					StaticValue.set_合并 = false;
					inihelp.SetValue("工具栏", "合并", "False");
					inihelp.SetValue("工具栏", "拆分", "False");
				}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005508 File Offset: 0x00003708
		public void topmost_keydown(object sender, MouseEventArgs e)
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AdvRichTextBox));
			if (e.Button == MouseButtons.Left)
			{
				if (!this.topmost_flag)
				{
					this.topmost.Image = (Image)componentResourceManager.GetObject("main.Image");
					StaticValue.v_topmost = true;
					this.topmost_flag = true;
					inihelp.SetValue("工具栏", "顶置", "True");
					HelpWin32.SendMessage(StaticValue.mainhandle, 600, 725);
					return;
				}
				this.topmost.Image = (Image)componentResourceManager.GetObject("mode.Image");
				StaticValue.v_topmost = false;
				this.topmost_flag = false;
				inihelp.SetValue("工具栏", "顶置", "False");
				HelpWin32.SendMessage(StaticValue.mainhandle, 600, 725);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000055E4 File Offset: 0x000037E4
		public void readIniFile()
		{
			string value = inihelp.GetValue("工具栏", "顶置");
			if (inihelp.GetValue("工具栏", "顶置") == "发生错误")
			{
				inihelp.SetValue("工具栏", "顶置", "False");
			}
			try
			{
				this.topmost_flag = bool.Parse(value);
			}
			catch
			{
				inihelp.SetValue("工具栏", "顶置", "True");
				this.topmost_flag = true;
			}
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AdvRichTextBox));
			if (this.topmost_flag)
			{
				this.topmost.Image = (Image)componentResourceManager.GetObject("main.Image");
				StaticValue.v_topmost = true;
			}
			if (!this.topmost_flag)
			{
				this.topmost.Image = (Image)componentResourceManager.GetObject("mode.Image");
				StaticValue.v_topmost = false;
			}
			if (inihelp.GetValue("工具栏", "合并") == "发生错误")
			{
				inihelp.SetValue("工具栏", "合并", "False");
			}
			this.mergecolor = bool.Parse(inihelp.GetValue("工具栏", "合并"));
			if (inihelp.GetValue("工具栏", "拆分") == "发生错误")
			{
				inihelp.SetValue("工具栏", "拆分", "False");
			}
			this.splitcolor = bool.Parse(inihelp.GetValue("工具栏", "拆分"));
			if (inihelp.GetValue("工具栏", "检查") == "发生错误")
			{
				inihelp.SetValue("工具栏", "检查", "False");
			}
			this.checkcolor = bool.Parse(inihelp.GetValue("工具栏", "检查"));
			if (inihelp.GetValue("工具栏", "翻译") == "发生错误")
			{
				inihelp.SetValue("工具栏", "翻译", "False");
			}
			this.transcolor = bool.Parse(inihelp.GetValue("工具栏", "翻译"));
			if (inihelp.GetValue("工具栏", "分段") == "发生错误")
			{
				inihelp.SetValue("工具栏", "分段", "False");
			}
			this.Paragraphcolor = bool.Parse(inihelp.GetValue("工具栏", "分段"));
			if (inihelp.GetValue("工具栏", "分栏") == "发生错误")
			{
				inihelp.SetValue("工具栏", "分栏", "False");
			}
			this.Fencecolor = bool.Parse(inihelp.GetValue("工具栏", "分栏"));
			if (this.Fencecolor)
			{
				this.toolStripButtonFence.Image = (Image)componentResourceManager.GetObject("toolStripButtonFence2.Image");
			}
			else
			{
				this.toolStripButtonFence.Image = (Image)componentResourceManager.GetObject("toolStripButtonFence.Image");
			}
			if (this.Paragraphcolor)
			{
				this.toolStripButtonParagraph.Image = (Image)componentResourceManager.GetObject("toolStripButtonParagraph2.Image");
			}
			else
			{
				this.toolStripButtonParagraph.Image = (Image)componentResourceManager.GetObject("toolStripButtonParagraph.Image");
			}
			if (this.checkcolor)
			{
				this.toolStripButtoncheck.Image = (Image)componentResourceManager.GetObject("toolStripButtoncheck2.Image");
			}
			else
			{
				this.toolStripButtoncheck.Image = (Image)componentResourceManager.GetObject("toolStripButtoncheck.Image");
			}
			if (this.mergecolor)
			{
				this.toolStripButtonMerge.Image = (Image)componentResourceManager.GetObject("toolStripButtonMerge_2.Image");
			}
			else
			{
				this.toolStripButtonMerge.Image = (Image)componentResourceManager.GetObject("toolStripButtonMerge.Image");
			}
			if (this.splitcolor)
			{
				this.toolStripButtonSplit.Image = (Image)componentResourceManager.GetObject("toolStripButtonSplit_2.Image");
			}
			else
			{
				this.toolStripButtonSplit.Image = (Image)componentResourceManager.GetObject("toolStripButtonSplit.Image");
			}
			if (this.transcolor)
			{
				this.toolStripButtonTrans.Image = (Image)componentResourceManager.GetObject("toolStripButtonTrans2.Image");
				return;
			}
			this.toolStripButtonTrans.Image = (Image)componentResourceManager.GetObject("toolStripButtonTrans.Image");
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000022EC File Offset: 0x000004EC
		public void saveIniFile()
		{
			inihelp.SetValue("工具栏", "顶置", this.topmost_flag.ToString());
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005A0C File Offset: 0x00003C0C
		public void toolStripButtoncheck_keydown(object sender, MouseEventArgs e)
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AdvRichTextBox));
			if (e.Button == MouseButtons.Right)
			{
				if (!this.checkcolor)
				{
					this.toolStripButtoncheck.Image = (Image)componentResourceManager.GetObject("toolStripButtoncheck2.Image");
					this.checkcolor = true;
					inihelp.SetValue("工具栏", "检查", "True");
					return;
				}
				if (this.checkcolor)
				{
					this.toolStripButtoncheck.Image = (Image)componentResourceManager.GetObject("toolStripButtoncheck.Image");
					this.checkcolor = false;
					inihelp.SetValue("工具栏", "检查", "False");
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005AB8 File Offset: 0x00003CB8
		public void toolStripButtontrans_keydown(object sender, MouseEventArgs e)
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AdvRichTextBox));
			if (e.Button == MouseButtons.Right)
			{
				if (!this.transcolor)
				{
					this.toolStripButtonTrans.Image = (Image)componentResourceManager.GetObject("toolStripButtonTrans2.Image");
					this.transcolor = true;
					inihelp.SetValue("工具栏", "翻译", "True");
					return;
				}
				if (this.transcolor)
				{
					this.toolStripButtonTrans.Image = (Image)componentResourceManager.GetObject("toolStripButtonTrans.Image");
					this.transcolor = false;
					inihelp.SetValue("工具栏", "翻译", "False");
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005B64 File Offset: 0x00003D64
		public void toolStripButtonParagraph_keydown(object sender, MouseEventArgs e)
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AdvRichTextBox));
			if (e.Button == MouseButtons.Right)
			{
				if (!this.Paragraphcolor)
				{
					this.toolStripButtonParagraph.Image = (Image)componentResourceManager.GetObject("toolStripButtonParagraph2.Image");
					this.Paragraphcolor = true;
					inihelp.SetValue("工具栏", "分段", "True");
					return;
				}
				if (this.Paragraphcolor)
				{
					this.toolStripButtonParagraph.Image = (Image)componentResourceManager.GetObject("toolStripButtonParagraph.Image");
					this.Paragraphcolor = false;
					inihelp.SetValue("工具栏", "分段", "False");
				}
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005C10 File Offset: 0x00003E10
		public void toolStripButtonFence_keydown(object sender, MouseEventArgs e)
		{
			if (!File.Exists("cvextern.dll"))
			{
				MessageBox.Show("请从蓝奏网盘中下载cvextern.dll大小约25m，点击确定自动弹出网页。\r\n将下载后的文件与 天若OCR文字识别.exe 这个文件放在一起。");
				Process.Start("https://www.lanzous.com/i1ab3vg");
				return;
			}
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AdvRichTextBox));
			if (e.Button == MouseButtons.Right)
			{
				if (!this.Fencecolor)
				{
					this.toolStripButtonFence.Image = (Image)componentResourceManager.GetObject("toolStripButtonFence2.Image");
					this.Fencecolor = true;
					inihelp.SetValue("工具栏", "分栏", "True");
					return;
				}
				if (this.Fencecolor)
				{
					this.toolStripButtonFence.Image = (Image)componentResourceManager.GetObject("toolStripButtonFence.Image");
					this.Fencecolor = false;
					inihelp.SetValue("工具栏", "分栏", "False");
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002309 File Offset: 0x00000509
		public string Rtf
		{
			set
			{
				this.richTextBox1.Rtf = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002317 File Offset: 0x00000517
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00002309 File Offset: 0x00000509
		public string rtf
		{
			get
			{
				return this.richTextBox1.Rtf;
			}
			set
			{
				this.richTextBox1.Rtf = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00005CDC File Offset: 0x00003EDC
		public string set_language
		{
			set
			{
				if (value == "中英")
				{
					this.zh_en.ForeColor = Color.Red;
					this.zh_jp.ForeColor = Color.Black;
					this.zh_ko.ForeColor = Color.Black;
				}
				if (value == "日语")
				{
					this.zh_en.ForeColor = Color.Black;
					this.zh_jp.ForeColor = Color.Red;
					this.zh_ko.ForeColor = Color.Black;
				}
				if (value == "韩语")
				{
					this.zh_en.ForeColor = Color.Black;
					this.zh_jp.ForeColor = Color.Black;
					this.zh_ko.ForeColor = Color.Red;
				}
			}
		}

		// Token: 0x04000001 RID: 1
		public IContainer components;

		// Token: 0x04000002 RID: 2
		public ToolStripButton toolStripButtonclose;

		// Token: 0x04000003 RID: 3
		public ToolStripButton toolStripButtonBold;

		// Token: 0x04000004 RID: 4
		public ToolStripButton toolStripButtonParagraph;

		// Token: 0x04000005 RID: 5
		public ToolStripButton toolStripButtonFind;

		// Token: 0x04000006 RID: 6
		public ToolStripSeparator toolStripSeparatorFont;

		// Token: 0x04000007 RID: 7
		public ToolStripButton toolStripButtonFence;

		// Token: 0x04000008 RID: 8
		public ToolStripButton toolStripButtonSplit;

		// Token: 0x04000009 RID: 9
		public ToolStripButton toolStripButtoncheck;

		// Token: 0x0400000A RID: 10
		public ToolStripButton toolStripButtonIndent;

		// Token: 0x0400000B RID: 11
		public ToolStripSeparator toolStripSeparatorFormat;

		// Token: 0x0400000C RID: 12
		public ToolStripButton toolStripButtonLeft;

		// Token: 0x0400000D RID: 13
		public ToolStripButton toolStripButtonMerge;

		// Token: 0x0400000E RID: 14
		public ToolStripButton toolStripButtonVoice;

		// Token: 0x0400000F RID: 15
		public ToolStripButton toolStripButtonFull;

		// Token: 0x04000010 RID: 16
		public ToolStripSeparator toolStripSeparatorAlign;

		// Token: 0x04000011 RID: 17
		public ToolStripButton toolStripButtonspace;

		// Token: 0x04000012 RID: 18
		public ToolStripButton toolStripButtonR_arow;

		// Token: 0x04000013 RID: 19
		public ToolStripButton toolStripButtonSend;

		// Token: 0x04000014 RID: 20
		public int dataUpdate;

		// Token: 0x04000015 RID: 21
		public bool toolspace;

		// Token: 0x04000016 RID: 22
		public string txt_flag;

		// Token: 0x04000017 RID: 23
		public ToolStripButton toolStripButtonTrans;

		// Token: 0x04000018 RID: 24
		public bool toolFull;

		// Token: 0x04000019 RID: 25
		public ToolStripDropDownButton languagle;

		// Token: 0x0400001A RID: 26
		public ToolStripMenuItem zh_jp;

		// Token: 0x0400001B RID: 27
		public ToolStripMenuItem zh_ko;

		// Token: 0x0400001C RID: 28
		public ToolStripMenuItem zh_en;

		// Token: 0x0400001D RID: 29
		public ToolStripDropDownButton mode;

		// Token: 0x0400001E RID: 30
		private ToolStripMenuItem mode_顶置;

		// Token: 0x0400001F RID: 31
		private ToolStripMenuItem mode_正常;

		// Token: 0x04000020 RID: 32
		private ToolStripMenuItem mode_合并;

		// Token: 0x04000021 RID: 33
		public ToolStripDropDownButton Fontstyle;

		// Token: 0x04000022 RID: 34
		private ToolStripMenuItem font_宋体;

		// Token: 0x04000023 RID: 35
		private ToolStripMenuItem font_楷体;

		// Token: 0x04000024 RID: 36
		private ToolStripMenuItem font_黑体;

		// Token: 0x04000025 RID: 37
		private ToolStripMenuItem font_微软雅黑;

		// Token: 0x04000026 RID: 38
		private ToolStripMenuItem font_新罗马;

		// Token: 0x04000027 RID: 39
		public HelpRepaint.ColorPicker toolStripButtonColor;

		// Token: 0x04000028 RID: 40
		public RichTextBoxEx richTextBox1;

		// Token: 0x04000029 RID: 41
		public HelpRepaint.ToolStripEx toolStripToolBar;

		// Token: 0x0400002A RID: 42
		private ToolStripButton toolStripButtonNote;

		// Token: 0x0400002B RID: 43
		private AdvRichTextBox.cmd c;

		// Token: 0x0400002C RID: 44
		public bool splitcolor;

		// Token: 0x0400002D RID: 45
		public bool mergecolor;

		// Token: 0x0400002E RID: 46
		public ToolStripButton topmost;

		// Token: 0x0400002F RID: 47
		public bool topmost_flag;

		// Token: 0x04000030 RID: 48
		public bool checkcolor;

		// Token: 0x04000031 RID: 49
		public bool transcolor;

		// Token: 0x04000032 RID: 50
		public bool Paragraphcolor;

		// Token: 0x04000033 RID: 51
		public bool Fencecolor;

		// Token: 0x02000003 RID: 3
		public class cmd
		{
			// Token: 0x0600003F RID: 63 RVA: 0x00002324 File Offset: 0x00000524
			public cmd(int _undoCount)
			{
				this.undoCount = _undoCount + 1;
				this.undoList.Add("");
			}

			// Token: 0x06000040 RID: 64 RVA: 0x00005DA0 File Offset: 0x00003FA0
			public void execute(string command)
			{
				this.temp = command;
				if (!this.und)
				{
					this.undoList.Add(command);
					if (this.undoCount != -1 && this.undoList.Count > this.undoCount)
					{
						this.undoList.RemoveAt(0);
						return;
					}
				}
				else
				{
					this.und = false;
				}
			}

			// Token: 0x06000041 RID: 65 RVA: 0x00005DF8 File Offset: 0x00003FF8
			public void undo()
			{
				if (this.undoList.Count > 1)
				{
					this.und = true;
					this.redoList.Add(this.undoList[this.undoList.Count - 1]);
					this.undoList.RemoveAt(this.undoList.Count - 1);
					this.temp = this.undoList[this.undoList.Count - 1];
				}
			}

			// Token: 0x06000042 RID: 66 RVA: 0x00005E74 File Offset: 0x00004074
			public void redo()
			{
				if (this.redoList.Count > 0)
				{
					this.temp = this.redoList[this.redoList.Count - 1];
					this.redoList.RemoveAt(this.redoList.Count - 1);
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000043 RID: 67 RVA: 0x00002362 File Offset: 0x00000562
			public string Record
			{
				get
				{
					return this.temp;
				}
			}

			// Token: 0x04000034 RID: 52
			private List<string> undoList = new List<string>();

			// Token: 0x04000035 RID: 53
			private List<string> redoList = new List<string>();

			// Token: 0x04000036 RID: 54
			private int undoCount = -1;

			// Token: 0x04000037 RID: 55
			private bool und;

			// Token: 0x04000038 RID: 56
			private string temp;
		}
	}
}
