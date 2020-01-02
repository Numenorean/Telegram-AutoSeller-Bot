using System;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace TelegramBotBankStore
{
	// Token: 0x02000020 RID: 32
	public class Key
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00002308 File Offset: 0x00000508
		private Key()
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000C120 File Offset: 0x0000A320
		private static string GetUniqueIDWithoutDirectory()
		{
			string processorID = Key.GetProcessorID();
			string text = processorID.Substring(13);
			try
			{
				text += processorID.Substring(1, 4);
			}
			catch
			{
			}
			try
			{
				string volumeSerial = Key.GetVolumeSerial(Key.getDrive());
				text += volumeSerial;
			}
			catch
			{
			}
			try
			{
				text += processorID.Substring(4, 4);
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000C1B8 File Offset: 0x0000A3B8
		public static string GetUniqueID()
		{
			string text = Key.GetUniqueIDWithoutDirectory();
			try
			{
				string currentDirectory = Directory.GetCurrentDirectory();
				text = text + Key.delimeterFolder + Convert.ToBase64String(Encoding.UTF8.GetBytes(currentDirectory));
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000C20C File Offset: 0x0000A40C
		public static string GetProcessorID()
		{
			string result = "";
			try
			{
				foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("Select ProcessorID From Win32_processor").Get())
				{
					result = managementBaseObject["ProcessorID"].ToString();
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000C290 File Offset: 0x0000A490
		public static string Encrypt(string text)
		{
			string result = string.Empty;
			try
			{
				UTF8Encoding utf8Encoding = new UTF8Encoding();
				MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
				byte[] key = md5CryptoServiceProvider.ComputeHash(utf8Encoding.GetBytes(Key.passphrase));
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				tripleDESCryptoServiceProvider.Key = key;
				tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
				tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
				byte[] bytes = utf8Encoding.GetBytes(text);
				byte[] inArray;
				try
				{
					inArray = tripleDESCryptoServiceProvider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length);
				}
				finally
				{
					tripleDESCryptoServiceProvider.Clear();
					md5CryptoServiceProvider.Clear();
				}
				result = Convert.ToBase64String(inArray);
			}
			catch (Exception ex)
			{
			}
			return result;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000C350 File Offset: 0x0000A550
		public static string Decrypt(string text)
		{
			string result = string.Empty;
			try
			{
				UTF8Encoding utf8Encoding = new UTF8Encoding();
				MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
				byte[] key = md5CryptoServiceProvider.ComputeHash(utf8Encoding.GetBytes(Key.passphrase));
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				tripleDESCryptoServiceProvider.Key = key;
				tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
				tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
				byte[] array = Convert.FromBase64String(text);
				byte[] bytes;
				try
				{
					bytes = tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(array, 0, array.Length);
				}
				finally
				{
					tripleDESCryptoServiceProvider.Clear();
					md5CryptoServiceProvider.Clear();
				}
				result = utf8Encoding.GetString(bytes);
			}
			catch (Exception ex)
			{
			}
			return result;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000C410 File Offset: 0x0000A610
		public static string GetVolumeSerial(string drive)
		{
			string empty = string.Empty;
			string result;
			try
			{
				ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + drive + ":\"");
				managementObject.Get();
				result = managementObject["VolumeSerialNumber"].ToString();
				managementObject.Dispose();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000C478 File Offset: 0x0000A678
		private static string getDrive()
		{
			string text = "C";
			foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
			{
				bool isReady = driveInfo.IsReady;
				if (isReady)
				{
					text = driveInfo.RootDirectory.ToString();
					break;
				}
			}
			bool flag = text.EndsWith(":\\");
			if (flag)
			{
				text = text.Substring(0, text.Length - 2);
			}
			return text;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000C4EC File Offset: 0x0000A6EC
		public static string Encrypt(string text, int numberDayToWork)
		{
			string text2 = Key.GetNistTime().ToString(Key.dateFormat);
			string str = string.Concat(new object[]
			{
				Key.delimeterStartDay,
				text2,
				Key.delimeterNumbDay,
				numberDayToWork
			});
			string str2 = text.Insert(text.IndexOf(Key.delimeterFolder), (numberDayToWork - 1).ToString());
			return Key.Encrypt(str2 + str);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000C56C File Offset: 0x0000A76C
		public static bool CheckKey(string key)
		{
			bool result;
			try
			{
				bool flag = false;
				string text = Key.Decrypt(key);
				bool flag2 = !string.IsNullOrEmpty(text);
				if (flag2)
				{
					string[] array = text.Split(new string[]
					{
						Key.delimeterFolder,
						Key.delimeterStartDay,
						Key.delimeterNumbDay
					}, StringSplitOptions.RemoveEmptyEntries);
					bool flag3 = array.Length == 2;
					if (flag3)
					{
						string uniqueID = Key.GetUniqueID();
						flag = (!string.IsNullOrEmpty(uniqueID) && uniqueID == text);
					}
					else
					{
						bool flag4 = array.Length == 4;
						if (flag4)
						{
							DateTime nistTime = Key.GetNistTime();
							DateTime dateTime = DateTime.ParseExact(array[2], Key.dateFormat, CultureInfo.InvariantCulture);
							int num = int.Parse(array[3]);
							string uniqueIDWithoutDirectory = Key.GetUniqueIDWithoutDirectory();
							return !string.IsNullOrEmpty(uniqueIDWithoutDirectory) && uniqueIDWithoutDirectory + (num - 1).ToString() == array[0] && nistTime <= dateTime.AddDays((double)num);
						}
					}
				}
				result = flag;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000C680 File Offset: 0x0000A880
		public static bool IsLimitedLicense(string key)
		{
			bool result = false;
			string text = Key.Decrypt(key);
			bool flag = !string.IsNullOrEmpty(text);
			if (flag)
			{
				string[] array = text.Split(new string[]
				{
					Key.delimeterFolder,
					Key.delimeterStartDay,
					Key.delimeterNumbDay
				}, StringSplitOptions.RemoveEmptyEntries);
				bool flag2 = array.Length == 4;
				if (flag2)
				{
					return true;
				}
			}
			return result;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000C6E8 File Offset: 0x0000A8E8
		public static int GetDayToEndOfLicence(string key)
		{
			int result = -1;
			string text = Key.Decrypt(key);
			bool flag = !string.IsNullOrEmpty(text);
			if (flag)
			{
				string[] array = text.Split(new string[]
				{
					Key.delimeterFolder,
					Key.delimeterStartDay,
					Key.delimeterNumbDay
				}, StringSplitOptions.RemoveEmptyEntries);
				bool flag2 = array.Length == 4;
				if (flag2)
				{
					DateTime nistTime = Key.GetNistTime();
					DateTime dateTime = DateTime.ParseExact(array[2], Key.dateFormat, CultureInfo.InvariantCulture);
					int num = int.Parse(array[3]);
					result = (int)(dateTime.AddDays((double)num) - nistTime).TotalDays;
				}
			}
			return result;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000C78C File Offset: 0x0000A98C
		private static DateTime GetNistTime()
		{
			TcpClient tcpClient = new TcpClient("time.nist.gov", 13);
			DateTime result;
			using (StreamReader streamReader = new StreamReader(tcpClient.GetStream()))
			{
				string text = streamReader.ReadToEnd();
				string s = text.Substring(7, 17);
				result = DateTime.ParseExact(s, "yy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
			}
			return result;
		}

		// Token: 0x040000C8 RID: 200
		private static readonly string passphrase = "@sdlg#$5afl$dg";

		// Token: 0x040000C9 RID: 201
		private static readonly string delimeterFolder = Convert.ToBase64String(Encoding.UTF8.GetBytes("1qw"));

		// Token: 0x040000CA RID: 202
		private static readonly string delimeterStartDay = Convert.ToBase64String(Encoding.UTF8.GetBytes("a2s"));

		// Token: 0x040000CB RID: 203
		private static readonly string delimeterNumbDay = Convert.ToBase64String(Encoding.UTF8.GetBytes("zx3"));

		// Token: 0x040000CC RID: 204
		private static readonly string dateFormat = "yyyy:MM:dd";
	}
}
