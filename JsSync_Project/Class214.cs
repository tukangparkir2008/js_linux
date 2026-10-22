using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

internal sealed class Class214 : IDisposable
{
	private sealed class Class215
	{
		public Class214 class214_0;

		public FileInfo fileInfo_0;

		internal void method_0(object object_0)
		{
			class214_0.method_8(fileInfo_0.FullName);
		}
	}

	private readonly GClass31 gclass31_0;

	private readonly Delegate23<GClass29, GStruct1, bool> delegate23_0;

	private FileStream fileStream_0;

	private GClass29 gclass29_0;

	private GStruct1 gstruct1_0;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	public Class214(GClass31 gclass31_1, Delegate23<GClass29, GStruct1, bool> delegate23_1)
	{
		GClass24.smethod_1(gclass31_1, Class84.smethod_0(-994279873));
		GClass24.smethod_1(delegate23_1, Class84.smethod_0(-994283452));
		gclass31_0 = gclass31_1;
		delegate23_0 = delegate23_1;
	}

	public GClass29 method_0()
	{
		return gclass29_0;
	}

	public GStruct1 method_1()
	{
		return gstruct1_0;
	}

	public void method_2(string string_0, Dictionary<string, string> dictionary_0)
	{
		try
		{
			GEventArgs5 gEventArgs = new GEventArgs5(string_0, dictionary_0, method_3);
			gclass31_0.method_70(gEventArgs);
			bool_0 = !gclass31_0.method_19();
			if (gEventArgs.method_2())
			{
				return;
			}
			if (!string.IsNullOrEmpty(string_0))
			{
				if (string_0.StartsWith(Class84.smethod_0(-994283409), StringComparison.CurrentCultureIgnoreCase))
				{
					method_4(string_0);
				}
				else
				{
					method_6(string_0);
				}
			}
			else
			{
				method_11(bool_3: false);
			}
		}
		catch (Exception exception_)
		{
			gclass31_0.method_72(GEnum7.Image, Class84.smethod_0(-994283376), exception_);
			method_11(bool_3: false);
		}
	}

	public void Dispose()
	{
		bool_2 = true;
		method_12();
	}

	private void method_3(string string_0, object object_0, GStruct1 gstruct1_1)
	{
		if (!bool_2)
		{
			gstruct1_0 = gstruct1_1;
			if (object_0 != null)
			{
				gclass29_0 = gclass31_0.method_0().method_5(object_0);
				method_11(bool_0);
			}
			else if (!string.IsNullOrEmpty(string_0))
			{
				method_6(string_0);
			}
			else
			{
				method_11(bool_0);
			}
		}
	}

	private void method_4(string string_0)
	{
		gclass29_0 = method_5(string_0);
		if (gclass29_0 == null)
		{
			gclass31_0.method_72(GEnum7.Image, Class84.smethod_0(-994283351), null);
		}
		bool_1 = true;
		method_11(bool_3: false);
	}

	private GClass29 method_5(string string_0)
	{
		string[] array = string_0.Substring(string_0.IndexOf(':') + 1).Split(new char[1] { ',' }, 2);
		if (array.Length == 2)
		{
			int num = 0;
			int num2 = 0;
			string[] array2 = array[0].Split(';');
			for (int i = 0; i < array2.Length; i++)
			{
				string text = array2[i].Trim();
				if (text.StartsWith(Class84.smethod_0(-994283323), StringComparison.InvariantCultureIgnoreCase))
				{
					num++;
				}
				if (text.Equals(Class84.smethod_0(-994283278), StringComparison.InvariantCultureIgnoreCase))
				{
					num2++;
				}
			}
			if (num > 0)
			{
				byte[] buffer = ((num2 > 0) ? Convert.FromBase64String(array[1].Trim()) : new UTF8Encoding().GetBytes(Uri.UnescapeDataString(array[1].Trim())));
				return gclass31_0.method_0().method_6(new MemoryStream(buffer));
			}
		}
		return null;
	}

	private void method_6(string string_0)
	{
		Uri uri = Class299.smethod_4(string_0);
		if (uri != null && uri.Scheme != Class84.smethod_0(-994283281))
		{
			method_9(uri);
			return;
		}
		FileInfo fileInfo = Class299.smethod_6((uri != null) ? uri.AbsolutePath : string_0);
		if (fileInfo != null)
		{
			method_7(fileInfo);
			return;
		}
		gclass31_0.method_72(GEnum7.Image, Class84.smethod_0(-994283238) + string_0, null);
		method_11(bool_3: false);
	}

	private void method_7(FileInfo fileInfo_0)
	{
		Class215 @class = new Class215();
		@class.class214_0 = this;
		@class.fileInfo_0 = fileInfo_0;
		if (@class.fileInfo_0.Exists)
		{
			if (gclass31_0.method_19())
			{
				method_8(@class.fileInfo_0.FullName);
			}
			else
			{
				ThreadPool.QueueUserWorkItem(@class.method_0);
			}
		}
		else
		{
			method_11(bool_3: true);
		}
	}

	private void method_8(string string_0)
	{
		try
		{
			FileStream fileStream = File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			lock (delegate23_0)
			{
				fileStream_0 = fileStream;
				if (!bool_2)
				{
					gclass29_0 = gclass31_0.method_0().method_6(fileStream_0);
				}
				bool_1 = true;
			}
			method_11(bool_3: true);
		}
		catch (Exception exception_)
		{
			gclass31_0.method_72(GEnum7.Image, Class84.smethod_0(-994283212) + string_0, exception_);
			method_11(bool_3: true);
		}
	}

	private void method_9(Uri uri_0)
	{
		FileInfo fileInfo = Class299.smethod_8(uri_0);
		if (fileInfo.Exists && fileInfo.Length > 0L)
		{
			method_7(fileInfo);
		}
		else
		{
			gclass31_0.method_75().method_0(uri_0, fileInfo.FullName, !gclass31_0.method_19(), method_10);
		}
	}

	private void method_10(Uri uri_0, string string_0, Exception exception_0, bool bool_3)
	{
		if (!bool_3 && !bool_2)
		{
			if (exception_0 == null)
			{
				method_8(string_0);
				return;
			}
			gclass31_0.method_72(GEnum7.Image, Class84.smethod_0(-994283189) + uri_0, exception_0);
			method_11(bool_3: true);
		}
	}

	private void method_11(bool bool_3)
	{
		if (bool_2)
		{
			method_12();
		}
		else
		{
			delegate23_0(gclass29_0, gstruct1_0, bool_3);
		}
	}

	private void method_12()
	{
		lock (delegate23_0)
		{
			if (bool_1 && gclass29_0 != null)
			{
				gclass29_0.Dispose();
				gclass29_0 = null;
			}
			if (fileStream_0 != null)
			{
				fileStream_0.Dispose();
				fileStream_0 = null;
			}
		}
	}
}
