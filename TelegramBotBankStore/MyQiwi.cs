using System;
using System.Threading;
using System.Threading.Tasks;
using QiwiApi;
using QiwiApi.Models;

namespace TelegramBotBankStore
{
	// Token: 0x020000C0 RID: 192
	public class MyQiwi
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00003074 File Offset: 0x00001274
		// (set) Token: 0x06000378 RID: 888 RVA: 0x0000307C File Offset: 0x0000127C
		public string Number { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00003085 File Offset: 0x00001285
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0000308D File Offset: 0x0000128D
		public string API { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00003096 File Offset: 0x00001296
		// (set) Token: 0x0600037C RID: 892 RVA: 0x0000309E File Offset: 0x0000129E
		public Qiwi QiwiConnection { get; set; }

		// Token: 0x0600037D RID: 893 RVA: 0x0003F4C8 File Offset: 0x0003D6C8
		public async Task<History> GetHistory()
		{
			bool flag = this._historyQiwi == null || this._historyQiwi.Payments == null || (DateTime.Now - this._historydateTime).TotalSeconds >= 300.0;
			if (flag)
			{
				History historyQiwi = await this.QiwiConnection.GetHistoryAsync(null, null, default(CancellationToken));
				this._historyQiwi = historyQiwi;
				historyQiwi = null;
				this._historydateTime = DateTime.Now;
			}
			return this._historyQiwi;
		}

		// Token: 0x040006FF RID: 1791
		private History _historyQiwi = null;

		// Token: 0x04000700 RID: 1792
		private DateTime _historydateTime = DateTime.MinValue;
	}
}
