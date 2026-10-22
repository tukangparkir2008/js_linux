internal abstract class Class245
{
	private readonly Class197 class197_0;

	private GStruct1 gstruct1_0;

	private Class276 class276_0;

	protected Class245(Class197 class197_1)
	{
		class197_0 = class197_1;
	}

	public Class197 method_0()
	{
		return class197_0;
	}

	public GStruct1 method_1()
	{
		return gstruct1_0;
	}

	public void method_2(GStruct1 gstruct1_1)
	{
		gstruct1_0 = gstruct1_1;
	}

	public double method_3()
	{
		return gstruct1_0.method_4();
	}

	public void method_4(double double_0)
	{
		gstruct1_0.method_5(double_0);
	}

	public double method_5()
	{
		return gstruct1_0.method_6();
	}

	public void method_6(double double_0)
	{
		gstruct1_0.method_7(double_0);
	}

	public double method_7()
	{
		return gstruct1_0.method_8();
	}

	public void method_8(double double_0)
	{
		gstruct1_0.method_9(double_0);
	}

	public double method_9()
	{
		return gstruct1_0.method_8() + method_10();
	}

	public double method_10()
	{
		if (method_0() == null)
		{
			return 0.0;
		}
		return (vmethod_1() ? method_0().method_170() : 0.0) + (vmethod_4() ? method_0().method_170() : 0.0);
	}

	public double method_11()
	{
		return gstruct1_0.method_10();
	}

	public void method_12(double double_0)
	{
		gstruct1_0.method_11(double_0);
	}

	public double method_13()
	{
		return method_1().method_14();
	}

	public void method_14(double double_0)
	{
		method_8(double_0 - method_3());
	}

	public double method_15()
	{
		return method_1().method_15();
	}

	public void method_16(double double_0)
	{
		method_12(double_0 - method_5());
	}

	public Class276 method_17()
	{
		return class276_0;
	}

	public void method_18(Class276 class276_1)
	{
		class276_0 = class276_1;
	}

	public virtual bool vmethod_0()
	{
		return false;
	}

	public virtual bool vmethod_1()
	{
		return false;
	}

	public virtual GClass29 vmethod_2()
	{
		return null;
	}

	public virtual void vmethod_3(GClass29 gclass29_0)
	{
	}

	public virtual bool vmethod_4()
	{
		return false;
	}

	public virtual bool vmethod_5()
	{
		return true;
	}

	public virtual bool vmethod_6()
	{
		return false;
	}

	public virtual string vmethod_7()
	{
		return null;
	}

	public bool method_19()
	{
		return class276_0 != null;
	}

	public int method_20()
	{
		if (class276_0 == null)
		{
			return -1;
		}
		return class276_0.method_9(this);
	}

	public int method_21()
	{
		if (class276_0 == null)
		{
			return -1;
		}
		return class276_0.method_10(this);
	}

	public double method_22()
	{
		if (class276_0 == null)
		{
			return -1.0;
		}
		return class276_0.method_11(this);
	}

	public double method_23()
	{
		if (class276_0 == null)
		{
			return -1.0;
		}
		return class276_0.method_12(this);
	}

	internal double method_24()
	{
		if (method_0() == null)
		{
			return 0.0;
		}
		return method_0().method_176().vmethod_3();
	}

	public override string ToString()
	{
		return string.Format(Class84.smethod_0(-994295413), vmethod_7().Replace(' ', '-').Replace(Class84.smethod_0(-994263511), Class84.smethod_0(-994295373)), vmethod_7().Length, (vmethod_7().Length != 1) ? Class84.smethod_0(-994295380) : string.Empty);
	}

	public bool method_25()
	{
		GClass31 gClass = method_0().method_186();
		if (method_11() >= gClass.method_35().method_3())
		{
			return false;
		}
		double num = (method_5() - (double)gClass.method_37()) % gClass.method_35().method_3();
		double num2 = (method_15() - (double)gClass.method_37()) % gClass.method_35().method_3();
		if (num > num2)
		{
			method_6(method_5() + (gClass.method_35().method_3() - num + 1.0));
			return true;
		}
		return false;
	}
}
