using System;

namespace TelegramBotBankStore
{
	// Token: 0x020000C7 RID: 199
	public class Data
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00003165 File Offset: 0x00001365
		// (set) Token: 0x0600039C RID: 924 RVA: 0x0000316D File Offset: 0x0000136D
		public DateTime payDate { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00003176 File Offset: 0x00001376
		// (set) Token: 0x0600039E RID: 926 RVA: 0x0000317E File Offset: 0x0000137E
		public Sum sum { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00003187 File Offset: 0x00001387
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x0000318F File Offset: 0x0000138F
		public string type { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00003198 File Offset: 0x00001398
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x000031A0 File Offset: 0x000013A0
		public string description { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x000031A9 File Offset: 0x000013A9
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x000031B1 File Offset: 0x000013B1
		public string imageURL { get; set; }
	}
}
