using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json.Linq;

namespace TelegramBotBankStore
{
	// Token: 0x02000006 RID: 6
	public class Apirone
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00005480 File Offset: 0x00003680
		public Apirone(string idWalletBTC, string idWalletLTC)
		{
			bool flag = !string.IsNullOrEmpty(idWalletBTC);
			if (flag)
			{
				this._idWalletBTC = idWalletBTC.Replace(" ", "");
			}
			bool flag2 = !string.IsNullOrEmpty(idWalletLTC);
			if (flag2)
			{
				this._idWalletLTC = idWalletLTC.Replace(" ", "");
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000054DC File Offset: 0x000036DC
		static Apirone()
		{
			bool flag = File.Exists("DataBase\\CacheListAddress.bin");
			if (flag)
			{
				Apirone.cacheList = Serializer.Load<List<Apirone.CheckAddress>>("DataBase\\CacheListAddress.bin");
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00005534 File Offset: 0x00003734
		public static void SaveCache()
		{
			bool flag = Apirone.cacheList.Count > 0;
			if (flag)
			{
				Serializer.Save("DataBase\\CacheListAddress.bin", Apirone.cacheList);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00005564 File Offset: 0x00003764
		private static string LoadAndCacheAddress(string address, string currency, string loadPage)
		{
			Apirone.CheckAddress checkAddress = Apirone.cacheList.FirstOrDefault((Apirone.CheckAddress x) => x.Address == address && x.Currency == currency);
			bool flag = checkAddress == null;
			if (flag)
			{
				checkAddress = new Apirone.CheckAddress();
				checkAddress.Currency = currency;
				checkAddress.Address = address;
				checkAddress.DateStartCheck = DateTime.Now;
				checkAddress.DateLastCheck = DateTime.Now;
				checkAddress.Responce = Apirone.LoadPage(loadPage);
				Apirone.cacheList.Add(checkAddress);
			}
			else
			{
				TimeSpan timeSpan = DateTime.Now - checkAddress.DateStartCheck;
				TimeSpan timeSpan2 = DateTime.Now - checkAddress.DateLastCheck;
				bool flag2 = timeSpan.TotalDays > 1.0;
				if (flag2)
				{
					bool flag3 = timeSpan2.TotalMinutes > 25.0;
					if (flag3)
					{
						checkAddress.Responce = Apirone.LoadPage(loadPage);
						checkAddress.DateLastCheck = DateTime.Now;
					}
				}
				else
				{
					bool flag4 = timeSpan.TotalHours > 12.0;
					if (flag4)
					{
						bool flag5 = timeSpan2.TotalMinutes > 15.0;
						if (flag5)
						{
							checkAddress.Responce = Apirone.LoadPage(loadPage);
							checkAddress.DateLastCheck = DateTime.Now;
						}
					}
					else
					{
						bool flag6 = timeSpan2.TotalMinutes > 10.0;
						if (flag6)
						{
							checkAddress.Responce = Apirone.LoadPage(loadPage);
							checkAddress.DateLastCheck = DateTime.Now;
						}
					}
				}
			}
			bool flag7 = checkAddress.Responce.Contains("API calls limits have been reached");
			if (flag7)
			{
				checkAddress.Responce = "";
				throw new Exception("Error: Adress Apirone - API calls limits have been reached");
			}
			return checkAddress.Responce;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00005730 File Offset: 0x00003930
		public string GetBtcAddress()
		{
			bool flag = string.IsNullOrEmpty(this._idWalletBTC);
			if (flag)
			{
				throw new Exception("Wallet address did not enter.");
			}
			string result3;
			using (HttpClient httpClient = new HttpClient())
			{
				HttpResponseMessage result = httpClient.PostAsync("https://apirone.com/api/v2/btc/wallet/" + this._idWalletBTC + "/address", new StringContent(Apirone.myJson, Encoding.UTF8, "application/json")).Result;
				string result2 = result.Content.ReadAsStringAsync().Result;
				bool flag2 = result2.Contains(this._idWalletBTC.Substring(5)) && result2.Contains("secret") && result2.Contains("btc");
				if (!flag2)
				{
					throw new FormatException("Apirone BTC response is not valid. " + result2);
				}
				object arg = JObject.Parse(result2);
				if (Apirone.<>o__10.<>p__1 == null)
				{
					Apirone.<>o__10.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Apirone)));
				}
				Func<CallSite, object, string> target = Apirone.<>o__10.<>p__1.Target;
				CallSite <>p__ = Apirone.<>o__10.<>p__1;
				if (Apirone.<>o__10.<>p__0 == null)
				{
					Apirone.<>o__10.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "address", typeof(Apirone), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				result3 = target(<>p__, Apirone.<>o__10.<>p__0.Target(Apirone.<>o__10.<>p__0, arg));
			}
			return result3;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000058B4 File Offset: 0x00003AB4
		public static decimal CheckBtcAddress(string address)
		{
			string page = "https://blockchain.info/q/addressbalance/" + address + "?confirmations=1";
			string text = Apirone.LoadPage(page);
			string text2 = text;
			decimal num = decimal.Parse(text2);
			bool flag = num.ToString().Replace(",", ".") != text2.Replace(",", ".");
			if (flag)
			{
				throw new Exception(string.Concat(new object[]
				{
					"Parse error, received - ",
					text2,
					", parsed - ",
					num
				}));
			}
			return num / 100000000m;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00005958 File Offset: 0x00003B58
		public string GetLtcAddress()
		{
			bool flag = string.IsNullOrEmpty(this._idWalletLTC);
			if (flag)
			{
				throw new Exception("Wallet ltc address did not enter.");
			}
			string result3;
			using (HttpClient httpClient = new HttpClient())
			{
				HttpResponseMessage result = httpClient.PostAsync("https://apirone.com/api/v2/ltc/wallet/" + this._idWalletLTC + "/address", new StringContent(Apirone.myJson, Encoding.UTF8, "application/json")).Result;
				string result2 = result.Content.ReadAsStringAsync().Result;
				bool flag2 = result2.Contains(this._idWalletLTC.Substring(5)) && result2.Contains("secret") && result2.Contains("ltc");
				if (!flag2)
				{
					throw new FormatException("Apirone LTC response is not valid. " + result2);
				}
				object arg = JObject.Parse(result2);
				if (Apirone.<>o__12.<>p__1 == null)
				{
					Apirone.<>o__12.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Apirone)));
				}
				Func<CallSite, object, string> target = Apirone.<>o__12.<>p__1.Target;
				CallSite <>p__ = Apirone.<>o__12.<>p__1;
				if (Apirone.<>o__12.<>p__0 == null)
				{
					Apirone.<>o__12.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "address", typeof(Apirone), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				result3 = target(<>p__, Apirone.<>o__12.<>p__0.Target(Apirone.<>o__12.<>p__0, arg));
			}
			return result3;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00005ADC File Offset: 0x00003CDC
		public decimal CheckLtcAddress(string address)
		{
			string page = "https://ltc.btc.com/" + address;
			string text = Apirone.LoadPage(page);
			int startIndex = text.Contains("Balance") ? text.IndexOf("<dt>Balance</dt>") : text.IndexOf("<dt>Баланс</dt>");
			string text2 = text.Substring(startIndex, 100);
			string text3 = text2.Replace("<span class=\"text-muted\">", "").Replace(" ", "").Replace("</span>", "");
			text3 = text3.Substring(text3.IndexOf("<dd>") + 4);
			decimal num = decimal.Parse(text3);
			bool flag = num.ToString().Replace(",", ".") != text3.Replace(",", ".");
			if (flag)
			{
				throw new Exception(string.Concat(new object[]
				{
					"Parse error, received - ",
					text3,
					", parsed - ",
					num
				}));
			}
			return num;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00005BE8 File Offset: 0x00003DE8
		public decimal GetRate(string pare)
		{
			string page = "https://api.cryptonator.com/api/full/" + pare;
			object arg = JObject.Parse(Apirone.LoadPage(page));
			if (Apirone.<>o__14.<>p__2 == null)
			{
				Apirone.<>o__14.<>p__2 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Apirone)));
			}
			Func<CallSite, object, string> target = Apirone.<>o__14.<>p__2.Target;
			CallSite <>p__ = Apirone.<>o__14.<>p__2;
			if (Apirone.<>o__14.<>p__1 == null)
			{
				Apirone.<>o__14.<>p__1 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "price", typeof(Apirone), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, object> target2 = Apirone.<>o__14.<>p__1.Target;
			CallSite <>p__2 = Apirone.<>o__14.<>p__1;
			if (Apirone.<>o__14.<>p__0 == null)
			{
				Apirone.<>o__14.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(Apirone), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			string text = target(<>p__, target2(<>p__2, Apirone.<>o__14.<>p__0.Target(Apirone.<>o__14.<>p__0, arg, "ticker")));
			decimal num = decimal.Parse(text);
			bool flag = num.ToString().Replace(",", ".") != text.Replace(",", ".");
			if (flag)
			{
				throw new Exception(string.Concat(new object[]
				{
					"Parse error GetRate, received - ",
					text,
					", parsed - ",
					num
				}));
			}
			return num;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00005D60 File Offset: 0x00003F60
		public decimal GetLTCRate(bool isRub)
		{
			decimal rate;
			if (isRub)
			{
				rate = this.GetRate("ltc-rub");
			}
			else
			{
				rate = this.GetRate("ltc-usd");
			}
			return rate;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00005D90 File Offset: 0x00003F90
		public decimal ConvertRubToLTC(decimal value)
		{
			decimal rate = this.GetRate("ltc-rub");
			return Math.Round(value / rate, 8);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00005DBC File Offset: 0x00003FBC
		public static string LoadPage(string page)
		{
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
			string result2;
			using (HttpClient httpClient = new HttpClient())
			{
				using (HttpResponseMessage result = httpClient.GetAsync(page).Result)
				{
					using (HttpContent content = result.Content)
					{
						result2 = content.ReadAsStringAsync().Result;
					}
				}
			}
			return result2;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00005E60 File Offset: 0x00004060
		public string History()
		{
			string text = string.Empty;
			bool flag = !string.IsNullOrEmpty(this._idWalletBTC);
			if (flag)
			{
				text += "Баланс BTC:\r\n\r\n";
				text = text + this.GetBalanceBTC() + "\r\n\r\n";
			}
			else
			{
				text += "BTC - Не подключено.\r\n\r\n";
			}
			bool flag2 = !string.IsNullOrEmpty(this._idWalletLTC);
			if (flag2)
			{
				text += "Баланс LTC:\r\n\r\n";
				text = text + Apirone.LoadPage("https://apirone.com/api/v2/wallet/" + this._idWalletLTC + "/balance") + "\r\n\r\n";
			}
			else
			{
				text += "LTC - Не подключено.\r\n\r\n";
			}
			return text;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00005F14 File Offset: 0x00004114
		public string GetBalanceBTCDescribes()
		{
			bool flag = !string.IsNullOrEmpty(this._idWalletBTC);
			string result;
			if (flag)
			{
				result = Apirone.LoadPage("https://apirone.com/api/v2/wallet/" + this._idWalletBTC + "/balance");
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00005F5C File Offset: 0x0000415C
		public decimal GetBalanceBTC()
		{
			string balanceBTCDescribes = this.GetBalanceBTCDescribes();
			object arg = JObject.Parse(balanceBTCDescribes);
			if (Apirone.<>o__20.<>p__1 == null)
			{
				Apirone.<>o__20.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Apirone)));
			}
			Func<CallSite, object, string> target = Apirone.<>o__20.<>p__1.Target;
			CallSite <>p__ = Apirone.<>o__20.<>p__1;
			if (Apirone.<>o__20.<>p__0 == null)
			{
				Apirone.<>o__20.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "confirmed", typeof(Apirone), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			string s = target(<>p__, Apirone.<>o__20.<>p__0.Target(Apirone.<>o__20.<>p__0, arg));
			return decimal.Parse(s);
		}

		// Token: 0x04000020 RID: 32
		private static string secret = "telegrambot";

		// Token: 0x04000021 RID: 33
		private static string myJson = "{ \"callback\" : { \"data\" : { \"secret\" : \"" + Apirone.secret + "\" } } }";

		// Token: 0x04000022 RID: 34
		private string _idWalletBTC;

		// Token: 0x04000023 RID: 35
		private string _idWalletLTC;

		// Token: 0x04000024 RID: 36
		private static List<Apirone.CheckAddress> cacheList = new List<Apirone.CheckAddress>();

		// Token: 0x02000007 RID: 7
		[Serializable]
		private class CheckAddress
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000026 RID: 38 RVA: 0x000020C8 File Offset: 0x000002C8
			// (set) Token: 0x06000027 RID: 39 RVA: 0x000020D0 File Offset: 0x000002D0
			public string Currency { get; set; }

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000028 RID: 40 RVA: 0x000020D9 File Offset: 0x000002D9
			// (set) Token: 0x06000029 RID: 41 RVA: 0x000020E1 File Offset: 0x000002E1
			public string Address { get; set; }

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x0600002A RID: 42 RVA: 0x000020EA File Offset: 0x000002EA
			// (set) Token: 0x0600002B RID: 43 RVA: 0x000020F2 File Offset: 0x000002F2
			public string Responce { get; set; }

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x0600002C RID: 44 RVA: 0x000020FB File Offset: 0x000002FB
			// (set) Token: 0x0600002D RID: 45 RVA: 0x00002103 File Offset: 0x00000303
			public DateTime DateStartCheck { get; set; }

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600002E RID: 46 RVA: 0x0000210C File Offset: 0x0000030C
			// (set) Token: 0x0600002F RID: 47 RVA: 0x00002114 File Offset: 0x00000314
			public DateTime DateLastCheck { get; set; }
		}
	}
}
