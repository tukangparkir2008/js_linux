using System.Windows.Forms;

internal sealed class Class241
{
	public static bool smethod_0(TextBox textBox_0, string string_0, int int_0, int int_1)
	{
		if (textBox_0.Text.Trim().Length < int_0)
		{
			Class355.smethod_0(Class84.smethod_0(-994091975) + string_0 + Class84.smethod_0(-994091992) + int_0 + Class84.smethod_0(-994091951));
			return false;
		}
		if (textBox_0.Text.Trim().Length > int_1)
		{
			Class355.smethod_0(Class84.smethod_0(-994091975) + string_0 + Class84.smethod_0(-994091966) + int_1 + Class84.smethod_0(-994091951));
			return false;
		}
		return true;
	}

	public static bool smethod_1(TextBox textBox_0, string string_0, Control control_0)
	{
		if (textBox_0.Text.Trim().Length != 0)
		{
			return true;
		}
		Class355.smethod_0(string_0);
		control_0.Focus();
		return false;
	}

	public static bool smethod_2(ComboBox comboBox_0, string string_0, Control control_0)
	{
		if (comboBox_0.Items.Count != 0)
		{
			return true;
		}
		Class355.smethod_0(string_0);
		control_0.Focus();
		return false;
	}

	public static bool smethod_3(TextBox textBox_0, string string_0, Control control_0)
	{
		if (int.TryParse(textBox_0.Text, out var _))
		{
			return true;
		}
		return false;
	}

	public static bool smethod_4(string string_0, int int_0, int int_1)
	{
		if (int.TryParse(string_0, out var result))
		{
			if (int_0 <= result)
			{
				return int_1 >= result;
			}
			return false;
		}
		return false;
	}
}
