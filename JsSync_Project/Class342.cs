using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Net;
using System.Reflection;
using System.Text;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class342
{
	private static CookieContainer cookieContainer_0;

	public static CookieContainer smethod_0()
	{
		if (cookieContainer_0 == null)
		{
			cookieContainer_0 = new CookieContainer();
		}
		return cookieContainer_0;
	}

	private static GClass70 smethod_1()
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class191
			{
				Op = Class84.smethod_0(-994265364)
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 result;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_11(), Class84.smethod_0(-994265316), data);
				result = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			return result;
		}
		catch (Exception ex)
		{
			return new GClass70(-99, ex.Message, ex);
		}
	}

	public static void smethod_2(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 2318)
			{
				gClass = smethod_9(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2319)
			{
				gClass = smethod_8(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2320)
			{
				gClass = smethod_7(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2321)
			{
				gClass = smethod_6(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2322)
			{
				gClass = smethod_5(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2323)
			{
				gClass = smethod_4(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2324)
			{
				gClass = smethod_3(gclass4_0, gclass41_0, jsRequest_0);
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
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994137889));
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

	private static GClass70 smethod_3(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		try
		{
			GClass70 gClass = smethod_1();
			if (gClass.Value < 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994137874));
			}
			string transactionId = gClass.Data.ToString();
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			bool flag = !text.Equals(Class84.smethod_0(-994274584));
			string empty = string.Empty;
			empty = ((!flag) ? Class84.smethod_0(-994265123) : Class84.smethod_0(-994265116));
			mySqlCommand.CommandText = empty;
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994269130), MySqlDbType.VarChar);
			mySqlCommand.Parameters[Class84.smethod_0(-994269130)].Value = text2;
			mySqlCommand.ExecuteNonQuery();
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class288
			{
				SchoolId = Class348.Class352.string_0,
				Op = (flag ? Class84.smethod_0(-994269101) : Class84.smethod_0(-994269147)),
				TransactionId = transactionId,
				Content = text2
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 gClass2;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_14(), Class84.smethod_0(-994265316), data);
				gClass2 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			if (gClass2.Value == 1)
			{
				mySqlTransaction.Commit();
				return new GClass70(1, Class84.smethod_0(-994247224));
			}
			mySqlTransaction.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994137856) + gClass2.Text);
			return new GClass70(-1, Class84.smethod_0(-994137822) + gClass2.Text);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994137785));
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
			List<string> list = new List<string>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994137704), mySqlConnection).ExecuteReader();
			if (mySqlDataReader.Read())
			{
				list.Add(mySqlDataReader[Class84.smethod_0(-994264162)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994137676)].ToString());
			}
			else
			{
				list.Add(Class84.smethod_0(-994274584));
				list.Add(string.Empty);
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994137694));
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
		MySqlTransaction mySqlTransaction = null;
		try
		{
			GClass70 gClass = smethod_1();
			if (gClass.Value < 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994137874));
			}
			string transactionId = gClass.Data.ToString();
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			bool flag = !text.Equals(Class84.smethod_0(-994274584));
			string empty = string.Empty;
			empty = ((!flag) ? Class84.smethod_0(-994261635) : Class84.smethod_0(-994261628));
			mySqlCommand.CommandText = empty;
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994261546), MySqlDbType.VarChar);
			mySqlCommand.Parameters[Class84.smethod_0(-994261546)].Value = text2;
			mySqlCommand.ExecuteNonQuery();
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class288
			{
				SchoolId = Class348.Class352.string_0,
				Op = (flag ? Class84.smethod_0(-994261516) : Class84.smethod_0(-994261563)),
				TransactionId = transactionId,
				Content = text2
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 gClass2;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_14(), Class84.smethod_0(-994265316), data);
				gClass2 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			if (gClass2.Value == 1)
			{
				mySqlTransaction.Commit();
				return new GClass70(1, Class84.smethod_0(-994247224));
			}
			mySqlTransaction.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994137662) + gClass2.Text);
			return new GClass70(-1, Class84.smethod_0(-994137625) + gClass2.Text);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994137537));
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
			List<string> list = new List<string>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994137517), mySqlConnection).ExecuteReader();
			if (mySqlDataReader.Read())
			{
				list.Add(mySqlDataReader[Class84.smethod_0(-994264162)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994137489)].ToString());
			}
			else
			{
				list.Add(Class84.smethod_0(-994274584));
				list.Add(string.Empty);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994261452));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994137443));
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
		MySqlTransaction mySqlTransaction = null;
		try
		{
			GClass70 gClass = smethod_1();
			if (gClass.Value < 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994137874));
			}
			string transactionId = gClass.Data.ToString();
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.Transaction = mySqlTransaction;
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string commandText = Class84.smethod_0(-994259229) + text + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class218
			{
				SchoolId = Class348.Class352.string_0,
				Op = Class84.smethod_0(-994255819),
				TransactionId = transactionId,
				IdRunText = text
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 gClass2;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_12(), Class84.smethod_0(-994265316), data);
				gClass2 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			if (gClass2.Value == 1)
			{
				mySqlTransaction.Commit();
				return new GClass70(1, Class84.smethod_0(-994247224));
			}
			mySqlTransaction.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994137414) + gClass2.Text);
			return new GClass70(-1, Class84.smethod_0(-994137381) + gClass2.Text);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994137360));
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
		MySqlTransaction mySqlTransaction = null;
		try
		{
			GClass70 gClass = smethod_1();
			if (gClass.Value < 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994137874));
			}
			string transactionId = gClass.Data.ToString();
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string value = list[3];
			string item;
			string item2;
			if (text.Equals(Class84.smethod_0(-994274584)))
			{
				string format = Class84.smethod_0(-994259804);
				int num = 0;
				do
				{
					text = Class211.smethod_1(10);
					mySqlCommand.CommandText = string.Format(format, text);
				}
				while (Convert.ToInt32(mySqlCommand.ExecuteScalar()) != 0);
				format = Class84.smethod_0(-994259739);
				mySqlCommand.CommandText = format;
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994259818), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994259833), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269814), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994259786), MySqlDbType.Int32);
				mySqlCommand.Parameters[Class84.smethod_0(-994259818)].Value = text;
				mySqlCommand.Parameters[Class84.smethod_0(-994259833)].Value = text2;
				mySqlCommand.Parameters[Class84.smethod_0(-994269814)].Value = value;
				mySqlCommand.Parameters[Class84.smethod_0(-994259786)].Value = text3;
				mySqlCommand.ExecuteNonQuery();
				Class320.smethod_5(JsonConvert.SerializeObject(new Class218
				{
					SchoolId = Class348.Class352.string_0,
					Op = Class84.smethod_0(-994270626),
					TransactionId = transactionId,
					IdRunText = text,
					RunText = text2,
					Urutan = text3
				}), Class320.int_5, 10000).Deconstruct(out item, out item2);
				string name = item;
				string value2 = item2;
				NameValueCollection data = new NameValueCollection { { name, value2 } };
				Class139 @class = new Class139(smethod_0());
				GClass70 gClass2;
				try
				{
					byte[] bytes = @class.UploadValues(Class272.smethod_12(), Class84.smethod_0(-994265316), data);
					gClass2 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
				}
				finally
				{
					((IDisposable)@class).Dispose();
				}
				if (gClass2.Value == 1)
				{
					mySqlTransaction.Commit();
					return new GClass70(1, Class84.smethod_0(-994247224));
				}
				mySqlTransaction.Rollback();
				gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994137328) + gClass2.Text);
				return new GClass70(-1, Class84.smethod_0(-994137294) + gClass2.Text);
			}
			mySqlCommand.CommandText = Class84.smethod_0(-994259915);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994259818), MySqlDbType.VarChar);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994259833), MySqlDbType.VarChar);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994259786), MySqlDbType.Int32);
			mySqlCommand.Parameters[Class84.smethod_0(-994259818)].Value = text;
			mySqlCommand.Parameters[Class84.smethod_0(-994259833)].Value = text2;
			mySqlCommand.Parameters[Class84.smethod_0(-994259786)].Value = text3;
			mySqlCommand.ExecuteNonQuery();
			Class320.smethod_5(JsonConvert.SerializeObject(new Class218
			{
				SchoolId = Class348.Class352.string_0,
				Op = Class84.smethod_0(-994270647),
				TransactionId = transactionId,
				IdRunText = text,
				RunText = text2,
				Urutan = text3
			}), Class320.int_5, 10000).Deconstruct(out item2, out item);
			string name2 = item2;
			string value3 = item;
			NameValueCollection data2 = new NameValueCollection { { name2, value3 } };
			Class139 class2 = new Class139(smethod_0());
			GClass70 gClass3;
			try
			{
				byte[] bytes2 = class2.UploadValues(Class272.smethod_12(), Class84.smethod_0(-994265316), data2);
				gClass3 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes2), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)class2).Dispose();
			}
			if (gClass3.Value == 1)
			{
				mySqlTransaction.Commit();
				return new GClass70(1, Class84.smethod_0(-994247224));
			}
			mySqlTransaction.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994137328) + gClass3.Text);
			return new GClass70(-1, Class84.smethod_0(-994137294) + gClass3.Text);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994137257));
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
			string cmdText = Class84.smethod_0(-994137248);
			List<List<string>> list = new List<List<string>>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(cmdText, mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994259459)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994260157)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994260111)].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994137097));
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
