using System;
using System.IO;
using System.Runtime.CompilerServices;

internal sealed class Class69 : Class67
{
	private readonly int int_0;

	private readonly Stream stream_0;

	public Class69(Stream stream_1, int int_1)
	{
		stream_0 = stream_1;
		int_0 = int_1 ^ -559030707;
	}

	public Stream method_0()
	{
		return stream_0;
	}

	[SpecialName]
	public override bool vmethod_0()
	{
		return method_0().CanRead;
	}

	[SpecialName]
	public override bool vmethod_2()
	{
		return method_0().CanSeek;
	}

	[SpecialName]
	public override bool vmethod_1()
	{
		return method_0().CanWrite;
	}

	public override void vmethod_8()
	{
		method_0().Flush();
	}

	[SpecialName]
	public override long vmethod_3()
	{
		return method_0().Length;
	}

	[SpecialName]
	public override long vmethod_4()
	{
		return method_0().Position;
	}

	[SpecialName]
	public override void vmethod_5(long long_0)
	{
		method_0().Position = long_0;
	}

	private byte method_1(byte byte_0, uint uint_0)
	{
		byte b = (byte)((uint)int_0 ^ uint_0);
		return (byte)(byte_0 ^ b);
	}

	public override void vmethod_13(byte[] byte_0, int int_1, int int_2)
	{
		uint num = (uint)vmethod_4();
		byte[] array = new byte[int_2];
		for (uint num2 = 0u; num2 < int_2; num2++)
		{
			array[num2] = method_1(byte_0[num2 + int_1], num + num2);
		}
		method_0().Write(array, 0, int_2);
	}

	public override int vmethod_11(byte[] byte_0, int int_1, int int_2)
	{
		uint num = (uint)vmethod_4();
		int num2 = method_0().Read(byte_0, int_1, int_2);
		int num3 = int_1 + num2;
		for (int i = int_1; i < num3; i++)
		{
			byte_0[i] = method_1(byte_0[i], num++);
		}
		return num2;
	}

	public override long vmethod_9(long long_0, int int_1)
	{
		SeekOrigin origin = int_1 switch
		{
			0 => SeekOrigin.Begin, 
			1 => SeekOrigin.Current, 
			2 => SeekOrigin.End, 
			_ => throw new ArgumentException(), 
		};
		return method_0().Seek(long_0, origin);
	}

	public override void vmethod_10(long long_0)
	{
		method_0().SetLength(long_0);
	}
}
