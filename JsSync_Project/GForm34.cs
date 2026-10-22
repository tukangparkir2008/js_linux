using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm34 : Form
{
	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private DataTable dataTable_0;

	private Class216 class216_0;

	private IContainer icontainer_0;

	private PictureBox pictureBox_0;

	private Label label_0;

	private Class193 class193_0;

	private Label label_1;

	private LinkLabel linkLabel_0;

	public GForm34(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gform17_1.method_0();
		method_3();
		method_0();
	}

	private void GForm34_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void method_0()
	{
		try
		{
			dataTable_0 = new DataTable();
			dataTable_0.Columns.Add(Class84.smethod_0(-994264162), Type.GetType(Class84.smethod_0(-994276372)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994264169), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994264135), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994264137), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994264155), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994264107), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994264128), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994264067), Type.GetType(Class84.smethod_0(-994276505)));
			class216_0 = new Class216(class193_0, bool_0: false, bool_1: false);
			class216_0.method_4();
			class216_0.method_4();
			class216_0.method_4();
			class216_0.method_2(Class84.smethod_0(-994264086), 250, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994264040), 250, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994264056), 200, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994264061), 250, bool_0: true);
			class216_0.method_7(Class84.smethod_0(-994264016), 70);
			class216_0.method_1(7, method_1);
			class193_0.Columns[Class84.smethod_0(-994264086)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
			class193_0.Columns[Class84.smethod_0(-994264086)].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			class193_0.Columns[Class84.smethod_0(-994264040)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
			class193_0.Columns[Class84.smethod_0(-994264040)].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			class193_0.Columns[Class84.smethod_0(-994264056)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
			class193_0.Columns[Class84.smethod_0(-994264056)].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			class193_0.Columns[Class84.smethod_0(-994264061)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
			class193_0.Columns[Class84.smethod_0(-994264061)].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			class193_0.Columns[Class84.smethod_0(-994264016)].DefaultCellStyle.Padding = new Padding(2, 2, 2, 70);
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_1(int int_0, DataGridViewRow dataGridViewRow_0)
	{
		GClass70 gClass = Class316.smethod_12();
		if (gClass.Value != 1)
		{
			Class355.smethod_0(gClass.Text);
			return;
		}
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		try
		{
			if (Class355.smethod_1(Class84.smethod_0(-994264019)) != DialogResult.Cancel)
			{
				mySqlConnection.Open();
				mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
				dataGridViewRow_0.Cells[0].Value.ToString();
				string text = dataGridViewRow_0.Cells[1].Value.ToString();
				string text2 = dataGridViewRow_0.Cells[2].Value.ToString();
				string text3 = dataGridViewRow_0.Cells[6].Value.ToString().Trim().Replace('\'', '`');
				MySqlCommand mySqlCommand = new MySqlCommand
				{
					Connection = mySqlConnection,
					Transaction = mySqlTransaction
				};
				string commandText = Class84.smethod_0(-994263999) + gclass5_0.gclass6_0.method_4() + Class84.smethod_0(-994263882);
				mySqlCommand.CommandText = commandText;
				mySqlCommand.ExecuteNonQuery();
				commandText = Class84.smethod_0(-994263842) + text3 + Class84.smethod_0(-994263833) + text + Class84.smethod_0(-994263795) + text2 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = commandText;
				mySqlCommand.ExecuteNonQuery();
				commandText = Class84.smethod_0(-994263757) + text + Class84.smethod_0(-994263795) + text2 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = commandText;
				mySqlCommand.ExecuteNonQuery();
				mySqlTransaction.Commit();
				method_2();
			}
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private void method_2()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = Class84.smethod_0(-994263686)
			});
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			dataTable_0.Rows.Clear();
			class216_0.method_12();
			foreach (DataRow row in dataTable.Rows)
			{
				int num = Convert.ToInt32(row[Class84.smethod_0(-994264162)]);
				row[Class84.smethod_0(-994263532)].ToString();
				string text = row[Class84.smethod_0(-994264135)].ToString();
				string text2 = row[Class84.smethod_0(-994276501)].ToString();
				row[Class84.smethod_0(-994263550)].ToString();
				string value = row[Class84.smethod_0(-994264128)].ToString();
				string string_ = row[Class84.smethod_0(-994263493)].ToString();
				string value2 = string.Empty;
				Class326 @class = Class326.smethod_0(text);
				if (@class != null)
				{
					List<string> list_ = new List<string>();
					if (@class.method_3(mySqlConnection, ref list_))
					{
						value2 = list_[1] + Class84.smethod_0(-994273716) + list_[0] + Class84.smethod_0(-994263511);
						value2 = value2 + list_[3] + Class84.smethod_0(-994273716) + list_[5];
					}
				}
				string empty = string.Empty;
				Class341 class2 = Class341.smethod_0(mySqlConnection, string_);
				empty = ((class2 == null) ? Class84.smethod_0(-994263519) : (class2.string_1 + Class84.smethod_0(-994263511) + class2.string_6 + Class84.smethod_0(-994263511) + class2.string_2 + Class84.smethod_0(-994263511) + class2.string_3));
				empty = empty + Class84.smethod_0(-994263475) + row[Class84.smethod_0(-994263532)];
				string empty2 = string.Empty;
				Class341 class3 = Class341.smethod_0(mySqlConnection, text2);
				empty2 = ((class3 == null) ? Class84.smethod_0(-994263519) : (class3.string_1 + Class84.smethod_0(-994263511) + class3.string_6 + Class84.smethod_0(-994263511) + class3.string_2 + Class84.smethod_0(-994263511) + class3.string_3));
				DataRow dataRow2 = dataTable_0.NewRow();
				dataRow2[Class84.smethod_0(-994264162)] = num;
				dataRow2[Class84.smethod_0(-994264169)] = text2;
				dataRow2[Class84.smethod_0(-994264135)] = text;
				dataRow2[Class84.smethod_0(-994264137)] = empty;
				dataRow2[Class84.smethod_0(-994264155)] = empty2;
				dataRow2[Class84.smethod_0(-994264107)] = value2;
				dataRow2[Class84.smethod_0(-994264128)] = value;
				dataRow2[Class84.smethod_0(-994264067)] = Class84.smethod_0(-994264067);
				dataTable_0.Rows.Add(dataRow2);
			}
			class216_0.method_9(dataTable_0);
			class216_0.method_18(100);
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void GForm34_Shown(object sender, EventArgs e)
	{
		method_2();
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel_0.Enabled = false;
		method_2();
		linkLabel_0.Enabled = true;
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
		pictureBox_0 = new PictureBox();
		label_0 = new Label();
		label_1 = new Label();
		linkLabel_0 = new LinkLabel();
		class193_0 = new Class193();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)class193_0).BeginInit();
		SuspendLayout();
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(972, 4);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 99;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994278767);
		label_0.Size = new Size(120, 17);
		label_0.TabIndex = 100;
		label_0.Text = Class84.smethod_0(-994263448);
		label_1.AutoSize = true;
		label_1.Location = new Point(21, 42);
		label_1.Name = Class84.smethod_0(-994278834);
		label_1.Size = new Size(295, 13);
		label_1.TabIndex = 102;
		label_1.Text = Class84.smethod_0(-994263394);
		linkLabel_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		linkLabel_0.AutoSize = true;
		linkLabel_0.Location = new Point(903, 519);
		linkLabel_0.Name = Class84.smethod_0(-994278181);
		linkLabel_0.Size = new Size(59, 13);
		linkLabel_0.TabIndex = 103;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class84.smethod_0(-994278198);
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(24, 85);
		class193_0.Name = Class84.smethod_0(-994278735);
		class193_0.Size = new Size(939, 429);
		class193_0.TabIndex = 101;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(992, 550);
		Controls.Add(linkLabel_0);
		Controls.Add(label_1);
		Controls.Add(class193_0);
		Controls.Add(label_0);
		Controls.Add(pictureBox_0);
		Name = Class84.smethod_0(-994263331);
		Text = Class84.smethod_0(-994263355);
		Load += GForm34_Load;
		Shown += GForm34_Shown;
		((ISupportInitialize)pictureBox_0).EndInit();
		((ISupportInitialize)class193_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
