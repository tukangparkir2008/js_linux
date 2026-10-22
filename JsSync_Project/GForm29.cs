using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

public sealed class GForm29 : Form
{
	private static CookieContainer cookieContainer_0;

	private IContainer icontainer_0;

	private Label label_0;

	internal LinkLabel linkLabel_0;

	internal Label label_1;

	internal PictureBox pictureBox_0;

	internal LinkLabel linkLabel_1;

	internal Label label_2;

	internal PictureBox pictureBox_1;

	private PictureBox pictureBox_2;

	private LinkLabel linkLabel_2;

	private LinkLabel linkLabel_3;

	private LinkLabel linkLabel_4;

	private LinkLabel linkLabel_5;

	public GForm29()
	{
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

	private void GForm29_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void linkLabel_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start(Class84.smethod_0(-994305212));
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start(Class84.smethod_0(-994305169));
	}

	private void linkLabel_3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Class348.Class352.dateTime_0 = new DateTime(1970, 1, 1);
	}

	private void linkLabel_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Class348.Class352.string_5 = Class84.smethod_0(-994305147);
	}

	private void linkLabel_4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class293
			{
				Op = Class84.smethod_0(-994305103),
				SchoolId = Class84.smethod_0(-994305063)
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_17(), Class84.smethod_0(-994265316), data);
				GClass70 gClass = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
				if (gClass.Value == 1)
				{
					JsonConvert.DeserializeObject<Class265>(gClass.Data.ToString());
				}
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
		}
		catch (Exception)
		{
		}
	}

	private void linkLabel_5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new GClass58
			{
				Op = Class84.smethod_0(-994305067),
				SchoolId = Class348.Class352.string_0
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 gClass;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_15(), Class84.smethod_0(-994265316), data);
				gClass = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			if (gClass.Value == 1)
			{
				gClass.Data.ToString();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
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

	private void method_0()
	{
		label_0 = new Label();
		linkLabel_0 = new LinkLabel();
		label_1 = new Label();
		pictureBox_0 = new PictureBox();
		linkLabel_1 = new LinkLabel();
		label_2 = new Label();
		pictureBox_1 = new PictureBox();
		pictureBox_2 = new PictureBox();
		linkLabel_2 = new LinkLabel();
		linkLabel_3 = new LinkLabel();
		linkLabel_4 = new LinkLabel();
		linkLabel_5 = new LinkLabel();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)pictureBox_1).BeginInit();
		((ISupportInitialize)pictureBox_2).BeginInit();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994278767);
		label_0.Size = new Size(113, 17);
		label_0.TabIndex = 71;
		label_0.Text = Class84.smethod_0(-994305040);
		linkLabel_0.AutoSize = true;
		linkLabel_0.Font = new Font(Class84.smethod_0(-994305049), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		linkLabel_0.Location = new Point(78, 157);
		linkLabel_0.Name = Class84.smethod_0(-994305003);
		linkLabel_0.Size = new Size(207, 13);
		linkLabel_0.TabIndex = 79;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class84.smethod_0(-994305169);
		linkLabel_0.Visible = false;
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		label_1.AutoSize = true;
		label_1.Font = new Font(Class84.smethod_0(-994273712), 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_1.Location = new Point(77, 138);
		label_1.Name = Class84.smethod_0(-994278834);
		label_1.Size = new Size(208, 16);
		label_1.TabIndex = 78;
		label_1.Text = Class84.smethod_0(-994305018);
		label_1.Visible = false;
		pictureBox_0.Image = Class309.smethod_81();
		pictureBox_0.Location = new Point(21, 133);
		pictureBox_0.Name = Class84.smethod_0(-994304986);
		pictureBox_0.Size = new Size(50, 44);
		pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
		pictureBox_0.TabIndex = 77;
		pictureBox_0.TabStop = false;
		pictureBox_0.Visible = false;
		linkLabel_1.AutoSize = true;
		linkLabel_1.Font = new Font(Class84.smethod_0(-994305049), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		linkLabel_1.Location = new Point(78, 93);
		linkLabel_1.Name = Class84.smethod_0(-994304952);
		linkLabel_1.Size = new Size(124, 13);
		linkLabel_1.TabIndex = 76;
		linkLabel_1.TabStop = true;
		linkLabel_1.Text = Class84.smethod_0(-994305212);
		linkLabel_1.LinkClicked += linkLabel_1_LinkClicked;
		label_2.AutoSize = true;
		label_2.Font = new Font(Class84.smethod_0(-994273712), 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label_2.Location = new Point(77, 74);
		label_2.Name = Class84.smethod_0(-994304903);
		label_2.Size = new Size(302, 16);
		label_2.TabIndex = 75;
		label_2.Text = Class84.smethod_0(-994304905);
		pictureBox_1.Image = Class309.smethod_57();
		pictureBox_1.Location = new Point(24, 69);
		pictureBox_1.Name = Class84.smethod_0(-994304890);
		pictureBox_1.Size = new Size(44, 44);
		pictureBox_1.SizeMode = PictureBoxSizeMode.StretchImage;
		pictureBox_1.TabIndex = 74;
		pictureBox_1.TabStop = false;
		pictureBox_2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_2.Image = Class309.smethod_47();
		pictureBox_2.Location = new Point(911, -2);
		pictureBox_2.Name = Class84.smethod_0(-994304856);
		pictureBox_2.Size = new Size(76, 73);
		pictureBox_2.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_2.TabIndex = 80;
		pictureBox_2.TabStop = false;
		linkLabel_2.AutoSize = true;
		linkLabel_2.Location = new Point(445, 303);
		linkLabel_2.Name = Class84.smethod_0(-994304806);
		linkLabel_2.Size = new Size(97, 13);
		linkLabel_2.TabIndex = 91;
		linkLabel_2.TabStop = true;
		linkLabel_2.Text = Class84.smethod_0(-994304818);
		linkLabel_2.Visible = false;
		linkLabel_2.LinkClicked += linkLabel_2_LinkClicked;
		linkLabel_3.AutoSize = true;
		linkLabel_3.Location = new Point(445, 278);
		linkLabel_3.Name = Class84.smethod_0(-994304791);
		linkLabel_3.Size = new Size(81, 13);
		linkLabel_3.TabIndex = 90;
		linkLabel_3.TabStop = true;
		linkLabel_3.Text = Class84.smethod_0(-994304750);
		linkLabel_3.Visible = false;
		linkLabel_3.LinkClicked += linkLabel_3_LinkClicked;
		linkLabel_4.AutoSize = true;
		linkLabel_4.Location = new Point(21, 303);
		linkLabel_4.Name = Class84.smethod_0(-994304709);
		linkLabel_4.Size = new Size(66, 13);
		linkLabel_4.TabIndex = 93;
		linkLabel_4.TabStop = true;
		linkLabel_4.Text = Class84.smethod_0(-994304727);
		linkLabel_4.LinkClicked += linkLabel_4_LinkClicked;
		linkLabel_5.AutoSize = true;
		linkLabel_5.Location = new Point(21, 359);
		linkLabel_5.Name = Class84.smethod_0(-994304674);
		linkLabel_5.Size = new Size(125, 13);
		linkLabel_5.TabIndex = 94;
		linkLabel_5.TabStop = true;
		linkLabel_5.Text = Class84.smethod_0(-994304654);
		linkLabel_5.LinkClicked += linkLabel_5_LinkClicked;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(987, 595);
		Controls.Add(linkLabel_5);
		Controls.Add(linkLabel_4);
		Controls.Add(linkLabel_2);
		Controls.Add(linkLabel_3);
		Controls.Add(pictureBox_2);
		Controls.Add(linkLabel_0);
		Controls.Add(label_1);
		Controls.Add(pictureBox_0);
		Controls.Add(linkLabel_1);
		Controls.Add(label_2);
		Controls.Add(pictureBox_1);
		Controls.Add(label_0);
		Name = Class84.smethod_0(-994304621);
		Text = Class84.smethod_0(-994305040);
		Load += GForm29_Load;
		((ISupportInitialize)pictureBox_0).EndInit();
		((ISupportInitialize)pictureBox_1).EndInit();
		((ISupportInitialize)pictureBox_2).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
