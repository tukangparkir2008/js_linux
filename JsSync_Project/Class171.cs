using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

internal sealed class Class171 : GClass19
{
	private readonly Pen pen_0;

	public Class171(Pen pen_1)
	{
		pen_0 = pen_1;
	}

	public Pen method_0()
	{
		return pen_0;
	}

	[SpecialName]
	public override double vmethod_0()
	{
		return pen_0.Width;
	}

	[SpecialName]
	public override void vmethod_1(double double_0)
	{
		pen_0.Width = (float)double_0;
	}

	[SpecialName]
	public override void vmethod_2(GEnum4 genum4_0)
	{
		switch (genum4_0)
		{
		default:
			pen_0.DashStyle = DashStyle.Solid;
			break;
		case (GEnum4)0:
			pen_0.DashStyle = DashStyle.Solid;
			break;
		case (GEnum4)1:
			pen_0.DashStyle = DashStyle.Dash;
			if (vmethod_0() < 2.0)
			{
				pen_0.DashPattern = new float[2] { 4f, 4f };
			}
			break;
		case (GEnum4)2:
			pen_0.DashStyle = DashStyle.Dot;
			break;
		case (GEnum4)3:
			pen_0.DashStyle = DashStyle.DashDot;
			break;
		case (GEnum4)4:
			pen_0.DashStyle = DashStyle.DashDotDot;
			break;
		case (GEnum4)5:
			pen_0.DashStyle = DashStyle.Custom;
			break;
		}
	}
}
