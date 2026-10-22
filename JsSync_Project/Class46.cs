using System;

internal sealed class Class46 : IEquatable<Class46>
{
	private int int_0 = 255;

	private int int_1 = 12;

	private int int_2 = 96;

	private int int_3 = 10;

	private int int_4 = 4;

	private static readonly Class46 class46_0 = new Class46();

	public int method_0()
	{
		return int_0;
	}

	public void method_1(int int_5)
	{
		int_0 = int_5;
	}

	public int method_2()
	{
		return int_1;
	}

	public void method_3(int int_5)
	{
		int_1 = int_5;
	}

	public int method_4()
	{
		return int_2;
	}

	public void method_5(int int_5)
	{
		int_2 = int_5;
	}

	public int method_6()
	{
		return int_3;
	}

	public void method_7(int int_5)
	{
		int_3 = int_5;
	}

	public int method_8()
	{
		return int_4;
	}

	public void method_9(int int_5)
	{
		int_4 = int_5;
	}

	public static Class46 smethod_0()
	{
		return class46_0;
	}

	public override bool Equals(object obj)
	{
		return smethod_1(this, obj as Class46);
	}

	public bool Equals(Class46 other)
	{
		return smethod_1(this, other);
	}

	public static bool smethod_1(Class46 class46_1, Class46 class46_2)
	{
		if (class46_1 == class46_2)
		{
			return true;
		}
		if (class46_1 != null && class46_2 != null)
		{
			if (class46_1.method_0() == class46_2.method_0() && class46_1.method_2() == class46_2.method_2() && class46_1.method_4() == class46_2.method_4() && class46_1.method_6() == class46_2.method_6())
			{
				return class46_1.method_8() == class46_2.method_8();
			}
			return false;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ((((-8832819 + method_0().GetHashCode()) * -1521134295 + method_2().GetHashCode()) * -1521134295 + method_4().GetHashCode()) * -1521134295 + method_6().GetHashCode()) * -1521134295 + method_8().GetHashCode();
	}
}
