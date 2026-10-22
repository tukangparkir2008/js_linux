using System;
using System.Collections.Generic;
using Yim.Jibas.JendelaSekolah.Client.Library.HtmlFactory.Core.Entities;

public sealed class GClass55
{
	private static readonly List<CssBlock> list_0 = new List<CssBlock>();

	private readonly Dictionary<string, Dictionary<string, List<CssBlock>>> dictionary_0 = new Dictionary<string, Dictionary<string, List<CssBlock>>>(StringComparer.InvariantCultureIgnoreCase);

	internal GClass55()
	{
		dictionary_0.Add(Class84.smethod_0(-994290048), new Dictionary<string, List<CssBlock>>(StringComparer.InvariantCultureIgnoreCase));
	}

	public static GClass55 smethod_0(GClass0 gclass0_0, string string_0, bool bool_0)
	{
		return new Class308(gclass0_0).method_0(string_0, bool_0);
	}

	internal IDictionary<string, Dictionary<string, List<CssBlock>>> method_0()
	{
		return dictionary_0;
	}

	public bool method_1(string string_0, string string_1)
	{
		if (dictionary_0.TryGetValue(string_1, out var value))
		{
			return value.ContainsKey(string_0);
		}
		return false;
	}

	public IEnumerable<CssBlock> method_2(string string_0, string string_1)
	{
		List<CssBlock> value = null;
		if (dictionary_0.TryGetValue(string_1, out var value2))
		{
			value2.TryGetValue(string_0, out value);
		}
		return value ?? list_0;
	}

	public void method_3(string string_0, CssBlock cssBlock_0)
	{
		if (!dictionary_0.TryGetValue(string_0, out var value))
		{
			value = new Dictionary<string, List<CssBlock>>(StringComparer.InvariantCultureIgnoreCase);
			dictionary_0.Add(string_0, value);
		}
		if (!value.ContainsKey(cssBlock_0.Class))
		{
			List<CssBlock> list = new List<CssBlock>();
			list.Add(cssBlock_0);
			value[cssBlock_0.Class] = list;
			return;
		}
		bool flag = false;
		List<CssBlock> list2 = value[cssBlock_0.Class];
		foreach (CssBlock item in list2)
		{
			if (item.EqualsSelector(cssBlock_0))
			{
				flag = true;
				item.Merge(cssBlock_0);
				break;
			}
		}
		if (!flag)
		{
			if (cssBlock_0.Selectors == null)
			{
				list2.Insert(0, cssBlock_0);
			}
			else
			{
				list2.Add(cssBlock_0);
			}
		}
	}

	public void method_4(GClass55 gclass55_0)
	{
		GClass24.smethod_1(gclass55_0, Class84.smethod_0(-994289990));
		foreach (KeyValuePair<string, Dictionary<string, List<CssBlock>>> item in gclass55_0.method_0())
		{
			foreach (KeyValuePair<string, List<CssBlock>> item2 in item.Value)
			{
				foreach (CssBlock item3 in item2.Value)
				{
					method_3(item.Key, item3);
				}
			}
		}
	}

	public GClass55 method_5()
	{
		GClass55 gClass = new GClass55();
		foreach (KeyValuePair<string, Dictionary<string, List<CssBlock>>> item in dictionary_0)
		{
			Dictionary<string, List<CssBlock>> dictionary = new Dictionary<string, List<CssBlock>>(StringComparer.InvariantCultureIgnoreCase);
			foreach (KeyValuePair<string, List<CssBlock>> item2 in item.Value)
			{
				List<CssBlock> list = new List<CssBlock>();
				foreach (CssBlock item3 in item2.Value)
				{
					list.Add(item3.Clone());
				}
				dictionary[item2.Key] = list;
			}
			gClass.dictionary_0[item.Key] = dictionary;
		}
		return gClass;
	}
}
