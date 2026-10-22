using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

public sealed class GForm3 : Form
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct14 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GForm3 gform3_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GForm3 gForm = gform3_0;
			try
			{
				try
				{
					if (num != 0)
					{
						gForm.bool_0 = true;
						gForm.cancellationTokenSource_0 = new CancellationTokenSource();
						goto IL_0043;
					}
					TaskAwaiter awaiter = taskAwaiter_0;
					taskAwaiter_0 = default;
					num = -1;
					int_0 = -1;
					goto IL_0075;
					IL_0075:
					awaiter.GetResult();
					goto IL_0043;
					IL_0043:
					if (gForm.bool_0)
					{
						gForm.method_6();
						awaiter = Task.Delay(Class224.Class226.int_15, gForm.cancellationTokenSource_0.Token).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0075;
					}
				}
				catch (Exception)
				{
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private sealed class Class294 : GClass48
	{
		private readonly GForm3 gform3_0;

		public Class294(GForm3 gform3_1)
		{
			gform3_0 = gform3_1;
		}

		public override void vmethod_0()
		{
			gform3_0.method_7();
			gform3_0.method_4();
		}

		public override void vmethod_1()
		{
			gform3_0.method_8();
		}
	}

	private sealed class Class295 : GClass48
	{
		private readonly GForm3 gform3_0;

		public Class295(GForm3 gform3_1)
		{
			gform3_0 = gform3_1;
		}

		public override void vmethod_0()
		{
			gform3_0.method_12();
			gform3_0.method_5();
		}

		public override void vmethod_1()
		{
			gform3_0.method_13();
			gform3_0.method_5();
		}
	}

	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private int int_0;

	private bool bool_0;

	private CancellationTokenSource cancellationTokenSource_0;

	private IContainer icontainer_0;

	private Button button_0;

	private Button button_1;

	private Label label_0;

	private LinkLabel linkLabel_0;

	private GClass17 gclass17_0;

	private PictureBox pictureBox_0;

	private Label label_1;

	private Label label_2;

	private Button button_2;

	private Label label_3;

	private Label label_4;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private Label label_5;

	private LinkLabel linkLabel_1;

	private Label label_6;

	private Label label_7;

	private LinkLabel linkLabel_2;

	public GForm3(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gform17_1.method_0();
		method_14();
		method_0(Class84.smethod_0(-994310777));
	}

	public void method_0(string string_0)
	{
		if (!(string_0 == Class84.smethod_0(-994310731)))
		{
			if (!(string_0 == Class84.smethod_0(-994310746)))
			{
				if (string_0 == Class84.smethod_0(-994310777) || string_0 == Class84.smethod_0(-994310698))
				{
					Cursor = Cursors.Default;
					button_1.Enabled = true;
					button_0.Enabled = false;
					textBox_0.Text = Class84.smethod_0(-994274584);
					textBox_1.Text = Class84.smethod_0(-994274584);
				}
			}
			else
			{
				Cursor = Cursors.Default;
				button_1.Enabled = false;
				button_0.Enabled = true;
				textBox_0.Text = Class84.smethod_0(-994274584);
				textBox_1.Text = Class84.smethod_0(-994274584);
			}
		}
		else
		{
			Cursor = Cursors.WaitCursor;
			button_1.Enabled = false;
			button_0.Enabled = false;
			textBox_0.Text = Class84.smethod_0(-994274584);
			textBox_1.Text = Class84.smethod_0(-994274584);
		}
	}

	public void method_1(int int_1, int int_2)
	{
		try
		{
			switch (int_1)
			{
			case -1:
				pictureBox_0.Image = Class309.smethod_67();
				label_2.Text = Class84.smethod_0(-994310663);
				break;
			case 0:
				pictureBox_0.Image = Class309.smethod_49();
				label_2.Text = Class84.smethod_0(-994278690);
				break;
			case 1:
				pictureBox_0.Image = Class309.smethod_66();
				label_2.Text = string.Format(Class84.smethod_0(-994310665), int_2);
				break;
			case 2:
				pictureBox_0.Image = Class309.smethod_48();
				label_2.Text = Class84.smethod_0(-994310630);
				break;
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_2(GEnum0 genum0_0, string string_0, string string_1, string string_2)
	{
		try
		{
			if (InvokeRequired)
			{
				GDelegate7 method = method_2;
				Invoke(method, genum0_0, string_0, string_1, string_2);
				return;
			}
			if (int_0 > 5000)
			{
				gclass17_0.Items.Clear();
				int_0 = 0;
			}
			gclass17_0.Items.Add(new GClass33(genum0_0, string_0, DateTime.Now.ToString(Class84.smethod_0(-994304362)), string_1, string_2));
			gclass17_0.SelectedIndex = gclass17_0.Items.Count - 1;
			int_0++;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void GForm3_Load(object sender, EventArgs e)
	{
		WindowState = FormWindowState.Maximized;
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		if (!Class348.Class351.bool_0)
		{
			Class355.smethod_4(Class84.smethod_0(-994304294));
		}
		else
		{
			method_3();
		}
	}

	public void method_3()
	{
		if (Class348.Class349.bool_0)
		{
			return;
		}
		try
		{
			Class348.Class352.smethod_4();
			gform17_0.method_16(Class84.smethod_0(-994310731));
			method_0(Class84.smethod_0(-994310731));
			gclass5_0.vmethod_1(new Class294(this));
		}
		catch (Exception ex)
		{
			method_0(Class84.smethod_0(-994310698));
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public async void method_4()
	{
		try
		{
			bool_0 = true;
			cancellationTokenSource_0 = new CancellationTokenSource();
			while (bool_0)
			{
				method_6();
				await Task.Delay(Class224.Class226.int_15, cancellationTokenSource_0.Token);
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_5()
	{
		try
		{
			bool_0 = false;
			cancellationTokenSource_0?.Cancel();
			textBox_1.Text = Class84.smethod_0(-994274584);
			textBox_0.Text = Class84.smethod_0(-994274584);
		}
		catch (Exception)
		{
		}
	}

	private void method_6()
	{
		try
		{
			if (InvokeRequired)
			{
				GDelegate9 method = method_6;
				Invoke(method);
			}
			else
			{
				textBox_1.Text = gclass5_0.method_13().ToString();
				textBox_0.Text = gclass5_0.method_14().ToString();
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_7()
	{
		try
		{
			if (InvokeRequired)
			{
				GDelegate9 method = method_7;
				Invoke(method);
				return;
			}
			gclass17_0.Items.Clear();
			Class348.Class349.bool_0 = true;
			Class348.Class352.smethod_4();
			Class224.Class226.int_18 = 0;
			method_2(GEnum0.Info, string.Empty, string.Empty, Class224.Class227.smethod_0() ?? string.Empty);
			method_2(GEnum0.Info, string.Empty, string.Empty, Class84.smethod_0(-994310633) + Class224.Class228.string_0 + Class84.smethod_0(-994263069) + Class224.Class228.string_1);
			method_2(GEnum0.Info, string.Empty, string.Empty, Class84.smethod_0(-994310624) + Class249.Class251.smethod_0() + Class84.smethod_0(-994310570) + Class348.Class352.smethod_6());
			method_2(GEnum0.Info, string.Empty, string.Empty, string.Format(Class84.smethod_0(-994310585), Class224.Class229.string_0, Class224.Class229.int_0));
			method_2(GEnum0.Info, string.Empty, string.Empty, Class84.smethod_0(-994310526) + Class348.Class352.string_1 + Class84.smethod_0(-994310487) + Class348.Class352.string_0 + Class84.smethod_0(-994310490) + Class348.Class352.string_5);
			method_2(GEnum0.Info, string.Empty, string.Empty, Class84.smethod_0(-994310452) + (Class348.Class352.smethod_0() ? Class84.smethod_0(-994310428) : Class84.smethod_0(-994310412)));
			gform17_0.method_16(Class84.smethod_0(-994310746));
			method_0(Class84.smethod_0(-994310746));
			gform17_0.method_13();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_8()
	{
		try
		{
			if (InvokeRequired)
			{
				GDelegate9 method = method_8;
				Invoke(method);
				return;
			}
			Class348.Class349.bool_0 = false;
			Class224.Class226.int_18 = 0;
			method_2(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994310384) + Class224.Class227.smethod_0());
			method_0(Class84.smethod_0(-994310698));
			gform17_0.method_16(Class84.smethod_0(-994310698));
			gform17_0.method_14();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_9()
	{
		try
		{
			if (InvokeRequired)
			{
				GDelegate9 method = method_9;
				Invoke(method);
			}
			else
			{
				method_0(Class84.smethod_0(-994310698));
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_10(object sender, EventArgs e)
	{
		gclass5_0.method_35();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		if (Class348.Class349.bool_0)
		{
			if (!Class348.Class351.bool_0)
			{
				Class355.smethod_4(Class84.smethod_0(-994310338));
			}
			else if (gclass5_0.gclass6_0.method_6() == 2)
			{
				Class355.smethod_0(Class84.smethod_0(-994310330));
			}
			else if (Class355.smethod_1(Class84.smethod_0(-994310233)) != DialogResult.Cancel)
			{
				method_11();
			}
		}
	}

	public void method_11()
	{
		try
		{
			method_0(Class84.smethod_0(-994310731));
			gclass5_0.vmethod_0(new Class295(this));
		}
		catch (Exception ex)
		{
			method_0(Class84.smethod_0(-994310746));
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_12()
	{
		if (InvokeRequired)
		{
			GDelegate9 method = method_12;
			Invoke(method);
		}
		else
		{
			method_0(Class84.smethod_0(-994310698));
		}
	}

	public void method_13()
	{
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (Class355.smethod_1(Class84.smethod_0(-994310152)) != DialogResult.Cancel)
		{
			linkLabel_0.Enabled = false;
			gclass17_0.Items.Clear();
			linkLabel_0.Enabled = true;
		}
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		gclass5_0.method_35();
	}

	private void linkLabel_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	private void label_6_Click(object sender, EventArgs e)
	{
	}

	private void label_7_Click(object sender, EventArgs e)
	{
	}

	private void linkLabel_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_14()
	{
		button_0 = new Button();
		button_1 = new Button();
		label_0 = new Label();
		linkLabel_0 = new LinkLabel();
		pictureBox_0 = new PictureBox();
		label_1 = new Label();
		label_2 = new Label();
		button_2 = new Button();
		label_3 = new Label();
		label_4 = new Label();
		textBox_0 = new TextBox();
		gclass17_0 = new GClass17();
		textBox_1 = new TextBox();
		label_5 = new Label();
		linkLabel_1 = new LinkLabel();
		label_6 = new Label();
		label_7 = new Label();
		linkLabel_2 = new LinkLabel();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		button_0.Image = Class309.smethod_11();
		button_0.ImageAlign = ContentAlignment.MiddleLeft;
		button_0.Location = new Point(12, 122);
		button_0.Name = Class84.smethod_0(-994297836);
		button_0.Size = new Size(102, 30);
		button_0.TabIndex = 65;
		button_0.Text = Class84.smethod_0(-994297855);
		button_0.TextAlign = ContentAlignment.MiddleRight;
		button_0.UseVisualStyleBackColor = true;
		button_0.Click += button_0_Click;
		button_1.Image = Class309.smethod_21();
		button_1.ImageAlign = ContentAlignment.MiddleLeft;
		button_1.Location = new Point(12, 69);
		button_1.Name = Class84.smethod_0(-994297808);
		button_1.Size = new Size(102, 47);
		button_1.TabIndex = 64;
		button_1.Text = Class84.smethod_0(-994297810);
		button_1.TextAlign = ContentAlignment.MiddleRight;
		button_1.UseVisualStyleBackColor = true;
		button_1.Click += button_1_Click;
		label_0.AutoSize = true;
		label_0.Font = new Font(Class84.smethod_0(-994278794), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_0.ForeColor = Color.Teal;
		label_0.Location = new Point(21, 20);
		label_0.Name = Class84.smethod_0(-994278767);
		label_0.Size = new Size(103, 17);
		label_0.TabIndex = 63;
		label_0.Text = Class84.smethod_0(-994297766);
		linkLabel_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		linkLabel_0.AutoSize = true;
		linkLabel_0.Location = new Point(1068, 635);
		linkLabel_0.Name = Class84.smethod_0(-994304065);
		linkLabel_0.Size = new Size(98, 13);
		linkLabel_0.TabIndex = 78;
		linkLabel_0.TabStop = true;
		linkLabel_0.Text = Class84.smethod_0(-994304083);
		linkLabel_0.LinkClicked += linkLabel_0_LinkClicked;
		pictureBox_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		pictureBox_0.Image = Class309.smethod_49();
		pictureBox_0.Location = new Point(36, 552);
		pictureBox_0.Name = Class84.smethod_0(-994297781);
		pictureBox_0.Size = new Size(50, 50);
		pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
		pictureBox_0.TabIndex = 79;
		pictureBox_0.TabStop = false;
		label_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		label_1.ForeColor = Color.Gray;
		label_1.Location = new Point(14, 522);
		label_1.Name = Class84.smethod_0(-994278834);
		label_1.Size = new Size(100, 27);
		label_1.TabIndex = 80;
		label_1.Text = Class84.smethod_0(-994297744);
		label_1.TextAlign = ContentAlignment.TopCenter;
		label_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		label_2.Font = new Font(Class84.smethod_0(-994278794), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label_2.Location = new Point(0, 605);
		label_2.Name = Class84.smethod_0(-994297720);
		label_2.Size = new Size(125, 27);
		label_2.TabIndex = 81;
		label_2.Text = Class84.smethod_0(-994278690);
		label_2.TextAlign = ContentAlignment.TopCenter;
		button_2.Location = new Point(27, 168);
		button_2.Name = Class84.smethod_0(-994297667);
		button_2.Size = new Size(75, 23);
		button_2.TabIndex = 82;
		button_2.Text = Class84.smethod_0(-994297681);
		button_2.UseVisualStyleBackColor = true;
		button_2.Visible = false;
		button_2.Click += button_2_Click;
		label_3.AutoSize = true;
		label_3.Location = new Point(125, 633);
		label_3.Name = Class84.smethod_0(-994266720);
		label_3.Size = new Size(0, 13);
		label_3.TabIndex = 83;
		label_4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		label_4.AutoSize = true;
		label_4.Location = new Point(1089, 17);
		label_4.Name = Class84.smethod_0(-994266659);
		label_4.Size = new Size(54, 13);
		label_4.TabIndex = 84;
		label_4.Text = Class84.smethod_0(-994297648);
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		textBox_0.BackColor = Color.ForestGreen;
		textBox_0.BorderStyle = BorderStyle.FixedSingle;
		textBox_0.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_0.ForeColor = Color.White;
		textBox_0.Location = new Point(1066, 33);
		textBox_0.Name = Class84.smethod_0(-994297663);
		textBox_0.Size = new Size(100, 26);
		textBox_0.TabIndex = 85;
		textBox_0.Text = Class84.smethod_0(-994274584);
		textBox_0.TextAlign = HorizontalAlignment.Center;
		gclass17_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		gclass17_0.DrawMode = DrawMode.OwnerDrawVariable;
		gclass17_0.FormattingEnabled = true;
		gclass17_0.Location = new Point(128, 69);
		gclass17_0.Name = Class84.smethod_0(-994304140);
		gclass17_0.Size = new Size(1037, 563);
		gclass17_0.TabIndex = 72;
		textBox_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		textBox_1.BackColor = Color.DarkViolet;
		textBox_1.BorderStyle = BorderStyle.FixedSingle;
		textBox_1.Font = new Font(Class84.smethod_0(-994278794), 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
		textBox_1.ForeColor = Color.White;
		textBox_1.Location = new Point(961, 33);
		textBox_1.Name = Class84.smethod_0(-994297610);
		textBox_1.Size = new Size(100, 26);
		textBox_1.TabIndex = 87;
		textBox_1.Text = Class84.smethod_0(-994274584);
		textBox_1.TextAlign = HorizontalAlignment.Center;
		label_5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		label_5.AutoSize = true;
		label_5.Location = new Point(974, 17);
		label_5.Name = Class84.smethod_0(-994266638);
		label_5.Size = new Size(78, 13);
		label_5.TabIndex = 86;
		label_5.Text = Class84.smethod_0(-994297573);
		linkLabel_1.AutoSize = true;
		linkLabel_1.Location = new Point(35, 247);
		linkLabel_1.Name = Class84.smethod_0(-994297585);
		linkLabel_1.Size = new Size(53, 13);
		linkLabel_1.TabIndex = 88;
		linkLabel_1.TabStop = true;
		linkLabel_1.Text = Class84.smethod_0(-994297552);
		linkLabel_1.Visible = false;
		linkLabel_1.LinkClicked += linkLabel_1_LinkClicked;
		label_6.AutoSize = true;
		label_6.Location = new Point(38, 295);
		label_6.Name = Class84.smethod_0(-994297568);
		label_6.Size = new Size(47, 13);
		label_6.TabIndex = 89;
		label_6.Text = Class84.smethod_0(-994297515);
		label_6.Visible = false;
		label_6.Click += label_6_Click;
		label_7.AutoSize = true;
		label_7.Location = new Point(38, 319);
		label_7.Name = Class84.smethod_0(-994297532);
		label_7.Size = new Size(35, 13);
		label_7.TabIndex = 90;
		label_7.Text = Class84.smethod_0(-994297485);
		label_7.Visible = false;
		label_7.Click += label_7_Click;
		linkLabel_2.AutoSize = true;
		linkLabel_2.Location = new Point(34, 367);
		linkLabel_2.Name = Class84.smethod_0(-994297504);
		linkLabel_2.Size = new Size(49, 13);
		linkLabel_2.TabIndex = 91;
		linkLabel_2.TabStop = true;
		linkLabel_2.Text = Class84.smethod_0(-994297455);
		linkLabel_2.Visible = false;
		linkLabel_2.LinkClicked += linkLabel_2_LinkClicked;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1187, 665);
		Controls.Add(linkLabel_2);
		Controls.Add(label_7);
		Controls.Add(label_6);
		Controls.Add(linkLabel_1);
		Controls.Add(textBox_1);
		Controls.Add(label_5);
		Controls.Add(textBox_0);
		Controls.Add(label_4);
		Controls.Add(label_3);
		Controls.Add(button_2);
		Controls.Add(label_2);
		Controls.Add(label_1);
		Controls.Add(pictureBox_0);
		Controls.Add(linkLabel_0);
		Controls.Add(gclass17_0);
		Controls.Add(button_0);
		Controls.Add(button_1);
		Controls.Add(label_0);
		Name = Class84.smethod_0(-994297471);
		Text = Class84.smethod_0(-994297421);
		Load += GForm3_Load;
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
