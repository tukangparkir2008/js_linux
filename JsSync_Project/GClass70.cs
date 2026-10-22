using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

public sealed class GClass70
{
	private int int_0;

	private string string_0;

	private object object_0;

	public int Value
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public object Data
	{
		[CompilerGenerated]
		get
		{
			return object_0;
		}
		[CompilerGenerated]
		set
		{
			object_0 = value;
		}
	}

	public GClass70()
	{
		Value = 0;
		Text = string.Empty;
		Data = string.Empty;
	}

	public GClass70(int int_1, string string_1)
	{
		Value = int_1;
		Text = string_1;
		Data = string.Empty;
	}

	public GClass70(int int_1, string string_1, object object_1)
	{
		Value = int_1;
		Text = string_1;
		Data = object_1;
	}

	public string method_0()
	{
		return JsonConvert.SerializeObject(this);
	}

	public static string smethod_0(int int_1, string string_1, object object_1)
	{
		return new GClass70(int_1, string_1, object_1).method_0();
	}

	public static GClass70 smethod_1(string string_1)
	{
		try
		{
			return JsonConvert.DeserializeObject<GClass70>(string_1);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994274747), ex.Message, ex);
			return null;
		}
	}
}
