using System.Security.Cryptography;

internal abstract class Class53
{
	private readonly SymmetricAlgorithm[] symmetricAlgorithm_0;

	public Class53(byte[] byte_0, long long_0)
		: this(byte_0, smethod_2(long_0))
	{
	}

	public Class53(byte[] byte_0, byte[] byte_1)
	{
		Class44 @class = new Class44(byte_0, byte_1, 1);
		SymmetricAlgorithm[] array = new SymmetricAlgorithm[5];
		for (int i = 0; i < 5; i++)
		{
			Class76 class2 = new Class76(new Class3());
			class2.Key = @class.GetBytes(class2.KeySize / 8);
			class2.IV = @class.GetBytes(class2.method_0() / 8);
			array[i] = class2;
		}
		symmetricAlgorithm_0 = array;
	}

	protected static int smethod_0(int int_0)
	{
		return (int_0 + 3) / 4 * 4;
	}

	public static int smethod_1(int int_0)
	{
		return smethod_0(int_0 + 4);
	}

	protected static byte[] smethod_2(long long_0)
	{
		byte[] array = new byte[8];
		smethod_3(long_0, array, 0);
		return array;
	}

	protected static void smethod_3(long long_0, byte[] byte_0, int int_0)
	{
		byte_0[int_0] = (byte)long_0;
		byte_0[int_0 + 1] = (byte)(long_0 >> 8);
		byte_0[int_0 + 2] = (byte)(long_0 >> 16);
		byte_0[int_0 + 3] = (byte)(long_0 >> 24);
		byte_0[int_0 + 4] = (byte)(long_0 >> 32);
		byte_0[int_0 + 5] = (byte)(long_0 >> 40);
		byte_0[int_0 + 6] = (byte)(long_0 >> 48);
		byte_0[int_0 + 7] = (byte)(long_0 >> 56);
	}

	protected static int smethod_4(byte[] byte_0, int int_0)
	{
		return byte_0[int_0] | (byte_0[int_0 + 1] << 8) | (byte_0[int_0 + 2] << 16) | (byte_0[int_0 + 3] << 24);
	}

	protected static void smethod_5(int int_0, byte[] byte_0, int int_1)
	{
		byte_0[int_1] = (byte)int_0;
		byte_0[int_1 + 1] = (byte)(int_0 >> 8);
		byte_0[int_1 + 2] = (byte)(int_0 >> 16);
		byte_0[int_1 + 3] = (byte)(int_0 >> 24);
	}

	protected byte[] method_0(byte[] byte_0, bool bool_0)
	{
		if (bool_0)
		{
			SymmetricAlgorithm[] array = symmetricAlgorithm_0;
			foreach (SymmetricAlgorithm symmetricAlgorithm in array)
			{
				if (bool_0)
				{
					using ICryptoTransform cryptoTransform = symmetricAlgorithm.CreateEncryptor();
					byte_0 = cryptoTransform.TransformFinalBlock(byte_0, 0, byte_0.Length);
				}
				else
				{
					using ICryptoTransform cryptoTransform2 = symmetricAlgorithm.CreateDecryptor();
					byte_0 = cryptoTransform2.TransformFinalBlock(byte_0, 0, byte_0.Length);
				}
				bool_0 = !bool_0;
			}
		}
		else
		{
			for (int num = 4; num >= 0; num--)
			{
				SymmetricAlgorithm symmetricAlgorithm2 = symmetricAlgorithm_0[num];
				if (bool_0)
				{
					using ICryptoTransform cryptoTransform3 = symmetricAlgorithm2.CreateEncryptor();
					byte_0 = cryptoTransform3.TransformFinalBlock(byte_0, 0, byte_0.Length);
				}
				else
				{
					using ICryptoTransform cryptoTransform4 = symmetricAlgorithm2.CreateDecryptor();
					byte_0 = cryptoTransform4.TransformFinalBlock(byte_0, 0, byte_0.Length);
				}
				bool_0 = !bool_0;
			}
		}
		return byte_0;
	}
}
