using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

public sealed class GForm12 : Form
{
	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private int int_0;

	private IContainer icontainer_0;

	private Label label_0;

	private GClass11 gclass11_0;

	private Button button_0;

	private LinkLabel linkLabel_0;

	private LinkLabel linkLabel_1;

	private LinkLabel linkLabel_2;

	private Button button_1;

	public GForm12(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gform17_1.method_0();
		method_4();
	}

	public void method_0(GEnum0 genum0_0, string string_0, string string_1, string string_2)
	{
		try
		{
			if (InvokeRequired)
			{
				GDelegate7 method = method_0;
				Invoke(method, genum0_0, string_0, string_1, string_2);
				return;
			}
			if (int_0 > 5000)
			{
				gclass11_0.Items.Clear();
				int_0 = 0;
			}
			gclass11_0.Items.Add(new GClass33(genum0_0, string_0, DateTime.Now.ToString(Class84.smethod_0(-994304362)), string_1, string_2));
			gclass11_0.SelectedIndex = gclass11_0.Items.Count - 1;
			int_0++;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		try
		{
			if (!Class348.Class349.bool_0)
			{
				method_0(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994304379));
				return;
			}
			if (!Class348.Class351.bool_0)
			{
				Class355.smethod_4(Class84.smethod_0(-994304294));
				return;
			}
			button_0.Enabled = false;
			new Class268(gclass5_0).method_2(method_2, bool_4: true);
			new Class264(gclass5_0).method_3(method_3, bool_2: true);
		}
		catch (Exception ex)
		{
			button_0.Enabled = true;
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_1()
	{
		new Class268(gclass5_0).method_2(method_2, bool_4: true);
	}

	private void method_2()
	{
		try
		{
			if (InvokeRequired)
			{
				GDelegate9 method = method_2;
				Invoke(method);
			}
			else
			{
				button_0.Enabled = true;
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_3()
	{
		try
		{
			if (InvokeRequired)
			{
				GDelegate9 method = method_3;
				Invoke(method);
			}
			else
			{
				button_0.Enabled = true;
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void GForm12_Load(object sender, EventArgs e)
	{
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (Class355.smethod_1(Class84.smethod_0(-994304275)) != DialogResult.Cancel)
		{
			linkLabel_0.Enabled = false;
			gclass11_0.Items.Clear();
			linkLabel_0.Enabled = true;
		}
	}

	private void linkLabel_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (!Class348.Class349.bool_0)
		{
			method_0(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994304379));
		}
		else if (!Class348.Class351.bool_0)
		{
			Class355.smethod_4(Class84.smethod_0(-994304294));
		}
		else
		{
			new GForm7(this).ShowDialog();
		}
	}

	private void linkLabel_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass58 gclass58_ = new GClass58
		{
			SchoolId = Class348.Class352.string_0,
			Op = Class84.smethod_0(-994304201),
			Data = Class84.smethod_0(-994304173)
		};
		gclass5_0.method_24(gclass58_);
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		if (!Class348.Class349.bool_0)
		{
			method_0(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994304379));
		}
		else if (!Class348.Class351.bool_0)
		{
			Class355.smethod_4(Class84.smethod_0(-994304294));
		}
		else
		{
			new GForm7(this).ShowDialog();
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

	private void method_4()
	{
		label_0 = new Label();
		gclass11_0 = new GClass11();
		button_0 = new Button();
		linkLabel_0 = new LinkLabel();
		linkLabel_1 = new LinkLabel();
		linkLabel_2 = new LinkLabel();
		button_1 = new Button();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994278767);
		label_0.Size = new Size(144, 17);
		label_0.TabIndex = 64;
		label_0.Text = Class84.smethod_0(-994304180);
		gclass11_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gclass11_0.DrawMode = DrawMode.OwnerDrawVariable;
		gclass11_0.FormattingEnabled = true;
		gclass11_0.Location = new Point(128, 69);
		gclass11_0.Name = Class84.smethod_0(-994304140);
		gclass11_0.Size = new Size(1037, 563);
		gclass11_0.TabIndex = 73;
		button_0.Image = Class309.smethod_21();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(12, 69);
		button_0.Name = Class84.smethod_0(-994304159);
		button_0.Size = new Size(102, 50);
		button_0.TabIndex = 93;
		button_0.Text = Class84.smethod_0(-994304109);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		linkLabel_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		linkLabel_0.AutoSize = true;
		linkLabel_0.Location = new Point(1067, 643);
		linkLabel_0.Name = Class84.smethod_0(-994304065);
		linkLabel_0.Size = new Size(98, 13);
		linkLabel_0.TabIndex = 94;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class84.smethod_0(-994304083);
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		linkLabel_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		linkLabel_1.AutoSize = true;
		linkLabel_1.Location = new Point(9, 358);
		linkLabel_1.Name = Class84.smethod_0(-994304056);
		linkLabel_1.Size = new Size(97, 13);
		linkLabel_1.TabIndex = 95;
		linkLabel_1.TabStop = true;
		linkLabel_1.Text = Class84.smethod_0(-994304007);
		linkLabel_1.Visible = false;
		linkLabel_1.LinkClicked += linkLabel_1_LinkClicked;
		linkLabel_2.AutoSize = true;
		linkLabel_2.Location = new Point(21, 272);
		linkLabel_2.Name = Class84.smethod_0(-994304030);
		linkLabel_2.Size = new Size(58, 13);
		linkLabel_2.TabIndex = 96;
		linkLabel_2.TabStop = true;
		linkLabel_2.Text = Class84.smethod_0(-994308075);
		linkLabel_2.Visible = false;
		linkLabel_2.LinkClicked += linkLabel_2_LinkClicked;
		button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		button_1.Image = Class309.smethod_28();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(12, 587);
		button_1.Name = Class84.smethod_0(-994308089);
		button_1.Size = new Size(102, 45);
		button_1.TabIndex = 97;
		button_1.Text = Class84.smethod_0(-994304007);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1187, 665);
		Controls.Add(button_1);
		Controls.Add(linkLabel_2);
		Controls.Add(linkLabel_1);
		Controls.Add(linkLabel_0);
		Controls.Add(button_0);
		Controls.Add(gclass11_0);
		Controls.Add(label_0);
		Name = Class84.smethod_0(-994308051);
		Text = Class84.smethod_0(-994308016);
		Load += GForm12_Load;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
