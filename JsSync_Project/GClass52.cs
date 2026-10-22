using System;

public sealed class GClass52
{
	public static int smethod_0(int int_0, float float_0)
	{
		return Convert.ToInt32((float)int_0 / 100f * float_0);
	}

	public static int smethod_1(int int_0, float float_0)
	{
		return Convert.ToInt32((float)int_0 / float_0 * 100f);
	}

	public static int smethod_2(int int_0, float float_0, float float_1)
	{
		if (float_0 == float_1)
		{
			return int_0;
		}
		return smethod_0(smethod_1(int_0, float_0), float_1);
	}
}
