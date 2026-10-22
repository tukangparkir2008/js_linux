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

public sealed class GForm9 : Form
{
	private readonly GForm17 gform17_0;

	private Class216 class216_0;

	private DataTable dataTable_0;

	private MySqlConnection mySqlConnection_0;

	private MySqlTransaction mySqlTransaction_0;

	private static CookieContainer cookieContainer_0;

	private IContainer icontainer_0;

	private Label label_0;

	private Class193 class193_0;

	private Button button_0;

	private LinkLabel linkLabel_0;

	private PictureBox pictureBox_0;

	private Label label_1;

	public GForm9(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
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
			class216_0.method_2(Class84.smethod_0(-994259518), 350, bool_0: true);
			class216_0.method_7(Class84.smethod_0(-994256010), 50);
			class216_0.method_7(Class84.smethod_0(-994256031), 60);
			class216_0.method_1(3, method_1);
			class216_0.method_1(4, method_4);
			dataTable_0 = new DataTable();
			dataTable_0.Columns.Add(Class84.smethod_0(-994259459), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994255988), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994260157), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994255942), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994255947), Type.GetType(Class84.smethod_0(-994276505)));
			class193_0.Columns[Class84.smethod_0(-994256094)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
			class193_0.Columns[Class84.smethod_0(-994256094)].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			class193_0.Columns[Class84.smethod_0(-994259518)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
			class193_0.Columns[Class84.smethod_0(-994259518)].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
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
		if (gform17_0.method_0().gclass6_0.method_6() == 2)
		{
			Class355.smethod_4(Class84.smethod_0(-994259475));
			return;
		}
		try
		{
			string string_ = dataGridViewRow_0.Cells[0].Value.ToString();
			GForm24 gForm = new GForm24(gform17_0, this);
			gForm.method_0(string_);
			gForm.ShowDialog();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_2(string string_0)
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

	private GClass70 method_3()
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class191
			{
				Op = Class84.smethod_0(-994265364)
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 result;
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

	private void method_4(int int_0, DataGridViewRow dataGridViewRow_0)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
		}
		else if (gform17_0.method_0().gclass6_0.method_6() == 2)
		{
			Class355.smethod_4(Class84.smethod_0(-994259386));
		}
		else if (Class348.Class352.string_0.Trim().Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994278342));
		}
		else
		{
			if (Class355.smethod_1(Class84.smethod_0(-994259326)) == DialogResult.Cancel)
			{
				return;
			}
			if (Class348.Class352.string_0.Trim().Length == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994278342));
				return;
			}
			method_2(Class84.smethod_0(-994265321));
			GClass70 gClass2 = Class194.smethod_0();
			if (gClass2.Value < 0)
			{
				method_2(Class84.smethod_0(-994265342));
				Class355.smethod_0(Class84.smethod_0(-994259288) + gClass2.Text);
				return;
			}
			GClass70 gClass3 = method_3();
			if (gClass3.Value >= 0)
			{
				string transactionId = gClass3.Data.ToString();
				mySqlConnection_0 = new MySqlConnection(Class224.Class228.smethod_0());
				try
				{
					mySqlConnection_0.Open();
					mySqlTransaction_0 = mySqlConnection_0.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
					string text = dataGridViewRow_0.Cells[0].Value.ToString();
					string commandText = Class84.smethod_0(-994259229) + text + Class84.smethod_0(-994271698);
					MySqlCommand mySqlCommand = new MySqlCommand();
					mySqlCommand.Connection = mySqlConnection_0;
					mySqlCommand.Transaction = mySqlTransaction_0;
					mySqlCommand.CommandText = commandText;
					mySqlCommand.ExecuteNonQuery();
					var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class218
					{
						SchoolId = Class348.Class352.string_0,
						Op = Class84.smethod_0(-994255819),
						TransactionId = transactionId,
						IdRunText = text
					}), Class320.int_5, 10000);
					NameValueCollection data = new NameValueCollection { { name, value } };
					Class139 @class = new Class139(smethod_0());
					GClass70 gClass4;
					try
					{
						byte[] bytes = @class.UploadValues(Class272.smethod_12(), Class84.smethod_0(-994265316), data);
						gClass4 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
					}
					finally
					{
						((IDisposable)@class).Dispose();
					}
					method_2(Class84.smethod_0(-994265342));
					if (gClass4.Value == 1)
					{
						mySqlTransaction_0?.Commit();
						method_5();
					}
					else
					{
						mySqlTransaction_0?.Rollback();
						Class355.smethod_0(Class84.smethod_0(-994259937) + gClass4.Text);
					}
					return;
				}
				catch (Exception ex)
				{
					method_2(Class84.smethod_0(-994265342));
					mySqlTransaction_0?.Rollback();
					Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
					return;
				}
				finally
				{
					mySqlConnection_0?.Close();
				}
			}
			method_2(Class84.smethod_0(-994265342));
			Class355.smethod_0(Class84.smethod_0(-994259251) + gClass3.Text);
		}
	}

	private void GForm9_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
		}
		else if (gform17_0.method_0().gclass6_0.method_6() == 2)
		{
			Class355.smethod_4(Class84.smethod_0(-994259145));
		}
		else if (Class348.Class352.string_0.Trim().Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994278342));
		}
		else
		{
			new GForm24(gform17_0, this).ShowDialog();
		}
	}

	public void method_5()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			class216_0.method_12();
			dataTable_0.Rows.Clear();
			mySqlConnection.Open();
			string commandText = Class84.smethod_0(-994259087);
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = commandText
			}.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				DataRow dataRow = dataTable_0.NewRow();
				dataRow[Class84.smethod_0(-994259459)] = mySqlDataReader[Class84.smethod_0(-994259459)];
				dataRow[Class84.smethod_0(-994255988)] = mySqlDataReader[Class84.smethod_0(-994277142)]?.ToString() + Class84.smethod_0(-994265926) + mySqlDataReader[Class84.smethod_0(-994255988)]?.ToString() + Class84.smethod_0(-994262855) + mySqlDataReader[Class84.smethod_0(-994262869)];
				dataRow[Class84.smethod_0(-994260157)] = mySqlDataReader[Class84.smethod_0(-994260157)]?.ToString() + Class84.smethod_0(-994262823) + mySqlDataReader[Class84.smethod_0(-994260111)];
				dataRow[Class84.smethod_0(-994255942)] = Class84.smethod_0(-994255942);
				dataRow[Class84.smethod_0(-994255947)] = Class84.smethod_0(-994255947);
				dataTable_0.Rows.Add(dataRow);
			}
			mySqlDataReader.Close();
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

	private void GForm9_Shown(object sender, EventArgs e)
	{
		method_5();
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel_0.Enabled = false;
		method_5();
		linkLabel_0.Enabled = true;
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

	private void method_6()
	{
		label_0 = new Label();
		class193_0 = new Class193();
		button_0 = new Button();
		linkLabel_0 = new LinkLabel();
		pictureBox_0 = new PictureBox();
		label_1 = new Label();
		((ISupportInitialize)class193_0).BeginInit();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994256787), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994266659);
		label_0.Size = new Size(91, 17);
		label_0.TabIndex = 71;
		label_0.Text = Class84.smethod_0(-994259573);
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(24, 72);
		class193_0.Name = Class84.smethod_0(-994278735);
		class193_0.Size = new Size(1037, 490);
		class193_0.TabIndex = 104;
		button_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button_0.Image = Class309.smethod_64();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(938, 36);
		button_0.Name = Class84.smethod_0(-994262839);
		button_0.Size = new Size(123, 30);
		button_0.TabIndex = 105;
		button_0.Text = Class84.smethod_0(-994262787);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		linkLabel_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		linkLabel_0.AutoSize = true;
		linkLabel_0.Location = new Point(993, 570);
		linkLabel_0.Name = Class84.smethod_0(-994262811);
		linkLabel_0.Size = new Size(68, 13);
		linkLabel_0.TabIndex = 106;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class84.smethod_0(-994262761);
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(1054, 3);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 107;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		label_1.AutoSize = true;
		label_1.Location = new Point(21, 41);
		label_1.Name = Class84.smethod_0(-994278834);
		label_1.Size = new Size(573, 13);
		label_1.TabIndex = 127;
		label_1.Text = Class84.smethod_0(-994262725);
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1073, 592);
		Controls.Add(label_1);
		Controls.Add(pictureBox_0);
		Controls.Add(linkLabel_0);
		Controls.Add(button_0);
		Controls.Add(class193_0);
		Controls.Add(label_0);
		Name = Class84.smethod_0(-994262650);
		Text = Class84.smethod_0(-994259573);
		Load += GForm9_Load;
		Shown += GForm9_Shown;
		((ISupportInitialize)class193_0).EndInit();
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
