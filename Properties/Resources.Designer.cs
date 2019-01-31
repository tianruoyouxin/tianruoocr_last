using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace 天若OCR文字识别.Properties
{
	// Token: 0x02000031 RID: 49
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x060002A1 RID: 673 RVA: 0x00002F37 File Offset: 0x00001137
		internal Resources()
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0001F870 File Offset: 0x0001DA70
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				bool flag2 = flag;
				bool flag3 = flag2;
				if (flag3)
				{
					ResourceManager resourceManager = new ResourceManager("天若OCR文字识别.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0001F8BC File Offset: 0x0001DABC
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00002F41 File Offset: 0x00001141
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0001F8D4 File Offset: 0x0001DAD4
		internal static Bitmap 二维码
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("二维码", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0001F904 File Offset: 0x0001DB04
		internal static Bitmap 头像
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("头像", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0001F934 File Offset: 0x0001DB34
		internal static Bitmap 帮助
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("帮助", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0001F964 File Offset: 0x0001DB64
		internal static Bitmap 快捷键_0
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("快捷键_0", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0001F994 File Offset: 0x0001DB94
		internal static Bitmap 快捷键_1
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("快捷键_1", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0001F9C4 File Offset: 0x0001DBC4
		internal static Bitmap 语音按钮
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("语音按钮", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000226 RID: 550
		private static ResourceManager resourceMan;

		// Token: 0x04000227 RID: 551
		private static CultureInfo resourceCulture;
	}
}
