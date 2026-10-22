using System;
using System.IO;
using System.Runtime.CompilerServices;

internal sealed class Class68 : Class67, IDisposable
{
	private byte[] byte_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	public Class68()
		: this(0)
	{
	}

	public Class68(int int_4)
	{
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		byte_0 = new byte[int_4];
		int_3 = int_4;
		bool_0 = true;
		bool_1 = true;
		int_0 = 0;
		bool_2 = true;
	}

	public Class68(byte[] byte_1)
		: this(byte_1, bool_4: true)
	{
	}

	public Class68(byte[] byte_1, bool bool_4)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		byte_0 = byte_1;
		int_2 = (int_3 = byte_1.Length);
		bool_1 = bool_4;
		int_0 = 0;
		bool_2 = true;
	}

	public Class68(byte[] byte_1, int int_4, int int_5)
		: this(byte_1, int_4, int_5, bool_4: true)
	{
	}

	public Class68(byte[] byte_1, int int_4, int int_5, bool bool_4)
	{
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_5 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (byte_1.Length - int_4 < int_5)
		{
			throw new ArgumentException();
		}
		byte_0 = byte_1;
		int_0 = (int_1 = int_4);
		int_2 = (int_3 = int_4 + int_5);
		bool_1 = bool_4;
		bool_0 = false;
		bool_2 = true;
	}

	[SpecialName]
	public override bool vmethod_0()
	{
		return bool_2;
	}

	[SpecialName]
	public override bool vmethod_2()
	{
		return bool_2;
	}

	[SpecialName]
	public override bool vmethod_1()
	{
		return bool_1;
	}

	protected override void vmethod_7(bool bool_4)
	{
		if (!bool_3)
		{
			if (bool_4)
			{
				bool_2 = false;
				bool_1 = false;
				bool_0 = false;
			}
			bool_3 = true;
		}
	}

	private bool method_0(int int_4)
	{
		if (int_4 < 0)
		{
			throw new IOException();
		}
		if (int_4 > int_3)
		{
			int num = int_4;
			if (num < 256)
			{
				num = 256;
			}
			if (num < int_3 * 2)
			{
				num = int_3 * 2;
			}
			method_6(num);
			return true;
		}
		return false;
	}

	public override void vmethod_8()
	{
	}

	internal byte[] method_1()
	{
		return byte_0;
	}

	internal void method_2(out int int_4, out int int_5)
	{
		if (!bool_2)
		{
			throw new Exception();
		}
		int_4 = int_0;
		int_5 = int_2;
	}

	internal int method_3()
	{
		if (!bool_2)
		{
			throw new Exception();
		}
		return int_1;
	}

	public int method_4(int int_4)
	{
		if (!bool_2)
		{
			throw new Exception();
		}
		int num = int_2 - int_1;
		if (num > int_4)
		{
			num = int_4;
		}
		if (num < 0)
		{
			num = 0;
		}
		int_1 += num;
		return num;
	}

	public int method_5()
	{
		if (!bool_2)
		{
			throw new Exception();
		}
		return int_3 - int_0;
	}

	public void method_6(int int_4)
	{
		if (!bool_2)
		{
			throw new Exception();
		}
		if (int_4 == int_3)
		{
			return;
		}
		if (!bool_0)
		{
			throw new Exception();
		}
		if (int_4 < int_2)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_4 > 0)
		{
			byte[] dst = new byte[int_4];
			if (int_2 > 0)
			{
				Buffer.BlockCopy(byte_0, 0, dst, 0, int_2);
			}
			byte_0 = dst;
		}
		else
		{
			byte_0 = null;
		}
		int_3 = int_4;
	}

	[SpecialName]
	public override long vmethod_3()
	{
		if (!bool_2)
		{
			throw new Exception();
		}
		return int_2 - int_0;
	}

	[SpecialName]
	public override long vmethod_4()
	{
		if (!bool_2)
		{
			throw new Exception();
		}
		return int_1 - int_0;
	}

	[SpecialName]
	public override void vmethod_5(long long_0)
	{
		if (!bool_2)
		{
			throw new Exception();
		}
		if (long_0 < 0L)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (long_0 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException();
		}
		int_1 = int_0 + (int)long_0;
	}

	public override int vmethod_11(byte[] byte_1, int int_4, int int_5)
	{
		if (!bool_2)
		{
			throw new Exception();
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_5 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (byte_1.Length - int_4 < int_5)
		{
			throw new ArgumentException();
		}
		int num = int_2 - int_1;
		if (num > int_5)
		{
			num = int_5;
		}
		if (num <= 0)
		{
			return 0;
		}
		if (num <= 8)
		{
			int num2 = num;
			while (--num2 >= 0)
			{
				byte_1[int_4 + num2] = byte_0[int_1 + num2];
			}
		}
		else
		{
			Buffer.BlockCopy(byte_0, int_1, byte_1, int_4, num);
		}
		int_1 += num;
		return num;
	}

	public override int vmethod_12()
	{
		if (!bool_2)
		{
			throw new Exception();
		}
		if (int_1 >= int_2)
		{
			return -1;
		}
		return byte_0[int_1++];
	}

	public override long vmethod_9(long long_0, int int_4)
	{
		if (!bool_2)
		{
			throw new Exception();
		}
		if (long_0 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException();
		}
		switch (int_4)
		{
		default:
			throw new ArgumentException();
		case 0:
			if (long_0 < 0L)
			{
				throw new IOException();
			}
			int_1 = int_0 + (int)long_0;
			break;
		case 1:
			if (long_0 + int_1 < int_0)
			{
				throw new IOException();
			}
			int_1 += (int)long_0;
			break;
		case 2:
			if (int_2 + long_0 < int_0)
			{
				throw new IOException();
			}
			int_1 = int_2 + (int)long_0;
			break;
		}
		return int_1;
	}

	public override void vmethod_10(long long_0)
	{
		if (!bool_1)
		{
			throw new Exception();
		}
		if (long_0 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (long_0 >= 0L && long_0 <= int.MaxValue - int_0)
		{
			int num = int_0 + (int)long_0;
			if (!method_0(num) && num > int_2)
			{
				Array.Clear(byte_0, int_2, num - int_2);
			}
			int_2 = num;
			if (int_1 > num)
			{
				int_1 = num;
			}
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	public byte[] method_7()
	{
		byte[] array = new byte[int_2 - int_0];
		Buffer.BlockCopy(byte_0, int_0, array, 0, int_2 - int_0);
		return array;
	}

	public override void vmethod_13(byte[] byte_1, int int_4, int int_5)
	{
		if (!bool_2)
		{
			throw new Exception();
		}
		if (!bool_1)
		{
			throw new Exception();
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_5 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (byte_1.Length - int_4 < int_5)
		{
			throw new ArgumentException();
		}
		int num = int_1 + int_5;
		if (num < 0)
		{
			throw new IOException();
		}
		if (num > int_2)
		{
			bool flag = int_1 > int_2;
			if (num > int_3 && method_0(num))
			{
				flag = false;
			}
			if (flag)
			{
				Array.Clear(byte_0, int_2, num - int_2);
			}
			int_2 = num;
		}
		if (int_5 <= 8)
		{
			int num2 = int_5;
			while (--num2 >= 0)
			{
				byte_0[int_1 + num2] = byte_1[int_4 + num2];
			}
		}
		else
		{
			Buffer.BlockCopy(byte_1, int_4, byte_0, int_1, int_5);
		}
		int_1 = num;
	}

	public override void vmethod_14(byte byte_1)
	{
		if (!bool_2)
		{
			throw new Exception();
		}
		if (!bool_1)
		{
			throw new Exception();
		}
		if (int_1 >= int_2)
		{
			int num = int_1 + 1;
			bool flag = int_1 > int_2;
			if (num >= int_3 && method_0(num))
			{
				flag = false;
			}
			if (flag)
			{
				Array.Clear(byte_0, int_2, int_1 - int_2);
			}
			int_2 = num;
		}
		byte_0[int_1++] = byte_1;
	}

	public void method_8(Stream stream_0)
	{
		if (!bool_2)
		{
			throw new Exception();
		}
		if (stream_0 == null)
		{
			throw new ArgumentNullException();
		}
		stream_0.Write(byte_0, int_0, int_2 - int_0);
	}

	internal int method_9()
	{
		if (!bool_2)
		{
			throw new Exception();
		}
		int num = (int_1 += 4);
		if (num > int_2)
		{
			int_1 = int_2;
			throw new Exception();
		}
		return (byte_0[num - 2] << 16) | (byte_0[num - 4] << 24) | byte_0[num - 1] | (byte_0[num - 3] << 8);
	}
}
