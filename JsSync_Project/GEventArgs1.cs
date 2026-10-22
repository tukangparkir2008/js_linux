using System;
using System.Collections.Generic;

public sealed class GEventArgs1 : EventArgs
{
	private readonly string string_0;

	private readonly Dictionary<string, string> dictionary_0;

	private bool bool_0;

	public GEventArgs1(string string_1, Dictionary<string, string> dictionary_1)
	{
		string_0 = string_1;
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

	public bool method_2()
	{
		return bool_0;
	}

	public void method_3(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public override string ToString()
	{
		return string.Format(Class84.smethod_0(-994295251), string_0, bool_0);
	}
}
