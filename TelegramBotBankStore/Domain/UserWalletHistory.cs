using System;

namespace TelegramBotBankStore.Domain
{
	// Token: 0x020000DE RID: 222
	public class UserWalletHistory
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x000038A3 File Offset: 0x00001AA3
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x000038AB File Offset: 0x00001AAB
		public long Id { get; set; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x000038B4 File Offset: 0x00001AB4
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x000038BC File Offset: 0x00001ABC
		public HistoryType HistoryType { get; set; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x000038C5 File Offset: 0x00001AC5
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x000038CD File Offset: 0x00001ACD
		public string Address { get; set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x000038D6 File Offset: 0x00001AD6
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x000038DE File Offset: 0x00001ADE
		public DateTime Date { get; set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x000038E7 File Offset: 0x00001AE7
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x000038EF File Offset: 0x00001AEF
		public virtual User User { get; set; }

		// Token: 0x0600051B RID: 1307 RVA: 0x000038F8 File Offset: 0x00001AF8
		public UserWalletHistory()
		{
			this.Date = DateTime.Now;
		}
	}
}
