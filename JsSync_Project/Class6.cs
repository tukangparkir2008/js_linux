using System;

internal abstract class Class6
{
	private readonly int int_0;

	private Type type_0;

	protected Class6(int int_1)
	{
		int_0 = int_1;
	}

	public static Class6 smethod_0(object object_0, Type type_1)
	{
		if (object_0 is Class6 result)
		{
			return result;
		}
		if ((object)type_1 == null)
		{
			if (object_0 == null)
			{
				return new Class8();
			}
			type_1 = object_0.GetType();
		}
		type_1 = Class99.smethod_2(type_1);
		Class6 @class;
		switch (Class99.smethod_6(type_1))
		{
		case 0:
			@class = new Class14();
			break;
		case 1:
		{
			Enum enum_ = ((object_0 != null) ? ((Enum)Enum.ToObject(type_1, object_0)) : ((Enum)Activator.CreateInstance(type_1)));
			return new Class15(enum_);
		}
		case 3:
			@class = new Class12();
			break;
		case 4:
			@class = new Class30();
			break;
		case 6:
			@class = new Class31();
			break;
		case 8:
			@class = new Class7();
			break;
		case 9:
		{
			Class8 class2 = new Class8();
			class2.method_2(type_1);
			@class = class2;
			break;
		}
		case 10:
			@class = new Class27();
			break;
		case 11:
			if (object_0 == null)
			{
				object_0 = Activator.CreateInstance(type_1);
			}
			else if ((object)object_0.GetType() != type_1)
			{
				try
				{
					object_0 = Convert.ChangeType(object_0, type_1);
				}
				catch
				{
				}
			}
			return new Class32(object_0);
		case 12:
			@class = new Class33();
			break;
		case 13:
			@class = new Class25();
			break;
		case 14:
			@class = new Class13();
			break;
		case 15:
			@class = new Class11();
			break;
		case 16:
			@class = new Class9();
			break;
		case 18:
			@class = new Class26();
			break;
		default:
			@class = new Class8();
			break;
		case 22:
			@class = new Class17();
			break;
		case 23:
			@class = new Class28();
			break;
		case 24:
			@class = new Class16();
			break;
		case 25:
			@class = new Class10();
			break;
		case 26:
			@class = new Class8();
			if (object_0 != null && (object)object_0.GetType() != Class99.type_0)
			{
				@class.method_2(object_0.GetType());
			}
			break;
		}
		if (object_0 != null)
		{
			@class.vmethod_1(object_0);
		}
		return @class;
	}

	public abstract object vmethod_0();

	public abstract void vmethod_1(object object_0);

	public int method_0()
	{
		return int_0;
	}

	public abstract Class6 vmethod_2(Class6 class6_0);

	public abstract Class6 vmethod_3();

	public Type method_1()
	{
		return type_0;
	}

	public void method_2(Type type_1)
	{
		type_0 = type_1;
	}
}
