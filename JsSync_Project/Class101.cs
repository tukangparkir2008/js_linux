using System;
using System.Runtime.CompilerServices;

internal sealed class Class101 : Interface4, IDisposable
{
	private sealed class Class102
	{
		public bool bool_0;

		public Interface4 interface4_0;
	}

	private readonly Class45 class45_0;

	private readonly bool bool_0;

	private readonly bool bool_1;

	private readonly int int_0;

	private readonly int int_1;

	private Class102 class102_0;

	private bool bool_2;

	private readonly object object_0 = new object();

	public Class101(bool bool_3, Class45 class45_1, bool bool_4 = false)
	{
		bool_0 = bool_3;
		class45_0 = class45_1;
		bool_1 = bool_4;
		bool_1 = true;
		int int_ = class45_1.method_1().method_1();
		int_0 = smethod_0(int_, bool_3);
		int_1 = smethod_1(int_, bool_3);
	}

	public bool method_0()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int imethod_0()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int imethod_1()
	{
		return int_1;
	}

	private static int smethod_0(int int_2, bool bool_3)
	{
		if (!bool_3)
		{
			return (int_2 + 7) / 8;
		}
		return (int_2 - 1) / 8;
	}

	private static int smethod_1(int int_2, bool bool_3)
	{
		if (!bool_3)
		{
			return (int_2 - 1) / 8;
		}
		return (int_2 + 7) / 8;
	}

	public int imethod_2(byte[] byte_0, int int_2, int int_3, byte[] byte_1, int int_4)
	{
		method_2();
		Class102 @class = class102_0;
		try
		{
			return @class.interface4_0.imethod_2(byte_0, int_2, int_3, byte_1, int_4);
		}
		catch when (@class.bool_0)
		{
			method_1();
			@class = class102_0;
			return @class.interface4_0.imethod_2(byte_0, int_2, int_3, byte_1, int_4);
		}
	}

	private void method_1()
	{
		lock (object_0)
		{
			Class102 @class = class102_0;
			if (!@class.bool_0)
			{
				return;
			}
			try
			{
				if (@class.interface4_0 is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
			catch
			{
			}
			Interface4 @interface = vmethod_0(bool_0, class45_0);
			if (@interface == null)
			{
				throw new InvalidOperationException();
			}
			class102_0 = new Class102
			{
				bool_0 = false,
				interface4_0 = @interface
			};
		}
	}

	private void method_2()
	{
		if (bool_2)
		{
			return;
		}
		lock (object_0)
		{
			if (bool_2)
			{
				return;
			}
			Interface4 interface4_;
			if (!bool_1 && (interface4_ = vmethod_1(bool_0, class45_0)) != null)
			{
				class102_0 = new Class102
				{
					bool_0 = true,
					interface4_0 = interface4_
				};
			}
			else
			{
				interface4_ = vmethod_0(bool_0, class45_0);
				if (interface4_ == null)
				{
					throw new InvalidOperationException();
				}
				class102_0 = new Class102
				{
					bool_0 = false,
					interface4_0 = interface4_
				};
			}
			bool_2 = true;
		}
	}

	protected virtual Interface4 vmethod_0(bool bool_3, Class45 class45_1)
	{
		return new Class103(bool_3, class45_1);
	}

	protected virtual Interface4 vmethod_1(bool bool_3, Class45 class45_1)
	{
		return Class2.smethod_0(bool_3, class45_1);
	}

	public void Dispose()
	{
		if (class102_0?.interface4_0 is IDisposable disposable)
		{
			disposable.Dispose();
			class102_0 = null;
		}
	}
}
