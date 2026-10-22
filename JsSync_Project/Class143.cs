internal sealed class Class143
{
	private readonly Enum2 enum2_0;

	private readonly string string_0;

	public Class143(Enum2 enum2_1, string string_1)
	{
		enum2_0 = enum2_1;
		string_0 = string_1;
	}

	public Enum2 method_0()
	{
		return enum2_0;
	}

	public string method_1()
	{
		return string_0;
	}

	public static Class143 smethod_0(Enum2 enum2_1, string string_1, string string_2, string string_3)
	{
		return new Class143(enum2_1, Class312.smethod_0(enum2_1, string_1, string_2, string_3));
	}
}
