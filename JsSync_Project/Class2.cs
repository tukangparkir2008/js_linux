using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal sealed class Class2 : Interface4, IDisposable
{
	private static bool bool_0 = true;

	protected Class61.Class62 class62_0;

	protected Class61.Class63 class63_0;

	protected int int_0;

	private int int_1;

	private int int_2;

	private byte[] byte_0;

	private byte[] byte_1;

	private bool bool_1;

	protected Class2(bool bool_2, Class45 class45_0)
	{
		if (class45_0 == null)
		{
			throw new ArgumentNullException(Class84.smethod_0(-994273148));
		}
		int int_ = class45_0.method_1().method_1();
		int_0 = smethod_3(int_);
		method_0(smethod_1(int_, bool_2));
		method_1(smethod_2(int_, bool_2));
		Class61.smethod_0(Class61.NCryptOpenStorageProvider(out class62_0, Class84.smethod_0(-994274856), 0u));
		byte[] array = vmethod_0(class45_0, out var string_);
		Class61.smethod_0(Class61.NCryptImportKey(class62_0, IntPtr.Zero, string_, IntPtr.Zero, out class63_0, array, array.Length, 64u));
	}

	public static Class2 smethod_0(bool bool_2, Class45 class45_0)
	{
		if (!bool_0)
		{
			return null;
		}
		if (!Class0.smethod_1())
		{
			bool_0 = false;
			return null;
		}
		Class2 @class = null;
		try
		{
			@class = new Class2(bool_2, class45_0);
			return @class;
		}
		catch
		{
			@class?.Dispose();
			bool_0 = false;
			return null;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public int imethod_0()
	{
		return int_1;
	}

	private void method_0(int int_3)
	{
		int_1 = int_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public int imethod_1()
	{
		return int_2;
	}

	private void method_1(int int_3)
	{
		int_2 = int_3;
	}

	private static int smethod_1(int int_3, bool bool_2)
	{
		if (!bool_2)
		{
			return (int_3 + 7) / 8;
		}
		return (int_3 - 1) / 8;
	}

	private static int smethod_2(int int_3, bool bool_2)
	{
		if (!bool_2)
		{
			return (int_3 - 1) / 8;
		}
		return (int_3 + 7) / 8;
	}

	private static int smethod_3(int int_3)
	{
		return (int_3 + 7) / 8;
	}

	private void method_2()
	{
		if (!bool_1)
		{
			byte_0 = new byte[int_0];
			byte_1 = new byte[int_0];
			bool_1 = true;
		}
	}

	public virtual int imethod_2(byte[] byte_2, int int_3, int int_4, byte[] byte_3, int int_5)
	{
		method_2();
		byte[] array = byte_0;
		int num = array.Length - int_4;
		if (num > 0)
		{
			Array.Clear(array, 0, num);
		}
		Buffer.BlockCopy(byte_2, int_3, array, num, int_4);
		Class61.smethod_0(Class61.NCryptEncrypt(class63_0, array, array.Length, IntPtr.Zero, byte_1, int_0, out var num2, 1));
		int num3 = imethod_1();
		int srcOffset = num2 - num3;
		Buffer.BlockCopy(byte_1, srcOffset, byte_3, int_5, num3);
		return num3;
	}

	protected virtual byte[] vmethod_0(Class45 class45_0, out string string_0)
	{
		string_0 = Class84.smethod_0(-994274826);
		return smethod_4(class45_0);
	}

	protected static byte[] smethod_4(Class45 class45_0)
	{
		int num = Marshal.SizeOf(typeof(Class61.Struct3));
		byte[] array = new byte[num + class45_0.method_2().method_10() + class45_0.method_1().method_10()];
		smethod_5(new Class61.Struct3
		{
			uint_0 = 826364754u,
			int_0 = class45_0.method_1().method_1(),
			int_1 = class45_0.method_2().method_10(),
			int_2 = class45_0.method_1().method_10()
		}, array, 0);
		int num2 = num;
		num2 += class45_0.method_2().method_11(array, num2);
		num2 += class45_0.method_1().method_11(array, num2);
		return array;
	}

	protected static void smethod_5(Class61.Struct3 struct3_0, byte[] byte_2, int int_3)
	{
		int num = Marshal.SizeOf((object)struct3_0);
		if (int_3 + num > byte_2.Length)
		{
			throw new ArgumentException(Class84.smethod_0(-994274790));
		}
		try
		{
		}
		finally
		{
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr((object)struct3_0, intPtr, false);
			Marshal.Copy(intPtr, byte_2, int_3, num);
			Marshal.DestroyStructure(intPtr, typeof(Class61.Struct3));
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public void Dispose()
	{
		if (class62_0 != null)
		{
			class62_0.Dispose();
			class62_0 = null;
		}
		if (class63_0 != null)
		{
			class63_0.Dispose();
			class63_0 = null;
		}
	}
}
