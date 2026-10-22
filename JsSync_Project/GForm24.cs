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

public sealed class GForm24 : Form
{
	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private readonly GForm9 gform9_0;

	private MySqlConnection mySqlConnection_0;

	private MySqlTransaction mySqlTransaction_0;

	private bool bool_0;

	private string string_0 = string.Empty;

	private static CookieContainer cookieContainer_0;

	private IContainer icontainer_0;

	private TextBox textBox_0;

	private Button button_0;

	private Button button_1;

	private Label label_0;

	private Label label_1;

	private TextBox textBox_1;

	public GForm24(GForm17 gform17_1, GForm9 gform9_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gform17_1.method_0();
		gform9_0 = gform9_1;
		method_5();
	}

	public static CookieContainer smethod_0()
	{
		if (cookieContainer_0 == null)
		{
			cookieContainer_0 = new CookieContainer();
		}
		return cookieContainer_0;
	}

	public void method_0(string string_1)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string commandText = Class84.smethod_0(-994260209) + string_1 + Class84.smethod_0(-994271698);
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = commandText
			}.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				textBox_0.Text = mySqlDataReader[Class84.smethod_0(-994260157)].ToString();
				textBox_1.Text = mySqlDataReader[Class84.smethod_0(-994260111)].ToString();
				bool_0 = true;
				string_0 = string_1;
			}
			else
			{
				Class355.smethod_0(Class84.smethod_0(-994260114));
				Close();
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

	private void button_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		if (textBox_0.Text.Trim().Length != 0 && textBox_1.Text.Trim().Length != 0)
		{
			if (textBox_0.Text.Trim().Length < 10)
			{
				Class355.smethod_0(Class84.smethod_0(-994260086));
				textBox_0.Focus();
			}
			if (Class348.Class352.string_0.Trim().Length == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994278342));
			}
			else if (!Class256.smethod_1(textBox_1.Text.Trim()))
			{
				Class355.smethod_0(Class84.smethod_0(-994260006));
				textBox_1.Focus();
			}
			else if (bool_0)
			{
				method_3();
			}
			else
			{
				method_4();
			}
		}
	}

	private void method_1(string string_1)
	{
		if (!(string_1 == Class84.smethod_0(-994265321)))
		{
			if (string_1 == Class84.smethod_0(-994265342))
			{
				Cursor = Cursors.Default;
				button_1.Enabled = true;
			}
		}
		else
		{
			Cursor = Cursors.WaitCursor;
			button_1.Enabled = false;
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

	private void method_3()
	{
		if (Class348.Class352.string_0.Trim().Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994278342));
			return;
		}
		string text = textBox_0.Text.Trim();
		string text2 = textBox_1.Text.Trim();
		method_1(Class84.smethod_0(-994265321));
		GClass70 gClass = Class194.smethod_0();
		if (gClass.Value < 0)
		{
			method_1(Class84.smethod_0(-994265342));
			Class355.smethod_0(Class84.smethod_0(-994259974) + gClass.Text);
			return;
		}
		GClass70 gClass2 = method_2();
		if (gClass2.Value < 0)
		{
			method_1(Class84.smethod_0(-994265342));
			Class355.smethod_0(Class84.smethod_0(-994259937) + gClass2.Text);
			return;
		}
		string transactionId = gClass2.Data.ToString();
		mySqlConnection_0 = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection_0.Open();
			mySqlTransaction_0 = mySqlConnection_0.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection_0;
			mySqlCommand.Transaction = mySqlTransaction_0;
			mySqlCommand.CommandText = Class84.smethod_0(-994259915);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994259818), MySqlDbType.VarChar);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994259833), MySqlDbType.VarChar);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994259786), MySqlDbType.Int32);
			mySqlCommand.Parameters[Class84.smethod_0(-994259818)].Value = string_0;
			mySqlCommand.Parameters[Class84.smethod_0(-994259833)].Value = text;
			mySqlCommand.Parameters[Class84.smethod_0(-994259786)].Value = text2;
			mySqlCommand.ExecuteNonQuery();
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class218
			{
				SchoolId = Class348.Class352.string_0,
				Op = Class84.smethod_0(-994270647),
				TransactionId = transactionId,
				IdRunText = string_0,
				RunText = text,
				Urutan = text2
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 gClass3;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_12(), Class84.smethod_0(-994265316), data);
				gClass3 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			method_1(Class84.smethod_0(-994265342));
			if (gClass3.Value == 1)
			{
				mySqlTransaction_0?.Commit();
				gform9_0.method_5();
				Close();
			}
			else
			{
				mySqlTransaction_0?.Rollback();
				Class355.smethod_0(Class84.smethod_0(-994259937) + gClass3.Text);
			}
		}
		catch (Exception ex)
		{
			method_1(Class84.smethod_0(-994265342));
			mySqlTransaction_0?.Rollback();
			mySqlConnection_0.Close();
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_4()
	{
		if (Class348.Class352.string_0.Trim().Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994278342));
			return;
		}
		string text = textBox_0.Text.Trim();
		string text2 = textBox_1.Text.Trim();
		method_1(Class84.smethod_0(-994265321));
		GClass70 gClass = Class194.smethod_0();
		if (gClass.Value < 0)
		{
			method_1(Class84.smethod_0(-994265342));
			Class355.smethod_0(Class84.smethod_0(-994259974) + gClass.Text);
			return;
		}
		GClass70 gClass2 = method_2();
		if (gClass2.Value < 0)
		{
			method_1(Class84.smethod_0(-994265342));
			Class355.smethod_0(Class84.smethod_0(-994259937) + gClass2.Text);
			return;
		}
		string transactionId = gClass2.Data.ToString();
		mySqlConnection_0 = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection_0.Open();
			mySqlTransaction_0 = mySqlConnection_0.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection_0,
				Transaction = mySqlTransaction_0
			};
			string format = Class84.smethod_0(-994259804);
			string empty = string.Empty;
			int num = 0;
			do
			{
				empty = Class211.smethod_1(10);
				mySqlCommand.CommandText = string.Format(format, empty);
			}
			while (Convert.ToInt32(mySqlCommand.ExecuteScalar()) != 0);
			format = Class84.smethod_0(-994259739);
			mySqlCommand.CommandText = format;
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994259818), MySqlDbType.VarChar);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994259833), MySqlDbType.VarChar);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994269814), MySqlDbType.VarChar);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994259786), MySqlDbType.Int32);
			mySqlCommand.Parameters[Class84.smethod_0(-994259818)].Value = empty;
			mySqlCommand.Parameters[Class84.smethod_0(-994259833)].Value = text;
			mySqlCommand.Parameters[Class84.smethod_0(-994269814)].Value = ((gclass5_0.gclass6_0.method_6() == 0) ? null : gclass5_0.gclass6_0.method_2());
			mySqlCommand.Parameters[Class84.smethod_0(-994259786)].Value = text2;
			mySqlCommand.ExecuteNonQuery();
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class218
			{
				SchoolId = Class348.Class352.string_0,
				Op = Class84.smethod_0(-994270626),
				TransactionId = transactionId,
				IdRunText = empty,
				RunText = text,
				Urutan = text2
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 gClass3;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_12(), Class84.smethod_0(-994265316), data);
				gClass3 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			method_1(Class84.smethod_0(-994265342));
			if (gClass3.Value == 1)
			{
				mySqlTransaction_0?.Commit();
				gform9_0.method_5();
				Close();
			}
			else
			{
				mySqlTransaction_0?.Rollback();
				Class355.smethod_0(Class84.smethod_0(-994259974) + gClass3.Text);
			}
		}
		catch (Exception ex)
		{
			method_1(Class84.smethod_0(-994265342));
			mySqlTransaction_0?.Rollback();
			mySqlConnection_0.Close();
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
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

	private void method_5()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm24));
		textBox_0 = new TextBox();
		button_0 = new Button();
		button_1 = new Button();
		label_0 = new Label();
		label_1 = new Label();
		textBox_1 = new TextBox();
		SuspendLayout();
		textBox_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_0.Location = new Point(23, 35);
		textBox_0.MaxLength = 255;
		textBox_0.Multiline = true;
		textBox_0.Name = Class84.smethod_0(-994259557);
		textBox_0.Size = new Size(358, 57);
		textBox_0.TabIndex = 1;
		button_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		button_0.Image = Class309.smethod_10();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(205, 153);
		button_0.Name = Class84.smethod_0(-994278087);
		button_0.Size = new Size(69, 26);
		button_0.TabIndex = 4;
		button_0.Text = Class84.smethod_0(-994278089);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		button_1.Image = Class309.smethod_24();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(130, 153);
		button_1.Name = Class84.smethod_0(-994266730);
		button_1.Size = new Size(69, 26);
		button_1.TabIndex = 3;
		button_1.Text = Class84.smethod_0(-994266747);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		label_0.AutoSize = true;
		label_0.Location = new Point(20, 19);
		label_0.Name = Class84.smethod_0(-994278834);
		label_0.Size = new Size(71, 13);
		label_0.TabIndex = 124;
		label_0.Text = Class84.smethod_0(-994259573);
		label_1.AutoSize = true;
		label_1.Location = new Point(17, 108);
		label_1.Name = Class84.smethod_0(-994278767);
		label_1.Size = new Size(39, 13);
		label_1.TabIndex = 125;
		label_1.Text = Class84.smethod_0(-994259522);
		textBox_1.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_1.Location = new Point(62, 105);
		textBox_1.MaxLength = 3;
		textBox_1.Name = Class84.smethod_0(-994259541);
		textBox_1.Size = new Size(50, 23);
		textBox_1.TabIndex = 2;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(405, 191);
		Controls.Add(textBox_1);
		Controls.Add(label_1);
		Controls.Add(label_0);
		Controls.Add(button_0);
		Controls.Add(button_1);
		Controls.Add(textBox_0);
		Icon = (Icon)componentResourceManager.GetObject(Class84.smethod_0(-994278109));
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class84.smethod_0(-994259494);
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class84.smethod_0(-994259573);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
