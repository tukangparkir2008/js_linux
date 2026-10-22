using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal static class Class51
{
	public static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		if (Class72.smethod_0())
		{
			_ = FieldInfo.GetFieldFromHandle(runtimeFieldHandle_0).MetadataToken;
		}
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}
}
