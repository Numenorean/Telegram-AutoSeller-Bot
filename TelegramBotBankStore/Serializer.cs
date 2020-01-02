using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TelegramBotBankStore
{
	// Token: 0x02000005 RID: 5
	public static class Serializer
	{
		// Token: 0x06000015 RID: 21 RVA: 0x000053AC File Offset: 0x000035AC
		public static void Save(string filePath, object objToSerialize)
		{
			try
			{
				using (Stream stream = File.Open(filePath, FileMode.Create))
				{
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					binaryFormatter.Serialize(stream, objToSerialize);
				}
			}
			catch (IOException)
			{
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00005408 File Offset: 0x00003608
		public static T Load<T>(string filePath) where T : new()
		{
			T result = Activator.CreateInstance<T>();
			try
			{
				using (Stream stream = File.Open(filePath, FileMode.Open))
				{
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					bool flag = stream.Length > 0L;
					if (flag)
					{
						result = (T)((object)binaryFormatter.Deserialize(stream));
					}
				}
			}
			catch (IOException)
			{
			}
			return result;
		}
	}
}
