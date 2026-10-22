using System.Collections.Generic;
using System.Threading;

internal sealed class Class219
{
	private readonly List<Class150> list_0 = new List<Class150>();

	public void method_0(string string_0, string string_1)
	{
		lock (list_0)
		{
			list_0.Add(new Class150(string_0, string_1));
			Monitor.Pulse(list_0);
		}
	}

	public Class150 method_1()
	{
		lock (list_0)
		{
			if (list_0.Count == 0)
			{
				Monitor.Wait(list_0);
			}
			if (list_0.Count == 0)
			{
				return null;
			}
			Class150 result = list_0[0];
			list_0.RemoveAt(0);
			return result;
		}
	}

	public int method_2()
	{
		lock (list_0)
		{
			return list_0.Count;
		}
	}

	public void method_3()
	{
		lock (list_0)
		{
			list_0.Clear();
		}
	}
}
