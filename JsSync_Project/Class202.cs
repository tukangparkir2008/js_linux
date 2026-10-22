using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;

internal sealed class Class202
{
	private sealed class Class334 : GClass59
	{
		private readonly Class202 class202_0;

		public Class334(Class202 class202_1)
		{
			class202_0 = class202_1;
		}

		public override void vmethod_0(GClass41 gclass41_0, JsRequest jsRequest_0, string string_0)
		{
			try
			{
				if (jsRequest_0.ExecCode == 1)
				{
					gclass41_0.method_44(bool_11: true);
					class202_0.method_6(jsRequest_0);
				}
				else
				{
					gclass41_0.method_44(bool_11: false);
					class202_0.method_9(GEnum0.Error, gclass41_0.method_46(), string.Empty, jsRequest_0.Message);
					class202_0.method_7();
				}
			}
			catch (Exception ex)
			{
				Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			}
		}

		public override void vmethod_1(GClass41 gclass41_0, string string_0)
		{
			try
			{
				gclass41_0.method_44(bool_11: false);
				class202_0.method_7();
			}
			catch (Exception ex)
			{
				Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			}
		}
	}

	private readonly GClass4 gclass4_0;

	private readonly GClass48 gclass48_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private readonly object object_0 = new object();

	public Class202(GClass4 gclass4_1, GClass48 gclass48_1)
	{
		gclass4_0 = gclass4_1;
		gclass48_0 = gclass48_1;
	}

	public void method_0()
	{
		try
		{
			if (!method_2())
			{
				gclass48_0.vmethod_1();
			}
			else if (!method_1())
			{
				gclass48_0.vmethod_1();
			}
			else if (!method_10())
			{
				gclass48_0.vmethod_1();
			}
			else if (!method_11())
			{
				gclass48_0.vmethod_1();
			}
			else
			{
				method_3();
			}
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994101727) + Class224.Class227.smethod_0());
			gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994263061) + ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			gclass48_0.vmethod_1();
		}
	}

	private bool method_1()
	{
		try
		{
			if (!Class348.Class352.bool_2)
			{
				gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994101674));
				gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994101641));
				return false;
			}
			if (!Class348.Class350.string_0.Equals(Class348.Class352.string_5))
			{
				gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994200433) + Class348.Class350.string_0 + Class84.smethod_0(-994200398) + Class348.Class352.string_5 + Class84.smethod_0(-994101593));
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994101552));
			gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994263061) + ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return false;
		}
	}

	private bool method_2()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = Class84.smethod_0(-994247438)
			};
			mySqlCommand.ExecuteNonQuery();
			mySqlCommand.CommandText = Class84.smethod_0(-994247451);
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994101526) + Class224.Class228.string_0 + Class84.smethod_0(-994263069) + Class224.Class228.string_1);
				gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994101501));
				return false;
			}
			Class160.smethod_2(mySqlCommand);
			Class206.smethod_0();
			Class348.Class350.string_0 = Class190.smethod_9(mySqlConnection);
			Class348.Class350.dateTime_0 = Class190.smethod_11(mySqlConnection);
			return true;
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994101526) + Class224.Class228.string_0 + Class84.smethod_0(-994263069) + Class224.Class228.string_1);
			gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994263061) + ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return false;
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private void method_3()
	{
		int_0 = 0;
		int_1 = 0;
		gclass4_0.method_15();
	}

	public void method_4(bool bool_0)
	{
		try
		{
			bool flag = false;
			lock (object_0)
			{
				int_0++;
				if (bool_0)
				{
					int_1++;
				}
				flag = int_0 == Class348.Class352.int_1;
			}
			if (flag)
			{
				gclass4_0.method_40();
				if (int_1 > 0)
				{
					method_5();
					return;
				}
				gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994101436) + Class249.Class251.smethod_0() + Class84.smethod_0(-994263061) + Class249.Class251.string_0);
				gclass48_0.vmethod_1();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_5()
	{
		try
		{
			JsUserRequest userRequest = new JsUserRequest
			{
				SchoolId = Class348.Class352.string_0,
				SchoolName = Class348.Class352.string_1,
				DataId = Class211.smethod_0(10),
				SessionId = Class348.Class353.string_5,
				MaxAgentConn = Class348.Class352.int_1,
				ServerInstanceId = Class348.Class353.string_4
			};
			JsRequest jsRequest_ = new JsRequest(JsProtocol.SchoolRegistration, JsDirection.SchoolToServer, userRequest, 0, 0, 100, Class84.smethod_0(-994101396), null, null);
			lock (object_0)
			{
				int_2 = 0;
				int_3 = 0;
			}
			for (int i = 0; i < gclass4_0.method_10(); i++)
			{
				GClass41 gClass = gclass4_0.method_9(i);
				if (gClass != null && gClass.method_25())
				{
					gClass.method_52(jsRequest_, Class224.Class226.int_7, new Class334(this));
				}
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_6(JsRequest jsRequest_0)
	{
		lock (object_0)
		{
			int_2++;
			int_3++;
			if (int_2 == Class348.Class352.int_1 && int_3 == Class348.Class352.int_1)
			{
				method_8(jsRequest_0.Data.ToString());
				gclass48_0.vmethod_0();
			}
		}
	}

	public void method_7()
	{
		lock (object_0)
		{
			int_2++;
			if (int_2 == Class348.Class352.int_1 && int_3 == 0)
			{
				method_9(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994101345) + Class249.Class251.smethod_0() + Class84.smethod_0(-994263061) + Class249.Class251.string_0);
				gclass48_0.vmethod_1();
			}
		}
	}

	private void method_8(string string_0)
	{
		try
		{
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(string_0);
			Class348.Class353.string_0 = list[0];
			Class348.Class353.string_1 = list[1];
			Class348.Class353.string_2 = list[2];
			Class348.Class353.string_5 = list[3];
			Class348.Class353.string_4 = list[4];
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_9(GEnum0 genum0_0, string string_0, string string_1, string string_2)
	{
		gclass4_0.method_5(genum0_0, string_0, string_1, string_2);
	}

	private bool method_10()
	{
		try
		{
			string string_ = string.Empty;
			bool flag = false;
			int num = 0;
			do
			{
				try
				{
					num++;
					WebClient webClient = new WebClient();
					try
					{
						string_ = webClient.DownloadString(Class249.Class253.smethod_1());
					}
					finally
					{
						((IDisposable)webClient).Dispose();
					}
					flag = true;
				}
				catch (Exception ex)
				{
					Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, Class84.smethod_0(-994288787) + ex.Message, ex);
					Tuple<string, int> tuple = Class135.smethod_0(num);
					gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994288837) + Class249.Class253.smethod_0());
					gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994101318) + tuple.Item1);
					Thread.Sleep(tuple.Item2);
				}
			}
			while (!flag && num < Class135.int_0);
			if (!flag)
			{
				return false;
			}
			GClass70 gClass = Class305.smethod_0(string_, Class320.int_5);
			if (gClass.Value <= 0)
			{
				gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994288837) + Class249.Class253.smethod_0());
				gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994263061) + gClass.Text);
				return false;
			}
			GClass70 gClass2 = GClass70.smethod_1(gClass.Data.ToString());
			if (gClass2.Value <= 0)
			{
				gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994288837) + Class249.Class253.smethod_0());
				gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994263061) + gClass2.Text);
				return false;
			}
			Class272.list_0 = JsonConvert.DeserializeObject<List<string>>(gClass2.Data.ToString());
			return true;
		}
		catch (Exception ex2)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, Class84.smethod_0(-994288787) + ex2.Message, ex2);
			gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994288837) + Class249.Class253.smethod_0());
			gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994263061) + ex2.Message);
			return false;
		}
	}

	private bool method_11()
	{
		try
		{
			Tuple<string, string> tuple = Class320.smethod_5(JsonConvert.SerializeObject(new List<string>
			{
				Class224.Class227.string_5,
				Class224.Class227.string_6,
				Class224.Class227.string_7,
				Class224.Class227.string_8,
				Class348.Class352.string_6,
				Class348.Class352.string_0,
				Class84.smethod_0(-994288809),
				Class211.smethod_0(10),
				Class211.smethod_0(10),
				Class211.smethod_0(10)
			}), Class320.int_5, 10000);
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add(tuple.Item1, tuple.Item2);
			string string_ = string.Empty;
			int num = 0;
			bool flag = false;
			do
			{
				try
				{
					num++;
					WebClient webClient = new WebClient();
					try
					{
						byte[] bytes = webClient.UploadValues(Class272.smethod_10(), Class84.smethod_0(-994265316), nameValueCollection);
						string_ = Encoding.UTF8.GetString(bytes);
					}
					finally
					{
						((IDisposable)webClient).Dispose();
					}
					flag = true;
				}
				catch (Exception ex)
				{
					Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, Class84.smethod_0(-994288787) + ex.Message, ex);
					Tuple<string, int> tuple2 = Class135.smethod_0(num);
					gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994288837) + Class249.Class254.smethod_0());
					gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994101318) + tuple2.Item1);
					Thread.Sleep(5000);
				}
			}
			while (!flag && num < Class135.int_0);
			if (!flag)
			{
				return false;
			}
			GClass70 gClass = Class305.smethod_0(string_, Class320.int_5);
			if (gClass.Value <= 0)
			{
				gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994288837) + Class249.Class254.smethod_0());
				gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994263061) + gClass.Text);
				return false;
			}
			GClass70 gClass2 = GClass70.smethod_1(gClass.Data.ToString());
			if (gClass2.Value <= 0)
			{
				gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994288837) + Class249.Class254.smethod_0());
				gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994263061) + gClass2.Text);
				return false;
			}
			List<string> list = JsonConvert.DeserializeObject<List<string>>(gClass2.Data.ToString());
			if (list.Count < 5)
			{
				gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994288837) + Class249.Class254.smethod_0());
				gclass4_0.method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994101282));
				return false;
			}
			Class224.Class233.string_0 = list[0];
			Class224.Class233.string_1 = list[1];
			Class224.Class233.string_2 = list[2];
			Class249.Class251.smethod_1(list[3], Convert.ToInt32(list[4]));
			Class249.Class250.smethod_2(list[8], Convert.ToInt32(list[9]));
			Class249.Class252.smethod_2(list[15], Convert.ToInt32(list[16]));
			return true;
		}
		catch (Exception ex2)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, Class84.smethod_0(-994288787) + ex2.Message, ex2);
			gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994288837) + Class249.Class254.smethod_0());
			gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994263061) + ex2.Message);
			return false;
		}
	}
}
