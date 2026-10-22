using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

public sealed class GClass35
{
	private sealed class Class238
	{
		public readonly string string_0;

		public readonly int int_0;

		public readonly int int_1;

		public readonly int int_2;

		public Class238(string string_1, int int_3, int int_4, int int_5)
		{
			string_0 = string_1;
			int_0 = int_3;
			int_1 = int_4;
			int_2 = int_5;
		}
	}

	private static readonly Random random_0 = new Random();

	private static string smethod_0()
	{
		string text2;
		do
		{
			string text = string.Empty;
			for (int i = 0; i < 12; i++)
			{
				int startIndex = random_0.Next(0, 36);
				text += Class84.smethod_0(-994212604).Substring(startIndex, 1);
			}
			text += Class84.smethod_0(-994213407);
			text2 = Path.Combine(Class224.Class232.string_1, text);
		}
		while (File.Exists(text2));
		return text2;
	}

	public static GClass43 smethod_1(DataGridView dataGridView_0, int[] int_0, bool bool_0)
	{
		List<Class238> list = new List<Class238>();
		if (bool_0)
		{
			list.Add(new Class238(string.Empty, dataGridView_0.RowHeadersWidth, -99, 0));
		}
		for (int i = 0; i < int_0.Length; i++)
		{
			if (i >= dataGridView_0.Columns.Count)
			{
				continue;
			}
			DataGridViewColumn dataGridViewColumn = dataGridView_0.Columns[i];
			if (dataGridViewColumn.Visible)
			{
				if (dataGridViewColumn is DataGridViewTextBoxColumn)
				{
					list.Add(new Class238(dataGridViewColumn.Name, dataGridViewColumn.Width, i, 0));
				}
				else if (dataGridViewColumn is DataGridViewImageColumn)
				{
					list.Add(new Class238(dataGridViewColumn.Name, dataGridViewColumn.Width, i, 1));
				}
			}
		}
		return smethod_3(dataGridView_0, list);
	}

	public static GClass43 smethod_2(DataGridView dataGridView_0, bool bool_0)
	{
		List<Class238> list = new List<Class238>();
		if (bool_0)
		{
			list.Add(new Class238(string.Empty, dataGridView_0.RowHeadersWidth, -99, 0));
		}
		for (int i = 0; i < dataGridView_0.Columns.Count; i++)
		{
			DataGridViewColumn dataGridViewColumn = dataGridView_0.Columns[i];
			if (dataGridViewColumn.Visible)
			{
				if (dataGridViewColumn is DataGridViewTextBoxColumn)
				{
					list.Add(new Class238(dataGridViewColumn.Name, dataGridViewColumn.Width, i, 0));
				}
				else if (dataGridViewColumn is DataGridViewImageColumn)
				{
					list.Add(new Class238(dataGridViewColumn.Name, dataGridViewColumn.Width, i, 1));
				}
			}
		}
		return smethod_3(dataGridView_0, list);
	}

	private static GClass43 smethod_3(DataGridView dataGridView_0, List<Class238> list_0)
	{
		GClass49 gClass = new GClass49();
		foreach (Class238 item in list_0)
		{
			gClass.method_1(item.string_0, item.int_0);
		}
		int count = dataGridView_0.Rows.Count;
		int count2 = list_0.Count;
		Font font = dataGridView_0.Font;
		GClass50 gClass2 = new GClass50(count, count2, gClass);
		for (int i = 0; i < count; i++)
		{
			int num = 0;
			foreach (Class238 item2 in list_0)
			{
				int int_ = item2.int_1;
				if (int_ == -99)
				{
					string string_ = (i + 1).ToString();
					gClass2.method_5(i, num, string_, font, Color.WhiteSmoke, Color.Black, (GEnum10)2);
					num++;
					continue;
				}
				if (item2.int_2 == 0)
				{
					string string_2 = ((dataGridView_0.Rows[i].Cells[int_].Value == null) ? string.Empty : dataGridView_0.Rows[i].Cells[int_].Value.ToString());
					Color foreColor = dataGridView_0.Rows[i].Cells[int_].Style.ForeColor;
					Color backColor = dataGridView_0.Rows[i].Cells[int_].Style.BackColor;
					string text = dataGridView_0.Rows[i].Cells[int_].Style.Alignment.ToString();
					if (text == Class84.smethod_0(-994212513))
					{
						text = dataGridView_0.Columns[int_].DefaultCellStyle.Alignment.ToString();
					}
					if (foreColor == backColor)
					{
						foreColor = dataGridView_0.ForeColor;
					}
					GEnum10 genum10_ = ((text.ToLower().IndexOf(Class84.smethod_0(-994291853), StringComparison.Ordinal) >= 0) ? ((GEnum10)2) : ((text.ToLower().IndexOf(Class84.smethod_0(-994291897), StringComparison.Ordinal) < 0) ? ((GEnum10)1) : ((GEnum10)3)));
					gClass2.method_5(i, num, string_2, font, backColor, foreColor, genum10_);
				}
				else
				{
					byte[] array = (byte[])dataGridView_0.Rows[i].Cells[int_].Value;
					if (array != null)
					{
						Image image_ = GClass18.smethod_26(array, Class84.smethod_0(-994212532));
						gClass2.method_6(i, num, image_);
					}
					else
					{
						Bitmap bitmap = new Bitmap(10, 10);
						using (Graphics graphics = Graphics.FromImage(bitmap))
						{
							graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, 10, 10);
						}
						gClass2.method_6(i, num, bitmap);
					}
				}
				num++;
			}
		}
		return new GClass43(gClass, gClass2);
	}

	public static void smethod_4(string string_0)
	{
		string text = smethod_0();
		StreamWriter streamWriter = new StreamWriter(text, append: false);
		streamWriter.WriteLine(string_0);
		streamWriter.Close();
		Process.Start(text);
	}

	public static string smethod_5(DataGridView dataGridView_0, bool bool_0)
	{
		List<Class238> list = new List<Class238>();
		if (bool_0)
		{
			list.Add(new Class238(Class84.smethod_0(-994212482), dataGridView_0.RowHeadersWidth, -99, 0));
		}
		for (int i = 0; i < dataGridView_0.Columns.Count; i++)
		{
			DataGridViewColumn dataGridViewColumn = dataGridView_0.Columns[i];
			if (dataGridViewColumn.Visible && dataGridViewColumn is DataGridViewTextBoxColumn)
			{
				list.Add(new Class238(dataGridViewColumn.Name, dataGridViewColumn.Width, i, 0));
			}
		}
		return smethod_7(dataGridView_0, list);
	}

	public static string smethod_6(DataGridView dataGridView_0, int[] int_0, bool bool_0)
	{
		List<Class238> list = new List<Class238>();
		if (bool_0)
		{
			list.Add(new Class238(Class84.smethod_0(-994212482), dataGridView_0.RowHeadersWidth, -99, 0));
		}
		for (int i = 0; i < int_0.Length; i++)
		{
			if (i < dataGridView_0.Columns.Count)
			{
				DataGridViewColumn dataGridViewColumn = dataGridView_0.Columns[i];
				if (dataGridViewColumn.Visible && dataGridViewColumn is DataGridViewTextBoxColumn)
				{
					list.Add(new Class238(dataGridViewColumn.Name, dataGridViewColumn.Width, i, 0));
				}
			}
		}
		return smethod_7(dataGridView_0, list);
	}

	private static string smethod_7(DataGridView dataGridView_0, List<Class238> list_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		foreach (Class238 item in list_0)
		{
			if (stringBuilder2.Length != 0)
			{
				stringBuilder2.Append(',');
			}
			stringBuilder2.Append(smethod_8(item.string_0));
		}
		stringBuilder.AppendLine(stringBuilder2.ToString());
		int count = dataGridView_0.Rows.Count;
		for (int i = 0; i < count; i++)
		{
			stringBuilder2.Clear();
			foreach (Class238 item2 in list_0)
			{
				if (stringBuilder2.Length != 0)
				{
					stringBuilder2.Append(',');
				}
				int int_ = item2.int_1;
				if (int_ == -99)
				{
					string string_ = (i + 1).ToString();
					stringBuilder2.Append(smethod_8(string_));
				}
				else if (item2.int_2 == 0)
				{
					string string_2 = ((dataGridView_0.Rows[i].Cells[int_].Value == null) ? string.Empty : dataGridView_0.Rows[i].Cells[int_].Value.ToString());
					stringBuilder2.Append(smethod_8(string_2));
				}
			}
			stringBuilder.AppendLine(stringBuilder2.ToString());
		}
		return stringBuilder.ToString();
	}

	private static string smethod_8(string string_0)
	{
		return Class84.smethod_0(-994293038) + string_0.Trim().Replace(Class84.smethod_0(-994293038), Class84.smethod_0(-994212489)) + Class84.smethod_0(-994293038);
	}
}
