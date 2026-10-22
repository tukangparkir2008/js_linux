using System;
using System.Collections.Generic;

internal sealed class Class5
{
	private object object_0 = new object();

	private Dictionary<Class46, Class42> dictionary_0;

	internal Class42 method_0(Class46 class46_0)
	{
		if (class46_0 == null)
		{
			throw new ArgumentNullException();
		}
		lock (object_0)
		{
			if (dictionary_0 == null)
			{
				dictionary_0 = new Dictionary<Class46, Class42>();
			}
			if (!dictionary_0.TryGetValue(class46_0, out var value))
			{
				value = new Class42(class46_0);
				dictionary_0[class46_0] = value;
			}
			return value;
		}
	}
}
