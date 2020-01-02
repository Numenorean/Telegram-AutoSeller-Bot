using System;

namespace TelegramBotBankStore.Domain
{
	// Token: 0x020000DA RID: 218
	public class PromoCode
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x000036AD File Offset: 0x000018AD
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x000036B5 File Offset: 0x000018B5
		public long Id { get; set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x000036BE File Offset: 0x000018BE
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x000036C6 File Offset: 0x000018C6
		public string Name { get; set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x000036CF File Offset: 0x000018CF
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x000036D7 File Offset: 0x000018D7
		public bool IsApplied { get; set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x000036E0 File Offset: 0x000018E0
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x000036E8 File Offset: 0x000018E8
		public PromoCodeEnum PromoCodeType { get; set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x000036F1 File Offset: 0x000018F1
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x000036F9 File Offset: 0x000018F9
		public decimal Value { get; set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00003702 File Offset: 0x00001902
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x0000370A File Offset: 0x0000190A
		public decimal DiscountFrom { get; set; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00003713 File Offset: 0x00001913
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x0000371B File Offset: 0x0000191B
		public DateTime DateCreate { get; set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00003724 File Offset: 0x00001924
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x0000372C File Offset: 0x0000192C
		public DateTime? DateApply { get; set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00003735 File Offset: 0x00001935
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x0000373D File Offset: 0x0000193D
		public int NumberOfCurrentPromo { get; set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00003746 File Offset: 0x00001946
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x0000374E File Offset: 0x0000194E
		public int MaxNumberOfCurrentPromo { get; set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00003757 File Offset: 0x00001957
		public string UserName
		{
			get
			{
				return (this.User == null) ? "" : this.User.GetFullName();
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00003773 File Offset: 0x00001973
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x0000377B File Offset: 0x0000197B
		public virtual User User { get; set; }

		// Token: 0x060004F4 RID: 1268 RVA: 0x00003784 File Offset: 0x00001984
		public PromoCode()
		{
			this.DateCreate = DateTime.Now;
		}
	}
}
