using System;
using System.Globalization;
using System.IO;

internal sealed class Class275 : IDisposable
{
	private static readonly string string_0;

	private static readonly string string_1;

	private static readonly string string_2;

	private static readonly string string_3;

	private static readonly string string_4;

	private static readonly string string_5;

	private static readonly string string_6;

	private static readonly string string_7;

	private static readonly string string_8;

	private readonly Class276 class276_0;

	private readonly GClass31 gclass31_0;

	private GClass42 gclass42_0;

	private GClass38 gclass38_0;

	private Class245 class245_0;

	private Class197 class197_0;

	static Class275()
	{
		if (CultureInfo.CurrentUICulture.Name.StartsWith(Class84.smethod_0(-994295001), StringComparison.InvariantCultureIgnoreCase))
		{
			string_0 = Class84.smethod_0(-994294960);
			string_1 = Class84.smethod_0(-994294920);
			string_2 = Class84.smethod_0(-994294923);
			string_3 = Class84.smethod_0(-994294892);
			string_4 = Class84.smethod_0(-994294855);
			string_5 = Class84.smethod_0(-994294873);
			string_6 = Class84.smethod_0(-994294836);
			string_7 = Class84.smethod_0(-994294802);
			string_8 = Class84.smethod_0(-994294764);
		}
		else if (CultureInfo.CurrentUICulture.Name.StartsWith(Class84.smethod_0(-994294734), StringComparison.InvariantCultureIgnoreCase))
		{
			string_0 = Class84.smethod_0(-994294741);
			string_1 = Class84.smethod_0(-994294704);
			string_2 = Class84.smethod_0(-994294705);
			string_3 = Class84.smethod_0(-994294677);
			string_4 = Class84.smethod_0(-994294627);
			string_5 = Class84.smethod_0(-994294651);
			string_6 = Class84.smethod_0(-994294615);
			string_7 = Class84.smethod_0(-994294569);
			string_8 = Class84.smethod_0(-994294534);
		}
		else if (CultureInfo.CurrentUICulture.Name.StartsWith(Class84.smethod_0(-994294557), StringComparison.InvariantCultureIgnoreCase))
		{
			string_0 = Class84.smethod_0(-994294500);
			string_1 = Class84.smethod_0(-994294526);
			string_2 = Class84.smethod_0(-994294466);
			string_3 = Class84.smethod_0(-994294435);
			string_4 = Class84.smethod_0(-994294451);
			string_5 = Class84.smethod_0(-994294410);
			string_6 = Class84.smethod_0(-994294373);
			string_7 = Class84.smethod_0(-994294340);
			string_8 = Class84.smethod_0(-994294368);
		}
		else if (CultureInfo.CurrentUICulture.Name.StartsWith(Class84.smethod_0(-994294314), StringComparison.InvariantCultureIgnoreCase))
		{
			string_0 = Class84.smethod_0(-994294321);
			string_1 = Class84.smethod_0(-994294282);
			string_2 = Class84.smethod_0(-994294301);
			string_3 = Class84.smethod_0(-994294268);
			string_4 = Class84.smethod_0(-994294217);
			string_5 = Class84.smethod_0(-994294187);
			string_6 = Class84.smethod_0(-994294151);
			string_7 = Class84.smethod_0(-994294170);
			string_8 = Class84.smethod_0(-994294136);
		}
		else if (CultureInfo.CurrentUICulture.Name.StartsWith(Class84.smethod_0(-994294091), StringComparison.InvariantCultureIgnoreCase))
		{
			string_0 = Class84.smethod_0(-994294098);
			string_1 = Class84.smethod_0(-994294069);
			string_2 = Class84.smethod_0(-994294026);
			string_3 = Class84.smethod_0(-994293957);
			string_4 = Class84.smethod_0(-994293932);
			string_5 = Class84.smethod_0(-994293869);
			string_6 = Class84.smethod_0(-994293850);
			string_7 = Class84.smethod_0(-994293787);
			string_8 = Class84.smethod_0(-994281466);
		}
		else if (CultureInfo.CurrentUICulture.Name.StartsWith(Class84.smethod_0(-994281399), StringComparison.InvariantCultureIgnoreCase))
		{
			string_0 = Class84.smethod_0(-994281406);
			string_1 = Class84.smethod_0(-994281358);
			string_2 = Class84.smethod_0(-994281376);
			string_3 = Class84.smethod_0(-994281335);
			string_4 = Class84.smethod_0(-994281286);
			string_5 = Class84.smethod_0(-994281308);
			string_6 = Class84.smethod_0(-994281257);
			string_7 = Class84.smethod_0(-994281217);
			string_8 = Class84.smethod_0(-994281247);
		}
		else if (CultureInfo.CurrentUICulture.Name.StartsWith(Class84.smethod_0(-994281207), StringComparison.InvariantCultureIgnoreCase))
		{
			string_0 = Class84.smethod_0(-994281214);
			string_1 = Class84.smethod_0(-994281172);
			string_2 = Class84.smethod_0(-994281126);
			string_3 = Class84.smethod_0(-994281092);
			string_4 = Class84.smethod_0(-994281064);
			string_5 = Class84.smethod_0(-994281073);
			string_6 = Class84.smethod_0(-994281038);
			string_7 = Class84.smethod_0(-994280993);
			string_8 = Class84.smethod_0(-994281018);
		}
		else if (CultureInfo.CurrentUICulture.Name.StartsWith(Class84.smethod_0(-994280977), StringComparison.InvariantCultureIgnoreCase))
		{
			string_0 = Class84.smethod_0(-994280936);
			string_1 = Class84.smethod_0(-994280957);
			string_2 = Class84.smethod_0(-994280909);
			string_3 = Class84.smethod_0(-994280879);
			string_4 = Class84.smethod_0(-994280846);
			string_5 = Class84.smethod_0(-994280803);
			string_6 = Class84.smethod_0(-994280828);
			string_7 = Class84.smethod_0(-994280747);
			string_8 = Class84.smethod_0(-994280714);
		}
		else if (CultureInfo.CurrentUICulture.Name.StartsWith(Class84.smethod_0(-994280688), StringComparison.InvariantCultureIgnoreCase))
		{
			string_0 = Class84.smethod_0(-994280695);
			string_1 = Class84.smethod_0(-994280648);
			string_2 = Class84.smethod_0(-994280651);
			string_3 = Class84.smethod_0(-994280609);
			string_4 = Class84.smethod_0(-994280626);
			string_5 = Class84.smethod_0(-994280585);
			string_6 = Class84.smethod_0(-994280548);
			string_7 = Class84.smethod_0(-994280571);
			string_8 = Class84.smethod_0(-994280523);
		}
		else if (CultureInfo.CurrentUICulture.Name.StartsWith(Class84.smethod_0(-994280484), StringComparison.InvariantCultureIgnoreCase))
		{
			string_0 = Class84.smethod_0(-994280491);
			string_1 = Class84.smethod_0(-994280452);
			string_2 = Class84.smethod_0(-994280469);
			string_3 = Class84.smethod_0(-994280427);
			string_4 = Class84.smethod_0(-994280441);
			string_5 = Class84.smethod_0(-994280411);
			string_6 = Class84.smethod_0(-994280369);
			string_7 = Class84.smethod_0(-994280338);
			string_8 = Class84.smethod_0(-994280303);
		}
		else if (CultureInfo.CurrentUICulture.Name.StartsWith(Class84.smethod_0(-994280262), StringComparison.InvariantCultureIgnoreCase))
		{
			string_0 = Class84.smethod_0(-994280269);
			string_1 = Class84.smethod_0(-994280232);
			string_2 = Class84.smethod_0(-994280235);
			string_3 = Class84.smethod_0(-994280208);
			string_4 = Class84.smethod_0(-994280222);
			string_5 = Class84.smethod_0(-994280183);
			string_6 = Class84.smethod_0(-994280133);
			string_7 = Class84.smethod_0(-994280103);
			string_8 = Class84.smethod_0(-994280118);
		}
		else
		{
			string_0 = Class84.smethod_0(-994280079);
			string_1 = Class84.smethod_0(-994280094);
			string_2 = Class84.smethod_0(-994280035);
			string_3 = Class84.smethod_0(-994280059);
			string_4 = Class84.smethod_0(-994280011);
			string_5 = Class84.smethod_0(-994279974);
			string_6 = Class84.smethod_0(-994279989);
			string_7 = Class84.smethod_0(-994279950);
			string_8 = Class84.smethod_0(-994279965);
		}
	}

	public Class275(Class276 class276_1, GClass31 gclass31_1)
	{
		GClass24.smethod_1(class276_1, Class84.smethod_0(-994279928));
		GClass24.smethod_1(gclass31_1, Class84.smethod_0(-994279873));
		class276_0 = class276_1;
		gclass31_0 = gclass31_1;
	}

	public void method_0(GClass38 gclass38_1, Class245 class245_1, Class197 class197_1)
	{
		try
		{
			method_1();
			gclass38_0 = gclass38_1;
			class245_0 = class245_1;
			class197_0 = class197_1;
			gclass42_0 = gclass31_0.method_0().method_17();
			if (class245_1 != null)
			{
				bool flag = false;
				if (class197_1 != null)
				{
					flag = class197_1 is Class198 && ((Class198)class197_1).method_238();
					bool bool_ = !string.IsNullOrEmpty(class197_1.vmethod_6());
					gclass42_0.vmethod_2(flag ? string_7 : string_3, bool_, method_2);
					if (gclass31_0.method_23())
					{
						gclass42_0.vmethod_2(flag ? string_8 : string_2, bool_, method_3);
					}
					gclass42_0.vmethod_1();
				}
				if (class245_1.vmethod_4() && !flag)
				{
					gclass42_0.vmethod_2(string_6, class245_1.vmethod_2() != null, method_4);
					if (gclass31_0.method_23())
					{
						gclass42_0.vmethod_2(string_4, !string.IsNullOrEmpty(class245_0.method_0().method_217(Class84.smethod_0(-994293138))), method_5);
						gclass42_0.vmethod_2(string_5, class245_1.vmethod_2() != null, method_6);
					}
					gclass42_0.vmethod_1();
				}
				if (gclass31_0.method_23())
				{
					gclass42_0.vmethod_2(string_1, class245_1.method_19(), method_7);
				}
			}
			if (gclass31_0.method_23())
			{
				gclass42_0.vmethod_2(string_0, bool_0: true, method_8);
			}
			if (gclass42_0.vmethod_0() > 0)
			{
				gclass42_0.vmethod_3();
				gclass42_0.vmethod_4(gclass38_1, gclass38_1.vmethod_2());
			}
		}
		catch (Exception exception_)
		{
			gclass31_0.method_72(GEnum7.ContextMenu, Class84.smethod_0(-994279901), exception_);
		}
	}

	public void Dispose()
	{
		method_1();
	}

	private void method_1()
	{
		try
		{
			if (gclass42_0 != null)
			{
				gclass42_0.Dispose();
			}
			gclass42_0 = null;
			gclass38_0 = null;
			class245_0 = null;
			class197_0 = null;
		}
		catch
		{
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		try
		{
			class197_0.method_186().method_73(gclass38_0, gclass38_0.vmethod_2(), class197_0);
		}
		catch (GException0)
		{
			throw;
		}
		catch (Exception exception_)
		{
			gclass31_0.method_72(GEnum7.ContextMenu, Class84.smethod_0(-994279867), exception_);
		}
		finally
		{
			method_1();
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		try
		{
			gclass31_0.method_0().method_14(class197_0.vmethod_6());
		}
		catch (Exception exception_)
		{
			gclass31_0.method_72(GEnum7.ContextMenu, Class84.smethod_0(-994279825), exception_);
		}
		finally
		{
			method_1();
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		try
		{
			string path = class245_0.method_0().method_217(Class84.smethod_0(-994293138));
			gclass31_0.method_0().method_18(class245_0.vmethod_2(), Path.GetFileName(path) ?? Class84.smethod_0(-994295247), Path.GetExtension(path) ?? Class84.smethod_0(-994279750), null);
		}
		catch (Exception exception_)
		{
			gclass31_0.method_72(GEnum7.ContextMenu, Class84.smethod_0(-994279756), exception_);
		}
		finally
		{
			method_1();
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		try
		{
			gclass31_0.method_0().method_14(class245_0.method_0().method_217(Class84.smethod_0(-994293138)));
		}
		catch (Exception exception_)
		{
			gclass31_0.method_72(GEnum7.ContextMenu, Class84.smethod_0(-994279713), exception_);
		}
		finally
		{
			method_1();
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		try
		{
			gclass31_0.method_0().method_16(class245_0.vmethod_2());
		}
		catch (Exception exception_)
		{
			gclass31_0.method_72(GEnum7.ContextMenu, Class84.smethod_0(-994279701), exception_);
		}
		finally
		{
			method_1();
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		try
		{
			class276_0.method_6();
		}
		catch (Exception exception_)
		{
			gclass31_0.method_72(GEnum7.ContextMenu, Class84.smethod_0(-994279677), exception_);
		}
		finally
		{
			method_1();
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		try
		{
			class276_0.method_0(gclass38_0);
		}
		catch (Exception exception_)
		{
			gclass31_0.method_72(GEnum7.ContextMenu, Class84.smethod_0(-994279590), exception_);
		}
		finally
		{
			method_1();
		}
	}
}
