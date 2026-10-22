using Newtonsoft.Json;

internal sealed class Class270
{
	public string SchoolId;

	public string JibasId;

	public string Op;

	public string TransactionId;

	public string Nomor;

	public string Jenis;

	public string Jumlah;

	public string NomorTs;

	public string Desc;

	public string Info;

	public string Data;

	public string ServiceFee;

	public string JsSchoolGwAddr;

	public string JsSchoolGwPort;

	public string UserId;

	public string UserName;

	public string UserCol;

	public string Dept;

	public string IdDept;

	public string DevInfo;

	public string Extra1;

	public string Extra2;

	public string Extra3;

	public string JsUserId;

	public string JsUserName;

	public string JsDevId;

	public string JsDevName;

	public string IdBank;

	public string JsUserPhone;

	public string JsUserEmail;

	public static Class270 smethod_0(string string_0)
	{
		return JsonConvert.DeserializeObject<Class270>(string_0);
	}
}
