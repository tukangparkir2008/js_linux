using System;

public sealed class GEventArgs4 : EventArgs
{
	private readonly bool bool_0;

	public GEventArgs4(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public bool method_0()
	{
		return bool_0;
	}

	public override string ToString()
	{
		return string.Format(Class84.smethod_0(-994295221), bool_0);
	}
}
