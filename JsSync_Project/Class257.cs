using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading;

internal sealed class Class257 : IDisposable
{
	private sealed class Class258
	{
		public readonly Uri uri_0;

		public readonly string string_0;

		public readonly string string_1;

		public Class258(Uri uri_1, string string_2, string string_3)
		{
			uri_0 = uri_1;
			string_0 = string_2;
			string_1 = string_3;
		}
	}

	private readonly List<WebClient> list_0 = new List<WebClient>();

	private readonly Dictionary<string, List<GDelegate11>> dictionary_0 = new Dictionary<string, List<GDelegate11>>();

	public Class257()
	{
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
	}

	public void method_0(Uri uri_0, string string_0, bool bool_0, GDelegate11 gdelegate11_0)
	{
		GClass24.smethod_1(uri_0, Class84.smethod_0(-994279529));
		GClass24.smethod_1(gdelegate11_0, Class84.smethod_0(-994279546));
		bool flag = true;
		lock (dictionary_0)
		{
			if (dictionary_0.ContainsKey(string_0))
			{
				flag = false;
				dictionary_0[string_0].Add(gdelegate11_0);
			}
			else
			{
				dictionary_0[string_0] = new List<GDelegate11> { gdelegate11_0 };
			}
		}
		if (flag)
		{
			string tempFileName = Path.GetTempFileName();
			if (bool_0)
			{
				ThreadPool.QueueUserWorkItem(method_2, new Class258(uri_0, tempFileName, string_0));
			}
			else
			{
				method_1(uri_0, tempFileName, string_0);
			}
		}
	}

	public void Dispose()
	{
		method_5();
	}

	private void method_1(Uri uri_0, string string_0, string string_1)
	{
		try
		{
			WebClient webClient = new WebClient();
			try
			{
				list_0.Add(webClient);
				webClient.DownloadFile(uri_0, string_0);
				method_4(webClient, uri_0, string_0, string_1, null, bool_0: false);
			}
			finally
			{
				((IDisposable)webClient).Dispose();
			}
		}
		catch (Exception exception_)
		{
			method_4(null, uri_0, string_0, string_1, exception_, bool_0: false);
		}
	}

	private void method_2(object object_0)
	{
		Class258 @class = (Class258)object_0;
		try
		{
			WebClient webClient = new WebClient();
			list_0.Add(webClient);
			webClient.DownloadFileCompleted += method_3;
			webClient.DownloadFileAsync(@class.uri_0, @class.string_0, @class);
		}
		catch (Exception exception_)
		{
			method_4(null, @class.uri_0, @class.string_0, @class.string_1, exception_, bool_0: false);
		}
	}

	private void method_3(object sender, AsyncCompletedEventArgs e)
	{
		Class258 @class = (Class258)e.UserState;
		try
		{
			using WebClient webClient = (WebClient)sender;
			webClient.DownloadFileCompleted -= method_3;
			method_4(webClient, @class.uri_0, @class.string_0, @class.string_1, e.Error, e.Cancelled);
		}
		catch (Exception exception_)
		{
			method_4(null, @class.uri_0, @class.string_0, @class.string_1, exception_, bool_0: false);
		}
	}

	private void method_4(WebClient webClient_0, Uri uri_0, string string_0, string string_1, Exception exception_0, bool bool_0)
	{
		if (!bool_0)
		{
			if (exception_0 == null)
			{
				string text = Class299.smethod_7(webClient_0);
				if (text == null || !text.StartsWith(Class84.smethod_0(-994295247), StringComparison.OrdinalIgnoreCase))
				{
					exception_0 = new Exception(Class84.smethod_0(-994279505) + text);
				}
			}
			if (exception_0 == null)
			{
				if (File.Exists(string_0))
				{
					try
					{
						File.Move(string_0, string_1);
					}
					catch (Exception innerException)
					{
						exception_0 = new Exception(Class84.smethod_0(-994279436), innerException);
					}
				}
				exception_0 = (File.Exists(string_1) ? null : (exception_0 ?? new Exception(Class84.smethod_0(-994283466))));
			}
		}
		List<GDelegate11> value;
		lock (dictionary_0)
		{
			if (dictionary_0.TryGetValue(string_1, out value))
			{
				dictionary_0.Remove(string_1);
			}
		}
		if (value == null)
		{
			return;
		}
		foreach (GDelegate11 item in value)
		{
			try
			{
				item(uri_0, string_1, exception_0, bool_0);
			}
			catch
			{
			}
		}
	}

	private void method_5()
	{
		dictionary_0.Clear();
		while (list_0.Count > 0)
		{
			try
			{
				WebClient webClient = list_0[0];
				webClient.CancelAsync();
				webClient.Dispose();
				list_0.RemoveAt(0);
			}
			catch
			{
			}
		}
	}
}
