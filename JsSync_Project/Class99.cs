using System;
using System.Collections.Generic;
using System.Reflection;

internal static class Class99
{
	private static class Class100
	{
		public static readonly Dictionary<Type, int> dictionary_0 = new Dictionary<Type, int>
		{
			{
				typeof(object),
				26
			},
			{
				typeof(byte),
				3
			},
			{
				typeof(sbyte),
				8
			},
			{
				typeof(short),
				22
			},
			{
				typeof(int),
				6
			},
			{
				typeof(long),
				12
			},
			{
				typeof(ushort),
				0
			},
			{
				typeof(uint),
				23
			},
			{
				typeof(ulong),
				10
			},
			{
				typeof(IntPtr),
				18
			},
			{
				typeof(UIntPtr),
				25
			},
			{
				typeof(float),
				14
			},
			{
				typeof(double),
				15
			},
			{
				typeof(bool),
				4
			},
			{
				typeof(char),
				13
			},
			{
				typeof(string),
				16
			}
		};
	}

	public static readonly Type type_0 = typeof(object);

	public static readonly Type type_1 = typeof(ValueType);

	public static readonly Type type_2 = typeof(Enum);

	public static readonly Type type_3 = typeof(Nullable<>);

	public static readonly Assembly assembly_0 = typeof(Class99).Assembly;

	public static bool smethod_0(Type type_4)
	{
		if (type_4.IsGenericType && !type_4.IsGenericTypeDefinition)
		{
			return (object)type_4.GetGenericTypeDefinition() == type_3;
		}
		return false;
	}

	public static Type smethod_1(Type type_4)
	{
		while (type_4.HasElementType)
		{
			type_4 = type_4.GetElementType();
		}
		return type_4;
	}

	public static Type smethod_2(Type type_4)
	{
		if (type_4.HasElementType && !type_4.IsArray)
		{
			type_4 = type_4.GetElementType();
		}
		return type_4;
	}

	public static Stack<Struct2> smethod_3(Type type_4)
	{
		Stack<Struct2> stack = new Stack<Struct2>();
		Type type = type_4;
		while (true)
		{
			if (!type.IsArray)
			{
				if (type.IsByRef)
				{
					stack.Push(new Struct2
					{
						int_0 = 2
					});
				}
				else
				{
					if (!type.IsPointer)
					{
						break;
					}
					stack.Push(new Struct2
					{
						int_0 = 1
					});
				}
			}
			else
			{
				stack.Push(new Struct2
				{
					int_0 = 0,
					int_1 = type.GetArrayRank()
				});
			}
			type = type.GetElementType();
		}
		return stack;
	}

	public static Stack<Struct2> smethod_4(string string_0)
	{
		string text = string_0;
		Stack<Struct2> stack = new Stack<Struct2>();
		while (true)
		{
			if (!text.EndsWith(Class84.smethod_0(-994275035), StringComparison.Ordinal))
			{
				if (text.EndsWith(Class84.smethod_0(-994274979), StringComparison.Ordinal))
				{
					stack.Push(new Struct2
					{
						int_0 = 1
					});
					text = text.Substring(0, text.Length - 1);
					continue;
				}
				if (text.EndsWith(Class84.smethod_0(-994274987), StringComparison.Ordinal))
				{
					stack.Push(new Struct2
					{
						int_0 = 0,
						int_1 = 1
					});
					text = text.Substring(0, text.Length - 2);
					continue;
				}
				if (!text.EndsWith(Class84.smethod_0(-994274994), StringComparison.Ordinal))
				{
					break;
				}
				int num = 1;
				int num2 = -1;
				for (int num3 = text.Length - 2; num3 >= 0; num3--)
				{
					switch (text[num3])
					{
					case '[':
						num2 = num3;
						num3 = -1;
						break;
					case ',':
						num++;
						break;
					default:
						throw new InvalidOperationException(Class84.smethod_0(-994275001));
					}
				}
				if (num2 < 0)
				{
					throw new InvalidOperationException(Class84.smethod_0(-994274955));
				}
				text = text.Substring(0, num2);
				stack.Push(new Struct2
				{
					int_0 = 0,
					int_1 = num
				});
			}
			else
			{
				stack.Push(new Struct2
				{
					int_0 = 2
				});
				text = text.Substring(0, text.Length - 1);
			}
		}
		return stack;
	}

	public static Type smethod_5(Type type_4, Stack<Struct2> stack_0)
	{
		Type type = type_4;
		while (stack_0.Count > 0)
		{
			Struct2 @struct = stack_0.Pop();
			switch (@struct.int_0)
			{
			case 0:
				type = ((@struct.int_1 != 1) ? type.MakeArrayType(@struct.int_1) : type.MakeArrayType());
				break;
			case 1:
				type = type.MakePointerType();
				break;
			case 2:
				type = type.MakeByRefType();
				break;
			}
		}
		return type;
	}

	public static int smethod_6(Type type_4)
	{
		if (Class100.dictionary_0.TryGetValue(type_4, out var value))
		{
			return value;
		}
		if (type_4.IsArray)
		{
			return 24;
		}
		if (type_4.IsValueType)
		{
			if (type_4.IsSubclassOf(type_2))
			{
				return 1;
			}
			if (smethod_0(type_4))
			{
				return 9;
			}
			return 11;
		}
		return 19;
	}
}
