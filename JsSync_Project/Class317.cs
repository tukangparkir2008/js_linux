using System;
using System.Collections.Generic;

internal sealed class Class317
{
	private readonly Class197 class197_0;

	private Class197 class197_1;

	private Class197 class197_2;

	private Class197 class197_3;

	private readonly List<Class197> list_0 = new List<Class197>();

	private readonly List<Class197> list_1 = new List<Class197>();

	private readonly List<Class197> list_2 = new List<Class197>();

	private int int_0;

	private bool bool_0;

	private double[] double_0;

	private double[] double_1;

	private Class317(Class197 class197_4)
	{
		class197_0 = class197_4;
	}

	public static double smethod_0(Class197 class197_4)
	{
		int num = 0;
		int num2 = 0;
		foreach (Class197 item in class197_4.method_190())
		{
			if (item.method_82() == Class84.smethod_0(-994291803))
			{
				num2 += smethod_6(item);
			}
			else if (item.method_82() == Class84.smethod_0(-994291768))
			{
				foreach (Class197 item2 in class197_4.method_190())
				{
					num++;
					if (item2.method_82() == Class84.smethod_0(-994291714))
					{
						num2 = Math.Max(num2, item2.method_190().Count);
					}
				}
			}
			else if (item.method_82() == Class84.smethod_0(-994291714))
			{
				num++;
				num2 = Math.Max(num2, item.method_190().Count);
			}
			if (num > 30)
			{
				break;
			}
		}
		return (double)(num2 + 1) * smethod_7(class197_4);
	}

	public static void smethod_1(GClass14 gclass14_0, Class197 class197_4)
	{
		GClass24.smethod_1(gclass14_0, Class84.smethod_0(-994288345));
		GClass24.smethod_1(class197_4, Class84.smethod_0(-994291730));
		try
		{
			new Class317(class197_4).method_0(gclass14_0);
		}
		catch (Exception exception_)
		{
			class197_4.method_186().method_72(GEnum7.Layout, Class84.smethod_0(-994295779), exception_);
		}
	}

	private void method_0(GClass14 gclass14_0)
	{
		smethod_5(class197_0, gclass14_0);
		method_1();
		method_2();
		double double_ = method_3();
		method_4(double_);
		method_6();
		method_5();
		Class197 @class = class197_0;
		Class197 class2 = class197_0;
		Class197 class3 = class197_0;
		string text;
		class197_0.method_47(text = Class84.smethod_0(-994274584));
		string text2;
		class3.method_51(text2 = text);
		string string_;
		class2.method_53(string_ = text2);
		@class.method_49(string_);
		method_7(gclass14_0);
	}

	private void method_1()
	{
		foreach (Class197 item in class197_0.method_190())
		{
			string text = item.method_82();
			if (text == null)
			{
				continue;
			}
			switch (text.Length)
			{
			case 18:
				switch (text[6])
				{
				case 'h':
					if (text == Class84.smethod_0(-994295765))
					{
						if (class197_2 != null)
						{
							list_0.Add(item);
						}
						else
						{
							class197_2 = item;
						}
					}
					break;
				case 'f':
					if (text == Class84.smethod_0(-994295724))
					{
						if (class197_3 != null)
						{
							list_0.Add(item);
						}
						else
						{
							class197_3 = item;
						}
					}
					break;
				case 'c':
					if (!(text == Class84.smethod_0(-994295683)))
					{
						break;
					}
					if (item.method_190().Count == 0)
					{
						int num = smethod_6(item);
						for (int i = 0; i < num; i++)
						{
							list_1.Add(item);
						}
						break;
					}
					foreach (Class197 item2 in item.method_190())
					{
						int num2 = smethod_6(item2);
						for (int j = 0; j < num2; j++)
						{
							list_1.Add(item2);
						}
					}
					break;
				}
				break;
			case 9:
				if (text == Class84.smethod_0(-994291714))
				{
					list_0.Add(item);
				}
				break;
			case 12:
				if (text == Class84.smethod_0(-994291803))
				{
					for (int k = 0; k < smethod_6(item); k++)
					{
						list_1.Add(item);
					}
				}
				break;
			case 13:
				if (text == Class84.smethod_0(-994295801))
				{
					class197_1 = item;
				}
				break;
			case 15:
				if (!(text == Class84.smethod_0(-994291768)))
				{
					break;
				}
				foreach (Class197 item3 in item.method_190())
				{
					if (item3.method_82() == Class84.smethod_0(-994291714))
					{
						list_0.Add(item3);
					}
				}
				break;
			}
		}
		if (class197_2 != null)
		{
			list_2.AddRange(class197_2.method_190());
		}
		list_2.AddRange(list_0);
		if (class197_3 != null)
		{
			list_2.AddRange(class197_3.method_190());
		}
	}

	private void method_2()
	{
		if (class197_0.bool_0)
		{
			return;
		}
		int num = 0;
		List<Class197> list = list_0;
		foreach (Class197 item in list)
		{
			for (int i = 0; i < item.method_190().Count; i++)
			{
				Class197 class197_ = item.method_190()[i];
				int num2 = smethod_4(class197_);
				int num3 = smethod_2(item, class197_);
				for (int j = num + 1; j < num + num2; j++)
				{
					if (list.Count <= j)
					{
						continue;
					}
					int num4 = 0;
					for (int k = 0; k < list[j].method_190().Count; k++)
					{
						if (num4 != num3)
						{
							num4++;
							num3 -= smethod_3(list[j].method_190()[k]) - 1;
							continue;
						}
						list[j].method_190().Insert(num4, new Class201(class197_0, ref class197_, num));
						break;
					}
				}
			}
			num++;
		}
		class197_0.bool_0 = true;
	}

	private double method_3()
	{
		if (list_1.Count > 0)
		{
			int_0 = list_1.Count;
		}
		else
		{
			foreach (Class197 item in list_2)
			{
				int_0 = Math.Max(int_0, item.method_190().Count);
			}
		}
		double_0 = new double[int_0];
		for (int i = 0; i < double_0.Length; i++)
		{
			double_0[i] = double.NaN;
		}
		double result = method_15();
		if (list_1.Count > 0)
		{
			for (int j = 0; j < list_1.Count; j++)
			{
				Class239 @class = new Class239(list_1[j].method_60());
				if (@class.method_0() > 0.0)
				{
					if (@class.method_2())
					{
						double_0[j] = Class172.smethod_3(list_1[j].method_60(), result);
					}
					else if (@class.method_4() == (Enum4)2 || @class.method_4() == 0)
					{
						double_0[j] = @class.method_0();
					}
				}
			}
		}
		else
		{
			foreach (Class197 item2 in list_2)
			{
				for (int k = 0; k < int_0; k++)
				{
					if ((k >= 20 && !double.IsNaN(double_0[k])) || k >= item2.method_190().Count || !(item2.method_190()[k].method_82() == Class84.smethod_0(-994289914)))
					{
						continue;
					}
					double num = Class172.smethod_4(item2.method_190()[k].method_60(), result, item2.method_190()[k], bool_0: false);
					if (num > 0.0)
					{
						int num2 = smethod_3(item2.method_190()[k]);
						num /= (double)Convert.ToSingle(num2);
						for (int l = k; l < k + num2; l++)
						{
							double_0[l] = (double.IsNaN(double_0[l]) ? num : Math.Max(double_0[l], num));
						}
					}
				}
			}
		}
		return result;
	}

	private void method_4(double double_2)
	{
		double num = 0.0;
		if (bool_0)
		{
			int num2 = 0;
			double[] array = double_0;
			foreach (double num3 in array)
			{
				if (double.IsNaN(num3))
				{
					num2++;
				}
				else
				{
					num += num3;
				}
			}
			int num4 = num2;
			double[] array2 = null;
			if (num2 < double_0.Length)
			{
				array2 = new double[double_0.Length];
				for (int j = 0; j < double_0.Length; j++)
				{
					array2[j] = double_0[j];
				}
			}
			if (num2 > 0)
			{
				method_14(bool_1: true, out var _, out var double_4);
				int num5;
				do
				{
					num5 = num2;
					for (int k = 0; k < double_0.Length; k++)
					{
						double num6 = (double_2 - num) / (double)num2;
						if (double.IsNaN(double_0[k]) && num6 > double_4[k])
						{
							double_0[k] = double_4[k];
							num2--;
							num += double_4[k];
						}
					}
				}
				while (num5 != num2);
				if (num2 > 0)
				{
					double num7 = (double_2 - num) / (double)num2;
					for (int l = 0; l < double_0.Length; l++)
					{
						if (double.IsNaN(double_0[l]))
						{
							double_0[l] = num7;
						}
					}
				}
			}
			if (num2 != 0 || !(num < double_2))
			{
				return;
			}
			if (num4 > 0)
			{
				double num8 = (double_2 - num) / (double)num4;
				for (int m = 0; m < double_0.Length; m++)
				{
					if (array2 == null || double.IsNaN(array2[m]))
					{
						double_0[m] += num8;
					}
				}
			}
			else
			{
				for (int n = 0; n < double_0.Length; n++)
				{
					double_0[n] += (double_2 - num) * (double_0[n] / num);
				}
			}
			return;
		}
		method_14(bool_1: true, out var double_5, out var double_6);
		for (int num9 = 0; num9 < double_0.Length; num9++)
		{
			if (double.IsNaN(double_0[num9]))
			{
				double_0[num9] = double_5[num9];
			}
			num += double_0[num9];
		}
		for (int num10 = 0; num10 < double_0.Length; num10++)
		{
			if (double_6[num10] > double_0[num10])
			{
				double num11 = double_0[num10];
				double_0[num10] = Math.Min(double_0[num10] + (double_2 - num) / (double)Convert.ToSingle(double_0.Length - num10), double_6[num10]);
				num = num + double_0[num10] - num11;
			}
		}
	}

	private void method_5()
	{
		int i = 0;
		double num = method_16();
		while (!(num <= method_12()) && method_10())
		{
			for (; !method_11(i); i++)
			{
			}
			double_0[i]--;
			i++;
			if (i >= double_0.Length)
			{
				i = 0;
			}
		}
		double num2 = method_13();
		if (!(num2 < 90999.0))
		{
			return;
		}
		num = method_16();
		if (!(num2 < num))
		{
			return;
		}
		method_14(bool_1: false, out var double_, out var double_2);
		for (int j = 0; j < double_0.Length; j++)
		{
			double_0[j] = double_[j];
		}
		num = method_16();
		if (num2 < num)
		{
			for (int k = 0; k < 15; k++)
			{
				if (num2 >= num - 0.1)
				{
					break;
				}
				int num3 = 0;
				double num4 = 0.0;
				double num5 = 0.0;
				for (int l = 0; l < double_0.Length; l++)
				{
					if (double_0[l] > num4 + 0.1)
					{
						num5 = num4;
						num4 = double_0[l];
						num3 = 1;
					}
					else if (double_0[l] > num4 - 0.1)
					{
						num3++;
					}
				}
				double num6 = ((num5 > 0.0) ? (num4 - num5) : ((num - num2) / (double)double_0.Length));
				if (num6 * (double)num3 > num - num2)
				{
					num6 = (num - num2) / (double)num3;
				}
				for (int m = 0; m < double_0.Length; m++)
				{
					if (double_0[m] > num4 - 0.1)
					{
						double_0[m] -= num6;
					}
				}
				num = method_16();
			}
			return;
		}
		for (int n = 0; n < 15; n++)
		{
			if (num2 <= num + 0.1)
			{
				break;
			}
			int num7 = 0;
			for (int num8 = 0; num8 < double_0.Length; num8++)
			{
				if (double_0[num8] + 1.0 < double_2[num8])
				{
					num7++;
				}
			}
			if (num7 == 0)
			{
				num7 = double_0.Length;
			}
			bool flag = false;
			double num9 = (num2 - num) / (double)num7;
			for (int num10 = 0; num10 < double_0.Length; num10++)
			{
				if (double_0[num10] + 0.1 < double_2[num10])
				{
					num9 = Math.Min(num9, double_2[num10] - double_0[num10]);
					flag = true;
				}
			}
			for (int num11 = 0; num11 < double_0.Length; num11++)
			{
				if (!flag || double_0[num11] + 1.0 < double_2[num11])
				{
					double_0[num11] += num9;
				}
			}
			num = method_16();
		}
	}

	private void method_6()
	{
		foreach (Class197 item in list_2)
		{
			foreach (Class197 item2 in item.method_190())
			{
				int num = smethod_3(item2);
				int num2 = smethod_2(item, item2);
				int num3 = num2 + num - 1;
				if (double_0.Length > num2 && double_0[num2] < method_17()[num2])
				{
					double num4 = method_17()[num2] - double_0[num2];
					double_0[num3] = method_17()[num3];
					if (num2 < double_0.Length - 1)
					{
						double_0[num2 + 1] -= num4;
					}
				}
			}
		}
	}

	private void method_7(GClass14 gclass14_0)
	{
		double num = Math.Max(class197_0.method_140() + method_18(), 0.0);
		double num2 = Math.Max(class197_0.method_141() + method_19(), 0.0);
		double double_ = num2;
		double val = num;
		double num3 = 0.0;
		int num4 = 0;
		if (class197_0.method_98() == Class84.smethod_0(-994291853) || class197_0.method_98() == Class84.smethod_0(-994291897))
		{
			double num5 = method_16();
			num = ((class197_0.method_98() == Class84.smethod_0(-994291897)) ? (method_12() - num5) : (num + (method_12() - num5) / 2.0));
			class197_0.method_131(new GStruct2(num - class197_0.method_158() - class197_0.method_148() - method_18(), class197_0.method_130().method_3()));
		}
		for (int i = 0; i < list_2.Count; i++)
		{
			Class197 @class = list_2[i];
			double double_2 = num;
			int num6 = 0;
			bool flag = false;
			for (int j = 0; j < @class.method_190().Count; j++)
			{
				Class197 class2 = @class.method_190()[j];
				if (num6 >= double_0.Length)
				{
					break;
				}
				int num7 = smethod_4(class2);
				int int_ = smethod_2(@class, class2);
				double double_3 = method_9(int_, class2);
				class2.method_131(new GStruct2(double_2, double_));
				class2.method_133(new GStruct4(double_3, 0.0));
				class2.method_209(gclass14_0);
				if (class2 is Class201 class3)
				{
					if (class3.method_240() == num4)
					{
						num3 = Math.Max(num3, class3.method_238().method_138());
					}
				}
				else if (num7 == 1)
				{
					num3 = Math.Max(num3, class2.method_138());
				}
				val = Math.Max(val, class2.method_136());
				num6++;
				double_2 = class2.method_136() + method_18();
			}
			foreach (Class197 item in @class.method_190())
			{
				Class201 class4 = item as Class201;
				if (class4 == null && smethod_4(item) == 1)
				{
					item.method_139(num3);
					Class281.smethod_2(gclass14_0, item);
				}
				else if (class4 != null && class4.method_240() == num4)
				{
					class4.method_238().method_139(num3);
					Class281.smethod_2(gclass14_0, class4.method_238());
				}
				if (class197_0.method_54() == Class84.smethod_0(-994295706) && (flag = item.method_225()))
				{
					double_ = item.method_130().method_3();
					break;
				}
			}
			if (flag)
			{
				i = ((i != 1) ? (i - 1) : (-1));
				num3 = 0.0;
			}
			else
			{
				double_ = num3 + method_19();
				num4++;
			}
		}
		val = Math.Max(val, class197_0.method_130().method_1() + class197_0.method_146());
		class197_0.method_137(val + method_18() + class197_0.method_160());
		class197_0.method_139(Math.Max(num3, num2) + method_19() + class197_0.method_159());
	}

	private double method_8(Class197 class197_4, Class197 class197_5, int int_1, int int_2)
	{
		double num = 0.0;
		for (int i = int_1; i < class197_4.method_190().Count || i < int_1 + int_2 - 1; i++)
		{
			if (i < method_17().Length)
			{
				num += method_17()[i];
			}
		}
		return num;
	}

	private static int smethod_2(Class197 class197_4, Class197 class197_5)
	{
		int num = 0;
		foreach (Class197 item in class197_4.method_190())
		{
			if (!item.Equals(class197_5))
			{
				num += smethod_3(item);
				continue;
			}
			break;
		}
		return num;
	}

	private double method_9(int int_1, Class197 class197_4)
	{
		double num = Convert.ToSingle(smethod_3(class197_4));
		double num2 = 0.0;
		for (int i = int_1; (double)i < (double)int_1 + num; i++)
		{
			if (int_1 >= double_0.Length)
			{
				break;
			}
			if (double_0.Length <= i)
			{
				break;
			}
			num2 += double_0[i];
		}
		return num2 + (num - 1.0) * method_18();
	}

	private static int smethod_3(Class197 class197_4)
	{
		if (!int.TryParse(class197_4.method_218(Class84.smethod_0(-994295662), Class84.smethod_0(-994248276)), out var result))
		{
			return 1;
		}
		return result;
	}

	private static int smethod_4(Class197 class197_4)
	{
		if (!int.TryParse(class197_4.method_218(Class84.smethod_0(-994295680), Class84.smethod_0(-994248276)), out var result))
		{
			return 1;
		}
		return result;
	}

	private static void smethod_5(Class197 class197_4, GClass14 gclass14_0)
	{
		if (class197_4 == null)
		{
			return;
		}
		foreach (Class197 item in class197_4.method_190())
		{
			item.vmethod_8(gclass14_0);
			smethod_5(item, gclass14_0);
		}
	}

	private bool method_10()
	{
		int num = 0;
		while (true)
		{
			if (num < double_0.Length)
			{
				if (method_11(num))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private bool method_11(int int_1)
	{
		if (double_0.Length < int_1 && method_17().Length < int_1)
		{
			return double_0[int_1] > method_17()[int_1];
		}
		return false;
	}

	private double method_12()
	{
		if (new Class239(class197_0.method_60()).method_0() > 0.0)
		{
			bool_0 = true;
			return Class172.smethod_4(class197_0.method_60(), class197_0.method_188().method_135(), class197_0, bool_0: false);
		}
		return class197_0.method_188().method_135();
	}

	private double method_13()
	{
		if (new Class239(class197_0.method_62()).method_0() > 0.0)
		{
			bool_0 = true;
			return Class172.smethod_4(class197_0.method_62(), class197_0.method_188().method_135(), class197_0, bool_0: false);
		}
		return 9999.0;
	}

	private void method_14(bool bool_1, out double[] double_2, out double[] double_3)
	{
		double_3 = new double[double_0.Length];
		double_2 = new double[double_0.Length];
		foreach (Class197 item in list_2)
		{
			for (int i = 0; i < item.method_190().Count; i++)
			{
				int num = smethod_2(item, item.method_190()[i]);
				num = ((double_0.Length > num) ? num : (double_0.Length - 1));
				if ((!bool_1 || double.IsNaN(double_0[num])) && i < item.method_190().Count)
				{
					item.method_190()[i].method_221(out var double_4, out var double_5);
					int num2 = smethod_3(item.method_190()[i]);
					double_4 /= (double)num2;
					double_5 /= (double)num2;
					for (int j = 0; j < num2; j++)
					{
						double_2[num + j] = Math.Max(double_2[num + j], double_4);
						double_3[num + j] = Math.Max(double_3[num + j], double_5);
					}
				}
			}
		}
	}

	private double method_15()
	{
		return method_12() - method_18() * (double)(int_0 + 1) - class197_0.method_158() - class197_0.method_160();
	}

	private double method_16()
	{
		double num = 0.0;
		double[] array = double_0;
		foreach (double num2 in array)
		{
			if (!double.IsNaN(num2))
			{
				num += num2;
				continue;
			}
			throw new Exception(Class84.smethod_0(-994295618));
		}
		num += method_18() * (double)(double_0.Length + 1);
		return num + (class197_0.method_158() + class197_0.method_160());
	}

	private static int smethod_6(Class197 class197_4)
	{
		double value = Class172.smethod_3(class197_4.method_217(Class84.smethod_0(-994295555)), 1.0);
		return Math.Max(1, Convert.ToInt32(value));
	}

	private double[] method_17()
	{
		if (double_1 == null)
		{
			double_1 = new double[double_0.Length];
			foreach (Class197 item in list_2)
			{
				foreach (Class197 item2 in item.method_190())
				{
					int num = smethod_3(item2);
					int num2 = smethod_2(item, item2);
					int num3 = Math.Min(num2 + num, double_1.Length) - 1;
					double num4 = method_8(item, item2, num2, num) + (double)(num - 1) * method_18();
					double_1[num3] = Math.Max(double_1[num3], item2.method_219() - num4);
				}
			}
		}
		return double_1;
	}

	private double method_18()
	{
		if (!(class197_0.method_26() == Class84.smethod_0(-994295576)))
		{
			return class197_0.method_179();
		}
		return -1.0;
	}

	private static double smethod_7(Class197 class197_4)
	{
		if (!(class197_4.method_26() == Class84.smethod_0(-994295576)))
		{
			return class197_4.method_179();
		}
		return -1.0;
	}

	private double method_19()
	{
		if (!(class197_0.method_26() == Class84.smethod_0(-994295576)))
		{
			return class197_0.method_180();
		}
		return -1.0;
	}
}
