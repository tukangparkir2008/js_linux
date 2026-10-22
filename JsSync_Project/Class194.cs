using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

internal sealed class Class194
{
	public static GClass70 smethod_0()
	{
		if (Class348.Class352.string_0.Trim().Length == 0)
		{
			return new GClass70(-1, Class84.smethod_0(-994278342));
		}
		if (Class249.Class251.smethod_2() && Class249.Class250.smethod_3() && Class272.list_0.Count > 0)
		{
			return new GClass70(1, Class84.smethod_0(-994247224));
		}
		try
		{
			WebClient webClient = new WebClient();
			string string_;
			try
			{
				string_ = webClient.DownloadString(Class249.Class253.smethod_1());
			}
			finally
			{
				((IDisposable)webClient).Dispose();
			}
			GClass70 gClass = Class305.smethod_0(string_, Class320.int_5);
			if (gClass.Value <= 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994288837) + Class249.Class253.smethod_0() + Class84.smethod_0(-994288861) + gClass.Text);
			}
			GClass70 gClass2 = GClass70.smethod_1(gClass.Data.ToString());
			if (gClass2.Value <= 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994288837) + Class249.Class253.smethod_0() + Class84.smethod_0(-994288861) + gClass2.Text);
			}
			Class272.list_0 = JsonConvert.DeserializeObject<List<string>>(gClass2.Data.ToString());
			Tuple<string, string> tuple = Class320.smethod_5(JsonConvert.SerializeObject(new List<string>
			{
				Class224.Class227.string_5,
				Class224.Class227.string_6,
				Class224.Class227.string_7,
				Class224.Class227.string_8,
				Class84.smethod_0(-994288804),
				Class348.Class352.string_0,
				Class84.smethod_0(-994288809),
				Class211.smethod_0(10),
				Class211.smethod_0(10),
				Class211.smethod_0(10)
			}), Class320.int_5, 10000);
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add(tuple.Item1, tuple.Item2);
			WebClient webClient2 = new WebClient();
			try
			{
				byte[] bytes = webClient2.UploadValues(Class272.smethod_10(), Class84.smethod_0(-994265316), nameValueCollection);
				string_ = Encoding.UTF8.GetString(bytes);
			}
			finally
			{
				((IDisposable)webClient2).Dispose();
			}
			gClass = Class305.smethod_0(string_, Class320.int_5);
			if (gClass.Value <= 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994288837) + Class249.Class254.smethod_0() + Class84.smethod_0(-994288861) + gClass.Text);
			}
			GClass70 gClass3 = GClass70.smethod_1(gClass.Data.ToString());
			if (gClass3.Value <= 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994288837) + Class249.Class254.smethod_0() + Class84.smethod_0(-994288861) + gClass3.Text);
			}
			List<string> list = JsonConvert.DeserializeObject<List<string>>(gClass3.Data.ToString());
			if (list.Count < 5)
			{
				return new GClass70(-1, Class84.smethod_0(-994288837) + Class249.Class254.smethod_0() + Class84.smethod_0(-994288828));
			}
			Class224.Class233.string_0 = list[0];
			Class224.Class233.string_1 = list[1];
			Class224.Class233.string_2 = list[2];
			Class249.Class251.smethod_1(list[3], Convert.ToInt32(list[4]));
			Class249.Class250.smethod_2(list[8], Convert.ToInt32(list[9]));
			Class249.Class252.smethod_2(list[15], Convert.ToInt32(list[16]));
			return new GClass70(1, Class84.smethod_0(-994247224));
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, Class84.smethod_0(-994288787) + ex.Message, ex);
			return new GClass70(-99, ex.Message);
		}
	}
}
