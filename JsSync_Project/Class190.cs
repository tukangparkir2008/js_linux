using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

internal sealed class Class190
{
	private static readonly int int_0 = 33;

	private static Random random_0;

	private static readonly string[] string_0 = new string[12]
	{
		Class84.smethod_0(-994103511),
		Class84.smethod_0(-994103464),
		Class84.smethod_0(-994103465),
		Class84.smethod_0(-994103482),
		Class84.smethod_0(-994103435),
		Class84.smethod_0(-994103452),
		Class84.smethod_0(-994103405),
		Class84.smethod_0(-994103422),
		Class84.smethod_0(-994103375),
		Class84.smethod_0(-994103392),
		Class84.smethod_0(-994103329),
		Class84.smethod_0(-994103346)
	};

	public static string smethod_0(int int_1)
	{
		if (random_0 == null)
		{
			random_0 = new Random();
		}
		string text = string.Empty;
		for (int i = 0; i < int_1; i++)
		{
			int startIndex = random_0.Next(0, int_0 - 1);
			text += Class84.smethod_0(-994103299).Substring(startIndex, 1);
		}
		return text;
	}

	private static void smethod_1(MySqlConnection mySqlConnection_0)
	{
		MySqlCommand mySqlCommand = new MySqlCommand
		{
			Connection = mySqlConnection_0
		};
		string commandText = Class84.smethod_0(-994107371);
		mySqlCommand.CommandText = commandText;
		if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
		{
			commandText = Class84.smethod_0(-994107202);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994107034);
			string arg = Class84.smethod_0(-994106870);
			string arg2 = smethod_0(64);
			mySqlCommand.CommandText = string.Format(commandText, arg, arg2);
			mySqlCommand.ExecuteNonQuery();
			arg = Class84.smethod_0(-994106874);
			arg2 = smethod_0(64);
			mySqlCommand.CommandText = string.Format(commandText, arg, arg2);
			mySqlCommand.ExecuteNonQuery();
			arg = Class84.smethod_0(-994106830);
			arg2 = smethod_0(64);
			mySqlCommand.CommandText = string.Format(commandText, arg, arg2);
			mySqlCommand.ExecuteNonQuery();
			arg = Class84.smethod_0(-994106834);
			arg2 = smethod_0(64);
			mySqlCommand.CommandText = string.Format(commandText, arg, arg2);
			mySqlCommand.ExecuteNonQuery();
			arg = Class84.smethod_0(-994106790);
			arg2 = smethod_0(64);
			mySqlCommand.CommandText = string.Format(commandText, arg, arg2);
			mySqlCommand.ExecuteNonQuery();
			arg = Class84.smethod_0(-994106794);
			arg2 = smethod_0(64);
			mySqlCommand.CommandText = string.Format(commandText, arg, arg2);
			mySqlCommand.ExecuteNonQuery();
			arg = Class84.smethod_0(-994106814);
			arg2 = smethod_0(64);
			mySqlCommand.CommandText = string.Format(commandText, arg, arg2);
			mySqlCommand.ExecuteNonQuery();
			arg = Class84.smethod_0(-994106754);
			arg2 = smethod_0(64);
			mySqlCommand.CommandText = string.Format(commandText, arg, arg2);
			mySqlCommand.ExecuteNonQuery();
		}
	}

	private static void smethod_2(MySqlConnection mySqlConnection_0)
	{
		MySqlCommand mySqlCommand = new MySqlCommand
		{
			Connection = mySqlConnection_0,
			CommandText = Class84.smethod_0(-994106774)
		};
		mySqlCommand.ExecuteNonQuery();
		string[] array = string_0;
		foreach (string string_ in array)
		{
			mySqlCommand.CommandText = smethod_12(string_);
			mySqlCommand.ExecuteNonQuery();
		}
	}

	private static string[] smethod_3(MySqlCommand mySqlCommand_0, string string_1)
	{
		string[] array = new string[9];
		mySqlCommand_0.CommandText = string_1;
		mySqlCommand_0.ExecuteNonQuery();
		array[0] = mySqlCommand_0.Parameters[Class84.smethod_0(-994106726)].Value.ToString();
		array[1] = mySqlCommand_0.Parameters[Class84.smethod_0(-994106731)].Value.ToString();
		array[2] = mySqlCommand_0.Parameters[Class84.smethod_0(-994106752)].Value.ToString();
		array[3] = mySqlCommand_0.Parameters[Class84.smethod_0(-994106693)].Value.ToString();
		array[4] = mySqlCommand_0.Parameters[Class84.smethod_0(-994106698)].Value.ToString();
		array[5] = mySqlCommand_0.Parameters[Class84.smethod_0(-994106719)].Value.ToString();
		array[6] = mySqlCommand_0.Parameters[Class84.smethod_0(-994106660)].Value.ToString();
		array[7] = mySqlCommand_0.Parameters[Class84.smethod_0(-994106665)].Value.ToString();
		array[8] = mySqlCommand_0.Parameters[Class84.smethod_0(-994106686)].Value.ToString();
		return array;
	}

	public static void smethod_4(MySqlConnection mySqlConnection_0)
	{
		MySqlCommand mySqlCommand = new MySqlCommand
		{
			Connection = mySqlConnection_0
		};
		int num = 0;
		string[] array = string_0;
		foreach (string arg in array)
		{
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994106627), arg);
			num += Convert.ToInt32(mySqlCommand.ExecuteScalar());
		}
		switch (num)
		{
		case 0:
			smethod_2(mySqlConnection_0);
			smethod_1(mySqlConnection_0);
			break;
		default:
			throw new Exception(Class84.smethod_0(-994106523));
		case 12:
			break;
		}
	}

	public static int smethod_5(MySqlConnection mySqlConnection_0)
	{
		int result = 0;
		string commandText = Class84.smethod_0(-994106434);
		MySqlDataReader mySqlDataReader = new MySqlCommand
		{
			CommandText = commandText,
			Connection = mySqlConnection_0
		}.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			result = Convert.ToInt32(mySqlDataReader[1]);
		}
		mySqlDataReader.Close();
		return result;
	}

	public static int smethod_6()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			return smethod_5(mySqlConnection);
		}
		catch (Exception ex)
		{
			Class125.smethod_0(Class84.smethod_0(-994106419), ex.Message, ex);
			return 0;
		}
		finally
		{
			mySqlConnection.Close();
			mySqlConnection.Dispose();
		}
	}

	public static string smethod_7()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			return smethod_9(mySqlConnection);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994106398), ex.Message, ex);
			return string.Empty;
		}
		finally
		{
			mySqlConnection.Close();
			mySqlConnection.Dispose();
		}
	}

	public static string smethod_8(MySqlConnection mySqlConnection_0)
	{
		try
		{
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection_0
			};
			string commandText = Class84.smethod_0(-994106367);
			mySqlCommand.CommandText = commandText;
			int item = Convert.ToInt32(mySqlCommand.ExecuteScalar());
			commandText = Class84.smethod_0(-994106273);
			mySqlCommand.CommandText = commandText;
			int item2 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
			commandText = Class84.smethod_0(-994106258);
			mySqlCommand.CommandText = commandText;
			int item3 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
			commandText = Class84.smethod_0(-994106191);
			mySqlCommand.CommandText = commandText;
			int item4 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
			commandText = Class84.smethod_0(-994106161);
			mySqlCommand.CommandText = commandText;
			int item5 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
			commandText = Class84.smethod_0(-994106095);
			mySqlCommand.CommandText = commandText;
			int item6 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
			commandText = Class84.smethod_0(-994106079);
			mySqlCommand.CommandText = commandText;
			int item7 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
			commandText = Class84.smethod_0(-994106000);
			mySqlCommand.CommandText = commandText;
			int item8 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
			commandText = Class84.smethod_0(-994105981);
			mySqlCommand.CommandText = commandText;
			int item9 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
			commandText = Class84.smethod_0(-994105889);
			mySqlCommand.CommandText = commandText;
			int item10 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
			commandText = Class84.smethod_0(-994105836);
			mySqlCommand.CommandText = commandText;
			int item11 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
			commandText = Class84.smethod_0(-994105778);
			mySqlCommand.CommandText = commandText;
			int item12 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
			commandText = Class84.smethod_0(-994105727);
			mySqlCommand.CommandText = commandText;
			int item13 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
			Random random = new Random();
			Tuple<string, string> tuple = Class320.smethod_5(JsonConvert.SerializeObject(new List<int>
			{
				random.Next(100, 999),
				item,
				item2,
				item3,
				item4,
				item5,
				item8,
				item9,
				item6,
				item7,
				item10,
				item11,
				item12,
				item13,
				random.Next(100, 999)
			}), Class320.int_2, 90000);
			return tuple.Item1 + tuple.Item2;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return string.Empty;
		}
	}

	public static string smethod_9(MySqlConnection mySqlConnection_0)
	{
		string empty = string.Empty;
		MySqlCommand mySqlCommand = new MySqlCommand
		{
			Connection = mySqlConnection_0,
			CommandText = Class84.smethod_0(-994106774)
		};
		mySqlCommand.ExecuteNonQuery();
		mySqlCommand.CommandText = Class84.smethod_0(-994105657);
		if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
		{
			return string.Empty;
		}
		smethod_4(mySqlConnection_0);
		mySqlCommand.CommandType = CommandType.StoredProcedure;
		mySqlCommand.Parameters.Add(Class84.smethod_0(-994106726), MySqlDbType.String).Direction = ParameterDirection.Output;
		mySqlCommand.Parameters.Add(Class84.smethod_0(-994106731), MySqlDbType.String).Direction = ParameterDirection.Output;
		mySqlCommand.Parameters.Add(Class84.smethod_0(-994106752), MySqlDbType.String).Direction = ParameterDirection.Output;
		mySqlCommand.Parameters.Add(Class84.smethod_0(-994106693), MySqlDbType.String).Direction = ParameterDirection.Output;
		mySqlCommand.Parameters.Add(Class84.smethod_0(-994106698), MySqlDbType.String).Direction = ParameterDirection.Output;
		mySqlCommand.Parameters.Add(Class84.smethod_0(-994106719), MySqlDbType.String).Direction = ParameterDirection.Output;
		mySqlCommand.Parameters.Add(Class84.smethod_0(-994106660), MySqlDbType.String).Direction = ParameterDirection.Output;
		mySqlCommand.Parameters.Add(Class84.smethod_0(-994106665), MySqlDbType.String).Direction = ParameterDirection.Output;
		mySqlCommand.Parameters.Add(Class84.smethod_0(-994106686), MySqlDbType.String).Direction = ParameterDirection.Output;
		string text = Class282.smethod_5(smethod_3(mySqlCommand, Class84.smethod_0(-994105518))[2]);
		empty += text.Substring(6, 1);
		text = Class282.smethod_5(smethod_3(mySqlCommand, Class84.smethod_0(-994105529))[3]);
		empty += text.Substring(13, 1);
		text = Class282.smethod_5(smethod_3(mySqlCommand, Class84.smethod_0(-994105492))[6]);
		empty += text.Substring(20, 1);
		text = Class282.smethod_5(smethod_3(mySqlCommand, Class84.smethod_0(-994105455))[1]);
		empty += text.Substring(27, 1);
		text = Class282.smethod_5(smethod_3(mySqlCommand, Class84.smethod_0(-994105466))[8]);
		empty += text.Substring(34, 1);
		return empty.ToUpper();
	}

	public static DateTime smethod_10()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			return smethod_11(mySqlConnection);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994105429), ex.Message, ex);
			return DateTime.Now;
		}
		finally
		{
			mySqlConnection.Close();
			mySqlConnection.Dispose();
		}
	}

	public static DateTime smethod_11(MySqlConnection mySqlConnection_0)
	{
		int year = 1970;
		int month = 1;
		int day = 1;
		int hour = 12;
		int minute = 0;
		int second = 0;
		MySqlDataReader mySqlDataReader = new MySqlCommand
		{
			Connection = mySqlConnection_0,
			CommandText = Class84.smethod_0(-994105396)
		}.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			year = Convert.ToInt32(mySqlDataReader[0]);
			month = Convert.ToInt32(mySqlDataReader[1]);
			day = Convert.ToInt32(mySqlDataReader[2]);
			hour = Convert.ToInt32(mySqlDataReader[3]);
			minute = Convert.ToInt32(mySqlDataReader[4]);
			second = Convert.ToInt32(mySqlDataReader[5]);
		}
		mySqlDataReader.Close();
		return new DateTime(year, month, day, hour, minute, second);
	}

	public static string smethod_12(string string_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(Class84.smethod_0(-994093009) + string_1 + Class84.smethod_0(-994092933));
		stringBuilder.AppendLine(Class84.smethod_0(-994092940));
		stringBuilder.AppendLine(Class84.smethod_0(-994092881));
		stringBuilder.AppendLine(Class84.smethod_0(-994092774));
		stringBuilder.AppendLine(Class84.smethod_0(-994092715));
		stringBuilder.AppendLine(string.Concat(str1: Class282.smethod_4(smethod_0(64)), str0: Class84.smethod_0(-994092735), str2: Class84.smethod_0(-994092683)));
		stringBuilder.AppendLine(string.Concat(str1: Class282.smethod_4(smethod_0(64)), str0: Class84.smethod_0(-994092690), str2: Class84.smethod_0(-994092683)));
		stringBuilder.AppendLine(string.Concat(str1: Class282.smethod_4(smethod_0(64)), str0: Class84.smethod_0(-994092654), str2: Class84.smethod_0(-994092683)));
		stringBuilder.AppendLine(string.Concat(str1: Class282.smethod_4(smethod_0(64)), str0: Class84.smethod_0(-994092666), str2: Class84.smethod_0(-994092683)));
		stringBuilder.AppendLine(string.Concat(str1: Class282.smethod_4(smethod_0(64)), str0: Class84.smethod_0(-994092630), str2: Class84.smethod_0(-994092683)));
		stringBuilder.AppendLine(string.Concat(str1: Class282.smethod_4(smethod_0(64)), str0: Class84.smethod_0(-994092578), str2: Class84.smethod_0(-994092683)));
		stringBuilder.AppendLine(string.Concat(str1: Class282.smethod_4(smethod_0(64)), str0: Class84.smethod_0(-994092606), str2: Class84.smethod_0(-994092683)));
		stringBuilder.AppendLine(string.Concat(str1: Class282.smethod_4(smethod_0(64)), str0: Class84.smethod_0(-994092554), str2: Class84.smethod_0(-994092683)));
		stringBuilder.AppendLine(string.Concat(str1: Class282.smethod_4(smethod_0(64)), str0: Class84.smethod_0(-994092518), str2: Class84.smethod_0(-994092683)));
		stringBuilder.AppendLine(Class84.smethod_0(-994092530));
		return stringBuilder.ToString();
	}
}
