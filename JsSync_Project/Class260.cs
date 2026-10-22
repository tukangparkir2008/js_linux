using Newtonsoft.Json;

internal sealed class Class260
{
	public string Token;

	public string Nomor;

	public string Jumlah;

	public string Protocol;

	public string Message;

	public string Data1;

	public string Data2;

	public string Data3;

	public string Action;

	public string Counter;

	public static Class260 smethod_0(string string_0)
	{
		return JsonConvert.DeserializeObject<Class260>(string_0);
	}
}
