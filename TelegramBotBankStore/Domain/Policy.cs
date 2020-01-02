using System;

namespace TelegramBotBankStore.Domain
{
	// Token: 0x020000E0 RID: 224
	public class Policy
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00003996 File Offset: 0x00001B96
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x0000399E File Offset: 0x00001B9E
		public long Id { get; set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x000039A7 File Offset: 0x00001BA7
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x000039AF File Offset: 0x00001BAF
		public string Name { get; set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x000039B8 File Offset: 0x00001BB8
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x000039C0 File Offset: 0x00001BC0
		public string Value { get; set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x000039C9 File Offset: 0x00001BC9
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x000039D1 File Offset: 0x00001BD1
		public DateTime Din { get; set; }

		// Token: 0x06000533 RID: 1331 RVA: 0x000039DA File Offset: 0x00001BDA
		public Policy()
		{
			this.Din = DateTime.Now;
		}
	}
}
