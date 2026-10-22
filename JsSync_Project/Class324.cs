using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal static class Class324
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 128)]
	private struct a1
	{
	}

	private static Class96 class96_0;

	[ThreadStatic]
	private static Stream stream_0;

	internal static a1 a1/* Not supported: data(DC E5 81 D9 B2 44 F2 61 A0 CC 56 86 01 11 E2 24 C8 2F D3 83 D1 EF 9E 4C 6D 5C 61 A0 C4 E7 0D 99 4B 70 9B 42 0A 54 70 7B 14 46 EF 9F 21 A0 66 DA BD A2 82 40 B5 2D 6C 9F B7 F1 5A D4 C8 72 15 DF DA 67 7F 13 58 AD B6 52 F9 9C 3D A2 CB C0 78 A5 39 B5 B3 E3 0C C4 9C C4 C3 93 1C 42 D8 63 91 99 01 74 86 C2 D3 A7 CA C4 3B 70 7F D7 AE 55 E9 03 0A 43 AF 84 E6 71 3A 01 63 31 66 6E 32 D5 8B 4D) */;

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static Class104 smethod_0()
	{
		if (class96_0 == null)
		{
			class96_0 = new Class96();
		}
		return new Class104(class96_0);
	}

	public static string smethod_1()
	{
		return Class84.smethod_0(-994273085);
	}

	public static Stream smethod_2()
	{
		if (stream_0 == null)
		{
			stream_0 = Class80.smethod_0(typeof(Class324).Assembly.GetManifestResourceStream("7b4ab831841943e2b3baf696c705eb8e"), new byte[128]
			{
				220, 229, 129, 217, 178, 68, 242, 97, 160, 204,
				86, 134, 1, 17, 226, 36, 200, 47, 211, 131,
				209, 239, 158, 76, 109, 92, 97, 160, 196, 231,
				13, 153, 75, 112, 155, 66, 10, 84, 112, 123,
				20, 70, 239, 159, 33, 160, 102, 218, 189, 162,
				130, 64, 181, 45, 108, 159, 183, 241, 90, 212,
				200, 114, 21, 223, 218, 103, 127, 19, 88, 173,
				182, 82, 249, 156, 61, 162, 203, 192, 120, 165,
				57, 181, 179, 227, 12, 196, 156, 196, 195, 147,
				28, 66, 216, 99, 145, 153, 1, 116, 134, 194,
				211, 167, 202, 196, 59, 112, 127, 215, 174, 85,
				233, 3, 10, 67, 175, 132, 230, 113, 58, 1,
				99, 49, 102, 110, 50, 213, 139, 77
			}, smethod_1());
		}
		return stream_0;
	}
}
