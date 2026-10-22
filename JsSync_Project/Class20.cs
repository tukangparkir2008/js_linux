using System;
using System.Reflection;

internal sealed class Class20 : Class18
{
	private object object_0;

	private FieldInfo fieldInfo_0;

	private Class18 class18_0;

	public Class20(FieldInfo fieldInfo_1, object object_1)
		: this()
	{
		method_6(fieldInfo_1);
		method_4(object_1);
	}

	public Class20(FieldInfo fieldInfo_1, object object_1, Class18 class18_1)
		: this(fieldInfo_1, object_1)
	{
		method_8(class18_1);
	}

	private Class20()
		: base(20)
	{
	}

	public object method_3()
	{
		return object_0;
	}

	private void method_4(object object_1)
	{
		object_0 = object_1;
	}

	public FieldInfo method_5()
	{
		return fieldInfo_0;
	}

	private void method_6(FieldInfo fieldInfo_1)
	{
		fieldInfo_0 = fieldInfo_1;
	}

	public Class18 method_7()
	{
		return class18_0;
	}

	private void method_8(Class18 class18_1)
	{
		class18_0 = class18_1;
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		if (class6_0.method_0() != 20)
		{
			throw new ArgumentOutOfRangeException();
		}
		Class20 @class = (Class20)class6_0;
		method_4(@class.method_3());
		method_6(@class.method_5());
		return this;
	}

	public override Class6 vmethod_3()
	{
		Class20 @class = new Class20();
		@class.method_4(method_3());
		@class.method_6(method_5());
		@class.method_8(method_7());
		@class.method_2(method_1());
		return @class;
	}
}
