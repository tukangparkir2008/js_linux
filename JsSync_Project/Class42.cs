using System;
using System.Collections.Generic;

internal sealed class Class42
{
	private sealed class Class43
	{
		public byte[] byte_0;

		public bool bool_0;

		public Class43()
		{
		}

		public Class43(byte[] byte_1, int int_0, int int_1, bool bool_1)
		{
			method_0(byte_1, int_0, int_1, bool_1);
		}

		public void method_0(byte[] byte_1, int int_0, int int_1, bool bool_1)
		{
			byte_0 = new byte[int_1];
			Buffer.BlockCopy(byte_1, int_0, byte_0, 0, int_1);
			bool_0 = bool_1;
		}
	}

	private readonly object object_0 = new object();

	private Class65[] class65_0;

	private Dictionary<int, Class65> dictionary_0;

	private bool bool_0;

	private Class46 class46_0;

	private Dictionary<int, WeakReference> dictionary_1;

	private object object_1;

	private int int_0;

	private object[] object_2;

	private int int_1;

	public Class42(Class46 class46_1)
	{
		class46_0 = class46_1;
	}

	private void method_0()
	{
		if (bool_0)
		{
			return;
		}
		lock (object_0)
		{
			if (!bool_0)
			{
				class65_0 = new Class65[class46_0.method_4()];
				for (int i = 0; i < class46_0.method_4(); i++)
				{
					class65_0[i] = new Class65();
				}
				dictionary_0 = new Dictionary<int, Class65>();
				dictionary_1 = new Dictionary<int, WeakReference>();
				object_1 = new object();
				int_0 = class46_0.method_6();
				object_2 = new object[class46_0.method_8()];
				bool_0 = true;
			}
		}
	}

	public void method_1(Class65 class65_1)
	{
		method_0();
		lock (object_0)
		{
			if (dictionary_0.TryGetValue(class65_1.int_0, out var value) && value != null)
			{
				value.dateTime_0 = class65_1.dateTime_0;
				return;
			}
			int num = 0;
			DateTime dateTime_ = class65_0[0].dateTime_0;
			for (int i = 1; i < class46_0.method_4(); i++)
			{
				if (class65_0[i].dateTime_0 < dateTime_)
				{
					num = i;
				}
			}
			value = class65_0[num];
			if (value.byte_0 == null)
			{
				value.byte_0 = new byte[class46_0.method_0()];
			}
			else
			{
				dictionary_0[value.int_0] = null;
			}
			method_4(class65_1, value);
			dictionary_0[value.int_0] = value;
			if (dictionary_0.Count > class46_0.method_4() * 2)
			{
				method_2();
			}
		}
	}

	private void method_2()
	{
		Dictionary<int, Class65> dictionary = dictionary_0;
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, Class65> item in dictionary)
		{
			if (item.Value == null)
			{
				list.Add(item.Key);
			}
		}
		foreach (int item2 in list)
		{
			dictionary.Remove(item2);
		}
	}

	public bool method_3(int int_2, ref Class65 class65_1)
	{
		if (!bool_0)
		{
			return false;
		}
		lock (object_0)
		{
			if (dictionary_0.TryGetValue(int_2, out var value) && value != null)
			{
				method_4(value, class65_1);
				return true;
			}
		}
		return false;
	}

	private void method_4(Class65 class65_1, Class65 class65_2)
	{
		class65_1.dateTime_0 = DateTime.UtcNow;
		class65_2.int_0 = class65_1.int_0;
		class65_2.int_1 = class65_1.int_1;
		class65_2.dateTime_0 = class65_1.dateTime_0;
		Buffer.BlockCopy(class65_1.byte_0, 0, class65_2.byte_0, 0, class46_0.method_0());
	}

	private void method_5(object object_3)
	{
		for (int i = 0; i < object_2.Length; i++)
		{
			if (object_2[i] == object_3)
			{
				return;
			}
		}
		object_2[int_1] = object_3;
		int_1++;
		if (int_1 == object_2.Length)
		{
			int_1 = 0;
		}
	}

	private void method_6()
	{
		if (dictionary_1.Count < int_0)
		{
			return;
		}
		Dictionary<int, WeakReference> dictionary = new Dictionary<int, WeakReference>();
		foreach (KeyValuePair<int, WeakReference> item in dictionary_1)
		{
			if (item.Value.IsAlive)
			{
				dictionary.Add(item.Key, item.Value);
			}
		}
		dictionary_1 = dictionary;
		int_0 = Math.Max(dictionary.Count * 2, 10);
	}

	public void method_7(int int_2, byte[] byte_0, int int_3, int int_4, bool bool_1)
	{
		method_0();
		lock (object_1)
		{
			Class43 @class;
			if (dictionary_1.TryGetValue(int_2, out var value))
			{
				@class = value.Target as Class43;
				if (@class != null)
				{
					if (@class.byte_0.Length < int_4)
					{
						@class.method_0(byte_0, int_3, int_4, bool_1);
					}
					goto IL_0070;
				}
			}
			method_6();
			@class = new Class43(byte_0, int_3, int_4, bool_1);
			dictionary_1[int_2] = new WeakReference(@class);
			goto IL_0070;
			IL_0070:
			method_5(@class);
		}
	}

	public bool method_8(int int_2, byte[] byte_0, int int_3, int int_4, out int int_5)
	{
		int_5 = 0;
		if (!bool_0)
		{
			return false;
		}
		lock (object_1)
		{
			if (!dictionary_1.TryGetValue(int_2, out var value))
			{
				return false;
			}
			if (!(value.Target is Class43 @class))
			{
				return false;
			}
			int num = @class.byte_0.Length;
			int_5 = int_4;
			if (num < int_4)
			{
				if (!@class.bool_0)
				{
					return false;
				}
				int_5 = num;
			}
			Buffer.BlockCopy(@class.byte_0, 0, byte_0, int_3, int_5);
			method_5(@class);
			return true;
		}
	}
}
