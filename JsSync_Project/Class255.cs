using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal sealed class Class255 : GClass38
{
	private readonly Control control_0;

	private readonly bool bool_0;

	public Class255(Control control_1, bool bool_1)
		: base(Class119.smethod_0())
	{
		GClass24.smethod_1(control_1, Class84.smethod_0(-994288514));
		control_0 = control_1;
		bool_0 = bool_1;
	}

	public Control method_1()
	{
		return control_0;
	}

	[SpecialName]
	public override GStruct2 vmethod_2()
	{
		return Class237.smethod_0(control_0.PointToClient(Control.MousePosition));
	}

	[SpecialName]
	public override bool vmethod_0()
	{
		return (Control.MouseButtons & MouseButtons.Left) != 0;
	}

	[SpecialName]
	public override bool vmethod_1()
	{
		return (Control.MouseButtons & MouseButtons.Right) != 0;
	}

	public override void vmethod_3()
	{
		control_0.Cursor = Cursors.Default;
	}

	public override void vmethod_4()
	{
		control_0.Cursor = Cursors.Hand;
	}

	public override void vmethod_5()
	{
		control_0.Cursor = Cursors.IBeam;
	}

	public override void vmethod_6(object object_0)
	{
		control_0.DoDragDrop(object_0, DragDropEffects.Copy);
	}

	public override void vmethod_7(string string_0, GClass62 gclass62_0, double double_0, out int int_0, out double double_1)
	{
		Class149 @class = new Class149(control_0.CreateGraphics(), bool_0, bool_4: true);
		try
		{
			@class.vmethod_8(string_0, gclass62_0, double_0, out int_0, out double_1);
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
	}

	public override void vmethod_8()
	{
		control_0.Invalidate();
	}
}
