using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Yim.Jibas.JendelaSekolah.Client.Library.HtmlFactory.Core.Entities;

public sealed class GClass31 : IDisposable
{
	private readonly GClass0 gclass0_0;

	private readonly Class308 class308_0;

	private Class197 class197_0;

	private List<Class338> list_0;

	private Class276 class276_0;

	private Class257 class257_0;

	private GStruct3 gstruct3_0;

	private GStruct3 gstruct3_1;

	private GClass55 gclass55_0;

	private bool bool_0 = true;

	private bool bool_1 = true;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private GStruct2 gstruct2_0;

	private GStruct4 gstruct4_0;

	private GStruct2 gstruct2_1;

	private GStruct4 gstruct4_1;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private EventHandler eventHandler_0;

	private EventHandler<GEventArgs1> eventHandler_1;

	private EventHandler<GEventArgs4> eventHandler_2;

	private EventHandler<GEventArgs3> eventHandler_3;

	private EventHandler<GEventArgs2> eventHandler_4;

	private EventHandler<GEventArgs0> eventHandler_5;

	private EventHandler<GEventArgs5> eventHandler_6;

	private GStruct4 gstruct4_2;

	public GClass31(GClass0 gclass0_1)
	{
		GClass24.smethod_1(gclass0_1, Class84.smethod_0(-994290092));
		gclass0_0 = gclass0_1;
		class308_0 = new Class308(gclass0_1);
	}

	internal GClass0 method_0()
	{
		return gclass0_0;
	}

	internal Class308 method_1()
	{
		return class308_0;
	}

	public void method_2(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_3(EventHandler eventHandler_7)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_4(EventHandler<GEventArgs1> eventHandler_7)
	{
		EventHandler<GEventArgs1> eventHandler = eventHandler_1;
		EventHandler<GEventArgs1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs1> value = (EventHandler<GEventArgs1>)Delegate.Combine(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_5(EventHandler<GEventArgs1> eventHandler_7)
	{
		EventHandler<GEventArgs1> eventHandler = eventHandler_1;
		EventHandler<GEventArgs1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs1> value = (EventHandler<GEventArgs1>)Delegate.Remove(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_6(EventHandler<GEventArgs4> eventHandler_7)
	{
		EventHandler<GEventArgs4> eventHandler = eventHandler_2;
		EventHandler<GEventArgs4> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs4> value = (EventHandler<GEventArgs4>)Delegate.Combine(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_7(EventHandler<GEventArgs4> eventHandler_7)
	{
		EventHandler<GEventArgs4> eventHandler = eventHandler_2;
		EventHandler<GEventArgs4> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs4> value = (EventHandler<GEventArgs4>)Delegate.Remove(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_8(EventHandler<GEventArgs3> eventHandler_7)
	{
		EventHandler<GEventArgs3> eventHandler = eventHandler_3;
		EventHandler<GEventArgs3> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs3> value = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_9(EventHandler<GEventArgs3> eventHandler_7)
	{
		EventHandler<GEventArgs3> eventHandler = eventHandler_3;
		EventHandler<GEventArgs3> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs3> value = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_10(EventHandler<GEventArgs2> eventHandler_7)
	{
		EventHandler<GEventArgs2> eventHandler = eventHandler_4;
		EventHandler<GEventArgs2> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs2> value = (EventHandler<GEventArgs2>)Delegate.Combine(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_11(EventHandler<GEventArgs2> eventHandler_7)
	{
		EventHandler<GEventArgs2> eventHandler = eventHandler_4;
		EventHandler<GEventArgs2> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs2> value = (EventHandler<GEventArgs2>)Delegate.Remove(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_12(EventHandler<GEventArgs0> eventHandler_7)
	{
		EventHandler<GEventArgs0> eventHandler = eventHandler_5;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_13(EventHandler<GEventArgs0> eventHandler_7)
	{
		EventHandler<GEventArgs0> eventHandler = eventHandler_5;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_14(EventHandler<GEventArgs5> eventHandler_7)
	{
		EventHandler<GEventArgs5> eventHandler = eventHandler_6;
		EventHandler<GEventArgs5> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs5> value = (EventHandler<GEventArgs5>)Delegate.Combine(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_6, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_15(EventHandler<GEventArgs5> eventHandler_7)
	{
		EventHandler<GEventArgs5> eventHandler = eventHandler_6;
		EventHandler<GEventArgs5> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs5> value = (EventHandler<GEventArgs5>)Delegate.Remove(eventHandler2, eventHandler_7);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_6, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public GClass55 method_16()
	{
		return gclass55_0;
	}

	public bool method_17()
	{
		return bool_2;
	}

	public void method_18(bool bool_6)
	{
		bool_2 = bool_6;
	}

	public bool method_19()
	{
		return bool_3;
	}

	public void method_20(bool bool_6)
	{
		bool_3 = bool_6;
	}

	public bool method_21()
	{
		return bool_4;
	}

	public void method_22(bool bool_6)
	{
		bool_4 = bool_6;
	}

	public bool method_23()
	{
		return bool_0;
	}

	public void method_24(bool bool_6)
	{
		bool_0 = bool_6;
	}

	public bool method_25()
	{
		return bool_1;
	}

	public void method_26(bool bool_6)
	{
		bool_1 = bool_6;
	}

	public GStruct2 method_27()
	{
		return gstruct2_1;
	}

	public void method_28(GStruct2 gstruct2_2)
	{
		gstruct2_1 = gstruct2_2;
	}

	public GStruct2 method_29()
	{
		return gstruct2_0;
	}

	public void method_30(GStruct2 gstruct2_2)
	{
		gstruct2_0 = gstruct2_2;
	}

	public GStruct4 method_31()
	{
		return gstruct4_0;
	}

	public void method_32(GStruct4 gstruct4_3)
	{
		gstruct4_0 = gstruct4_3;
	}

	public GStruct4 method_33()
	{
		return gstruct4_1;
	}

	public void method_34(GStruct4 gstruct4_3)
	{
		gstruct4_1 = gstruct4_3;
	}

	public GStruct4 method_35()
	{
		return gstruct4_2;
	}

	public void method_36(GStruct4 gstruct4_3)
	{
		gstruct4_2 = gstruct4_3;
	}

	public int method_37()
	{
		return int_0;
	}

	public void method_38(int int_4)
	{
		if (int_4 > -1)
		{
			int_0 = int_4;
		}
	}

	public int method_39()
	{
		return int_1;
	}

	public void method_40(int int_4)
	{
		if (int_4 > -1)
		{
			int_1 = int_4;
		}
	}

	public int method_41()
	{
		return int_2;
	}

	public void method_42(int int_4)
	{
		if (int_4 > -1)
		{
			int_2 = int_4;
		}
	}

	public int method_43()
	{
		return int_3;
	}

	public void method_44(int int_4)
	{
		if (int_4 > -1)
		{
			int_3 = int_4;
		}
	}

	public void method_45(int int_4)
	{
		if (int_4 > -1)
		{
			int_1 = (int_2 = (int_0 = (int_3 = int_4)));
		}
	}

	public string method_46()
	{
		return class276_0.method_7();
	}

	public string method_47()
	{
		return class276_0.method_8();
	}

	internal Class197 method_48()
	{
		return class197_0;
	}

	internal GStruct3 method_49()
	{
		return gstruct3_0;
	}

	internal void method_50(GStruct3 gstruct3_2)
	{
		gstruct3_0 = gstruct3_2;
	}

	internal GStruct3 method_51()
	{
		return gstruct3_1;
	}

	internal void method_52(GStruct3 gstruct3_2)
	{
		gstruct3_1 = gstruct3_2;
	}

	public void method_53(string string_0, GClass55 gclass55_1)
	{
		method_54();
		if (!string.IsNullOrEmpty(string_0))
		{
			bool_5 = false;
			gclass55_0 = gclass55_1 ?? gclass0_0.method_0();
			Class220 @class = new Class220(class308_0);
			class197_0 = @class.method_0(string_0, this, ref gclass55_0);
			if (class197_0 != null)
			{
				class276_0 = new Class276(class197_0);
				class257_0 = new Class257();
			}
		}
	}

	public void method_54()
	{
		if (class197_0 != null)
		{
			class197_0.Dispose();
			class197_0 = null;
			if (class276_0 != null)
			{
				class276_0.Dispose();
			}
			class276_0 = null;
			if (class257_0 != null)
			{
				class257_0.Dispose();
			}
			class257_0 = null;
			list_0 = null;
		}
	}

	public void method_55()
	{
		if (class276_0 != null)
		{
			class276_0.method_13();
			method_71(bool_6: false);
		}
	}

	public string method_56(GEnum3 genum3_0)
	{
		return Class277.smethod_17(class197_0, genum3_0, bool_0: false);
	}

	public string method_57(GStruct2 gstruct2_2, string string_0)
	{
		GClass24.smethod_3(string_0, Class84.smethod_0(-994282998));
		Class197 @class = Class277.smethod_8(class197_0, method_76(gstruct2_2), bool_0: true);
		if (@class == null)
		{
			return null;
		}
		return Class277.smethod_7(@class, string_0);
	}

	public List<GClass34<GStruct1>> method_58()
	{
		List<Class197> list = new List<Class197>();
		Class277.smethod_9(class197_0, list);
		List<GClass34<GStruct1>> list2 = new List<GClass34<GStruct1>>();
		foreach (Class197 item in list)
		{
			list2.Add(new GClass34<GStruct1>(item.method_217(Class84.smethod_0(-994264162)), item.method_217(Class84.smethod_0(-994289937)), Class299.smethod_5(item.method_202(), item.method_134())));
		}
		return list2;
	}

	public string method_59(GStruct2 gstruct2_2)
	{
		return Class277.smethod_10(class197_0, method_76(gstruct2_2))?.vmethod_6();
	}

	public GStruct1? method_60(string string_0)
	{
		GClass24.smethod_3(string_0, Class84.smethod_0(-994282950));
		Class197 @class = Class277.smethod_11(class197_0, string_0.ToLower());
		if (@class == null)
		{
			return null;
		}
		return Class299.smethod_5(@class.method_202(), @class.method_134());
	}

	public void method_61(GClass14 gclass14_0)
	{
		GClass24.smethod_1(gclass14_0, Class84.smethod_0(-994288345));
		gstruct4_1 = GStruct4.gstruct4_0;
		if (class197_0 != null)
		{
			class197_0.method_133(new GStruct4((gstruct4_0.method_1() > 0.0) ? gstruct4_0.method_1() : 99999.0, 0.0));
			class197_0.method_131(gstruct2_0);
			class197_0.method_209(gclass14_0);
			if (gstruct4_0.method_1() <= 0.1)
			{
				class197_0.method_133(new GStruct4((int)Math.Ceiling(gstruct4_1.method_1()), 0.0));
				gstruct4_1 = GStruct4.gstruct4_0;
				class197_0.method_209(gclass14_0);
			}
			if (!bool_5)
			{
				bool_5 = true;
				eventHandler_0?.Invoke(this, EventArgs.Empty);
			}
		}
	}

	public void method_62(GClass14 gclass14_0)
	{
		GClass24.smethod_1(gclass14_0, Class84.smethod_0(-994288345));
		if (method_31().method_3() > 0.0)
		{
			gclass14_0.vmethod_1(new GStruct1(gstruct2_0.method_1(), gstruct2_0.method_3(), Math.Min(gstruct4_0.method_1(), method_35().method_1()), Math.Min(gstruct4_0.method_3(), method_35().method_3())));
		}
		else
		{
			gclass14_0.vmethod_1(new GStruct1(method_41(), method_37(), method_35().method_1(), method_35().method_3()));
		}
		if (class197_0 != null)
		{
			class197_0.method_210(gclass14_0);
		}
		gclass14_0.vmethod_0();
	}

	public void method_63(GClass38 gclass38_0, GStruct2 gstruct2_2)
	{
		GClass24.smethod_1(gclass38_0, Class84.smethod_0(-994289776));
		try
		{
			if (class276_0 != null)
			{
				class276_0.method_2(gclass38_0, method_76(gstruct2_2), method_77(gstruct2_2));
			}
		}
		catch (Exception exception_)
		{
			method_72(GEnum7.KeyboardMouse, Class84.smethod_0(-994282966), exception_);
		}
	}

	public void method_64(GClass38 gclass38_0, GStruct2 gstruct2_2, GClass8 gclass8_0)
	{
		GClass24.smethod_1(gclass38_0, Class84.smethod_0(-994289776));
		try
		{
			if (class276_0 != null && method_77(gstruct2_2) && !class276_0.method_3(gclass38_0, gclass8_0.method_0()) && gclass8_0.method_0())
			{
				GStruct2 gStruct = method_76(gstruct2_2);
				Class197 @class = Class277.smethod_10(class197_0, gStruct);
				if (@class != null)
				{
					method_73(gclass38_0, gstruct2_2, @class);
				}
			}
		}
		catch (GException0)
		{
			throw;
		}
		catch (Exception exception_)
		{
			method_72(GEnum7.KeyboardMouse, Class84.smethod_0(-994282935), exception_);
		}
	}

	public void method_65(GClass38 gclass38_0, GStruct2 gstruct2_2)
	{
		GClass24.smethod_1(gclass38_0, Class84.smethod_0(-994289776));
		try
		{
			if (class276_0 != null && method_77(gstruct2_2))
			{
				class276_0.method_1(gclass38_0, method_76(gstruct2_2));
			}
		}
		catch (Exception exception_)
		{
			method_72(GEnum7.KeyboardMouse, Class84.smethod_0(-994282890), exception_);
		}
	}

	public void method_66(GClass38 gclass38_0, GStruct2 gstruct2_2)
	{
		GClass24.smethod_1(gclass38_0, Class84.smethod_0(-994289776));
		try
		{
			GStruct2 gStruct = method_76(gstruct2_2);
			if (class276_0 != null && method_77(gstruct2_2))
			{
				class276_0.method_4(gclass38_0, gStruct);
			}
		}
		catch (Exception exception_)
		{
			method_72(GEnum7.KeyboardMouse, Class84.smethod_0(-994282867), exception_);
		}
	}

	public void method_67(GClass38 gclass38_0)
	{
		GClass24.smethod_1(gclass38_0, Class84.smethod_0(-994289776));
		try
		{
			if (class276_0 != null)
			{
				class276_0.method_5(gclass38_0);
			}
		}
		catch (Exception exception_)
		{
			method_72(GEnum7.KeyboardMouse, Class84.smethod_0(-994282836), exception_);
		}
	}

	public void method_68(GClass38 gclass38_0, GClass13 gclass13_0)
	{
		GClass24.smethod_1(gclass38_0, Class84.smethod_0(-994289776));
		GClass24.smethod_1(gclass13_0, Class84.smethod_0(-994282804));
		try
		{
			if (gclass13_0.method_0() && class276_0 != null)
			{
				if (gclass13_0.method_1())
				{
					class276_0.method_0(gclass38_0);
				}
				if (gclass13_0.method_2())
				{
					class276_0.method_6();
				}
			}
		}
		catch (Exception exception_)
		{
			method_72(GEnum7.KeyboardMouse, Class84.smethod_0(-994282812), exception_);
		}
	}

	internal void method_69(GEventArgs0 geventArgs0_0)
	{
		try
		{
			eventHandler_5?.Invoke(this, geventArgs0_0);
		}
		catch (Exception exception_)
		{
			method_72(GEnum7.CssParsing, Class84.smethod_0(-994282783), exception_);
		}
	}

	internal void method_70(GEventArgs5 geventArgs5_0)
	{
		try
		{
			eventHandler_6?.Invoke(this, geventArgs5_0);
		}
		catch (Exception exception_)
		{
			method_72(GEnum7.Image, Class84.smethod_0(-994282748), exception_);
		}
	}

	public void method_71(bool bool_6)
	{
		try
		{
			eventHandler_2?.Invoke(this, new GEventArgs4(bool_6));
		}
		catch (Exception exception_)
		{
			method_72(GEnum7.General, Class84.smethod_0(-994282718), exception_);
		}
	}

	internal void method_72(GEnum7 genum7_0, string string_0, Exception exception_0)
	{
		try
		{
			eventHandler_4?.Invoke(this, new GEventArgs2(genum7_0, string_0, exception_0));
		}
		catch
		{
		}
	}

	internal void method_73(GClass38 gclass38_0, GStruct2 gstruct2_2, Class197 class197_1)
	{
		EventHandler<GEventArgs1> eventHandler = eventHandler_1;
		if (eventHandler != null)
		{
			GEventArgs1 gEventArgs = new GEventArgs1(class197_1.vmethod_6(), class197_1.method_195().method_1());
			try
			{
				eventHandler(this, gEventArgs);
			}
			catch (Exception exception_)
			{
				throw new GException0(Class84.smethod_0(-994282673), exception_);
			}
			if (gEventArgs.method_2())
			{
				return;
			}
		}
		if (string.IsNullOrEmpty(class197_1.vmethod_6()))
		{
			return;
		}
		if (class197_1.vmethod_6().StartsWith(Class84.smethod_0(-994282651)) && class197_1.vmethod_6().Length > 1)
		{
			EventHandler<GEventArgs3> eventHandler2 = eventHandler_3;
			if (eventHandler2 != null)
			{
				GStruct1? gStruct = method_60(class197_1.vmethod_6().Substring(1));
				if (gStruct.HasValue)
				{
					eventHandler2(this, new GEventArgs3(gStruct.Value.method_0()));
					method_66(gclass38_0, gstruct2_2);
				}
			}
		}
		else
		{
			Process.Start(new ProcessStartInfo(class197_1.vmethod_6())
			{
				UseShellExecute = true
			});
		}
	}

	internal void method_74(Class197 class197_1, CssBlock cssBlock_0)
	{
		GClass24.smethod_1(class197_1, Class84.smethod_0(-994282595));
		GClass24.smethod_1(cssBlock_0, Class84.smethod_0(-994289969));
		if (list_0 == null)
		{
			list_0 = new List<Class338>();
		}
		list_0.Add(new Class338(class197_1, cssBlock_0));
	}

	internal Class257 method_75()
	{
		return class257_0;
	}

	public void Dispose()
	{
		method_78(bool_6: true);
	}

	private GStruct2 method_76(GStruct2 gstruct2_2)
	{
		return new GStruct2(gstruct2_2.method_1() - method_27().method_1(), gstruct2_2.method_3() - method_27().method_3());
	}

	private bool method_77(GStruct2 gstruct2_2)
	{
		if (gstruct2_2.method_1() >= gstruct2_0.method_1() && gstruct2_2.method_1() <= gstruct2_0.method_1() + gstruct4_1.method_1() && gstruct2_2.method_3() >= gstruct2_0.method_3() + method_27().method_3())
		{
			return gstruct2_2.method_3() <= gstruct2_0.method_3() + method_27().method_3() + gstruct4_1.method_3();
		}
		return false;
	}

	private void method_78(bool bool_6)
	{
		try
		{
			if (bool_6)
			{
				eventHandler_1 = null;
				eventHandler_2 = null;
				eventHandler_4 = null;
				eventHandler_5 = null;
				eventHandler_6 = null;
			}
			gclass55_0 = null;
			if (class197_0 != null)
			{
				class197_0.Dispose();
			}
			class197_0 = null;
			if (class276_0 != null)
			{
				class276_0.Dispose();
			}
			class276_0 = null;
		}
		catch
		{
		}
	}
}
