using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

internal static class Class84
{
	private sealed class Class85
	{
		private Stream stream_0;

		private byte[] byte_0;

		public Class85(Stream stream_1)
		{
			stream_0 = stream_1;
			byte_0 = new byte[4];
		}

		public Stream method_0()
		{
			return stream_0;
		}

		public short method_1()
		{
			method_4(2);
			return (short)(byte_0[0] | (byte_0[1] << 8));
		}

		public int method_2()
		{
			method_4(4);
			return byte_0[0] | (byte_0[1] << 8) | (byte_0[2] << 16) | (byte_0[3] << 24);
		}

		private void method_3()
		{
			throw new EndOfStreamException();
		}

		private void method_4(int int_0)
		{
			int num = 0;
			int num2 = 0;
			if (int_0 == 1)
			{
				num2 = stream_0.ReadByte();
				if (num2 == -1)
				{
					method_3();
				}
				byte_0[0] = (byte)num2;
				return;
			}
			do
			{
				num2 = stream_0.Read(byte_0, num, int_0 - num);
				if (num2 == 0)
				{
					method_3();
				}
				num += num2;
			}
			while (num < int_0);
		}

		public void method_5()
		{
			Stream stream = stream_0;
			stream_0 = null;
			stream?.Close();
			byte_0 = null;
		}

		public byte[] method_6(int int_0)
		{
			if (int_0 < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] array = new byte[int_0];
			int num = 0;
			do
			{
				int num2 = stream_0.Read(array, num, int_0);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				int_0 -= num2;
			}
			while (int_0 > 0);
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(array, 0, array2, 0, num);
				array = array2;
			}
			return array;
		}
	}

	private enum Enum1
	{

	}

	private static int int_0;

	private static Enum1 enum1_0;

	private static short short_0;

	private static byte[] byte_0;

	private static Dictionary<int, string> dictionary_0;

	private static int int_1;

	private static byte[] byte_1;

	private static Class85 class85_0;

	private static int int_2;

	static Class84()
	{
		int num = -1523455389;
		int num2 = 1236495904;
		dictionary_0 = new Dictionary<int, string>(5734);
		int num3 = 2;
		StackTrace stackTrace = new StackTrace(2, fNeedFileInfo: false);
		num3 = 0;
		StackFrame frame = stackTrace.GetFrame(0);
		int int_ = 0;
		if (frame == null)
		{
			stackTrace = new StackTrace();
			int_ = 1;
			frame = stackTrace.GetFrame(1);
		}
		int num4 = -(~(-(~(-(~(~(-(~((-357714966 - num) ^ num2))))))))) ^ ~(-(-(~(~(-(-(~(-(~(~((num ^ -1815545249) - num2)))))))))));
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num4 ^= -(~(-(~(~(-(~(-(-(~(~(1220836419 - num + num2)))))))))));
		}
		Type type = methodBase?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			num4 ^= num + -1535015196 - num2 + num3;
			enum1_0 = (Enum1)4 | enum1_0;
		}
		else if ((object)type == null)
		{
			if (smethod_4(stackTrace, int_))
			{
				num4 ^= -(~(~(-(~(-(~(-(~(0x137D265A ^ num ^ num2))))))))) - num3;
				enum1_0 |= (Enum1)16;
			}
			else
			{
				enum1_0 = (Enum1)1 | enum1_0;
				num4 ^= -(~(~(-(-(~(~(-(-(~(~(-286996531 - num - num2)))))))))));
			}
		}
		else
		{
			num4 ^= -(~(~(-(-(~(-(~(~((num ^ 0x137DD99E) + num2))))))))) - num3;
			enum1_0 = (Enum1)0x10 | enum1_0;
		}
		int_0 += num4;
	}

	internal static string smethod_0(int int_3)
	{
		lock (dictionary_0)
		{
			if (dictionary_0.TryGetValue(int_3, out var value))
			{
				return value;
			}
			return smethod_1(int_3, bool_0: true);
		}
	}

	private static string smethod_1(int int_3, bool bool_0)
	{
		int num = -717443498;
		int num2 = -197802471;
		string value = null;
		byte[] array;
		int num18;
		while (true)
		{
			int num3;
			if (class85_0 != null)
			{
				num3 = int_1;
			}
			else
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Assembly callingAssembly = Assembly.GetCallingAssembly();
				int_2 |= (0x2172F6CD ^ num) - num2;
				StringBuilder stringBuilder = new StringBuilder();
				int num4 = (num + -17287223) ^ num2;
				stringBuilder.Append((char)(num4 >> 16)).Append((char)num4);
				num4 = 17500229 - num + num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				num4 = (num ^ -1056225204) - num2;
				stringBuilder.Append((char)(num4 >> 16)).Append((char)num4);
				num4 = num + 1452321689 + num2;
				stringBuilder.Append((char)(num4 >> 16)).Append((char)num4);
				num4 = 0x1094845 ^ num ^ num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				num4 = 17631293 - num + num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(stringBuilder.ToString());
				int num5 = 2;
				StackTrace stackTrace = new StackTrace(2, fNeedFileInfo: false);
				int_2 ^= ((num ^ 0x21097109) - num2) | 2;
				num5 = 0;
				StackFrame frame = stackTrace.GetFrame(0);
				int int_4 = 0;
				if (frame == null)
				{
					stackTrace = new StackTrace();
					int_4 = 1;
					frame = stackTrace.GetFrame(1);
				}
				MethodBase methodBase = frame?.GetMethod();
				int_2 ^= num5 + (-519640899 - num + num2);
				Type type = methodBase?.DeclaringType;
				if (frame == null)
				{
					int_2 ^= (519696468 + num) ^ num2;
				}
				bool flag = (object)type == typeof(RuntimeMethodHandle);
				int_2 ^= (-554265391 ^ num) + num2;
				if (!flag && (flag = (object)type == null))
				{
					if (smethod_4(stackTrace, int_4))
					{
						flag = false;
					}
					else
					{
						int_2 ^= -915026686 - num - num2;
					}
				}
				if (flag == (stackTrace != null))
				{
					int_2 ^= 32;
				}
				int_2 ^= ((519647529 + num) ^ num2) | (1 + num5);
				class85_0 = new Class85(manifestResourceStream);
				short num6 = (short)(class85_0.method_1() ^ (short)(-(~(~(-(-(~(-(~(~((num ^ -554255486) + num2)))))))))));
				if (num6 == 0)
				{
					short_0 = (short)(class85_0.method_1() ^ (short)(~(-(-(~(-(~(~(-(~(-(~((915262733 + num) ^ num2)))))))))))));
				}
				else
				{
					byte_1 = class85_0.method_6(num6);
				}
				callingAssembly = executingAssembly;
				AssemblyName assemblyName_ = smethod_2(callingAssembly);
				byte_0 = smethod_3(assemblyName_);
				num3 = int_0;
				int_0 = 0;
				num3 ^= (num ^ -2014420296) + num2;
				long num7 = Class87.smethod_0();
				num3 ^= (int)num7;
				num3 ^= 179948709 - num - num2;
				int num8 = num3;
				int num9 = num8;
				int num10 = ((519644254 + num) ^ num2) * num9 % ((num ^ 0x20E1BA50) - num2);
				int num11 = 0;
				int num12 = (num10 + ((182125904 + num) ^ num2)) ^ ((num ^ 0x16DEDA6B) - num2);
				int int_5 = num12;
				Interface0<int> enumerator = ((Interface3<int>)new Class34.Class35((num + 915245969) ^ num2)
				{
					int_4 = int_5
				}).GetEnumerator();
				try
				{
					while (enumerator.imethod_1())
					{
						int num13 = enumerator.imethod_3();
						num12 ^= num13 + num11;
						num11 += num12 >> 3;
					}
				}
				finally
				{
					((Interface2)enumerator)?.imethod_0();
				}
				int num14 = num12;
				num3 ^= -914530911 - num - num2 + -(~(~(-(~(-(-(~(-(~(~((-554264861 ^ num) + num2)))))))))));
				num3 ^= -(~(-(~(~(-(-(~(-(~(~((1099839665 - num) ^ num2)))))))))));
				num3 = (int_1 = num14 + num3);
				int_2 = (int_2 & (num + 1183681283 + num2)) ^ (0x210972CB ^ num ^ num2);
				if (((uint)enum1_0 & (uint)(-(~(~(-(~(-(~(-(-(~(~(-915245987 - num - num2))))))))))))) == 0)
				{
					int_2 = num + 915289931 + num2;
				}
			}
			if (int_2 != (0x210ADF85 ^ num) - num2)
			{
				int num15 = int_3 ^ (-597394454 - num + num2) ^ num3;
				num15 ^= (num ^ -1318471458) - num2;
				class85_0.method_0().Position = num15;
				if (byte_1 != null)
				{
					array = byte_1;
				}
				else
				{
					short num16 = ((short_0 != -1) ? short_0 : ((short)(class85_0.method_1() ^ ((915251744 + num) ^ num2) ^ num15)));
					if (num16 == 0)
					{
						array = null;
					}
					else
					{
						array = class85_0.method_6(num16);
						for (int num17 = 0; num17 != array.Length; num17 = 1 + num17)
						{
							array[num17] ^= (byte)(int_1 >> ((num17 & 3) << 3));
						}
					}
				}
				num18 = class85_0.method_2() ^ num15 ^ ~(-(-(~(~(-(~(-(~(758301528 - num - num2))))))))) ^ num3;
				if (num18 != (num ^ -554264653) + num2)
				{
					break;
				}
				byte[] array2 = class85_0.method_6(4);
				int_3 = (1028072803 - num) ^ num2 ^ num3;
				int_3 = (array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -int_3;
				if (dictionary_0.TryGetValue(int_3, out value))
				{
					return value;
				}
				continue;
			}
			return new string(new char[3]
			{
				(char)((-915245929 - num) ^ num2),
				'0',
				(char)((0x21096827 ^ num) - num2)
			});
		}
		bool flag2 = (num18 & ((-1628006479 ^ num) + num2)) != 0;
		bool flag3 = (num18 & (-378375057 - num - num2)) != 0;
		bool flag4 = (num18 & ((0x5EF697B1 ^ num) + num2)) != 0;
		num18 &= -646810514 - num - num2;
		byte[] array3 = array;
		byte[] array4 = class85_0.method_6(num18);
		byte[] array5 = array3;
		byte b = array5[1];
		int num19 = array4.Length;
		byte b2 = (byte)((11 + num19) ^ (b + 7));
		uint num20 = (uint)((array5[0] | (array5[2] << 8)) + (b2 << 3));
		int num21 = 0;
		ushort num22 = 0;
		while (num21 < num19)
		{
			if ((num21 & 1) == 0)
			{
				num20 = (uint)((int)num20 * (num + 915459982 + num2) + (-912714958 - num - num2));
				num22 = (ushort)(num20 >> 16);
			}
			byte b3 = (byte)num22;
			num22 >>= 8;
			byte b4 = array4[num21];
			array4[num21] = (byte)(b4 ^ b ^ (b2 + 3) ^ b3);
			b2 = b4;
			num21 = 1 + num21;
		}
		byte[] array6 = array4;
		if (byte_0 != null != (int_2 != ((519086153 + num) ^ num2)))
		{
			for (int i = 0; i < num18; i++)
			{
				byte b5 = byte_0[7 & i];
				b5 = (byte)((b5 << 3) | (b5 >> 5));
				array6[i] ^= b5;
			}
		}
		int num23 = int_2 - 12;
		byte[] array7;
		int num24;
		if (!flag3)
		{
			array7 = array6;
			num24 = num18;
		}
		else
		{
			num24 = array6[2] | (array6[0] << 16) | (array6[3] << 8) | (array6[1] << 24);
			array7 = new byte[num24];
			smethod_5(array6, 4, array7);
		}
		if (flag2 && num23 == -518033225 - num + num2)
		{
			char[] array8 = new char[num24];
			for (int j = 0; j < num24; j++)
			{
				array8[j] = (char)array7[j];
			}
			value = new string(array8);
		}
		else
		{
			value = Encoding.Unicode.GetString(array7, 0, array7.Length);
		}
		num23 += (0x210968CE ^ num) - num2 + (num23 & 3) << 5;
		if (num23 != 916857899 + num + num2)
		{
			int num25 = (int_3 + num18) ^ (0x21072237 ^ num ^ num2) ^ (num23 & (-915244676 - num - num2));
			StringBuilder stringBuilder = new StringBuilder();
			int num4 = 915246057 + num + num2;
			stringBuilder.Append((char)(byte)num4);
			value = num25.ToString(stringBuilder.ToString());
		}
		if (!flag4 & bool_0)
		{
			value = string.Intern(value);
			dictionary_0[int_3] = value;
			if (dictionary_0.Count == (0x21097E29 ^ num ^ num2))
			{
				class85_0.method_5();
				class85_0 = null;
				byte_1 = null;
				byte_0 = null;
			}
		}
		return value;
	}

	private static AssemblyName smethod_2(Assembly assembly_0)
	{
		try
		{
			return assembly_0.GetName();
		}
		catch
		{
			return new AssemblyName(assembly_0.FullName);
		}
	}

	private static byte[] smethod_3(AssemblyName assemblyName_0)
	{
		byte[] array = assemblyName_0.GetPublicKeyToken();
		if (array != null && array.Length == 0)
		{
			array = null;
		}
		return array;
	}

	private static bool smethod_4(StackTrace stackTrace_0, int int_3)
	{
		Assembly assembly = stackTrace_0.GetFrame(++int_3)?.GetMethod()?.DeclaringType?.Assembly;
		if ((object)assembly != null)
		{
			AssemblyName assemblyName_ = smethod_2(assembly);
			byte[] array = smethod_3(assemblyName_);
			if (array != null && array.Length == 8 && array[0] == 183 && array[7] == 137)
			{
				return true;
			}
		}
		while (true)
		{
			StackFrame frame = stackTrace_0.GetFrame(++int_3);
			if (frame == null)
			{
				break;
			}
			assembly = frame.GetMethod()?.DeclaringType?.Assembly;
			if ((object)assembly != null && (object)assembly == typeof(Class84).Assembly)
			{
				return true;
			}
		}
		return false;
	}

	private static void smethod_5(byte[] byte_2, int int_3, byte[] byte_3)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 128;
		int num4 = byte_3.Length;
		while (num < num4)
		{
			if ((num3 <<= 1) == 256)
			{
				num3 = 1;
				num2 = byte_2[int_3++];
			}
			if ((num2 & num3) != 0)
			{
				int num5 = (byte_2[int_3] >> 2) + 3;
				int num6 = ((byte_2[int_3] << 8) | byte_2[int_3 + 1]) & 0x3FF;
				int_3 += 2;
				int num7 = num - num6;
				if (num7 < 0)
				{
					break;
				}
				while (--num5 >= 0 && num < num4)
				{
					byte_3[num++] = byte_3[num7++];
				}
			}
			else
			{
				byte_3[num++] = byte_2[int_3++];
			}
		}
	}
}
