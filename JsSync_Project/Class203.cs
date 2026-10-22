using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class203
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 2260)
			{
				gClass = smethod_3(gclass4_0, gclass41_0, jsRequest_0);
			}
			if (jsRequest_0.UserRequest.Protocol == 2266)
			{
				gClass = smethod_2(gclass4_0, gclass41_0, jsRequest_0);
			}
			if (jsRequest_0.UserRequest.Protocol == 2301)
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
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994131758));
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
			List<List<string>> list2 = new List<List<string>>();
			string text5 = Class84.smethod_0(-994176442) + text + Class84.smethod_0(-994176204) + text2 + Class84.smethod_0(-994224932) + text3 + Class84.smethod_0(-994176140);
			if (!text4.Equals(Class84.smethod_0(-994239381)))
			{
				text5 = text5 + Class84.smethod_0(-994176074) + text4 + Class84.smethod_0(-994118982);
			}
			text5 += Class84.smethod_0(-994176035);
			MySqlDataReader mySqlDataReader = new MySqlCommand(text5, mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994247190)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994214738)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994297386)].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994175997));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994175958));
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
			string value = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestInfo, jsRequest_0.UserRequest.RequestInfoKey);
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(value);
			string text2 = list[0];
			string text3 = list[1];
			string text4 = list[2];
			string text5 = list[3];
			string text6 = list[4];
			List<List<string>> list2 = new List<List<string>>();
			string empty = string.Empty;
			empty = (text3.Equals(Class84.smethod_0(-994278690)) ? Class84.smethod_0(-994175675) : (Class84.smethod_0(-994175928) + text3 + Class84.smethod_0(-994271698)));
			empty = empty + Class84.smethod_0(-994175334) + text2 + Class84.smethod_0(-994175354) + text4 + Class84.smethod_0(-994224932) + text5 + Class84.smethod_0(-994271698);
			if (!text6.Equals(Class84.smethod_0(-994278690)))
			{
				empty = empty + Class84.smethod_0(-994175294) + text6 + Class84.smethod_0(-994271698);
			}
			if (text.Equals(Class84.smethod_0(-994175252)))
			{
				empty += Class84.smethod_0(-994175204);
			}
			empty += Class84.smethod_0(-994175173);
			MySqlDataReader mySqlDataReader = new MySqlCommand(empty, mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994268492)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994175195)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994214738)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994122981)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994175150)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994175153)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994175108)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994221697)].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994175127));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994175086));
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
			string string_ = list[0];
			string text = list[1];
			string string_2 = list[2];
			string string_3 = list[3];
			HashSet<int> hashSet = new HashSet<int>();
			if (text.Equals(Class84.smethod_0(-994248828)))
			{
				smethod_7(mySqlCommand, hashSet, string_, string_2, string_3);
				smethod_8(mySqlCommand, hashSet, string_, string_2, string_3);
			}
			else if (text.Equals(Class84.smethod_0(-994175054)))
			{
				smethod_7(mySqlCommand, hashSet, string_, string_2, string_3);
			}
			else if (text.Equals(Class84.smethod_0(-994175061)))
			{
				smethod_8(mySqlCommand, hashSet, string_, string_2, string_3);
			}
			if (hashSet.Count == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994175067), string.Empty);
			}
			string text2 = string.Empty;
			foreach (int item7 in hashSet)
			{
				if (!text2.Equals(string.Empty))
				{
					text2 += Class84.smethod_0(-994279022);
				}
				text2 += item7;
			}
			List<List<string>> list2 = new List<List<string>>();
			string commandText = Class84.smethod_0(-994175040) + text2 + Class84.smethod_0(-994178852);
			mySqlCommand.CommandText = commandText;
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			foreach (DataRow row in dataTable.Rows)
			{
				string text3 = row[Class84.smethod_0(-994178786)].ToString();
				string text4 = row[Class84.smethod_0(-994178804)].ToString();
				string item = (text4.Equals(Class84.smethod_0(-994175054)) ? Class84.smethod_0(-994178773) : Class84.smethod_0(-994178755));
				string item2 = (text4.Equals(Class84.smethod_0(-994175054)) ? Class84.smethod_0(-994178740) : Class84.smethod_0(-994178727));
				string empty = string.Empty;
				empty = Convert.ToInt32(row[Class84.smethod_0(-994123023)]) switch
				{
					1 => Class84.smethod_0(-994178690), 
					2 => Class84.smethod_0(-994178717), 
					_ => Class84.smethod_0(-994178671), 
				};
				string item3 = smethod_4(mySqlCommand, text3, text4);
				string item4 = smethod_5(mySqlCommand, text3, text4);
				string item5 = smethod_6(mySqlCommand, text3);
				List<string> item6 = new List<string>
				{
					text3,
					row[Class84.smethod_0(-994178675)].ToString(),
					row[Class84.smethod_0(-994201454)].ToString(),
					item2,
					row[Class84.smethod_0(-994178640)].ToString(),
					row[Class84.smethod_0(-994214738)].ToString(),
					empty,
					item5,
					item3,
					item4,
					item
				};
				list2.Add(item6);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994178642));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994178610));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static string smethod_4(MySqlCommand mySqlCommand_0, string string_0, string string_1)
	{
		string text = string.Empty;
		if (string_1.Equals(Class84.smethod_0(-994175054)))
		{
			string commandText = Class84.smethod_0(-994178587) + string_0;
			mySqlCommand_0.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				text = mySqlDataReader[0].ToString();
			}
			mySqlDataReader.Close();
		}
		else
		{
			string commandText2 = Class84.smethod_0(-994178426) + string_0 + Class84.smethod_0(-994178228) + string_0 + Class84.smethod_0(-994178017);
			mySqlCommand_0.CommandText = commandText2;
			MySqlDataReader mySqlDataReader2 = mySqlCommand_0.ExecuteReader();
			while (mySqlDataReader2.Read())
			{
				if (!text.Equals(string.Empty))
				{
					text += Class84.smethod_0(-994271851);
				}
				text += mySqlDataReader2[0].ToString();
			}
			mySqlDataReader2.Close();
			commandText2 = Class84.smethod_0(-994177976) + string_0 + Class84.smethod_0(-994177810);
			mySqlCommand_0.CommandText = commandText2;
			mySqlDataReader2 = mySqlCommand_0.ExecuteReader();
			while (mySqlDataReader2.Read())
			{
				if (!text.Equals(string.Empty))
				{
					text += Class84.smethod_0(-994271851);
				}
				text += mySqlDataReader2[0].ToString();
			}
			mySqlDataReader2.Close();
		}
		return text;
	}

	private static string smethod_5(MySqlCommand mySqlCommand_0, string string_0, string string_1)
	{
		string text = string.Empty;
		if (string_1.Equals(Class84.smethod_0(-994175054)))
		{
			string commandText = Class84.smethod_0(-994177740) + string_0 + Class84.smethod_0(-994177551) + string_0 + Class84.smethod_0(-994177349);
			mySqlCommand_0.CommandText = commandText;
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
			commandText = Class84.smethod_0(-994177293) + string_0 + Class84.smethod_0(-994177810);
			mySqlCommand_0.CommandText = commandText;
			mySqlDataReader = mySqlCommand_0.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				if (!text.Equals(string.Empty))
				{
					text += Class84.smethod_0(-994271851);
				}
				text += mySqlDataReader[0].ToString();
			}
			mySqlDataReader.Close();
		}
		else
		{
			string commandText2 = Class84.smethod_0(-994177133) + string_0 + Class84.smethod_0(-994181038) + string_0 + Class84.smethod_0(-994180891) + string_0 + Class84.smethod_0(-994180696) + string_0 + Class84.smethod_0(-994180483);
			mySqlCommand_0.CommandText = commandText2;
			MySqlDataReader mySqlDataReader2 = mySqlCommand_0.ExecuteReader();
			while (mySqlDataReader2.Read())
			{
				if (!text.Equals(string.Empty))
				{
					text += Class84.smethod_0(-994271851);
				}
				text += mySqlDataReader2[0].ToString();
			}
			mySqlDataReader2.Close();
		}
		return text;
	}

	private static string smethod_6(MySqlCommand mySqlCommand_0, string string_0)
	{
		string commandText = Class84.smethod_0(-994180425) + string_0;
		mySqlCommand_0.CommandText = commandText;
		return mySqlCommand_0.ExecuteScalar().ToString();
	}

	private static void smethod_7(MySqlCommand mySqlCommand_0, HashSet<int> hashSet_0, string string_0, string string_1, string string_2)
	{
		string commandText = Class84.smethod_0(-994180299) + string_0 + Class84.smethod_0(-994180143) + string_1 + Class84.smethod_0(-994224932) + string_2 + Class84.smethod_0(-994180066);
		mySqlCommand_0.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		while (mySqlDataReader.Read())
		{
			int item = Convert.ToInt32(mySqlDataReader[0]);
			if (!hashSet_0.Contains(item))
			{
				hashSet_0.Add(item);
			}
		}
		mySqlDataReader.Close();
		commandText = Class84.smethod_0(-994180004) + string_0 + Class84.smethod_0(-994179904) + string_1 + Class84.smethod_0(-994224932) + string_2 + Class84.smethod_0(-994179831);
		mySqlCommand_0.CommandText = commandText;
		mySqlDataReader = mySqlCommand_0.ExecuteReader();
		while (mySqlDataReader.Read())
		{
			int item2 = Convert.ToInt32(mySqlDataReader[0]);
			if (!hashSet_0.Contains(item2))
			{
				hashSet_0.Add(item2);
			}
		}
		mySqlDataReader.Close();
		commandText = Class84.smethod_0(-994179757) + string_0 + Class84.smethod_0(-994179904) + string_1 + Class84.smethod_0(-994224932) + string_2 + Class84.smethod_0(-994179831);
		mySqlCommand_0.CommandText = commandText;
		mySqlDataReader = mySqlCommand_0.ExecuteReader();
		while (mySqlDataReader.Read())
		{
			int item3 = Convert.ToInt32(mySqlDataReader[0]);
			if (!hashSet_0.Contains(item3))
			{
				hashSet_0.Add(item3);
			}
		}
		mySqlDataReader.Close();
	}

	private static void smethod_8(MySqlCommand mySqlCommand_0, HashSet<int> hashSet_0, string string_0, string string_1, string string_2)
	{
		string commandText = Class84.smethod_0(-994179553) + string_0 + Class84.smethod_0(-994180143) + string_1 + Class84.smethod_0(-994224932) + string_2 + Class84.smethod_0(-994180066);
		mySqlCommand_0.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		while (mySqlDataReader.Read())
		{
			int item = Convert.ToInt32(mySqlDataReader[0]);
			if (!hashSet_0.Contains(item))
			{
				hashSet_0.Add(item);
			}
		}
		mySqlDataReader.Close();
		commandText = Class84.smethod_0(-994179450) + string_0 + Class84.smethod_0(-994179904) + string_1 + Class84.smethod_0(-994224932) + string_2 + Class84.smethod_0(-994179831);
		mySqlCommand_0.CommandText = commandText;
		mySqlDataReader = mySqlCommand_0.ExecuteReader();
		while (mySqlDataReader.Read())
		{
			int item2 = Convert.ToInt32(mySqlDataReader[0]);
			if (!hashSet_0.Contains(item2))
			{
				hashSet_0.Add(item2);
			}
		}
		mySqlDataReader.Close();
		commandText = Class84.smethod_0(-994179283) + string_0 + Class84.smethod_0(-994179904) + string_1 + Class84.smethod_0(-994224932) + string_2 + Class84.smethod_0(-994179831);
		mySqlCommand_0.CommandText = commandText;
		mySqlDataReader = mySqlCommand_0.ExecuteReader();
		while (mySqlDataReader.Read())
		{
			int item3 = Convert.ToInt32(mySqlDataReader[0]);
			if (!hashSet_0.Contains(item3))
			{
				hashSet_0.Add(item3);
			}
		}
		mySqlDataReader.Close();
	}
}
