using System;

namespace TelegramBotBankStore.Domain
{
	// Token: 0x020000E2 RID: 226
	public enum ProductStatus
	{
		// Token: 0x040007AE RID: 1966
		None,
		// Token: 0x040007AF RID: 1967
		WaitForPay,
		// Token: 0x040007B0 RID: 1968
		Canceled,
		// Token: 0x040007B1 RID: 1969
		Paid,
		// Token: 0x040007B2 RID: 1970
		AdminConfirmed,
		// Token: 0x040007B3 RID: 1971
		AdminCanceled,
		// Token: 0x040007B4 RID: 1972
		TimeOut
	}
}
