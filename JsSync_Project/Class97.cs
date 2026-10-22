using System;
using System.Threading;

internal static class Class97
{
	public static Interface6 smethod_0()
	{
		return smethod_1() ?? new Class41();
	}

	private static Interface6 smethod_1()
	{
		try
		{
			Class98 @class = new Class98();
			if (!smethod_3(@class))
			{
				@class.Dispose();
				return null;
			}
			return @class;
		}
		catch (Exception exception_) when (!smethod_2(exception_))
		{
			return null;
		}
	}

	private static bool smethod_2(Exception exception_0)
	{
		if (!(exception_0 is ThreadAbortException))
		{
			return exception_0 is ThreadInterruptedException;
		}
		return true;
	}

	private static bool smethod_3(Interface6 interface6_0)
	{
		byte[] array = new byte[3] { 0, 130, 255 };
		for (int i = 0; i < array.Length; i++)
		{
			byte byte_ = array[i];
			interface6_0.imethod_2(i, ref byte_);
		}
		if (interface6_0.imethod_0() != array.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				interface6_0.imethod_1(num, out var byte_2);
				if (byte_2 != array[num])
				{
					break;
				}
				num++;
				continue;
			}
			interface6_0.imethod_3();
			if (interface6_0.imethod_0() != 0)
			{
				return false;
			}
			return true;
		}
		return false;
	}
}
