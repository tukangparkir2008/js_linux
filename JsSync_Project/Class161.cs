using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class161
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 2221)
			{
				gClass = smethod_7(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2222)
			{
				gClass = smethod_6(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2223)
			{
				gClass = smethod_5(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2224)
			{
				gClass = smethod_4(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2225)
			{
				gClass = smethod_3(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2226)
			{
				gClass = smethod_2(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2227)
			{
				gClass = smethod_1(gclass4_0, gclass41_0, jsRequest_0);
			}
			if (gClass.Value < 0)
			{
				gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), Class84.smethod_0(-994242818), gClass.Text);
				jsRequest_0.Data = string.Empty;
				jsRequest_0.Message = gClass.Text;
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.UserRequest.Inflate();
			}
			else
			{
				jsRequest_0.Data = gClass.Data;
				jsRequest_0.Message = gClass.Text;
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = gClass.Value;
				jsRequest_0.UserRequest.Inflate();
			}
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994242837));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			jsRequest_0.Data = string.Empty;
			jsRequest_0.ServerStatus = -1;
			jsRequest_0.ExecCode = -1;
			jsRequest_0.Message = Class309.smethod_73() + ex.Message;
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
	}

	private static GClass70 smethod_1(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string commandText = Class84.smethod_0(-994157854) + text + Class84.smethod_0(-994157670);
			mySqlCommand.CommandText = commandText;
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994078633));
			}
			int num = 0;
			string arg = string.Empty;
			commandText = Class84.smethod_0(-994078609) + text + Class84.smethod_0(-994157499);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994240446)]);
				arg = mySqlDataReader[Class84.smethod_0(-994078448)].ToString();
			}
			mySqlDataReader.Close();
			string text2 = DateTime.Now.ToString(Class84.smethod_0(-994078461));
			string arg2 = DateTime.Now.ToString(Class84.smethod_0(-994078461));
			string text3 = DateTime.Now.ToString(Class84.smethod_0(-994078461));
			_ = DateTime.Now.Month;
			_ = DateTime.Now.Year;
			commandText = Class84.smethod_0(-994078412);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				text2 = mySqlDataReader[0].ToString();
				arg2 = mySqlDataReader[1].ToString();
				text3 = mySqlDataReader[2].ToString();
				Convert.ToInt32(mySqlDataReader[3]);
				Convert.ToInt32(mySqlDataReader[4]);
			}
			mySqlDataReader.Close();
			List<string> list = null;
			List<Tuple<string, string>> list2 = new List<Tuple<string, string>>();
			commandText = Class84.smethod_0(-994078265);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list2.Add(new Tuple<string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			long num2 = 0L;
			List<List<string>> list3 = new List<List<string>>();
			foreach (Tuple<string, string> item11 in list2)
			{
				string item = item11.Item1;
				string item2 = item11.Item2;
				commandText = string.Format(Class84.smethod_0(-994078092), item, text2, text3, num);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					long num3 = Convert.ToInt64(mySqlDataReader[0]);
					if (num3 > 0L)
					{
						num2 += num3;
						list = new List<string>
						{
							item,
							Class84.smethod_0(-994077703) + item2,
							num3.ToString(),
							string.Empty
						};
						list3.Add(list);
					}
				}
				mySqlDataReader.Close();
			}
			foreach (Tuple<string, string> item12 in list2)
			{
				string item3 = item12.Item1;
				string item4 = item12.Item2;
				commandText = string.Format(Class84.smethod_0(-994077725), item3, text2, text3, num);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					long num4 = Convert.ToInt64(mySqlDataReader[0]);
					if (num4 > 0L)
					{
						num2 += num4;
						list = new List<string>
						{
							item3,
							Class84.smethod_0(-994077703) + item4,
							num4.ToString(),
							string.Empty
						};
						list3.Add(list);
					}
				}
				mySqlDataReader.Close();
			}
			foreach (Tuple<string, string> item13 in list2)
			{
				string item5 = item13.Item1;
				string item6 = item13.Item2;
				commandText = string.Format(Class84.smethod_0(-994077371), item5, text2, text3, num);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					long num5 = Convert.ToInt64(mySqlDataReader[0]);
					if (num5 > 0L)
					{
						num2 += num5;
						list = new List<string>
						{
							item5,
							Class84.smethod_0(-994077703) + item6,
							num5.ToString(),
							string.Empty
						};
						list3.Add(list);
					}
				}
				mySqlDataReader.Close();
			}
			foreach (Tuple<string, string> item14 in list2)
			{
				string item7 = item14.Item1;
				string item8 = item14.Item2;
				commandText = string.Format(Class84.smethod_0(-994076992), item7, text2, text3, num);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					long num6 = Convert.ToInt64(mySqlDataReader[0]);
					if (num6 > 0L)
					{
						num2 += num6;
						list = new List<string>
						{
							item7,
							Class84.smethod_0(-994077703) + item8,
							num6.ToString(),
							string.Empty
						};
						list3.Add(list);
					}
				}
				mySqlDataReader.Close();
			}
			foreach (Tuple<string, string> item15 in list2)
			{
				string item9 = item15.Item1;
				string item10 = item15.Item2;
				commandText = string.Format(Class84.smethod_0(-994080680), item9, text2, text3, num);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					long num7 = Convert.ToInt64(mySqlDataReader[0]);
					if (num7 > 0L)
					{
						num2 += num7;
						list = new List<string>
						{
							item9,
							Class84.smethod_0(-994077703) + item10,
							num7.ToString(),
							string.Empty
						};
						list3.Add(list);
					}
				}
				mySqlDataReader.Close();
			}
			commandText = string.Format(Class84.smethod_0(-994080327), text2, text3, num);
			mySqlCommand.CommandText = commandText;
			long num8 = Convert.ToInt64(mySqlCommand.ExecuteScalar());
			list = new List<string>
			{
				string.Empty,
				Class84.smethod_0(-994080063),
				num8.ToString(),
				string.Empty
			};
			list3.Add(list);
			long num9 = num2 + num8;
			list = new List<string>
			{
				Class84.smethod_0(-994080023),
				Class84.smethod_0(-994080027),
				string.Empty,
				num9.ToString()
			};
			list3.Add(list);
			List<List<string>> list4 = new List<List<string>>();
			commandText = string.Format(Class84.smethod_0(-994079951), text2, text3, num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			long num10 = 0L;
			if (mySqlDataReader.Read())
			{
				num10 = Convert.ToInt64(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			if (num10 > 0L)
			{
				list = new List<string>
				{
					string.Empty,
					Class84.smethod_0(-994079573),
					num10.ToString(),
					string.Empty
				};
				list4.Add(list);
			}
			commandText = string.Format(Class84.smethod_0(-994079542), text2, text3, num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			long num11 = 0L;
			if (mySqlDataReader.Read())
			{
				num11 = Convert.ToInt64(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			if (num11 > 0L)
			{
				list = new List<string>
				{
					string.Empty,
					Class84.smethod_0(-994079164),
					num11.ToString(),
					string.Empty
				};
				list4.Add(list);
			}
			commandText = string.Format(Class84.smethod_0(-994079132), text2, text3, num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			long num12 = 0L;
			if (mySqlDataReader.Read())
			{
				num12 = Convert.ToInt64(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			if (num12 > 0L)
			{
				list = new List<string>
				{
					string.Empty,
					Class84.smethod_0(-994082785),
					num12.ToString(),
					string.Empty
				};
				list4.Add(list);
			}
			commandText = string.Format(Class84.smethod_0(-994082811), text2, text3, num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			long num13 = 0L;
			if (mySqlDataReader.Read())
			{
				num13 = Convert.ToInt64(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			if (num13 > 0L)
			{
				list = new List<string>
				{
					string.Empty,
					Class84.smethod_0(-994082382),
					num13.ToString(),
					string.Empty
				};
				list4.Add(list);
			}
			long num14 = num10 + num11 + num12 + num13;
			list = new List<string>
			{
				Class84.smethod_0(-994080023),
				Class84.smethod_0(-994082393),
				string.Empty,
				num14.ToString()
			};
			list4.Add(list);
			List<List<string>> list5 = new List<List<string>>();
			commandText = string.Format(Class84.smethod_0(-994082305), text2, text3, num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			long num15 = 0L;
			while (mySqlDataReader.Read())
			{
				long num16 = Convert.ToInt64(mySqlDataReader[1]);
				if (num16 > 0L)
				{
					num15 += num16;
					list = new List<string>
					{
						string.Empty,
						Class84.smethod_0(-994081901) + mySqlDataReader[0],
						num16.ToString(),
						string.Empty
					};
					list5.Add(list);
				}
			}
			mySqlDataReader.Close();
			commandText = string.Format(Class84.smethod_0(-994081865), text2, text3, num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			long num17 = 0L;
			while (mySqlDataReader.Read())
			{
				long num18 = Convert.ToInt64(mySqlDataReader[1]);
				if (num18 > 0L)
				{
					num17 += num18;
					list = new List<string>
					{
						string.Empty,
						Class84.smethod_0(-994081459) + mySqlDataReader[0],
						num18.ToString(),
						string.Empty
					};
					list5.Add(list);
				}
			}
			mySqlDataReader.Close();
			commandText = string.Format(Class84.smethod_0(-994081435), text2, text3, num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			long num19 = 0L;
			while (mySqlDataReader.Read())
			{
				long num20 = Convert.ToInt64(mySqlDataReader[1]);
				if (num20 > 0L)
				{
					num19 += num20;
					list = new List<string>
					{
						string.Empty,
						mySqlDataReader[0].ToString(),
						num20.ToString(),
						string.Empty
					};
					list5.Add(list);
				}
			}
			mySqlDataReader.Close();
			long num21 = num15 + num17 + num19;
			list = new List<string>
			{
				Class84.smethod_0(-994080023),
				Class84.smethod_0(-994081019),
				string.Empty,
				num21.ToString()
			};
			list5.Add(list);
			List<List<string>> list6 = new List<List<string>>();
			long num22 = num9 + num14 + num21;
			list = new List<string>
			{
				Class84.smethod_0(-994080023),
				Class84.smethod_0(-994080930),
				string.Empty,
				num22.ToString()
			};
			list6.Add(list);
			commandText = string.Format(Class84.smethod_0(-994080958), arg, arg2, num);
			mySqlCommand.CommandText = commandText;
			long num23 = Convert.ToInt64(mySqlCommand.ExecuteScalar());
			List<List<string>> list7 = new List<List<string>>();
			list = new List<string>
			{
				Class84.smethod_0(-994080023),
				Class84.smethod_0(-994068380) + text2,
				string.Empty,
				num23.ToString()
			};
			list7.Add(list);
			long num24 = num23 + num22;
			List<List<string>> list8 = new List<List<string>>();
			list = new List<string>
			{
				Class84.smethod_0(-994080023),
				Class84.smethod_0(-994068380) + text3,
				string.Empty,
				num24.ToString()
			};
			list8.Add(list);
			List<string> value = new List<string>
			{
				JsonConvert.SerializeObject(list3),
				JsonConvert.SerializeObject(list4),
				JsonConvert.SerializeObject(list5),
				JsonConvert.SerializeObject(list6),
				JsonConvert.SerializeObject(list7),
				JsonConvert.SerializeObject(list8)
			};
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994068331));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(value));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994068292));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_2(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string commandText = Class84.smethod_0(-994157854) + text + Class84.smethod_0(-994157670);
			mySqlCommand.CommandText = commandText;
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994078633));
			}
			int num = 0;
			commandText = Class84.smethod_0(-994157630) + text + Class84.smethod_0(-994157499);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994240446)]);
			}
			mySqlDataReader.Close();
			List<string> list = null;
			long num2 = 0L;
			List<List<string>> list2 = new List<List<string>>();
			commandText = string.Format(Class84.smethod_0(-994068262), num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				num2 += Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994297386)]);
				list = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994067908)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994297386)].ToString(),
					string.Empty
				};
				list2.Add(list);
			}
			mySqlDataReader.Close();
			list = new List<string>
			{
				Class84.smethod_0(-994080023),
				Class84.smethod_0(-994067926),
				string.Empty,
				num2.ToString()
			};
			list2.Add(list);
			long num3 = 0L;
			List<List<string>> list3 = new List<List<string>>();
			commandText = Class84.smethod_0(-994067896);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				num3 += Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994297386)]);
				list = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994067908)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994297386)].ToString(),
					string.Empty
				};
				list3.Add(list);
			}
			mySqlDataReader.Close();
			list = new List<string>
			{
				Class84.smethod_0(-994080023),
				Class84.smethod_0(-994067577),
				string.Empty,
				num3.ToString()
			};
			list3.Add(list);
			List<List<string>> list4 = new List<List<string>>();
			list = new List<string>
			{
				Class84.smethod_0(-994080023),
				Class84.smethod_0(-994067548),
				string.Empty,
				(num2 + num3).ToString()
			};
			list4.Add(list);
			long num4 = 0L;
			List<List<string>> list5 = new List<List<string>>();
			commandText = string.Format(Class84.smethod_0(-994067498), num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				num4 += Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994297386)]);
				list = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994067908)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994297386)].ToString(),
					string.Empty
				};
				list5.Add(list);
			}
			mySqlDataReader.Close();
			list = new List<string>
			{
				Class84.smethod_0(-994080023),
				Class84.smethod_0(-994067187),
				string.Empty,
				num4.ToString()
			};
			list5.Add(list);
			long num5 = 0L;
			commandText = string.Format(Class84.smethod_0(-994067148), num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num5 = Convert.ToInt64(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			long num6 = 0L;
			commandText = string.Format(Class84.smethod_0(-994066885), num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num6 = Convert.ToInt64(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			long num7 = num5 - num6;
			List<List<string>> list6 = new List<List<string>>();
			list = new List<string>
			{
				Class84.smethod_0(-994080023),
				Class84.smethod_0(-994066638),
				string.Empty,
				num7.ToString()
			};
			list6.Add(list);
			List<List<string>> list7 = new List<List<string>>();
			list = new List<string>
			{
				Class84.smethod_0(-994080023),
				Class84.smethod_0(-994066605),
				string.Empty,
				(num7 + num4).ToString()
			};
			list7.Add(list);
			List<string> value = new List<string>
			{
				JsonConvert.SerializeObject(list2),
				JsonConvert.SerializeObject(list3),
				JsonConvert.SerializeObject(list4),
				JsonConvert.SerializeObject(list5),
				JsonConvert.SerializeObject(list6),
				JsonConvert.SerializeObject(list7)
			};
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994066573));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(value));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994066536));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_3(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string commandText = Class84.smethod_0(-994157854) + text + Class84.smethod_0(-994157670);
			mySqlCommand.CommandText = commandText;
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994078633));
			}
			int num = 0;
			string arg = string.Empty;
			commandText = Class84.smethod_0(-994078609) + text + Class84.smethod_0(-994157499);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994240446)]);
				arg = mySqlDataReader[Class84.smethod_0(-994078448)].ToString();
			}
			mySqlDataReader.Close();
			string arg2 = DateTime.Now.ToString(Class84.smethod_0(-994078461));
			string arg3 = DateTime.Now.ToString(Class84.smethod_0(-994078461));
			string text2 = DateTime.Now.ToString(Class84.smethod_0(-994078461));
			int int_ = DateTime.Now.Month;
			int num2 = DateTime.Now.Year;
			commandText = Class84.smethod_0(-994078412);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				arg2 = mySqlDataReader[0].ToString();
				arg3 = mySqlDataReader[1].ToString();
				text2 = mySqlDataReader[2].ToString();
				num2 = Convert.ToInt32(mySqlDataReader[3]);
				int_ = Convert.ToInt32(mySqlDataReader[4]);
			}
			mySqlDataReader.Close();
			long num3 = 0L;
			commandText = string.Format(Class84.smethod_0(-994066556), num, arg, arg3);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num3 = (Convert.IsDBNull(mySqlDataReader[0]) ? 0L : Convert.ToInt64(mySqlDataReader[0]));
			}
			mySqlDataReader.Close();
			long num4 = 0L;
			commandText = string.Format(Class84.smethod_0(-994070352), num, arg, arg3);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num4 = (Convert.IsDBNull(mySqlDataReader[0]) ? 0L : Convert.ToInt64(mySqlDataReader[0]));
			}
			mySqlDataReader.Close();
			long num5 = num3 - num4;
			long num6 = 0L;
			commandText = string.Format(Class84.smethod_0(-994070054), num, arg2, text2);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num6 = (Convert.IsDBNull(mySqlDataReader[0]) ? 0L : Convert.ToInt64(mySqlDataReader[0]));
			}
			mySqlDataReader.Close();
			long num7 = 0L;
			commandText = string.Format(Class84.smethod_0(-994069771), num, arg2, text2);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num7 = (Convert.IsDBNull(mySqlDataReader[0]) ? 0L : Convert.ToInt64(mySqlDataReader[0]));
			}
			mySqlDataReader.Close();
			long num8 = 0L;
			commandText = string.Format(Class84.smethod_0(-994069490), num, arg2, text2);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num8 = (Convert.IsDBNull(mySqlDataReader[0]) ? 0L : Convert.ToInt64(mySqlDataReader[0]));
			}
			mySqlDataReader.Close();
			long num9 = 0L;
			commandText = string.Format(Class84.smethod_0(-994069199), num, arg2, text2);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num9 = (Convert.IsDBNull(mySqlDataReader[0]) ? 0L : Convert.ToInt64(mySqlDataReader[0]));
			}
			mySqlDataReader.Close();
			long num10 = num8 - num9;
			long num11 = num5 + num6 - num7 + num10;
			List<List<string>> list = new List<List<string>>();
			List<string> item = new List<string>
			{
				Class84.smethod_0(-994068959) + Class120.smethod_18(int_) + Class84.smethod_0(-994263061) + num2,
				num5.ToString()
			};
			list.Add(item);
			item = new List<string>
			{
				Class84.smethod_0(-994068906) + Class120.smethod_18(int_) + Class84.smethod_0(-994263061) + num2,
				num6.ToString()
			};
			list.Add(item);
			item = new List<string>
			{
				Class84.smethod_0(-994068868) + Class120.smethod_18(int_) + Class84.smethod_0(-994263061) + num2,
				(-1L * num7).ToString()
			};
			list.Add(item);
			string text3 = ((num8 > num9) ? Class84.smethod_0(-994068833) : Class84.smethod_0(-994068892));
			List<string> list2 = new List<string>();
			list2.Add(text3 + Class84.smethod_0(-994068854) + Class120.smethod_18(int_) + Class84.smethod_0(-994263061) + num2);
			list2.Add(num10.ToString());
			item = list2;
			list.Add(item);
			item = new List<string>
			{
				Class84.smethod_0(-994068857) + text2,
				num11.ToString()
			};
			list.Add(item);
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994068832));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994068786));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_4(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string commandText = Class84.smethod_0(-994157854) + text + Class84.smethod_0(-994157670);
			mySqlCommand.CommandText = commandText;
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994078633));
			}
			int num = 0;
			commandText = Class84.smethod_0(-994157630) + text + Class84.smethod_0(-994157499);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			string commandText2 = string.Format(Class84.smethod_0(-994068765), num);
			string commandText3 = string.Format(Class84.smethod_0(-994072472), num);
			long num2 = 0L;
			List<List<string>> list = new List<List<string>>();
			mySqlCommand.CommandText = commandText2;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			List<string> item;
			while (mySqlDataReader.Read())
			{
				long num3 = Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994230830)]) - Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994230874)]);
				num2 += num3;
				item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994296808)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					num3.ToString(),
					string.Empty,
					string.Empty
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			item = new List<string>
			{
				Class84.smethod_0(-994080023),
				Class84.smethod_0(-994072065),
				string.Empty,
				string.Empty,
				num2.ToString()
			};
			list.Add(item);
			long num4 = 0L;
			List<List<string>> list2 = new List<List<string>>();
			mySqlCommand.CommandText = commandText3;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				long num5 = Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994230874)]) - Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994230830)]);
				num4 += num5;
				item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994296808)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					string.Empty,
					num5.ToString(),
					string.Empty
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			item = new List<string>
			{
				Class84.smethod_0(-994080023),
				Class84.smethod_0(-994072038),
				string.Empty,
				string.Empty,
				num4.ToString()
			};
			list2.Add(item);
			string item2 = Class84.smethod_0(-994072064);
			long num6 = num2 - num4;
			if (num4 > num2)
			{
				item2 = Class84.smethod_0(-994072005);
			}
			List<string> value = new List<string>
			{
				item2,
				num6.ToString()
			};
			List<string> value2 = new List<string>
			{
				JsonConvert.SerializeObject(list),
				JsonConvert.SerializeObject(list2),
				JsonConvert.SerializeObject(value)
			};
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994072010));
			string object_ = JsonConvert.SerializeObject(value2);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994071970));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_5(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string commandText = Class84.smethod_0(-994157854) + text + Class84.smethod_0(-994157670);
			mySqlCommand.CommandText = commandText;
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994078633));
			}
			int num = 0;
			commandText = Class84.smethod_0(-994157630) + text + Class84.smethod_0(-994157499);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			long num2 = 0L;
			long num3 = 0L;
			List<List<string>> list = new List<List<string>>();
			commandText = string.Format(Class84.smethod_0(-994071939), num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			List<string> item3;
			while (mySqlDataReader.Read())
			{
				string item = string.Empty;
				string item2 = string.Empty;
				string text2 = mySqlDataReader[Class84.smethod_0(-994214738)].ToString();
				if (!(text2 == Class84.smethod_0(-994071640)) && !(text2 == Class84.smethod_0(-994071644)) && !(text2 == Class84.smethod_0(-994071598)) && !(text2 == Class84.smethod_0(-994071613)))
				{
					long num4 = Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994230830)]) - Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994230874)]);
					item2 = num4.ToString();
					num3 += num4;
				}
				else
				{
					long num5 = Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994230874)]) - Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994230830)]);
					item = num5.ToString();
					num2 += num5;
				}
				item3 = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994296808)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					item,
					item2
				};
				list.Add(item3);
			}
			mySqlDataReader.Close();
			item3 = new List<string>
			{
				Class84.smethod_0(-994080023),
				string.Empty,
				num2.ToString(),
				num3.ToString()
			};
			list.Add(item3);
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994071553));
			string object_ = JsonConvert.SerializeObject(list);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994071522));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_6(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string commandText = Class84.smethod_0(-994157854) + text + Class84.smethod_0(-994157670);
			mySqlCommand.CommandText = commandText;
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994078633));
			}
			int num = 0;
			commandText = Class84.smethod_0(-994157630) + text + Class84.smethod_0(-994157499);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			long num2 = 0L;
			long num3 = 0L;
			List<List<string>> list = new List<List<string>>();
			commandText = string.Format(Class84.smethod_0(-994071500), num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			List<string> item;
			while (mySqlDataReader.Read())
			{
				item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994296808)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994230874)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994230830)].ToString()
				};
				list.Add(item);
				num2 += Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994230874)]);
				num3 += Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994230830)]);
			}
			mySqlDataReader.Close();
			item = new List<string>
			{
				Class84.smethod_0(-994080023),
				string.Empty,
				num2.ToString(),
				num3.ToString()
			};
			list.Add(item);
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994071257));
			string object_ = JsonConvert.SerializeObject(list);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994071232));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_7(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string text4 = list[3];
			string commandText = Class84.smethod_0(-994157854) + text + Class84.smethod_0(-994157670);
			mySqlCommand.CommandText = commandText;
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994078633));
			}
			int num = 0;
			commandText = Class84.smethod_0(-994157630) + text + Class84.smethod_0(-994157499);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			List<List<string>> list2 = new List<List<string>>();
			commandText = string.Format(Class84.smethod_0(-994071200), text, text2, text3, num, text4);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994070825)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994245305)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994156399)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188553)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994230874)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994230830)].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994070845));
			string object_ = JsonConvert.SerializeObject(list2);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994070812));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}
}
