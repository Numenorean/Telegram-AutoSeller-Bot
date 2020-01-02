using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlatUI;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using TelegramBotBankStore.Properties;
using Yandex.Money.Api.Sdk.Authorization;
using Yandex.Money.Api.Sdk.Interfaces;
using Yandex.Money.Api.Sdk.Net;
using Yandex.Money.Api.Sdk.Requests;
using Yandex.Money.Api.Sdk.Responses;
using Yandex.Money.Api.Sdk.Utils;

namespace TelegramBotBankStore
{
	// Token: 0x020000C9 RID: 201
	public partial class YandexMoney : Form
	{
		// Token: 0x060003AB RID: 939 RVA: 0x000031DC File Offset: 0x000013DC
		public YandexMoney()
		{
			this.InitializeComponent();
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0003FE20 File Offset: 0x0003E020
		public static void InitYandexMoney()
		{
			YandexMoney.hp = new DefaultHostsProvider();
			YandexMoney.auth = new YandexMoney.Authenticator();
			YandexMoney.auth.Token = Settings.Default.YandexToken;
			YandexMoney.Connection = new DefaultHttpPostClient(YandexMoney.hp, YandexMoney.auth);
			YandexMoney._proxyStatus = "Не подключено.";
			string yandexProxyNamePass = Settings.Default.YandexProxyNamePass;
			string yandexProxyIpPort = Settings.Default.YandexProxyIpPort;
			bool flag = !string.IsNullOrEmpty(yandexProxyIpPort) && string.IsNullOrEmpty(yandexProxyNamePass);
			if (flag)
			{
				try
				{
					string[] array = yandexProxyIpPort.Split(new char[]
					{
						':'
					});
					string[] array2 = yandexProxyNamePass.Split(new char[]
					{
						':'
					});
					WebProxy webProxy = new WebProxy(array[0], Convert.ToInt32(array[1]));
					webProxy.Credentials = new NetworkCredential(array2[0], array2[1]);
					object value = typeof(DefaultHttpPostClient).GetField("_handler", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(YandexMoney.Connection);
					typeof(HttpClientHandler).GetField("_proxy", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(value, webProxy);
					typeof(HttpClientHandler).GetField("_useProxy", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(value, true);
					YandexMoney._proxyStatus = "Подключено.";
				}
				catch (Exception ex)
				{
					YandexMoney._proxyStatus = ex.Message;
				}
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0003FF88 File Offset: 0x0003E188
		private async void YandexMoney_LoadAsync(object sender, EventArgs e)
		{
			this.labelProxy.Text = YandexMoney._proxyStatus;
			this.ClientId = Settings.Default.YansexClientId;
			this.RedirectUri = Settings.Default.YandexRedirectUri;
			YandexMoney.auth.Token = Settings.Default.YandexToken;
			bool flag = string.IsNullOrEmpty(this.ClientId) || string.IsNullOrEmpty(this.RedirectUri);
			if (flag)
			{
				this.label1.Text = "Заполните настройки.";
			}
			else
			{
				try
				{
					this.webBrowser1.Visible = false;
					this.label1.Text = "Проверка подключения.";
					Label label = this.label1;
					double? num = await YandexMoney.GetYandexBalanceAsync();
					label.Text = "Подключено. Баланс = " + num;
					label = null;
					num = null;
					string text = await YandexMoney.GetYandexOrderHistoryAsync();
					string hist = text;
					text = null;
					this.labelHist.Text = hist;
					return;
				}
				catch (Exception ex)
				{
					this.label1.Text = "Не подключено: " + ex.Message;
					this.webBrowser1.Visible = true;
				}
				this.webBrowser1.Refresh();
				YandexMoney.Wrapper wrapper = new YandexMoney.Wrapper(this.webBrowser1);
				YandexMoney.AuthorizationBroker ab = new YandexMoney.AuthorizationBroker();
				string text2 = await ab.AuthorizeAsync(YandexMoney.Connection, wrapper, YandexMoney.hp.AuthorizationdUri.ToString(), new AuthorizationRequestParams
				{
					ClientId = this.ClientId,
					RedirectUri = this.RedirectUri,
					Scope = Scopes.Compose(new string[]
					{
						Scopes.AccountInfo,
						Scopes.OperationHistory,
						Scopes.OperationDetails
					})
				});
				string token = text2;
				text2 = null;
				YandexMoney.auth.Token = token;
				Settings.Default.YandexToken = token;
				Settings.Default.Save();
				AccountInfoRequest<AccountInfoResult> accountInfoRequest = new AccountInfoRequest<AccountInfoResult>(YandexMoney.Connection, new JsonSerializer<AccountInfoResult>());
				AccountInfoResult accountInfoResult2 = await accountInfoRequest.Perform();
				AccountInfoResult accountInfoResult = accountInfoResult2;
				accountInfoResult2 = null;
				this.label1.Text = "Подключено. Баланс = " + accountInfoResult.Balance;
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0003FFD4 File Offset: 0x0003E1D4
		public static async Task<double?> GetYandexBalanceAsync()
		{
			AccountInfoRequest<AccountInfoResult> accountInfoRequest = new AccountInfoRequest<AccountInfoResult>(YandexMoney.Connection, new JsonSerializer<AccountInfoResult>());
			AccountInfoResult accountInfoResult2 = await accountInfoRequest.Perform();
			AccountInfoResult accountInfoResult = accountInfoResult2;
			accountInfoResult2 = null;
			return new double?(accountInfoResult.Balance);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00040014 File Offset: 0x0003E214
		public static async Task<string> GetYandexOrderHistoryAsync()
		{
			OperationHistoryResult operationHistoryResult = await new OperationHistoryRequest<OperationHistoryResult>(YandexMoney.Connection, new JsonSerializer<OperationHistoryResult>())
			{
				Type = "deposition",
				Details = true
			}.Perform();
			OperationHistoryResult rr = operationHistoryResult;
			operationHistoryResult = null;
			string text = "";
			foreach (OperationDetailsResult o in rr.Operations)
			{
				text += new StringBuilder().Append("Title ").Append(o.Title).Append(", Amount ").Append(o.Amount).Append(", Comment ").Append(o.Comment).Append(", DateTime ").Append(o.DateTime).Append(", Message ").Append(o.Message).Append(", Status ").Append(o.Status).Append(", Type ").Append(o.Type).Append(".\n").ToString();
				o = null;
			}
			List<OperationDetailsResult>.Enumerator enumerator = default(List<OperationDetailsResult>.Enumerator);
			return text;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00040054 File Offset: 0x0003E254
		private async void button1_ClickAsync(object sender, EventArgs e)
		{
			try
			{
				this.label1.Text = "Проверка подключения";
				Label label = this.label1;
				double? num = await YandexMoney.GetYandexBalanceAsync();
				label.Text = "Подключено. Баланс = " + num;
				label = null;
				num = null;
			}
			catch (Exception ex)
			{
				this.label1.Text = "Не подключено, перезагрузите форму. " + ex.Message;
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000031F4 File Offset: 0x000013F4
		private void button2_Click(object sender, EventArgs e)
		{
			Settings.Default.YandexToken = "";
			Settings.Default.Save();
			base.Close();
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000400A0 File Offset: 0x0003E2A0
		private void button4_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(YandexMoney.auth.Token);
			if (flag)
			{
				FormMessage formMessage = new FormMessage("", "Введите токен доступа.");
				formMessage.ShowDialog();
				bool flag2 = formMessage.DialogResult == DialogResult.OK;
				if (flag2)
				{
					YandexMoney.auth.Token = formMessage.GetMessage;
					Settings.Default.YandexToken = formMessage.GetMessage;
					Settings.Default.Save();
				}
				formMessage.Dispose();
				base.Close();
			}
			else
			{
				FormMessage formMessage2 = new FormMessage(YandexMoney.auth.Token.ToString(), "Скопировать токен доступа?");
				formMessage2.ShowDialog();
				bool flag3 = formMessage2.DialogResult == DialogResult.OK;
				if (flag3)
				{
					Clipboard.SetText(YandexMoney.auth.Token.ToString());
				}
				formMessage2.Dispose();
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00011B28 File Offset: 0x0000FD28
		private void flatMax1_Click(object sender, EventArgs e)
		{
			this.MaximumSize = Screen.FromControl(this).WorkingArea.Size;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002076 File Offset: 0x00000276
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0400071D RID: 1821
		private string ClientId;

		// Token: 0x0400071E RID: 1822
		private string RedirectUri;

		// Token: 0x0400071F RID: 1823
		private static IHostProvider hp;

		// Token: 0x04000720 RID: 1824
		private static YandexMoney.Authenticator auth;

		// Token: 0x04000721 RID: 1825
		public static IHttpClient Connection;

		// Token: 0x04000722 RID: 1826
		private static string _proxyStatus;

		// Token: 0x020000CA RID: 202
		public class Authenticator : DefaultAuthenticator
		{
			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060003B7 RID: 951 RVA: 0x00003219 File Offset: 0x00001419
			// (set) Token: 0x060003B8 RID: 952 RVA: 0x00003221 File Offset: 0x00001421
			public override string Token { get; set; }
		}

		// Token: 0x020000CB RID: 203
		public interface IWebBrowser<T>
		{
			// Token: 0x060003BA RID: 954
			void Navigate(string uri, byte[] postParams, string additionalHeaders);

			// Token: 0x14000001 RID: 1
			// (add) Token: 0x060003BB RID: 955
			// (remove) Token: 0x060003BC RID: 956
			event EventHandler<T> NavigationEvent;
		}

		// Token: 0x020000CC RID: 204
		public class Wrapper : YandexMoney.IWebBrowser<string>
		{
			// Token: 0x060003BD RID: 957 RVA: 0x00040D7C File Offset: 0x0003EF7C
			public Wrapper(WebBrowser browser)
			{
				bool flag = browser == null;
				if (!flag)
				{
					this._browser = browser;
					this._browser.Navigated += delegate(object s, WebBrowserNavigatedEventArgs e)
					{
						bool flag2 = this.NavigationEvent != null;
						if (flag2)
						{
							this.NavigationEvent(s, e.Url.Query);
						}
					};
				}
			}

			// Token: 0x060003BE RID: 958 RVA: 0x00040DBC File Offset: 0x0003EFBC
			public void Navigate(string uri, byte[] postParams, string additionalHeaders)
			{
				bool flag = this._browser != null;
				if (flag)
				{
					this._browser.Navigate(uri, "_self", postParams, additionalHeaders);
				}
			}

			// Token: 0x14000002 RID: 2
			// (add) Token: 0x060003BF RID: 959 RVA: 0x00040DEC File Offset: 0x0003EFEC
			// (remove) Token: 0x060003C0 RID: 960 RVA: 0x00040E24 File Offset: 0x0003F024
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public event EventHandler<string> NavigationEvent;

			// Token: 0x04000731 RID: 1841
			private WebBrowser _browser;
		}

		// Token: 0x020000CD RID: 205
		public class AuthorizationBroker
		{
			// Token: 0x060003C2 RID: 962 RVA: 0x00040E90 File Offset: 0x0003F090
			public Task<string> AuthorizeAsync(IHttpClient client, YandexMoney.IWebBrowser<string> browser, string uri, AuthorizationRequestParams prms)
			{
				bool flag = browser == null;
				Task<string> result;
				if (flag)
				{
					result = null;
				}
				else
				{
					this._tcs = new TaskCompletionSource<string>();
					browser.NavigationEvent += async delegate(object s, string e)
					{
						Dictionary<string, string> d = Misc.QueryParamsToDictionary(e);
						bool flag2 = d.ContainsKey("code");
						if (flag2)
						{
							TokenRequest<TokenResult> tr = new TokenRequest<TokenResult>(client, new JsonSerializer<TokenResult>())
							{
								Code = d["code"],
								ClientId = prms.ClientId,
								RedirectUri = prms.RedirectUri
							};
							TokenResult token = new TokenResult();
							string ar = string.Concat(new string[]
							{
								"https://money.yandex.ru/oauth/token?code=",
								tr.Code,
								"&client_id=",
								tr.ClientId,
								"&grant_type=authorization_code&redirect_uri=",
								tr.RedirectUri
							});
							HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ar);
							request.AllowAutoRedirect = false;
							request.ContentType = "application/json; charset=utf-8";
							HttpWebResponse response = (HttpWebResponse)request.GetResponse();
							Stream dataStream = response.GetResponseStream();
							StreamReader reader = new StreamReader(dataStream);
							string responseFromServer = reader.ReadToEnd();
							object obj = JsonConvert.DeserializeObject<object>(responseFromServer);
							if (YandexMoney.AuthorizationBroker.<>o__1.<>p__1 == null)
							{
								YandexMoney.AuthorizationBroker.<>o__1.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(YandexMoney.AuthorizationBroker)));
							}
							Func<CallSite, object, string> target = YandexMoney.AuthorizationBroker.<>o__1.<>p__1.Target;
							CallSite <>p__ = YandexMoney.AuthorizationBroker.<>o__1.<>p__1;
							if (YandexMoney.AuthorizationBroker.<>o__1.<>p__0 == null)
							{
								YandexMoney.AuthorizationBroker.<>o__1.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetIndex(CSharpBinderFlags.None, typeof(YandexMoney.AuthorizationBroker), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							string t = target(<>p__, YandexMoney.AuthorizationBroker.<>o__1.<>p__0.Target(YandexMoney.AuthorizationBroker.<>o__1.<>p__0, obj, "access_token"));
							reader.Close();
							dataStream.Close();
							response.Close();
							token.Token = t;
							bool flag3 = token == null;
							if (!flag3)
							{
								bool flag4 = this._tcs != null;
								if (flag4)
								{
									this._tcs.SetResult((token == null) ? null : token.Token);
								}
								tr = null;
								token = null;
								ar = null;
								request = null;
								response = null;
								dataStream = null;
								reader = null;
								responseFromServer = null;
								obj = null;
								t = null;
							}
						}
					};
					browser.Navigate(uri, prms.PostBytes(), "Content-Type: application/x-www-form-urlencoded/r/n");
					result = this._tcs.Task;
				}
				return result;
			}

			// Token: 0x04000733 RID: 1843
			private TaskCompletionSource<string> _tcs;
		}
	}
}
