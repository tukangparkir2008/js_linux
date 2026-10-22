using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

public sealed class GForm19 : Form
{
	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private Class216 class216_0;

	private IContainer icontainer_0;

	private Button button_0;

	private Class193 class193_0;

	private PictureBox pictureBox_0;

	private Label label_0;

	private OpenFileDialog openFileDialog_0;

	private LinkLabel linkLabel_0;

	private Button button_1;

	public GForm19(GForm17 gform17_1, GClass5 gclass5_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gclass5_1;
		method_4();
		method_0();
	}

	private void method_0()
	{
		class216_0 = new Class216(class193_0, bool_0: false, bool_1: false);
		class216_0.method_2(Class84.smethod_0(-994250879), 80, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994250831), 170, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994250845), 170, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994250796), 80, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994250813), 170, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994250563), 100, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994250764), 100, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994250782), 100, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994254818), 180, bool_0: true);
		class216_0.method_2(Class84.smethod_0(-994254847), 100, bool_0: true);
	}

	private void GForm19_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private string method_1(DateTime dateTime_0)
	{
		try
		{
			int num = Convert.ToInt32((dateTime_0 - Class348.Class350.dateTime_0).TotalDays);
			return Class84.smethod_0(-994271858) + num + Class84.smethod_0(-994254800);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994254803), ex.Message, ex);
			return string.Empty;
		}
	}

	public string method_2(int int_0)
	{
		return int_0 switch
		{
			1 => Class84.smethod_0(-994254768), 
			2 => Class84.smethod_0(-994254781), 
			3 => Class84.smethod_0(-994254730), 
			4 => Class84.smethod_0(-994254695), 
			_ => Class84.smethod_0(-994254710), 
		};
	}

	public void method_3()
	{
		try
		{
			if (Class316.smethod_0() == null)
			{
				Class316.smethod_5();
			}
			class216_0.method_12();
			if (Class316.smethod_0().Rows.Count == 0)
			{
				return;
			}
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add(Class84.smethod_0(-994254662), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable.Columns.Add(Class84.smethod_0(-994254679), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable.Columns.Add(Class84.smethod_0(-994254626), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable.Columns.Add(Class84.smethod_0(-994254641), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable.Columns.Add(Class84.smethod_0(-994254595), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable.Columns.Add(Class84.smethod_0(-994254611), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable.Columns.Add(Class84.smethod_0(-994250764), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable.Columns.Add(Class84.smethod_0(-994254562), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable.Columns.Add(Class84.smethod_0(-994254591), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable.Columns.Add(Class84.smethod_0(-994254847), Type.GetType(Class84.smethod_0(-994276505)));
			foreach (DataRow row in Class316.smethod_0().Rows)
			{
				DateTime dateTime_ = Convert.ToDateTime(row[Class84.smethod_0(-994254591)]);
				string text = method_1(dateTime_);
				int num = Class159.smethod_0(row[Class84.smethod_0(-994254562)].ToString(), 1);
				DataRow dataRow2 = dataTable.NewRow();
				dataRow2[Class84.smethod_0(-994254662)] = row[Class84.smethod_0(-994254662)];
				dataRow2[Class84.smethod_0(-994254679)] = row[Class84.smethod_0(-994254679)];
				dataRow2[Class84.smethod_0(-994254626)] = row[Class84.smethod_0(-994254626)];
				dataRow2[Class84.smethod_0(-994254641)] = row[Class84.smethod_0(-994254641)];
				dataRow2[Class84.smethod_0(-994254595)] = row[Class84.smethod_0(-994254595)];
				dataRow2[Class84.smethod_0(-994254611)] = row[Class84.smethod_0(-994254611)];
				if (num != 1)
				{
					dataRow2[Class84.smethod_0(-994250764)] = Class84.smethod_0(-994254543);
					dataRow2[Class84.smethod_0(-994254562)] = method_2(num);
					dataRow2[Class84.smethod_0(-994254591)] = Convert.ToDateTime(row[Class84.smethod_0(-994254591)]).ToString(Class84.smethod_0(-994254559)) + Class84.smethod_0(-994263061) + text;
				}
				else
				{
					dataRow2[Class84.smethod_0(-994250764)] = Class84.smethod_0(-994254517);
					dataRow2[Class84.smethod_0(-994254562)] = method_2(num);
					dataRow2[Class84.smethod_0(-994254591)] = Class84.smethod_0(-994278690);
				}
				dataRow2[Class84.smethod_0(-994254847)] = row[Class84.smethod_0(-994254847)];
				dataTable.Rows.Add(dataRow2);
			}
			class216_0.method_9(dataTable);
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		try
		{
			openFileDialog_0.Filter = Class84.smethod_0(-994254469);
			openFileDialog_0.FileName = string.Empty;
			if (openFileDialog_0.ShowDialog() != DialogResult.Cancel && Class316.smethod_10(openFileDialog_0.FileName))
			{
				Class348.Class352.smethod_4();
				gform17_0.method_24();
				gform17_0.method_22();
				method_3();
				Class355.smethod_3(Class84.smethod_0(-994254443));
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (Class316.smethod_0().Rows.Count == 0 || Class355.smethod_1(Class84.smethod_0(-994254415)) == DialogResult.Cancel)
		{
			return;
		}
		try
		{
			Class316.smethod_11();
			class193_0.Rows.Clear();
			gform17_0.method_22();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		try
		{
			Process.Start(Class84.smethod_0(-994254389));
		}
		catch (Exception)
		{
		}
	}

	private void GForm19_Shown(object sender, EventArgs e)
	{
		button_1.Visible = gclass5_0.gclass6_0.method_6() == 0;
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

	private void method_4()
	{
		button_0 = new Button();
		pictureBox_0 = new PictureBox();
		label_0 = new Label();
		class193_0 = new Class193();
		openFileDialog_0 = new OpenFileDialog();
		linkLabel_0 = new LinkLabel();
		button_1 = new Button();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)class193_0).BeginInit();
		SuspendLayout();
		button_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button_0.Image = Class309.smethod_12();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(887, 24);
		button_0.Name = Class84.smethod_0(-994254324);
		button_0.Size = new Size(107, 31);
		button_0.TabIndex = 99;
		button_0.Text = Class84.smethod_0(-994254276);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(993, 4);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 97;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994278834);
		label_0.Size = new Size(52, 17);
		label_0.TabIndex = 96;
		label_0.Text = Class84.smethod_0(-994254303);
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(24, 61);
		class193_0.Name = Class84.smethod_0(-994278735);
		class193_0.Size = new Size(970, 479);
		class193_0.TabIndex = 98;
		linkLabel_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		linkLabel_0.AutoSize = true;
		linkLabel_0.Location = new Point(926, 554);
		linkLabel_0.Name = Class84.smethod_0(-994254241);
		linkLabel_0.Size = new Size(75, 13);
		linkLabel_0.TabIndex = 156;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class84.smethod_0(-994254268);
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		button_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button_1.Image = Class309.smethod_20();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(719, 24);
		button_1.Name = Class84.smethod_0(-994254229);
		button_1.Size = new Size(162, 31);
		button_1.TabIndex = 157;
		button_1.Text = Class84.smethod_0(-994254183);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1013, 586);
		Controls.Add(button_1);
		Controls.Add(linkLabel_0);
		Controls.Add(button_0);
		Controls.Add(class193_0);
		Controls.Add(pictureBox_0);
		Controls.Add(label_0);
		Name = Class84.smethod_0(-994254150);
		Text = Class84.smethod_0(-994254303);
		Load += GForm19_Load;
		Shown += GForm19_Shown;
		((ISupportInitialize)pictureBox_0).EndInit();
		((ISupportInitialize)class193_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
