using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelegramBotBankStore.Domain
{
	// Token: 0x020000E3 RID: 227
	public class Product
	{
		// Token: 0x06000534 RID: 1332 RVA: 0x00043C80 File Offset: 0x00041E80
		private static void Copy(Product copyFrom, Product copyTo)
		{
			copyTo.Name = copyFrom.Name;
			copyTo.Status = copyFrom.Status;
			copyTo.HistoryCategoryName = copyFrom.HistoryCategoryName;
			copyTo.HistoryCategoryId = copyFrom.HistoryCategoryId;
			copyTo.HistoryOnePositionPrice = copyFrom.HistoryOnePositionPrice;
			copyTo.SumToPay = copyFrom.SumToPay;
			copyTo.Currency = copyFrom.Currency;
			copyTo.Price = copyFrom.Price;
			copyTo.Positions = copyFrom.Positions;
			copyTo.PurchaseSum = copyFrom.PurchaseSum;
			copyTo.PurchasePosition = copyFrom.PurchasePosition;
			copyTo.PurchaseDate = copyFrom.PurchaseDate;
			copyTo.Category = copyFrom.Category;
			copyTo.User = copyFrom.User;
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x000039F0 File Offset: 0x00001BF0
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x000039F8 File Offset: 0x00001BF8
		public long Id { get; set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00003A01 File Offset: 0x00001C01
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00003A09 File Offset: 0x00001C09
		public string Name { get; set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00003A12 File Offset: 0x00001C12
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00003A1A File Offset: 0x00001C1A
		public ProductStatus Status { get; set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00003A23 File Offset: 0x00001C23
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00003A2B File Offset: 0x00001C2B
		public string HistoryCategoryName { get; set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00003A34 File Offset: 0x00001C34
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00003A3C File Offset: 0x00001C3C
		public long? HistoryCategoryId { get; set; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00003A45 File Offset: 0x00001C45
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00003A4D File Offset: 0x00001C4D
		public decimal? HistoryOnePositionPrice { get; set; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00003A56 File Offset: 0x00001C56
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00003A5E File Offset: 0x00001C5E
		public decimal? SumToPay { get; set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00003A67 File Offset: 0x00001C67
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00003A6F File Offset: 0x00001C6F
		public PayCurrency Currency { get; set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00003A78 File Offset: 0x00001C78
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00003A80 File Offset: 0x00001C80
		public decimal Price { get; set; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00003A89 File Offset: 0x00001C89
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00003A91 File Offset: 0x00001C91
		public string Positions { get; set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00043D44 File Offset: 0x00041F44
		[NotMapped]
		public decimal PurchaseSumValue
		{
			get
			{
				return (this.PurchaseSum != null) ? Math.Round(this.PurchaseSum.Value, 10) : 0m;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00003A9A File Offset: 0x00001C9A
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x00003AA2 File Offset: 0x00001CA2
		public decimal? PurchaseSum { get; set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00003AAB File Offset: 0x00001CAB
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x00003AB3 File Offset: 0x00001CB3
		public string PurchasePosition { get; set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00003ABC File Offset: 0x00001CBC
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x00003AC4 File Offset: 0x00001CC4
		public DateTime? PurchaseDate { get; set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00003ACD File Offset: 0x00001CCD
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x00003AD5 File Offset: 0x00001CD5
		public bool IsForOperator { get; set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00043D84 File Offset: 0x00041F84
		[NotMapped]
		public int PositionsCount
		{
			get
			{
				return this.PositionsList.Count;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00043DA4 File Offset: 0x00041FA4
		[NotMapped]
		public List<string> PositionsList
		{
			get
			{
				List<string> list = new List<string>();
				bool flag = !string.IsNullOrEmpty(this.Positions);
				if (flag)
				{
					string[] array = this.Positions.Split(new string[]
					{
						"\r\n"
					}, StringSplitOptions.RemoveEmptyEntries);
					foreach (string item in array)
					{
						list.Add(item);
					}
				}
				return list;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00003ADE File Offset: 0x00001CDE
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x00003AE6 File Offset: 0x00001CE6
		public virtual Category Category { get; set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00003AEF File Offset: 0x00001CEF
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x00003AF7 File Offset: 0x00001CF7
		public virtual User User { get; set; }

		// Token: 0x06000558 RID: 1368 RVA: 0x00043E14 File Offset: 0x00042014
		public decimal PriceIn_BTC_Or_LTC(decimal rate, decimal discount)
		{
			decimal num = decimal.Parse((this.Price / rate).ToString());
			bool flag = discount > 0m && discount <= 100m;
			if (flag)
			{
				num -= decimal.Multiply(num, discount) / 100m;
			}
			return Math.Round(num, 8);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00043E88 File Offset: 0x00042088
		public decimal PriceWithDiscount(decimal discount)
		{
			decimal num = this.Price;
			bool flag = discount > 0m && discount <= 100m;
			if (flag)
			{
				num -= decimal.Multiply(num, discount) / 100m;
			}
			return Math.Round(num);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00043EE8 File Offset: 0x000420E8
		public static void ExchangeProduct(Product product, Product product2)
		{
			Product product3 = new Product();
			Product.Copy(product, product3);
			Product.Copy(product2, product);
			Product.Copy(product3, product2);
		}
	}
}
