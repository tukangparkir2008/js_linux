using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm18 : Form
{
	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private DataTable dataTable_0;

	private Class216 class216_0;

	private IContainer icontainer_0;

	private Label label_0;

	private Class193 class193_0;

	private Button button_0;

	private PictureBox pictureBox_0;

	public GForm18(GForm17 gform17_1, GClass5 gclass5_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gclass5_1;
		method_2();
		method_0();
	}

	private void method_0()
	{
		try
		{
			dataTable_0 = new DataTable();
			dataTable_0.Columns.Add(Class84.smethod_0(-994264162), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994277142), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994276441), Type.GetType(Class84.smethod_0(-994276505)));
			class216_0 = new Class216(class193_0, bool_0: false, bool_1: false);
			class216_0.method_2(Class84.smethod_0(-994312184), 80, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994312189), 300, bool_0: true);
			class216_0.method_8(Class84.smethod_0(-994276302), 100, new List<string>
			{
				Class84.smethod_0(-994312143),
				Class84.smethod_0(-994312146)
			});
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_1()
	{
		try
		{
			foreach (string key in Class224.Class225.dictionary_0.Keys)
			{
				DataRow dataRow = dataTable_0.NewRow();
				dataRow[Class84.smethod_0(-994264162)] = key;
				dataRow[Class84.smethod_0(-994277142)] = Class224.Class225.dictionary_0[key].string_0;
				dataRow[Class84.smethod_0(-994276441)] = ((Class224.Class225.dictionary_0[key].int_0 == 1) ? Class84.smethod_0(-994312143) : Class84.smethod_0(-994312146));
				dataTable_0.Rows.Add(dataRow);
			}
			class216_0.method_9(dataTable_0);
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void GForm18_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void GForm18_Shown(object sender, EventArgs e)
	{
		Class224.Class225.smethod_3();
		method_1();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
			return;
		}
		Cursor = Cursors.WaitCursor;
		button_0.Enabled = false;
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string format = Class84.smethod_0(-994312100);
			foreach (DataRow row in class216_0.method_16().Rows)
			{
				string arg = row[0].ToString();
				int num = (row[2].ToString().Equals(Class84.smethod_0(-994312143)) ? 1 : 0);
				mySqlCommand.CommandText = string.Format(format, arg, num);
				mySqlCommand.ExecuteNonQuery();
			}
			Cursor = Cursors.Default;
			button_0.Enabled = true;
			Class355.smethod_3(Class84.smethod_0(-994312056));
		}
		catch (Exception ex)
		{
			Cursor = Cursors.Default;
			button_0.Enabled = true;
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
		label_0 = new Label();
		class193_0 = new Class193();
		button_0 = new Button();
		pictureBox_0 = new PictureBox();
		((ISupportInitialize)class193_0).BeginInit();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994256787), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994266659);
		label_0.Size = new Size(239, 17);
		label_0.TabIndex = 71;
		label_0.Text = Class84.smethod_0(-994312022);
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(24, 62);
		class193_0.Name = Class84.smethod_0(-994311996);
		class193_0.Size = new Size(836, 417);
		class193_0.TabIndex = 91;
		button_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		button_0.Image = Class309.smethod_24();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(24, 493);
		button_0.Name = Class84.smethod_0(-994266730);
		button_0.Size = new Size(81, 33);
		button_0.TabIndex = 121;
		button_0.Text = Class84.smethod_0(-994266747);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(850, 3);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 122;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(872, 538);
		Controls.Add(pictureBox_0);
		Controls.Add(button_0);
		Controls.Add(class193_0);
		Controls.Add(label_0);
		Name = Class84.smethod_0(-994311948);
		Text = Class84.smethod_0(-994312022);
		Load += GForm18_Load;
		Shown += GForm18_Shown;
		((ISupportInitialize)class193_0).EndInit();
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
