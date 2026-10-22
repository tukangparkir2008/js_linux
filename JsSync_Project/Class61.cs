using System;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

internal static class Class61
{
	[SecurityCritical]
	public sealed class Class62 : SafeHandleZeroOrMinusOneIsInvalid
	{
		public override bool IsInvalid => handle == IntPtr.Zero;

		public Class62()
			: base(ownsHandle: true)
		{
		}

		protected override bool ReleaseHandle()
		{
			return NCryptFreeObject(handle) == 0;
		}
	}

	public struct Struct3
	{
		public uint uint_0;

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;
	}

	[SecurityCritical]
	public sealed class Class63 : SafeHandleZeroOrMinusOneIsInvalid
	{
		public override bool IsInvalid => handle == IntPtr.Zero;

		public Class63()
			: base(ownsHandle: true)
		{
		}

		protected override bool ReleaseHandle()
		{
			return NCryptFreeObject(handle) == 0;
		}
	}

	public static void smethod_0(uint uint_0)
	{
		if (uint_0 != 0)
		{
			uint num = uint_0;
			throw new InvalidOperationException(num.ToString());
		}
	}

	[DllImport("ncrypt.dll")]
	public static extern uint NCryptFreeObject(IntPtr intptr_0);

	[DllImport("ncrypt.dll")]
	public static extern uint NCryptEncrypt(Class63 class63_0, [MarshalAs(UnmanagedType.LPArray)] byte[] byte_0, int int_0, IntPtr intptr_0, [MarshalAs(UnmanagedType.LPArray)] byte[] byte_1, int int_1, out int int_2, int int_3);

	[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
	public static extern uint NCryptImportKey(Class62 class62_0, IntPtr intptr_0, string string_0, IntPtr intptr_1, out Class63 class63_0, [MarshalAs(UnmanagedType.LPArray)] byte[] byte_0, int int_0, uint uint_0);

	[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
	public static extern uint NCryptOpenStorageProvider(out Class62 class62_0, string string_0, uint uint_0);
}
