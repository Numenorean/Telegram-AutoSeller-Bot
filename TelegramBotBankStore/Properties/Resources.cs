using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace TelegramBotBankStore.Properties
{
	// Token: 0x020000D5 RID: 213
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x060003D5 RID: 981 RVA: 0x00002308 File Offset: 0x00000508
		internal Resources()
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00041CC0 File Offset: 0x0003FEC0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("TelegramBotBankStore.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00041D08 File Offset: 0x0003FF08
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00003233 File Offset: 0x00001433
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00041D20 File Offset: 0x0003FF20
		internal static Bitmap edit_dark
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("edit_dark", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00041D50 File Offset: 0x0003FF50
		internal static Bitmap message
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("message", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00041D80 File Offset: 0x0003FF80
		internal static Bitmap remove_dark
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("remove_dark", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000775 RID: 1909
		private static ResourceManager resourceMan;

		// Token: 0x04000776 RID: 1910
		private static CultureInfo resourceCulture;
	}
}
