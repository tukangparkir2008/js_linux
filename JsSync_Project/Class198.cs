using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

internal sealed class Class198 : Class197
{
	private sealed class Class128
	{
		public Uri uri_0;

		public Class198 class198_0;

		internal void method_0(object object_0)
		{
			try
			{
				Uri address = new Uri(string.Format(Class84.smethod_0(-994293344), uri_0.Segments[2]));
				WebClient webClient = new WebClient();
				webClient.Encoding = Encoding.UTF8;
				webClient.DownloadStringCompleted += class198_0.method_240;
				webClient.DownloadStringAsync(address);
			}
			catch (Exception exception_)
			{
				class198_0.method_186().method_72(GEnum7.Iframe, Class84.smethod_0(-994293279) + uri_0, exception_);
				class198_0.method_186().method_71(bool_6: false);
			}
		}
	}

	private sealed class Class129
	{
		public Uri uri_0;

		public Class198 class198_0;

		internal void method_0(object object_0)
		{
			try
			{
				Uri address = new Uri(string.Format(Class84.smethod_0(-994293190), uri_0.Segments[2]));
				WebClient webClient = new WebClient();
				webClient.Encoding = Encoding.UTF8;
				webClient.DownloadStringCompleted += class198_0.method_242;
				webClient.DownloadStringAsync(address);
			}
			catch (Exception exception_)
			{
				class198_0.bool_3 = true;
				class198_0.method_248();
				class198_0.method_186().method_72(GEnum7.Iframe, Class84.smethod_0(-994293161) + uri_0, exception_);
				class198_0.method_186().method_71(bool_6: false);
			}
		}
	}

	private readonly Class246 class246_0;

	private readonly bool bool_2;

	private string string_67;

	private string string_68;

	private string string_69;

	private Class214 class214_1;

	private bool bool_3;

	public Class198(Class197 class197_2, Class343 class343_1)
		: base(class197_2, class343_1)
	{
		class246_0 = new Class246(this);
		method_203().Add(class246_0);
		if (Uri.TryCreate(method_217(Class84.smethod_0(-994293138)), UriKind.Absolute, out var result))
		{
			if (result.Host.IndexOf(Class84.smethod_0(-994293096), StringComparison.InvariantCultureIgnoreCase) > -1)
			{
				bool_2 = true;
				method_239(result);
			}
			else if (result.Host.IndexOf(Class84.smethod_0(-994293110), StringComparison.InvariantCultureIgnoreCase) > -1)
			{
				bool_2 = true;
				method_241(result);
			}
		}
		if (!bool_2)
		{
			method_248();
		}
	}

	[SpecialName]
	public override bool vmethod_4()
	{
		return true;
	}

	[SpecialName]
	public override string vmethod_6()
	{
		return string_69 ?? method_217(Class84.smethod_0(-994293138));
	}

	public bool method_238()
	{
		return bool_2;
	}

	public override void Dispose()
	{
		if (class214_1 != null)
		{
			class214_1.Dispose();
		}
		base.Dispose();
	}

	private void method_239(Uri uri_0)
	{
		ThreadPool.QueueUserWorkItem(new Class128
		{
			uri_0 = uri_0,
			class198_0 = this
		}.method_0);
	}

	private void method_240(object sender, DownloadStringCompletedEventArgs e)
	{
		try
		{
			if (!e.Cancelled)
			{
				if (e.Error == null)
				{
					int num = e.Result.IndexOf(Class84.smethod_0(-994293062), StringComparison.Ordinal);
					if (num > -1)
					{
						num = e.Result.IndexOf(Class84.smethod_0(-994293074), num);
						if (num > -1)
						{
							num = e.Result.IndexOf('"', num + 4);
							if (num > -1)
							{
								int num2 = e.Result.IndexOf('"', num + 1);
								while (e.Result[num2 - 1] == '\\')
								{
									num2 = e.Result.IndexOf('"', num2 + 1);
								}
								if (num2 > -1)
								{
									string_67 = e.Result.Substring(num + 1, num2 - num - 1).Replace(Class84.smethod_0(-994293031), Class84.smethod_0(-994293038));
								}
							}
						}
					}
					num = e.Result.IndexOf(Class84.smethod_0(-994293046), StringComparison.Ordinal);
					if (num > -1)
					{
						int num3 = e.Result.IndexOf(Class84.smethod_0(-994293006), num);
						if (num3 > -1)
						{
							if (string.IsNullOrEmpty(method_60()))
							{
								method_61(Class84.smethod_0(-994293022));
							}
							if (string.IsNullOrEmpty(method_64()))
							{
								method_65(Class84.smethod_0(-994292962));
							}
						}
						else
						{
							num3 = e.Result.IndexOf(Class84.smethod_0(-994292982), num);
							if (num3 > -1)
							{
								if (string.IsNullOrEmpty(method_60()))
								{
									method_61(Class84.smethod_0(-994292962));
								}
								if (string.IsNullOrEmpty(method_64()))
								{
									method_65(Class84.smethod_0(-994292934));
								}
							}
							else
							{
								num3 = e.Result.IndexOf(Class84.smethod_0(-994292938), num);
								if (num3 > -1)
								{
									if (string.IsNullOrEmpty(method_60()))
									{
										method_61(Class84.smethod_0(-994292954));
									}
									if (string.IsNullOrEmpty(method_64()))
									{
										method_65(Class84.smethod_0(-994292910));
									}
								}
								else
								{
									num3 = e.Result.IndexOf(Class84.smethod_0(-994292914), num);
									if (string.IsNullOrEmpty(method_60()))
									{
										method_61(Class84.smethod_0(-994292868));
									}
									if (string.IsNullOrEmpty(method_64()))
									{
										method_65(Class84.smethod_0(-994292888));
									}
								}
							}
						}
						num3 = e.Result.LastIndexOf(Class84.smethod_0(-994292893), num3, StringComparison.Ordinal);
						if (num3 > -1)
						{
							int num4 = e.Result.IndexOf('"', num3);
							if (num4 > -1)
							{
								string_68 = e.Result.Substring(num3, num4 - num3).Replace(Class84.smethod_0(-994293031), Class84.smethod_0(-994293038)).Replace(Class84.smethod_0(-994292833), string.Empty);
							}
						}
					}
					num = e.Result.IndexOf(Class84.smethod_0(-994292841), StringComparison.Ordinal);
					if (num > -1)
					{
						num = e.Result.IndexOf(Class84.smethod_0(-994292893), num);
						if (num > -1)
						{
							int num5 = e.Result.IndexOf('"', num);
							if (num5 > -1)
							{
								string_69 = e.Result.Substring(num, num5 - num).Replace(Class84.smethod_0(-994293031), Class84.smethod_0(-994293038)).Replace(Class84.smethod_0(-994292833), string.Empty);
							}
						}
					}
				}
				else
				{
					method_243(e.Error, Class84.smethod_0(-994292860));
				}
			}
		}
		catch (Exception exception_)
		{
			method_186().method_72(GEnum7.Iframe, Class84.smethod_0(-994292814), exception_);
		}
		method_244(sender);
	}

	private void method_241(Uri uri_0)
	{
		ThreadPool.QueueUserWorkItem(new Class129
		{
			uri_0 = uri_0,
			class198_0 = this
		}.method_0);
	}

	private void method_242(object sender, DownloadStringCompletedEventArgs e)
	{
		try
		{
			if (!e.Cancelled)
			{
				if (e.Error == null)
				{
					int num = e.Result.IndexOf(Class84.smethod_0(-994292785), StringComparison.Ordinal);
					if (num > -1)
					{
						num = e.Result.IndexOf('"', num + 7);
						if (num > -1)
						{
							int num2 = e.Result.IndexOf('"', num + 1);
							while (e.Result[num2 - 1] == '\\')
							{
								num2 = e.Result.IndexOf('"', num2 + 1);
							}
							if (num2 > -1)
							{
								string_67 = e.Result.Substring(num + 1, num2 - num - 1).Replace(Class84.smethod_0(-994293031), Class84.smethod_0(-994293038));
							}
						}
					}
					num = e.Result.IndexOf(Class84.smethod_0(-994292739), StringComparison.Ordinal);
					if (num > -1)
					{
						if (string.IsNullOrEmpty(method_60()))
						{
							method_61(Class84.smethod_0(-994292763));
						}
						if (string.IsNullOrEmpty(method_64()))
						{
							method_65(Class84.smethod_0(-994292705));
						}
					}
					else
					{
						num = e.Result.IndexOf(Class84.smethod_0(-994292727), num);
						if (num > -1)
						{
							if (string.IsNullOrEmpty(method_60()))
							{
								method_61(Class84.smethod_0(-994292688));
							}
							if (string.IsNullOrEmpty(method_64()))
							{
								method_65(Class84.smethod_0(-994292694));
							}
						}
						else
						{
							num = e.Result.IndexOf(Class84.smethod_0(-994292700), num);
							if (string.IsNullOrEmpty(method_60()))
							{
								method_61(Class84.smethod_0(-994292662));
							}
							if (string.IsNullOrEmpty(method_64()))
							{
								method_65(Class84.smethod_0(-994292668));
							}
						}
					}
					if (num > -1)
					{
						num = e.Result.IndexOf(Class84.smethod_0(-994292893), num);
						if (num > -1)
						{
							int num3 = e.Result.IndexOf('"', num);
							if (num3 > -1)
							{
								string_68 = e.Result.Substring(num, num3 - num).Replace(Class84.smethod_0(-994293031), Class84.smethod_0(-994293038)).Replace(Class84.smethod_0(-994292833), string.Empty);
							}
						}
					}
					num = e.Result.IndexOf(Class84.smethod_0(-994292611), StringComparison.Ordinal);
					if (num > -1)
					{
						num = e.Result.IndexOf(Class84.smethod_0(-994292893), num);
						if (num > -1)
						{
							int num4 = e.Result.IndexOf('"', num);
							if (num4 > -1)
							{
								string_69 = e.Result.Substring(num, num4 - num).Replace(Class84.smethod_0(-994293031), Class84.smethod_0(-994293038)).Replace(Class84.smethod_0(-994292833), string.Empty);
							}
						}
					}
				}
				else
				{
					method_243(e.Error, Class84.smethod_0(-994292631));
				}
			}
		}
		catch (Exception exception_)
		{
			method_186().method_72(GEnum7.Iframe, Class84.smethod_0(-994292635), exception_);
		}
		method_244(sender);
	}

	private void method_243(Exception exception_0, string string_70)
	{
		HttpWebResponse httpWebResponse = ((exception_0 is WebException ex) ? (ex.Response as HttpWebResponse) : null);
		if (httpWebResponse != null && httpWebResponse.StatusCode == HttpStatusCode.NotFound)
		{
			string_67 = Class84.smethod_0(-994292560);
		}
		else
		{
			method_186().method_72(GEnum7.Iframe, Class84.smethod_0(-994292484) + string_70 + Class84.smethod_0(-994292510), exception_0);
		}
	}

	private void method_244(object object_0)
	{
		try
		{
			if (string_68 == null)
			{
				bool_3 = true;
				method_248();
			}
			WebClient webClient = (WebClient)object_0;
			webClient.DownloadStringCompleted -= method_240;
			webClient.DownloadStringCompleted -= method_242;
			webClient.Dispose();
			method_186().method_71(method_250());
		}
		catch
		{
		}
	}

	protected override void vmethod_9(GClass14 gclass14_0)
	{
		if (string_68 != null && class214_1 == null)
		{
			class214_1 = new Class214(method_186(), method_249);
			class214_1.method_2(string_68, (method_195() != null) ? method_195().method_1() : null);
		}
		GStruct1 gstruct1_ = Class299.smethod_5(method_202(), default);
		GStruct2 gstruct2_ = ((method_186() == null || vmethod_5()) ? GStruct2.gstruct2_0 : method_186().method_27());
		gstruct1_.method_24(gstruct2_);
		bool flag = Class328.smethod_1(gclass14_0, this);
		method_230(gclass14_0, gstruct1_, bool_2: true, bool_3: true);
		Class259.smethod_0(gclass14_0, this, gstruct1_, bool_0: true, bool_1: true);
		GStruct1 gStruct = method_203()[0].method_1();
		gStruct.method_24(gstruct2_);
		gStruct.method_11(gStruct.method_10() - (method_157() + method_159() + method_147() + method_149()));
		gStruct.method_7(gStruct.method_6() + (method_157() + method_147()));
		gStruct.method_5(Math.Floor(gStruct.method_4()));
		gStruct.method_7(Math.Floor(gStruct.method_6()));
		GStruct1 gstruct1_2 = gStruct;
		method_245(gclass14_0, gstruct2_, gstruct1_2);
		method_246(gclass14_0, gstruct1_2);
		method_247(gclass14_0, gstruct1_2);
		if (flag)
		{
			gclass14_0.vmethod_0();
		}
	}

	private void method_245(GClass14 gclass14_0, GStruct2 gstruct2_1, GStruct1 gstruct1_0)
	{
		if (class246_0.vmethod_2() != null)
		{
			if (gstruct1_0.method_8() > 0.0 && gstruct1_0.method_10() > 0.0)
			{
				if (class246_0.method_26() == GStruct1.gstruct1_0)
				{
					gclass14_0.vmethod_14(class246_0.vmethod_2(), gstruct1_0);
				}
				else
				{
					gclass14_0.vmethod_13(class246_0.vmethod_2(), gstruct1_0, class246_0.method_26());
				}
				if (class246_0.method_19())
				{
					gclass14_0.vmethod_12(method_237(gclass14_0, bool_2: true), class246_0.method_3() + gstruct2_1.method_1(), class246_0.method_5() + gstruct2_1.method_3(), class246_0.method_7() + 2.0, Class277.smethod_15(class246_0).method_4());
				}
			}
		}
		else if (bool_2 && !bool_3)
		{
			Class328.smethod_2(gclass14_0, method_186(), gstruct1_0);
			if (gstruct1_0.method_8() > 19.0 && gstruct1_0.method_10() > 19.0)
			{
				gclass14_0.vmethod_11(gclass14_0.method_0(GStruct3.smethod_4()), gstruct1_0.method_4(), gstruct1_0.method_6(), gstruct1_0.method_8(), gstruct1_0.method_10());
			}
		}
	}

	private void method_246(GClass14 gclass14_0, GStruct1 gstruct1_0)
	{
		if (string_67 != null && class246_0.method_7() > 40.0 && class246_0.method_11() > 40.0)
		{
			GClass62 gClass = method_186().method_0().method_10(Class84.smethod_0(-994273712), 9.0, (GEnum14)0);
			gclass14_0.vmethod_12(gclass14_0.method_1(GStruct3.smethod_5(160, 0, 0, 0)), gstruct1_0.method_12(), gstruct1_0.method_13(), gstruct1_0.method_8(), method_176().vmethod_1() + 7.0);
			GStruct1 gStruct = new GStruct1(gstruct1_0.method_12() + 3.0, gstruct1_0.method_13() + 3.0, gstruct1_0.method_8() - 6.0, gstruct1_0.method_10() - 6.0);
			gclass14_0.vmethod_9(string_67, gClass, GStruct3.smethod_3(), gStruct.method_0(), GStruct4.gstruct4_0, bool_0: false);
		}
	}

	private void method_247(GClass14 gclass14_0, GStruct1 gstruct1_0)
	{
		if (bool_2 && class246_0.method_7() > 70.0 && class246_0.method_11() > 50.0)
		{
			object object_ = gclass14_0.vmethod_3();
			GStruct4 gStruct = new GStruct4(60.0, 40.0);
			double num = gstruct1_0.method_12() + (gstruct1_0.method_8() - gStruct.method_1()) / 2.0;
			double num2 = gstruct1_0.method_13() + (gstruct1_0.method_10() - gStruct.method_3()) / 2.0;
			gclass14_0.vmethod_12(gclass14_0.method_1(GStruct3.smethod_5(160, 0, 0, 0)), num, num2, gStruct.method_1(), gStruct.method_3());
			GStruct2[] array = new GStruct2[3]
			{
				new GStruct2(num + gStruct.method_1() / 3.0 + 1.0, num2 + 3.0 * gStruct.method_3() / 4.0),
				new GStruct2(num + gStruct.method_1() / 3.0 + 1.0, num2 + gStruct.method_3() / 4.0),
				new GStruct2(num + 2.0 * gStruct.method_1() / 3.0 + 1.0, num2 + gStruct.method_3() / 2.0)
			};
			gclass14_0.vmethod_17(gclass14_0.method_1(GStruct3.smethod_2()), array);
			gclass14_0.vmethod_4(object_);
		}
	}

	internal override void vmethod_8(GClass14 gclass14_0)
	{
		if (!bool_1)
		{
			method_184(gclass14_0);
			bool_1 = true;
		}
		Class281.smethod_0(class246_0);
	}

	private void method_248()
	{
		method_183(Class84.smethod_0(-994292460), Class84.smethod_0(-994292480), Class84.smethod_0(-994292422));
		string text;
		method_17(text = Class84.smethod_0(-994292440));
		method_21(text);
	}

	private void method_249(GClass29 gclass29_0, GStruct1 gstruct1_0, bool bool_4)
	{
		class246_0.vmethod_3(gclass29_0);
		class246_0.method_27(gstruct1_0);
		bool_3 = true;
		bool_1 = false;
		if (bool_3 && gclass29_0 == null)
		{
			method_248();
		}
		if (bool_4)
		{
			method_186().method_71(method_250());
		}
	}

	private bool method_250()
	{
		Class239 @class = new Class239(method_60());
		Class239 class2 = new Class239(method_64());
		if (!(@class.method_0() <= 0.0) && @class.method_4() == (Enum4)2)
		{
			if (!(class2.method_0() <= 0.0))
			{
				return class2.method_4() != (Enum4)2;
			}
			return true;
		}
		return true;
	}
}
