using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm21 : Form
{
	private enum Enum7
	{

	}

	public delegate void GDelegate6(int int_0, int int_1, string string_0, string string_1, string string_2, string string_3, Image image_0, string string_4);

	private List<GClass57> list_0;

	private readonly GDelegate6 gdelegate6_0;

	private readonly string string_0;

	private readonly bool bool_0;

	private bool bool_1;

	private IContainer icontainer_0;

	private TextBox textBox_0;

	private ComboBox comboBox_0;

	private ComboBox comboBox_1;

	private Label label_0;

	private Label label_1;

	private GClass69 gclass69_0;

	private TabControl tabControl_0;

	private TabPage tabPage_0;

	private TabPage tabPage_1;

	private TabPage tabPage_2;

	private Label label_2;

	private ComboBox comboBox_2;

	private Label label_3;

	private ComboBox comboBox_3;

	private Panel panel_0;

	private ComboBox comboBox_4;

	private Label label_4;

	private Button button_0;

	private Panel panel_1;

	private Button button_1;

	private Label label_5;

	private ComboBox comboBox_5;

	private Label label_6;

	private ComboBox comboBox_6;

	private Label label_7;

	public GForm21(GDelegate6 gdelegate6_1, string string_1, bool bool_2)
	{
		method_15();
		gdelegate6_0 = gdelegate6_1;
		string_0 = (string_1.Equals(Class84.smethod_0(-994248828)) ? method_0() : string_1);
		bool_0 = bool_2;
		method_3((Enum7)2);
		method_2();
		method_1();
	}

	private string method_0()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string text = string.Empty;
			string commandText = Class84.smethod_0(-994299031);
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = commandText
			}.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				if (!text.Equals(string.Empty))
				{
					text += Class84.smethod_0(-994279022);
				}
				text += string.Format(Class84.smethod_0(-994298919), mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			return text;
		}
		catch (Exception ex)
		{
			Class125.smethod_0(string.Format(Class84.smethod_0(-994247990), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name), ex.Message, ex);
			return string.Empty;
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private void method_1()
	{
		try
		{
			bool_1 = true;
			comboBox_6.Items.Clear();
			if (string_0.IndexOf(Class84.smethod_0(-994279022), StringComparison.Ordinal) == 0)
			{
				ComboBox.ObjectCollection items = comboBox_6.Items;
				GClass2 gClass = new GClass2();
				gClass.method_3(string_0);
				gClass.method_1(string_0.Replace(Class84.smethod_0(-994271698), string.Empty));
				items.Add(gClass);
			}
			else
			{
				ComboBox.ObjectCollection items2 = comboBox_6.Items;
				GClass2 gClass2 = new GClass2();
				gClass2.method_3(string_0);
				gClass2.method_1(Class84.smethod_0(-994298923));
				items2.Add(gClass2);
				string[] array = string_0.Split(',');
				foreach (string text in array)
				{
					ComboBox.ObjectCollection items3 = comboBox_6.Items;
					GClass2 gClass3 = new GClass2();
					gClass3.method_3(text);
					gClass3.method_1(text.Replace(Class84.smethod_0(-994271698), string.Empty));
					items3.Add(gClass3);
				}
			}
			if (comboBox_6.Items.Count != 0)
			{
				comboBox_6.SelectedIndex = 0;
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_0(Class84.smethod_0(-994298882), ex.Message, ex);
		}
		finally
		{
			bool_1 = false;
		}
	}

	private void method_2()
	{
		bool_1 = true;
		comboBox_5.Items.Clear();
		comboBox_5.Items.Add(Class84.smethod_0(-994298870));
		comboBox_5.Items.Add(Class84.smethod_0(-994274768));
		comboBox_5.Items.Add(Class84.smethod_0(-994298832));
		comboBox_5.SelectedIndex = 0;
		bool_1 = false;
	}

	private void method_3(Enum7 enum7_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand_ = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			if ((Enum7)1 < enum7_0)
			{
				method_4(mySqlCommand_);
			}
			if ((Enum7)0 < enum7_0)
			{
				method_5(mySqlCommand_);
			}
			method_6(mySqlCommand_);
		}
		catch (Exception ex)
		{
			Class125.smethod_0(Class84.smethod_0(-994298845), ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private void method_4(MySqlCommand mySqlCommand_0)
	{
		try
		{
			bool_1 = true;
			comboBox_3.Items.Clear();
			string[] array = string_0.Replace(Class84.smethod_0(-994271698), string.Empty).Split(',');
			foreach (string text in array)
			{
				ComboBox.ObjectCollection items = comboBox_3.Items;
				GClass2 gClass = new GClass2();
				gClass.method_3(text);
				gClass.method_1(text);
				items.Add(gClass);
			}
			if (comboBox_3.Items.Count != 0)
			{
				comboBox_3.SelectedIndex = 0;
			}
		}
		finally
		{
			bool_1 = false;
		}
	}

	private void method_5(MySqlCommand mySqlCommand_0)
	{
		if (comboBox_3.Items.Count == 0 || bool_1)
		{
			return;
		}
		MySqlDataReader mySqlDataReader = null;
		try
		{
			bool_1 = true;
			comboBox_2.Items.Clear();
			string arg = comboBox_3.Text;
			mySqlCommand_0.CommandText = string.Format(Class84.smethod_0(-994298754), arg);
			mySqlDataReader = mySqlCommand_0.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				int num = Convert.ToInt32(mySqlDataReader[0]);
				string string_ = mySqlDataReader[1].ToString();
				ComboBox.ObjectCollection items = comboBox_2.Items;
				GClass2 gClass = new GClass2();
				gClass.method_3(num);
				gClass.method_1(string_);
				items.Add(gClass);
			}
			if (comboBox_2.Items.Count != 0)
			{
				comboBox_2.SelectedIndex = 0;
			}
		}
		finally
		{
			mySqlDataReader?.Close();
			bool_1 = false;
		}
	}

	private void method_6(MySqlCommand mySqlCommand_0)
	{
		if (comboBox_3.Items.Count == 0 || comboBox_2.Items.Count == 0 || bool_1)
		{
			return;
		}
		MySqlDataReader mySqlDataReader = null;
		try
		{
			bool_1 = true;
			comboBox_4.Items.Clear();
			string arg = comboBox_3.Text;
			int num = ((GClass2)comboBox_2.SelectedItem).method_4();
			string format = Class84.smethod_0(-994298606);
			format = string.Format(format, arg, num);
			mySqlCommand_0.CommandText = format;
			mySqlDataReader = mySqlCommand_0.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				int num2 = Convert.ToInt32(mySqlDataReader[0]);
				string string_ = mySqlDataReader[1].ToString();
				ComboBox.ObjectCollection items = comboBox_4.Items;
				GClass2 gClass = new GClass2();
				gClass.method_3(num2);
				gClass.method_1(string_);
				items.Add(gClass);
			}
			if (comboBox_4.Items.Count != 0)
			{
				comboBox_4.SelectedIndex = 0;
			}
		}
		finally
		{
			mySqlDataReader?.Close();
			bool_1 = false;
		}
	}

	public void method_7(int int_0, int int_1, string string_1)
	{
		comboBox_1.SelectedIndex = int_0;
		comboBox_0.SelectedIndex = int_1;
		textBox_0.Text = string_1;
	}

	public void method_8()
	{
		Text = Class84.smethod_0(-994305423);
		tabPage_0.Text = Class84.smethod_0(-994305423);
		panel_0.Enabled = false;
		panel_1.Enabled = true;
		comboBox_0.SelectedIndex = 1;
		comboBox_0.Enabled = false;
		comboBox_1.SelectedIndex = 0;
		textBox_0.Focus();
	}

	public void method_9()
	{
		Text = Class84.smethod_0(-994305436);
		tabPage_0.Text = Class84.smethod_0(-994305436);
		panel_0.Enabled = true;
		panel_1.Enabled = false;
		comboBox_0.SelectedIndex = 0;
		comboBox_0.Enabled = false;
		comboBox_1.SelectedIndex = 0;
		textBox_0.Focus();
	}

	public void method_10()
	{
		method_12();
	}

	private void GForm21_Load(object sender, EventArgs e)
	{
	}

	private void textBox_0_KeyUp(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			method_12();
		}
	}

	private void method_11(string string_1, string string_2)
	{
		string text = string_2.ToLower();
		if (!(text == Class84.smethod_0(-994305387)))
		{
			if (!(text == Class84.smethod_0(-994305405)))
			{
				if (text == Class84.smethod_0(-994305360))
				{
					label_1.ForeColor = Color.Gray;
				}
			}
			else
			{
				label_1.ForeColor = Color.Red;
			}
		}
		else
		{
			label_1.ForeColor = Color.Blue;
		}
		label_1.Text = string_1;
	}

	private void method_12()
	{
		if (comboBox_6.Items.Count == 0)
		{
			return;
		}
		string text = textBox_0.Text.Trim();
		if (text.Length < 3)
		{
			method_11(Class84.smethod_0(-994305365), Class84.smethod_0(-994305360));
			return;
		}
		try
		{
			if (comboBox_0.SelectedIndex == 0)
			{
				string string_ = ((GClass2)comboBox_6.SelectedItem).method_5();
				string string_2 = ((comboBox_1.SelectedIndex == 0) ? Class84.smethod_0(-994275813) : Class84.smethod_0(-994275857));
				list_0 = Class124.smethod_3(text, string_2, string_);
			}
			else
			{
				string string_3 = ((comboBox_1.SelectedIndex == 0) ? Class84.smethod_0(-994276221) : Class84.smethod_0(-994276201));
				list_0 = Class124.smethod_4(text, string_3);
			}
			method_13();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(Class84.smethod_0(-994298379), ex.Message, ex);
		}
	}

	private void method_13()
	{
		try
		{
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
				method_11(Class84.smethod_0(-994298347), Class84.smethod_0(-994305360));
			}
			else
			{
				method_11(Class84.smethod_0(-994305310) + list_0.Count + Class84.smethod_0(-994305261), Class84.smethod_0(-994305387));
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_0(Class84.smethod_0(-994298319), ex.Message, ex);
		}
	}

	private void GForm21_FormClosing(object sender, FormClosingEventArgs e)
	{
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
			method_14();
		}
	}

	private void method_14()
	{
		if (gclass69_0.Items.Count == 0)
		{
			return;
		}
		int selectedIndex = gclass69_0.SelectedIndex;
		if (selectedIndex >= 0 && selectedIndex < list_0.Count)
		{
			string string_ = list_0[selectedIndex].string_0;
			string string_2 = list_0[selectedIndex].string_1;
			string string_3 = list_0[selectedIndex].string_3;
			Image image_ = list_0[selectedIndex].image_0;
			string string_4 = list_0[selectedIndex].string_2;
			int int_ = ((!list_0[selectedIndex].string_4.Equals(Class84.smethod_0(-994257743))) ? 1 : 0);
			gdelegate6_0(comboBox_1.SelectedIndex, int_, textBox_0.Text, string_, string_2, string_3, image_, string_4);
			if (bool_0)
			{
				Close();
			}
		}
	}

	private void gclass69_0_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		method_14();
	}

	private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		label_1.Text = string.Empty;
		gclass69_0.Items.Clear();
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		label_1.Text = string.Empty;
		gclass69_0.Items.Clear();
	}

	private void GForm21_Shown(object sender, EventArgs e)
	{
		textBox_0.Focus();
	}

	private void comboBox_3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			label_1.Text = string.Empty;
			gclass69_0.Items.Clear();
			method_3((Enum7)1);
		}
	}

	private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			label_1.Text = string.Empty;
			gclass69_0.Items.Clear();
			method_3((Enum7)0);
		}
	}

	private void comboBox_4_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			label_1.Text = string.Empty;
			gclass69_0.Items.Clear();
		}
	}

	private void comboBox_5_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			label_1.Text = string.Empty;
			gclass69_0.Items.Clear();
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		if (comboBox_4.Items.Count == 0)
		{
			return;
		}
		try
		{
			int int_ = ((GClass2)comboBox_4.SelectedItem).method_4();
			list_0 = Class124.smethod_5(int_);
			method_13();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(Class84.smethod_0(-994298295), ex.Message, ex);
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		try
		{
			string text = comboBox_5.Text;
			list_0 = Class124.smethod_6(text);
			method_13();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(Class84.smethod_0(-994298295), ex.Message, ex);
		}
	}

	private void comboBox_6_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			label_1.Text = string.Empty;
			gclass69_0.Items.Clear();
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

	private void method_15()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm21));
		textBox_0 = new TextBox();
		comboBox_0 = new ComboBox();
		comboBox_1 = new ComboBox();
		label_0 = new Label();
		label_1 = new Label();
		gclass69_0 = new GClass69();
		tabControl_0 = new TabControl();
		tabPage_0 = new TabPage();
		tabPage_1 = new TabPage();
		panel_0 = new Panel();
		button_0 = new Button();
		comboBox_2 = new ComboBox();
		comboBox_4 = new ComboBox();
		label_2 = new Label();
		label_4 = new Label();
		comboBox_3 = new ComboBox();
		label_3 = new Label();
		tabPage_2 = new TabPage();
		panel_1 = new Panel();
		button_1 = new Button();
		label_5 = new Label();
		comboBox_5 = new ComboBox();
		label_6 = new Label();
		comboBox_6 = new ComboBox();
		label_7 = new Label();
		tabControl_0.SuspendLayout();
		tabPage_0.SuspendLayout();
		tabPage_1.SuspendLayout();
		panel_0.SuspendLayout();
		tabPage_2.SuspendLayout();
		panel_1.SuspendLayout();
		SuspendLayout();
		textBox_0.BorderStyle = BorderStyle.FixedSingle;
		textBox_0.Location = new Point(83, 69);
		textBox_0.Name = Class84.smethod_0(-994265496);
		textBox_0.Size = new Size(214, 20);
		textBox_0.TabIndex = 19;
		textBox_0.KeyUp += textBox_0_KeyUp;
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Items.AddRange(new object[2]
		{
			Class84.smethod_0(-994278876),
			Class84.smethod_0(-994278858)
		});
		comboBox_0.Location = new Point(193, 42);
		comboBox_0.Name = Class84.smethod_0(-994265446);
		comboBox_0.Size = new Size(104, 21);
		comboBox_0.TabIndex = 18;
		comboBox_0.SelectedIndexChanged += comboBox_0_SelectedIndexChanged;
		comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_1.FormattingEnabled = true;
		comboBox_1.Items.AddRange(new object[2]
		{
			Class84.smethod_0(-994276345),
			Class84.smethod_0(-994265459)
		});
		comboBox_1.Location = new Point(83, 42);
		comboBox_1.Name = Class84.smethod_0(-994265409);
		comboBox_1.Size = new Size(104, 21);
		comboBox_1.TabIndex = 17;
		comboBox_1.SelectedIndexChanged += comboBox_1_SelectedIndexChanged;
		label_0.AutoSize = true;
		label_0.Location = new Point(52, 45);
		label_0.Name = Class84.smethod_0(-994266638);
		label_0.Size = new Size(25, 13);
		label_0.TabIndex = 16;
		label_0.Text = Class84.smethod_0(-994278789);
		label_1.AutoSize = true;
		label_1.Location = new Point(13, 159);
		label_1.Name = Class84.smethod_0(-994278751);
		label_1.Size = new Size(16, 13);
		label_1.TabIndex = 20;
		label_1.Text = Class84.smethod_0(-994252256);
		gclass69_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gclass69_0.DrawMode = DrawMode.OwnerDrawVariable;
		gclass69_0.FormattingEnabled = true;
		gclass69_0.Location = new Point(12, 176);
		gclass69_0.Name = Class84.smethod_0(-994305265);
		gclass69_0.Size = new Size(460, 369);
		gclass69_0.TabIndex = 21;
		gclass69_0.KeyUp += gclass69_0_KeyUp;
		gclass69_0.MouseDoubleClick += gclass69_0_MouseDoubleClick;
		tabControl_0.Controls.Add(tabPage_0);
		tabControl_0.Controls.Add(tabPage_1);
		tabControl_0.Controls.Add(tabPage_2);
		tabControl_0.Location = new Point(12, 12);
		tabControl_0.Name = Class84.smethod_0(-994298269);
		tabControl_0.SelectedIndex = 0;
		tabControl_0.Size = new Size(464, 135);
		tabControl_0.TabIndex = 22;
		tabPage_0.Controls.Add(label_7);
		tabPage_0.Controls.Add(label_6);
		tabPage_0.Controls.Add(comboBox_6);
		tabPage_0.Controls.Add(comboBox_0);
		tabPage_0.Controls.Add(label_0);
		tabPage_0.Controls.Add(comboBox_1);
		tabPage_0.Controls.Add(textBox_0);
		tabPage_0.Location = new Point(4, 22);
		tabPage_0.Name = Class84.smethod_0(-994298219);
		tabPage_0.Padding = new Padding(3);
		tabPage_0.Size = new Size(456, 109);
		tabPage_0.TabIndex = 0;
		tabPage_0.Text = Class84.smethod_0(-994305191);
		tabPage_0.UseVisualStyleBackColor = true;
		tabPage_1.Controls.Add(panel_0);
		tabPage_1.Location = new Point(4, 22);
		tabPage_1.Name = Class84.smethod_0(-994298236);
		tabPage_1.Padding = new Padding(3);
		tabPage_1.Size = new Size(456, 109);
		tabPage_1.TabIndex = 1;
		tabPage_1.Text = Class84.smethod_0(-994298189);
		tabPage_1.UseVisualStyleBackColor = true;
		panel_0.Controls.Add(button_0);
		panel_0.Controls.Add(comboBox_2);
		panel_0.Controls.Add(comboBox_4);
		panel_0.Controls.Add(label_2);
		panel_0.Controls.Add(label_4);
		panel_0.Controls.Add(comboBox_3);
		panel_0.Controls.Add(label_3);
		panel_0.Location = new Point(6, 5);
		panel_0.Name = Class84.smethod_0(-994298203);
		panel_0.Size = new Size(424, 98);
		panel_0.TabIndex = 6;
		button_0.Location = new Point(341, 32);
		button_0.Name = Class84.smethod_0(-994298157);
		button_0.Size = new Size(62, 28);
		button_0.TabIndex = 6;
		button_0.Text = Class84.smethod_0(-994277847);
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_2.FormattingEnabled = true;
		comboBox_2.Location = new Point(93, 39);
		comboBox_2.Name = Class84.smethod_0(-994304396);
		comboBox_2.Size = new Size(121, 21);
		comboBox_2.TabIndex = 3;
		comboBox_2.SelectedIndexChanged += comboBox_2_SelectedIndexChanged;
		comboBox_4.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_4.FormattingEnabled = true;
		comboBox_4.Location = new Point(93, 66);
		comboBox_4.Name = Class84.smethod_0(-994298170);
		comboBox_4.Size = new Size(185, 21);
		comboBox_4.TabIndex = 5;
		comboBox_4.SelectedIndexChanged += comboBox_4_SelectedIndexChanged;
		label_2.AutoSize = true;
		label_2.Location = new Point(22, 15);
		label_2.Name = Class84.smethod_0(-994278834);
		label_2.Size = new Size(65, 13);
		label_2.TabIndex = 0;
		label_2.Text = Class84.smethod_0(-994264227);
		label_4.AutoSize = true;
		label_4.Location = new Point(54, 69);
		label_4.Name = Class84.smethod_0(-994266720);
		label_4.Size = new Size(33, 13);
		label_4.TabIndex = 4;
		label_4.Text = Class84.smethod_0(-994278020);
		comboBox_3.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_3.FormattingEnabled = true;
		comboBox_3.Location = new Point(93, 12);
		comboBox_3.Name = Class84.smethod_0(-994264242);
		comboBox_3.Size = new Size(185, 21);
		comboBox_3.TabIndex = 1;
		comboBox_3.SelectedIndexChanged += comboBox_3_SelectedIndexChanged;
		label_3.AutoSize = true;
		label_3.Location = new Point(44, 42);
		label_3.Name = Class84.smethod_0(-994278767);
		label_3.Size = new Size(43, 13);
		label_3.TabIndex = 2;
		label_3.Text = Class84.smethod_0(-994256485);
		tabPage_2.Controls.Add(panel_1);
		tabPage_2.Location = new Point(4, 22);
		tabPage_2.Name = Class84.smethod_0(-994298124);
		tabPage_2.Size = new Size(456, 109);
		tabPage_2.TabIndex = 2;
		tabPage_2.Text = Class84.smethod_0(-994298141);
		tabPage_2.UseVisualStyleBackColor = true;
		panel_1.Controls.Add(button_1);
		panel_1.Controls.Add(label_5);
		panel_1.Controls.Add(comboBox_5);
		panel_1.Location = new Point(3, 6);
		panel_1.Name = Class84.smethod_0(-994298089);
		panel_1.Size = new Size(429, 100);
		panel_1.TabIndex = 0;
		button_1.Location = new Point(339, 29);
		button_1.Name = Class84.smethod_0(-994298105);
		button_1.Size = new Size(62, 28);
		button_1.TabIndex = 9;
		button_1.Text = Class84.smethod_0(-994277847);
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		label_5.AutoSize = true;
		label_5.Location = new Point(58, 37);
		label_5.Name = Class84.smethod_0(-994266659);
		label_5.Size = new Size(43, 13);
		label_5.TabIndex = 7;
		label_5.Text = Class84.smethod_0(-994298068);
		comboBox_5.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_5.FormattingEnabled = true;
		comboBox_5.Location = new Point(107, 34);
		comboBox_5.Name = Class84.smethod_0(-994298022);
		comboBox_5.Size = new Size(185, 21);
		comboBox_5.TabIndex = 8;
		comboBox_5.SelectedIndexChanged += comboBox_5_SelectedIndexChanged;
		label_6.AutoSize = true;
		label_6.Location = new Point(12, 19);
		label_6.Name = Class84.smethod_0(-994266614);
		label_6.Size = new Size(65, 13);
		label_6.TabIndex = 20;
		label_6.Text = Class84.smethod_0(-994264227);
		comboBox_6.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_6.FormattingEnabled = true;
		comboBox_6.Location = new Point(83, 16);
		comboBox_6.Name = Class84.smethod_0(-994298039);
		comboBox_6.Size = new Size(214, 21);
		comboBox_6.TabIndex = 21;
		comboBox_6.SelectedIndexChanged += comboBox_6_SelectedIndexChanged;
		label_7.AutoSize = true;
		label_7.Location = new Point(18, 71);
		label_7.Name = Class84.smethod_0(-994266391);
		label_7.Size = new Size(59, 13);
		label_7.TabIndex = 22;
		label_7.Text = Class84.smethod_0(-994298000);
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(484, 553);
		Controls.Add(tabControl_0);
		Controls.Add(gclass69_0);
		Controls.Add(label_1);
		FormBorderStyle = FormBorderStyle.FixedSingle;
		Icon = (Icon)componentResourceManager.GetObject(Class84.smethod_0(-994278109));
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class84.smethod_0(-994305228);
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class84.smethod_0(-994298015);
		FormClosing += GForm21_FormClosing;
		Load += GForm21_Load;
		Shown += GForm21_Shown;
		tabControl_0.ResumeLayout(performLayout: false);
		tabPage_0.ResumeLayout(performLayout: false);
		tabPage_0.PerformLayout();
		tabPage_1.ResumeLayout(performLayout: false);
		panel_0.ResumeLayout(performLayout: false);
		panel_0.PerformLayout();
		tabPage_2.ResumeLayout(performLayout: false);
		panel_1.ResumeLayout(performLayout: false);
		panel_1.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
