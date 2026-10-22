using System;
using System.Collections.Generic;
using Newtonsoft.Json;

internal sealed class Class330
{
	public GEnum13 genum13_0;

	public string string_0;

	public List<string> list_0;

	public static Class330 smethod_0(string string_1)
	{
		try
		{
			List<string> list = JsonConvert.DeserializeObject<List<string>>(string_1);
			if (list.Count != 3)
			{
				return null;
			}
			return new Class330
			{
				genum13_0 = (GEnum13)Convert.ToInt32(list[0]),
				string_0 = list[1],
				list_0 = JsonConvert.DeserializeObject<List<string>>(list[2])
			};
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994288758), ex.Message, ex);
			return null;
		}
	}
}
