using System;
using System.IO;

public static class GClass24
{
	public static void smethod_0<TException>(bool bool_0, string string_0) where TException : Exception, new()
	{
		if (!bool_0)
		{
			throw (TException)Activator.CreateInstance(typeof(TException), string_0);
		}
	}

	public static void smethod_1(object object_0, string string_0)
	{
		if (object_0 == null)
		{
			throw new ArgumentNullException(string_0);
		}
	}

	public static void smethod_2(IntPtr intptr_0, string string_0)
	{
		if (intptr_0 == IntPtr.Zero)
		{
			throw new ArgumentException(Class84.smethod_0(-994284624), string_0);
		}
	}

	public static void smethod_3(string string_0, string string_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentNullException(string_1);
		}
	}

	public static T smethod_4<T>(object object_0, string string_0)
	{
		smethod_1(object_0, string_0);
		if (!(object_0 is T))
		{
			throw new ArgumentException(string.Format(Class84.smethod_0(-994284587), typeof(T).Name), string_0);
		}
		return (T)object_0;
	}

	public static void smethod_5(string string_0, string string_1)
	{
		smethod_3(string_0, string_1);
		if (!File.Exists(string_0))
		{
			throw new FileNotFoundException(string.Format(Class84.smethod_0(-994284561), string_1), string_0);
		}
	}
}
