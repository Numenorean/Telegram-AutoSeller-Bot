using System;
using System.Collections.Generic;

namespace TelegramBotBankStore.Domain
{
	// Token: 0x020000DC RID: 220
	public class TelegramPage
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x000037F4 File Offset: 0x000019F4
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x000037FC File Offset: 0x000019FC
		public long Id { get; set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00003805 File Offset: 0x00001A05
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x0000380D File Offset: 0x00001A0D
		public long? ParentId { get; set; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00003816 File Offset: 0x00001A16
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x0000381E File Offset: 0x00001A1E
		public bool IsAnabled { get; set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x00003827 File Offset: 0x00001A27
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x0000382F File Offset: 0x00001A2F
		public string Name { get; set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00003838 File Offset: 0x00001A38
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00003840 File Offset: 0x00001A40
		public string Text { get; set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00003849 File Offset: 0x00001A49
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00003851 File Offset: 0x00001A51
		public string PathPhoto { get; set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0000385A File Offset: 0x00001A5A
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00003862 File Offset: 0x00001A62
		public byte buttonsInOneLine { get; set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0000386B File Offset: 0x00001A6B
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00003873 File Offset: 0x00001A73
		public virtual TelegramPage Parent { get; set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0000387C File Offset: 0x00001A7C
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00003884 File Offset: 0x00001A84
		public virtual ICollection<TelegramPage> Childs { get; set; }

		// Token: 0x06000510 RID: 1296 RVA: 0x0000388D File Offset: 0x00001A8D
		public TelegramPage()
		{
			this.Childs = new List<TelegramPage>();
		}
	}
}
