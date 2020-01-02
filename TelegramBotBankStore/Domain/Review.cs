using System;

namespace TelegramBotBankStore.Domain
{
	// Token: 0x020000DB RID: 219
	public class Review
	{
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0000379A File Offset: 0x0000199A
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x000037A2 File Offset: 0x000019A2
		public long Id { get; set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x000037AB File Offset: 0x000019AB
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x000037B3 File Offset: 0x000019B3
		public string Text { get; set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x000037BC File Offset: 0x000019BC
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x000037C4 File Offset: 0x000019C4
		public string UserName { get; set; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x000037CD File Offset: 0x000019CD
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x000037D5 File Offset: 0x000019D5
		public DateTime Date { get; set; }

		// Token: 0x060004FD RID: 1277 RVA: 0x000037DE File Offset: 0x000019DE
		public Review()
		{
			this.Date = DateTime.Now;
		}
	}
}
