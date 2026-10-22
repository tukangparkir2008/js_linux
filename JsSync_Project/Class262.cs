using System;
using System.Collections.Generic;

internal sealed class Class262
{
	private readonly GClass0 gclass0_0;

	private readonly Dictionary<string, string> dictionary_0 = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

	private readonly Dictionary<string, GClass68> dictionary_1 = new Dictionary<string, GClass68>(StringComparer.InvariantCultureIgnoreCase);

	private readonly Dictionary<string, Dictionary<double, Dictionary<GEnum14, GClass62>>> dictionary_2 = new Dictionary<string, Dictionary<double, Dictionary<GEnum14, GClass62>>>(StringComparer.InvariantCultureIgnoreCase);

	public Class262(GClass0 gclass0_1)
	{
		GClass24.smethod_1(gclass0_1, Class84.smethod_0(-994290092));
		gclass0_0 = gclass0_1;
	}

	public bool method_0(string string_0)
	{
		bool result;
		if (!(result = dictionary_1.ContainsKey(string_0)) && dictionary_0.TryGetValue(string_0, out var value))
		{
			result = dictionary_1.ContainsKey(value);
		}
		return result;
	}

	public void method_1(GClass68 gclass68_0)
	{
		GClass24.smethod_1(gclass68_0, Class84.smethod_0(-994279558));
		dictionary_1[gclass68_0.vmethod_0()] = gclass68_0;
	}

	public void method_2(string string_0, string string_1)
	{
		GClass24.smethod_3(string_0, Class84.smethod_0(-994279561));
		GClass24.smethod_3(string_1, Class84.smethod_0(-994279528));
		dictionary_0[string_0] = string_1;
	}

	public GClass62 method_3(string string_0, double double_0, GEnum14 genum14_0)
	{
		GClass62 gClass = method_4(string_0, double_0, genum14_0);
		if (gClass == null)
		{
			if (!dictionary_1.ContainsKey(string_0) && dictionary_0.TryGetValue(string_0, out var value))
			{
				gClass = method_4(value, double_0, genum14_0);
				if (gClass == null)
				{
					gClass = method_5(value, double_0, genum14_0);
					dictionary_2[value][double_0][genum14_0] = gClass;
				}
			}
			if (gClass == null)
			{
				gClass = method_5(string_0, double_0, genum14_0);
			}
			dictionary_2[string_0][double_0][genum14_0] = gClass;
		}
		return gClass;
	}

	private GClass62 method_4(string string_0, double double_0, GEnum14 genum14_0)
	{
		GClass62 result = null;
		if (dictionary_2.ContainsKey(string_0))
		{
			Dictionary<double, Dictionary<GEnum14, GClass62>> dictionary = dictionary_2[string_0];
			if (dictionary.ContainsKey(double_0))
			{
				Dictionary<GEnum14, GClass62> dictionary2 = dictionary[double_0];
				if (dictionary2.ContainsKey(genum14_0))
				{
					result = dictionary2[genum14_0];
				}
			}
			else
			{
				dictionary_2[string_0][double_0] = new Dictionary<GEnum14, GClass62>();
			}
		}
		else
		{
			dictionary_2[string_0] = new Dictionary<double, Dictionary<GEnum14, GClass62>>();
			dictionary_2[string_0][double_0] = new Dictionary<GEnum14, GClass62>();
		}
		return result;
	}

	private GClass62 method_5(string string_0, double double_0, GEnum14 genum14_0)
	{
		GClass68 value;
		try
		{
			return dictionary_1.TryGetValue(string_0, out value) ? gclass0_0.method_20(value, double_0, genum14_0) : gclass0_0.method_19(string_0, double_0, genum14_0);
		}
		catch
		{
			return dictionary_1.TryGetValue(string_0, out value) ? gclass0_0.method_20(value, double_0, (GEnum14)0) : gclass0_0.method_19(string_0, double_0, (GEnum14)0);
		}
	}
}
