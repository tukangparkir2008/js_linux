using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

internal sealed class Class137
{
	public static GClass70 smethod_0(string string_0)
	{
		try
		{
			Class330 @class = Class330.smethod_0(string_0);
			if (@class == null)
			{
				return new GClass70(-1, Class84.smethod_0(-994288714));
			}
			if (@class.genum13_0 == (GEnum13)1)
			{
				return smethod_1(@class.list_0);
			}
			return new GClass70(1, Class84.smethod_0(-994247224));
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994288684), ex.Message, ex);
			return new GClass70(-99, ex.Message);
		}
	}

	private static GClass70 smethod_1(List<string> list_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<List<List<string>>> list = new List<List<List<string>>>();
			for (int i = 0; i < list_0.Count; i++)
			{
				string text = list_0[i];
				int num = text.IndexOf(Class84.smethod_0(-994288651), 0, StringComparison.Ordinal);
				while (num >= 0)
				{
					string text2 = string.Empty;
					int num2 = text.IndexOf(Class84.smethod_0(-994267367), num, StringComparison.Ordinal);
					int num3 = text.IndexOf(Class84.smethod_0(-994267375), num, StringComparison.Ordinal);
					if (num2 >= 0 && num3 > num2)
					{
						string[] array = text.Substring(num2 + 1, num3 - num2 - 1).Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
						if (array.Length == 3)
						{
							int num4 = Class159.smethod_0(array[0].Trim(), -1);
							int num5 = Class159.smethod_0(array[1].Trim(), -1);
							int num6 = Class159.smethod_0(array[2].Trim(), -1);
							if (num4 >= 0 && num4 < list.Count)
							{
								List<List<string>> list2 = list[num4];
								if (num5 >= 0 && num5 < list2.Count)
								{
									List<string> list3 = list2[num5];
									if (num6 >= 0 && num6 < list3.Count)
									{
										text2 = list3[num6];
									}
								}
							}
						}
						string text3 = text.Substring(0, num);
						string text4 = text.Substring(num3 + 1);
						text = text3 + text2 + text4;
						num = text.IndexOf(Class84.smethod_0(-994288651), 0, StringComparison.Ordinal);
					}
					else
					{
						num = text.IndexOf(Class84.smethod_0(-994288651), num + 1, StringComparison.Ordinal);
					}
				}
				List<List<string>> list4 = new List<List<string>>();
				mySqlCommand.CommandText = text;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					List<string> list5 = new List<string>();
					for (int j = 0; j < mySqlDataReader.FieldCount; j++)
					{
						string empty = string.Empty;
						if (mySqlDataReader[j].GetType() == Type.GetType(Class84.smethod_0(-994288671)))
						{
							empty = (Convert.IsDBNull(mySqlDataReader[j]) ? Class84.smethod_0(-994288619) : Convert.ToBase64String((byte[])mySqlDataReader[j]));
						}
						else
						{
							empty = (Convert.IsDBNull(mySqlDataReader[j]) ? string.Empty : mySqlDataReader[j].ToString());
						}
						list5.Add(empty);
					}
					list4.Add(list5);
				}
				mySqlDataReader.Close();
				list.Add(list4);
			}
			return new GClass70(1, Class84.smethod_0(-994247224), list);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994288578), ex.Message, ex);
			return new GClass70(-99, ex.Message);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}
}
