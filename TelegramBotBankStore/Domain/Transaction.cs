using System;

namespace TelegramBotBankStore.Domain
{
	// Token: 0x020000E5 RID: 229
	public class Transaction
	{
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x00003B00 File Offset: 0x00001D00
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x00003B08 File Offset: 0x00001D08
		public long Id { get; set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00003B11 File Offset: 0x00001D11
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x00003B19 File Offset: 0x00001D19
		public TransactionType TransactionType { get; set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00003B22 File Offset: 0x00001D22
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x00003B2A File Offset: 0x00001D2A
		public bool IsAddedToBalance { get; set; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00003B33 File Offset: 0x00001D33
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x00003B3B File Offset: 0x00001D3B
		public long? IdQiwiTransaction { get; set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00003B44 File Offset: 0x00001D44
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x00003B4C File Offset: 0x00001D4C
		public string Address { get; set; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x00003B55 File Offset: 0x00001D55
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x00003B5D File Offset: 0x00001D5D
		public decimal Sum { get; set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00003B66 File Offset: 0x00001D66
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00003B6E File Offset: 0x00001D6E
		public DateTime Din { get; set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00003B77 File Offset: 0x00001D77
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00003B7F File Offset: 0x00001D7F
		public virtual User User { get; set; }

		// Token: 0x0600056C RID: 1388 RVA: 0x00003B88 File Offset: 0x00001D88
		public Transaction()
		{
			this.Din = DateTime.Now;
		}
	}
}
