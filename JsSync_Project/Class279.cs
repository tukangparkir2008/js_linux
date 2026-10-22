using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

internal static class Class279
{
	public static void smethod_0(GClass31 gclass31_0, string string_0, Dictionary<string, string> dictionary_0, out string string_1, out GClass55 gclass55_0)
	{
		GClass24.smethod_1(gclass31_0, Class84.smethod_0(-994279873));
		string_1 = null;
		gclass55_0 = null;
		try
		{
			GEventArgs0 gEventArgs = new GEventArgs0(string_0, dictionary_0);
			gclass31_0.method_69(gEventArgs);
			if (!string.IsNullOrEmpty(gEventArgs.method_4()))
			{
				string_1 = gEventArgs.method_4();
			}
			else if (gEventArgs.method_6() != null)
			{
				gclass55_0 = gEventArgs.method_6();
			}
			else if (gEventArgs.method_2() != null)
			{
				string_1 = smethod_1(gclass31_0, gEventArgs.method_2());
			}
			else
			{
				string_1 = smethod_1(gclass31_0, string_0);
			}
		}
		catch (Exception exception_)
		{
			gclass31_0.method_72(GEnum7.CssParsing, Class84.smethod_0(-994283167), exception_);
		}
	}

	private static string smethod_1(GClass31 gclass31_0, string string_0)
	{
		Uri uri = Class299.smethod_4(string_0);
		if (!(uri == null) && !(uri.Scheme == Class84.smethod_0(-994283281)))
		{
			return smethod_3(gclass31_0, uri);
		}
		return smethod_2(gclass31_0, (uri != null) ? uri.AbsolutePath : string_0);
	}

	private static string smethod_2(GClass31 gclass31_0, string string_0)
	{
		FileInfo fileInfo = Class299.smethod_6(string_0);
		if (fileInfo != null)
		{
			if (fileInfo.Exists)
			{
				StreamReader streamReader = new StreamReader(fileInfo.FullName);
				try
				{
					return streamReader.ReadToEnd();
				}
				finally
				{
					((IDisposable)streamReader).Dispose();
				}
			}
			gclass31_0.method_72(GEnum7.CssParsing, Class84.smethod_0(-994283073) + string_0, null);
		}
		else
		{
			gclass31_0.method_72(GEnum7.CssParsing, Class84.smethod_0(-994283238) + string_0, null);
		}
		return string.Empty;
	}

	private static string smethod_3(GClass31 gclass31_0, Uri uri_0)
	{
		WebClient webClient = new WebClient();
		try
		{
			string text = webClient.DownloadString(uri_0);
			try
			{
				text = smethod_4(text, uri_0);
			}
			catch (Exception exception_)
			{
				gclass31_0.method_72(GEnum7.CssParsing, Class84.smethod_0(-994283053), exception_);
			}
			return text;
		}
		finally
		{
			((IDisposable)webClient).Dispose();
		}
	}

	private static string smethod_4(string string_0, Uri uri_0)
	{
		int num = 0;
		while (num >= 0 && num < string_0.Length)
		{
			num = string_0.IndexOf(Class84.smethod_0(-994282977), num, StringComparison.OrdinalIgnoreCase);
			if (num < 0)
			{
				continue;
			}
			int num2 = string_0.IndexOf(')', num);
			if (num2 > num + 4)
			{
				int num3 = 4 + ((string_0[num + 4] == '\'') ? 1 : 0);
				int num4 = ((string_0[num2 - 1] == '\'') ? 1 : 0);
				if (Uri.TryCreate(string_0.Substring(num + num3, num2 - num - num3 - num4), UriKind.Relative, out var result))
				{
					result = new Uri(uri_0, result);
					string_0 = string_0.Remove(num + 4, num2 - num - 4);
					string_0 = string_0.Insert(num + 4, result.AbsoluteUri);
					num += result.AbsoluteUri.Length + 4;
				}
				else
				{
					num = num2 + 1;
				}
			}
			else
			{
				num += 4;
			}
		}
		return string_0;
	}
}
