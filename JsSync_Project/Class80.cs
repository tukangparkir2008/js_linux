using System;
using System.IO;

internal static class Class80
{
	private static readonly Class117 class117_0 = Class117.smethod_18(65537uL);

	private static readonly Class5 class5_0 = new Class5();

	public static Stream smethod_0(Stream stream_0, byte[] byte_0, string string_0)
	{
		byte[] array = Convert.FromBase64String(string_0);
		byte[] array2 = new byte[byte_0.Length + array.Length];
		Buffer.BlockCopy(byte_0, 0, array2, 0, byte_0.Length);
		Buffer.BlockCopy(array, 0, array2, byte_0.Length, array.Length);
		Class117 class117_ = new Class117(1, array2);
		Class45 class45_ = new Class45(bool_1: false, class117_, class117_0);
		Class74 @class = new Class74(new Class101(bool_3: false, class45_));
		Class46 class2 = new Class46();
		class2.method_1(@class.imethod_1());
		Class46 class46_ = class2;
		return new Stream0(new Stream1(stream_0, @class), class46_, class5_0);
	}
}
