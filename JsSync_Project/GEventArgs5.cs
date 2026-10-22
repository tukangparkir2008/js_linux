using System;
using System.Collections.Generic;

public sealed class GEventArgs5 : EventArgs
{
	private bool bool_0;

	private readonly string string_0;

	private readonly Dictionary<string, string> dictionary_0;

	private readonly GDelegate10 gdelegate10_0;

	internal GEventArgs5(string string_1, Dictionary<string, string> dictionary_1, GDelegate10 gdelegate10_1)
	{
		string_0 = string_1;
		dictionary_0 = dictionary_1;
		gdelegate10_0 = gdelegate10_1;
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

	public void method_4()
	{
		bool_0 = true;
		gdelegate10_0(null, null, default);
	}

	public void method_5(string string_1)
	{
		GClass24.smethod_3(string_1, Class84.smethod_0(-994295290));
		bool_0 = true;
		gdelegate10_0(string_1, null, GStruct1.gstruct1_0);
	}

	public void method_6(string string_1, double double_0, double double_1, double double_2, double double_3)
	{
		GClass24.smethod_3(string_1, Class84.smethod_0(-994295290));
		bool_0 = true;
		gdelegate10_0(string_1, null, new GStruct1(double_0, double_1, double_2, double_3));
	}

	public void method_7(object object_0)
	{
		GClass24.smethod_1(object_0, Class84.smethod_0(-994295247));
		bool_0 = true;
		gdelegate10_0(null, object_0, GStruct1.gstruct1_0);
	}

	public void method_8(object object_0, double double_0, double double_1, double double_2, double double_3)
	{
		GClass24.smethod_1(object_0, Class84.smethod_0(-994295247));
		bool_0 = true;
		gdelegate10_0(null, object_0, new GStruct1(double_0, double_1, double_2, double_3));
	}
}
