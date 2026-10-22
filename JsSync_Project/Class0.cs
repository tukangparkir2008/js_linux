using System;
using System.Diagnostics;

internal static class Class0
{
	private static readonly bool bool_0;

	private static readonly bool bool_1;

	static Class0()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		bool_0 = oSVersion.Platform == PlatformID.Win32NT && oSVersion.Version >= new Version(6, 0);
		if (smethod_0())
		{
			try
			{
				bool_1 = smethod_2(oSVersion);
			}
			catch
			{
				bool_1 = false;
			}
		}
	}

	public static bool smethod_0()
	{
		return bool_0;
	}

	public static bool smethod_1()
	{
		return bool_1;
	}

	private static bool smethod_2(OperatingSystem operatingSystem_0)
	{
		if (operatingSystem_0.Platform == PlatformID.Win32NT && operatingSystem_0.Version < new Version(6, 2, 9200) && Process.GetCurrentProcess().SessionId == 0)
		{
			return false;
		}
		return true;
	}
}
