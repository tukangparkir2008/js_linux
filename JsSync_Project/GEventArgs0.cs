using System;
using System.Collections.Generic;

public sealed class GEventArgs0 : EventArgs
{
	private readonly string string_0;

	private readonly Dictionary<string, string> dictionary_0;

	private string string_1;

	private string string_2;

	private GClass55 gclass55_0;

	internal GEventArgs0(string string_3, Dictionary<string, string> dictionary_1)
	{
		string_0 = string_3;
		dictionary_0 = dictionary_1;
	}

	public string method_0()
	{
		return string_0;
	}

	public Dictionary<string, string> method_1()
	{
		return dictionary_0;
	}

	public string method_2()
	{
		return string_1;
	}

	public void method_3(string string_3)
	{
		string_1 = string_3;
	}

	public string method_4()
	{
		return string_2;
	}

	public void method_5(string string_3)
	{
		string_2 = string_3;
	}

	public GClass55 method_6()
	{
		return gclass55_0;
	}

	public void method_7(GClass55 gclass55_1)
	{
		gclass55_0 = gclass55_1;
	}
}
