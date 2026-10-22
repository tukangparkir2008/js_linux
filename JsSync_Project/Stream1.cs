using System;
using System.IO;

internal sealed class Stream1 : Stream
{
	private int int_0;

	private int int_1;

	private int int_2;

	private Stream stream_0;

	private Interface4 interface4_0;

	private int int_3;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private byte[] byte_0;

	private int int_4;

	private byte[] byte_1;

	private int int_5;

	private int int_6;

	private int int_7;

	private bool bool_3;

	public override bool CanRead => true;

	public override bool CanSeek => true;

	public override bool CanWrite => false;

	public override long Length
	{
		get
		{
			method_4();
			return int_0;
		}
	}

	public override long Position
	{
		get
		{
			return int_3 * int_7 + int_6;
		}
		set
		{
			int num = (int)value / int_7;
			int_6 = (int)value % int_7;
			if (int_3 != num)
			{
				int_3 = num;
				bool_2 = true;
				bool_0 = false;
			}
		}
	}

	public Stream1(Stream stream_1, Interface4 interface4_1)
	{
		if (stream_1 == null)
		{
			throw new ArgumentNullException(Class84.smethod_0(-994273099));
		}
		if (interface4_1 == null)
		{
			throw new ArgumentNullException(Class84.smethod_0(-994272790));
		}
		stream_0 = stream_1;
		interface4_0 = interface4_1;
		if (stream_0.Length < 4L)
		{
			throw new InvalidOperationException();
		}
		method_0();
	}

	private void method_0()
	{
		int_4 = interface4_0.imethod_0();
		byte_0 = new byte[int_4];
		int_7 = interface4_0.imethod_1();
		byte_1 = new byte[int_7];
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		switch (origin)
		{
		case SeekOrigin.Begin:
			Position = offset;
			break;
		case SeekOrigin.Current:
			Position += offset;
			break;
		case SeekOrigin.End:
			Position = Length + offset;
			break;
		}
		return Position;
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException(Class84.smethod_0(-994272742));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException(Class84.smethod_0(-994272747));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException();
		}
		if (count == 0)
		{
			return 0;
		}
		int num = count;
		int num2 = offset;
		if (int_6 < int_7)
		{
			method_1();
			int num3 = int_5 - int_6;
			if (num3 > count)
			{
				Buffer.BlockCopy(byte_1, int_6, buffer, offset, count);
				int_6 += count;
				return count;
			}
			Buffer.BlockCopy(byte_1, int_6, buffer, offset, num3);
			int_6 = int_5;
			if (bool_1)
			{
				return num3;
			}
			num -= num3;
			num2 += num3;
		}
		if (bool_1)
		{
			return count - num;
		}
		while (true)
		{
			if (num > 0)
			{
				method_2();
				if (!bool_1)
				{
					int num4 = int_5;
					if (num < num4)
					{
						break;
					}
					Buffer.BlockCopy(byte_1, 0, buffer, num2, num4);
					num2 += num4;
					num -= num4;
					int_6 = num4;
					continue;
				}
				return count - num;
			}
			return count;
		}
		Buffer.BlockCopy(byte_1, 0, buffer, num2, num);
		int_6 = num;
		return count;
	}

	private void method_1()
	{
		method_4();
		if (!bool_0)
		{
			bool_0 = true;
			bool_1 = false;
			int num = int_3;
			if (bool_2)
			{
				stream_0.Position = 4 + num * int_4;
				bool_2 = false;
			}
			method_3(num);
		}
	}

	private void method_2()
	{
		int int_ = int_3 + 1;
		if (method_3(int_))
		{
			int_3 = int_;
			int_6 = 0;
		}
		bool_0 = true;
	}

	private bool method_3(int int_8)
	{
		int num = 0;
		while (true)
		{
			if (num < int_4)
			{
				int num2 = stream_0.Read(byte_0, num, int_4 - num);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				continue;
			}
			int_5 = interface4_0.imethod_2(byte_0, 0, int_4, byte_1, 0);
			if (int_8 == int_1)
			{
				int_5 = int_2;
			}
			return true;
		}
		if (num != 0)
		{
			throw new InvalidOperationException();
		}
		bool_1 = true;
		return false;
	}

	private void method_4()
	{
		if (!bool_3)
		{
			if (stream_0.Position != 0L)
			{
				stream_0.Position = 0L;
				bool_2 = true;
			}
			Class50 @class = smethod_0(stream_0);
			int_0 = @class.method_0();
			int_1 = int_0 / int_7;
			int_2 = int_0 % int_7;
			bool_3 = true;
		}
	}

	private static Class50 smethod_0(Stream stream_1)
	{
		Class69 @class = new Class69(stream_1, 0);
		try
		{
			Class48 class2 = new Class48(@class);
			try
			{
				int num = class2.method_19();
				Class50 class3 = new Class50();
				class3.method_1(num);
				return class3;
			}
			finally
			{
				((IDisposable)class2).Dispose();
			}
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
	}

	public override void Flush()
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}
}
