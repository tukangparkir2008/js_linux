using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class310
{
	private sealed class Class311
	{
		public int int_0;

		public string string_0;

		public int int_1;

		public string string_1;

		public int int_2;

		public string string_2;

		public int int_3;

		public string string_3;

		public string string_4;

		public int int_4;
	}

	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 115)
			{
				gClass = smethod_11(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 116)
			{
				gClass = smethod_9(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 117)
			{
				gClass = smethod_8(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 118)
			{
				gClass = smethod_7(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 119)
			{
				gClass = smethod_6(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 120)
			{
				gClass = smethod_5(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 121)
			{
				gClass = smethod_4(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 122)
			{
				gClass = smethod_2(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 123)
			{
				gClass = smethod_3(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 124)
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
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994183935));
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
			string arg = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string format = Class84.smethod_0(-994183898);
			mySqlCommand.CommandText = string.Format(format, arg);
			int num = 0;
			List<List<string>> list = new List<List<string>>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[0]);
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			List<List<string>> list2 = new List<List<string>>();
			format = Class84.smethod_0(-994183679);
			mySqlCommand.CommandText = string.Format(format, num);
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				string string_ = mySqlDataReader[3].ToString();
				string_ = Class282.smethod_3(string_);
				string_ = Class282.smethod_2(string_);
				List<string> item2 = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString(),
					string_
				};
				list2.Add(item2);
			}
			mySqlDataReader.Close();
			string item3 = JsonConvert.SerializeObject(list);
			string item4 = JsonConvert.SerializeObject(list2);
			List<string> value = new List<string> { item3, item4 };
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994183445));
			string object_ = JsonConvert.SerializeObject(value);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994183411));
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
			string arg = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = string.Format(Class84.smethod_0(-994183386), arg)
			};
			List<List<string>> list = new List<List<string>>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			string object_ = JsonConvert.SerializeObject(list);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994187264));
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string arg = list[0];
			string text = list[1];
			string text2 = list[2];
			string format = Class84.smethod_0(-994187227);
			mySqlCommand.CommandText = string.Format(format, arg);
			List<List<string>> list2 = new List<List<string>>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			List<List<string>> list3 = new List<List<string>>();
			for (int i = 0; i < list2.Count; i++)
			{
				List<string> list4 = new List<string>();
				for (int j = 0; j < 7; j++)
				{
					list4.Add(Class84.smethod_0(-994278690));
				}
				list3.Add(list4);
			}
			format = Class84.smethod_0(-994187015);
			for (int k = 1; k <= list2.Count; k++)
			{
				for (int l = 1; l <= 7; l++)
				{
					mySqlCommand.CommandText = string.Format(format, text2, text, k, l);
					mySqlDataReader = mySqlCommand.ExecuteReader();
					if (mySqlDataReader.Read())
					{
						int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994186671)]);
						mySqlDataReader[Class84.smethod_0(-994186676)].ToString();
						string text3 = mySqlDataReader[Class84.smethod_0(-994186682)].ToString();
						string text4 = mySqlDataReader[Class84.smethod_0(-994186634)].ToString();
						string text5 = mySqlDataReader[Class84.smethod_0(-994276441)].ToString();
						for (int m = 0; m < num; m++)
						{
							list3[k - 1 + m][l - 1] = text3 + Class84.smethod_0(-994263511) + text4 + Class84.smethod_0(-994263511) + text5;
						}
					}
					mySqlDataReader.Close();
				}
			}
			string item2 = JsonConvert.SerializeObject(list2);
			string item3 = JsonConvert.SerializeObject(list3);
			string object_ = JsonConvert.SerializeObject(new List<string> { item2, item3 });
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994186655));
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994186610));
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
			string text = list[0];
			string text2 = list[1];
			string format = Class84.smethod_0(-994186590);
			mySqlCommand.CommandText = string.Format(format, string_, text2, text);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			List<List<string>> list2 = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			format = Class84.smethod_0(-994186334);
			mySqlCommand.CommandText = string.Format(format, text2, text, string_);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			List<List<string>> list3 = new List<List<string>>();
			foreach (DataRow row in dataTable.Rows)
			{
				List<string> list4 = new List<string>();
				string text3 = row[0].ToString();
				string item2 = row[1].ToString();
				row[2].ToString();
				row[3].ToString();
				list4.Add(item2);
				for (int i = 0; i < list2.Count; i++)
				{
					string text4 = list2[i][0];
					string item3 = Class84.smethod_0(-994278690);
					format = Class84.smethod_0(-994186009);
					mySqlCommand.CommandText = string.Format(format, string_, text3, text2, text, text4);
					mySqlDataReader = mySqlCommand.ExecuteReader();
					if (mySqlDataReader.Read())
					{
						item3 = mySqlDataReader[0].ToString();
						item3 = Class282.smethod_3(item3);
						item3 = Class282.smethod_2(item3);
					}
					mySqlDataReader.Close();
					list4.Add(item3);
				}
				list3.Add(list4);
			}
			string item4 = JsonConvert.SerializeObject(list2);
			string item5 = JsonConvert.SerializeObject(list3);
			string object_ = JsonConvert.SerializeObject(new List<string> { item4, item5 });
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994185697));
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994185697));
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string format = Class84.smethod_0(-994186590);
			mySqlCommand.CommandText = string.Format(format, string_, text2, text);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			List<List<string>> list2 = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			format = Class84.smethod_0(-994186334);
			mySqlCommand.CommandText = string.Format(format, text2, text, string_);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			List<List<string>> list3 = new List<List<string>>();
			foreach (DataRow row in dataTable.Rows)
			{
				List<string> list4 = new List<string>();
				string text3 = row[0].ToString();
				string item2 = row[1].ToString();
				row[2].ToString();
				string item3 = row[3].ToString();
				string item4 = Class84.smethod_0(-994274584);
				format = Class84.smethod_0(-994185685);
				mySqlCommand.CommandText = string.Format(format, text3, text2, text);
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					item4 = mySqlDataReader[0].ToString();
				}
				mySqlDataReader.Close();
				list4.Add(item3);
				list4.Add(item2);
				list4.Add(item4);
				for (int i = 0; i < list2.Count; i++)
				{
					string text4 = list2[i][0];
					string item5 = Class84.smethod_0(-994278690);
					string item6 = Class84.smethod_0(-994278690);
					format = Class84.smethod_0(-994185479);
					mySqlCommand.CommandText = string.Format(format, string_, text3, text2, text, text4);
					mySqlDataReader = mySqlCommand.ExecuteReader();
					if (mySqlDataReader.Read())
					{
						item5 = mySqlDataReader[0].ToString();
						item6 = mySqlDataReader[1].ToString();
					}
					mySqlDataReader.Close();
					list4.Add(item5);
					list4.Add(item6);
				}
				list3.Add(list4);
			}
			string item7 = JsonConvert.SerializeObject(list2);
			string item8 = JsonConvert.SerializeObject(list3);
			string object_ = JsonConvert.SerializeObject(new List<string> { item7, item8 });
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994185241));
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994189264));
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string format = Class84.smethod_0(-994189248);
			mySqlCommand.CommandText = string.Format(format, text2);
			List<Tuple<string, string>> list2 = new List<Tuple<string, string>>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list2.Add(new Tuple<string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			List<List<string>> list3 = new List<List<string>>();
			foreach (Tuple<string, string> item6 in list2)
			{
				string item = item6.Item1;
				string item2 = item6.Item2;
				format = Class84.smethod_0(-994188997);
				mySqlCommand.CommandText = string.Format(format, text, text2, text3, item, string_);
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
				mySqlDataAdapter.SelectCommand = mySqlCommand;
				DataTable dataTable = new DataTable();
				mySqlDataAdapter.Fill(dataTable);
				foreach (DataRow row in dataTable.Rows)
				{
					double num = Convert.ToDouble(row[Class84.smethod_0(-994188612)]);
					double num2 = Convert.ToDouble(row[Class84.smethod_0(-994188627)]);
					double num3 = (num - num2) / num2;
					num3 = Math.Round(100.0 * num3, 2);
					string item3 = ((num3 >= 0.0) ? Class84.smethod_0(-994188587) : Class84.smethod_0(-994188581));
					string item4 = ((num3 >= 0.0) ? Class84.smethod_0(-994188608) : string.Empty) + num3 + Class84.smethod_0(-994264352);
					List<string> item5 = new List<string>
					{
						item2,
						row[Class84.smethod_0(-994188552)].ToString(),
						row[Class84.smethod_0(-994188612)].ToString(),
						row[Class84.smethod_0(-994188627)].ToString(),
						item4,
						item3,
						row[Class84.smethod_0(-994188553)].ToString()
					};
					list3.Add(item5);
				}
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994188520));
			string object_ = JsonConvert.SerializeObject(list3);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994188481));
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			mySqlCommand.CommandText = string.Format(arg0: text.Replace(Class84.smethod_0(-994271698), Class84.smethod_0(-994188467)), format: Class84.smethod_0(-994188474));
			List<List<string>> list = new List<List<string>>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			string object_ = JsonConvert.SerializeObject(list);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994188299));
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
			string arg = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994188280), arg, string_);
			List<List<string>> list = new List<List<string>>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994188054)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			string object_ = JsonConvert.SerializeObject(list);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994188004));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
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
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994187978), string_);
			List<List<string>> list = new List<List<string>>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994277103)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277105)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994268361)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994264701)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994187656)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994187668)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994187618)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994273283)].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			string object_ = JsonConvert.SerializeObject(list);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994187636));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static Class311 smethod_10(MySqlCommand mySqlCommand_0, string string_0)
	{
		Class311 @class = null;
		string format = Class84.smethod_0(-994187603);
		mySqlCommand_0.CommandText = string.Format(format, string_0);
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			@class = new Class311();
			@class.int_4 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994277147)]);
			@class.int_0 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994277103)]);
			@class.string_0 = mySqlDataReader[Class84.smethod_0(-994277105)].ToString();
			@class.int_1 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994268361)]);
			@class.string_1 = mySqlDataReader[Class84.smethod_0(-994264701)].ToString();
			@class.int_3 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994187348)]);
			@class.string_3 = mySqlDataReader[Class84.smethod_0(-994187299)].ToString();
			@class.string_4 = mySqlDataReader[Class84.smethod_0(-994273283)].ToString();
		}
		mySqlDataReader.Close();
		if (@class != null)
		{
			string arg = @class.string_4.Replace(Class84.smethod_0(-994271698), Class84.smethod_0(-994188467));
			format = Class84.smethod_0(-994187316);
			mySqlCommand_0.CommandText = string.Format(format, arg);
			mySqlDataReader = mySqlCommand_0.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				@class.int_2 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994240446)]);
				@class.string_2 = mySqlDataReader[Class84.smethod_0(-994240385)].ToString();
			}
			mySqlDataReader.Close();
		}
		return @class;
	}

	private static GClass70 smethod_11(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
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
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994240402), string_, arg);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			List<List<string>> list = new List<List<string>>();
			foreach (DataRow row in dataTable.Rows)
			{
				double num = Convert.ToDouble(row[Class84.smethod_0(-994188612)]);
				double num2 = Convert.ToDouble(row[Class84.smethod_0(-994188627)]);
				double num3 = (num - num2) / num2;
				num3 = Math.Round(100.0 * num3, 2);
				string item = ((num3 >= 0.0) ? Class84.smethod_0(-994188587) : Class84.smethod_0(-994188581));
				string item2 = ((num3 >= 0.0) ? Class84.smethod_0(-994188608) : string.Empty) + num3 + Class84.smethod_0(-994264352);
				List<string> item3 = new List<string>
				{
					row[Class84.smethod_0(-994239992)].ToString(),
					row[Class84.smethod_0(-994186682)].ToString(),
					row[Class84.smethod_0(-994239993)].ToString(),
					row[Class84.smethod_0(-994188612)].ToString(),
					row[Class84.smethod_0(-994188627)].ToString(),
					item2,
					item
				};
				list.Add(item3);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994239960));
			string object_ = JsonConvert.SerializeObject(list);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994239880));
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
