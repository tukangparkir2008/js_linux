using System;

internal static class Class72
{
	private static readonly bool bool_0;

	static Class72()
	{
		try
		{
			bool_0 = (object)Type.GetType(Class84.smethod_0(-994272874)) != null;
		}
		catch
		{
			bool_0 = false;
		}
	}

	public static bool smethod_0()
	{
		return bool_0;
	}
}
