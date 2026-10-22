using System;
using System.IO;

internal sealed class Stream0 : Stream
{
	private bool bool_0;

	private Stream stream_0;

	private Class65[] class65_0;

	private Class46 class46_0;

	private Class5 class5_0;

	private Class42 class42_0;

	private bool bool_1;

	private byte[] byte_0;

	private int int_0;

	private int int_1;

	public override bool CanRead => true;

	public override bool CanSeek => true;

	public override bool CanWrite => false;

	public override long Length => stream_0.Length;

	public override long Position
	{
		get
		{
			return stream_0.Position + (int_0 - int_1);
		}
		set
		{
			Seek(value, SeekOrigin.Begin);
		}
	}

	public Stream0(Stream stream_1, Class46 class46_1 = null, Class5 class5_1 = null, bool bool_2 = false)
	{
		stream_0 = stream_1;
		bool_0 = bool_2;
		class5_0 = class5_1;
		class46_0 = class46_1;
		if (class46_0 == null)
		{
			class46_0 = Class46.smethod_0();
		}
		if (class46_0.method_2() == 0)
		{
			throw new ArgumentException(Class84.smethod_0(-994273148));
		}
		if (class46_0.method_4() == 0)
		{
			throw new ArgumentException(Class84.smethod_0(-994273148));
		}
		if (!stream_0.CanRead)
		{
			throw new ArgumentException(Class84.smethod_0(-994273099));
		}
		if (!stream_0.CanSeek)
		{
			throw new ArgumentException(Class84.smethod_0(-994273099));
		}
	}

	private void method_0()
	{
		if (!bool_1)
		{
			class65_0 = new Class65[class46_0.method_2()];
			for (int i = 0; i < class46_0.method_2(); i++)
			{
				class65_0[i] = new Class65();
			}
			if (class5_0 != null)
			{
				class42_0 = class5_0.method_0(class46_0);
			}
			bool_1 = true;
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && !bool_0)
			{
				stream_0.Close();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	public override void Flush()
	{
	}

	private int method_1(byte[] byte_1, int int_2, int int_3)
	{
		int num = int_1 - int_0;
		if (num <= 0)
		{
			return 0;
		}
		if (num > int_3)
		{
			num = int_3;
		}
		Buffer.BlockCopy(byte_0, int_0, byte_1, int_2, num);
		int_0 += num;
		return num;
	}

	private void method_2(int int_2)
	{
		int num = (int)stream_0.Position;
		if (num >= stream_0.Length)
		{
			return;
		}
		int num2 = num + int_2;
		Class65[] array = class65_0;
		int num3 = 0;
		Class65 @class;
		while (true)
		{
			if (num3 < array.Length)
			{
				@class = array[num3];
				if (@class.int_0 <= num && @class.int_1 >= num2)
				{
					break;
				}
				num3++;
				continue;
			}
			int num4 = 0;
			DateTime dateTime_ = class65_0[0].dateTime_0;
			for (int i = 1; i < class65_0.Length; i++)
			{
				if (class65_0[i].dateTime_0 < dateTime_)
				{
					num4 = i;
				}
			}
			Class65 class65_ = class65_0[num4];
			if (class65_.byte_0 == null)
			{
				class65_.byte_0 = new byte[class46_0.method_0()];
			}
			int num5 = num;
			num = method_3(num);
			if (num < 0)
			{
				num = 0;
			}
			num2 = num + class46_0.method_0();
			if (class42_0 != null && class42_0.method_3(num, ref class65_))
			{
				byte_0 = class65_.byte_0;
				int_1 = class65_.int_1 - num;
				stream_0.Position = class65_.int_1;
				int_0 = num5 - num;
				return;
			}
			class65_.int_0 = num;
			class65_.dateTime_0 = DateTime.UtcNow;
			byte_0 = class65_.byte_0;
			stream_0.Position = num;
			int_1 = stream_0.Read(byte_0, 0, num2 - num);
			int_0 = num5 - num;
			class65_.int_1 = num + int_1;
			if (class42_0 != null)
			{
				class42_0.method_1(class65_);
			}
			return;
		}
		byte_0 = @class.byte_0;
		int_1 = @class.int_1 - @class.int_0;
		int_0 = num - @class.int_0;
		stream_0.Position = @class.int_1;
		@class.dateTime_0 = DateTime.UtcNow;
	}

	private int method_3(int int_2)
	{
		return int_2 - int_2 % class46_0.method_0();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException(Class84.smethod_0(-994273118));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException(Class84.smethod_0(-994273059));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException(Class84.smethod_0(-994273080));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException();
		}
		int int_ = offset;
		int num = method_1(buffer, offset, count);
		if (num == count)
		{
			return num;
		}
		int num2 = num;
		if (num > 0)
		{
			count -= num;
			offset += num;
		}
		int_1 = 0;
		int_0 = 0;
		method_0();
		if (count >= class46_0.method_0())
		{
			if (class42_0 == null)
			{
				return stream_0.Read(buffer, offset, count) + num2;
			}
			int int_2 = (int)stream_0.Position - num2;
			if (class42_0.method_8(int_2, buffer, int_, count + num2, out var int_3))
			{
				stream_0.Seek(int_3 - num2, SeekOrigin.Current);
				return int_3;
			}
			int_3 = stream_0.Read(buffer, offset, count);
			if (int_3 != 0)
			{
				class42_0.method_7(int_2, buffer, int_, int_3 + num2, int_3 < count);
			}
			return int_3 + num2;
		}
		method_2(count);
		num = method_1(buffer, offset, count);
		return num + num2;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		if (int_1 - int_0 > 0 && origin == SeekOrigin.Current)
		{
			offset -= int_1 - int_0;
		}
		long position = Position;
		long num = stream_0.Seek(offset, origin);
		int_0 = (int)(num - (position - int_0));
		if (0 <= int_0 && int_0 < int_1)
		{
			stream_0.Seek(int_1 - int_0, SeekOrigin.Current);
		}
		else
		{
			int_1 = 0;
			int_0 = 0;
		}
		return num;
	}
}
