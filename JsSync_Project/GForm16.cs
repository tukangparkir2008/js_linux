using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

public sealed class GForm16 : Form
{
	private delegate void Delegate26(string string_0);

	private IContainer icontainer_0;

	private TextBox textBox_0;

	private Label label_0;

	private Label label_1;

	private Button button_0;

	private Button button_1;

	public GForm16()
	{
		method_3();
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		try
		{
			textBox_0.Text = string.Empty;
			string text = Path.Combine(Class224.Class232.string_0, Class84.smethod_0(-994251076));
			if (!File.Exists(text))
			{
				textBox_0.Text = Class84.smethod_0(-994251095);
				return;
			}
			Process process = new Process();
			process.StartInfo.FileName = text;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.EnableRaisingEvents = true;
			process.OutputDataReceived += method_1;
			process.ErrorDataReceived += method_2;
			process.Start();
			process.BeginOutputReadLine();
			process.BeginErrorReadLine();
		}
		catch (Exception)
		{
		}
	}

	private void method_0(string string_0)
	{
		if (InvokeRequired)
		{
			Delegate26 method = method_0;
			Invoke(method, string_0);
		}
		else
		{
			textBox_0.Text = string_0;
		}
	}

	private void method_1(object sender, DataReceivedEventArgs e)
	{
		try
		{
			if (e.Data != null && e.Data.Trim().Length != 0)
			{
				method_0(e.Data);
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_2(object sender, DataReceivedEventArgs e)
	{
		try
		{
			if (e.Data != null && e.Data.Trim().Length != 0)
			{
				method_0(e.Data);
			}
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

	private void method_3()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm16));
		textBox_0 = new TextBox();
		label_0 = new Label();
		label_1 = new Label();
		button_0 = new Button();
		button_1 = new Button();
		SuspendLayout();
		textBox_0.Font = new Font(Class84.smethod_0(-994274653), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_0.Location = new Point(23, 85);
		textBox_0.Multiline = true;
		textBox_0.Name = Class84.smethod_0(-994250984);
		textBox_0.Size = new Size(526, 112);
		textBox_0.TabIndex = 0;
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(20, 21);
		label_0.Name = Class84.smethod_0(-994278767);
		label_0.Size = new Size(157, 17);
		label_0.TabIndex = 94;
		label_0.Text = Class84.smethod_0(-994248054);
		label_1.AutoSize = true;
		label_1.Location = new Point(20, 55);
		label_1.Name = Class84.smethod_0(-994278834);
		label_1.Size = new Size(406, 13);
		label_1.TabIndex = 95;
		label_1.Text = Class84.smethod_0(-994250985);
		button_0.Image = Class309.smethod_64();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(207, 215);
		button_0.Name = Class84.smethod_0(-994250881);
		button_0.Size = new Size(75, 33);
		button_0.TabIndex = 96;
		button_0.Text = Class84.smethod_0(-994250900);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		button_1.Image = Class309.smethod_10();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(288, 215);
		button_1.Name = Class84.smethod_0(-994278087);
		button_1.Size = new Size(75, 33);
		button_1.TabIndex = 97;
		button_1.Text = Class84.smethod_0(-994278089);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(570, 260);
		Controls.Add(button_1);
		Controls.Add(button_0);
		Controls.Add(label_1);
		Controls.Add(label_0);
		Controls.Add(textBox_0);
		Icon = (Icon)componentResourceManager.GetObject(Class84.smethod_0(-994278109));
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class84.smethod_0(-994250905);
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class84.smethod_0(-994248054);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
