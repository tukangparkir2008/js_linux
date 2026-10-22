using System;
using System.Drawing;
using System.Runtime.CompilerServices;

internal sealed class Class339 : GClass62
{
	private readonly Font font_0;

	private IntPtr intptr_0;

	private float float_0 = -1f;

	private float float_1 = -1f;

	private double double_0 = -1.0;

	public Class339(Font font_1)
	{
		font_0 = font_1;
	}

	public Font method_0()
	{
		return font_0;
	}

	public IntPtr method_1()
	{
		if (intptr_0 == IntPtr.Zero)
		{
			intptr_0 = font_0.ToHfont();
		}
		return intptr_0;
	}

	[SpecialName]
	public override double vmethod_0()
	{
		return font_0.Size;
	}

	[SpecialName]
	public override double vmethod_2()
	{
		return float_0;
	}

	[SpecialName]
	public override double vmethod_1()
	{
		return float_1;
	}

	[SpecialName]
	public override double vmethod_3()
	{
		return float_1 / 6f;
	}

	public override double vmethod_4(GClass14 gclass14_0)
	{
		if (double_0 < 0.0)
		{
			double_0 = gclass14_0.vmethod_7(Class84.smethod_0(-994263061), this).method_1();
		}
		return double_0;
	}

	internal void method_2(int int_0, int int_1)
	{
		float_1 = int_0;
		float_0 = int_1;
	}
}
