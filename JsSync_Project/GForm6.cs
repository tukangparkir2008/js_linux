using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class GForm6 : Form
{
	private readonly GForm31 gform31_0;

	private IContainer icontainer_0;

	private Label label_0;

	private TextBox textBox_0;

	private Button button_0;

	private Button button_1;

	public GForm6(GForm31 gform31_1)
	{
		gform31_0 = gform31_1;
		method_0();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		if (textBox_0.Text.Trim().Length < 10)
		{
			Class355.smethod_0(Class84.smethod_0(-994266323));
			return;
		}
		gform31_0.method_5(textBox_0.Text.Trim());
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

	private void method_0()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm6));
		label_0 = new Label();
		textBox_0 = new TextBox();
		button_0 = new Button();
		button_1 = new Button();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Location = new Point(12, 26);
		label_0.Name = Class84.smethod_0(-994278834);
		label_0.Size = new Size(86, 13);
		label_0.TabIndex = 0;
		label_0.Text = Class84.smethod_0(-994266248);
		textBox_0.Location = new Point(12, 42);
		textBox_0.MaxLength = 255;
		textBox_0.Multiline = true;
		textBox_0.Name = Class84.smethod_0(-994266257);
		textBox_0.Size = new Size(359, 75);
		textBox_0.TabIndex = 1;
		button_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		button_0.Image = Class309.smethod_10();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(194, 130);
		button_0.Name = Class84.smethod_0(-994278087);
		button_0.Size = new Size(69, 26);
		button_0.TabIndex = 6;
		button_0.Text = Class84.smethod_0(-994278089);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		button_1.Image = Class309.smethod_24();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(119, 130);
		button_1.Name = Class84.smethod_0(-994266730);
		button_1.Size = new Size(69, 26);
		button_1.TabIndex = 5;
		button_1.Text = Class84.smethod_0(-994266747);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(383, 168);
		Controls.Add(button_0);
		Controls.Add(button_1);
		Controls.Add(textBox_0);
		Controls.Add(label_0);
		Icon = (Icon)componentResourceManager.GetObject(Class84.smethod_0(-994278109));
		MaximizeBox = false;
		MinimizeBox = false;
		Name = Class84.smethod_0(-994266210);
		ShowInTaskbar = false;
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class84.smethod_0(-994266248);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
