using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

internal sealed class Class119 : GClass0
{
	private static readonly Class119 class119_0 = new Class119();

	private Class119()
	{
		method_9(Class84.smethod_0(-994290111), Class84.smethod_0(-994274653));
		method_9(Class84.smethod_0(-994290063), Class84.smethod_0(-994273712));
		FontFamily[] families = FontFamily.Families;
		foreach (FontFamily fontFamily_ in families)
		{
			method_8(new Class346(fontFamily_));
		}
	}

	public static Class119 smethod_0()
	{
		return class119_0;
	}

	protected override GStruct3 vmethod_0(string string_0)
	{
		return Class237.smethod_10(Color.FromName(string_0));
	}

	protected override GClass19 vmethod_1(GStruct3 gstruct3_0)
	{
		return new Class171(new Pen(Class237.smethod_11(gstruct3_0)));
	}

	protected override GClass25 vmethod_2(GStruct3 gstruct3_0)
	{
		Brush brush_;
		if (gstruct3_0 == GStruct3.smethod_2())
		{
			brush_ = Brushes.White;
		}
		else if (gstruct3_0 == GStruct3.smethod_1())
		{
			brush_ = Brushes.Black;
		}
		else
		{
			brush_ = ((gstruct3_0.method_3() >= 1) ? new SolidBrush(Class237.smethod_11(gstruct3_0)) : Brushes.Transparent);
		}
		return new Class192(brush_, bool_1: false);
	}

	protected override GClass25 vmethod_3(GStruct1 gstruct1_0, GStruct3 gstruct3_0, GStruct3 gstruct3_1, double double_0)
	{
		return new Class192(new LinearGradientBrush(Class237.smethod_8(gstruct1_0), Class237.smethod_11(gstruct3_0), Class237.smethod_11(gstruct3_1), (float)double_0), bool_1: true);
	}

	protected override GClass29 vmethod_4(object object_0)
	{
		if (object_0 == null)
		{
			return null;
		}
		return new Class209((Image)object_0);
	}

	protected override GClass29 vmethod_5(Stream stream_0)
	{
		return new Class209(Image.FromStream(stream_0));
	}

	protected override GClass62 vmethod_6(string string_0, double double_0, GEnum14 genum14_0)
	{
		return new Class339(new Font(string_0, (float)double_0, (FontStyle)genum14_0));
	}

	protected override GClass62 vmethod_7(GClass68 gclass68_0, double double_0, GEnum14 genum14_0)
	{
		return new Class339(new Font(((Class346)gclass68_0).method_0(), (float)double_0, (FontStyle)genum14_0));
	}

	protected override object vmethod_8(string string_0, string string_1)
	{
		return Class189.smethod_0(string_0, string_1);
	}

	protected override void vmethod_9(string string_0)
	{
		Class189.smethod_2(string_0);
	}

	protected override void vmethod_10(string string_0, string string_1)
	{
		Class189.smethod_1(string_0, string_1);
	}

	protected override void vmethod_11(GClass29 gclass29_2)
	{
		Clipboard.SetImage(((Class209)gclass29_2).method_0());
	}

	protected override GClass42 vmethod_12()
	{
		return new Class269();
	}

	protected override void vmethod_13(GClass29 gclass29_2, string string_0, string string_1, GClass38 gclass38_0 = null)
	{
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		try
		{
			saveFileDialog.Filter = Class84.smethod_0(-994290079);
			saveFileDialog.FileName = string_0;
			saveFileDialog.DefaultExt = string_1;
			if (((gclass38_0 == null) ? saveFileDialog.ShowDialog() : saveFileDialog.ShowDialog(((Class255)gclass38_0).method_1())) == DialogResult.OK)
			{
				((Class209)gclass29_2).method_0().Save(saveFileDialog.FileName);
			}
		}
		finally
		{
			((IDisposable)saveFileDialog).Dispose();
		}
	}
}
