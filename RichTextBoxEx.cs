using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace 天若OCR文字识别
{
	// Token: 0x02000034 RID: 52
	public class RichTextBoxEx : HelpRepaint.AdvRichTextBox
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x00002FA2 File Offset: 0x000011A2
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002FC1 File Offset: 0x000011C1
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x060002B9 RID: 697
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr LoadLibrary(string path);

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00002FD6 File Offset: 0x000011D6
		// (set) Token: 0x060002BC RID: 700 RVA: 0x00002FDE File Offset: 0x000011DE
		[Bindable(true)]
		[RefreshProperties(RefreshProperties.All)]
		[SettingsBindable(true)]
		[DefaultValue(false)]
		[Category("Appearance")]
		public string Rtf2
		{
			get
			{
				return base.Rtf;
			}
			set
			{
				base.Rtf = value;
			}
		}

		// Token: 0x04000235 RID: 565
		private IContainer components;

		// Token: 0x04000236 RID: 566
		private static IntPtr moduleHandle;
	}
}
