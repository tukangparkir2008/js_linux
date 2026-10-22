using System.Runtime.InteropServices;
using System.Text;

[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
internal static class Class86
{
	internal static StringBuilder smethod_0(StringBuilder stringBuilder_0, string string_0, int int_0)
	{
		return stringBuilder_0.Append(string_0, int_0, string_0.Length - int_0);
	}
}
