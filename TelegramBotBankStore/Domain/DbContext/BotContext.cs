using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.IO;
using TelegramBotBankStore.Migrations;

namespace TelegramBotBankStore.Domain.DbContext
{
	// Token: 0x020000E9 RID: 233
	public class BotContext : DbContext
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x000445F0 File Offset: 0x000427F0
		public BotContext() : base("Data Source=DataBase\\TelegramBotBankAdminDB.sdf;Persist Security Info=True")
		{
			bool flag = !Directory.Exists("DataBase");
			if (flag)
			{
				Directory.CreateDirectory("DataBase");
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00003E96 File Offset: 0x00002096
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x00003E9E File Offset: 0x0000209E
		public virtual DbSet<User> Users { get; set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x00003EA7 File Offset: 0x000020A7
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x00003EAF File Offset: 0x000020AF
		public virtual DbSet<Category> Categories { get; set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x00003EB8 File Offset: 0x000020B8
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x00003EC0 File Offset: 0x000020C0
		public virtual DbSet<Product> Products { get; set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x00003EC9 File Offset: 0x000020C9
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00003ED1 File Offset: 0x000020D1
		public virtual DbSet<Transaction> Transactions { get; set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00003EDA File Offset: 0x000020DA
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00003EE2 File Offset: 0x000020E2
		public virtual DbSet<Policy> Policies { get; set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00003EEB File Offset: 0x000020EB
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00003EF3 File Offset: 0x000020F3
		public virtual DbSet<Review> Reviews { get; set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00003EFC File Offset: 0x000020FC
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00003F04 File Offset: 0x00002104
		public virtual DbSet<PromoCode> PromoCodes { get; set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00003F0D File Offset: 0x0000210D
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x00003F15 File Offset: 0x00002115
		public virtual DbSet<UserWalletHistory> UsersWalletHistories { get; set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00003F1E File Offset: 0x0000211E
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00003F26 File Offset: 0x00002126
		public virtual DbSet<TelegramPage> TelegramPages { get; set; }

		// Token: 0x060005EA RID: 1514 RVA: 0x00044628 File Offset: 0x00042828
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			Database.SetInitializer<BotContext>(new CreateDatabaseIfNotExists<BotContext>());
			Database.SetInitializer<BotContext>(new MigrateDatabaseToLatestVersion<BotContext, Configuration>());
			base.OnModelCreating(modelBuilder);
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Entity<User>().Property((User x) => x.BalanceBTC).HasPrecision(12, 10);
			modelBuilder.Entity<User>().Property((User x) => x.BalanceLTC).HasPrecision(12, 10);
			modelBuilder.Entity<User>().Property((User x) => x.BalanceRUB).HasPrecision(7, 1);
			modelBuilder.Entity<Transaction>().Property((Transaction x) => x.Sum).HasPrecision(17, 10);
			modelBuilder.Entity<Product>().Property((Product x) => x.PurchaseSum).HasPrecision(17, 10);
			modelBuilder.Entity<Product>().Property((Product x) => x.SumToPay).HasPrecision(14, 8);
			modelBuilder.Entity<Product>().Property((Product x) => x.Positions).HasColumnType("ntext").IsMaxLength();
			modelBuilder.Entity<Category>().HasOptional<Category>((Category x) => x.Parent).WithMany((Category x) => x.Childs).HasForeignKey<long?>((Category x) => x.ParentId).WillCascadeOnDelete(false);
			modelBuilder.Entity<Category>().HasMany<Product>((Category x) => x.Products).WithOptional().WillCascadeOnDelete(true);
			modelBuilder.Entity<User>().HasMany<Product>((User x) => x.Products).WithOptional().WillCascadeOnDelete(true);
			modelBuilder.Entity<User>().HasMany<Transaction>((User x) => x.Transactions).WithOptional().WillCascadeOnDelete(true);
			modelBuilder.Entity<PromoCode>().Property((PromoCode x) => x.Value).HasPrecision(7, 1);
			modelBuilder.Entity<PromoCode>().HasOptional<User>((PromoCode j) => j.User).WithMany().WillCascadeOnDelete(true);
			modelBuilder.Entity<TelegramPage>().HasOptional<TelegramPage>((TelegramPage x) => x.Parent).WithMany((TelegramPage x) => x.Childs).HasForeignKey<long?>((TelegramPage x) => x.ParentId).WillCascadeOnDelete(false);
			modelBuilder.Entity<User>().HasMany<UserWalletHistory>((User x) => x.WalletHistories).WithOptional().WillCascadeOnDelete(true);
		}

		// Token: 0x04000824 RID: 2084
		public const string DirName = "DataBase";

		// Token: 0x04000825 RID: 2085
		private const string connectionString = "Data Source=DataBase\\TelegramBotBankAdminDB.sdf;Persist Security Info=True";
	}
}
