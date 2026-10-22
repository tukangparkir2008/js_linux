using System;
using System.IO;
using System.Text;

internal sealed class Class48 : IDisposable
{
	private Class67 class67_0;

	private byte[] byte_0;

	private Decoder decoder_0;

	private byte[] byte_1;

	private char[] char_0;

	private char[] char_1;

	private int int_0;

	private bool bool_0;

	private bool bool_1;

	private byte[] byte_2;

	private MemoryStream memoryStream_0;

	private BinaryReader binaryReader_0;

	public Class48(Class67 class67_1)
		: this(class67_1, new UTF8Encoding())
	{
	}

	private Class48(Class67 class67_1, Encoding encoding_0)
	{
		if (class67_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (encoding_0 == null)
		{
			throw new ArgumentNullException();
		}
		if (!class67_1.vmethod_0())
		{
			throw new ArgumentException();
		}
		class67_0 = class67_1;
		decoder_0 = encoding_0.GetDecoder();
		int_0 = encoding_0.GetMaxCharCount(128);
		int num = encoding_0.GetMaxByteCount(1);
		if (num < 16)
		{
			num = 16;
		}
		byte_0 = new byte[num];
		char_1 = null;
		byte_1 = null;
		bool_0 = encoding_0 is UnicodeEncoding;
		bool_1 = class67_0 is Class68;
	}

	public Class67 method_0()
	{
		return class67_0;
	}

	public void method_1()
	{
		method_2(bool_2: true);
	}

	private void method_2(bool bool_2)
	{
		if (bool_2)
		{
			Class67 @class = class67_0;
			class67_0 = null;
			@class?.vmethod_6();
		}
		class67_0 = null;
		byte_0 = null;
		decoder_0 = null;
		byte_1 = null;
		char_0 = null;
		char_1 = null;
	}

	void IDisposable.Dispose()
	{
		method_2(bool_2: true);
	}

	public int method_3()
	{
		method_15();
		if (!class67_0.vmethod_2())
		{
			return -1;
		}
		long long_ = class67_0.vmethod_4();
		int result = method_4();
		class67_0.vmethod_5(long_);
		return result;
	}

	public int method_4()
	{
		method_15();
		return method_12();
	}

	public bool method_5()
	{
		method_17(1);
		return byte_0[0] != 0;
	}

	public byte method_6()
	{
		method_15();
		int num = class67_0.vmethod_12();
		if (num == -1)
		{
			throw new Exception();
		}
		return (byte)num;
	}

	public sbyte method_7()
	{
		method_17(1);
		return (sbyte)byte_0[0];
	}

	public char method_8()
	{
		int num = method_4();
		if (num == -1)
		{
			throw new Exception();
		}
		return (char)num;
	}

	private static decimal smethod_0(int int_1, int int_2, int int_3, int int_4)
	{
		bool isNegative = (int_4 & int.MinValue) != 0;
		byte scale = (byte)(int_4 >> 16);
		return new decimal(int_1, int_2, int_3, isNegative, scale);
	}

	internal static decimal smethod_1(byte[] byte_3)
	{
		int int_ = byte_3[0] | (byte_3[1] << 8) | (byte_3[2] << 16) | (byte_3[3] << 24);
		int int_2 = byte_3[4] | (byte_3[5] << 8) | (byte_3[6] << 16) | (byte_3[7] << 24);
		int int_3 = byte_3[8] | (byte_3[9] << 8) | (byte_3[10] << 16) | (byte_3[11] << 24);
		int int_4 = byte_3[12] | (byte_3[13] << 8) | (byte_3[14] << 16) | (byte_3[15] << 24);
		return smethod_0(int_, int_2, int_3, int_4);
	}

	public string method_9()
	{
		int num = 0;
		method_15();
		int num2 = method_18();
		if (num2 < 0)
		{
			throw new IOException();
		}
		if (num2 == 0)
		{
			return string.Empty;
		}
		if (byte_1 == null)
		{
			byte_1 = new byte[128];
		}
		if (char_1 == null)
		{
			char_1 = new char[int_0];
		}
		StringBuilder stringBuilder = null;
		do
		{
			int int_ = ((num2 - num <= 128) ? (num2 - num) : 128);
			int num3 = class67_0.vmethod_11(byte_1, 0, int_);
			if (num3 != 0)
			{
				int chars = decoder_0.GetChars(byte_1, 0, num3, char_1, 0);
				if (num != 0 || num3 != num2)
				{
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder(num2);
					}
					stringBuilder.Append(char_1, 0, chars);
					num += num3;
					continue;
				}
				return new string(char_1, 0, chars);
			}
			throw new Exception();
		}
		while (num < num2);
		return stringBuilder.ToString();
	}

	public int method_10(char[] char_2, int int_1, int int_2)
	{
		if (char_2 == null)
		{
			throw new ArgumentNullException(Class84.smethod_0(-994273169), Class84.smethod_0(-994273126));
		}
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_2 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (char_2.Length - int_1 < int_2)
		{
			throw new ArgumentException();
		}
		method_15();
		return method_11(char_2, int_1, int_2);
	}

	private int method_11(char[] char_2, int int_1, int int_2)
	{
		int num = 0;
		int num2 = 0;
		int num3 = int_2;
		if (byte_1 == null)
		{
			byte_1 = new byte[128];
		}
		while (true)
		{
			if (num3 > 0)
			{
				num2 = num3;
				if (bool_0)
				{
					num2 <<= 1;
				}
				if (num2 > 128)
				{
					num2 = 128;
				}
				if (bool_1)
				{
					Class68 @class = (Class68)class67_0;
					int byteIndex = @class.method_3();
					num2 = @class.method_4(num2);
					if (num2 == 0)
					{
						return int_2 - num3;
					}
					num = decoder_0.GetChars(@class.method_1(), byteIndex, num2, char_2, int_1);
				}
				else
				{
					num2 = class67_0.vmethod_11(byte_1, 0, num2);
					if (num2 == 0)
					{
						break;
					}
					num = decoder_0.GetChars(byte_1, 0, num2, char_2, int_1);
				}
				num3 -= num;
				int_1 += num;
				continue;
			}
			return int_2;
		}
		return int_2 - num3;
	}

	private int method_12()
	{
		int num = 0;
		int num2 = 0;
		long num3 = 0L;
		num3 = 0L;
		if (class67_0.vmethod_2())
		{
			num3 = class67_0.vmethod_4();
		}
		if (byte_1 == null)
		{
			byte_1 = new byte[128];
		}
		if (char_0 == null)
		{
			char_0 = new char[1];
		}
		while (true)
		{
			if (num == 0)
			{
				num2 = ((!bool_0) ? 1 : 2);
				int num4 = class67_0.vmethod_12();
				byte_1[0] = (byte)num4;
				if (num4 == -1)
				{
					num2 = 0;
				}
				if (num2 == 2)
				{
					num4 = class67_0.vmethod_12();
					byte_1[1] = (byte)num4;
					if (num4 == -1)
					{
						num2 = 1;
					}
				}
				if (num2 == 0)
				{
					break;
				}
				try
				{
					num = decoder_0.GetChars(byte_1, 0, num2, char_0, 0);
				}
				catch
				{
					if (class67_0.vmethod_2())
					{
						class67_0.vmethod_9(num3 - class67_0.vmethod_4(), 1);
					}
					throw;
				}
				continue;
			}
			if (num == 0)
			{
				return -1;
			}
			return char_0[0];
		}
		return -1;
	}

	public char[] method_13(int int_1)
	{
		method_15();
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		char[] array = new char[int_1];
		int num = method_11(array, 0, int_1);
		if (num != int_1)
		{
			char[] array2 = new char[num];
			Buffer.BlockCopy(array, 0, array2, 0, 2 * num);
			array = array2;
		}
		return array;
	}

	public int method_14(byte[] byte_3, int int_1, int int_2)
	{
		if (byte_3 == null)
		{
			throw new ArgumentNullException();
		}
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (int_2 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (byte_3.Length - int_1 < int_2)
		{
			throw new ArgumentException();
		}
		method_15();
		return class67_0.vmethod_11(byte_3, int_1, int_2);
	}

	private void method_15()
	{
		if (class67_0 == null)
		{
			throw new Exception();
		}
	}

	public byte[] method_16(int int_1)
	{
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		method_15();
		byte[] array = new byte[int_1];
		int num = 0;
		do
		{
			int num2 = class67_0.vmethod_11(array, num, int_1);
			if (num2 == 0)
			{
				break;
			}
			num += num2;
			int_1 -= num2;
		}
		while (int_1 > 0);
		if (num != array.Length)
		{
			byte[] array2 = new byte[num];
			Buffer.BlockCopy(array, 0, array2, 0, num);
			array = array2;
		}
		return array;
	}

	private void method_17(int int_1)
	{
		method_15();
		int num = 0;
		int num2 = 0;
		if (int_1 == 1)
		{
			num2 = class67_0.vmethod_12();
			if (num2 == -1)
			{
				throw new Exception();
			}
			byte_0[0] = (byte)num2;
			return;
		}
		do
		{
			num2 = class67_0.vmethod_11(byte_0, num, int_1 - num);
			if (num2 != 0)
			{
				num += num2;
				continue;
			}
			throw new Exception();
		}
		while (num < int_1);
	}

	internal int method_18()
	{
		int num = 0;
		int num2 = 0;
		byte b;
		do
		{
			if (num2 != 35)
			{
				b = method_6();
				num |= (b & 0x7F) << num2;
				num2 += 7;
				continue;
			}
			throw new FormatException();
		}
		while ((b & 0x80) != 0);
		return num;
	}

	public int method_19()
	{
		if (bool_1)
		{
			return ((Class68)class67_0).method_9();
		}
		method_17(4);
		return (byte_0[2] << 16) | (byte_0[0] << 24) | byte_0[3] | (byte_0[1] << 8);
	}

	public uint method_20()
	{
		method_17(4);
		return (uint)((byte_0[0] << 24) | (byte_0[3] << 8) | (byte_0[1] << 16) | byte_0[2]);
	}

	public long method_21()
	{
		method_17(8);
		byte[] array = byte_0;
		return (uint)((array[6] << 24) | (array[1] << 16) | array[2] | (array[7] << 8)) | ((long)((array[4] << 16) | (array[3] << 24) | array[0] | (array[5] << 8)) << 32);
	}

	public ulong method_22()
	{
		method_17(8);
		byte[] array = byte_0;
		return (ulong)((uint)((array[5] << 8) | (array[6] << 24) | array[0] | (array[1] << 16)) | ((long)((array[7] << 24) | array[4] | (array[2] << 8) | (array[3] << 16)) << 32));
	}

	public short method_23()
	{
		method_17(2);
		byte[] array = byte_0;
		return (short)(array[1] | (array[0] << 8));
	}

	public ushort method_24()
	{
		method_17(2);
		byte[] array = byte_0;
		return (ushort)((array[1] << 8) | array[0]);
	}

	private byte[] method_25()
	{
		byte[] array = byte_2;
		if (array == null)
		{
			array = (byte_2 = new byte[16]);
		}
		return array;
	}

	public float method_26()
	{
		method_17(4);
		byte[] array = byte_0;
		byte[] array2 = method_25();
		array2[2] = array[0];
		array2[0] = array[3];
		array2[3] = array[2];
		array2[1] = array[1];
		return method_29(array2).ReadSingle();
	}

	public double method_27()
	{
		method_17(8);
		byte[] array = byte_0;
		byte[] array2 = method_25();
		array2[1] = array[2];
		array2[5] = array[6];
		array2[0] = array[7];
		array2[7] = array[3];
		array2[3] = array[1];
		array2[6] = array[0];
		array2[4] = array[5];
		array2[2] = array[4];
		return method_29(array2).ReadDouble();
	}

	public decimal method_28()
	{
		method_17(16);
		byte[] array = byte_0;
		byte[] array2 = method_25();
		array2[5] = array[7];
		array2[8] = array[15];
		array2[13] = array[12];
		array2[9] = array[14];
		array2[11] = array[11];
		array2[12] = array[1];
		array2[10] = array[2];
		array2[4] = array[8];
		array2[15] = array[13];
		array2[1] = array[5];
		array2[14] = array[6];
		array2[3] = array[9];
		array2[2] = array[4];
		array2[6] = array[3];
		array2[0] = array[0];
		array2[7] = array[10];
		return smethod_1(array2);
	}

	private BinaryReader method_29(byte[] byte_3)
	{
		MemoryStream memoryStream = memoryStream_0;
		BinaryReader binaryReader = binaryReader_0;
		if (memoryStream == null)
		{
			memoryStream = (memoryStream_0 = new MemoryStream(8));
			binaryReader = (binaryReader_0 = new BinaryReader(memoryStream));
		}
		else
		{
			binaryReader.BaseStream.Position = 0L;
		}
		memoryStream.Write(byte_3, 0, byte_3.Length);
		memoryStream.Position = 0L;
		return binaryReader;
	}
}
