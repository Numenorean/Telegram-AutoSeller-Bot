using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace TelegramBotBankStore
{
	// Token: 0x02000013 RID: 19
	public class ExmoApi
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00002295 File Offset: 0x00000495
		public ExmoApi(string key, string secret)
		{
			this._key = key;
			this._secret = secret;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000A7E4 File Offset: 0x000089E4
		public async Task<string> ApiQueryAsync(string apiName, IDictionary<string, string> req)
		{
			string result;
			using (HttpClient client = new HttpClient())
			{
				long i = Interlocked.Increment(ref ExmoApi._nounce);
				req.Add("nonce", Convert.ToString(i));
				string message = this.ToQueryString(req);
				string sign = ExmoApi.Sign(this._secret, message);
				FormUrlEncodedContent content = new FormUrlEncodedContent(req);
				content.Headers.Add("Sign", sign);
				content.Headers.Add("Key", this._key);
				HttpResponseMessage httpResponseMessage = await client.PostAsync(string.Format(this._url, apiName), content);
				HttpResponseMessage response = httpResponseMessage;
				httpResponseMessage = null;
				string text = await response.Content.ReadAsStringAsync();
				result = text;
			}
			return result;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000A83C File Offset: 0x00008A3C
		public async Task<HttpStatusCode> ApiQueryAsyncEx(string apiName, IDictionary<string, string> req)
		{
			HttpStatusCode statusCode;
			using (HttpClient client = new HttpClient())
			{
				long i = Interlocked.Increment(ref ExmoApi._nounce);
				req.Add("nonce", Convert.ToString(i));
				string message = this.ToQueryString(req);
				string sign = ExmoApi.Sign(this._secret, message);
				FormUrlEncodedContent content = new FormUrlEncodedContent(req);
				content.Headers.Add("Sign", sign);
				content.Headers.Add("Key", this._key);
				HttpResponseMessage response2 = await client.PostAsync(string.Format(this._url, apiName), content);
				HttpResponseMessage response = response2;
				response2 = null;
				await Task.Factory.StartNew<Task>(async delegate()
				{
					string text = await response.Content.ReadAsStringAsync();
					string data = text;
					text = null;
					Console.WriteLine(data);
				});
				statusCode = response.StatusCode;
			}
			return statusCode;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000A894 File Offset: 0x00008A94
		public string ApiQuery(string apiName, IDictionary<string, string> req)
		{
			string @string;
			using (WebClient webClient = new WebClient())
			{
				string key = "nonce";
				long nounce = ExmoApi._nounce;
				ExmoApi._nounce = nounce + 1L;
				req.Add(key, Convert.ToString(nounce));
				string message = this.ToQueryString(req);
				string value = ExmoApi.Sign(this._secret, message);
				webClient.Headers.Add("Sign", value);
				webClient.Headers.Add("Key", this._key);
				NameValueCollection data = req.ToNameValueCollection<string, string>();
				byte[] bytes = webClient.UploadValues(string.Format(this._url, apiName), "POST", data);
				@string = Encoding.UTF8.GetString(bytes);
			}
			return @string;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000A954 File Offset: 0x00008B54
		private string ToQueryString(IDictionary<string, string> dic)
		{
			string[] value = (from key in dic.Keys
			select string.Format("{0}={1}", HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(dic[key]))).ToArray<string>();
			return string.Join("&", value);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000A9A0 File Offset: 0x00008BA0
		public IDictionary<string, string> ToDictionary(string str)
		{
			return JsonConvert.DeserializeObject<Dictionary<string, string>>(str);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000A9B8 File Offset: 0x00008BB8
		public static string Sign(string key, string message)
		{
			string result;
			using (HMACSHA512 hmacsha = new HMACSHA512(Encoding.UTF8.GetBytes(key)))
			{
				byte[] buff = hmacsha.ComputeHash(Encoding.UTF8.GetBytes(message));
				result = ExmoApi.ByteToString(buff);
			}
			return result;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000AA10 File Offset: 0x00008C10
		public static string ByteToString(byte[] buff)
		{
			string text = "";
			for (int i = 0; i < buff.Length; i++)
			{
				text += buff[i].ToString("X2");
			}
			return text.ToLowerInvariant();
		}

		// Token: 0x04000078 RID: 120
		private static long _nounce = Helpers.GetTimestamp();

		// Token: 0x04000079 RID: 121
		private string _key;

		// Token: 0x0400007A RID: 122
		private string _secret;

		// Token: 0x0400007B RID: 123
		private string _url = "http://api.exmo.com/v1/{0}";
	}
}
