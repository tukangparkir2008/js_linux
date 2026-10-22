using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

public sealed class GForm2 : Form
{
	private string string_0;

	private string string_1;

	private bool bool_0;

	private IContainer icontainer_0;

	private Label label_0;

	private Button button_0;

	private Button button_1;

	private TextBox textBox_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private ComboBox comboBox_0;

	private ComboBox comboBox_1;

	private ComboBox comboBox_2;

	private ComboBox comboBox_3;

	private ComboBox comboBox_4;

	private RadioButton radioButton_0;

	private RadioButton radioButton_1;

	private Label label_5;

	private GroupBox groupBox_0;

	private Label label_6;

	private Label label_7;

	public GForm2()
	{
		method_3();
	}

	public void method_0(string string_2, string string_3)
	{
		string_0 = string_2;
		string_1 = string_3;
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		string text = textBox_0.Text.Trim();
		if (text.Length == 0 || Class355.smethod_1(Class84.smethod_0(-994263322)) == DialogResult.Cancel)
		{
			return;
		}
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		try
		{
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			string empty = string.Empty;
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			Class156 @class = new Class156(mySqlCommand);
			if (!string_0.Equals(string.Empty))
			{
				empty = Class84.smethod_0(-994263281);
				empty = string.Format(empty, string_0);
				mySqlCommand.CommandText = empty;
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
				mySqlDataAdapter.SelectCommand = mySqlCommand;
				DataTable dataTable = new DataTable();
				mySqlDataAdapter.Fill(dataTable);
				string text2 = Class120.smethod_31(mySqlConnection, Class224.Class226.string_3);
				if (radioButton_0.Checked)
				{
					string text3 = string.Format(Class84.smethod_0(-994263055), comboBox_3.SelectedIndex + 1);
					text3 = text3.PadLeft(2, '0');
					text2 = comboBox_4.Text + Class84.smethod_0(-994278690) + text3 + Class84.smethod_0(-994278690) + comboBox_2.Text + Class84.smethod_0(-994263061) + comboBox_1.Text + Class84.smethod_0(-994263069) + comboBox_0.Text + Class84.smethod_0(-994267109);
				}
				string text4 = string.Empty;
				string newValue = string.Empty;
				HashSet<string> hashSet = new HashSet<string>();
				foreach (DataRow row in dataTable.Rows)
				{
					string text5 = row[Class84.smethod_0(-994277136)].ToString();
					string text6 = row[Class84.smethod_0(-994277142)].ToString();
					string item = row[Class84.smethod_0(-994267115)].ToString();
					if (text4.Equals(string.Empty))
					{
						text4 = text5;
						newValue = text6;
						hashSet.Add(item);
					}
					else if (text4.Equals(text5))
					{
						if (!hashSet.Contains(item))
						{
							hashSet.Add(item);
						}
					}
					else if (!text4.Equals(text5))
					{
						string text7 = text.Replace(Class84.smethod_0(-994267135), text4);
						text7 = text7.Replace(Class84.smethod_0(-994267075), newValue);
						if (hashSet.Count > 0)
						{
							string text8 = JsonConvert.SerializeObject(hashSet);
							@class.method_2(text8, Class84.smethod_0(-994267094), text7, Class84.smethod_0(-994267055), text2);
						}
						@class.method_4(text4, string.Empty, string.Empty, string.Empty, Class84.smethod_0(-994267094), text7, Class84.smethod_0(-994267055), text2);
						text4 = text5;
						newValue = text6;
						hashSet.Clear();
						hashSet.Add(item);
					}
				}
				if (!text4.Equals(string.Empty))
				{
					string text9 = text.Replace(Class84.smethod_0(-994267135), text4);
					text9 = text9.Replace(Class84.smethod_0(-994267075), newValue);
					if (hashSet.Count > 0)
					{
						string text10 = JsonConvert.SerializeObject(hashSet);
						@class.method_2(text10, Class84.smethod_0(-994267094), text9, Class84.smethod_0(-994267055), text2);
					}
					@class.method_4(text4, string.Empty, string.Empty, string.Empty, Class84.smethod_0(-994267094), text9, Class84.smethod_0(-994267055), text2);
				}
			}
			if (!string_1.Equals(string.Empty))
			{
				empty = Class84.smethod_0(-994267059);
				empty = string.Format(empty, string_1);
				mySqlCommand.CommandText = empty;
				MySqlDataAdapter mySqlDataAdapter2 = new MySqlDataAdapter();
				mySqlDataAdapter2.SelectCommand = mySqlCommand;
				DataTable dataTable2 = new DataTable();
				mySqlDataAdapter2.Fill(dataTable2);
				string text11 = Class120.smethod_31(mySqlConnection, Class224.Class226.string_3);
				if (radioButton_0.Checked)
				{
					string text12 = string.Format(Class84.smethod_0(-994263055), comboBox_3.SelectedIndex + 1);
					text12 = text12.PadLeft(2, '0');
					text11 = comboBox_4.Text + Class84.smethod_0(-994278690) + text12 + Class84.smethod_0(-994278690) + comboBox_2.Text + Class84.smethod_0(-994263061) + comboBox_1.Text + Class84.smethod_0(-994263069) + comboBox_0.Text + Class84.smethod_0(-994267109);
				}
				string text13 = string.Empty;
				string newValue2 = string.Empty;
				HashSet<string> hashSet2 = new HashSet<string>();
				foreach (DataRow row2 in dataTable2.Rows)
				{
					string text14 = row2[Class84.smethod_0(-994266832)].ToString();
					string text15 = row2[Class84.smethod_0(-994277142)].ToString();
					string item2 = row2[Class84.smethod_0(-994267115)].ToString();
					if (text13.Equals(string.Empty))
					{
						text13 = text14;
						newValue2 = text15;
						hashSet2.Add(item2);
					}
					else if (text13.Equals(text14))
					{
						if (!hashSet2.Contains(item2))
						{
							hashSet2.Add(item2);
						}
					}
					else if (!text13.Equals(text14))
					{
						string text16 = text.Replace(Class84.smethod_0(-994266838), text13);
						text16 = text16.Replace(Class84.smethod_0(-994267075), newValue2);
						if (hashSet2.Count > 0)
						{
							string text17 = JsonConvert.SerializeObject(hashSet2);
							@class.method_2(text17, Class84.smethod_0(-994267094), text16, Class84.smethod_0(-994267055), text11);
						}
						@class.method_4(string.Empty, text13, string.Empty, string.Empty, Class84.smethod_0(-994267094), text16, Class84.smethod_0(-994267055), text11);
						text13 = text14;
						newValue2 = text15;
						hashSet2.Clear();
						hashSet2.Add(item2);
					}
				}
				if (!text13.Equals(string.Empty))
				{
					string text18 = text.Replace(Class84.smethod_0(-994266838), text13);
					text18 = text18.Replace(Class84.smethod_0(-994267075), newValue2);
					if (hashSet2.Count > 0)
					{
						string text19 = JsonConvert.SerializeObject(hashSet2);
						@class.method_2(text19, Class84.smethod_0(-994267094), text18, Class84.smethod_0(-994267055), text11);
					}
					@class.method_4(string.Empty, text13, string.Empty, string.Empty, Class84.smethod_0(-994267094), text18, Class84.smethod_0(-994267055), text11);
				}
			}
			mySqlTransaction.Commit();
			Class355.smethod_3(Class84.smethod_0(-994266842));
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

	private void GForm2_Load(object sender, EventArgs e)
	{
	}

	private void method_1()
	{
		try
		{
			Cursor = Cursors.WaitCursor;
			bool_0 = true;
			DateTime dateTime = Class348.Class349.smethod_0();
			comboBox_4.Items.Clear();
			for (int i = Class224.Class227.int_0; i <= dateTime.Year + 1; i++)
			{
				comboBox_4.Items.Add(i);
			}
			comboBox_4.Text = dateTime.Year.ToString();
			comboBox_3.Items.Clear();
			for (int j = 1; j <= 12; j++)
			{
				comboBox_3.Items.Add(Class120.smethod_18(j));
			}
			comboBox_3.SelectedIndex = dateTime.Month - 1;
			method_2();
			comboBox_1.Items.Clear();
			for (int k = 0; k < 24; k++)
			{
				comboBox_1.Items.Add(k.ToString().PadLeft(2, '0'));
			}
			comboBox_1.Text = dateTime.Hour.ToString().PadLeft(2, '0');
			comboBox_0.Items.Clear();
			for (int l = 0; l < 60; l++)
			{
				comboBox_0.Items.Add(l.ToString().PadLeft(2, '0'));
			}
			comboBox_0.Text = dateTime.Minute.ToString().PadLeft(2, '0');
		}
		catch (Exception ex)
		{
			Cursor = Cursors.Default;
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			bool_0 = false;
			Cursor = Cursors.Default;
		}
	}

	private void method_2()
	{
		DateTime dateTime = Class348.Class349.smethod_0();
		comboBox_2.Items.Clear();
		int num = Class120.smethod_0(Convert.ToInt32(comboBox_4.Text), comboBox_3.SelectedIndex + 1);
		for (int i = 1; i <= num; i++)
		{
			comboBox_2.Items.Add(i.ToString().PadLeft(2, '0'));
		}
		if (comboBox_4.Text == dateTime.Year.ToString() && comboBox_3.SelectedIndex == dateTime.Month - 1)
		{
			comboBox_2.SelectedIndex = dateTime.Day - 1;
		}
		else
		{
			comboBox_2.SelectedIndex = 0;
		}
	}

	private void radioButton_0_CheckedChanged(object sender, EventArgs e)
	{
		comboBox_4.Enabled = true;
		comboBox_3.Enabled = true;
		comboBox_2.Enabled = true;
		comboBox_1.Enabled = true;
		comboBox_0.Enabled = true;
	}

	private void radioButton_1_CheckedChanged(object sender, EventArgs e)
	{
		comboBox_4.Enabled = false;
		comboBox_3.Enabled = false;
		comboBox_2.Enabled = false;
		comboBox_1.Enabled = false;
		comboBox_0.Enabled = false;
	}

	private void comboBox_4_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			method_2();
		}
	}

	private void comboBox_3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			method_2();
		}
	}

	private void GForm2_Shown(object sender, EventArgs e)
	{
		method_1();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_3()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm2));
		label_0 = new Label();
		button_0 = new Button();
		button_1 = new Button();
		textBox_0 = new TextBox();
		label_1 = new Label();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		comboBox_0 = new ComboBox();
		comboBox_1 = new ComboBox();
		comboBox_2 = new ComboBox();
		comboBox_3 = new ComboBox();
		comboBox_4 = new ComboBox();
		radioButton_0 = new RadioButton();
		radioButton_1 = new RadioButton();
		label_5 = new Label();
		groupBox_0 = new GroupBox();
		label_6 = new Label();
		label_7 = new Label();
		groupBox_0.SuspendLayout();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_0.Location = new Point(34, 25);
		label_0.Name = Class84.smethod_0(-994278834);
		label_0.Size = new Size(42, 13);
		label_0.TabIndex = 128;
		label_0.Text = Class84.smethod_0(-994266726);
		button_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		button_0.Image = Class309.smethod_10();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(155, 194);
		button_0.Name = Class84.smethod_0(-994278087);
		button_0.Size = new Size(69, 37);
		button_0.TabIndex = 127;
		button_0.Text = Class84.smethod_0(-994278089);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		button_1.Image = Class309.smethod_24();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(80, 194);
		button_1.Name = Class84.smethod_0(-994266730);
		button_1.Size = new Size(69, 37);
		button_1.TabIndex = 126;
		button_1.Text = Class84.smethod_0(-994266747);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		textBox_0.Font = new Font(Class84.smethod_0(-994278794), 11f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_0.Location = new Point(82, 25);
		textBox_0.MaxLength = 500;
		textBox_0.Multiline = true;
		textBox_0.Name = Class84.smethod_0(-994266702);
		textBox_0.Size = new Size(420, 76);
		textBox_0.TabIndex = 125;
		label_1.AutoSize = true;
		label_1.ForeColor = Color.Blue;
		label_1.Location = new Point(18, 29);
		label_1.Name = Class84.smethod_0(-994266720);
		label_1.Size = new Size(33, 13);
		label_1.TabIndex = 130;
		label_1.Text = Class84.smethod_0(-994267135);
		label_2.AutoSize = true;
		label_2.Location = new Point(71, 29);
		label_2.Name = Class84.smethod_0(-994266659);
		label_2.Size = new Size(99, 13);
		label_2.TabIndex = 131;
		label_2.Text = Class84.smethod_0(-994266678);
		label_3.AutoSize = true;
		label_3.Location = new Point(70, 63);
		label_3.Name = Class84.smethod_0(-994266638);
		label_3.Size = new Size(115, 13);
		label_3.TabIndex = 133;
		label_3.Text = Class84.smethod_0(-994266641);
		label_4.AutoSize = true;
		label_4.ForeColor = Color.Blue;
		label_4.Location = new Point(18, 63);
		label_4.Name = Class84.smethod_0(-994266614);
		label_4.Size = new Size(46, 13);
		label_4.TabIndex = 132;
		label_4.Text = Class84.smethod_0(-994267075);
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.Enabled = false;
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Location = new Point(455, 146);
		comboBox_0.Name = Class84.smethod_0(-994266617);
		comboBox_0.Size = new Size(45, 21);
		comboBox_0.TabIndex = 141;
		comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_1.Enabled = false;
		comboBox_1.FormattingEnabled = true;
		comboBox_1.Location = new Point(404, 146);
		comboBox_1.Name = Class84.smethod_0(-994266570);
		comboBox_1.Size = new Size(45, 21);
		comboBox_1.TabIndex = 140;
		comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_2.Enabled = false;
		comboBox_2.FormattingEnabled = true;
		comboBox_2.Location = new Point(344, 146);
		comboBox_2.Name = Class84.smethod_0(-994266589);
		comboBox_2.Size = new Size(45, 21);
		comboBox_2.TabIndex = 139;
		comboBox_3.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_3.Enabled = false;
		comboBox_3.FormattingEnabled = true;
		comboBox_3.Location = new Point(252, 146);
		comboBox_3.Name = Class84.smethod_0(-994266540);
		comboBox_3.Size = new Size(86, 21);
		comboBox_3.TabIndex = 138;
		comboBox_3.SelectedIndexChanged += comboBox_3_SelectedIndexChanged;
		comboBox_4.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_4.Enabled = false;
		comboBox_4.FormattingEnabled = true;
		comboBox_4.Location = new Point(193, 146);
		comboBox_4.Name = Class84.smethod_0(-994266557);
		comboBox_4.Size = new Size(53, 21);
		comboBox_4.TabIndex = 137;
		comboBox_4.SelectedIndexChanged += comboBox_4_SelectedIndexChanged;
		radioButton_0.AutoSize = true;
		radioButton_0.Location = new Point(80, 146);
		radioButton_0.Name = Class84.smethod_0(-994266510);
		radioButton_0.Size = new Size(103, 17);
		radioButton_0.TabIndex = 136;
		radioButton_0.Text = Class84.smethod_0(-994266527);
		radioButton_0.UseVisualStyleBackColor = true;
		radioButton_0.CheckedChanged += radioButton_0_CheckedChanged;
		radioButton_1.AutoSize = true;
		radioButton_1.Checked = true;
		radioButton_1.Location = new Point(80, 116);
		radioButton_1.Name = Class84.smethod_0(-994266473);
		radioButton_1.Size = new Size(71, 17);
		radioButton_1.TabIndex = 135;
		radioButton_1.TabStop = true;
		radioButton_1.Text = Class84.smethod_0(-994266493);
		radioButton_1.UseVisualStyleBackColor = true;
		radioButton_1.CheckedChanged += radioButton_1_CheckedChanged;
		label_5.AutoSize = true;
		label_5.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_5.Location = new Point(27, 118);
		label_5.Name = Class84.smethod_0(-994266446);
		label_5.Size = new Size(46, 13);
		label_5.TabIndex = 134;
		label_5.Text = Class84.smethod_0(-994266464);
		label_5.TextAlign = ContentAlignment.TopRight;
		groupBox_0.Controls.Add(label_6);
		groupBox_0.Controls.Add(label_7);
		groupBox_0.Controls.Add(label_2);
		groupBox_0.Controls.Add(label_1);
		groupBox_0.Controls.Add(label_4);
		groupBox_0.Controls.Add(label_3);
		groupBox_0.Location = new Point(302, 183);
		groupBox_0.Name = Class84.smethod_0(-994278480);
		groupBox_0.Size = new Size(200, 82);
		groupBox_0.TabIndex = 142;
		groupBox_0.TabStop = false;
		groupBox_0.Text = Class84.smethod_0(-994266403);
		label_6.AutoSize = true;
		label_6.Location = new Point(71, 46);
		label_6.Name = Class84.smethod_0(-994278767);
		label_6.Size = new Size(112, 13);
		label_6.TabIndex = 135;
		label_6.Text = Class84.smethod_0(-994266417);
		label_7.AutoSize = true;
		label_7.ForeColor = Color.Blue;
		label_7.Location = new Point(18, 46);
		label_7.Name = Class84.smethod_0(-994266391);
		label_7.Size = new Size(33, 13);
		label_7.TabIndex = 134;
		label_7.Text = Class84.smethod_0(-994266838);
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(531, 277);
		Controls.Add(groupBox_0);
		Controls.Add(comboBox_0);
		Controls.Add(comboBox_1);
		Controls.Add(comboBox_2);
		Controls.Add(comboBox_3);
		Controls.Add(comboBox_4);
		Controls.Add(radioButton_0);
		Controls.Add(radioButton_1);
		Controls.Add(label_5);
		Controls.Add(label_0);
		Controls.Add(button_0);
		Controls.Add(button_1);
		Controls.Add(textBox_0);
		Icon = (Icon)componentResourceManager.GetObject(Class84.smethod_0(-994278109));
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class84.smethod_0(-994266394);
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class84.smethod_0(-994266368);
		Load += GForm2_Load;
		Shown += GForm2_Shown;
		groupBox_0.ResumeLayout(performLayout: false);
		groupBox_0.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
