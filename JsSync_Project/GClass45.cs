public class GClass45 : GClass44
{
	private readonly GClass12 gclass12_0;

	private readonly GClass61 gclass61_0;

	private readonly GClass21 gclass21_0;

	public GClass45(GClass54 gclass54_0)
		: base(gclass54_0)
	{
		gclass12_0 = gclass54_0.method_39();
		gclass61_0 = new GClass61();
		gclass21_0 = new GClass21();
	}

	public GClass12 method_30()
	{
		return gclass12_0;
	}

	protected GClass61 method_31()
	{
		return gclass61_0;
	}

	public GClass21 method_32()
	{
		return gclass21_0;
	}

	public long method_33()
	{
		return method_34(method_32());
	}

	public long method_34(GClass21 gclass21_1)
	{
		return vmethod_2(gclass21_1.method_11().method_1(), gclass21_1.method_11().method_4(), gclass21_1.method_11().method_3());
	}

	public long method_35(string string_0)
	{
		return vmethod_3(string_0);
	}

	public long method_36(byte[] byte_0)
	{
		return vmethod_1(byte_0);
	}

	public long method_37(byte[] byte_0, long long_5, long long_6)
	{
		return vmethod_2(byte_0, long_5, long_6);
	}

	public bool method_38()
	{
		return method_39(method_32());
	}

	public bool method_39(GClass21 gclass21_1)
	{
		return vmethod_5(gclass21_1.method_11().method_1(), gclass21_1.method_11().method_4(), gclass21_1.method_11().method_3());
	}

	public bool method_40(string string_0)
	{
		return vmethod_6(string_0);
	}

	public bool method_41(byte[] byte_0)
	{
		return vmethod_4(byte_0);
	}

	public bool method_42(byte[] byte_0, long long_5, long long_6)
	{
		return vmethod_5(byte_0, long_5, long_6);
	}

	protected override void vmethod_15(byte[] byte_0, long long_5, long long_6)
	{
		if (method_31().method_33())
		{
			if (method_31().method_35(byte_0, (int)long_5, (int)long_6))
			{
				vmethod_20(method_31());
			}
			long_6 = 0L;
		}
		if (method_31().method_1())
		{
			vmethod_22(method_31(), Class84.smethod_0(-994212878));
			method_31().method_13();
			vmethod_0();
		}
		else if (method_31().method_36(byte_0, (int)long_5, (int)long_6))
		{
			method_43(method_31());
			method_31().method_13();
		}
		else if (method_31().method_1())
		{
			vmethod_22(method_31(), Class84.smethod_0(-994212878));
			method_31().method_13();
			vmethod_0();
		}
	}

	protected override void vmethod_14()
	{
		if (method_31().method_34())
		{
			method_43(method_31());
			method_31().method_13();
		}
	}

	protected virtual void vmethod_20(GClass61 gclass61_1)
	{
	}

	protected virtual void vmethod_21(GClass61 gclass61_1)
	{
	}

	protected virtual void vmethod_22(GClass61 gclass61_1, string string_0)
	{
	}

	private void method_43(GClass61 gclass61_1)
	{
		if (gclass61_1.method_3() == Class84.smethod_0(-994207767))
		{
			(bool, byte[]) tuple = method_30().method_3(gclass61_1.method_4());
			if (tuple.Item1)
			{
				vmethod_4(tuple.Item2);
				return;
			}
		}
		vmethod_21(gclass61_1);
	}
}
