using System;

public sealed class GEventArgs3 : EventArgs
{
	private readonly GStruct2 gstruct2_0;

	public GEventArgs3(GStruct2 gstruct2_1)
	{
		gstruct2_0 = gstruct2_1;
	}

	public double method_0()
	{
		return gstruct2_0.method_1();
	}

	public double method_1()
	{
		return gstruct2_0.method_3();
	}

	public override string ToString()
	{
		return string.Format(Class84.smethod_0(-994295187), gstruct2_0);
	}
}
