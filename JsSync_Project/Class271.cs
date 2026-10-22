using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class271
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 132)
			{
				gClass = smethod_5(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 133)
			{
				gClass = smethod_4(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 134)
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
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994244439));
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
			MySqlDataAdapter mySqlDataAdapter_ = new MySqlDataAdapter
			{
				SelectCommand = mySqlCommand
			};
			List<Tuple<int, int, string>> list = new List<Tuple<int, int, string>>();
			mySqlCommand.CommandText = Class84.smethod_0(-994244404);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				list.Add(new Tuple<int, int, string>(0, Convert.ToInt32(mySqlDataReader[0]), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			if (list.Count == 0)
			{
				return new GClass70(1, Class84.smethod_0(-994244303), Class84.smethod_0(-994299845));
			}
			int item = list[0].Item2;
			smethod_2(mySqlDataAdapter_, 1, item, list);
			StringBuilder stringBuilder = new StringBuilder(Class84.smethod_0(-994244307));
			stringBuilder.AppendLine();
			foreach (Tuple<int, int, string> item5 in list)
			{
				int item2 = item5.Item1;
				int item3 = item5.Item2;
				string item4 = item5.Item3;
				string text = string.Empty;
				for (int i = 0; i < item2; i++)
				{
					text += Class84.smethod_0(-994244213);
				}
				text += Class84.smethod_0(-994244172);
				string text2 = smethod_3(mySqlCommand, item3);
				stringBuilder.AppendLine(Class84.smethod_0(-994244185) + text + Class84.smethod_0(-994244095) + item4 + Class84.smethod_0(-994244006) + text2 + Class84.smethod_0(-994244023));
			}
			stringBuilder.AppendLine(Class84.smethod_0(-994243978));
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994243995));
			return new GClass70(1, Class84.smethod_0(-994247224), stringBuilder.ToString());
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994243962));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static void smethod_2(MySqlDataAdapter mySqlDataAdapter_0, int int_0, int int_1, List<Tuple<int, int, string>> list_0)
	{
		DataTable dataTable = new DataTable();
		string commandText = Class84.smethod_0(-994243874) + int_1;
		mySqlDataAdapter_0.SelectCommand.CommandText = commandText;
		mySqlDataAdapter_0.Fill(dataTable);
		foreach (DataRow row in dataTable.Rows)
		{
			int num = Convert.ToInt32(row[0]);
			string item = row[1].ToString();
			list_0.Add(new Tuple<int, int, string>(int_0, num, item));
			smethod_2(mySqlDataAdapter_0, int_0 + 1, num, list_0);
		}
	}

	private static string smethod_3(MySqlCommand mySqlCommand_0, int int_0)
	{
		string text = string.Empty;
		mySqlCommand_0.CommandText = string.Format(Class84.smethod_0(-994243809), int_0);
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		while (mySqlDataReader.Read())
		{
			if (!text.Equals(string.Empty))
			{
				text += Class84.smethod_0(-994271851);
			}
			text += mySqlDataReader[0].ToString();
		}
		mySqlDataReader.Close();
		return text;
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
			string arg = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string format = Class84.smethod_0(-994243673);
			mySqlCommand.CommandText = string.Format(format, arg);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			List<Tuple<string, string>> list = new List<Tuple<string, string>>();
			while (mySqlDataReader.Read())
			{
				list.Add(new Tuple<string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			if (list.Count == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994244303), Class84.smethod_0(-994299845));
			}
			StringBuilder stringBuilder = new StringBuilder(Class84.smethod_0(-994244307));
			stringBuilder.AppendLine();
			format = Class84.smethod_0(-994243484);
			for (int i = 0; i < list.Count; i++)
			{
				string item = list[i].Item1;
				string item2 = list[i].Item2;
				stringBuilder.AppendLine(Class84.smethod_0(-994243281) + item2 + Class84.smethod_0(-994243206));
				int num = 1;
				mySqlCommand.CommandText = string.Format(format, item);
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					string text = mySqlDataReader[0].ToString();
					string text2 = string.Empty;
					if (!Convert.IsDBNull(mySqlDataReader[1]))
					{
						byte[] array = (byte[])mySqlDataReader[1];
						if (array != null)
						{
							string text3 = GClass18.smethod_18(GClass18.smethod_24(array));
							text2 = Class84.smethod_0(-994243217) + text3 + Class84.smethod_0(-994243149);
						}
					}
					else
					{
						text2 = Class84.smethod_0(-994243217) + Class309.smethod_46() + Class84.smethod_0(-994243149);
					}
					if (num == 1)
					{
						stringBuilder.AppendLine(Class84.smethod_0(-994243111) + text2 + Class84.smethod_0(-994243044) + text + Class84.smethod_0(-994243049));
						num = 2;
					}
					else
					{
						stringBuilder.AppendLine(Class84.smethod_0(-994243069) + text2 + Class84.smethod_0(-994243044) + text + Class84.smethod_0(-994242983));
						num = 1;
					}
				}
				mySqlDataReader.Close();
				if (num == 2)
				{
					stringBuilder.AppendLine(Class84.smethod_0(-994242998));
				}
			}
			stringBuilder.AppendLine(Class84.smethod_0(-994243978));
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994242928));
			return new GClass70(1, Class84.smethod_0(-994247224), stringBuilder.ToString());
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994242884));
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
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = Class84.smethod_0(-994299031)
			}.ExecuteReader();
			List<List<string>> list = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[0].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			string object_ = JsonConvert.SerializeObject(list);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994242849));
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
