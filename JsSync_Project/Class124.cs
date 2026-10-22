using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

internal sealed class Class124
{
	public static string smethod_0(string string_0)
	{
		DataTable dataTable = Class280.smethod_7(Class84.smethod_0(-994253458) + string_0 + Class84.smethod_0(-994271698));
		if (dataTable.Rows.Count <= 0)
		{
			return string.Empty;
		}
		return dataTable.Rows[0][0].ToString();
	}

	public static string smethod_1(string string_0)
	{
		DataTable dataTable = Class280.smethod_7(Class84.smethod_0(-994253391) + string_0 + Class84.smethod_0(-994271698));
		if (dataTable.Rows.Count <= 0)
		{
			return string.Empty;
		}
		return dataTable.Rows[0][0].ToString();
	}

	public static string smethod_2(string string_0)
	{
		DataTable dataTable = Class280.smethod_7(Class84.smethod_0(-994253325) + string_0 + Class84.smethod_0(-994271698));
		if (dataTable.Rows.Count <= 0)
		{
			return string.Empty;
		}
		return dataTable.Rows[0][0].ToString();
	}

	public static List<GClass57> smethod_3(string string_0, string string_1, string string_2)
	{
		List<GClass57> list = new List<GClass57>();
		foreach (DataRow row in Class280.smethod_7(string.Format(Class84.smethod_0(-994253305), string_2, string_1, string_0)).Rows)
		{
			string string_3 = Convert.ToString(row[0]);
			string string_4 = Convert.ToString(row[1]);
			string string_5 = Convert.ToString(row[2]);
			string string_6 = Convert.ToString(row[4]);
			int int_ = Convert.ToInt32(row[5]);
			int int_2 = Convert.ToInt32(row[6]);
			Image image = null;
			if (!Convert.IsDBNull(row[3]))
			{
				try
				{
					image = GClass18.smethod_10(row, 3);
					if (image != null)
					{
						image = GClass18.smethod_3(image, 42f, 42f);
					}
				}
				catch (Exception ex)
				{
					Class162.smethod_2(Class84.smethod_0(-994253014), ex.Message, ex);
					image = null;
				}
			}
			list.Add(new GClass57(string_3, Class84.smethod_0(-994257743), string_4, string_5, image, string_6, int_, int_2));
		}
		return list;
	}

	public static List<GClass57> smethod_4(string string_0, string string_1)
	{
		List<GClass57> list = new List<GClass57>();
		foreach (DataRow row in Class280.smethod_7(string.Format(Class84.smethod_0(-994252988), string_1, string_0)).Rows)
		{
			string string_2 = Convert.ToString(row[0]);
			string string_3 = Convert.ToString(row[1]);
			string string_4 = Convert.ToString(row[2]);
			Image image = null;
			if (!Convert.IsDBNull(row[3]))
			{
				try
				{
					image = GClass18.smethod_10(row, 3);
					if (image != null)
					{
						image = GClass18.smethod_3(image, 42f, 42f);
					}
				}
				catch (Exception ex)
				{
					Class162.smethod_2(Class84.smethod_0(-994306030), ex.Message, ex);
					image = null;
				}
			}
			list.Add(new GClass57(string_2, Class84.smethod_0(-994257747), string_3, string_4, image, string.Empty, -1, -1));
		}
		return list;
	}

	public static List<GClass57> smethod_5(int int_0)
	{
		List<GClass57> list = new List<GClass57>();
		foreach (DataRow row in Class280.smethod_7(string.Format(Class84.smethod_0(-994306003), int_0)).Rows)
		{
			string string_ = Convert.ToString(row[0]);
			string string_2 = Convert.ToString(row[1]);
			string string_3 = Convert.ToString(row[2]);
			string string_4 = Convert.ToString(row[4]);
			int int_1 = Convert.ToInt32(row[5]);
			int int_2 = Convert.ToInt32(row[6]);
			Image image = null;
			if (!Convert.IsDBNull(row[3]))
			{
				try
				{
					image = GClass18.smethod_10(row, 3);
					if (image != null)
					{
						image = GClass18.smethod_3(image, 42f, 42f);
					}
				}
				catch (Exception ex)
				{
					Class162.smethod_2(Class84.smethod_0(-994305738), ex.Message, ex);
					image = null;
				}
			}
			list.Add(new GClass57(string_, Class84.smethod_0(-994257743), string_2, string_3, image, string_4, int_1, int_2));
		}
		return list;
	}

	public static List<GClass57> smethod_6(string string_0)
	{
		List<GClass57> list = new List<GClass57>();
		foreach (DataRow row in Class280.smethod_7(string.Format(arg0: string_0.ToLower().Equals(Class84.smethod_0(-994305721)) ? Class84.smethod_0(-994305674) : ((!string_0.ToLower().Equals(Class84.smethod_0(-994305645))) ? Class84.smethod_0(-994305625) : Class84.smethod_0(-994305658)), format: Class84.smethod_0(-994305580))).Rows)
		{
			string string_1 = Convert.ToString(row[0]);
			string string_2 = Convert.ToString(row[1]);
			string string_3 = Convert.ToString(row[2]);
			Image image = null;
			if (!Convert.IsDBNull(row[3]))
			{
				try
				{
					image = GClass18.smethod_10(row, 3);
					if (image != null)
					{
						image = GClass18.smethod_3(image, 42f, 42f);
					}
				}
				catch (Exception ex)
				{
					Class162.smethod_2(Class84.smethod_0(-994306030), ex.Message, ex);
					image = null;
				}
			}
			list.Add(new GClass57(string_1, Class84.smethod_0(-994257747), string_2, string_3, image, string.Empty, -1, -1));
		}
		return list;
	}
}
