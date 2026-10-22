using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

internal sealed class Class98 : Interface6, IDisposable
{
	private SecureString secureString_0 = new SecureString();

	[SpecialName]
	public int imethod_0()
	{
		return secureString_0.Length;
	}

	public Interface6 imethod_4()
	{
		return new Class98();
	}

	public void imethod_1(int int_0, out byte byte_0)
	{
		if (int_0 >= 0 && int_0 < imethod_0())
		{
			IntPtr intPtr = IntPtr.Zero;
			char char_ = '\0';
			try
			{
				intPtr = Marshal.SecureStringToGlobalAllocUnicode(secureString_0);
				char_ = (char)Marshal.ReadInt16(intPtr, int_0 * 2);
				byte_0 = smethod_1(char_, int_0);
				return;
			}
			finally
			{
				Class66.smethod_3(ref char_);
				if (intPtr != IntPtr.Zero)
				{
					Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
				}
			}
		}
		throw new ArgumentOutOfRangeException();
	}

	public void imethod_2(int int_0, ref byte byte_0)
	{
		int num = secureString_0.Length;
		while (true)
		{
			if (num <= int_0)
			{
				if (num == int_0)
				{
					break;
				}
				secureString_0.AppendChar(smethod_0(0, num));
				num++;
				continue;
			}
			secureString_0.SetAt(int_0, smethod_0(byte_0, int_0));
			return;
		}
		secureString_0.AppendChar(smethod_0(byte_0, num));
	}

	private static char smethod_0(byte byte_0, int int_0)
	{
		return (char)(byte_0 + 1);
	}

	private static byte smethod_1(char char_0, int int_0)
	{
		return (byte)(char_0 - 1);
	}

	public void imethod_3()
	{
		secureString_0.Clear();
	}

	public void Dispose()
	{
		secureString_0.Dispose();
		secureString_0 = null;
	}
}
