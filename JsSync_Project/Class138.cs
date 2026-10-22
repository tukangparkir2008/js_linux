using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

internal sealed class Class138
{
	private static CookieContainer cookieContainer_0;

	public static CookieContainer smethod_0()
	{
		if (cookieContainer_0 == null)
		{
			cookieContainer_0 = new CookieContainer();
		}
		return cookieContainer_0;
	}

	public static GClass70 smethod_1(string string_0)
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class293
			{
				SchoolId = Class348.Class352.string_0,
				Op = Class84.smethod_0(-994201225),
				Data = string_0
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_18(), Class84.smethod_0(-994265316), data);
				return GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class84.smethod_0(-994201197) + ex.Message, string.Empty);
		}
	}

	public static GClass70 smethod_2(string string_0)
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class293
			{
				SchoolId = Class348.Class352.string_0,
				Op = Class84.smethod_0(-994201168),
				Data = string_0
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_18(), Class84.smethod_0(-994265316), data);
				return GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class84.smethod_0(-994201197) + ex.Message, string.Empty);
		}
	}

	public static GClass70 smethod_3()
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class293
			{
				SchoolId = Class348.Class352.string_0,
				Op = Class84.smethod_0(-994201136)
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_18(), Class84.smethod_0(-994265316), data);
				return GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class84.smethod_0(-994201197) + ex.Message, string.Empty);
		}
	}

	public static GClass70 smethod_4()
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class293
			{
				Op = Class84.smethod_0(-994305103),
				SchoolId = Class348.Class352.string_0
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_18(), Class84.smethod_0(-994265316), data);
				string string_ = Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString();
				Class313.smethod_2(Class84.smethod_0(-994201094), string_);
				GClass70 gClass = GClass70.smethod_1(string_);
				if (gClass.Value == 1)
				{
					Class265 class2 = JsonConvert.DeserializeObject<Class265>(gClass.Data.ToString());
					if (class2.Available && class2.Code == 1)
					{
						if (class2.Aktif)
						{
							List<string> value2 = new List<string>
							{
								Class348.Class352.string_0,
								class2.DatabaseId,
								Class249.Class252.smethod_3()
							};
							return new GClass70(1, Class84.smethod_0(-994201117), JsonConvert.SerializeObject(value2));
						}
						return new GClass70(-1, Class84.smethod_0(-994201029), string.Empty);
					}
					return new GClass70(-1, Class84.smethod_0(-994201015) + class2.Message, string.Empty);
				}
				return new GClass70(-1, Class84.smethod_0(-994201017), string.Empty);
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class84.smethod_0(-994201197) + ex.Message, string.Empty);
		}
	}
}
