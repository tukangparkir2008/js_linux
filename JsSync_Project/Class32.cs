using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal sealed class Class32 : Class6
{
	private object object_0;

	public Class32(object object_1)
		: base(11)
	{
		if (object_1 != null && !(object_1 is ValueType))
		{
			throw new ArgumentException();
		}
		object_0 = object_1;
	}

	public object method_3()
	{
		return object_0;
	}

	public void method_4(object object_1)
	{
		if (object_1 != null && !(object_1 is ValueType))
		{
			throw new ArgumentException();
		}
		object_0 = object_1;
	}

	[SpecialName]
	public override object vmethod_0()
	{
		return method_3();
	}

	[SpecialName]
	public override void vmethod_1(object object_1)
	{
		method_4(object_1);
	}

	private static bool smethod_1(Type type_1)
	{
		if (type_1.IsGenericType && type_1.Namespace == Class84.smethod_0(-994275050))
		{
			string name = type_1.Name;
			if (name == Class84.smethod_0(-994275069) || name == Class84.smethod_0(-994275024))
			{
				return false;
			}
		}
		return true;
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		switch (class6_0.method_0())
		{
		default:
			method_4(class6_0.vmethod_0());
			break;
		case 26:
			method_4(((Class8)class6_0).method_3());
			break;
		case 11:
		{
			object obj = ((Class32)class6_0).method_3();
			object obj2 = method_3();
			if (obj2 != null && obj != null)
			{
				Type type = obj2.GetType();
				if (!type.IsPrimitive && !type.IsEnum && (object)type == obj.GetType() && smethod_1(type))
				{
					FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					foreach (FieldInfo fieldInfo in fields)
					{
						fieldInfo.SetValue(obj2, fieldInfo.GetValue(obj));
					}
					break;
				}
			}
			method_4(obj);
			break;
		}
		}
		return this;
	}

	public override Class6 vmethod_3()
	{
		Class32 @class = new Class32(object_0);
		@class.method_2(method_1());
		return @class;
	}
}
