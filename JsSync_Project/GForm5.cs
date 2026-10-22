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

public sealed class GForm5 : Form
{
	private sealed class Class333 : GClass59
	{
		private readonly GForm5 gform5_0;

		public Class333(GForm5 gform5_1)
		{
			gform5_0 = gform5_1;
		}

		public override void vmethod_0(GClass41 gclass41_0, JsRequest jsRequest_0, string string_0)
		{
			if (gform5_0.InvokeRequired)
			{
				GDelegate13 method = vmethod_0;
				gform5_0.Invoke(method, gclass41_0, jsRequest_0, string_0);
			}
			else
			{
				gform5_0.method_4(jsRequest_0);
			}
		}

		public override void vmethod_1(GClass41 gclass41_0, string string_0)
		{
			if (gform5_0.InvokeRequired)
			{
				GDelegate12 method = vmethod_1;
				gform5_0.Invoke(method, gclass41_0, string_0);
			}
			else
			{
				gform5_0.method_5(string_0);
			}
		}
	}

	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private DataTable dataTable_0;

	private Class216 class216_0;

	private string string_0;

	private string string_1;

	private IContainer icontainer_0;

	private Label label_0;

	private Class193 class193_0;

	private Button button_0;

	private LinkLabel linkLabel_0;

	private Button button_1;

	private LinkLabel linkLabel_1;

	private LinkLabel linkLabel_2;

	private Button button_2;

	private GroupBox groupBox_0;

	private GroupBox groupBox_1;

	private Button button_3;

	public GForm5(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gform17_1.method_0();
		method_8();
		method_0();
	}

	private void GForm5_Load(object sender, EventArgs e)
	{
	}

	private void method_0()
	{
		dataTable_0 = new DataTable();
		dataTable_0.Columns.Add(Class84.smethod_0(-994276501), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994277056), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994276469), Type.GetType(Class84.smethod_0(-994276473)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994276436), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994277142), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994276441), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994276954), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994276396), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994276414), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994276993), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994276975), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994276989), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994276939), Type.GetType(Class84.smethod_0(-994276505)));
		class216_0 = new Class216(class193_0, bool_0: false, bool_1: false);
		class216_0.method_4();
		class216_0.method_4();
		class216_0.method_5(Class84.smethod_0(-994276321), 60, bool_0: false);
		class216_0.method_2(Class84.smethod_0(-994276341), 120, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994276345), 200, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994276302), 70, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994276305), 200, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994276257), 120, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994276274), 120, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994278442), 180, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994278405), 180, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994278418), 180, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994278380), 180, bool_0: true);
	}

	public void method_1(string string_2, string string_3, string string_4)
	{
		Text = string_2;
		label_0.Text = string_2;
		string_0 = string_3;
		string_1 = string_4;
		method_2();
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
		dataTable_0.Rows.Clear();
		class216_0.method_12();
		MySqlDataReader mySqlDataReader = new MySqlCommand
		{
			Connection = mySqlConnection_0,
			CommandText = string_0
		}.ExecuteReader();
		while (mySqlDataReader.Read())
		{
			int int_ = Class159.smethod_0(mySqlDataReader[Class84.smethod_0(-994276939)].ToString(), 1);
			DataRow dataRow = dataTable_0.NewRow();
			dataRow[Class84.smethod_0(-994276501)] = mySqlDataReader[Class84.smethod_0(-994276501)];
			dataRow[Class84.smethod_0(-994277056)] = mySqlDataReader[Class84.smethod_0(-994277056)];
			dataRow[Class84.smethod_0(-994276469)] = false;
			dataRow[Class84.smethod_0(-994276436)] = mySqlDataReader[Class84.smethod_0(-994276436)];
			dataRow[Class84.smethod_0(-994277142)] = mySqlDataReader[Class84.smethod_0(-994277142)];
			dataRow[Class84.smethod_0(-994276441)] = ((Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994275514)]) == 1) ? Class84.smethod_0(-994275430) : Class84.smethod_0(-994275480));
			dataRow[Class84.smethod_0(-994276954)] = mySqlDataReader[Class84.smethod_0(-994276954)];
			dataRow[Class84.smethod_0(-994276396)] = mySqlDataReader[Class84.smethod_0(-994276396)];
			dataRow[Class84.smethod_0(-994276414)] = mySqlDataReader[Class84.smethod_0(-994276414)];
			dataRow[Class84.smethod_0(-994276993)] = mySqlDataReader[Class84.smethod_0(-994276993)];
			dataRow[Class84.smethod_0(-994276975)] = mySqlDataReader[Class84.smethod_0(-994276975)];
			dataRow[Class84.smethod_0(-994276989)] = mySqlDataReader[Class84.smethod_0(-994276989)];
			dataRow[Class84.smethod_0(-994276939)] = Class314.smethod_0(int_);
			dataTable_0.Rows.Add(dataRow);
		}
		mySqlDataReader.Close();
		class216_0.method_9(dataTable_0);
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		try
		{
			GClass70 gClass = Class316.smethod_12();
			if (gClass.Value != 1)
			{
				Class355.smethod_0(gClass.Text);
			}
			else
			{
				if (class193_0.Rows.Count == 0)
				{
					return;
				}
				GClass41 gClass2 = gclass5_0.method_9(0);
				if (gClass2 == null)
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
				gClass2.method_52(jsRequest_, 10000, new Class333(this));
				button_0.Enabled = false;
				Cursor = Cursors.WaitCursor;
			}
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
			button_0.Enabled = true;
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

	public void method_5(string string_2)
	{
		button_0.Enabled = true;
		Cursor = Cursors.Default;
		Class355.smethod_0(string_2);
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel_0.Enabled = false;
		method_2();
		linkLabel_0.Enabled = true;
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

	private void method_6(bool bool_0)
	{
		foreach (DataRow row in dataTable_0.Rows)
		{
			row[Class84.smethod_0(-994276469)] = bool_0;
		}
		class216_0.method_9(dataTable_0);
	}

	private void linkLabel_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (dataTable_0.Rows.Count != 0)
		{
			method_6(bool_0: true);
		}
	}

	private void linkLabel_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (dataTable_0.Rows.Count != 0)
		{
			method_6(bool_0: false);
		}
	}

	private Tuple<string, int> method_7()
	{
		int num = 0;
		string text = string.Empty;
		foreach (DataRow row in class216_0.method_14(new int[2] { 3, 2 }).Rows)
		{
			string text2 = Convert.ToString(row[0]);
			if (Convert.ToBoolean(row[1]))
			{
				if (text != string.Empty)
				{
					text += Class84.smethod_0(-994279022);
				}
				text = text + Class84.smethod_0(-994271698) + text2 + Class84.smethod_0(-994271698);
				num++;
			}
		}
		return new Tuple<string, int>(text, num);
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
			return;
		}
		var (text2, num2) = method_7();
		if (num2 > Class224.Class226.int_19)
		{
			Class355.smethod_0(string.Format(Class84.smethod_0(-994279030), Class224.Class226.int_19));
			return;
		}
		if (text2.Equals(string.Empty))
		{
			Class355.smethod_0(Class84.smethod_0(-994278948));
			return;
		}
		if (Class348.Class352.string_0.Trim().Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994278342));
			return;
		}
		GForm2 gForm = new GForm2();
		gForm.method_0(text2, string.Empty);
		gForm.ShowDialog();
	}

	private void button_3_Click(object sender, EventArgs e)
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

	private void method_8()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm5));
		label_0 = new Label();
		button_0 = new Button();
		linkLabel_0 = new LinkLabel();
		button_1 = new Button();
		linkLabel_1 = new LinkLabel();
		linkLabel_2 = new LinkLabel();
		button_2 = new Button();
		class193_0 = new Class193();
		groupBox_0 = new GroupBox();
		groupBox_1 = new GroupBox();
		button_3 = new Button();
		((ISupportInitialize)class193_0).BeginInit();
		groupBox_0.SuspendLayout();
		groupBox_1.SuspendLayout();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994278216);
		label_0.Size = new Size(104, 17);
		label_0.TabIndex = 54;
		label_0.Text = Class84.smethod_0(-994278218);
		button_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button_0.Location = new Point(16, 23);
		button_0.Name = Class84.smethod_0(-994278680);
		button_0.Size = new Size(163, 33);
		button_0.TabIndex = 71;
		button_0.Text = Class84.smethod_0(-994278626);
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		linkLabel_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		linkLabel_0.AutoSize = true;
		linkLabel_0.Location = new Point(912, 582);
		linkLabel_0.Name = Class84.smethod_0(-994278181);
		linkLabel_0.Size = new Size(59, 13);
		linkLabel_0.TabIndex = 73;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class84.smethod_0(-994278198);
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		button_1.Image = Class309.smethod_14();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(800, 576);
		button_1.Name = Class84.smethod_0(-994278698);
		button_1.Size = new Size(106, 29);
		button_1.TabIndex = 95;
		button_1.Text = Class84.smethod_0(-994278149);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		linkLabel_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		linkLabel_1.AutoSize = true;
		linkLabel_1.Location = new Point(134, 40);
		linkLabel_1.Name = Class84.smethod_0(-994278586);
		linkLabel_1.Size = new Size(66, 13);
		linkLabel_1.TabIndex = 97;
		linkLabel_1.TabStop = true;
		linkLabel_1.Text = Class84.smethod_0(-994278550);
		linkLabel_1.LinkClicked += linkLabel_1_LinkClicked;
		linkLabel_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		linkLabel_2.AutoSize = true;
		linkLabel_2.Location = new Point(134, 23);
		linkLabel_2.Name = Class84.smethod_0(-994278500);
		linkLabel_2.Size = new Size(59, 13);
		linkLabel_2.TabIndex = 96;
		linkLabel_2.TabStop = true;
		linkLabel_2.Text = Class84.smethod_0(-994278514);
		linkLabel_2.LinkClicked += linkLabel_2_LinkClicked;
		button_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		button_2.Location = new Point(21, 23);
		button_2.Name = Class84.smethod_0(-994278612);
		button_2.Size = new Size(107, 33);
		button_2.TabIndex = 98;
		button_2.Text = Class84.smethod_0(-994278561);
		button_2.UseVisualStyleBackColor = true;
		button_2.Click += button_2_Click;
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(24, 51);
		class193_0.Name = Class84.smethod_0(-994278735);
		class193_0.Size = new Size(953, 495);
		class193_0.TabIndex = 70;
		groupBox_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		groupBox_0.Controls.Add(button_2);
		groupBox_0.Controls.Add(linkLabel_2);
		groupBox_0.Controls.Add(linkLabel_1);
		groupBox_0.Location = new Point(24, 552);
		groupBox_0.Name = Class84.smethod_0(-994278480);
		groupBox_0.Size = new Size(226, 71);
		groupBox_0.TabIndex = 99;
		groupBox_0.TabStop = false;
		groupBox_0.Text = Class84.smethod_0(-994278561);
		groupBox_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		groupBox_1.Controls.Add(button_0);
		groupBox_1.Location = new Point(256, 552);
		groupBox_1.Name = Class84.smethod_0(-994278161);
		groupBox_1.Size = new Size(200, 71);
		groupBox_1.TabIndex = 100;
		groupBox_1.TabStop = false;
		groupBox_1.Text = Class84.smethod_0(-994278113);
		button_3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		button_3.Image = Class309.smethod_10();
		button_3.ImageAlign = ContentAlignment.MiddleLeft;
		button_3.Location = new Point(728, 576);
		button_3.Name = Class84.smethod_0(-994278087);
		button_3.Size = new Size(66, 29);
		button_3.TabIndex = 101;
		button_3.Text = Class84.smethod_0(-994278089);
		button_3.TextAlign = ContentAlignment.MiddleRight;
		button_3.UseVisualStyleBackColor = true;
		button_3.Click += button_3_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1000, 633);
		Controls.Add(button_3);
		Controls.Add(groupBox_1);
		Controls.Add(groupBox_0);
		Controls.Add(button_1);
		Controls.Add(linkLabel_0);
		Controls.Add(class193_0);
		Controls.Add(label_0);
		Icon = (Icon)componentResourceManager.GetObject(Class84.smethod_0(-994278109));
		Name = Class84.smethod_0(-994278060);
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class84.smethod_0(-994278218);
		Load += GForm5_Load;
		((ISupportInitialize)class193_0).EndInit();
		groupBox_0.ResumeLayout(performLayout: false);
		groupBox_0.PerformLayout();
		groupBox_1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
