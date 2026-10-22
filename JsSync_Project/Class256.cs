using System;
using System.Windows.Forms;

internal sealed class Class256
{
	public static bool smethod_0(string string_0)
	{
		string_0 = string_0.Trim();
		if (string_0.Length == 0)
		{
			return false;
		}
		bool flag = true;
		int num = 0;
		while (flag && num < string_0.Length)
		{
			int num2 = string_0[num];
			flag = num2 >= 43 && num2 <= 57;
			num++;
		}
		return flag;
	}

	public static bool smethod_1(string string_0)
	{
		string_0 = string_0.Trim();
		if (string_0.Length == 0)
		{
			return false;
		}
		bool flag = true;
		int num = 0;
		while (flag && num < string_0.Length)
		{
			int num2 = string_0[num];
			flag = num2 >= 48 && num2 <= 57;
			num++;
		}
		return flag;
	}

	public static bool smethod_2(string string_0, int int_0, int int_1)
	{
		string_0 = string_0.Trim();
		if (string_0.Length == 0)
		{
			return false;
		}
		double num = Convert.ToDouble(string_0);
		if (num >= (double)int_0)
		{
			return num <= (double)int_1;
		}
		return false;
	}

	public static bool smethod_3(string string_0, double double_0, double double_1)
	{
		string_0 = string_0.Trim();
		if (string_0.Length == 0)
		{
			return false;
		}
		double num = Convert.ToDouble(string_0);
		if (num >= double_0)
		{
			return num <= double_1;
		}
		return false;
	}

	public static bool smethod_4(TextBox textBox_0)
	{
		string text = textBox_0.Text.Trim();
		if (text.Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994091510));
			textBox_0.Focus();
			return false;
		}
		if (!smethod_0(text))
		{
			Class355.smethod_0(Class84.smethod_0(-994091467));
			textBox_0.Focus();
			return false;
		}
		if (!smethod_2(text, 0, 23))
		{
			Class355.smethod_0(Class84.smethod_0(-994091446));
			textBox_0.Focus();
			return false;
		}
		return true;
	}

	public static bool smethod_5(string string_0)
	{
		if (string_0.Length == 0)
		{
			return false;
		}
		if (!smethod_0(string_0))
		{
			return false;
		}
		if (!smethod_2(string_0, 0, 23))
		{
			return false;
		}
		return true;
	}

	public static bool smethod_6(string string_0)
	{
		if (string_0.Length == 0)
		{
			return false;
		}
		if (!smethod_0(string_0))
		{
			return false;
		}
		if (!smethod_2(string_0, 0, 59))
		{
			return false;
		}
		return true;
	}

	public static bool smethod_7(string string_0)
	{
		if (string_0.Length == 0)
		{
			return false;
		}
		if (!smethod_0(string_0))
		{
			return false;
		}
		if (!smethod_2(string_0, 1, 31))
		{
			return false;
		}
		return true;
	}

	public static bool smethod_8(string string_0)
	{
		if (string_0.Length == 0)
		{
			return false;
		}
		if (!smethod_0(string_0))
		{
			return false;
		}
		if (!smethod_2(string_0, 1, 12))
		{
			return false;
		}
		return true;
	}

	public static bool smethod_9(TextBox textBox_0)
	{
		string text = textBox_0.Text.Trim();
		if (text.Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994091510));
			textBox_0.Focus();
			return false;
		}
		if (!smethod_0(text))
		{
			Class355.smethod_0(Class84.smethod_0(-994091467));
			textBox_0.Focus();
			return false;
		}
		if (!smethod_2(text, 0, 59))
		{
			Class355.smethod_0(Class84.smethod_0(-994091362));
			textBox_0.Focus();
			return false;
		}
		return true;
	}

	public static bool smethod_10(string string_0)
	{
		if (string_0.Length == 0)
		{
			return false;
		}
		if (!smethod_0(string_0))
		{
			return false;
		}
		if (!smethod_2(string_0, 0, 59))
		{
			return false;
		}
		return true;
	}

	public static bool smethod_11(string string_0, string string_1, string string_2)
	{
		string_0 = string_0.Trim();
		string_1 = string_1.Trim();
		string_2 = string_2.Trim();
		if (string_0.Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994091358));
			return false;
		}
		if (string_1.Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994091327));
			return false;
		}
		if (string_2.Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994091294));
			return false;
		}
		if (!smethod_0(string_0))
		{
			Class355.smethod_0(Class84.smethod_0(-994091261));
			return false;
		}
		if (!smethod_2(string_0, 0, 23))
		{
			Class355.smethod_0(Class84.smethod_0(-994091172));
			return false;
		}
		if (!smethod_0(string_1))
		{
			Class355.smethod_0(Class84.smethod_0(-994091159));
			return false;
		}
		if (!smethod_2(string_1, 0, 59))
		{
			Class355.smethod_0(Class84.smethod_0(-994091132));
			return false;
		}
		if (!smethod_0(string_2))
		{
			Class355.smethod_0(Class84.smethod_0(-994091053));
			return false;
		}
		if (!smethod_2(string_2, 0, 59))
		{
			Class355.smethod_0(Class84.smethod_0(-994091026));
			return false;
		}
		return true;
	}

	public static bool smethod_12(string string_0, string string_1, string string_2)
	{
		string_0 = string_0.Trim();
		string_1 = string_1.Trim();
		string_2 = string_2.Trim();
		if (string_0.Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994095043));
			return false;
		}
		if (string_1.Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994095024));
			return false;
		}
		if (string_2.Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994094991));
			return false;
		}
		if (!smethod_0(string_2))
		{
			Class355.smethod_0(Class84.smethod_0(-994094958));
			return false;
		}
		if (!smethod_2(string_2, Class224.Class227.int_0, 2999))
		{
			Class355.smethod_0(Class84.smethod_0(-994094934) + Class224.Class227.int_0 + Class84.smethod_0(-994094900));
			return false;
		}
		if (!smethod_0(string_1))
		{
			Class355.smethod_0(Class84.smethod_0(-994094849));
			return false;
		}
		if (!smethod_2(string_1, 1, 12))
		{
			Class355.smethod_0(Class84.smethod_0(-994094825));
			return false;
		}
		int int_ = Convert.ToInt32(string_2);
		int int_2 = Convert.ToInt32(string_1);
		int int_3 = Class120.smethod_0(int_, int_2);
		if (!smethod_0(string_0))
		{
			Class355.smethod_0(Class84.smethod_0(-994094812));
			return false;
		}
		if (!smethod_2(string_0, 1, int_3))
		{
			Class355.smethod_0(Class84.smethod_0(-994094722) + int_3);
			return false;
		}
		return true;
	}
}
