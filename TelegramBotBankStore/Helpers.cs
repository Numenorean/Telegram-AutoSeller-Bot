using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace TelegramBotBankStore
{
	// Token: 0x02000019 RID: 25
	public static class Helpers
	{
		// Token: 0x0600006F RID: 111 RVA: 0x0000B0A8 File Offset: 0x000092A8
		public static NameValueCollection ToNameValueCollection<TKey, TValue>(this IDictionary<TKey, TValue> dict)
		{
			NameValueCollection nameValueCollection = new NameValueCollection();
			foreach (KeyValuePair<TKey, TValue> keyValuePair in dict)
			{
				string value = string.Empty;
				bool flag = keyValuePair.Value != null;
				if (flag)
				{
					TValue value2 = keyValuePair.Value;
					value = value2.ToString();
				}
				NameValueCollection nameValueCollection2 = nameValueCollection;
				TKey key = keyValuePair.Key;
				nameValueCollection2.Add(key.ToString(), value);
			}
			return nameValueCollection;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000B14C File Offset: 0x0000934C
		public static long GetTimestamp()
		{
			double totalMilliseconds = (DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
			return (long)totalMilliseconds;
		}
	}
}
