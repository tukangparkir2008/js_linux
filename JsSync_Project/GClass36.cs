using System.Text;

public sealed class GClass36
{
	public static string smethod_0(string string_0, string string_1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < string_0.Length; i++)
		{
			stringBuilder.Append((char)(string_0[i] ^ string_1[i % string_1.Length]));
		}
		return stringBuilder.ToString();
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0)
	{
		byte[] array = new byte[byte_0.Length];
		for (int i = 0; i < byte_0.Length; i++)
		{
			array[i] = (byte)(byte_0[i] ^ string_0[i % string_0.Length]);
		}
		return array;
	}
}
