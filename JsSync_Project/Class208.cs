using System.Security.Cryptography;
using System.Text;

internal sealed class Class208
{
	public static string smethod_0(string string_0)
	{
		using MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString(Class84.smethod_0(-994092488)));
		}
		return stringBuilder.ToString();
	}
}
