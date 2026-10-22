using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;

public sealed class GForm28 : Form
{
	private sealed class Class335 : GClass59
	{
		private readonly GForm28 gform28_0;

		public Class335(GForm28 gform28_1)
		{
			gform28_0 = gform28_1;
		}

		public override void vmethod_0(GClass41 gclass41_0, JsRequest jsRequest_0, string string_0)
		{
			if (gform28_0.InvokeRequired)
			{
				GDelegate13 method = vmethod_0;
				gform28_0.Invoke(method, gclass41_0, jsRequest_0, string_0);
			}
			else
			{
				gform28_0.method_4(jsRequest_0);
			}
		}

		public override void vmethod_1(GClass41 gclass41_0, string string_0)
		{
			if (gform28_0.InvokeRequired)
			{
				GDelegate12 method = vmethod_1;
				gform28_0.Invoke(method, gclass41_0, string_0);
			}
			else
			{
				gform28_0.method_5(string_0);
			}
		}
	}

	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private DataTable dataTable_0;

	private Class216 class216_0;

	private bool bool_0;

	private string string_0;

	private IContainer icontainer_0;

	private Button button_0;

	private TextBox textBox_0;

	private ComboBox comboBox_0;

	private ComboBox comboBox_1;

	private Label label_0;

	private Label label_1;

	private Class193 class193_0;

	private Label label_2;

	private Button button_1;

	private Button button_2;

	private PictureBox pictureBox_0;

	private Button button_3;

	private LinkLabel linkLabel_0;

	private LinkLabel linkLabel_1;

	private GroupBox groupBox_0;

	public GForm28(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gform17_1.method_0();
		method_8();
		method_1();
		method_0();
	}

	private void method_0()
	{
		bool_0 = true;
		comboBox_0.SelectedIndex = 0;
		comboBox_1.SelectedIndex = 1;
		bool_0 = false;
	}

	private void method_1()
	{
		try
		{
			dataTable_0 = new DataTable();
			dataTable_0.Columns.Add(Class84.smethod_0(-994276501), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994276469), Type.GetType(Class84.smethod_0(-994276473)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994276436), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994277142), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994276441), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994276954), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994276396), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994276414), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994276368), Type.GetType(Class84.smethod_0(-994276372)));
			class216_0 = new Class216(class193_0, bool_0: false, bool_1: false);
			class216_0.method_4();
			class216_0.method_5(Class84.smethod_0(-994276321), 60, bool_0: false);
			class216_0.method_2(Class84.smethod_0(-994276341), 120, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994276345), 200, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994276302), 70, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994276305), 200, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994276257), 120, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994276274), 120, bool_0: true);
			class216_0.method_4();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void GForm28_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void method_2()
	{
		label_2.Text = string.Empty;
		string text = textBox_0.Text.Trim().Replace('\'', '`');
		if (text.Length < 3)
		{
			label_2.Text = Class84.smethod_0(-994276237);
			return;
		}
		string_0 = text;
		method_3(null);
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_3(MySqlConnection mySqlConnection_0)
	{
		bool flag = false;
		if (mySqlConnection_0 == null)
		{
			mySqlConnection_0 = new MySqlConnection(Class224.Class228.smethod_0());
			flag = true;
		}
		try
		{
			Cursor = Cursors.WaitCursor;
			mySqlConnection_0.Open();
			dataTable_0.Rows.Clear();
			class216_0.method_12();
			string text = string.Empty;
			if (comboBox_1.SelectedIndex == 0)
			{
				string arg = ((comboBox_0.SelectedIndex == 0) ? Class84.smethod_0(-994276221) : Class84.smethod_0(-994276201));
				text = Class84.smethod_0(-994276176);
				text = string.Format(text, arg, string_0);
			}
			else if (comboBox_1.SelectedIndex == 1)
			{
				string arg2 = ((comboBox_0.SelectedIndex == 0) ? Class84.smethod_0(-994275813) : Class84.smethod_0(-994275857));
				text = Class84.smethod_0(-994275832);
				text = string.Format(text, arg2, string_0);
			}
			foreach (DataRow row in Class280.smethod_6(mySqlConnection_0, text).Rows)
			{
				DataRow dataRow2 = dataTable_0.NewRow();
				dataRow2[Class84.smethod_0(-994276501)] = row[Class84.smethod_0(-994276501)];
				dataRow2[Class84.smethod_0(-994276469)] = false;
				dataRow2[Class84.smethod_0(-994276436)] = row[Class84.smethod_0(-994276436)];
				dataRow2[Class84.smethod_0(-994277142)] = row[Class84.smethod_0(-994277142)];
				dataRow2[Class84.smethod_0(-994276441)] = ((Convert.ToInt32(row[Class84.smethod_0(-994275514)]) == 1) ? Class84.smethod_0(-994275430) : Class84.smethod_0(-994275480));
				dataRow2[Class84.smethod_0(-994276954)] = row[Class84.smethod_0(-994276954)];
				dataRow2[Class84.smethod_0(-994276396)] = row[Class84.smethod_0(-994276396)];
				dataRow2[Class84.smethod_0(-994276414)] = row[Class84.smethod_0(-994276414)];
				dataRow2[Class84.smethod_0(-994276368)] = row[Class84.smethod_0(-994276368)];
				dataTable_0.Rows.Add(dataRow2);
			}
			if (dataTable_0.Rows.Count == 0)
			{
				label_2.Text = Class84.smethod_0(-994275434);
				return;
			}
			label_2.Text = string.Format(Class84.smethod_0(-994275415), dataTable_0.Rows.Count);
			class216_0.method_9(dataTable_0);
		}
		catch (Exception ex)
		{
			Cursor = Cursors.Default;
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			Cursor = Cursors.Default;
			if (flag)
			{
				mySqlConnection_0.Close();
			}
		}
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			dataTable_0.Rows.Clear();
			class216_0.method_12();
			label_2.Text = string.Empty;
		}
	}

	private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			dataTable_0.Rows.Clear();
			class216_0.method_12();
			label_2.Text = string.Empty;
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

	private void button_2_Click(object sender, EventArgs e)
	{
		try
		{
			if (class193_0.Rows.Count == 0)
			{
				return;
			}
			List<string> list = new List<string>();
			for (int i = 0; i < class193_0.Rows.Count; i++)
			{
				string item = class193_0.Rows[i].Cells[0].Value.ToString();
				if (class193_0.Rows[i].Cells[1].Value.ToString().Trim().Length == 0)
				{
					list.Add(item);
				}
			}
			if (list.Count == 0)
			{
				Class355.smethod_3(Class84.smethod_0(-994275386));
				return;
			}
			string data = JsonConvert.SerializeObject(list);
			JsUserRequest userRequest = new JsUserRequest
			{
				SchoolId = Class348.Class352.string_0,
				SchoolName = Class348.Class352.string_1,
				DataId = Class211.smethod_0(10),
				SessionId = string.Empty
			};
			JsRequest jsRequest_ = new JsRequest(JsProtocol.GetJsUserInfo, JsDirection.SchoolToServer, userRequest, 0, 0, 0, string.Empty, data, null);
			gclass5_0.method_9(0).method_52(jsRequest_, 10000, new Class335(this));
			button_2.Enabled = false;
			Cursor = Cursors.WaitCursor;
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_4(JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			button_2.Enabled = true;
			Cursor = Cursors.Default;
			if (jsRequest_0.ExecCode == 0)
			{
				Class355.smethod_3(Class84.smethod_0(-994279402));
				return;
			}
			if (jsRequest_0.ExecCode == -1)
			{
				Class355.smethod_0(jsRequest_0.Message);
				return;
			}
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			mySqlCommand.CommandText = Class84.smethod_0(-994279300);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994279142), MySqlDbType.VarChar);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994279145), MySqlDbType.VarChar);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994279162), MySqlDbType.VarChar);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994279114), MySqlDbType.VarChar);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994279080), MySqlDbType.VarChar);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994279093), MySqlDbType.VarChar);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994279042), MySqlDbType.Int32);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994279072), MySqlDbType.Date);
			foreach (List<string> item in JsonConvert.DeserializeObject<List<List<string>>>(jsRequest_0.Data.ToString()))
			{
				mySqlCommand.Parameters[Class84.smethod_0(-994279142)].Value = item[0].Trim();
				mySqlCommand.Parameters[Class84.smethod_0(-994279145)].Value = item[1].Trim();
				mySqlCommand.Parameters[Class84.smethod_0(-994279162)].Value = item[2].Trim();
				mySqlCommand.Parameters[Class84.smethod_0(-994279114)].Value = item[3].Trim();
				mySqlCommand.Parameters[Class84.smethod_0(-994279072)].Value = item[4].Trim();
				mySqlCommand.Parameters[Class84.smethod_0(-994279080)].Value = item[5].Trim();
				mySqlCommand.Parameters[Class84.smethod_0(-994279093)].Value = item[6].Trim();
				mySqlCommand.Parameters[Class84.smethod_0(-994279042)].Value = Class159.smethod_0(item[7].Trim(), 1);
				mySqlCommand.ExecuteNonQuery();
			}
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

	public void method_5(string string_1)
	{
		button_2.Enabled = true;
		Cursor = Cursors.Default;
		Class355.smethod_0(string_1);
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void textBox_0_KeyUp(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			method_2();
		}
	}

	private void method_6(bool bool_1)
	{
		foreach (DataRow row in dataTable_0.Rows)
		{
			row[Class84.smethod_0(-994276469)] = bool_1;
		}
		class216_0.method_9(dataTable_0);
	}

	private void linkLabel_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (dataTable_0.Rows.Count != 0)
		{
			method_6(bool_1: true);
		}
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (dataTable_0.Rows.Count != 0)
		{
			method_6(bool_1: false);
		}
	}

	private Tuple<string, string, int> method_7()
	{
		int num = 0;
		string text = string.Empty;
		string text2 = string.Empty;
		foreach (DataRow row in class216_0.method_14(new int[3] { 2, 1, 8 }).Rows)
		{
			string text3 = Convert.ToString(row[0]);
			bool flag = Convert.ToBoolean(row[1]);
			int num2 = Convert.ToInt32(row[2]);
			if (!flag)
			{
				continue;
			}
			if (num2 == 0)
			{
				if (text2 != string.Empty)
				{
					text2 += Class84.smethod_0(-994279022);
				}
				text2 = text2 + Class84.smethod_0(-994271698) + text3 + Class84.smethod_0(-994271698);
			}
			else
			{
				if (text != string.Empty)
				{
					text += Class84.smethod_0(-994279022);
				}
				text = text + Class84.smethod_0(-994271698) + text3 + Class84.smethod_0(-994271698);
			}
			num++;
		}
		return new Tuple<string, string, int>(text, text2, num);
	}

	private void button_3_Click(object sender, EventArgs e)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
			return;
		}
		var (text3, text4, num2) = method_7();
		if (num2 > Class224.Class226.int_19)
		{
			Class355.smethod_0(string.Format(Class84.smethod_0(-994279030), Class224.Class226.int_19));
			return;
		}
		if (text3.Equals(string.Empty) && text4.Equals(string.Empty))
		{
			Class355.smethod_0(Class84.smethod_0(-994278948));
			return;
		}
		GForm2 gForm = new GForm2();
		gForm.method_0(text3, text4);
		gForm.ShowDialog();
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
		button_0 = new Button();
		textBox_0 = new TextBox();
		comboBox_0 = new ComboBox();
		comboBox_1 = new ComboBox();
		label_0 = new Label();
		label_1 = new Label();
		class193_0 = new Class193();
		label_2 = new Label();
		button_1 = new Button();
		button_2 = new Button();
		pictureBox_0 = new PictureBox();
		button_3 = new Button();
		linkLabel_0 = new LinkLabel();
		linkLabel_1 = new LinkLabel();
		groupBox_0 = new GroupBox();
		((ISupportInitialize)class193_0).BeginInit();
		((ISupportInitialize)pictureBox_0).BeginInit();
		groupBox_0.SuspendLayout();
		SuspendLayout();
		button_0.Location = new Point(487, 54);
		button_0.Name = Class84.smethod_0(-994278923);
		button_0.Size = new Size(46, 23);
		button_0.TabIndex = 93;
		button_0.Text = Class84.smethod_0(-994278942);
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		textBox_0.Location = new Point(306, 56);
		textBox_0.Name = Class84.smethod_0(-994278883);
		textBox_0.Size = new Size(175, 20);
		textBox_0.TabIndex = 92;
		textBox_0.KeyUp += textBox_0_KeyUp;
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Items.AddRange(new object[2]
		{
			Class84.smethod_0(-994276345),
			Class84.smethod_0(-994278899)
		});
		comboBox_0.Location = new Point(52, 56);
		comboBox_0.Name = Class84.smethod_0(-994278855);
		comboBox_0.Size = new Size(121, 21);
		comboBox_0.TabIndex = 91;
		comboBox_0.SelectedIndexChanged += comboBox_0_SelectedIndexChanged;
		comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_1.FormattingEnabled = true;
		comboBox_1.Items.AddRange(new object[2]
		{
			Class84.smethod_0(-994278858),
			Class84.smethod_0(-994278876)
		});
		comboBox_1.Location = new Point(179, 56);
		comboBox_1.Name = Class84.smethod_0(-994278832);
		comboBox_1.Size = new Size(121, 21);
		comboBox_1.TabIndex = 90;
		comboBox_1.SelectedIndexChanged += comboBox_1_SelectedIndexChanged;
		label_0.AutoSize = true;
		label_0.Location = new Point(21, 59);
		label_0.Name = Class84.smethod_0(-994278834);
		label_0.Size = new Size(25, 13);
		label_0.TabIndex = 89;
		label_0.Text = Class84.smethod_0(-994278789);
		label_1.AutoSize = true;
		label_1.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_1.ForeColor = Color.Teal;
		label_1.Location = new Point(21, 20);
		label_1.Name = Class84.smethod_0(-994278767);
		label_1.Size = new Size(90, 17);
		label_1.TabIndex = 88;
		label_1.Text = Class84.smethod_0(-994278770);
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(24, 87);
		class193_0.Name = Class84.smethod_0(-994278735);
		class193_0.Size = new Size(949, 404);
		class193_0.TabIndex = 94;
		label_2.AutoSize = true;
		label_2.ForeColor = Color.Blue;
		label_2.Location = new Point(539, 59);
		label_2.Name = Class84.smethod_0(-994278751);
		label_2.Size = new Size(10, 13);
		label_2.TabIndex = 95;
		label_2.Text = Class84.smethod_0(-994278690);
		button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		button_1.Image = Class309.smethod_14();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(867, 516);
		button_1.Name = Class84.smethod_0(-994278698);
		button_1.Size = new Size(106, 29);
		button_1.TabIndex = 96;
		button_1.Text = Class84.smethod_0(-994278718);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		button_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		button_2.Location = new Point(264, 522);
		button_2.Name = Class84.smethod_0(-994278680);
		button_2.Size = new Size(163, 23);
		button_2.TabIndex = 97;
		button_2.Text = Class84.smethod_0(-994278626);
		button_2.UseVisualStyleBackColor = true;
		button_2.Visible = false;
		button_2.Click += button_2_Click;
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(966, 3);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 98;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		button_3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		button_3.Location = new Point(6, 19);
		button_3.Name = Class84.smethod_0(-994278612);
		button_3.Size = new Size(107, 29);
		button_3.TabIndex = 101;
		button_3.Text = Class84.smethod_0(-994278561);
		button_3.UseVisualStyleBackColor = true;
		button_3.Click += button_3_Click;
		linkLabel_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		linkLabel_0.AutoSize = true;
		linkLabel_0.Location = new Point(119, 33);
		linkLabel_0.Name = Class84.smethod_0(-994278586);
		linkLabel_0.Size = new Size(66, 13);
		linkLabel_0.TabIndex = 100;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class84.smethod_0(-994278550);
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		linkLabel_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		linkLabel_1.AutoSize = true;
		linkLabel_1.Location = new Point(119, 18);
		linkLabel_1.Name = Class84.smethod_0(-994278500);
		linkLabel_1.Size = new Size(59, 13);
		linkLabel_1.TabIndex = 99;
		linkLabel_1.TabStop = true;
		linkLabel_1.Text = Class84.smethod_0(-994278514);
		linkLabel_1.LinkClicked += linkLabel_1_LinkClicked;
		groupBox_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		groupBox_0.Controls.Add(button_3);
		groupBox_0.Controls.Add(linkLabel_1);
		groupBox_0.Controls.Add(linkLabel_0);
		groupBox_0.Location = new Point(24, 497);
		groupBox_0.Name = Class84.smethod_0(-994278480);
		groupBox_0.Size = new Size(212, 59);
		groupBox_0.TabIndex = 102;
		groupBox_0.TabStop = false;
		groupBox_0.Text = Class84.smethod_0(-994278561);
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(985, 563);
		Controls.Add(groupBox_0);
		Controls.Add(pictureBox_0);
		Controls.Add(button_2);
		Controls.Add(button_1);
		Controls.Add(label_2);
		Controls.Add(class193_0);
		Controls.Add(button_0);
		Controls.Add(textBox_0);
		Controls.Add(comboBox_0);
		Controls.Add(comboBox_1);
		Controls.Add(label_0);
		Controls.Add(label_1);
		Name = Class84.smethod_0(-994278496);
		Text = Class84.smethod_0(-994278770);
		Load += GForm28_Load;
		((ISupportInitialize)class193_0).EndInit();
		((ISupportInitialize)pictureBox_0).EndInit();
		groupBox_0.ResumeLayout(performLayout: false);
		groupBox_0.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
