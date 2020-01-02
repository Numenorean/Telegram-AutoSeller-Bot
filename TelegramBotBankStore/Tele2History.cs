using System;
using System.Collections.Generic;

namespace TelegramBotBankStore
{
	// Token: 0x020000C5 RID: 197
	public class Tele2History
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00003121 File Offset: 0x00001321
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00003129 File Offset: 0x00001329
		public Meta meta { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00003132 File Offset: 0x00001332
		// (set) Token: 0x06000394 RID: 916 RVA: 0x0000313A File Offset: 0x0000133A
		public List<Data> data { get; set; }
	}
}
