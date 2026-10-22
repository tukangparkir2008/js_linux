using System;

public sealed class GClass2
{
	private string string_0;

	private object object_0;

	public string method_0()
	{
		return string_0;
	}

	public void method_1(string string_1)
	{
		string_0 = string_1;
	}

	public object method_2()
	{
		return object_0;
	}

	public void method_3(object object_1)
	{
		object_0 = object_1;
	}

	public int method_4()
	{
		return Convert.ToInt32(method_2());
	}

	public string method_5()
	{
		return method_2().ToString();
	}

	public override string ToString()
	{
		return method_0();
	}
}
