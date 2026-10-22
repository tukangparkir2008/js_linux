using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm35 : Form
{
	[Serializable]
	private sealed class Class344
	{
		public static readonly Class344 class344_0 = new Class344();

		public static Func<DataRow, string> func_0;

		internal string method_0(DataRow dataRow_0)
		{
			return Convert.ToString(dataRow_0[0]);
		}
	}

	private readonly GForm17 gform17_0;

	private DataTable dataTable_0;

	private Class216 class216_0;

	private bool bool_0;

	private IContainer icontainer_0;

	private Label label_0;

	private Button button_0;

	private Label label_1;

	private ComboBox comboBox_0;

	private Class193 class193_0;

	private Button button_1;

	private LinkLabel linkLabel_0;

	private PictureBox pictureBox_0;

	public GForm35(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
		method_5();
		method_2();
		method_0();
	}

	private void method_0()
	{
		try
		{
			class216_0 = new Class216(class193_0, bool_0: false, bool_1: false);
			class216_0.method_4();
			class216_0.method_2(Class84.smethod_0(-994278020), 350, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994278040), 100, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994277992), 120, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994278004), 100, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994277956), 100, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994277982), 100, bool_0: true);
			class216_0.method_7(Class84.smethod_0(-994277940), 60);
			class216_0.method_1(7, method_1);
			dataTable_0 = new DataTable();
			dataTable_0.Columns.Add(Class84.smethod_0(-994277103), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994277105), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994277895), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994277911), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994277862), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994277865), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994277881), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994277847), Type.GetType(Class84.smethod_0(-994276505)));
			class193_0.Columns[Class84.smethod_0(-994278040)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
			class193_0.Columns[Class84.smethod_0(-994277992)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
			class193_0.Columns[Class84.smethod_0(-994278004)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
			class193_0.Columns[Class84.smethod_0(-994277956)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
			class193_0.Columns[Class84.smethod_0(-994277982)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_1(int int_0, DataGridViewRow dataGridViewRow_0)
	{
		try
		{
			string text = dataGridViewRow_0.Cells[1].Value.ToString();
			string arg = dataGridViewRow_0.Cells[0].Value.ToString();
			string format = Class84.smethod_0(-994277851);
			format = string.Format(format, arg);
			GForm5 gForm = new GForm5(gform17_0);
			gForm.method_1(Class84.smethod_0(-994277399) + text, format, Class84.smethod_0(-994278876));
			gForm.ShowDialog();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_2()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			method_3(mySqlConnection);
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

	private void method_3(MySqlConnection mySqlConnection_0)
	{
		comboBox_0.Items.Clear();
		try
		{
			bool_0 = true;
			foreach (string item in Class280.smethod_6(mySqlConnection_0, Class84.smethod_0(-994265085)).Rows.Cast<DataRow>().Select(Class344.class344_0.method_0))
			{
				comboBox_0.Items.Add(item);
			}
			if (comboBox_0.Items.Count > 0)
			{
				comboBox_0.SelectedIndex = 0;
			}
		}
		finally
		{
			bool_0 = false;
		}
	}

	private void GForm35_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		method_4();
	}

	private void method_4()
	{
		if (comboBox_0.Items.Count == 0)
		{
			return;
		}
		dataTable_0.Rows.Clear();
		class216_0.method_12();
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string format = Class84.smethod_0(-994264907);
			format = string.Format(format, comboBox_0.Text);
			mySqlCommand.CommandText = format;
			List<Tuple<int, string>> list = new List<Tuple<int, string>>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				int item = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994277103)]);
				string item2 = Class84.smethod_0(-994264684) + mySqlDataReader[Class84.smethod_0(-994264701)]?.ToString() + Class84.smethod_0(-994264655) + mySqlDataReader[Class84.smethod_0(-994277105)];
				list.Add(new Tuple<int, string>(item, item2));
			}
			mySqlDataReader.Close();
			string format2 = Class84.smethod_0(-994264672);
			format = Class84.smethod_0(-994264483);
			foreach (Tuple<int, string> item5 in list)
			{
				int item3 = item5.Item1;
				string item4 = item5.Item2;
				int num = 0;
				int num2 = 0;
				mySqlCommand.CommandText = string.Format(format, item3);
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					num = Convert.ToInt32(mySqlDataReader[0]);
					num2 = Convert.ToInt32(mySqlDataReader[1]);
				}
				mySqlDataReader.Close();
				mySqlCommand.CommandText = string.Format(format2, item3);
				int num3 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
				int num4 = num3 - num;
				double num5 = ((num3 == 0) ? 0.0 : Math.Round(100.0 * (double)((float)num4 / (float)num3)));
				DataRow dataRow = dataTable_0.NewRow();
				dataRow[Class84.smethod_0(-994277103)] = item3;
				dataRow[Class84.smethod_0(-994277105)] = item4;
				dataRow[Class84.smethod_0(-994277895)] = num;
				dataRow[Class84.smethod_0(-994277911)] = num2;
				dataRow[Class84.smethod_0(-994277862)] = num3;
				dataRow[Class84.smethod_0(-994277865)] = num4;
				dataRow[Class84.smethod_0(-994277881)] = num5 + Class84.smethod_0(-994264352);
				dataRow[Class84.smethod_0(-994277847)] = Class84.smethod_0(-994277847);
				dataTable_0.Rows.Add(dataRow);
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

	private void button_1_Click(object sender, EventArgs e)
	{
		if (class193_0.Rows.Count == 0)
		{
			return;
		}
		button_1.Enabled = false;
		try
		{
			GClass35.smethod_4(GClass35.smethod_5(class193_0, bool_0: true));
			button_1.Enabled = true;
		}
		catch (Exception ex)
		{
			button_1.Enabled = true;
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel_0.Enabled = false;
		method_4();
		linkLabel_0.Enabled = true;
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
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

	private void method_5()
	{
		label_0 = new Label();
		button_0 = new Button();
		label_1 = new Label();
		comboBox_0 = new ComboBox();
		button_1 = new Button();
		linkLabel_0 = new LinkLabel();
		class193_0 = new Class193();
		pictureBox_0 = new PictureBox();
		((ISupportInitialize)class193_0).BeginInit();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994278767);
		label_0.Size = new Size(336, 17);
		label_0.TabIndex = 53;
		label_0.Text = Class84.smethod_0(-994264296);
		button_0.Location = new Point(300, 54);
		button_0.Name = Class84.smethod_0(-994264273);
		button_0.Size = new Size(40, 23);
		button_0.TabIndex = 68;
		button_0.Text = Class84.smethod_0(-994277847);
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		label_1.AutoSize = true;
		label_1.Location = new Point(21, 59);
		label_1.Name = Class84.smethod_0(-994278834);
		label_1.Size = new Size(65, 13);
		label_1.TabIndex = 66;
		label_1.Text = Class84.smethod_0(-994264227);
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Location = new Point(92, 56);
		comboBox_0.Name = Class84.smethod_0(-994264242);
		comboBox_0.Size = new Size(202, 21);
		comboBox_0.TabIndex = 67;
		button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		button_1.Image = Class309.smethod_14();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(767, 568);
		button_1.Name = Class84.smethod_0(-994278698);
		button_1.Size = new Size(106, 24);
		button_1.TabIndex = 94;
		button_1.Text = Class84.smethod_0(-994278149);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		linkLabel_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		linkLabel_0.AutoSize = true;
		linkLabel_0.Location = new Point(879, 571);
		linkLabel_0.Name = Class84.smethod_0(-994278181);
		linkLabel_0.Size = new Size(59, 13);
		linkLabel_0.TabIndex = 93;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class84.smethod_0(-994278198);
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(24, 89);
		class193_0.Name = Class84.smethod_0(-994278735);
		class193_0.Size = new Size(914, 470);
		class193_0.TabIndex = 69;
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(944, 3);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 95;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(964, 601);
		Controls.Add(pictureBox_0);
		Controls.Add(button_1);
		Controls.Add(linkLabel_0);
		Controls.Add(class193_0);
		Controls.Add(button_0);
		Controls.Add(label_1);
		Controls.Add(comboBox_0);
		Controls.Add(label_0);
		Name = Class84.smethod_0(-994264207);
		Text = Class84.smethod_0(-994264296);
		Load += GForm35_Load;
		((ISupportInitialize)class193_0).EndInit();
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
