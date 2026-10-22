using System;

internal sealed class Class276 : IDisposable
{
	private readonly Class197 class197_0;

	private readonly Class275 class275_0;

	private GStruct2 gstruct2_0;

	private Class245 class245_0;

	private Class245 class245_1;

	private int int_0 = -1;

	private int int_1 = -1;

	private double double_0 = -1.0;

	private double double_1 = -1.0;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private DateTime dateTime_0;

	private object object_0;

	public Class276(Class197 class197_1)
	{
		GClass24.smethod_1(class197_1, Class84.smethod_0(-994302302));
		class197_0 = class197_1;
		class275_0 = new Class275(this, class197_1.method_186());
	}

	public void method_0(GClass38 gclass38_0)
	{
		if (class197_0.method_186().method_23())
		{
			method_13();
			method_16(class197_0);
			gclass38_0.vmethod_8();
		}
	}

	public void method_1(GClass38 gclass38_0, GStruct2 gstruct2_1)
	{
		if (class197_0.method_186().method_23())
		{
			Class245 @class = Class277.smethod_13(class197_0, gstruct2_1);
			if (@class != null)
			{
				@class.method_18(this);
				gstruct2_0 = gstruct2_1;
				class245_0 = (class245_1 = @class);
				gclass38_0.vmethod_8();
			}
		}
	}

	public void method_2(GClass38 gclass38_0, GStruct2 gstruct2_1, bool bool_6)
	{
		bool flag = !bool_6;
		if (bool_6)
		{
			bool_3 = true;
			bool_2 = (DateTime.Now - dateTime_0).TotalMilliseconds < 400.0;
			dateTime_0 = DateTime.Now;
			bool_4 = false;
			if (class197_0.method_186().method_23() && gclass38_0.vmethod_0())
			{
				Class245 @class = Class277.smethod_13(class197_0, gstruct2_1);
				if (@class != null && @class.method_19())
				{
					bool_4 = true;
				}
				else
				{
					flag = true;
				}
			}
			else if (gclass38_0.vmethod_1())
			{
				Class245 class2 = Class277.smethod_13(class197_0, gstruct2_1);
				Class197 class197_ = Class277.smethod_10(class197_0, gstruct2_1);
				if (class197_0.method_186().method_25())
				{
					class275_0.method_0(gclass38_0, class2, class197_);
				}
				flag = class2 == null || !class2.method_19();
			}
		}
		if (flag)
		{
			method_13();
			gclass38_0.vmethod_8();
		}
	}

	public bool method_3(GClass38 gclass38_0, bool bool_6)
	{
		bool flag = false;
		bool_3 = false;
		if (class197_0.method_186().method_23())
		{
			flag = bool_1;
			if ((!bool_1 & bool_6) && bool_4)
			{
				method_13();
				gclass38_0.vmethod_8();
			}
			bool_4 = false;
			bool_1 = false;
		}
		return flag = flag || DateTime.Now - dateTime_0 > TimeSpan.FromSeconds(1.0);
	}

	public void method_4(GClass38 gclass38_0, GStruct2 gstruct2_1)
	{
		if (class197_0.method_186().method_23() && bool_3 && gclass38_0.vmethod_0())
		{
			if (bool_4)
			{
				if ((DateTime.Now - dateTime_0).TotalMilliseconds > 200.0)
				{
					method_15(gclass38_0);
				}
			}
			else
			{
				method_14(gclass38_0, gstruct2_1, !bool_2);
				bool_1 = class245_0 != null && class245_1 != null && (class245_0 != class245_1 || int_0 != int_1);
			}
		}
		else if (Class277.smethod_10(class197_0, gstruct2_1) != null)
		{
			bool_5 = true;
			gclass38_0.vmethod_4();
		}
		else if (class197_0.method_186().method_23())
		{
			Class245 @class = Class277.smethod_13(class197_0, gstruct2_1);
			bool_5 = @class != null && !@class.vmethod_4() && (!@class.method_19() || (@class.method_20() >= 0 && !(@class.method_3() + @class.method_22() <= gstruct2_1.method_1())) || (!(@class.method_23() < 0.0) && !(@class.method_3() + @class.method_23() >= gstruct2_1.method_1())));
			if (bool_5)
			{
				gclass38_0.vmethod_5();
			}
			else
			{
				gclass38_0.vmethod_3();
			}
		}
		else if (bool_5)
		{
			gclass38_0.vmethod_3();
		}
	}

	public void method_5(GClass38 gclass38_0)
	{
		if (bool_5)
		{
			bool_5 = false;
			gclass38_0.vmethod_3();
		}
	}

	public void method_6()
	{
		if (class197_0.method_186().method_23())
		{
			string string_ = Class277.smethod_17(class197_0, (GEnum3)1, bool_0: true);
			string text = Class277.smethod_16(class197_0);
			if (!string.IsNullOrEmpty(text))
			{
				class197_0.method_186().method_0().method_15(string_, text);
			}
		}
	}

	public string method_7()
	{
		if (!class197_0.method_186().method_23())
		{
			return null;
		}
		return Class277.smethod_16(class197_0);
	}

	public string method_8()
	{
		if (!class197_0.method_186().method_23())
		{
			return null;
		}
		return Class277.smethod_17(class197_0, (GEnum3)1, bool_0: true);
	}

	public int method_9(Class245 class245_2)
	{
		if (class245_2 != (bool_0 ? class245_1 : class245_0))
		{
			return -1;
		}
		if (!bool_0)
		{
			return int_0;
		}
		return int_1;
	}

	public int method_10(Class245 class245_2)
	{
		if (class245_2 != (bool_0 ? class245_0 : class245_1))
		{
			return -1;
		}
		if (!bool_0)
		{
			return int_1;
		}
		return int_0;
	}

	public double method_11(Class245 class245_2)
	{
		if (class245_2 != (bool_0 ? class245_1 : class245_0))
		{
			return -1.0;
		}
		if (!bool_0)
		{
			return double_0;
		}
		return double_1;
	}

	public double method_12(Class245 class245_2)
	{
		if (class245_2 != (bool_0 ? class245_0 : class245_1))
		{
			return -1.0;
		}
		if (!bool_0)
		{
			return double_1;
		}
		return double_0;
	}

	public void method_13()
	{
		object_0 = null;
		smethod_0(class197_0);
		double_0 = -1.0;
		int_0 = -1;
		double_1 = -1.0;
		int_1 = -1;
		gstruct2_0 = GStruct2.gstruct2_0;
		class245_0 = null;
		class245_1 = null;
	}

	public void Dispose()
	{
		class275_0.Dispose();
	}

	private void method_14(GClass38 gclass38_0, GStruct2 gstruct2_1, bool bool_6)
	{
		Class301 @class = Class277.smethod_12(class197_0, gstruct2_1);
		if (@class == null)
		{
			return;
		}
		Class245 class2 = Class277.smethod_14(@class, gstruct2_1);
		if (class2 == null && @class.method_1().Count > 0)
		{
			if (gstruct2_1.method_3() > @class.method_5())
			{
				class2 = @class.method_1()[@class.method_1().Count - 1];
			}
			else if (gstruct2_1.method_1() < @class.method_1()[0].method_3())
			{
				class2 = @class.method_1()[0];
			}
			else if (gstruct2_1.method_1() > @class.method_1()[@class.method_1().Count - 1].method_13())
			{
				class2 = @class.method_1()[@class.method_1().Count - 1];
			}
		}
		if (class2 == null)
		{
			return;
		}
		if (class245_0 == null)
		{
			gstruct2_0 = gstruct2_1;
			class245_0 = class2;
			if (bool_6)
			{
				method_20(gclass38_0, class2, gstruct2_1, bool_6: true);
			}
		}
		class245_1 = class2;
		if (bool_6)
		{
			method_20(gclass38_0, class2, gstruct2_1, bool_6: false);
		}
		smethod_0(class197_0);
		if (method_17(gstruct2_1, bool_6))
		{
			method_21();
			method_18(class197_0, bool_0 ? class245_1 : class245_0, bool_0 ? class245_0 : class245_1);
		}
		else
		{
			class245_1 = null;
		}
		bool_5 = true;
		gclass38_0.vmethod_5();
		gclass38_0.vmethod_8();
	}

	private static void smethod_0(Class197 class197_1)
	{
		foreach (Class245 item in class197_1.method_203())
		{
			item.method_18(null);
		}
		foreach (Class197 item2 in class197_1.method_190())
		{
			smethod_0(item2);
		}
	}

	private void method_15(GClass38 gclass38_0)
	{
		if (object_0 == null)
		{
			string string_ = Class277.smethod_17(class197_0, (GEnum3)1, bool_0: true);
			string string_2 = Class277.smethod_16(class197_0);
			object_0 = gclass38_0.method_0().method_13(string_, string_2);
		}
		gclass38_0.vmethod_6(object_0);
	}

	public void method_16(Class197 class197_1)
	{
		foreach (Class245 item in class197_1.method_203())
		{
			item.method_18(this);
		}
		foreach (Class197 item2 in class197_1.method_190())
		{
			method_16(item2);
		}
	}

	private bool method_17(GStruct2 gstruct2_1, bool bool_6)
	{
		if (!bool_6)
		{
			return true;
		}
		if (Math.Abs(gstruct2_0.method_1() - gstruct2_1.method_1()) <= 1.0 && Math.Abs(gstruct2_0.method_3() - gstruct2_1.method_3()) < 5.0)
		{
			return false;
		}
		if (class245_0 == class245_1)
		{
			return int_0 != int_1;
		}
		return true;
	}

	private void method_18(Class197 class197_1, Class245 class245_2, Class245 class245_3)
	{
		bool bool_ = false;
		method_19(class197_1, class245_2, class245_3, ref bool_);
	}

	private bool method_19(Class197 class197_1, Class245 class245_2, Class245 class245_3, ref bool bool_6)
	{
		foreach (Class245 item in class197_1.method_203())
		{
			if (!bool_6 && item == class245_2)
			{
				bool_6 = true;
			}
			if (bool_6)
			{
				item.method_18(this);
				if (class245_2 == class245_3 || item == class245_3)
				{
					return true;
				}
			}
		}
		foreach (Class197 item2 in class197_1.method_190())
		{
			if (method_19(item2, class245_2, class245_3, ref bool_6))
			{
				return true;
			}
		}
		return false;
	}

	private void method_20(GClass38 gclass38_0, Class245 class245_2, GStruct2 gstruct2_1, bool bool_6)
	{
		smethod_1(gclass38_0, class245_2, gstruct2_1, bool_6, out var int_, out var double_);
		if (bool_6)
		{
			int_0 = int_;
			double_0 = double_;
		}
		else
		{
			int_1 = int_;
			double_1 = double_;
		}
	}

	private static void smethod_1(GClass38 gclass38_0, Class245 class245_2, GStruct2 gstruct2_1, bool bool_6, out int int_2, out double double_2)
	{
		int_2 = 0;
		double_2 = 0.0;
		double num = gstruct2_1.method_1() - class245_2.method_3();
		if (class245_2.vmethod_7() == null)
		{
			int_2 = -1;
			double_2 = -1.0;
		}
		else if (!(num > class245_2.method_7() - class245_2.method_0().method_170()) && gstruct2_1.method_3() <= Class277.smethod_15(class245_2).method_5())
		{
			if (num > 0.0)
			{
				double num2 = num + (bool_6 ? 0.0 : (1.5 * class245_2.method_24()));
				gclass38_0.vmethod_7(class245_2.vmethod_7(), class245_2.method_0().method_176(), num2, out var num3, out var num4);
				int_2 = num3;
				double_2 = num4;
			}
		}
		else
		{
			int_2 = class245_2.vmethod_7().Length;
			double_2 = class245_2.method_7();
		}
	}

	private void method_21()
	{
		if (class245_0 == class245_1)
		{
			bool_0 = int_0 > int_1;
		}
		else if (Class277.smethod_15(class245_0) == Class277.smethod_15(class245_1))
		{
			bool_0 = class245_0.method_3() > class245_1.method_3();
		}
		else
		{
			bool_0 = class245_0.method_5() >= class245_1.method_15();
		}
	}
}
