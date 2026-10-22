using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm10 : Form
{
	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private DataTable dataTable_0;

	private Class216 class216_0;

	private bool bool_0;

	private IContainer icontainer_0;

	private Label label_0;

	private Label label_1;

	private Button button_0;

	private Class193 class193_0;

	private Button button_1;

	private PictureBox pictureBox_0;

	private ComboBox comboBox_0;

	private ComboBox comboBox_1;

	private ComboBox comboBox_2;

	public GForm10(GForm17 gform17_1, GClass5 gclass5_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gclass5_1;
		method_6();
		method_1();
		method_0();
	}

	private void method_0()
	{
		dataTable_0 = new DataTable();
		dataTable_0.Columns.Add(Class84.smethod_0(-994263532), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994311908), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994311927), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994311878), Type.GetType(Class84.smethod_0(-994276505)));
		class216_0 = new Class216(class193_0, bool_0: false, bool_1: false);
		class216_0.method_2(Class84.smethod_0(-994311881), 120, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994311899), 250, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994311854), 400, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994311869), 200, bool_0: true);
	}

	private void method_1()
	{
		try
		{
			bool_0 = true;
			DateTime dateTime = Class348.Class349.smethod_0();
			comboBox_2.Items.Clear();
			for (int i = Class224.Class227.int_0; i <= dateTime.Year + 1; i++)
			{
				comboBox_2.Items.Add(i);
			}
			comboBox_2.Text = dateTime.Year.ToString();
			comboBox_1.Items.Clear();
			for (int j = 1; j <= 12; j++)
			{
				comboBox_1.Items.Add(Class120.smethod_18(j));
			}
			comboBox_1.SelectedIndex = dateTime.Month - 1;
			method_2();
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

	private void method_2()
	{
		DateTime dateTime = Class348.Class349.smethod_0();
		comboBox_0.Items.Clear();
		int num = Class120.smethod_0(Convert.ToInt32(comboBox_2.Text), comboBox_1.SelectedIndex + 1);
		for (int i = 1; i <= num; i++)
		{
			comboBox_0.Items.Add(i.ToString().PadLeft(2, '0'));
		}
		if (comboBox_2.Text == dateTime.Year.ToString() && comboBox_1.SelectedIndex == dateTime.Month - 1)
		{
			comboBox_0.SelectedIndex = dateTime.Day - 1;
		}
		else
		{
			comboBox_0.SelectedIndex = 0;
		}
	}

	private void GForm10_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void method_3(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			dataTable_0.Rows.Clear();
			class216_0.method_12();
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			dataTable_0.Rows.Clear();
			class216_0.method_12();
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		method_5();
	}

	private void method_5()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string format = Class84.smethod_0(-994311824);
			format = string.Format(format, comboBox_1.SelectedIndex + 1, comboBox_2.Text, Convert.ToInt32(comboBox_0.Text));
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(format, mySqlConnection);
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			dataTable_0.Rows.Clear();
			class216_0.method_12();
			foreach (DataRow row in dataTable.Rows)
			{
				string value = string.Empty;
				if (row[Class84.smethod_0(-994277136)].ToString().Length > 0)
				{
					value = string.Format(Class84.smethod_0(-994311407), row[Class84.smethod_0(-994311417)], row[Class84.smethod_0(-994277136)]);
				}
				else if (row[Class84.smethod_0(-994266832)].ToString().Length > 0)
				{
					value = string.Format(Class84.smethod_0(-994311369), row[Class84.smethod_0(-994311329)], row[Class84.smethod_0(-994266832)]);
				}
				else if (row[Class84.smethod_0(-994270443)].ToString().Length > 0)
				{
					value = string.Format(Class84.smethod_0(-994311359), row[Class84.smethod_0(-994311315)], row[Class84.smethod_0(-994270443)]);
				}
				else if (row[Class84.smethod_0(-994311267)].ToString().Length > 0)
				{
					string[] array = row[Class84.smethod_0(-994311267)].ToString().Split('.');
					if (array.Length >= 2)
					{
						string text = array[1];
						string text2 = string.Empty;
						if (array.Length >= 3)
						{
							text2 = array[2];
						}
						if (text.Equals(Class84.smethod_0(-994268389)))
						{
							value = Class84.smethod_0(-994311285);
						}
						else if (text.Equals(Class84.smethod_0(-994268415)))
						{
							format = Class84.smethod_0(-994311244) + text2;
							mySqlCommand.CommandText = format;
							MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
							if (mySqlDataReader.Read())
							{
								value = string.Format(Class84.smethod_0(-994311180), mySqlDataReader[0]);
							}
							mySqlDataReader.Close();
						}
						else if (text.Equals(Class84.smethod_0(-994268356)))
						{
							format = Class84.smethod_0(-994311152) + text2;
							mySqlCommand.CommandText = format;
							MySqlDataReader mySqlDataReader2 = mySqlCommand.ExecuteReader();
							if (mySqlDataReader2.Read())
							{
								value = string.Format(Class84.smethod_0(-994311082), mySqlDataReader2[0], mySqlDataReader2[1]);
							}
							mySqlDataReader2.Close();
						}
						else if (text.Equals(Class84.smethod_0(-994268377)))
						{
							format = Class84.smethod_0(-994311058) + text2;
							mySqlCommand.CommandText = format;
							MySqlDataReader mySqlDataReader3 = mySqlCommand.ExecuteReader();
							if (mySqlDataReader3.Read())
							{
								value = string.Format(Class84.smethod_0(-994310943), mySqlDataReader3[0], mySqlDataReader3[1], mySqlDataReader3[2]);
							}
							mySqlDataReader3.Close();
						}
					}
				}
				DataRow dataRow2 = dataTable_0.NewRow();
				dataRow2[Class84.smethod_0(-994263532)] = row[Class84.smethod_0(-994310861)];
				dataRow2[Class84.smethod_0(-994311927)] = row[Class84.smethod_0(-994310877)];
				dataRow2[Class84.smethod_0(-994311878)] = row[Class84.smethod_0(-994310831)];
				dataRow2[Class84.smethod_0(-994311908)] = value;
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

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			method_2();
		}
	}

	private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			method_2();
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

	private void method_6()
	{
		label_0 = new Label();
		label_1 = new Label();
		button_0 = new Button();
		class193_0 = new Class193();
		button_1 = new Button();
		pictureBox_0 = new PictureBox();
		comboBox_0 = new ComboBox();
		comboBox_1 = new ComboBox();
		comboBox_2 = new ComboBox();
		((ISupportInitialize)class193_0).BeginInit();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994256787), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(20, 21);
		label_0.Name = Class84.smethod_0(-994266659);
		label_0.Size = new Size(112, 17);
		label_0.TabIndex = 72;
		label_0.Text = Class84.smethod_0(-994310834);
		label_1.AutoSize = true;
		label_1.Location = new Point(20, 58);
		label_1.Name = Class84.smethod_0(-994278834);
		label_1.Size = new Size(49, 13);
		label_1.TabIndex = 73;
		label_1.Text = Class84.smethod_0(-994310793);
		button_0.Location = new Point(281, 53);
		button_0.Name = Class84.smethod_0(-994264273);
		button_0.Size = new Size(39, 23);
		button_0.TabIndex = 76;
		button_0.Text = Class84.smethod_0(-994277847);
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(23, 94);
		class193_0.Name = Class84.smethod_0(-994278735);
		class193_0.Size = new Size(948, 453);
		class193_0.TabIndex = 92;
		button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		button_1.Image = Class309.smethod_14();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(897, 556);
		button_1.Name = Class84.smethod_0(-994278698);
		button_1.Size = new Size(74, 23);
		button_1.TabIndex = 190;
		button_1.Text = Class84.smethod_0(-994310810);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(977, 4);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 191;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Location = new Point(230, 55);
		comboBox_0.Name = Class84.smethod_0(-994266589);
		comboBox_0.Size = new Size(45, 21);
		comboBox_0.TabIndex = 194;
		comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_1.FormattingEnabled = true;
		comboBox_1.Location = new Point(138, 55);
		comboBox_1.Name = Class84.smethod_0(-994266540);
		comboBox_1.Size = new Size(86, 21);
		comboBox_1.TabIndex = 193;
		comboBox_1.SelectedIndexChanged += comboBox_1_SelectedIndexChanged;
		comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_2.FormattingEnabled = true;
		comboBox_2.Location = new Point(79, 55);
		comboBox_2.Name = Class84.smethod_0(-994266557);
		comboBox_2.Size = new Size(53, 21);
		comboBox_2.TabIndex = 192;
		comboBox_2.SelectedIndexChanged += comboBox_2_SelectedIndexChanged;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(997, 598);
		Controls.Add(comboBox_0);
		Controls.Add(comboBox_1);
		Controls.Add(comboBox_2);
		Controls.Add(pictureBox_0);
		Controls.Add(button_1);
		Controls.Add(class193_0);
		Controls.Add(button_0);
		Controls.Add(label_1);
		Controls.Add(label_0);
		Name = Class84.smethod_0(-994310768);
		Text = Class84.smethod_0(-994310834);
		Load += GForm10_Load;
		((ISupportInitialize)class193_0).EndInit();
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
