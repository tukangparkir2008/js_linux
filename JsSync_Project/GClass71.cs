using System.Drawing;
using System.Windows.Forms;

public sealed class GClass71
{
	private readonly int int_0;

	private readonly int int_1;

	private readonly int int_2;

	private readonly int int_3;

	private readonly int int_4;

	private readonly int int_5;

	private readonly float float_0;

	private readonly float float_1;

	private readonly float float_2;

	private readonly float float_3;

	public GClass71(Control control_0, int int_6, int int_7, int int_8, float float_4)
	{
		Graphics graphics = control_0.CreateGraphics();
		float_2 = graphics.DpiX;
		float_3 = graphics.DpiY;
		float_0 = float_4;
		float_1 = float_4;
		if (int_8 == 0)
		{
			int_1 = GClass52.smethod_0(int_6, float_0);
			int_0 = GClass52.smethod_0(int_7, float_1);
		}
		else
		{
			int_1 = GClass52.smethod_0(int_7, float_0);
			int_0 = GClass52.smethod_0(int_6, float_1);
		}
		int_2 = (int)(0.05 * (double)int_1);
		int_3 = (int)(0.05 * (double)int_0);
		int_4 = (int)(0.05 * (double)int_1);
		int_5 = (int)(0.07 * (double)int_0);
	}

	public float method_0()
	{
		return float_0;
	}

	public float method_1()
	{
		return float_1;
	}

	public float method_2()
	{
		return float_2;
	}

	public float method_3()
	{
		return float_3;
	}

	public int method_4()
	{
		return int_0;
	}

	public int method_5()
	{
		return int_1;
	}

	public int method_6()
	{
		return int_2;
	}

	public int method_7()
	{
		return int_4;
	}

	public int method_8()
	{
		return int_3;
	}

	public int method_9()
	{
		return int_5;
	}

	public int method_10()
	{
		return method_5() - method_6() - method_7();
	}

	public int method_11()
	{
		return method_4() - method_8() - method_9() + 10;
	}
}
