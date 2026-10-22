using System;

internal sealed class Class305
{
	public static GClass70 smethod_0(string string_0, int int_0)
	{
		if (string_0.Length <= 5)
		{
			return new GClass70(-1, Class84.smethod_0(-994101789));
		}
		try
		{
			int int_1 = Convert.ToInt32(string_0.Substring(0, 5)) - int_0;
			string object_ = Class320.smethod_4(string_0.Substring(5), int_1);
			return new GClass70(1, Class84.smethod_0(-994102416), object_);
		}
		catch (Exception)
		{
			return new GClass70(-1, Class84.smethod_0(-994101759) + string_0 + Class84.smethod_0(-994271866));
		}
	}
}
