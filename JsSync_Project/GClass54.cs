using System;
using System.IO;
using System.Net;

public class GClass54 : GClass53
{
	private readonly GClass12 gclass12_0;

	private bool bool_9;

	public GClass54(IPAddress ipaddress_0, int int_3)
		: base(ipaddress_0, int_3)
	{
		gclass12_0 = new GClass12();
	}

	public GClass54(string string_0, int int_3)
		: base(string_0, int_3)
	{
		gclass12_0 = new GClass12();
	}

	public GClass54(IPEndPoint ipendPoint_1)
		: base(ipendPoint_1)
	{
		gclass12_0 = new GClass12();
	}

	public GClass12 method_39()
	{
		return gclass12_0;
	}

	public void method_40(string string_0, string string_1, string string_2, TimeSpan? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			nullable_0 = TimeSpan.FromHours(1.0);
		}
		method_39().method_5(string_0, string_1, string_2, nullable_0.Value, smethod_0);
	}

	public void method_41(string string_0)
	{
		method_39().method_7(string_0);
	}

	public void method_42()
	{
		method_39().method_8();
	}

	protected override GClass44 vmethod_4()
	{
		return new GClass45(this);
	}

	protected override void vmethod_18(bool bool_10)
	{
		if (!bool_9)
		{
			if (bool_10)
			{
				method_39().Dispose();
			}
			bool_9 = true;
		}
		base.vmethod_18(bool_10);
	}

	internal static bool smethod_0(GClass12 gclass12_1, string string_0, byte[] byte_0, TimeSpan timeSpan_0)
	{
		GClass21 gClass = new GClass21();
		gClass.method_13(200, Class84.smethod_0(-994207750));
		gClass.method_15(Path.GetExtension(string_0));
		gClass.method_16(Class84.smethod_0(-994212900), string.Format(Class84.smethod_0(-994212928), timeSpan_0.Seconds));
		gClass.method_19(byte_0);
		return gclass12_1.method_2(string_0, gClass.method_11().method_1(), timeSpan_0);
	}
}
