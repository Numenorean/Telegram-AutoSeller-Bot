using System;
using System.Data.Entity.Migrations;
using TelegramBotBankStore.Domain.DbContext;

namespace TelegramBotBankStore.Migrations
{
	// Token: 0x020000D7 RID: 215
	internal sealed class Configuration : DbMigrationsConfiguration<BotContext>
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x00003687 File Offset: 0x00001887
		public Configuration()
		{
			base.AutomaticMigrationsEnabled = true;
			base.AutomaticMigrationDataLossAllowed = true;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000036A1 File Offset: 0x000018A1
		protected override void Seed(BotContext context)
		{
		}
	}
}
