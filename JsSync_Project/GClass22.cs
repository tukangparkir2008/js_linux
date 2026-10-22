using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

public sealed class GClass22
{
	public enum GEnum2
	{

	}

	public static GClass51 smethod_0(MySqlCommand mySqlCommand_0, int int_0, int int_1, GEnum2 genum2_0)
	{
		GClass51 gClass = new GClass51
		{
			gstruct5_0 = 
			{
				int_4 = int_0,
				int_5 = int_1
			}
		};
		mySqlCommand_0.Parameters.Clear();
		smethod_1(mySqlCommand_0, gClass, int_0);
		if (genum2_0 == (GEnum2)1)
		{
			smethod_2(mySqlCommand_0, gClass);
		}
		else
		{
			smethod_3(mySqlCommand_0, gClass);
		}
		return gClass;
	}

	private static void smethod_1(MySqlCommand mySqlCommand_0, GClass51 gclass51_0, int int_0)
	{
		string format = Class84.smethod_0(-994229083);
		format = string.Format(format, int_0);
		mySqlCommand_0.CommandText = format;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			gclass51_0.gstruct5_0.int_1 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994228878)]);
			gclass51_0.gstruct5_0.int_2 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994241172)]);
			gclass51_0.gstruct5_0.double_3 = Convert.ToDouble(mySqlDataReader[Class84.smethod_0(-994241168)]);
			gclass51_0.gstruct5_0.int_16 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994241099)]);
			gclass51_0.gstruct5_0.int_17 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994241072)]);
			gclass51_0.gstruct5_0.double_1 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994228896)]);
			gclass51_0.gstruct5_0.double_2 = Convert.ToDouble(mySqlDataReader[Class84.smethod_0(-994228835)]);
		}
		mySqlDataReader.Close();
	}

	private static void smethod_2(MySqlCommand mySqlCommand_0, GClass51 gclass51_0)
	{
		string string_ = Class84.smethod_0(-994228854) + gclass51_0.gstruct5_0.int_4 + Class84.smethod_0(-994228736);
		DataTable dataTable = Class280.smethod_6(mySqlCommand_0.Connection, string_);
		string format = Class84.smethod_0(-994228685);
		mySqlCommand_0.Parameters.Clear();
		foreach (DataRow row in dataTable.Rows)
		{
			int num = Convert.ToInt32(row[Class84.smethod_0(-994228614)]);
			mySqlCommand_0.CommandText = string.Format(format, num);
			if (Convert.ToInt32(mySqlCommand_0.ExecuteScalar()) != 0)
			{
				GClass16 value = smethod_4(mySqlCommand_0, gclass51_0.gstruct5_0.int_1, gclass51_0.gstruct5_0.int_2, gclass51_0.gstruct5_0.int_4, num);
				gclass51_0.list_0.Add(num);
				gclass51_0.dictionary_0.Add(num, value);
			}
		}
	}

	private static void smethod_3(MySqlCommand mySqlCommand_0, GClass51 gclass51_0)
	{
		int num = ((gclass51_0.gstruct5_0.int_2 != 0) ? gclass51_0.gstruct5_0.int_2 : gclass51_0.gstruct5_0.int_1);
		string string_ = Class84.smethod_0(-994228617) + num;
		DataTable dataTable = Class280.smethod_6(mySqlCommand_0.Connection, string_);
		string format = Class84.smethod_0(-994228685);
		string format2 = Class84.smethod_0(-994228493);
		mySqlCommand_0.Parameters.Clear();
		foreach (DataRow row in dataTable.Rows)
		{
			int num2 = Convert.ToInt32(row[Class84.smethod_0(-994228614)]);
			mySqlCommand_0.CommandText = string.Format(format, num2);
			if (Convert.ToInt32(mySqlCommand_0.ExecuteScalar()) != 0)
			{
				mySqlCommand_0.CommandText = string.Format(format2, gclass51_0.gstruct5_0.int_4, num2);
				if (Convert.ToInt32(mySqlCommand_0.ExecuteScalar()) != 0)
				{
					GClass16 value = smethod_4(mySqlCommand_0, gclass51_0.gstruct5_0.int_1, gclass51_0.gstruct5_0.int_2, gclass51_0.gstruct5_0.int_4, num2);
					gclass51_0.list_0.Add(num2);
					gclass51_0.dictionary_0.Add(num2, value);
				}
			}
		}
	}

	public static GClass16 smethod_4(MySqlCommand mySqlCommand_0, int int_0, int int_1, int int_2, int int_3)
	{
		int num = ((int_1 == 0) ? int_0 : int_1);
		GClass16 gClass = new GClass16();
		string format = Class84.smethod_0(-994228386);
		format = string.Format(format, int_2, int_3);
		mySqlCommand_0.CommandText = format;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			gClass.string_0 = mySqlDataReader[Class84.smethod_0(-994260111)].ToString();
			gClass.int_0 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994228253)]);
			gClass.double_2 = Convert.ToDouble(mySqlDataReader[Class84.smethod_0(-994241168)]);
		}
		mySqlDataReader.Close();
		format = Class84.smethod_0(-994215905);
		format = string.Format(format, num, int_3);
		mySqlCommand_0.CommandText = format;
		mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			gClass.double_0 = Convert.ToDouble(mySqlDataReader[Class84.smethod_0(-994215791)]);
			gClass.double_1 = Convert.ToDouble(mySqlDataReader[Class84.smethod_0(-994215795)]);
		}
		mySqlDataReader.Close();
		format = Class84.smethod_0(-994215750);
		format = string.Format(format, int_3);
		mySqlCommand_0.CommandText = format;
		mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			gClass.genum6_0 = (GEnum6)Convert.ToInt32(mySqlDataReader[0]);
			gClass.int_1 = Convert.ToInt32(mySqlDataReader[1]);
			gClass.int_2 = Convert.ToInt32(mySqlDataReader[2]);
			gClass.int_3 = Convert.ToInt32(mySqlDataReader[3]);
			gClass.bool_0 = 1 == Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994215633)]);
		}
		mySqlDataReader.Close();
		return gClass;
	}

	public static GClass16 smethod_5(MySqlCommand mySqlCommand_0, int int_0, int int_1, int int_2, int int_3)
	{
		GClass16 gClass = new GClass16();
		string format = Class84.smethod_0(-994215599);
		format = string.Format(format, int_2, int_3);
		mySqlCommand_0.CommandText = format;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			gClass.string_0 = mySqlDataReader[Class84.smethod_0(-994260111)].ToString();
			gClass.int_0 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994228253)]);
			gClass.double_2 = Convert.ToDouble(mySqlDataReader[Class84.smethod_0(-994241168)]);
		}
		mySqlDataReader.Close();
		format = Class84.smethod_0(-994215400);
		format = string.Format(format, int_0, int_3);
		mySqlCommand_0.CommandText = format;
		mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			gClass.double_0 = Convert.ToDouble(mySqlDataReader[Class84.smethod_0(-994215791)]);
			gClass.double_1 = Convert.ToDouble(mySqlDataReader[Class84.smethod_0(-994215795)]);
			gClass.int_5 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994215278)]);
		}
		mySqlDataReader.Close();
		format = Class84.smethod_0(-994215282);
		format = string.Format(format, int_2, int_3);
		mySqlCommand_0.CommandText = format;
		mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			gClass.int_6 = Convert.ToInt32(mySqlDataReader[0]);
		}
		mySqlDataReader.Close();
		format = Class84.smethod_0(-994215192);
		format = string.Format(format, int_3);
		mySqlCommand_0.CommandText = format;
		mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			gClass.genum6_0 = (GEnum6)Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994276368)]);
			gClass.int_1 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994214723)]);
			gClass.string_1 = mySqlDataReader[Class84.smethod_0(-994214738)].ToString();
			gClass.int_2 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994214691)]);
			gClass.string_2 = mySqlDataReader[Class84.smethod_0(-994214705)].ToString();
			gClass.int_3 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994214657)]);
			gClass.string_3 = mySqlDataReader[Class84.smethod_0(-994214676)].ToString();
			gClass.bool_0 = 1 == Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994215633)]);
			gClass.bool_1 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994214681)]) == 0;
			gClass.string_4 = mySqlDataReader[Class84.smethod_0(-994214642)].ToString();
			gClass.string_5 = mySqlDataReader[Class84.smethod_0(-994214594)].ToString();
			gClass.string_6 = Class84.smethod_0(-994214622);
			gClass.int_4 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994215791)]);
		}
		mySqlDataReader.Close();
		if (gClass.genum6_0 == 0)
		{
			format = Class84.smethod_0(-994214576);
			mySqlCommand_0.CommandText = string.Format(format, int_3);
			mySqlDataReader = mySqlCommand_0.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				gClass.int_7 = Convert.ToInt32(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			if (gClass.int_7 == 0)
			{
				gClass.int_7 = 5;
			}
		}
		else if (gClass.genum6_0 == (GEnum6)4)
		{
			format = Class84.smethod_0(-994214492);
			mySqlCommand_0.CommandText = string.Format(format, int_3);
			mySqlDataReader = mySqlCommand_0.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				gClass.int_7 = Convert.ToInt32(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			if (gClass.int_7 == 0)
			{
				gClass.int_7 = 10;
			}
		}
		else if (gClass.genum6_0 == (GEnum6)1)
		{
			gClass.int_7 = 4;
		}
		else
		{
			gClass.int_7 = 0;
		}
		if (gClass.genum6_0 == (GEnum6)3)
		{
			format = Class84.smethod_0(-994214355);
			mySqlCommand_0.CommandText = string.Format(format, int_3);
			gClass.genum12_0 = (GEnum12)Convert.ToInt32(mySqlCommand_0.ExecuteScalar());
			format = Class84.smethod_0(-994214220);
			mySqlCommand_0.CommandText = string.Format(format, int_3);
			gClass.int_8 = Convert.ToInt32(mySqlCommand_0.ExecuteScalar());
		}
		return gClass;
	}

	public static GClass39 smethod_6(MySqlCommand mySqlCommand_0, int int_0, int int_1, int int_2)
	{
		GClass39 gClass = new GClass39((GEnum5)0, string.Empty);
		switch (int_2)
		{
		case 0:
		{
			mySqlCommand_0.CommandText = Class84.smethod_0(-994214154) + int_1;
			string text4 = Class267.smethod_1(mySqlCommand_0.ExecuteScalar().ToString());
			string text5 = Class84.smethod_0(-994239046);
			mySqlCommand_0.CommandText = Class84.smethod_0(-994214095) + int_0 + Class84.smethod_0(-994214027) + int_1;
			MySqlDataReader mySqlDataReader3 = mySqlCommand_0.ExecuteReader();
			if (mySqlDataReader3.Read())
			{
				text5 = mySqlDataReader3[0].ToString();
			}
			mySqlDataReader3.Close();
			int num3 = text5.IndexOf(text4, 0);
			if (num3 >= 0)
			{
				text4 = Class84.smethod_0(-994239046).Substring(num3, 1);
			}
			gClass.genum5_0 = (GEnum5)0;
			gClass.object_0 = text4;
			break;
		}
		case 4:
		{
			mySqlCommand_0.CommandText = Class84.smethod_0(-994213990) + int_1;
			string text = Class267.smethod_1(mySqlCommand_0.ExecuteScalar().ToString());
			string text2 = Class84.smethod_0(-994239213);
			mySqlCommand_0.CommandText = Class84.smethod_0(-994214095) + int_0 + Class84.smethod_0(-994214027) + int_1;
			MySqlDataReader mySqlDataReader2 = mySqlCommand_0.ExecuteReader();
			if (mySqlDataReader2.Read())
			{
				text2 = mySqlDataReader2[0].ToString();
			}
			mySqlDataReader2.Close();
			List<string> list = new List<string>();
			foreach (string item2 in Class300.smethod_0(text, Class84.smethod_0(-994267367) + text + Class84.smethod_0(-994267375)))
			{
				int num2 = text2.IndexOf(item2, StringComparison.Ordinal);
				string item = ((num2 >= 0) ? Class84.smethod_0(-994239213).Substring(num2, 1) : string.Empty);
				list.Add(item);
			}
			list.Sort();
			string text3 = JsonConvert.SerializeObject(list);
			text3 = text3.Replace(Class84.smethod_0(-994293038), string.Empty).Replace(Class84.smethod_0(-994267367), string.Empty).Replace(Class84.smethod_0(-994267375), string.Empty);
			gClass.genum5_0 = (GEnum5)0;
			gClass.object_0 = text3;
			break;
		}
		case 1:
		{
			mySqlCommand_0.CommandText = Class84.smethod_0(-994213926) + int_1;
			string string_ = mySqlCommand_0.ExecuteScalar().ToString();
			gClass.genum5_0 = (GEnum5)0;
			gClass.object_0 = Class267.smethod_1(string_);
			break;
		}
		case 2:
		{
			mySqlCommand_0.CommandText = Class84.smethod_0(-994217960) + int_1;
			string string_2 = mySqlCommand_0.ExecuteScalar().ToString();
			gClass.genum5_0 = (GEnum5)0;
			gClass.object_0 = Class267.smethod_1(string_2);
			break;
		}
		case 3:
		{
			string commandText = Class84.smethod_0(-994217949) + int_1;
			mySqlCommand_0.CommandText = commandText;
			int num = Convert.ToInt32(mySqlCommand_0.ExecuteScalar());
			DataTable dataTable = null;
			bool flag = true;
			commandText = Class84.smethod_0(-994217886) + int_1;
			mySqlCommand_0.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				if (flag)
				{
					flag = false;
					dataTable = new DataTable();
					switch (num)
					{
					case 0:
						dataTable.Columns.Add(Class84.smethod_0(-994238711), Type.GetType(Class84.smethod_0(-994276505)));
						break;
					case 1:
						dataTable.Columns.Add(Class84.smethod_0(-994238711), Type.GetType(Class84.smethod_0(-994288671)));
						break;
					}
				}
				DataRow dataRow = dataTable.NewRow();
				if (num == 0)
				{
					dataRow[Class84.smethod_0(-994238711)] = Class123.smethod_4(mySqlDataReader[Class84.smethod_0(-994238693)].ToString());
				}
				else
				{
					Image image_ = GClass27.smethod_3((byte[])mySqlDataReader[Class84.smethod_0(-994217815)]);
					dataRow[Class84.smethod_0(-994238711)] = GClass18.smethod_9(image_);
				}
				dataTable.Rows.Add(dataRow);
			}
			mySqlDataReader.Close();
			gClass.genum5_0 = ((num == 0) ? ((GEnum5)1) : ((GEnum5)2));
			gClass.object_0 = dataTable;
			break;
		}
		}
		return gClass;
	}

	public static GClass39 smethod_7(MySqlCommand mySqlCommand_0, int int_0, int int_1, int int_2)
	{
		string empty = string.Empty;
		MySqlDataReader mySqlDataReader;
		if (int_2 == 3)
		{
			DataTable dataTable = null;
			bool flag = true;
			GEnum5 genum5_ = (GEnum5)1;
			int num = 0;
			empty = Class84.smethod_0(-994217767);
			empty = string.Format(empty, int_0, int_1);
			mySqlCommand_0.CommandText = empty;
			mySqlDataReader = mySqlCommand_0.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				if (flag)
				{
					num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994276368)]);
					flag = false;
					dataTable = new DataTable();
					dataTable.Columns.Add(Class84.smethod_0(-994264162), Type.GetType(Class84.smethod_0(-994276372)));
					if (num == 0)
					{
						genum5_ = (GEnum5)1;
						dataTable.Columns.Add(Class84.smethod_0(-994238693), Type.GetType(Class84.smethod_0(-994276505)));
					}
					else
					{
						genum5_ = (GEnum5)2;
						dataTable.Columns.Add(Class84.smethod_0(-994238693), Type.GetType(Class84.smethod_0(-994288671)));
					}
				}
				DataRow dataRow = dataTable.NewRow();
				dataRow[Class84.smethod_0(-994264162)] = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994264162)]);
				dataRow[Class84.smethod_0(-994238693)] = ((num == 0) ? mySqlDataReader[Class84.smethod_0(-994238693)] : mySqlDataReader[Class84.smethod_0(-994217815)]);
				dataTable.Rows.Add(dataRow);
			}
			mySqlDataReader.Close();
			if (dataTable == null)
			{
				dataTable = new DataTable();
				dataTable.Columns.Add(Class84.smethod_0(-994264162), Type.GetType(Class84.smethod_0(-994276372)));
				dataTable.Columns.Add(Class84.smethod_0(-994238693), Type.GetType(Class84.smethod_0(-994276505)));
				DataRow dataRow2 = dataTable.NewRow();
				dataRow2[Class84.smethod_0(-994264162)] = 0;
				dataRow2[Class84.smethod_0(-994238693)] = string.Empty;
				dataTable.Rows.Add(dataRow2);
			}
			return new GClass39(genum5_, dataTable);
		}
		string object_ = string.Empty;
		empty = Class84.smethod_0(-994217662);
		empty = string.Format(empty, int_0, int_1);
		mySqlCommand_0.CommandText = empty;
		mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			object_ = mySqlDataReader[0].ToString();
		}
		mySqlDataReader.Close();
		return new GClass39((GEnum5)0, object_);
	}

	public static Image smethod_8(MySqlConnection mySqlConnection_0, int int_0, GEnum6 genum6_0)
	{
		return GClass27.smethod_3(smethod_9(mySqlConnection_0, int_0, genum6_0));
	}

	public static byte[] smethod_9(MySqlConnection mySqlConnection_0, int int_0, GEnum6 genum6_0)
	{
		string arg = string.Empty;
		switch (genum6_0)
		{
		case (GEnum6)0:
			arg = Class84.smethod_0(-994217534);
			break;
		case (GEnum6)1:
			arg = Class84.smethod_0(-994217495);
			break;
		case (GEnum6)2:
			arg = Class84.smethod_0(-994217453);
			break;
		case (GEnum6)3:
			arg = Class84.smethod_0(-994217414);
			break;
		case (GEnum6)4:
			arg = Class84.smethod_0(-994217440);
			break;
		}
		string string_ = string.Format(Class84.smethod_0(-994217396), arg, int_0);
		return (byte[])Class280.smethod_4(mySqlConnection_0, string_);
	}

	public static string smethod_10(GEnum6 genum6_0)
	{
		if (genum6_0 != (GEnum6)4)
		{
			return Class84.smethod_0(-994239046);
		}
		return Class84.smethod_0(-994239213);
	}
}
