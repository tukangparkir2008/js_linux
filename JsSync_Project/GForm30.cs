using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm30 : Form
{
	private readonly int int_0;

	private readonly GForm17 gform17_0;

	private readonly GForm14 gform14_0;

	private IContainer icontainer_0;

	private ComboBox comboBox_0;

	private Label label_0;

	private Button button_0;

	private Button button_1;

	private TextBox textBox_0;

	private Label label_1;

	private TextBox textBox_1;

	private Label label_2;

	public GForm30(int int_1, GForm14 gform14_1, GForm17 gform17_1)
	{
		int_0 = int_1;
		gform14_0 = gform14_1;
		gform17_0 = gform17_1;
		method_5();
		method_0();
	}

	private void method_0()
	{
		comboBox_0.Items.Clear();
		foreach (Tuple<int, string> item in gform17_0.method_0().gclass6_0.method_10())
		{
			ComboBox.ObjectCollection items = comboBox_0.Items;
			GClass2 gClass = new GClass2();
			gClass.method_1(item.Item2);
			gClass.method_3(item.Item1);
			items.Add(gClass);
		}
		if (comboBox_0.Items.Count > 0)
		{
			comboBox_0.SelectedIndex = 0;
		}
	}

	private void GForm30_Load(object sender, EventArgs e)
	{
		if (int_0 != 0)
		{
			method_1();
		}
	}

	private void method_1()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlDataReader mySqlDataReader = new MySqlCommand(string.Format(Class84.smethod_0(-994262616), int_0), mySqlConnection).ExecuteReader();
			if (mySqlDataReader.Read())
			{
				textBox_1.Text = Convert.ToString(mySqlDataReader[0]);
				textBox_0.Text = Convert.ToString(mySqlDataReader[1]);
				comboBox_0.Text = Convert.ToString(mySqlDataReader[2]);
			}
			mySqlDataReader.Close();
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
		if (method_4())
		{
			if (int_0 == 0)
			{
				method_2();
			}
			else
			{
				method_3();
			}
		}
	}

	private void method_2()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string format;
			if (gform17_0.method_0().gclass6_0.method_6() == 0)
			{
				format = Class84.smethod_0(-994262447);
				format = string.Format(format, textBox_1.Text.Trim().Replace('\'', '`'), textBox_0.Text.Trim().Replace('\'', '`'), comboBox_0.Text);
			}
			else
			{
				format = Class84.smethod_0(-994262332);
				format = string.Format(format, textBox_1.Text.Trim().Replace('\'', '`'), textBox_0.Text.Trim().Replace('\'', '`'), comboBox_0.Text, gform17_0.method_0().gclass6_0.method_2());
			}
			new MySqlCommand(format, mySqlConnection).ExecuteNonQuery();
			Close();
			gform14_0.method_10();
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

	private void method_3()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			new MySqlCommand(string.Format(Class84.smethod_0(-994262168), textBox_1.Text.Trim().Replace('\'', '`'), textBox_0.Text.Trim().Replace('\'', '`'), comboBox_0.Text, int_0), mySqlConnection).ExecuteNonQuery();
			Close();
			gform14_0.method_9();
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

	private bool method_4()
	{
		if (textBox_1.Text.Trim().Length >= 5)
		{
			return true;
		}
		Class355.smethod_2(Class84.smethod_0(-994261955));
		return false;
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

	private void method_5()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm30));
		comboBox_0 = new ComboBox();
		label_0 = new Label();
		button_0 = new Button();
		button_1 = new Button();
		textBox_0 = new TextBox();
		label_1 = new Label();
		textBox_1 = new TextBox();
		label_2 = new Label();
		SuspendLayout();
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Location = new Point(92, 39);
		comboBox_0.Name = Class84.smethod_0(-994261949);
		comboBox_0.Size = new Size(207, 21);
		comboBox_0.TabIndex = 28;
		label_0.AutoSize = true;
		label_0.Location = new Point(21, 42);
		label_0.Name = Class84.smethod_0(-994266720);
		label_0.Size = new Size(65, 13);
		label_0.TabIndex = 27;
		label_0.Text = Class84.smethod_0(-994264227);
		button_0.Image = Class309.smethod_10();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(185, 154);
		button_0.Name = Class84.smethod_0(-994278087);
		button_0.Size = new Size(69, 26);
		button_0.TabIndex = 26;
		button_0.Text = Class84.smethod_0(-994278089);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		button_1.Image = Class309.smethod_24();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(110, 154);
		button_1.Name = Class84.smethod_0(-994266730);
		button_1.Size = new Size(69, 26);
		button_1.TabIndex = 25;
		button_1.Text = Class84.smethod_0(-994266747);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		textBox_0.Location = new Point(92, 66);
		textBox_0.MaxLength = 255;
		textBox_0.Multiline = true;
		textBox_0.Name = Class84.smethod_0(-994256283);
		textBox_0.Size = new Size(239, 73);
		textBox_0.TabIndex = 24;
		label_1.AutoSize = true;
		label_1.Location = new Point(36, 71);
		label_1.Name = Class84.smethod_0(-994278767);
		label_1.Size = new Size(50, 13);
		label_1.TabIndex = 23;
		label_1.Text = Class84.smethod_0(-994258372);
		textBox_1.Location = new Point(92, 13);
		textBox_1.MaxLength = 100;
		textBox_1.Name = Class84.smethod_0(-994261904);
		textBox_1.Size = new Size(239, 20);
		textBox_1.TabIndex = 22;
		label_2.AutoSize = true;
		label_2.Location = new Point(51, 16);
		label_2.Name = Class84.smethod_0(-994278834);
		label_2.Size = new Size(35, 13);
		label_2.TabIndex = 21;
		label_2.Text = Class84.smethod_0(-994276345);
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(353, 192);
		Controls.Add(comboBox_0);
		Controls.Add(label_0);
		Controls.Add(button_0);
		Controls.Add(button_1);
		Controls.Add(textBox_0);
		Controls.Add(label_1);
		Controls.Add(textBox_1);
		Controls.Add(label_2);
		Icon = (Icon)componentResourceManager.GetObject(Class84.smethod_0(-994278109));
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class84.smethod_0(-994261907);
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class84.smethod_0(-994261876);
		Load += GForm30_Load;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
