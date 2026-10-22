using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

public sealed class GForm36 : Form
{
	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private readonly GForm8 gform8_0;

	private Class216 class216_0;

	private DataTable dataTable_0;

	private Class216 class216_1;

	private DataTable dataTable_1;

	private bool bool_0;

	private string string_0 = string.Empty;

	private string string_1 = string.Empty;

	private int int_0;

	private string string_2 = string.Empty;

	private string string_3 = string.Empty;

	private bool bool_1;

	private static CookieContainer cookieContainer_0;

	private IContainer icontainer_0;

	private Panel panel_0;

	private SplitContainer splitContainer_0;

	private Label label_0;

	private Label label_1;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private Label label_2;

	private ComboBox comboBox_0;

	private Label label_3;

	private Panel panel_1;

	private ComboBox comboBox_1;

	private Label label_4;

	private Label label_5;

	private ComboBox comboBox_2;

	private Label label_6;

	private ComboBox comboBox_3;

	private Label label_7;

	private Panel panel_2;

	private ComboBox comboBox_4;

	private Label label_8;

	private ComboBox comboBox_5;

	private Label label_9;

	private ComboBox comboBox_6;

	private Label label_10;

	private Panel panel_3;

	private ComboBox comboBox_7;

	private Label label_11;

	private ComboBox comboBox_8;

	private Label label_12;

	private Class193 class193_0;

	private Panel panel_4;

	private Class193 class193_1;

	private Label label_13;

	private ComboBox comboBox_9;

	private Label label_14;

	private Label label_15;

	private GControl1 gcontrol1_0;

	private Button button_0;

	private Button button_1;

	private ComboBox comboBox_10;

	private ComboBox comboBox_11;

	private ComboBox comboBox_12;

	private ComboBox comboBox_13;

	private ComboBox comboBox_14;

	private RadioButton radioButton_0;

	private RadioButton radioButton_1;

	private Label label_16;

	private CheckBox checkBox_0;

	public GForm36(GForm17 gform17_1, GForm8 gform8_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gform17_1.method_0();
		gform8_0 = gform8_1;
		method_14();
		method_2();
		method_3();
		method_4();
	}

	public static CookieContainer smethod_0()
	{
		if (cookieContainer_0 == null)
		{
			cookieContainer_0 = new CookieContainer();
		}
		return cookieContainer_0;
	}

	private void method_0(object object_0)
	{
		try
		{
			gcontrol1_0.method_2(object_0.ToString());
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_1(string string_4)
	{
		bool_1 = true;
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string format = Class84.smethod_0(-994268782);
			format = string.Format(format, string_4);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = format
			};
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			if (dataTable.Rows.Count == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994268571));
				return;
			}
			string_0 = string_4;
			textBox_0.Text = dataTable.Rows[0][Class84.smethod_0(-994268488)].ToString();
			textBox_1.Text = dataTable.Rows[0][Class84.smethod_0(-994268492)].ToString();
			string object_ = dataTable.Rows[0][Class84.smethod_0(-994268508)].ToString();
			new GClass10(500, method_0, object_, this).method_0();
			if (Convert.ToInt32(dataTable.Rows[0][Class84.smethod_0(-994268463)]) == 2000)
			{
				radioButton_1.Checked = true;
			}
			else
			{
				radioButton_0.Checked = true;
				DateTime dateTime = Convert.ToDateTime(dataTable.Rows[0][Class84.smethod_0(-994268477)]);
				comboBox_14.Text = dateTime.Year.ToString();
				comboBox_13.SelectedIndex = dateTime.Month - 1;
				comboBox_12.SelectedIndex = dateTime.Day - 1;
				comboBox_11.SelectedIndex = dateTime.Hour;
				comboBox_10.SelectedIndex = dateTime.Minute;
			}
			object obj = dataTable.Rows[0][Class84.smethod_0(-994268429)];
			if (obj.Equals(Class84.smethod_0(-994268448)))
			{
				comboBox_0.SelectedIndex = 0;
			}
			else if (obj.Equals(Class84.smethod_0(-994268389)))
			{
				comboBox_0.SelectedIndex = 1;
			}
			else if (obj.Equals(Class84.smethod_0(-994268394)))
			{
				comboBox_0.SelectedIndex = 2;
			}
			else if (obj.Equals(Class84.smethod_0(-994268415)))
			{
				string_1 = dataTable.Rows[0][Class84.smethod_0(-994273283)].ToString();
				comboBox_0.SelectedIndex = 3;
			}
			else if (obj.Equals(Class84.smethod_0(-994268356)))
			{
				string_1 = dataTable.Rows[0][Class84.smethod_0(-994273283)].ToString();
				int_0 = Convert.ToInt32(dataTable.Rows[0][Class84.smethod_0(-994268361)]);
				comboBox_0.SelectedIndex = 4;
			}
			else if (obj.Equals(Class84.smethod_0(-994268377)))
			{
				string_1 = dataTable.Rows[0][Class84.smethod_0(-994273283)].ToString();
				int_0 = Convert.ToInt32(dataTable.Rows[0][Class84.smethod_0(-994268361)]);
				string_2 = string.Empty;
				format = Class84.smethod_0(-994268334) + string_4 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = format;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					string_2 += string.Format(Class84.smethod_0(-994268271), mySqlDataReader[Class84.smethod_0(-994277103)]);
				}
				mySqlDataReader.Close();
				comboBox_0.SelectedIndex = 5;
			}
			else if (obj.Equals(Class84.smethod_0(-994268275)))
			{
				string_1 = dataTable.Rows[0][Class84.smethod_0(-994273283)].ToString();
				string_3 = string.Empty;
				format = Class84.smethod_0(-994268232) + string_4 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = format;
				MySqlDataReader mySqlDataReader2 = mySqlCommand.ExecuteReader();
				while (mySqlDataReader2.Read())
				{
					string_3 += string.Format(Class84.smethod_0(-994268271), mySqlDataReader2[Class84.smethod_0(-994268163)]);
				}
				mySqlDataReader2.Close();
				comboBox_0.SelectedIndex = 6;
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private void method_2()
	{
		panel_2.Location = panel_3.Location;
		panel_1.Location = panel_3.Location;
		panel_4.Location = panel_3.Location;
	}

	private void method_3()
	{
		class216_0 = new Class216(class193_0, bool_0: false, bool_1: false);
		class216_0.method_4();
		class216_0.method_5(Class84.smethod_0(-994263061), 40, bool_0: false);
		class216_0.method_2(Class84.smethod_0(-994278020), 270, bool_0: true);
		dataTable_0 = new DataTable();
		dataTable_0.Columns.Add(Class84.smethod_0(-994264162), Type.GetType(Class84.smethod_0(-994276372)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994276469), Type.GetType(Class84.smethod_0(-994276372)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994277105), Type.GetType(Class84.smethod_0(-994276505)));
		class216_1 = new Class216(class193_1, bool_0: false, bool_1: false);
		class216_1.method_4();
		class216_1.method_5(Class84.smethod_0(-994263061), 40, bool_0: false);
		class216_1.method_2(Class84.smethod_0(-994268178), 270, bool_0: true);
		dataTable_1 = new DataTable();
		dataTable_1.Columns.Add(Class84.smethod_0(-994264162), Type.GetType(Class84.smethod_0(-994276372)));
		dataTable_1.Columns.Add(Class84.smethod_0(-994276469), Type.GetType(Class84.smethod_0(-994276372)));
		dataTable_1.Columns.Add(Class84.smethod_0(-994268131), Type.GetType(Class84.smethod_0(-994276505)));
	}

	private void method_4()
	{
		try
		{
			bool_0 = true;
			ComboBox.ObjectCollection items = comboBox_0.Items;
			GClass2 gClass = new GClass2();
			gClass.method_1(Class84.smethod_0(-994268148));
			gClass.method_3(Class84.smethod_0(-994268448));
			items.Add(gClass);
			ComboBox.ObjectCollection items2 = comboBox_0.Items;
			GClass2 gClass2 = new GClass2();
			gClass2.method_1(Class84.smethod_0(-994268118));
			gClass2.method_3(Class84.smethod_0(-994268389));
			items2.Add(gClass2);
			ComboBox.ObjectCollection items3 = comboBox_0.Items;
			GClass2 gClass3 = new GClass2();
			gClass3.method_1(Class84.smethod_0(-994268066));
			gClass3.method_3(Class84.smethod_0(-994268394));
			items3.Add(gClass3);
			ComboBox.ObjectCollection items4 = comboBox_0.Items;
			GClass2 gClass4 = new GClass2();
			gClass4.method_1(Class84.smethod_0(-994268092));
			gClass4.method_3(Class84.smethod_0(-994268415));
			items4.Add(gClass4);
			ComboBox.ObjectCollection items5 = comboBox_0.Items;
			GClass2 gClass5 = new GClass2();
			gClass5.method_1(Class84.smethod_0(-994268049));
			gClass5.method_3(Class84.smethod_0(-994268356));
			items5.Add(gClass5);
			ComboBox.ObjectCollection items6 = comboBox_0.Items;
			GClass2 gClass6 = new GClass2();
			gClass6.method_1(Class84.smethod_0(-994268009));
			gClass6.method_3(Class84.smethod_0(-994268377));
			items6.Add(gClass6);
			ComboBox.ObjectCollection items7 = comboBox_0.Items;
			GClass2 gClass7 = new GClass2();
			gClass7.method_1(Class84.smethod_0(-994267971));
			gClass7.method_3(Class84.smethod_0(-994268275));
			items7.Add(gClass7);
			comboBox_0.SelectedIndex = 0;
			comboBox_7.Items.Add(Class84.smethod_0(-994278876));
			comboBox_7.Items.Add(Class84.smethod_0(-994267997));
			comboBox_7.Items.Add(Class84.smethod_0(-994267960));
			comboBox_7.SelectedIndex = 0;
			comboBox_4.Items.Add(Class84.smethod_0(-994278876));
			comboBox_4.Items.Add(Class84.smethod_0(-994267997));
			comboBox_4.Items.Add(Class84.smethod_0(-994267960));
			comboBox_4.SelectedIndex = 0;
			comboBox_1.Items.Add(Class84.smethod_0(-994278876));
			comboBox_1.Items.Add(Class84.smethod_0(-994267997));
			comboBox_1.Items.Add(Class84.smethod_0(-994267960));
			comboBox_1.SelectedIndex = 0;
			method_6(comboBox_8);
			DateTime dateTime = Class348.Class349.smethod_0();
			comboBox_14.Items.Clear();
			for (int i = Class224.Class227.int_0; i <= dateTime.Year + 1; i++)
			{
				comboBox_14.Items.Add(i);
			}
			comboBox_14.Text = dateTime.Year.ToString();
			comboBox_13.Items.Clear();
			for (int j = 1; j <= 12; j++)
			{
				comboBox_13.Items.Add(Class120.smethod_18(j));
			}
			comboBox_13.SelectedIndex = dateTime.Month - 1;
			method_5();
			comboBox_11.Items.Clear();
			for (int k = 0; k < 24; k++)
			{
				comboBox_11.Items.Add(k.ToString().PadLeft(2, '0'));
			}
			comboBox_11.Text = dateTime.Hour.ToString().PadLeft(2, '0');
			comboBox_10.Items.Clear();
			for (int l = 0; l < 60; l++)
			{
				comboBox_10.Items.Add(l.ToString().PadLeft(2, '0'));
			}
			comboBox_10.Text = dateTime.Minute.ToString().PadLeft(2, '0');
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			bool_0 = false;
		}
	}

	private void method_5()
	{
		DateTime dateTime = Class348.Class349.smethod_0();
		comboBox_12.Items.Clear();
		int num = Class120.smethod_0(Convert.ToInt32(comboBox_14.Text), comboBox_13.SelectedIndex + 1);
		for (int i = 1; i <= num; i++)
		{
			comboBox_12.Items.Add(i.ToString().PadLeft(2, '0'));
		}
		if (comboBox_14.Text == dateTime.Year.ToString() && comboBox_13.SelectedIndex == dateTime.Month - 1)
		{
			comboBox_12.SelectedIndex = dateTime.Day - 1;
		}
		else
		{
			comboBox_12.SelectedIndex = 0;
		}
	}

	private void method_6(ComboBox comboBox_15)
	{
		bool_0 = true;
		int selectedIndex = 0;
		comboBox_15.Items.Clear();
		foreach (Tuple<int, string> item in gform17_0.method_0().gclass6_0.method_10())
		{
			ComboBox.ObjectCollection items = comboBox_15.Items;
			GClass2 gClass = new GClass2();
			gClass.method_1(item.Item2);
			gClass.method_3(item.Item1);
			items.Add(gClass);
			if (string_1.Equals(item.Item2))
			{
				selectedIndex = comboBox_15.Items.Count - 1;
			}
		}
		if (comboBox_15.Items.Count > 0)
		{
			comboBox_15.SelectedIndex = selectedIndex;
		}
		bool_0 = false;
	}

	private void GForm36_Load(object sender, EventArgs e)
	{
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			panel_3.Visible = comboBox_0.SelectedIndex == 3;
			panel_2.Visible = comboBox_0.SelectedIndex == 4;
			panel_1.Visible = comboBox_0.SelectedIndex == 5;
			panel_4.Visible = comboBox_0.SelectedIndex == 6;
			if (comboBox_0.SelectedIndex == 3)
			{
				method_6(comboBox_8);
			}
			else if (comboBox_0.SelectedIndex == 4)
			{
				method_6(comboBox_6);
				method_7(comboBox_5, null, comboBox_6, int_0, -1);
			}
			else if (comboBox_0.SelectedIndex == 5)
			{
				method_6(comboBox_3);
				method_7(comboBox_2, null, comboBox_3, int_0, -1);
				method_8();
			}
			else if (comboBox_0.SelectedIndex == 6)
			{
				method_6(comboBox_9);
				method_9();
			}
		}
	}

	private void method_7(ComboBox comboBox_15, ComboBox comboBox_16, ComboBox comboBox_17, int int_1, int int_2)
	{
		if (bool_0 || comboBox_17.Items.Count == 0)
		{
			return;
		}
		bool_0 = true;
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			comboBox_15.Items.Clear();
			comboBox_16?.Items.Clear();
			int selectedIndex = 0;
			string arg = ((GClass2)comboBox_17.SelectedItem).method_0();
			string format = Class84.smethod_0(-994267919);
			format = string.Format(format, arg);
			foreach (DataRow row in Class280.smethod_6(mySqlConnection, format).Rows)
			{
				ComboBox.ObjectCollection items = comboBox_15.Items;
				GClass2 gClass = new GClass2();
				gClass.method_3(Convert.ToInt32(row[0]));
				gClass.method_1(Convert.ToString(row[1]));
				items.Add(gClass);
				if (int_1 == Convert.ToInt32(row[0]))
				{
					selectedIndex = comboBox_15.Items.Count - 1;
				}
			}
			if (comboBox_15.Items.Count > 0)
			{
				comboBox_15.SelectedIndex = selectedIndex;
			}
			if (comboBox_16 == null)
			{
				return;
			}
			selectedIndex = 0;
			format = Class84.smethod_0(-994267748);
			format = string.Format(format, arg);
			foreach (DataRow row2 in Class280.smethod_6(mySqlConnection, format).Rows)
			{
				ComboBox.ObjectCollection items2 = comboBox_16.Items;
				GClass2 gClass2 = new GClass2();
				gClass2.method_3(Convert.ToInt32(row2[0]));
				gClass2.method_1(Convert.ToString(row2[1]));
				items2.Add(gClass2);
				if (int_2 == -1)
				{
					if (1 == Convert.ToInt32(row2[2]))
					{
						selectedIndex = comboBox_16.Items.Count - 1;
					}
				}
				else if (int_2 == Convert.ToInt32(row2[0]))
				{
					selectedIndex = comboBox_16.Items.Count - 1;
				}
			}
			if (comboBox_16.Items.Count > 0)
			{
				comboBox_16.SelectedIndex = selectedIndex;
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
			bool_0 = false;
		}
	}

	private void method_8()
	{
		if (bool_0 || comboBox_3.Items.Count == 0 || comboBox_2.Items.Count == 0)
		{
			return;
		}
		dataTable_0.Rows.Clear();
		class193_0.Rows.Clear();
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string arg = comboBox_3.Text;
			int num = ((GClass2)comboBox_2.SelectedItem).method_4();
			string format = Class84.smethod_0(-994267642);
			format = string.Format(format, arg, num);
			foreach (DataRow row in Class280.smethod_6(mySqlConnection, format).Rows)
			{
				string value = Class84.smethod_0(-994267367) + row[0]?.ToString() + Class84.smethod_0(-994267375);
				DataRow dataRow2 = dataTable_0.NewRow();
				dataRow2[Class84.smethod_0(-994264162)] = Convert.ToInt32(row[0]);
				dataRow2[Class84.smethod_0(-994276469)] = string_2.IndexOf(value, StringComparison.Ordinal) >= 0;
				dataRow2[Class84.smethod_0(-994277105)] = Convert.ToString(row[1]);
				dataTable_0.Rows.Add(dataRow2);
			}
			class216_0.method_9(dataTable_0);
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private void method_9()
	{
		if (bool_0)
		{
			return;
		}
		dataTable_1.Rows.Clear();
		class193_1.Rows.Clear();
		if (comboBox_9.Items.Count == 0)
		{
			return;
		}
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			_ = comboBox_9.Text;
			string text = ((gform17_0.method_0().gclass6_0.method_6() != 0) ? (Class84.smethod_0(-994267204) + gform17_0.method_0().gclass6_0.method_2() + Class84.smethod_0(-994271187)) : Class84.smethod_0(-994267383));
			foreach (DataRow row in Class280.smethod_6(mySqlConnection, text).Rows)
			{
				string value = Class84.smethod_0(-994267367) + row[0]?.ToString() + Class84.smethod_0(-994267375);
				DataRow dataRow2 = dataTable_1.NewRow();
				dataRow2[Class84.smethod_0(-994264162)] = Convert.ToInt32(row[0]);
				dataRow2[Class84.smethod_0(-994276469)] = string_3.IndexOf(value, StringComparison.Ordinal) >= 0;
				dataRow2[Class84.smethod_0(-994268131)] = Convert.ToString(row[1]);
				dataTable_1.Rows.Add(dataRow2);
			}
			class216_1.method_9(dataTable_1);
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private void comboBox_14_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			method_5();
		}
	}

	private void comboBox_13_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			method_5();
		}
	}

	private void radioButton_1_CheckedChanged(object sender, EventArgs e)
	{
		comboBox_14.Enabled = false;
		comboBox_13.Enabled = false;
		comboBox_12.Enabled = false;
		comboBox_11.Enabled = false;
		comboBox_10.Enabled = false;
	}

	private void radioButton_0_CheckedChanged(object sender, EventArgs e)
	{
		comboBox_14.Enabled = true;
		comboBox_13.Enabled = true;
		comboBox_12.Enabled = true;
		comboBox_11.Enabled = true;
		comboBox_10.Enabled = true;
	}

	private void comboBox_6_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			method_7(comboBox_5, null, comboBox_6, 0, -1);
		}
	}

	private void comboBox_3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			method_7(comboBox_2, null, comboBox_3, 0, -1);
			method_8();
		}
	}

	private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			method_8();
		}
	}

	private void comboBox_9_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			method_9();
		}
	}

	private bool method_10()
	{
		if (textBox_0.Text.Trim().Length < 5)
		{
			Class355.smethod_0(Class84.smethod_0(-994271095));
			textBox_0.Focus();
			return false;
		}
		if (textBox_1.Text.Trim().Length < 5)
		{
			Class355.smethod_0(Class84.smethod_0(-994271071));
			textBox_1.Focus();
			return false;
		}
		if (comboBox_0.SelectedIndex == 3 && comboBox_8.Items.Count == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994270979));
			comboBox_8.Focus();
			return false;
		}
		if (comboBox_0.SelectedIndex == 4)
		{
			if (comboBox_6.Items.Count == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994270979));
				comboBox_6.Focus();
				return false;
			}
			if (comboBox_5.Items.Count == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994270945));
				comboBox_5.Focus();
				return false;
			}
		}
		if (comboBox_0.SelectedIndex == 5)
		{
			if (comboBox_3.Items.Count == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994270979));
				comboBox_3.Focus();
				return false;
			}
			if (comboBox_2.Items.Count == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994270945));
				comboBox_2.Focus();
				return false;
			}
			if (class193_0.Rows.Count == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994270915));
				class193_0.Focus();
				return false;
			}
			DataTable dataTable = class216_0.method_14(new int[1] { 1 });
			bool flag = false;
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				try
				{
					while (enumerator.MoveNext() && !(flag = Convert.ToBoolean(((DataRow)enumerator.Current)[0])))
					{
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
			if (!flag)
			{
				Class355.smethod_0(Class84.smethod_0(-994270887));
				class193_0.Focus();
				return false;
			}
		}
		if (comboBox_0.SelectedIndex == 6)
		{
			if (comboBox_9.Items.Count == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994270979));
				comboBox_9.Focus();
				return false;
			}
			if (class193_1.Rows.Count == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994270855));
				return false;
			}
			DataTable dataTable2 = class216_1.method_14(new int[1] { 1 });
			bool flag2 = false;
			{
				IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
				try
				{
					while (enumerator.MoveNext() && !(flag2 = Convert.ToBoolean(((DataRow)enumerator.Current)[0])))
					{
					}
				}
				finally
				{
					IDisposable disposable2 = enumerator as IDisposable;
					if (disposable2 != null)
					{
						disposable2.Dispose();
					}
				}
			}
			if (!flag2)
			{
				Class355.smethod_0(Class84.smethod_0(-994270824));
				class193_1.Focus();
				return false;
			}
		}
		if (gcontrol1_0.method_1() == null)
		{
			Class355.smethod_0(Class84.smethod_0(-994270789));
			return false;
		}
		if (gcontrol1_0.method_1().Trim().Length < 10)
		{
			Class355.smethod_0(Class84.smethod_0(-994270810));
			return false;
		}
		return true;
	}

	private GClass70 method_11()
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

	private void method_12(string string_4)
	{
		if (!(string_4 == Class84.smethod_0(-994265321)))
		{
			if (string_4 == Class84.smethod_0(-994265342))
			{
				Cursor = Cursors.Default;
				button_1.Enabled = true;
			}
		}
		else
		{
			Cursor = Cursors.WaitCursor;
			button_1.Enabled = false;
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		if (!method_10())
		{
			return;
		}
		if (Class348.Class352.string_0.Trim().Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994278342));
			return;
		}
		string text = method_13(gcontrol1_0.method_1().Trim());
		if (text.Length > Class224.Class226.int_14)
		{
			Class355.smethod_0(string.Format(Class84.smethod_0(-994270725), Class224.Class226.int_14));
		}
		else
		{
			if (Class355.smethod_1(Class84.smethod_0(-994270699)) == DialogResult.Cancel)
			{
				return;
			}
			method_12(Class84.smethod_0(-994265321));
			GClass70 gClass = Class194.smethod_0();
			if (gClass.Value < 0)
			{
				method_12(Class84.smethod_0(-994265342));
				Class355.smethod_0(Class84.smethod_0(-994270657) + gClass.Text);
				return;
			}
			GClass70 gClass2 = method_11();
			if (gClass2.Value >= 0)
			{
				string transactionId = gClass2.Data.ToString();
				Class191 @class = new Class191
				{
					Op = (bool_1 ? Class84.smethod_0(-994270647) : Class84.smethod_0(-994270626)),
					TransactionId = transactionId
				};
				MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
				try
				{
					mySqlConnection.Open();
					MySqlTransaction mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
					MySqlCommand mySqlCommand = new MySqlCommand
					{
						Connection = mySqlConnection,
						Transaction = mySqlTransaction
					};
					string text2 = method_13(textBox_0.Text.Trim());
					string deskripsi = method_13(textBox_1.Text.Trim());
					string tglTayang = Class120.smethod_31(mySqlConnection, Class224.Class226.string_3);
					if (radioButton_0.Checked)
					{
						string text3 = string.Format(Class84.smethod_0(-994263055), comboBox_13.SelectedIndex + 1);
						text3 = text3.PadLeft(2, '0');
						tglTayang = comboBox_14.Text + Class84.smethod_0(-994278690) + text3 + Class84.smethod_0(-994278690) + comboBox_12.Text + Class84.smethod_0(-994263061) + comboBox_11.Text + Class84.smethod_0(-994263069) + comboBox_10.Text + Class84.smethod_0(-994267109);
					}
					string text4 = ((GClass2)comboBox_0.SelectedItem).method_5();
					string idDepartemen = Class84.smethod_0(-994274584);
					string text5 = string.Empty;
					string idTingkat = Class84.smethod_0(-994274584);
					List<int> list = new List<int>();
					List<int> list2 = new List<int>();
					List<string> list3 = new List<string>();
					string text6 = Class84.smethod_0(-994270650);
					if (text4.Equals(Class84.smethod_0(-994268415)))
					{
						idDepartemen = ((GClass2)comboBox_8.SelectedItem).method_5();
						text5 = ((GClass2)comboBox_8.SelectedItem).method_0();
						text6 = Class84.smethod_0(-994270613) + text5;
					}
					else if (text4.Equals(Class84.smethod_0(-994268356)))
					{
						idDepartemen = ((GClass2)comboBox_6.SelectedItem).method_5();
						text5 = ((GClass2)comboBox_6.SelectedItem).method_0();
						idTingkat = ((GClass2)comboBox_5.SelectedItem).method_5();
						text6 = Class84.smethod_0(-994270567) + comboBox_5.Text;
					}
					else if (text4.Equals(Class84.smethod_0(-994268377)))
					{
						idDepartemen = ((GClass2)comboBox_3.SelectedItem).method_5();
						text5 = ((GClass2)comboBox_3.SelectedItem).method_0();
						idTingkat = ((GClass2)comboBox_2.SelectedItem).method_5();
						string text7 = string.Empty;
						foreach (DataRow row in class216_0.method_14(new int[3] { 0, 1, 2 }).Rows)
						{
							if (Convert.ToBoolean(row[1]))
							{
								list.Add(Convert.ToInt32(row[0]));
								if (!text7.Equals(string.Empty))
								{
									text7 += Class84.smethod_0(-994271851);
								}
								text7 += row[2];
							}
						}
						text6 = Class84.smethod_0(-994270577) + comboBox_2.Text + Class84.smethod_0(-994263061) + text7;
					}
					else if (text4.Equals(Class84.smethod_0(-994268275)))
					{
						idDepartemen = ((GClass2)comboBox_9.SelectedItem).method_5();
						text5 = ((GClass2)comboBox_9.SelectedItem).method_0();
						string text8 = string.Empty;
						string text9 = string.Empty;
						foreach (DataRow row2 in class216_1.method_14(new int[3] { 0, 1, 2 }).Rows)
						{
							if (Convert.ToBoolean(row2[1]))
							{
								if (!text9.Equals(string.Empty))
								{
									text9 += Class84.smethod_0(-994279022);
								}
								text9 += row2[0];
								if (!text8.Equals(string.Empty))
								{
									text8 += Class84.smethod_0(-994271851);
								}
								text8 += row2[2];
								list2.Add(Convert.ToInt32(row2[0]));
							}
						}
						text6 = Class84.smethod_0(-994270541) + text8;
						string commandText = Class84.smethod_0(-994270502) + text9 + Class84.smethod_0(-994271866);
						mySqlCommand.CommandText = commandText;
						MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
						while (mySqlDataReader.Read())
						{
							int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994276368)]);
							string arg = string.Empty;
							string arg2 = string.Empty;
							switch (num)
							{
							case 0:
								arg = mySqlDataReader[Class84.smethod_0(-994277136)].ToString();
								arg2 = Class84.smethod_0(-994277136);
								break;
							case 1:
								arg = mySqlDataReader[Class84.smethod_0(-994266832)].ToString();
								arg2 = Class84.smethod_0(-994266832);
								break;
							case 3:
								arg = mySqlDataReader[Class84.smethod_0(-994270443)].ToString();
								arg2 = Class84.smethod_0(-994270443);
								break;
							}
							list3.Add(string.Format(Class84.smethod_0(-994270449), num, arg2, arg));
						}
						mySqlDataReader.Close();
					}
					else if (text4.Equals(Class84.smethod_0(-994268394)))
					{
						text6 = Class84.smethod_0(-994270415);
					}
					if (!bool_1)
					{
						int num2 = 0;
						do
						{
							string_0 = Class211.smethod_1(10) ?? string.Empty;
							string commandText = Class84.smethod_0(-994270426) + string_0 + Class84.smethod_0(-994271698);
							mySqlCommand.CommandText = commandText;
						}
						while (Convert.ToInt32(mySqlCommand.ExecuteScalar()) != 0);
					}
					@class.SchoolId = Class348.Class352.string_0;
					@class.IdBerita = string_0;
					@class.Judul = text2;
					@class.Deskripsi = deskripsi;
					@class.Berita = text;
					@class.TglTayang = tglTayang;
					@class.Target = text4;
					@class.IdDepartemen = idDepartemen;
					@class.Departemen = text5;
					@class.IdTingkat = idTingkat;
					@class.IdKelas = JsonConvert.SerializeObject(list);
					@class.IdKelompok = JsonConvert.SerializeObject(list2);
					@class.IdAnggota = JsonConvert.SerializeObject(list3);
					@class.Penulis = gclass5_0.gclass6_0.method_2();
					@class.NamaPenulis = gclass5_0.gclass6_0.method_4();
					@class.NamaTarget = ((text6.Length <= 255) ? text6 : text6.Substring(0, 255));
					if (bool_1)
					{
						string commandText = Class84.smethod_0(-994270367) + string_0 + Class84.smethod_0(-994271698);
						mySqlCommand.CommandText = commandText;
						mySqlCommand.ExecuteNonQuery();
						commandText = Class84.smethod_0(-994270296) + string_0 + Class84.smethod_0(-994271698);
						mySqlCommand.CommandText = commandText;
						mySqlCommand.ExecuteNonQuery();
						commandText = Class84.smethod_0(-994270222) + string_0 + Class84.smethod_0(-994271698);
						mySqlCommand.CommandText = commandText;
						mySqlCommand.ExecuteNonQuery();
						commandText = Class84.smethod_0(-994270149);
						mySqlCommand.CommandText = commandText;
						mySqlCommand.Parameters.Clear();
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269940), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269892), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269911), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269862), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269880), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269831), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269833), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269799), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269814), MySqlDbType.VarChar);
						mySqlCommand.Parameters[Class84.smethod_0(-994269940)].Value = @class.IdBerita;
						mySqlCommand.Parameters[Class84.smethod_0(-994269892)].Value = @class.Judul;
						mySqlCommand.Parameters[Class84.smethod_0(-994269911)].Value = @class.Deskripsi;
						mySqlCommand.Parameters[Class84.smethod_0(-994269862)].Value = @class.Berita;
						mySqlCommand.Parameters[Class84.smethod_0(-994269880)].Value = @class.TglTayang;
						mySqlCommand.Parameters[Class84.smethod_0(-994269831)].Value = @class.Target;
						if (!@class.Departemen.Equals(string.Empty))
						{
							mySqlCommand.Parameters[Class84.smethod_0(-994269833)].Value = @class.Departemen;
						}
						if (!@class.IdTingkat.Equals(Class84.smethod_0(-994274584)))
						{
							mySqlCommand.Parameters[Class84.smethod_0(-994269799)].Value = @class.IdTingkat;
						}
						mySqlCommand.Parameters[Class84.smethod_0(-994269814)].Value = ((gclass5_0.gclass6_0.method_6() == 0) ? null : gclass5_0.gclass6_0.method_2());
						mySqlCommand.ExecuteNonQuery();
					}
					else
					{
						string commandText = Class84.smethod_0(-994269767);
						mySqlCommand.CommandText = commandText;
						mySqlCommand.Parameters.Clear();
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269940), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269892), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269911), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269862), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269880), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269831), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269833), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269799), MySqlDbType.VarChar);
						mySqlCommand.Parameters.Add(Class84.smethod_0(-994269814), MySqlDbType.VarChar);
						mySqlCommand.Parameters[Class84.smethod_0(-994269940)].Value = @class.IdBerita;
						mySqlCommand.Parameters[Class84.smethod_0(-994269892)].Value = @class.Judul;
						mySqlCommand.Parameters[Class84.smethod_0(-994269911)].Value = @class.Deskripsi;
						mySqlCommand.Parameters[Class84.smethod_0(-994269862)].Value = @class.Berita;
						mySqlCommand.Parameters[Class84.smethod_0(-994269880)].Value = @class.TglTayang;
						mySqlCommand.Parameters[Class84.smethod_0(-994269831)].Value = @class.Target;
						if (!@class.Departemen.Equals(string.Empty))
						{
							mySqlCommand.Parameters[Class84.smethod_0(-994269833)].Value = @class.Departemen;
						}
						if (!@class.IdTingkat.Equals(Class84.smethod_0(-994274584)))
						{
							mySqlCommand.Parameters[Class84.smethod_0(-994269799)].Value = @class.IdTingkat;
						}
						mySqlCommand.Parameters[Class84.smethod_0(-994269814)].Value = ((gclass5_0.gclass6_0.method_6() == 0) ? null : gclass5_0.gclass6_0.method_2());
						mySqlCommand.ExecuteNonQuery();
					}
					if (list.Count > 0)
					{
						string commandText = Class84.smethod_0(-994269579);
						foreach (int item in list)
						{
							mySqlCommand.CommandText = string.Format(commandText, string_0, item);
							mySqlCommand.ExecuteNonQuery();
						}
					}
					if (list2.Count > 0)
					{
						string commandText = Class84.smethod_0(-994269521);
						foreach (int item2 in list2)
						{
							mySqlCommand.CommandText = string.Format(commandText, string_0, item2);
							mySqlCommand.ExecuteNonQuery();
						}
					}
					if (list3.Count > 0)
					{
						string commandText = Class84.smethod_0(-994269409);
						foreach (string item3 in list3)
						{
							string[] array = item3.Split(':');
							if (array.Length == 3)
							{
								string text10 = array[0];
								string text11 = array[1];
								string text12 = array[2];
								mySqlCommand.CommandText = string.Format(commandText, string_0, text10, text11, text12);
								mySqlCommand.ExecuteNonQuery();
							}
						}
					}
					if (checkBox_0.Checked)
					{
						string text13 = Class120.smethod_31(mySqlConnection, Class224.Class226.string_3);
						if (radioButton_0.Checked)
						{
							text13 = comboBox_14.Text + Class84.smethod_0(-994278690);
							text13 = text13 + (comboBox_13.SelectedIndex + 1).ToString().PadLeft(2, '0') + Class84.smethod_0(-994278690);
							text13 = text13 + comboBox_12.Text.PadLeft(2, '0') + Class84.smethod_0(-994263061);
							text13 = text13 + comboBox_11.Text.PadLeft(2, '0') + Class84.smethod_0(-994263069);
							text13 = text13 + comboBox_10.Text.PadLeft(2, '0') + Class84.smethod_0(-994267109);
						}
						Class156 class2 = new Class156(mySqlCommand);
						if (text4.Equals(Class84.smethod_0(-994268448)))
						{
							string text14 = Class348.Class352.string_0 + Class84.smethod_0(-994269372);
							class2.method_0(text14, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
							text14 = Class348.Class352.string_0 + Class84.smethod_0(-994269372);
							class2.method_4(string.Empty, string.Empty, string.Empty, text14, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
						}
						else if (text4.Equals(Class84.smethod_0(-994268389)))
						{
							string text15 = Class348.Class352.string_0 + Class84.smethod_0(-994269343);
							class2.method_0(text15, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
							text15 = Class348.Class352.string_0 + Class84.smethod_0(-994269343);
							class2.method_4(string.Empty, string.Empty, string.Empty, text15, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
						}
						else if (text4.Equals(Class84.smethod_0(-994268394)))
						{
							string text16 = Class348.Class352.string_0 + Class84.smethod_0(-994269283);
							class2.method_0(text16, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
							text16 = Class348.Class352.string_0 + Class84.smethod_0(-994269283);
							class2.method_4(string.Empty, string.Empty, string.Empty, text16, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
						}
						else if (text4.Equals(Class84.smethod_0(-994268415)))
						{
							string text17 = Class348.Class352.string_0 + Class84.smethod_0(-994269303) + @class.IdDepartemen;
							class2.method_0(text17, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
							text17 = Class348.Class352.string_0 + Class84.smethod_0(-994269303) + @class.IdDepartemen;
							class2.method_4(string.Empty, string.Empty, string.Empty, text17, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
						}
						else if (text4.Equals(Class84.smethod_0(-994268356)))
						{
							string text18 = Class348.Class352.string_0 + Class84.smethod_0(-994269306) + @class.IdTingkat;
							class2.method_0(text18, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
							text18 = Class348.Class352.string_0 + Class84.smethod_0(-994269306) + @class.IdTingkat;
							class2.method_4(string.Empty, string.Empty, string.Empty, text18, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
						}
						else if (text4.Equals(Class84.smethod_0(-994268377)))
						{
							foreach (int item4 in list)
							{
								string text19 = Class348.Class352.string_0 + Class84.smethod_0(-994269261) + item4;
								class2.method_0(text19, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
								text19 = Class348.Class352.string_0 + Class84.smethod_0(-994269261) + item4;
								class2.method_4(string.Empty, string.Empty, string.Empty, text19, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
							}
						}
						else if (text4.Equals(Class84.smethod_0(-994268275)))
						{
							List<string> list4 = new List<string>();
							string commandText = Class84.smethod_0(-994269280);
							foreach (string item5 in list3)
							{
								string[] array2 = item5.Split(':');
								if (array2.Length == 3)
								{
									string text20 = array2[1];
									string arg3 = array2[2];
									mySqlCommand.CommandText = string.Format(commandText, text20, arg3);
									MySqlDataReader mySqlDataReader2 = mySqlCommand.ExecuteReader();
									while (mySqlDataReader2.Read())
									{
										list4.Add(mySqlDataReader2[Class84.smethod_0(-994267115)].ToString());
									}
									mySqlDataReader2.Close();
									if (text20.Equals(Class84.smethod_0(-994277136)))
									{
										class2.method_4(arg3, string.Empty, string.Empty, string.Empty, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
									}
									else if (text20.Equals(Class84.smethod_0(-994266832)))
									{
										class2.method_4(string.Empty, arg3, string.Empty, string.Empty, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
									}
									else if (text20.Equals(Class84.smethod_0(-994270443)))
									{
										class2.method_4(string.Empty, string.Empty, arg3, string.Empty, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
									}
								}
							}
							string text21 = JsonConvert.SerializeObject(list4);
							class2.method_2(text21, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text13);
						}
					}
					var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(@class), Class320.int_5, 10000);
					NameValueCollection data = new NameValueCollection { { name, value } };
					Class139 class3 = new Class139(smethod_0());
					GClass70 gClass3;
					try
					{
						byte[] bytes = class3.UploadValues(Class272.smethod_11(), Class84.smethod_0(-994265316), data);
						gClass3 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
					}
					finally
					{
						((IDisposable)class3).Dispose();
					}
					method_12(Class84.smethod_0(-994265342));
					if (gClass3.Value == 1)
					{
						mySqlTransaction?.Commit();
						Class355.smethod_3(Class84.smethod_0(-994256874));
						Close();
						gform8_0.method_10();
					}
					else
					{
						mySqlTransaction?.Rollback();
						Class355.smethod_0(Class84.smethod_0(-994256846) + gClass3.Text);
					}
					return;
				}
				catch (Exception ex)
				{
					method_12(Class84.smethod_0(-994265342));
					Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, Class84.smethod_0(-994256815) + ex.Message, ex);
					return;
				}
				finally
				{
					mySqlConnection?.Close();
				}
			}
			method_12(Class84.smethod_0(-994265342));
			Class355.smethod_0(Class84.smethod_0(-994270657) + gClass2.Text);
		}
	}

	private string method_13(string string_4)
	{
		string_4 = string_4.Replace('"', '\'');
		string_4 = string_4.Replace('\'', '\'');
		return string_4;
	}

	private void GForm36_Shown(object sender, EventArgs e)
	{
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_14()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm36));
		panel_0 = new Panel();
		label_0 = new Label();
		splitContainer_0 = new SplitContainer();
		comboBox_10 = new ComboBox();
		comboBox_11 = new ComboBox();
		comboBox_12 = new ComboBox();
		comboBox_13 = new ComboBox();
		comboBox_14 = new ComboBox();
		radioButton_0 = new RadioButton();
		radioButton_1 = new RadioButton();
		label_16 = new Label();
		panel_4 = new Panel();
		class193_1 = new Class193();
		label_13 = new Label();
		comboBox_9 = new ComboBox();
		label_14 = new Label();
		panel_1 = new Panel();
		class193_0 = new Class193();
		comboBox_1 = new ComboBox();
		label_4 = new Label();
		label_5 = new Label();
		comboBox_2 = new ComboBox();
		label_6 = new Label();
		comboBox_3 = new ComboBox();
		label_7 = new Label();
		panel_2 = new Panel();
		comboBox_4 = new ComboBox();
		label_8 = new Label();
		comboBox_5 = new ComboBox();
		label_9 = new Label();
		comboBox_6 = new ComboBox();
		label_10 = new Label();
		panel_3 = new Panel();
		comboBox_7 = new ComboBox();
		label_11 = new Label();
		comboBox_8 = new ComboBox();
		label_12 = new Label();
		comboBox_0 = new ComboBox();
		label_3 = new Label();
		textBox_1 = new TextBox();
		label_2 = new Label();
		textBox_0 = new TextBox();
		label_1 = new Label();
		checkBox_0 = new CheckBox();
		button_0 = new Button();
		button_1 = new Button();
		gcontrol1_0 = new GControl1();
		label_15 = new Label();
		panel_0.SuspendLayout();
		((ISupportInitialize)splitContainer_0).BeginInit();
		splitContainer_0.Panel1.SuspendLayout();
		splitContainer_0.Panel2.SuspendLayout();
		splitContainer_0.SuspendLayout();
		panel_4.SuspendLayout();
		((ISupportInitialize)class193_1).BeginInit();
		panel_1.SuspendLayout();
		((ISupportInitialize)class193_0).BeginInit();
		panel_2.SuspendLayout();
		panel_3.SuspendLayout();
		SuspendLayout();
		panel_0.Controls.Add(label_0);
		panel_0.Dock = DockStyle.Top;
		panel_0.Location = new Point(0, 0);
		panel_0.Name = Class84.smethod_0(-994256784);
		panel_0.Size = new Size(1176, 44);
		panel_0.TabIndex = 0;
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994256787), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994266659);
		label_0.Size = new Size(93, 17);
		label_0.TabIndex = 70;
		label_0.Text = Class84.smethod_0(-994270650);
		splitContainer_0.BackColor = Color.Gainsboro;
		splitContainer_0.Dock = DockStyle.Fill;
		splitContainer_0.Location = new Point(0, 44);
		splitContainer_0.Name = Class84.smethod_0(-994256742);
		splitContainer_0.Panel1.BackColor = SystemColors.Control;
		splitContainer_0.Panel1.Controls.Add(comboBox_10);
		splitContainer_0.Panel1.Controls.Add(comboBox_11);
		splitContainer_0.Panel1.Controls.Add(comboBox_12);
		splitContainer_0.Panel1.Controls.Add(comboBox_13);
		splitContainer_0.Panel1.Controls.Add(comboBox_14);
		splitContainer_0.Panel1.Controls.Add(radioButton_0);
		splitContainer_0.Panel1.Controls.Add(radioButton_1);
		splitContainer_0.Panel1.Controls.Add(label_16);
		splitContainer_0.Panel1.Controls.Add(panel_4);
		splitContainer_0.Panel1.Controls.Add(panel_1);
		splitContainer_0.Panel1.Controls.Add(panel_2);
		splitContainer_0.Panel1.Controls.Add(panel_3);
		splitContainer_0.Panel1.Controls.Add(comboBox_0);
		splitContainer_0.Panel1.Controls.Add(label_3);
		splitContainer_0.Panel1.Controls.Add(textBox_1);
		splitContainer_0.Panel1.Controls.Add(label_2);
		splitContainer_0.Panel1.Controls.Add(textBox_0);
		splitContainer_0.Panel1.Controls.Add(label_1);
		splitContainer_0.Panel2.BackColor = SystemColors.Control;
		splitContainer_0.Panel2.Controls.Add(checkBox_0);
		splitContainer_0.Panel2.Controls.Add(button_0);
		splitContainer_0.Panel2.Controls.Add(button_1);
		splitContainer_0.Panel2.Controls.Add(gcontrol1_0);
		splitContainer_0.Panel2.Controls.Add(label_15);
		splitContainer_0.Size = new Size(1176, 693);
		splitContainer_0.SplitterDistance = 588;
		splitContainer_0.TabIndex = 1;
		comboBox_10.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_10.Enabled = false;
		comboBox_10.FormattingEnabled = true;
		comboBox_10.Location = new Point(471, 197);
		comboBox_10.Name = Class84.smethod_0(-994266617);
		comboBox_10.Size = new Size(45, 21);
		comboBox_10.TabIndex = 130;
		comboBox_11.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_11.Enabled = false;
		comboBox_11.FormattingEnabled = true;
		comboBox_11.Location = new Point(420, 197);
		comboBox_11.Name = Class84.smethod_0(-994266570);
		comboBox_11.Size = new Size(45, 21);
		comboBox_11.TabIndex = 129;
		comboBox_12.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_12.Enabled = false;
		comboBox_12.FormattingEnabled = true;
		comboBox_12.Location = new Point(360, 197);
		comboBox_12.Name = Class84.smethod_0(-994266589);
		comboBox_12.Size = new Size(45, 21);
		comboBox_12.TabIndex = 128;
		comboBox_13.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_13.Enabled = false;
		comboBox_13.FormattingEnabled = true;
		comboBox_13.Location = new Point(268, 197);
		comboBox_13.Name = Class84.smethod_0(-994266540);
		comboBox_13.Size = new Size(86, 21);
		comboBox_13.TabIndex = 127;
		comboBox_13.SelectedIndexChanged += comboBox_13_SelectedIndexChanged;
		comboBox_14.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_14.Enabled = false;
		comboBox_14.FormattingEnabled = true;
		comboBox_14.Location = new Point(209, 197);
		comboBox_14.Name = Class84.smethod_0(-994266557);
		comboBox_14.Size = new Size(53, 21);
		comboBox_14.TabIndex = 126;
		comboBox_14.SelectedIndexChanged += comboBox_14_SelectedIndexChanged;
		radioButton_0.AutoSize = true;
		radioButton_0.Location = new Point(96, 197);
		radioButton_0.Name = Class84.smethod_0(-994266510);
		radioButton_0.Size = new Size(103, 17);
		radioButton_0.TabIndex = 125;
		radioButton_0.Text = Class84.smethod_0(-994266527);
		radioButton_0.UseVisualStyleBackColor = true;
		radioButton_0.CheckedChanged += radioButton_0_CheckedChanged;
		radioButton_1.AutoSize = true;
		radioButton_1.Checked = true;
		radioButton_1.Location = new Point(96, 167);
		radioButton_1.Name = Class84.smethod_0(-994266473);
		radioButton_1.Size = new Size(71, 17);
		radioButton_1.TabIndex = 124;
		radioButton_1.TabStop = true;
		radioButton_1.Text = Class84.smethod_0(-994266493);
		radioButton_1.UseVisualStyleBackColor = true;
		radioButton_1.CheckedChanged += radioButton_1_CheckedChanged;
		label_16.AutoSize = true;
		label_16.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_16.Location = new Point(37, 169);
		label_16.Name = Class84.smethod_0(-994266446);
		label_16.Size = new Size(53, 13);
		label_16.TabIndex = 123;
		label_16.Text = Class84.smethod_0(-994256768);
		label_16.TextAlign = ContentAlignment.TopRight;
		panel_4.Controls.Add(class193_1);
		panel_4.Controls.Add(label_13);
		panel_4.Controls.Add(comboBox_9);
		panel_4.Controls.Add(label_14);
		panel_4.Location = new Point(8, 573);
		panel_4.Name = Class84.smethod_0(-994256706);
		panel_4.Size = new Size(555, 131);
		panel_4.TabIndex = 122;
		panel_4.Visible = false;
		class193_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_1.BackgroundColor = Color.White;
		class193_1.BorderStyle = BorderStyle.None;
		class193_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_1.Location = new Point(88, 34);
		class193_1.Name = Class84.smethod_0(-994256731);
		class193_1.Size = new Size(460, 89);
		class193_1.TabIndex = 116;
		label_13.AutoSize = true;
		label_13.Location = new Point(28, 34);
		label_13.Name = Class84.smethod_0(-994256681);
		label_13.Size = new Size(54, 13);
		label_13.TabIndex = 89;
		label_13.Text = Class84.smethod_0(-994268178);
		comboBox_9.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_9.FormattingEnabled = true;
		comboBox_9.Location = new Point(88, 7);
		comboBox_9.Name = Class84.smethod_0(-994256699);
		comboBox_9.Size = new Size(162, 21);
		comboBox_9.TabIndex = 46;
		comboBox_9.SelectedIndexChanged += comboBox_9_SelectedIndexChanged;
		label_14.AutoSize = true;
		label_14.Location = new Point(17, 10);
		label_14.Name = Class84.smethod_0(-994256663);
		label_14.Size = new Size(65, 13);
		label_14.TabIndex = 1;
		label_14.Text = Class84.smethod_0(-994264227);
		panel_1.Controls.Add(class193_0);
		panel_1.Controls.Add(comboBox_1);
		panel_1.Controls.Add(label_4);
		panel_1.Controls.Add(label_5);
		panel_1.Controls.Add(comboBox_2);
		panel_1.Controls.Add(label_6);
		panel_1.Controls.Add(comboBox_3);
		panel_1.Controls.Add(label_7);
		panel_1.Location = new Point(8, 403);
		panel_1.Name = Class84.smethod_0(-994256665);
		panel_1.Size = new Size(555, 164);
		panel_1.TabIndex = 121;
		panel_1.Visible = false;
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(88, 34);
		class193_0.Name = Class84.smethod_0(-994256629);
		class193_0.Size = new Size(460, 89);
		class193_0.TabIndex = 115;
		comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_1.FormattingEnabled = true;
		comboBox_1.Location = new Point(88, 129);
		comboBox_1.Name = Class84.smethod_0(-994256582);
		comboBox_1.Size = new Size(232, 21);
		comboBox_1.TabIndex = 114;
		comboBox_1.Visible = false;
		label_4.AutoSize = true;
		label_4.Location = new Point(50, 132);
		label_4.Name = Class84.smethod_0(-994256593);
		label_4.Size = new Size(31, 13);
		label_4.TabIndex = 113;
		label_4.Text = Class84.smethod_0(-994256547);
		label_4.Visible = false;
		label_5.AutoSize = true;
		label_5.Location = new Point(49, 34);
		label_5.Name = Class84.smethod_0(-994256567);
		label_5.Size = new Size(33, 13);
		label_5.TabIndex = 53;
		label_5.Text = Class84.smethod_0(-994278020);
		comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_2.FormattingEnabled = true;
		comboBox_2.Location = new Point(305, 7);
		comboBox_2.Name = Class84.smethod_0(-994256569);
		comboBox_2.Size = new Size(91, 21);
		comboBox_2.TabIndex = 52;
		comboBox_2.SelectedIndexChanged += comboBox_2_SelectedIndexChanged;
		label_6.AutoSize = true;
		label_6.Location = new Point(256, 10);
		label_6.Name = Class84.smethod_0(-994256530);
		label_6.Size = new Size(43, 13);
		label_6.TabIndex = 51;
		label_6.Text = Class84.smethod_0(-994256485);
		comboBox_3.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_3.FormattingEnabled = true;
		comboBox_3.Location = new Point(88, 7);
		comboBox_3.Name = Class84.smethod_0(-994256503);
		comboBox_3.Size = new Size(162, 21);
		comboBox_3.TabIndex = 50;
		comboBox_3.SelectedIndexChanged += comboBox_3_SelectedIndexChanged;
		label_7.AutoSize = true;
		label_7.Location = new Point(17, 10);
		label_7.Name = Class84.smethod_0(-994256451);
		label_7.Size = new Size(65, 13);
		label_7.TabIndex = 49;
		label_7.Text = Class84.smethod_0(-994264227);
		panel_2.Controls.Add(comboBox_4);
		panel_2.Controls.Add(label_8);
		panel_2.Controls.Add(comboBox_5);
		panel_2.Controls.Add(label_9);
		panel_2.Controls.Add(comboBox_6);
		panel_2.Controls.Add(label_10);
		panel_2.Location = new Point(8, 332);
		panel_2.Name = Class84.smethod_0(-994256469);
		panel_2.Size = new Size(605, 65);
		panel_2.TabIndex = 120;
		panel_2.Visible = false;
		comboBox_4.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_4.FormattingEnabled = true;
		comboBox_4.Location = new Point(88, 34);
		comboBox_4.Name = Class84.smethod_0(-994256431);
		comboBox_4.Size = new Size(232, 21);
		comboBox_4.TabIndex = 51;
		comboBox_4.Visible = false;
		label_8.AutoSize = true;
		label_8.Location = new Point(50, 37);
		label_8.Name = Class84.smethod_0(-994256442);
		label_8.Size = new Size(31, 13);
		label_8.TabIndex = 50;
		label_8.Text = Class84.smethod_0(-994256547);
		label_8.Visible = false;
		comboBox_5.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_5.FormattingEnabled = true;
		comboBox_5.Location = new Point(305, 7);
		comboBox_5.Name = Class84.smethod_0(-994256396);
		comboBox_5.Size = new Size(103, 21);
		comboBox_5.TabIndex = 48;
		label_9.AutoSize = true;
		label_9.Location = new Point(256, 10);
		label_9.Name = Class84.smethod_0(-994256357);
		label_9.Size = new Size(43, 13);
		label_9.TabIndex = 47;
		label_9.Text = Class84.smethod_0(-994256485);
		comboBox_6.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_6.FormattingEnabled = true;
		comboBox_6.Location = new Point(88, 7);
		comboBox_6.Name = Class84.smethod_0(-994256376);
		comboBox_6.Size = new Size(162, 21);
		comboBox_6.TabIndex = 46;
		comboBox_6.SelectedIndexChanged += comboBox_6_SelectedIndexChanged;
		label_10.AutoSize = true;
		label_10.Location = new Point(17, 10);
		label_10.Name = Class84.smethod_0(-994266391);
		label_10.Size = new Size(65, 13);
		label_10.TabIndex = 1;
		label_10.Text = Class84.smethod_0(-994264227);
		panel_3.Controls.Add(comboBox_7);
		panel_3.Controls.Add(label_11);
		panel_3.Controls.Add(comboBox_8);
		panel_3.Controls.Add(label_12);
		panel_3.Location = new Point(8, 258);
		panel_3.Name = Class84.smethod_0(-994256324);
		panel_3.Size = new Size(555, 68);
		panel_3.TabIndex = 119;
		panel_3.Visible = false;
		comboBox_7.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_7.FormattingEnabled = true;
		comboBox_7.Location = new Point(89, 32);
		comboBox_7.Name = Class84.smethod_0(-994256337);
		comboBox_7.Size = new Size(232, 21);
		comboBox_7.TabIndex = 49;
		comboBox_7.Visible = false;
		label_11.AutoSize = true;
		label_11.Location = new Point(51, 35);
		label_11.Name = Class84.smethod_0(-994266638);
		label_11.Size = new Size(31, 13);
		label_11.TabIndex = 48;
		label_11.Text = Class84.smethod_0(-994256547);
		label_11.Visible = false;
		comboBox_8.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_8.FormattingEnabled = true;
		comboBox_8.Location = new Point(88, 5);
		comboBox_8.Name = Class84.smethod_0(-994256300);
		comboBox_8.Size = new Size(232, 21);
		comboBox_8.TabIndex = 47;
		label_12.AutoSize = true;
		label_12.Location = new Point(17, 8);
		label_12.Name = Class84.smethod_0(-994266614);
		label_12.Size = new Size(65, 13);
		label_12.TabIndex = 1;
		label_12.Text = Class84.smethod_0(-994264227);
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Location = new Point(96, 231);
		comboBox_0.Name = Class84.smethod_0(-994256264);
		comboBox_0.Size = new Size(223, 21);
		comboBox_0.TabIndex = 118;
		comboBox_0.SelectedIndexChanged += comboBox_0_SelectedIndexChanged;
		label_3.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_3.Location = new Point(12, 234);
		label_3.Name = Class84.smethod_0(-994266720);
		label_3.Size = new Size(78, 33);
		label_3.TabIndex = 117;
		label_3.Text = Class84.smethod_0(-994256265);
		label_3.TextAlign = ContentAlignment.TopRight;
		textBox_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_1.Font = new Font(Class84.smethod_0(-994278794), 11f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_1.Location = new Point(96, 51);
		textBox_1.MaxLength = 2000;
		textBox_1.Multiline = true;
		textBox_1.Name = Class84.smethod_0(-994256283);
		textBox_1.Size = new Size(471, 106);
		textBox_1.TabIndex = 116;
		label_2.AutoSize = true;
		label_2.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_2.Location = new Point(27, 51);
		label_2.Name = Class84.smethod_0(-994278834);
		label_2.Size = new Size(63, 13);
		label_2.TabIndex = 115;
		label_2.Text = Class84.smethod_0(-994256233);
		label_2.TextAlign = ContentAlignment.TopRight;
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Font = new Font(Class84.smethod_0(-994278794), 11f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_0.Location = new Point(96, 14);
		textBox_0.MaxLength = 255;
		textBox_0.Name = Class84.smethod_0(-994256200);
		textBox_0.Size = new Size(471, 24);
		textBox_0.TabIndex = 114;
		label_1.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_1.Location = new Point(12, 21);
		label_1.Name = Class84.smethod_0(-994278767);
		label_1.Size = new Size(78, 33);
		label_1.TabIndex = 113;
		label_1.Text = Class84.smethod_0(-994256202);
		label_1.TextAlign = ContentAlignment.TopRight;
		checkBox_0.AutoSize = true;
		checkBox_0.Checked = true;
		checkBox_0.CheckState = CheckState.Checked;
		checkBox_0.Location = new Point(119, 617);
		checkBox_0.Name = Class84.smethod_0(-994256221);
		checkBox_0.Size = new Size(151, 17);
		checkBox_0.TabIndex = 122;
		checkBox_0.Text = Class84.smethod_0(-994256170);
		checkBox_0.UseVisualStyleBackColor = true;
		button_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		button_0.Image = Class309.smethod_10();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(479, 602);
		button_0.Name = Class84.smethod_0(-994278087);
		button_0.Size = new Size(79, 33);
		button_0.TabIndex = 121;
		button_0.Text = Class84.smethod_0(-994278089);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		button_1.Image = Class309.smethod_24();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(19, 602);
		button_1.Name = Class84.smethod_0(-994266730);
		button_1.Size = new Size(94, 45);
		button_1.TabIndex = 120;
		button_1.Text = Class84.smethod_0(-994266747);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		gcontrol1_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol1_0.method_2(null);
		gcontrol1_0.Location = new Point(19, 30);
		gcontrol1_0.Name = Class84.smethod_0(-994256137);
		gcontrol1_0.Size = new Size(539, 552);
		gcontrol1_0.TabIndex = 119;
		label_15.AutoSize = true;
		label_15.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_15.Location = new Point(16, 14);
		label_15.Name = Class84.smethod_0(-994256112);
		label_15.Size = new Size(44, 13);
		label_15.TabIndex = 118;
		label_15.Text = Class84.smethod_0(-994256114);
		label_15.TextAlign = ContentAlignment.TopRight;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1176, 737);
		Controls.Add(splitContainer_0);
		Controls.Add(panel_0);
		Icon = (Icon)componentResourceManager.GetObject(Class84.smethod_0(-994278109));
		Name = Class84.smethod_0(-994256068);
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class84.smethod_0(-994270650);
		Load += GForm36_Load;
		Shown += GForm36_Shown;
		panel_0.ResumeLayout(performLayout: false);
		panel_0.PerformLayout();
		splitContainer_0.Panel1.ResumeLayout(performLayout: false);
		splitContainer_0.Panel1.PerformLayout();
		splitContainer_0.Panel2.ResumeLayout(performLayout: false);
		splitContainer_0.Panel2.PerformLayout();
		((ISupportInitialize)splitContainer_0).EndInit();
		splitContainer_0.ResumeLayout(performLayout: false);
		panel_4.ResumeLayout(performLayout: false);
		panel_4.PerformLayout();
		((ISupportInitialize)class193_1).EndInit();
		panel_1.ResumeLayout(performLayout: false);
		panel_1.PerformLayout();
		((ISupportInitialize)class193_0).EndInit();
		panel_2.ResumeLayout(performLayout: false);
		panel_2.PerformLayout();
		panel_3.ResumeLayout(performLayout: false);
		panel_3.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
