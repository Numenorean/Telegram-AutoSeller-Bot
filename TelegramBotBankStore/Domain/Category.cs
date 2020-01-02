using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelegramBotBankStore.Domain
{
	// Token: 0x020000DF RID: 223
	public class Category
	{
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0000390E File Offset: 0x00001B0E
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00003916 File Offset: 0x00001B16
		public long Id { get; set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x0000391F File Offset: 0x00001B1F
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00003927 File Offset: 0x00001B27
		public long? ParentId { get; set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00003930 File Offset: 0x00001B30
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00003938 File Offset: 0x00001B38
		public string Name { get; set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00043AF0 File Offset: 0x00041CF0
		[NotMapped]
		public string NameFull
		{
			get
			{
				string text = string.Empty;
				List<string> list = new List<string>();
				list.Insert(0, this.Name);
				for (Category parent = this.Parent; parent != null; parent = parent.Parent)
				{
					list.Insert(0, parent.Name);
				}
				foreach (string str in list)
				{
					text = text + str + " → ";
				}
				text = text.Remove(text.Length - 2, 2);
				return text;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00003941 File Offset: 0x00001B41
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00003949 File Offset: 0x00001B49
		public virtual Category Parent { get; set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00003952 File Offset: 0x00001B52
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x0000395A File Offset: 0x00001B5A
		public virtual ICollection<Category> Childs { get; set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00003963 File Offset: 0x00001B63
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x0000396B File Offset: 0x00001B6B
		public virtual ICollection<Product> Products { get; set; }

		// Token: 0x06000529 RID: 1321 RVA: 0x00003974 File Offset: 0x00001B74
		public Category()
		{
			this.Childs = new List<Category>();
			this.Products = new List<Product>();
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00043BA8 File Offset: 0x00041DA8
		public static void ExchangeCategory(Category category, Category category2)
		{
			Category category3 = new Category();
			category3.ParentId = category.ParentId;
			category3.Name = category.Name;
			category3.Parent = category.Parent;
			category3.Childs = category.Childs;
			category3.Products = category.Products;
			category.ParentId = category2.ParentId;
			category.Name = category2.Name;
			category.Parent = category2.Parent;
			category.Childs = category2.Childs;
			category.Products = category2.Products;
			category2.ParentId = category3.ParentId;
			category2.Name = category3.Name;
			category2.Parent = category3.Parent;
			category2.Childs = category3.Childs;
			category2.Products = category3.Products;
		}
	}
}
