using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm11 : Form
{
	private IContainer icontainer_0;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private WebBrowser webBrowser_0;

	private Button button_0;

	public GForm11()
	{
		method_1();
	}

	private void GForm11_Load(object sender, EventArgs e)
	{
	}

	public void method_0(string string_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string text = string.Empty;
			string text2 = string.Empty;
			string documentText = string.Empty;
			string commandText = Class84.smethod_0(-994260302) + string_0 + Class84.smethod_0(-994271698);
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = commandText
			}.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				text = mySqlDataReader[Class84.smethod_0(-994268488)].ToString();
				text2 = mySqlDataReader[Class84.smethod_0(-994268492)].ToString();
				documentText = mySqlDataReader[Class84.smethod_0(-994268508)].ToString();
			}
			mySqlDataReader.Close();
			if (text.Length == 0)
			{
				Class355.smethod_0(Class84.smethod_0(-994268571));
				Close();
			}
			else
			{
				textBox_0.Text = text;
				textBox_1.Text = text2;
				webBrowser_0.DocumentText = documentText;
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

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_1()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm11));
		textBox_0 = new TextBox();
		textBox_1 = new TextBox();
		webBrowser_0 = new WebBrowser();
		button_0 = new Button();
		SuspendLayout();
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.BackColor = Color.White;
		textBox_0.BorderStyle = BorderStyle.None;
		textBox_0.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
		textBox_0.Location = new Point(12, 12);
		textBox_0.Multiline = true;
		textBox_0.Name = Class84.smethod_0(-994256200);
		textBox_0.ReadOnly = true;
		textBox_0.Size = new Size(641, 51);
		textBox_0.TabIndex = 0;
		textBox_0.Text = Class84.smethod_0(-994260243);
		textBox_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_1.BackColor = Color.White;
		textBox_1.BorderStyle = BorderStyle.None;
		textBox_1.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Italic, GraphicsUnit.Point, 0);
		textBox_1.Location = new Point(12, 65);
		textBox_1.Multiline = true;
		textBox_1.Name = Class84.smethod_0(-994256283);
		textBox_1.ReadOnly = true;
		textBox_1.Size = new Size(641, 81);
		textBox_1.TabIndex = 1;
		textBox_1.Text = Class84.smethod_0(-994258372);
		webBrowser_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		webBrowser_0.Location = new Point(12, 158);
		webBrowser_0.MinimumSize = new Size(20, 20);
		webBrowser_0.Name = Class84.smethod_0(-994273807);
		webBrowser_0.Size = new Size(641, 401);
		webBrowser_0.TabIndex = 2;
		button_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		button_0.Image = Class309.smethod_10();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(298, 568);
		button_0.Name = Class84.smethod_0(-994278087);
		button_0.Size = new Size(69, 26);
		button_0.TabIndex = 122;
		button_0.Text = Class84.smethod_0(-994278089);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.White;
		ClientSize = new Size(665, 601);
		Controls.Add(button_0);
		Controls.Add(webBrowser_0);
		Controls.Add(textBox_1);
		Controls.Add(textBox_0);
		Icon = (Icon)componentResourceManager.GetObject(Class84.smethod_0(-994278109));
		Name = Class84.smethod_0(-994260199);
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class84.smethod_0(-994256048);
		Load += GForm11_Load;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
