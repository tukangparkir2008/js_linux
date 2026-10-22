using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

public sealed class GForm20 : Form
{
	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private DataTable dataTable_0;

	private Class216 class216_0;

	private bool bool_0;

	private IContainer icontainer_0;

	private Label label_0;

	private Label label_1;

	private ComboBox comboBox_0;

	private Button button_0;

	private Panel panel_0;

	private SplitContainer splitContainer_0;

	private Class193 class193_0;

	private Label label_2;

	private Chart chart_0;

	private PictureBox pictureBox_0;

	public GForm20(GForm17 gform17_1, GClass5 gclass5_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gclass5_1;
		method_2();
		method_1();
		method_0();
	}

	private void method_0()
	{
		try
		{
			class216_0 = new Class216(class193_0, bool_0: false, bool_1: false);
			class216_0.method_2(Class84.smethod_0(-994311881), 120, bool_0: true);
			class216_0.method_2(Class84.smethod_0(-994297383), 120, bool_0: true);
			dataTable_0 = new DataTable();
			dataTable_0.Columns.Add(Class84.smethod_0(-994263532), Type.GetType(Class84.smethod_0(-994276505)));
			dataTable_0.Columns.Add(Class84.smethod_0(-994297386), Type.GetType(Class84.smethod_0(-994276505)));
			class193_0.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
			bool_0 = true;
			ComboBox.ObjectCollection items = comboBox_0.Items;
			GClass2 gClass = new GClass2();
			gClass.method_3(7);
			gClass.method_1(Class84.smethod_0(-994297405));
			items.Add(gClass);
			ComboBox.ObjectCollection items2 = comboBox_0.Items;
			GClass2 gClass2 = new GClass2();
			gClass2.method_3(30);
			gClass2.method_1(Class84.smethod_0(-994297367));
			items2.Add(gClass2);
			ComboBox.ObjectCollection items3 = comboBox_0.Items;
			GClass2 gClass3 = new GClass2();
			gClass3.method_3(90);
			gClass3.method_1(Class84.smethod_0(-994297328));
			items3.Add(gClass3);
			ComboBox.ObjectCollection items4 = comboBox_0.Items;
			GClass2 gClass4 = new GClass2();
			gClass4.method_3(180);
			gClass4.method_1(Class84.smethod_0(-994297337));
			items4.Add(gClass4);
			ComboBox.ObjectCollection items5 = comboBox_0.Items;
			GClass2 gClass5 = new GClass2();
			gClass5.method_3(365);
			gClass5.method_1(Class84.smethod_0(-994297298));
			items5.Add(gClass5);
			comboBox_0.SelectedIndex = 0;
			bool_0 = false;
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void GForm20_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			int num = ((GClass2)comboBox_0.SelectedItem).method_4();
			string format = Class84.smethod_0(-994297259);
			format = string.Format(format, num);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = format
			};
			dataTable_0.Rows.Clear();
			class216_0.method_12();
			chart_0.Series.Clear();
			chart_0.Legends.Clear();
			List<Tuple<string, int>> list = new List<Tuple<string, int>>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list.Add(new Tuple<string, int>(mySqlDataReader[0].ToString(), Convert.ToInt32(mySqlDataReader[2])));
				DataRow dataRow = dataTable_0.NewRow();
				dataRow[Class84.smethod_0(-994263532)] = mySqlDataReader[1].ToString();
				dataRow[Class84.smethod_0(-994297386)] = mySqlDataReader[2].ToString();
				dataTable_0.Rows.Add(dataRow);
			}
			mySqlDataReader.Close();
			if (list.Count != 0)
			{
				string name = Class84.smethod_0(-994297081);
				chart_0.Series.Add(name);
				chart_0.Series[name].ChartType = SeriesChartType.Column;
				for (int i = 0; i < list.Count; i++)
				{
					chart_0.Series[name].Points.AddXY(list[i].Item1, list[i].Item2);
				}
				class216_0.method_9(dataTable_0);
			}
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

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!bool_0)
		{
			class216_0.method_12();
			chart_0.Series.Clear();
			chart_0.Legends.Clear();
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
		ChartArea chartArea = new ChartArea();
		Legend legend = new Legend();
		Series series = new Series();
		label_0 = new Label();
		label_1 = new Label();
		comboBox_0 = new ComboBox();
		button_0 = new Button();
		panel_0 = new Panel();
		splitContainer_0 = new SplitContainer();
		chart_0 = new Chart();
		label_2 = new Label();
		class193_0 = new Class193();
		pictureBox_0 = new PictureBox();
		panel_0.SuspendLayout();
		((ISupportInitialize)splitContainer_0).BeginInit();
		splitContainer_0.Panel1.SuspendLayout();
		splitContainer_0.Panel2.SuspendLayout();
		splitContainer_0.SuspendLayout();
		((ISupportInitialize)chart_0).BeginInit();
		((ISupportInitialize)class193_0).BeginInit();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994278767);
		label_0.Size = new Size(145, 17);
		label_0.TabIndex = 54;
		label_0.Text = Class84.smethod_0(-994297052);
		label_1.AutoSize = true;
		label_1.Location = new Point(21, 51);
		label_1.Name = Class84.smethod_0(-994278834);
		label_1.Size = new Size(48, 13);
		label_1.TabIndex = 68;
		label_1.Text = Class84.smethod_0(-994297023);
		comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		comboBox_0.FormattingEnabled = true;
		comboBox_0.Location = new Point(75, 48);
		comboBox_0.Name = Class84.smethod_0(-994296961);
		comboBox_0.Size = new Size(133, 21);
		comboBox_0.TabIndex = 69;
		comboBox_0.SelectedIndexChanged += comboBox_0_SelectedIndexChanged;
		button_0.Location = new Point(213, 47);
		button_0.Name = Class84.smethod_0(-994264273);
		button_0.Size = new Size(40, 23);
		button_0.TabIndex = 70;
		button_0.Text = Class84.smethod_0(-994277847);
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		panel_0.Controls.Add(pictureBox_0);
		panel_0.Controls.Add(label_0);
		panel_0.Controls.Add(button_0);
		panel_0.Controls.Add(comboBox_0);
		panel_0.Controls.Add(label_1);
		panel_0.Dock = DockStyle.Top;
		panel_0.Location = new Point(0, 0);
		panel_0.Name = Class84.smethod_0(-994256784);
		panel_0.Size = new Size(1010, 81);
		panel_0.TabIndex = 71;
		splitContainer_0.BackColor = Color.Gainsboro;
		splitContainer_0.Dock = DockStyle.Fill;
		splitContainer_0.Location = new Point(0, 81);
		splitContainer_0.Name = Class84.smethod_0(-994256742);
		splitContainer_0.Panel1.BackColor = SystemColors.Control;
		splitContainer_0.Panel1.Controls.Add(chart_0);
		splitContainer_0.Panel2.BackColor = SystemColors.Control;
		splitContainer_0.Panel2.Controls.Add(label_2);
		splitContainer_0.Panel2.Controls.Add(class193_0);
		splitContainer_0.Size = new Size(1010, 534);
		splitContainer_0.SplitterDistance = 675;
		splitContainer_0.TabIndex = 72;
		chart_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		chartArea.Name = Class84.smethod_0(-994296977);
		chart_0.ChartAreas.Add(chartArea);
		legend.Name = Class84.smethod_0(-994296944);
		chart_0.Legends.Add(legend);
		chart_0.Location = new Point(12, 14);
		chart_0.Name = Class84.smethod_0(-994296946);
		series.ChartArea = Class84.smethod_0(-994296977);
		series.Legend = Class84.smethod_0(-994296944);
		series.Name = Class84.smethod_0(-994296899);
		chart_0.Series.Add(series);
		chart_0.Size = new Size(644, 497);
		chart_0.TabIndex = 0;
		chart_0.Text = Class84.smethod_0(-994296917);
		label_2.AutoSize = true;
		label_2.Location = new Point(15, 14);
		label_2.Name = Class84.smethod_0(-994266720);
		label_2.Size = new Size(43, 13);
		label_2.TabIndex = 71;
		label_2.Text = Class84.smethod_0(-994296872);
		class193_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class193_0.BackgroundColor = Color.White;
		class193_0.BorderStyle = BorderStyle.None;
		class193_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		class193_0.Location = new Point(15, 34);
		class193_0.Name = Class84.smethod_0(-994296874);
		class193_0.Size = new Size(301, 477);
		class193_0.TabIndex = 70;
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(989, 4);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 99;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1010, 615);
		Controls.Add(splitContainer_0);
		Controls.Add(panel_0);
		Name = Class84.smethod_0(-994296890);
		Text = Class84.smethod_0(-994297052);
		Load += GForm20_Load;
		panel_0.ResumeLayout(performLayout: false);
		panel_0.PerformLayout();
		splitContainer_0.Panel1.ResumeLayout(performLayout: false);
		splitContainer_0.Panel2.ResumeLayout(performLayout: false);
		splitContainer_0.Panel2.PerformLayout();
		((ISupportInitialize)splitContainer_0).EndInit();
		splitContainer_0.ResumeLayout(performLayout: false);
		((ISupportInitialize)chart_0).EndInit();
		((ISupportInitialize)class193_0).EndInit();
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
	}
}
