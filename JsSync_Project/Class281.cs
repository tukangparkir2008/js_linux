using System;
using System.Collections.Generic;

internal static class Class281
{
	public static void smethod_0(Class246 class246_0)
	{
		GClass24.smethod_1(class246_0, Class84.smethod_0(-994291981));
		GClass24.smethod_1(class246_0.method_0(), Class84.smethod_0(-994291997));
		Class239 @class = new Class239(class246_0.method_0().method_60());
		Class239 class2 = new Class239(class246_0.method_0().method_64());
		bool flag = @class.method_0() > 0.0 && @class.method_4() == (Enum4)2;
		bool flag2 = class2.method_0() > 0.0 && class2.method_4() == (Enum4)2;
		bool flag3 = false;
		if (flag)
		{
			class246_0.method_8(@class.method_0());
		}
		else if (@class.method_0() > 0.0 && @class.method_2())
		{
			class246_0.method_8(@class.method_0() * class246_0.method_0().method_194().method_132()
				.method_1());
			flag3 = true;
		}
		else if (class246_0.vmethod_2() != null)
		{
			class246_0.method_8((class246_0.method_26() == GStruct1.gstruct1_0) ? class246_0.vmethod_2().vmethod_0() : class246_0.method_26().method_8());
		}
		else
		{
			class246_0.method_8(flag2 ? (class2.method_0() / 1.1399999856948853) : 20.0);
		}
		Class239 class3 = new Class239(class246_0.method_0().method_62());
		if (class3.method_0() > 0.0)
		{
			double num = -1.0;
			if (class3.method_4() == (Enum4)2)
			{
				num = class3.method_0();
			}
			else if (class3.method_2())
			{
				num = class3.method_0() * class246_0.method_0().method_194().method_132()
					.method_1();
			}
			if (num > -1.0 && class246_0.method_7() > num)
			{
				class246_0.method_8(num);
				flag3 = !flag2;
			}
		}
		if (flag2)
		{
			class246_0.method_12(class2.method_0());
		}
		else if (class246_0.vmethod_2() != null)
		{
			class246_0.method_12((class246_0.method_26() == GStruct1.gstruct1_0) ? class246_0.vmethod_2().vmethod_1() : class246_0.method_26().method_10());
		}
		else
		{
			class246_0.method_12((class246_0.method_7() > 0.0) ? (class246_0.method_7() * 1.1399999856948853) : 22.799999237060547);
		}
		if (class246_0.vmethod_2() != null)
		{
			if ((flag && !flag2) | flag3)
			{
				double num2 = class246_0.method_7() / class246_0.vmethod_2().vmethod_0();
				class246_0.method_12(class246_0.vmethod_2().vmethod_1() * num2);
			}
			else if (flag2 && !flag)
			{
				double num3 = class246_0.method_11() / class246_0.vmethod_2().vmethod_1();
				class246_0.method_8(class246_0.vmethod_2().vmethod_0() * num3);
			}
		}
		class246_0.method_12(class246_0.method_11() + (class246_0.method_0().method_159() + class246_0.method_0().method_157() + class246_0.method_0().method_147() + class246_0.method_0().method_149()));
	}

	public static void smethod_1(GClass14 gclass14_0, Class197 class197_0)
	{
		GClass24.smethod_1(gclass14_0, Class84.smethod_0(-994288345));
		GClass24.smethod_1(class197_0, Class84.smethod_0(-994291956));
		class197_0.method_200().Clear();
		double double_ = class197_0.method_136() - class197_0.method_150() - class197_0.method_160();
		double num = class197_0.method_130().method_1() + class197_0.method_148() - 0.0 + class197_0.method_158();
		double num2 = class197_0.method_130().method_3() + class197_0.method_147() - 0.0 + class197_0.method_157();
		double double_2 = num + class197_0.method_178();
		double double_3 = num2;
		double double_4 = num;
		double double_5 = num2;
		Class301 class301_ = new Class301(class197_0);
		smethod_3(gclass14_0, class197_0, class197_0, double_, 0.0, num, ref class301_, ref double_2, ref double_3, ref double_4, ref double_5);
		if (class197_0.method_136() >= 90999.0)
		{
			class197_0.method_137(double_4 + class197_0.method_150() + class197_0.method_160());
		}
		foreach (Class301 item in class197_0.method_200())
		{
			smethod_6(gclass14_0, item);
			smethod_7(class197_0, item);
			smethod_5(class197_0, item);
			smethod_10(gclass14_0, item);
			item.method_9();
		}
		class197_0.method_139(double_5 + class197_0.method_149() + class197_0.method_159());
		if (class197_0.method_64() != null && class197_0.method_64() != Class84.smethod_0(-994293691) && class197_0.method_122() == Class84.smethod_0(-994291909) && class197_0.method_138() - class197_0.method_130().method_3() > class197_0.method_145())
		{
			class197_0.method_139(class197_0.method_130().method_3() + class197_0.method_145());
		}
	}

	public static void smethod_2(GClass14 gclass14_0, Class197 class197_0)
	{
		GClass24.smethod_1(gclass14_0, Class84.smethod_0(-994288345));
		GClass24.smethod_1(class197_0, Class84.smethod_0(-994291928));
		if (class197_0.method_94() == Class84.smethod_0(-994291933) || class197_0.method_94() == Class84.smethod_0(-994292231))
		{
			return;
		}
		double num = class197_0.method_143();
		double num2 = class197_0.method_220(class197_0, 0.0);
		double double_ = 0.0;
		if (class197_0.method_94() == Class84.smethod_0(-994291875))
		{
			double_ = num - num2;
		}
		else if (class197_0.method_94() == Class84.smethod_0(-994291894))
		{
			double_ = (num - num2) / 2.0;
		}
		foreach (Class197 item in class197_0.method_190())
		{
			item.method_228(double_);
		}
	}

	private static void smethod_3(GClass14 gclass14_0, Class197 class197_0, Class197 class197_1, double double_0, double double_1, double double_2, ref Class301 class301_0, ref double double_3, ref double double_4, ref double double_5, ref double double_6)
	{
		double num = double_3;
		double num2 = double_4;
		class197_1.method_206(class301_0);
		double num3 = double_3;
		double num4 = double_5;
		double num5 = double_6;
		foreach (Class197 item in class197_1.method_190())
		{
			double num6 = ((!(item.method_90() != Class84.smethod_0(-994293484)) || !(item.method_90() != Class84.smethod_0(-994289933))) ? 0.0 : (item.method_154() + item.method_158() + item.method_148()));
			double num7 = ((!(item.method_90() != Class84.smethod_0(-994293484)) || !(item.method_90() != Class84.smethod_0(-994289933))) ? 0.0 : (item.method_156() + item.method_160() + item.method_150()));
			item.method_234();
			item.vmethod_8(gclass14_0);
			double_3 += num6;
			if (item.method_203().Count > 0)
			{
				bool flag = false;
				if (item.method_102() == Class84.smethod_0(-994293524) && double_3 > double_2)
				{
					double num8 = double_3;
					foreach (Class245 item2 in item.method_203())
					{
						num8 += item2.method_9();
					}
					if (num8 > double_0)
					{
						flag = true;
					}
				}
				if (Class277.smethod_5(item))
				{
					double_3 += class197_1.method_170();
				}
				foreach (Class245 item3 in item.method_203())
				{
					if (double_6 - double_4 < class197_1.method_177())
					{
						double_6 += class197_1.method_177() - (double_6 - double_4);
					}
					if (((item.method_102() != Class84.smethod_0(-994293524) && item.method_102() != Class84.smethod_0(-994293750) && double_3 + item3.method_7() + num7 > double_0 && (item.method_102() != Class84.smethod_0(-994293756) || !item3.vmethod_5())) || item3.vmethod_6()) | flag)
					{
						flag = false;
						double_3 = double_2;
						if (item == class197_1.method_190()[0] && !item3.vmethod_6() && (item3 == item.method_203()[0] || (class197_1.method_188() != null && class197_1.method_188().method_193())))
						{
							double_3 += class197_1.method_154() + class197_1.method_158() + class197_1.method_148();
						}
						double_4 = double_6 + double_1;
						class301_0 = new Class301(class197_0);
						if (item3.vmethod_4() || item3.Equals(item.method_204()))
						{
							double_3 += num6;
						}
					}
					class301_0.method_6(item3);
					item3.method_4(double_3);
					item3.method_6(double_4);
					if (!class197_1.vmethod_5())
					{
						item3.method_25();
					}
					double_3 = item3.method_3() + item3.method_9();
					double_5 = Math.Max(double_5, item3.method_13());
					double_6 = Math.Max(double_6, item3.method_15());
					if (item.method_90() == Class84.smethod_0(-994293484))
					{
						item3.method_4(item3.method_3() + class197_1.method_154());
						item3.method_6(item3.method_5() + class197_1.method_151());
					}
				}
			}
			else
			{
				smethod_3(gclass14_0, class197_0, item, double_0, double_1, double_2, ref class301_0, ref double_3, ref double_4, ref double_5, ref double_6);
			}
			double_3 += num7;
		}
		if (double_6 - num2 < class197_1.method_145())
		{
			double_6 += class197_1.method_145() - (double_6 - num2);
		}
		if (class197_1.method_192() && 0.0 <= double_3 - num && double_3 - num < class197_1.method_146())
		{
			double_3 += class197_1.method_146() - (double_3 - num);
			class301_0.method_3().Add(class197_1, new GStruct1(num, num2, class197_1.method_146(), class197_1.method_145()));
		}
		if (class197_1.method_198() != null && class197_1.method_198().method_5() && !class197_1.method_196() && class197_1.method_192() && class197_1.method_190().Count == 0 && class197_1.method_203().Count == 0)
		{
			double_3 += class197_1.method_170();
		}
		if (class197_1.method_90() == Class84.smethod_0(-994293484))
		{
			double_3 = num3;
			double_5 = num4;
			double_6 = num5;
			smethod_4(class197_1, 0.0, 0.0);
		}
		class197_1.method_208(class301_0);
	}

	private static void smethod_4(Class197 class197_0, double double_0, double double_1)
	{
		double_0 += class197_0.method_154();
		double_1 += class197_0.method_151();
		if (class197_0.method_203().Count > 0)
		{
			foreach (Class245 item in class197_0.method_203())
			{
				item.method_4(item.method_3() + double_0);
				item.method_6(item.method_5() + double_1);
			}
			return;
		}
		foreach (Class197 item2 in class197_0.method_190())
		{
			smethod_4(item2, double_0, double_1);
		}
	}

	private static void smethod_5(Class197 class197_0, Class301 class301_0)
	{
		if (class197_0.method_203().Count > 0)
		{
			double num = 3.4028234663852886E+38;
			double num2 = 3.4028234663852886E+38;
			double num3 = -3.4028234663852886E+38;
			double num4 = -3.4028234663852886E+38;
			List<Class245> list = class301_0.method_7(class197_0);
			if (list.Count <= 0)
			{
				return;
			}
			foreach (Class245 item in list)
			{
				double num5 = item.method_3();
				if (class197_0 == class197_0.method_188().method_190()[0] && item == class197_0.method_203()[0] && item == class301_0.method_1()[0] && class301_0 != class301_0.method_2().method_200()[0] && !item.vmethod_6())
				{
					num5 -= class197_0.method_188().method_154() + class197_0.method_188().method_158() + class197_0.method_188().method_148();
				}
				num = Math.Min(num, num5);
				num3 = Math.Max(num3, item.method_13());
				num2 = Math.Min(num2, item.method_5());
				num4 = Math.Max(num4, item.method_15());
			}
			class301_0.method_8(class197_0, num, num2, num3, num4);
			return;
		}
		foreach (Class197 item2 in class197_0.method_190())
		{
			smethod_5(item2, class301_0);
		}
	}

	private static void smethod_6(GClass14 gclass14_0, Class301 class301_0)
	{
		string text = class301_0.method_2().method_98();
		if (!(text == Class84.smethod_0(-994291897)))
		{
			if (!(text == Class84.smethod_0(-994291853)))
			{
				if (!(text == Class84.smethod_0(-994291872)))
				{
					smethod_14(gclass14_0, class301_0);
				}
				else
				{
					smethod_11(gclass14_0, class301_0);
				}
			}
			else
			{
				smethod_12(gclass14_0, class301_0);
			}
		}
		else
		{
			smethod_13(gclass14_0, class301_0);
		}
	}

	private static void smethod_7(Class197 class197_0, Class301 class301_0)
	{
		if (class197_0.method_84() == Class84.smethod_0(-994293501))
		{
			smethod_8(class301_0);
			return;
		}
		foreach (Class197 item in class301_0.method_0())
		{
			if (item.method_84() == Class84.smethod_0(-994293501))
			{
				smethod_9(class301_0, item);
			}
		}
	}

	private static void smethod_8(Class301 class301_0)
	{
		if (class301_0.method_1().Count <= 0)
		{
			return;
		}
		double num = class301_0.method_1()[0].method_3();
		double num2 = class301_0.method_1()[class301_0.method_1().Count - 1].method_13();
		foreach (Class245 item in class301_0.method_1())
		{
			double num3 = item.method_3() - num;
			double num4 = num2 - num3;
			item.method_4(num4 - item.method_7());
		}
	}

	private static void smethod_9(Class301 class301_0, Class197 class197_0)
	{
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < class301_0.method_1().Count; i++)
		{
			if (class301_0.method_1()[i].method_0() == class197_0)
			{
				if (num < 0)
				{
					num = i;
				}
				num2 = i;
			}
		}
		if (num > -1 && num2 > num)
		{
			double num3 = class301_0.method_1()[num].method_3();
			double num4 = class301_0.method_1()[num2].method_13();
			for (int j = num; j <= num2; j++)
			{
				double num5 = class301_0.method_1()[j].method_3() - num3;
				double num6 = num4 - num5;
				class301_0.method_1()[j].method_4(num6 - class301_0.method_1()[j].method_7());
			}
		}
	}

	private static void smethod_10(GClass14 gclass14_0, Class301 class301_0)
	{
		double num = -3.4028234663852886E+38;
		foreach (Class197 key in class301_0.method_3().Keys)
		{
			num = Math.Max(num, class301_0.method_3()[key].method_13());
		}
		foreach (Class197 item in new List<Class197>(class301_0.method_3().Keys))
		{
			string text = item.method_94();
			if (text != null)
			{
				switch (text.Length)
				{
				case 3:
					switch (text[0])
					{
					case 't':
						if (text == Class84.smethod_0(-994291933))
						{
							continue;
						}
						break;
					case 's':
						if (text == Class84.smethod_0(-994291810))
						{
							class301_0.method_10(gclass14_0, item, num + class301_0.method_3()[item].method_10() * 0.5);
							continue;
						}
						break;
					}
					break;
				case 5:
					if (text == Class84.smethod_0(-994291832))
					{
						class301_0.method_10(gclass14_0, item, num - class301_0.method_3()[item].method_10() * 0.20000000298023224);
						continue;
					}
					break;
				case 6:
					switch (text[0])
					{
					case 'm':
						if (text == Class84.smethod_0(-994291894))
						{
							continue;
						}
						break;
					case 'b':
						if (text == Class84.smethod_0(-994291875))
						{
							continue;
						}
						break;
					}
					break;
				case 8:
					if (text == Class84.smethod_0(-994291836))
					{
						continue;
					}
					break;
				case 11:
					if (text == Class84.smethod_0(-994291789))
					{
						continue;
					}
					break;
				}
			}
			class301_0.method_10(gclass14_0, item, num);
		}
	}

	private static void smethod_11(GClass14 gclass14_0, Class301 class301_0)
	{
		if (class301_0.Equals(class301_0.method_2().method_200()[class301_0.method_2().method_200().Count - 1]))
		{
			return;
		}
		double num = (class301_0.Equals(class301_0.method_2().method_200()[0]) ? class301_0.method_2().method_178() : 0.0);
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = class301_0.method_2().method_144().method_8() - num;
		foreach (Class245 item in class301_0.method_1())
		{
			num2 += item.method_7();
			num3++;
		}
		if (num3 <= 0.0)
		{
			return;
		}
		double num5 = (num4 - num2) / num3;
		double double_ = class301_0.method_2().method_140() + num;
		foreach (Class245 item2 in class301_0.method_1())
		{
			item2.method_4(double_);
			double_ = item2.method_13() + num5;
			if (item2 == class301_0.method_1()[class301_0.method_1().Count - 1])
			{
				item2.method_4(class301_0.method_2().method_142() - item2.method_7());
			}
		}
	}

	private static void smethod_12(GClass14 gclass14_0, Class301 class301_0)
	{
		if (class301_0.method_1().Count == 0)
		{
			return;
		}
		Class245 @class = class301_0.method_1()[class301_0.method_1().Count - 1];
		double num = class301_0.method_2().method_136() - class301_0.method_2().method_150() - class301_0.method_2().method_160() - @class.method_13() - @class.method_0().method_160() - @class.method_0().method_150();
		num /= 2.0;
		if (!(num > 0.0))
		{
			return;
		}
		foreach (Class245 item in class301_0.method_1())
		{
			item.method_4(item.method_3() + num);
		}
		if (class301_0.method_3().Count <= 0)
		{
			return;
		}
		foreach (Class197 item2 in smethod_15(class301_0.method_3().Keys))
		{
			GStruct1 gStruct = class301_0.method_3()[item2];
			class301_0.method_3()[item2] = new GStruct1(gStruct.method_4() + num, gStruct.method_6(), gStruct.method_8(), gStruct.method_10());
		}
	}

	private static void smethod_13(GClass14 gclass14_0, Class301 class301_0)
	{
		if (class301_0.method_1().Count == 0)
		{
			return;
		}
		Class245 @class = class301_0.method_1()[class301_0.method_1().Count - 1];
		double num = class301_0.method_2().method_136() - class301_0.method_2().method_150() - class301_0.method_2().method_160() - @class.method_13() - @class.method_0().method_160() - @class.method_0().method_150();
		if (!(num > 0.0))
		{
			return;
		}
		foreach (Class245 item in class301_0.method_1())
		{
			item.method_4(item.method_3() + num);
		}
		if (class301_0.method_3().Count <= 0)
		{
			return;
		}
		foreach (Class197 item2 in smethod_15(class301_0.method_3().Keys))
		{
			GStruct1 gStruct = class301_0.method_3()[item2];
			class301_0.method_3()[item2] = new GStruct1(gStruct.method_4() + num, gStruct.method_6(), gStruct.method_8(), gStruct.method_10());
		}
	}

	private static void smethod_14(GClass14 gclass14_0, Class301 class301_0)
	{
	}

	private static List<T> smethod_15<T>(IEnumerable<T> ienumerable_0)
	{
		List<T> list = new List<T>();
		foreach (T item in ienumerable_0)
		{
			list.Add(item);
		}
		return list;
	}
}
