using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class331
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		if (jsRequest_0.UserRequest.Protocol == 2500)
		{
			smethod_1(gclass4_0, gclass41_0, jsRequest_0);
		}
	}

	private static void smethod_1(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		Class223 @class = JsonConvert.DeserializeObject<Class223>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
		if (@class.Op == Class84.smethod_0(-994065733))
		{
			smethod_20(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065746))
		{
			smethod_21(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065697))
		{
			smethod_19(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065713))
		{
			smethod_18(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065679))
		{
			smethod_17(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065695))
		{
			smethod_16(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065645))
		{
			smethod_15(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065657))
		{
			smethod_14(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065623))
		{
			smethod_13(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065573))
		{
			smethod_12(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065585))
		{
			smethod_11(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065548))
		{
			smethod_10(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065511))
		{
			smethod_9(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065536))
		{
			smethod_8(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065493))
		{
			smethod_7(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065463))
		{
			smethod_6(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065411))
		{
			smethod_5(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065434))
		{
			smethod_4(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065408))
		{
			smethod_3(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
		else if (@class.Op == Class84.smethod_0(-994065366))
		{
			smethod_2(gclass4_0, gclass41_0, jsRequest_0, @class);
		}
	}

	private static void smethod_2(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<List<string>> list = new List<List<string>>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994065328), mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994065276));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_3(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string idDepartemen = class223_0.IdDepartemen;
			List<string> list = new List<string>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994065245) + idDepartemen + Class84.smethod_0(-994065061), mySqlConnection).ExecuteReader();
			if (mySqlDataReader.Read())
			{
				list.Add(mySqlDataReader[0].ToString());
				list.Add(mySqlDataReader[1].ToString());
			}
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994065019));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_4(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<List<string>> list = new List<List<string>>();
			mySqlCommand.CommandText = Class84.smethod_0(-994064936);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994064823));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_5(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string idDepartemen = class223_0.IdDepartemen;
			idDepartemen = idDepartemen.Replace(Class84.smethod_0(-994293038), string.Empty).Replace(Class84.smethod_0(-994267367), string.Empty).Replace(Class84.smethod_0(-994267375), string.Empty);
			List<List<string>> list = new List<List<string>>();
			string commandText = Class84.smethod_0(-994064788) + idDepartemen + Class84.smethod_0(-994064557) + class223_0.Nip + Class84.smethod_0(-994064486);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994064429));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_6(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string idDepartemen = class223_0.IdDepartemen;
			List<List<string>> list = new List<List<string>>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994064395) + idDepartemen + Class84.smethod_0(-994051996), mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994051921));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_7(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string idDepartemen = class223_0.IdDepartemen;
			idDepartemen = idDepartemen.Replace(Class84.smethod_0(-994293038), string.Empty).Replace(Class84.smethod_0(-994267367), string.Empty).Replace(Class84.smethod_0(-994267375), string.Empty);
			List<List<string>> list = new List<List<string>>();
			string commandText = Class84.smethod_0(-994051893) + idDepartemen + Class84.smethod_0(-994051695);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			List<List<string>> list2 = new List<List<string>>();
			commandText = Class84.smethod_0(-994051603) + idDepartemen + Class84.smethod_0(-994051413);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item2 = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString()
				};
				list2.Add(item2);
			}
			mySqlDataReader.Close();
			List<string> value = new List<string>
			{
				JsonConvert.SerializeObject(list),
				JsonConvert.SerializeObject(list2)
			};
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(value);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994051342));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_8(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string idDepartemen = class223_0.IdDepartemen;
			idDepartemen = idDepartemen.Replace(Class84.smethod_0(-994293038), string.Empty).Replace(Class84.smethod_0(-994267367), string.Empty).Replace(Class84.smethod_0(-994267375), string.Empty);
			List<List<string>> list = new List<List<string>>();
			string text = string.Empty;
			string commandText = Class84.smethod_0(-994051893) + idDepartemen + Class84.smethod_0(-994051695);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString()
				};
				list.Add(item);
				if (!text.Equals(string.Empty))
				{
					text += Class84.smethod_0(-994279022);
				}
				text += mySqlDataReader[1];
			}
			mySqlDataReader.Close();
			List<List<string>> list2 = new List<List<string>>();
			if (!text.Equals(string.Empty))
			{
				commandText = Class84.smethod_0(-994051318) + text + Class84.smethod_0(-994051105);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					List<string> item2 = new List<string>
					{
						mySqlDataReader[0].ToString(),
						mySqlDataReader[1].ToString(),
						mySqlDataReader[2].ToString()
					};
					list2.Add(item2);
				}
				mySqlDataReader.Close();
			}
			List<string> value = new List<string>
			{
				JsonConvert.SerializeObject(list),
				JsonConvert.SerializeObject(list2)
			};
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(value);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994051026));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_9(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string idDepartemen = class223_0.IdDepartemen;
			string text = string.Empty;
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string commandText = Class84.smethod_0(-994311244) + idDepartemen;
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				text = mySqlDataReader[0].ToString();
			}
			mySqlDataReader.Close();
			if (text.Equals(string.Empty))
			{
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.MessageCode = 0;
				jsRequest_0.Message = Class84.smethod_0(-994051005);
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			List<List<string>> list = new List<List<string>>();
			commandText = Class84.smethod_0(-994050919) + Class348.Class352.string_0 + Class84.smethod_0(-994050906) + text + Class84.smethod_0(-994050626) + class223_0.Filter + Class84.smethod_0(-994050616) + class223_0.Keyword + Class84.smethod_0(-994050617);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString(),
					mySqlDataReader[3].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994050467));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_10(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994050435) + jsRequest_0.UserRequest.SchoolId + Class84.smethod_0(-994050461) + class223_0.Nic + Class84.smethod_0(-994271698), mySqlConnection).ExecuteReader();
			if (!mySqlDataReader.Read())
			{
				mySqlDataReader.Close();
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.MessageCode = 0;
				jsRequest_0.Message = Class84.smethod_0(-994053965);
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			string text;
			if (!Convert.IsDBNull(mySqlDataReader[Class84.smethod_0(-994205227)]))
			{
				byte[] array = (byte[])mySqlDataReader[Class84.smethod_0(-994205227)];
				text = ((array.Length == 0) ? GClass18.smethod_18(Class309.smethod_44()) : Convert.ToBase64String(array));
			}
			else
			{
				text = GClass18.smethod_18(Class309.smethod_44());
			}
			string fotoMd = Class208.smethod_0(text);
			Class302 value = new Class302
			{
				JibasId = mySqlDataReader[Class84.smethod_0(-994264135)].ToString(),
				Nis = class223_0.Nic,
				Nisn = mySqlDataReader[Class84.smethod_0(-994053942)].ToString(),
				Nik = mySqlDataReader[Class84.smethod_0(-994053947)].ToString(),
				Nama = mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
				Foto = text,
				FotoMd5 = fotoMd,
				Panggilan = mySqlDataReader[Class84.smethod_0(-994053889)].ToString(),
				Agama = mySqlDataReader[Class84.smethod_0(-994053905)].ToString(),
				IdKelas = mySqlDataReader[Class84.smethod_0(-994268163)].ToString(),
				Kelas = mySqlDataReader[Class84.smethod_0(-994268131)].ToString(),
				IdTingkat = mySqlDataReader[Class84.smethod_0(-994053861)].ToString(),
				Tingkat = mySqlDataReader[Class84.smethod_0(-994264067)].ToString(),
				IdAngkatan = mySqlDataReader[Class84.smethod_0(-994187348)].ToString(),
				Angkatan = mySqlDataReader[Class84.smethod_0(-994187299)].ToString(),
				IdDepartemen = mySqlDataReader[Class84.smethod_0(-994205248)].ToString(),
				Departemen = mySqlDataReader[Class84.smethod_0(-994273283)].ToString(),
				TempatLahir = mySqlDataReader[Class84.smethod_0(-994053878)].ToString(),
				TanggalLahir = mySqlDataReader[Class84.smethod_0(-994053831)].ToString(),
				AlamatSiswa = mySqlDataReader[Class84.smethod_0(-994053848)].ToString(),
				EmailSiswa = mySqlDataReader[Class84.smethod_0(-994053798)].ToString(),
				HpSiswa = mySqlDataReader[Class84.smethod_0(-994053813)].ToString(),
				NamaAyah = mySqlDataReader[Class84.smethod_0(-994053767)].ToString(),
				NamaIbu = mySqlDataReader[Class84.smethod_0(-994053784)].ToString(),
				HpOrtu1 = mySqlDataReader[Class84.smethod_0(-994053786)].ToString(),
				HpOrtu2 = mySqlDataReader[Class84.smethod_0(-994053740)].ToString(),
				HpOrtu3 = mySqlDataReader[Class84.smethod_0(-994053758)].ToString(),
				AlamatOrtu = mySqlDataReader[Class84.smethod_0(-994053712)].ToString(),
				Kelamin = mySqlDataReader[Class84.smethod_0(-994053727)].ToString()
			};
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(value);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994053665));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994053690));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_11(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<List<string>> list = new List<List<string>>();
			string commandText = Class84.smethod_0(-994050919) + Class348.Class352.string_0 + Class84.smethod_0(-994053660) + class223_0.IdKelompok + Class84.smethod_0(-994053470);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString(),
					mySqlDataReader[3].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994053363));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_12(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<List<string>> list = new List<List<string>>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994053333) + class223_0.IdProses + Class84.smethod_0(-994053156), mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994053148));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_13(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string idDepartemen = class223_0.IdDepartemen;
			string text = string.Empty;
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string commandText = Class84.smethod_0(-994053060) + idDepartemen;
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				text = mySqlDataReader[0].ToString();
			}
			mySqlDataReader.Close();
			if (text.Equals(string.Empty))
			{
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.MessageCode = 0;
				jsRequest_0.Message = Class84.smethod_0(-994051005);
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			List<List<string>> list = new List<List<string>>();
			commandText = Class84.smethod_0(-994052931) + text + Class84.smethod_0(-994052822);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994052707));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_14(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994050435) + jsRequest_0.UserRequest.SchoolId + Class84.smethod_0(-994052685) + class223_0.Nip + Class84.smethod_0(-994271698), mySqlConnection).ExecuteReader();
			if (!mySqlDataReader.Read())
			{
				mySqlDataReader.Close();
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.MessageCode = 0;
				jsRequest_0.Message = Class84.smethod_0(-994052388);
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			string text;
			if (!Convert.IsDBNull(mySqlDataReader[Class84.smethod_0(-994205227)]))
			{
				byte[] array = (byte[])mySqlDataReader[Class84.smethod_0(-994205227)];
				text = ((array.Length == 0) ? GClass18.smethod_18(Class309.smethod_44()) : Convert.ToBase64String(array));
			}
			else
			{
				text = GClass18.smethod_18(Class309.smethod_44());
			}
			string fotoMd = Class208.smethod_0(text);
			Class358 value = new Class358
			{
				JibasId = mySqlDataReader[Class84.smethod_0(-994264135)].ToString(),
				Nip = class223_0.Nip,
				Nama = mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
				Foto = text,
				FotoMd5 = fotoMd,
				Panggilan = mySqlDataReader[Class84.smethod_0(-994053889)].ToString(),
				Agama = mySqlDataReader[Class84.smethod_0(-994053905)].ToString(),
				Bagian = mySqlDataReader[Class84.smethod_0(-994052353)].ToString(),
				TempatLahir = mySqlDataReader[Class84.smethod_0(-994053878)].ToString(),
				TanggalLahir = mySqlDataReader[Class84.smethod_0(-994053831)].ToString(),
				Alamat = mySqlDataReader[Class84.smethod_0(-994052372)].ToString(),
				Email = mySqlDataReader[Class84.smethod_0(-994052327)].ToString(),
				Hp = mySqlDataReader[Class84.smethod_0(-994263550)].ToString(),
				Kelamin = mySqlDataReader[Class84.smethod_0(-994053727)].ToString()
			};
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(value);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994052331));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994052296));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_15(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<List<string>> list = new List<List<string>>();
			string text = Class84.smethod_0(-994052318) + Class348.Class352.string_0 + Class84.smethod_0(-994052239) + class223_0.Filter + Class84.smethod_0(-994050616) + class223_0.Keyword + Class84.smethod_0(-994052115);
			if (!class223_0.Bagian.Equals(Class84.smethod_0(-994248828)))
			{
				text = text + Class84.smethod_0(-994056152) + class223_0.Bagian + Class84.smethod_0(-994271698);
			}
			text += Class84.smethod_0(-994056112);
			mySqlCommand.CommandText = text;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString(),
					mySqlDataReader[3].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994056121));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_16(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<List<string>> list = new List<List<string>>();
			string text = Class84.smethod_0(-994052318) + Class348.Class352.string_0 + Class84.smethod_0(-994056093);
			if (!class223_0.Bagian.Equals(Class84.smethod_0(-994248828)))
			{
				text = text + Class84.smethod_0(-994056152) + class223_0.Bagian + Class84.smethod_0(-994271698);
			}
			text += Class84.smethod_0(-994056112);
			mySqlCommand.CommandText = text;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString(),
					mySqlDataReader[3].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994055927));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_17(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994050435) + jsRequest_0.UserRequest.SchoolId + Class84.smethod_0(-994055885) + class223_0.Nis + Class84.smethod_0(-994271698), mySqlConnection).ExecuteReader();
			if (!mySqlDataReader.Read())
			{
				mySqlDataReader.Close();
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.MessageCode = 0;
				jsRequest_0.Message = Class84.smethod_0(-994055343);
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			string text;
			if (!Convert.IsDBNull(mySqlDataReader[Class84.smethod_0(-994205227)]))
			{
				byte[] array = (byte[])mySqlDataReader[Class84.smethod_0(-994205227)];
				text = ((array.Length == 0) ? GClass18.smethod_18(Class309.smethod_44()) : Convert.ToBase64String(array));
			}
			else
			{
				text = GClass18.smethod_18(Class309.smethod_44());
			}
			string fotoMd = Class208.smethod_0(text);
			Class302 value = new Class302
			{
				JibasId = mySqlDataReader[Class84.smethod_0(-994264135)].ToString(),
				Nis = class223_0.Nis,
				Nisn = mySqlDataReader[Class84.smethod_0(-994053942)].ToString(),
				Nik = mySqlDataReader[Class84.smethod_0(-994053947)].ToString(),
				Nama = mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
				Foto = text,
				FotoMd5 = fotoMd,
				Panggilan = mySqlDataReader[Class84.smethod_0(-994053889)].ToString(),
				Agama = mySqlDataReader[Class84.smethod_0(-994053905)].ToString(),
				IdKelas = mySqlDataReader[Class84.smethod_0(-994277103)].ToString(),
				Kelas = mySqlDataReader[Class84.smethod_0(-994277105)].ToString(),
				IdTingkat = mySqlDataReader[Class84.smethod_0(-994268361)].ToString(),
				Tingkat = mySqlDataReader[Class84.smethod_0(-994264701)].ToString(),
				IdAngkatan = mySqlDataReader[Class84.smethod_0(-994187348)].ToString(),
				Angkatan = mySqlDataReader[Class84.smethod_0(-994187299)].ToString(),
				IdDepartemen = mySqlDataReader[Class84.smethod_0(-994205248)].ToString(),
				Departemen = mySqlDataReader[Class84.smethod_0(-994273283)].ToString(),
				TempatLahir = mySqlDataReader[Class84.smethod_0(-994053878)].ToString(),
				TanggalLahir = mySqlDataReader[Class84.smethod_0(-994053831)].ToString(),
				AlamatSiswa = mySqlDataReader[Class84.smethod_0(-994053848)].ToString(),
				EmailSiswa = mySqlDataReader[Class84.smethod_0(-994053798)].ToString(),
				HpSiswa = mySqlDataReader[Class84.smethod_0(-994053813)].ToString(),
				NamaAyah = mySqlDataReader[Class84.smethod_0(-994053767)].ToString(),
				NamaIbu = mySqlDataReader[Class84.smethod_0(-994053784)].ToString(),
				HpOrtu1 = mySqlDataReader[Class84.smethod_0(-994053786)].ToString(),
				HpOrtu2 = mySqlDataReader[Class84.smethod_0(-994053740)].ToString(),
				HpOrtu3 = mySqlDataReader[Class84.smethod_0(-994053758)].ToString(),
				AlamatOrtu = mySqlDataReader[Class84.smethod_0(-994053712)].ToString(),
				Kelamin = mySqlDataReader[Class84.smethod_0(-994053727)].ToString()
			};
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(value);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994055310));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994055325));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_18(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string idDepartemen = class223_0.IdDepartemen;
			string text = string.Empty;
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string commandText = Class84.smethod_0(-994311244) + idDepartemen;
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				text = mySqlDataReader[0].ToString();
			}
			mySqlDataReader.Close();
			if (text.Equals(string.Empty))
			{
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.MessageCode = 0;
				jsRequest_0.Message = Class84.smethod_0(-994051005);
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			List<List<string>> list = new List<List<string>>();
			commandText = Class84.smethod_0(-994055285) + Class348.Class352.string_0 + Class84.smethod_0(-994055207) + text + Class84.smethod_0(-994050626) + class223_0.Filter + Class84.smethod_0(-994050616) + class223_0.Keyword + Class84.smethod_0(-994055030);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString(),
					mySqlDataReader[3].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994054914));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_19(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<List<string>> list = new List<List<string>>();
			string commandText = Class84.smethod_0(-994055285) + Class348.Class352.string_0 + Class84.smethod_0(-994054888) + class223_0.IdKelas + Class84.smethod_0(-994054731);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString(),
					mySqlDataReader[3].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994054626));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_20(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string idDepartemen = class223_0.IdDepartemen;
			string text = string.Empty;
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string commandText = Class84.smethod_0(-994311244) + idDepartemen;
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				text = mySqlDataReader[0].ToString();
			}
			mySqlDataReader.Close();
			if (text.Equals(string.Empty))
			{
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.MessageCode = 0;
				jsRequest_0.Message = Class84.smethod_0(-994051005);
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			List<List<string>> list = new List<List<string>>();
			commandText = Class84.smethod_0(-994054650) + text + Class84.smethod_0(-994054531);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994054509));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static void smethod_21(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, Class223 class223_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string idTingkat = class223_0.IdTingkat;
			List<List<string>> list = new List<List<string>>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994054466) + idTingkat + Class84.smethod_0(-994054315), mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994054226));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}
}
