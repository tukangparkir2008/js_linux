using System;
using System.Security.Cryptography;

internal sealed class Class3 : SymmetricAlgorithm
{
	private sealed class Class4 : IDisposable, ICryptoTransform
	{
		private byte[] byte_0;

		private bool bool_0;

		public int InputBlockSize => 4;

		public int OutputBlockSize => 4;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => true;

		public Class4(byte[] byte_1, bool bool_1)
		{
			byte_0 = byte_1;
			bool_0 = bool_1;
		}

		public void Dispose()
		{
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			if (inputCount % 4 != 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			for (int i = 0; i < inputCount; i += 4)
			{
				smethod_1(byte_0, inputBuffer, inputOffset + i, outputBuffer, outputOffset + i, bool_0);
			}
			return inputCount;
		}

		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			byte[] array = new byte[inputCount];
			TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}
	}

	private static byte[] byte_0 = new byte[256]
	{
		163, 215, 9, 131, 248, 72, 246, 244, 179, 33,
		21, 120, 153, 177, 175, 249, 231, 45, 77, 138,
		206, 76, 202, 46, 82, 149, 217, 30, 78, 56,
		68, 40, 10, 223, 2, 160, 23, 241, 96, 104,
		18, 183, 122, 195, 233, 250, 61, 83, 150, 132,
		107, 186, 242, 99, 154, 25, 124, 174, 229, 245,
		247, 22, 106, 162, 57, 182, 123, 15, 193, 147,
		129, 27, 238, 180, 26, 234, 208, 145, 47, 184,
		85, 185, 218, 133, 63, 65, 191, 224, 90, 88,
		128, 95, 102, 11, 216, 144, 53, 213, 192, 167,
		51, 6, 101, 105, 69, 0, 148, 86, 109, 152,
		155, 118, 151, 252, 178, 194, 176, 254, 219, 32,
		225, 235, 214, 228, 221, 71, 74, 29, 66, 237,
		158, 110, 73, 60, 205, 67, 39, 210, 7, 212,
		222, 199, 103, 24, 137, 203, 48, 31, 141, 198,
		143, 170, 200, 116, 220, 201, 93, 92, 49, 164,
		112, 136, 97, 44, 159, 13, 43, 135, 80, 130,
		84, 100, 38, 125, 3, 64, 52, 75, 28, 115,
		209, 196, 253, 59, 204, 251, 127, 171, 230, 62,
		91, 165, 173, 4, 35, 156, 20, 81, 34, 240,
		41, 121, 113, 126, 255, 140, 14, 226, 12, 239,
		188, 114, 117, 111, 55, 161, 236, 211, 142, 98,
		139, 134, 16, 232, 8, 119, 17, 190, 146, 79,
		36, 197, 50, 54, 157, 207, 243, 166, 187, 172,
		94, 108, 169, 19, 87, 37, 181, 227, 189, 168,
		58, 1, 5, 89, 42, 70
	};

	public Class3()
	{
		LegalBlockSizesValue = new KeySizes[1]
		{
			new KeySizes(32, 32, 0)
		};
		LegalKeySizesValue = new KeySizes[1]
		{
			new KeySizes(80, 80, 0)
		};
		BlockSizeValue = 32;
		KeySizeValue = 80;
		ModeValue = CipherMode.ECB;
		PaddingValue = PaddingMode.None;
	}

	public Class3(byte[] byte_1)
		: this()
	{
		Key = byte_1 ?? throw new ArgumentNullException();
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return new Class4(rgbKey, bool_1: false);
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return new Class4(rgbKey, bool_1: true);
	}

	public override void GenerateIV()
	{
		throw new NotImplementedException();
	}

	public override void GenerateKey()
	{
		throw new NotImplementedException();
	}

	private static ushort smethod_0(byte[] byte_1, int int_0, ushort ushort_0)
	{
		byte b = (byte)(ushort_0 >> 8);
		byte b2 = (byte)ushort_0;
		byte b3 = (byte)(byte_0[b2 ^ byte_1[4 * int_0 % 10]] ^ b);
		byte b4 = (byte)(byte_0[b3 ^ byte_1[(4 * int_0 + 1) % 10]] ^ b2);
		byte b5 = (byte)(byte_0[b4 ^ byte_1[(4 * int_0 + 2) % 10]] ^ b3);
		byte b6 = (byte)(byte_0[b5 ^ byte_1[(4 * int_0 + 3) % 10]] ^ b4);
		return (ushort)((b5 << 8) + b6);
	}

	private static void smethod_1(byte[] byte_1, byte[] byte_2, int int_0, byte[] byte_3, int int_1, bool bool_0)
	{
		int num;
		int num2;
		if (bool_0)
		{
			num = 1;
			num2 = 0;
		}
		else
		{
			num = -1;
			num2 = 23;
		}
		ushort num3 = (ushort)((byte_2[int_0] << 8) + byte_2[int_0 + 1]);
		ushort num4 = (ushort)((byte_2[int_0 + 2] << 8) + byte_2[int_0 + 3]);
		for (int i = 0; i < 12; i++)
		{
			num4 ^= (ushort)(smethod_0(byte_1, num2, num3) ^ num2);
			num2 += num;
			num3 ^= (ushort)(smethod_0(byte_1, num2, num4) ^ num2);
			num2 += num;
		}
		byte_3[int_1] = (byte)(num4 >> 8);
		byte_3[int_1 + 1] = (byte)num4;
		byte_3[int_1 + 2] = (byte)(num3 >> 8);
		byte_3[int_1 + 3] = (byte)num3;
	}
}
