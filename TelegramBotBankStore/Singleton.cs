using System;

namespace TelegramBotBankStore
{
	// Token: 0x020000C2 RID: 194
	public class Singleton
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000382 RID: 898 RVA: 0x000030C2 File Offset: 0x000012C2
		// (set) Token: 0x06000383 RID: 899 RVA: 0x000030C9 File Offset: 0x000012C9
		public static Main Main { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000384 RID: 900 RVA: 0x000030D1 File Offset: 0x000012D1
		// (set) Token: 0x06000385 RID: 901 RVA: 0x000030D8 File Offset: 0x000012D8
		public static string UniqueID { get; set; }

		// Token: 0x06000386 RID: 902 RVA: 0x00002308 File Offset: 0x00000508
		private Singleton()
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0003F698 File Offset: 0x0003D898
		public static Singleton Instance
		{
			get
			{
				bool flag = Singleton.instance == null;
				if (flag)
				{
					Singleton.instance = new Singleton();
				}
				return Singleton.instance;
			}
		}

		// Token: 0x04000706 RID: 1798
		private static Singleton instance;
	}
}
