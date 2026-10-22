using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class321
{
	private sealed class Class322
	{
		public int int_0;

		public int int_1;

		public string string_0;

		public int int_2;

		public string string_1;

		public string string_2;

		public long long_0;

		public long long_1;
	}

	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 103)
			{
				gClass = smethod_10(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 104)
			{
				gClass = smethod_8(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 108)
			{
				gClass = smethod_11(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 109)
			{
				gClass = smethod_9(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 110)
			{
				gClass = smethod_7(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 111)
			{
				gClass = smethod_6(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 113)
			{
				gClass = smethod_3(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 114)
			{
				gClass = smethod_2(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 146)
			{
				gClass = smethod_1(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 147)
			{
				gClass = smethod_4(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 160)
			{
				gClass = smethod_5(gclass4_0, gclass41_0, jsRequest_0);
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
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			List<string> list_ = new List<string>();
			if (!@class.method_3(mySqlConnection, ref list_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			string text = list_[0];
			string text2 = list_[3];
			List<Tuple<string, string>> list = new List<Tuple<string, string>>();
			string commandText = Class84.smethod_0(-994242816) + text2 + Class84.smethod_0(-994242634);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list.Add(new Tuple<string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			List<List<string>> list2 = new List<List<string>>();
			List<int> list3 = new List<int>();
			int num = -1;
			foreach (Tuple<string, string> item7 in list)
			{
				num++;
				string item = item7.Item1;
				string item2 = item7.Item2;
				commandText = Class84.smethod_0(-994246651) + item + Class84.smethod_0(-994246489) + text + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					int num2 = Convert.ToInt32(mySqlDataReader[0]);
					if (num2 > 0)
					{
						long num3 = Convert.ToInt64(mySqlDataReader[1]);
						List<string> item3 = new List<string>
						{
							item,
							item2,
							num2.ToString(),
							Class176.smethod_0(num3.ToString())
						};
						list2.Add(item3);
					}
					else
					{
						list3.Add(num);
					}
				}
				mySqlDataReader.Close();
			}
			foreach (int item8 in list3)
			{
				string item4 = list[item8].Item1;
				string item5 = list[item8].Item2;
				List<string> item6 = new List<string>
				{
					item4,
					item5,
					Class84.smethod_0(-994278690),
					Class84.smethod_0(-994278690)
				};
				list2.Add(item6);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994246419));
			if (list2.Count == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994247224), Class84.smethod_0(-994246346));
			}
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994246331));
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
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			string string_ = string.Empty;
			if (!@class.method_1(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			List<Tuple<int, int>> list = new List<Tuple<int, int>>();
			string format = Class84.smethod_0(-994246267);
			mySqlCommand.CommandText = string.Format(format, string_);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				string[] array = mySqlDataReader[0].ToString().Split('-');
				if (array.Length == 2)
				{
					int item = Convert.ToInt32(array[0]);
					int item2 = Convert.ToInt32(array[1]);
					list.Add(new Tuple<int, int>(item, item2));
				}
			}
			mySqlDataReader.Close();
			format = Class84.smethod_0(-994246073);
			List<List<string>> list2 = new List<List<string>>();
			foreach (Tuple<int, int> item6 in list)
			{
				int item3 = item6.Item1;
				int item4 = item6.Item2;
				int num = 0;
				long num2 = 0L;
				mySqlCommand.CommandText = string.Format(format, string_, item3, item4);
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					num = Convert.ToInt32(mySqlDataReader[0]);
					num2 = Convert.ToInt64(mySqlDataReader[1]);
				}
				mySqlDataReader.Close();
				List<string> item5 = new List<string>
				{
					Class120.smethod_18(item4) + Class84.smethod_0(-994263061) + item3,
					num.ToString(),
					Class176.smethod_0(num2.ToString()),
					item3.ToString(),
					item4.ToString()
				};
				list2.Add(item5);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994245802));
			string object_ = JsonConvert.SerializeObject(list2);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994245730));
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
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			string string_ = string.Empty;
			if (!@class.method_1(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			string requestData = jsRequest_0.UserRequest.RequestData;
			int int_ = Convert.ToInt32(jsRequest_0.UserRequest.RequestDataKey);
			string arg = Class320.smethod_4(requestData, int_);
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994245667), string_, arg);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			List<List<string>> list = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				string item = mySqlDataReader[Class84.smethod_0(-994245302)]?.ToString() + Class84.smethod_0(-994243044) + mySqlDataReader[Class84.smethod_0(-994245305)];
				int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994245259)]);
				string empty = string.Empty;
				empty = ((num != 0) ? (Class84.smethod_0(-994245243) + mySqlDataReader[Class84.smethod_0(-994245197)]) : Class84.smethod_0(-994245274));
				string text = mySqlDataReader[Class84.smethod_0(-994188553)].ToString().Trim();
				if (text.Length != 0)
				{
					empty = empty + Class84.smethod_0(-994245212) + text;
				}
				List<string> item2 = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994263532)].ToString(),
					Class176.smethod_0(mySqlDataReader[Class84.smethod_0(-994297386)].ToString()),
					item,
					empty
				};
				list.Add(item2);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994245176));
			string object_ = JsonConvert.SerializeObject(list);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994245149));
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
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			string string_ = string.Empty;
			if (!@class.method_1(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			string requestData = jsRequest_0.UserRequest.RequestData;
			int int_ = Convert.ToInt32(jsRequest_0.UserRequest.RequestDataKey);
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_4(requestData, int_));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994245067), string_, text, text2, text3);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			List<List<string>> list2 = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				string item = mySqlDataReader[Class84.smethod_0(-994245302)]?.ToString() + Class84.smethod_0(-994243044) + mySqlDataReader[Class84.smethod_0(-994245305)];
				int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994245259)]);
				string empty = string.Empty;
				empty = ((num != 0) ? (Class84.smethod_0(-994245243) + mySqlDataReader[Class84.smethod_0(-994245197)]) : Class84.smethod_0(-994245274));
				string text4 = mySqlDataReader[Class84.smethod_0(-994188553)].ToString().Trim();
				if (text4.Length != 0)
				{
					empty = empty + Class84.smethod_0(-994245212) + text4;
				}
				List<string> item2 = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994263532)].ToString(),
					Class176.smethod_0(mySqlDataReader[Class84.smethod_0(-994297386)].ToString()),
					item,
					empty
				};
				list2.Add(item2);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994244666));
			string object_ = JsonConvert.SerializeObject(list2);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994232311));
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
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			List<string> list_ = new List<string>();
			if (!@class.method_3(mySqlConnection, ref list_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			string text = list_[0];
			string text2 = list_[3];
			List<Tuple<string, string>> list = new List<Tuple<string, string>>();
			string format = Class84.smethod_0(-994232237) + text2 + Class84.smethod_0(-994232117);
			mySqlCommand.CommandText = string.Format(format, text);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list.Add(new Tuple<string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			List<int> list2 = new List<int>();
			List<List<string>> list3 = new List<List<string>>();
			int num = -1;
			foreach (Tuple<string, string> item10 in list)
			{
				num++;
				string item = item10.Item1;
				string item2 = item10.Item2;
				long num2 = 0L;
				format = Class84.smethod_0(-994232002) + item + Class84.smethod_0(-994231895) + text + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = format;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					num2 = (Convert.IsDBNull(mySqlDataReader[0]) ? 0L : Convert.ToInt64(mySqlDataReader[0]));
				}
				mySqlDataReader.Close();
				string item3 = Class84.smethod_0(-994278690);
				string item4 = Class84.smethod_0(-994278690);
				string item5 = Class84.smethod_0(-994278690);
				format = Class84.smethod_0(-994231810) + item + Class84.smethod_0(-994231895) + text + Class84.smethod_0(-994231673);
				mySqlCommand.CommandText = string.Format(format, item, text);
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					item3 = mySqlDataReader[0].ToString();
					item4 = mySqlDataReader[1].ToString();
					item5 = mySqlDataReader[2].ToString();
				}
				mySqlDataReader.Close();
				if (num2 != 0L)
				{
					List<string> item6 = new List<string>
					{
						item,
						item2,
						num2.ToString(),
						item3,
						item4,
						item5
					};
					list3.Add(item6);
				}
				else
				{
					list2.Add(num);
				}
			}
			foreach (int item11 in list2)
			{
				string item7 = list[item11].Item1;
				string item8 = list[item11].Item2;
				List<string> item9 = new List<string>
				{
					item7,
					item8,
					Class84.smethod_0(-994278690),
					Class84.smethod_0(-994278690),
					Class84.smethod_0(-994278690),
					Class84.smethod_0(-994278690)
				};
				list3.Add(item9);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994231544));
			string object_ = JsonConvert.SerializeObject(list3);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994231516));
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
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			string string_ = string.Empty;
			if (!@class.method_1(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			List<Tuple<string, string>> list = new List<Tuple<string, string>>();
			string format = Class84.smethod_0(-994231433);
			mySqlCommand.CommandText = string.Format(format, string_);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list.Add(new Tuple<string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			List<List<string>> list2 = new List<List<string>>();
			foreach (Tuple<string, string> item5 in list)
			{
				string item = item5.Item1;
				string item2 = item5.Item2;
				format = Class84.smethod_0(-994231235);
				mySqlCommand.CommandText = string.Format(format, item, string_);
				long num = Convert.ToInt64(mySqlCommand.ExecuteScalar());
				format = Class84.smethod_0(-994231080);
				mySqlCommand.CommandText = string.Format(format, item, string_);
				mySqlDataReader = mySqlCommand.ExecuteReader();
				long num2 = num;
				bool flag = true;
				int num3 = 0;
				while (mySqlDataReader.Read())
				{
					num3++;
					if (flag)
					{
						flag = false;
						List<string> item3 = new List<string>
						{
							Class84.smethod_0(-994230871),
							item,
							item2,
							mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
							Class176.smethod_0(mySqlDataReader[Class84.smethod_0(-994230874)].ToString()),
							Class176.smethod_0(mySqlDataReader[Class84.smethod_0(-994230830)].ToString()),
							Class176.smethod_0(num2.ToString()),
							Class176.smethod_0(num.ToString())
						};
						list2.Add(item3);
					}
					else
					{
						List<string> item4 = new List<string>
						{
							Class84.smethod_0(-994230833),
							item,
							Class84.smethod_0(-994278690),
							mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
							Class176.smethod_0(mySqlDataReader[Class84.smethod_0(-994230874)].ToString()),
							Class176.smethod_0(mySqlDataReader[Class84.smethod_0(-994230830)].ToString()),
							Class176.smethod_0(num2.ToString()),
							Class84.smethod_0(-994278690)
						};
						list2.Add(item4);
					}
					long num4 = Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994230874)]);
					long num5 = Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994230830)]);
					num2 = ((num4 > 0L) ? (num2 + num4) : (num2 - num5));
				}
				mySqlDataReader.Close();
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994230788));
			string object_ = JsonConvert.SerializeObject(list2);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994230766));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	public static GClass70 smethod_7(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			string string_ = string.Empty;
			if (!@class.method_1(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			string requestData = jsRequest_0.UserRequest.RequestData;
			int int_ = Convert.ToInt32(jsRequest_0.UserRequest.RequestDataKey);
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_4(requestData, int_));
			string arg = list[0];
			string arg2 = list[1];
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994230737), string_, arg, arg2);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			if (dataTable.Rows.Count == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994247224), Class84.smethod_0(-994246346));
			}
			List<List<string>> list2 = new List<List<string>>();
			foreach (DataRow row in dataTable.Rows)
			{
				List<string> item = new List<string>
				{
					row[Class84.smethod_0(-994239992)].ToString(),
					Class176.smethod_0(row[Class84.smethod_0(-994297386)].ToString()),
					row[Class84.smethod_0(-994230482)].ToString()
				};
				list2.Add(item);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994230434));
			string object_ = JsonConvert.SerializeObject(list2);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994230373));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	public static GClass70 smethod_8(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			string requestData = jsRequest_0.UserRequest.RequestData;
			int int_ = Convert.ToInt32(jsRequest_0.UserRequest.RequestDataKey);
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_4(requestData, int_));
			string arg = list[0];
			string arg2 = list[1];
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994230305), arg, arg2);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			if (dataTable.Rows.Count == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994247224), Class84.smethod_0(-994234125));
			}
			List<List<string>> list2 = new List<List<string>>();
			foreach (DataRow row in dataTable.Rows)
			{
				long num = Class159.smethod_2(row[Class84.smethod_0(-994297386)].ToString(), 0L);
				long num2 = Class159.smethod_2(row[Class84.smethod_0(-994234097)].ToString(), 0L);
				long num3 = num + num2;
				List<string> item = new List<string>
				{
					row[Class84.smethod_0(-994239992)].ToString(),
					Class176.smethod_0(num3.ToString()),
					Class176.smethod_0(row[Class84.smethod_0(-994234097)].ToString()),
					Class176.smethod_0(row[Class84.smethod_0(-994297386)].ToString()),
					row[Class84.smethod_0(-994188553)].ToString()
				};
				list2.Add(item);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994234052));
			string object_ = JsonConvert.SerializeObject(list2);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994234042));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_72() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	public static GClass70 smethod_9(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			string string_ = string.Empty;
			if (!@class.method_1(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			string requestData = jsRequest_0.UserRequest.RequestData;
			int int_ = Convert.ToInt32(jsRequest_0.UserRequest.RequestDataKey);
			string arg = Class320.smethod_4(requestData, int_);
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994233977), string_, arg);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			if (dataTable.Rows.Count == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994247224), Class84.smethod_0(-994233639));
			}
			List<List<string>> list = new List<List<string>>();
			foreach (DataRow row in dataTable.Rows)
			{
				List<string> item = new List<string>
				{
					row[Class84.smethod_0(-994233618)].ToString(),
					row[Class84.smethod_0(-994277142)].ToString(),
					row[Class84.smethod_0(-994239992)].ToString(),
					Class176.smethod_0(row[Class84.smethod_0(-994297386)].ToString())
				};
				list.Add(item);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994233583));
			string object_ = JsonConvert.SerializeObject(list);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994233561));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	public static GClass70 smethod_10(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			string string_ = string.Empty;
			if (!@class.method_1(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			string requestData = jsRequest_0.UserRequest.RequestData;
			int int_ = Convert.ToInt32(jsRequest_0.UserRequest.RequestDataKey);
			string arg = Class320.smethod_4(requestData, int_);
			string format = Class84.smethod_0(-994233500);
			mySqlCommand.CommandText = string.Format(format, string_, arg);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			if (dataTable.Rows.Count == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994247224), Class84.smethod_0(-994234125));
			}
			List<List<string>> list = new List<List<string>>();
			foreach (DataRow row in dataTable.Rows)
			{
				string text = row[Class84.smethod_0(-994233036)].ToString();
				int num = Class159.smethod_0(row[Class84.smethod_0(-994233051)].ToString(), 0);
				string item = row[Class84.smethod_0(-994233007)].ToString();
				long num2 = 0L;
				long num3 = 0L;
				format = Class84.smethod_0(-994233009) + text + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = format;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					num2 = Convert.ToInt64(mySqlDataReader[0]);
					num3 = Convert.ToInt64(mySqlDataReader[1]);
				}
				mySqlDataReader.Close();
				long num4 = num - num2 - num3;
				int num5 = Class159.smethod_0(row[Class84.smethod_0(-994297386)].ToString(), 0);
				int num6 = Class159.smethod_0(row[Class84.smethod_0(-994234097)].ToString(), 0);
				int num7 = num5 + num6;
				List<string> item2 = new List<string>
				{
					row[Class84.smethod_0(-994239992)].ToString(),
					row[Class84.smethod_0(-994277142)].ToString(),
					Class176.smethod_0(num7.ToString()),
					Class176.smethod_0(row[Class84.smethod_0(-994234097)].ToString()),
					Class176.smethod_0(row[Class84.smethod_0(-994297386)].ToString()),
					row[Class84.smethod_0(-994233036)].ToString(),
					row[Class84.smethod_0(-994233618)].ToString(),
					row[Class84.smethod_0(-994232845)].ToString(),
					num.ToString(),
					item,
					num4.ToString(),
					row[Class84.smethod_0(-994232859)].ToString()
				};
				list.Add(item2);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994232815));
			string object_ = JsonConvert.SerializeObject(list);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994232796));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	public static GClass70 smethod_11(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			string string_ = string.Empty;
			if (!@class.method_1(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			string empty = string.Empty;
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<Class322> list = new List<Class322>();
			empty = Class84.smethod_0(-994232722);
			mySqlCommand.CommandText = string.Format(empty, string_);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				Class322 item = new Class322
				{
					int_0 = Convert.ToInt32(mySqlDataReader[0]),
					int_1 = Convert.ToInt32(mySqlDataReader[1]),
					string_0 = mySqlDataReader[2].ToString(),
					int_2 = Convert.ToInt32(mySqlDataReader[3]),
					string_1 = mySqlDataReader[4].ToString(),
					string_2 = mySqlDataReader[5].ToString(),
					long_0 = Convert.ToInt64(mySqlDataReader[6]),
					long_1 = Convert.ToInt64(mySqlDataReader[7])
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			empty = Class84.smethod_0(-994232447);
			string format = Class84.smethod_0(-994236232);
			List<List<string>> list2 = new List<List<string>>();
			foreach (Class322 item5 in list)
			{
				mySqlCommand.CommandText = string.Format(empty, item5.int_0);
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					string string_2 = mySqlDataReader[Class84.smethod_0(-994297386)].ToString();
					string item2 = mySqlDataReader[Class84.smethod_0(-994239992)].ToString();
					string string_3 = mySqlDataReader[Class84.smethod_0(-994234097)].ToString();
					mySqlDataReader.Close();
					mySqlCommand.CommandText = string.Format(format, item5.int_0);
					long num = Convert.ToInt64(mySqlCommand.ExecuteScalar());
					long num2 = item5.long_0 - num;
					List<string> item3 = new List<string>
					{
						item5.string_0,
						item5.string_1,
						Class176.smethod_0(num2.ToString()),
						item2,
						Class176.smethod_0(string_2),
						Class176.smethod_0(string_3),
						item5.int_0.ToString(),
						Class176.smethod_0(item5.long_0.ToString()),
						Class176.smethod_0(num.ToString()),
						item5.int_1.ToString(),
						item5.long_0.ToString(),
						item5.long_1.ToString(),
						item5.int_2.ToString()
					};
					list2.Add(item3);
				}
				else
				{
					mySqlDataReader.Close();
					List<string> item4 = new List<string>
					{
						item5.string_0,
						item5.string_1,
						Class176.smethod_0(item5.long_0.ToString()),
						Class84.smethod_0(-994278690),
						Class84.smethod_0(-994278690),
						Class84.smethod_0(-994278690),
						item5.int_0.ToString(),
						Class176.smethod_0(item5.long_0.ToString()),
						Class84.smethod_0(-994278690),
						item5.int_1.ToString(),
						item5.long_0.ToString(),
						item5.long_1.ToString(),
						item5.int_2.ToString()
					};
					list2.Add(item4);
				}
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994236123));
			string object_ = JsonConvert.SerializeObject(list2);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994236056));
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
