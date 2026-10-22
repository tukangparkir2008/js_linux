public sealed class GClass34<T>
{
	private readonly string string_0;

	private readonly string string_1;

	private readonly T gparam_0;

	public GClass34(string string_2, string string_3, T gparam_1)
	{
		string_0 = string_2;
		string_1 = string_3;
		gparam_0 = gparam_1;
	}

	public string method_0()
	{
		return string_0;
	}

	public string method_1()
	{
		return string_1;
	}

	public T method_2()
	{
		return gparam_0;
	}

	public bool method_3()
	{
		if (string_1.Length > 0)
		{
			return string_1[0] == '#';
		}
		return false;
	}

	public string method_4()
	{
		if (method_3() && string_1.Length > 1)
		{
			return string_1.Substring(1);
		}
		return string.Empty;
	}

	public override string ToString()
	{
		return string.Format(Class84.smethod_0(-994295151), string_0, string_1, gparam_0);
	}
}
