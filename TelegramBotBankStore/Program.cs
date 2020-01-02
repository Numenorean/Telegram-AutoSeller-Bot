using System;
using System.Windows.Forms;
using log4net;

namespace TelegramBotBankStore
{
	// Token: 0x020000BE RID: 190
	internal static class Program
	{
		// Token: 0x06000375 RID: 885 RVA: 0x0003F474 File Offset: 0x0003D674
		[STAThread]
		private static void Main()
		{
			try
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Main());
			}
			catch (Exception message)
			{
				ILog logger = LogManager.GetLogger("Program");
				logger.Fatal(message);
				throw;
			}
		}
	}
}
