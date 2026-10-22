using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class GForm32 : Form
{
	private IContainer icontainer_0;

	private Label label_0;

	private TextBox textBox_0;

	private PictureBox pictureBox_0;

	public GForm32()
	{
		method_0();
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void GForm32_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void GForm32_Activated(object sender, EventArgs e)
	{
		textBox_0.DeselectAll();
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm32));
		label_0 = new Label();
		textBox_0 = new TextBox();
		pictureBox_0 = new PictureBox();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994278834);
		label_0.Size = new Size(109, 17);
		label_0.TabIndex = 28;
		label_0.Text = Class84.smethod_0(-994253518);
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		textBox_0.Font = new Font(Class84.smethod_0(-994274653), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_0.Location = new Point(33, 63);
		textBox_0.Multiline = true;
		textBox_0.Name = Class84.smethod_0(-994253479);
		textBox_0.ReadOnly = true;
		textBox_0.ScrollBars = ScrollBars.Both;
		textBox_0.Size = new Size(867, 498);
		textBox_0.TabIndex = 29;
		textBox_0.Text = componentResourceManager.GetString(Class84.smethod_0(-994253496));
		pictureBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		pictureBox_0.Image = Class309.smethod_13();
		pictureBox_0.Location = new Point(955, 3);
		pictureBox_0.Name = Class84.smethod_0(-994278594);
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 91;
		pictureBox_0.TabStop = false;
		pictureBox_0.Click += pictureBox_0_Click;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(975, 608);
		Controls.Add(pictureBox_0);
		Controls.Add(textBox_0);
		Controls.Add(label_0);
		Name = Class84.smethod_0(-994253444);
		Text = Class84.smethod_0(-994253518);
		Activated += GForm32_Activated;
		Load += GForm32_Load;
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
