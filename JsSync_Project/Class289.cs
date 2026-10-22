using System;
using System.Reflection;

[DefaultMember("#=zAKt$Eys=")]
internal sealed class Class289
{
	private readonly string string_0;

	private readonly int int_0;

	private readonly int int_1;

	// C# has no syntax for parameterized property 'Item'.
	public char get_Item(int int_2)
	{
		if (int_2 < 0 || int_2 > int_1)
		{
			throw new ArgumentOutOfRangeException(Class84.smethod_0(-994208819), Class84.smethod_0(-994208776));
		}
		return string_0[int_0 + int_2];
	}

	public Class289(string string_1)
	{
		GClass24.smethod_1(string_1, Class84.smethod_0(-994208865));
		string_0 = string_1;
		int_0 = 0;
		int_1 = string_1.Length;
	}

	public Class289(string string_1, int int_2, int int_3)
	{
		GClass24.smethod_1(string_1, Class84.smethod_0(-994208865));
		if (int_2 >= 0 && int_2 < string_1.Length)
		{
			if (int_3 < 0 || int_2 + int_3 > string_1.Length)
			{
				throw new ArgumentOutOfRangeException(Class84.smethod_0(-994208814), Class84.smethod_0(-994208837));
			}
			string_0 = string_1;
			int_0 = int_2;
			int_1 = int_3;
			return;
		}
		throw new ArgumentOutOfRangeException(Class84.smethod_0(-994208896), Class84.smethod_0(-994208837));
	}

	public string method_0()
	{
		return string_0;
	}

	public int method_1()
	{
		return int_0;
	}

	public int method_2()
	{
		return int_1;
	}

	public bool method_3()
	{
		return int_1 < 1;
	}

	public bool method_4()
	{
		int num = 0;
		while (true)
		{
			if (num < int_1)
			{
				if (!char.IsWhiteSpace(string_0, int_0 + num))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public bool method_5()
	{
		if (int_1 < 1)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < int_1)
			{
				if (!char.IsWhiteSpace(string_0, int_0 + num))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public string method_6()
	{
		if (int_1 <= 0)
		{
			return string.Empty;
		}
		return string_0.Substring(int_0, int_1);
	}

	public string method_7(int int_2, int int_3)
	{
		if (int_2 >= 0 && int_2 <= int_1)
		{
			if (int_3 > int_1)
			{
				throw new ArgumentOutOfRangeException(Class84.smethod_0(-994208759));
			}
			if (int_2 + int_3 > int_1)
			{
				throw new ArgumentOutOfRangeException(Class84.smethod_0(-994208764));
			}
			return string_0.Substring(int_0 + int_2, int_3);
		}
		throw new ArgumentOutOfRangeException(Class84.smethod_0(-994208738));
	}

	public override string ToString()
	{
		return string.Format(Class84.smethod_0(-994208705), (int_1 > 0) ? string_0.Substring(int_0, int_1) : string.Empty);
	}
}
