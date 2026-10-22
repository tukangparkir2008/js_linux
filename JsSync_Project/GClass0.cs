using System;
using System.Collections.Generic;
using System.IO;

public abstract class GClass0
{
	private readonly Dictionary<GStruct3, GClass25> dictionary_0 = new Dictionary<GStruct3, GClass25>();

	private readonly Dictionary<GStruct3, GClass19> dictionary_1 = new Dictionary<GStruct3, GClass19>();

	private readonly Class262 class262_0;

	private GClass55 gclass55_0;

	private GClass29 gclass29_0;

	private GClass29 gclass29_1;

	protected GClass0()
	{
		class262_0 = new Class262(this);
	}

	public GClass55 method_0()
	{
		return gclass55_0 ?? (gclass55_0 = GClass55.smethod_0(this, Class84.smethod_0(-994288310), bool_0: false));
	}

	public GStruct3 method_1(string string_0)
	{
		GClass24.smethod_3(string_0, Class84.smethod_0(-994290267));
		return vmethod_0(string_0);
	}

	public GClass19 method_2(GStruct3 gstruct3_0)
	{
		if (!dictionary_1.TryGetValue(gstruct3_0, out var value))
		{
			value = (dictionary_1[gstruct3_0] = vmethod_1(gstruct3_0));
		}
		return value;
	}

	public GClass25 method_3(GStruct3 gstruct3_0)
	{
		if (!dictionary_0.TryGetValue(gstruct3_0, out var value))
		{
			value = (dictionary_0[gstruct3_0] = vmethod_2(gstruct3_0));
		}
		return value;
	}

	public GClass25 method_4(GStruct1 gstruct1_0, GStruct3 gstruct3_0, GStruct3 gstruct3_1, double double_0)
	{
		return vmethod_3(gstruct1_0, gstruct3_0, gstruct3_1, double_0);
	}

	public GClass29 method_5(object object_0)
	{
		return vmethod_4(object_0);
	}

	public GClass29 method_6(Stream stream_0)
	{
		return vmethod_5(stream_0);
	}

	public bool method_7(string string_0)
	{
		return class262_0.method_0(string_0);
	}

	public void method_8(GClass68 gclass68_0)
	{
		class262_0.method_1(gclass68_0);
	}

	public void method_9(string string_0, string string_1)
	{
		class262_0.method_2(string_0, string_1);
	}

	public GClass62 method_10(string string_0, double double_0, GEnum14 genum14_0)
	{
		return class262_0.method_3(string_0, double_0, genum14_0);
	}

	public GClass29 method_11()
	{
		if (gclass29_0 == null)
		{
			Stream manifestResourceStream = typeof(GClass7).Assembly.GetManifestResourceStream(Class84.smethod_0(-994290219));
			if (manifestResourceStream != null)
			{
				gclass29_0 = method_6(manifestResourceStream);
			}
		}
		return gclass29_0;
	}

	public GClass29 method_12()
	{
		if (gclass29_1 == null)
		{
			Stream manifestResourceStream = typeof(GClass7).Assembly.GetManifestResourceStream(Class84.smethod_0(-994290147));
			if (manifestResourceStream != null)
			{
				gclass29_1 = method_6(manifestResourceStream);
			}
		}
		return gclass29_1;
	}

	public object method_13(string string_0, string string_1)
	{
		return vmethod_8(string_0, string_1);
	}

	public void method_14(string string_0)
	{
		vmethod_9(string_0);
	}

	public void method_15(string string_0, string string_1)
	{
		vmethod_10(string_0, string_1);
	}

	public void method_16(GClass29 gclass29_2)
	{
		vmethod_11(gclass29_2);
	}

	public GClass42 method_17()
	{
		return vmethod_12();
	}

	public void method_18(GClass29 gclass29_2, string string_0, string string_1, GClass38 gclass38_0)
	{
		vmethod_13(gclass29_2, string_0, string_1, gclass38_0);
	}

	internal GClass62 method_19(string string_0, double double_0, GEnum14 genum14_0)
	{
		return vmethod_6(string_0, double_0, genum14_0);
	}

	internal GClass62 method_20(GClass68 gclass68_0, double double_0, GEnum14 genum14_0)
	{
		return vmethod_7(gclass68_0, double_0, genum14_0);
	}

	protected abstract GStruct3 vmethod_0(string string_0);

	protected abstract GClass19 vmethod_1(GStruct3 gstruct3_0);

	protected abstract GClass25 vmethod_2(GStruct3 gstruct3_0);

	protected abstract GClass25 vmethod_3(GStruct1 gstruct1_0, GStruct3 gstruct3_0, GStruct3 gstruct3_1, double double_0);

	protected abstract GClass29 vmethod_4(object object_0);

	protected abstract GClass29 vmethod_5(Stream stream_0);

	protected abstract GClass62 vmethod_6(string string_0, double double_0, GEnum14 genum14_0);

	protected abstract GClass62 vmethod_7(GClass68 gclass68_0, double double_0, GEnum14 genum14_0);

	protected virtual object vmethod_8(string string_0, string string_1)
	{
		throw new NotImplementedException();
	}

	protected virtual void vmethod_9(string string_0)
	{
		throw new NotImplementedException();
	}

	protected virtual void vmethod_10(string string_0, string string_1)
	{
		throw new NotImplementedException();
	}

	protected virtual void vmethod_11(GClass29 gclass29_2)
	{
		throw new NotImplementedException();
	}

	protected virtual GClass42 vmethod_12()
	{
		throw new NotImplementedException();
	}

	protected virtual void vmethod_13(GClass29 gclass29_2, string string_0, string string_1, GClass38 gclass38_0)
	{
		throw new NotImplementedException();
	}
}
