using System;

public sealed class GEventArgs2 : EventArgs
{
	private readonly GEnum7 genum7_0;

	private readonly string string_0;

	private readonly Exception exception_0;

	public GEventArgs2(GEnum7 genum7_1, string string_1, Exception exception_1 = null)
	{
		genum7_0 = genum7_1;
		string_0 = string_1;
		exception_0 = exception_1;
	}

	public GEnum7 method_0()
	{
		return genum7_0;
	}

	public string method_1()
	{
		return string_0;
	}

	public Exception method_2()
	{
		return exception_0;
	}

	public override string ToString()
	{
		return string.Format(Class84.smethod_0(-994295171), genum7_0);
	}
}
