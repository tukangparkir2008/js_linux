using System;
using System.Collections.Generic;
using Newtonsoft.Json;

internal sealed class Class300
{
	public static List<string> smethod_0(string string_0, string string_1)
	{
		try
		{
			return JsonConvert.DeserializeObject<List<string>>(string_0);
		}
		catch (Exception)
		{
			try
			{
				return JsonConvert.DeserializeObject<List<string>>(string_1);
			}
			catch (Exception)
			{
				List<string> list = new List<string>();
				string[] array = string_1.Split(',');
				for (int i = 0; i < array.Length; i++)
				{
					list.Add(array[i]);
				}
				return list;
			}
		}
	}
}
