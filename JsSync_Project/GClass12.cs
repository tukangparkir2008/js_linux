using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Web;

public sealed class GClass12 : IDisposable
{
	private sealed class Class144
	{
		private readonly byte[] byte_0;

		private readonly TimeSpan timeSpan_0;

		public Class144(byte[] byte_1, TimeSpan timeSpan_1 = default(TimeSpan))
		{
			byte_0 = byte_1;
			timeSpan_0 = timeSpan_1;
		}

		public Class144(string string_0, TimeSpan timeSpan_1 = default(TimeSpan))
		{
			byte_0 = Encoding.UTF8.GetBytes(string_0);
			timeSpan_0 = timeSpan_1;
		}

		public byte[] method_0()
		{
			return byte_0;
		}

		public TimeSpan method_1()
		{
			return timeSpan_0;
		}
	}

	public delegate bool GDelegate3(GClass12 gclass12_0, string string_0, byte[] byte_0, TimeSpan timeSpan_0);

	private sealed class Class145
	{
		private sealed class Class146
		{
			public GClass12 gclass12_0;

			public Class145 class145_0;

			internal void method_0(object sender, FileSystemEventArgs e)
			{
				smethod_1(sender, e, gclass12_0, class145_0);
			}

			internal void method_1(object sender, FileSystemEventArgs e)
			{
				smethod_2(sender, e, gclass12_0, class145_0);
			}

			internal void method_2(object sender, FileSystemEventArgs e)
			{
				smethod_3(sender, e, gclass12_0, class145_0);
			}

			internal void method_3(object sender, RenamedEventArgs e)
			{
				smethod_4(sender, e, gclass12_0, class145_0);
			}
		}

		private readonly string string_0;

		private readonly string string_1;

		private readonly GDelegate3 gdelegate3_0;

		private readonly TimeSpan timeSpan_0;

		private readonly FileSystemWatcher fileSystemWatcher_0;

		public Class145(GClass12 gclass12_0, string string_2, string string_3, string string_4, GDelegate3 gdelegate3_1, TimeSpan timeSpan_1)
		{
			string_0 = string_2;
			string_1 = string_3;
			gdelegate3_0 = gdelegate3_1;
			timeSpan_0 = timeSpan_1;
			fileSystemWatcher_0 = new FileSystemWatcher();
			method_0(gclass12_0, string_3, string_4);
		}

		private void method_0(GClass12 gclass12_0, string string_2, string string_3)
		{
			Class146 @class = new Class146();
			@class.gclass12_0 = gclass12_0;
			@class.class145_0 = this;
			fileSystemWatcher_0.Created += @class.method_0;
			fileSystemWatcher_0.Changed += @class.method_1;
			fileSystemWatcher_0.Deleted += @class.method_2;
			fileSystemWatcher_0.Renamed += @class.method_3;
			fileSystemWatcher_0.Path = string_2;
			fileSystemWatcher_0.IncludeSubdirectories = true;
			fileSystemWatcher_0.Filter = string_3;
			fileSystemWatcher_0.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;
			fileSystemWatcher_0.EnableRaisingEvents = true;
		}

		public void method_1()
		{
			fileSystemWatcher_0.Dispose();
		}

		private static bool smethod_0(string string_2)
		{
			try
			{
				if ((File.GetAttributes(string_2) & FileAttributes.Directory) == FileAttributes.Directory)
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
			return false;
		}

		private static void smethod_1(object object_0, FileSystemEventArgs fileSystemEventArgs_0, GClass12 gclass12_0, Class145 class145_0)
		{
			string string_ = fileSystemEventArgs_0.FullPath.Replace(class145_0.string_1, class145_0.string_0);
			string fullPath = fileSystemEventArgs_0.FullPath;
			if (File.Exists(fullPath) && !smethod_0(fullPath))
			{
				gclass12_0.method_9(class145_0.string_1, fullPath, string_, class145_0.timeSpan_0, class145_0.gdelegate3_0);
			}
		}

		private static void smethod_2(object object_0, FileSystemEventArgs fileSystemEventArgs_0, GClass12 gclass12_0, Class145 class145_0)
		{
			if (fileSystemEventArgs_0.ChangeType == WatcherChangeTypes.Changed)
			{
				string string_ = fileSystemEventArgs_0.FullPath.Replace(class145_0.string_1, class145_0.string_0);
				string fullPath = fileSystemEventArgs_0.FullPath;
				if (File.Exists(fullPath) && !smethod_0(fullPath))
				{
					gclass12_0.method_9(class145_0.string_1, fullPath, string_, class145_0.timeSpan_0, class145_0.gdelegate3_0);
				}
			}
		}

		private static void smethod_3(object object_0, FileSystemEventArgs fileSystemEventArgs_0, GClass12 gclass12_0, Class145 class145_0)
		{
			string text = fileSystemEventArgs_0.FullPath.Replace(class145_0.string_1, class145_0.string_0);
			_ = fileSystemEventArgs_0.FullPath;
			gclass12_0.method_10(class145_0.string_1, text);
		}

		private static void smethod_4(object object_0, RenamedEventArgs renamedEventArgs_0, GClass12 gclass12_0, Class145 class145_0)
		{
			string text = renamedEventArgs_0.OldFullPath.Replace(class145_0.string_1, class145_0.string_0);
			_ = renamedEventArgs_0.OldFullPath;
			string string_ = renamedEventArgs_0.FullPath.Replace(class145_0.string_1, class145_0.string_0);
			string fullPath = renamedEventArgs_0.FullPath;
			if (File.Exists(fullPath) && !smethod_0(fullPath))
			{
				gclass12_0.method_10(class145_0.string_1, text);
				gclass12_0.method_9(class145_0.string_1, fullPath, string_, class145_0.timeSpan_0, class145_0.gdelegate3_0);
			}
		}
	}

	[Serializable]
	private sealed class Class147
	{
		public static readonly Class147 class147_0 = new Class147();

		public static GDelegate3 gdelegate3_0;

		internal bool method_0(GClass12 gclass12_0, string string_0, byte[] byte_0, TimeSpan timeSpan_0)
		{
			return gclass12_0.method_2(string_0, byte_0, timeSpan_0);
		}
	}

	private readonly ReaderWriterLockSlim readerWriterLockSlim_0 = new ReaderWriterLockSlim();

	private Dictionary<string, Class144> dictionary_0 = new Dictionary<string, Class144>();

	private Dictionary<string, HashSet<string>> dictionary_1 = new Dictionary<string, HashSet<string>>();

	private Dictionary<string, Class145> dictionary_2 = new Dictionary<string, Class145>();

	private bool bool_0;

	public bool method_0()
	{
		return dictionary_0.Count == 0;
	}

	public int method_1()
	{
		return dictionary_0.Count;
	}

	public bool method_2(string string_0, byte[] byte_0, TimeSpan timeSpan_0)
	{
		GClass66 gClass = new GClass66(readerWriterLockSlim_0);
		try
		{
			dictionary_0.Remove(string_0);
			dictionary_0.Add(string_0, new Class144(byte_0, timeSpan_0));
			return true;
		}
		finally
		{
			((IDisposable)gClass).Dispose();
		}
	}

	public (bool, byte[]) method_3(string string_0)
	{
		GClass67 gClass = new GClass67(readerWriterLockSlim_0);
		try
		{
			if (!dictionary_0.TryGetValue(string_0, out var value))
			{
				return (false, new byte[0]);
			}
			return (true, value.method_0());
		}
		finally
		{
			((IDisposable)gClass).Dispose();
		}
	}

	public bool method_4(string string_0)
	{
		GClass66 gClass = new GClass66(readerWriterLockSlim_0);
		try
		{
			return dictionary_0.Remove(string_0);
		}
		finally
		{
			((IDisposable)gClass).Dispose();
		}
	}

	public bool method_5(string string_0, string string_1, string string_2, TimeSpan timeSpan_0, GDelegate3 gdelegate3_0)
	{
		if (gdelegate3_0 == null)
		{
			gdelegate3_0 = Class147.class147_0.method_0;
		}
		method_12(string_0);
		GClass66 gClass = new GClass66(readerWriterLockSlim_0);
		try
		{
			dictionary_2.Add(string_0, new Class145(this, string_1, string_0, string_2, gdelegate3_0, timeSpan_0));
			dictionary_1[string_0] = new HashSet<string>();
		}
		finally
		{
			((IDisposable)gClass).Dispose();
		}
		if (!method_11(string_0, string_0, string_1, timeSpan_0, gdelegate3_0))
		{
			return false;
		}
		return true;
	}

	public bool method_6(string string_0)
	{
		GClass67 gClass = new GClass67(readerWriterLockSlim_0);
		try
		{
			return dictionary_2.ContainsKey(string_0);
		}
		finally
		{
			((IDisposable)gClass).Dispose();
		}
	}

	public bool method_7(string string_0)
	{
		return method_12(string_0);
	}

	public void method_8()
	{
		GClass66 gClass = new GClass66(readerWriterLockSlim_0);
		try
		{
			foreach (KeyValuePair<string, Class145> item in dictionary_2)
			{
				item.Value.method_1();
			}
			dictionary_0.Clear();
			dictionary_1.Clear();
			dictionary_2.Clear();
		}
		finally
		{
			((IDisposable)gClass).Dispose();
		}
	}

	private bool method_9(string string_0, string string_1, string string_2, TimeSpan timeSpan_0, GDelegate3 gdelegate3_0)
	{
		try
		{
			string_2 = string_2.Replace('\\', '/');
			string_1 = string_1.Replace('\\', '/');
			byte[] byte_ = File.ReadAllBytes(string_1);
			if (!gdelegate3_0(this, string_2, byte_, timeSpan_0))
			{
				return false;
			}
			GClass66 gClass = new GClass66(readerWriterLockSlim_0);
			try
			{
				dictionary_1[string_0].Add(string_2);
			}
			finally
			{
				((IDisposable)gClass).Dispose();
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private bool method_10(string string_0, string string_1)
	{
		try
		{
			string_1 = string_1.Replace('\\', '/');
			GClass66 gClass = new GClass66(readerWriterLockSlim_0);
			try
			{
				dictionary_1[string_0].Remove(string_1);
			}
			finally
			{
				((IDisposable)gClass).Dispose();
			}
			return method_4(string_1);
		}
		catch (Exception)
		{
			return false;
		}
	}

	private bool method_11(string string_0, string string_1, string string_2, TimeSpan timeSpan_0, GDelegate3 gdelegate3_0)
	{
		try
		{
			string text = ((string.IsNullOrEmpty(string_2) || string_2 == Class84.smethod_0(-994276891)) ? Class84.smethod_0(-994276891) : (string_2 + Class84.smethod_0(-994276891)));
			string[] directories = Directory.GetDirectories(string_1);
			int num = 0;
			while (true)
			{
				if (num < directories.Length)
				{
					string text2 = directories[num];
					string string_3 = text + HttpUtility.UrlDecode(Path.GetFileName(text2));
					if (!method_11(string_0, text2, string_3, timeSpan_0, gdelegate3_0))
					{
						break;
					}
					num++;
					continue;
				}
				directories = Directory.GetFiles(string_1);
				num = 0;
				while (true)
				{
					if (num < directories.Length)
					{
						string text3 = directories[num];
						string string_4 = text + HttpUtility.UrlDecode(Path.GetFileName(text3));
						if (!method_9(string_0, text3, string_4, timeSpan_0, gdelegate3_0))
						{
							break;
						}
						num++;
						continue;
					}
					return true;
				}
				return false;
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private bool method_12(string string_0)
	{
		GClass66 gClass = new GClass66(readerWriterLockSlim_0);
		try
		{
			if (!dictionary_2.TryGetValue(string_0, out var value))
			{
				return false;
			}
			value.method_1();
			foreach (string item in dictionary_1[string_0])
			{
				dictionary_0.Remove(item);
			}
			dictionary_1.Remove(string_0);
			dictionary_2.Remove(string_0);
			return true;
		}
		finally
		{
			((IDisposable)gClass).Dispose();
		}
	}

	public void Dispose()
	{
		vmethod_0(bool_1: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void vmethod_0(bool bool_1)
	{
		if (!bool_0)
		{
			if (bool_1)
			{
				method_8();
			}
			bool_0 = true;
		}
	}

	~GClass12()
	{
		vmethod_0(bool_1: false);
	}
}
