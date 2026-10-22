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

public sealed class GForm7 : Form
{
	private readonly GForm12 gform12_0;

	private static CookieContainer cookieContainer_0;

	private IContainer icontainer_0;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private TextBox textBox_0;

	private Button button_0;

	private Button button_1;

	private LinkLabel linkLabel_0;

	private Label label_3;

	private TextBox textBox_1;

	public GForm7(GForm12 gform12_1)
	{
		gform12_0 = gform12_1;
		method_1();
	}

	public static CookieContainer smethod_0()
	{
		if (cookieContainer_0 == null)
		{
			cookieContainer_0 = new CookieContainer();
		}
		return cookieContainer_0;
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private bool method_0()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		try
		{
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.Transaction = mySqlTransaction;
			string commandText = Class84.smethod_0(-994307976);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994307942);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994307778);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994307628);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994307470);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994307310);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994307140);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994306980);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994306843);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994306687);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994306479);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994306309);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994306145);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994310091);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994309945);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994309751);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994309585);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994309425);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994309273);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994309059);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994308905);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = string.Concat(str1: textBox_0.Text.Trim().Replace('\'', '\''), str0: Class84.smethod_0(-994308749), str2: Class84.smethod_0(-994271698));
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			mySqlTransaction.Commit();
			return true;
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return false;
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		try
		{
			if (textBox_1.Text.Trim().Length != 5)
			{
				Class355.smethod_0(Class84.smethod_0(-994308627));
				textBox_0.Focus();
				return;
			}
			if (textBox_0.Text.Trim().Length < 10)
			{
				Class355.smethod_0(Class84.smethod_0(-994308549));
				textBox_0.Focus();
				return;
			}
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new GClass58
			{
				Op = Class84.smethod_0(-994308544),
				SchoolId = Class348.Class352.string_0,
				Data = textBox_1.Text.Trim()
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_15(), Class84.smethod_0(-994265316), data);
				GClass70 gClass = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
				if (gClass.Value != 1)
				{
					Class355.smethod_4(gClass.Text);
				}
				else if (method_0())
				{
					gform12_0.method_1();
					Close();
				}
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new GClass58
			{
				Op = Class84.smethod_0(-994308490),
				SchoolId = Class348.Class352.string_0,
				Data = Class84.smethod_0(-994308453)
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_15(), Class84.smethod_0(-994265316), data);
				Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6);
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
		}
		catch (Exception ex)
		{
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

	private void method_1()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm7));
		label_0 = new Label();
		label_1 = new Label();
		label_2 = new Label();
		textBox_0 = new TextBox();
		button_0 = new Button();
		button_1 = new Button();
		linkLabel_0 = new LinkLabel();
		label_3 = new Label();
		textBox_1 = new TextBox();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994278767);
		label_0.Size = new Size(296, 17);
		label_0.TabIndex = 65;
		label_0.Text = Class84.smethod_0(-994308472);
		label_1.Location = new Point(21, 52);
		label_1.Name = Class84.smethod_0(-994278834);
		label_1.Size = new Size(496, 45);
		label_1.TabIndex = 66;
		label_1.Text = Class84.smethod_0(-994308392);
		label_2.AutoSize = true;
		label_2.Location = new Point(21, 169);
		label_2.Name = Class84.smethod_0(-994266720);
		label_2.Size = new Size(187, 13);
		label_2.TabIndex = 67;
		label_2.Text = Class84.smethod_0(-994308208);
		textBox_0.Location = new Point(24, 185);
		textBox_0.Multiline = true;
		textBox_0.Name = Class84.smethod_0(-994266257);
		textBox_0.Size = new Size(493, 79);
		textBox_0.TabIndex = 2;
		button_0.Image = Class309.smethod_21();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(191, 285);
		button_0.Name = Class84.smethod_0(-994308182);
		button_0.Size = new Size(82, 34);
		button_0.TabIndex = 69;
		button_0.Text = Class84.smethod_0(-994308136);
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		button_1.Image = Class309.smethod_10();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(279, 285);
		button_1.Name = Class84.smethod_0(-994278087);
		button_1.Size = new Size(80, 34);
		button_1.TabIndex = 70;
		button_1.Text = Class84.smethod_0(-994278089);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		linkLabel_0.AutoSize = true;
		linkLabel_0.Location = new Point(48, 290);
		linkLabel_0.Name = Class84.smethod_0(-994260361);
		linkLabel_0.Size = new Size(55, 13);
		linkLabel_0.TabIndex = 71;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class84.smethod_0(-994260361);
		linkLabel_0.Visible = false;
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		label_3.AutoSize = true;
		label_3.Location = new Point(21, 111);
		label_3.Name = Class84.smethod_0(-994266659);
		label_3.Size = new Size(131, 13);
		label_3.TabIndex = 72;
		label_3.Text = Class84.smethod_0(-994308140);
		textBox_1.Font = new Font(Class84.smethod_0(-994278794), 16f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_1.Location = new Point(24, 127);
		textBox_1.MaxLength = 5;
		textBox_1.Name = Class84.smethod_0(-994308109);
		textBox_1.Size = new Size(134, 32);
		textBox_1.TabIndex = 1;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(551, 331);
		Controls.Add(textBox_1);
		Controls.Add(label_3);
		Controls.Add(linkLabel_0);
		Controls.Add(button_1);
		Controls.Add(button_0);
		Controls.Add(textBox_0);
		Controls.Add(label_2);
		Controls.Add(label_1);
		Controls.Add(label_0);
		Icon = (Icon)componentResourceManager.GetObject(Class84.smethod_0(-994278109));
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class84.smethod_0(-994308127);
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class84.smethod_0(-994304007);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
