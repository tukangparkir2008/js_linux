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

public sealed class GForm25 : Form
{
	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private MySqlConnection mySqlConnection_0;

	private MySqlTransaction mySqlTransaction_0;

	private bool bool_0;

	private static CookieContainer cookieContainer_0;

	private IContainer icontainer_0;

	private Label label_0;

	private TextBox textBox_0;

	private Button button_0;

	private PictureBox pictureBox_0;

	private Label label_1;

	public GForm25(GForm17 gform17_1, GClass5 gclass5_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gclass5_1;
		method_2();
	}

	public static CookieContainer smethod_0()
	{
		if (cookieContainer_0 == null)
		{
			cookieContainer_0 = new CookieContainer();
		}
		return cookieContainer_0;
	}

	private void GForm25_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void GForm25_Shown(object sender, EventArgs e)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = Class84.smethod_0(-994265388)
			}.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				textBox_0.Text = mySqlDataReader[0].ToString().Trim();
				bool_0 = true;
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

	private GClass70 method_0()
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class288
			{
				Op = Class84.smethod_0(-994265364)
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 result;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_14(), Class84.smethod_0(-994265316), data);
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

	private void method_1(string string_0)
	{
		if (!(string_0 == Class84.smethod_0(-994265321)))
		{
			if (string_0 == Class84.smethod_0(-994265342))
			{
				Cursor = Cursors.Default;
				button_0.Enabled = true;
				textBox_0.Enabled = true;
			}
		}
		else
		{
			Cursor = Cursors.WaitCursor;
			button_0.Enabled = false;
			textBox_0.Enabled = false;
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
		}
		else if (textBox_0.Text.Trim().Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994265282));
			textBox_0.Focus();
		}
		else
		{
			if (Class355.smethod_1(Class84.smethod_0(-994265261)) == DialogResult.Cancel)
			{
				return;
			}
			if (Class348.Class352.string_0.Trim().Length == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994278342));
				return;
			}
			string text = textBox_0.Text.Trim();
			if (text.Length > Class224.Class226.int_14)
			{
				Class355.smethod_0(string.Format(Class84.smethod_0(-994265240), Class224.Class226.int_14));
				return;
			}
			method_1(Class84.smethod_0(-994265321));
			GClass70 gClass2 = Class194.smethod_0();
			if (gClass2.Value < 0)
			{
				method_1(Class84.smethod_0(-994265342));
				Class355.smethod_0(Class84.smethod_0(-994265213) + gClass2.Text);
				return;
			}
			GClass70 gClass3 = method_0();
			if (gClass3.Value >= 0)
			{
				string transactionId = gClass3.Data.ToString();
				mySqlConnection_0 = new MySqlConnection(Class224.Class228.smethod_0());
				try
				{
					mySqlConnection_0.Open();
					mySqlTransaction_0 = mySqlConnection_0.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
					MySqlCommand mySqlCommand = new MySqlCommand();
					mySqlCommand.Connection = mySqlConnection_0;
					mySqlCommand.Transaction = mySqlTransaction_0;
					mySqlCommand.CommandText = (bool_0 ? Class84.smethod_0(-994265116) : Class84.smethod_0(-994265123));
					mySqlCommand.Parameters.Add(Class84.smethod_0(-994269130), MySqlDbType.VarChar);
					mySqlCommand.Parameters[Class84.smethod_0(-994269130)].Value = textBox_0.Text.Trim();
					mySqlCommand.ExecuteNonQuery();
					var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class288
					{
						SchoolId = Class348.Class352.string_0,
						Op = (bool_0 ? Class84.smethod_0(-994269101) : Class84.smethod_0(-994269147)),
						TransactionId = transactionId,
						Content = text
					}), Class320.int_5, 10000);
					NameValueCollection data = new NameValueCollection { { name, value } };
					Class139 @class = new Class139(smethod_0());
					GClass70 gClass4;
					try
					{
						byte[] bytes = @class.UploadValues(Class272.smethod_14(), Class84.smethod_0(-994265316), data);
						gClass4 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
					}
					finally
					{
						((IDisposable)@class).Dispose();
					}
					method_1(Class84.smethod_0(-994265342));
					if (gClass4.Value == 1)
					{
						mySqlTransaction_0?.Commit();
						bool_0 = true;
						Class355.smethod_3(Class84.smethod_0(-994269118));
					}
					else
					{
						mySqlTransaction_0?.Rollback();
						Class355.smethod_0(Class84.smethod_0(-994265213) + gClass4.Text);
					}
					return;
				}
				catch (Exception ex)
				{
					method_1(Class84.smethod_0(-994265342));
					mySqlTransaction_0?.Rollback();
					mySqlConnection_0.Close();
					Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
					return;
				}
			}
			method_1(Class84.smethod_0(-994265342));
			Class355.smethod_0(Class84.smethod_0(-994265213) + gClass3.Text);
		}
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

	private void method_2()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm25));
		label_0 = new Label();
		textBox_0 = new TextBox();
		button_0 = new Button();
		pictureBox_0 = new PictureBox();
		label_1 = new Label();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Margin = new Padding(4, 0, 4, 0);
		label_0.Name = Class84.smethod_0(-994278767);
		label_0.Size = new Size(122, 17);
		label_0.TabIndex = 54;
		label_0.Text = Class84.smethod_0(-994269030);
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		textBox_0.Location = new Point(23, 77);
		textBox_0.Margin = new Padding(4);
		textBox_0.Multiline = true;
		textBox_0.Name = Class84.smethod_0(-994269054);
		textBox_0.ScrollBars = ScrollBars.Both;
		textBox_0.Size = new Size(958, 321);
		textBox_0.TabIndex = 55;
		textBox_0.Text = componentResourceManager.GetString(Class84.smethod_0(-994269006));
		button_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		button_0.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button_0.Image = Class309.smethod_24();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(24, 407);
		button_0.Name = Class84.smethod_0(-994266730);
		button_0.Size = new Size(81, 39);
		button_0.TabIndex = 123;
		button_0.Text = Class84.smethod_0(-994266747);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(1002, 3);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 124;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		label_1.AutoSize = true;
		label_1.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_1.Location = new Point(21, 42);
		label_1.Name = Class84.smethod_0(-994278834);
		label_1.Size = new Size(790, 13);
		label_1.TabIndex = 127;
		label_1.Text = Class84.smethod_0(-994269017);
		AutoScaleDimensions = new SizeF(9f, 19f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1022, 482);
		Controls.Add(label_1);
		Controls.Add(pictureBox_0);
		Controls.Add(button_0);
		Controls.Add(textBox_0);
		Controls.Add(label_0);
		Font = new Font(Class84.smethod_0(-994268815), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		Margin = new Padding(4);
		Name = Class84.smethod_0(-994268832);
		Text = Class84.smethod_0(-994269030);
		Load += GForm25_Load;
		Shown += GForm25_Shown;
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
