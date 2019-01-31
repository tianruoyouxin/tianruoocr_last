using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace 天若OCR文字识别
{
	// Token: 0x02000005 RID: 5
	public partial class FmHelp : Form
	{
		// Token: 0x0600004D RID: 77 RVA: 0x000066CC File Offset: 0x000048CC
		public FmHelp()
		{
			this.components = null;
			this.InitializeComponent();
			this.panel_识别说明.Visible = true;
			this.panel_快捷键.Visible = false;
			this.panel_常见问题.Visible = false;
			this.listBox1.Font = new Font("宋体", 10f / Program.factor);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006730 File Offset: 0x00004930
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listBox1.SelectedItem.ToString().Trim() == "快捷键")
			{
				this.panel_快捷键.Location = this.dpi_size();
				this.panel_识别说明.Visible = false;
				this.panel_快捷键.Visible = true;
				this.panel_常见问题.Visible = false;
			}
			if (this.listBox1.SelectedItem.ToString() == "使用说明")
			{
				this.panel_识别说明.Location = this.dpi_size();
				this.panel_识别说明.Visible = true;
				this.panel_快捷键.Visible = false;
				this.panel_常见问题.Visible = false;
			}
			if (this.listBox1.SelectedItem.ToString() == "常见问题")
			{
				this.panel_常见问题.Location = this.dpi_size();
				this.panel_识别说明.Visible = false;
				this.panel_快捷键.Visible = false;
				this.panel_常见问题.Visible = true;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006838 File Offset: 0x00004A38
		private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
		{
			int index = e.Index;
			Graphics graphics = e.Graphics;
			Rectangle bounds = e.Bounds;
			bool flag = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
			if (flag)
			{
				Rectangle rect = new Rectangle(bounds.Left, bounds.Top + 1, bounds.Width, bounds.Height - 4);
				graphics.FillRectangle(Brushes.LightSkyBlue, rect);
			}
			else
			{
				graphics.FillRectangle(Brushes.White, bounds);
			}
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			e.Graphics.DrawString(this.listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.Black), e.Bounds, stringFormat);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00006910 File Offset: 0x00004B10
		private void FmHelp_Load(object sender, EventArgs e)
		{
			this.webBrowser1.DocumentText = "<p>\t<strong><span style=\"font-size:19px;font-family:微软雅黑, sans-serif;line-height:1;\"><strong>使用说明</strong></span></strong><strong><span style=\"font-size:19px;font-family:微软雅黑, sans-serif;line-height:1;\">：</span></strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;line-height:1;\">\t<p style=\"margin-left:8pt;\"><strong>1.</strong><strong>&nbsp;</strong><strong>文字识别</strong>\t</p>\t\t<p style=\"margin-left:8pt;\">按下快捷键-按下鼠标左键-移动鼠标-画出矩形区域-松开鼠标\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>2.</strong><strong>&nbsp;</strong><strong>截图到粘贴板</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-鼠标左键按下-画出矩形区域（鼠标按住）-按下空格键\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>3.</strong><strong>截图自动保存</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-鼠标左键按下-画出矩形区域（鼠标按住）-按下A键\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>4.</strong><strong>截图另存为</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-鼠标左键按下-画出矩形区域（鼠标按住）-按下S键\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>5.</strong><strong>识别后百度</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-鼠标左键按下-画出矩形区域（鼠标按住）-按下B键\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>6.</strong><strong>识别后分割文本</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-鼠标左键按下-画出矩形区域（鼠标按住）-按下数字键1键\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>7.</strong><strong>识别后合并文本</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-鼠标左键按下-画出矩形区域（鼠标按住）-按下数字键2键\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>8.</strong><strong>贴图功能</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-鼠标左键按下-画出矩形区域（鼠标按住）-按下Q键\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>9.</strong><strong>屏幕取色器</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-按下C键-拾取颜色-松开鼠标\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>10.</strong><strong>高级截图功能</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-按下E键-进行截图编辑\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>11.</strong><strong>多选区识别</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-按下Tab键-选择区域-鼠标双击选中区域\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>12.</strong><strong>多选区截图</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-按下Tab键-画区域-按下A键保存\t</p>\t</span></p><p class=\"MsoNormal\">\t<span>&nbsp;</span></p><br /><p>\t<br /></p>";
			this.webBrowser2.DocumentText = "<p>\t&nbsp;<strong><span style=\"font-size:19px;font-family:微软雅黑, sans-serif;line-height:1;\"><strong>常见问题</strong></span></strong><strong><span style=\"font-size:19px;font-family:微软雅黑, sans-serif;line-height:1;\">：</span></strong> </p><p style=\"margin-left:8pt;\">\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;line-height:1;\"> \t<p style=\"margin-left:8pt;\">\t\t<strong>1.</strong><strong>&nbsp;识别出现：--该区域未发现文本--</strong> \t</p>\t<p style=\"margin-left:8pt;\">\t\t<span id=\"__kindeditor_bookmark_start_217__\" style=\"display:none;\"></span>可能1：网络连接不正常<span id=\"__kindeditor_bookmark_end_218__\" style=\"display:none;\"></span> \t</p>\t<p style=\"margin-left:8pt;\">\t\t可能2：接口暂时不能使用，请更换接口\t</p>\t<p style=\"margin-left:8pt;\">\t\t可能3：请检查是否进行了网络代理\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>2.</strong><strong>&nbsp;如何更换接口</strong> \t</p>\t<p style=\"margin-left:8pt;\">\t\t在文本框中右键菜单中进行切换\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>3.如何截图后立即翻译</strong> \t</p>\t<p style=\"margin-left:8pt;\">\t\t在文本框中找到“翻”右键点击变成红色即可\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>4.软件启动第一次识别速度很慢</strong> \t</p>\t<p style=\"margin-left:8pt;\">\t\t请到设置中切换不使用代理\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>5.软件首发地址</strong> \t</p>\t<p style=\"margin-left:8pt;\">链接：<a href=\"https://www.52pojie.cn/thread-692917-1-1.html\" target=\"_blank\">https://www.52pojie.cn/thread-692917-1-1.html</a></p></span>";
			this.webBrowser3.DocumentText = "<p>\t<table class=\"ke-zeroborder\" style=\"width:444px;\" cellspacing=\"0\" cellpadding=\"8\">\t\t<tbody>\t\t\t<tr class=\"firstRow\">\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<strong><span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">快捷键</span></strong> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<strong><span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">功能说明</span></strong> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">A</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">截图自动保存</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">B</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">识别后百度</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">C</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">屏幕取色器</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">E</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">高级截图功能</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Q</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">贴图</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">S</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">截图另存为</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">1</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">识别后分割文本</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">2</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">识别后合并文本</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t</tbody>\t</table>\t<table class=\"ke-zeroborder\" style=\"width:444px;\" cellspacing=\"0\" cellpadding=\"8\">\t\t<tbody>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">Space</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">复制图片到粘贴板</span>\t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t</tbody>\t</table>\t<table class=\"ke-zeroborder\" cellspacing=\"0\" cellpadding=\"8\" style=\"width:444px;\">\t\t<tbody>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">Tab</span>\t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">多选区识别或截图</span>\t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t</tbody>\t</table></p><p>\t<br /></p>";
			this.webBrowser3.ScrollBarsEnabled = false;
			this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
			this.webBrowser2.IsWebBrowserContextMenuEnabled = false;
			this.webBrowser3.IsWebBrowserContextMenuEnabled = false;
			this.webBrowser1.Document.Write("<p>\t<strong><span style=\"font-size:19px;font-family:微软雅黑, sans-serif;line-height:1;\"><strong>使用说明</strong></span></strong><strong><span style=\"font-size:19px;font-family:微软雅黑, sans-serif;line-height:1;\">：</span></strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;line-height:1;\">\t<p style=\"margin-left:8pt;\"><strong>1.</strong><strong>&nbsp;</strong><strong>文字识别</strong>\t</p>\t\t<p style=\"margin-left:8pt;\">按下快捷键-按下鼠标左键-移动鼠标-画出矩形区域-松开鼠标\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>2.</strong><strong>&nbsp;</strong><strong>截图到粘贴板</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-鼠标左键按下-画出矩形区域（鼠标按住）-按下空格键\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>3.</strong><strong>截图自动保存</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-鼠标左键按下-画出矩形区域（鼠标按住）-按下A键\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>4.</strong><strong>截图另存为</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-鼠标左键按下-画出矩形区域（鼠标按住）-按下S键\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>5.</strong><strong>识别后百度</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-鼠标左键按下-画出矩形区域（鼠标按住）-按下B键\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>6.</strong><strong>识别后分割文本</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-鼠标左键按下-画出矩形区域（鼠标按住）-按下数字键1键\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>7.</strong><strong>识别后合并文本</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-鼠标左键按下-画出矩形区域（鼠标按住）-按下数字键2键\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>8.</strong><strong>贴图功能</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-鼠标左键按下-画出矩形区域（鼠标按住）-按下Q键\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>9.</strong><strong>屏幕取色器</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-按下C键-拾取颜色-松开鼠标\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>10.</strong><strong>高级截图功能</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-按下E键-进行截图编辑\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>11.</strong><strong>多选区识别</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-按下Tab键-选择区域-鼠标双击选中区域\t</p>\t<p style=\"margin-left:8pt;\">\t\t<strong>12.</strong><strong>多选区截图</strong>\t</p>\t<p style=\"margin-left:8pt;\">\t\t按下快捷键-按下Tab键-画区域-按下A键保存\t</p>\t</span></p><p class=\"MsoNormal\">\t<span>&nbsp;</span></p><br /><p>\t<br /></p>");
			this.webBrowser1.Document.Body.Style = "ZOOM:0.95";
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FmMain));
			base.Icon = (Icon)componentResourceManager.GetObject("minico.Icon");
			this.panel_识别说明.Location = this.dpi_size();
			using (StreamWriter streamWriter = new StreamWriter("52.txt", true))
			{
				streamWriter.Write("<p>\t<table class=\"ke-zeroborder\" style=\"width:444px;\" cellspacing=\"0\" cellpadding=\"8\">\t\t<tbody>\t\t\t<tr class=\"firstRow\">\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<strong><span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">快捷键</span></strong> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<strong><span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">功能说明</span></strong> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">A</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">截图自动保存</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">B</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">识别后百度</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">C</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">屏幕取色器</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">E</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">高级截图功能</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">Q</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">贴图</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">S</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">截图另存为</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">1</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">识别后分割文本</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">2</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:'微软雅黑',sans-serif;\">识别后合并文本</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t</tbody>\t</table>\t<table class=\"ke-zeroborder\" style=\"width:444px;\" cellspacing=\"0\" cellpadding=\"8\">\t\t<tbody>\t\t\t<tr>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">Space</span> \t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td style=\"background:#f2f2f2;\" valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">复制图片到粘贴板</span>\t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t</tbody>\t</table>\t<table class=\"ke-zeroborder\" cellspacing=\"0\" cellpadding=\"8\" style=\"width:444px;\">\t\t<tbody>\t\t\t<tr>\t\t\t\t<td valign=\"top\" width=\"151\">\t\t\t\t\t<p class=\"MsoListParagraph\" style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">Tab</span>\t\t\t\t\t</p>\t\t\t\t</td>\t\t\t\t<td valign=\"top\" width=\"293\">\t\t\t\t\t<p style=\"text-align:center;\">\t\t\t\t\t\t<span style=\"font-size:13px;font-family:微软雅黑, sans-serif;\">多选区识别或截图</span>\t\t\t\t\t</p>\t\t\t\t</td>\t\t\t</tr>\t\t</tbody>\t</table></p><p>\t<br /></p>");
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006A18 File Offset: 0x00004C18
		public Point dpi_size()
		{
			return new Point(109, 5);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000237B File Offset: 0x0000057B
		private void pic_识别说明_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000237B File Offset: 0x0000057B
		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00006F58 File Offset: 0x00005158
		private void webBrowser_NewWindow(object sender, CancelEventArgs e)
		{
			e.Cancel = true;
			HtmlDocument document = ((WebBrowser)sender).Document;
			if (document != null && document.ActiveElement != null)
			{
				string attribute = document.ActiveElement.GetAttribute("href");
				Help.ShowHelp(this, attribute);
			}
		}
	}
}
