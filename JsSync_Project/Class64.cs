using System;
using System.Reflection;
using System.Security;

internal static class Class64
{
	private static readonly bool bool_0;

	static Class64()
	{
		bool_0 = smethod_0();
	}

	private static bool smethod_0()
	{
		try
		{
			if (Environment.Version.Major < 4)
			{
				return false;
			}
			Assembly assembly = typeof(Class104).Assembly;
			Assembly assembly2 = typeof(SecurityCriticalAttribute).Assembly;
			bool result = false;
			object[] customAttributes = assembly.GetCustomAttributes(inherit: false);
			int num = 0;
			while (true)
			{
				if (num < customAttributes.Length)
				{
					object obj = customAttributes[num];
					if (obj is AllowPartiallyTrustedCallersAttribute)
					{
						result = true;
					}
					else
					{
						Type type = obj.GetType();
						if ((object)type.Assembly == assembly2 && Class84.smethod_0(-994272839).Equals(type.FullName, StringComparison.Ordinal) && (byte)type.GetProperty(Class84.smethod_0(-994272810)).GetValue(obj, null) != 2)
						{
							break;
						}
					}
					num++;
					continue;
				}
				return result;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_1()
	{
		return bool_0;
	}
}
