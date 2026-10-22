using System;
using System.Security.Cryptography;

internal sealed class Class76 : SymmetricAlgorithm
{
	[Serializable]
	private sealed class Class77
	{
		public static readonly Class77 class77_0 = new Class77();

		public static Comparison<SymmetricAlgorithm> comparison_0;

		internal int method_0(SymmetricAlgorithm symmetricAlgorithm_0, SymmetricAlgorithm symmetricAlgorithm_1)
		{
			return symmetricAlgorithm_1.BlockSize.CompareTo(symmetricAlgorithm_0.BlockSize);
		}
	}

	private sealed class Class78 : IDisposable, ICryptoTransform
	{
		private readonly byte[] byte_0;

		private readonly byte[] byte_1;

		private readonly SymmetricAlgorithm[] symmetricAlgorithm_0;

		private ICryptoTransform[] icryptoTransform_0;

		private readonly bool bool_0;

		private readonly int int_0;

		public int InputBlockSize => int_0;

		public int OutputBlockSize => int_0;

		public bool CanTransformMultipleBlocks => true;

		public bool CanReuseTransform => true;

		public Class78(SymmetricAlgorithm[] symmetricAlgorithm_1, byte[] byte_2, byte[] byte_3, bool bool_1)
		{
			byte_0 = byte_2;
			byte_1 = byte_3;
			symmetricAlgorithm_0 = symmetricAlgorithm_1;
			bool_0 = bool_1;
			int_0 = symmetricAlgorithm_1[symmetricAlgorithm_1.Length - 1].BlockSize / 8;
		}

		public void Dispose()
		{
			if (icryptoTransform_0 != null)
			{
				ICryptoTransform[] array = icryptoTransform_0;
				for (int i = 0; i < array.Length; i++)
				{
					array[i]?.Dispose();
				}
				icryptoTransform_0 = null;
			}
		}

		private void method_0()
		{
			SymmetricAlgorithm[] array = symmetricAlgorithm_0;
			int num = array.Length;
			if (icryptoTransform_0 == null)
			{
				ICryptoTransform[] array2 = new ICryptoTransform[num];
				int num2 = 0;
				for (int i = 0; i < num; i++)
				{
					SymmetricAlgorithm symmetricAlgorithm = array[i];
					int num3 = symmetricAlgorithm.KeySize / 8;
					byte[] array3 = new byte[num3];
					Buffer.BlockCopy(byte_0, num2, array3, 0, num3);
					num2 += num3;
					byte[] rgbIV = new byte[symmetricAlgorithm.BlockSize / 8];
					ICryptoTransform cryptoTransform = (bool_0 ? symmetricAlgorithm.CreateEncryptor(array3, rgbIV) : symmetricAlgorithm.CreateDecryptor(array3, rgbIV));
					array2[i] = cryptoTransform;
				}
				icryptoTransform_0 = array2;
			}
		}

		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			byte[] array = new byte[inputCount];
			TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
			return array;
		}

		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			Buffer.BlockCopy(inputBuffer, inputOffset, outputBuffer, outputOffset, inputCount);
			method_0();
			if (bool_0)
			{
				method_1(outputBuffer, outputOffset, inputCount);
			}
			else
			{
				method_2(outputBuffer, outputOffset, inputCount);
			}
			return inputCount;
		}

		private void method_1(byte[] byte_2, int int_1, int int_2)
		{
			byte[] array = new byte[byte_1.Length];
			Buffer.BlockCopy(byte_1, 0, array, 0, array.Length);
			int num = 0;
			ICryptoTransform[] array2 = icryptoTransform_0;
			foreach (ICryptoTransform cryptoTransform in array2)
			{
				int inputBlockSize = cryptoTransform.InputBlockSize;
				int num2 = (int_2 - num) & ~(inputBlockSize - 1);
				int num3 = num + num2;
				for (int j = num; j < num3; j += inputBlockSize)
				{
					int num4 = j + int_1;
					smethod_0(byte_2, num4, array, 0, inputBlockSize);
					cryptoTransform.TransformBlock(byte_2, num4, inputBlockSize, byte_2, num4);
					Buffer.BlockCopy(byte_2, num4, array, 0, inputBlockSize);
				}
				num = num3;
				if (num3 == int_2)
				{
					break;
				}
			}
		}

		private void method_2(byte[] byte_2, int int_1, int int_2)
		{
			byte[] array = new byte[byte_1.Length];
			Buffer.BlockCopy(byte_1, 0, array, 0, array.Length);
			byte[] array2 = new byte[array.Length];
			int num = 0;
			ICryptoTransform[] array3 = icryptoTransform_0;
			foreach (ICryptoTransform cryptoTransform in array3)
			{
				int inputBlockSize = cryptoTransform.InputBlockSize;
				int num2 = (int_2 - num) & ~(inputBlockSize - 1);
				int num3 = num + num2;
				for (int j = num; j < num3; j += inputBlockSize)
				{
					int num4 = j + int_1;
					Buffer.BlockCopy(byte_2, num4, array2, 0, inputBlockSize);
					cryptoTransform.TransformBlock(byte_2, num4, inputBlockSize, byte_2, num4);
					smethod_0(byte_2, num4, array, 0, inputBlockSize);
					Buffer.BlockCopy(array2, 0, array, 0, inputBlockSize);
				}
				num = num3;
				if (num3 == int_2)
				{
					break;
				}
			}
		}

		private static void smethod_0(byte[] byte_2, int int_1, byte[] byte_3, int int_2, int int_3)
		{
			for (int i = 0; i < int_3; i++)
			{
				byte_2[int_1 + i] ^= byte_3[int_2 + i];
			}
		}
	}

	private readonly SymmetricAlgorithm[] symmetricAlgorithm_0;

	private readonly int int_0;

	public override byte[] IV
	{
		get
		{
			return base.IV;
		}
		set
		{
			IVValue = (byte[])value.Clone();
		}
	}

	public Class76(params SymmetricAlgorithm[] symmetricAlgorithm_1)
	{
		symmetricAlgorithm_1 = (SymmetricAlgorithm[])symmetricAlgorithm_1.Clone();
		Array.Sort(symmetricAlgorithm_1, Class77.class77_0.method_0);
		symmetricAlgorithm_0 = symmetricAlgorithm_1;
		int num = 0;
		SymmetricAlgorithm[] array = symmetricAlgorithm_1;
		foreach (SymmetricAlgorithm symmetricAlgorithm in array)
		{
			num += symmetricAlgorithm.KeySize;
			symmetricAlgorithm.Mode = CipherMode.ECB;
			symmetricAlgorithm.Padding = PaddingMode.None;
		}
		BlockSizeValue = symmetricAlgorithm_1[symmetricAlgorithm_1.Length - 1].BlockSize;
		LegalBlockSizesValue = new KeySizes[1]
		{
			new KeySizes(BlockSizeValue, BlockSizeValue, 0)
		};
		KeySizeValue = num;
		LegalKeySizesValue = new KeySizes[1]
		{
			new KeySizes(num, num, 0)
		};
		int_0 = symmetricAlgorithm_1[0].BlockSize;
		Mode = CipherMode.ECB;
		Padding = PaddingMode.None;
	}

	public int method_0()
	{
		return int_0;
	}

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return method_1(rgbKey, rgbIV, bool_0: false);
	}

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
	{
		return method_1(rgbKey, rgbIV, bool_0: true);
	}

	private ICryptoTransform method_1(byte[] byte_0, byte[] byte_1, bool bool_0)
	{
		if (byte_0.Length * 8 != KeySize)
		{
			throw new ArgumentException(Class84.smethod_0(-994274973), Class84.smethod_0(-994274933));
		}
		if (byte_1.Length * 8 != method_0())
		{
			throw new ArgumentException(Class84.smethod_0(-994274938), Class84.smethod_0(-994274899));
		}
		return new Class78(symmetricAlgorithm_0, byte_0, byte_1, bool_0);
	}

	public override void GenerateIV()
	{
		throw new NotSupportedException();
	}

	public override void GenerateKey()
	{
		throw new NotSupportedException();
	}
}
