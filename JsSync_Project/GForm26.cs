using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm26 : Form
{
	public delegate void GDelegate8(int int_0, int int_1, string string_0, string string_1, string string_2, string string_3, Image image_0, string string_4);

	private MySqlConnection mySqlConnection_0;

	private MySqlCommand mySqlCommand_0;

	private List<GClass57> list_0;

	private readonly GDelegate8 gdelegate8_0;

	private readonly string string_0;

	private readonly bool bool_0;

	private IContainer icontainer_0;

	private Label label_0;

	private TextBox textBox_0;

	private ComboBox comboBox_0;

	private ComboBox comboBox_1;

	private Label label_1;

	private GClass69 gclass69_0;

	public GForm26(GDelegate8 gdelegate8_1, string string_1, bool bool_1)
	{
		method_9();
		gdelegate8_0 = gdelegate8_1;
		string_0 = string_1;
		bool_0 = bool_1;
	}

	public void method_0(int int_0, int int_1, string string_1)
	{
		comboBox_1.SelectedIndex = int_0;
		comboBox_0.SelectedIndex = int_1;
		textBox_0.Text = string_1;
	}

	public void method_1()
	{
		Text = Class84.smethod_0(-994305423);
		comboBox_0.SelectedIndex = 1;
		comboBox_0.Enabled = false;
		comboBox_1.SelectedIndex = 0;
		textBox_0.Focus();
	}

	public void method_2()
	{
		Text = Class84.smethod_0(-994305436);
		comboBox_0.SelectedIndex = 0;
		comboBox_0.Enabled = false;
		comboBox_1.SelectedIndex = 0;
		textBox_0.Focus();
	}

	private void method_3()
	{
		try
		{
			mySqlConnection_0 = new MySqlConnection(Class224.Class228.smethod_0());
			mySqlConnection_0.Open();
			mySqlCommand_0 = new MySqlCommand
			{
				Connection = mySqlConnection_0
			};
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_4()
	{
		method_7();
	}

	private void method_5()
	{
		if (mySqlConnection_0 != null)
		{
			mySqlConnection_0.Close();
		}
	}

	private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		gclass69_0.Items.Clear();
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		gclass69_0.Items.Clear();
	}

	private void textBox_0_KeyUp(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			method_7();
		}
	}

	private void method_6(string string_1, string string_2)
	{
		string text = string_2.ToLower();
		if (!(text == Class84.smethod_0(-994305387)))
		{
			if (!(text == Class84.smethod_0(-994305405)))
			{
				if (text == Class84.smethod_0(-994305360))
				{
					label_0.ForeColor = Color.Gray;
				}
			}
			else
			{
				label_0.ForeColor = Color.Red;
			}
		}
		else
		{
			label_0.ForeColor = Color.Blue;
		}
		label_0.Text = string_1;
	}

	private void method_7()
	{
		string text = textBox_0.Text.Trim();
		if (text.Length < 3)
		{
			method_6(Class84.smethod_0(-994305365), Class84.smethod_0(-994305360));
			return;
		}
		try
		{
			if (mySqlConnection_0 == null)
			{
				method_3();
			}
			if (comboBox_0.SelectedIndex == 0)
			{
				string string_ = ((comboBox_1.SelectedIndex == 0) ? Class84.smethod_0(-994275813) : Class84.smethod_0(-994275857));
				list_0 = Class124.smethod_3(text, string_, string_0);
			}
			else
			{
				string string_2 = ((comboBox_1.SelectedIndex == 0) ? Class84.smethod_0(-994276221) : Class84.smethod_0(-994276201));
				list_0 = Class124.smethod_4(text, string_2);
			}
			gclass69_0.Items.Clear();
			foreach (GClass57 item in list_0)
			{
				gclass69_0.Items.Add(item);
			}
			if (gclass69_0.Items.Count > 0)
			{
				gclass69_0.Focus();
			}
			else
			{
				textBox_0.Focus();
			}
			if (list_0.Count == 0)
			{
				method_6(Class84.smethod_0(-994305337), Class84.smethod_0(-994305360));
			}
			else
			{
				method_6(Class84.smethod_0(-994305310) + list_0.Count + Class84.smethod_0(-994305261), Class84.smethod_0(-994305387));
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_8()
	{
		try
		{
			if (gclass69_0.Items.Count != 0)
			{
				int selectedIndex = gclass69_0.SelectedIndex;
				string string_ = list_0[selectedIndex].string_0;
				string string_2 = list_0[selectedIndex].string_1;
				string string_3 = list_0[selectedIndex].string_3;
				Image image_ = list_0[selectedIndex].image_0;
				string string_4 = list_0[selectedIndex].string_2;
				gdelegate8_0(comboBox_1.SelectedIndex, comboBox_0.SelectedIndex, textBox_0.Text, string_, string_2, string_3, image_, string_4);
				if (bool_0)
				{
					Close();
				}
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void gclass69_0_KeyUp(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Escape)
		{
			textBox_0.Text = string.Empty;
			textBox_0.Focus();
			gclass69_0.Items.Clear();
		}
		if (e.KeyCode == Keys.Up && gclass69_0.SelectedIndex == 0)
		{
			textBox_0.Focus();
		}
		if (e.KeyCode == Keys.Return && gclass69_0.Items.Count > 0)
		{
			method_8();
		}
	}

	private void gclass69_0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		method_8();
	}

	private void GForm26_FormClosing(object sender, FormClosingEventArgs e)
	{
		method_5();
	}

	private void GForm26_Load(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_9()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm26));
		label_0 = new Label();
		textBox_0 = new TextBox();
		comboBox_0 = new ComboBox();
		comboBox_1 = new ComboBox();
		label_1 = new Label();
		gclass69_0 = new GClass69();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Location = new Point(13, 39);
		label_0.Name = Class84.smethod_0(-994278751);
		label_0.Size = new Size(16, 13);
		label_0.TabIndex = 31;
		label_0.Text = Class84.smethod_0(-994252256);
		textBox_0.Location = new Point(265, 12);
		textBox_0.Name = Class84.smethod_0(-994265496);
		textBox_0.Size = new Size(122, 20);
		textBox_0.TabIndex = 30;
		textBox_0.KeyUp += textBox_0_KeyUp;
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Items.AddRange(new object[2]
		{
			Class84.smethod_0(-994278876),
			Class84.smethod_0(-994278858)
		});
		comboBox_0.Location = new Point(152, 12);
		comboBox_0.Name = Class84.smethod_0(-994265446);
		comboBox_0.Size = new Size(104, 21);
		comboBox_0.TabIndex = 29;
		comboBox_0.SelectedIndexChanged += comboBox_0_SelectedIndexChanged;
		comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_1.FormattingEnabled = true;
		comboBox_1.Items.AddRange(new object[2]
		{
			Class84.smethod_0(-994276345),
			Class84.smethod_0(-994265459)
		});
		comboBox_1.Location = new Point(42, 12);
		comboBox_1.Name = Class84.smethod_0(-994265409);
		comboBox_1.Size = new Size(104, 21);
		comboBox_1.TabIndex = 28;
		comboBox_1.SelectedIndexChanged += comboBox_1_SelectedIndexChanged;
		label_1.AutoSize = true;
		label_1.Location = new Point(11, 15);
		label_1.Name = Class84.smethod_0(-994266638);
		label_1.Size = new Size(25, 13);
		label_1.TabIndex = 27;
		label_1.Text = Class84.smethod_0(-994278789);
		gclass69_0.DrawMode = DrawMode.OwnerDrawVariable;
		gclass69_0.FormattingEnabled = true;
		gclass69_0.Location = new Point(16, 55);
		gclass69_0.Name = Class84.smethod_0(-994305265);
		gclass69_0.Size = new Size(371, 342);
		gclass69_0.TabIndex = 32;
		gclass69_0.KeyUp += gclass69_0_KeyUp;
		gclass69_0.MouseDoubleClick += gclass69_0_MouseDoubleClick;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(398, 415);
		Controls.Add(gclass69_0);
		Controls.Add(label_0);
		Controls.Add(textBox_0);
		Controls.Add(comboBox_0);
		Controls.Add(comboBox_1);
		Controls.Add(label_1);
		Icon = (Icon)componentResourceManager.GetObject(Class84.smethod_0(-994278109));
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class84.smethod_0(-994305228);
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class84.smethod_0(-994305191);
		FormClosing += GForm26_FormClosing;
		Load += GForm26_Load;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
