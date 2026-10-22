using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm33 : Form
{
	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private Class216 class216_0;

	private DataTable dataTable_0;

	private Class216 class216_1;

	private DataTable dataTable_1;

	private string string_0;

	private string string_1;

	private IContainer icontainer_0;

	private Panel panel_0;

	private Label label_0;

	private SplitContainer splitContainer_0;

	private Button button_0;

	private Class193 class193_0;

	private Panel panel_1;

	private Button button_1;

	private Class193 class193_1;

	private Label label_1;

	private PictureBox pictureBox_0;

	public GForm33(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gform17_1.method_0();
		method_8();
		method_0();
	}

	private void method_0()
	{
		try
		{
			class216_0 = new Class216(class193_0, bool_0: false, bool_1: false);
			class216_0.method_2(Class84.smethod_0(-994252133), 100, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994276345), 170, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994275430), 60, bool_0: true);
			class216_0.method_7(Class84.smethod_0(-994256031), 60);
			class216_0.method_7(Class84.smethod_0(-994248847), 65);
			class216_0.method_1(2, method_1);
			class216_0.method_1(3, method_6);
			class216_0.method_1(4, method_4);
			dataTable_0 = new DataTable();
			dataTable_0.Columns.Add(Class84.smethod_0(-994266832), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994277142), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994277147), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994255947), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994252139), Type.GetType(Class84.smethod_0(-994276505)));
			class216_1 = new Class216(class193_1, bool_0: false, bool_1: false);
			class216_1.method_4();
			class216_1.method_2(Class84.smethod_0(-994248847), 100, bool_0: true);
			class216_1.method_2(Class84.smethod_0(-994264227), 220, bool_0: true);
			class216_1.method_7(Class84.smethod_0(-994256010), 60);
			class216_1.method_7(Class84.smethod_0(-994256031), 60);
			class216_1.method_4();
			class216_1.method_4();
			class216_1.method_1(3, method_3);
			class216_1.method_1(4, method_2);
			dataTable_1 = new DataTable();
			dataTable_1.Columns.Add(Class84.smethod_0(-994252159), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_1.Columns.Add(Class84.smethod_0(-994252139), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_1.Columns.Add(Class84.smethod_0(-994273283), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_1.Columns.Add(Class84.smethod_0(-994255942), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_1.Columns.Add(Class84.smethod_0(-994255947), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_1.Columns.Add(Class84.smethod_0(-994252098), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_1.Columns.Add(Class84.smethod_0(-994252115), Type.GetType(Class84.smethod_0(-994276372)));
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_1(int int_0, DataGridViewRow dataGridViewRow_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			int num = (dataGridViewRow_0.Cells[2].Value.ToString().Equals(Class84.smethod_0(-994275430)) ? 1 : 0);
			if (num == 1)
			{
				if (Class355.smethod_1(Class84.smethod_0(-994252072)) == DialogResult.Cancel)
				{
					return;
				}
			}
			else if (Class355.smethod_1(Class84.smethod_0(-994252038)) == DialogResult.Cancel)
			{
				return;
			}
			mySqlConnection.Open();
			string arg = dataGridViewRow_0.Cells[0].Value.ToString();
			int num2 = ((num != 1) ? 1 : 0);
			new MySqlCommand(string.Format(Class84.smethod_0(-994252008), num2, arg), mySqlConnection).ExecuteNonQuery();
			panel_1.Visible = false;
			method_7();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_2(int int_0, DataGridViewRow dataGridViewRow_0)
	{
		if (Class355.smethod_1(Class84.smethod_0(-994251995)) == DialogResult.Cancel)
		{
			return;
		}
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			string commandText = string.Format(arg0: Convert.ToInt32(dataGridViewRow_0.Cells[0].Value), format: Class84.smethod_0(-994251963));
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			method_5();
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

	private void method_3(int int_0, DataGridViewRow dataGridViewRow_0)
	{
		try
		{
			int int_1 = Convert.ToInt32(dataGridViewRow_0.Cells[0].Value);
			string string_ = dataGridViewRow_0.Cells[5].Value.ToString();
			int int_2 = Convert.ToInt32(dataGridViewRow_0.Cells[6].Value);
			GForm27 gForm = new GForm27(this);
			gForm.method_2(string_0, int_1, int_2, string_);
			gForm.ShowDialog();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_4(int int_0, DataGridViewRow dataGridViewRow_0)
	{
		try
		{
			string_0 = dataGridViewRow_0.Cells[0].Value.ToString();
			string_1 = dataGridViewRow_0.Cells[1].Value.ToString();
			label_1.Text = string_1 + Class84.smethod_0(-994265926) + string_0 + Class84.smethod_0(-994271866);
			panel_1.Visible = true;
			method_5();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_5()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			dataTable_1.Rows.Clear();
			class216_1.method_12();
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<Tuple<int, int, string>> list = new List<Tuple<int, int, string>>();
			string format = Class84.smethod_0(-994251884);
			mySqlCommand.CommandText = string.Format(format, string_0);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list.Add(new Tuple<int, int, string>(Convert.ToInt32(mySqlDataReader[0]), Convert.ToInt32(mySqlDataReader[1]), mySqlDataReader[2].ToString()));
			}
			mySqlDataReader.Close();
			foreach (Tuple<int, int, string> item4 in list)
			{
				int item = item4.Item1;
				int item2 = item4.Item2;
				string item3 = item4.Item3;
				string text = item3.Replace(Class84.smethod_0(-994267367), string.Empty);
				text = text.Replace(Class84.smethod_0(-994267375), string.Empty);
				string value = string.Empty;
				format = Class84.smethod_0(-994251768) + text + Class84.smethod_0(-994271866);
				mySqlCommand.CommandText = format;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					value = mySqlDataReader[0].ToString();
				}
				mySqlDataReader.Close();
				DataRow dataRow = dataTable_1.NewRow();
				dataRow[Class84.smethod_0(-994252159)] = item.ToString();
				dataRow[Class84.smethod_0(-994252139)] = Class127.smethod_0((Enum3)item2);
				dataRow[Class84.smethod_0(-994273283)] = value;
				dataRow[Class84.smethod_0(-994255942)] = Class84.smethod_0(-994255942);
				dataRow[Class84.smethod_0(-994255947)] = Class84.smethod_0(-994255947);
				dataRow[Class84.smethod_0(-994252098)] = item3;
				dataRow[Class84.smethod_0(-994252115)] = item2;
				dataTable_1.Rows.Add(dataRow);
			}
			class216_1.method_9(dataTable_1);
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

	private void method_6(int int_0, DataGridViewRow dataGridViewRow_0)
	{
		if (Class355.smethod_1(Class84.smethod_0(-994251592)) == DialogResult.Cancel)
		{
			return;
		}
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			string commandText = string.Concat(str1: dataGridViewRow_0.Cells[0].Value.ToString(), str0: Class84.smethod_0(-994251614), str2: Class84.smethod_0(-994271698));
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			method_7();
			panel_1.Visible = false;
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

	private void GForm33_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void GForm33_Activated(object sender, EventArgs e)
	{
		panel_1.Visible = false;
		method_7();
	}

	public void method_7()
	{
		dataTable_0.Rows.Clear();
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = Class84.smethod_0(-994251536)
			}.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994277147)]);
				DataRow dataRow = dataTable_0.NewRow();
				dataRow[Class84.smethod_0(-994266832)] = mySqlDataReader[Class84.smethod_0(-994266832)];
				dataRow[Class84.smethod_0(-994277142)] = mySqlDataReader[Class84.smethod_0(-994277142)];
				dataRow[Class84.smethod_0(-994277147)] = ((num == 1) ? Class84.smethod_0(-994275430) : Class84.smethod_0(-994266147));
				dataRow[Class84.smethod_0(-994255947)] = Class84.smethod_0(-994255947);
				dataRow[Class84.smethod_0(-994252139)] = Class84.smethod_0(-994251378);
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
			new GForm0(this, Class84.smethod_0(-994251325)).ShowDialog();
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		GForm27 gForm = new GForm27(this);
		gForm.method_1(string_0);
		gForm.ShowDialog();
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

	private void method_8()
	{
		panel_0 = new Panel();
		pictureBox_0 = new PictureBox();
		label_0 = new Label();
		splitContainer_0 = new SplitContainer();
		button_0 = new Button();
		class193_0 = new Class193();
		panel_1 = new Panel();
		button_1 = new Button();
		class193_1 = new Class193();
		label_1 = new Label();
		panel_0.SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)splitContainer_0).BeginInit();
		splitContainer_0.Panel1.SuspendLayout();
		splitContainer_0.Panel2.SuspendLayout();
		splitContainer_0.SuspendLayout();
		((ISupportInitialize)class193_0).BeginInit();
		panel_1.SuspendLayout();
		((ISupportInitialize)class193_1).BeginInit();
		SuspendLayout();
		panel_0.Controls.Add(pictureBox_0);
		panel_0.Controls.Add(label_0);
		panel_0.Dock = DockStyle.Top;
		panel_0.Location = new Point(0, 0);
		panel_0.Name = Class84.smethod_0(-994256784);
		panel_0.Size = new Size(1132, 48);
		panel_0.TabIndex = 1;
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(1112, 3);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 95;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994278767);
		label_0.Size = new Size(126, 17);
		label_0.TabIndex = 94;
		label_0.Text = Class84.smethod_0(-994251296);
		splitContainer_0.BackColor = Color.Gainsboro;
		splitContainer_0.Dock = DockStyle.Fill;
		splitContainer_0.Location = new Point(0, 48);
		splitContainer_0.Name = Class84.smethod_0(-994256742);
		splitContainer_0.Panel1.BackColor = SystemColors.Control;
		splitContainer_0.Panel1.Controls.Add(button_0);
		splitContainer_0.Panel1.Controls.Add(class193_0);
		splitContainer_0.Panel2.BackColor = SystemColors.Control;
		splitContainer_0.Panel2.Controls.Add(panel_1);
		splitContainer_0.Size = new Size(1132, 657);
		splitContainer_0.SplitterDistance = 538;
		splitContainer_0.TabIndex = 2;
		button_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button_0.Image = Class309.smethod_12();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(404, 9);
		button_0.Name = Class84.smethod_0(-994251242);
		button_0.Size = new Size(119, 33);
		button_0.TabIndex = 96;
		button_0.Text = Class84.smethod_0(-994251259);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(12, 48);
		class193_0.Name = Class84.smethod_0(-994278735);
		class193_0.Size = new Size(511, 577);
		class193_0.TabIndex = 94;
		panel_1.Controls.Add(button_1);
		panel_1.Controls.Add(class193_1);
		panel_1.Controls.Add(label_1);
		panel_1.Dock = DockStyle.Fill;
		panel_1.Location = new Point(0, 0);
		panel_1.Name = Class84.smethod_0(-994251221);
		panel_1.Size = new Size(590, 657);
		panel_1.TabIndex = 0;
		panel_1.Visible = false;
		button_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button_1.Image = Class309.smethod_12();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(464, 6);
		button_1.Name = Class84.smethod_0(-994251172);
		button_1.Size = new Size(114, 33);
		button_1.TabIndex = 98;
		button_1.Text = Class84.smethod_0(-994251188);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		class193_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_1.BackgroundColor = Color.White;
		class193_1.BorderStyle = BorderStyle.None;
		class193_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_1.Location = new Point(15, 48);
		class193_1.Name = Class84.smethod_0(-994251137);
		class193_1.Size = new Size(563, 577);
		class193_1.TabIndex = 97;
		label_1.AutoSize = true;
		label_1.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_1.ForeColor = Color.Blue;
		label_1.Location = new Point(12, 17);
		label_1.Name = Class84.smethod_0(-994251155);
		label_1.Size = new Size(70, 17);
		label_1.TabIndex = 96;
		label_1.Text = Class84.smethod_0(-994251108);
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1132, 705);
		Controls.Add(splitContainer_0);
		Controls.Add(panel_0);
		Name = Class84.smethod_0(-994251126);
		Text = Class84.smethod_0(-994251296);
		Activated += GForm33_Activated;
		Load += GForm33_Load;
		panel_0.ResumeLayout(performLayout: false);
		panel_0.PerformLayout();
		((ISupportInitialize)pictureBox_0).EndInit();
		splitContainer_0.Panel1.ResumeLayout(performLayout: false);
		splitContainer_0.Panel2.ResumeLayout(performLayout: false);
		((ISupportInitialize)splitContainer_0).EndInit();
		splitContainer_0.ResumeLayout(performLayout: false);
		((ISupportInitialize)class193_0).EndInit();
		panel_1.ResumeLayout(performLayout: false);
		panel_1.PerformLayout();
		((ISupportInitialize)class193_1).EndInit();
		ResumeLayout(performLayout: false);
	}
}
