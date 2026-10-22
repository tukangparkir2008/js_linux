using System;
using System.Security.Cryptography;

internal sealed class Class39 : DeriveBytes
{
	private byte[] byte_0;

	private byte[] byte_1;

	private int int_0;

	private readonly Class83 class83_0 = new Class83();

	private readonly byte[] byte_2;

	public Class39(byte[] byte_3, byte[] byte_4, int int_1)
	{
		if (byte_3 == null)
		{
			throw new ArgumentNullException(Class84.smethod_0(-994273279));
		}
		if (byte_4 == null)
		{
			throw new ArgumentNullException(Class84.smethod_0(-994273220));
		}
		if (int_1 < 1)
		{
			throw new ArgumentException(Class84.smethod_0(-994273225));
		}
		byte_0 = (byte[])byte_3.Clone();
		byte_1 = (byte[])byte_4.Clone();
		int_0 = int_1;
		byte_2 = new byte[class83_0.method_1()];
	}

	private void method_0(byte[] byte_3, int int_1, byte[] byte_4, byte[] byte_5, int int_2)
	{
		if (byte_3 != null)
		{
			class83_0.method_2(byte_3, 0, byte_3.Length);
		}
		class83_0.method_2(byte_4, 0, byte_4.Length);
		class83_0.method_3(byte_2, 0);
		Buffer.BlockCopy(byte_2, 0, byte_5, int_2, byte_2.Length);
		for (int i = 1; i < int_1; i++)
		{
			class83_0.method_2(byte_2, 0, byte_2.Length);
			class83_0.method_3(byte_2, 0);
			for (int j = 0; j < byte_2.Length; j++)
			{
				byte_5[int_2 + j] ^= byte_2[j];
			}
		}
	}

	public override byte[] GetBytes(int cb)
	{
		int num = class83_0.method_1();
		int num2 = (cb + num - 1) / num;
		byte[] array = new byte[4];
		byte[] array2 = new byte[num2 * num];
		int num3 = 0;
		class83_0.method_0(byte_0);
		for (int i = 1; i <= num2; i++)
		{
			int num4 = 3;
			while (++array[num4] == 0)
			{
				num4--;
			}
			method_0(byte_1, int_0, array, array2, num3);
			num3 += num;
		}
		if (cb < array2.Length)
		{
			byte[] array3 = new byte[cb];
			Buffer.BlockCopy(array2, 0, array3, 0, cb);
			array2 = array3;
		}
		return array2;
	}

	public override void Reset()
	{
		throw new NotSupportedException();
	}
}
