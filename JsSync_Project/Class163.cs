using System.Collections.Generic;

internal sealed class Class163
{
	private readonly List<GClass41> list_0 = new List<GClass41>();

	public void method_0(GClass41 gclass41_0)
	{
		lock (list_0)
		{
			list_0.Add(gclass41_0);
		}
	}

	public void method_1(GClass41 gclass41_0)
	{
		lock (list_0)
		{
			list_0.Remove(gclass41_0);
		}
	}

	public void method_2(int int_0)
	{
		lock (list_0)
		{
			list_0.RemoveAt(int_0);
		}
	}

	public void method_3()
	{
		lock (list_0)
		{
			while (list_0.Count > 0)
			{
				list_0.RemoveAt(0);
			}
		}
	}

	public int method_4()
	{
		lock (list_0)
		{
			return list_0.Count;
		}
	}

	public GClass41 method_5(int int_0)
	{
		lock (list_0)
		{
			if (int_0 >= list_0.Count)
			{
				return null;
			}
			return list_0[int_0];
		}
	}
}
