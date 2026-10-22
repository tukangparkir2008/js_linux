using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class177
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 127)
			{
				gClass = smethod_8(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 128)
			{
				gClass = smethod_5(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 129)
			{
				gClass = smethod_6(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 139)
			{
				gClass = smethod_4(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 140)
			{
				gClass = smethod_3(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 143)
			{
				gClass = smethod_7(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 144)
			{
				gClass = smethod_2(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 145)
			{
				gClass = smethod_1(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 1533)
			{
				gClass = smethod_9(gclass4_0, gclass41_0, jsRequest_0);
			}
			if (gClass.Value < 0)
			{
				gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, gClass.Text);
				jsRequest_0.Data = string.Empty;
				jsRequest_0.Message = gClass.Text;
				jsRequest_0.ServerStatus = -1;
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
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994237954));
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<Tuple<string, string>> list2 = new List<Tuple<string, string>>();
			string commandText = Class84.smethod_0(-994237934) + text2 + Class84.smethod_0(-994237801) + text + Class84.smethod_0(-994237774) + text3;
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list2.Add(new Tuple<string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			List<List<string>> list3 = new List<List<string>>();
			foreach (Tuple<string, string> item2 in list2)
			{
				commandText = Class84.smethod_0(-994237738) + string_ + Class84.smethod_0(-994237636) + item2.Item1 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				List<string> list4 = new List<string>();
				if (mySqlDataReader.Read())
				{
					string item = ((Convert.IsDBNull(mySqlDataReader[Class84.smethod_0(-994203637)]) || Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994203637)]) == 0) ? string.Empty : (mySqlDataReader[Class84.smethod_0(-994203637)]?.ToString() + Class84.smethod_0(-994240938)));
					list4.Add(item2.Item2);
					list4.Add(mySqlDataReader[Class84.smethod_0(-994237662)].ToString());
					list4.Add(mySqlDataReader[Class84.smethod_0(-994237616)].ToString());
					list4.Add(item);
					list4.Add(mySqlDataReader[Class84.smethod_0(-994237617)].ToString());
					mySqlDataReader.Close();
				}
				else
				{
					mySqlDataReader.Close();
					list4.Add(item2.Item2);
					list4.Add(Class84.smethod_0(-994237583));
					list4.Add(Class84.smethod_0(-994237583));
					list4.Add(string.Empty);
					list4.Add(string.Empty);
				}
				list3.Add(list4);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994237588));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list3));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994237516));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string> list = new List<string>();
			string commandText = Class84.smethod_0(-994237453);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list.Add(mySqlDataReader[0].ToString());
			}
			mySqlDataReader.Close();
			if (list.Count == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994247224), Class84.smethod_0(-994237338));
			}
			int num = 0;
			List<List<string>> list2 = new List<List<string>>();
			foreach (string item2 in list)
			{
				List<string>? list3 = JsonConvert.DeserializeObject<List<string>>(item2);
				int num2 = Convert.ToInt32(list3[0]);
				int num3 = Convert.ToInt32(list3[1]);
				List<string> list4 = new List<string>();
				commandText = string.Format(Class84.smethod_0(-994237227), num2, num3);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					list4.Add(mySqlDataReader[0].ToString());
				}
				mySqlDataReader.Close();
				int num4 = 0;
				int num5 = 0;
				foreach (string item3 in list4)
				{
					commandText = Class84.smethod_0(-994237102) + string_ + Class84.smethod_0(-994237038) + item3 + Class84.smethod_0(-994271698);
					mySqlCommand.CommandText = commandText;
					if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
					{
						num5++;
					}
					else
					{
						num4++;
					}
				}
				num += num4;
				List<string> item = new List<string>
				{
					Class120.smethod_18(num3) + Class84.smethod_0(-994263061) + num2,
					num4.ToString(),
					num5.ToString(),
					num2.ToString(),
					num3.ToString()
				};
				list2.Add(item);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994236998));
			if (num == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994247224), Class84.smethod_0(-994237338));
			}
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994236992));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			List<Tuple<int, string>> list2 = new List<Tuple<int, string>>();
			string format = Class84.smethod_0(-994236915);
			mySqlCommand.CommandText = string.Format(format, string_, text, text2);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list2.Add(new Tuple<int, string>(Convert.ToInt32(mySqlDataReader[0]), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			List<List<string>> list3 = new List<List<string>>();
			if (list2.Count == 0)
			{
				return new GClass70(1, Class84.smethod_0(-994236700), JsonConvert.SerializeObject(list3));
			}
			foreach (Tuple<int, string> item4 in list2)
			{
				int item = item4.Item1;
				string item2 = item4.Item2;
				format = Class84.smethod_0(-994236652);
				mySqlCommand.CommandText = string.Format(format, item, text, text2);
				int num = Convert.ToInt32(mySqlCommand.ExecuteScalar());
				format = Class84.smethod_0(-994236457);
				mySqlCommand.CommandText = string.Format(format, string_, item, text, text2);
				int num2 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
				double num3 = ((num == 0) ? 0.0 : (100.0 * Math.Round((float)num2 / (float)num, 2)));
				List<string> item3 = new List<string>
				{
					item.ToString(),
					item2,
					num.ToString(),
					num2.ToString(),
					num3.ToString()
				};
				list3.Add(item3);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994223944));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list3));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994223916));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string arg = list[0];
			string arg2 = list[1];
			string format = Class84.smethod_0(-994223897);
			format = string.Format(format, string_, arg, arg2);
			mySqlCommand.CommandText = format;
			List<string> list2 = new List<string>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				list2.Add(mySqlDataReader[0].ToString());
				list2.Add(mySqlDataReader[1].ToString());
				list2.Add(mySqlDataReader[2].ToString());
				list2.Add(mySqlDataReader[3].ToString());
				list2.Add(mySqlDataReader[4].ToString());
			}
			mySqlDataReader.Close();
			string item = JsonConvert.SerializeObject(list2);
			format = Class84.smethod_0(-994223615);
			format = string.Format(format, string_, arg, arg2);
			mySqlCommand.CommandText = format;
			List<List<string>> list3 = new List<List<string>>();
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item2 = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString(),
					mySqlDataReader[3].ToString(),
					mySqlDataReader[4].ToString(),
					mySqlDataReader[5].ToString(),
					mySqlDataReader[6].ToString()
				};
				list3.Add(item2);
			}
			mySqlDataReader.Close();
			string item3 = JsonConvert.SerializeObject(list3);
			List<string> value = new List<string> { item3, item };
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994223254));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(value));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994223228));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994223147), string_);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			List<List<string>> list = new List<List<string>>();
			List<string> item = new List<string>
			{
				Class84.smethod_0(-994274584),
				Class84.smethod_0(-994222955)
			};
			list.Add(item);
			foreach (DataRow row in dataTable.Rows)
			{
				item = new List<string>
				{
					row[Class84.smethod_0(-994222916)].ToString(),
					row[Class84.smethod_0(-994222931)].ToString()
				};
				list.Add(item);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994222884));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994222867));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string empty = string.Empty;
			if (text.Equals(Class84.smethod_0(-994274584)))
			{
				empty = Class84.smethod_0(-994222795);
				empty = string.Format(empty, string_);
			}
			else
			{
				empty = Class84.smethod_0(-994222536);
				empty = string.Format(empty, string_, text);
			}
			empty = empty + Class84.smethod_0(-994222281) + text2;
			mySqlCommand.CommandText = empty;
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			List<List<string>> list2 = new List<List<string>>();
			foreach (DataRow row in dataTable.Rows)
			{
				List<string> list3 = new List<string>();
				string item = ((Convert.IsDBNull(row[Class84.smethod_0(-994203637)]) || Convert.ToInt32(row[Class84.smethod_0(-994203637)]) == 0) ? string.Empty : (row[Class84.smethod_0(-994203637)]?.ToString() + Class84.smethod_0(-994240938)));
				list3.Add(row[Class84.smethod_0(-994239992)].ToString());
				list3.Add(row[Class84.smethod_0(-994222931)].ToString());
				list3.Add(row[Class84.smethod_0(-994237662)].ToString());
				list3.Add(row[Class84.smethod_0(-994237616)].ToString());
				list3.Add(item);
				list3.Add(row[Class84.smethod_0(-994237617)].ToString());
				list2.Add(list3);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994222259));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994222233));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string text4 = list[3];
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string empty = string.Empty;
			List<Tuple<string, string>> list2 = new List<Tuple<string, string>>();
			empty = Class84.smethod_0(-994222168);
			mySqlCommand.CommandText = string.Format(empty, text, text2, text3, text4);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list2.Add(new Tuple<string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			empty = Class84.smethod_0(-994226005);
			List<List<string>> list3 = new List<List<string>>();
			foreach (Tuple<string, string> item4 in list2)
			{
				mySqlCommand.CommandText = string.Format(empty, string_, text, item4.Item1);
				MySqlDataReader mySqlDataReader2 = mySqlCommand.ExecuteReader();
				if (mySqlDataReader2.Read())
				{
					string item = ((Convert.IsDBNull(mySqlDataReader2[Class84.smethod_0(-994203637)]) || Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994203637)]) == 0) ? Class84.smethod_0(-994263061) : (mySqlDataReader2[Class84.smethod_0(-994203637)]?.ToString() + Class84.smethod_0(-994240938)));
					List<string> item2 = new List<string>
					{
						item4.Item2,
						mySqlDataReader2[Class84.smethod_0(-994237662)].ToString(),
						mySqlDataReader2[Class84.smethod_0(-994237616)].ToString(),
						item,
						mySqlDataReader2[Class84.smethod_0(-994237617)].ToString()
					};
					list3.Add(item2);
				}
				else
				{
					List<string> item3 = new List<string>
					{
						item4.Item2,
						Class84.smethod_0(-994237583),
						Class84.smethod_0(-994237583),
						string.Empty,
						string.Empty
					};
					list3.Add(item3);
				}
				mySqlDataReader2.Close();
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994225767));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list3));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994225750));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_8(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
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
			string arg = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994225678), string_, arg);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			List<List<string>> list = new List<List<string>>();
			foreach (DataRow row in dataTable.Rows)
			{
				List<string> list2 = new List<string>();
				string item = ((Convert.IsDBNull(row[Class84.smethod_0(-994203637)]) || Convert.ToInt32(row[Class84.smethod_0(-994203637)]) == 0) ? string.Empty : (row[Class84.smethod_0(-994203637)]?.ToString() + Class84.smethod_0(-994240938)));
				list2.Add(row[Class84.smethod_0(-994239992)].ToString());
				list2.Add(row[Class84.smethod_0(-994237662)].ToString());
				list2.Add(row[Class84.smethod_0(-994237616)].ToString());
				list2.Add(item);
				list2.Add(row[Class84.smethod_0(-994237617)].ToString());
				list.Add(list2);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994225451));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994225427));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_9(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string cmdText = Class84.smethod_0(-994225348) + text + Class84.smethod_0(-994224998) + text2 + Class84.smethod_0(-994224932) + text3 + Class84.smethod_0(-994224950);
			List<List<string>> list2 = new List<List<string>>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(cmdText, mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224886)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277105)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224892)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224846)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224863)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224813)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224832)].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994224770));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994224749));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}
}
