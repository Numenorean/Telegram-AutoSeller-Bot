using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using log4net;
using Newtonsoft.Json;

namespace TelegramBotBankStore
{
	// Token: 0x020000C3 RID: 195
	public class Tele2Api
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000388 RID: 904 RVA: 0x000030E0 File Offset: 0x000012E0
		public string Number
		{
			get
			{
				return this._number;
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0003F6C8 File Offset: 0x0003D8C8
		public Tele2Api(string number, string password)
		{
			this._number = number.Replace("+", "");
			this._password = password;
			this._lastHistory = DateTime.MinValue;
			this._paidList = new List<Data>();
			this._historyDateTime = DateTime.MinValue;
			try
			{
				this.IsDataSumPaid(-1m);
			}
			catch (Exception message)
			{
				this.log.Error(message);
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0003F760 File Offset: 0x0003D960
		private void Logging()
		{
			try
			{
				CookieContainer cookieContainer = new CookieContainer();
				HttpClientHandler handler = new HttpClientHandler
				{
					AllowAutoRedirect = true,
					UseCookies = true,
					CookieContainer = cookieContainer
				};
				this._httpClient = new HttpClient(handler);
				HttpResponseMessage result = this._httpClient.GetAsync("https://msk.tele2.ru/lk/expenses").Result;
				string result2 = result.Content.ReadAsStringAsync().Result;
				bool flag = result2.Contains("Введите свой номер для управления услугами");
				if (flag)
				{
					result = this._httpClient.GetAsync("https://login.tele2.ru/ssotele2/wap/auth/").Result;
					result2 = result.Content.ReadAsStringAsync().Result;
					Regex regex = new Regex("<input value=\"(.*)name=\"_csrf\"");
					Match match = regex.Match(result2);
					string text = match.Groups[1].ToString();
					string value = text.Substring(0, text.IndexOf("\""));
					HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, "https://login.tele2.ru:443/ssotele2/wap/auth/submitLoginAndPassword");
					httpRequestMessage.Content = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>
					{
						new KeyValuePair<string, string>("pNumber", this._number),
						new KeyValuePair<string, string>("password", this._password),
						new KeyValuePair<string, string>("authBy", "BY_PASS"),
						new KeyValuePair<string, string>("rememberMe", "true"),
						new KeyValuePair<string, string>("_csrf", value)
					});
					HttpResponseMessage result3 = this._httpClient.SendAsync(httpRequestMessage).Result;
				}
				this._isLogged = true;
			}
			catch (Exception message)
			{
				this.log.Error(message);
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0003F92C File Offset: 0x0003DB2C
		private List<Data> GetLastHistory()
		{
			bool flag = !this._isLogged;
			if (flag)
			{
				this.Logging();
			}
			string requestUri = string.Concat(new string[]
			{
				"https://msk.tele2.ru/api/subscribers/",
				this._number,
				"/payments?fromDate=",
				DateTime.Now.AddDays(-1.0).ToString("yyyy-MM-dd"),
				"T00%3A00%3A00%2B01%3A00&toDate=",
				DateTime.Now.ToString("yyyy-MM-dd"),
				"T23%3A59%3A59%2B01%3A00"
			});
			HttpResponseMessage result = this._httpClient.GetAsync(requestUri).Result;
			string result2 = result.Content.ReadAsStringAsync().Result;
			Tele2History tele2History = JsonConvert.DeserializeObject<Tele2History>(result2);
			List<Data> result3 = new List<Data>();
			bool flag2 = this._lastHistory == DateTime.MinValue;
			if (flag2)
			{
				bool flag3 = tele2History.data != null && tele2History.data.Any<Data>();
				if (flag3)
				{
					this._lastHistory = tele2History.data.First<Data>().payDate;
				}
				else
				{
					this._lastHistory = DateTime.Now;
				}
			}
			bool flag4 = tele2History.data != null && tele2History.data.Any<Data>();
			if (flag4)
			{
				result3 = (from x in tele2History.data
				where x.payDate > this._lastHistory.AddSeconds(20.0)
				select x).ToList<Data>();
				this._lastHistory = tele2History.data.FirstOrDefault<Data>().payDate;
			}
			return result3;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0003FAA8 File Offset: 0x0003DCA8
		public string GetBalance()
		{
			HttpResponseMessage result = this._httpClient.GetAsync("https://msk.tele2.ru/api/subscribers/" + this._number + "/balance").Result;
			string result2 = result.Content.ReadAsStringAsync().Result;
			Regex regex = new Regex("value\":(.*)}}");
			Match match = regex.Match(result2);
			return match.Groups[1].ToString();
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0003FB1C File Offset: 0x0003DD1C
		public Data IsDataSumPaid(decimal sum)
		{
			bool flag = this._historyDateTime == DateTime.MinValue || (DateTime.Now - this._historyDateTime).TotalSeconds >= 100.0;
			if (flag)
			{
				string text = string.Empty;
				foreach (Data data in this._paidList)
				{
					text = string.Concat(new object[]
					{
						text,
						data.sum.amount,
						"(",
						data.payDate,
						"), "
					});
				}
				this.log.Info("Tele2 - Current paid list : " + text);
				List<Data> lastHistory = this.GetLastHistory();
				bool flag2 = lastHistory.Any<Data>();
				if (flag2)
				{
					this._paidList.AddRange(lastHistory.AsEnumerable<Data>());
					string text2 = string.Empty;
					foreach (Data data2 in lastHistory)
					{
						text2 = string.Concat(new object[]
						{
							text2,
							data2.sum.amount,
							"(",
							data2.payDate,
							"), "
						});
					}
					this.log.Info("Tele2 - Added to paid : " + text2);
				}
			}
			Data data3 = this._paidList.FirstOrDefault((Data x) => x.sum.amount == sum);
			bool flag3 = data3 != null;
			Data result;
			if (flag3)
			{
				this._paidList.Remove(data3);
				this.log.Info(string.Concat(new object[]
				{
					"Tele2 - Deleted from paid : ",
					data3.sum.amount,
					" ",
					data3.payDate
				}));
				string text3 = string.Empty;
				foreach (Data data4 in this._paidList)
				{
					text3 = string.Concat(new object[]
					{
						text3,
						data4.sum.amount,
						"(",
						data4.payDate,
						"), "
					});
				}
				this.log.Info("Tele2 - Current paid list After Deleting : " + text3);
				result = data3;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x04000709 RID: 1801
		private readonly ILog log = LogManager.GetLogger("Tele2Api");

		// Token: 0x0400070A RID: 1802
		private string _number;

		// Token: 0x0400070B RID: 1803
		private string _password;

		// Token: 0x0400070C RID: 1804
		private bool _isLogged;

		// Token: 0x0400070D RID: 1805
		private HttpClient _httpClient;

		// Token: 0x0400070E RID: 1806
		private DateTime _lastHistory;

		// Token: 0x0400070F RID: 1807
		private List<Data> _paidList;

		// Token: 0x04000710 RID: 1808
		private DateTime _historyDateTime;
	}
}
