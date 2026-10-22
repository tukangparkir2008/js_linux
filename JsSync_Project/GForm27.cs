using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

public sealed class GForm27 : Form
{
	private Class216 class216_0;

	private DataTable dataTable_0;

	private string string_0;

	private int int_0;

	private readonly HashSet<int> hashSet_0 = new HashSet<int>();

	private readonly HashSet<int> hashSet_1 = new HashSet<int>();

	private int int_1;

	private readonly GForm33 gform33_0;

	private IContainer icontainer_0;

	private Button button_0;

	private Button button_1;

	private Class193 class193_0;

	private Label label_0;

	private ComboBox comboBox_0;

	private Label label_1;

	public GForm27(GForm33 gform33_1)
	{
		gform33_0 = gform33_1;
		method_7();
		method_0();
	}

	private void method_0()
	{
		try
		{
			class216_0 = new Class216(class193_0, bool_0: false, bool_1: false);
			class216_0.method_5(Class84.smethod_0(-994263061), 40, bool_0: false);
			class216_0.method_2(Class84.smethod_0(-994264227), 270, bool_0: true);
			class216_0.method_4();
			dataTable_0 = new DataTable();
			dataTable_0.Columns.Add(Class84.smethod_0(-994276469), Type.GetType(Class84.smethod_0(-994276372)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994249586), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994249543), Type.GetType(Class84.smethod_0(-994276372)));
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_1(string string_1)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			hashSet_0.Clear();
			hashSet_1.Clear();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994249546) + string_1 + Class84.smethod_0(-994271698), mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				hashSet_0.Add(Convert.ToInt32(mySqlDataReader[0]));
			}
			mySqlDataReader.Close();
			string_0 = string_1;
			int_0 = 0;
			method_4();
			method_3();
			comboBox_0.Enabled = true;
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_2(string string_1, int int_2, int int_3, string string_2)
	{
		try
		{
			string_0 = string_1;
			int_0 = int_2;
			int_1 = int_3;
			List<int>? list = JsonConvert.DeserializeObject<List<int>>(string_2);
			hashSet_0.Clear();
			hashSet_1.Clear();
			foreach (int item in list)
			{
				hashSet_1.Add(item);
			}
			method_4();
			method_3();
			comboBox_0.Enabled = false;
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_3()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994249423), mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				int num = Convert.ToInt32(mySqlDataReader[0]);
				string value = mySqlDataReader[1].ToString();
				DataRow dataRow = dataTable_0.NewRow();
				dataRow[Class84.smethod_0(-994276469)] = (hashSet_1.Contains(num) ? 1 : 0);
				dataRow[Class84.smethod_0(-994249586)] = value;
				dataRow[Class84.smethod_0(-994249543)] = num;
				dataTable_0.Rows.Add(dataRow);
			}
			mySqlDataReader.Close();
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

	private void method_4()
	{
		int selectedIndex = 0;
		for (int i = 1; i <= Class127.int_0; i++)
		{
			if (!hashSet_0.Contains(i))
			{
				ComboBox.ObjectCollection items = comboBox_0.Items;
				GClass2 gClass = new GClass2();
				gClass.method_1(Class127.smethod_0((Enum3)i));
				gClass.method_3(i);
				items.Add(gClass);
				if (i == int_1)
				{
					selectedIndex = i - 1;
				}
			}
		}
		comboBox_0.SelectedIndex = selectedIndex;
	}

	private void GForm27_Load(object sender, EventArgs e)
	{
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		DataTable dataTable = class216_0.method_16();
		int num = 0;
		foreach (DataRow row in dataTable.Rows)
		{
			if (Convert.ToInt32(row[0]) == 1)
			{
				num++;
			}
		}
		if (num == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994249290));
		}
		else if (int_0 == 0)
		{
			method_5();
		}
		else
		{
			method_6();
		}
	}

	private void method_5()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		try
		{
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			string commandText = string.Format(Class84.smethod_0(-994249271), string_0, ((GClass2)comboBox_0.SelectedItem).method_4());
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			int num = 0;
			commandText = Class84.smethod_0(-994260596);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			string text = string.Empty;
			foreach (DataRow row in class216_0.method_16().Rows)
			{
				int num2 = Convert.ToInt32(row[0]);
				string text2 = row[2].ToString();
				if (num2 == 1)
				{
					if (!text.Equals(string.Empty))
					{
						text += Class84.smethod_0(-994279022);
					}
					text += text2;
				}
			}
			string arg = Class84.smethod_0(-994267367) + text + Class84.smethod_0(-994267375);
			commandText = string.Format(Class84.smethod_0(-994249150), arg, num);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			mySqlTransaction.Commit();
			gform33_0.method_5();
			Close();
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private void method_6()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		try
		{
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			string text = string.Empty;
			foreach (DataRow row in class216_0.method_16().Rows)
			{
				int num = Convert.ToInt32(row[0]);
				string text2 = row[2].ToString();
				if (num == 1)
				{
					if (!text.Equals(string.Empty))
					{
						text += Class84.smethod_0(-994279022);
					}
					text += text2;
				}
			}
			string arg = Class84.smethod_0(-994267367) + text + Class84.smethod_0(-994267375);
			string commandText = string.Format(Class84.smethod_0(-994249001), ((GClass2)comboBox_0.SelectedItem).method_4(), arg, int_0);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			mySqlTransaction.Commit();
			gform33_0.method_5();
			Close();
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			int num = ((GClass2)comboBox_0.SelectedItem).method_4();
			int num2 = 0;
			bool enabled = true;
			if (num == 5)
			{
				num2 = 1;
				enabled = false;
			}
			foreach (DataRow row in dataTable_0.Rows)
			{
				row[Class84.smethod_0(-994276469)] = num2;
			}
			class193_0.Enabled = enabled;
			class216_0.method_9(dataTable_0);
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_7()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm27));
		button_0 = new Button();
		button_1 = new Button();
		class193_0 = new Class193();
		label_0 = new Label();
		comboBox_0 = new ComboBox();
		label_1 = new Label();
		((ISupportInitialize)class193_0).BeginInit();
		SuspendLayout();
		button_0.Image = Class309.smethod_10();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(232, 262);
		button_0.Name = Class84.smethod_0(-994278087);
		button_0.Size = new Size(75, 23);
		button_0.TabIndex = 106;
		button_0.Text = Class84.smethod_0(-994278089);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		button_1.Image = Class309.smethod_24();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(151, 262);
		button_1.Name = Class84.smethod_0(-994266730);
		button_1.Size = new Size(75, 23);
		button_1.TabIndex = 105;
		button_1.Text = Class84.smethod_0(-994266747);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(33, 73);
		class193_0.Name = Class84.smethod_0(-994248875);
		class193_0.Size = new Size(391, 173);
		class193_0.TabIndex = 104;
		label_0.AutoSize = true;
		label_0.Location = new Point(30, 57);
		label_0.Name = Class84.smethod_0(-994278767);
		label_0.Size = new Size(65, 13);
		label_0.TabIndex = 103;
		label_0.Text = Class84.smethod_0(-994264227);
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Location = new Point(80, 22);
		comboBox_0.Name = Class84.smethod_0(-994248893);
		comboBox_0.Size = new Size(299, 21);
		comboBox_0.TabIndex = 102;
		comboBox_0.SelectedIndexChanged += comboBox_0_SelectedIndexChanged;
		label_1.AutoSize = true;
		label_1.Location = new Point(30, 25);
		label_1.Name = Class84.smethod_0(-994278834);
		label_1.Size = new Size(35, 13);
		label_1.TabIndex = 101;
		label_1.Text = Class84.smethod_0(-994248847);
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(455, 307);
		Controls.Add(button_0);
		Controls.Add(button_1);
		Controls.Add(class193_0);
		Controls.Add(label_0);
		Controls.Add(comboBox_0);
		Controls.Add(label_1);
		Icon = (Icon)componentResourceManager.GetObject(Class84.smethod_0(-994278109));
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class84.smethod_0(-994248851);
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class84.smethod_0(-994248801);
		Load += GForm27_Load;
		((ISupportInitialize)class193_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
