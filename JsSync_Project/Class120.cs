using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

internal sealed class Class120
{
	private static readonly DateTime dateTime_0 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	public static int smethod_0(int int_0, int int_1)
	{
		switch (int_1)
		{
		case 2:
			return (int_0 % 4 == 0) ? 29 : 28;
		default:
			return 30;
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12:
			return 31;
		}
	}

	public static int smethod_1(int int_0, int int_1)
	{
		return smethod_0(int_0, int_1);
	}

	public static int smethod_2(int int_0)
	{
		int num = int_0 / 4;
		int num2 = int_0 - num;
		return num * 366 + num2 * 365;
	}

	public static long smethod_3(int int_0, int int_1, int int_2, int int_3, int int_4)
	{
		long num = int_4;
		num += int_3 * 60;
		num += int_2 * 24 * 60;
		for (int i = 1; i <= int_1; i++)
		{
			num += smethod_1(int_0, i) * 24 * 60;
		}
		return num + smethod_2(int_0) * 24 * 60;
	}

	public static long smethod_4(DateTime dateTime_1)
	{
		return smethod_3(dateTime_1.Year, dateTime_1.Month, dateTime_1.Day, dateTime_1.Hour, dateTime_1.Minute);
	}

	public static int smethod_5(string string_0)
	{
		int result = 0;
		int result2 = 0;
		if (string_0.IndexOf(':') < 0)
		{
			int.TryParse(string_0, out result);
			return result * 60;
		}
		string[] array = string_0.Split(':');
		int.TryParse(array[0], out result);
		int.TryParse(array[1], out result2);
		return result * 60 + result2;
	}

	public static int smethod_6(DateTime dateTime_1, DateTime dateTime_2)
	{
		long num = smethod_4(dateTime_1);
		long num2 = smethod_4(dateTime_2);
		if (num == num2)
		{
			return 0;
		}
		if (num < num2)
		{
			return -1;
		}
		return 1;
	}

	public static List<DateTime> smethod_7(DateTime dateTime_1, DateTime dateTime_2)
	{
		List<DateTime> list = new List<DateTime>();
		for (int i = dateTime_1.Year; i <= dateTime_2.Year; i++)
		{
			int num = ((i != dateTime_1.Year) ? 1 : dateTime_1.Month);
			int num2 = ((i == dateTime_2.Year) ? dateTime_2.Month : 12);
			for (int j = num; j <= num2; j++)
			{
				int num3 = ((i != dateTime_1.Year || j != dateTime_1.Month) ? 1 : dateTime_1.Day);
				int num4 = ((i != dateTime_2.Year || j != dateTime_2.Month) ? smethod_0(i, j) : dateTime_2.Day);
				for (int k = num3; k <= num4; k++)
				{
					list.Add(new DateTime(i, j, k));
				}
			}
		}
		return list;
	}

	public static string smethod_8(string string_0)
	{
		string_0 = string_0.Trim();
		if (string_0.Length != 1)
		{
			return string_0;
		}
		return Class84.smethod_0(-994274584) + string_0;
	}

	public static string smethod_9(int int_0, int int_1, int int_2)
	{
		return string.Format(Class84.smethod_0(-994092449), smethod_8(int_2.ToString()), smethod_18(int_1), int_0);
	}

	public static bool smethod_10(string string_0)
	{
		string_0 = string_0.Trim();
		if (string_0.IndexOf(Class84.smethod_0(-994263069)) < 0)
		{
			return false;
		}
		string[] array = string_0.Split(':');
		if (array.Length != 2)
		{
			return false;
		}
		if (Class241.smethod_4(array[1], 0, 59))
		{
			return Class241.smethod_4(array[0], 0, 23);
		}
		return false;
	}

	public static string smethod_11(DateTime dateTime_1)
	{
		return dateTime_1.Day + Class84.smethod_0(-994263061) + smethod_18(dateTime_1.Month) + Class84.smethod_0(-994263061) + dateTime_1.Year;
	}

	public static string smethod_12(string string_0)
	{
		string[] array = string_0.Split('-');
		if (array.Length != 3)
		{
			return string_0;
		}
		return array[2] + Class84.smethod_0(-994263061) + smethod_18(Convert.ToInt32(array[1])) + Class84.smethod_0(-994263061) + array[0];
	}

	public static string smethod_13(int int_0)
	{
		return int_0 switch
		{
			0 => Class84.smethod_0(-994212424), 
			1 => Class84.smethod_0(-994212428), 
			2 => Class84.smethod_0(-994212447), 
			3 => Class84.smethod_0(-994212388), 
			4 => Class84.smethod_0(-994212408), 
			5 => Class84.smethod_0(-994092479), 
			_ => Class84.smethod_0(-994212469), 
		};
	}

	public static string smethod_14(DayOfWeek dayOfWeek_0)
	{
		return dayOfWeek_0 switch
		{
			DayOfWeek.Monday => Class84.smethod_0(-994212424), 
			DayOfWeek.Tuesday => Class84.smethod_0(-994212428), 
			DayOfWeek.Wednesday => Class84.smethod_0(-994212447), 
			DayOfWeek.Thursday => Class84.smethod_0(-994212388), 
			DayOfWeek.Friday => Class84.smethod_0(-994212408), 
			DayOfWeek.Saturday => Class84.smethod_0(-994092479), 
			_ => Class84.smethod_0(-994212469), 
		};
	}

	public static string smethod_15(DateTime dateTime_1)
	{
		return dateTime_1.DayOfWeek switch
		{
			DayOfWeek.Sunday => Class84.smethod_0(-994212469), 
			DayOfWeek.Monday => Class84.smethod_0(-994212424), 
			DayOfWeek.Tuesday => Class84.smethod_0(-994212428), 
			DayOfWeek.Wednesday => Class84.smethod_0(-994212447), 
			DayOfWeek.Thursday => Class84.smethod_0(-994212388), 
			DayOfWeek.Friday => Class84.smethod_0(-994212408), 
			_ => Class84.smethod_0(-994092479), 
		};
	}

	public static string smethod_16(int int_0, int int_1, int int_2)
	{
		return smethod_15(new DateTime(int_0, int_1, int_2));
	}

	public static string smethod_17(string string_0)
	{
		string[] array = string_0.Split('-');
		if (array.Length != 3)
		{
			return string_0;
		}
		return smethod_15(new DateTime(Convert.ToInt32(array[0]), Convert.ToInt32(array[1]), Convert.ToInt32(array[2])));
	}

	public static string smethod_18(int int_0)
	{
		return int_0 switch
		{
			1 => Class84.smethod_0(-994092419), 
			2 => Class84.smethod_0(-994092437), 
			3 => Class84.smethod_0(-994092390), 
			4 => Class84.smethod_0(-994092394), 
			5 => Class84.smethod_0(-994092414), 
			6 => Class84.smethod_0(-994092356), 
			7 => Class84.smethod_0(-994092361), 
			8 => Class84.smethod_0(-994092382), 
			9 => Class84.smethod_0(-994092336), 
			10 => Class84.smethod_0(-994092352), 
			11 => Class84.smethod_0(-994092290), 
			12 => Class84.smethod_0(-994092307), 
			_ => string.Empty, 
		};
	}

	public static int smethod_19(string string_0)
	{
		string_0 = string_0.Trim().ToLower();
		if (string_0 != null)
		{
			switch (string_0.Length)
			{
			case 3:
				if (string_0 == Class84.smethod_0(-994092181))
				{
					return 5;
				}
				break;
			case 4:
				switch (string_0[2])
				{
				case 'n':
					if (string_0 == Class84.smethod_0(-994092187))
					{
						return 6;
					}
					break;
				case 'l':
					if (string_0 == Class84.smethod_0(-994092144))
					{
						return 7;
					}
					break;
				}
				break;
			case 5:
				switch (string_0[0])
				{
				case 'm':
					if (string_0 == Class84.smethod_0(-994092221))
					{
						return 3;
					}
					break;
				case 'a':
					if (string_0 == Class84.smethod_0(-994092161))
					{
						return 4;
					}
					break;
				}
				break;
			case 7:
				switch (string_0[0])
				{
				case 'o':
					if (string_0 == Class84.smethod_0(-994092232))
					{
						return 10;
					}
					break;
				case 'j':
					if (string_0 == Class84.smethod_0(-994092260))
					{
						return 1;
					}
					break;
				case 'a':
					if (string_0 == Class84.smethod_0(-994092278))
					{
						return 8;
					}
					break;
				}
				break;
			case 8:
				switch (string_0[0])
				{
				case 'n':
					if (string_0 == Class84.smethod_0(-994092251))
					{
						return 11;
					}
					break;
				case 'f':
					if (string_0 == Class84.smethod_0(-994092234))
					{
						return 2;
					}
					break;
				case 'd':
					if (string_0 == Class84.smethod_0(-994092204))
					{
						return 12;
					}
					break;
				}
				break;
			case 9:
				if (string_0 == Class84.smethod_0(-994092149))
				{
					return 9;
				}
				break;
			}
		}
		return 0;
	}

	public static DateTime smethod_20(string string_0, int int_0, string string_1)
	{
		return new DateTime(smethod_24(string_0), int_0, smethod_24(string_1));
	}

	public static DateTime smethod_21(string string_0)
	{
		string_0 = string_0.Trim();
		if (string_0.IndexOf(Class84.smethod_0(-994278690), StringComparison.Ordinal) < 0)
		{
			return new DateTime(1970, 1, 1);
		}
		string[] array = string_0.Split('-');
		if (array.Length != 3)
		{
			return new DateTime(1970, 1, 1);
		}
		string text = array[0];
		string text2 = array[1];
		string text3 = array[2];
		if (Class256.smethod_0(text) && Class256.smethod_8(text2) && Class256.smethod_7(text3))
		{
			int year = Convert.ToInt32(text);
			int month = Convert.ToInt32(text2);
			int day = Convert.ToInt32(text3);
			return new DateTime(year, month, day);
		}
		return new DateTime(1970, 1, 1);
	}

	public static DateTime smethod_22(string string_0)
	{
		string_0 = string_0.Trim();
		if (string_0.IndexOf(Class84.smethod_0(-994278690), StringComparison.Ordinal) < 0)
		{
			return new DateTime(1970, 1, 1);
		}
		if (string_0.IndexOf(Class84.smethod_0(-994263069), StringComparison.Ordinal) < 0)
		{
			return new DateTime(1970, 1, 1);
		}
		if (string_0.IndexOf(Class84.smethod_0(-994263061), StringComparison.Ordinal) < 0)
		{
			return new DateTime(1970, 1, 1);
		}
		string[] array = string_0.Split(' ');
		if (array.Length != 2)
		{
			return new DateTime(1970, 1, 1);
		}
		string text = array[0].Trim();
		string text2 = array[1].Trim();
		if (text.IndexOf(Class84.smethod_0(-994278690), StringComparison.Ordinal) < 0)
		{
			return new DateTime(1970, 1, 1);
		}
		array = text.Split('-');
		if (array.Length != 3)
		{
			return new DateTime(1970, 1, 1);
		}
		string text3 = array[0];
		string text4 = array[1];
		string text5 = array[2];
		if (Class256.smethod_0(text3) && Class256.smethod_8(text4) && Class256.smethod_7(text5))
		{
			int year = Convert.ToInt32(text3);
			int month = Convert.ToInt32(text4);
			int day = Convert.ToInt32(text5);
			if (text2.IndexOf(Class84.smethod_0(-994263069), StringComparison.Ordinal) < 0)
			{
				return new DateTime(1970, 1, 1);
			}
			array = text2.Split(':');
			if (array.Length != 3)
			{
				return new DateTime(1970, 1, 1);
			}
			string text6 = array[0];
			string text7 = array[1];
			string text8 = array[2];
			if (Class256.smethod_5(text6) && Class256.smethod_10(text7) && Class256.smethod_6(text8))
			{
				int hour = Convert.ToInt32(text6);
				int minute = Convert.ToInt32(text7);
				int second = Convert.ToInt32(text8);
				return new DateTime(year, month, day, hour, minute, second);
			}
			return new DateTime(1970, 1, 1);
		}
		return new DateTime(1970, 1, 1);
	}

	public static float smethod_23(DateTime dateTime_1, DateTime dateTime_2)
	{
		long num = smethod_4(dateTime_1);
		return (float)(smethod_4(dateTime_2) - num) / 1440f;
	}

	private static int smethod_24(string string_0)
	{
		int.TryParse(string_0, out var result);
		return result;
	}

	public static void smethod_25(string string_0, string string_1, ref int int_0, ref int int_1, ref int int_2)
	{
		if (string_0.IndexOf(Class84.smethod_0(-994263069)) < 0)
		{
			string_0 += Class84.smethod_0(-994092101);
		}
		if (string_1.IndexOf(Class84.smethod_0(-994263069)) < 0)
		{
			string_1 += Class84.smethod_0(-994092101);
		}
		string[] array = string_0.Split(':');
		string[] array2 = string_1.Split(':');
		int[] array3 = ((array.Length != 3) ? new int[3]
		{
			smethod_24(array[0]),
			smethod_24(array[1]),
			0
		} : new int[3]
		{
			smethod_24(array[0]),
			smethod_24(array[1]),
			smethod_24(array[2])
		});
		int[] array4 = ((array2.Length != 3) ? new int[3]
		{
			smethod_24(array2[0]),
			smethod_24(array2[1]),
			0
		} : new int[3]
		{
			smethod_24(array2[0]),
			smethod_24(array2[1]),
			smethod_24(array2[2])
		});
		if (array3[0] * 3600 + array3[1] * 60 + array3[2] > array4[0] * 3600 + array4[1] * 60 + array4[2])
		{
			int[] array5 = array3;
			array3 = array4;
			array4 = array5;
		}
		int num = 0;
		int num2 = array4[2] - array3[2];
		if (num2 < 0)
		{
			int_2 = 60 + num2;
			num = 1;
		}
		else
		{
			int_2 = num2;
		}
		int num3 = 0;
		num2 = array4[1] - array3[1];
		if (num2 < 0)
		{
			int_1 = 60 + num2;
			num3 = 1;
		}
		else
		{
			int_1 = num2;
		}
		int_1 -= num;
		if (int_1 < 0)
		{
			int_1 = 60 + int_1;
			num3 = 1;
		}
		int_0 = array4[0] - array3[0];
		int_0 -= num3;
	}

	public static string smethod_26(int int_0, int int_1, int int_2)
	{
		if (int_2 > 60)
		{
			int_1 += int_2 / 60;
			int_2 %= 60;
		}
		string arg = int_2.ToString().PadLeft(2, '0');
		if (int_1 > 60)
		{
			int_0 += int_1 / 60;
			int_1 %= 60;
		}
		string arg2 = int_1.ToString().PadLeft(2, '0');
		string arg3 = int_0.ToString().PadLeft(2, '0');
		return string.Format(Class84.smethod_0(-994270449), arg3, arg2, arg);
	}

	public static void smethod_27(int int_0, int int_1, int int_2, int int_3, ref int int_4, ref int int_5, ref int int_6)
	{
		if (int_3 == 0)
		{
			int_4 = 0;
			int_5 = 0;
			int_6 = 0;
			return;
		}
		if (int_2 > 60)
		{
			int_1 += int_2 / 60;
			int_2 %= 60;
		}
		if (int_1 > 60)
		{
			int_0 += int_1 / 60;
			int_1 %= 60;
		}
		int_6 = int_2 / int_3;
		int_5 = int_1 / int_3;
		int_4 = int_0 / int_3;
	}

	public static string smethod_28(int int_0)
	{
		int num = 0;
		if (int_0 > 60)
		{
			num = int_0 / 60;
			int_0 %= 60;
		}
		string arg = int_0.ToString().PadLeft(2, '0');
		string arg2 = num.ToString().PadLeft(2, '0');
		return string.Format(Class84.smethod_0(-994092120), arg2, arg);
	}

	public static Dictionary<int, List<Tuple<int, int, int>>> smethod_29(int int_0, int int_1)
	{
		int num = smethod_0(int_1, int_0);
		int dayOfWeek = (int)new DateTime(int_1, int_0, 1).DayOfWeek;
		int num2 = ((int_0 == 1) ? 12 : (int_0 - 1));
		int num3 = ((int_0 == 1) ? (int_1 - 1) : int_1);
		int num4 = smethod_0(num3, num2);
		int item = ((int_0 == 12) ? 1 : (int_0 + 1));
		int item2 = ((int_0 == 12) ? (int_1 + 1) : int_1);
		int num5 = 0;
		Dictionary<int, List<Tuple<int, int, int>>> dictionary = new Dictionary<int, List<Tuple<int, int, int>>>();
		dictionary.Add(0, new List<Tuple<int, int, int>>());
		List<Tuple<int, int, int>> list = dictionary[0];
		switch (dayOfWeek)
		{
		case 0:
		{
			num5 = num4 - 6;
			for (int j = 1; j <= 6; j++)
			{
				num5++;
				Tuple<int, int, int> item4 = new Tuple<int, int, int>(num5, num2, num3);
				list.Add(item4);
			}
			break;
		}
		default:
		{
			num5 = num4 - (dayOfWeek - 1);
			for (int i = 1; i <= dayOfWeek - 1; i++)
			{
				num5++;
				Tuple<int, int, int> item3 = new Tuple<int, int, int>(num5, num2, num3);
				list.Add(item3);
			}
			break;
		}
		case 1:
			break;
		}
		num5 = 0;
		int count = list.Count;
		for (int num6 = 7; num6 > count; num6--)
		{
			num5++;
			Tuple<int, int, int> item5 = new Tuple<int, int, int>(num5, int_0, int_1);
			list.Add(item5);
		}
		for (int k = 1; k < 4; k++)
		{
			dictionary.Add(k, new List<Tuple<int, int, int>>());
			list = dictionary[k];
			for (int l = 1; l <= 7; l++)
			{
				num5++;
				Tuple<int, int, int> item6 = new Tuple<int, int, int>(num5, int_0, int_1);
				list.Add(item6);
			}
		}
		if (num5 != num)
		{
			dictionary.Add(4, new List<Tuple<int, int, int>>());
			list = dictionary[4];
			for (int m = num5 + 1; m <= num; m++)
			{
				Tuple<int, int, int> item7 = new Tuple<int, int, int>(m, int_0, int_1);
				list.Add(item7);
				if (list.Count == 7)
				{
					dictionary.Add(5, new List<Tuple<int, int, int>>());
					list = dictionary[5];
				}
			}
			num5 = 0;
			for (int n = list.Count + 1; n <= 7; n++)
			{
				num5++;
				Tuple<int, int, int> item8 = new Tuple<int, int, int>(num5, item, item2);
				list.Add(item8);
			}
		}
		return dictionary;
	}

	public static long smethod_30()
	{
		return (long)(DateTime.UtcNow - dateTime_0).TotalMilliseconds;
	}

	public static string smethod_31(MySqlConnection mySqlConnection_0, string string_0)
	{
		try
		{
			return new MySqlCommand(Class84.smethod_0(-994092122), mySqlConnection_0).ExecuteScalar().ToString();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994092053), ex.Message, ex);
			return string_0;
		}
	}
}
