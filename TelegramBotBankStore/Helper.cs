using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotBankStore.Domain;

namespace TelegramBotBankStore
{
	// Token: 0x0200001C RID: 28
	public class Helper
	{
		// Token: 0x06000078 RID: 120 RVA: 0x0000B870 File Offset: 0x00009A70
		public static async Task SendBotLongMessage(TelegramBotClient client, long chatId, string message, IReplyMarkup replyMarkupBoard = null)
		{
			int len = Encoding.Unicode.GetByteCount(message);
			bool flag = len < 3000;
			if (flag)
			{
				bool flag2 = replyMarkupBoard == null;
				if (flag2)
				{
					await client.SendTextMessageAsync(chatId, message, ParseMode.Html, false, false, 0, null, default(CancellationToken));
				}
				else
				{
					await client.SendTextMessageAsync(chatId, message, ParseMode.Html, false, false, 0, replyMarkupBoard, default(CancellationToken));
				}
			}
			else
			{
				int part = len / 3000;
				string[] spl = message.Split(new string[]
				{
					"\n"
				}, StringSplitOptions.None);
				int insms = spl.Length / part;
				string textSend = "";
				int numbcount = 1;
				for (int i = 0; i < spl.Length; i++)
				{
					textSend = textSend + spl[i] + "\n";
					if (numbcount == insms || i + 1 == spl.Length)
					{
						if (replyMarkupBoard == null)
						{
							await client.SendTextMessageAsync(chatId, textSend, ParseMode.Html, false, false, 0, null, default(CancellationToken));
						}
						else
						{
							await client.SendTextMessageAsync(chatId, textSend, ParseMode.Html, false, false, 0, replyMarkupBoard, default(CancellationToken));
						}
						textSend = "";
						numbcount = 1;
					}
					else
					{
						numbcount++;
					}
				}
				spl = null;
				textSend = null;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000B8CC File Offset: 0x00009ACC
		public static async Task SendOrModifyMessage(TelegramBotClient client, TelegramBotBankStore.Domain.User user, string message, InlineKeyboardMarkup replyMarkupBoard = null)
		{
			bool flag = user.MessageId != null;
			if (flag)
			{
				await client.EditMessageTextAsync(user.ChatId, user.MessageId.Value, message, ParseMode.Html, false, replyMarkupBoard, default(CancellationToken));
			}
			else
			{
				Message message2 = await client.SendTextMessageAsync(user.ChatId, message, ParseMode.Html, false, false, 0, replyMarkupBoard, default(CancellationToken));
				Message respMessage = message2;
				message2 = null;
				user.MessageId = new int?(respMessage.MessageId);
				respMessage = null;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000B928 File Offset: 0x00009B28
		public static async Task<Message> SendPhoto(TelegramBotClient client, long chatId, string pathToPhoto)
		{
			bool flag = System.IO.File.Exists(pathToPhoto);
			if (flag)
			{
				try
				{
					using (FileStream stream = System.IO.File.Open(pathToPhoto, FileMode.Open))
					{
						return await client.SendPhotoAsync(chatId, stream, null, ParseMode.Default, false, 0, null, default(CancellationToken));
					}
				}
				catch
				{
				}
			}
			return null;
		}
	}
}
