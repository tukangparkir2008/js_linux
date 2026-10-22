using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;
using System.Threading;

internal sealed class Class104
{
	private static class Class105
	{
		public static readonly bool bool_0;

		static Class105()
		{
			try
			{
				bool_0 = smethod_0();
			}
			catch
			{
				bool_0 = false;
			}
		}

		private static bool smethod_0()
		{
			if (typeof(DynamicMethod).IsAbstract)
			{
				return false;
			}
			try
			{
				new DynamicMethod(string.Empty, typeof(void), Type.EmptyTypes);
			}
			catch (PlatformNotSupportedException)
			{
				return false;
			}
			return true;
		}
	}

	private sealed class Class106
	{
		private string string_0;

		private Type type_0;

		public string method_0()
		{
			return string_0;
		}

		public void method_1(string string_1)
		{
			string_0 = string_1;
		}

		public Type method_2()
		{
			return type_0;
		}

		public void method_3(Type type_1)
		{
			type_0 = type_1;
		}
	}

	private struct Struct5(Struct0 struct0_0, Delegate0 delegate0_1)
	{
		public readonly byte byte_0 = struct0_0.method_2();

		public readonly Delegate0 delegate0_0 = delegate0_1;
	}

	private delegate void Delegate0(Class104 class104_0, Class6 class6_0);

	private delegate object Delegate1(object object_0, object[] object_1);

	private struct Struct6(MethodBase methodBase_1, bool bool_1) : IEquatable<Struct6>
	{
		private readonly MethodBase methodBase_0 = methodBase_1;

		private readonly bool bool_0 = bool_1;

		public MethodBase method_0()
		{
			return methodBase_0;
		}

		public bool method_1()
		{
			return bool_0;
		}

		public override int GetHashCode()
		{
			return method_0().GetHashCode() ^ method_1().GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (obj is Struct6 other)
			{
				return Equals(other);
			}
			return false;
		}

		public bool Equals(Struct6 other)
		{
			if ((object)method_0() == other.method_0())
			{
				return method_1() == other.method_1();
			}
			return false;
		}
	}

	private static class Class107
	{
		private static readonly Dictionary<MethodBase, MethodInfo> dictionary_0 = new Dictionary<MethodBase, MethodInfo>();

		public static MethodBase smethod_0(Class104 class104_0, Class36 class36_0, MethodBase methodBase_0, bool bool_0)
		{
			lock (dictionary_0)
			{
				if (dictionary_0.TryGetValue(methodBase_0, out var value))
				{
					return value;
				}
				Type returnType = ((!(methodBase_0 is MethodInfo methodInfo)) ? type_3 : methodInfo.ReturnType);
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				Type[] array;
				if (methodBase_0.IsStatic)
				{
					array = new Type[parameters.Length];
					for (int i = 0; i < parameters.Length; i++)
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				else
				{
					array = new Type[parameters.Length + 1];
					Type type = methodBase_0.DeclaringType;
					if (type.IsValueType)
					{
						type = type.MakeByRefType();
						bool_0 = false;
					}
					array[0] = type;
					for (int j = 0; j < parameters.Length; j++)
					{
						array[j + 1] = parameters[j].ParameterType;
					}
				}
				string empty = string.Empty;
				if ((object)value == null)
				{
					value = new DynamicMethod(empty, returnType, array, class104_0.method_71(class36_0.method_6(), bool_2: true), skipVisibility: true);
				}
				ILGenerator iLGenerator = ((DynamicMethod)value).GetILGenerator();
				for (int k = 0; k < array.Length; k++)
				{
					iLGenerator.Emit(OpCodes.Ldarg, k);
				}
				if (methodBase_0 is ConstructorInfo con)
				{
					iLGenerator.Emit(bool_0 ? OpCodes.Callvirt : OpCodes.Call, con);
				}
				else
				{
					iLGenerator.Emit(bool_0 ? OpCodes.Callvirt : OpCodes.Call, (MethodInfo)methodBase_0);
				}
				iLGenerator.Emit(OpCodes.Ret);
				dictionary_0.Add(methodBase_0, value);
				return value;
			}
		}
	}

	[Serializable]
	private sealed class Class108
	{
		public static readonly Class108 class108_0 = new Class108();

		public static Comparison<Class75> comparison_0;

		internal int method_0(Class75 class75_0, Class75 class75_1)
		{
			if (class75_0.method_4() == class75_1.method_4())
			{
				return class75_1.method_6().CompareTo(class75_0.method_6());
			}
			return class75_0.method_4().CompareTo(class75_1.method_4());
		}
	}

	private sealed class Class109<T> : IComparer<KeyValuePair<int, T>>
	{
		private readonly Comparison<T> comparison_0;

		public Class109(Comparison<T> comparison_1)
		{
			comparison_0 = comparison_1;
		}

		public int Compare(KeyValuePair<int, T> x, KeyValuePair<int, T> y)
		{
			int num = comparison_0(x.Value, y.Value);
			if (num == 0)
			{
				return y.Key.CompareTo(x.Key);
			}
			return num;
		}
	}

	private sealed class Class110 : IDisposable
	{
		public Class40 class40_0;

		public Class48 class48_0;

		public Class67 class67_0;

		public long long_0;

		public void Dispose()
		{
			IDisposable disposable = class48_0;
			if (disposable != null)
			{
				disposable.Dispose();
				disposable = null;
			}
			if (class67_0 != null)
			{
				class67_0.Dispose();
				class67_0 = null;
			}
		}
	}

	private struct Struct7
	{
		private readonly uint uint_0;

		private readonly object object_0;

		public Struct7(uint uint_1)
		{
			uint_0 = uint_1;
			object_0 = null;
		}

		public Struct7(uint uint_1, object object_1)
		{
			uint_0 = uint_1;
			object_0 = object_1;
		}

		public uint method_0()
		{
			return uint_0;
		}

		public object method_1()
		{
			return object_0;
		}
	}

	private static class Class111
	{
		private delegate void Delegate2<in T, in U>(T gparam_0, U gparam_1);

		private delegate T7 Delegate3<in T, in U, in V, in W, in X, in Y, in Z, out T7>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6);

		private delegate void Delegate4<in T, in U, in V, in W, in X>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4);

		private delegate void Delegate5<in T, in U, in V, in W, in X, in Y, in Z>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6);

		private delegate void Delegate6<in T, in U, in V, in W, in X, in Y>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5);

		private delegate W Delegate7<in T, in U, in V, out W>(T gparam_0, U gparam_1, V gparam_2);

		private delegate X Delegate8<in T, in U, in V, in W, out X>(T gparam_0, U gparam_1, V gparam_2, W gparam_3);

		private delegate T8 Delegate9<in T, in U, in V, in W, in X, in Y, in Z, in T7, out T8>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6, T7 gparam_7);

		private delegate void Delegate10<in T, in U, in V, in W>(T gparam_0, U gparam_1, V gparam_2, W gparam_3);

		private delegate Z Delegate11<in T, in U, in V, in W, in X, in Y, out Z>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5);

		private delegate T Delegate12<out T>();

		private delegate void Delegate13<in T, in U, in V, in W, in X, in Y, in Z, in T7, in T8>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6, T7 gparam_7, T8 gparam_8);

		private delegate void Delegate14();

		private delegate V Delegate15<in T, in U, out V>(T gparam_0, U gparam_1);

		private delegate U Delegate16<in T, out U>(T gparam_0);

		private delegate Y Delegate17<in T, in U, in V, in W, in X, out Y>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4);

		private delegate T9 Delegate18<in T, in U, in V, in W, in X, in Y, in Z, in T7, in T8, out T9>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6, T7 gparam_7, T8 gparam_8);

		private delegate void Delegate19<in T, in U, in V>(T gparam_0, U gparam_1, V gparam_2);

		private delegate void Delegate20<in T, in U, in V, in W, in X, in Y, in Z, in T7>(T gparam_0, U gparam_1, V gparam_2, W gparam_3, X gparam_4, Y gparam_5, Z gparam_6, T7 gparam_7);

		private delegate void Delegate21<in T>(T gparam_0);

		private static readonly Dictionary<MethodBase, KeyValuePair<Type, MethodInfo>> dictionary_0 = new Dictionary<MethodBase, KeyValuePair<Type, MethodInfo>>();

		public static object smethod_0(object object_0, MethodBase methodBase_0, out MethodInfo methodInfo_0)
		{
			KeyValuePair<Type, MethodInfo> keyValuePair = smethod_1(methodBase_0);
			Delegate result = (Delegate)Activator.CreateInstance(keyValuePair.Key, object_0, methodBase_0.MethodHandle.GetFunctionPointer());
			methodInfo_0 = keyValuePair.Value;
			return result;
		}

		private static KeyValuePair<Type, MethodInfo> smethod_1(MethodBase methodBase_0)
		{
			lock (dictionary_0)
			{
				if (dictionary_0.TryGetValue(methodBase_0, out var value))
				{
					return value;
				}
				MethodInfo obj = methodBase_0 as MethodInfo;
				object obj2;
				if ((object)obj == null)
				{
					obj2 = null;
				}
				else
				{
					obj2 = obj.ReturnType;
					if (obj2 != null)
					{
						goto IL_0041;
					}
				}
				obj2 = type_3;
				goto IL_0041;
				IL_0041:
				Type type = (Type)obj2;
				bool flag = (object)type != type_3;
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				if (parameters.Length > 9)
				{
					throw new Exception(string.Format(Class84.smethod_0(-994272768), parameters.Length));
				}
				Type[] array = new Type[parameters.Length + (flag ? 1 : 0)];
				int num = 0;
				Type type2;
				while (true)
				{
					if (num < parameters.Length)
					{
						Type parameterType = parameters[num].ParameterType;
						if (!parameterType.IsByRef && !parameterType.IsPointer)
						{
							array[num] = parameterType;
							num++;
							continue;
						}
						throw new Exception(Class84.smethod_0(-994272654));
					}
					if (flag)
					{
						array[array.Length - 1] = type;
					}
					type2 = (flag ? smethod_2(array) : smethod_3(array));
					break;
				}
				Type type3 = type2;
				MethodInfo method = type3.GetMethod(Class84.smethod_0(-994272607));
				value = new KeyValuePair<Type, MethodInfo>(type3, method);
				dictionary_0.Add(methodBase_0, value);
				return value;
			}
		}

		private static Type smethod_2(Type[] type_0)
		{
			return type_0.Length switch
			{
				1 => typeof(Delegate12<>).MakeGenericType(type_0), 
				2 => typeof(Delegate16<, >).MakeGenericType(type_0), 
				3 => typeof(Delegate15<, , >).MakeGenericType(type_0), 
				4 => typeof(Delegate7<, , , >).MakeGenericType(type_0), 
				5 => typeof(Delegate8<, , , , >).MakeGenericType(type_0), 
				6 => typeof(Delegate17<, , , , , >).MakeGenericType(type_0), 
				7 => typeof(Delegate11<, , , , , , >).MakeGenericType(type_0), 
				8 => typeof(Delegate3<, , , , , , , >).MakeGenericType(type_0), 
				9 => typeof(Delegate9<, , , , , , , , >).MakeGenericType(type_0), 
				10 => typeof(Delegate18<, , , , , , , , , >).MakeGenericType(type_0), 
				_ => null, 
			};
		}

		private static Type smethod_3(Type[] type_0)
		{
			return type_0.Length switch
			{
				0 => typeof(Delegate14), 
				1 => typeof(Delegate21<>).MakeGenericType(type_0), 
				2 => typeof(Delegate2<, >).MakeGenericType(type_0), 
				3 => typeof(Delegate19<, , >).MakeGenericType(type_0), 
				4 => typeof(Delegate10<, , , >).MakeGenericType(type_0), 
				5 => typeof(Delegate4<, , , , >).MakeGenericType(type_0), 
				6 => typeof(Delegate6<, , , , , >).MakeGenericType(type_0), 
				7 => typeof(Delegate5<, , , , , , >).MakeGenericType(type_0), 
				8 => typeof(Delegate20<, , , , , , , >).MakeGenericType(type_0), 
				9 => typeof(Delegate13<, , , , , , , , >).MakeGenericType(type_0), 
				_ => null, 
			};
		}
	}

	private struct Struct8
	{
		public bool bool_0;
	}

	private static readonly Dictionary<MethodBase, object> dictionary_0 = new Dictionary<MethodBase, object>();

	private Class36 class36_0;

	private Class6 class6_0;

	private Class75[] class75_0;

	private object[] object_0;

	private uint uint_0;

	private readonly Class96 class96_0;

	private static Type type_0 = typeof(object[]);

	private static readonly Dictionary<Struct6, Delegate1> dictionary_1 = new Dictionary<Struct6, Delegate1>(256);

	private Class6[] class6_1;

	private Type type_1;

	private byte[] byte_0;

	private long long_0;

	private static readonly Dictionary<MethodBase, int> dictionary_2 = new Dictionary<MethodBase, int>(256);

	private readonly Stack<Class6> stack_0 = new Stack<Class6>(16);

	private Class6 class6_2;

	private Type[] type_2;

	private Class48 class48_0;

	private readonly Module module_0;

	private static Type type_3 = typeof(void);

	private static Type type_4 = typeof(RuntimeHelpers);

	private Stack<Class110> stack_1;

	private static readonly Dictionary<int, object> dictionary_3 = new Dictionary<int, object>();

	private bool bool_0;

	private static Type type_5 = typeof(IntPtr);

	private Stream stream_0;

	private uint? nullable_0;

	private static Type type_6 = typeof(Assembly);

	private static Dictionary<int, Struct5> dictionary_4;

	private static object object_1 = new object();

	private static Type type_7 = typeof(MethodBase);

	private object object_2;

	private bool bool_1;

	private uint uint_1;

	private uint uint_2;

	private Class48 class48_1;

	private readonly Stack<Struct7> stack_2 = new Stack<Struct7>();

	private Class6[] class6_3;

	private Type[] type_8;

	public Class104(Class96 class96_1, Module module_1)
	{
		class96_0 = class96_1;
		module_0 = module_1;
		method_6();
	}

	public Class104(Class96 class96_1)
		: this(class96_1, typeof(Class104).Module)
	{
	}

	private void method_0(int int_0, Type[] type_9, Type[] type_10, bool bool_2)
	{
		class48_1.method_0().vmethod_9(int_0, 0);
		method_47(class48_1);
		Class36 @class = method_41(class48_1);
		method_66(@class);
		int num = @class.method_2().Length;
		object[] array = new object[num];
		Class6[] array2 = new Class6[num];
		if (((object)type_1 != null) & bool_2)
		{
			int num2 = ((!@class.method_12()) ? 1 : 0);
			Type[] array3 = new Type[num - num2];
			for (int num3 = num - 1; num3 >= num2; num3--)
			{
				array3[num3] = method_71(@class.method_2()[num3].method_0(), bool_2: true);
			}
			MethodInfo method = type_1.GetMethod(@class.method_4(), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array3, null);
			type_1 = null;
			if ((object)method != null)
			{
				method_28(method, bool_2: true);
				return;
			}
		}
		int num4 = num - 1;
		while (true)
		{
			if (num4 < 0)
			{
				Class104 class2 = new Class104(class96_0);
				object[] object_ = new object[1] { module_0.Assembly };
				object obj;
				try
				{
					obj = class2.method_19(stream_0, int_0, array, type_9, type_10, object_);
				}
				finally
				{
					bool flag = !@class.method_12();
					for (int i = 0; i < num; i++)
					{
						int num5;
						if (flag)
						{
							num5 = i + 1;
							if (num5 == num)
							{
								num5 = 0;
							}
						}
						else
						{
							num5 = i;
						}
						if (array2[num5] is Class18 class18_)
						{
							method_9(class18_, Class6.smethod_0(array[num5], null));
						}
					}
				}
				Type type = class2.method_71(class2.class36_0.method_8(), bool_2: true);
				if ((object)type != type_3)
				{
					method_35(Class6.smethod_0(obj, type));
				}
				break;
			}
			Class6 class3 = (array2[num4] = method_80());
			if (class3 is Class18 class18_2)
			{
				class3 = method_94(class18_2);
			}
			if ((object)class3.method_1() != null)
			{
				class3 = Class6.smethod_0(null, class3.method_1()).vmethod_2(class3);
			}
			Class6 class4 = Class6.smethod_0(null, method_71(@class.method_2()[num4].method_0(), bool_2: true)).vmethod_2(class3);
			array[num4] = class4.vmethod_0();
			if (!((num4 == 0) & bool_2) || @class.method_12() || array[num4] != null)
			{
				num4--;
				continue;
			}
			throw new NullReferenceException();
		}
	}

	private static void smethod_0(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_16(2);
	}

	private static void smethod_1(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_23(bool_2: true);
	}

	private static void smethod_2(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		class104_0.method_8(@class.vmethod_0());
	}

	private static void smethod_3(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		class104_0.method_35(new Class31(@class.method_0() switch
		{
			6 => (int)checked((ushort)(uint)((Class31)@class).method_3()), 
			1 => checked((ushort)Convert.ToUInt64(((Class15)@class).method_3())), 
			15 => checked((ushort)((Class11)@class).method_3()), 
			12 => checked((ushort)(ulong)((Class33)@class).method_3()), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private bool method_1(MethodBase methodBase_0)
	{
		if (!methodBase_0.IsVirtual)
		{
			return false;
		}
		if (method_71(class36_0.method_6(), bool_2: true).IsSubclassOf(methodBase_0.DeclaringType))
		{
			return true;
		}
		return false;
	}

	private static void smethod_4(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_74(bool_2: false);
	}

	private static Exception smethod_5(string string_0, string string_1)
	{
		return new FieldAccessException(smethod_15(Class84.smethod_0(-994271734) + string_0 + Class84.smethod_0(-994271698), Class84.smethod_0(-994271284) + string_1 + Class84.smethod_0(-994271698)));
	}

	private void method_2(Class6 class6_4)
	{
		if (((Class31)method_80()).method_3() != 0)
		{
			stack_2.Push(new Struct7(uint_1, object_2));
			bool_1 = false;
		}
		method_17();
	}

	private static bool smethod_6(object object_3)
	{
		return RemotingServices.IsTransparentProxy(object_3);
	}

	private void method_3(MemberInfo memberInfo_0)
	{
		if (!smethod_55() || class36_0.method_13())
		{
			return;
		}
		bool flag = false;
		Assembly assembly = typeof(SecurityCriticalAttribute).Assembly;
		MemberInfo memberInfo = memberInfo_0;
		while ((object)memberInfo != null)
		{
			object[] customAttributes = memberInfo.GetCustomAttributes(inherit: false);
			for (int i = 0; i < customAttributes.Length; i++)
			{
				Type type = customAttributes[i].GetType();
				if ((object)type.Assembly == assembly)
				{
					string fullName = type.FullName;
					if (Class84.smethod_0(-994272139).Equals(fullName, StringComparison.Ordinal))
					{
						flag = true;
						goto end_IL_0094;
					}
					if (Class84.smethod_0(-994272123).Equals(fullName, StringComparison.Ordinal))
					{
						goto end_IL_0094;
					}
				}
			}
			memberInfo = memberInfo.DeclaringType;
			continue;
			end_IL_0094:
			break;
		}
		if (flag)
		{
			if (memberInfo_0 is MethodBase)
			{
				string string_ = smethod_233((MethodBase)memberInfo_0);
				throw smethod_125(method_4(class36_0), string_);
			}
			if (memberInfo_0 is FieldInfo)
			{
				string string_2 = memberInfo_0.DeclaringType.FullName + Class84.smethod_0(-994272055) + memberInfo_0.Name;
				throw smethod_5(method_4(class36_0), string_2);
			}
			if (memberInfo_0 is Type)
			{
				string fullName2 = ((Type)memberInfo_0).FullName;
				throw smethod_175(method_4(class36_0), fullName2);
			}
			throw new SecurityException(Class84.smethod_0(-994272063));
		}
	}

	private static void smethod_7(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_81(bool_2: true);
	}

	private static Class40 smethod_8(Class104 class104_0)
	{
		Class6 @class = class104_0.method_80();
		Class6 class2 = class104_0.method_80();
		Class6 class3 = class104_0.method_80();
		if (@class.method_0() != 12)
		{
			throw new InvalidOperationException();
		}
		long long_ = ((Class33)@class).method_3();
		int num = class2.method_0();
		if (num != 24 && num != 26)
		{
			throw new InvalidOperationException();
		}
		byte[] byte_ = Class112.smethod_3(class2.vmethod_0());
		if (class3.method_0() != 6)
		{
			throw new InvalidOperationException();
		}
		int int_ = ((Class31)class3).method_3();
		Class40 class4 = new Class40();
		class4.method_0(int_);
		class4.method_1(byte_);
		class4.method_2(long_);
		return class4;
	}

	private string method_4(Class36 class36_1)
	{
		Type type = method_71(class36_1.method_6(), bool_2: false);
		Class114[] array = class36_1.method_2();
		string[] array2 = new string[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = method_71(array[i].method_0(), bool_2: false)?.FullName;
		}
		string text = string.Join(Class84.smethod_0(-994271851), array2);
		return type.FullName + Class84.smethod_0(-994272055) + class36_1.method_4() + Class84.smethod_0(-994271858) + text + Class84.smethod_0(-994271866);
	}

	private static void smethod_9(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_100();
	}

	private static void smethod_10(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_16(0);
	}

	private long method_5(string string_0)
	{
		MemoryStream memoryStream = new MemoryStream(Class81.smethod_0(string_0));
		long result = new Class48(new Class69(memoryStream, method_104())).method_21();
		memoryStream.Dispose();
		return result;
	}

	private static void smethod_11(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_45(bool_2: true);
	}

	private void method_6()
	{
		if (!class96_0.method_0())
		{
			lock (class96_0)
			{
				if (!class96_0.method_0())
				{
					dictionary_4 = smethod_230(class96_0);
					method_11();
					class96_0.method_1(bool_1: true);
				}
			}
		}
		if (dictionary_4 == null)
		{
			dictionary_4 = smethod_230(class96_0);
		}
	}

	private static Class6 smethod_12(Class6 class6_4, Class6 class6_5, bool bool_2, bool bool_3)
	{
		if (!bool_3)
		{
			long num = ((Class33)class6_4).method_3();
			long num2 = ((Class33)class6_5).method_3();
			long long_ = ((!bool_2) ? (num + num2) : checked(num + num2));
			return new Class33(long_);
		}
		ulong num3 = (ulong)((Class33)class6_4).method_3();
		ulong num4 = (ulong)((Class33)class6_5).method_3();
		ulong long_2 = ((!bool_2) ? (num3 + num4) : checked(num3 + num4));
		return new Class33((long)long_2);
	}

	private Class37[] method_7(Class48 class48_2)
	{
		Class37[] array = new Class37[class48_2.method_23()];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = method_75(class48_2);
		}
		return array;
	}

	private static void smethod_13(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_39(5);
	}

	private static void smethod_14(Class104 class104_0, Class6 class6_4)
	{
		throw new NotSupportedException(Class84.smethod_0(-994271538));
	}

	private void method_8(object object_3)
	{
		if (object_3 is Exception exception_)
		{
			smethod_139(exception_);
		}
		smethod_44(object_3);
	}

	private static string smethod_15(string string_0, string string_1)
	{
		string fullName = typeof(Class104).Assembly.FullName;
		return Class84.smethod_0(-994272528) + string_0 + Class84.smethod_0(-994272542) + string_1 + Class84.smethod_0(-994272492) + Environment.NewLine + Environment.NewLine + Class84.smethod_0(-994272509) + fullName + Class84.smethod_0(-994272460);
	}

	private static void smethod_16(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_23(bool_2: false);
	}

	private static void smethod_17(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_53(Class99.type_0);
	}

	private static void smethod_18(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_83(typeof(long));
	}

	private void method_9(Class18 class18_0, Class6 class6_4)
	{
		switch (class18_0.method_0())
		{
		default:
			throw new ArgumentOutOfRangeException();
		case 20:
		{
			Class20 class3 = (Class20)class18_0;
			FieldInfo fieldInfo = class3.method_5();
			Class6 class4 = Class6.smethod_0(class6_4.vmethod_0(), fieldInfo.FieldType);
			fieldInfo.SetValue(class3.method_3(), class4.vmethod_0());
			Class18 class5 = class3.method_7();
			if (class5 != null && fieldInfo.DeclaringType.IsValueType)
			{
				method_9(class5, Class6.smethod_0(class3.method_3(), null));
			}
			break;
		}
		case 21:
			class6_1[((Class19)class18_0).method_3()].vmethod_2(class6_4);
			break;
		case 7:
			((Class21)class18_0).method_3().vmethod_2(class6_4);
			break;
		case 2:
		case 17:
		{
			Class22 @class = (Class22)class18_0;
			Class6 class2 = Class6.smethod_0(class6_4.vmethod_0(), @class.method_3());
			@class.vmethod_5(class2.vmethod_0());
			break;
		}
		}
	}

	private static void smethod_19(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_16(3);
	}

	private static void smethod_20(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_83(typeof(ushort));
	}

	private static void smethod_21(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_40(2);
	}

	private static void smethod_22(Class104 class104_0, Class6 class6_4)
	{
	}

	private static void smethod_23(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_100();
	}

	private void method_10(Type type_9, object object_3, long long_1, Array array_0)
	{
		Class6 @class = Class6.smethod_0(object_3, type_9);
		array_0.SetValue(@class.vmethod_0(), long_1);
	}

	private static bool smethod_24(Class6 class6_4, Class6 class6_5)
	{
		bool result = false;
		switch (class6_4.method_0())
		{
		case 26:
			result = class6_4.vmethod_0() == class6_5.vmethod_0();
			break;
		case 25:
			if (class6_5.method_0() == 26 && class6_5.vmethod_0() == null)
			{
				result = ((Class10)class6_4).method_3() == UIntPtr.Zero;
			}
			else if (class6_5.method_0() != 6)
			{
				result = ((class6_5.method_0() != 12) ? (((Class10)class6_4).method_3() == ((Class10)class6_5).method_3()) : (((Class10)class6_4).method_3() == new UIntPtr((ulong)((Class33)class6_5).method_3())));
			}
			else
			{
				result = ((Class10)class6_4).method_3() == new UIntPtr((uint)((Class31)class6_5).method_3());
			}
			break;
		case 1:
		{
			Class15 class7 = (Class15)class6_4;
			if (class6_5.method_0() == 1)
			{
				result = Convert.ToInt64(class7.method_3()) == Convert.ToInt64(((Class15)class6_5).method_3());
			}
			else if (class7.method_3() == null)
			{
				result = class6_5.vmethod_0() == null;
			}
			else if (class6_5.vmethod_0() != null)
			{
				result = Convert.ToInt64(class7.method_3()) == Convert.ToInt64(class6_5.vmethod_0());
			}
			break;
		}
		case 6:
			if (class6_5.method_0() != 1)
			{
				result = ((class6_5.method_0() != 26 || class6_5.vmethod_0() != null) ? (((Class31)class6_4).method_3() == ((Class31)class6_5).method_3()) : (((Class31)class6_4).method_3() == 0));
			}
			else
			{
				result = ((Class31)class6_4).method_3() == Convert.ToInt64(((Class15)class6_5).method_3());
			}
			break;
		case 7:
		{
			Class21 class6 = (Class21)class6_4;
			result = smethod_24(class6_5: ((Class21)class6_5).method_3(), class6_4: class6.method_3());
			break;
		}
		case 11:
			result = (class6_5.method_0() != 26 || class6_5.vmethod_0() != null) && ((Class32)class6_4).method_3() == ((Class32)class6_5).method_3();
			break;
		case 12:
			if (class6_5.method_0() != 1)
			{
				result = ((class6_5.method_0() != 26 || class6_5.vmethod_0() != null) ? (((Class33)class6_4).method_3() == ((Class33)class6_5).method_3()) : (((Class33)class6_4).method_3() == 0L));
			}
			else
			{
				result = ((Class33)class6_4).method_3() == Convert.ToInt64(((Class15)class6_5).method_3());
			}
			break;
		case 15:
		{
			double d = ((Class11)class6_4).method_3();
			double num = ((Class11)class6_5).method_3();
			result = !double.IsNaN(d) && !double.IsNaN(num) && d.Equals(num);
			break;
		}
		case 2:
		case 17:
		{
			Class22 class5 = (Class22)class6_4;
			Class22 class22_ = (Class22)class6_5;
			result = class5.vmethod_6(class22_);
			break;
		}
		case 18:
			if (class6_5.method_0() == 26 && class6_5.vmethod_0() == null)
			{
				result = ((Class26)class6_4).method_3() == IntPtr.Zero;
			}
			else if (class6_5.method_0() != 6)
			{
				result = ((class6_5.method_0() != 12) ? (((Class26)class6_4).method_3() == ((Class26)class6_5).method_3()) : (((Class26)class6_4).method_3() == new IntPtr(((Class33)class6_5).method_3())));
			}
			else
			{
				result = ((Class26)class6_4).method_3() == new IntPtr(((Class31)class6_5).method_3());
			}
			break;
		default:
			result = class6_4.vmethod_0() == class6_5.vmethod_0();
			break;
		case 20:
		{
			Class20 class3 = (Class20)class6_4;
			Class20 class4 = (Class20)class6_5;
			result = class3.method_3() == class4.method_3() && (object)class3.method_5() == class4.method_5();
			break;
		}
		case 21:
		{
			Class19 @class = (Class19)class6_4;
			Class19 class2 = (Class19)class6_5;
			result = @class.method_3() == class2.method_3();
			break;
		}
		}
		return result;
	}

	private static void smethod_25(Class104 class104_0, Class6 class6_4)
	{
		Class12 @class = (Class12)class6_4;
		class104_0.method_16(@class.method_3());
	}

	private static void smethod_26(Class104 class104_0, Class6 class6_4)
	{
		uint uint_ = ((Class28)class6_4).method_3();
		class104_0.method_93(null, uint_);
	}

	private void method_11()
	{
	}

	private static bool smethod_27()
	{
		return false;
	}

	private static void smethod_28(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_95(typeof(short));
	}

	private static void smethod_29(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_69(bool_2: false);
	}

	private static bool smethod_30(MethodBase methodBase_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		int num = 0;
		while (true)
		{
			if (num < parameters.Length)
			{
				if (parameters[num].ParameterType.IsByRef)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static void smethod_31(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_95(Class99.type_0);
	}

	private static Delegate1 smethod_32(MethodBase methodBase_0, bool bool_2)
	{
		DynamicMethod dynamicMethod = null;
		dynamicMethod = new DynamicMethod(string.Empty, Class99.type_0, new Type[2]
		{
			Class99.type_0,
			type_0
		}, typeof(Class104).Module, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		Type[] array = new Type[parameters.Length];
		bool flag = false;
		for (int i = 0; i < parameters.Length; i++)
		{
			Type type = parameters[i].ParameterType;
			if (type.IsByRef)
			{
				flag = true;
				type = type.GetElementType();
			}
			array[i] = type;
		}
		LocalBuilder[] array2 = new LocalBuilder[array.Length];
		if (array2.Length != 0)
		{
			dynamicMethod.InitLocals = true;
		}
		for (int j = 0; j < array.Length; j++)
		{
			array2[j] = iLGenerator.DeclareLocal(array[j]);
		}
		for (int k = 0; k < array.Length; k++)
		{
			iLGenerator.Emit(OpCodes.Ldarg_1);
			smethod_214(iLGenerator, k);
			iLGenerator.Emit(OpCodes.Ldelem_Ref);
			smethod_39(iLGenerator, array[k]);
			iLGenerator.Emit(OpCodes.Stloc, array2[k]);
		}
		if (flag)
		{
			iLGenerator.BeginExceptionBlock();
		}
		if (!methodBase_0.IsStatic && !methodBase_0.IsConstructor)
		{
			iLGenerator.Emit(OpCodes.Ldarg_0);
			Type declaringType = methodBase_0.DeclaringType;
			if (declaringType.IsValueType)
			{
				iLGenerator.Emit(OpCodes.Unbox, declaringType);
				bool_2 = false;
			}
			else
			{
				smethod_202(iLGenerator, declaringType);
			}
		}
		for (int l = 0; l < array.Length; l++)
		{
			if (parameters[l].ParameterType.IsByRef)
			{
				iLGenerator.Emit(OpCodes.Ldloca_S, array2[l]);
			}
			else
			{
				iLGenerator.Emit(OpCodes.Ldloc, array2[l]);
			}
		}
		if (methodBase_0.IsConstructor)
		{
			iLGenerator.Emit(OpCodes.Newobj, (ConstructorInfo)methodBase_0);
			smethod_183(iLGenerator, methodBase_0.DeclaringType);
		}
		else
		{
			MethodInfo methodInfo = (MethodInfo)methodBase_0;
			if (bool_2 && !methodBase_0.IsStatic)
			{
				iLGenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
			}
			else
			{
				iLGenerator.EmitCall(OpCodes.Call, methodInfo, null);
			}
			if ((object)methodInfo.ReturnType == type_3)
			{
				iLGenerator.Emit(OpCodes.Ldnull);
			}
			else
			{
				smethod_183(iLGenerator, methodInfo.ReturnType);
			}
		}
		if (flag)
		{
			LocalBuilder local = iLGenerator.DeclareLocal(Class99.type_0);
			iLGenerator.Emit(OpCodes.Stloc, local);
			iLGenerator.BeginFinallyBlock();
			for (int m = 0; m < array.Length; m++)
			{
				if (parameters[m].ParameterType.IsByRef)
				{
					iLGenerator.Emit(OpCodes.Ldarg_1);
					smethod_214(iLGenerator, m);
					iLGenerator.Emit(OpCodes.Ldloc, array2[m]);
					if (array2[m].LocalType.IsValueType || Class99.smethod_1(array2[m].LocalType).IsGenericParameter)
					{
						iLGenerator.Emit(OpCodes.Box, array2[m].LocalType);
					}
					iLGenerator.Emit(OpCodes.Stelem_Ref);
				}
			}
			iLGenerator.EndExceptionBlock();
			iLGenerator.Emit(OpCodes.Ldloc, local);
		}
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate1)dynamicMethod.CreateDelegate(typeof(Delegate1));
	}

	private static void smethod_33(Class104 class104_0, Class6 class6_4)
	{
		Class31 @class = (Class31)class6_4;
		MethodBase methodBase_ = class104_0.method_15(@class.method_3());
		class104_0.method_28(methodBase_, bool_2: false);
	}

	private static void smethod_34(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_62(bool_2: false);
	}

	private static void smethod_35(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		if (smethod_24(class104_0.method_80(), class6_5))
		{
			uint uint_ = ((Class28)class6_4).method_3();
			class104_0.method_92(uint_);
		}
	}

	private static void smethod_36(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_62(bool_2: true);
	}

	private void method_12(bool bool_2, bool bool_3)
	{
		Class6 class6_ = method_80();
		Class6 class6_2 = method_80();
		method_35(smethod_229(class6_2, class6_, bool_2, bool_3));
	}

	private static void smethod_37(Class104 class104_0, Class6 class6_4)
	{
		Class14 @class = (Class14)class6_4;
		Class21 class2 = new Class21();
		class2.method_4(class104_0.class6_3[@class.method_3()]);
		class104_0.method_35(class2);
	}

	private static void smethod_38(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_21(bool_2: false, bool_3: false);
	}

	private static void smethod_39(ILGenerator ilgenerator_0, Type type_9)
	{
		if (!type_9.IsValueType && !Class99.smethod_1(type_9).IsGenericParameter)
		{
			smethod_202(ilgenerator_0, type_9);
		}
		else
		{
			ilgenerator_0.Emit(OpCodes.Unbox_Any, type_9);
		}
	}

	private void method_13(Class6 class6_4)
	{
		Class31 @class = (Class31)class6_4;
		MethodBase methodBase = method_15(@class.method_3());
		if ((object)type_1 != null)
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			Type[] array = new Type[parameters.Length];
			int num = 0;
			ParameterInfo[] array2 = parameters;
			foreach (ParameterInfo parameterInfo in array2)
			{
				array[num++] = parameterInfo.ParameterType;
			}
			MethodInfo method = type_1.GetMethod(methodBase.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array, null);
			if ((object)method != null)
			{
				methodBase = method;
			}
			type_1 = null;
		}
		method_28(methodBase, bool_2: true);
	}

	private static void smethod_40(Class104 class104_0, Class6 class6_4)
	{
		Class31 @class = (Class31)class6_4;
		MethodBase methodBase_ = class104_0.method_15(@class.method_3());
		Class6[] array = class104_0.class6_3;
		foreach (Class6 class6_5 in array)
		{
			class104_0.method_35(class6_5);
		}
		class104_0.method_28(methodBase_, bool_2: false);
	}

	private static void smethod_41(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_35(class6_4);
	}

	private void method_14(bool bool_2)
	{
		Class6 class6_ = method_80();
		Class6 class6_2 = method_80();
		method_35(smethod_133(class6_2, class6_, bool_2));
	}

	[Conditional("DEBUG")]
	public static void smethod_42(string string_0)
	{
	}

	private static Class6 smethod_43(Class6 class6_4, Class6 class6_5, bool bool_2, bool bool_3)
	{
		if (class6_4.method_0() == 6)
		{
			if (class6_5.method_0() == 6)
			{
				if (!bool_3)
				{
					int num = ((Class31)class6_4).method_3();
					int num2 = ((Class31)class6_5).method_3();
					int int_ = ((!bool_2) ? (num + num2) : checked(num + num2));
					return new Class31(int_);
				}
				uint num3 = (uint)((Class31)class6_4).method_3();
				uint num4 = (uint)((Class31)class6_5).method_3();
				uint int_2 = ((!bool_2) ? (num3 + num4) : checked(num3 + num4));
				return new Class31((int)int_2);
			}
			if (class6_5.method_0() == 12)
			{
				return smethod_12(new Class33(((Class31)class6_4).method_3()), class6_5, bool_2, bool_3);
			}
			if (class6_5.method_0() == 1)
			{
				Type underlyingType = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType != typeof(long) && (object)underlyingType != typeof(ulong))
				{
					return smethod_43(class6_4, new Class31(Convert.ToInt32(class6_5.vmethod_0())), bool_2, bool_3);
				}
				return smethod_12(new Class33(((Class31)class6_4).method_3()), new Class33(Convert.ToInt64(class6_5.vmethod_0())), bool_2, bool_3);
			}
		}
		if (class6_4.method_0() == 12)
		{
			if (class6_5.method_0() == 12)
			{
				return smethod_12(class6_4, class6_5, bool_2, bool_3);
			}
			if (class6_5.method_0() == 6)
			{
				return smethod_12(class6_4, new Class33(((Class31)class6_5).method_3()), bool_2, bool_3);
			}
			if (class6_5.method_0() == 1)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType2 != typeof(long) && (object)underlyingType2 != typeof(ulong))
				{
					return smethod_12(class6_4, new Class31(Convert.ToInt32(class6_5.vmethod_0())), bool_2, bool_3);
				}
				return smethod_12(class6_4, new Class33(Convert.ToInt64(class6_5.vmethod_0())), bool_2, bool_3);
			}
		}
		if (class6_4.method_0() == 15 && class6_5.method_0() == 15)
		{
			Class11 @class = new Class11();
			@class.method_4(((Class11)class6_4).method_3() + ((Class11)class6_5).method_3());
			return @class;
		}
		if (class6_4.method_0() == 1)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(class6_4.vmethod_0().GetType());
			if ((object)underlyingType3 != typeof(long) && (object)underlyingType3 != typeof(ulong))
			{
				return smethod_43(new Class31(Convert.ToInt32(class6_4.vmethod_0())), class6_5, bool_2, bool_3);
			}
			return smethod_43(new Class33(Convert.ToInt64(class6_4.vmethod_0())), class6_5, bool_2, bool_3);
		}
		throw new InvalidOperationException();
	}

	[DebuggerNonUserCode]
	private MethodBase method_15(int int_0)
	{
		Class70 class70_ = method_20(int_0);
		MethodBase methodBase = method_77(int_0, class70_);
		method_3(methodBase);
		return methodBase;
	}

	private void method_16(int int_0)
	{
		Class6 @class = method_80();
		if (@class is Class18)
		{
			class6_1[int_0] = @class;
		}
		else
		{
			class6_1[int_0].vmethod_2(@class);
		}
	}

	private static void smethod_44(object object_3)
	{
		throw object_3;
	}

	private static BindingFlags smethod_45(bool bool_2)
	{
		BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic;
		if (bool_2)
		{
			return bindingFlags | BindingFlags.Static;
		}
		return bindingFlags | BindingFlags.Instance;
	}

	private static void smethod_46(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_74(bool_2: true);
	}

	private static void smethod_47(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_59(((Class14)class6_4).method_3());
	}

	private void method_17()
	{
		if (stack_2.Count == 0)
		{
			if (bool_1)
			{
				method_8(object_2);
			}
			return;
		}
		Struct7 @struct = stack_2.Pop();
		if (@struct.method_1() != null)
		{
			Class8 @class = new Class8();
			@class.vmethod_1(@struct.method_1());
			method_35(@class);
		}
		else
		{
			method_82();
		}
		method_92(@struct.method_0());
	}

	private static void smethod_48(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_16(1);
	}

	private static void smethod_49(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_83(typeof(sbyte));
	}

	private void method_18(ref Struct8 struct8_0, MethodBase methodBase_0, bool bool_2)
	{
		bool flag = false;
		if ((object)methodBase_0.DeclaringType == typeof(Interlocked) && methodBase_0.IsStatic)
		{
			string name = methodBase_0.Name;
			if (name == Class84.smethod_0(-994275156) || name == Class84.smethod_0(-994275162) || name == Class84.smethod_0(-994275124) || name == Class84.smethod_0(-994275076) || name == Class84.smethod_0(-994275093) || name == Class84.smethod_0(-994275045))
			{
				flag = true;
			}
		}
		if (flag)
		{
			try
			{
			}
			finally
			{
				Monitor.Enter(object_1);
				struct8_0.bool_0 = true;
			}
		}
	}

	private static void smethod_50(Class104 class104_0, Class6 class6_4)
	{
		throw new NotSupportedException(Class84.smethod_0(-994272250));
	}

	private static void smethod_51(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_83(typeof(uint));
	}

	private object method_19(Stream stream_1, int int_0, object[] object_3, Type[] type_9, Type[] type_10, object[] object_4)
	{
		stream_0 = stream_1;
		method_97(stream_1, int_0, null);
		return method_37(object_3, type_9, type_10, object_4);
	}

	private static void smethod_52(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		class104_0.method_35(new Class31(@class.method_0() switch
		{
			6 => (int)checked((short)(uint)((Class31)@class).method_3()), 
			1 => checked((short)Convert.ToUInt64(((Class15)@class).method_3())), 
			15 => checked((short)((Class11)@class).method_3()), 
			12 => checked((short)(ulong)((Class33)@class).method_3()), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private Class70 method_20(int int_0)
	{
		if (class48_1 == null)
		{
			throw new InvalidOperationException();
		}
		lock (class48_1.method_0())
		{
			class48_1.method_0().vmethod_9(int_0, 0);
			Class70 @class = new Class70();
			@class.method_1(class48_1.method_6());
			if (@class.method_0() == 1)
			{
				@class.method_3(class48_1.method_19());
			}
			else
			{
				@class.method_5(method_26(class48_1));
			}
			return @class;
		}
	}

	private static bool smethod_53(Class6 class6_4, Class6 class6_5)
	{
		bool result = false;
		switch (class6_4.method_0())
		{
		case 6:
			if (class6_5.method_0() == 1)
			{
				return smethod_53(class6_4, new Class31(Convert.ToInt32(((Class15)class6_5).method_3())));
			}
			result = (uint)((Class31)class6_4).method_3() < (uint)((Class31)class6_5).method_3();
			break;
		case 1:
			return smethod_53(new Class33(Convert.ToInt64(((Class15)class6_4).method_3())), class6_5);
		case 15:
		{
			double num = ((Class11)class6_4).method_3();
			double num2 = ((Class11)class6_5).method_3();
			result = num < num2 || double.IsNaN(num) || double.IsNaN(num2);
			break;
		}
		case 12:
			if (class6_5.method_0() == 1)
			{
				return smethod_53(class6_4, new Class33(Convert.ToInt64(((Class15)class6_5).method_3())));
			}
			if (class6_5.method_0() == 6)
			{
				return smethod_53(class6_4, new Class33(((Class31)class6_5).method_3()));
			}
			result = (ulong)((Class33)class6_4).method_3() < (ulong)((Class33)class6_5).method_3();
			break;
		}
		return result;
	}

	private void method_21(bool bool_2, bool bool_3)
	{
		Class6 class6_ = method_80();
		Class6 class6_2 = method_80();
		method_35(smethod_43(class6_2, class6_, bool_2, bool_3));
	}

	private static void smethod_54(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		FieldInfo fieldInfo = class104_0.method_79(int_);
		Class6 @class = Class6.smethod_0(class104_0.method_80().vmethod_0(), fieldInfo.FieldType);
		fieldInfo.SetValue(null, @class.vmethod_0());
	}

	private static bool smethod_55()
	{
		return false;
	}

	private void method_22(int int_0)
	{
		Class6 @class = method_80();
		class6_3[int_0].vmethod_2(@class);
	}

	private void method_23(bool bool_2)
	{
		Class6 @class = method_80();
		UIntPtr uintptr_ = @class.method_0() switch
		{
			6 => (!bool_2) ? new UIntPtr((uint)((Class31)@class).method_3()) : new UIntPtr(checked((uint)((Class31)@class).method_3())), 
			1 => (!bool_2) ? new UIntPtr(Convert.ToUInt64(((Class15)@class).method_3())) : new UIntPtr(Convert.ToUInt64(((Class15)@class).method_3())), 
			15 => (!bool_2) ? new UIntPtr((ulong)((Class11)@class).method_3()) : new UIntPtr(checked((ulong)((Class11)@class).method_3())), 
			12 => (!bool_2) ? new UIntPtr((ulong)((Class33)@class).method_3()) : new UIntPtr(checked((ulong)((Class33)@class).method_3())), 
			_ => throw new InvalidOperationException(), 
		};
		Class10 class2 = new Class10();
		class2.method_4(uintptr_);
		method_35(class2);
	}

	private static void smethod_56(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_100();
	}

	private void method_24(ref Struct8 struct8_0)
	{
		if (struct8_0.bool_0)
		{
			Monitor.Exit(object_1);
		}
	}

	private static void smethod_57(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		Class6 class6_6 = class104_0.method_80();
		class104_0.method_35(new Class31(smethod_89(class6_6, class6_5) ? 1 : 0));
	}

	private static void smethod_58(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_59(3);
	}

	private static void smethod_59(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		string string_ = class104_0.method_67(int_);
		Class9 @class = new Class9();
		@class.method_4(string_);
		class104_0.method_35(@class);
	}

	private static void smethod_60(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		if (smethod_53(class104_0.method_80(), class6_5))
		{
			uint uint_ = ((Class28)class6_4).method_3();
			class104_0.method_92(uint_);
		}
	}

	private static void smethod_61(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_29();
	}

	private static void smethod_62(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		bool flag = false;
		if (@class.method_0() switch
		{
			12 => ((Class33)@class).method_3() == 0L, 
			6 => ((Class31)@class).method_3() == 0, 
			1 => !Convert.ToBoolean(((Class15)@class).method_3()), 
			26 => ((Class8)@class).method_3() == null, 
			25 => ((Class10)@class).method_3() == UIntPtr.Zero, 
			18 => ((Class26)@class).method_3() == IntPtr.Zero, 
			_ => @class.vmethod_0() == null, 
		})
		{
			uint uint_ = ((Class28)class6_4).method_3();
			class104_0.method_92(uint_);
		}
	}

	private static void smethod_63(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		class104_0.method_35(class104_0.method_46(class6_5));
	}

	private static void smethod_64(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		FieldInfo fieldInfo = class104_0.method_79(int_);
		Class6 @class = class104_0.method_80();
		if (@class is Class18 class18_)
		{
			@class = class104_0.method_94(class18_);
		}
		object obj = @class.vmethod_0();
		if (obj == null)
		{
			throw new NullReferenceException();
		}
		class104_0.method_35(Class6.smethod_0(fieldInfo.GetValue(obj), fieldInfo.FieldType));
	}

	private static void smethod_65(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_27(bool_2: false);
	}

	private static void smethod_66(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		Type type = class104_0.method_71(int_, bool_2: true);
		Class18 class18_ = (Class18)class104_0.method_80();
		if (type.IsValueType)
		{
			object obj = class104_0.method_94(class18_).vmethod_0();
			if (Class99.smethod_0(type))
			{
				Class8 @class = new Class8();
				@class.method_2(type);
				class104_0.method_9(class18_, @class);
				return;
			}
			FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
			foreach (FieldInfo fieldInfo in fields)
			{
				fieldInfo.SetValue(obj, smethod_128(fieldInfo.FieldType));
			}
		}
		else
		{
			class104_0.method_9(class18_, new Class8());
		}
	}

	private static byte[] smethod_67(Class48 class48_2)
	{
		int num = class48_2.method_19();
		byte[] array = new byte[num];
		class48_2.method_14(array, 0, num);
		return array;
	}

	private static void smethod_68(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		class104_0.method_35(new Class31(@class.method_0() switch
		{
			6 => (int)checked((sbyte)(uint)((Class31)@class).method_3()), 
			1 => checked((sbyte)Convert.ToUInt64(((Class15)@class).method_3())), 
			15 => checked((sbyte)((Class11)@class).method_3()), 
			12 => checked((sbyte)(ulong)((Class33)@class).method_3()), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private Class6 method_25(Class6 class6_4, Class6 class6_5)
	{
		if (class6_4.method_0() == 6)
		{
			if (class6_5.method_0() == 6)
			{
				int num = ((Class31)class6_4).method_3();
				int num2 = ((Class31)class6_5).method_3();
				return new Class31(num | num2);
			}
			if (class6_5.method_0() == 1)
			{
				int num3 = ((Class31)class6_4).method_3();
				Type underlyingType = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType != typeof(long) && (object)underlyingType != typeof(ulong))
				{
					int num4 = Convert.ToInt32(class6_5.vmethod_0());
					return new Class31(num3 | num4);
				}
				long num5 = Convert.ToInt64(class6_5.vmethod_0());
				return new Class33(num3 | num5);
			}
		}
		if (class6_4.method_0() == 12)
		{
			if (class6_5.method_0() == 12)
			{
				long num6 = ((Class33)class6_4).method_3();
				long num7 = ((Class33)class6_5).method_3();
				return new Class33(num6 | num7);
			}
			if (class6_5.method_0() == 1)
			{
				int num8 = ((Class31)class6_4).method_3();
				long num9 = Convert.ToInt64(class6_5.vmethod_0());
				return new Class33(num8 | num9);
			}
		}
		if (class6_4.method_0() == 1)
		{
			if (class6_5.method_0() == 6)
			{
				int num10 = ((Class31)class6_5).method_3();
				Type underlyingType2 = Enum.GetUnderlyingType(class6_4.vmethod_0().GetType());
				if ((object)underlyingType2 != typeof(long) && (object)underlyingType2 != typeof(ulong))
				{
					return new Class31(Convert.ToInt32(class6_4.vmethod_0()) | num10);
				}
				return new Class33(Convert.ToInt64(class6_5.vmethod_0()) | num10);
			}
			if (class6_5.method_0() == 12)
			{
				long num11 = Convert.ToInt64(class6_4.vmethod_0());
				long num12 = ((Class33)class6_5).method_3();
				return new Class33(num11 | num12);
			}
			if (class6_5.method_0() == 1)
			{
				Type underlyingType3 = Enum.GetUnderlyingType(class6_4.vmethod_0().GetType());
				Type underlyingType4 = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType3 != typeof(long) && (object)underlyingType3 != typeof(ulong) && (object)underlyingType4 != typeof(long) && (object)underlyingType4 != typeof(ulong))
				{
					int num13 = Convert.ToInt32(class6_4.vmethod_0());
					int num14 = Convert.ToInt32(class6_5.vmethod_0());
					return new Class31(num13 | num14);
				}
				long num15 = Convert.ToInt64(class6_4.vmethod_0());
				long num16 = Convert.ToInt64(class6_5.vmethod_0());
				return new Class33(num15 | num16);
			}
		}
		throw new InvalidOperationException();
	}

	private Class55 method_26(Class48 class48_2)
	{
		switch (class48_2.method_6())
		{
		default:
			throw new ArgumentOutOfRangeException();
		case 0:
		{
			Class60 class11 = new Class60();
			class11.method_1(class48_2.method_9());
			return class11;
		}
		case 1:
		{
			Class56 class9 = new Class56();
			class9.method_1(class48_2.method_9());
			class9.method_5(class48_2.method_5());
			class9.method_3(class48_2.method_5());
			class9.method_11(class48_2.method_19());
			class9.method_9(class48_2.method_19());
			int num5 = class48_2.method_18();
			Class70[] array3 = new Class70[num5];
			for (int k = 0; k < num5; k++)
			{
				int num6 = k;
				Class70 class10 = new Class70();
				class10.method_1(0);
				class10.method_3(class48_2.method_19());
				array3[num6] = class10;
			}
			class9.method_7(array3);
			return class9;
		}
		case 2:
		{
			Class59 class4 = new Class59();
			Class70 class5 = new Class70();
			class5.method_1(0);
			class5.method_3(class48_2.method_19());
			class4.method_5(class5);
			class4.method_1(class48_2.method_6());
			class4.method_7(class48_2.method_9());
			Class70 class6 = new Class70();
			class6.method_1(0);
			class6.method_3(class48_2.method_19());
			class4.method_13(class6);
			int num = class48_2.method_18();
			Class70[] array = new Class70[num];
			for (int i = 0; i < num; i++)
			{
				int num2 = i;
				Class70 class7 = new Class70();
				class7.method_1(0);
				class7.method_3(class48_2.method_19());
				array[num2] = class7;
			}
			class4.method_9(array);
			int num3 = class48_2.method_18();
			Class70[] array2 = new Class70[num3];
			for (int j = 0; j < num3; j++)
			{
				int num4 = j;
				Class70 class8 = new Class70();
				class8.method_1(0);
				class8.method_3(class48_2.method_19());
				array2[num4] = class8;
			}
			class4.method_11(array2);
			return class4;
		}
		case 3:
		{
			Class58 class3 = new Class58();
			class3.method_1(class48_2.method_19());
			class3.method_3(class48_2.method_19());
			return class3;
		}
		case 4:
		{
			Class57 @class = new Class57();
			Class70 class2 = new Class70();
			class2.method_1(0);
			class2.method_3(class48_2.method_19());
			@class.method_1(class2);
			@class.method_3(class48_2.method_9());
			@class.method_5(class48_2.method_5());
			return @class;
		}
		}
	}

	private static void smethod_69(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_35(class6_4);
	}

	private void method_27(bool bool_2)
	{
		Class6 class6_ = method_80();
		Class6 class6_2 = method_80();
		method_35(smethod_90(class6_2, class6_, bool_2));
	}

	private static void smethod_70(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_21(bool_2: true, bool_3: true);
	}

	private void method_28(MethodBase methodBase_0, bool bool_2)
	{
		bool flag;
		if ((flag = !bool_2 && method_1(methodBase_0)) && Class105.bool_0)
		{
			methodBase_0 = Class107.smethod_0(this, class36_0, methodBase_0, bool_2);
		}
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		int num = parameters.Length;
		Class6[] array = new Class6[num];
		object[] array2 = new object[num];
		Struct8 struct8_ = default;
		try
		{
			method_18(ref struct8_, methodBase_0, bool_2);
			for (int num2 = num - 1; num2 >= 0; num2--)
			{
				Class6 @class = (array[num2] = method_80());
				if (@class is Class18 class18_)
				{
					@class = method_94(class18_);
				}
				if ((object)@class.method_1() != null)
				{
					@class = Class6.smethod_0(null, @class.method_1()).vmethod_2(@class);
				}
				Class6 class2 = Class6.smethod_0(null, parameters[num2].ParameterType).vmethod_2(@class);
				array2[num2] = class2.vmethod_0();
			}
			Class6 class3 = null;
			if (!methodBase_0.IsStatic)
			{
				class3 = method_80();
				if (class3 != null && (object)class3.method_1() != null)
				{
					class3 = Class6.smethod_0(null, class3.method_1()).vmethod_2(class3);
				}
			}
			object object_ = null;
			object obj = null;
			try
			{
				if (methodBase_0.IsConstructor)
				{
					object_ = Activator.CreateInstance(methodBase_0.DeclaringType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, array2, null);
					if (!(class3 is Class18))
					{
						throw new InvalidOperationException();
					}
					obj = object_;
				}
				else
				{
					if (class3 != null)
					{
						Class6 class4 = class3;
						if (class3 is Class18 class18_2)
						{
							class4 = method_94(class18_2);
						}
						obj = class4.vmethod_0();
					}
					try
					{
						if (!method_99(methodBase_0, obj, ref object_, array2))
						{
							if (bool_2 && !methodBase_0.IsStatic && obj == null)
							{
								throw new NullReferenceException();
							}
							if (!method_30(methodBase_0, obj, array, array2, bool_2, ref object_))
							{
								MethodBase methodBase_1 = methodBase_0;
								object object_2 = obj;
								if (flag && !Class105.bool_0)
								{
									object_2 = Class111.smethod_0(obj, methodBase_0, out var methodInfo_);
									methodBase_1 = methodInfo_;
								}
								object_ = smethod_192(methodBase_1, object_2, array2, bool_2);
							}
						}
					}
					catch (TargetInvocationException ex)
					{
						Exception object_3 = ex.InnerException ?? ex;
						method_8(object_3);
					}
				}
			}
			finally
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] is Class18 class18_3)
					{
						object obj2 = array2[i];
						method_9(class18_3, Class6.smethod_0(obj2, null));
					}
				}
				if (obj != null && class3 is Class18 class18_4)
				{
					method_9(class18_4, Class6.smethod_0(obj, methodBase_0.DeclaringType));
				}
			}
			if (methodBase_0 is MethodInfo { ReturnType: var returnType } && (object)returnType != type_3)
			{
				method_35(Class6.smethod_0(object_, returnType));
			}
		}
		finally
		{
			method_24(ref struct8_);
		}
	}

	private static void smethod_71(Class104 class104_0, Class6 class6_4)
	{
		Class40 @class = smethod_8(class104_0);
		Class67 class67_ = class104_0.class48_0.method_0();
		long num = class104_0.method_106();
		byte[] array = new Class54(@class.imethod_1(), @class.imethod_2()).method_1(class67_, @class);
		Class110 class2 = new Class110
		{
			class40_0 = @class,
			long_0 = num
		};
		@class.method_4(Class53.smethod_1(array.Length) - array.Length);
		class2.class48_0 = new Class48(class2.class67_0 = new Class68(array, 0, array.Length, bool_4: false));
		class104_0.method_73().Push(class2);
		class104_0.method_52(class2);
	}

	private static void smethod_72(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		FieldInfo fieldInfo_ = class104_0.method_79(int_);
		class104_0.method_35(new Class20(fieldInfo_, null));
	}

	private void method_29()
	{
		bool_0 = true;
	}

	private static void smethod_73(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_39(4);
	}

	private bool method_30(MethodBase methodBase_0, object object_3, Class6[] class6_4, object[] object_4, bool bool_2, ref object object_5)
	{
		Type declaringType = methodBase_0.DeclaringType;
		if ((object)declaringType == null)
		{
			return false;
		}
		if ((object)declaringType == type_4 && methodBase_0.Name == Class84.smethod_0(-994271939) && object_4.Length == 2 && methodBase_0.ToString() == Class84.smethod_0(-994271965))
		{
			Class51.smethod_0((Array)object_4[0], (RuntimeFieldHandle)object_4[1]);
			return true;
		}
		return false;
	}

	private static bool smethod_74(Class6 class6_4, Class6 class6_5)
	{
		bool result = false;
		switch (class6_4.method_0())
		{
		case 6:
			if (class6_5.method_0() == 1)
			{
				return smethod_74(class6_4, new Class31(Convert.ToInt32(((Class15)class6_5).method_3())));
			}
			result = ((Class31)class6_4).method_3() > ((Class31)class6_5).method_3();
			break;
		case 1:
			return smethod_74(new Class33(Convert.ToInt64(((Class15)class6_4).method_3())), class6_5);
		case 15:
		{
			double num = ((Class11)class6_4).method_3();
			double num2 = ((Class11)class6_5).method_3();
			result = !double.IsNaN(num) && !double.IsNaN(num2) && num > num2;
			break;
		}
		case 12:
			if (class6_5.method_0() == 1)
			{
				return smethod_74(class6_4, new Class33(Convert.ToInt64(((Class15)class6_5).method_3())));
			}
			if (class6_5.method_0() == 6)
			{
				return smethod_74(class6_4, new Class33(((Class31)class6_5).method_3()));
			}
			result = ((Class33)class6_4).method_3() > ((Class33)class6_5).method_3();
			break;
		}
		return result;
	}

	private static void smethod_75(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		if (smethod_77(class104_0.method_80(), class6_5))
		{
			uint uint_ = ((Class28)class6_4).method_3();
			class104_0.method_92(uint_);
		}
	}

	private static void smethod_76(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_83(typeof(float));
	}

	private static bool smethod_77(Class6 class6_4, Class6 class6_5)
	{
		bool flag = false;
		switch (class6_4.method_0())
		{
		case 11:
			if (class6_5.method_0() == 26 && class6_5.vmethod_0() == null)
			{
				return true;
			}
			return ((Class32)class6_4).method_3() != ((Class32)class6_5).method_3();
		case 12:
			return (ulong)((Class33)class6_4).method_3() > (ulong)((Class33)class6_5).method_3();
		case 15:
		{
			double num3 = ((Class11)class6_4).method_3();
			double num4 = ((Class11)class6_5).method_3();
			return num3 > num4 || double.IsNaN(num3) || double.IsNaN(num4);
		}
		case 6:
			return (uint)((Class31)class6_4).method_3() > (uint)((Class31)class6_5).method_3();
		case 1:
		{
			long num = Convert.ToInt64(((Class15)class6_4).method_3());
			long num2 = ((class6_5.method_0() != 6) ? Convert.ToInt64(((Class15)class6_5).method_3()) : ((Class31)class6_5).method_3());
			return num > num2;
		}
		default:
			return class6_4.vmethod_0() != class6_5.vmethod_0();
		case 26:
			return ((Class8)class6_4).method_3() != ((Class8)class6_5).method_3();
		case 25:
			if (class6_5.method_0() == 26 && class6_5.vmethod_0() == null)
			{
				return ((Class10)class6_4).method_3() != UIntPtr.Zero;
			}
			return ((Class10)class6_4).method_3() != ((Class10)class6_5).method_3();
		case 18:
			if (class6_5.method_0() == 26 && class6_5.vmethod_0() == null)
			{
				return ((Class26)class6_4).method_3() != IntPtr.Zero;
			}
			return ((Class26)class6_4).method_3() != ((Class26)class6_5).method_3();
		}
	}

	private static void smethod_78(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_76(((Class12)class6_4).method_3());
	}

	private static void smethod_79(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		UIntPtr uintptr_ = @class.method_0() switch
		{
			6 => new UIntPtr((uint)((Class31)@class).method_3()), 
			1 => new UIntPtr(Convert.ToUInt64(((Class15)@class).method_3())), 
			15 => new UIntPtr((ulong)((Class11)@class).method_3()), 
			12 => new UIntPtr((ulong)((Class33)@class).method_3()), 
			_ => throw new InvalidOperationException(), 
		};
		Class10 class2 = new Class10();
		class2.method_4(uintptr_);
		class104_0.method_35(class2);
	}

	private static void smethod_80(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		double double_ = @class.method_0() switch
		{
			6 => ((Class31)@class).method_3(), 
			1 => Convert.ToUInt64(((Class15)@class).method_3()), 
			15 => ((Class11)@class).method_3(), 
			12 => ((Class33)@class).method_3(), 
			_ => throw new InvalidOperationException(), 
		};
		Class11 class2 = new Class11();
		class2.method_4(double_);
		class104_0.method_35(class2);
	}

	private Class6 method_31(Class6 class6_4, Class6 class6_5)
	{
		if (class6_4.method_0() == 6)
		{
			if (class6_5.method_0() == 6)
			{
				int num = ((Class31)class6_4).method_3();
				int num2 = ((Class31)class6_5).method_3();
				Class31 @class = new Class31();
				@class.method_4(num & num2);
				return @class;
			}
			if (class6_5.method_0() == 1)
			{
				int num3 = ((Class31)class6_4).method_3();
				Type underlyingType = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType != typeof(long) && (object)underlyingType != typeof(ulong))
				{
					int num4 = Convert.ToInt32(class6_5.vmethod_0());
					Class31 class2 = new Class31();
					class2.method_4(num3 & num4);
					return class2;
				}
				long num5 = Convert.ToInt64(class6_5.vmethod_0());
				return new Class33(num3 & num5);
			}
		}
		if (class6_4.method_0() == 12)
		{
			if (class6_5.method_0() == 12)
			{
				long num6 = ((Class33)class6_4).method_3();
				long num7 = ((Class33)class6_5).method_3();
				Class33 class3 = new Class33();
				class3.method_4(num6 & num7);
				return class3;
			}
			if (class6_5.method_0() == 1)
			{
				int num8 = ((Class31)class6_4).method_3();
				long num9 = Convert.ToInt64(class6_5.vmethod_0());
				return new Class33(num8 & num9);
			}
		}
		if (class6_4.method_0() == 1)
		{
			if (class6_5.method_0() == 6)
			{
				int num10 = ((Class31)class6_5).method_3();
				Type underlyingType2 = Enum.GetUnderlyingType(class6_4.vmethod_0().GetType());
				if ((object)underlyingType2 != typeof(long) && (object)underlyingType2 != typeof(ulong))
				{
					int num11 = Convert.ToInt32(class6_4.vmethod_0());
					Class31 class4 = new Class31();
					class4.method_4(num11 & num10);
					return class4;
				}
				return new Class33(Convert.ToInt64(class6_5.vmethod_0()) & num10);
			}
			if (class6_5.method_0() == 12)
			{
				long num12 = Convert.ToInt64(class6_4.vmethod_0());
				long num13 = ((Class33)class6_5).method_3();
				Class33 class5 = new Class33();
				class5.method_4(num12 & num13);
				return class5;
			}
			if (class6_5.method_0() == 1)
			{
				Type underlyingType3 = Enum.GetUnderlyingType(class6_4.vmethod_0().GetType());
				Type underlyingType4 = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType3 != typeof(long) && (object)underlyingType3 != typeof(ulong) && (object)underlyingType4 != typeof(long) && (object)underlyingType4 != typeof(ulong))
				{
					int num14 = Convert.ToInt32(class6_4.vmethod_0());
					int num15 = Convert.ToInt32(class6_5.vmethod_0());
					return new Class31(num14 & num15);
				}
				long num16 = Convert.ToInt64(class6_4.vmethod_0());
				long num17 = Convert.ToInt64(class6_5.vmethod_0());
				return new Class33(num16 & num17);
			}
		}
		throw new InvalidOperationException();
	}

	private static void smethod_81(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		Class6 class6_6 = class104_0.method_80();
		class104_0.method_35(class104_0.method_25(class6_6, class6_5));
	}

	private void method_32(bool bool_2)
	{
		Class6 @class = method_80();
		int int_ = @class.method_0() switch
		{
			6 => (!bool_2) ? ((Class31)@class).method_3() : ((Class31)@class).method_3(), 
			1 => (!bool_2) ? ((int)Convert.ToUInt64(((Class15)@class).method_3())) : checked((int)Convert.ToUInt64(((Class15)@class).method_3())), 
			15 => (!bool_2) ? ((int)((Class11)@class).method_3()) : checked((int)((Class11)@class).method_3()), 
			12 => (int)((!bool_2) ? ((Class33)@class).method_3() : checked((int)((Class33)@class).method_3())), 
			_ => throw new InvalidOperationException(), 
		};
		Class31 class2 = new Class31();
		class2.method_4(int_);
		method_35(class2);
	}

	private long method_33()
	{
		Class6 @class = method_80();
		return @class.method_0() switch
		{
			6 => ((Class31)@class).method_3(), 
			1 => Convert.ToInt64(((Class15)@class).method_3()), 
			25 => (long)((Class10)@class).method_3().ToUInt64(), 
			18 => ((Class26)@class).method_3().ToInt64(), 
			_ => throw new Exception(Class84.smethod_0(-994271631)), 
		};
	}

	private Class6[] method_34()
	{
		Class37[] array = class36_0.method_0();
		int num = array.Length;
		Class6[] array2 = new Class6[num];
		for (int i = 0; i < num; i++)
		{
			array2[i] = Class6.smethod_0(null, method_71(array[i].method_0(), bool_2: false));
		}
		return array2;
	}

	private static void smethod_82(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_51(bool_2: true);
	}

	public static void smethod_83<T>(T[] gparam_0, Comparison<T> comparison_0)
	{
		KeyValuePair<int, T>[] array = new KeyValuePair<int, T>[gparam_0.Length];
		for (int i = 0; i < gparam_0.Length; i++)
		{
			array[i] = new KeyValuePair<int, T>(i, gparam_0[i]);
		}
		Array.Sort(array, gparam_0, new Class109<T>(comparison_0));
	}

	private void method_35(Class6 class6_4)
	{
		if (class6_4 == null)
		{
			throw new ArgumentNullException(Class84.smethod_0(-994271673));
		}
		Class6 @class;
		if ((object)class6_4.method_1() != null)
		{
			@class = class6_4;
		}
		else
		{
			switch (class6_4.method_0())
			{
			case 22:
			{
				Class31 class3 = new Class31(((Class17)class6_4).method_3());
				class3.method_2(class6_4.method_1());
				@class = class3;
				break;
			}
			case 23:
			{
				Class31 class4 = new Class31((int)((Class28)class6_4).method_3());
				class4.method_2(class6_4.method_1());
				@class = class4;
				break;
			}
			case 26:
			{
				object obj = class6_4.vmethod_0();
				if (obj == null)
				{
					@class = class6_4;
					break;
				}
				Type type = obj.GetType();
				if (type.HasElementType && !type.IsArray)
				{
					type = type.GetElementType();
				}
				@class = (((object)type == null || type.IsValueType || type.IsEnum) ? Class6.smethod_0(obj, type) : class6_4);
				break;
			}
			case 8:
			{
				Class31 class10 = new Class31(((Class7)class6_4).method_3());
				class10.method_2(class6_4.method_1());
				@class = class10;
				break;
			}
			case 10:
			{
				Class33 class9 = new Class33((long)((Class27)class6_4).method_3());
				class9.method_2(class6_4.method_1());
				@class = class9;
				break;
			}
			case 13:
			{
				Class31 class8 = new Class31(((Class25)class6_4).method_3());
				class8.method_2(class6_4.method_1());
				@class = class8;
				break;
			}
			case 14:
			{
				Class11 class7 = new Class11();
				class7.method_4(((Class13)class6_4).method_3());
				class7.method_2(class6_4.method_1());
				@class = class7;
				break;
			}
			case 0:
			{
				Class31 class6 = new Class31(((Class14)class6_4).method_3());
				class6.method_2(class6_4.method_1());
				@class = class6;
				break;
			}
			default:
				@class = class6_4;
				break;
			case 3:
			{
				Class31 class5 = new Class31(((Class12)class6_4).method_3());
				class5.method_2(class6_4.method_1());
				@class = class5;
				break;
			}
			case 4:
			{
				Class31 class2 = new Class31(((Class30)class6_4).method_3() ? 1 : 0);
				class2.method_2(class6_4.method_1());
				@class = class2;
				break;
			}
			}
		}
		if (class6_0 != null)
		{
			if (class6_2 != null)
			{
				stack_0.Push(class6_2);
			}
			class6_2 = class6_0;
		}
		class6_0 = @class;
	}

	private static bool smethod_84(uint uint_3, uint uint_4, uint uint_5)
	{
		if (uint_3 >= uint_4)
		{
			return uint_3 <= uint_4 + uint_5;
		}
		return false;
	}

	private void method_36(Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		MethodBase methodBase = method_15(int_);
		Type declaringType = methodBase.DeclaringType;
		ParameterInfo[] parameters = methodBase.GetParameters();
		int num = parameters.Length;
		object[] array = new object[num];
		Dictionary<int, Class18> dictionary = new Dictionary<int, Class18>();
		for (int num2 = num - 1; num2 >= 0; num2--)
		{
			Class6 @class = method_80();
			if (@class is Class18 class2)
			{
				dictionary.Add(num2, class2);
				@class = method_94(class2);
			}
			if ((object)@class.method_1() != null)
			{
				@class = Class6.smethod_0(null, @class.method_1()).vmethod_2(@class);
			}
			Class6 class3 = Class6.smethod_0(null, parameters[num2].ParameterType).vmethod_2(@class);
			array[num2] = class3.vmethod_0();
		}
		object obj;
		try
		{
			obj = smethod_192(methodBase, null, array, bool_2: false);
		}
		catch (TargetInvocationException ex)
		{
			Exception object_ = ex.InnerException ?? ex;
			method_8(object_);
			return;
		}
		foreach (KeyValuePair<int, Class18> item in dictionary)
		{
			method_9(item.Value, Class6.smethod_0(array[item.Key], null));
		}
		method_35(Class6.smethod_0(obj, declaringType));
	}

	private static void smethod_85(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_32(bool_2: true);
	}

	private static void smethod_86(Class104 class104_0, Class6 class6_4)
	{
	}

	private static void smethod_87(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_43(bool_2: false);
	}

	private object method_37(object[] object_3, Type[] type_9, Type[] type_10, object[] object_4)
	{
		method_54();
		if (object_3 == null)
		{
			object_3 = Class73<object>.gparam_0;
		}
		object_0 = object_4;
		type_8 = type_9;
		type_2 = type_10;
		class6_3 = method_105(object_3);
		class6_1 = method_34();
		try
		{
			Class68 @class = new Class68(byte_0);
			try
			{
				using (class48_0 = new Class48(@class))
				{
					uint_0 = (uint)@class.vmethod_3();
					bool_0 = false;
					nullable_0 = null;
					uint_2 = 0u;
					uint_1 = 0u;
					method_82();
					method_70();
				}
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			Type type = method_71(class36_0.method_8(), bool_2: false);
			if ((object)type != type_3 && method_49())
			{
				return Class6.smethod_0(null, type).vmethod_2(method_80()).vmethod_0();
			}
			return null;
		}
		finally
		{
			for (int i = 0; i < class36_0.method_2().Length; i++)
			{
				Class114 class2 = class36_0.method_2()[i];
				if (class2.method_2())
				{
					Class21 class3 = (Class21)class6_3[i];
					Type type2 = method_71(class2.method_0(), bool_2: false);
					object_3[i] = Class6.smethod_0(null, type2.GetElementType()).vmethod_2(class3.method_3()).vmethod_0();
				}
			}
			object_0 = null;
			class6_3 = null;
			class6_1 = null;
		}
	}

	private static void smethod_88(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_100();
	}

	private bool method_38(MethodInfo methodInfo_0, Class59 class59_0, Type[] type_9, out int int_0)
	{
		int_0 = 0;
		if (!methodInfo_0.IsGenericMethodDefinition)
		{
			return false;
		}
		ParameterInfo[] parameters = methodInfo_0.GetParameters();
		if (parameters.Length != class59_0.method_8().Length)
		{
			return false;
		}
		if (methodInfo_0.GetGenericArguments().Length != class59_0.method_10().Length)
		{
			return false;
		}
		int num = -1;
		while (true)
		{
			if (num < parameters.Length)
			{
				Type type = ((num == -1) ? methodInfo_0.ReturnType : parameters[num].ParameterType);
				if (type_9 != null && type.IsGenericParameter && (object)type.DeclaringMethod != null)
				{
					type = type_9[type.GenericParameterPosition] ?? type;
				}
				Class70 @class = ((num == -1) ? class59_0.method_12() : class59_0.method_8()[num]);
				if (@class != null)
				{
					if (!method_103(type, @class, out var int_1))
					{
						break;
					}
					if (num >= 0)
					{
						int_0 += int_1;
					}
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private static bool smethod_89(Class6 class6_4, Class6 class6_5)
	{
		bool result = false;
		switch (class6_4.method_0())
		{
		case 6:
			if (class6_5.method_0() == 1)
			{
				return smethod_89(class6_4, new Class31(Convert.ToInt32(((Class15)class6_5).method_3())));
			}
			result = ((Class31)class6_4).method_3() < ((Class31)class6_5).method_3();
			break;
		case 1:
			return smethod_89(new Class33(Convert.ToInt64(((Class15)class6_4).method_3())), class6_5);
		case 15:
			result = ((Class11)class6_4).method_3() < ((Class11)class6_5).method_3();
			break;
		case 12:
			if (class6_5.method_0() == 1)
			{
				return smethod_89(class6_4, new Class33(Convert.ToInt64(((Class15)class6_5).method_3())));
			}
			if (class6_5.method_0() == 6)
			{
				return smethod_89(class6_4, new Class33(((Class31)class6_5).method_3()));
			}
			result = ((Class33)class6_4).method_3() < ((Class33)class6_5).method_3();
			break;
		}
		return result;
	}

	private static Class6 smethod_90(Class6 class6_4, Class6 class6_5, bool bool_2)
	{
		if (class6_4.method_0() == 6)
		{
			if (class6_5.method_0() == 6)
			{
				if (!bool_2)
				{
					int num = ((Class31)class6_4).method_3();
					int num2 = ((Class31)class6_5).method_3();
					return new Class31(num >> num2);
				}
				int num3 = ((Class31)class6_4).method_3();
				int num4 = ((Class31)class6_5).method_3();
				return new Class31(num3 >>> num4);
			}
			if (class6_5.method_0() == 1)
			{
				return smethod_90(class6_4, new Class31(Convert.ToInt32(class6_5.vmethod_0())), bool_2);
			}
		}
		if (class6_4.method_0() == 12)
		{
			if (class6_5.method_0() == 6)
			{
				if (!bool_2)
				{
					long num5 = ((Class33)class6_4).method_3();
					int num6 = ((Class31)class6_5).method_3();
					return new Class33(num5 >> num6);
				}
				long num7 = ((Class33)class6_4).method_3();
				int num8 = ((Class31)class6_5).method_3();
				return new Class33(num7 >>> num8);
			}
			if (class6_5.method_0() == 1)
			{
				return smethod_90(class6_4, new Class31(Convert.ToInt32(class6_5.vmethod_0())), bool_2);
			}
		}
		if (class6_4.method_0() == 1)
		{
			Type underlyingType = Enum.GetUnderlyingType(class6_4.vmethod_0().GetType());
			if ((object)underlyingType != typeof(long) && (object)underlyingType != typeof(ulong))
			{
				return smethod_90(new Class31(Convert.ToInt32(class6_4.vmethod_0())), class6_5, bool_2);
			}
			return smethod_90(new Class33(Convert.ToInt64(class6_4.vmethod_0())), class6_5, bool_2);
		}
		throw new InvalidOperationException();
	}

	private static void smethod_91(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		Type type = class104_0.method_71(int_, bool_2: true);
		long long_ = class104_0.method_33();
		Array array_ = (Array)class104_0.method_80().vmethod_0();
		Class24 @class = new Class24();
		@class.method_6(array_);
		@class.method_4(type);
		@class.method_8(long_);
		class104_0.method_35(@class);
	}

	private void method_39(int int_0)
	{
		method_35(new Class31(int_0));
	}

	private static void smethod_92(Class104 class104_0, Class6 class6_4)
	{
		object object_ = class104_0.method_80().vmethod_0();
		long num = class104_0.method_33();
		Array array = (Array)class104_0.method_80().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		if ((object)elementType == typeof(long))
		{
			Class6 @class = Class6.smethod_0(object_, typeof(long));
			((long[])array)[num] = (long)@class.vmethod_0();
		}
		else if ((object)elementType == typeof(ulong))
		{
			Class6 class2 = Class6.smethod_0(object_, typeof(ulong));
			((ulong[])array)[num] = (ulong)class2.vmethod_0();
		}
		else if (elementType.IsEnum)
		{
			class104_0.method_10(elementType, object_, num, array);
		}
		else
		{
			class104_0.method_10(typeof(long), object_, num, array);
		}
	}

	private static void smethod_93(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_17();
	}

	private void method_40(int int_0)
	{
		method_35(class6_3[int_0].vmethod_3());
	}

	private static void smethod_94(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_100();
	}

	private static void smethod_95(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_100();
	}

	private Class36 method_41(Class48 class48_2)
	{
		Class36 @class = new Class36();
		@class.method_11(class48_2.method_6());
		@class.method_7(class48_2.method_19());
		@class.method_9(class48_2.method_19());
		@class.method_1(method_7(class48_2));
		@class.method_5(class48_2.method_9());
		@class.method_3(method_87(class48_2));
		return @class;
	}

	private static void smethod_96(Class104 class104_0, Class6 class6_4)
	{
		Class14 @class = (Class14)class6_4;
		class104_0.method_16(@class.method_3());
	}

	private static void smethod_97(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_22(((Class14)class6_4).method_3());
	}

	private Class6 method_42(Class6 class6_4)
	{
		if (class6_4.method_0() == 6)
		{
			int num = ((Class31)class6_4).method_3();
			Class31 @class = new Class31();
			@class.method_4(~num);
			return @class;
		}
		if (class6_4.method_0() == 12)
		{
			long num2 = ((Class33)class6_4).method_3();
			Class33 class2 = new Class33();
			class2.method_4(~num2);
			return class2;
		}
		if (class6_4.method_0() == 1)
		{
			Type underlyingType = Enum.GetUnderlyingType(class6_4.vmethod_0().GetType());
			if ((object)underlyingType != typeof(long) && (object)underlyingType != typeof(ulong))
			{
				return new Class31(~Convert.ToInt32(class6_4.vmethod_0()));
			}
			return new Class33(~Convert.ToInt64(class6_4.vmethod_0()));
		}
		throw new InvalidOperationException();
	}

	private static void smethod_98(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_95(typeof(uint));
	}

	private static void smethod_99(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_51(bool_2: false);
	}

	private void method_43(bool bool_2)
	{
		Class6 @class = method_80();
		method_35(new Class31(@class.method_0() switch
		{
			6 => (int)((!bool_2) ? ((byte)((Class31)@class).method_3()) : checked((byte)(uint)((Class31)@class).method_3())), 
			1 => (!bool_2) ? ((byte)Convert.ToUInt64(((Class15)@class).method_3())) : checked((byte)Convert.ToUInt64(((Class15)@class).method_3())), 
			15 => (!bool_2) ? ((byte)((Class11)@class).method_3()) : checked((byte)((Class11)@class).method_3()), 
			12 => (!bool_2) ? ((byte)((Class33)@class).method_3()) : checked((byte)(ulong)((Class33)@class).method_3()), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private static void smethod_100(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_22(((Class12)class6_4).method_3());
	}

	private static void smethod_101(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_53(type_5);
	}

	private static void smethod_102(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_39(8);
	}

	private static void smethod_103(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		FieldInfo fieldInfo_ = class104_0.method_79(int_);
		Class6 @class = class104_0.method_80();
		Class18 class2 = @class as Class18;
		object obj = ((class2 == null) ? @class.vmethod_0() : class104_0.method_94(class2).vmethod_0());
		class104_0.method_35(new Class20(fieldInfo_, obj, class2));
	}

	private static void smethod_104(Class104 class104_0, Class6 class6_4)
	{
		MethodBase methodBase_ = ((Class29)class104_0.method_80()).method_3();
		class104_0.method_28(methodBase_, bool_2: false);
	}

	private static void smethod_105(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		Class70 @class = class104_0.method_20(int_);
		object obj = ((@class.method_0() == 1) ? class104_0.method_63(@class.method_2()) : (@class.method_4().vmethod_0() switch
		{
			1 => (object)class104_0.method_71(int_, bool_2: true).TypeHandle, 
			2 => class104_0.method_15(int_).MethodHandle, 
			4 => class104_0.method_79(int_).FieldHandle, 
			_ => throw new InvalidOperationException(), 
		}));
		Class8 class2 = new Class8();
		class2.method_4(obj);
		class104_0.method_35(class2);
	}

	private void method_44(Class58 class58_0)
	{
		Class70 @class = method_20(class58_0.method_2());
		_ = (Class59)@class.method_4();
		MethodBase methodBase = method_77(class58_0.method_2(), @class);
		methodBase.GetParameters();
		int num = class58_0.method_0();
		bool bool_ = (num & 0x40000000) != 0;
		num &= -1073741825;
		Type[] array = type_8;
		Type[] array2 = type_2;
		try
		{
			type_8 = ((methodBase is ConstructorInfo) ? null : methodBase.GetGenericArguments());
			type_2 = methodBase.DeclaringType.GetGenericArguments();
			method_0(num, type_8, type_2, bool_);
		}
		finally
		{
			type_8 = array;
			type_2 = array2;
		}
	}

	private void method_45(bool bool_2)
	{
		Class6 @class = method_80();
		long long_ = @class.method_0() switch
		{
			6 => (!bool_2) ? ((Class31)@class).method_3() : ((Class31)@class).method_3(), 
			1 => (!bool_2) ? ((long)Convert.ToUInt64(((Class15)@class).method_3())) : checked((long)Convert.ToUInt64(((Class15)@class).method_3())), 
			15 => (!bool_2) ? ((long)((Class11)@class).method_3()) : checked((long)((Class11)@class).method_3()), 
			12 => (!bool_2) ? ((Class33)@class).method_3() : ((Class33)@class).method_3(), 
			_ => throw new InvalidOperationException(), 
		};
		Class33 class2 = new Class33();
		class2.method_4(long_);
		method_35(class2);
	}

	private Class6 method_46(Class6 class6_4)
	{
		if (class6_4.method_0() == 6)
		{
			return new Class31(-((Class31)class6_4).method_3());
		}
		if (class6_4.method_0() == 12)
		{
			return new Class33(-((Class33)class6_4).method_3());
		}
		if (class6_4.method_0() == 15)
		{
			Class11 @class = new Class11();
			@class.method_4(0.0 - ((Class11)class6_4).method_3());
			return @class;
		}
		if (class6_4.method_0() == 1)
		{
			Type underlyingType = Enum.GetUnderlyingType(class6_4.vmethod_0().GetType());
			if ((object)underlyingType != typeof(long) && (object)underlyingType != typeof(ulong))
			{
				return method_46(new Class31(Convert.ToInt32(class6_4.vmethod_0())));
			}
			return method_46(new Class33(Convert.ToInt64(class6_4.vmethod_0())));
		}
		throw new InvalidOperationException();
	}

	private static void smethod_106(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_91(bool_2: true);
	}

	private static void smethod_107(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		Type elementType = class104_0.method_71(int_, bool_2: true);
		Class6 @class = class104_0.method_80();
		int length;
		if (@class is Class31 class2)
		{
			length = class2.method_3();
		}
		else if (@class is Class26 class3)
		{
			length = class3.method_3().ToInt32();
		}
		else
		{
			if (!(@class is Class10 class4))
			{
				throw new Exception();
			}
			length = (int)class4.method_3().ToUInt32();
		}
		Array array_ = Array.CreateInstance(elementType, length);
		Class16 class5 = new Class16();
		class5.method_4(array_);
		class104_0.method_35(class5);
	}

	private static void smethod_108(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		Class6 class6_6 = class104_0.method_80();
		class104_0.method_35(class104_0.method_98(class6_6, class6_5));
	}

	private static void smethod_109(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		Type type_ = class104_0.method_71(int_, bool_2: true);
		class104_0.method_83(type_);
	}

	private void method_47(Class48 class48_2)
	{
	}

	private static Class6 smethod_110(Class6 class6_4, Class6 class6_5, bool bool_2, bool bool_3)
	{
		if (!bool_3)
		{
			long num = ((Class33)class6_4).method_3();
			long num2 = ((Class33)class6_5).method_3();
			long long_ = ((!bool_2) ? (num - num2) : checked(num - num2));
			return new Class33(long_);
		}
		ulong num3 = (ulong)((Class33)class6_4).method_3();
		ulong num4 = (ulong)((Class33)class6_5).method_3();
		ulong long_2 = ((!bool_2) ? (num3 - num4) : checked(num3 - num4));
		return new Class33((long)long_2);
	}

	private static void smethod_111(Class104 class104_0, Class6 class6_4)
	{
		uint uint_ = ((Class28)class6_4).method_3();
		class104_0.method_92(uint_);
	}

	private static void smethod_112(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		Class6 class6_6 = class104_0.method_80();
		class104_0.method_35(new Class31(smethod_74(class6_6, class6_5) ? 1 : 0));
	}

	private static void smethod_113(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_59(1);
	}

	private void method_48()
	{
		smethod_83(class75_0, Class108.class108_0.method_0);
	}

	private static void smethod_114(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		class104_0.method_35(class104_0.method_42(class6_5));
	}

	private static void smethod_115(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_35(class6_4);
	}

	private static void smethod_116(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_76(((Class14)class6_4).method_3());
	}

	private static void smethod_117(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_39(0);
	}

	private static void smethod_118(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_65(bool_2: false);
	}

	private bool method_49()
	{
		if (class6_0 == null)
		{
			return stack_0.Count != 0;
		}
		return true;
	}

	private static void smethod_119(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		class104_0.method_35(new Class33(@class.method_0() switch
		{
			6 => checked((uint)((Class31)@class).method_3()), 
			1 => (long)Convert.ToUInt64(((Class15)@class).method_3()), 
			15 => (long)checked((ulong)((Class11)@class).method_3()), 
			12 => (long)checked((ulong)((Class33)@class).method_3()), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private static void smethod_120(Class104 class104_0, Class6 class6_4)
	{
		Debugger.Break();
	}

	private bool method_50(Class6 class6_4, Type type_9)
	{
		object obj = class6_4.vmethod_0();
		if (obj == null)
		{
			return true;
		}
		Type type = class6_4.method_1() ?? obj.GetType();
		if ((object)type != type_9 && !type_9.IsAssignableFrom(type))
		{
			if (!type.IsValueType && !type_9.IsValueType)
			{
				if (Marshal.IsComObject(obj))
				{
					IntPtr intPtr;
					try
					{
						intPtr = Marshal.GetComInterfaceForObject(obj, type_9);
					}
					catch (InvalidCastException)
					{
						intPtr = IntPtr.Zero;
					}
					if (intPtr != IntPtr.Zero)
					{
						try
						{
							Marshal.Release(intPtr);
						}
						catch
						{
						}
						return true;
					}
				}
				else if (smethod_6(obj))
				{
					return true;
				}
			}
			return false;
		}
		return true;
	}

	private static Class6 smethod_121(Class6 class6_4, Class6 class6_5, bool bool_2, bool bool_3)
	{
		if (class6_4.method_0() == 6)
		{
			if (class6_5.method_0() == 6)
			{
				if (!bool_3)
				{
					int num = ((Class31)class6_4).method_3();
					int num2 = ((Class31)class6_5).method_3();
					int int_ = ((!bool_2) ? (num * num2) : checked(num * num2));
					return new Class31(int_);
				}
				uint num3 = (uint)((Class31)class6_4).method_3();
				uint num4 = (uint)((Class31)class6_5).method_3();
				uint int_2 = ((!bool_2) ? (num3 * num4) : checked(num3 * num4));
				return new Class31((int)int_2);
			}
			if (class6_5.method_0() == 12)
			{
				return smethod_196(new Class33(((Class31)class6_4).method_3()), class6_5, bool_2, bool_3);
			}
			if (class6_5.method_0() == 1)
			{
				Type underlyingType = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType != typeof(long) && (object)underlyingType != typeof(ulong))
				{
					return smethod_121(class6_4, new Class31(Convert.ToInt32(class6_5.vmethod_0())), bool_2, bool_3);
				}
				return smethod_196(new Class33(((Class31)class6_4).method_3()), new Class33(Convert.ToInt64(class6_5.vmethod_0())), bool_2, bool_3);
			}
		}
		if (class6_4.method_0() == 12)
		{
			if (class6_5.method_0() == 12)
			{
				return smethod_196(class6_4, class6_5, bool_2, bool_3);
			}
			if (class6_5.method_0() == 6)
			{
				return smethod_196(class6_4, new Class33(((Class31)class6_5).method_3()), bool_2, bool_3);
			}
			if (class6_5.method_0() == 1)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType2 != typeof(long) && (object)underlyingType2 != typeof(ulong))
				{
					return smethod_196(class6_4, new Class31(Convert.ToInt32(class6_5.vmethod_0())), bool_2, bool_3);
				}
				return smethod_196(class6_4, new Class33(Convert.ToInt64(class6_5.vmethod_0())), bool_2, bool_3);
			}
		}
		if (class6_4.method_0() == 15 && class6_5.method_0() == 15)
		{
			Class11 @class = new Class11();
			@class.method_4(((Class11)class6_4).method_3() * ((Class11)class6_5).method_3());
			return @class;
		}
		if (class6_4.method_0() == 1)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(class6_4.vmethod_0().GetType());
			if ((object)underlyingType3 != typeof(long) && (object)underlyingType3 != typeof(ulong))
			{
				return smethod_121(new Class31(Convert.ToInt32(class6_4.vmethod_0())), class6_5, bool_2, bool_3);
			}
			return smethod_121(new Class33(Convert.ToInt64(class6_4.vmethod_0())), class6_5, bool_2, bool_3);
		}
		throw new InvalidOperationException();
	}

	private void method_51(bool bool_2)
	{
		Class6 @class = method_80();
		sbyte int_ = @class.method_0() switch
		{
			6 => (!bool_2) ? ((sbyte)((Class31)@class).method_3()) : checked((sbyte)((Class31)@class).method_3()), 
			1 => (!bool_2) ? ((sbyte)Convert.ToUInt64(((Class15)@class).method_3())) : checked((sbyte)Convert.ToUInt64(((Class15)@class).method_3())), 
			15 => (!bool_2) ? ((sbyte)((Class11)@class).method_3()) : checked((sbyte)((Class11)@class).method_3()), 
			12 => (!bool_2) ? ((sbyte)((Class33)@class).method_3()) : checked((sbyte)((Class33)@class).method_3()), 
			_ => throw new InvalidOperationException(), 
		};
		Class31 class2 = new Class31();
		class2.method_4(int_);
		method_35(class2);
	}

	private void method_52(Class110 class110_0)
	{
		class48_0 = class110_0.class48_0;
		long_0 = class110_0.long_0;
	}

	private static void smethod_122(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		Class6 @class = class104_0.method_80();
		if ((@class.method_0() != 15) ? (!smethod_74(@class, class6_5)) : (!smethod_77(@class, class6_5)))
		{
			uint uint_ = ((Class28)class6_4).method_3();
			class104_0.method_92(uint_);
		}
	}

	private static void smethod_123(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		class104_0.method_35(new Class31(@class.method_0() switch
		{
			6 => (int)checked((byte)(uint)((Class31)@class).method_3()), 
			1 => checked((byte)Convert.ToUInt64(((Class15)@class).method_3())), 
			15 => checked((byte)((Class11)@class).method_3()), 
			12 => checked((byte)(ulong)((Class33)@class).method_3()), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private void method_53(Type type_9)
	{
		object object_ = method_80().vmethod_0();
		long long_ = method_33();
		Array array_ = (Array)method_80().vmethod_0();
		method_10(type_9, object_, long_, array_);
	}

	private static void smethod_124(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		FieldInfo fieldInfo = class104_0.method_79(int_);
		class104_0.method_35(Class6.smethod_0(fieldInfo.GetValue(null), fieldInfo.FieldType));
	}

	private void method_54()
	{
		if (class36_0.method_12())
		{
			Type type;
			try
			{
				type = method_71(class36_0.method_6(), bool_2: false);
			}
			catch (InvalidOperationException)
			{
				type = null;
			}
			if ((object)type != null)
			{
				RuntimeHelpers.RunClassConstructor(type.TypeHandle);
			}
		}
	}

	private static Exception smethod_125(string string_0, string string_1)
	{
		return new MethodAccessException(smethod_15(Class84.smethod_0(-994271734) + string_0 + Class84.smethod_0(-994271698), Class84.smethod_0(-994271706) + string_1 + Class84.smethod_0(-994271698)));
	}

	private static void smethod_126(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		FieldInfo fieldInfo = class104_0.method_79(int_);
		Class6 @class = class104_0.method_80();
		Class6 class2 = class104_0.method_80();
		Class18 class3 = class2 as Class18;
		object obj = ((class3 == null) ? class2.vmethod_0() : class104_0.method_94(class3).vmethod_0());
		if (obj == null)
		{
			throw new NullReferenceException();
		}
		Class6 class4 = Class6.smethod_0(@class.vmethod_0(), fieldInfo.FieldType);
		fieldInfo.SetValue(obj, class4.vmethod_0());
		if (class3 != null && obj != null && obj.GetType().IsValueType)
		{
			class104_0.method_9(class3, Class6.smethod_0(obj, null));
		}
	}

	private static void smethod_127(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		if (smethod_89(class104_0.method_80(), class6_5))
		{
			uint uint_ = ((Class28)class6_4).method_3();
			class104_0.method_92(uint_);
		}
	}

	public static object smethod_128(Type type_9)
	{
		if (type_9.IsValueType)
		{
			return Activator.CreateInstance(type_9);
		}
		return null;
	}

	private Class6 method_55(Class6 class6_4, Class6 class6_5, bool bool_2)
	{
		if (class6_4.method_0() == 6)
		{
			if (class6_5.method_0() == 6)
			{
				if (!bool_2)
				{
					int num = ((Class31)class6_4).method_3();
					int num2 = ((Class31)class6_5).method_3();
					return new Class31(num / num2);
				}
				int num3 = ((Class31)class6_4).method_3();
				uint num4 = (uint)((Class31)class6_5).method_3();
				return new Class31((int)((uint)num3 / num4));
			}
			if (class6_5.method_0() == 12)
			{
				return smethod_182(new Class33(((Class31)class6_4).method_3()), class6_5, bool_2);
			}
			if (class6_5.method_0() == 1)
			{
				Type underlyingType = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType != typeof(long) && (object)underlyingType != typeof(ulong))
				{
					return method_55(class6_4, new Class31(Convert.ToInt32(class6_5.vmethod_0())), bool_2);
				}
				return smethod_182(new Class33(((Class31)class6_4).method_3()), new Class33(Convert.ToInt64(class6_5.vmethod_0())), bool_2);
			}
		}
		if (class6_4.method_0() == 12)
		{
			if (class6_5.method_0() == 12)
			{
				return smethod_182(class6_4, class6_5, bool_2);
			}
			if (class6_5.method_0() == 6)
			{
				return smethod_182(class6_4, new Class33(((Class31)class6_5).method_3()), bool_2);
			}
			if (class6_5.method_0() == 1)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType2 != typeof(long) && (object)underlyingType2 != typeof(ulong))
				{
					return smethod_182(class6_4, new Class31(Convert.ToInt32(class6_5.vmethod_0())), bool_2);
				}
				return smethod_182(class6_4, new Class33(Convert.ToInt64(class6_5.vmethod_0())), bool_2);
			}
		}
		if (class6_4.method_0() == 15 && class6_5.method_0() == 15)
		{
			Class11 @class = new Class11();
			@class.method_4(((Class11)class6_4).method_3() / ((Class11)class6_5).method_3());
			return @class;
		}
		if (class6_4.method_0() == 1)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(class6_4.vmethod_0().GetType());
			if ((object)underlyingType3 != typeof(long) && (object)underlyingType3 != typeof(ulong))
			{
				return method_55(new Class31(Convert.ToInt32(class6_4.vmethod_0())), class6_5, bool_2);
			}
			return method_55(new Class33(Convert.ToInt64(class6_4.vmethod_0())), class6_5, bool_2);
		}
		throw new InvalidOperationException();
	}

	private void method_56(Stream stream_1, string string_0)
	{
		method_97(stream_1, 0L, string_0);
	}

	private static void smethod_129(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_100();
	}

	public void method_57(Stream stream_1, string string_0, object[] object_3)
	{
		method_101(stream_1, string_0, object_3);
	}

	private static void smethod_130(Class104 class104_0, Class6 class6_4)
	{
		Class12 @class = (Class12)class6_4;
		Class21 class2 = new Class21();
		class2.method_4(class104_0.class6_3[@class.method_3()]);
		class104_0.method_35(class2);
	}

	private Class6 method_58(Class6 class6_4, Class6 class6_5)
	{
		if (class6_4.method_0() == 6)
		{
			if (class6_5.method_0() == 6)
			{
				int num = ((Class31)class6_4).method_3();
				int num2 = ((Class31)class6_5).method_3();
				return new Class31(num ^ num2);
			}
			if (class6_5.method_0() == 1)
			{
				int num3 = ((Class31)class6_4).method_3();
				Type underlyingType = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType != typeof(long) && (object)underlyingType != typeof(ulong))
				{
					int num4 = Convert.ToInt32(class6_5.vmethod_0());
					return new Class31(num3 ^ num4);
				}
				long num5 = Convert.ToInt64(class6_5.vmethod_0());
				return new Class33(num3 ^ num5);
			}
		}
		if (class6_4.method_0() == 12)
		{
			if (class6_5.method_0() == 12)
			{
				long num6 = ((Class33)class6_4).method_3();
				long num7 = ((Class33)class6_5).method_3();
				return new Class33(num6 ^ num7);
			}
			if (class6_5.method_0() == 1)
			{
				int num8 = ((Class31)class6_4).method_3();
				long num9 = Convert.ToInt64(class6_5.vmethod_0());
				return new Class33(num8 ^ num9);
			}
		}
		if (class6_4.method_0() == 1)
		{
			if (class6_5.method_0() == 6)
			{
				int num10 = ((Class31)class6_5).method_3();
				Type underlyingType2 = Enum.GetUnderlyingType(class6_4.vmethod_0().GetType());
				if ((object)underlyingType2 != typeof(long) && (object)underlyingType2 != typeof(ulong))
				{
					return new Class31(Convert.ToInt32(class6_4.vmethod_0()) ^ num10);
				}
				return new Class33(Convert.ToInt64(class6_5.vmethod_0()) ^ num10);
			}
			if (class6_5.method_0() == 12)
			{
				long num11 = Convert.ToInt64(class6_4.vmethod_0());
				long num12 = ((Class33)class6_5).method_3();
				return new Class33(num11 ^ num12);
			}
			if (class6_5.method_0() == 1)
			{
				Type underlyingType3 = Enum.GetUnderlyingType(class6_4.vmethod_0().GetType());
				Type underlyingType4 = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType3 != typeof(long) && (object)underlyingType3 != typeof(ulong) && (object)underlyingType4 != typeof(long) && (object)underlyingType4 != typeof(ulong))
				{
					int num13 = Convert.ToInt32(class6_4.vmethod_0());
					int num14 = Convert.ToInt32(class6_5.vmethod_0());
					return new Class31(num13 ^ num14);
				}
				long num15 = Convert.ToInt64(class6_4.vmethod_0());
				long num16 = Convert.ToInt64(class6_5.vmethod_0());
				return new Class33(num15 ^ num16);
			}
		}
		throw new InvalidOperationException();
	}

	private static void smethod_131(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_43(bool_2: true);
	}

	private static void smethod_132(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_95(typeof(float));
	}

	private void method_59(int int_0)
	{
		method_35(class6_1[int_0].vmethod_3());
	}

	private Class114 method_60(Class48 class48_2)
	{
		Class114 @class = new Class114();
		@class.method_1(class48_2.method_19());
		@class.method_3(class48_2.method_5());
		return @class;
	}

	private static Class6 smethod_133(Class6 class6_4, Class6 class6_5, bool bool_2)
	{
		if (class6_4.method_0() == 6)
		{
			if (class6_5.method_0() == 6)
			{
				if (!bool_2)
				{
					int num = ((Class31)class6_4).method_3();
					int num2 = ((Class31)class6_5).method_3();
					return new Class31(num % num2);
				}
				int num3 = ((Class31)class6_4).method_3();
				uint num4 = (uint)((Class31)class6_5).method_3();
				return new Class31((int)((uint)num3 % num4));
			}
			if (class6_5.method_0() == 12)
			{
				return smethod_238(new Class33(((Class31)class6_4).method_3()), class6_5, bool_2);
			}
			if (class6_5.method_0() == 1)
			{
				Type underlyingType = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType != typeof(long) && (object)underlyingType != typeof(ulong))
				{
					return smethod_133(class6_4, new Class31(Convert.ToInt32(class6_5.vmethod_0())), bool_2);
				}
				return smethod_238(new Class33(((Class31)class6_4).method_3()), new Class33(Convert.ToInt64(class6_5.vmethod_0())), bool_2);
			}
		}
		if (class6_4.method_0() == 12)
		{
			if (class6_5.method_0() == 12)
			{
				return smethod_238(class6_4, class6_5, bool_2);
			}
			if (class6_5.method_0() == 6)
			{
				return smethod_238(class6_4, new Class33(((Class31)class6_5).method_3()), bool_2);
			}
			if (class6_5.method_0() == 1)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType2 != typeof(long) && (object)underlyingType2 != typeof(ulong))
				{
					return smethod_238(class6_4, new Class31(Convert.ToInt32(class6_5.vmethod_0())), bool_2);
				}
				return smethod_238(class6_4, new Class33(Convert.ToInt64(class6_5.vmethod_0())), bool_2);
			}
		}
		if (class6_4.method_0() == 15 && class6_5.method_0() == 15)
		{
			Class11 @class = new Class11();
			@class.method_4(((Class11)class6_4).method_3() % ((Class11)class6_5).method_3());
			return @class;
		}
		if (class6_4.method_0() == 1)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(class6_4.vmethod_0().GetType());
			if ((object)underlyingType3 != typeof(long) && (object)underlyingType3 != typeof(ulong))
			{
				return smethod_133(new Class31(Convert.ToInt32(class6_4.vmethod_0())), class6_5, bool_2);
			}
			return smethod_133(new Class33(Convert.ToInt64(class6_4.vmethod_0())), class6_5, bool_2);
		}
		throw new InvalidOperationException();
	}

	private bool method_61(MethodBase methodBase_0, object object_3, ref object object_4, object[] object_5)
	{
		if (!methodBase_0.IsStatic && methodBase_0.Name == Class84.smethod_0(-994272217) && methodBase_0 is MethodInfo { ReturnType: var returnType } && returnType.IsByRef)
		{
			Type elementType = returnType.GetElementType();
			int num = object_5.Length;
			if (num >= 1 && object_5[0] is int)
			{
				int[] array = new int[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = (int)object_5[i];
				}
				Class23 @class = new Class23();
				@class.method_6((Array)object_3);
				@class.method_8(array);
				@class.method_4(elementType);
				object_4 = @class;
				return true;
			}
		}
		return false;
	}

	private void method_62(bool bool_2)
	{
		Class6 class6_ = method_80();
		Class6 class6_2 = method_80();
		method_35(method_55(class6_2, class6_, bool_2));
	}

	private static void smethod_134(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_95(typeof(int));
	}

	private static void smethod_135(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_95(typeof(byte));
	}

	private static void smethod_136(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_40(3);
	}

	private object method_63(int int_0)
	{
		switch (Class113.smethod_0(int_0))
		{
		case 67108864:
			return module_0.ModuleHandle.ResolveFieldHandle(int_0);
		case 167772160:
			try
			{
				return module_0.ModuleHandle.ResolveFieldHandle(int_0);
			}
			catch
			{
				try
				{
					return module_0.ModuleHandle.ResolveMethodHandle(int_0);
				}
				catch
				{
					throw new InvalidOperationException();
				}
			}
		default:
			throw new InvalidOperationException();
		case 100663296:
		case 721420288:
			return module_0.ModuleHandle.ResolveMethodHandle(int_0);
		case 16777216:
		case 33554432:
		case 452984832:
			return module_0.ModuleHandle.ResolveTypeHandle(int_0);
		}
	}

	private static void smethod_137(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		uint num = @class.method_0() switch
		{
			12 => (uint)((Class33)@class).method_3(), 
			6 => (uint)((Class31)@class).method_3(), 
			1 => (uint)Convert.ToInt64(@class.vmethod_0()), 
			_ => throw new InvalidOperationException(), 
		};
		Class31[] array = (Class31[])((Class16)class6_4).method_3();
		if (num < array.Length)
		{
			uint uint_ = (uint)array[num].method_3();
			class104_0.method_92(uint_);
		}
	}

	private static void smethod_138(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_53(typeof(float));
	}

	private MethodBase method_64(Class59 class59_0)
	{
		Type type = method_71(class59_0.method_4().method_2(), bool_2: false);
		BindingFlags bindingAttr = smethod_45(class59_0.method_2());
		Type[] array = null;
		Class70[] array2 = class59_0.method_10();
		if (array2 != null)
		{
			array = new Type[array2.Length];
			for (int i = 0; i < array.Length; i++)
			{
				Class70 @class = array2[i];
				if (@class != null)
				{
					array[i] = method_71(@class.method_2(), bool_2: true);
				}
			}
		}
		MemberInfo[] member = type.GetMember(class59_0.method_6(), MemberTypes.Method, bindingAttr);
		MethodInfo methodInfo = null;
		int num = -1;
		MemberInfo[] array3 = member;
		for (int j = 0; j < array3.Length; j++)
		{
			MethodInfo methodInfo2 = (MethodInfo)array3[j];
			if (method_38(methodInfo2, class59_0, array, out var int_) && int_ > num)
			{
				methodInfo = methodInfo2;
				num = int_;
			}
		}
		if ((object)methodInfo == null)
		{
			throw new Exception(string.Format(Class84.smethod_0(-994271830), type.Name, class59_0.method_6()));
		}
		return methodInfo.MakeGenericMethod(array);
	}

	private void method_65(bool bool_2)
	{
		Class6 @class = method_80();
		method_35(new Class33(@class.method_0() switch
		{
			6 => (!bool_2) ? ((uint)((Class31)@class).method_3()) : checked((uint)((Class31)@class).method_3()), 
			1 => (long)((!bool_2) ? Convert.ToUInt64(((Class15)@class).method_3()) : Convert.ToUInt64(((Class15)@class).method_3())), 
			15 => (long)((!bool_2) ? ((ulong)((Class11)@class).method_3()) : checked((ulong)((Class11)@class).method_3())), 
			12 => (!bool_2) ? ((Class33)@class).method_3() : ((long)checked((ulong)((Class33)@class).method_3())), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private static void smethod_139(Exception exception_0)
	{
		ExceptionDispatchInfo.Capture(exception_0).Throw();
	}

	private static void smethod_140(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_21(bool_2: true, bool_3: false);
	}

	private void method_66(Class36 class36_1)
	{
		if (smethod_55() && !class36_0.method_13() && class36_1.method_13() && !class36_1.method_14())
		{
			string string_ = method_4(class36_1);
			throw smethod_125(method_4(class36_0), string_);
		}
	}

	private static void smethod_141(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_59(((Class12)class6_4).method_3());
	}

	private static void smethod_142(Class104 class104_0, Class6 class6_4)
	{
	}

	private string method_67(int int_0)
	{
		lock (dictionary_3)
		{
			bool flag = true;
			if (dictionary_3.TryGetValue(int_0, out var value))
			{
				return (string)value;
			}
			Class70 @class = method_20(int_0);
			if (@class.method_0() == 1)
			{
				return module_0.ResolveString(@class.method_2());
			}
			string text = ((Class60)@class.method_4()).method_0();
			if (flag)
			{
				dictionary_3.Add(int_0, text);
			}
			return text;
		}
	}

	private static void smethod_143(Class104 class104_0, Class6 class6_4)
	{
		throw new NotSupportedException(Class84.smethod_0(-994271753));
	}

	private static void smethod_144(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_36(class6_4);
	}

	private static void smethod_145(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_32(bool_2: false);
	}

	public object method_68(Stream stream_1, string string_0, object[] object_3, Type[] type_9, Type[] type_10, object[] object_4)
	{
		stream_0 = stream_1;
		method_56(stream_1, string_0);
		return method_37(object_3, type_9, type_10, object_4);
	}

	private static void smethod_146(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		Class6 class6_6 = class104_0.method_80();
		class104_0.method_35(new Class31(smethod_53(class6_6, class6_5) ? 1 : 0));
	}

	private static void smethod_147(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_83(typeof(int));
	}

	private static void smethod_148(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		if (!smethod_89(class104_0.method_80(), class6_5))
		{
			uint uint_ = ((Class28)class6_4).method_3();
			class104_0.method_92(uint_);
		}
	}

	private void method_69(bool bool_2)
	{
		Class6 @class = method_80();
		method_35(new Class31(@class.method_0() switch
		{
			6 => (int)((!bool_2) ? ((ushort)((Class31)@class).method_3()) : checked((uint)((Class31)@class).method_3())), 
			1 => (int)((!bool_2) ? Convert.ToUInt64(((Class15)@class).method_3()) : checked((uint)Convert.ToUInt64(((Class15)@class).method_3()))), 
			15 => (int)((!bool_2) ? ((uint)((Class11)@class).method_3()) : checked((uint)((Class11)@class).method_3())), 
			12 => (int)((!bool_2) ? ((Class33)@class).method_3() : checked((uint)((Class33)@class).method_3())), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private static void smethod_149(Class104 class104_0, Class6 class6_4)
	{
	}

	private static void smethod_150(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_69(bool_2: true);
	}

	private static void smethod_151(Class104 class104_0, Class6 class6_4)
	{
		object object_ = class104_0.method_80().vmethod_0();
		long num = class104_0.method_33();
		Array array = (Array)class104_0.method_80().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		if ((object)elementType == typeof(short))
		{
			Class6 @class = Class6.smethod_0(object_, typeof(short));
			((short[])array)[num] = (short)@class.vmethod_0();
		}
		else if ((object)elementType == typeof(ushort))
		{
			Class6 class2 = Class6.smethod_0(object_, typeof(ushort));
			((ushort[])array)[num] = (ushort)class2.vmethod_0();
		}
		else if ((object)elementType == typeof(char))
		{
			Class6 class3 = Class6.smethod_0(object_, typeof(char));
			((char[])array)[num] = (char)class3.vmethod_0();
		}
		else if (elementType.IsEnum)
		{
			class104_0.method_10(elementType, object_, num, array);
		}
		else
		{
			class104_0.method_10(typeof(short), object_, num, array);
		}
	}

	private static void smethod_152(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		IntPtr intptr_ = checked(@class.method_0() switch
		{
			6 => new IntPtr((uint)((Class31)@class).method_3()), 
			1 => new IntPtr((long)Convert.ToUInt64(((Class15)@class).method_3())), 
			15 => new IntPtr((long)((Class11)@class).method_3()), 
			12 => new IntPtr((long)(ulong)((Class33)@class).method_3()), 
			_ => throw new InvalidOperationException(), 
		});
		Class26 class2 = new Class26();
		class2.method_4(intptr_);
		class104_0.method_35(class2);
	}

	private static void smethod_153(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		Type type_ = class104_0.method_71(int_, bool_2: true);
		class104_0.method_53(type_);
	}

	private static object smethod_154(MethodBase methodBase_0, object object_3, object[] object_4)
	{
		if (methodBase_0.IsConstructor)
		{
			try
			{
				return Activator.CreateInstance(methodBase_0.DeclaringType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, object_4, null);
			}
			catch (AmbiguousMatchException)
			{
				return ((ConstructorInfo)methodBase_0).Invoke(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, object_4, null);
			}
		}
		return methodBase_0.Invoke(object_3, object_4);
	}

	private static void smethod_155(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_91(bool_2: false);
	}

	private static void smethod_156(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_39(7);
	}

	private void method_70()
	{
		method_96(bool_2: false);
	}

	private static void smethod_157(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_12(bool_2: true, bool_3: false);
	}

	private Type method_71(int int_0, bool bool_2)
	{
		Type type;
		lock (dictionary_3)
		{
			bool bool_3 = true;
			if (dictionary_3.TryGetValue(int_0, out var value))
			{
				type = (Type)value;
			}
			else
			{
				Class70 class70_ = method_20(int_0);
				type = method_85(int_0, class70_, ref bool_3, bool_2);
				if (bool_3)
				{
					dictionary_3.Add(int_0, type);
				}
			}
		}
		if (bool_2)
		{
			method_3(type);
		}
		return type;
	}

	private static void smethod_158(Class104 class104_0, Class6 class6_4)
	{
		int num = ((Class31)class6_4).method_3();
		bool flag = (num & int.MinValue) != 0;
		bool bool_ = (num & 0x40000000) != 0;
		num &= 0x3FFFFFFF;
		if (flag)
		{
			class104_0.method_0(num, null, null, bool_);
			return;
		}
		Class58 class58_ = (Class58)class104_0.method_20(num).method_4();
		class104_0.method_44(class58_);
	}

	private static void smethod_159(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_83(typeof(double));
	}

	private void method_72(bool bool_2, bool bool_3)
	{
		Class6 class6_ = method_80();
		Class6 class6_2 = method_80();
		method_35(smethod_121(class6_2, class6_, bool_2, bool_3));
	}

	private static void smethod_160(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_12(bool_2: true, bool_3: true);
	}

	private static void smethod_161(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_40(((Class14)class6_4).method_3());
	}

	private static void smethod_162(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_83(type_5);
	}

	private static void smethod_163(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_14(bool_2: false);
	}

	private Stack<Class110> method_73()
	{
		Stack<Class110> stack = stack_1;
		if (stack == null)
		{
			stack = (stack_1 = new Stack<Class110>());
			stack.Push(new Class110
			{
				class48_0 = class48_0,
				class67_0 = class48_0.method_0(),
				long_0 = long_0
			});
		}
		return stack;
	}

	private static void smethod_164(Class104 class104_0, Class6 class6_4)
	{
		throw new NotSupportedException(Class84.smethod_0(-994271796));
	}

	private static void smethod_165(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_83(typeof(byte));
	}

	private void method_74(bool bool_2)
	{
		Class6 @class = method_80();
		method_35(new Class31(@class.method_0() switch
		{
			6 => (int)((!bool_2) ? ((ushort)((Class31)@class).method_3()) : checked((ushort)(uint)((Class31)@class).method_3())), 
			1 => (!bool_2) ? ((ushort)Convert.ToUInt64(((Class15)@class).method_3())) : checked((ushort)Convert.ToUInt64(((Class15)@class).method_3())), 
			15 => (!bool_2) ? ((ushort)((Class11)@class).method_3()) : checked((ushort)((Class11)@class).method_3()), 
			12 => (!bool_2) ? ((ushort)((Class33)@class).method_3()) : checked((ushort)(ulong)((Class33)@class).method_3()), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private Class37 method_75(Class48 class48_2)
	{
		Class37 @class = new Class37();
		@class.method_1(class48_2.method_19());
		return @class;
	}

	private static void smethod_166(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_39(3);
	}

	private static void smethod_167(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		if (!smethod_53(class104_0.method_80(), class6_5))
		{
			uint uint_ = ((Class28)class6_4).method_3();
			class104_0.method_92(uint_);
		}
	}

	private void method_76(int int_0)
	{
		Class19 @class = new Class19();
		@class.method_4(int_0);
		method_35(@class);
	}

	private static void smethod_168(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_72(bool_2: true, bool_3: false);
	}

	private static void smethod_169(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_81(bool_2: false);
	}

	private static void smethod_170(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_59(2);
	}

	[DebuggerNonUserCode]
	private MethodBase method_77(int int_0, Class70 class70_0)
	{
		lock (dictionary_3)
		{
			bool flag = true;
			if (dictionary_3.TryGetValue(int_0, out var value))
			{
				return (MethodBase)value;
			}
			if (class70_0.method_0() == 1)
			{
				MethodBase methodBase = module_0.ResolveMethod(class70_0.method_2());
				if (flag)
				{
					dictionary_3.Add(int_0, methodBase);
				}
				return methodBase;
			}
			Class59 @class = (Class59)class70_0.method_4();
			if (@class.method_3())
			{
				return method_64(@class);
			}
			Type type = method_71(@class.method_4().method_2(), bool_2: false);
			Type type2 = method_71(@class.method_12().method_2(), bool_2: true);
			Type[] array = new Type[@class.method_8().Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = method_71(@class.method_8()[i].method_2(), bool_2: true);
			}
			if (type.IsGenericType)
			{
				flag = false;
			}
			if (@class.method_6() == Class84.smethod_0(-994271810))
			{
				ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, CallingConventions.Any, array, null);
				if ((object)constructor == null)
				{
					throw new Exception();
				}
				if (flag)
				{
					dictionary_3.Add(int_0, constructor);
				}
				return constructor;
			}
			BindingFlags bindingAttr = smethod_45(@class.method_2());
			MethodBase methodBase2 = null;
			try
			{
				methodBase2 = type.GetMethod(@class.method_6(), bindingAttr, null, CallingConventions.Any, array, null);
			}
			catch (AmbiguousMatchException)
			{
				MethodInfo[] methods = type.GetMethods(bindingAttr);
				foreach (MethodInfo methodInfo in methods)
				{
					if (methodInfo.Name != @class.method_6() || (object)methodInfo.ReturnType != type2)
					{
						continue;
					}
					ParameterInfo[] parameters = methodInfo.GetParameters();
					if (parameters.Length != array.Length)
					{
						continue;
					}
					bool flag2 = false;
					for (int k = 0; k < array.Length; k++)
					{
						if ((object)parameters[k].ParameterType != array[k])
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						methodBase2 = methodInfo;
						break;
					}
				}
			}
			if ((object)methodBase2 == null)
			{
				throw new Exception(string.Format(Class84.smethod_0(-994271830), type.Name, @class.method_6()));
			}
			if (flag)
			{
				dictionary_3.Add(int_0, methodBase2);
			}
			return methodBase2;
		}
	}

	private Class6 method_78()
	{
		return class6_0 ?? stack_0.Peek();
	}

	private static void smethod_171(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		if (!smethod_24(class104_0.method_80(), class6_5))
		{
			uint uint_ = ((Class28)class6_4).method_3();
			class104_0.method_92(uint_);
		}
	}

	private static void smethod_172(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_65(bool_2: true);
	}

	private static void smethod_173(Class104 class104_0, Class6 class6_4)
	{
		Class31 @class = (Class31)class6_4;
		MethodBase methodBase = class104_0.method_15(@class.method_3());
		Type declaringType = methodBase.DeclaringType;
		Type type = class104_0.method_80().vmethod_0().GetType();
		ParameterInfo[] parameters = methodBase.GetParameters();
		Type[] array = new Type[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			array[i] = parameters[i].ParameterType;
		}
		MethodBase methodBase2 = null;
		Type type2 = type;
		while ((object)type2 != null && (object)type2 != declaringType)
		{
			MethodInfo method = type2.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
			if ((object)method == null || (object)method.GetBaseDefinition() != methodBase)
			{
				type2 = type2.BaseType;
				continue;
			}
			methodBase2 = method;
			break;
		}
		if ((object)methodBase2 == null)
		{
			methodBase2 = methodBase;
		}
		Class29 class2 = new Class29();
		class2.method_4(methodBase2);
		class104_0.method_35(class2);
	}

	private static void smethod_174(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_35(class6_4);
	}

	private static Exception smethod_175(string string_0, string string_1)
	{
		return new TypeLoadException(smethod_15(Class84.smethod_0(-994271734) + string_0 + Class84.smethod_0(-994271698), Class84.smethod_0(-994271315) + string_1 + Class84.smethod_0(-994271698)));
	}

	private static void smethod_176(Class104 class104_0, Class6 class6_4)
	{
		throw new NotSupportedException(Class84.smethod_0(-994272546));
	}

	private static Delegate1 smethod_177(Struct6 struct6_0)
	{
		Delegate1 value;
		lock (dictionary_1)
		{
			dictionary_1.TryGetValue(struct6_0, out value);
		}
		if (value != null)
		{
			return value;
		}
		MethodBase methodBase = struct6_0.method_0();
		lock (dictionary_0)
		{
			while (dictionary_0.ContainsKey(methodBase))
			{
				Monitor.Wait(dictionary_0);
			}
			dictionary_0[methodBase] = null;
		}
		try
		{
			lock (dictionary_1)
			{
				dictionary_1.TryGetValue(struct6_0, out value);
			}
			if (value == null)
			{
				value = smethod_32(methodBase, struct6_0.method_1());
				lock (dictionary_1)
				{
					dictionary_1[struct6_0] = value;
				}
			}
			return value;
		}
		finally
		{
			lock (dictionary_0)
			{
				dictionary_0.Remove(methodBase);
				Monitor.PulseAll(dictionary_0);
			}
		}
	}

	private static void smethod_178(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		Class6 @class = class104_0.method_80();
		if ((@class.method_0() != 15) ? (!smethod_77(@class, class6_5)) : (!smethod_74(@class, class6_5)))
		{
			uint uint_ = ((Class28)class6_4).method_3();
			class104_0.method_92(uint_);
		}
	}

	private static void smethod_179(Class104 class104_0, Class6 class6_4)
	{
		throw new NotSupportedException(Class84.smethod_0(-994271475));
	}

	private static void smethod_180(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_83(Class99.type_0);
	}

	private FieldInfo method_79(int int_0)
	{
		lock (dictionary_3)
		{
			bool bool_ = true;
			FieldInfo fieldInfo;
			if (dictionary_3.TryGetValue(int_0, out var value))
			{
				fieldInfo = (FieldInfo)value;
			}
			else
			{
				Class70 class70_ = method_20(int_0);
				fieldInfo = method_90(int_0, class70_, ref bool_);
				if (bool_)
				{
					dictionary_3.Add(int_0, fieldInfo);
				}
			}
			method_3(fieldInfo);
			return fieldInfo;
		}
	}

	private Class6 method_80()
	{
		Class6 @class = class6_0;
		if (@class != null)
		{
			class6_0 = class6_2;
			class6_2 = null;
			return @class;
		}
		return stack_0.Pop();
	}

	private static Delegate1 smethod_181(Struct6 struct6_0)
	{
		lock (dictionary_1)
		{
			dictionary_1.TryGetValue(struct6_0, out var value);
			return value;
		}
	}

	private static Class6 smethod_182(Class6 class6_4, Class6 class6_5, bool bool_2)
	{
		if (!bool_2)
		{
			long num = ((Class33)class6_4).method_3();
			long num2 = ((Class33)class6_5).method_3();
			return new Class33(num / num2);
		}
		long num3 = ((Class33)class6_4).method_3();
		ulong num4 = (ulong)((Class33)class6_5).method_3();
		return new Class33((long)((ulong)num3 / num4));
	}

	private static void smethod_183(ILGenerator ilgenerator_0, Type type_9)
	{
		if (type_9.IsValueType || Class99.smethod_1(type_9).IsGenericParameter)
		{
			ilgenerator_0.Emit(OpCodes.Box, type_9);
		}
	}

	private void method_81(bool bool_2)
	{
		Class6 @class = method_80();
		IntPtr intptr_ = @class.method_0() switch
		{
			6 => (!bool_2) ? new IntPtr(((Class31)@class).method_3()) : new IntPtr(((Class31)@class).method_3()), 
			1 => (!bool_2) ? new IntPtr((long)Convert.ToUInt64(((Class15)@class).method_3())) : new IntPtr(checked((long)Convert.ToUInt64(((Class15)@class).method_3()))), 
			15 => (!bool_2) ? new IntPtr((long)((Class11)@class).method_3()) : new IntPtr(checked((long)((Class11)@class).method_3())), 
			12 => (!bool_2) ? new IntPtr(((Class33)@class).method_3()) : new IntPtr(((Class33)@class).method_3()), 
			_ => throw new InvalidOperationException(), 
		};
		Class26 class2 = new Class26();
		class2.method_4(intptr_);
		method_35(class2);
	}

	private void method_82()
	{
		class6_0 = null;
		class6_2 = null;
		stack_0.Clear();
	}

	private static void smethod_184(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		Type type_ = class104_0.method_71(int_, bool_2: true);
		Class6 class6_5 = class104_0.method_80();
		if (!class104_0.method_50(class6_5, type_))
		{
			throw new InvalidCastException();
		}
		class104_0.method_35(class6_5);
	}

	private static void smethod_185(Class104 class104_0, Class6 class6_4)
	{
		object object_ = class104_0.method_80().vmethod_0();
		long num = class104_0.method_33();
		Array array = (Array)class104_0.method_80().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		if ((object)elementType == typeof(int))
		{
			Class6 @class = Class6.smethod_0(object_, typeof(int));
			((int[])array)[num] = (int)@class.vmethod_0();
		}
		else if ((object)elementType == typeof(uint))
		{
			Class6 class2 = Class6.smethod_0(object_, typeof(uint));
			((uint[])array)[num] = (uint)class2.vmethod_0();
		}
		else if (elementType.IsEnum)
		{
			class104_0.method_10(elementType, object_, num, array);
		}
		else
		{
			class104_0.method_10(typeof(int), object_, num, array);
		}
	}

	private static void smethod_186(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		class104_0.method_35(new Class33(checked(@class.method_0() switch
		{
			6 => (uint)((Class31)@class).method_3(), 
			1 => (long)Convert.ToUInt64(((Class15)@class).method_3()), 
			15 => (long)((Class11)@class).method_3(), 
			12 => (long)(ulong)((Class33)@class).method_3(), 
			_ => throw new InvalidOperationException(), 
		})));
	}

	private void method_83(Type type_9)
	{
		Class18 class18_ = (Class18)method_80();
		method_35(Class6.smethod_0(method_94(class18_).vmethod_0(), type_9));
	}

	private static void smethod_187(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		class104_0.method_35(new Class31(@class.method_0() switch
		{
			6 => (int)checked((uint)((Class31)@class).method_3()), 
			1 => (int)checked((uint)Convert.ToUInt64(((Class15)@class).method_3())), 
			15 => (int)checked((uint)((Class11)@class).method_3()), 
			12 => (int)checked((uint)(ulong)((Class33)@class).method_3()), 
			_ => throw new InvalidOperationException(), 
		}));
	}

	private static void smethod_188(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_100();
	}

	private static void smethod_189(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_95(typeof(long));
	}

	private static void smethod_190(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		Type type = class104_0.method_71(int_, bool_2: true);
		Class6 class6_5 = Class6.smethod_0(class104_0.method_80().vmethod_0(), type);
		class104_0.method_35(class6_5);
	}

	private int method_84()
	{
		return 1854700134;
	}

	private static void smethod_191(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		Class6 class6_6 = class104_0.method_80();
		class104_0.method_35(new Class31(smethod_77(class6_6, class6_5) ? 1 : 0));
	}

	private Type method_85(int int_0, Class70 class70_0, ref bool bool_2, bool bool_3)
	{
		if (class70_0.method_0() == 1)
		{
			return module_0.ResolveType(class70_0.method_2());
		}
		Class56 @class = (Class56)class70_0.method_4();
		Type type;
		if (@class.method_2())
		{
			if (@class.method_10() != -1)
			{
				if (type_8 == null)
				{
					throw new InvalidOperationException(Class84.smethod_0(-994271445));
				}
				type = type_8[@class.method_10()];
			}
			else
			{
				if (@class.method_8() == -1)
				{
					throw new Exception();
				}
				if (type_2 == null)
				{
					throw new InvalidOperationException(Class84.smethod_0(-994271396));
				}
				type = type_2[@class.method_8()];
			}
			Stack<Struct2> stack = Class99.smethod_4(@class.method_0());
			type = Class99.smethod_5(type, stack);
			bool_2 = false;
			return type;
		}
		string text = @class.method_0();
		type = Type.GetType(text);
		if ((object)type == null)
		{
			int num = text.IndexOf(',');
			string text2 = text.Substring(0, num);
			string text3 = text.Substring(num + 1).Trim();
			Assembly assembly_ = Class99.assembly_0;
			if (text3.Equals(assembly_.FullName, StringComparison.Ordinal))
			{
				type = assembly_.GetType(text2);
			}
			else
			{
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				foreach (Assembly assembly in assemblies)
				{
					string value = null;
					try
					{
						value = assembly.Location;
					}
					catch (NotSupportedException)
					{
					}
					if (string.IsNullOrEmpty(value) && assembly.FullName.Equals(text3, StringComparison.Ordinal))
					{
						type = assembly.GetType(text2);
						if ((object)type != null)
						{
							break;
						}
					}
				}
			}
			if ((object)type == null && text2.StartsWith(Class84.smethod_0(-994271411), StringComparison.Ordinal) && text2.Contains(Class84.smethod_0(-994272055)))
			{
				try
				{
					Type[] types = Assembly.Load(text3).GetTypes();
					foreach (Type type2 in types)
					{
						if (type2.FullName == text2)
						{
							type = type2;
							break;
						}
					}
				}
				catch
				{
				}
			}
		}
		if ((object)type == null)
		{
			throw new TypeLoadException(string.Format(Class84.smethod_0(-994271389), text));
		}
		if (@class.method_4())
		{
			Type[] array = new Type[@class.method_6().Length];
			for (int j = 0; j < @class.method_6().Length; j++)
			{
				array[j] = method_71(@class.method_6()[j].method_2(), bool_3);
			}
			if (array != null)
			{
				Type genericTypeDefinition = Class99.smethod_1(type).GetGenericTypeDefinition();
				Stack<Struct2> stack2 = Class99.smethod_3(type);
				type = genericTypeDefinition.MakeGenericType(array);
				type = Class99.smethod_5(type, stack2);
			}
			bool_2 = false;
		}
		return type;
	}

	private Class6 method_86(Class48 class48_2, byte byte_1)
	{
		switch (byte_1)
		{
		default:
			throw new Exception(Class84.smethod_0(-994271359));
		case 0:
		{
			uint_1 += 4u;
			Class28 class7 = new Class28();
			class7.method_4(class48_2.method_20());
			return class7;
		}
		case 1:
			uint_1 += 8u;
			return new Class33(class48_2.method_21());
		case 3:
		{
			int num = class48_2.method_19();
			Class31[] array = new Class31[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = new Class31(class48_2.method_19());
			}
			uint_1 += (uint)((num + 1) * 4);
			Class16 class6 = new Class16();
			class6.method_4(array);
			return class6;
		}
		case 5:
		{
			uint_1 += 8u;
			Class11 class5 = new Class11();
			class5.method_4(class48_2.method_27());
			return class5;
		}
		case 2:
		case 6:
		{
			uint_1++;
			Class12 class4 = new Class12();
			class4.method_4(class48_2.method_6());
			return class4;
		}
		case 7:
		{
			uint_1 += 4u;
			Class13 class3 = new Class13();
			class3.method_4(class48_2.method_26());
			return class3;
		}
		case 8:
		{
			uint_1++;
			Class7 class2 = new Class7();
			class2.method_4(class48_2.method_7());
			return class2;
		}
		case 9:
		case 10:
		{
			uint_1 += 2u;
			Class14 @class = new Class14();
			@class.method_4(class48_2.method_24());
			return @class;
		}
		case 11:
			return null;
		case 4:
		case 12:
			uint_1 += 4u;
			return new Class31(class48_2.method_19());
		}
	}

	private static object smethod_192(MethodBase methodBase_0, object object_3, object[] object_4, bool bool_2)
	{
		if (!Class105.bool_0)
		{
			return smethod_154(methodBase_0, object_3, object_4);
		}
		Struct6 struct6_ = new Struct6(methodBase_0, bool_2);
		Delegate1 @delegate = smethod_181(struct6_);
		if (@delegate == null)
		{
			bool flag;
			lock (dictionary_2)
			{
				dictionary_2.TryGetValue(methodBase_0, out var value);
				if (!(flag = value >= 50))
				{
					dictionary_2[methodBase_0] = value + 1;
				}
			}
			if (!(flag = flag || (!bool_2 && object_3 == null && !methodBase_0.IsStatic && !methodBase_0.IsConstructor) || smethod_30(methodBase_0) || (methodBase_0.CallingConvention & CallingConventions.Any) == CallingConventions.VarArgs))
			{
				return smethod_154(methodBase_0, object_3, object_4);
			}
			@delegate = smethod_177(struct6_);
			lock (dictionary_2)
			{
				dictionary_2.Remove(methodBase_0);
			}
		}
		return @delegate(object_3, object_4);
	}

	private static void smethod_193(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_40(1);
	}

	private static void smethod_194(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		Type type = class104_0.method_71(int_, bool_2: true);
		Class6 @class = Class6.smethod_0(class104_0.method_80().vmethod_0(), type);
		@class.method_2(type);
		class104_0.method_35(@class);
	}

	private Class114[] method_87(Class48 class48_2)
	{
		Class114[] array = new Class114[class48_2.method_23()];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = method_60(class48_2);
		}
		return array;
	}

	private static void smethod_195(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_40(0);
	}

	private static Class6 smethod_196(Class6 class6_4, Class6 class6_5, bool bool_2, bool bool_3)
	{
		if (!bool_3)
		{
			long num = ((Class33)class6_4).method_3();
			long num2 = ((Class33)class6_5).method_3();
			long long_ = ((!bool_2) ? (num * num2) : checked(num * num2));
			return new Class33(long_);
		}
		ulong num3 = (ulong)((Class33)class6_4).method_3();
		ulong num4 = (ulong)((Class33)class6_5).method_3();
		ulong long_2 = ((!bool_2) ? (num3 * num4) : checked(num3 * num4));
		return new Class33((long)long_2);
	}

	private static void smethod_197(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_78();
		class104_0.method_35(@class.vmethod_3());
	}

	private static void smethod_198(Class104 class104_0, Class6 class6_4)
	{
		throw new NotSupportedException(Class84.smethod_0(-994272171));
	}

	private static void smethod_199(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_83(typeof(short));
	}

	private static void smethod_200(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_59(0);
	}

	[Conditional("DEBUG")]
	private void method_88(object object_3)
	{
	}

	private static void smethod_201(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		class104_0.method_35(new Class31(checked(@class.method_0() switch
		{
			6 => (int)(uint)((Class31)@class).method_3(), 
			1 => (int)Convert.ToUInt64(((Class15)@class).method_3()), 
			15 => (int)((Class11)@class).method_3(), 
			12 => (int)(ulong)((Class33)@class).method_3(), 
			_ => throw new InvalidOperationException(), 
		})));
	}

	private void method_89(long long_1)
	{
		class48_0.method_0().vmethod_5(long_1 - long_0);
	}

	private FieldInfo method_90(int int_0, Class70 class70_0, ref bool bool_2)
	{
		if (class70_0.method_0() == 1)
		{
			bool_2 = false;
			return module_0.ResolveField(class70_0.method_2());
		}
		Class57 @class = (Class57)class70_0.method_4();
		Type type = method_71(@class.method_0().method_2(), bool_2: false);
		if (type.IsGenericType)
		{
			bool_2 = false;
		}
		return type.GetField(bindingAttr: smethod_45(@class.method_4()), name: @class.method_2());
	}

	private static void smethod_202(ILGenerator ilgenerator_0, Type type_9)
	{
		if ((object)type_9 != Class99.type_0)
		{
			ilgenerator_0.Emit(OpCodes.Castclass, type_9);
		}
	}

	private static void smethod_203(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_45(bool_2: false);
	}

	private static void smethod_204(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_35(new Class8());
	}

	private static void smethod_205(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		bool flag = false;
		if (@class.method_0() switch
		{
			12 => (ulong)((Class33)@class).method_3() > 0uL, 
			6 => ((Class31)@class).method_3() != 0, 
			1 => Convert.ToBoolean(((Class15)@class).method_3()), 
			26 => ((Class8)@class).method_3() != null, 
			25 => ((Class10)@class).method_3() != UIntPtr.Zero, 
			18 => ((Class26)@class).method_3() != IntPtr.Zero, 
			_ => @class.vmethod_0() != null, 
		})
		{
			uint uint_ = ((Class28)class6_4).method_3();
			class104_0.method_92(uint_);
		}
	}

	private void method_91(bool bool_2)
	{
		Class6 @class = method_80();
		short int_ = @class.method_0() switch
		{
			6 => (!bool_2) ? ((short)((Class31)@class).method_3()) : checked((short)((Class31)@class).method_3()), 
			1 => (!bool_2) ? ((short)Convert.ToUInt64(((Class15)@class).method_3())) : checked((short)Convert.ToUInt64(((Class15)@class).method_3())), 
			15 => (!bool_2) ? ((short)((Class11)@class).method_3()) : checked((short)((Class11)@class).method_3()), 
			12 => (!bool_2) ? ((short)((Class33)@class).method_3()) : checked((short)((Class33)@class).method_3()), 
			_ => throw new InvalidOperationException(), 
		};
		Class31 class2 = new Class31();
		class2.method_4(int_);
		method_35(class2);
	}

	private static void smethod_206(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_13(class6_4);
	}

	private static void smethod_207(Class104 class104_0, Class6 class6_4)
	{
		Array array = (Array)class104_0.method_80().vmethod_0();
		class104_0.method_35(new Class31(array.Length));
	}

	private static void smethod_208(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		Type type_ = class104_0.method_71(int_, bool_2: true);
		class104_0.method_95(type_);
	}

	private static void smethod_209(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		Type type_ = class104_0.method_71(int_, bool_2: true);
		Class6 class6_5 = class104_0.method_80();
		if (class104_0.method_50(class6_5, type_))
		{
			class104_0.method_35(class6_5);
		}
		else
		{
			class104_0.method_35(new Class8());
		}
	}

	private static void smethod_210(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_39(1);
	}

	private static void smethod_211(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_80();
	}

	private static void smethod_212(Class104 class104_0, Class6 class6_4)
	{
		Class11 @class = (Class11)class104_0.method_80();
		if (double.IsNaN(@class.method_3()) || double.IsInfinity(@class.method_3()))
		{
			throw new OverflowException(Class84.smethod_0(-994271594));
		}
		class104_0.method_35(@class);
	}

	private static void smethod_213(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		Class6 class6_6 = class104_0.method_80();
		Class31 @class = new Class31();
		@class.method_4(smethod_24(class6_6, class6_5) ? 1 : 0);
		class104_0.method_35(@class);
	}

	private static void smethod_214(ILGenerator ilgenerator_0, int int_0)
	{
		switch (int_0)
		{
		case -1:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
			return;
		case 0:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
			return;
		case 1:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
			return;
		case 2:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_2);
			return;
		case 3:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_3);
			return;
		case 4:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_4);
			return;
		case 5:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
			return;
		case 6:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_6);
			return;
		case 7:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_7);
			return;
		case 8:
			ilgenerator_0.Emit(OpCodes.Ldc_I4_8);
			return;
		}
		if (int_0 > -129 && int_0 < 128)
		{
			ilgenerator_0.Emit(OpCodes.Ldc_I4_S, (sbyte)int_0);
		}
		else
		{
			ilgenerator_0.Emit(OpCodes.Ldc_I4, int_0);
		}
	}

	private static void smethod_215(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_72(bool_2: true, bool_3: true);
	}

	private static void smethod_216(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_95(type_5);
	}

	private static void smethod_217(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_39(-1);
	}

	private static Class75 smethod_218(Class48 class48_2)
	{
		Class75 @class = new Class75();
		@class.method_1(class48_2.method_6());
		@class.method_3(class48_2.method_19());
		@class.method_11(class48_2.method_20());
		@class.method_9(class48_2.method_20());
		@class.method_7(class48_2.method_20());
		@class.method_5(class48_2.method_20());
		return @class;
	}

	private static void smethod_219(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		Class6 class6_6 = class104_0.method_80();
		class104_0.method_35(class104_0.method_31(class6_6, class6_5));
	}

	private static void smethod_220(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_12(bool_2: false, bool_3: false);
	}

	private void method_92(uint uint_3)
	{
		nullable_0 = uint_3;
	}

	private static void smethod_221(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_39(6);
	}

	private static void smethod_222(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_95(typeof(double));
	}

	private static Class75[] smethod_223(Class48 class48_2)
	{
		int num = class48_2.method_23();
		Class75[] array = new Class75[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = smethod_218(class48_2);
		}
		return array;
	}

	private void method_93(object object_3, uint uint_3)
	{
		bool flag = object_3 != null;
		object_2 = object_3;
		if (flag)
		{
			stack_2.Clear();
		}
		bool_1 = flag;
		if (!flag)
		{
			stack_2.Push(new Struct7(uint_3));
		}
		Class75[] array = class75_0;
		foreach (Class75 @class in array)
		{
			if (!smethod_84(uint_2, @class.method_4(), @class.method_6()))
			{
				continue;
			}
			switch (@class.method_0())
			{
			case 0:
				if (flag)
				{
					Type type = object_3.GetType();
					Type type2 = method_71(@class.method_2(), bool_2: true);
					if ((object)type == type2 || type.IsSubclassOf(type2))
					{
						stack_2.Push(new Struct7(@class.method_8(), object_3));
						bool_1 = false;
					}
				}
				break;
			case 1:
				if (flag)
				{
					stack_2.Push(new Struct7(@class.method_10(), object_3));
				}
				break;
			case 2:
				if (flag || !smethod_84(uint_3, @class.method_4(), @class.method_6()))
				{
					stack_2.Push(new Struct7(@class.method_8()));
				}
				break;
			case 4:
				if (flag)
				{
					stack_2.Push(new Struct7(@class.method_8()));
				}
				break;
			}
		}
		method_17();
	}

	private Class6 method_94(Class18 class18_0)
	{
		switch (class18_0.method_0())
		{
		default:
			throw new ArgumentOutOfRangeException();
		case 20:
		{
			Class20 class2 = (Class20)class18_0;
			return Class6.smethod_0(class2.method_5().GetValue(class2.method_3()), null);
		}
		case 21:
			return class6_1[((Class19)class18_0).method_3()];
		case 7:
			return ((Class21)class18_0).method_3();
		case 2:
		case 17:
		{
			Class22 @class = (Class22)class18_0;
			return Class6.smethod_0(@class.vmethod_4(), @class.method_3());
		}
		}
	}

	private static void smethod_224(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_40(((Class12)class6_4).method_3());
	}

	private void method_95(Type type_9)
	{
		long index = method_33();
		Array array = (Array)method_80().vmethod_0();
		method_35(Class6.smethod_0(array.GetValue(index), type_9));
	}

	private static void smethod_225(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		class104_0.type_1 = class104_0.method_71(int_, bool_2: true);
	}

	private void method_96(bool bool_2)
	{
		uint num = uint_0;
		while (true)
		{
			try
			{
				while (!bool_0)
				{
					if (nullable_0.HasValue)
					{
						uint_1 = nullable_0.Value;
						method_89(uint_1);
						nullable_0 = null;
					}
					else if (uint_1 >= num)
					{
						break;
					}
					method_102();
				}
				break;
			}
			catch (object object_)
			{
				method_93(object_, 0u);
				if (!bool_2)
				{
					method_96(bool_2: true);
					break;
				}
			}
		}
	}

	private static void smethod_226(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_27(bool_2: true);
	}

	private void method_97(Stream stream_1, long long_1, string string_0)
	{
		int int_ = method_84();
		Class69 class67_ = new Class69(stream_1, int_);
		class48_1 = new Class48(class67_);
		if (string_0 != null)
		{
			long_1 = method_5(string_0);
		}
		Class67 @class = class48_1.method_0();
		lock (@class)
		{
			@class.vmethod_9(long_1, 0);
			method_47(class48_1);
			class36_0 = method_41(class48_1);
			class75_0 = smethod_223(class48_1);
			byte_0 = smethod_67(class48_1);
		}
		method_48();
	}

	private static void smethod_227(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_95(typeof(ushort));
	}

	private Class6 method_98(Class6 class6_4, Class6 class6_5)
	{
		if (class6_4.method_0() == 6)
		{
			if (class6_5.method_0() == 6)
			{
				int num = ((Class31)class6_4).method_3();
				int num2 = ((Class31)class6_5).method_3();
				return new Class31(num << num2);
			}
			if (class6_5.method_0() == 1)
			{
				return method_98(class6_4, new Class31(Convert.ToInt32(class6_5.vmethod_0())));
			}
		}
		if (class6_4.method_0() == 12)
		{
			if (class6_5.method_0() == 6)
			{
				long num3 = ((Class33)class6_4).method_3();
				int num4 = ((Class31)class6_5).method_3();
				return new Class33(num3 << num4);
			}
			if (class6_5.method_0() == 1)
			{
				return method_98(class6_4, new Class31(Convert.ToInt32(class6_5.vmethod_0())));
			}
		}
		if (class6_4.method_0() == 1)
		{
			Type underlyingType = Enum.GetUnderlyingType(class6_4.vmethod_0().GetType());
			if ((object)underlyingType != typeof(long) && (object)underlyingType != typeof(ulong))
			{
				return method_98(new Class31(Convert.ToInt32(class6_4.vmethod_0())), class6_5);
			}
			return method_98(new Class33(Convert.ToInt64(class6_4.vmethod_0())), class6_5);
		}
		throw new InvalidOperationException();
	}

	private bool method_99(MethodBase methodBase_0, object object_3, ref object object_4, object[] object_5)
	{
		Type declaringType = methodBase_0.DeclaringType;
		if ((object)declaringType == null)
		{
			return false;
		}
		if (Class99.smethod_0(declaringType))
		{
			if (string.Equals(methodBase_0.Name, Class84.smethod_0(-994275274), StringComparison.Ordinal))
			{
				object_4 = object_3 != null;
			}
			else if (string.Equals(methodBase_0.Name, Class84.smethod_0(-994275239), StringComparison.Ordinal))
			{
				if (object_3 == null)
				{
					return ((bool?)null).Value;
				}
				object_4 = object_3;
			}
			else if (methodBase_0.Name.Equals(Class84.smethod_0(-994275255), StringComparison.Ordinal))
			{
				if (object_3 == null)
				{
					object_4 = Activator.CreateInstance(Nullable.GetUnderlyingType(methodBase_0.DeclaringType));
				}
				object_4 = object_3;
			}
			else
			{
				if (object_3 != null || methodBase_0.IsStatic)
				{
					return false;
				}
				object_4 = null;
			}
			return true;
		}
		if ((object)declaringType == type_6)
		{
			if (methodBase_0.Name.Equals(Class84.smethod_0(-994275215), StringComparison.Ordinal))
			{
				object_4 = Class99.assembly_0;
				return true;
			}
			if (object_0 != null && methodBase_0.Name == Class84.smethod_0(-994275172))
			{
				Assembly assembly = null;
				object[] array = object_0;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] is Assembly assembly2)
					{
						object_4 = assembly2;
						return true;
					}
				}
			}
		}
		else if ((object)declaringType == type_7)
		{
			if (methodBase_0.Name == Class84.smethod_0(-994275195))
			{
				if (object_0 != null)
				{
					MethodBase methodBase = null;
					object[] array = object_0;
					for (int i = 0; i < array.Length; i++)
					{
						if (array[i] is MethodBase methodBase2)
						{
							object_4 = methodBase2;
							return true;
						}
					}
				}
				object_4 = MethodBase.GetCurrentMethod();
				return true;
			}
		}
		else if (declaringType.IsArray && declaringType.GetArrayRank() >= 2)
		{
			return method_61(methodBase_0, object_3, ref object_4, object_5);
		}
		return false;
	}

	private static void smethod_228(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_100();
	}

	private static Class6 smethod_229(Class6 class6_4, Class6 class6_5, bool bool_2, bool bool_3)
	{
		if (class6_4.method_0() == 6)
		{
			if (class6_5.method_0() == 6)
			{
				if (!bool_3)
				{
					int num = ((Class31)class6_4).method_3();
					int num2 = ((Class31)class6_5).method_3();
					int int_ = ((!bool_2) ? (num - num2) : checked(num - num2));
					return new Class31(int_);
				}
				uint num3 = (uint)((Class31)class6_4).method_3();
				uint num4 = (uint)((Class31)class6_5).method_3();
				uint int_2 = ((!bool_2) ? (num3 - num4) : checked(num3 - num4));
				return new Class31((int)int_2);
			}
			if (class6_5.method_0() == 12)
			{
				return smethod_110(new Class33(((Class31)class6_4).method_3()), class6_5, bool_2, bool_3);
			}
			if (class6_5.method_0() == 1)
			{
				Type underlyingType = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType != typeof(long) && (object)underlyingType != typeof(ulong))
				{
					return smethod_229(class6_4, new Class31(Convert.ToInt32(class6_5.vmethod_0())), bool_2, bool_3);
				}
				return smethod_110(new Class33(((Class31)class6_4).method_3()), new Class33(Convert.ToInt64(class6_5.vmethod_0())), bool_2, bool_3);
			}
		}
		if (class6_4.method_0() == 12)
		{
			if (class6_5.method_0() == 12)
			{
				return smethod_110(class6_4, class6_5, bool_2, bool_3);
			}
			if (class6_5.method_0() == 6)
			{
				return smethod_110(class6_4, new Class33(((Class31)class6_5).method_3()), bool_2, bool_3);
			}
			if (class6_5.method_0() == 1)
			{
				Type underlyingType2 = Enum.GetUnderlyingType(class6_5.vmethod_0().GetType());
				if ((object)underlyingType2 != typeof(long) && (object)underlyingType2 != typeof(ulong))
				{
					return smethod_110(class6_4, new Class31(Convert.ToInt32(class6_5.vmethod_0())), bool_2, bool_3);
				}
				return smethod_110(class6_4, new Class33(Convert.ToInt64(class6_5.vmethod_0())), bool_2, bool_3);
			}
		}
		if (class6_4.method_0() == 15 && class6_5.method_0() == 15)
		{
			Class11 @class = new Class11();
			@class.method_4(((Class11)class6_4).method_3() - ((Class11)class6_5).method_3());
			return @class;
		}
		if (class6_4.method_0() == 1)
		{
			Type underlyingType3 = Enum.GetUnderlyingType(class6_4.vmethod_0().GetType());
			if ((object)underlyingType3 != typeof(long) && (object)underlyingType3 != typeof(ulong))
			{
				return smethod_229(new Class31(Convert.ToInt32(class6_4.vmethod_0())), class6_5, bool_2, bool_3);
			}
			return smethod_229(new Class33(Convert.ToInt64(class6_4.vmethod_0())), class6_5, bool_2, bool_3);
		}
		throw new InvalidOperationException();
	}

	private static Dictionary<int, Struct5> smethod_230(Class96 class96_1)
	{
		return new Dictionary<int, Struct5>(256)
		{
			{
				class96_1.struct0_29.method_0(),
				new Struct5(class96_1.struct0_29, smethod_109)
			},
			{
				class96_1.struct0_141.method_0(),
				new Struct5(class96_1.struct0_141, smethod_129)
			},
			{
				class96_1.struct0_151.method_0(),
				new Struct5(class96_1.struct0_151, smethod_112)
			},
			{
				class96_1.struct0_138.method_0(),
				new Struct5(class96_1.struct0_138, smethod_188)
			},
			{
				class96_1.struct0_79.method_0(),
				new Struct5(class96_1.struct0_79, smethod_124)
			},
			{
				class96_1.struct0_167.method_0(),
				new Struct5(class96_1.struct0_167, smethod_2)
			},
			{
				class96_1.struct0_206.method_0(),
				new Struct5(class96_1.struct0_206, smethod_54)
			},
			{
				class96_1.struct0_23.method_0(),
				new Struct5(class96_1.struct0_23, smethod_118)
			},
			{
				class96_1.struct0_126.method_0(),
				new Struct5(class96_1.struct0_126, smethod_163)
			},
			{
				class96_1.struct0_179.method_0(),
				new Struct5(class96_1.struct0_179, smethod_76)
			},
			{
				class96_1.struct0_176.method_0(),
				new Struct5(class96_1.struct0_176, smethod_165)
			},
			{
				class96_1.struct0_80.method_0(),
				new Struct5(class96_1.struct0_80, smethod_199)
			},
			{
				class96_1.struct0_133.method_0(),
				new Struct5(class96_1.struct0_133, smethod_152)
			},
			{
				class96_1.struct0_115.method_0(),
				new Struct5(class96_1.struct0_115, smethod_88)
			},
			{
				class96_1.struct0_208.method_0(),
				new Struct5(class96_1.struct0_208, smethod_37)
			},
			{
				class96_1.struct0_135.method_0(),
				new Struct5(class96_1.struct0_135, smethod_172)
			},
			{
				class96_1.struct0_120.method_0(),
				new Struct5(class96_1.struct0_120, smethod_114)
			},
			{
				class96_1.struct0_156.method_0(),
				new Struct5(class96_1.struct0_156, smethod_63)
			},
			{
				class96_1.struct0_188.method_0(),
				new Struct5(class96_1.struct0_188, smethod_158)
			},
			{
				class96_1.struct0_136.method_0(),
				new Struct5(class96_1.struct0_136, smethod_49)
			},
			{
				class96_1.struct0_54.method_0(),
				new Struct5(class96_1.struct0_54, smethod_23)
			},
			{
				class96_1.struct0_162.method_0(),
				new Struct5(class96_1.struct0_162, smethod_52)
			},
			{
				class96_1.struct0_77.method_0(),
				new Struct5(class96_1.struct0_77, smethod_231)
			},
			{
				class96_1.struct0_75.method_0(),
				new Struct5(class96_1.struct0_75, smethod_113)
			},
			{
				class96_1.struct0_57.method_0(),
				new Struct5(class96_1.struct0_57, smethod_25)
			},
			{
				class96_1.struct0_41.method_0(),
				new Struct5(class96_1.struct0_41, smethod_160)
			},
			{
				class96_1.struct0_28.method_0(),
				new Struct5(class96_1.struct0_28, smethod_243)
			},
			{
				class96_1.struct0_8.method_0(),
				new Struct5(class96_1.struct0_8, smethod_156)
			},
			{
				class96_1.struct0_2.method_0(),
				new Struct5(class96_1.struct0_2, smethod_102)
			},
			{
				class96_1.struct0_85.method_0(),
				new Struct5(class96_1.struct0_85, smethod_247)
			},
			{
				class96_1.struct0_130.method_0(),
				new Struct5(class96_1.struct0_130, smethod_155)
			},
			{
				class96_1.struct0_44.method_0(),
				new Struct5(class96_1.struct0_44, smethod_228)
			},
			{
				class96_1.struct0_11.method_0(),
				new Struct5(class96_1.struct0_11, smethod_191)
			},
			{
				class96_1.struct0_200.method_0(),
				new Struct5(class96_1.struct0_200, smethod_38)
			},
			{
				class96_1.struct0_165.method_0(),
				new Struct5(class96_1.struct0_165, smethod_31)
			},
			{
				class96_1.struct0_83.method_0(),
				new Struct5(class96_1.struct0_83, smethod_13)
			},
			{
				class96_1.struct0_127.method_0(),
				new Struct5(class96_1.struct0_127, smethod_204)
			},
			{
				class96_1.struct0_88.method_0(),
				new Struct5(class96_1.struct0_88, smethod_173)
			},
			{
				class96_1.struct0_152.method_0(),
				new Struct5(class96_1.struct0_152, smethod_60)
			},
			{
				class96_1.struct0_198.method_0(),
				new Struct5(class96_1.struct0_198, smethod_73)
			},
			{
				class96_1.struct0_60.method_0(),
				new Struct5(class96_1.struct0_60, smethod_46)
			},
			{
				class96_1.struct0_195.method_0(),
				new Struct5(class96_1.struct0_195, smethod_41)
			},
			{
				class96_1.struct0_214.method_0(),
				new Struct5(class96_1.struct0_214, smethod_58)
			},
			{
				class96_1.struct0_124.method_0(),
				new Struct5(class96_1.struct0_124, smethod_171)
			},
			{
				class96_1.struct0_0.method_0(),
				new Struct5(class96_1.struct0_0, smethod_239)
			},
			{
				class96_1.struct0_111.method_0(),
				new Struct5(class96_1.struct0_111, smethod_206)
			},
			{
				class96_1.struct0_197.method_0(),
				new Struct5(class96_1.struct0_197, smethod_232)
			},
			{
				class96_1.struct0_53.method_0(),
				new Struct5(class96_1.struct0_53, smethod_87)
			},
			{
				class96_1.struct0_184.method_0(),
				new Struct5(class96_1.struct0_184, smethod_179)
			},
			{
				class96_1.struct0_189.method_0(),
				new Struct5(class96_1.struct0_189, smethod_100)
			},
			{
				class96_1.struct0_89.method_0(),
				new Struct5(class96_1.struct0_89, smethod_219)
			},
			{
				class96_1.struct0_125.method_0(),
				new Struct5(class96_1.struct0_125, smethod_131)
			},
			{
				class96_1.struct0_108.method_0(),
				new Struct5(class96_1.struct0_108, smethod_4)
			},
			{
				class96_1.struct0_177.method_0(),
				new Struct5(class96_1.struct0_177, smethod_115)
			},
			{
				class96_1.struct0_143.method_0(),
				new Struct5(class96_1.struct0_143, smethod_240)
			},
			{
				class96_1.struct0_100.method_0(),
				new Struct5(class96_1.struct0_100, smethod_75)
			},
			{
				class96_1.struct0_34.method_0(),
				new Struct5(class96_1.struct0_34, smethod_189)
			},
			{
				class96_1.struct0_153.method_0(),
				new Struct5(class96_1.struct0_153, smethod_164)
			},
			{
				class96_1.struct0_150.method_0(),
				new Struct5(class96_1.struct0_150, smethod_108)
			},
			{
				class96_1.struct0_30.method_0(),
				new Struct5(class96_1.struct0_30, smethod_237)
			},
			{
				class96_1.struct0_61.method_0(),
				new Struct5(class96_1.struct0_61, smethod_184)
			},
			{
				class96_1.struct0_139.method_0(),
				new Struct5(class96_1.struct0_139, smethod_119)
			},
			{
				class96_1.struct0_72.method_0(),
				new Struct5(class96_1.struct0_72, smethod_36)
			},
			{
				class96_1.struct0_24.method_0(),
				new Struct5(class96_1.struct0_24, smethod_187)
			},
			{
				class96_1.struct0_172.method_0(),
				new Struct5(class96_1.struct0_172, smethod_249)
			},
			{
				class96_1.struct0_205.method_0(),
				new Struct5(class96_1.struct0_205, smethod_138)
			},
			{
				class96_1.struct0_121.method_0(),
				new Struct5(class96_1.struct0_121, smethod_136)
			},
			{
				class96_1.struct0_38.method_0(),
				new Struct5(class96_1.struct0_38, smethod_35)
			},
			{
				class96_1.struct0_209.method_0(),
				new Struct5(class96_1.struct0_209, smethod_162)
			},
			{
				class96_1.struct0_87.method_0(),
				new Struct5(class96_1.struct0_87, smethod_241)
			},
			{
				class96_1.struct0_210.method_0(),
				new Struct5(class96_1.struct0_210, smethod_16)
			},
			{
				class96_1.struct0_203.method_0(),
				new Struct5(class96_1.struct0_203, smethod_82)
			},
			{
				class96_1.struct0_91.method_0(),
				new Struct5(class96_1.struct0_91, smethod_161)
			},
			{
				class96_1.struct0_168.method_0(),
				new Struct5(class96_1.struct0_168, smethod_236)
			},
			{
				class96_1.struct0_81.method_0(),
				new Struct5(class96_1.struct0_81, smethod_205)
			},
			{
				class96_1.struct0_64.method_0(),
				new Struct5(class96_1.struct0_64, smethod_122)
			},
			{
				class96_1.struct0_180.method_0(),
				new Struct5(class96_1.struct0_180, smethod_64)
			},
			{
				class96_1.struct0_5.method_0(),
				new Struct5(class96_1.struct0_5, smethod_22)
			},
			{
				class96_1.struct0_19.method_0(),
				new Struct5(class96_1.struct0_19, smethod_195)
			},
			{
				class96_1.struct0_183.method_0(),
				new Struct5(class96_1.struct0_183, smethod_148)
			},
			{
				class96_1.struct0_9.method_0(),
				new Struct5(class96_1.struct0_9, smethod_217)
			},
			{
				class96_1.struct0_12.method_0(),
				new Struct5(class96_1.struct0_12, smethod_159)
			},
			{
				class96_1.struct0_159.method_0(),
				new Struct5(class96_1.struct0_159, smethod_227)
			},
			{
				class96_1.struct0_96.method_0(),
				new Struct5(class96_1.struct0_96, smethod_56)
			},
			{
				class96_1.struct0_33.method_0(),
				new Struct5(class96_1.struct0_33, smethod_242)
			},
			{
				class96_1.struct0_132.method_0(),
				new Struct5(class96_1.struct0_132, smethod_244)
			},
			{
				class96_1.struct0_190.method_0(),
				new Struct5(class96_1.struct0_190, smethod_185)
			},
			{
				class96_1.struct0_55.method_0(),
				new Struct5(class96_1.struct0_55, smethod_72)
			},
			{
				class96_1.struct0_163.method_0(),
				new Struct5(class96_1.struct0_5, smethod_142)
			},
			{
				class96_1.struct0_58.method_0(),
				new Struct5(class96_1.struct0_58, smethod_91)
			},
			{
				class96_1.struct0_199.method_0(),
				new Struct5(class96_1.struct0_199, smethod_209)
			},
			{
				class96_1.struct0_160.method_0(),
				new Struct5(class96_1.struct0_160, smethod_11)
			},
			{
				class96_1.struct0_74.method_0(),
				new Struct5(class96_1.struct0_74, smethod_81)
			},
			{
				class96_1.struct0_63.method_0(),
				new Struct5(class96_1.struct0_63, smethod_146)
			},
			{
				class96_1.struct0_43.method_0(),
				new Struct5(class96_1.struct0_43, smethod_225)
			},
			{
				class96_1.struct0_25.method_0(),
				new Struct5(class96_1.struct0_25, smethod_144)
			},
			{
				class96_1.struct0_51.method_0(),
				new Struct5(class96_1.struct0_51, smethod_234)
			},
			{
				class96_1.struct0_211.method_0(),
				new Struct5(class96_1.struct0_211, smethod_153)
			},
			{
				class96_1.struct0_182.method_0(),
				new Struct5(class96_1.struct0_182, smethod_62)
			},
			{
				class96_1.struct0_22.method_0(),
				new Struct5(class96_1.struct0_22, smethod_224)
			},
			{
				class96_1.struct0_95.method_0(),
				new Struct5(class96_1.struct0_95, smethod_149)
			},
			{
				class96_1.struct0_175.method_0(),
				new Struct5(class96_1.struct0_175, smethod_19)
			},
			{
				class96_1.struct0_86.method_0(),
				new Struct5(class96_1.struct0_86, smethod_85)
			},
			{
				class96_1.struct0_146.method_0(),
				new Struct5(class96_1.struct0_146, smethod_29)
			},
			{
				class96_1.struct0_185.method_0(),
				new Struct5(class96_1.struct0_185, smethod_10)
			},
			{
				class96_1.struct0_47.method_0(),
				new Struct5(class96_1.struct0_47, smethod_198)
			},
			{
				class96_1.struct0_104.method_0(),
				new Struct5(class96_1.struct0_104, smethod_57)
			},
			{
				class96_1.struct0_196.method_0(),
				new Struct5(class96_1.struct0_196, smethod_80)
			},
			{
				class96_1.struct0_71.method_0(),
				new Struct5(class96_1.struct0_71, smethod_93)
			},
			{
				class96_1.struct0_202.method_0(),
				new Struct5(class96_1.struct0_202, smethod_180)
			},
			{
				class96_1.struct0_155.method_0(),
				new Struct5(class96_1.struct0_155, smethod_167)
			},
			{
				class96_1.struct0_6.method_0(),
				new Struct5(class96_1.struct0_6, smethod_7)
			},
			{
				class96_1.struct0_68.method_0(),
				new Struct5(class96_1.struct0_68, smethod_95)
			},
			{
				class96_1.struct0_15.method_0(),
				new Struct5(class96_1.struct0_15, smethod_65)
			},
			{
				class96_1.struct0_78.method_0(),
				new Struct5(class96_1.struct0_78, smethod_104)
			},
			{
				class96_1.struct0_3.method_0(),
				new Struct5(class96_1.struct0_3, smethod_92)
			},
			{
				class96_1.struct0_166.method_0(),
				new Struct5(class96_1.struct0_166, smethod_200)
			},
			{
				class96_1.struct0_178.method_0(),
				new Struct5(class96_1.struct0_178, smethod_141)
			},
			{
				class96_1.struct0_10.method_0(),
				new Struct5(class96_1.struct0_10, smethod_245)
			},
			{
				class96_1.struct0_107.method_0(),
				new Struct5(class96_1.struct0_107, smethod_222)
			},
			{
				class96_1.struct0_191.method_0(),
				new Struct5(class96_1.struct0_191, smethod_211)
			},
			{
				class96_1.struct0_66.method_0(),
				new Struct5(class96_1.struct0_66, smethod_190)
			},
			{
				class96_1.struct0_99.method_0(),
				new Struct5(class96_1.struct0_99, smethod_145)
			},
			{
				class96_1.struct0_36.method_0(),
				new Struct5(class96_1.struct0_36, smethod_86)
			},
			{
				class96_1.struct0_26.method_0(),
				new Struct5(class96_1.struct0_26, smethod_221)
			},
			{
				class96_1.struct0_204.method_0(),
				new Struct5(class96_1.struct0_204, smethod_130)
			},
			{
				class96_1.struct0_98.method_0(),
				new Struct5(class96_1.struct0_98, smethod_137)
			},
			{
				class96_1.struct0_21.method_0(),
				new Struct5(class96_1.struct0_21, smethod_248)
			},
			{
				class96_1.struct0_82.method_0(),
				new Struct5(class96_1.struct0_82, smethod_210)
			},
			{
				class96_1.struct0_154.method_0(),
				new Struct5(class96_1.struct0_154, smethod_197)
			},
			{
				class96_1.struct0_93.method_0(),
				new Struct5(class96_1.struct0_93, smethod_193)
			},
			{
				class96_1.struct0_65.method_0(),
				new Struct5(class96_1.struct0_65, smethod_1)
			},
			{
				class96_1.struct0_118.method_0(),
				new Struct5(class96_1.struct0_118, smethod_203)
			},
			{
				class96_1.struct0_50.method_0(),
				new Struct5(class96_1.struct0_50, smethod_216)
			},
			{
				class96_1.struct0_103.method_0(),
				new Struct5(class96_1.struct0_103, smethod_48)
			},
			{
				class96_1.struct0_35.method_0(),
				new Struct5(class96_1.struct0_35, smethod_235)
			},
			{
				class96_1.struct0_1.method_0(),
				new Struct5(class96_1.struct0_1, smethod_101)
			},
			{
				class96_1.struct0_174.method_0(),
				new Struct5(class96_1.struct0_174, smethod_166)
			},
			{
				class96_1.struct0_40.method_0(),
				new Struct5(class96_1.struct0_40, smethod_9)
			},
			{
				class96_1.struct0_27.method_0(),
				new Struct5(class96_1.struct0_27, smethod_79)
			},
			{
				class96_1.struct0_131.method_0(),
				new Struct5(class96_1.struct0_131, smethod_186)
			},
			{
				class96_1.struct0_192.method_0(),
				new Struct5(class96_1.struct0_192, smethod_0)
			},
			{
				class96_1.struct0_84.method_0(),
				new Struct5(class96_1.struct0_84, smethod_126)
			},
			{
				class96_1.struct0_207.method_0(),
				new Struct5(class96_1.struct0_207, smethod_220)
			},
			{
				class96_1.struct0_14.method_0(),
				new Struct5(class96_1.struct0_14, smethod_213)
			},
			{
				class96_1.struct0_7.method_0(),
				new Struct5(class96_1.struct0_7, smethod_14)
			},
			{
				class96_1.struct0_4.method_0(),
				new Struct5(class96_1.struct0_4, smethod_98)
			},
			{
				class96_1.struct0_42.method_0(),
				new Struct5(class96_1.struct0_42, smethod_127)
			},
			{
				class96_1.struct0_181.method_0(),
				new Struct5(class96_1.struct0_181, smethod_28)
			},
			{
				class96_1.struct0_56.method_0(),
				new Struct5(class96_1.struct0_56, smethod_106)
			},
			{
				class96_1.struct0_49.method_0(),
				new Struct5(class96_1.struct0_49, smethod_70)
			},
			{
				class96_1.struct0_171.method_0(),
				new Struct5(class96_1.struct0_171, smethod_174)
			},
			{
				class96_1.struct0_170.method_0(),
				new Struct5(class96_1.struct0_170, smethod_97)
			},
			{
				class96_1.struct0_116.method_0(),
				new Struct5(class96_1.struct0_116, smethod_132)
			},
			{
				class96_1.struct0_31.method_0(),
				new Struct5(class96_1.struct0_31, smethod_103)
			},
			{
				class96_1.struct0_148.method_0(),
				new Struct5(class96_1.struct0_148, smethod_151)
			},
			{
				class96_1.struct0_186.method_0(),
				new Struct5(class96_1.struct0_186, smethod_246)
			},
			{
				class96_1.struct0_92.method_0(),
				new Struct5(class96_1.struct0_92, smethod_105)
			},
			{
				class96_1.struct0_122.method_0(),
				new Struct5(class96_1.struct0_122, smethod_18)
			},
			{
				class96_1.struct0_112.method_0(),
				new Struct5(class96_1.struct0_112, smethod_21)
			},
			{
				class96_1.struct0_161.method_0(),
				new Struct5(class96_1.struct0_161, smethod_168)
			},
			{
				class96_1.struct0_187.method_0(),
				new Struct5(class96_1.struct0_187, smethod_194)
			},
			{
				class96_1.struct0_137.method_0(),
				new Struct5(class96_1.struct0_137, smethod_134)
			},
			{
				class96_1.struct0_114.method_0(),
				new Struct5(class96_1.struct0_114, smethod_178)
			},
			{
				class96_1.struct0_102.method_0(),
				new Struct5(class96_1.struct0_102, smethod_96)
			},
			{
				class96_1.struct0_123.method_0(),
				new Struct5(class96_1.struct0_123, smethod_61)
			},
			{
				class96_1.struct0_69.method_0(),
				new Struct5(class96_1.struct0_69, smethod_3)
			},
			{
				class96_1.struct0_37.method_0(),
				new Struct5(class96_1.struct0_37, smethod_176)
			},
			{
				class96_1.struct0_90.method_0(),
				new Struct5(class96_1.struct0_90, smethod_71)
			},
			{
				class96_1.struct0_193.method_0(),
				new Struct5(class96_1.struct0_193, smethod_94)
			},
			{
				class96_1.struct0_140.method_0(),
				new Struct5(class96_1.struct0_140, smethod_111)
			},
			{
				class96_1.struct0_173.method_0(),
				new Struct5(class96_1.struct0_173, smethod_207)
			},
			{
				class96_1.struct0_113.method_0(),
				new Struct5(class96_1.struct0_113, smethod_59)
			},
			{
				class96_1.struct0_70.method_0(),
				new Struct5(class96_1.struct0_70, smethod_157)
			},
			{
				class96_1.struct0_129.method_0(),
				new Struct5(class96_1.struct0_129, smethod_26)
			},
			{
				class96_1.struct0_149.method_0(),
				new Struct5(class96_1.struct0_149, smethod_212)
			},
			{
				class96_1.struct0_134.method_0(),
				new Struct5(class96_1.struct0_134, smethod_116)
			},
			{
				class96_1.struct0_144.method_0(),
				new Struct5(class96_1.struct0_144, smethod_69)
			},
			{
				class96_1.struct0_117.method_0(),
				new Struct5(class96_1.struct0_117, smethod_169)
			},
			{
				class96_1.struct0_13.method_0(),
				new Struct5(class96_1.struct0_13, smethod_123)
			},
			{
				class96_1.struct0_128.method_0(),
				new Struct5(class96_1.struct0_128, smethod_208)
			},
			{
				class96_1.struct0_106.method_0(),
				new Struct5(class96_1.struct0_106, smethod_143)
			},
			{
				class96_1.struct0_16.method_0(),
				new Struct5(class96_1.struct0_16, smethod_170)
			},
			{
				class96_1.struct0_59.method_0(),
				new Struct5(class96_1.struct0_59, smethod_99)
			},
			{
				class96_1.struct0_119.method_0(),
				new Struct5(class96_1.struct0_119, smethod_40)
			},
			{
				class96_1.struct0_62.method_0(),
				new Struct5(class96_1.struct0_62, smethod_140)
			},
			{
				class96_1.struct0_142.method_0(),
				new Struct5(class96_1.struct0_142, smethod_47)
			},
			{
				class96_1.struct0_201.method_0(),
				new Struct5(class96_1.struct0_201, smethod_78)
			},
			{
				class96_1.struct0_212.method_0(),
				new Struct5(class96_1.struct0_212, smethod_150)
			},
			{
				class96_1.struct0_32.method_0(),
				new Struct5(class96_1.struct0_32, smethod_68)
			},
			{
				class96_1.struct0_164.method_0(),
				new Struct5(class96_1.struct0_164, smethod_135)
			},
			{
				class96_1.struct0_76.method_0(),
				new Struct5(class96_1.struct0_76, smethod_50)
			},
			{
				class96_1.struct0_48.method_0(),
				new Struct5(class96_1.struct0_48, smethod_201)
			},
			{
				class96_1.struct0_169.method_0(),
				new Struct5(class96_1.struct0_169, smethod_33)
			},
			{
				class96_1.struct0_213.method_0(),
				new Struct5(class96_1.struct0_213, smethod_107)
			},
			{
				class96_1.struct0_67.method_0(),
				new Struct5(class96_1.struct0_67, smethod_117)
			},
			{
				class96_1.struct0_194.method_0(),
				new Struct5(class96_1.struct0_194, smethod_215)
			},
			{
				class96_1.struct0_97.method_0(),
				new Struct5(class96_1.struct0_97, smethod_120)
			},
			{
				class96_1.struct0_45.method_0(),
				new Struct5(class96_1.struct0_45, smethod_51)
			},
			{
				class96_1.struct0_158.method_0(),
				new Struct5(class96_1.struct0_158, smethod_147)
			},
			{
				class96_1.struct0_105.method_0(),
				new Struct5(class96_1.struct0_105, smethod_20)
			},
			{
				class96_1.struct0_110.method_0(),
				new Struct5(class96_1.struct0_110, smethod_66)
			},
			{
				class96_1.struct0_101.method_0(),
				new Struct5(class96_1.struct0_101, smethod_226)
			},
			{
				class96_1.struct0_39.method_0(),
				new Struct5(class96_1.struct0_39, smethod_34)
			},
			{
				class96_1.struct0_46.method_0(),
				new Struct5(class96_1.struct0_46, smethod_17)
			}
		};
	}

	private void method_100()
	{
		Class6 class6_ = method_80();
		Class18 class18_ = (Class18)method_80();
		method_9(class18_, class6_);
	}

	private static void smethod_231(Class104 class104_0, Class6 class6_4)
	{
		Class31 @class = (Class31)class6_4;
		MethodBase methodBase_ = class104_0.method_15(@class.method_3());
		Class29 class2 = new Class29();
		class2.method_4(methodBase_);
		class104_0.method_35(class2);
	}

	public object method_101(Stream stream_1, string string_0, object[] object_3)
	{
		return method_68(stream_1, string_0, object_3, null, null, null);
	}

	private static void smethod_232(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_35(class6_4);
	}

	private static string smethod_233(MethodBase methodBase_0)
	{
		Type declaringType = methodBase_0.DeclaringType;
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		string[] array = new string[parameters.Length];
		for (int i = 0; i < parameters.Length; i++)
		{
			ParameterInfo parameterInfo = parameters[i];
			array[i] = string.Format(Class84.smethod_0(-994271897), parameterInfo.ParameterType, parameterInfo.Name);
		}
		string text = string.Join(Class84.smethod_0(-994271851), array);
		return declaringType.FullName + Class84.smethod_0(-994272055) + methodBase_0.Name + Class84.smethod_0(-994271858) + text + Class84.smethod_0(-994271866);
	}

	private static void smethod_234(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		float num = @class.method_0() switch
		{
			6 => ((Class31)@class).method_3(), 
			1 => Convert.ToUInt64(((Class15)@class).method_3()), 
			15 => (float)((Class11)@class).method_3(), 
			12 => ((Class33)@class).method_3(), 
			_ => throw new InvalidOperationException(), 
		};
		Class11 class2 = new Class11();
		class2.method_4(num);
		class104_0.method_35(class2);
	}

	private static void smethod_235(Class104 class104_0, Class6 class6_4)
	{
		object object_ = class104_0.method_80().vmethod_0();
		long num = class104_0.method_33();
		Array array = (Array)class104_0.method_80().vmethod_0();
		Type elementType = array.GetType().GetElementType();
		if ((object)elementType == typeof(sbyte))
		{
			Class6 @class = Class6.smethod_0(object_, typeof(sbyte));
			((sbyte[])array)[num] = (sbyte)@class.vmethod_0();
		}
		else if ((object)elementType == typeof(byte))
		{
			Class6 class2 = Class6.smethod_0(object_, typeof(byte));
			((byte[])array)[num] = (byte)class2.vmethod_0();
		}
		else if ((object)elementType == typeof(bool))
		{
			Class6 class3 = Class6.smethod_0(object_, typeof(bool));
			((bool[])array)[num] = (bool)class3.vmethod_0();
		}
		else if (elementType.IsEnum)
		{
			class104_0.method_10(elementType, object_, num, array);
		}
		else
		{
			class104_0.method_10(typeof(sbyte), object_, num, array);
		}
	}

	private void method_102()
	{
		uint_2 = uint_1;
		int key = class48_0.method_19();
		uint_1 += 4u;
		dictionary_4.TryGetValue(key, out var value);
		value.delegate0_0(this, method_86(class48_0, value.byte_0));
	}

	private static void smethod_236(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		double double_ = @class.method_0() switch
		{
			12 => (double)(ulong)((Class33)@class).method_3(), 
			6 => (uint)((Class31)@class).method_3(), 
			1 => Convert.ToUInt64(((Class15)@class).method_3()), 
			_ => throw new InvalidOperationException(), 
		};
		Class11 class2 = new Class11();
		class2.method_4(double_);
		class104_0.method_35(class2);
	}

	private bool method_103(Type type_9, Class70 class70_0, out int int_0)
	{
		int_0 = 0;
		Class56 @class = (Class56)class70_0.method_4();
		if (Class99.smethod_1(type_9).IsGenericParameter)
		{
			if (@class != null && !@class.method_2())
			{
				return false;
			}
			return true;
		}
		Type type = method_71(class70_0.method_2(), bool_2: false);
		if (!Class79.smethod_0(type_9, type, out int_0))
		{
			return false;
		}
		return true;
	}

	private static void smethod_237(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_39(2);
	}

	private static Class6 smethod_238(Class6 class6_4, Class6 class6_5, bool bool_2)
	{
		if (!bool_2)
		{
			long num = ((Class33)class6_4).method_3();
			long num2 = ((Class33)class6_5).method_3();
			return new Class33(num % num2);
		}
		long num3 = ((Class33)class6_4).method_3();
		ulong num4 = (ulong)((Class33)class6_5).method_3();
		return new Class33((long)((ulong)num3 % num4));
	}

	private static void smethod_239(Class104 class104_0, Class6 class6_4)
	{
		Class6 @class = class104_0.method_80();
		if (@class.method_0() != 6)
		{
			throw new InvalidOperationException();
		}
		int num = ((Class31)@class).method_3();
		Stack<Class110> stack = class104_0.method_73();
		if (stack.Count < 2)
		{
			throw new InvalidOperationException();
		}
		using Class110 class2 = stack.Pop();
		if (class2 == null || class2.class40_0.imethod_0() != num)
		{
			throw new InvalidOperationException();
		}
		Class110 class110_ = stack.Peek();
		class104_0.method_52(class110_);
		class104_0.uint_1 += (uint)class2.class40_0.method_3();
		class104_0.method_89(class104_0.uint_1);
	}

	private static void smethod_240(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_53(typeof(double));
	}

	private int method_104()
	{
		return -1363038944;
	}

	private static void smethod_241(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_2(class6_4);
	}

	private static void smethod_242(Class104 class104_0, Class6 class6_4)
	{
		if (class104_0.object_2 == null)
		{
			throw new InvalidOperationException();
		}
		class104_0.method_8(class104_0.object_2);
	}

	private static void smethod_243(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		if (smethod_74(class104_0.method_80(), class6_5))
		{
			uint uint_ = ((Class28)class6_4).method_3();
			class104_0.method_92(uint_);
		}
	}

	private static void smethod_244(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_95(typeof(sbyte));
	}

	private Class6[] method_105(object[] object_3)
	{
		Class114[] array = class36_0.method_2();
		int num = array.Length;
		Class6[] array2 = new Class6[num];
		int num2 = 0;
		while (true)
		{
			if (num2 < num)
			{
				object obj = object_3[num2];
				Type type = method_71(array[num2].method_0(), bool_2: false);
				Type type2 = null;
				Type type3 = Class99.smethod_2(type);
				if ((object)type3 == Class99.type_0 || Class99.smethod_0(type3))
				{
					type2 = type;
				}
				else
				{
					type2 = ((obj != null) ? obj.GetType() : type);
				}
				if (obj == null || type.IsAssignableFrom(type2) || !type.IsByRef || type.GetElementType().IsAssignableFrom(type2))
				{
					array2[num2] = Class6.smethod_0(obj, type2);
					num2++;
					continue;
				}
				throw new ArgumentException(string.Format(Class84.smethod_0(-994271252), type2, type));
			}
			if (!class36_0.method_12() && method_71(class36_0.method_6(), bool_2: false).IsValueType)
			{
				Class21 @class = new Class21();
				@class.method_4(array2[0]);
				array2[0] = @class;
			}
			for (int i = 0; i < num; i++)
			{
				if (array[i].method_2())
				{
					int num3 = i;
					Class21 class2 = new Class21();
					class2.method_4(array2[i]);
					array2[num3] = class2;
				}
			}
			break;
		}
		return array2;
	}

	private static void smethod_245(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_72(bool_2: false, bool_3: false);
	}

	private long method_106()
	{
		return class48_0.method_0().vmethod_4() + long_0;
	}

	private static void smethod_246(Class104 class104_0, Class6 class6_4)
	{
		Class6 class6_5 = class104_0.method_80();
		Class6 class6_6 = class104_0.method_80();
		class104_0.method_35(class104_0.method_58(class6_6, class6_5));
	}

	private static void smethod_247(Class104 class104_0, Class6 class6_4)
	{
		throw new NotSupportedException(Class84.smethod_0(-994271583));
	}

	private static void smethod_248(Class104 class104_0, Class6 class6_4)
	{
		class104_0.method_14(bool_2: true);
	}

	private static void smethod_249(Class104 class104_0, Class6 class6_4)
	{
		int int_ = ((Class31)class6_4).method_3();
		Type t = class104_0.method_71(int_, bool_2: true);
		class104_0.method_35(new Class31(Marshal.SizeOf(t)));
	}
}
