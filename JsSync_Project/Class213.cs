using System;
using System.Collections.Specialized;
using System.Web;

internal sealed class Class213
{
	private readonly GClass4 gclass4_0;

	public Class213(GClass4 gclass4_1)
	{
		gclass4_0 = gclass4_1;
	}

	public string method_0(string string_0)
	{
		try
		{
			string_0 = HttpUtility.HtmlDecode(string_0);
			NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(string_0);
			string text = nameValueCollection[Class84.smethod_0(-994201555)];
			if (text == null)
			{
				return GClass70.smethod_0(0, Class84.smethod_0(-994201562), string.Empty);
			}
			if (text.Equals(Class84.smethod_0(-994201513)))
			{
				return GClass70.smethod_0(1, Class84.smethod_0(-994247224), string.Empty);
			}
			if (text.Equals(Class84.smethod_0(-994201534)))
			{
				return Class138.smethod_4().method_0();
			}
			if (text.Equals(Class84.smethod_0(-994201473)))
			{
				gclass4_0.method_23();
				return GClass70.smethod_0(1, Class84.smethod_0(-994247224), string.Empty);
			}
			if (text.Equals(Class84.smethod_0(-994201490)))
			{
				return Class138.smethod_1(nameValueCollection[Class84.smethod_0(-994201454)]).method_0();
			}
			if (text.Equals(Class84.smethod_0(-994201458)))
			{
				return Class138.smethod_2(nameValueCollection[Class84.smethod_0(-994201419)]).method_0();
			}
			if (text.Equals(Class84.smethod_0(-994201440)))
			{
				return Class138.smethod_3().method_0();
			}
			return GClass70.smethod_0(0, Class84.smethod_0(-994201562), string.Empty);
		}
		catch (Exception ex)
		{
			return GClass70.smethod_0(-1, Class84.smethod_0(-994288787) + ex.Message, string.Empty);
		}
	}
}
