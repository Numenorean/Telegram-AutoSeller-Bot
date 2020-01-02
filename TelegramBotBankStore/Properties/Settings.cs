using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TelegramBotBankStore.Properties
{
	// Token: 0x020000D6 RID: 214
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.2.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x00042104 File Offset: 0x00040304
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x000033CA File Offset: 0x000015CA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public StringCollection QiwiListSettings
		{
			get
			{
				return (StringCollection)this["QiwiListSettings"];
			}
			set
			{
				this["QiwiListSettings"] = value;
			}
		}
	}
}
