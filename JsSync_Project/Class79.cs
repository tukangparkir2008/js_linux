using System;

internal static class Class79
{
	public static bool smethod_0(Type type_0, Type type_1, out int int_0)
	{
		int_0 = 0;
		if ((object)type_0 == type_1)
		{
			int_0 = 1;
			return true;
		}
		if ((object)type_0 != null && (object)type_1 != null)
		{
			if (type_0.IsByRef)
			{
				if (!type_1.IsByRef)
				{
					return false;
				}
				return smethod_0(type_0.GetElementType(), type_1.GetElementType(), out int_0);
			}
			if (type_1.IsByRef)
			{
				return false;
			}
			if (type_0.IsPointer)
			{
				if (!type_1.IsPointer)
				{
					return false;
				}
				return smethod_0(type_0.GetElementType(), type_1.GetElementType(), out int_0);
			}
			if (type_1.IsPointer)
			{
				return false;
			}
			if (type_0.IsArray)
			{
				if (!type_1.IsArray)
				{
					return false;
				}
				if (type_0.GetArrayRank() != type_1.GetArrayRank())
				{
					return false;
				}
				return smethod_0(type_0.GetElementType(), type_1.GetElementType(), out int_0);
			}
			if (type_1.IsArray)
			{
				return false;
			}
			if (type_0.IsGenericType != type_1.IsGenericType)
			{
				return false;
			}
			if (type_0.IsGenericType)
			{
				Type type = (type_0.IsGenericTypeDefinition ? type_0 : type_0.GetGenericTypeDefinition());
				Type type2 = (type_1.IsGenericTypeDefinition ? type_1 : type_1.GetGenericTypeDefinition());
				if ((object)type != type2)
				{
					return false;
				}
				Type[] genericArguments = type_0.GetGenericArguments();
				Type[] genericArguments2 = type_1.GetGenericArguments();
				if (genericArguments.Length != genericArguments2.Length)
				{
					return false;
				}
				for (int i = 0; i < genericArguments.Length; i++)
				{
					if (smethod_0(genericArguments[i], genericArguments2[i], out var int_1))
					{
						int_0 += int_1;
					}
				}
			}
			else if ((object)type_0 != type_1)
			{
				return false;
			}
			int_0++;
			return true;
		}
		return false;
	}
}
