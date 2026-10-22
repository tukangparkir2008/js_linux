using System;
using System.Runtime.CompilerServices;

internal sealed class Class15 : Class6
{
	private enum Enum0
	{
		Value
	}

	private Enum enum_0;

	public Class15()
		: base(1)
	{
	}

	public Class15(Enum enum_1)
		: this()
	{
		enum_0 = (Enum)(enum_1 ?? ((object)Enum0.Value));
	}

	public Enum method_3()
	{
		return enum_0;
	}

	public void method_4(Enum enum_1)
	{
		if (enum_1 == null)
		{
			throw new ArgumentException();
		}
		enum_0 = enum_1;
	}

	[SpecialName]
	public override object vmethod_0()
	{
		return method_3();
	}

	[SpecialName]
	public override void vmethod_1(object object_0)
	{
		method_4((Enum)Enum.Parse(method_3().GetType(), object_0.ToString()));
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		switch (class6_0.method_0())
		{
		case 22:
			method_4((Enum)Enum.ToObject(enum_0.GetType(), ((Class17)class6_0).method_3()));
			break;
		case 23:
			method_4((Enum)Enum.ToObject(enum_0.GetType(), ((Class28)class6_0).method_3()));
			break;
		case 26:
			method_4((Enum)Enum.ToObject(enum_0.GetType(), ((Class8)class6_0).method_3()));
			break;
		case 0:
			method_4((Enum)Enum.ToObject(enum_0.GetType(), ((Class14)class6_0).method_3()));
			break;
		case 1:
		{
			Type type = enum_0.GetType();
			Enum obj = ((Class15)class6_0).method_3();
			if ((object)obj.GetType() == type)
			{
				method_4(obj);
			}
			else
			{
				method_4((Enum)Enum.ToObject(type, obj));
			}
			break;
		}
		case 3:
			method_4((Enum)Enum.ToObject(enum_0.GetType(), ((Class12)class6_0).method_3()));
			break;
		case 6:
			method_4((Enum)Enum.ToObject(enum_0.GetType(), ((Class31)class6_0).method_3()));
			break;
		case 8:
			method_4((Enum)Enum.ToObject(enum_0.GetType(), ((Class7)class6_0).method_3()));
			break;
		case 10:
			method_4((Enum)Enum.ToObject(enum_0.GetType(), ((Class27)class6_0).method_3()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 12:
			method_4((Enum)Enum.ToObject(enum_0.GetType(), ((Class33)class6_0).method_3()));
			break;
		}
		return this;
	}

	public override Class6 vmethod_3()
	{
		Class15 @class = new Class15(enum_0);
		@class.method_2(method_1());
		return @class;
	}
}
