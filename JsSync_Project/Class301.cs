using System;
using System.Collections.Generic;

internal sealed class Class301
{
	private readonly List<Class245> list_0;

	private readonly Class197 class197_0;

	private readonly Dictionary<Class197, GStruct1> dictionary_0;

	private readonly List<Class197> list_1;

	public Class301(Class197 class197_1)
	{
		dictionary_0 = new Dictionary<Class197, GStruct1>();
		list_1 = new List<Class197>();
		list_0 = new List<Class245>();
		class197_0 = class197_1;
		class197_0.method_200().Add(this);
	}

	public List<Class197> method_0()
	{
		return list_1;
	}

	public List<Class245> method_1()
	{
		return list_0;
	}

	public Class197 method_2()
	{
		return class197_0;
	}

	public Dictionary<Class197, GStruct1> method_3()
	{
		return dictionary_0;
	}

	public double method_4()
	{
		double num = 0.0;
		foreach (KeyValuePair<Class197, GStruct1> item in dictionary_0)
		{
			num = Math.Max(num, item.Value.method_10());
		}
		return num;
	}

	public double method_5()
	{
		double num = 0.0;
		foreach (KeyValuePair<Class197, GStruct1> item in dictionary_0)
		{
			num = Math.Max(num, item.Value.method_15());
		}
		return num;
	}

	internal void method_6(Class245 class245_0)
	{
		if (!method_1().Contains(class245_0))
		{
			method_1().Add(class245_0);
		}
		if (!method_0().Contains(class245_0.method_0()))
		{
			method_0().Add(class245_0.method_0());
		}
	}

	internal List<Class245> method_7(Class197 class197_1)
	{
		List<Class245> list = new List<Class245>();
		foreach (Class245 item in method_1())
		{
			if (item.method_0().Equals(class197_1))
			{
				list.Add(item);
			}
		}
		return list;
	}

	internal void method_8(Class197 class197_1, double double_0, double double_1, double double_2, double double_3)
	{
		double num = class197_1.method_158() + class197_1.method_148();
		double num2 = class197_1.method_160() + class197_1.method_150();
		double num3 = class197_1.method_157() + class197_1.method_147();
		double num4 = class197_1.method_159() + class197_1.method_147();
		if ((class197_1.method_205() != null && class197_1.method_205().Equals(this)) || class197_1.method_196())
		{
			double_0 -= num;
		}
		if ((class197_1.method_207() != null && class197_1.method_207().Equals(this)) || class197_1.method_196())
		{
			double_2 += num2;
		}
		if (!class197_1.method_196())
		{
			double_1 -= num3;
			double_3 += num4;
		}
		if (!method_3().ContainsKey(class197_1))
		{
			method_3().Add(class197_1, GStruct1.smethod_0(double_0, double_1, double_2, double_3));
		}
		else
		{
			GStruct1 gStruct = method_3()[class197_1];
			method_3()[class197_1] = GStruct1.smethod_0(Math.Min(gStruct.method_4(), double_0), Math.Min(gStruct.method_6(), double_1), Math.Max(gStruct.method_14(), double_2), Math.Max(gStruct.method_15(), double_3));
		}
		if (class197_1.method_188() != null && class197_1.method_188().method_192())
		{
			method_8(class197_1.method_188(), double_0, double_1, double_2, double_3);
		}
	}

	internal void method_9()
	{
		foreach (Class197 key in method_3().Keys)
		{
			key.method_202().Add(this, method_3()[key]);
		}
	}

	internal void method_10(GClass14 gclass14_0, Class197 class197_1, double double_0)
	{
		List<Class245> list = method_7(class197_1);
		if (!method_3().ContainsKey(class197_1))
		{
			return;
		}
		GStruct1 gStruct = method_3()[class197_1];
		double num = 0.0;
		if (list.Count > 0)
		{
			num = list[0].method_5() - gStruct.method_13();
		}
		else
		{
			Class245 @class = class197_1.method_216(class197_1, this);
			if (@class != null)
			{
				num = @class.method_5() - gStruct.method_13();
			}
		}
		if (class197_1.method_188() != null && class197_1.method_188().method_202().ContainsKey(this) && gStruct.method_10() < class197_1.method_188().method_202()[this].method_10())
		{
			double double_1 = double_0 - num;
			GStruct1 value = new GStruct1(gStruct.method_4(), double_1, gStruct.method_8(), gStruct.method_10());
			method_3()[class197_1] = value;
			class197_1.method_233(this, num);
		}
		foreach (Class245 item in list)
		{
			if (!item.vmethod_4())
			{
				item.method_6(double_0);
			}
		}
	}

	public bool method_11(Class245 class245_0)
	{
		int num = 0;
		while (true)
		{
			if (num < list_0.Count - 1)
			{
				if (list_0[num] == class245_0)
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return !list_0[num + 1].method_19();
	}

	public override string ToString()
	{
		string[] array = new string[method_1().Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = method_1()[i].vmethod_7();
		}
		return string.Join(Class84.smethod_0(-994263061), array);
	}
}
