public struct GStruct0
{
	private readonly string string_0;

	private readonly bool bool_0;

	public GStruct0(string string_1, bool bool_1)
	{
		GClass24.smethod_3(string_1, Class84.smethod_0(-994295349));
		string_0 = string_1;
		bool_0 = bool_1;
	}

	public string method_0()
	{
		return string_0;
	}

	public bool method_1()
	{
		return bool_0;
	}

	public override string ToString()
	{
		return string_0 + (bool_0 ? Class84.smethod_0(-994295284) : string.Empty);
	}
}
