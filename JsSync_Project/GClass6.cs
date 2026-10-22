using System;
using System.Collections.Generic;

public sealed class GClass6
{
	private int int_0;

	private string string_0;

	private string string_1;

	private int int_1;

	private string string_2;

	private List<Tuple<int, string>> list_0;

	public GClass6(int int_2, string string_3, string string_4, int int_3, string string_5, List<Tuple<int, string>> list_1)
	{
		method_1(int_2);
		method_3(string_3);
		method_5(string_4);
		method_7(int_3);
		method_9(string_5);
		method_11(list_1);
	}

	public int method_0()
	{
		return int_0;
	}

	private void method_1(int int_2)
	{
		int_0 = int_2;
	}

	public string method_2()
	{
		return string_0;
	}

	private void method_3(string string_3)
	{
		string_0 = string_3;
	}

	public string method_4()
	{
		return string_1;
	}

	private void method_5(string string_3)
	{
		string_1 = string_3;
	}

	public int method_6()
	{
		return int_1;
	}

	private void method_7(int int_2)
	{
		int_1 = int_2;
	}

	public string method_8()
	{
		return string_2;
	}

	public void method_9(string string_3)
	{
		string_2 = string_3;
	}

	public List<Tuple<int, string>> method_10()
	{
		return list_0;
	}

	private void method_11(List<Tuple<int, string>> list_1)
	{
		list_0 = list_1;
	}

	public string method_12()
	{
		string text = string.Empty;
		foreach (Tuple<int, string> item in method_10())
		{
			if (text != string.Empty)
			{
				text += Class84.smethod_0(-994279022);
			}
			text = text + Class84.smethod_0(-994271698) + item.Item2 + Class84.smethod_0(-994271698);
		}
		if (text.Length != 0)
		{
			return text;
		}
		return Class84.smethod_0(-994288741);
	}
}
