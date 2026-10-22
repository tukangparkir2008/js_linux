using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class166
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 2305)
			{
				gClass = smethod_14(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2306)
			{
				gClass = smethod_13(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2307)
			{
				gClass = smethod_12(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2308)
			{
				gClass = smethod_11(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2309)
			{
				gClass = smethod_9(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2310)
			{
				gClass = smethod_5(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2311)
			{
				gClass = smethod_4(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2313)
			{
				gClass = smethod_8(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2314)
			{
				gClass = smethod_2(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2315)
			{
				gClass = smethod_1(gclass4_0, gclass41_0, jsRequest_0);
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
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994239857));
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string text4 = list[3];
			string text5 = Class84.smethod_0(-994179118) + text2 + Class84.smethod_0(-994200012) + text + Class84.smethod_0(-994271698);
			if (!text3.Equals(Class84.smethod_0(-994274584)))
			{
				text5 = text5 + Class84.smethod_0(-994242328) + text3;
			}
			text5 = text5 + Class84.smethod_0(-994166281) + text4;
			MySqlDataReader mySqlDataReader = new MySqlCommand(text5, mySqlConnection).ExecuteReader();
			List<List<string>> list2 = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				int int_ = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166231)]);
				double double_ = Convert.ToDouble(mySqlDataReader[Class84.smethod_0(-994166182)]);
				Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166188)]);
				int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166207)]);
				int num2 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166145)]);
				int num3 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166163)]);
				int num4 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166114)]);
				int num5 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166131)]);
				string item = mySqlDataReader[Class84.smethod_0(-994277142)].ToString();
				string item2 = mySqlDataReader[Class84.smethod_0(-994268488)].ToString();
				string item3 = mySqlDataReader[Class84.smethod_0(-994166083)].ToString();
				int num6 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166101)]);
				int num7 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994241099)]);
				int num8 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994241072)]);
				double num9 = Convert.ToDouble(mySqlDataReader[Class84.smethod_0(-994241168)]);
				int num10 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994240936)]);
				string item4 = mySqlDataReader[Class84.smethod_0(-994263532)].ToString();
				int num11 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994276441)]);
				string item5 = ((Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166050)]) == 1) ? Class84.smethod_0(-994166020) : Class84.smethod_0(-994166066));
				string item6 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166039)]) switch
				{
					2 => Class84.smethod_0(-994166005), 
					1 => Class84.smethod_0(-994165959), 
					0 => Class84.smethod_0(-994278690), 
					_ => Class84.smethod_0(-994165990), 
				};
				int num12 = ((Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994241172)]) != 0) ? 1 : 0);
				string item7 = mySqlDataReader[Class84.smethod_0(-994165961)].ToString();
				string item8 = ((num11 == 1) ? Class84.smethod_0(-994240783) : num9.ToString());
				string item9 = smethod_6(num9, double_, num11);
				string item10 = smethod_7(num11, 0, 0);
				string item11 = ColorTranslator.ToHtml(new GClass26(0, int_, -99).method_2(Convert.ToInt32(num9)));
				string item12 = JsonConvert.SerializeObject(new List<string>
				{
					item2,
					item,
					item4,
					item8,
					item11,
					num6.ToString(),
					num11.ToString(),
					num12.ToString(),
					num.ToString(),
					num2.ToString(),
					num3.ToString(),
					num4.ToString(),
					num5.ToString(),
					item7,
					item3
				});
				List<string> item13 = new List<string>
				{
					num6.ToString(),
					num7.ToString(),
					num8.ToString(),
					item8,
					item11,
					num10.ToString(),
					item4,
					item9,
					item10,
					item5,
					item6,
					item12
				};
				list2.Add(item13);
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994165978));
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994165901) + text2 + Class84.smethod_0(-994200012) + text + Class84.smethod_0(-994165654), mySqlConnection).ExecuteReader();
			List<List<string>> list2 = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994273283)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188054)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994165587));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static double smethod_3(int int_0, int int_1)
	{
		if (int_1 == 0)
		{
			return 0.0;
		}
		double result = Math.Round((double)int_0 / (double)int_1, 2) * 100.0;
		string text = result.ToString() ?? string.Empty;
		text = text.Replace(',', '.');
		int num = text.IndexOf(Class84.smethod_0(-994272055), StringComparison.Ordinal);
		if (num < 0)
		{
			return result;
		}
		if (Class159.smethod_0(text.Substring(num + 1), 0) != 0)
		{
			return result;
		}
		return Class159.smethod_1(text.Substring(0, num), 0.0);
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string format = string.Empty;
			List<List<string>> list2 = new List<List<string>>();
			if (text3.Equals(Class84.smethod_0(-994165563)))
			{
				format = (mySqlCommand.CommandText = Class84.smethod_0(-994165515) + text + Class84.smethod_0(-994165372));
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
				DataTable dataTable = new DataTable();
				mySqlDataAdapter.Fill(dataTable);
				if (text2.Equals(Class84.smethod_0(-994165221)))
				{
					format = Class84.smethod_0(-994165239);
				}
				else if (text2.Equals(Class84.smethod_0(-994165073)))
				{
					format = Class84.smethod_0(-994165026);
				}
				int num = 0;
				foreach (DataRow row in dataTable.Rows)
				{
					string arg = row[Class84.smethod_0(-994188054)].ToString();
					string text5 = row[Class84.smethod_0(-994277142)].ToString();
					mySqlCommand.CommandText = string.Format(format, text, arg);
					int num2 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
					if (num2 != 0)
					{
						num += num2;
						List<string> item = new List<string>
						{
							Class84.smethod_0(-994164855) + text5 + Class84.smethod_0(-994164861),
							num2.ToString(),
							Class84.smethod_0(-994274584)
						};
						list2.Add(item);
					}
				}
				for (int i = 0; i < list2.Count; i++)
				{
					int int_ = Convert.ToInt32(list2[i][1]);
					list2[i][2] = smethod_3(int_, num).ToString();
				}
			}
			else if (text3.Equals(Class84.smethod_0(-994164802)))
			{
				DataTable dataTable2 = new DataTable();
				if (text2.Equals(Class84.smethod_0(-994165073)))
				{
					format = Class84.smethod_0(-994164823) + text + Class84.smethod_0(-994168706);
					mySqlCommand.CommandText = format;
					MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter(mySqlCommand);
					dataTable2 = new DataTable();
					mySqlDataAdapter2.Fill(dataTable2);
					format = Class84.smethod_0(-994168646);
				}
				else if (text2.Equals(Class84.smethod_0(-994165221)))
				{
					format = Class84.smethod_0(-994168461) + text + Class84.smethod_0(-994168272);
					mySqlCommand.CommandText = format;
					MySqlDataAdapter mySqlDataAdapter3 = new MySqlDataAdapter(mySqlCommand);
					dataTable2 = new DataTable();
					mySqlDataAdapter3.Fill(dataTable2);
					format = Class84.smethod_0(-994168197);
				}
				int num3 = 0;
				foreach (DataRow row2 in dataTable2.Rows)
				{
					string text6 = row2[Class84.smethod_0(-994166083)].ToString();
					string text7 = row2[Class84.smethod_0(-994277142)].ToString();
					mySqlCommand.CommandText = string.Format(format, text, text6);
					int num4 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
					num3 += num4;
					List<string> item2 = new List<string>
					{
						Class84.smethod_0(-994164855) + text7 + Class84.smethod_0(-994244006) + text6,
						num4.ToString(),
						Class84.smethod_0(-994274584)
					};
					list2.Add(item2);
				}
				for (int j = 0; j < list2.Count; j++)
				{
					int int_2 = Convert.ToInt32(list2[j][1]);
					list2[j][2] = smethod_3(int_2, num3).ToString();
				}
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994168033));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994168005));
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994167970) + text + Class84.smethod_0(-994167643) + text2, mySqlConnection).ExecuteReader();
			List<List<string>> list2 = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994264162)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994268488)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188553)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994166188)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994166083)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994221697)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188054)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224892)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994167489)].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994167518));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994167431));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static string smethod_6(double double_0, double double_1, int int_0)
	{
		if (int_0 == 2)
		{
			if (!(double_0 >= double_1))
			{
				return Class84.smethod_0(-994240794);
			}
			return Class84.smethod_0(-994240790);
		}
		return Class84.smethod_0(-994240783);
	}

	private static string smethod_7(int int_0, int int_1, int int_2)
	{
		string text = ((int_1 == 1) ? Class84.smethod_0(-994240749) : string.Empty);
		if (int_0 == 0)
		{
			text = ((int_2 != 1) ? (text + Class84.smethod_0(-994240718)) : (text + Class84.smethod_0(-994167401)));
		}
		if (int_0 == -1)
		{
			text += Class84.smethod_0(-994240764);
		}
		if (int_0 == 1)
		{
			text += Class84.smethod_0(-994240677);
		}
		if (int_0 == 2)
		{
			text += Class84.smethod_0(-994240648);
		}
		return text;
	}

	private static GClass70 smethod_8(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
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
			string arg = ((!text2.Equals(Class84.smethod_0(-994274584))) ? text2 : text);
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add(Class84.smethod_0(-994166101), typeof(int));
			dataTable.Columns.Add(Class84.smethod_0(-994167380), typeof(int));
			dataTable.Columns.Add(Class84.smethod_0(-994247190), typeof(string));
			dataTable.Columns.Add(Class84.smethod_0(-994167329), typeof(string));
			dataTable.Columns.Add(Class84.smethod_0(-994277105), typeof(string));
			dataTable.Columns.Add(Class84.smethod_0(-994276441), typeof(int));
			string empty = string.Empty;
			int num = 0;
			empty = Class84.smethod_0(-994167346) + text;
			mySqlCommand.CommandText = empty;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166188)]);
			}
			mySqlDataReader.Close();
			empty = Class84.smethod_0(-994167203);
			if (!text2.Equals(Class84.smethod_0(-994274584)))
			{
				empty += Class84.smethod_0(-994166819);
				empty = string.Format(empty, arg, text);
			}
			else
			{
				empty += Class84.smethod_0(-994166787);
				empty = string.Format(empty, text);
			}
			mySqlCommand.CommandText = empty;
			MySqlDataReader mySqlDataReader2 = mySqlCommand.ExecuteReader();
			while (mySqlDataReader2.Read())
			{
				int num2 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994264162)]);
				int num3 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994167380)]);
				string value = num3 switch
				{
					2 => mySqlDataReader2[Class84.smethod_0(-994277136)].ToString(), 
					1 => mySqlDataReader2[Class84.smethod_0(-994266832)].ToString(), 
					_ => mySqlDataReader2[Class84.smethod_0(-994270443)].ToString(), 
				};
				string value2 = num3 switch
				{
					2 => mySqlDataReader2[Class84.smethod_0(-994257743)].ToString(), 
					1 => mySqlDataReader2[Class84.smethod_0(-994257747)].ToString(), 
					_ => mySqlDataReader2[Class84.smethod_0(-994166809)].ToString(), 
				};
				string value3 = num3 switch
				{
					2 => mySqlDataReader2[Class84.smethod_0(-994277105)].ToString(), 
					1 => Class84.smethod_0(-994278690), 
					_ => mySqlDataReader2[Class84.smethod_0(-994268131)].ToString(), 
				};
				int num4 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994276441)]);
				DataRow dataRow = dataTable.NewRow();
				dataRow[Class84.smethod_0(-994166101)] = num2;
				dataRow[Class84.smethod_0(-994167380)] = num3;
				dataRow[Class84.smethod_0(-994247190)] = value;
				dataRow[Class84.smethod_0(-994167329)] = value2;
				dataRow[Class84.smethod_0(-994277105)] = value3;
				dataRow[Class84.smethod_0(-994276441)] = num4;
				dataTable.Rows.Add(dataRow);
			}
			mySqlDataReader2.Close();
			empty = Class84.smethod_0(-994170872);
			if (!text2.Equals(Class84.smethod_0(-994274584)))
			{
				empty += Class84.smethod_0(-994170441);
				empty = string.Format(empty, arg, num, text);
			}
			else
			{
				empty += Class84.smethod_0(-994166787);
				empty = string.Format(empty, text, num);
			}
			mySqlCommand.CommandText = empty;
			mySqlDataReader2 = mySqlCommand.ExecuteReader();
			while (mySqlDataReader2.Read())
			{
				int num5 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994264162)]);
				int num6 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994167380)]);
				string value4 = num6 switch
				{
					2 => mySqlDataReader2[Class84.smethod_0(-994277136)].ToString(), 
					1 => mySqlDataReader2[Class84.smethod_0(-994266832)].ToString(), 
					_ => mySqlDataReader2[Class84.smethod_0(-994270443)].ToString(), 
				};
				string value5 = num6 switch
				{
					2 => mySqlDataReader2[Class84.smethod_0(-994257743)].ToString(), 
					1 => mySqlDataReader2[Class84.smethod_0(-994257747)].ToString(), 
					_ => mySqlDataReader2[Class84.smethod_0(-994166809)].ToString(), 
				};
				string value6 = num6 switch
				{
					2 => mySqlDataReader2[Class84.smethod_0(-994277105)].ToString(), 
					1 => Class84.smethod_0(-994278690), 
					_ => mySqlDataReader2[Class84.smethod_0(-994268131)].ToString(), 
				};
				int num7 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994276441)]);
				DataRow dataRow2 = dataTable.NewRow();
				dataRow2[Class84.smethod_0(-994166101)] = num5;
				dataRow2[Class84.smethod_0(-994167380)] = num6;
				dataRow2[Class84.smethod_0(-994247190)] = value4;
				dataRow2[Class84.smethod_0(-994167329)] = value5;
				dataRow2[Class84.smethod_0(-994277105)] = value6;
				dataRow2[Class84.smethod_0(-994276441)] = num7;
				dataTable.Rows.Add(dataRow2);
			}
			mySqlDataReader2.Close();
			dataTable.DefaultView.Sort = Class84.smethod_0(-994167329);
			DataTable dataTable2 = dataTable.DefaultView.ToTable();
			List<List<string>> list2 = new List<List<string>>();
			foreach (DataRow row in dataTable2.Rows)
			{
				List<string> item = new List<string>
				{
					row[Class84.smethod_0(-994166101)].ToString(),
					row[Class84.smethod_0(-994167380)].ToString(),
					row[Class84.smethod_0(-994247190)].ToString(),
					row[Class84.smethod_0(-994167329)].ToString(),
					row[Class84.smethod_0(-994277105)].ToString(),
					row[Class84.smethod_0(-994276441)].ToString()
				};
				list2.Add(item);
			}
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994170409));
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey).Replace(Class84.smethod_0(-994267367), string.Empty).Replace(Class84.smethod_0(-994267375), string.Empty)
				.Replace(Class84.smethod_0(-994293038), string.Empty);
			string text2 = Class320.smethod_3(jsRequest_0.UserRequest.RequestInfo, jsRequest_0.UserRequest.RequestInfoKey);
			List<List<string>> list = new List<List<string>>();
			int int_ = 0;
			double double_ = 0.0;
			int num = 1;
			int num2 = 1;
			int num3 = 1;
			int num4 = 1;
			int num5 = 0;
			string item = string.Empty;
			string item2 = string.Empty;
			string item3 = string.Empty;
			string commandText = Class84.smethod_0(-994170388) + text2;
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				int_ = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166231)]);
				double_ = Convert.ToDouble(mySqlDataReader[Class84.smethod_0(-994166182)]);
				Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166188)]);
				num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166207)]);
				num2 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166145)]);
				num3 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166163)]);
				num4 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166114)]);
				num5 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166131)]);
				item2 = mySqlDataReader[Class84.smethod_0(-994277142)].ToString();
				item = mySqlDataReader[Class84.smethod_0(-994268488)].ToString();
				item3 = mySqlDataReader[Class84.smethod_0(-994166083)].ToString();
			}
			mySqlDataReader.Close();
			commandText = Class84.smethod_0(-994170090) + text + Class84.smethod_0(-994169763) + text + Class84.smethod_0(-994271866);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader2 = mySqlCommand.ExecuteReader();
			while (mySqlDataReader2.Read())
			{
				int num6 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994264162)]);
				int num7 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994241099)]);
				int num8 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994241072)]);
				double num9 = Convert.ToDouble(mySqlDataReader2[Class84.smethod_0(-994241168)]);
				int num10 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994240936)]);
				string item4 = mySqlDataReader2[Class84.smethod_0(-994263532)].ToString();
				int num11 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994276441)]);
				string item5 = ((Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994166050)]) == 1) ? Class84.smethod_0(-994166020) : Class84.smethod_0(-994166066));
				string item6 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994166039)]) switch
				{
					2 => Class84.smethod_0(-994166005), 
					1 => Class84.smethod_0(-994165959), 
					0 => Class84.smethod_0(-994278690), 
					_ => Class84.smethod_0(-994165990), 
				};
				int num12 = ((Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994241172)]) != 0) ? 1 : 0);
				string item7 = mySqlDataReader2[Class84.smethod_0(-994165961)].ToString();
				string item8 = ((num11 == 1) ? Class84.smethod_0(-994240783) : num9.ToString());
				string item9 = smethod_6(num9, double_, num11);
				string item10 = smethod_7(num11, 0, 0);
				string item11 = ColorTranslator.ToHtml(new GClass26(0, int_, -99).method_2(Convert.ToInt32(num9)));
				string item12 = JsonConvert.SerializeObject(new List<string>
				{
					item,
					item2,
					item4,
					item8,
					item11,
					num6.ToString(),
					num11.ToString(),
					num12.ToString(),
					num.ToString(),
					num2.ToString(),
					num3.ToString(),
					num4.ToString(),
					num5.ToString(),
					item7,
					item3
				});
				List<string> item13 = new List<string>
				{
					num6.ToString(),
					num7.ToString(),
					num8.ToString(),
					item8,
					item11,
					num10.ToString(),
					item4,
					item9,
					item10,
					item5,
					item6,
					item12
				};
				list.Add(item13);
			}
			mySqlDataReader2.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994169754));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994169724));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_10(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
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
			List<List<string>> list = new List<List<string>>();
			int int_ = 0;
			double double_ = 0.0;
			int num = 0;
			int num2 = 1;
			int num3 = 1;
			int num4 = 1;
			int num5 = 1;
			int num6 = 0;
			string item = string.Empty;
			string item2 = string.Empty;
			string item3 = string.Empty;
			string commandText = Class84.smethod_0(-994170388) + text;
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				int_ = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166231)]);
				double_ = Convert.ToDouble(mySqlDataReader[Class84.smethod_0(-994166182)]);
				num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166188)]);
				num2 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166207)]);
				num3 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166145)]);
				num4 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166163)]);
				num5 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166114)]);
				num6 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994166131)]);
				item2 = mySqlDataReader[Class84.smethod_0(-994277142)].ToString();
				item = mySqlDataReader[Class84.smethod_0(-994268488)].ToString();
				item3 = mySqlDataReader[Class84.smethod_0(-994166083)].ToString();
			}
			mySqlDataReader.Close();
			commandText = Class84.smethod_0(-994169639) + text + Class84.smethod_0(-994169099);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader2 = mySqlCommand.ExecuteReader();
			while (mySqlDataReader2.Read())
			{
				int num7 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994264162)]);
				int num8 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994167380)]);
				string item4 = num8 switch
				{
					2 => mySqlDataReader2[Class84.smethod_0(-994277136)].ToString(), 
					1 => mySqlDataReader2[Class84.smethod_0(-994266832)].ToString(), 
					_ => mySqlDataReader2[Class84.smethod_0(-994270443)].ToString(), 
				};
				string item5 = num8 switch
				{
					2 => mySqlDataReader2[Class84.smethod_0(-994257743)].ToString(), 
					1 => mySqlDataReader2[Class84.smethod_0(-994257747)].ToString(), 
					_ => mySqlDataReader2[Class84.smethod_0(-994166809)].ToString(), 
				};
				string item6 = num8 switch
				{
					2 => mySqlDataReader2[Class84.smethod_0(-994277105)].ToString(), 
					1 => Class84.smethod_0(-994278690), 
					_ => mySqlDataReader2[Class84.smethod_0(-994268131)].ToString(), 
				};
				int num9 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994241099)]);
				int num10 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994241072)]);
				double num11 = Convert.ToDouble(mySqlDataReader2[Class84.smethod_0(-994241168)]);
				int num12 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994240936)]);
				string item7 = mySqlDataReader2[Class84.smethod_0(-994263532)].ToString();
				int num13 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994276441)]);
				string item8 = ((Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994166050)]) == 1) ? Class84.smethod_0(-994166020) : Class84.smethod_0(-994166066));
				string item9 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994166039)]) switch
				{
					2 => Class84.smethod_0(-994166005), 
					1 => Class84.smethod_0(-994165959), 
					0 => Class84.smethod_0(-994278690), 
					_ => Class84.smethod_0(-994165990), 
				};
				int num14 = ((Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994241172)]) != 0) ? 1 : 0);
				string item10 = mySqlDataReader2[Class84.smethod_0(-994165961)].ToString();
				string item11 = ((num13 == 1) ? Class84.smethod_0(-994240783) : num11.ToString());
				string item12 = smethod_6(num11, double_, num13);
				string item13 = smethod_7(num13, 0, 0);
				string item14 = ColorTranslator.ToHtml(new GClass26(0, int_, -99).method_2(Convert.ToInt32(num11)));
				string item15 = JsonConvert.SerializeObject(new List<string>
				{
					item,
					item2,
					item7,
					item11,
					item14,
					num7.ToString(),
					num13.ToString(),
					num14.ToString(),
					num2.ToString(),
					num3.ToString(),
					num4.ToString(),
					num5.ToString(),
					num6.ToString(),
					item10,
					item3
				});
				List<string> item16 = new List<string>
				{
					num7.ToString(),
					num8.ToString(),
					item4,
					item5,
					item6,
					num9.ToString(),
					num10.ToString(),
					item11,
					item14,
					num12.ToString(),
					item7,
					item12,
					item13,
					item8,
					item9,
					item15
				};
				list.Add(item16);
			}
			mySqlDataReader2.Close();
			commandText = string.Format(Class84.smethod_0(-994169009), text, num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader2 = mySqlCommand.ExecuteReader();
			while (mySqlDataReader2.Read())
			{
				int num15 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994264162)]);
				int num16 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994167380)]);
				string item17 = num16 switch
				{
					2 => mySqlDataReader2[Class84.smethod_0(-994277136)].ToString(), 
					1 => mySqlDataReader2[Class84.smethod_0(-994266832)].ToString(), 
					_ => mySqlDataReader2[Class84.smethod_0(-994270443)].ToString(), 
				};
				string item18 = num16 switch
				{
					2 => mySqlDataReader2[Class84.smethod_0(-994257743)].ToString(), 
					1 => mySqlDataReader2[Class84.smethod_0(-994257747)].ToString(), 
					_ => mySqlDataReader2[Class84.smethod_0(-994166809)].ToString(), 
				};
				string item19 = num16 switch
				{
					2 => mySqlDataReader2[Class84.smethod_0(-994277105)].ToString(), 
					1 => Class84.smethod_0(-994278690), 
					_ => mySqlDataReader2[Class84.smethod_0(-994268131)].ToString(), 
				};
				int num17 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994241099)]);
				int num18 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994241072)]);
				double num19 = Convert.ToDouble(mySqlDataReader2[Class84.smethod_0(-994241168)]);
				int num20 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994240936)]);
				string item20 = mySqlDataReader2[Class84.smethod_0(-994263532)].ToString();
				int num21 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994276441)]);
				string item21 = ((Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994166050)]) == 1) ? Class84.smethod_0(-994166020) : Class84.smethod_0(-994166066));
				string item22 = Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994166039)]) switch
				{
					2 => Class84.smethod_0(-994166005), 
					1 => Class84.smethod_0(-994165959), 
					0 => Class84.smethod_0(-994278690), 
					_ => Class84.smethod_0(-994165990), 
				};
				int num22 = ((Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994241172)]) != 0) ? 1 : 0);
				string item23 = mySqlDataReader2[Class84.smethod_0(-994165961)].ToString();
				string item24 = ((num21 == 1) ? Class84.smethod_0(-994240783) : num19.ToString());
				string item25 = smethod_6(num19, double_, num21);
				string item26 = smethod_7(num21, 0, 1);
				string item27 = ColorTranslator.ToHtml(new GClass26(0, int_, -99).method_2(Convert.ToInt32(num19)));
				string item28 = JsonConvert.SerializeObject(new List<string>
				{
					item,
					item2,
					item20,
					item24,
					item27,
					num15.ToString(),
					num21.ToString(),
					num22.ToString(),
					num2.ToString(),
					num3.ToString(),
					num4.ToString(),
					num5.ToString(),
					num6.ToString(),
					item23,
					item3
				});
				List<string> item29 = new List<string>
				{
					num15.ToString(),
					num16.ToString(),
					item17,
					item18,
					item19,
					num17.ToString(),
					num18.ToString(),
					item24,
					item27,
					num20.ToString(),
					item20,
					item25,
					item26,
					item21,
					item22,
					item28
				};
				list.Add(item29);
			}
			mySqlDataReader2.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994169754));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994169724));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_11(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994172470) + text, mySqlConnection).ExecuteReader();
			List<List<string>> list = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994228614)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994276368)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994215633)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994215791)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994215795)].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994172269));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994238596));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_12(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994172233) + text + Class84.smethod_0(-994172023), mySqlConnection).ExecuteReader();
			List<List<string>> list = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994264162)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994268488)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188553)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994166188)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994167489)].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994171927));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994171896));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_13(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string cmdText = Class84.smethod_0(-994171858) + text2 + Class84.smethod_0(-994171496) + text + Class84.smethod_0(-994171486);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(new MySqlCommand(cmdText, mySqlConnection));
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			List<List<string>> list2 = new List<List<string>>();
			foreach (DataRow row in dataTable.Rows)
			{
				string text3 = row[Class84.smethod_0(-994264162)].ToString();
				string text4 = row[Class84.smethod_0(-994171328)].ToString();
				string text5 = row[Class84.smethod_0(-994171280)].ToString();
				string item = Class84.smethod_0(-994171296);
				if (!text4.Equals(string.Empty))
				{
					item = text4 + Class84.smethod_0(-994273716) + text5;
				}
				string text6 = row[Class84.smethod_0(-994268429)].ToString();
				string item2 = string.Empty;
				if (text6.Equals(Class84.smethod_0(-994274584)))
				{
					item2 = Class84.smethod_0(-994171264) + row[Class84.smethod_0(-994273283)];
				}
				else if (text6.Equals(Class84.smethod_0(-994248276)))
				{
					string text7 = row[Class84.smethod_0(-994268361)].ToString();
					cmdText = Class84.smethod_0(-994258923) + text7;
					string text8 = Class280.smethod_4(mySqlConnection, cmdText).ToString();
					item2 = Class84.smethod_0(-994171210) + text8;
				}
				else if (text6.Equals(Class84.smethod_0(-994248284)))
				{
					string text9 = string.Empty;
					cmdText = Class84.smethod_0(-994171174);
					cmdText = string.Format(cmdText, text3);
					foreach (DataRow row2 in Class280.smethod_6(mySqlConnection, cmdText).Rows)
					{
						string text10 = row2[0].ToString();
						if (text9 != string.Empty)
						{
							text9 += Class84.smethod_0(-994279022);
						}
						text9 += text10;
					}
					item2 = Class84.smethod_0(-994171036) + text9 + Class84.smethod_0(-994271866);
				}
				else if (text6.Equals(Class84.smethod_0(-994248228)))
				{
					string text11 = string.Empty;
					cmdText = Class84.smethod_0(-994170986);
					cmdText = string.Format(cmdText, text3);
					foreach (DataRow row3 in Class280.smethod_6(mySqlConnection, cmdText).Rows)
					{
						string text12 = row3[0].ToString();
						if (text11 != string.Empty)
						{
							text11 += Class84.smethod_0(-994279022);
						}
						text11 += text12;
					}
					item2 = Class84.smethod_0(-994158511) + text11 + Class84.smethod_0(-994271866);
				}
				cmdText = Class84.smethod_0(-994158522);
				cmdText = string.Format(cmdText, text3);
				string item3 = Class280.smethod_4(mySqlConnection, cmdText).ToString();
				List<string> item4 = new List<string>
				{
					text3,
					row[Class84.smethod_0(-994277142)].ToString(),
					item2,
					item,
					item3,
					row[Class84.smethod_0(-994187668)].ToString(),
					row[Class84.smethod_0(-994268492)].ToString()
				};
				list2.Add(item4);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994158367));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994158332));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_14(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			List<List<string>> list2 = new List<List<string>>();
			List<List<string>> list3 = new List<List<string>>();
			HashSet<string> hashSet = new HashSet<string>();
			string text3 = Class84.smethod_0(-994158242) + text + Class84.smethod_0(-994271698);
			if (!text2.Equals(Class84.smethod_0(-994239381)))
			{
				text3 = text3 + Class84.smethod_0(-994157991) + text2 + Class84.smethod_0(-994271698);
			}
			text3 += Class84.smethod_0(-994158014);
			MySqlDataReader mySqlDataReader = new MySqlCommand(text3, mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				string item = mySqlDataReader[Class84.smethod_0(-994247190)].ToString();
				if (!hashSet.Contains(item))
				{
					list2.Add(new List<string>
					{
						mySqlDataReader[Class84.smethod_0(-994247190)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994224846)].ToString()
					});
					hashSet.Add(item);
				}
				List<string> item2 = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994247190)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188054)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224892)].ToString()
				};
				list3.Add(item2);
			}
			mySqlDataReader.Close();
			List<string> value = new List<string>
			{
				JsonConvert.SerializeObject(list2),
				JsonConvert.SerializeObject(list3)
			};
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(value));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994157878));
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
