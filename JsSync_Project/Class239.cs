using System;
using System.Globalization;

internal sealed class Class239
{
	private readonly double double_0;

	private readonly bool bool_0;

	private readonly Enum4 enum4_0;

	private readonly string string_0;

	private readonly bool bool_1;

	private readonly bool bool_2;

	public Class239(string string_1)
	{
		string_0 = string_1;
		double_0 = 0.0;
		enum4_0 = (Enum4)0;
		bool_1 = false;
		if (string.IsNullOrEmpty(string_1) || string_1 == Class84.smethod_0(-994274584))
		{
			return;
		}
		if (string_1.EndsWith(Class84.smethod_0(-994264352)))
		{
			double_0 = Class172.smethod_3(string_1, 1.0);
			bool_1 = true;
			return;
		}
		if (string_1.Length < 3)
		{
			double.TryParse(string_1, out double_0);
			bool_2 = true;
			return;
		}
		string text = string_1.Substring(string_1.Length - 2, 2);
		string s = string_1.Substring(0, string_1.Length - 2);
		if (text != null)
		{
			int length = text.Length;
			if (length == 2)
			{
				char c = text[0];
				if ((uint)c <= 101u)
				{
					if (c != 'c')
					{
						if (c == 'e')
						{
							if (!(text == Class84.smethod_0(-994292181)))
							{
								if (!(text == Class84.smethod_0(-994295577)))
								{
									goto IL_0215;
								}
								enum4_0 = (Enum4)3;
								bool_0 = true;
							}
							else
							{
								enum4_0 = (Enum4)1;
								bool_0 = true;
							}
							goto IL_01f8;
						}
					}
					else if (text == Class84.smethod_0(-994295493))
					{
						enum4_0 = (Enum4)5;
						goto IL_01f8;
					}
				}
				else if (c != 'i')
				{
					if (c != 'm')
					{
						if (c == 'p')
						{
							if (!(text == Class84.smethod_0(-994295536)))
							{
								if (!(text == Class84.smethod_0(-994292141)))
								{
									if (!(text == Class84.smethod_0(-994295543)))
									{
										goto IL_0215;
									}
									enum4_0 = (Enum4)8;
								}
								else
								{
									enum4_0 = (Enum4)7;
								}
							}
							else
							{
								enum4_0 = (Enum4)2;
								bool_0 = true;
							}
							goto IL_01f8;
						}
					}
					else if (text == Class84.smethod_0(-994295550))
					{
						enum4_0 = (Enum4)6;
						goto IL_01f8;
					}
				}
				else if (text == Class84.smethod_0(-994295500))
				{
					enum4_0 = (Enum4)4;
					goto IL_01f8;
				}
			}
		}
		goto IL_0215;
		IL_0215:
		bool_2 = true;
		return;
		IL_01f8:
		if (!double.TryParse(s, NumberStyles.Number, NumberFormatInfo.InvariantInfo, out double_0))
		{
			bool_2 = true;
		}
	}

	public double method_0()
	{
		return double_0;
	}

	public bool method_1()
	{
		return bool_2;
	}

	public bool method_2()
	{
		return bool_1;
	}

	public bool method_3()
	{
		return bool_0;
	}

	public Enum4 method_4()
	{
		return enum4_0;
	}

	public string method_5()
	{
		return string_0;
	}

	public Class239 method_6(double double_1)
	{
		if (method_1())
		{
			throw new InvalidOperationException(Class84.smethod_0(-994295507));
		}
		if (method_4() != (Enum4)1)
		{
			throw new InvalidOperationException(Class84.smethod_0(-994295470));
		}
		return new Class239(string.Format(Class84.smethod_0(-994295427), Convert.ToSingle(method_0() * double_1).ToString(Class84.smethod_0(-994295447), NumberFormatInfo.InvariantInfo)));
	}

	public Class239 method_7(double double_1)
	{
		if (method_1())
		{
			throw new InvalidOperationException(Class84.smethod_0(-994295507));
		}
		if (method_4() != (Enum4)1)
		{
			throw new InvalidOperationException(Class84.smethod_0(-994295470));
		}
		return new Class239(string.Format(Class84.smethod_0(-994292161), Convert.ToSingle(method_0() * double_1).ToString(Class84.smethod_0(-994295447), NumberFormatInfo.InvariantInfo)));
	}

	public override string ToString()
	{
		if (method_1())
		{
			return string.Empty;
		}
		if (method_2())
		{
			return string.Format(NumberFormatInfo.InvariantInfo, Class84.smethod_0(-994295453), method_0());
		}
		string arg = string.Empty;
		switch (method_4())
		{
		case (Enum4)1:
			arg = Class84.smethod_0(-994292181);
			break;
		case (Enum4)2:
			arg = Class84.smethod_0(-994295536);
			break;
		case (Enum4)3:
			arg = Class84.smethod_0(-994295577);
			break;
		case (Enum4)4:
			arg = Class84.smethod_0(-994295500);
			break;
		case (Enum4)5:
			arg = Class84.smethod_0(-994295493);
			break;
		case (Enum4)6:
			arg = Class84.smethod_0(-994295550);
			break;
		case (Enum4)7:
			arg = Class84.smethod_0(-994292141);
			break;
		case (Enum4)8:
			arg = Class84.smethod_0(-994295543);
			break;
		}
		return string.Format(NumberFormatInfo.InvariantInfo, Class84.smethod_0(-994295394), method_0(), arg);
	}
}
