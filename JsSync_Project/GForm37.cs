using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm37 : Form
{
	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private IContainer icontainer_0;

	private Label label_0;

	private GroupBox groupBox_0;

	private Button button_0;

	private TextBox textBox_0;

	private Label label_1;

	private CheckBox checkBox_0;

	private PictureBox pictureBox_0;

	private GroupBox groupBox_1;

	private Label label_2;

	private ComboBox comboBox_0;

	private Label label_3;

	private Button button_1;

	private GroupBox groupBox_2;

	private Label label_4;

	private Button button_2;

	public GForm37(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gform17_0.method_0();
		method_2();
	}

	public void method_0()
	{
		try
		{
			checkBox_0.Checked = Class224.Class226.bool_0;
			textBox_0.Text = Class224.Class226.string_2;
			string text = Convert.ToInt32(Class224.Class226.int_11 / 1000).ToString();
			comboBox_0.Text = text;
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		if (!checkBox_0.Checked)
		{
			Class224.Class226.bool_0 = false;
			Class224.Class226.string_2 = string.Empty;
			Class205.smethod_1();
			Class355.smethod_3(Class84.smethod_0(-994261260));
			return;
		}
		string text = textBox_0.Text.Trim();
		if (text.Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994261248));
			textBox_0.Focus();
			return;
		}
		if (!method_1(text))
		{
			Class355.smethod_0(Class84.smethod_0(-994261141));
			textBox_0.Focus();
			return;
		}
		Class224.Class226.bool_0 = true;
		Class224.Class226.string_2 = text;
		Class205.smethod_1();
		Class355.smethod_3(Class84.smethod_0(-994261260));
	}

	private bool method_1(string string_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string format = Class84.smethod_0(-994261060);
			format = string.Format(format, string_0);
			return Convert.ToInt32(new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = format
			}.ExecuteScalar()) != 0;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return false;
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private void GForm37_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void GForm37_Shown(object sender, EventArgs e)
	{
		groupBox_0.Enabled = gclass5_0.gclass6_0.method_6() == 0;
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		try
		{
			Class224.Class226.int_11 = Convert.ToInt32(comboBox_0.Text) * 1000;
			Class205.smethod_1();
			Class355.smethod_3(Class84.smethod_0(-994248655));
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		try
		{
			new GForm16().ShowDialog();
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

	private void method_2()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm37));
		label_0 = new Label();
		groupBox_0 = new GroupBox();
		button_0 = new Button();
		textBox_0 = new TextBox();
		label_1 = new Label();
		checkBox_0 = new CheckBox();
		pictureBox_0 = new PictureBox();
		groupBox_1 = new GroupBox();
		button_1 = new Button();
		label_3 = new Label();
		comboBox_0 = new ComboBox();
		label_2 = new Label();
		groupBox_2 = new GroupBox();
		label_4 = new Label();
		button_2 = new Button();
		groupBox_0.SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();
		groupBox_1.SuspendLayout();
		groupBox_2.SuspendLayout();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994278767);
		label_0.Size = new Size(82, 17);
		label_0.TabIndex = 51;
		label_0.Text = Class84.smethod_0(-994248629);
		groupBox_0.Controls.Add(button_0);
		groupBox_0.Controls.Add(textBox_0);
		groupBox_0.Controls.Add(label_1);
		groupBox_0.Controls.Add(checkBox_0);
		groupBox_0.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		groupBox_0.Location = new Point(24, 59);
		groupBox_0.Name = Class84.smethod_0(-994248580);
		groupBox_0.Size = new Size(727, 158);
		groupBox_0.TabIndex = 97;
		groupBox_0.TabStop = false;
		groupBox_0.Text = Class84.smethod_0(-994248594);
		button_0.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button_0.Image = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994248545));
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(29, 107);
		button_0.Name = Class84.smethod_0(-994248517);
		button_0.Size = new Size(150, 28);
		button_0.TabIndex = 54;
		button_0.Text = Class84.smethod_0(-994248543);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		textBox_0.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_0.Location = new Point(180, 62);
		textBox_0.Name = Class84.smethod_0(-994248501);
		textBox_0.PasswordChar = '?';
		textBox_0.Size = new Size(406, 26);
		textBox_0.TabIndex = 2;
		label_1.AutoSize = true;
		label_1.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_1.Location = new Point(26, 70);
		label_1.Name = Class84.smethod_0(-994256357);
		label_1.Size = new Size(148, 13);
		label_1.TabIndex = 1;
		label_1.Text = Class84.smethod_0(-994248463);
		checkBox_0.AutoSize = true;
		checkBox_0.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		checkBox_0.Location = new Point(29, 35);
		checkBox_0.Name = Class84.smethod_0(-994248428);
		checkBox_0.Size = new Size(416, 17);
		checkBox_0.TabIndex = 0;
		checkBox_0.Text = Class84.smethod_0(-994248442);
		checkBox_0.UseVisualStyleBackColor = true;
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(998, 3);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 98;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		groupBox_1.Controls.Add(button_1);
		groupBox_1.Controls.Add(label_3);
		groupBox_1.Controls.Add(comboBox_0);
		groupBox_1.Controls.Add(label_2);
		groupBox_1.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		groupBox_1.Location = new Point(24, 223);
		groupBox_1.Name = Class84.smethod_0(-994278480);
		groupBox_1.Size = new Size(727, 137);
		groupBox_1.TabIndex = 98;
		groupBox_1.TabStop = false;
		groupBox_1.Text = Class84.smethod_0(-994276257);
		button_1.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button_1.Image = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994248338));
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(29, 80);
		button_1.Name = Class84.smethod_0(-994248310);
		button_1.Size = new Size(150, 28);
		button_1.TabIndex = 55;
		button_1.Text = Class84.smethod_0(-994248543);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		label_3.AutoSize = true;
		label_3.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_3.Location = new Point(252, 37);
		label_3.Name = Class84.smethod_0(-994266638);
		label_3.Size = new Size(30, 13);
		label_3.TabIndex = 2;
		label_3.Text = Class84.smethod_0(-994248272);
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Items.AddRange(new object[5]
		{
			Class84.smethod_0(-994248276),
			Class84.smethod_0(-994248284),
			Class84.smethod_0(-994248228),
			Class84.smethod_0(-994248236),
			Class84.smethod_0(-994248244)
		});
		comboBox_0.Location = new Point(180, 32);
		comboBox_0.Name = Class84.smethod_0(-994248252);
		comboBox_0.Size = new Size(66, 24);
		comboBox_0.TabIndex = 1;
		label_2.AutoSize = true;
		label_2.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_2.Location = new Point(26, 37);
		label_2.Name = Class84.smethod_0(-994266659);
		label_2.Size = new Size(132, 13);
		label_2.TabIndex = 0;
		label_2.Text = Class84.smethod_0(-994248213);
		groupBox_2.Controls.Add(label_4);
		groupBox_2.Controls.Add(button_2);
		groupBox_2.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		groupBox_2.Location = new Point(24, 366);
		groupBox_2.Name = Class84.smethod_0(-994278161);
		groupBox_2.Size = new Size(727, 137);
		groupBox_2.TabIndex = 99;
		groupBox_2.TabStop = false;
		groupBox_2.Text = Class84.smethod_0(-994248179);
		label_4.AutoSize = true;
		label_4.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_4.Location = new Point(26, 33);
		label_4.Name = Class84.smethod_0(-994278834);
		label_4.Size = new Size(286, 13);
		label_4.TabIndex = 56;
		label_4.Text = Class84.smethod_0(-994248132);
		button_2.Font = new Font(Class84.smethod_0(-994278794), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button_2.Image = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994248068));
		button_2.ImageAlign = ContentAlignment.MiddleLeft;
		button_2.Location = new Point(29, 59);
		button_2.Name = Class84.smethod_0(-994248090);
		button_2.Size = new Size(150, 28);
		button_2.TabIndex = 55;
		button_2.Text = Class84.smethod_0(-994248054);
		button_2.TextAlign = ContentAlignment.MiddleRight;
		button_2.UseVisualStyleBackColor = true;
		button_2.Click += button_2_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1018, 576);
		Controls.Add(groupBox_2);
		Controls.Add(groupBox_1);
		Controls.Add(groupBox_0);
		Controls.Add(pictureBox_0);
		Controls.Add(label_0);
		Name = Class84.smethod_0(-994248009);
		Text = Class84.smethod_0(-994276257);
		Load += GForm37_Load;
		Shown += GForm37_Shown;
		groupBox_0.ResumeLayout(performLayout: false);
		groupBox_0.PerformLayout();
		((ISupportInitialize)pictureBox_0).EndInit();
		groupBox_1.ResumeLayout(performLayout: false);
		groupBox_1.PerformLayout();
		groupBox_2.ResumeLayout(performLayout: false);
		groupBox_2.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
