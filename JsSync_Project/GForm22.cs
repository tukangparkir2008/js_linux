using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm22 : Form
{
	private readonly GForm17 gform17_0;

	private IContainer icontainer_0;

	private PictureBox pictureBox_0;

	private Label label_0;

	private GroupBox groupBox_0;

	private LinkLabel linkLabel_0;

	private LinkLabel linkLabel_1;

	internal TextBox textBox_0;

	private Button button_0;

	internal Label label_1;

	internal Label label_2;

	internal TextBox textBox_1;

	internal TextBox textBox_2;

	internal Label label_3;

	internal TextBox textBox_3;

	private SaveFileDialog saveFileDialog_0;

	private OpenFileDialog openFileDialog_0;

	private GroupBox groupBox_1;

	private LinkLabel linkLabel_2;

	private Button button_1;

	internal Label label_4;

	internal TextBox textBox_4;

	internal Label label_5;

	private GroupBox groupBox_2;

	private LinkLabel linkLabel_3;

	private Button button_2;

	internal Label label_6;

	internal TextBox textBox_5;

	internal Label label_7;

	private GroupBox groupBox_3;

	private Panel panel_0;

	private Label label_8;

	private Label label_9;

	private Label label_10;

	private ComboBox comboBox_0;

	private Label label_11;

	internal TextBox textBox_6;

	private Button button_3;

	internal Label label_12;

	private Label label_13;

	public GForm22(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
		method_8();
	}

	private void GForm22_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
		method_0();
	}

	private void method_0()
	{
		try
		{
			comboBox_0.Items.Clear();
			int num = -1;
			int selectedIndex = 0;
			IPAddress[] hostAddresses = Dns.GetHostAddresses(Dns.GetHostName());
			foreach (IPAddress iPAddress in hostAddresses)
			{
				if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
				{
					num++;
					comboBox_0.Items.Add(iPAddress.ToString());
					if (iPAddress.ToString().Equals(Class224.Class229.string_0))
					{
						selectedIndex = num;
					}
				}
			}
			comboBox_0.Items.Add(Class84.smethod_0(-994247974));
			comboBox_0.SelectedIndex = selectedIndex;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(string.Format(Class84.smethod_0(-994247990), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name), ex.Message, ex);
		}
	}

	public void method_1()
	{
		textBox_3.Text = Class224.Class228.string_0;
		textBox_0.Text = Class224.Class228.string_1;
		textBox_2.Text = Class224.Class228.string_2;
		textBox_1.Text = Class224.Class228.string_3;
		textBox_4.Text = Class348.Class350.string_0;
		method_2();
	}

	private void method_2()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			textBox_5.Text = Class190.smethod_8(mySqlConnection);
		}
		catch (Exception)
		{
			textBox_5.Text = string.Empty;
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		if (Class348.Class349.bool_0)
		{
			Class355.smethod_3(Class84.smethod_0(-994247944));
			return;
		}
		if (Class348.Class351.bool_0)
		{
			Class355.smethod_3(Class84.smethod_0(-994247886));
			return;
		}
		try
		{
			if (method_3())
			{
				Cursor = Cursors.WaitCursor;
				GClass70 gClass = method_5();
				if (gClass.Value == 0)
				{
					Cursor = Cursors.Default;
					return;
				}
				if (gClass.Value == -1)
				{
					Cursor = Cursors.Default;
					Class355.smethod_0(Class84.smethod_0(-994247811) + gClass.Text);
					return;
				}
				Class224.Class228.string_0 = textBox_3.Text;
				Class224.Class228.string_1 = textBox_0.Text;
				Class224.Class228.string_2 = textBox_2.Text;
				Class224.Class228.string_3 = textBox_1.Text;
				Class205.smethod_1();
				gform17_0.method_22();
				gform17_0.method_17();
				MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
				mySqlConnection.Open();
				Class348.Class350.string_0 = Class190.smethod_9(mySqlConnection);
				Class348.Class350.dateTime_0 = Class190.smethod_11(mySqlConnection);
				textBox_4.Text = Class348.Class350.string_0;
				textBox_5.Text = Class190.smethod_8(mySqlConnection);
				gform17_0.method_25();
				Cursor = Cursors.Default;
				Class224.Class225.smethod_1();
				Class224.Class225.smethod_3();
				gform17_0.method_22();
				Class355.smethod_3(Class84.smethod_0(-994247793));
			}
		}
		catch (Exception ex)
		{
			Cursor = Cursors.Default;
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private bool method_3()
	{
		if (textBox_3.Text.Trim().Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994247728));
			textBox_3.Focus();
			return false;
		}
		if (textBox_0.Text.Trim().Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994247692));
			textBox_0.Focus();
			return false;
		}
		if (textBox_2.Text.Trim().Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994247661));
			textBox_2.Focus();
			return false;
		}
		if (textBox_1.Text.Trim().Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994247630));
			textBox_1.Focus();
			return false;
		}
		string text = textBox_3.Text.Trim();
		text = (text.ToLower().Equals(Class84.smethod_0(-994247974)) ? Class84.smethod_0(-994247595) : text);
		if (!IPAddress.TryParse(text, out var _))
		{
			Class355.smethod_0(Class84.smethod_0(-994247611));
			textBox_3.Focus();
			return false;
		}
		if (!int.TryParse(textBox_0.Text.Trim(), out var _))
		{
			Class355.smethod_0(Class84.smethod_0(-994247527));
			textBox_0.Focus();
			return false;
		}
		return true;
	}

	private GClass70 method_4(string string_0, string string_1, string string_2, string string_3)
	{
		if (string_0.Length != 0 && string_1.Length != 0 && string_2.Length != 0)
		{
			MySqlConnection mySqlConnection = null;
			try
			{
				mySqlConnection = new MySqlConnection(string.Format(Class84.smethod_0(-994247548), string_0, string_1, string_2, string_3));
				mySqlConnection.Open();
				MySqlCommand mySqlCommand = new MySqlCommand();
				mySqlCommand.Connection = mySqlConnection;
				mySqlCommand.CommandText = Class84.smethod_0(-994247438);
				mySqlCommand.ExecuteNonQuery();
				mySqlCommand.CommandText = Class84.smethod_0(-994247451);
				if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
				{
					throw new Exception(Class84.smethod_0(-994247276) + string_0 + Class84.smethod_0(-994263069) + string_1);
				}
				Class160.smethod_2(mySqlCommand);
				Class206.smethod_0();
				return new GClass70(1, Class84.smethod_0(-994247224));
			}
			catch (Exception ex)
			{
				Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
				return new GClass70(-1, ex.Message);
			}
			finally
			{
				if (mySqlConnection != null)
				{
					mySqlConnection.Close();
					mySqlConnection.Dispose();
				}
			}
		}
		return new GClass70(0, string.Empty);
	}

	private GClass70 method_5()
	{
		string text = textBox_3.Text.Trim();
		string text2 = textBox_0.Text.Trim();
		string text3 = textBox_2.Text.Trim();
		string string_ = textBox_1.Text.Trim();
		if (text.Length != 0 && text2.Length != 0 && text3.Length != 0)
		{
			return method_4(text, text2, text3, string_);
		}
		return new GClass70(0, string.Empty);
	}

	private void linkLabel_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (saveFileDialog_0.ShowDialog() == DialogResult.Cancel)
		{
			return;
		}
		try
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add(Class84.smethod_0(-994247231), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable.Columns.Add(Class84.smethod_0(-994247169), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable.Columns.Add(Class84.smethod_0(-994247190), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable.Columns.Add(Class84.smethod_0(-994247193), Type.GetType(Class84.smethod_0(-994276505)));
			DataRow dataRow = dataTable.NewRow();
			dataRow[Class84.smethod_0(-994247231)] = Class224.Class228.string_0;
			dataRow[Class84.smethod_0(-994247169)] = Class224.Class228.string_1;
			dataRow[Class84.smethod_0(-994247190)] = Class224.Class228.string_2;
			dataRow[Class84.smethod_0(-994247193)] = Class123.smethod_1(Class224.Class228.string_3);
			dataTable.Rows.Add(dataRow);
			DataSet dataSet = new DataSet(Class84.smethod_0(-994247146));
			dataSet.Tables.Add(dataTable);
			dataSet.WriteXml(saveFileDialog_0.FileName);
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (Class348.Class351.bool_0)
		{
			Class355.smethod_3(Class84.smethod_0(-994247886));
		}
		else if (openFileDialog_0.ShowDialog() != DialogResult.Cancel)
		{
			try
			{
				DataSet dataSet = new DataSet(Class84.smethod_0(-994247146));
				dataSet.ReadXml(openFileDialog_0.FileName);
				DataTable dataTable = dataSet.Tables[0];
				textBox_3.Text = dataTable.Rows[0][Class84.smethod_0(-994247231)].ToString();
				textBox_0.Text = dataTable.Rows[0][Class84.smethod_0(-994247169)].ToString();
				textBox_2.Text = dataTable.Rows[0][Class84.smethod_0(-994247190)].ToString();
				textBox_1.Text = Class123.smethod_4(dataTable.Rows[0][Class84.smethod_0(-994247193)].ToString());
			}
			catch (Exception ex)
			{
				Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			}
		}
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void linkLabel_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Clipboard.Clear();
			Clipboard.SetText(textBox_4.Text);
		}
		catch (Exception)
		{
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		MySqlConnection mySqlConnection = null;
		try
		{
			Cursor = Cursors.WaitCursor;
			GClass70 gClass = method_5();
			if (gClass.Value == 0)
			{
				Cursor = Cursors.Default;
				return;
			}
			if (gClass.Value == -1)
			{
				Cursor = Cursors.Default;
				Class355.smethod_0(Class84.smethod_0(-994247811) + gClass.Text);
				return;
			}
			string text = textBox_3.Text.Trim();
			string text2 = textBox_0.Text.Trim();
			string text3 = textBox_2.Text.Trim();
			string text4 = textBox_1.Text.Trim();
			mySqlConnection = new MySqlConnection(string.Format(Class84.smethod_0(-994247115), text, text2, text3, text4));
			mySqlConnection.Open();
			Class348.Class350.string_0 = Class190.smethod_9(mySqlConnection);
			textBox_4.Text = Class348.Class350.string_0;
			Cursor = Cursors.Default;
		}
		catch (Exception ex)
		{
			Cursor = Cursors.Default;
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		MySqlConnection mySqlConnection = null;
		try
		{
			Cursor = Cursors.WaitCursor;
			GClass70 gClass = method_5();
			if (gClass.Value == 0)
			{
				Cursor = Cursors.Default;
				return;
			}
			if (gClass.Value == -1)
			{
				Cursor = Cursors.Default;
				Class355.smethod_0(Class84.smethod_0(-994247811) + gClass.Text);
				return;
			}
			string text = textBox_3.Text.Trim();
			string text2 = textBox_0.Text.Trim();
			string text3 = textBox_2.Text.Trim();
			string text4 = textBox_1.Text.Trim();
			mySqlConnection = new MySqlConnection(string.Format(Class84.smethod_0(-994247115), text, text2, text3, text4));
			mySqlConnection.Open();
			textBox_5.Text = Class190.smethod_8(mySqlConnection);
			Cursor = Cursors.Default;
		}
		catch (Exception ex)
		{
			Cursor = Cursors.Default;
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private void linkLabel_3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Clipboard.Clear();
			Clipboard.SetText(textBox_5.Text);
		}
		catch (Exception)
		{
		}
	}

	private void GForm22_Shown(object sender, EventArgs e)
	{
	}

	private void GForm22_Activated(object sender, EventArgs e)
	{
		button_0.Enabled = !Class348.Class349.bool_0 && !Class348.Class351.bool_0;
		button_3.Enabled = !Class348.Class349.bool_0;
		textBox_3.Enabled = !Class348.Class349.bool_0 && !Class348.Class351.bool_0;
		textBox_1.Enabled = !Class348.Class349.bool_0 && !Class348.Class351.bool_0;
		textBox_0.Enabled = !Class348.Class349.bool_0 && !Class348.Class351.bool_0;
		textBox_2.Enabled = !Class348.Class349.bool_0 && !Class348.Class351.bool_0;
		label_13.Visible = Class348.Class351.bool_0;
	}

	private bool method_6()
	{
		if (comboBox_0.Items.Count == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994247728));
			comboBox_0.Focus();
			return false;
		}
		return true;
	}

	private bool method_7()
	{
		string value = comboBox_0.Text;
		return Class224.Class229.string_0.Equals(value);
	}

	private void button_3_Click(object sender, EventArgs e)
	{
		if (Class348.Class349.bool_0)
		{
			Class355.smethod_2(Class84.smethod_0(-994247047));
		}
		else if (!method_7() && method_6())
		{
			Class224.Class229.string_0 = comboBox_0.Text;
			Class205.smethod_1();
			method_1();
			gform17_0.method_22();
			Class355.smethod_3(Class84.smethod_0(-994246980));
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm22));
		pictureBox_0 = new PictureBox();
		label_0 = new Label();
		groupBox_0 = new GroupBox();
		linkLabel_0 = new LinkLabel();
		linkLabel_1 = new LinkLabel();
		textBox_0 = new TextBox();
		button_0 = new Button();
		label_1 = new Label();
		label_2 = new Label();
		textBox_1 = new TextBox();
		textBox_2 = new TextBox();
		label_3 = new Label();
		textBox_3 = new TextBox();
		saveFileDialog_0 = new SaveFileDialog();
		openFileDialog_0 = new OpenFileDialog();
		groupBox_1 = new GroupBox();
		linkLabel_2 = new LinkLabel();
		button_1 = new Button();
		label_4 = new Label();
		textBox_4 = new TextBox();
		label_5 = new Label();
		groupBox_2 = new GroupBox();
		linkLabel_3 = new LinkLabel();
		button_2 = new Button();
		label_6 = new Label();
		textBox_5 = new TextBox();
		label_7 = new Label();
		groupBox_3 = new GroupBox();
		panel_0 = new Panel();
		label_8 = new Label();
		label_9 = new Label();
		label_10 = new Label();
		comboBox_0 = new ComboBox();
		label_11 = new Label();
		textBox_6 = new TextBox();
		button_3 = new Button();
		label_12 = new Label();
		label_13 = new Label();
		((ISupportInitialize)pictureBox_0).BeginInit();
		groupBox_0.SuspendLayout();
		groupBox_1.SuspendLayout();
		groupBox_2.SuspendLayout();
		groupBox_3.SuspendLayout();
		panel_0.SuspendLayout();
		SuspendLayout();
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(1055, 3);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 91;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994278767);
		label_0.Size = new Size(76, 17);
		label_0.TabIndex = 93;
		label_0.Text = Class84.smethod_0(-994246860);
		groupBox_0.Controls.Add(linkLabel_0);
		groupBox_0.Controls.Add(linkLabel_1);
		groupBox_0.Controls.Add(textBox_0);
		groupBox_0.Controls.Add(button_0);
		groupBox_0.Controls.Add(label_1);
		groupBox_0.Controls.Add(label_2);
		groupBox_0.Controls.Add(textBox_1);
		groupBox_0.Controls.Add(textBox_2);
		groupBox_0.Controls.Add(label_3);
		groupBox_0.Controls.Add(textBox_3);
		groupBox_0.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		groupBox_0.Location = new Point(24, 65);
		groupBox_0.Name = Class84.smethod_0(-994246875);
		groupBox_0.Size = new Size(520, 190);
		groupBox_0.TabIndex = 92;
		groupBox_0.TabStop = false;
		groupBox_0.Text = Class84.smethod_0(-994246826);
		linkLabel_0.AutoSize = true;
		linkLabel_0.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		linkLabel_0.Location = new Point(290, 153);
		linkLabel_0.Name = Class84.smethod_0(-994246796);
		linkLabel_0.Size = new Size(160, 13);
		linkLabel_0.TabIndex = 34;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class84.smethod_0(-994246815);
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		linkLabel_1.AutoSize = true;
		linkLabel_1.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		linkLabel_1.Location = new Point(290, 132);
		linkLabel_1.Name = Class84.smethod_0(-994246728);
		linkLabel_1.Size = new Size(170, 13);
		linkLabel_1.TabIndex = 33;
		linkLabel_1.TabStop = true;
		linkLabel_1.Text = Class84.smethod_0(-994246729);
		linkLabel_1.LinkClicked += linkLabel_1_LinkClicked;
		textBox_0.BorderStyle = BorderStyle.FixedSingle;
		textBox_0.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_0.Location = new Point(279, 35);
		textBox_0.Name = Class84.smethod_0(-994246720);
		textBox_0.Size = new Size(42, 26);
		textBox_0.TabIndex = 2;
		button_0.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button_0.Image = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994246657));
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(100, 132);
		button_0.Name = Class84.smethod_0(-994246681);
		button_0.Size = new Size(152, 28);
		button_0.TabIndex = 5;
		button_0.Text = Class84.smethod_0(-994248543);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		label_1.AutoSize = true;
		label_1.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_1.Location = new Point(41, 101);
		label_1.Name = Class84.smethod_0(-994250743);
		label_1.Size = new Size(53, 13);
		label_1.TabIndex = 32;
		label_1.Text = Class84.smethod_0(-994250745);
		label_1.TextAlign = ContentAlignment.MiddleRight;
		label_2.AutoSize = true;
		label_2.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_2.Location = new Point(51, 71);
		label_2.Name = Class84.smethod_0(-994250698);
		label_2.Size = new Size(43, 13);
		label_2.TabIndex = 30;
		label_2.Text = Class84.smethod_0(-994250716);
		label_2.TextAlign = ContentAlignment.MiddleRight;
		textBox_1.BorderStyle = BorderStyle.FixedSingle;
		textBox_1.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_1.Location = new Point(100, 97);
		textBox_1.Name = Class84.smethod_0(-994250670);
		textBox_1.PasswordChar = '?';
		textBox_1.Size = new Size(173, 23);
		textBox_1.TabIndex = 4;
		textBox_2.BorderStyle = BorderStyle.FixedSingle;
		textBox_2.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_2.Location = new Point(100, 68);
		textBox_2.Name = Class84.smethod_0(-994250683);
		textBox_2.Size = new Size(173, 23);
		textBox_2.TabIndex = 3;
		label_3.AutoSize = true;
		label_3.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_3.Location = new Point(56, 38);
		label_3.Name = Class84.smethod_0(-994250636);
		label_3.Size = new Size(38, 13);
		label_3.TabIndex = 26;
		label_3.Text = Class84.smethod_0(-994250654);
		textBox_3.BorderStyle = BorderStyle.FixedSingle;
		textBox_3.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_3.Location = new Point(100, 35);
		textBox_3.Name = Class84.smethod_0(-994250593);
		textBox_3.Size = new Size(173, 26);
		textBox_3.TabIndex = 1;
		groupBox_1.Controls.Add(linkLabel_2);
		groupBox_1.Controls.Add(button_1);
		groupBox_1.Controls.Add(label_4);
		groupBox_1.Controls.Add(textBox_4);
		groupBox_1.Controls.Add(label_5);
		groupBox_1.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		groupBox_1.Location = new Point(550, 65);
		groupBox_1.Name = Class84.smethod_0(-994250624);
		groupBox_1.Size = new Size(472, 166);
		groupBox_1.TabIndex = 94;
		groupBox_1.TabStop = false;
		groupBox_1.Text = Class84.smethod_0(-994250563);
		linkLabel_2.AutoSize = true;
		linkLabel_2.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		linkLabel_2.Location = new Point(288, 112);
		linkLabel_2.Name = Class84.smethod_0(-994250577);
		linkLabel_2.Size = new Size(91, 13);
		linkLabel_2.TabIndex = 31;
		linkLabel_2.TabStop = true;
		linkLabel_2.Text = Class84.smethod_0(-994250544);
		linkLabel_2.LinkClicked += linkLabel_2_LinkClicked;
		button_1.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button_1.Location = new Point(125, 105);
		button_1.Name = Class84.smethod_0(-994250503);
		button_1.Size = new Size(142, 26);
		button_1.TabIndex = 30;
		button_1.Text = Class84.smethod_0(-994250513);
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		label_4.AutoSize = true;
		label_4.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_4.Location = new Point(26, 38);
		label_4.Name = Class84.smethod_0(-994266720);
		label_4.Size = new Size(368, 13);
		label_4.TabIndex = 29;
		label_4.Text = Class84.smethod_0(-994250473);
		textBox_4.BackColor = Color.Green;
		textBox_4.BorderStyle = BorderStyle.FixedSingle;
		textBox_4.Font = new Font(Class84.smethod_0(-994274653), 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
		textBox_4.ForeColor = Color.Yellow;
		textBox_4.Location = new Point(125, 64);
		textBox_4.MaxLength = 5;
		textBox_4.Name = Class84.smethod_0(-994250426);
		textBox_4.ReadOnly = true;
		textBox_4.Size = new Size(301, 35);
		textBox_4.TabIndex = 28;
		textBox_4.TextAlign = HorizontalAlignment.Center;
		label_5.AutoSize = true;
		label_5.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_5.Location = new Point(54, 76);
		label_5.Name = Class84.smethod_0(-994278834);
		label_5.Size = new Size(65, 13);
		label_5.TabIndex = 27;
		label_5.Text = Class84.smethod_0(-994250563);
		groupBox_2.Controls.Add(linkLabel_3);
		groupBox_2.Controls.Add(button_2);
		groupBox_2.Controls.Add(label_6);
		groupBox_2.Controls.Add(textBox_5);
		groupBox_2.Controls.Add(label_7);
		groupBox_2.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		groupBox_2.Location = new Point(550, 239);
		groupBox_2.Name = Class84.smethod_0(-994250381);
		groupBox_2.Size = new Size(472, 190);
		groupBox_2.TabIndex = 95;
		groupBox_2.TabStop = false;
		groupBox_2.Text = Class84.smethod_0(-994250396);
		linkLabel_3.AutoSize = true;
		linkLabel_3.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		linkLabel_3.Location = new Point(288, 159);
		linkLabel_3.Name = Class84.smethod_0(-994250355);
		linkLabel_3.Size = new Size(91, 13);
		linkLabel_3.TabIndex = 31;
		linkLabel_3.TabStop = true;
		linkLabel_3.Text = Class84.smethod_0(-994250544);
		linkLabel_3.LinkClicked += linkLabel_3_LinkClicked;
		button_2.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button_2.Location = new Point(125, 152);
		button_2.Name = Class84.smethod_0(-994250318);
		button_2.Size = new Size(142, 26);
		button_2.TabIndex = 30;
		button_2.Text = Class84.smethod_0(-994250273);
		button_2.UseVisualStyleBackColor = true;
		button_2.Click += button_2_Click;
		label_6.AutoSize = true;
		label_6.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_6.Location = new Point(26, 38);
		label_6.Name = Class84.smethod_0(-994266659);
		label_6.Size = new Size(400, 13);
		label_6.TabIndex = 29;
		label_6.Text = Class84.smethod_0(-994250242);
		textBox_5.BackColor = Color.RoyalBlue;
		textBox_5.BorderStyle = BorderStyle.FixedSingle;
		textBox_5.Font = new Font(Class84.smethod_0(-994274653), 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		textBox_5.ForeColor = Color.White;
		textBox_5.Location = new Point(125, 71);
		textBox_5.MaxLength = 5;
		textBox_5.Multiline = true;
		textBox_5.Name = Class84.smethod_0(-994250204);
		textBox_5.ReadOnly = true;
		textBox_5.Size = new Size(301, 75);
		textBox_5.TabIndex = 28;
		label_7.AutoSize = true;
		label_7.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_7.Location = new Point(22, 75);
		label_7.Name = Class84.smethod_0(-994266638);
		label_7.Size = new Size(97, 13);
		label_7.TabIndex = 27;
		label_7.Text = Class84.smethod_0(-994250396);
		groupBox_3.Controls.Add(panel_0);
		groupBox_3.Controls.Add(comboBox_0);
		groupBox_3.Controls.Add(label_11);
		groupBox_3.Controls.Add(textBox_6);
		groupBox_3.Controls.Add(button_3);
		groupBox_3.Controls.Add(label_12);
		groupBox_3.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		groupBox_3.Location = new Point(24, 261);
		groupBox_3.Name = Class84.smethod_0(-994278480);
		groupBox_3.Size = new Size(520, 249);
		groupBox_3.TabIndex = 100;
		groupBox_3.TabStop = false;
		groupBox_3.Text = Class84.smethod_0(-994250155);
		panel_0.BackColor = Color.Beige;
		panel_0.Controls.Add(label_8);
		panel_0.Controls.Add(label_9);
		panel_0.Controls.Add(label_10);
		panel_0.Location = new Point(16, 136);
		panel_0.Name = Class84.smethod_0(-994256784);
		panel_0.Size = new Size(475, 92);
		panel_0.TabIndex = 156;
		label_8.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_8.Location = new Point(7, 48);
		label_8.Name = Class84.smethod_0(-994266614);
		label_8.Size = new Size(437, 30);
		label_8.TabIndex = 101;
		label_8.Text = Class84.smethod_0(-994250121);
		label_9.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_9.Location = new Point(7, 28);
		label_9.Name = Class84.smethod_0(-994256681);
		label_9.Size = new Size(447, 30);
		label_9.TabIndex = 1;
		label_9.Text = Class84.smethod_0(-994250012);
		label_10.AutoSize = true;
		label_10.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_10.Location = new Point(5, 5);
		label_10.Name = Class84.smethod_0(-994256663);
		label_10.Size = new Size(61, 13);
		label_10.TabIndex = 0;
		label_10.Text = Class84.smethod_0(-994249912);
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Location = new Point(102, 59);
		comboBox_0.Name = Class84.smethod_0(-994249864);
		comboBox_0.Size = new Size(176, 28);
		comboBox_0.TabIndex = 36;
		label_11.AutoSize = true;
		label_11.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_11.ForeColor = Color.Black;
		label_11.Location = new Point(26, 36);
		label_11.Name = Class84.smethod_0(-994266391);
		label_11.Size = new Size(396, 13);
		label_11.TabIndex = 35;
		label_11.Text = Class84.smethod_0(-994249874);
		textBox_6.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_6.Location = new Point(284, 59);
		textBox_6.Name = Class84.smethod_0(-994249775);
		textBox_6.ReadOnly = true;
		textBox_6.Size = new Size(52, 26);
		textBox_6.TabIndex = 34;
		textBox_6.Text = Class84.smethod_0(-994249791);
		button_3.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button_3.Image = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994249732));
		button_3.ImageAlign = ContentAlignment.MiddleLeft;
		button_3.Location = new Point(102, 93);
		button_3.Name = Class84.smethod_0(-994249699);
		button_3.Size = new Size(150, 28);
		button_3.TabIndex = 7;
		button_3.Text = Class84.smethod_0(-994248543);
		button_3.TextAlign = ContentAlignment.MiddleRight;
		button_3.UseVisualStyleBackColor = true;
		button_3.Click += button_3_Click;
		label_12.AutoSize = true;
		label_12.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_12.Location = new Point(36, 67);
		label_12.Name = Class84.smethod_0(-994256357);
		label_12.Size = new Size(60, 13);
		label_12.TabIndex = 26;
		label_12.Text = Class84.smethod_0(-994249672);
		label_13.AutoSize = true;
		label_13.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_13.ForeColor = Color.Red;
		label_13.Location = new Point(121, 20);
		label_13.Name = Class84.smethod_0(-994249686);
		label_13.Size = new Size(364, 17);
		label_13.TabIndex = 101;
		label_13.Text = Class84.smethod_0(-994249634);
		label_13.Visible = false;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1076, 620);
		Controls.Add(label_13);
		Controls.Add(groupBox_3);
		Controls.Add(groupBox_2);
		Controls.Add(groupBox_1);
		Controls.Add(label_0);
		Controls.Add(groupBox_0);
		Controls.Add(pictureBox_0);
		Name = Class84.smethod_0(-994249574);
		Text = Class84.smethod_0(-994246860);
		Activated += GForm22_Activated;
		Load += GForm22_Load;
		Shown += GForm22_Shown;
		((ISupportInitialize)pictureBox_0).EndInit();
		groupBox_0.ResumeLayout(performLayout: false);
		groupBox_0.PerformLayout();
		groupBox_1.ResumeLayout(performLayout: false);
		groupBox_1.PerformLayout();
		groupBox_2.ResumeLayout(performLayout: false);
		groupBox_2.PerformLayout();
		groupBox_3.ResumeLayout(performLayout: false);
		groupBox_3.PerformLayout();
		panel_0.ResumeLayout(performLayout: false);
		panel_0.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
