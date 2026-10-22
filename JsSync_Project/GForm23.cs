using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm23 : Form
{
	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private Class216 class216_0;

	private DataTable dataTable_0;

	private IContainer icontainer_0;

	private Label label_0;

	private PictureBox pictureBox_0;

	private Class193 class193_0;

	private LinkLabel linkLabel_0;

	private Button button_0;

	public GForm23(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gform17_1.method_0();
		method_4();
		method_0();
	}

	private void method_0()
	{
		try
		{
			class216_0 = new Class216(class193_0, bool_0: false, bool_1: false);
			class216_0.method_2(Class84.smethod_0(-994252133), 100, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994276345), 220, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994256485), 120, bool_0: true);
			class216_0.method_7(Class84.smethod_0(-994258388), 60);
			class216_0.method_1(3, method_1);
			dataTable_0 = new DataTable();
			dataTable_0.Columns.Add(Class84.smethod_0(-994266832), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994277142), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994264701), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994255947), Type.GetType(Class84.smethod_0(-994276505)));
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_1(int int_0, DataGridViewRow dataGridViewRow_0)
	{
		if (gclass5_0.gclass6_0.method_6() != 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994254164));
		}
		else
		{
			if (Class355.smethod_1(Class84.smethod_0(-994254081)) == DialogResult.Cancel)
			{
				return;
			}
			string arg = dataGridViewRow_0.Cells[0].Value.ToString();
			MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
			try
			{
				mySqlConnection.Open();
				MySqlCommand mySqlCommand = new MySqlCommand();
				mySqlCommand.Connection = mySqlConnection;
				string format = Class84.smethod_0(-994254076);
				format = string.Format(format, arg);
				mySqlCommand.CommandText = format;
				mySqlCommand.ExecuteNonQuery();
				method_2();
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
	}

	public void method_2()
	{
		dataTable_0.Rows.Clear();
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = Class84.smethod_0(-994253893)
			}.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994264701)]);
				DataRow dataRow = dataTable_0.NewRow();
				dataRow[Class84.smethod_0(-994266832)] = mySqlDataReader[Class84.smethod_0(-994253701)];
				dataRow[Class84.smethod_0(-994277142)] = mySqlDataReader[Class84.smethod_0(-994277142)];
				dataRow[Class84.smethod_0(-994264701)] = ((num == 1) ? Class84.smethod_0(-994253722) : Class84.smethod_0(-994253705));
				dataRow[Class84.smethod_0(-994255947)] = Class84.smethod_0(-994255947);
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

	private void button_0_Click(object sender, EventArgs e)
	{
		if (gclass5_0.gclass6_0.method_6() != 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994251331));
		}
		else
		{
			new GForm1(method_3, gform17_0, Class84.smethod_0(-994253675)).ShowDialog();
		}
	}

	public void method_3(string string_0, bool bool_0, string string_1, int int_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string format;
			if (bool_0)
			{
				format = Class84.smethod_0(-994252523);
				format = string.Format(format, string_0, string_1);
				mySqlCommand.CommandText = format;
				mySqlCommand.ExecuteNonQuery();
			}
			format = Class84.smethod_0(-994253637);
			format = string.Format(format, string_0, int_0);
			mySqlCommand.CommandText = format;
			mySqlCommand.ExecuteNonQuery();
			method_2();
			Close();
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

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel_0.Enabled = false;
		method_2();
		linkLabel_0.Enabled = true;
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void GForm23_Shown(object sender, EventArgs e)
	{
		button_0.Visible = gclass5_0.gclass6_0.method_6() == 0;
		method_2();
	}

	private void GForm23_Load(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_4()
	{
		label_0 = new Label();
		pictureBox_0 = new PictureBox();
		class193_0 = new Class193();
		linkLabel_0 = new LinkLabel();
		button_0 = new Button();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)class193_0).BeginInit();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994278834);
		label_0.Size = new Size(116, 17);
		label_0.TabIndex = 61;
		label_0.Text = Class84.smethod_0(-994253543);
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(983, 2);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 92;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(24, 77);
		class193_0.Name = Class84.smethod_0(-994278735);
		class193_0.Size = new Size(967, 505);
		class193_0.TabIndex = 93;
		linkLabel_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		linkLabel_0.AutoSize = true;
		linkLabel_0.Location = new Point(932, 592);
		linkLabel_0.Name = Class84.smethod_0(-994278181);
		linkLabel_0.Size = new Size(59, 13);
		linkLabel_0.TabIndex = 94;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class84.smethod_0(-994278198);
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		button_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button_0.Image = Class309.smethod_12();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(863, 40);
		button_0.Name = Class84.smethod_0(-994254324);
		button_0.Size = new Size(128, 31);
		button_0.TabIndex = 95;
		button_0.Text = Class84.smethod_0(-994253675);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1003, 616);
		Controls.Add(button_0);
		Controls.Add(linkLabel_0);
		Controls.Add(class193_0);
		Controls.Add(pictureBox_0);
		Controls.Add(label_0);
		Name = Class84.smethod_0(-994253553);
		Text = Class84.smethod_0(-994253543);
		Load += GForm23_Load;
		Shown += GForm23_Shown;
		((ISupportInitialize)pictureBox_0).EndInit();
		((ISupportInitialize)class193_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
