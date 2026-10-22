using System.Collections.Generic;
using System.Threading;

internal sealed class Class306
{
	private readonly List<Class345> list_0 = new List<Class345>();

	public void method_0(Class345 class345_0)
	{
		lock (list_0)
		{
			list_0.Add(class345_0);
			Monitor.Pulse(list_0);
		}
	}

	public Class345 method_1()
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
			Class345 result = list_0[0];
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
