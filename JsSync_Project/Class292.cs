using System;
using System.Net.Sockets;

internal sealed class Class292 : GClass45
{
	private readonly Class319 class319_0;

	public Class292(Class319 class319_1)
		: base(class319_1)
	{
		class319_0 = class319_1;
	}

	protected override void vmethod_21(GClass61 gclass61_1)
	{
		try
		{
			if (gclass61_1.method_3() == Class84.smethod_0(-994265316))
			{
				string string_ = class319_0.method_45().method_0(gclass61_1.method_10());
				method_39(method_32().method_26(string_, Class84.smethod_0(-994201350)));
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994201318), ex.Message, ex);
		}
	}

	protected override void vmethod_22(GClass61 gclass61_1, string string_0)
	{
		Class125.smethod_1(Class84.smethod_0(-994201296), string_0, null);
	}

	protected override void vmethod_18(SocketError socketError_0)
	{
		Class125.smethod_1(Class84.smethod_0(-994201269), socketError_0.ToString(), null);
	}
}
