using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

internal sealed class Class348
{
	public sealed class Class349
	{
		public static bool bool_0;

		public static DateTime smethod_0()
		{
			DateTime result = DateTime.Now;
			MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
			try
			{
				mySqlConnection.Open();
				string commandText = Class84.smethod_0(-994289482);
				MySqlDataReader mySqlDataReader = new MySqlCommand
				{
					Connection = mySqlConnection,
					CommandText = commandText
				}.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					int year = Convert.ToInt32(mySqlDataReader[0]);
					int month = Convert.ToInt32(mySqlDataReader[1]);
					int day = Convert.ToInt32(mySqlDataReader[2]);
					int hour = Convert.ToInt32(mySqlDataReader[3]);
					int minute = Convert.ToInt32(mySqlDataReader[4]);
					int second = Convert.ToInt32(mySqlDataReader[5]);
					result = new DateTime(year, month, day, hour, minute, second);
				}
				mySqlDataReader.Close();
				return result;
			}
			catch (Exception ex)
			{
				Class125.smethod_1(Class84.smethod_0(-994289388), ex.Message, ex);
				return DateTime.Now;
			}
			finally
			{
				mySqlConnection.Close();
			}
		}
	}

	public sealed class Class350
	{
		public static bool bool_0;

		public static string string_0;

		public static DateTime dateTime_0 = DateTime.Now;
	}

	public sealed class Class351
	{
		public static bool bool_0;
	}

	public sealed class Class352
	{
		private static bool bool_0;

		private static bool bool_1;

		public static bool bool_2 = false;

		public static string string_0 = string.Empty;

		public static string string_1 = string.Empty;

		public static string string_2 = string.Empty;

		public static string string_3 = string.Empty;

		public static string string_4 = string.Empty;

		public static string string_5 = string.Empty;

		public static string string_6 = string.Empty;

		public static int int_0 = 0;

		public static int int_1 = 0;

		public static string string_7 = string.Empty;

		public static DateTime dateTime_0 = DateTime.Now;

		public static int int_2;

		public static List<List<string>> list_0;

		public static bool smethod_0()
		{
			return bool_0;
		}

		private static void smethod_1(bool bool_3)
		{
			bool_0 = bool_3;
		}

		public static bool smethod_2()
		{
			return bool_1;
		}

		private static void smethod_3(bool bool_3)
		{
			bool_1 = bool_3;
		}

		public static void smethod_4()
		{
			Class324.smethod_0().method_57(Class324.smethod_2(), "D/=-.BkV:#", null);
		}

		public static void smethod_5()
		{
			string_0 = string.Empty;
			string_1 = string.Empty;
			string_2 = string.Empty;
			string_3 = string.Empty;
			string_4 = string.Empty;
			string_5 = string.Empty;
			string_6 = string.Empty;
			int_0 = 0;
			int_1 = 0;
			string_7 = string.Empty;
			dateTime_0 = DateTime.Now;
			int_2 = 0;
		}

		public static string smethod_6()
		{
			if (int_1 == 1)
			{
				return Class84.smethod_0(-994289253);
			}
			if (int_1 == 2)
			{
				return Class84.smethod_0(-994289224);
			}
			if (int_1 == 3)
			{
				return Class84.smethod_0(-994289247);
			}
			if (int_1 == 4)
			{
				return Class84.smethod_0(-994289206);
			}
			return Class84.smethod_0(-994278690);
		}
	}

	public sealed class Class353
	{
		public static string string_0 = Class84.smethod_0(-994302068);

		public static string string_1 = Class84.smethod_0(-994302042);

		public static string string_2 = Class84.smethod_0(-994289595);

		public static string string_3 = Class84.smethod_0(-994289366);

		public static string string_4 = string.Empty;

		public static string string_5 = string.Empty;
	}

	public sealed class Class354
	{
		public static bool bool_0;

		public static bool bool_1;
	}
}
