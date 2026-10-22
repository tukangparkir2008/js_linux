using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;

public sealed class GControl1 : UserControl
{
	private static class Class178
	{
		public static CallSite<Func<CallSite, object, object, object>> callSite_0;

		public static CallSite<Func<CallSite, object, bool>> callSite_1;

		public static CallSite<Func<CallSite, object, string, object>> callSite_2;
	}

	private static class Class179
	{
		public static CallSite<Func<CallSite, object, string, object>> callSite_0;

		public static CallSite<Func<CallSite, object, int, object>> callSite_1;

		public static CallSite<Func<CallSite, object, string, object>> callSite_2;
	}

	private static class Class180
	{
		public static CallSite<Action<CallSite, object, string, bool, object>> callSite_0;
	}

	private static class Class181
	{
		public static CallSite<Action<CallSite, object, string>> callSite_0;
	}

	private static class Class182
	{
		public static CallSite<Action<CallSite, object, string, bool, object>> callSite_0;
	}

	private static class Class183
	{
		public static CallSite<Action<CallSite, object, string, bool, string>> callSite_0;
	}

	private static class Class184
	{
		public static CallSite<Action<CallSite, object, string, bool, object>> callSite_0;
	}

	private static class Class185
	{
		public static CallSite<Action<CallSite, object, string, bool, object>> callSite_0;
	}

	private static class Class186
	{
		public static CallSite<Action<CallSite, object, string, bool, object>> callSite_0;
	}

	private static class Class187
	{
		public static CallSite<Func<CallSite, object, object, object>> callSite_0;

		public static CallSite<Func<CallSite, object, bool>> callSite_1;

		public static CallSite<Func<CallSite, object, object>> callSite_2;

		public static CallSite<Func<CallSite, object, string>> callSite_3;
	}

	private static class Class188
	{
		public static CallSite<Action<CallSite, object, string, bool, string>> callSite_0;
	}

	private dynamic object_0;

	private dynamic object_1;

	private IContainer icontainer_0;

	private Panel panel_0;

	private ToolStrip toolStrip_0;

	private WebBrowser webBrowser_0;

	private ToolStripButton toolStripButton_0;

	private ToolStripButton toolStripButton_1;

	private ToolStripButton toolStripButton_2;

	private ToolStripSeparator toolStripSeparator_0;

	private ToolStripButton toolStripButton_3;

	private ToolStripButton toolStripButton_4;

	private ToolStripSeparator toolStripSeparator_1;

	private ToolStripButton toolStripButton_5;

	private ToolStripButton toolStripButton_6;

	private ToolStripButton toolStripButton_7;

	private OpenFileDialog openFileDialog_0;

	private ColorDialog colorDialog_0;

	public GControl1()
	{
		method_3();
		method_0();
	}

	private void method_0()
	{
		try
		{
			webBrowser_0.DocumentText = Class84.smethod_0(-994274592);
			webBrowser_0.DocumentCompleted += webBrowser_0_DocumentCompleted;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void GControl1_Load(object sender, EventArgs e)
	{
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		try
		{
			toolStripButton_0.Checked = !toolStripButton_0.Checked;
			if (Class180.callSite_0 == null)
			{
				Class180.callSite_0 = CallSite<Action<CallSite, object, string, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class84.smethod_0(-994274503), null, typeof(GControl1), new CSharpArgumentInfo[4]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Class180.callSite_0.Target(Class180.callSite_0, (object)object_0, Class84.smethod_0(-994274517), arg4: false, null);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		try
		{
			toolStripButton_1.Checked = !toolStripButton_1.Checked;
			if (Class185.callSite_0 == null)
			{
				Class185.callSite_0 = CallSite<Action<CallSite, object, string, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class84.smethod_0(-994274503), null, typeof(GControl1), new CSharpArgumentInfo[4]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Class185.callSite_0.Target(Class185.callSite_0, (object)object_0, Class84.smethod_0(-994274522), arg4: false, null);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void toolStripButton_2_Click(object sender, EventArgs e)
	{
		try
		{
			toolStripButton_2.Checked = !toolStripButton_2.Checked;
			if (Class184.callSite_0 == null)
			{
				Class184.callSite_0 = CallSite<Action<CallSite, object, string, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class84.smethod_0(-994274503), null, typeof(GControl1), new CSharpArgumentInfo[4]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Class184.callSite_0.Target(Class184.callSite_0, (object)object_0, Class84.smethod_0(-994274477), arg4: false, null);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void toolStripButton_3_Click(object sender, EventArgs e)
	{
		try
		{
			if (Class186.callSite_0 == null)
			{
				Class186.callSite_0 = CallSite<Action<CallSite, object, string, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class84.smethod_0(-994274503), null, typeof(GControl1), new CSharpArgumentInfo[4]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Class186.callSite_0.Target(Class186.callSite_0, (object)object_0, Class84.smethod_0(-994274493), arg4: false, null);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void toolStripButton_4_Click(object sender, EventArgs e)
	{
		try
		{
			if (Class182.callSite_0 == null)
			{
				Class182.callSite_0 = CallSite<Action<CallSite, object, string, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class84.smethod_0(-994274503), null, typeof(GControl1), new CSharpArgumentInfo[4]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Class182.callSite_0.Target(Class182.callSite_0, (object)object_0, Class84.smethod_0(-994274453), arg4: false, null);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void toolStripButton_5_Click(object sender, EventArgs e)
	{
		try
		{
			openFileDialog_0.Filter = Class84.smethod_0(-994274411);
			if (openFileDialog_0.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			FileInfo fileInfo = new FileInfo(openFileDialog_0.FileName);
			if (fileInfo.Length > Class224.Class226.int_13)
			{
				Class355.smethod_0(Class84.smethod_0(-994274394) + Class224.Class226.int_13 + Class84.smethod_0(-994274319));
				return;
			}
			string text = Class84.smethod_0(-994274323);
			if (fileInfo.Extension.Equals(Class84.smethod_0(-994274274)))
			{
				text = Class84.smethod_0(-994274295);
			}
			if (fileInfo.Extension.Equals(Class84.smethod_0(-994274247)))
			{
				text = Class84.smethod_0(-994274252);
			}
			if (fileInfo.Extension.Equals(Class84.smethod_0(-994274268)))
			{
				text = Class84.smethod_0(-994274209);
			}
			Image value = Image.FromFile(openFileDialog_0.FileName);
			byte[] inArray = (byte[])new ImageConverter().ConvertTo(value, typeof(byte[]));
			string arg = Class84.smethod_0(-994274225) + text + Class84.smethod_0(-994274181) + Convert.ToBase64String(inArray);
			if (Class183.callSite_0 == null)
			{
				Class183.callSite_0 = CallSite<Action<CallSite, object, string, bool, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class84.smethod_0(-994274503), null, typeof(GControl1), new CSharpArgumentInfo[4]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			Class183.callSite_0.Target(Class183.callSite_0, (object)object_0, Class84.smethod_0(-994274198), arg4: false, arg);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void toolStripButton_6_Click(object sender, EventArgs e)
	{
		try
		{
			if (Class181.callSite_0 == null)
			{
				Class181.callSite_0 = CallSite<Action<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class84.smethod_0(-994274503), null, typeof(GControl1), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Class181.callSite_0.Target(Class181.callSite_0, (object)object_0, Class84.smethod_0(-994274148));
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void toolStripButton_7_Click(object sender, EventArgs e)
	{
		try
		{
			if (colorDialog_0.ShowDialog() != DialogResult.Cancel)
			{
				if (Class188.callSite_0 == null)
				{
					Class188.callSite_0 = CallSite<Action<CallSite, object, string, bool, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, Class84.smethod_0(-994274503), null, typeof(GControl1), new CSharpArgumentInfo[4]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Class188.callSite_0.Target(Class188.callSite_0, (object)object_0, Class84.smethod_0(-994274163), arg4: false, ColorTranslator.ToHtml(colorDialog_0.Color));
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public string method_1()
	{
		if (object_1 == null)
		{
			return string.Empty;
		}
		if (Class187.callSite_2 == null)
		{
			Class187.callSite_2 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, Class84.smethod_0(-994274115), typeof(GControl1), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
		}
		return (dynamic)Class187.callSite_2.Target(Class187.callSite_2, (object)object_1);
	}

	public void method_2(string string_0)
	{
		if (!((object_1 == null) ? true : false))
		{
			if (Class178.callSite_2 == null)
			{
				Class178.callSite_2 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, Class84.smethod_0(-994274115), typeof(GControl1), new CSharpArgumentInfo[2]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			Class178.callSite_2.Target(Class178.callSite_2, (object)object_1, string_0);
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
		panel_0 = new Panel();
		toolStrip_0 = new ToolStrip();
		toolStripButton_0 = new ToolStripButton();
		toolStripButton_1 = new ToolStripButton();
		toolStripButton_2 = new ToolStripButton();
		toolStripSeparator_0 = new ToolStripSeparator();
		toolStripButton_3 = new ToolStripButton();
		toolStripButton_4 = new ToolStripButton();
		toolStripSeparator_1 = new ToolStripSeparator();
		toolStripButton_5 = new ToolStripButton();
		toolStripButton_6 = new ToolStripButton();
		toolStripButton_7 = new ToolStripButton();
		webBrowser_0 = new WebBrowser();
		openFileDialog_0 = new OpenFileDialog();
		colorDialog_0 = new ColorDialog();
		panel_0.SuspendLayout();
		toolStrip_0.SuspendLayout();
		SuspendLayout();
		panel_0.Controls.Add(toolStrip_0);
		panel_0.Dock = DockStyle.Top;
		panel_0.Location = new Point(0, 0);
		panel_0.Name = Class84.smethod_0(-994274131);
		panel_0.Size = new Size(922, 25);
		panel_0.TabIndex = 0;
		toolStrip_0.Items.AddRange(new ToolStripItem[10] { toolStripButton_0, toolStripButton_1, toolStripButton_2, toolStripSeparator_0, toolStripButton_3, toolStripButton_4, toolStripSeparator_1, toolStripButton_5, toolStripButton_6, toolStripButton_7 });
		toolStrip_0.Location = new Point(0, 0);
		toolStrip_0.Name = Class84.smethod_0(-994274085);
		toolStrip_0.Size = new Size(922, 25);
		toolStrip_0.TabIndex = 0;
		toolStrip_0.Text = Class84.smethod_0(-994274085);
		toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_0.Image = Class309.smethod_9();
		toolStripButton_0.ImageTransparentColor = Color.Magenta;
		toolStripButton_0.Name = Class84.smethod_0(-994274100);
		toolStripButton_0.Size = new Size(23, 22);
		toolStripButton_0.Text = Class84.smethod_0(-994274055);
		toolStripButton_0.Click += toolStripButton_0_Click;
		toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_1.Image = Class309.smethod_50();
		toolStripButton_1.ImageTransparentColor = Color.Magenta;
		toolStripButton_1.Name = Class84.smethod_0(-994274060);
		toolStripButton_1.Size = new Size(23, 22);
		toolStripButton_1.Text = Class84.smethod_0(-994274077);
		toolStripButton_1.Click += toolStripButton_1_Click;
		toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_2.Image = Class309.smethod_78();
		toolStripButton_2.ImageTransparentColor = Color.Magenta;
		toolStripButton_2.Name = Class84.smethod_0(-994274032);
		toolStripButton_2.Size = new Size(23, 22);
		toolStripButton_2.Text = Class84.smethod_0(-994274046);
		toolStripButton_2.Click += toolStripButton_2_Click;
		toolStripSeparator_0.Name = Class84.smethod_0(-994273998);
		toolStripSeparator_0.Size = new Size(6, 25);
		toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_3.Image = Class309.smethod_35();
		toolStripButton_3.ImageTransparentColor = Color.Magenta;
		toolStripButton_3.Name = Class84.smethod_0(-994273956);
		toolStripButton_3.Size = new Size(23, 22);
		toolStripButton_3.Text = Class84.smethod_0(-994273961);
		toolStripButton_3.Click += toolStripButton_3_Click;
		toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_4.Image = Class309.smethod_41();
		toolStripButton_4.ImageTransparentColor = Color.Magenta;
		toolStripButton_4.Name = Class84.smethod_0(-994273926);
		toolStripButton_4.Size = new Size(23, 22);
		toolStripButton_4.Text = Class84.smethod_0(-994273931);
		toolStripButton_4.Click += toolStripButton_4_Click;
		toolStripSeparator_1.Name = Class84.smethod_0(-994273894);
		toolStripSeparator_1.Size = new Size(6, 25);
		toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_5.Image = Class309.smethod_31();
		toolStripButton_5.ImageTransparentColor = Color.Magenta;
		toolStripButton_5.Name = Class84.smethod_0(-994273916);
		toolStripButton_5.Size = new Size(23, 22);
		toolStripButton_5.Text = Class84.smethod_0(-994273870);
		toolStripButton_5.Click += toolStripButton_5_Click;
		toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_6.Image = Class309.smethod_32();
		toolStripButton_6.ImageTransparentColor = Color.Magenta;
		toolStripButton_6.Name = Class84.smethod_0(-994273873);
		toolStripButton_6.Size = new Size(23, 22);
		toolStripButton_6.Text = Class84.smethod_0(-994273828);
		toolStripButton_6.Click += toolStripButton_6_Click;
		toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
		toolStripButton_7.Image = Class309.smethod_28();
		toolStripButton_7.ImageTransparentColor = Color.Magenta;
		toolStripButton_7.Name = Class84.smethod_0(-994273833);
		toolStripButton_7.Size = new Size(23, 22);
		toolStripButton_7.Text = Class84.smethod_0(-994273851);
		toolStripButton_7.Click += toolStripButton_7_Click;
		webBrowser_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
		webBrowser_0.Location = new Point(3, 31);
		webBrowser_0.MinimumSize = new Size(20, 20);
		webBrowser_0.Name = Class84.smethod_0(-994273807);
		webBrowser_0.Size = new Size(900, 636);
		webBrowser_0.TabIndex = 1;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		Controls.Add(webBrowser_0);
		Controls.Add(panel_0);
		Name = Class84.smethod_0(-994273821);
		Size = new Size(922, 670);
		Load += GControl1_Load;
		panel_0.ResumeLayout(performLayout: false);
		panel_0.PerformLayout();
		toolStrip_0.ResumeLayout(performLayout: false);
		toolStrip_0.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	private void webBrowser_0_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		object_0 = webBrowser_0.Document.DomDocument;
		if (Class179.callSite_0 == null)
		{
			Class179.callSite_0 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, Class84.smethod_0(-994273781), null, typeof(GControl1), new CSharpArgumentInfo[2]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
			}));
		}
		object_1 = ((dynamic)Class179.callSite_0.Target(Class179.callSite_0, (object)object_0, Class84.smethod_0(-994273738)))[0];
		if (Class179.callSite_2 == null)
		{
			Class179.callSite_2 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, Class84.smethod_0(-994273760), typeof(GControl1), new CSharpArgumentInfo[2]
			{
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
				CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
			}));
		}
		Class179.callSite_2.Target(Class179.callSite_2, (object)object_1, string.Empty);
	}
}
