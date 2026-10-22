using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class244
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			int int_ = Convert.ToInt32(jsRequest_0.UserRequest.RequestDataKey);
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_4(jsRequest_0.UserRequest.RequestData, int_));
			string text = list[0];
			_ = list[1];
			if (text.Equals(Class84.smethod_0(-994200304)))
			{
				Class348.Class352.smethod_4();
				if (Class348.Class352.smethod_2())
				{
					gclass4_0.method_5(GEnum0.Warn, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994200317));
					jsRequest_0.Data = string.Empty;
					jsRequest_0.Message = Class84.smethod_0(-994200317);
					jsRequest_0.ServerStatus = 1;
					jsRequest_0.ExecCode = 0;
					jsRequest_0.UserRequest.Inflate();
					gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				}
				else if (!Class348.Class352.smethod_0())
				{
					gclass4_0.method_5(GEnum0.Warn, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994200204));
					jsRequest_0.Data = string.Empty;
					jsRequest_0.Message = Class84.smethod_0(-994200204);
					jsRequest_0.ServerStatus = 1;
					jsRequest_0.ExecCode = 0;
					jsRequest_0.UserRequest.Inflate();
					gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				}
				else
				{
					jsRequest_0.Data = string.Empty;
					jsRequest_0.Message = Class84.smethod_0(-994200137);
					jsRequest_0.ServerStatus = 1;
					jsRequest_0.ExecCode = 1;
					jsRequest_0.UserRequest.Inflate();
					gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				}
			}
		}
		catch (Exception ex)
		{
			jsRequest_0.Data = string.Empty;
			jsRequest_0.ServerStatus = -1;
			jsRequest_0.ExecCode = -1;
			jsRequest_0.Message = Class309.smethod_73() + ex.Message;
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
	}
}
