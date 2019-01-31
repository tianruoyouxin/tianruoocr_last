using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace 天若OCR文字识别.Properties
{
	// Token: 0x02000032 RID: 50
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0001F9F4 File Offset: 0x0001DBF4
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000228 RID: 552
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
