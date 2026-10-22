using System.Collections.Generic;

internal sealed class Class343
{
	private readonly string string_0;

	private readonly bool bool_0;

	private readonly Dictionary<string, string> dictionary_0;

	public Class343(string string_1, bool bool_1, Dictionary<string, string> dictionary_1 = null)
	{
		GClass24.smethod_3(string_1, Class84.smethod_0(-994295344));
		string_0 = string_1;
		bool_0 = bool_1;
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

	public bool method_3()
	{
		if (dictionary_0 != null)
		{
			return dictionary_0.Count > 0;
		}
		return false;
	}

	public bool method_4(string string_1)
	{
		if (dictionary_0 != null)
		{
			return dictionary_0.ContainsKey(string_1);
		}
		return false;
	}

	public string method_5(string string_1, string string_2)
	{
		if (dictionary_0 != null && dictionary_0.ContainsKey(string_1))
		{
			return dictionary_0[string_1];
		}
		return string_2;
	}

	public override string ToString()
	{
		return string.Format(Class84.smethod_0(-994293430), string_0);
	}
}
