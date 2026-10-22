using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class173
{
	private sealed class Class174
	{
		public string string_0;

		public int int_0;

		public string string_1;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public string string_2;

		public string string_3;

		public string string_4;

		public string string_5;

		public string string_6;

		public string string_7;

		public string string_8;

		public string string_9;

		public string string_10;

		public string string_11;

		public string string_12;

		public string string_13;
	}

	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			Class122.smethod_0(Class84.smethod_0(-994205061), string.Empty, string.Empty, string.Empty, string.Empty);
			Class260 @class = Class260.smethod_0(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			int num = Convert.ToInt32(@class.Protocol);
			GClass70 gClass = null;
			switch (num)
			{
			case 153:
				gClass = smethod_1(gclass4_0, gclass41_0.method_46(), @class);
				break;
			case 163:
				gClass = smethod_2(gclass4_0, gclass41_0.method_46(), @class);
				break;
			case 157:
				gClass = smethod_14(gclass4_0, gclass41_0.method_46(), @class);
				break;
			case 159:
				gClass = smethod_10(gclass4_0, gclass41_0.method_46(), @class);
				break;
			case 162:
				gClass = smethod_3(gclass4_0, gclass41_0.method_46(), @class);
				break;
			}
			if (gClass.Value < 0)
			{
				gclass4_0.method_5(GEnum0.Error, gclass41_0?.method_46(), string.Empty, gClass.Text);
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
			gclass41_0?.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0?.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994201677));
			gclass4_0.method_5(GEnum0.Error, gclass41_0?.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			jsRequest_0.Data = string.Empty;
			jsRequest_0.ServerStatus = -1;
			jsRequest_0.ExecCode = -1;
			jsRequest_0.Message = Class309.smethod_73() + ex.Message;
			jsRequest_0.UserRequest.Inflate();
			gclass41_0?.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
	}

	public static GClass70 smethod_1(GClass4 gclass4_0, string string_0, Class260 class260_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		string string_1 = string.Empty;
		try
		{
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			Class270 @class = Class270.smethod_0(Class282.smethod_8(class260_0.Data1));
			string text = @class.Desc.Trim().Replace('\'', '`');
			@class.Info.Trim().Replace('\'', '`');
			string jsUserId = @class.JsUserId;
			string text2 = @class.JsUserName.Trim().Replace('\'', '`');
			string_1 = @class.UserName.Trim().Replace('\'', '`');
			string jsDevId = @class.JsDevId;
			string text3 = @class.JsDevName.Trim().Replace('\'', '`');
			string commandText = Class84.smethod_0(-994205086);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994205055) + text + Class84.smethod_0(-994204911) + jsUserId + Class84.smethod_0(-994204837) + text2 + Class84.smethod_0(-994204859) + jsDevId + Class84.smethod_0(-994204787) + text3 + Class84.smethod_0(-994204746) + @class.Nomor + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994204674) + @class.Nomor + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994204559);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			string text4 = Class282.smethod_9(JsonConvert.SerializeObject(class260_0));
			string text5 = class260_0.Message.Trim().Replace('\'', '`');
			commandText = Class84.smethod_0(-994204525) + class260_0.Token + Class84.smethod_0(-994204395) + @class.Nomor + Class84.smethod_0(-994204326) + text5 + Class84.smethod_0(-994204349) + class260_0.Protocol + Class84.smethod_0(-994204311) + text4 + Class84.smethod_0(-994204253);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			if (class260_0.Action.Equals(Class84.smethod_0(-994204210)))
			{
				mySqlTransaction.Commit();
			}
			else
			{
				mySqlTransaction.Rollback();
			}
			gclass4_0.method_5(GEnum0.Info, string_0, string_1, text5);
			return new GClass70(1, Class84.smethod_0(-994247224), Class84.smethod_0(-994204165));
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, string_0, string_1, Class84.smethod_0(-994204132));
			gclass4_0.method_5(GEnum0.Error, string_0, string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	public static GClass70 smethod_2(GClass4 gclass4_0, string string_0, Class260 class260_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		string string_1 = string.Empty;
		try
		{
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			string string_2 = Class282.smethod_8(class260_0.Data1);
			string empty = string.Empty;
			Class270 @class = Class270.smethod_0(string_2);
			string_1 = @class.UserName.Trim().Replace('\'', '`');
			empty = Class84.smethod_0(-994205086);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			empty = Class84.smethod_0(-994204105) + @class.Nomor + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			empty = Class84.smethod_0(-994203989) + @class.Nomor + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			empty = Class84.smethod_0(-994204559);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			string text = Class282.smethod_9(JsonConvert.SerializeObject(class260_0));
			string text2 = class260_0.Message.Trim().Replace('\'', '`');
			empty = Class84.smethod_0(-994204525) + class260_0.Token + Class84.smethod_0(-994204395) + @class.Nomor + Class84.smethod_0(-994204326) + text2 + Class84.smethod_0(-994204349) + class260_0.Protocol + Class84.smethod_0(-994204311) + text + Class84.smethod_0(-994204253);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			if (class260_0.Action.Equals(Class84.smethod_0(-994204210)))
			{
				mySqlTransaction.Commit();
			}
			else
			{
				mySqlTransaction.Rollback();
			}
			gclass4_0.method_5(GEnum0.Info, string_0, string_1, text2);
			return new GClass70(1, Class84.smethod_0(-994247224), Class84.smethod_0(-994203858));
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, string_0, string_1, Class84.smethod_0(-994203828));
			gclass4_0.method_5(GEnum0.Error, string_0, string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	public static GClass70 smethod_3(GClass4 gclass4_0, string string_0, Class260 class260_0)
	{
		string string_1 = string.Empty;
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		try
		{
			string nomor = class260_0.Nomor;
			string_1 = class260_0.Data1;
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			string commandText = Class84.smethod_0(-994205086);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994203758) + nomor + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994191340) + nomor + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994204559);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			string text = Class282.smethod_9(JsonConvert.SerializeObject(class260_0));
			string text2 = class260_0.Message.Trim().Replace('\'', '`');
			commandText = Class84.smethod_0(-994204525) + class260_0.Token + Class84.smethod_0(-994204395) + class260_0.Nomor + Class84.smethod_0(-994204326) + text2 + Class84.smethod_0(-994204349) + class260_0.Protocol + Class84.smethod_0(-994204311) + text + Class84.smethod_0(-994204253);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			if (class260_0.Action.Equals(Class84.smethod_0(-994204210)))
			{
				mySqlTransaction.Commit();
			}
			else
			{
				mySqlTransaction.Rollback();
			}
			return new GClass70(1, Class84.smethod_0(-994247224));
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, string_0, string_1, Class84.smethod_0(-994191109));
			gclass4_0.method_5(GEnum0.Error, string_0, string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			Class143 @class = Class143.smethod_0((Enum2)6000, Class84.smethod_0(-994191092), string.Empty, string.Empty);
			return new GClass70(-1, @class.method_1());
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static string smethod_4(MySqlCommand mySqlCommand_0, string string_0)
	{
		string result = string.Empty;
		string commandText = Class84.smethod_0(-994191048) + string_0 + Class84.smethod_0(-994271698);
		mySqlCommand_0.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			result = mySqlDataReader[0].ToString();
		}
		mySqlDataReader.Close();
		return result;
	}

	private static int smethod_5(MySqlCommand mySqlCommand_0, string string_0)
	{
		int result = 0;
		string commandText = Class84.smethod_0(-994190974) + string_0 + Class84.smethod_0(-994190837);
		mySqlCommand_0.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			result = Convert.ToInt32(mySqlDataReader[0]);
		}
		mySqlDataReader.Close();
		return result;
	}

	private static string smethod_6(MySqlCommand mySqlCommand_0, int int_0)
	{
		string result = string.Empty;
		string commandText = string.Format(Class84.smethod_0(-994190754), int_0);
		mySqlCommand_0.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			string text = mySqlDataReader[Class84.smethod_0(-994190628)].ToString();
			int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994190647)]);
			result = text + (num + 1).ToString().PadLeft(6, '0');
		}
		mySqlDataReader.Close();
		return result;
	}

	private static void smethod_7(int int_0, string string_0, int int_1, int int_2, string string_1, string string_2, string string_3)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			smethod_8(new MySqlCommand
			{
				Connection = mySqlConnection
			}, int_0, string_0, int_1, int_2, string_1, string_2, string_3);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static void smethod_8(MySqlCommand mySqlCommand_0, int int_0, string string_0, int int_1, int int_2, string string_1, string string_2, string string_3)
	{
		try
		{
			mySqlCommand_0.CommandText = Class84.smethod_0(-994190651);
			mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994190343), MySqlDbType.Int32);
			mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994190345), MySqlDbType.VarChar);
			mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994190364), MySqlDbType.Int32);
			mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994190318), MySqlDbType.Int32);
			mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994190334), MySqlDbType.VarChar);
			mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994190284), MySqlDbType.VarChar);
			mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994190298), MySqlDbType.VarChar);
			mySqlCommand_0.Parameters[Class84.smethod_0(-994190343)].Value = int_0;
			mySqlCommand_0.Parameters[Class84.smethod_0(-994190345)].Value = string_0;
			mySqlCommand_0.Parameters[Class84.smethod_0(-994190364)].Value = int_1;
			mySqlCommand_0.Parameters[Class84.smethod_0(-994190318)].Value = int_2;
			mySqlCommand_0.Parameters[Class84.smethod_0(-994190334)].Value = string_1;
			mySqlCommand_0.Parameters[Class84.smethod_0(-994190284)].Value = string_2;
			mySqlCommand_0.Parameters[Class84.smethod_0(-994190298)].Value = string_3;
			mySqlCommand_0.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private static void smethod_9(MySqlCommand mySqlCommand_0, string string_0, ref string string_1, ref string string_2)
	{
		string commandText = Class84.smethod_0(-994190249) + string_0 + Class84.smethod_0(-994271698);
		mySqlCommand_0.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			string_1 = mySqlDataReader[0].ToString();
			string_2 = mySqlDataReader[1].ToString();
		}
		mySqlDataReader.Close();
	}

	public static GClass70 smethod_10(GClass4 gclass4_0, string string_0, Class260 class260_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		string text = string.Empty;
		try
		{
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class282.smethod_8(class260_0.Data1));
			List<List<string>> list2 = JsonConvert.DeserializeObject<List<List<string>>>(Class282.smethod_8(class260_0.Data2));
			string text2 = list[0];
			string text3 = list[1];
			string text4 = list[2];
			text = Class282.smethod_6(list[3]);
			string text5 = list[4];
			string string_1 = list[5];
			string text6 = list[6];
			Convert.ToInt32(list[7]);
			string text7 = list[8];
			string text8 = list[9];
			string text9 = list[10];
			string text10 = list[11];
			string text11 = Class282.smethod_6(list[12]);
			string text12 = Class282.smethod_6(list[13]);
			string string_2 = list[14];
			string value = list[15];
			string text13 = Class282.smethod_6(list[16]);
			string text14 = list[17];
			string text15 = list[18];
			string text16 = list[19];
			bool flag = Class159.smethod_0(list[20], 0) == 1;
			_ = list[21];
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string empty = string.Empty;
			empty = Class84.smethod_0(-994190130) + text2 + Class84.smethod_0(-994190012);
			mySqlCommand.CommandText = empty;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				string object_ = mySqlDataReader[Class84.smethod_0(-994189914)].ToString();
				return new GClass70(2, Class84.smethod_0(-994189865) + text2 + Class84.smethod_0(-994189837), object_);
			}
			mySqlDataReader.Close();
			mySqlTransaction = (mySqlCommand.Transaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty));
			text6 = smethod_4(mySqlCommand, string_1);
			if (text6.Equals(string.Empty))
			{
				smethod_7(2, text2, -1, 0, Class84.smethod_0(-994189798), string.Empty, text16);
				mySqlTransaction.Rollback();
				return new GClass70(-1, Class84.smethod_0(-994189733), string.Empty);
			}
			int num = smethod_5(mySqlCommand, text6);
			if (num == 0)
			{
				smethod_7(2, text2, -1, 0, Class84.smethod_0(-994189677), string.Empty, text16);
				mySqlTransaction.Rollback();
				return new GClass70(-1, Class84.smethod_0(-994189612), string.Empty);
			}
			string string_3 = string.Empty;
			string string_4 = string.Empty;
			smethod_9(mySqlCommand, text10, ref string_3, ref string_4);
			List<List<string>> list3 = new List<List<string>>();
			int num2 = 0;
			int int_ = 0;
			int num3 = 0;
			int num4 = Math.Abs(Convert.ToInt32(value));
			int int_2 = 0;
			empty = Class84.smethod_0(-994189556) + text3 + Class84.smethod_0(-994189444) + text5 + Class84.smethod_0(-994200012) + text4 + Class84.smethod_0(-994189450) + text + Class84.smethod_0(-994189412) + text6 + Class84.smethod_0(-994189436) + text9 + Class84.smethod_0(-994189386) + text10 + Class84.smethod_0(-994189350) + text2 + Class84.smethod_0(-994193379) + text15 + Class84.smethod_0(-994193330) + text11 + Class84.smethod_0(-994193291) + text12 + Class84.smethod_0(-994193254) + text13 + Class84.smethod_0(-994193266) + text16 + Class84.smethod_0(-994193227) + text7 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			empty = Class84.smethod_0(-994260596);
			mySqlCommand.CommandText = empty;
			string text17 = mySqlCommand.ExecuteScalar().ToString();
			foreach (List<string> item3 in list2)
			{
				int num5 = Convert.ToInt32(item3[1]);
				if (num5 == 0)
				{
					num2 += Convert.ToInt32(item3[5]);
					continue;
				}
				Class174 @class = new Class174
				{
					string_0 = item3[0],
					string_6 = text2,
					int_0 = num5,
					string_1 = item3[2],
					int_1 = Convert.ToInt32(item3[3]),
					int_2 = num,
					int_3 = Convert.ToInt32(item3[4]),
					int_4 = Convert.ToInt32(item3[5]),
					int_5 = Convert.ToInt32(item3[6]),
					string_7 = text10,
					string_5 = text4,
					string_4 = text,
					string_8 = text11,
					string_9 = text12,
					string_10 = text15,
					string_11 = text17,
					string_12 = text6,
					string_13 = text16
				};
				if (@class.string_0.Equals(Class84.smethod_0(-994193155)))
				{
					GClass70 gClass = smethod_13(mySqlTransaction, mySqlCommand, 2, @class, list3, ref int_, ref int_2);
					if (gClass.Value < 0)
					{
						return gClass;
					}
				}
				else if (@class.string_0.Equals(Class84.smethod_0(-994193161)))
				{
					GClass70 gClass2 = smethod_12(mySqlTransaction, mySqlCommand, @class, list3, ref int_);
					if (gClass2.Value < 0)
					{
						return gClass2;
					}
				}
				else if (@class.string_0.Equals(Class84.smethod_0(-994193183)))
				{
					GClass70 gClass3 = smethod_11(mySqlTransaction, mySqlCommand, @class, list3, ref int_);
					if (gClass3.Value < 0)
					{
						return gClass3;
					}
				}
			}
			if (num2 > 0)
			{
				string text18 = string.Empty;
				if (!string_3.Equals(string.Empty) && !string_4.Equals(string.Empty))
				{
					text18 = smethod_6(mySqlCommand, num);
					List<string> item = new List<string>
					{
						text18,
						Class84.smethod_0(-994193122),
						num2.ToString(),
						Class84.smethod_0(-994274584),
						Class84.smethod_0(-994193150),
						Class84.smethod_0(-994274584)
					};
					list3.Add(item);
					int int_3 = smethod_16(mySqlCommand, num, text15, Class84.smethod_0(-994193093) + text2, text18, string.Empty, text11, text12, Class84.smethod_0(-994193062));
					smethod_17(mySqlCommand, int_3, Class84.smethod_0(-994284297), string_3, num2);
					smethod_17(mySqlCommand, int_3, Class84.smethod_0(-994193066), string_4, num2);
					empty = string.Format(Class84.smethod_0(-994193074), num);
					mySqlCommand.CommandText = empty;
					mySqlCommand.ExecuteNonQuery();
				}
				empty = string.Format(Class84.smethod_0(-994192947), text17, num, num2, text18);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				empty = string.Format(Class84.smethod_0(-994192643), text6, text10, num2, num2);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			num3 = int_ + num2;
			string text19 = text9 + Class84.smethod_0(-994263061) + text10;
			empty = string.Format(Class84.smethod_0(-994192406), num, text5, text4, text11, text8, text2, num3, text19);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			empty = Class84.smethod_0(-994260596);
			mySqlCommand.CommandText = empty;
			int num6 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
			for (int i = 0; i < list3.Count; i++)
			{
				string arg = list3[i][0];
				string arg2 = list3[i][4];
				empty = string.Format(Class84.smethod_0(-994192184), num6, arg, arg2);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			int num7 = 0;
			if (num4 > 0 || int_2 > 0)
			{
				empty = string.Format(Class84.smethod_0(-994192042), text6, text2, num4, int_2, text10);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				num7 = num4 + int_2;
				string text20 = string.Empty;
				if (!string_3.Equals(string.Empty) && !string_4.Equals(string.Empty))
				{
					text20 = smethod_6(mySqlCommand, num);
					List<string> item2 = new List<string>
					{
						text20,
						Class84.smethod_0(-994191869),
						num7.ToString(),
						Class84.smethod_0(-994274584),
						Class84.smethod_0(-994191828),
						Class84.smethod_0(-994274584)
					};
					list3.Add(item2);
					int int_4 = smethod_16(mySqlCommand, num, text15, Class84.smethod_0(-994191835) + text2, text20, string.Empty, text11, text12, Class84.smethod_0(-994191793));
					smethod_17(mySqlCommand, int_4, Class84.smethod_0(-994284297), string_3, num7);
					smethod_17(mySqlCommand, int_4, Class84.smethod_0(-994193066), string_4, num7);
				}
				empty = string.Format(Class84.smethod_0(-994191757), text17, num, num7, text20);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				empty = string.Format(Class84.smethod_0(-994191464), text6, text10, num7, num7);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			empty = string.Format(Class84.smethod_0(-994195307), num3, num2, num7, text17);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			string text21 = JsonConvert.SerializeObject(new List<string>
			{
				text15,
				num3.ToString(),
				JsonConvert.SerializeObject(list3)
			});
			smethod_8(mySqlCommand, 2, text2, 1, 1, Class84.smethod_0(-994195150), text21, text16);
			string text22 = Class282.smethod_9(text21);
			string text23 = Class282.smethod_9(JsonConvert.SerializeObject(class260_0));
			string text24 = class260_0.Message.Trim().Replace('\'', '`');
			empty = Class84.smethod_0(-994204525) + class260_0.Token + Class84.smethod_0(-994204395) + class260_0.Nomor + Class84.smethod_0(-994204326) + text24 + Class84.smethod_0(-994204349) + class260_0.Protocol + Class84.smethod_0(-994204311) + text23 + Class84.smethod_0(-994195167) + text22 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			if (flag)
			{
				mySqlTransaction.Rollback();
			}
			else
			{
				mySqlTransaction.Commit();
			}
			if (!flag && text14.Equals(Class84.smethod_0(-994248276)))
			{
				smethod_15(text6, text, text4, text5, string_2, text7);
			}
			if (!flag)
			{
				gclass4_0.method_23();
			}
			gclass4_0.method_5(GEnum0.Info, string_0, text, flag ? Class84.smethod_0(-994195104) : Class84.smethod_0(-994195125));
			return new GClass70(1, Class84.smethod_0(-994247224), text21);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, string_0, text, Class84.smethod_0(-994195010));
			gclass4_0.method_5(GEnum0.Error, string_0, string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			Class143 class2 = Class143.smethod_0((Enum2)6000, Class84.smethod_0(-994205106), string.Empty, string.Empty);
			return new GClass70(-1, class2.method_1());
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static GClass70 smethod_11(MySqlTransaction mySqlTransaction_0, MySqlCommand mySqlCommand_0, Class174 class174_0, List<List<string>> list_0, ref int int_0)
	{
		string text = string.Empty;
		string string_ = string.Empty;
		string commandText = string.Format(Class84.smethod_0(-994194998), class174_0.int_0);
		mySqlCommand_0.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			text = mySqlDataReader[Class84.smethod_0(-994194878)].ToString();
			string_ = mySqlDataReader[Class84.smethod_0(-994194817)].ToString();
		}
		mySqlDataReader.Close();
		if (text.Equals(string.Empty))
		{
			smethod_7(2, class174_0.string_6, -1, 0, Class84.smethod_0(-994194834), string.Empty, class174_0.string_13);
			mySqlTransaction_0.Rollback();
			return new GClass70(-1, Class84.smethod_0(-994194771), string.Empty);
		}
		string text2 = smethod_6(mySqlCommand_0, class174_0.int_2);
		List<string> item = new List<string>
		{
			text2,
			class174_0.string_1,
			class174_0.int_4.ToString(),
			class174_0.int_5.ToString(),
			Class84.smethod_0(-994193183),
			Class84.smethod_0(-994274584)
		};
		list_0.Add(item);
		string string_2 = Class84.smethod_0(-994194717) + class174_0.string_1 + Class84.smethod_0(-994194676) + class174_0.string_4 + Class84.smethod_0(-994265926) + class174_0.string_5 + Class84.smethod_0(-994271866);
		int num = smethod_16(mySqlCommand_0, class174_0.int_2, class174_0.string_10, string_2, text2, string.Empty, class174_0.string_8, class174_0.string_9, Class84.smethod_0(-994194630));
		smethod_17(mySqlCommand_0, num, Class84.smethod_0(-994284297), text, class174_0.int_4);
		smethod_17(mySqlCommand_0, num, Class84.smethod_0(-994193066), string_, class174_0.int_4);
		commandText = string.Format(Class84.smethod_0(-994194656), class174_0.int_2);
		mySqlCommand_0.CommandText = commandText;
		mySqlCommand_0.ExecuteNonQuery();
		commandText = string.Format(Class84.smethod_0(-994194516), class174_0.string_5, class174_0.int_0, class174_0.int_4, class174_0.string_3, class174_0.string_8, num, class174_0.string_10);
		mySqlCommand_0.CommandText = commandText;
		mySqlCommand_0.ExecuteNonQuery();
		commandText = Class84.smethod_0(-994260596);
		mySqlCommand_0.CommandText = commandText;
		int num2 = Convert.ToInt32(mySqlCommand_0.ExecuteScalar());
		commandText = string.Format(Class84.smethod_0(-994194278), class174_0.string_11, class174_0.int_2, class174_0.int_0, num2, class174_0.int_4, class174_0.string_1, text2);
		mySqlCommand_0.CommandText = commandText;
		mySqlCommand_0.ExecuteNonQuery();
		commandText = string.Format(Class84.smethod_0(-994194046), class174_0.string_12, class174_0.string_7, class174_0.int_0, class174_0.int_4, class174_0.int_4);
		mySqlCommand_0.CommandText = commandText;
		mySqlCommand_0.ExecuteNonQuery();
		int_0 += class174_0.int_4;
		return new GClass70(1, Class84.smethod_0(-994247224));
	}

	private static GClass70 smethod_12(MySqlTransaction mySqlTransaction_0, MySqlCommand mySqlCommand_0, Class174 class174_0, List<List<string>> list_0, ref int int_0)
	{
		string text = string.Empty;
		string string_ = string.Empty;
		string commandText = string.Format(Class84.smethod_0(-994193715), class174_0.int_0);
		mySqlCommand_0.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			text = mySqlDataReader[Class84.smethod_0(-994194878)].ToString();
			string_ = mySqlDataReader[Class84.smethod_0(-994193594)].ToString();
		}
		mySqlDataReader.Close();
		if (text.Equals(string.Empty))
		{
			smethod_7(2, class174_0.string_6, -1, 0, Class84.smethod_0(-994193558), string.Empty, class174_0.string_13);
			mySqlTransaction_0.Rollback();
			return new GClass70(-1, Class84.smethod_0(-994193493), string.Empty);
		}
		string text2 = smethod_6(mySqlCommand_0, class174_0.int_2);
		List<string> item = new List<string>
		{
			text2,
			class174_0.string_1,
			class174_0.int_4.ToString(),
			class174_0.int_5.ToString(),
			Class84.smethod_0(-994193161),
			Class84.smethod_0(-994274584)
		};
		list_0.Add(item);
		string string_2 = Class84.smethod_0(-994193437) + class174_0.string_1 + Class84.smethod_0(-994197483) + Class120.smethod_12(class174_0.string_10) + Class84.smethod_0(-994194676) + class174_0.string_4 + Class84.smethod_0(-994265926) + class174_0.string_5 + Class84.smethod_0(-994271866);
		int num = smethod_16(mySqlCommand_0, class174_0.int_2, class174_0.string_10, string_2, text2, string.Empty, class174_0.string_8, class174_0.string_9, Class84.smethod_0(-994197499));
		smethod_17(mySqlCommand_0, num, Class84.smethod_0(-994284297), text, class174_0.int_4);
		smethod_17(mySqlCommand_0, num, Class84.smethod_0(-994193066), string_, class174_0.int_4);
		commandText = string.Format(Class84.smethod_0(-994194656), class174_0.int_2);
		mySqlCommand_0.CommandText = commandText;
		mySqlCommand_0.ExecuteNonQuery();
		commandText = string.Format(Class84.smethod_0(-994197461), class174_0.int_0, class174_0.string_5, num, class174_0.int_4, class174_0.string_10, class174_0.string_8);
		mySqlCommand_0.CommandText = commandText;
		mySqlCommand_0.ExecuteNonQuery();
		commandText = Class84.smethod_0(-994260596);
		mySqlCommand_0.CommandText = commandText;
		int num2 = Convert.ToInt32(mySqlCommand_0.ExecuteScalar());
		commandText = string.Format(Class84.smethod_0(-994197269), class174_0.string_11, class174_0.int_2, class174_0.int_0, num2, class174_0.int_4, class174_0.string_1, text2);
		mySqlCommand_0.CommandText = commandText;
		mySqlCommand_0.ExecuteNonQuery();
		commandText = string.Format(Class84.smethod_0(-994196962), class174_0.string_12, class174_0.string_7, class174_0.int_0, class174_0.int_4, class174_0.int_4);
		mySqlCommand_0.CommandText = commandText;
		mySqlCommand_0.ExecuteNonQuery();
		int_0 += class174_0.int_4;
		return new GClass70(1, Class84.smethod_0(-994247224));
	}

	private static GClass70 smethod_13(MySqlTransaction mySqlTransaction_0, MySqlCommand mySqlCommand_0, int int_0, Class174 class174_0, List<List<string>> list_0, ref int int_1, ref int int_2)
	{
		int num = class174_0.int_4 - class174_0.int_5;
		string string_ = class174_0.string_1;
		string string_2 = class174_0.string_1 + Class84.smethod_0(-994194676) + class174_0.string_4 + Class84.smethod_0(-994265926) + class174_0.string_5 + Class84.smethod_0(-994271866);
		int num2 = 0;
		string commandText = string.Format(Class84.smethod_0(-994196699), class174_0.int_3);
		mySqlCommand_0.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			num2 = Convert.ToInt32(mySqlDataReader[0]);
		}
		mySqlDataReader.Close();
		string text = string.Empty;
		string string_3 = string.Empty;
		string string_4 = string.Empty;
		commandText = string.Format(Class84.smethod_0(-994196568), class174_0.int_0);
		mySqlCommand_0.CommandText = commandText;
		mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			text = mySqlDataReader[Class84.smethod_0(-994194878)].ToString();
			string_3 = mySqlDataReader[Class84.smethod_0(-994196398)].ToString();
			mySqlDataReader[Class84.smethod_0(-994193594)].ToString();
			string_4 = mySqlDataReader[Class84.smethod_0(-994203637)].ToString();
		}
		mySqlDataReader.Close();
		if (text.Equals(string.Empty))
		{
			smethod_7(int_0, class174_0.string_6, -1, 0, Class84.smethod_0(-994193558), string.Empty, class174_0.string_13);
			mySqlTransaction_0.Rollback();
			return new GClass70(-1, Class84.smethod_0(-994196413), string.Empty);
		}
		int num3 = 0;
		int num4 = 0;
		commandText = string.Format(Class84.smethod_0(-994196293), class174_0.int_3);
		mySqlCommand_0.CommandText = commandText;
		mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			num3 = Convert.ToInt32(mySqlDataReader[0]);
			num4 = Convert.ToInt32(mySqlDataReader[1]);
		}
		mySqlDataReader.Close();
		int num5 = num2 - num3 - num4 - class174_0.int_4;
		int num6 = ((num5 <= 0) ? 1 : 0);
		if (num5 < 0)
		{
			string arg = Class176.smethod_0(num5.ToString());
			smethod_7(int_0, class174_0.string_6, 0, 0, string.Format(Class84.smethod_0(-994196135), arg, class174_0.string_1, class174_0.int_0), string.Empty, class174_0.string_13);
			int_2 = Math.Abs(num5);
			class174_0.int_4 = num2 - num3 - num4;
			class174_0.int_5 = 0;
			num = class174_0.int_4;
		}
		int_1 += num;
		if (num5 < 0)
		{
			num5 = 0;
		}
		string text2 = smethod_6(mySqlCommand_0, class174_0.int_2);
		List<string> item = new List<string>
		{
			text2,
			string_,
			class174_0.int_4.ToString(),
			class174_0.int_5.ToString(),
			Class84.smethod_0(-994193155),
			num5.ToString()
		};
		list_0.Add(item);
		int num7 = smethod_16(mySqlCommand_0, class174_0.int_2, class174_0.string_10, string_2, text2, string.Empty, class174_0.string_8, class174_0.string_9, Class84.smethod_0(-994191793));
		smethod_17(mySqlCommand_0, num7, Class84.smethod_0(-994284297), text, num);
		smethod_17(mySqlCommand_0, num7, Class84.smethod_0(-994193066), string_3, class174_0.int_4);
		if (class174_0.int_5 > 0)
		{
			smethod_17(mySqlCommand_0, num7, Class84.smethod_0(-994284297), string_4, class174_0.int_5);
		}
		commandText = string.Format(Class84.smethod_0(-994194656), class174_0.int_2);
		mySqlCommand_0.CommandText = commandText;
		mySqlCommand_0.ExecuteNonQuery();
		commandText = string.Format(Class84.smethod_0(-994196077), class174_0.int_3, num7, class174_0.string_10, num, class174_0.string_8, class174_0.int_5);
		mySqlCommand_0.CommandText = commandText;
		mySqlCommand_0.ExecuteNonQuery();
		commandText = Class84.smethod_0(-994260596);
		mySqlCommand_0.CommandText = commandText;
		int num8 = Convert.ToInt32(mySqlCommand_0.ExecuteScalar());
		if (num6 == 1)
		{
			commandText = Class84.smethod_0(-994195930);
			mySqlCommand_0.CommandText = commandText;
			mySqlCommand_0.ExecuteNonQuery();
			commandText = string.Format(Class84.smethod_0(-994195898), class174_0.int_3);
			mySqlCommand_0.CommandText = commandText;
			mySqlCommand_0.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994195775);
			mySqlCommand_0.CommandText = commandText;
			mySqlCommand_0.ExecuteNonQuery();
		}
		commandText = string.Format(Class84.smethod_0(-994195740), class174_0.string_11, class174_0.int_2, class174_0.int_0, num8, num, class174_0.int_5, string_, num5, text2);
		mySqlCommand_0.CommandText = commandText;
		mySqlCommand_0.ExecuteNonQuery();
		commandText = string.Format(Class84.smethod_0(-994183153), class174_0.string_12, class174_0.string_7, class174_0.int_0, num, num);
		mySqlCommand_0.CommandText = commandText;
		mySqlCommand_0.ExecuteNonQuery();
		return new GClass70(1, Class84.smethod_0(-994247224));
	}

	public static GClass70 smethod_14(GClass4 gclass4_0, string string_0, Class260 class260_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		string text = string.Empty;
		try
		{
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class282.smethod_8(class260_0.Data1));
			List<List<string>> list2 = JsonConvert.DeserializeObject<List<List<string>>>(Class282.smethod_8(class260_0.Data2));
			string text2 = list[0];
			string text3 = list[1];
			string text4 = list[2];
			text = Class282.smethod_6(list[3]);
			string text5 = list[4];
			string string_1 = list[5];
			string text6 = list[6];
			int num = Convert.ToInt32(list[7]);
			string text7 = Class282.smethod_6(list[8]);
			string text8 = list[9];
			string text9 = list[10];
			string text10 = list[11];
			string text11 = Class282.smethod_6(list[12]);
			string text12 = Class282.smethod_6(list[13]);
			string string_2 = list[14];
			string value = list[15];
			string text13 = Class282.smethod_6(list[16]);
			string text14 = list[17];
			string text15 = list[18];
			string text16 = list[19];
			bool flag = Class159.smethod_0(list[20], 0) == 1;
			_ = list[21];
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string empty = string.Empty;
			empty = Class84.smethod_0(-994182825) + text2 + Class84.smethod_0(-994190012);
			mySqlCommand.CommandText = empty;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				string object_ = mySqlDataReader[Class84.smethod_0(-994189914)].ToString();
				return new GClass70(2, Class84.smethod_0(-994182707) + text2 + Class84.smethod_0(-994189837), object_);
			}
			mySqlDataReader.Close();
			mySqlTransaction = (mySqlCommand.Transaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty));
			text6 = smethod_4(mySqlCommand, string_1);
			if (text6.Equals(string.Empty))
			{
				smethod_7(1, text2, -1, 0, Class84.smethod_0(-994189798), string.Empty, text16);
				mySqlTransaction.Rollback();
				return new GClass70(-1, Class84.smethod_0(-994189733), string.Empty);
			}
			int num2 = smethod_5(mySqlCommand, text6);
			if (num2 == 0)
			{
				smethod_7(1, text2, -1, 0, Class84.smethod_0(-994189677), string.Empty, text16);
				mySqlTransaction.Rollback();
				return new GClass70(-1, Class84.smethod_0(-994189612), string.Empty);
			}
			if (num != num2)
			{
				smethod_7(1, text2, -1, 0, Class84.smethod_0(-994182665), string.Empty, text16);
				mySqlTransaction.Rollback();
				return new GClass70(-1, Class84.smethod_0(-994182569), string.Empty);
			}
			string string_3 = string.Empty;
			string string_4 = string.Empty;
			smethod_9(mySqlCommand, text10, ref string_3, ref string_4);
			List<List<string>> list3 = new List<List<string>>();
			int num3 = 0;
			int int_ = 0;
			int num4 = 0;
			int num5 = Math.Abs(Convert.ToInt32(value));
			int int_2 = 0;
			empty = Class84.smethod_0(-994189556) + text3 + Class84.smethod_0(-994189444) + text5 + Class84.smethod_0(-994200012) + text4 + Class84.smethod_0(-994189450) + text + Class84.smethod_0(-994189412) + text6 + Class84.smethod_0(-994189436) + text9 + Class84.smethod_0(-994189386) + text10 + Class84.smethod_0(-994182482) + text8 + Class84.smethod_0(-994182445) + text2 + Class84.smethod_0(-994182458) + text15 + Class84.smethod_0(-994182396) + text7 + Class84.smethod_0(-994182357) + text11 + Class84.smethod_0(-994193291) + text12 + Class84.smethod_0(-994193254) + text13 + Class84.smethod_0(-994193266) + text16 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			empty = Class84.smethod_0(-994260596);
			mySqlCommand.CommandText = empty;
			string text17 = mySqlCommand.ExecuteScalar().ToString();
			foreach (List<string> item3 in list2)
			{
				int num6 = Convert.ToInt32(item3[1]);
				if (num6 == 0)
				{
					num3 += Convert.ToInt32(item3[5]);
					continue;
				}
				Class174 class174_ = new Class174
				{
					string_0 = item3[0],
					string_6 = text2,
					int_0 = num6,
					string_1 = item3[2],
					int_1 = Convert.ToInt32(item3[3]),
					int_2 = num2,
					int_3 = Convert.ToInt32(item3[4]),
					int_4 = Convert.ToInt32(item3[5]),
					int_5 = Convert.ToInt32(item3[6]),
					string_7 = text10,
					string_5 = text4,
					string_4 = text,
					string_8 = text11,
					string_9 = text12,
					string_10 = text15,
					string_11 = text17,
					string_12 = text6,
					string_13 = text16
				};
				GClass70 gClass = smethod_13(mySqlTransaction, mySqlCommand, 1, class174_, list3, ref int_, ref int_2);
				if (gClass.Value >= 0)
				{
					continue;
				}
				return gClass;
			}
			if (num3 > 0)
			{
				string text18 = string.Empty;
				if (!string_3.Equals(string.Empty) && !string_4.Equals(string.Empty))
				{
					text18 = smethod_6(mySqlCommand, num2);
					List<string> item = new List<string>
					{
						text18,
						Class84.smethod_0(-994193122),
						num3.ToString(),
						Class84.smethod_0(-994274584),
						Class84.smethod_0(-994193150),
						Class84.smethod_0(-994274584)
					};
					list3.Add(item);
					int int_3 = smethod_16(mySqlCommand, num2, text15, Class84.smethod_0(-994182285) + text2, text18, string.Empty, text11, text12, Class84.smethod_0(-994193062));
					smethod_17(mySqlCommand, int_3, Class84.smethod_0(-994284297), string_3, num3);
					smethod_17(mySqlCommand, int_3, Class84.smethod_0(-994193066), string_4, num3);
					empty = string.Format(Class84.smethod_0(-994193074), num2);
					mySqlCommand.CommandText = empty;
					mySqlCommand.ExecuteNonQuery();
				}
				empty = string.Format(Class84.smethod_0(-994182256), text17, num2, num3, text18);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				empty = string.Format(Class84.smethod_0(-994182015), text6, text10, num3, num3);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			num4 = int_ + num3;
			string text19 = text9 + Class84.smethod_0(-994263061) + text10;
			empty = string.Format(Class84.smethod_0(-994181712), num2, text5, text4, text11, text2, num4, text19);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			empty = Class84.smethod_0(-994260596);
			mySqlCommand.CommandText = empty;
			int num7 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
			for (int i = 0; i < list3.Count; i++)
			{
				string arg = list3[i][0];
				string arg2 = list3[i][4];
				empty = string.Format(Class84.smethod_0(-994192184), num7, arg, arg2);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			int num8 = 0;
			if (num5 > 0 || int_2 > 0)
			{
				empty = string.Format(Class84.smethod_0(-994181475), text6, text2, num5, int_2, text10);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				num8 = num5 + int_2;
				string text20 = string.Empty;
				if (!string_3.Equals(string.Empty) && !string_4.Equals(string.Empty))
				{
					text20 = smethod_6(mySqlCommand, num2);
					List<string> item2 = new List<string>
					{
						text20,
						Class84.smethod_0(-994191869),
						num8.ToString(),
						Class84.smethod_0(-994274584),
						Class84.smethod_0(-994191828),
						Class84.smethod_0(-994274584)
					};
					list3.Add(item2);
					int int_4 = smethod_16(mySqlCommand, num2, text15, Class84.smethod_0(-994191835) + text2, text20, string.Empty, text11, text12, Class84.smethod_0(-994191793));
					smethod_17(mySqlCommand, int_4, Class84.smethod_0(-994284297), string_3, num8);
					smethod_17(mySqlCommand, int_4, Class84.smethod_0(-994193066), string_4, num8);
				}
				empty = string.Format(Class84.smethod_0(-994181302), text17, num2, num8, text20);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				empty = string.Format(Class84.smethod_0(-994191464), text6, text10, num8, num8);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			empty = string.Format(Class84.smethod_0(-994195307), num4, num3, num8, text17);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			empty = Class84.smethod_0(-994205086);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			empty = Class84.smethod_0(-994185090) + text2 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			empty = Class84.smethod_0(-994184972) + text2 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			empty = Class84.smethod_0(-994204559);
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			string text21 = JsonConvert.SerializeObject(new List<string>
			{
				text15,
				num4.ToString(),
				JsonConvert.SerializeObject(list3)
			});
			if (num5 <= 0 && int_2 <= 0)
			{
				smethod_8(mySqlCommand, 1, text2, 1, 1, Class84.smethod_0(-994195150), text21, text16);
			}
			else
			{
				string text22 = Class176.smethod_0((num5 + int_2).ToString() ?? string.Empty);
				smethod_8(mySqlCommand, 1, text2, 1, 1, Class84.smethod_0(-994184842) + text22, text21, text16);
			}
			Class282.smethod_9(text21);
			Class282.smethod_9(JsonConvert.SerializeObject(class260_0));
			class260_0.Message.Trim().Replace('\'', '`');
			if (flag)
			{
				mySqlTransaction.Rollback();
			}
			else
			{
				mySqlTransaction.Commit();
			}
			if (!flag && text14.Equals(Class84.smethod_0(-994248276)))
			{
				smethod_15(text6, text, text4, text5, string_2, text7);
			}
			if (!flag)
			{
				gclass4_0.method_23();
			}
			gclass4_0.method_5(GEnum0.Info, string_0, text, flag ? Class84.smethod_0(-994184746) : Class84.smethod_0(-994184773));
			return new GClass70(1, Class84.smethod_0(-994247224), text21);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, string_0, text, Class84.smethod_0(-994184678));
			gclass4_0.method_5(GEnum0.Error, string_0, string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			Class143 @class = Class143.smethod_0((Enum2)6000, Class84.smethod_0(-994205106), string.Empty, string.Empty);
			return new GClass70(-1, @class.method_1());
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_15(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string empty = string.Empty;
			string commandText = Class84.smethod_0(-994184660) + string_0 + Class84.smethod_0(-994184608);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			empty = ((!mySqlDataReader.Read()) ? Class84.smethod_0(-994184572) : mySqlDataReader[0].ToString());
			mySqlDataReader.Close();
			string text = empty.Replace(Class84.smethod_0(-994184420), Class176.smethod_0(string_4));
			text = text.Replace(Class84.smethod_0(-994267075), string_1);
			text = text.Replace(Class84.smethod_0(-994267135), string_2);
			Class243.smethod_0(string_3: text.Replace(Class84.smethod_0(-994184437), string_5), mySqlCommand_0: mySqlCommand, string_0: string_2, string_1: string_3, string_2: Class84.smethod_0(-994184387), string_4: Class84.smethod_0(-994184411), bool_0: true, bool_1: true, bool_2: true);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static int smethod_16(MySqlCommand mySqlCommand_0, int int_0, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		string text = (string_0.Equals(Class84.smethod_0(-994184368)) ? Class84.smethod_0(-994184374) : (Class84.smethod_0(-994271698) + string_0 + Class84.smethod_0(-994271698)));
		string commandText = string.Format(Class84.smethod_0(-994184378), int_0, text, string_1, string_2, string_3, string_4, string_5, string_6);
		mySqlCommand_0.CommandText = commandText;
		mySqlCommand_0.ExecuteNonQuery();
		commandText = Class84.smethod_0(-994260596);
		mySqlCommand_0.CommandText = commandText;
		return Convert.ToInt32(mySqlCommand_0.ExecuteScalar());
	}

	private static void smethod_17(MySqlCommand mySqlCommand_0, int int_0, string string_0, string string_1, int int_1)
	{
		string empty = string.Empty;
		empty = ((!string_0.Equals(Class84.smethod_0(-994284297))) ? string.Format(Class84.smethod_0(-994184057), int_0, string_1, int_1) : string.Format(Class84.smethod_0(-994184130), int_0, string_1, int_1));
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
	}
}
