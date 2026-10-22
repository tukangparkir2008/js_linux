using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm31 : Form
{
	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private bool bool_0;

	private string string_0 = string.Empty;

	private string string_1;

	private string string_2;

	private DataTable dataTable_0;

	private Class216 class216_0;

	private string string_3;

	private string string_4;

	private IContainer icontainer_0;

	private Label label_0;

	private PictureBox pictureBox_0;

	private Button button_0;

	private Button button_1;

	private TextBox textBox_0;

	private ComboBox comboBox_0;

	private ComboBox comboBox_1;

	private Label label_1;

	private LinkLabel linkLabel_0;

	private Class193 class193_0;

	public GForm31(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gform17_1.method_0();
		method_8();
		method_0();
		method_3();
	}

	private void method_0()
	{
		try
		{
			dataTable_0 = new DataTable();
			dataTable_0.Columns.Add(Class84.smethod_0(-994264162), Type.GetType(Class84.smethod_0(-994276372)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994276501), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994276441), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994264135), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994264155), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994266239), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994266191), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994266206), Type.GetType(Class84.smethod_0(-994276505)));
			class216_0 = new Class216(class193_0, bool_0: false, bool_1: false);
			class216_0.method_4();
			class216_0.method_4();
			class216_0.method_4();
			class216_0.method_4();
			class216_0.method_2(Class84.smethod_0(-994264040), 300, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994276305), 250, bool_0: true);
			class216_0.method_8(Class84.smethod_0(-994276302), 80, new List<string>
			{
				Class84.smethod_0(-994275430),
				Class84.smethod_0(-994266147)
			});
			class216_0.method_7(Class84.smethod_0(-994266163), 70);
			class216_0.method_1(7, method_1);
			class193_0.Columns[Class84.smethod_0(-994264040)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
			class193_0.Columns[Class84.smethod_0(-994264040)].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			class193_0.Columns[Class84.smethod_0(-994276305)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
			class193_0.Columns[Class84.smethod_0(-994276305)].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			class193_0.Columns[Class84.smethod_0(-994276302)].DefaultCellStyle.Padding = new Padding(2, 2, 2, 70);
			class193_0.Columns[Class84.smethod_0(-994266163)].DefaultCellStyle.Padding = new Padding(2, 2, 2, 70);
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
			GClass70 gClass = Class316.smethod_12();
			if (gClass.Value != 1)
			{
				Class355.smethod_0(gClass.Text);
				return;
			}
			int num = Convert.ToInt32(dataGridViewRow_0.Cells[2].Value);
			string text = dataGridViewRow_0.Cells[6].Value.ToString();
			if ((num == 1 && text.Equals(Class84.smethod_0(-994275430))) || (num == 0 && text.Equals(Class84.smethod_0(-994266147))))
			{
				return;
			}
			string_3 = dataGridViewRow_0.Cells[1].Value.ToString();
			string_4 = dataGridViewRow_0.Cells[3].Value.ToString();
			if (num == 0)
			{
				if (Class355.smethod_1(Class84.smethod_0(-994266120)) != DialogResult.Cancel)
				{
					method_2();
				}
			}
			else
			{
				new GForm6(this).ShowDialog();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_2()
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
			string commandText = Class84.smethod_0(-994266082) + string_3 + Class84.smethod_0(-994263795) + string_4 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994266026) + string_3 + Class84.smethod_0(-994263795) + string_4 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			mySqlTransaction.Commit();
			method_6();
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private void method_3()
	{
		bool_0 = true;
		ComboBox comboBox = comboBox_1;
		comboBox_0.SelectedIndex = 0;
		comboBox.SelectedIndex = 0;
		bool_0 = false;
	}

	private void GForm31_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void textBox_0_KeyUp(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return && textBox_0.Text.Trim().Length >= 3)
		{
			GForm21 gForm = new GForm21(method_4, gform17_0.method_0().gclass6_0.method_12(), bool_2: true);
			gForm.method_7(comboBox_1.SelectedIndex, comboBox_0.SelectedIndex, textBox_0.Text);
			gForm.method_10();
			gForm.ShowDialog();
		}
	}

	private void method_4(int int_0, int int_1, string string_5, string string_6, string string_7, string string_8, Image image_0, string string_9)
	{
		comboBox_1.SelectedIndex = int_0;
		comboBox_0.SelectedIndex = int_1;
		textBox_0.Text = string_5;
		string_0 = string_6;
		string_1 = string_7;
		string_2 = ((int_1 == 0) ? Class84.smethod_0(-994277136) : Class84.smethod_0(-994266832));
		label_0.Text = Class84.smethod_0(-994265955) + string_1 + Class84.smethod_0(-994265926) + string_0 + Class84.smethod_0(-994271866);
		Text = label_0.Text;
		method_6();
	}

	public void method_5(string string_5)
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
			string commandText = Class84.smethod_0(-994263842) + string_5 + Class84.smethod_0(-994263833) + string_3 + Class84.smethod_0(-994263795) + string_4 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994263757) + string_3 + Class84.smethod_0(-994263795) + string_4 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			mySqlTransaction.Commit();
			method_6();
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private void method_6()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = string.Format(Class84.smethod_0(-994265933), string_2, string_0)
			}.ExecuteReader();
			dataTable_0.Rows.Clear();
			class216_0.method_12();
			while (mySqlDataReader.Read())
			{
				int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994264162)]);
				string text = mySqlDataReader[Class84.smethod_0(-994276414)].ToString();
				string text2 = mySqlDataReader[Class84.smethod_0(-994265628)].ToString();
				string text3 = mySqlDataReader[Class84.smethod_0(-994265582)].ToString();
				string text4 = mySqlDataReader[Class84.smethod_0(-994276954)].ToString();
				string value = mySqlDataReader[Class84.smethod_0(-994276501)].ToString();
				int num2 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994276441)]);
				mySqlDataReader[Class84.smethod_0(-994266191)].ToString();
				string value2 = mySqlDataReader[Class84.smethod_0(-994264135)].ToString();
				string text5 = mySqlDataReader[Class84.smethod_0(-994276993)].ToString();
				string text6 = mySqlDataReader[Class84.smethod_0(-994276975)].ToString();
				string text7 = mySqlDataReader[Class84.smethod_0(-994276989)].ToString();
				string text8 = mySqlDataReader[Class84.smethod_0(-994276939)].ToString();
				string empty = string.Empty;
				empty = ((text5.Trim().Length <= 0) ? Class84.smethod_0(-994263519) : (text5 + Class84.smethod_0(-994263511) + text6 + Class84.smethod_0(-994263511) + text7 + Class84.smethod_0(-994263511) + text8));
				empty = empty + Class84.smethod_0(-994265585) + text;
				string value3 = text4 + Class84.smethod_0(-994263511) + text2 + Class84.smethod_0(-994263061) + text3;
				DataRow dataRow = dataTable_0.NewRow();
				dataRow[Class84.smethod_0(-994264162)] = num;
				dataRow[Class84.smethod_0(-994276501)] = value;
				dataRow[Class84.smethod_0(-994276441)] = num2;
				dataRow[Class84.smethod_0(-994264135)] = value2;
				dataRow[Class84.smethod_0(-994264155)] = empty;
				dataRow[Class84.smethod_0(-994266239)] = value3;
				dataRow[Class84.smethod_0(-994266191)] = ((num2 == 1) ? Class84.smethod_0(-994275430) : Class84.smethod_0(-994266147));
				dataRow[Class84.smethod_0(-994266206)] = Class84.smethod_0(-994266747);
				dataTable_0.Rows.Add(dataRow);
			}
			mySqlDataReader.Close();
			class216_0.method_9(dataTable_0);
			class216_0.method_18(100);
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		if (textBox_0.Text.Trim().Length >= 3)
		{
			GForm21 gForm = new GForm21(method_4, gform17_0.method_0().gclass6_0.method_12(), bool_2: true);
			gForm.method_7(comboBox_1.SelectedIndex, comboBox_0.SelectedIndex, textBox_0.Text);
			gForm.method_10();
			gForm.ShowDialog();
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		GForm21 gForm = new GForm21(method_4, gform17_0.method_0().gclass6_0.method_12(), bool_2: true);
		gForm.method_7(comboBox_1.SelectedIndex, comboBox_0.SelectedIndex, string.Empty);
		gForm.method_10();
		gForm.ShowDialog();
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (!string_0.Equals(string.Empty))
		{
			linkLabel_0.Enabled = false;
			method_6();
			linkLabel_0.Enabled = true;
		}
	}

	private void method_7()
	{
		string_2 = string.Empty;
		string_0 = string.Empty;
		string_1 = string.Empty;
		dataTable_0.Rows.Clear();
		class216_0.method_12();
	}

	private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			method_7();
		}
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			method_7();
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

	private void method_8()
	{
		label_0 = new Label();
		pictureBox_0 = new PictureBox();
		button_0 = new Button();
		button_1 = new Button();
		textBox_0 = new TextBox();
		comboBox_0 = new ComboBox();
		comboBox_1 = new ComboBox();
		label_1 = new Label();
		linkLabel_0 = new LinkLabel();
		class193_0 = new Class193();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)class193_0).BeginInit();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994278216);
		label_0.Size = new Size(157, 17);
		label_0.TabIndex = 89;
		label_0.Text = Class84.smethod_0(-994265568);
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(1077, 4);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 100;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		button_0.Location = new Point(455, 55);
		button_0.Name = Class84.smethod_0(-994265524);
		button_0.Size = new Size(51, 23);
		button_0.TabIndex = 106;
		button_0.Text = Class84.smethod_0(-994265477);
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		button_1.Location = new Point(409, 55);
		button_1.Name = Class84.smethod_0(-994278923);
		button_1.Size = new Size(40, 23);
		button_1.TabIndex = 105;
		button_1.Text = Class84.smethod_0(-994278942);
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		textBox_0.Location = new Point(277, 57);
		textBox_0.Name = Class84.smethod_0(-994265496);
		textBox_0.Size = new Size(126, 20);
		textBox_0.TabIndex = 104;
		textBox_0.KeyUp += textBox_0_KeyUp;
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Items.AddRange(new object[2]
		{
			Class84.smethod_0(-994278876),
			Class84.smethod_0(-994278858)
		});
		comboBox_0.Location = new Point(167, 57);
		comboBox_0.Name = Class84.smethod_0(-994265446);
		comboBox_0.Size = new Size(104, 21);
		comboBox_0.TabIndex = 103;
		comboBox_0.SelectedIndexChanged += comboBox_0_SelectedIndexChanged;
		comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_1.FormattingEnabled = true;
		comboBox_1.Items.AddRange(new object[2]
		{
			Class84.smethod_0(-994276345),
			Class84.smethod_0(-994265459)
		});
		comboBox_1.Location = new Point(57, 57);
		comboBox_1.Name = Class84.smethod_0(-994265409);
		comboBox_1.Size = new Size(104, 21);
		comboBox_1.TabIndex = 102;
		comboBox_1.SelectedIndexChanged += comboBox_1_SelectedIndexChanged;
		label_1.AutoSize = true;
		label_1.Location = new Point(26, 60);
		label_1.Name = Class84.smethod_0(-994266638);
		label_1.Size = new Size(25, 13);
		label_1.TabIndex = 101;
		label_1.Text = Class84.smethod_0(-994278789);
		linkLabel_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		linkLabel_0.AutoSize = true;
		linkLabel_0.Location = new Point(1027, 592);
		linkLabel_0.Name = Class84.smethod_0(-994278181);
		linkLabel_0.Size = new Size(59, 13);
		linkLabel_0.TabIndex = 108;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class84.smethod_0(-994278198);
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(29, 84);
		class193_0.Name = Class84.smethod_0(-994278735);
		class193_0.Size = new Size(1057, 500);
		class193_0.TabIndex = 107;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1098, 629);
		Controls.Add(linkLabel_0);
		Controls.Add(class193_0);
		Controls.Add(button_0);
		Controls.Add(button_1);
		Controls.Add(textBox_0);
		Controls.Add(comboBox_0);
		Controls.Add(comboBox_1);
		Controls.Add(label_1);
		Controls.Add(pictureBox_0);
		Controls.Add(label_0);
		Name = Class84.smethod_0(-994265440);
		Text = Class84.smethod_0(-994265568);
		Load += GForm31_Load;
		((ISupportInitialize)pictureBox_0).EndInit();
		((ISupportInitialize)class193_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
