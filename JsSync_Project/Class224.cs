using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using MySql.Data.MySqlClient;

internal sealed class Class224
{
	public sealed class Class225
	{
		public static Dictionary<string, Class230> dictionary_0 = new Dictionary<string, Class230>();

		private static void smethod_0(string string_0, string string_1, string string_2, int int_0)
		{
			dictionary_0.Add(string_0, new Class230(string_1, string_2, int_0));
		}

		public static void smethod_1()
		{
			dictionary_0.Clear();
			smethod_0(Class84.smethod_0(-994300302), Class84.smethod_0(-994300308), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994300229), Class84.smethod_0(-994300235), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994300207), Class84.smethod_0(-994300213), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994300182), Class84.smethod_0(-994300188), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994300157), Class84.smethod_0(-994300099), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994300079), Class84.smethod_0(-994300085), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994300053), Class84.smethod_0(-994300059), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994299974), Class84.smethod_0(-994299980), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994299963), Class84.smethod_0(-994299920), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303983), Class84.smethod_0(-994303989), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303956), Class84.smethod_0(-994303961), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303876), Class84.smethod_0(-994303881), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303860), Class84.smethod_0(-994303865), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303797), Class84.smethod_0(-994303802), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303727), Class84.smethod_0(-994303732), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303697), Class84.smethod_0(-994303654), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303675), Class84.smethod_0(-994303632), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303599), Class84.smethod_0(-994303604), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303562), Class84.smethod_0(-994303583), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303551), Class84.smethod_0(-994303492), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303517), Class84.smethod_0(-994303458), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303481), Class84.smethod_0(-994303439), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994303393), Class84.smethod_0(-994303415), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994303383), Class84.smethod_0(-994303389), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994303347), Class84.smethod_0(-994303353), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994303325), Class84.smethod_0(-994303267), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994303238), Class84.smethod_0(-994303244), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994303210), Class84.smethod_0(-994303232), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303188), Class84.smethod_0(-994303194), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303108), Class84.smethod_0(-994303114), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994303096), Class84.smethod_0(-994303102), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994303010), Class84.smethod_0(-994303032), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994303002), Class84.smethod_0(-994302960), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994302922), Class84.smethod_0(-994302944), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994302860), Class84.smethod_0(-994302866), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994302800), Class84.smethod_0(-994302806), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994302783), Class84.smethod_0(-994302725), Class84.smethod_0(-994299959), 1);
			smethod_0(Class84.smethod_0(-994302700), Class84.smethod_0(-994302705), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994302674), Class84.smethod_0(-994302631), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994302595), Class84.smethod_0(-994302616), Class84.smethod_0(-994300277), 1);
			smethod_0(Class84.smethod_0(-994302577), Class84.smethod_0(-994302534), Class84.smethod_0(-994300277), 1);
			smethod_2();
		}

		private static void smethod_2()
		{
			MySqlConnection mySqlConnection = new MySqlConnection(Class228.smethod_0());
			try
			{
				mySqlConnection.Open();
				MySqlCommand mySqlCommand = new MySqlCommand
				{
					Connection = mySqlConnection
				};
				string format = Class84.smethod_0(-994302501);
				string format2 = Class84.smethod_0(-994302445);
				foreach (string key in dictionary_0.Keys)
				{
					mySqlCommand.CommandText = string.Format(format, key);
					if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
					{
						mySqlCommand.CommandText = string.Format(format2, key, dictionary_0[key].int_0);
						mySqlCommand.ExecuteNonQuery();
					}
				}
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

		public static void smethod_3()
		{
			MySqlConnection mySqlConnection = new MySqlConnection(Class228.smethod_0());
			try
			{
				mySqlConnection.Open();
				MySqlCommand mySqlCommand = new MySqlCommand
				{
					Connection = mySqlConnection
				};
				string format = Class84.smethod_0(-994302385);
				foreach (string key in dictionary_0.Keys)
				{
					mySqlCommand.CommandText = string.Format(format, key);
					MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
					if (mySqlDataReader.Read())
					{
						dictionary_0[key].int_0 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994276441)]);
					}
					mySqlDataReader.Close();
				}
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
	}

	public sealed class Class226
	{
		public static int int_0 = 60000;

		public static int int_1 = 3000;

		public static int int_2 = 180000;

		public static int int_3 = 180000;

		public static int int_4 = 600000;

		public static int int_5 = 60000;

		public static int int_6 = 3;

		public static int int_7 = 7500;

		public static int int_8 = 2500;

		public static readonly int int_9 = 2700000;

		public static readonly int int_10 = 30000;

		public static int int_11 = 2000;

		public static readonly int int_12 = 15000;

		public static readonly string string_0 = Class84.smethod_0(-994289545);

		public static readonly string string_1 = Class84.smethod_0(-994289562);

		public static bool bool_0 = false;

		public static string string_2 = string.Empty;

		public static int int_13 = 102400;

		public static int int_14 = 47185920;

		public static int int_15 = 5000;

		public static int int_16 = 5000;

		public static int int_17 = 15;

		public static int int_18 = 0;

		public static readonly Font font_0 = new Font(Class84.smethod_0(-994268815), 12f);

		public static string string_3 = Class84.smethod_0(-994289524);

		public static int int_19 = 25;
	}

	public sealed class Class227
	{
		public static string string_0 = Class84.smethod_0(-994300418);

		public static string string_1 = Class84.smethod_0(-994300403);

		public static string string_2 = Class84.smethod_0(-994300409);

		public static string string_3 = Class84.smethod_0(-994300375);

		public static string string_4 = Class84.smethod_0(-994300375);

		public static string string_5 = Class84.smethod_0(-994300380);

		public static string string_6 = Class84.smethod_0(-994300334);

		public static string string_7 = Class84.smethod_0(-994300340);

		public static string string_8 = Class84.smethod_0(-994300346);

		public static int int_0 = 2022;

		public static string smethod_0()
		{
			return string_0 + Class84.smethod_0(-994263061) + string_1 + Class84.smethod_0(-994272055) + string_4;
		}
	}

	public sealed class Class228
	{
		public static bool bool_0;

		public static string string_0 = Class84.smethod_0(-994302332);

		public static string string_1 = Class84.smethod_0(-994302281);

		public static string string_2 = Class84.smethod_0(-994302302);

		public static string string_3 = Class84.smethod_0(-994302243);

		public static string string_4 = Class84.smethod_0(-994302257);

		public static string string_5 = string.Empty;

		public static string smethod_0()
		{
			return string.Format(Class84.smethod_0(-994302213), string_0, string_1, string_2, string_3, string_4);
		}

		public static string smethod_1()
		{
			return string_0 + Class84.smethod_0(-994263069) + string_1;
		}
	}

	public sealed class Class229
	{
		public static string string_0 = Class84.smethod_0(-994247595);

		public static readonly int int_0 = 8105;
	}

	public sealed class Class230
	{
		public string string_0;

		public int int_0;

		public string string_1;

		public string string_2;

		public Class230(string string_3, string string_4, int int_1)
		{
			string_0 = string_3;
			string_1 = string_4;
			int_0 = int_1;
			string_2 = string.Empty;
		}

		public Class230(string string_3, string string_4, int int_1, string string_5)
		{
			string_0 = string_3;
			string_1 = string_4;
			int_0 = int_1;
			string_2 = string_5;
		}
	}

	public sealed class Class231
	{
	}

	public enum Enum5
	{

	}

	public sealed class Class232
	{
		public static readonly string string_0 = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

		public static readonly string string_1 = Path.Combine(string_0, Class84.smethod_0(-994302085));

		public static Enum5 enum5_0;

		public static string string_2;

		private static void smethod_0()
		{
			try
			{
				if (!Directory.Exists(string_1))
				{
					Directory.CreateDirectory(string_1);
				}
				string[] files = Directory.GetFiles(string_1);
				for (int i = 0; i < files.Length; i++)
				{
					File.Delete(files[i]);
				}
				switch (Environment.OSVersion.Platform)
				{
				default:
					enum5_0 = (Enum5)3;
					string_2 = string_0;
					break;
				case PlatformID.Unix:
					enum5_0 = (Enum5)2;
					string_2 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
					break;
				case PlatformID.Win32S:
				case PlatformID.Win32Windows:
				case PlatformID.Win32NT:
				case PlatformID.WinCE:
					enum5_0 = (Enum5)1;
					string_2 = Environment.GetFolderPath(Environment.SpecialFolder.System);
					break;
				}
			}
			catch (Exception ex)
			{
				Class125.smethod_0(Class84.smethod_0(-994302090), ex.Message, ex);
			}
		}

		public static void smethod_1()
		{
			smethod_0();
		}
	}

	public sealed class Class233
	{
		public static string string_0;

		public static string string_1;

		public static string string_2;

		public static string string_3 = Class84.smethod_0(-994302068);

		public static string string_4 = Class84.smethod_0(-994302042);

		public static string string_5 = Class84.smethod_0(-994289595);
	}

	public sealed class Class234
	{
		public static readonly int[,] int_0 = new int[20, 20]
		{
			{
				203, 77, -145, 191, 63, 93, 171, -251, 169, 127,
				-153, 161, 205, 189, 59, 163, 209, -97, -253, 111
			},
			{
				39, -235, 163, -169, -257, -251, -223, -141, -103, -159,
				-237, -181, -125, 157, -107, 195, 115, 47, -243, 193
			},
			{
				141, -227, -251, 189, 39, 65, 141, -239, 171, -217,
				75, 113, -119, 103, 107, -173, -161, 169, -171, -181
			},
			{
				199, -175, -187, -129, -103, -159, -115, 95, 205, 209,
				77, 61, 91, 85, 169, -161, -257, -105, -181, -221
			},
			{
				199, -235, -235, -115, -141, -187, 121, 183, 43, 47,
				215, -259, 191, -183, -239, 59, 179, -251, -127, 47
			},
			{
				-229, 169, -241, -251, -137, -147, 43, -261, 123, -147,
				131, -213, -271, 65, -243, -221, -197, 193, -179, 197
			},
			{
				-119, -239, 161, -239, 55, -265, -211, -227, 53, -141,
				-145, -159, 121, -143, -133, 75, 73, 147, -135, -199
			},
			{
				191, -153, 115, 129, -97, -115, -161, 57, 207, 71,
				-265, 121, -269, -257, 161, 121, -243, 91, 59, 119
			},
			{
				189, 79, -199, -169, -239, 87, -245, -233, -93, 157,
				-217, 149, -219, -129, 117, -197, -181, -201, 99, -233
			},
			{
				167, -259, 87, -129, 171, -241, -103, -123, -159, 103,
				209, 41, 95, -237, 137, 207, 71, 139, -225, 77
			},
			{
				195, 59, -171, -119, -119, -199, 45, -249, -171, -177,
				-157, 65, 51, -269, -201, 117, 135, 155, -171, 57
			},
			{
				201, -159, -131, -195, 211, 191, 139, 71, -159, -157,
				-173, 167, -269, -103, -203, -219, 89, 93, 91, -219
			},
			{
				155, -141, -113, -125, 153, -105, -133, 115, 175, -115,
				-143, -147, 163, 51, 161, -253, -179, 139, -207, 57
			},
			{
				195, 141, -157, -203, -121, -113, -255, 117, -229, 131,
				-95, -247, -191, 175, 95, -155, -99, -145, 75, -121
			},
			{
				-155, 149, -125, 117, 73, -205, 217, 195, -211, -201,
				165, -107, -267, 59, 85, 129, 143, -239, -233, -119
			},
			{
				91, 111, -167, 201, 75, 55, 133, 133, -199, 109,
				-205, 161, 175, 93, 61, 161, -107, 97, 149, 83
			},
			{
				147, -147, -197, 55, -227, 83, -111, 71, 63, 91,
				-121, 211, 63, 123, 77, 165, 183, 167, 121, -257
			},
			{
				201, -267, 179, -103, -203, 171, 171, -155, -103, -145,
				125, -243, -231, -177, -113, 49, 215, -185, 141, -101
			},
			{
				195, -111, -257, 189, 135, 137, 209, -149, 115, 193,
				207, 63, -225, 171, -229, -183, 115, 181, -137, -125
			},
			{
				101, 161, -95, -261, 69, 123, 121, -235, -105, -213,
				-139, 177, -117, 139, -177, 123, -217, -139, 69, 45
			}
		};

		public static readonly int[,] int_1 = new int[20, 20]
		{
			{
				121, -97, -113, 159, -267, 161, -193, 131, 55, 203,
				-261, 125, -253, -229, 131, 49, 65, 191, 71, 87
			},
			{
				-209, -181, 73, 45, -189, 147, 101, -243, 157, 79,
				75, 151, -179, -267, 163, 155, 115, 103, 67, 83
			},
			{
				-153, -157, 85, -139, -233, -265, 87, 195, 119, -101,
				-253, -201, 101, -119, 169, 153, 99, -165, 115, -243
			},
			{
				183, 65, 205, -149, 213, 103, 199, -117, -245, 71,
				-153, 97, 111, -137, -115, -171, -193, -149, 209, 167
			},
			{
				-217, -189, -193, 187, -101, -253, 205, 155, -197, -137,
				181, -231, 47, -127, 183, -141, 39, 139, -129, -135
			},
			{
				113, -99, 79, 113, 111, -165, 165, -181, -181, 73,
				-215, -167, 201, 167, -95, 193, -111, 87, 73, 149
			},
			{
				-209, -167, 175, 73, 109, -197, 199, 191, -203, -99,
				-95, -267, 109, 127, 173, 87, 53, 189, -197, 61
			},
			{
				-237, 155, 217, -201, -249, 65, -233, -147, -137, 67,
				69, -133, 187, 115, -255, -241, 41, 117, -223, -243
			},
			{
				-147, -113, 143, 193, 141, 77, 161, -103, 131, 53,
				-259, 119, -97, -95, 207, -189, 151, -191, -107, -105
			},
			{
				45, 119, -121, 53, 173, 177, 213, 137, 161, 193,
				-129, 151, 43, -137, 171, 77, 181, -97, -115, -151
			},
			{
				-147, -135, -137, 77, 39, 101, -175, 107, -261, 95,
				-197, 39, 95, 187, -225, 147, 167, 201, 159, 91
			},
			{
				-237, -193, 159, -221, -109, 87, -235, -201, 87, 43,
				213, 79, -131, 63, 213, -177, 77, -151, -265, -101
			},
			{
				-249, 107, 153, -231, -105, -209, -251, 85, -99, -217,
				209, 49, 113, 145, 193, -241, -175, 181, -155, -177
			},
			{
				217, -221, 183, -163, 187, -141, 109, -143, 169, 117,
				181, -137, 89, -217, -241, -221, 215, 199, 73, -241
			},
			{
				-201, 199, 39, 127, -141, 121, 207, 45, 177, 141,
				-205, -121, 135, 131, 83, -227, 203, -97, -123, 177
			},
			{
				161, -101, 77, -223, -243, 65, -207, 71, 117, -105,
				-239, -103, 53, 161, 183, 175, -121, 157, -95, -117
			},
			{
				-251, -217, -129, -249, -245, -227, -195, -117, -149, -255,
				115, -155, 75, -111, -243, -185, -93, 137, -195, 165
			},
			{
				51, -229, -107, 139, 123, -259, 85, -93, 41, 53,
				-161, 143, 215, 127, 195, 189, 117, -199, -157, -255
			},
			{
				-175, -189, 93, 39, 153, 115, 163, 75, -215, -151,
				163, 203, 111, -173, 195, 111, 181, 167, -149, 95
			},
			{
				-179, -143, -139, 189, 57, -177, -221, -231, 111, 181,
				73, -211, 99, -109, -237, -253, 187, 61, -155, 133
			}
		};

		public static string string_0 = string.Empty;

		public static string string_1 = string.Empty;
	}
}
