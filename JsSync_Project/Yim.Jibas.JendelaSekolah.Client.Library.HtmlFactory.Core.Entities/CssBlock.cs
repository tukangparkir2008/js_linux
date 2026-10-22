using System.Collections.Generic;

namespace Yim.Jibas.JendelaSekolah.Client.Library.HtmlFactory.Core.Entities;

public sealed class CssBlock
{
	private readonly string string_0;

	private readonly Dictionary<string, string> dictionary_0;

	private readonly List<GStruct0> list_0;

	private readonly bool bool_0;

	public string Class => string_0;

	public List<GStruct0> Selectors => list_0;

	public IDictionary<string, string> Properties => dictionary_0;

	public bool Hover => bool_0;

	public CssBlock(string @class, Dictionary<string, string> properties, List<GStruct0> selectors = null, bool hover = false)
	{
		GClass24.smethod_3(@class, Class84.smethod_0(-994295349));
		GClass24.smethod_1(properties, Class84.smethod_0(-994295304));
		string_0 = @class;
		list_0 = selectors;
		dictionary_0 = properties;
		bool_0 = hover;
	}

	public void Merge(CssBlock other)
	{
		GClass24.smethod_1(other, Class84.smethod_0(-994289990));
		foreach (string key in other.dictionary_0.Keys)
		{
			dictionary_0[key] = other.dictionary_0[key];
		}
	}

	public CssBlock Clone()
	{
		return new CssBlock(string_0, new Dictionary<string, string>(dictionary_0), (list_0 != null) ? new List<GStruct0>(list_0) : null);
	}

	public bool Equals(CssBlock other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (!object.Equals(other.string_0, string_0))
		{
			return false;
		}
		if (!object.Equals(other.dictionary_0.Count, dictionary_0.Count))
		{
			return false;
		}
		foreach (KeyValuePair<string, string> item in dictionary_0)
		{
			if (other.dictionary_0.ContainsKey(item.Key))
			{
				if (!object.Equals(other.dictionary_0[item.Key], item.Value))
				{
					return false;
				}
				continue;
			}
			return false;
		}
		if (!EqualsSelector(other))
		{
			return false;
		}
		return true;
	}

	public bool EqualsSelector(CssBlock other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (other.Hover != Hover)
		{
			return false;
		}
		if (other.list_0 == null && list_0 != null)
		{
			return false;
		}
		if (other.list_0 != null && list_0 == null)
		{
			return false;
		}
		if (other.list_0 != null && list_0 != null)
		{
			if (!object.Equals(other.list_0.Count, list_0.Count))
			{
				return false;
			}
			for (int i = 0; i < list_0.Count; i++)
			{
				if (object.Equals(other.list_0[i].method_0(), list_0[i].method_0()))
				{
					if (!object.Equals(other.list_0[i].method_1(), list_0[i].method_1()))
					{
						return false;
					}
					continue;
				}
				return false;
			}
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != typeof(CssBlock))
		{
			return false;
		}
		return Equals((CssBlock)obj);
	}

	public override int GetHashCode()
	{
		return (((string_0 != null) ? string_0.GetHashCode() : 0) * 397) ^ ((dictionary_0 != null) ? dictionary_0.GetHashCode() : 0);
	}

	public override string ToString()
	{
		string text = string_0 + Class84.smethod_0(-994295319);
		foreach (KeyValuePair<string, string> item in dictionary_0)
		{
			text += string.Format(Class84.smethod_0(-994295325), item.Key, item.Value);
		}
		return text + Class84.smethod_0(-994295277);
	}
}
