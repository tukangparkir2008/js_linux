using System.Runtime.CompilerServices;

internal sealed class Class246 : Class245
{
	private GClass29 gclass29_0;

	private GStruct1 gstruct1_1;

	public Class246(Class197 class197_1)
		: base(class197_1)
	{
	}

	[SpecialName]
	public override GClass29 vmethod_2()
	{
		return gclass29_0;
	}

	[SpecialName]
	public override void vmethod_3(GClass29 gclass29_1)
	{
		gclass29_0 = gclass29_1;
	}

	[SpecialName]
	public override bool vmethod_4()
	{
		return true;
	}

	public GStruct1 method_26()
	{
		return gstruct1_1;
	}

	public void method_27(GStruct1 gstruct1_2)
	{
		gstruct1_1 = gstruct1_2;
	}

	public override string ToString()
	{
		return Class84.smethod_0(-994295388);
	}
}
