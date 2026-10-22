using System;
using System.Collections.Generic;
using System.Globalization;

internal class Class197 : Class196, IDisposable
{
	private Class197 class197_0;

	protected GClass31 gclass31_0;

	private readonly Class343 class343_0;

	private readonly List<Class245> list_0 = new List<Class245>();

	private readonly List<Class197> list_1 = new List<Class197>();

	private readonly List<Class301> list_2 = new List<Class301>();

	private readonly List<Class301> list_3 = new List<Class301>();

	private readonly Dictionary<Class301, GStruct1> dictionary_0 = new Dictionary<Class301, GStruct1>();

	private Class289 class289_0;

	internal bool bool_0;

	protected bool bool_1;

	private Class197 class197_1;

	private Class301 class301_0;

	private Class301 class301_1;

	private Class214 class214_0;

	public Class197(Class197 class197_2, Class343 class343_1)
	{
		if (class197_2 != null)
		{
			class197_0 = class197_2;
			class197_0.method_190().Add(this);
		}
		class343_0 = class343_1;
	}

	public GClass31 method_186()
	{
		return gclass31_0 ?? (gclass31_0 = ((class197_0 != null) ? class197_0.method_186() : null));
	}

	public void method_187(GClass31 gclass31_1)
	{
		gclass31_0 = gclass31_1;
	}

	public Class197 method_188()
	{
		return class197_0;
	}

	public void method_189(Class197 class197_2)
	{
		if (class197_0 != null)
		{
			class197_0.method_190().Remove(this);
		}
		class197_0 = class197_2;
		if (class197_2 != null)
		{
			class197_0.method_190().Add(this);
		}
	}

	public List<Class197> method_190()
	{
		return list_1;
	}

	public bool method_191()
	{
		if (class343_0 != null)
		{
			return class343_0.method_0().Equals(Class84.smethod_0(-994289994), StringComparison.InvariantCultureIgnoreCase);
		}
		return false;
	}

	public bool method_192()
	{
		if (!(method_82() == Class84.smethod_0(-994290001)) && !(method_82() == Class84.smethod_0(-994289956)))
		{
			return false;
		}
		return !method_191();
	}

	public bool method_193()
	{
		return method_82() == Class84.smethod_0(-994289969);
	}

	public virtual bool vmethod_4()
	{
		if (method_195() != null && method_195().method_0() == Class84.smethod_0(-994289925))
		{
			return !method_195().method_4(Class84.smethod_0(-994264162));
		}
		return false;
	}

	public virtual bool vmethod_5()
	{
		if (method_90() == Class84.smethod_0(-994289933))
		{
			return true;
		}
		if (method_188() == null)
		{
			return false;
		}
		Class197 @class = this;
		while (@class.method_188() != null && @class != @class.method_188())
		{
			@class = @class.method_188();
			if (@class.method_90() == Class84.smethod_0(-994289933))
			{
				return true;
			}
		}
		return false;
	}

	public virtual string vmethod_6()
	{
		return method_217(Class84.smethod_0(-994289937));
	}

	public Class197 method_194()
	{
		if (method_188() == null)
		{
			return this;
		}
		Class197 @class = method_188();
		while (!@class.method_193() && @class.method_82() != Class84.smethod_0(-994289894) && @class.method_82() != Class84.smethod_0(-994289910) && @class.method_82() != Class84.smethod_0(-994289914) && @class.method_188() != null)
		{
			@class = @class.method_188();
		}
		if (@class == null)
		{
			throw new Exception(Class84.smethod_0(-994289865));
		}
		return @class;
	}

	public Class343 method_195()
	{
		return class343_0;
	}

	public bool method_196()
	{
		if (method_203().Count == 1)
		{
			return method_203()[0].vmethod_4();
		}
		return false;
	}

	public bool method_197()
	{
		if ((method_203().Count != 0 || method_190().Count != 0) && (method_203().Count != 1 || !method_203()[0].vmethod_5()))
		{
			foreach (Class245 item in method_203())
			{
				if (!item.vmethod_5())
				{
					return false;
				}
			}
		}
		return true;
	}

	public Class289 method_198()
	{
		return class289_0;
	}

	public void method_199(Class289 class289_1)
	{
		class289_0 = class289_1;
		list_0.Clear();
	}

	internal List<Class301> method_200()
	{
		return list_2;
	}

	internal List<Class301> method_201()
	{
		return list_3;
	}

	internal Dictionary<Class301, GStruct1> method_202()
	{
		return dictionary_0;
	}

	internal List<Class245> method_203()
	{
		return list_0;
	}

	internal Class245 method_204()
	{
		return method_203()[0];
	}

	internal Class301 method_205()
	{
		return class301_0;
	}

	internal void method_206(Class301 class301_2)
	{
		class301_0 = class301_2;
	}

	internal Class301 method_207()
	{
		return class301_1;
	}

	internal void method_208(Class301 class301_2)
	{
		class301_1 = class301_2;
	}

	public static Class197 smethod_0(Class343 class343_1, Class197 class197_2)
	{
		GClass24.smethod_1(class343_1, Class84.smethod_0(-994289850));
		if (class343_1.method_0() == Class84.smethod_0(-994289808))
		{
			return new Class200(class197_2, class343_1);
		}
		if (class343_1.method_0() == Class84.smethod_0(-994289814))
		{
			return new Class198(class197_2, class343_1);
		}
		if (class343_1.method_0() == Class84.smethod_0(-994289817))
		{
			return new Class199(class197_2, class343_1);
		}
		return new Class197(class197_2, class343_1);
	}

	public static Class197 smethod_1(Class197 class197_2, Class343 class343_1, Class197 class197_3)
	{
		GClass24.smethod_1(class197_2, Class84.smethod_0(-994289776));
		Class197 @class = new Class197(class197_2, class343_1);
		@class.method_223(null, bool_2: false);
		if (class197_3 != null)
		{
			@class.method_211(class197_3);
		}
		return @class;
	}

	public static Class197 smethod_2()
	{
		Class197 @class = new Class197(null, null);
		@class.method_83(Class84.smethod_0(-994289969));
		return @class;
	}

	public static Class197 smethod_3(Class197 class197_2, Class343 class343_1, Class197 class197_3)
	{
		GClass24.smethod_1(class197_2, Class84.smethod_0(-994289776));
		Class197 @class = smethod_1(class197_2, class343_1, class197_3);
		@class.method_83(Class84.smethod_0(-994289969));
		return @class;
	}

	public void method_209(GClass14 gclass14_0)
	{
		try
		{
			vmethod_7(gclass14_0);
		}
		catch (Exception exception_)
		{
			method_186().method_72(GEnum7.Layout, Class84.smethod_0(-994289779), exception_);
		}
	}

	public void method_210(GClass14 gclass14_0)
	{
		try
		{
			if (!(method_82() != Class84.smethod_0(-994289749)) || !(method_104() == Class84.smethod_0(-994289754)))
			{
				return;
			}
			if (method_90() == Class84.smethod_0(-994289933))
			{
				gclass14_0.method_4();
			}
			bool flag;
			if (!(flag = method_202().Count == 0))
			{
				GStruct1 gStruct = gclass14_0.method_3();
				GStruct1 gstruct1_ = method_194().method_144();
				gstruct1_.method_5(gstruct1_.method_4() - 2.0);
				gstruct1_.method_9(gstruct1_.method_8() + 2.0);
				if (!vmethod_5())
				{
					gstruct1_.method_24(method_186().method_27());
				}
				gStruct.method_22(gstruct1_);
				if (gStruct != GStruct1.gstruct1_0)
				{
					flag = true;
				}
			}
			if (flag)
			{
				vmethod_9(gclass14_0);
			}
			if (method_90() == Class84.smethod_0(-994289933))
			{
				gclass14_0.method_5();
			}
		}
		catch (Exception exception_)
		{
			method_186().method_72(GEnum7.Paint, Class84.smethod_0(-994289708), exception_);
		}
	}

	public void method_211(Class197 class197_2)
	{
		int num = class197_0.method_190().IndexOf(class197_2);
		if (num < 0)
		{
			throw new Exception(Class84.smethod_0(-994289679));
		}
		class197_0.method_190().Remove(this);
		class197_0.method_190().Insert(num, this);
	}

	public void method_212(Class197 class197_2)
	{
		foreach (Class197 item in class197_2.list_1)
		{
			item.class197_0 = this;
		}
		list_1.AddRange(class197_2.list_1);
		class197_2.list_1.Clear();
	}

	public void method_213()
	{
		list_0.Clear();
		int i = 0;
		bool flag2;
		bool flag = (flag2 = method_102() == Class84.smethod_0(-994293750) || method_102() == Class84.smethod_0(-994293756)) || method_102() == Class84.smethod_0(-994293709);
		while (i < class289_0.method_2())
		{
			for (; i < class289_0.method_2() && class289_0.get_Item(i) == '\r'; i++)
			{
			}
			if (i >= class289_0.method_2())
			{
				continue;
			}
			int j;
			for (j = i; j < class289_0.method_2() && char.IsWhiteSpace(class289_0.get_Item(j)) && class289_0.get_Item(j) != '\n'; j++)
			{
			}
			if (j > i)
			{
				if (flag2)
				{
					list_0.Add(new Class247(this, Class273.smethod_1(class289_0.method_7(i, j - i)), bool_2: false, bool_3: false));
				}
			}
			else
			{
				for (j = i; j < class289_0.method_2() && !char.IsWhiteSpace(class289_0.get_Item(j)) && class289_0.get_Item(j) != '-'; j++)
				{
					if (!(method_108() != Class84.smethod_0(-994293726)))
					{
						break;
					}
					if (Class299.smethod_0(class289_0.get_Item(j)))
					{
						break;
					}
				}
				if (j < class289_0.method_2() && (class289_0.get_Item(j) == '-' || method_108() == Class84.smethod_0(-994293726) || Class299.smethod_0(class289_0.get_Item(j))))
				{
					j++;
				}
				if (j > i)
				{
					bool bool_ = !flag2 && i > 0 && list_0.Count == 0 && char.IsWhiteSpace(class289_0.get_Item(i - 1));
					bool bool_2 = !flag2 && j < class289_0.method_2() && char.IsWhiteSpace(class289_0.get_Item(j));
					list_0.Add(new Class247(this, Class273.smethod_1(class289_0.method_7(i, j - i)), bool_, bool_2));
				}
			}
			if (j < class289_0.method_2() && class289_0.get_Item(j) == '\n')
			{
				j++;
				if (flag)
				{
					list_0.Add(new Class247(this, Class84.smethod_0(-994263511), bool_2: false, bool_3: false));
				}
			}
			i = j;
		}
	}

	public virtual void Dispose()
	{
		if (class214_0 != null)
		{
			class214_0.Dispose();
		}
		foreach (Class197 item in method_190())
		{
			item.Dispose();
		}
	}

	protected virtual void vmethod_7(GClass14 gclass14_0)
	{
		if (method_82() != Class84.smethod_0(-994289749))
		{
			method_234();
			vmethod_8(gclass14_0);
		}
		if (!method_193() && !(method_82() == Class84.smethod_0(-994289894)) && !(method_82() == Class84.smethod_0(-994289910)) && !(method_82() == Class84.smethod_0(-994293678)) && !(method_82() == Class84.smethod_0(-994289914)))
		{
			Class197 @class = Class277.smethod_3(this);
			if (@class != null)
			{
				if (method_130() == GStruct2.gstruct2_0)
				{
					method_131(@class.method_130());
				}
				method_139(@class.method_138());
			}
		}
		else
		{
			if (method_82() != Class84.smethod_0(-994289914) && method_82() != Class84.smethod_0(-994289910))
			{
				double num = method_194().method_132().method_1() - method_194().method_148() - method_194().method_150() - method_194().method_158() - method_194().method_160();
				if (method_60() != Class84.smethod_0(-994293691) && !string.IsNullOrEmpty(method_60()))
				{
					num = Class172.smethod_4(method_60(), num, this, bool_0: false);
				}
				method_133(new GStruct4(num, method_132().method_3()));
				method_133(new GStruct4(num - method_154() - method_156(), method_132().method_3()));
			}
			if (method_82() != Class84.smethod_0(-994289914))
			{
				Class197 class2 = Class277.smethod_3(this);
				if (method_90() == Class84.smethod_0(-994289933))
				{
					double num2 = 0.0;
					double num3 = 0.0;
				}
				else
				{
					double num2 = method_194().method_130().method_1() + method_194().method_148() + method_154() + method_194().method_158();
					double num3 = ((class2 == null && method_188() != null) ? method_188().method_141() : ((method_188() == null) ? method_130().method_3() : 0.0)) + method_224(class2) + ((class2 != null) ? (class2.method_138() + class2.method_159()) : 0.0);
					method_131(new GStruct2(num2, num3));
					method_139(num3);
				}
			}
			if (!(method_82() == Class84.smethod_0(-994289910)) && !(method_82() == Class84.smethod_0(-994293678)))
			{
				if (Class277.smethod_1(this))
				{
					method_139(method_130().method_3());
					Class281.smethod_1(gclass14_0, this);
				}
				else if (list_1.Count > 0)
				{
					foreach (Class197 item in method_190())
					{
						item.method_209(gclass14_0);
					}
					method_137(method_226());
					method_139(method_227());
				}
			}
			else
			{
				Class317.smethod_1(gclass14_0, this);
			}
		}
		method_139(Math.Max(method_138(), method_130().method_3() + method_145()));
		method_215(gclass14_0);
		if (!vmethod_5())
		{
			double num4 = Math.Max(method_219() + smethod_5(this), (method_132().method_1() < 90999.0) ? (method_136() - method_186().method_48().method_130().method_1()) : 0.0);
			method_186().method_34(Class299.smethod_3(method_186().method_33(), new GStruct4(num4, method_138() - method_186().method_48().method_130().method_3())));
		}
	}

	internal virtual void vmethod_8(GClass14 gclass14_0)
	{
		if (bool_1)
		{
			return;
		}
		if (method_68() != Class84.smethod_0(-994289749) && class214_0 == null)
		{
			class214_0 = new Class214(method_186(), method_235);
			class214_0.method_2(method_68(), (method_195() != null) ? method_195().method_1() : null);
		}
		method_184(gclass14_0);
		if (method_203().Count > 0)
		{
			foreach (Class245 item in method_203())
			{
				item.method_8((item.vmethod_7() != Class84.smethod_0(-994263511)) ? gclass14_0.vmethod_7(item.vmethod_7(), method_176()).method_1() : 0.0);
				item.method_12(method_176().vmethod_1());
			}
		}
		bool_1 = true;
	}

	protected sealed override Class196 vmethod_3()
	{
		return class197_0;
	}

	private int method_214()
	{
		bool flag = !string.IsNullOrEmpty(method_188().method_217(Class84.smethod_0(-994293648)));
		if (!int.TryParse(method_188().method_217(Class84.smethod_0(-994293649)), out var result))
		{
			if (flag)
			{
				result = 0;
				foreach (Class197 item in method_188().method_190())
				{
					if (item.method_82() == Class84.smethod_0(-994289894))
					{
						result++;
					}
				}
			}
			else
			{
				result = 1;
			}
		}
		foreach (Class197 item2 in method_188().method_190())
		{
			if (!item2.Equals(this))
			{
				if (item2.method_82() == Class84.smethod_0(-994289894))
				{
					result += ((!flag) ? 1 : (-1));
				}
				continue;
			}
			return result;
		}
		return result;
	}

	private void method_215(GClass14 gclass14_0)
	{
		if (!(method_82() == Class84.smethod_0(-994289894)) || !(method_128() != Class84.smethod_0(-994289749)))
		{
			return;
		}
		if (class197_1 == null)
		{
			class197_1 = new Class197(null, null);
			class197_1.method_223(this, bool_2: false);
			class197_1.method_83(Class84.smethod_0(-994290001));
			class197_1.method_187(method_186());
			if (method_128().Equals(Class84.smethod_0(-994293605), StringComparison.InvariantCultureIgnoreCase))
			{
				class197_1.method_199(new Class289(Class84.smethod_0(-994293610)));
			}
			else if (method_128().Equals(Class84.smethod_0(-994293617), StringComparison.InvariantCultureIgnoreCase))
			{
				class197_1.method_199(new Class289(Class84.smethod_0(-994293572)));
			}
			else if (method_128().Equals(Class84.smethod_0(-994293580), StringComparison.InvariantCultureIgnoreCase))
			{
				class197_1.method_199(new Class289(Class84.smethod_0(-994293599)));
			}
			else if (method_128().Equals(Class84.smethod_0(-994293542), StringComparison.InvariantCultureIgnoreCase))
			{
				class197_1.method_199(new Class289(method_214().ToString(CultureInfo.InvariantCulture) + Class84.smethod_0(-994272055)));
			}
			else if (method_128().Equals(Class84.smethod_0(-994293560), StringComparison.InvariantCultureIgnoreCase))
			{
				class197_1.method_199(new Class289(method_214().ToString(Class84.smethod_0(-994293517), CultureInfo.InvariantCulture) + Class84.smethod_0(-994272055)));
			}
			else
			{
				class197_1.method_199(new Class289(Class299.smethod_12(method_214(), method_128()) + Class84.smethod_0(-994272055)));
			}
			class197_1.method_213();
			class197_1.vmethod_7(gclass14_0);
			class197_1.method_133(new GStruct4(class197_1.method_203()[0].method_7(), class197_1.method_203()[0].method_11()));
		}
		class197_1.method_203()[0].method_4(method_130().method_1() - class197_1.method_132().method_1() - 5.0);
		class197_1.method_203()[0].method_6(method_130().method_3() + method_147());
	}

	internal Class245 method_216(Class197 class197_2, Class301 class301_2)
	{
		if (class197_2.method_203().Count == 0 && class197_2.method_190().Count == 0)
		{
			return null;
		}
		if (class197_2.method_203().Count > 0)
		{
			foreach (Class245 item in class197_2.method_203())
			{
				if (class301_2.method_1().Contains(item))
				{
					return item;
				}
			}
			return null;
		}
		foreach (Class197 item2 in class197_2.method_190())
		{
			Class245 @class = method_216(item2, class301_2);
			if (@class != null)
			{
				return @class;
			}
		}
		return null;
	}

	internal string method_217(string string_67)
	{
		return method_218(string_67, string.Empty);
	}

	internal string method_218(string string_67, string string_68)
	{
		if (method_195() == null)
		{
			return string_68;
		}
		return method_195().method_5(string_67, string_68);
	}

	internal double method_219()
	{
		double double_ = 0.0;
		Class245 class245_ = null;
		smethod_4(this, ref double_, ref class245_);
		double num = 0.0;
		if (class245_ != null)
		{
			for (Class197 @class = class245_.method_0(); @class != null; @class = ((@class != this) ? @class.method_188() : null))
			{
				num += @class.method_160() + @class.method_150() + @class.method_158() + @class.method_148();
			}
		}
		return double_ + num;
	}

	private static void smethod_4(Class197 class197_2, ref double double_25, ref Class245 class245_0)
	{
		if (class197_2.method_203().Count > 0)
		{
			foreach (Class245 item in class197_2.method_203())
			{
				if (item.method_7() > double_25)
				{
					double_25 = item.method_7();
					class245_0 = item;
				}
			}
			return;
		}
		foreach (Class197 item2 in class197_2.method_190())
		{
			smethod_4(item2, ref double_25, ref class245_0);
		}
	}

	private static double smethod_5(Class197 class197_2)
	{
		double num = 0.0;
		if (class197_2.method_132().method_1() > 90999.0 || (class197_2.method_188() != null && class197_2.method_188().method_132().method_1() > 90999.0))
		{
			while (class197_2 != null)
			{
				num += class197_2.method_154() + class197_2.method_156();
				class197_2 = class197_2.method_188();
			}
		}
		return num;
	}

	internal double method_220(Class197 class197_2, double double_25)
	{
		foreach (Class301 key in class197_2.method_202().Keys)
		{
			double_25 = Math.Max(double_25, class197_2.method_202()[key].method_15());
		}
		foreach (Class197 item in class197_2.method_190())
		{
			double_25 = Math.Max(double_25, method_220(item, double_25));
		}
		return double_25;
	}

	internal void method_221(out double double_25, out double double_26)
	{
		double double_27 = 0.0;
		double double_28 = 0.0;
		double double_29 = 0.0;
		double double_30 = 0.0;
		smethod_6(this, ref double_27, ref double_28, ref double_29, ref double_30);
		double_26 = double_29 + double_28;
		double_25 = double_29 + ((double_27 < 90999.0) ? double_27 : 0.0);
	}

	private static void smethod_6(Class197 class197_2, ref double double_25, ref double double_26, ref double double_27, ref double double_28)
	{
		double? num = null;
		if (class197_2.method_82() != Class84.smethod_0(-994290001) && class197_2.method_82() != Class84.smethod_0(-994289914) && class197_2.method_102() != Class84.smethod_0(-994293524))
		{
			num = double_26;
			double_26 = double_28;
		}
		double_27 += class197_2.method_158() + class197_2.method_160() + class197_2.method_150() + class197_2.method_148();
		if (class197_2.method_82() == Class84.smethod_0(-994289910))
		{
			double_27 += Class317.smethod_0(class197_2);
		}
		if (class197_2.method_203().Count > 0)
		{
			foreach (Class245 item in class197_2.method_203())
			{
				double_26 += item.method_9() + (item.vmethod_0() ? item.method_0().method_170() : 0.0);
				double_25 = Math.Max(double_25, item.method_7());
			}
			if (class197_2.method_203().Count > 0 && !class197_2.method_203()[class197_2.method_203().Count - 1].vmethod_1())
			{
				double_26 -= class197_2.method_203()[class197_2.method_203().Count - 1].method_10();
			}
		}
		else
		{
			for (int i = 0; i < class197_2.method_190().Count; i++)
			{
				Class197 @class = class197_2.method_190()[i];
				double_28 += @class.method_154() + @class.method_156();
				smethod_6(@class, ref double_25, ref double_26, ref double_27, ref double_28);
				double_28 -= @class.method_154() + @class.method_156();
			}
		}
		if (num.HasValue)
		{
			double_26 = Math.Max(double_26, num.Value);
		}
	}

	internal bool method_222()
	{
		if (method_188() != null)
		{
			return Class277.smethod_1(method_188());
		}
		return false;
	}

	internal void method_223(Class197 class197_2, bool bool_2)
	{
		method_185(class197_2 ?? method_188(), bool_2);
	}

	protected double method_224(Class196 class196_0)
	{
		double num;
		if (class196_0 == null)
		{
			num = ((class197_0 == null || !(method_147() < 0.1) || !(method_149() < 0.1) || !(class197_0.method_147() < 0.1) || !(class197_0.method_149() < 0.1)) ? method_151() : Math.Max(0.0, method_151() - Math.Max(class197_0.method_151(), class197_0.method_152())));
		}
		else
		{
			num = Math.Max(class196_0.method_155(), method_151());
			method_153(num);
		}
		if (num < 0.1 && method_195() != null && method_195().method_0() == Class84.smethod_0(-994289817))
		{
			num = method_181() * 1.100000023841858;
		}
		return num;
	}

	public bool method_225()
	{
		GClass31 gClass = method_186();
		if (method_132().method_3() >= gClass.method_35().method_3())
		{
			return false;
		}
		double num = (method_130().method_3() - (double)gClass.method_37()) % gClass.method_35().method_3();
		double num2 = (method_138() - (double)gClass.method_37()) % gClass.method_35().method_3();
		if (num > num2)
		{
			double num3 = gClass.method_35().method_3() - num;
			method_131(new GStruct2(method_130().method_1(), method_130().method_3() + num3 + 1.0));
			return true;
		}
		return false;
	}

	private double method_226()
	{
		if (method_136() > 90999.0)
		{
			double num = 0.0;
			foreach (Class197 item in method_190())
			{
				num = Math.Max(num, item.method_136() + item.method_156());
			}
			return num + method_150() + method_156() + method_160();
		}
		return method_136();
	}

	private double method_227()
	{
		double num = 0.0;
		if (method_188() != null && method_188().method_190().IndexOf(this) == method_188().method_190().Count - 1 && class197_0.method_155() < 0.1)
		{
			double num2 = list_1[list_1.Count - 1].method_155();
			num = ((method_64() == Class84.smethod_0(-994293691)) ? Math.Max(method_155(), num2) : num2);
		}
		return Math.Max(method_138(), list_1[list_1.Count - 1].method_138() + num + method_149() + method_159());
	}

	internal void method_228(double double_25)
	{
		List<Class301> list = new List<Class301>();
		foreach (Class301 key in method_202().Keys)
		{
			list.Add(key);
		}
		foreach (Class301 item in list)
		{
			GStruct1 gStruct = method_202()[item];
			method_202()[item] = new GStruct1(gStruct.method_4(), gStruct.method_6() + double_25, gStruct.method_8(), gStruct.method_10());
		}
		foreach (Class245 item2 in method_203())
		{
			item2.method_6(item2.method_5() + double_25);
		}
		foreach (Class197 item3 in method_190())
		{
			item3.method_228(double_25);
		}
		if (class197_1 != null)
		{
			class197_1.method_228(double_25);
		}
		method_131(new GStruct2(method_130().method_1(), method_130().method_3() + double_25));
	}

	protected virtual void vmethod_9(GClass14 gclass14_0)
	{
		if (!(method_82() != Class84.smethod_0(-994289749)) || (!(method_82() != Class84.smethod_0(-994289914)) && !(method_86() != Class84.smethod_0(-994293479)) && method_197()))
		{
			return;
		}
		bool flag = Class328.smethod_1(gclass14_0, this);
		List<GStruct1> list = ((method_202().Count == 0) ? new List<GStruct1>(new GStruct1[1] { method_134() }) : new List<GStruct1>(method_202().Values));
		GStruct1 gstruct1_ = gclass14_0.method_3();
		GStruct1[] array = list.ToArray();
		GStruct2 gstruct2_ = GStruct2.gstruct2_0;
		if (!vmethod_5())
		{
			gstruct2_ = method_186().method_27();
		}
		for (int i = 0; i < array.Length; i++)
		{
			GStruct1 gstruct1_2 = array[i];
			gstruct1_2.method_24(gstruct2_);
			if (method_229(gstruct1_2, gstruct1_))
			{
				method_230(gclass14_0, gstruct1_2, i == 0, i == array.Length - 1);
				Class259.smethod_0(gclass14_0, this, gstruct1_2, i == 0, i == array.Length - 1);
			}
		}
		method_231(gclass14_0, gstruct2_);
		for (int j = 0; j < array.Length; j++)
		{
			GStruct1 gstruct1_3 = array[j];
			gstruct1_3.method_24(gstruct2_);
			if (method_229(gstruct1_3, gstruct1_))
			{
				method_232(gclass14_0, gstruct1_3, j == 0, j == array.Length - 1);
			}
		}
		foreach (Class197 item in method_190())
		{
			if (item.method_90() != Class84.smethod_0(-994293484) && !item.vmethod_5())
			{
				item.method_210(gclass14_0);
			}
		}
		foreach (Class197 item2 in method_190())
		{
			if (item2.method_90() == Class84.smethod_0(-994293484))
			{
				item2.method_210(gclass14_0);
			}
		}
		foreach (Class197 item3 in method_190())
		{
			if (item3.vmethod_5())
			{
				item3.method_210(gclass14_0);
			}
		}
		if (flag)
		{
			gclass14_0.vmethod_0();
		}
		if (class197_1 != null)
		{
			class197_1.method_210(gclass14_0);
		}
	}

	private bool method_229(GStruct1 gstruct1_0, GStruct1 gstruct1_1)
	{
		gstruct1_0.method_5(gstruct1_0.method_4() - 2.0);
		gstruct1_0.method_9(gstruct1_0.method_8() + 2.0);
		gstruct1_1.method_22(gstruct1_0);
		if (gstruct1_1 != GStruct1.gstruct1_0)
		{
			return true;
		}
		return false;
	}

	protected void method_230(GClass14 gclass14_0, GStruct1 gstruct1_0, bool bool_2, bool bool_3)
	{
		if (!(gstruct1_0.method_8() > 0.0) || !(gstruct1_0.method_10() > 0.0))
		{
			return;
		}
		GClass25 gClass = null;
		if (method_74() != Class84.smethod_0(-994289749))
		{
			gClass = gclass14_0.method_2(gstruct1_0, method_172(), method_173(), method_174());
		}
		else if (Class328.smethod_0(method_172()))
		{
			gClass = gclass14_0.method_1(method_172());
		}
		if (gClass != null)
		{
			GClass30 gClass2 = null;
			if (method_169())
			{
				gClass2 = Class328.smethod_4(gclass14_0, gstruct1_0, method_165(), method_166(), method_167(), method_168());
			}
			object object_ = null;
			if (method_186() != null && !method_186().method_17() && method_169())
			{
				object_ = gclass14_0.vmethod_3();
			}
			if (gClass2 != null)
			{
				gclass14_0.vmethod_16(gClass, gClass2);
			}
			else
			{
				gclass14_0.vmethod_12(gClass, Math.Ceiling(gstruct1_0.method_4()), Math.Ceiling(gstruct1_0.method_6()), gstruct1_0.method_8(), gstruct1_0.method_10());
			}
			gclass14_0.vmethod_4(object_);
			gClass2?.Dispose();
			gClass.Dispose();
		}
		if ((class214_0 != null && class214_0.method_0() != null) & bool_2)
		{
			Class307.smethod_0(gclass14_0, this, class214_0, gstruct1_0);
		}
	}

	private void method_231(GClass14 gclass14_0, GStruct2 gstruct2_1)
	{
		if (method_60().Length <= 0)
		{
			return;
		}
		bool flag = method_84() == Class84.smethod_0(-994293501);
		foreach (Class245 item in method_203())
		{
			if (item.vmethod_6())
			{
				continue;
			}
			GStruct1 gStruct = gclass14_0.method_3();
			GStruct1 gstruct1_ = item.method_1();
			gstruct1_.method_24(gstruct2_1);
			gStruct.method_22(gstruct1_);
			if (!(gStruct != GStruct1.gstruct1_0))
			{
				continue;
			}
			GStruct2 gStruct2 = new GStruct2(item.method_3() + gstruct2_1.method_1(), item.method_5() + gstruct2_1.method_3());
			if (item.method_19())
			{
				Class301 @class = Class277.smethod_15(item);
				double num;
				if (item.method_22() > -1.0)
				{
					num = item.method_22();
				}
				else
				{
					num = ((@class.method_1()[0] == item || !item.vmethod_0()) ? 0.0 : (0.0 - method_170()));
				}
				bool flag2 = item.vmethod_1() && !@class.method_11(item);
				double num2 = ((item.method_23() > -1.0) ? item.method_23() : (item.method_7() + (flag2 ? method_170() : 0.0)));
				GStruct1 gstruct1_2 = new GStruct1(item.method_3() + gstruct2_1.method_1() + num, item.method_5() + gstruct2_1.method_3(), num2 - num, @class.method_4());
				gclass14_0.vmethod_12(method_237(gclass14_0, bool_2: false), gstruct1_2.method_4(), gstruct1_2.method_6(), gstruct1_2.method_8(), gstruct1_2.method_10());
				if (method_186().method_49() != GStruct3.gstruct3_0 && (item.method_22() > 0.0 || item.method_21() > -1))
				{
					gclass14_0.vmethod_2(gstruct1_2);
					gclass14_0.vmethod_9(item.vmethod_7(), method_176(), method_171(), gStruct2, new GStruct4(item.method_7(), item.method_11()), flag);
					gclass14_0.vmethod_0();
					gclass14_0.vmethod_1(gstruct1_2);
					gclass14_0.vmethod_9(item.vmethod_7(), method_176(), method_236(), gStruct2, new GStruct4(item.method_7(), item.method_11()), flag);
					gclass14_0.vmethod_0();
				}
				else
				{
					gclass14_0.vmethod_9(item.vmethod_7(), method_176(), method_236(), gStruct2, new GStruct4(item.method_7(), item.method_11()), flag);
				}
			}
			else
			{
				gclass14_0.vmethod_9(item.vmethod_7(), method_176(), method_171(), gStruct2, new GStruct4(item.method_7(), item.method_11()), flag);
			}
		}
	}

	protected void method_232(GClass14 gclass14_0, GStruct1 gstruct1_0, bool bool_2, bool bool_3)
	{
		if (!string.IsNullOrEmpty(method_100()) && !(method_100() == Class84.smethod_0(-994289749)))
		{
			double num = 0.0;
			if (method_100() == Class84.smethod_0(-994274477))
			{
				num = Math.Round(gstruct1_0.method_13() + method_176().vmethod_2());
			}
			else if (method_100() == Class84.smethod_0(-994293443))
			{
				num = gstruct1_0.method_13() + gstruct1_0.method_10() / 2.0;
			}
			else if (method_100() == Class84.smethod_0(-994293472))
			{
				num = gstruct1_0.method_13();
			}
			num -= method_149() - method_159();
			double num2 = gstruct1_0.method_4();
			if (bool_2)
			{
				num2 += method_148() + method_158();
			}
			double num3 = gstruct1_0.method_14();
			if (bool_3)
			{
				num3 -= method_150() + method_160();
			}
			GClass19 gClass = gclass14_0.method_0(method_171());
			gClass.vmethod_1(1.0);
			gClass.vmethod_2((GEnum4)0);
			gclass14_0.vmethod_10(gClass, num2, num, num3, num);
		}
	}

	internal void method_233(Class301 class301_2, double double_25)
	{
		if (method_202().ContainsKey(class301_2))
		{
			GStruct1 gStruct = method_202()[class301_2];
			method_202()[class301_2] = new GStruct1(gStruct.method_4(), gStruct.method_6() + double_25, gStruct.method_8(), gStruct.method_10());
		}
	}

	internal void method_234()
	{
		dictionary_0.Clear();
	}

	private void method_235(GClass29 gclass29_0, GStruct1 gstruct1_0, bool bool_2)
	{
		if ((gclass29_0 != null) & bool_2)
		{
			method_186().method_71(bool_6: false);
		}
	}

	protected GStruct3 method_236()
	{
		if (!(method_186().method_49() != GStruct3.gstruct3_0))
		{
			return method_171();
		}
		return method_186().method_49();
	}

	protected GClass25 method_237(GClass14 gclass14_0, bool bool_2)
	{
		GStruct3 gStruct = method_186().method_51();
		if (gStruct != GStruct3.gstruct3_0)
		{
			if (bool_2 && gStruct.method_3() > 180)
			{
				return gclass14_0.method_1(GStruct3.smethod_5(180, gStruct.method_0(), gStruct.method_1(), gStruct.method_2()));
			}
			return gclass14_0.method_1(gStruct);
		}
		return gclass14_0.method_1(Class204.smethod_0());
	}

	protected override GClass62 vmethod_2(string string_67, double double_25, GEnum14 genum14_0)
	{
		return method_186().method_0().method_10(string_67, double_25, genum14_0);
	}

	protected override GStruct3 vmethod_1(string string_67)
	{
		return method_186().method_1().method_4(string_67);
	}

	protected override GStruct2 vmethod_0(string string_67, string string_68)
	{
		double num = Class172.smethod_5(string_67, method_186().method_35().method_1(), this, null);
		double num2 = Class172.smethod_5(string_68, method_186().method_35().method_3(), this, null);
		return new GStruct2(num, num2);
	}

	public override string ToString()
	{
		string text = ((method_195() != null) ? string.Format(Class84.smethod_0(-994293430), method_195().method_0()) : Class84.smethod_0(-994293409));
		if (method_193())
		{
			return string.Format(Class84.smethod_0(-994293434), (method_188() == null) ? Class84.smethod_0(-994293349) : string.Empty, text, method_112(), method_190().Count);
		}
		if (method_82() == Class84.smethod_0(-994289749))
		{
			return string.Format(Class84.smethod_0(-994293368), (method_188() == null) ? Class84.smethod_0(-994293349) : string.Empty, text);
		}
		return string.Format(Class84.smethod_0(-994293318), (method_188() == null) ? Class84.smethod_0(-994293349) : string.Empty, text, method_82(), method_198());
	}
}
