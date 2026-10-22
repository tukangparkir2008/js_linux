using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm14 : Form
{
	private readonly GForm17 gform17_0;

	private Class216 class216_0;

	private Class216 class216_1;

	private DataTable dataTable_0;

	private int int_0;

	private string string_0;

	private bool bool_0;

	private IContainer icontainer_0;

	private Panel panel_0;

	private Label label_0;

	private SplitContainer splitContainer_0;

	private LinkLabel linkLabel_0;

	private Button button_0;

	private ComboBox comboBox_0;

	private Label label_1;

	private Class193 class193_0;

	private Panel panel_1;

	private GroupBox groupBox_0;

	private TextBox textBox_0;

	private ComboBox comboBox_1;

	private ComboBox comboBox_2;

	private Label label_2;

	private LinkLabel linkLabel_1;

	private Class193 class193_1;

	private Label label_3;

	private PictureBox pictureBox_0;

	private Button button_1;

	private Button button_2;

	public GForm14(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
		method_14();
		method_0();
		method_1();
	}

	private void method_0()
	{
		bool_0 = true;
		comboBox_0.Items.Add(Class84.smethod_0(-994275430));
		comboBox_0.Items.Add(Class84.smethod_0(-994266147));
		comboBox_0.Items.Add(Class84.smethod_0(-994258418));
		comboBox_0.SelectedIndex = 0;
		ComboBox comboBox = comboBox_2;
		comboBox_1.SelectedIndex = 0;
		comboBox.SelectedIndex = 0;
		bool_0 = false;
	}

	private void method_1()
	{
		class216_0 = new Class216(class193_0, bool_0: false, bool_1: false);
		class216_0.method_4();
		class216_0.method_2(Class84.smethod_0(-994276345), 180, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994264227), 90, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994258372), 100, bool_0: true);
		class216_0.method_5(Class84.smethod_0(-994275430), 40, bool_0: false);
		class216_0.method_7(Class84.smethod_0(-994258388), 50);
		class216_0.method_7(Class84.smethod_0(-994258388), 50);
		class216_0.method_7(Class84.smethod_0(-994258388), 60);
		class216_0.method_1(4, method_2);
		class216_0.method_1(5, method_3);
		class216_0.method_1(6, method_4);
		class216_0.method_1(7, method_5);
		class216_1 = new Class216(class193_1, bool_0: false, bool_1: false);
		class216_1.method_4();
		class216_1.method_2(Class84.smethod_0(-994265459), 100, bool_0: true);
		class216_1.method_2(Class84.smethod_0(-994276345), 150, bool_0: true);
		class216_1.method_2(Class84.smethod_0(-994268178), 100, bool_0: true);
		class216_1.method_5(Class84.smethod_0(-994275430), 40, bool_0: false);
		class216_1.method_7(Class84.smethod_0(-994258388), 50);
		class216_1.method_1(4, method_7);
		class216_1.method_1(5, method_6);
		dataTable_0 = new DataTable();
		dataTable_0.Columns.Add(Class84.smethod_0(-994264162), Type.GetType(Class84.smethod_0(-994276372)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994276436), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994277142), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994276368), Type.GetType(Class84.smethod_0(-994276505)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994277147), Type.GetType(Class84.smethod_0(-994276372)));
		dataTable_0.Columns.Add(Class84.smethod_0(-994255947), Type.GetType(Class84.smethod_0(-994276505)));
	}

	private void method_2(int int_1, DataGridViewRow dataGridViewRow_0)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
			return;
		}
		int_0 = Convert.ToInt32(dataGridViewRow_0.Cells[0].Value);
		string_0 = Convert.ToString(dataGridViewRow_0.Cells[1].Value);
		panel_1.Visible = true;
		method_8();
		bool flag;
		if (Class355.smethod_1((flag = !Convert.ToBoolean((dataGridViewRow_0.Cells[4] as DataGridViewCheckBoxCell).EditedFormattedValue)) ? Class84.smethod_0(-994258362) : Class84.smethod_0(-994258395)) == DialogResult.Cancel)
		{
			return;
		}
		MySqlConnection mySqlConnection = null;
		try
		{
			mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
			mySqlConnection.Open();
			string format = Class84.smethod_0(-994258333);
			int num = (flag ? 1 : 0);
			format = string.Format(format, num, int_0);
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = format;
			mySqlCommand.ExecuteNonQuery();
			if (comboBox_0.SelectedIndex != 2)
			{
				class193_0.Rows.RemoveAt(int_1);
			}
			panel_1.Visible = false;
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

	private void method_3(int int_1, DataGridViewRow dataGridViewRow_0)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
			return;
		}
		int_0 = Convert.ToInt32(dataGridViewRow_0.Cells[0].Value);
		string_0 = Convert.ToString(dataGridViewRow_0.Cells[1].Value);
		panel_1.Visible = true;
		method_8();
		new GForm30(int_0, this, gform17_0).ShowDialog();
	}

	private void method_4(int int_1, DataGridViewRow dataGridViewRow_0)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
			return;
		}
		int_0 = Convert.ToInt32(dataGridViewRow_0.Cells[0].Value);
		string_0 = Convert.ToString(dataGridViewRow_0.Cells[1].Value);
		panel_1.Visible = true;
		method_8();
		MySqlConnection mySqlConnection = null;
		try
		{
			mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string format = Class84.smethod_0(-994258202);
			mySqlCommand.CommandText = string.Format(format, int_0);
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) != 0)
			{
				Class355.smethod_4(Class84.smethod_0(-994258082));
			}
			else if (Class355.smethod_1(Class84.smethod_0(-994258018)) != DialogResult.Cancel)
			{
				format = Class84.smethod_0(-994257992);
				mySqlCommand.CommandText = string.Format(format, int_0);
				mySqlCommand.ExecuteNonQuery();
				class193_0.Rows.RemoveAt(int_1);
				panel_1.Visible = false;
			}
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

	private void method_5(int int_1, DataGridViewRow dataGridViewRow_0)
	{
		int_0 = Convert.ToInt32(dataGridViewRow_0.Cells[0].Value);
		string_0 = Convert.ToString(dataGridViewRow_0.Cells[1].Value);
		panel_1.Visible = true;
		method_8();
	}

	private void method_6(int int_1, DataGridViewRow dataGridViewRow_0)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
		}
		else
		{
			if (Class355.smethod_1(Class84.smethod_0(-994257940)) == DialogResult.Cancel)
			{
				return;
			}
			string arg = Convert.ToString(dataGridViewRow_0.Cells[1].Value);
			string text = Convert.ToString(dataGridViewRow_0.Cells[3].Value).ToLower();
			MySqlConnection mySqlConnection = null;
			try
			{
				mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
				mySqlConnection.Open();
				string format = Class84.smethod_0(-994257860);
				if (text == Class84.smethod_0(-994257743))
				{
					format = string.Format(format, int_0, Class84.smethod_0(-994277136), arg);
				}
				else
				{
					format = ((!(text == Class84.smethod_0(-994257747))) ? string.Format(format, int_0, Class84.smethod_0(-994257701), arg) : string.Format(format, int_0, Class84.smethod_0(-994266832), arg));
				}
				MySqlCommand mySqlCommand = new MySqlCommand();
				mySqlCommand.Connection = mySqlConnection;
				mySqlCommand.CommandText = format;
				mySqlCommand.ExecuteNonQuery();
				class193_1.Rows.RemoveAt(int_1);
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
	}

	private void method_7(int int_1, DataGridViewRow dataGridViewRow_0)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
		}
		else
		{
			bool flag;
			if (Class355.smethod_1((flag = !Convert.ToBoolean((dataGridViewRow_0.Cells[4] as DataGridViewCheckBoxCell).EditedFormattedValue)) ? Class84.smethod_0(-994257688) : Class84.smethod_0(-994257720)) == DialogResult.Cancel)
			{
				return;
			}
			string text = Convert.ToString(dataGridViewRow_0.Cells[1].Value);
			string text2 = Convert.ToString(dataGridViewRow_0.Cells[3].Value).ToLower();
			MySqlConnection mySqlConnection = null;
			try
			{
				mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
				mySqlConnection.Open();
				string format = Class84.smethod_0(-994257644);
				int num = (flag ? 1 : 0);
				if (text2 == Class84.smethod_0(-994257743))
				{
					format = string.Format(format, num, int_0, Class84.smethod_0(-994277136), text);
				}
				else
				{
					format = ((!(text2 == Class84.smethod_0(-994257747))) ? string.Format(format, num, int_0, Class84.smethod_0(-994257701), text) : string.Format(format, num, int_0, Class84.smethod_0(-994266832), text));
				}
				MySqlCommand mySqlCommand = new MySqlCommand();
				mySqlCommand.Connection = mySqlConnection;
				mySqlCommand.CommandText = format;
				mySqlCommand.ExecuteNonQuery();
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
	}

	private void GForm14_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void method_8()
	{
		label_3.Text = string_0;
		MySqlConnection mySqlConnection = null;
		try
		{
			Cursor = Cursors.WaitCursor;
			mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
			mySqlConnection.Open();
			string format = Class84.smethod_0(-994257522);
			format = string.Format(format, int_0);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = format
			};
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			dataTable_0.Rows.Clear();
			foreach (DataRow row in dataTable.Rows)
			{
				int num = Convert.ToInt32(row[0]);
				int num2 = Convert.ToInt32(row[1]);
				string text = num2 switch
				{
					1 => Convert.ToString(row[3]), 
					0 => Convert.ToString(row[2]), 
					_ => Convert.ToString(row[4]), 
				};
				int num3 = Convert.ToInt32(row[5]);
				format = Class84.smethod_0(-994257366);
				mySqlCommand.CommandText = num2 switch
				{
					0 => string.Format(format, Class84.smethod_0(-994257337), Class84.smethod_0(-994277136), text), 
					1 => string.Format(format, Class84.smethod_0(-994257301), Class84.smethod_0(-994266832), text), 
					_ => string.Format(format, Class84.smethod_0(-994257264), Class84.smethod_0(-994257701), text), 
				};
				string value = string.Empty;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					value = Convert.ToString(mySqlDataReader[0]);
				}
				mySqlDataReader.Close();
				DataRow dataRow2 = dataTable_0.NewRow();
				dataRow2[Class84.smethod_0(-994264162)] = num;
				dataRow2[Class84.smethod_0(-994276436)] = text;
				dataRow2[Class84.smethod_0(-994277142)] = value;
				dataRow2[Class84.smethod_0(-994276368)] = num2 switch
				{
					1 => (object)Class84.smethod_0(-994278858), 
					0 => Class84.smethod_0(-994278876), 
					_ => Class84.smethod_0(-994257277), 
				};
				dataRow2[Class84.smethod_0(-994277147)] = num3;
				dataRow2[Class84.smethod_0(-994255947)] = Class84.smethod_0(-994255947);
				dataTable_0.Rows.Add(dataRow2);
			}
			class216_1.method_9(dataTable_0);
		}
		catch (Exception ex)
		{
			Cursor = Cursors.Default;
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			Cursor = Cursors.Default;
			mySqlConnection?.Close();
		}
	}

	public void method_9()
	{
		method_11();
	}

	public void method_10()
	{
		panel_1.Visible = false;
		method_11();
	}

	private void method_11()
	{
		MySqlConnection mySqlConnection = null;
		try
		{
			Cursor = Cursors.WaitCursor;
			mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter
			{
				SelectCommand = mySqlCommand
			};
			DataTable dataTable = new DataTable();
			string text;
			if (gform17_0.method_0().gclass6_0.method_6() == 0)
			{
				text = Class84.smethod_0(-994257231);
			}
			else
			{
				text = Class84.smethod_0(-994257047);
				text = string.Format(text, gform17_0.method_0().gclass6_0.method_2());
			}
			if (comboBox_0.SelectedIndex == 0)
			{
				text += Class84.smethod_0(-994260959);
			}
			else if (comboBox_0.SelectedIndex == 1)
			{
				text += Class84.smethod_0(-994260906);
			}
			text += Class84.smethod_0(-994260869);
			mySqlCommand.CommandText = text;
			mySqlDataAdapter.Fill(dataTable);
			class216_0.method_9(dataTable);
		}
		catch (Exception ex)
		{
			Cursor = Cursors.Default;
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			Cursor = Cursors.Default;
			mySqlConnection?.Close();
		}
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			method_11();
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
		}
		else
		{
			new GForm30(0, this, gform17_0).ShowDialog();
		}
	}

	private void textBox_0_KeyUp(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return && textBox_0.Text.Trim().Length >= 3)
		{
			GClass70 gClass = Class316.smethod_12();
			if (gClass.Value != 1)
			{
				Class355.smethod_0(gClass.Text);
				return;
			}
			GForm21 gForm = new GForm21(method_12, gform17_0.method_0().gclass6_0.method_12(), bool_2: false);
			gForm.method_7(comboBox_2.SelectedIndex, comboBox_1.SelectedIndex, textBox_0.Text);
			gForm.method_10();
			gForm.ShowDialog();
		}
	}

	private void method_12(int int_1, int int_2, string string_1, string string_2, string string_3, string string_4, Image image_0, string string_5)
	{
		comboBox_2.SelectedIndex = int_1;
		comboBox_1.SelectedIndex = int_2;
		textBox_0.Text = string_1;
		method_13(int_2, string_2, string_3);
	}

	private void method_13(int int_1, string string_1, string string_2)
	{
		MySqlConnection mySqlConnection = null;
		try
		{
			mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
			mySqlConnection.Open();
			string format = Class84.smethod_0(-994260892);
			format = int_1 switch
			{
				0 => string.Format(format, int_0, int_1, Class84.smethod_0(-994277136), string_1), 
				1 => string.Format(format, int_0, int_1, Class84.smethod_0(-994266832), string_1), 
				_ => string.Format(format, int_0, int_1, Class84.smethod_0(-994257701), string_1), 
			};
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = format
			};
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) <= 0)
			{
				format = Class84.smethod_0(-994260730);
				mySqlCommand.CommandText = int_1 switch
				{
					0 => string.Format(format, int_0, int_1, Class84.smethod_0(-994277136), string_1), 
					1 => string.Format(format, int_0, int_1, Class84.smethod_0(-994266832), string_1), 
					_ => string.Format(format, int_0, int_1, Class84.smethod_0(-994257701), string_1), 
				};
				mySqlCommand.ExecuteNonQuery();
				format = Class84.smethod_0(-994260596);
				mySqlCommand.CommandText = format;
				int num = Convert.ToInt32(mySqlCommand.ExecuteScalar());
				class193_1.Rows.Add(num, string_1, string_2, int_1 switch
				{
					1 => (object)Class84.smethod_0(-994278858), 
					0 => Class84.smethod_0(-994278876), 
					_ => Class84.smethod_0(-994257277), 
				}, 1, Class84.smethod_0(-994255947));
			}
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

	private void GForm14_Shown(object sender, EventArgs e)
	{
		method_11();
	}

	private void linkLabel_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel_1.Enabled = false;
		try
		{
			method_8();
		}
		finally
		{
			linkLabel_1.Enabled = true;
		}
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel_0.Enabled = false;
		try
		{
			method_11();
		}
		finally
		{
			linkLabel_0.Enabled = true;
		}
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		if (textBox_0.Text.Trim().Length >= 3)
		{
			GClass70 gClass = Class316.smethod_12();
			if (gClass.Value != 1)
			{
				Class355.smethod_0(gClass.Text);
				return;
			}
			GForm21 gForm = new GForm21(method_12, gform17_0.method_0().gclass6_0.method_12(), bool_2: false);
			gForm.method_7(comboBox_2.SelectedIndex, comboBox_1.SelectedIndex, textBox_0.Text);
			gForm.method_10();
			gForm.ShowDialog();
		}
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
			return;
		}
		GForm21 gForm = new GForm21(method_12, gform17_0.method_0().gclass6_0.method_12(), bool_2: false);
		gForm.method_7(comboBox_2.SelectedIndex, comboBox_1.SelectedIndex, string.Empty);
		gForm.method_10();
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

	private void method_14()
	{
		panel_0 = new Panel();
		pictureBox_0 = new PictureBox();
		label_0 = new Label();
		splitContainer_0 = new SplitContainer();
		class193_0 = new Class193();
		linkLabel_0 = new LinkLabel();
		button_0 = new Button();
		comboBox_0 = new ComboBox();
		label_1 = new Label();
		panel_1 = new Panel();
		label_3 = new Label();
		groupBox_0 = new GroupBox();
		button_2 = new Button();
		button_1 = new Button();
		textBox_0 = new TextBox();
		comboBox_1 = new ComboBox();
		comboBox_2 = new ComboBox();
		label_2 = new Label();
		linkLabel_1 = new LinkLabel();
		class193_1 = new Class193();
		panel_0.SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)splitContainer_0).BeginInit();
		splitContainer_0.Panel1.SuspendLayout();
		splitContainer_0.Panel2.SuspendLayout();
		splitContainer_0.SuspendLayout();
		((ISupportInitialize)class193_0).BeginInit();
		panel_1.SuspendLayout();
		groupBox_0.SuspendLayout();
		((ISupportInitialize)class193_1).BeginInit();
		SuspendLayout();
		panel_0.Controls.Add(pictureBox_0);
		panel_0.Controls.Add(label_0);
		panel_0.Dock = DockStyle.Top;
		panel_0.Location = new Point(0, 0);
		panel_0.Name = Class84.smethod_0(-994256784);
		panel_0.Size = new Size(1166, 46);
		panel_0.TabIndex = 0;
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(1146, 5);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 90;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994256787), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994266659);
		label_0.Size = new Size(275, 17);
		label_0.TabIndex = 69;
		label_0.Text = Class84.smethod_0(-994260566);
		splitContainer_0.BackColor = Color.Gainsboro;
		splitContainer_0.Dock = DockStyle.Fill;
		splitContainer_0.Location = new Point(0, 46);
		splitContainer_0.Name = Class84.smethod_0(-994256742);
		splitContainer_0.Panel1.BackColor = SystemColors.Control;
		splitContainer_0.Panel1.Controls.Add(class193_0);
		splitContainer_0.Panel1.Controls.Add(linkLabel_0);
		splitContainer_0.Panel1.Controls.Add(button_0);
		splitContainer_0.Panel1.Controls.Add(comboBox_0);
		splitContainer_0.Panel1.Controls.Add(label_1);
		splitContainer_0.Panel2.Controls.Add(panel_1);
		splitContainer_0.Size = new Size(1166, 576);
		splitContainer_0.SplitterDistance = 625;
		splitContainer_0.TabIndex = 1;
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(17, 48);
		class193_0.Name = Class84.smethod_0(-994256731);
		class193_0.Size = new Size(594, 516);
		class193_0.TabIndex = 82;
		linkLabel_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		linkLabel_0.AutoSize = true;
		linkLabel_0.Location = new Point(552, 28);
		linkLabel_0.Name = Class84.smethod_0(-994260486);
		linkLabel_0.Size = new Size(59, 13);
		linkLabel_0.TabIndex = 81;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class84.smethod_0(-994278198);
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		button_0.Image = Class309.smethod_12();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(135, 19);
		button_0.Name = Class84.smethod_0(-994260511);
		button_0.Size = new Size(106, 23);
		button_0.TabIndex = 80;
		button_0.Text = Class84.smethod_0(-994260458);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Location = new Point(57, 20);
		comboBox_0.Name = Class84.smethod_0(-994260422);
		comboBox_0.Size = new Size(76, 21);
		comboBox_0.TabIndex = 79;
		comboBox_0.SelectedIndexChanged += comboBox_0_SelectedIndexChanged;
		label_1.AutoSize = true;
		label_1.Location = new Point(14, 23);
		label_1.Name = Class84.smethod_0(-994278834);
		label_1.Size = new Size(37, 13);
		label_1.TabIndex = 78;
		label_1.Text = Class84.smethod_0(-994276302);
		panel_1.BackColor = SystemColors.Control;
		panel_1.Controls.Add(label_3);
		panel_1.Controls.Add(groupBox_0);
		panel_1.Controls.Add(linkLabel_1);
		panel_1.Controls.Add(class193_1);
		panel_1.Dock = DockStyle.Fill;
		panel_1.Location = new Point(0, 0);
		panel_1.Name = Class84.smethod_0(-994260439);
		panel_1.Size = new Size(537, 576);
		panel_1.TabIndex = 0;
		panel_1.Visible = false;
		label_3.AutoSize = true;
		label_3.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_3.Location = new Point(10, 29);
		label_3.Name = Class84.smethod_0(-994260387);
		label_3.Size = new Size(11, 13);
		label_3.TabIndex = 93;
		label_3.Text = Class84.smethod_0(-994278690);
		groupBox_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		groupBox_0.Controls.Add(button_2);
		groupBox_0.Controls.Add(button_1);
		groupBox_0.Controls.Add(textBox_0);
		groupBox_0.Controls.Add(comboBox_1);
		groupBox_0.Controls.Add(comboBox_2);
		groupBox_0.Controls.Add(label_2);
		groupBox_0.Location = new Point(13, 481);
		groupBox_0.Name = Class84.smethod_0(-994278480);
		groupBox_0.Size = new Size(509, 71);
		groupBox_0.TabIndex = 92;
		groupBox_0.TabStop = false;
		groupBox_0.Text = Class84.smethod_0(-994260414);
		button_2.Location = new Point(438, 26);
		button_2.Name = Class84.smethod_0(-994265524);
		button_2.Size = new Size(51, 23);
		button_2.TabIndex = 11;
		button_2.Text = Class84.smethod_0(-994265477);
		button_2.UseVisualStyleBackColor = true;
		button_2.Click += button_2_Click;
		button_1.Location = new Point(392, 26);
		button_1.Name = Class84.smethod_0(-994278923);
		button_1.Size = new Size(40, 23);
		button_1.TabIndex = 10;
		button_1.Text = Class84.smethod_0(-994278942);
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		textBox_0.Location = new Point(260, 28);
		textBox_0.Name = Class84.smethod_0(-994265496);
		textBox_0.Size = new Size(126, 20);
		textBox_0.TabIndex = 9;
		textBox_0.KeyUp += textBox_0_KeyUp;
		comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_1.FormattingEnabled = true;
		comboBox_1.Items.AddRange(new object[2]
		{
			Class84.smethod_0(-994278876),
			Class84.smethod_0(-994278858)
		});
		comboBox_1.Location = new Point(150, 28);
		comboBox_1.Name = Class84.smethod_0(-994265446);
		comboBox_1.Size = new Size(104, 21);
		comboBox_1.TabIndex = 8;
		comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_2.FormattingEnabled = true;
		comboBox_2.Items.AddRange(new object[2]
		{
			Class84.smethod_0(-994276345),
			Class84.smethod_0(-994265459)
		});
		comboBox_2.Location = new Point(40, 28);
		comboBox_2.Name = Class84.smethod_0(-994265409);
		comboBox_2.Size = new Size(104, 21);
		comboBox_2.TabIndex = 7;
		label_2.AutoSize = true;
		label_2.Location = new Point(9, 31);
		label_2.Name = Class84.smethod_0(-994266638);
		label_2.Size = new Size(25, 13);
		label_2.TabIndex = 6;
		label_2.Text = Class84.smethod_0(-994278789);
		linkLabel_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		linkLabel_1.AutoSize = true;
		linkLabel_1.Location = new Point(463, 25);
		linkLabel_1.Name = Class84.smethod_0(-994260361);
		linkLabel_1.Size = new Size(59, 13);
		linkLabel_1.TabIndex = 91;
		linkLabel_1.TabStop = true;
		linkLabel_1.Text = Class84.smethod_0(-994278198);
		linkLabel_1.LinkClicked += linkLabel_1_LinkClicked;
		class193_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_1.BackgroundColor = Color.White;
		class193_1.BorderStyle = BorderStyle.None;
		class193_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_1.Location = new Point(13, 45);
		class193_1.Name = Class84.smethod_0(-994260328);
		class193_1.Size = new Size(509, 420);
		class193_1.TabIndex = 90;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1166, 622);
		Controls.Add(splitContainer_0);
		Controls.Add(panel_0);
		Name = Class84.smethod_0(-994260343);
		Text = Class84.smethod_0(-994260566);
		Load += GForm14_Load;
		Shown += GForm14_Shown;
		panel_0.ResumeLayout(performLayout: false);
		panel_0.PerformLayout();
		((ISupportInitialize)pictureBox_0).EndInit();
		splitContainer_0.Panel1.ResumeLayout(performLayout: false);
		splitContainer_0.Panel1.PerformLayout();
		splitContainer_0.Panel2.ResumeLayout(performLayout: false);
		((ISupportInitialize)splitContainer_0).EndInit();
		splitContainer_0.ResumeLayout(performLayout: false);
		((ISupportInitialize)class193_0).EndInit();
		panel_1.ResumeLayout(performLayout: false);
		panel_1.PerformLayout();
		groupBox_0.ResumeLayout(performLayout: false);
		groupBox_0.PerformLayout();
		((ISupportInitialize)class193_1).EndInit();
		ResumeLayout(performLayout: false);
	}
}
