using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

public sealed class GForm8 : Form
{
	private readonly GForm17 gform17_0;

	private bool bool_0;

	private Class216 class216_0;

	private DataTable dataTable_0;

	private MySqlConnection mySqlConnection_0;

	private MySqlTransaction mySqlTransaction_0;

	private static CookieContainer cookieContainer_0;

	private IContainer icontainer_0;

	private Label label_0;

	private PictureBox pictureBox_0;

	private ComboBox comboBox_0;

	private Label label_1;

	private Label label_2;

	private ComboBox comboBox_1;

	private ComboBox comboBox_2;

	private Label label_3;

	private ComboBox comboBox_3;

	private ComboBox comboBox_4;

	private Button button_0;

	private Class193 class193_0;

	private Button button_1;

	public GForm8(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
		method_13();
		method_6();
		method_0();
	}

	public static CookieContainer smethod_0()
	{
		if (cookieContainer_0 == null)
		{
			cookieContainer_0 = new CookieContainer();
		}
		return cookieContainer_0;
	}

	private void method_0()
	{
		try
		{
			class216_0 = new Class216(class193_0, bool_0: false, bool_1: false);
			class216_0.method_4();
			class216_0.method_2(Class84.smethod_0(-994256094), 180, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994256048), 350, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994256051), 250, bool_0: true);
			class216_0.method_7(Class84.smethod_0(-994256006), 50);
			class216_0.method_7(Class84.smethod_0(-994256010), 50);
			class216_0.method_7(Class84.smethod_0(-994256031), 60);
			class216_0.method_4();
			class216_0.method_1(4, method_1);
			class216_0.method_1(5, method_5);
			class216_0.method_1(6, method_4);
			dataTable_0 = new DataTable();
			dataTable_0.Columns.Add(Class84.smethod_0(-994255971), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994255988), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994268508), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994268429), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994277847), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994255942), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994255947), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994255967), Type.GetType(Class84.smethod_0(-994276505)));
			class193_0.Columns[Class84.smethod_0(-994256094)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
			class193_0.Columns[Class84.smethod_0(-994256094)].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			class193_0.Columns[Class84.smethod_0(-994256048)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
			class193_0.Columns[Class84.smethod_0(-994256048)].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			class193_0.Columns[Class84.smethod_0(-994256051)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
			class193_0.Columns[Class84.smethod_0(-994256051)].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			class193_0.Columns[Class84.smethod_0(-994256006)].DefaultCellStyle.Padding = new Padding(2, 2, 2, 72);
			class193_0.Columns[Class84.smethod_0(-994256010)].DefaultCellStyle.Padding = new Padding(2, 2, 2, 72);
			class193_0.Columns[Class84.smethod_0(-994256031)].DefaultCellStyle.Padding = new Padding(2, 2, 2, 72);
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
			string string_ = dataGridViewRow_0.Cells[0].Value.ToString();
			GForm11 gForm = new GForm11();
			gForm.method_0(string_);
			gForm.ShowDialog();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private GClass70 method_2()
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class191
			{
				Op = Class84.smethod_0(-994265364)
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			GClass70 result = null;
			Class139 @class = new Class139(smethod_0());
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_11(), Class84.smethod_0(-994265316), data);
				result = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			return result;
		}
		catch (Exception ex)
		{
			return new GClass70(-99, ex.Message, ex);
		}
	}

	private void method_3(string string_0)
	{
		if (!(string_0 == Class84.smethod_0(-994265321)))
		{
			if (string_0 == Class84.smethod_0(-994265342))
			{
				Cursor = Cursors.Default;
			}
		}
		else
		{
			Cursor = Cursors.WaitCursor;
		}
	}

	private void method_4(int int_0, DataGridViewRow dataGridViewRow_0)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
			return;
		}
		if (Class348.Class352.string_0.Trim().Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994278342));
			return;
		}
		string value = dataGridViewRow_0.Cells[7].Value.ToString();
		if (gform17_0.method_0().gclass6_0.method_6() != 0 && !gform17_0.method_0().gclass6_0.method_2().Equals(value))
		{
			Class355.smethod_0(Class84.smethod_0(-994255919));
		}
		else
		{
			if (Class355.smethod_1(Class84.smethod_0(-994255890)) == DialogResult.Cancel)
			{
				return;
			}
			if (Class348.Class352.string_0.Trim().Length == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994278342));
				return;
			}
			method_3(Class84.smethod_0(-994265321));
			GClass70 gClass2 = Class194.smethod_0();
			if (gClass2.Value < 0)
			{
				method_3(Class84.smethod_0(-994265342));
				Class355.smethod_0(Class84.smethod_0(-994255850) + gClass2.Text);
				return;
			}
			GClass70 gClass3 = method_2();
			if (gClass3.Value >= 0)
			{
				string transactionId = gClass3.Data.ToString();
				mySqlConnection_0 = new MySqlConnection(Class224.Class228.smethod_0());
				try
				{
					string text = dataGridViewRow_0.Cells[0].Value.ToString();
					Class191 value2 = new Class191
					{
						SchoolId = Class348.Class352.string_0,
						IdBerita = text,
						Op = Class84.smethod_0(-994255819),
						TransactionId = transactionId
					};
					mySqlConnection_0.Open();
					mySqlTransaction_0 = mySqlConnection_0.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
					MySqlCommand mySqlCommand = new MySqlCommand();
					mySqlCommand.Connection = mySqlConnection_0;
					mySqlCommand.Transaction = mySqlTransaction_0;
					string commandText = Class84.smethod_0(-994270222) + text + Class84.smethod_0(-994271698);
					mySqlCommand.CommandText = commandText;
					mySqlCommand.ExecuteNonQuery();
					commandText = Class84.smethod_0(-994270367) + text + Class84.smethod_0(-994271698);
					mySqlCommand.CommandText = commandText;
					mySqlCommand.ExecuteNonQuery();
					commandText = Class84.smethod_0(-994270296) + text + Class84.smethod_0(-994271698);
					mySqlCommand.CommandText = commandText;
					mySqlCommand.ExecuteNonQuery();
					commandText = Class84.smethod_0(-994255838) + text + Class84.smethod_0(-994271698);
					mySqlCommand.CommandText = commandText;
					mySqlCommand.ExecuteNonQuery();
					var (name, value3) = Class320.smethod_5(JsonConvert.SerializeObject(value2), Class320.int_5, 10000);
					NameValueCollection data = new NameValueCollection { { name, value3 } };
					Class139 @class = new Class139(smethod_0());
					GClass70 gClass4;
					try
					{
						byte[] bytes = @class.UploadValues(Class272.smethod_11(), Class84.smethod_0(-994265316), data);
						gClass4 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
					}
					finally
					{
						((IDisposable)@class).Dispose();
					}
					method_3(Class84.smethod_0(-994265342));
					if (gClass4.Value == 1)
					{
						mySqlTransaction_0?.Commit();
						method_10();
					}
					else
					{
						mySqlTransaction_0?.Rollback();
						Class355.smethod_0(Class84.smethod_0(-994255850) + gClass4.Text);
					}
					return;
				}
				catch (Exception ex)
				{
					method_3(Class84.smethod_0(-994265342));
					mySqlTransaction_0?.Rollback();
					mySqlConnection_0?.Close();
					Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, Class84.smethod_0(-994255756) + ex.Message, ex);
					return;
				}
				finally
				{
					mySqlConnection_0?.Close();
				}
			}
			method_3(Class84.smethod_0(-994265342));
			Class355.smethod_0(Class84.smethod_0(-994255850) + gClass3.Text);
		}
	}

	private void method_5(int int_0, DataGridViewRow dataGridViewRow_0)
	{
		try
		{
			GClass70 gClass = Class316.smethod_12();
			if (gClass.Value != 1)
			{
				Class355.smethod_0(gClass.Text);
				return;
			}
			if (Class348.Class352.string_0.Trim().Length == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994278342));
				return;
			}
			string value = dataGridViewRow_0.Cells[7].Value.ToString();
			if (gform17_0.method_0().gclass6_0.method_6() != 0 && !gform17_0.method_0().gclass6_0.method_2().Equals(value))
			{
				Class355.smethod_0(Class84.smethod_0(-994255725));
				return;
			}
			string string_ = dataGridViewRow_0.Cells[0].Value.ToString();
			GForm36 gForm = new GForm36(gform17_0, this);
			gForm.method_1(string_);
			gForm.ShowDialog();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_6()
	{
		try
		{
			method_9();
			method_7(comboBox_1);
			method_7(comboBox_4);
			method_8(comboBox_2);
			method_8(comboBox_3);
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_7(ComboBox comboBox_5)
	{
		bool_0 = true;
		for (int i = 1; i <= 12; i++)
		{
			comboBox_5.Items.Add(Class120.smethod_18(i));
		}
		comboBox_5.SelectedIndex = DateTime.Now.Month - 1;
		bool_0 = false;
	}

	private void method_8(ComboBox comboBox_5)
	{
		bool_0 = true;
		for (int i = Class224.Class227.int_0; i <= DateTime.Now.Year + 1; i++)
		{
			comboBox_5.Items.Add(i.ToString());
		}
		comboBox_5.Text = DateTime.Now.Year.ToString();
		bool_0 = false;
	}

	private void method_9()
	{
		bool_0 = true;
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			comboBox_0.Items.Clear();
			ComboBox.ObjectCollection items = comboBox_0.Items;
			GClass2 gClass = new GClass2();
			gClass.method_3(Class84.smethod_0(-994278690));
			gClass.method_1(Class84.smethod_0(-994255697));
			items.Add(gClass);
			string commandText = Class84.smethod_0(-994255659);
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = commandText
			}.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				ComboBox.ObjectCollection items2 = comboBox_0.Items;
				GClass2 gClass2 = new GClass2();
				gClass2.method_3(mySqlDataReader[0].ToString());
				gClass2.method_1(mySqlDataReader[1].ToString());
				items2.Add(gClass2);
			}
			mySqlDataReader.Close();
			comboBox_0.SelectedIndex = 0;
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
			bool_0 = false;
		}
	}

	private void GForm8_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		method_10();
	}

	public void method_10()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			class216_0.method_12();
			dataTable_0.Rows.Clear();
			string text = ((GClass2)comboBox_0.SelectedItem).method_5();
			int num = comboBox_1.SelectedIndex + 1;
			string text2 = comboBox_2.Text;
			int num2 = comboBox_4.SelectedIndex + 1;
			string text3 = comboBox_3.Text;
			string format = Class84.smethod_0(-994255519);
			format = string.Format(format, num, text2, num2, text3);
			if (!text.Equals(Class84.smethod_0(-994278690)))
			{
				format = format + Class84.smethod_0(-994255044) + text + Class84.smethod_0(-994271698);
			}
			format += Class84.smethod_0(-994255069);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = format
			};
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			foreach (DataRow row in dataTable.Rows)
			{
				string text4 = row[Class84.smethod_0(-994255971)].ToString();
				string text5 = row[Class84.smethod_0(-994277142)]?.ToString() + Class84.smethod_0(-994265926) + row[Class84.smethod_0(-994255988)]?.ToString() + Class84.smethod_0(-994255040);
				text5 = text5 + Class84.smethod_0(-994254983) + row[Class84.smethod_0(-994254996)]?.ToString() + Class84.smethod_0(-994263511);
				text5 = text5 + Class84.smethod_0(-994254947) + row[Class84.smethod_0(-994254962)];
				string text6 = row[Class84.smethod_0(-994268488)]?.ToString() + Class84.smethod_0(-994263511);
				text6 += row[Class84.smethod_0(-994268492)];
				DataRow dataRow2 = dataTable_0.NewRow();
				dataRow2[Class84.smethod_0(-994255971)] = text4;
				dataRow2[Class84.smethod_0(-994255988)] = text5;
				dataRow2[Class84.smethod_0(-994268508)] = text6;
				dataRow2[Class84.smethod_0(-994268429)] = method_11(text4, mySqlCommand);
				dataRow2[Class84.smethod_0(-994277847)] = Class84.smethod_0(-994277847);
				dataRow2[Class84.smethod_0(-994255942)] = Class84.smethod_0(-994255942);
				dataRow2[Class84.smethod_0(-994255947)] = Class84.smethod_0(-994255947);
				dataRow2[Class84.smethod_0(-994255967)] = row[Class84.smethod_0(-994255988)].ToString();
				dataTable_0.Rows.Add(dataRow2);
			}
			class216_0.method_9(dataTable_0);
			class216_0.method_18(100);
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

	private string method_11(string string_0, MySqlCommand mySqlCommand_0)
	{
		string text = string.Empty;
		string text2 = string.Empty;
		string text3 = string.Empty;
		string commandText = Class84.smethod_0(-994254915) + string_0 + Class84.smethod_0(-994271698);
		mySqlCommand_0.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			text = mySqlDataReader[Class84.smethod_0(-994268429)].ToString();
			text2 = mySqlDataReader[Class84.smethod_0(-994273283)].ToString();
			text3 = mySqlDataReader[Class84.smethod_0(-994268361)].ToString();
		}
		mySqlDataReader.Close();
		if (text.Equals(string.Empty))
		{
			return string.Empty;
		}
		string result = string.Empty;
		if (text.Equals(Class84.smethod_0(-994268389)))
		{
			result = Class84.smethod_0(-994268118);
		}
		else if (text.Equals(Class84.smethod_0(-994268415)))
		{
			result = Class84.smethod_0(-994254867) + text2;
		}
		else if (text.Equals(Class84.smethod_0(-994268356)))
		{
			string text4 = string.Empty;
			commandText = Class84.smethod_0(-994258923) + text3;
			mySqlCommand_0.CommandText = commandText;
			mySqlDataReader = mySqlCommand_0.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				text4 = mySqlDataReader[Class84.smethod_0(-994264701)].ToString();
			}
			mySqlDataReader.Close();
			result = Class84.smethod_0(-994254867) + text2 + Class84.smethod_0(-994258849) + text4;
		}
		else if (text.Equals(Class84.smethod_0(-994268377)))
		{
			string text5 = string.Empty;
			commandText = Class84.smethod_0(-994258923) + text3;
			mySqlCommand_0.CommandText = commandText;
			mySqlDataReader = mySqlCommand_0.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				text5 = mySqlDataReader[Class84.smethod_0(-994264701)].ToString();
			}
			mySqlDataReader.Close();
			string text6 = string.Empty;
			commandText = Class84.smethod_0(-994258865) + string_0 + Class84.smethod_0(-994271698);
			mySqlCommand_0.CommandText = commandText;
			mySqlDataReader = mySqlCommand_0.ExecuteReader();
			int num = 0;
			while (mySqlDataReader.Read())
			{
				num++;
				if (!text6.Equals(string.Empty))
				{
					text6 += Class84.smethod_0(-994263511);
				}
				text6 = text6 + num + Class84.smethod_0(-994258724) + mySqlDataReader[Class84.smethod_0(-994277105)];
			}
			mySqlDataReader.Close();
			result = Class84.smethod_0(-994254867) + text2 + Class84.smethod_0(-994258849) + text5 + Class84.smethod_0(-994258731) + text6;
		}
		else if (text.Equals(Class84.smethod_0(-994268275)))
		{
			string text7 = string.Empty;
			commandText = Class84.smethod_0(-994258749) + string_0 + Class84.smethod_0(-994271698);
			mySqlCommand_0.CommandText = commandText;
			mySqlDataReader = mySqlCommand_0.ExecuteReader();
			int num2 = 0;
			while (mySqlDataReader.Read())
			{
				num2++;
				if (!text7.Equals(string.Empty))
				{
					text7 += Class84.smethod_0(-994263511);
				}
				text7 = text7 + num2 + Class84.smethod_0(-994258724) + mySqlDataReader[Class84.smethod_0(-994268131)];
			}
			mySqlDataReader.Close();
			result = Class84.smethod_0(-994254867) + text2 + Class84.smethod_0(-994258624) + text7;
		}
		return result;
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
		}
		else
		{
			new GForm36(gform17_0, this).ShowDialog();
		}
	}

	private void method_12()
	{
		if (!bool_0)
		{
			dataTable_0.Rows.Clear();
			class216_0.method_12();
		}
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_12();
	}

	private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_12();
	}

	private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_12();
	}

	private void comboBox_4_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_12();
	}

	private void comboBox_3_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_12();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_13()
	{
		label_0 = new Label();
		pictureBox_0 = new PictureBox();
		comboBox_0 = new ComboBox();
		label_1 = new Label();
		label_2 = new Label();
		comboBox_1 = new ComboBox();
		comboBox_2 = new ComboBox();
		label_3 = new Label();
		comboBox_3 = new ComboBox();
		comboBox_4 = new ComboBox();
		button_0 = new Button();
		class193_0 = new Class193();
		button_1 = new Button();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)class193_0).BeginInit();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994256787), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994266659);
		label_0.Size = new Size(93, 17);
		label_0.TabIndex = 70;
		label_0.Text = Class84.smethod_0(-994270650);
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(950, 3);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 91;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Location = new Point(92, 50);
		comboBox_0.Name = Class84.smethod_0(-994258575);
		comboBox_0.Size = new Size(393, 21);
		comboBox_0.TabIndex = 95;
		comboBox_0.SelectedIndexChanged += comboBox_0_SelectedIndexChanged;
		label_1.AutoSize = true;
		label_1.Location = new Point(45, 53);
		label_1.Name = Class84.smethod_0(-994278767);
		label_1.Size = new Size(41, 13);
		label_1.TabIndex = 94;
		label_1.Text = Class84.smethod_0(-994256094);
		label_2.Location = new Point(21, 82);
		label_2.Name = Class84.smethod_0(-994266720);
		label_2.Size = new Size(65, 32);
		label_2.TabIndex = 96;
		label_2.Text = Class84.smethod_0(-994258591);
		label_2.TextAlign = ContentAlignment.TopRight;
		comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_1.FormattingEnabled = true;
		comboBox_1.Location = new Point(92, 82);
		comboBox_1.Name = Class84.smethod_0(-994266540);
		comboBox_1.Size = new Size(103, 21);
		comboBox_1.TabIndex = 97;
		comboBox_1.SelectedIndexChanged += comboBox_1_SelectedIndexChanged;
		comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_2.FormattingEnabled = true;
		comboBox_2.Location = new Point(201, 82);
		comboBox_2.Name = Class84.smethod_0(-994266557);
		comboBox_2.Size = new Size(71, 21);
		comboBox_2.TabIndex = 98;
		comboBox_2.SelectedIndexChanged += comboBox_2_SelectedIndexChanged;
		label_3.AutoSize = true;
		label_3.Location = new Point(278, 85);
		label_3.Name = Class84.smethod_0(-994266638);
		label_3.Size = new Size(21, 13);
		label_3.TabIndex = 99;
		label_3.Text = Class84.smethod_0(-994258551);
		comboBox_3.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_3.FormattingEnabled = true;
		comboBox_3.Location = new Point(414, 82);
		comboBox_3.Name = Class84.smethod_0(-994258557);
		comboBox_3.Size = new Size(71, 21);
		comboBox_3.TabIndex = 101;
		comboBox_3.SelectedIndexChanged += comboBox_3_SelectedIndexChanged;
		comboBox_4.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_4.FormattingEnabled = true;
		comboBox_4.Location = new Point(305, 82);
		comboBox_4.Name = Class84.smethod_0(-994258510);
		comboBox_4.Size = new Size(103, 21);
		comboBox_4.TabIndex = 100;
		comboBox_4.SelectedIndexChanged += comboBox_4_SelectedIndexChanged;
		button_0.Image = Class309.smethod_63();
		button_0.Location = new Point(491, 50);
		button_0.Name = Class84.smethod_0(-994264273);
		button_0.Size = new Size(67, 53);
		button_0.TabIndex = 102;
		button_0.Text = Class84.smethod_0(-994256006);
		button_0.TextAlign = ContentAlignment.BottomCenter;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(24, 117);
		class193_0.Name = Class84.smethod_0(-994278735);
		class193_0.Size = new Size(934, 426);
		class193_0.TabIndex = 103;
		button_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button_1.Image = Class309.smethod_64();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(863, 73);
		button_1.Name = Class84.smethod_0(-994258527);
		button_1.Size = new Size(95, 30);
		button_1.TabIndex = 104;
		button_1.Text = Class84.smethod_0(-994258476);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(970, 578);
		Controls.Add(button_1);
		Controls.Add(class193_0);
		Controls.Add(button_0);
		Controls.Add(comboBox_3);
		Controls.Add(comboBox_4);
		Controls.Add(label_3);
		Controls.Add(comboBox_2);
		Controls.Add(comboBox_1);
		Controls.Add(label_2);
		Controls.Add(comboBox_0);
		Controls.Add(label_1);
		Controls.Add(pictureBox_0);
		Controls.Add(label_0);
		Name = Class84.smethod_0(-994258490);
		Text = Class84.smethod_0(-994258462);
		Load += GForm8_Load;
		((ISupportInitialize)pictureBox_0).EndInit();
		((ISupportInitialize)class193_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
