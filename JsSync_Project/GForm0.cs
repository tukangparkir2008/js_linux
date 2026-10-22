using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm0 : Form
{
	private readonly GForm33 gform33_0;

	private readonly string string_0;

	private int int_0;

	private Class216 class216_0;

	private DataTable dataTable_0;

	private bool bool_0;

	private IContainer icontainer_0;

	private Button button_0;

	private Button button_1;

	private TextBox textBox_0;

	private Label label_0;

	private TextBox textBox_1;

	private Label label_1;

	private Button button_2;

	private TextBox textBox_2;

	private TextBox textBox_3;

	private Label label_2;

	private Label label_3;

	private Class193 class193_0;

	private Label label_4;

	private ComboBox comboBox_0;

	private Label label_5;

	public GForm0(GForm33 gform33_1, string string_1)
	{
		method_7();
		method_0();
		method_1();
		method_2();
		gform33_0 = gform33_1;
		string_0 = string_1;
		int_0 = 0;
		Text = string_1;
		label_3.Text = string_1;
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

	private void method_1()
	{
		for (int i = 1; i <= Class127.int_0; i++)
		{
			ComboBox.ObjectCollection items = comboBox_0.Items;
			GClass2 gClass = new GClass2();
			gClass.method_1(Class127.smethod_0((Enum3)i));
			gClass.method_3(i);
			items.Add(gClass);
		}
		comboBox_0.SelectedIndex = 0;
	}

	private void method_2()
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
				dataRow[Class84.smethod_0(-994276469)] = 0;
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

	private void button_2_Click(object sender, EventArgs e)
	{
		GForm26 gForm = new GForm26(method_3, Class84.smethod_0(-994248828), bool_1: true);
		gForm.method_1();
		gForm.ShowDialog();
	}

	public void method_3(int int_1, int int_2, string string_1, string string_2, string string_3, string string_4, Image image_0, string string_5)
	{
		textBox_3.Text = string_2;
		textBox_2.Text = string_3;
		method_4();
	}

	private void method_4()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string format = Class84.smethod_0(-994248770);
			format = string.Format(format, textBox_3.Text);
			mySqlCommand.CommandText = format;
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) != 0)
			{
				textBox_3.Text = string.Empty;
				textBox_2.Text = string.Empty;
				Class355.smethod_0(Class84.smethod_0(-994248711));
				return;
			}
			format = Class84.smethod_0(-994252741);
			format = string.Format(format, textBox_3.Text);
			mySqlCommand.CommandText = format;
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) > 0)
			{
				bool_0 = false;
				textBox_1.Text = Class84.smethod_0(-994247193);
				textBox_1.Enabled = false;
				textBox_0.Text = Class84.smethod_0(-994247193);
				textBox_0.Enabled = false;
			}
			else
			{
				bool_0 = true;
				textBox_1.Text = string.Empty;
				textBox_1.Enabled = true;
				textBox_0.Text = string.Empty;
				textBox_0.Enabled = true;
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

	private void button_1_Click(object sender, EventArgs e)
	{
		if (method_5())
		{
			method_6();
		}
	}

	private bool method_5()
	{
		if (textBox_3.Text.Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994252680));
			button_2.Focus();
			return false;
		}
		if (textBox_1.Enabled)
		{
			if (textBox_1.Text.Trim().Length == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994252642));
				textBox_1.Focus();
				return false;
			}
			if (textBox_0.Text.Trim().Length == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994252642));
				textBox_0.Focus();
				return false;
			}
			if (textBox_1.Text.IndexOf(Class84.smethod_0(-994271698), StringComparison.Ordinal) >= 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994252610));
				textBox_1.Focus();
				return false;
			}
			if (!textBox_1.Text.Trim().Equals(textBox_0.Text.Trim()))
			{
				Class355.smethod_0(Class84.smethod_0(-994252606));
				textBox_1.Focus();
				return false;
			}
		}
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
			return false;
		}
		return Class355.smethod_1(Class84.smethod_0(-994252563)) == DialogResult.OK;
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
			string format;
			if (bool_0)
			{
				format = Class84.smethod_0(-994252523);
				format = string.Format(format, textBox_3.Text, textBox_1.Text.Trim());
				mySqlCommand.CommandText = format;
				mySqlCommand.ExecuteNonQuery();
			}
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
			format = string.Format(Class84.smethod_0(-994252423), textBox_3.Text, ((GClass2)comboBox_0.SelectedItem).method_4(), arg);
			mySqlCommand.CommandText = format;
			mySqlCommand.ExecuteNonQuery();
			mySqlTransaction.Commit();
			gform33_0.method_7();
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

	private void GForm0_Load(object sender, EventArgs e)
	{
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm0));
		button_0 = new Button();
		button_1 = new Button();
		textBox_0 = new TextBox();
		label_0 = new Label();
		textBox_1 = new TextBox();
		label_1 = new Label();
		button_2 = new Button();
		textBox_2 = new TextBox();
		textBox_3 = new TextBox();
		label_2 = new Label();
		label_3 = new Label();
		class193_0 = new Class193();
		label_4 = new Label();
		comboBox_0 = new ComboBox();
		label_5 = new Label();
		((ISupportInitialize)class193_0).BeginInit();
		SuspendLayout();
		button_0.Image = Class309.smethod_10();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(238, 366);
		button_0.Name = Class84.smethod_0(-994278087);
		button_0.Size = new Size(75, 23);
		button_0.TabIndex = 81;
		button_0.Text = Class84.smethod_0(-994278089);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		button_1.Image = Class309.smethod_24();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(157, 366);
		button_1.Name = Class84.smethod_0(-994266730);
		button_1.Size = new Size(75, 23);
		button_1.TabIndex = 80;
		button_1.Text = Class84.smethod_0(-994266747);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		textBox_0.Location = new Point(93, 91);
		textBox_0.Name = Class84.smethod_0(-994252289);
		textBox_0.PasswordChar = '?';
		textBox_0.Size = new Size(229, 20);
		textBox_0.TabIndex = 79;
		label_0.Location = new Point(32, 86);
		label_0.Name = Class84.smethod_0(-994266659);
		label_0.Size = new Size(68, 36);
		label_0.TabIndex = 78;
		label_0.Text = Class84.smethod_0(-994252319);
		textBox_1.Location = new Point(93, 63);
		textBox_1.Name = Class84.smethod_0(-994252277);
		textBox_1.PasswordChar = '?';
		textBox_1.Size = new Size(229, 20);
		textBox_1.TabIndex = 77;
		label_1.AutoSize = true;
		label_1.Location = new Point(34, 66);
		label_1.Name = Class84.smethod_0(-994266720);
		label_1.Size = new Size(53, 13);
		label_1.TabIndex = 76;
		label_1.Text = Class84.smethod_0(-994250745);
		button_2.Location = new Point(411, 35);
		button_2.Name = Class84.smethod_0(-994252227);
		button_2.Size = new Size(32, 23);
		button_2.TabIndex = 75;
		button_2.Text = Class84.smethod_0(-994252256);
		button_2.UseVisualStyleBackColor = true;
		button_2.Click += button_2_Click;
		textBox_2.Location = new Point(207, 37);
		textBox_2.Name = Class84.smethod_0(-994252198);
		textBox_2.ReadOnly = true;
		textBox_2.Size = new Size(198, 20);
		textBox_2.TabIndex = 74;
		textBox_3.Location = new Point(93, 37);
		textBox_3.Name = Class84.smethod_0(-994252213);
		textBox_3.ReadOnly = true;
		textBox_3.Size = new Size(108, 20);
		textBox_3.TabIndex = 73;
		label_2.AutoSize = true;
		label_2.Location = new Point(39, 40);
		label_2.Name = Class84.smethod_0(-994278834);
		label_2.Size = new Size(48, 13);
		label_2.TabIndex = 72;
		label_2.Text = Class84.smethod_0(-994278858);
		label_3.AutoSize = true;
		label_3.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_3.Location = new Point(16, 12);
		label_3.Name = Class84.smethod_0(-994278216);
		label_3.Size = new Size(42, 13);
		label_3.TabIndex = 71;
		label_3.Text = Class84.smethod_0(-994252166);
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(42, 172);
		class193_0.Name = Class84.smethod_0(-994248875);
		class193_0.Size = new Size(391, 174);
		class193_0.TabIndex = 108;
		label_4.AutoSize = true;
		label_4.Location = new Point(39, 156);
		label_4.Name = Class84.smethod_0(-994278767);
		label_4.Size = new Size(65, 13);
		label_4.TabIndex = 107;
		label_4.Text = Class84.smethod_0(-994264227);
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Location = new Point(93, 125);
		comboBox_0.Name = Class84.smethod_0(-994248893);
		comboBox_0.Size = new Size(299, 21);
		comboBox_0.TabIndex = 106;
		comboBox_0.SelectedIndexChanged += comboBox_0_SelectedIndexChanged;
		label_5.AutoSize = true;
		label_5.Location = new Point(43, 128);
		label_5.Name = Class84.smethod_0(-994266638);
		label_5.Size = new Size(35, 13);
		label_5.TabIndex = 105;
		label_5.Text = Class84.smethod_0(-994248847);
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(459, 401);
		Controls.Add(class193_0);
		Controls.Add(label_4);
		Controls.Add(comboBox_0);
		Controls.Add(label_5);
		Controls.Add(button_0);
		Controls.Add(button_1);
		Controls.Add(textBox_0);
		Controls.Add(label_0);
		Controls.Add(textBox_1);
		Controls.Add(label_1);
		Controls.Add(button_2);
		Controls.Add(textBox_2);
		Controls.Add(textBox_3);
		Controls.Add(label_2);
		Controls.Add(label_3);
		Icon = (Icon)componentResourceManager.GetObject(Class84.smethod_0(-994278109));
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class84.smethod_0(-994252170);
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class84.smethod_0(-994252170);
		Load += GForm0_Load;
		((ISupportInitialize)class193_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
