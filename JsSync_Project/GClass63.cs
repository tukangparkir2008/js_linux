using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public sealed class GClass63 : IDisposable
{
	private readonly GClass31 gclass31_0;

	private bool bool_0;

	public GClass63()
	{
		gclass31_0 = new GClass31(Class119.smethod_0());
		gclass31_0.method_45(0);
		gclass31_0.method_36(new GStruct4(99999.0, 99999.0));
	}

	public void method_0(EventHandler eventHandler_0)
	{
		method_14().method_2(eventHandler_0);
	}

	public void method_1(EventHandler eventHandler_0)
	{
		method_14().method_3(eventHandler_0);
	}

	public void method_2(EventHandler<GEventArgs1> eventHandler_0)
	{
		gclass31_0.method_4(eventHandler_0);
	}

	public void method_3(EventHandler<GEventArgs1> eventHandler_0)
	{
		gclass31_0.method_5(eventHandler_0);
	}

	public void method_4(EventHandler<GEventArgs4> eventHandler_0)
	{
		gclass31_0.method_6(eventHandler_0);
	}

	public void method_5(EventHandler<GEventArgs4> eventHandler_0)
	{
		gclass31_0.method_7(eventHandler_0);
	}

	public void method_6(EventHandler<GEventArgs3> eventHandler_0)
	{
		gclass31_0.method_8(eventHandler_0);
	}

	public void method_7(EventHandler<GEventArgs3> eventHandler_0)
	{
		gclass31_0.method_9(eventHandler_0);
	}

	public void method_8(EventHandler<GEventArgs2> eventHandler_0)
	{
		gclass31_0.method_10(eventHandler_0);
	}

	public void method_9(EventHandler<GEventArgs2> eventHandler_0)
	{
		gclass31_0.method_11(eventHandler_0);
	}

	public void method_10(EventHandler<GEventArgs0> eventHandler_0)
	{
		gclass31_0.method_12(eventHandler_0);
	}

	public void method_11(EventHandler<GEventArgs0> eventHandler_0)
	{
		gclass31_0.method_13(eventHandler_0);
	}

	public void method_12(EventHandler<GEventArgs5> eventHandler_0)
	{
		gclass31_0.method_14(eventHandler_0);
	}

	public void method_13(EventHandler<GEventArgs5> eventHandler_0)
	{
		gclass31_0.method_15(eventHandler_0);
	}

	internal GClass31 method_14()
	{
		return gclass31_0;
	}

	public bool method_15()
	{
		return bool_0;
	}

	public void method_16(bool bool_1)
	{
		if (bool_0 != bool_1)
		{
			bool_0 = bool_1;
			gclass31_0.method_71(bool_6: true);
		}
	}

	public GClass55 method_17()
	{
		return gclass31_0.method_16();
	}

	public bool method_18()
	{
		return gclass31_0.method_17();
	}

	public void method_19(bool bool_1)
	{
		gclass31_0.method_18(bool_1);
	}

	public bool method_20()
	{
		return gclass31_0.method_19();
	}

	public void method_21(bool bool_1)
	{
		gclass31_0.method_20(bool_1);
	}

	public bool method_22()
	{
		return gclass31_0.method_21();
	}

	public void method_23(bool bool_1)
	{
		gclass31_0.method_22(bool_1);
	}

	public bool method_24()
	{
		return gclass31_0.method_23();
	}

	public void method_25(bool bool_1)
	{
		gclass31_0.method_24(bool_1);
	}

	public bool method_26()
	{
		return gclass31_0.method_25();
	}

	public void method_27(bool bool_1)
	{
		gclass31_0.method_26(bool_1);
	}

	public Point method_28()
	{
		return Class237.smethod_3(gclass31_0.method_27());
	}

	public void method_29(Point point_0)
	{
		gclass31_0.method_28(Class237.smethod_0(point_0));
	}

	public PointF method_30()
	{
		return Class237.smethod_2(gclass31_0.method_29());
	}

	public void method_31(PointF pointF_0)
	{
		gclass31_0.method_30(Class237.smethod_0(pointF_0));
	}

	public SizeF method_32()
	{
		return Class237.smethod_5(gclass31_0.method_31());
	}

	public void method_33(SizeF sizeF_0)
	{
		gclass31_0.method_32(Class237.smethod_4(sizeF_0));
	}

	public SizeF method_34()
	{
		return Class237.smethod_5(gclass31_0.method_33());
	}

	internal void method_35(SizeF sizeF_0)
	{
		gclass31_0.method_34(Class237.smethod_4(sizeF_0));
	}

	public string method_36()
	{
		return gclass31_0.method_46();
	}

	public string method_37()
	{
		return gclass31_0.method_47();
	}

	public void method_38()
	{
		method_14().method_55();
	}

	public void method_39(string string_0, GClass55 gclass55_0)
	{
		gclass31_0.method_53(string_0, gclass55_0);
	}

	public string method_40(GEnum3 genum3_0)
	{
		return gclass31_0.method_56(genum3_0);
	}

	public string method_41(Point point_0, string string_0)
	{
		return gclass31_0.method_57(Class237.smethod_0(point_0), string_0);
	}

	public List<GClass34<RectangleF>> method_42()
	{
		List<GClass34<RectangleF>> list = new List<GClass34<RectangleF>>();
		foreach (GClass34<GStruct1> item in method_14().method_58())
		{
			list.Add(new GClass34<RectangleF>(item.method_0(), item.method_1(), Class237.smethod_8(item.method_2())));
		}
		return list;
	}

	public string method_43(Point point_0)
	{
		return gclass31_0.method_59(Class237.smethod_0(point_0));
	}

	public RectangleF? method_44(string string_0)
	{
		GStruct1? gStruct = gclass31_0.method_60(string_0);
		if (!gStruct.HasValue)
		{
			return null;
		}
		return Class237.smethod_8(gStruct.Value);
	}

	public void method_45(Graphics graphics_0)
	{
		GClass24.smethod_1(graphics_0, Class84.smethod_0(-994288345));
		Class149 @class = new Class149(graphics_0, bool_0);
		try
		{
			gclass31_0.method_61(@class);
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
	}

	public void method_46(Graphics graphics_0)
	{
		GClass24.smethod_1(graphics_0, Class84.smethod_0(-994288345));
		Class149 @class = new Class149(graphics_0, bool_0);
		try
		{
			gclass31_0.method_62(@class);
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
	}

	public void method_47(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		GClass24.smethod_1(control_0, Class84.smethod_0(-994289776));
		GClass24.smethod_1(mouseEventArgs_0, Class84.smethod_0(-994282804));
		gclass31_0.method_63(new Class255(control_0, bool_0), Class237.smethod_0(mouseEventArgs_0.Location));
	}

	public void method_48(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		GClass24.smethod_1(control_0, Class84.smethod_0(-994289776));
		GClass24.smethod_1(mouseEventArgs_0, Class84.smethod_0(-994282804));
		gclass31_0.method_64(new Class255(control_0, bool_0), Class237.smethod_0(mouseEventArgs_0.Location), smethod_0(mouseEventArgs_0));
	}

	public void method_49(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		GClass24.smethod_1(control_0, Class84.smethod_0(-994289776));
		GClass24.smethod_1(mouseEventArgs_0, Class84.smethod_0(-994282804));
		gclass31_0.method_65(new Class255(control_0, bool_0), Class237.smethod_0(mouseEventArgs_0.Location));
	}

	public void method_50(Control control_0, MouseEventArgs mouseEventArgs_0)
	{
		GClass24.smethod_1(control_0, Class84.smethod_0(-994289776));
		GClass24.smethod_1(mouseEventArgs_0, Class84.smethod_0(-994282804));
		gclass31_0.method_66(new Class255(control_0, bool_0), Class237.smethod_0(mouseEventArgs_0.Location));
	}

	public void method_51(Control control_0)
	{
		GClass24.smethod_1(control_0, Class84.smethod_0(-994289776));
		gclass31_0.method_67(new Class255(control_0, bool_0));
	}

	public void method_52(Control control_0, KeyEventArgs keyEventArgs_0)
	{
		GClass24.smethod_1(control_0, Class84.smethod_0(-994289776));
		GClass24.smethod_1(keyEventArgs_0, Class84.smethod_0(-994282804));
		gclass31_0.method_68(new Class255(control_0, bool_0), smethod_1(keyEventArgs_0));
	}

	public void Dispose()
	{
		gclass31_0.Dispose();
	}

	private static GClass8 smethod_0(MouseEventArgs mouseEventArgs_0)
	{
		return new GClass8((mouseEventArgs_0.Button & MouseButtons.Left) != 0);
	}

	private static GClass13 smethod_1(KeyEventArgs keyEventArgs_0)
	{
		return new GClass13(keyEventArgs_0.Control, keyEventArgs_0.KeyCode == Keys.A, keyEventArgs_0.KeyCode == Keys.C);
	}
}
