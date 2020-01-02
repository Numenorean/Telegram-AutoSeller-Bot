using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace TelegramBotBankStore.Domain
{
	// Token: 0x020000E6 RID: 230
	public class User
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00003B9E File Offset: 0x00001D9E
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00003BA6 File Offset: 0x00001DA6
		public long Id { get; set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00003BAF File Offset: 0x00001DAF
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00003BB7 File Offset: 0x00001DB7
		public long ChatId { get; set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00003BC0 File Offset: 0x00001DC0
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00003BC8 File Offset: 0x00001DC8
		public string Name { get; set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00003BD1 File Offset: 0x00001DD1
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00003BD9 File Offset: 0x00001DD9
		public string UserName { get; set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00003BE2 File Offset: 0x00001DE2
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x00003BEA File Offset: 0x00001DEA
		public string FirstName { get; set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00003BF3 File Offset: 0x00001DF3
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00003BFB File Offset: 0x00001DFB
		public string LastName { get; set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00003C04 File Offset: 0x00001E04
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x00003C0C File Offset: 0x00001E0C
		public string Phone { get; set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00003C15 File Offset: 0x00001E15
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x00003C1D File Offset: 0x00001E1D
		public string CommentForBuy { get; set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00003C26 File Offset: 0x00001E26
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00003C2E File Offset: 0x00001E2E
		public decimal BalanceRUB { get; set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00003C37 File Offset: 0x00001E37
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00003C3F File Offset: 0x00001E3F
		public string Comment { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00003C48 File Offset: 0x00001E48
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00003C50 File Offset: 0x00001E50
		public decimal BalanceLTC { get; set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00003C59 File Offset: 0x00001E59
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00003C61 File Offset: 0x00001E61
		public string WalletLTC { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00003C6A File Offset: 0x00001E6A
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00003C72 File Offset: 0x00001E72
		public decimal BalanceBTC { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00003C7B File Offset: 0x00001E7B
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00003C83 File Offset: 0x00001E83
		public string WalletBTC { get; set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00043F14 File Offset: 0x00042114
		[NotMapped]
		public string IsSupportText
		{
			get
			{
				return this.IsSupport ? "Да" : "Нет";
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00043F3C File Offset: 0x0004213C
		[NotMapped]
		public string IsAdminText
		{
			get
			{
				return this.IsAdmin ? "Да" : "Нет";
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00003C8C File Offset: 0x00001E8C
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00003C94 File Offset: 0x00001E94
		public int? MessageId { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00003C9D File Offset: 0x00001E9D
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00003CA5 File Offset: 0x00001EA5
		public DateTime Din { get; set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00003CAE File Offset: 0x00001EAE
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00003CB6 File Offset: 0x00001EB6
		public bool IsSupport { get; set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00003CBF File Offset: 0x00001EBF
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00003CC7 File Offset: 0x00001EC7
		public bool IsAdmin { get; set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00003CD0 File Offset: 0x00001ED0
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00003CD8 File Offset: 0x00001ED8
		public string Language { get; set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00003CE1 File Offset: 0x00001EE1
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x00003CE9 File Offset: 0x00001EE9
		public bool IsBanned { get; set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00003CF2 File Offset: 0x00001EF2
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00003CFA File Offset: 0x00001EFA
		public int NotFoundAmount { get; set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00003D03 File Offset: 0x00001F03
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00003D0B File Offset: 0x00001F0B
		public long? EdditingCategoryId { get; set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00003D14 File Offset: 0x00001F14
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x00003D1C File Offset: 0x00001F1C
		public long? EdditingProductId { get; set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00003D25 File Offset: 0x00001F25
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x00003D2D File Offset: 0x00001F2D
		public string ProductName { get; set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00003D36 File Offset: 0x00001F36
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00003D3E File Offset: 0x00001F3E
		public decimal ProductPrice { get; set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00003D47 File Offset: 0x00001F47
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00003D4F File Offset: 0x00001F4F
		public string ProductValue { get; set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00043F64 File Offset: 0x00042164
		[NotMapped]
		public int NotFoundStatistic
		{
			get
			{
				double num = (double)this.Products.Count<Product>();
				bool flag = this.NotFoundAmount < 1 || num < 1.0;
				int result;
				if (flag)
				{
					result = 0;
				}
				else
				{
					result = (int)((double)this.NotFoundAmount / num * 100.0);
				}
				return result;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00043FB8 File Offset: 0x000421B8
		public string RefferalName
		{
			get
			{
				string result;
				try
				{
					result = ((this.RefferalUser != null) ? this.RefferalUser.GetFullName() : string.Empty);
				}
				catch
				{
					result = "...";
				}
				return result;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00003D58 File Offset: 0x00001F58
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00003D60 File Offset: 0x00001F60
		public bool IsReferalDone { get; set; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00003D69 File Offset: 0x00001F69
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x00003D71 File Offset: 0x00001F71
		public virtual User RefferalUser { get; set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00044000 File Offset: 0x00042200
		[NotMapped]
		public decimal TotalLoadedBTC
		{
			get
			{
				return (from x in this.Transactions
				where x.TransactionType == TransactionType.BTC
				select x).Sum((Transaction x) => x.Sum);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0004405C File Offset: 0x0004225C
		[NotMapped]
		public decimal TotalLoadedLTC
		{
			get
			{
				return (from x in this.Transactions
				where x.TransactionType == TransactionType.LTC
				select x).Sum((Transaction x) => x.Sum);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x000440B8 File Offset: 0x000422B8
		[NotMapped]
		public decimal TotalLoadedRUB
		{
			get
			{
				return (from x in this.Transactions
				where x.TransactionType == TransactionType.Exmo || x.TransactionType == TransactionType.Qiwi
				select x).Sum((Transaction x) => x.Sum);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00044114 File Offset: 0x00042314
		[NotMapped]
		public decimal TotalReferralBonusBTC
		{
			get
			{
				return Math.Round((from x in this.Transactions
				where x.TransactionType == TransactionType.BTC && x.Address.StartsWith("Refferal")
				select x).Sum((Transaction x) => x.Sum), 8);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x00044178 File Offset: 0x00042378
		[NotMapped]
		public decimal TotalReferralBonusLTC
		{
			get
			{
				return Math.Round((from x in this.Transactions
				where x.TransactionType == TransactionType.LTC && x.Address.StartsWith("Refferal")
				select x).Sum((Transaction x) => x.Sum), 8);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x000441DC File Offset: 0x000423DC
		[NotMapped]
		public decimal TotalReferralBonusRUB
		{
			get
			{
				return Math.Round((from x in this.Transactions
				where x.TransactionType == TransactionType.Qiwi && x.Address.StartsWith("Refferal")
				select x).Sum((Transaction x) => x.Sum), 2);
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00044240 File Offset: 0x00042440
		[NotMapped]
		public decimal TotalSpentBTC
		{
			get
			{
				return (from x in this.Products
				where x.Currency == PayCurrency.BTC && x.PurchaseSum != null && (x.Status == ProductStatus.None || x.Status == ProductStatus.AdminConfirmed || x.Status == ProductStatus.Paid)
				select x).Sum((Product x) => x.PurchaseSum.Value);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0004429C File Offset: 0x0004249C
		[NotMapped]
		public decimal TotalSpentLTC
		{
			get
			{
				return (from x in this.Products
				where x.Currency == PayCurrency.LTC && x.PurchaseSum != null && (x.Status == ProductStatus.None || x.Status == ProductStatus.AdminConfirmed || x.Status == ProductStatus.Paid)
				select x).Sum((Product x) => x.PurchaseSum.Value);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x000442F8 File Offset: 0x000424F8
		[NotMapped]
		public decimal TotalSpentRUB
		{
			get
			{
				return (from x in this.Products
				where x.Currency == PayCurrency.RUB && x.PurchaseSum != null && (x.Status == ProductStatus.None || x.Status == ProductStatus.AdminConfirmed || x.Status == ProductStatus.Paid)
				select x).Sum((Product x) => x.PurchaseSum.Value);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x00003D7A File Offset: 0x00001F7A
		[NotMapped]
		public IEnumerable<Product> ProductsPaid
		{
			get
			{
				return from x in this.Products
				where x.Status == ProductStatus.None || x.Status == ProductStatus.AdminConfirmed || x.Status == ProductStatus.Paid
				select x;
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00044354 File Offset: 0x00042554
		public decimal BalanceBTCInRub(decimal BTC_RATE)
		{
			return this.BalanceBTC * BTC_RATE;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00044374 File Offset: 0x00042574
		public decimal BalanceLTCInRub(decimal LTC_RATE)
		{
			return this.BalanceLTC * LTC_RATE;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00044394 File Offset: 0x00042594
		public decimal BalanceRUBInBTC(decimal RUB_RATE)
		{
			return this.BalanceRUB / RUB_RATE;
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00003DA6 File Offset: 0x00001FA6
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x00003DAE File Offset: 0x00001FAE
		public User.Actions Action { get; set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00003DB7 File Offset: 0x00001FB7
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x00003DBF File Offset: 0x00001FBF
		public virtual ICollection<User> Referals { get; set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x00003DC8 File Offset: 0x00001FC8
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x00003DD0 File Offset: 0x00001FD0
		public virtual ICollection<Product> Products { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x00003DD9 File Offset: 0x00001FD9
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x00003DE1 File Offset: 0x00001FE1
		public virtual ICollection<Transaction> Transactions { get; set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x00003DEA File Offset: 0x00001FEA
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x00003DF2 File Offset: 0x00001FF2
		public virtual ICollection<UserWalletHistory> WalletHistories { get; set; }

		// Token: 0x060005C0 RID: 1472 RVA: 0x000443B4 File Offset: 0x000425B4
		public User()
		{
			this.Din = DateTime.Now;
			this.Language = "ru-RU";
			this.Products = new List<Product>();
			this.Transactions = new List<Transaction>();
			this.WalletHistories = new List<UserWalletHistory>();
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00044408 File Offset: 0x00042608
		public string GetFullName()
		{
			string text = string.Empty;
			bool flag = !string.IsNullOrEmpty(this.Name);
			if (flag)
			{
				text = this.Name;
			}
			bool flag2 = !string.IsNullOrEmpty(this.UserName);
			if (flag2)
			{
				bool flag3 = text != string.Empty;
				if (flag3)
				{
					text += " - ";
				}
				text += this.UserName;
			}
			bool flag4 = !string.IsNullOrEmpty(this.FirstName);
			if (flag4)
			{
				bool flag5 = text != string.Empty;
				if (flag5)
				{
					text += " - ";
				}
				text += this.FirstName;
			}
			bool flag6 = !string.IsNullOrEmpty(this.LastName);
			if (flag6)
			{
				bool flag7 = text != string.Empty;
				if (flag7)
				{
					text += " - ";
				}
				text += this.LastName;
			}
			return text;
		}

		// Token: 0x020000E7 RID: 231
		public enum Actions
		{
			// Token: 0x040007F6 RID: 2038
			None,
			// Token: 0x040007F7 RID: 2039
			Store,
			// Token: 0x040007F8 RID: 2040
			Wallet,
			// Token: 0x040007F9 RID: 2041
			Load,
			// Token: 0x040007FA RID: 2042
			LoadExmoCode,
			// Token: 0x040007FB RID: 2043
			LoadQiwi,
			// Token: 0x040007FC RID: 2044
			WaitForQiwiNumber,
			// Token: 0x040007FD RID: 2045
			LoadLTC,
			// Token: 0x040007FE RID: 2046
			WaitForBuyAmount,
			// Token: 0x040007FF RID: 2047
			WaitForReview,
			// Token: 0x04000800 RID: 2048
			WaitForPromoCode,
			// Token: 0x04000801 RID: 2049
			LoadYandex,
			// Token: 0x04000802 RID: 2050
			LoadTele2,
			// Token: 0x04000803 RID: 2051
			WaitForNotFoundMessage,
			// Token: 0x04000804 RID: 2052
			WaitForSendMoneyMessage,
			// Token: 0x04000805 RID: 2053
			SupportLogin,
			// Token: 0x04000806 RID: 2054
			SupportPassword,
			// Token: 0x04000807 RID: 2055
			Categories,
			// Token: 0x04000808 RID: 2056
			EnterCategoryName,
			// Token: 0x04000809 RID: 2057
			EditCategory,
			// Token: 0x0400080A RID: 2058
			EdditingCategory,
			// Token: 0x0400080B RID: 2059
			EnterProductName,
			// Token: 0x0400080C RID: 2060
			EnterProductPrice,
			// Token: 0x0400080D RID: 2061
			EnterProductValue,
			// Token: 0x0400080E RID: 2062
			EnterProductType,
			// Token: 0x0400080F RID: 2063
			AddPosition
		}
	}
}
