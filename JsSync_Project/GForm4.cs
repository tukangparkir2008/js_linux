using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm4 : Form
{
	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private IContainer icontainer_0;

	private LinkLabel linkLabel_0;

	private LinkLabel linkLabel_1;

	private LinkLabel linkLabel_2;

	private PictureBox pictureBox_0;

	private PictureBox pictureBox_1;

	internal TextBox textBox_0;

	internal Label label_0;

	internal TextBox textBox_1;

	internal Button button_0;

	internal Label label_1;

	internal Button button_1;

	public GForm4(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gform17_1.method_0();
		method_3();
	}

	private void GForm4_Load(object sender, EventArgs e)
	{
	}

	private void GForm4_Shown(object sender, EventArgs e)
	{
		textBox_1.Focus();
	}

	private void GForm4_Paint(object sender, PaintEventArgs e)
	{
		ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.SteelBlue, 2, ButtonBorderStyle.Solid, Color.SteelBlue, 2, ButtonBorderStyle.Solid, Color.SteelBlue, 2, ButtonBorderStyle.Solid, Color.SteelBlue, 2, ButtonBorderStyle.Solid);
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		if (textBox_1.Text.Trim().Length != 0 && textBox_0.Text.Trim().Length != 0)
		{
			if (textBox_1.Text.Trim().ToLower().Equals(Class84.smethod_0(-994299758)))
			{
				method_2();
			}
			else
			{
				method_1();
			}
		}
	}

	private GClass70 method_0(MySqlConnection mySqlConnection_0)
	{
		try
		{
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection_0;
			mySqlCommand.CommandText = Class84.smethod_0(-994247438);
			mySqlCommand.ExecuteNonQuery();
			mySqlCommand.CommandText = Class84.smethod_0(-994247451);
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				throw new Exception(Class84.smethod_0(-994247276) + Class224.Class228.string_0 + Class84.smethod_0(-994263069) + Class224.Class228.string_1);
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
	}

	private void method_1()
	{
		Cursor = Cursors.WaitCursor;
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			GClass70 gClass = method_0(mySqlConnection);
			if (gClass.Value == -1)
			{
				Cursor = Cursors.Default;
				Class355.smethod_0(gClass.Text);
				return;
			}
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string format = Class84.smethod_0(-994299762);
			format = string.Format(format, textBox_1.Text.Trim(), textBox_0.Text.Trim());
			mySqlCommand.CommandText = format;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (!mySqlDataReader.Read())
			{
				Cursor = Cursors.Default;
				mySqlDataReader.Close();
				Class355.smethod_0(Class84.smethod_0(-994299505));
				return;
			}
			int int_ = Convert.ToInt32(mySqlDataReader[0]);
			int int_2 = Convert.ToInt32(mySqlDataReader[1]);
			string string_ = Convert.ToString(mySqlDataReader[2]);
			int num = Convert.ToInt32(mySqlDataReader[3]);
			int num2 = Convert.ToInt32(mySqlDataReader[4]);
			int num3 = Convert.ToInt32(mySqlDataReader[5]);
			mySqlDataReader.Close();
			if (num != 0 && num3 != 0 && num2 != 0)
			{
				format = Class84.smethod_0(-994299378);
				mySqlCommand.CommandText = format;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				List<Tuple<int, string>> list = new List<Tuple<int, string>>();
				while (mySqlDataReader.Read())
				{
					list.Add(new Tuple<int, string>(Convert.ToInt32(mySqlDataReader[0]), Convert.ToString(mySqlDataReader[1])));
				}
				mySqlDataReader.Close();
				gclass5_0.method_43(int_, textBox_1.Text.Trim(), string_, int_2, textBox_0.Text.Trim(), list);
				gform17_0.method_12();
				Cursor = Cursors.Default;
				textBox_1.Text = string.Empty;
				textBox_0.Text = string.Empty;
				Close();
			}
			else
			{
				Cursor = Cursors.Default;
				string text;
				if (num != 0)
				{
					if (num3 != 0)
					{
						text = ((num2 == 0) ? Class84.smethod_0(-994299396) : string.Empty);
					}
					else
					{
						text = Class84.smethod_0(-994257747);
					}
				}
				else
				{
					text = Class84.smethod_0(-994253701);
				}
				Class355.smethod_0(Class84.smethod_0(-994299412) + text + Class84.smethod_0(-994299366));
			}
		}
		catch (Exception ex)
		{
			Cursor = Cursors.Default;
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private void method_2()
	{
		Cursor = Cursors.WaitCursor;
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			GClass70 gClass = method_0(mySqlConnection);
			if (gClass.Value == -1)
			{
				Cursor = Cursors.Default;
				Class355.smethod_0(gClass.Text);
				return;
			}
			string format = Class84.smethod_0(-994261060);
			format = string.Format(format, textBox_0.Text.Trim());
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = format
			};
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				Cursor = Cursors.Default;
				Class355.smethod_0(Class84.smethod_0(-994299249));
				return;
			}
			format = Class84.smethod_0(-994299378);
			mySqlCommand.CommandText = format;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			List<Tuple<int, string>> list = new List<Tuple<int, string>>();
			while (mySqlDataReader.Read())
			{
				list.Add(new Tuple<int, string>(Convert.ToInt32(mySqlDataReader[0]), Convert.ToString(mySqlDataReader[1])));
			}
			mySqlDataReader.Close();
			gclass5_0.method_43(0, Class84.smethod_0(-994299758), Class84.smethod_0(-994299211), 0, textBox_0.Text.Trim(), list);
			gform17_0.method_12();
			textBox_1.Text = string.Empty;
			textBox_0.Text = string.Empty;
			Cursor = Cursors.Default;
			Close();
		}
		catch (Exception ex)
		{
			Cursor = Cursors.Default;
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void linkLabel_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		textBox_1.Text = Class84.smethod_0(-994299758);
		textBox_0.Text = Class84.smethod_0(-994247193);
	}

	private void linkLabel_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		textBox_1.Text = Class84.smethod_0(-994299169);
		textBox_0.Text = Class84.smethod_0(-994247193);
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		textBox_1.Text = Class84.smethod_0(-994299199);
		textBox_0.Text = Class84.smethod_0(-994247193);
	}

	private void button_1_Click(object sender, EventArgs e)
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

	private void method_3()
	{
		linkLabel_0 = new LinkLabel();
		linkLabel_1 = new LinkLabel();
		linkLabel_2 = new LinkLabel();
		pictureBox_0 = new PictureBox();
		pictureBox_1 = new PictureBox();
		textBox_0 = new TextBox();
		label_0 = new Label();
		textBox_1 = new TextBox();
		button_0 = new Button();
		label_1 = new Label();
		button_1 = new Button();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)pictureBox_1).BeginInit();
		SuspendLayout();
		linkLabel_0.AutoSize = true;
		linkLabel_0.Location = new Point(248, 209);
		linkLabel_0.Name = Class84.smethod_0(-994299149);
		linkLabel_0.Size = new Size(24, 13);
		linkLabel_0.TabIndex = 67;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class84.smethod_0(-994299164);
		linkLabel_0.Visible = false;
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		linkLabel_1.AutoSize = true;
		linkLabel_1.Location = new Point(248, 183);
		linkLabel_1.Name = Class84.smethod_0(-994305003);
		linkLabel_1.Size = new Size(25, 13);
		linkLabel_1.TabIndex = 66;
		linkLabel_1.TabStop = true;
		linkLabel_1.Text = Class84.smethod_0(-994299105);
		linkLabel_1.Visible = false;
		linkLabel_1.LinkClicked += linkLabel_1_LinkClicked;
		linkLabel_2.AutoSize = true;
		linkLabel_2.Location = new Point(207, 195);
		linkLabel_2.Name = Class84.smethod_0(-994260361);
		linkLabel_2.Size = new Size(35, 13);
		linkLabel_2.TabIndex = 65;
		linkLabel_2.TabStop = true;
		linkLabel_2.Text = Class84.smethod_0(-994299127);
		linkLabel_2.Visible = false;
		linkLabel_2.LinkClicked += linkLabel_2_LinkClicked;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(273, 7);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 64;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		pictureBox_1.ErrorImage = Class309.smethod_58();
		pictureBox_1.Image = Class309.smethod_59();
		pictureBox_1.Location = new Point(21, 12);
		pictureBox_1.Name = Class84.smethod_0(-994304986);
		pictureBox_1.Size = new Size(210, 39);
		pictureBox_1.TabIndex = 63;
		pictureBox_1.TabStop = false;
		textBox_0.BorderStyle = BorderStyle.FixedSingle;
		textBox_0.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_0.Location = new Point(21, 154);
		textBox_0.MaxLength = 100;
		textBox_0.Name = Class84.smethod_0(-994299131);
		textBox_0.PasswordChar = '?';
		textBox_0.Size = new Size(252, 26);
		textBox_0.TabIndex = 59;
		textBox_0.Tag = string.Empty;
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.DimGray;
		label_0.Location = new Point(17, 133);
		label_0.Name = Class84.smethod_0(-994278767);
		label_0.Size = new Size(69, 17);
		label_0.TabIndex = 62;
		label_0.Text = Class84.smethod_0(-994250745);
		textBox_1.BorderStyle = BorderStyle.FixedSingle;
		textBox_1.Font = new Font(Class84.smethod_0(-994278794), 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_1.Location = new Point(20, 88);
		textBox_1.MaxLength = 100;
		textBox_1.Name = Class84.smethod_0(-994299082);
		textBox_1.Size = new Size(253, 29);
		textBox_1.TabIndex = 58;
		textBox_1.Tag = string.Empty;
		button_0.Image = Class309.smethod_24();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(21, 195);
		button_0.Name = Class84.smethod_0(-994299102);
		button_0.Size = new Size(86, 27);
		button_0.TabIndex = 60;
		button_0.Text = Class84.smethod_0(-994299056);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		label_1.AutoSize = true;
		label_1.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_1.ForeColor = Color.DimGray;
		label_1.Location = new Point(16, 67);
		label_1.Name = Class84.smethod_0(-994299060);
		label_1.Size = new Size(43, 17);
		label_1.TabIndex = 61;
		label_1.Text = Class84.smethod_0(-994299056);
		button_1.Image = Class309.smethod_10();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(113, 195);
		button_1.Name = Class84.smethod_0(-994278087);
		button_1.Size = new Size(86, 27);
		button_1.TabIndex = 68;
		button_1.Text = Class84.smethod_0(-994278089);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(297, 240);
		Controls.Add(button_1);
		Controls.Add(linkLabel_0);
		Controls.Add(linkLabel_1);
		Controls.Add(linkLabel_2);
		Controls.Add(pictureBox_0);
		Controls.Add(pictureBox_1);
		Controls.Add(textBox_0);
		Controls.Add(label_0);
		Controls.Add(textBox_1);
		Controls.Add(button_0);
		Controls.Add(label_1);
		FormBorderStyle = FormBorderStyle.None;
		Name = Class84.smethod_0(-994299015);
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class84.smethod_0(-994299015);
		TopMost = true;
		Load += GForm4_Load;
		Shown += GForm4_Shown;
		Paint += GForm4_Paint;
		((ISupportInitialize)pictureBox_0).EndInit();
		((ISupportInitialize)pictureBox_1).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
