public sealed class GClass33
{
	public readonly GEnum0 genum0_0;

	public readonly string string_0;

	public readonly string string_1;

	public readonly string string_2;

	public readonly string string_3;

	public readonly string string_4;

	public GClass33(GEnum0 genum0_1, string string_5, string string_6, string string_7)
	{
		genum0_0 = genum0_1;
		string_0 = string.Empty;
		string_1 = method_0(genum0_1);
		string_2 = string_5;
		string_4 = string_6;
		string_3 = string_7;
	}

	public GClass33(GEnum0 genum0_1, string string_5, string string_6, string string_7, string string_8)
	{
		genum0_0 = genum0_1;
		string_0 = string_5;
		string_1 = method_0(genum0_1);
		string_2 = string_6;
		string_4 = string_7;
		string_3 = string_8;
	}

	private string method_0(GEnum0 genum0_1)
	{
		switch (genum0_1)
		{
		default:
			return string.Empty;
		case GEnum0.Login:
		case GEnum0.Logout:
			return Class84.smethod_0(-994274718);
		case GEnum0.Info:
			return Class84.smethod_0(-994274665);
		case GEnum0.Error:
			return Class84.smethod_0(-994274659);
		case GEnum0.Scan:
			return Class84.smethod_0(-994274686);
		case GEnum0.Warn:
			return Class84.smethod_0(-994274627);
		case GEnum0.Started:
		case GEnum0.Stopped:
			return Class84.smethod_0(-994274648);
		}
	}
}
