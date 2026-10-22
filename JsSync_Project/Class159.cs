using System;

internal sealed class Class159
{
	public static int smethod_0(string string_0, int int_0)
	{
		try
		{
			return Convert.ToInt32(string_0);
		}
		catch (Exception)
		{
			return int_0;
		}
	}

	public static double smethod_1(string string_0, double double_0)
	{
		try
		{
			return Convert.ToDouble(string_0);
		}
		catch (Exception)
		{
			return double_0;
		}
	}

	public static long smethod_2(string string_0, long long_0)
	{
		try
		{
			return Convert.ToInt64(string_0);
		}
		catch (Exception)
		{
			return long_0;
		}
	}

	public static bool smethod_3(object object_0, bool bool_0)
	{
		try
		{
			return Convert.ToBoolean(object_0);
		}
		catch (Exception)
		{
			return bool_0;
		}
	}
}
