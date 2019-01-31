using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using mshtml;

namespace 天若OCR文字识别
{
	// Token: 0x0200003B RID: 59
	public partial class aliFMtable : Form
	{
		// Token: 0x06000301 RID: 769 RVA: 0x00020304 File Offset: 0x0001E504
		public aliFMtable()
		{
			string fileName = Path.GetFileName(Application.ExecutablePath);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
			if (registryKey != null)
			{
				registryKey.SetValue(fileName, 11001, RegistryValueKind.DWord);
				registryKey.SetValue(fileName, 11001, RegistryValueKind.DWord);
			}
			registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
			if (registryKey != null)
			{
				registryKey.SetValue(fileName, 11001, RegistryValueKind.DWord);
				registryKey.SetValue(fileName, 11001, RegistryValueKind.DWord);
			}
			this.InitializeComponent();
		}

		// Token: 0x06000302 RID: 770
		[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool InternetGetCookieEx(string pchURL, string pchCookieName, StringBuilder pchCookieData, ref int pcchCookieData, int dwFlags, object lpReserved);

		// Token: 0x06000303 RID: 771 RVA: 0x00020398 File Offset: 0x0001E598
		private string GetCookieString(string url)
		{
			int num = 256;
			StringBuilder stringBuilder = new StringBuilder(num);
			if (!aliFMtable.InternetGetCookieEx(url, null, stringBuilder, ref num, 8192, null))
			{
				if (num < 0)
				{
					return null;
				}
				stringBuilder = new StringBuilder(num);
				if (!aliFMtable.InternetGetCookieEx(url, null, stringBuilder, ref num, 8192, null))
				{
					return null;
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000203F4 File Offset: 0x0001E5F4
		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			try
			{
				this.count++;
				this.textBox1.Text = this.GetCookieString(e.Url.ToString());
				this.webBrowser1.Document.Window.ScrollTo(10000, 145);
				this.webBrowser1.Document.Body.SetAttribute("scroll", "no");
				this.webBrowser1.Document.GetElementById("guid-762944").OuterHtml = "";
				if (this.count <= 10)
				{
					this.timer1.Interval = 500;
					this.timer1.Start();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00003007 File Offset: 0x00001207
		private void Form2_Load(object sender, EventArgs e)
		{
			this.webBrowser1.Url = new Uri("https://data.aliyun.com/ai/ocr-other#/ocr-other");
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000204C4 File Offset: 0x0001E6C4
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (this.textBox1.Text.Contains("login_aliyunid=\""))
			{
				this.webBrowser1.Url = new Uri("https://data.aliyun.com/ai/ocr-other#/ocr-other");
				inihelp.SetValue("特殊", "ali_cookie", this.textBox1.Text);
				base.Hide();
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00020520 File Offset: 0x0001E720
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.webBrowser1.ReadyState == WebBrowserReadyState.Complete)
			{
				try
				{
					this.cclick();
				}
				catch
				{
				}
				if (this.count >= 2)
				{
					this.count = 0;
					base.Show();
				}
				this.timer1.Stop();
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00003043 File Offset: 0x00001243
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00003007 File Offset: 0x00001207
		public string getcookie
		{
			get
			{
				return this.textBox1.Text;
			}
			set
			{
				this.webBrowser1.Url = new Uri("https://data.aliyun.com/ai/ocr-other#/ocr-other");
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00020760 File Offset: 0x0001E960
		private bool ComposeEncrypt_onclick()
		{
			IHTMLDocument3 documentFromWindow = webrowserHelper.GetDocumentFromWindow(this.webBrowser1.Document.Window.Frames["alibaba-login-box"].DomWindow as IHTMLWindow2);
			string value = documentFromWindow.getElementById("fm-login-id").getAttribute("value", 0).ToString();
			string value2 = documentFromWindow.getElementById("fm-login-password").getAttribute("value", 0).ToString();
			inihelp.SetValue("特殊", "ali_account", value);
			inihelp.SetValue("特殊", "ali_password", value2);
			this.timer1.Stop();
			return true;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00020800 File Offset: 0x0001EA00
		public void cclick()
		{
			try
			{
				if (inihelp.GetValue("特殊", "ali_account").Trim() != "" && inihelp.GetValue("特殊", "ali_password").Trim() != "")
				{
					webrowserHelper.GetDocumentFromWindow(this.webBrowser1.Document.Window.Frames["alibaba-login-box"].DomWindow as IHTMLWindow2).getElementById("fm-login-id").setAttribute("value", inihelp.GetValue("特殊", "ali_account"), 1);
					webrowserHelper.GetDocumentFromWindow(this.webBrowser1.Document.Window.Frames["alibaba-login-box"].DomWindow as IHTMLWindow2).getElementById("fm-login-password").setAttribute("value", inihelp.GetValue("特殊", "ali_password"), 1);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0400024B RID: 587
		private int count;
	}
}
