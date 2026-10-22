using System;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

public class GClass4(GForm17 gform17_1) : GClass3(gform17_1)
{
	private sealed class Class297 : GClass48
	{
		private readonly GClass4 gclass4_0;

		public Class297(GClass4 gclass4_1)
		{
			gclass4_0 = gclass4_1;
		}

		public override void vmethod_0()
		{
			gclass4_0.method_21();
		}

		public override void vmethod_1()
		{
			gclass4_0.method_22();
		}
	}

	private sealed class Class266
	{
		public GClass41 gclass41_0;

		public GClass4 gclass4_0;

		internal Task method_0()
		{
			return gclass4_0.method_20(gclass41_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct29 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GClass41 gclass41_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(100).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default;
						num = -1;
						int_0 = -1;
					}
					awaiter.GetResult();
					gclass41_0.vmethod_5();
				}
				catch (Exception ex)
				{
					Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private sealed class Class298 : GClass48
	{
		private readonly GClass4 gclass4_0;

		public Class298(GClass4 gclass4_1)
		{
			gclass4_0 = gclass4_1;
		}

		public override void vmethod_0()
		{
			gclass4_0.method_33();
		}

		public override void vmethod_1()
		{
			gclass4_0.method_34();
		}
	}

	private readonly Class163 class163_0 = new Class163();

	private bool bool_0;

	private bool bool_1;

	private Class202 class202_0;

	private bool bool_2;

	private Class141 class141_0;

	private Class283 class283_0;

	private GClass48 gclass48_0;

	private GClass48 gclass48_1;

	private bool bool_3;

	private Class157 class157_0;

	private Class306 class306_0;

	private Class175 class175_0;

	private Class219 class219_0;

	private Class323 class323_0;

	private Class167 class167_0;

	private readonly object object_0 = new object();

	private ulong ulong_0;

	private int int_0;

	private bool bool_4;

	private Class319 class319_0;

	private bool bool_5;

	private Class268 class268_0;

	private Class264 class264_0;

	public bool method_7()
	{
		return bool_5;
	}

	public string method_8()
	{
		if (class167_0 == null)
		{
			return string.Empty;
		}
		return class167_0.method_0();
	}

	public GClass41 method_9(int int_1)
	{
		return class163_0.method_5(int_1);
	}

	public int method_10()
	{
		return class163_0.method_4();
	}

	public void method_11()
	{
		lock (object_0)
		{
			ulong_0++;
		}
	}

	private void method_12()
	{
		lock (object_0)
		{
			ulong_0 = 0uL;
		}
	}

	public ulong method_13()
	{
		lock (object_0)
		{
			return ulong_0;
		}
	}

	public ulong method_14()
	{
		return class175_0?.method_2() ?? 0L;
	}

	public void method_15()
	{
		class163_0.method_3();
		for (int i = 0; i < Class348.Class352.int_1; i++)
		{
			GClass41 gClass = new GClass41(this, i + 1, Dns.GetHostAddresses(Class249.Class251.string_0)[0].ToString(), Class249.Class251.int_0);
			gClass.method_39(method_19);
			gClass.method_41(method_17);
			class163_0.method_0(gClass);
			gClass.vmethod_4();
		}
	}

	public void method_16()
	{
		int num = class163_0.method_4();
		for (int i = 0; i < num; i++)
		{
			class163_0.method_5(i)?.vmethod_5();
		}
	}

	private void method_17(GClass41 gclass41_0)
	{
		if (bool_0)
		{
			if (gclass41_0.method_50() < Class135.int_0)
			{
				Tuple<string, int> tuple = Class135.smethod_0(gclass41_0.method_50());
				method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, Class84.smethod_0(-994288837) + Class249.Class251.smethod_0());
				method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, Class84.smethod_0(-994101318) + tuple.Item1);
				Thread.Sleep(tuple.Item2);
				gclass41_0.vmethod_4();
			}
			else
			{
				class202_0.method_4(bool_0: false);
			}
			return;
		}
		class163_0.method_1(gclass41_0);
		if (bool_2)
		{
			if (class163_0.method_4() == 0)
			{
				Class348.Class349.bool_0 = false;
				Class348.Class353.string_5 = string.Empty;
				method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994101306));
				method_0().method_21();
				bool_2 = false;
				gclass48_1?.vmethod_0();
			}
		}
		else if (class163_0.method_4() == 0)
		{
			Class162.smethod_1(Class84.smethod_0(-994105315), Class84.smethod_0(-994105300));
			if (!bool_1)
			{
				method_18();
			}
		}
	}

	private void method_18()
	{
		method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994105279) + Class249.Class251.smethod_0().ToUpper() + Class84.smethod_0(-994105229));
		method_38();
		Class348.Class349.bool_0 = false;
		method_0().method_21();
		Class224.Class226.int_18++;
		if (Class224.Class226.int_18 <= Class224.Class226.int_17)
		{
			method_0().method_18();
		}
	}

	private void method_19(GClass41 gclass41_0)
	{
		if (bool_0)
		{
			class202_0.method_4(bool_0: true);
		}
	}

	public virtual void vmethod_0(GClass48 gclass48_2)
	{
		try
		{
			gclass48_1 = gclass48_2;
			bool_2 = true;
			int num = class163_0.method_4();
			for (int i = 0; i < num; i++)
			{
				Class266 @class = new Class266();
				@class.gclass4_0 = this;
				@class.gclass41_0 = class163_0.method_5(i);
				if (@class.gclass41_0 != null)
				{
					Task.Run((Func<Task>)@class.method_0);
				}
			}
			method_36();
			method_37();
			method_38();
			method_31();
			method_39();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private async Task method_20(GClass41 gclass41_0)
	{
		try
		{
			await Task.Delay(100);
			gclass41_0.vmethod_5();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public virtual void vmethod_1(GClass48 gclass48_2)
	{
		try
		{
			Class162.smethod_1(Class84.smethod_0(-994105245), Class84.smethod_0(-994105215));
			gclass48_0 = gclass48_2;
			bool_0 = true;
			bool_1 = false;
			class202_0 = new Class202(this, new Class297(this));
			class202_0.method_0();
		}
		catch (Exception ex)
		{
			bool_0 = false;
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_21()
	{
		try
		{
			bool_1 = false;
			method_3(2, 100);
			gclass48_0?.vmethod_0();
			method_26();
			method_25();
			method_27();
			method_30();
			method_29();
			method_12();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_22()
	{
		try
		{
			bool_1 = true;
			method_40();
			gclass48_0?.vmethod_1();
			method_12();
			method_16();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_23()
	{
		class268_0.method_2(null, bool_4: false);
	}

	public GClass70 method_24(GClass58 gclass58_0)
	{
		return class264_0.method_11(gclass58_0);
	}

	private void method_25()
	{
		try
		{
			class268_0 = new Class268(this);
			class268_0.method_0();
			class264_0 = new Class264(this);
			class264_0.method_0();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_26()
	{
		try
		{
			class319_0 = new Class319(Class224.Class229.string_0, Class224.Class229.int_0, this);
			GClass70 gClass = class319_0.vmethod_1();
			bool_5 = gClass.Value == 1;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_27()
	{
		try
		{
			int_0 = 0;
			class141_0 = new Class141(this, method_32);
			class141_0.method_1();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_28()
	{
	}

	public void method_29()
	{
		try
		{
			class283_0 = new Class283(this, method_28);
			class283_0.method_0();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_30()
	{
		try
		{
			class167_0 = new Class167(this);
			class167_0.method_2();
			class306_0 = new Class306();
			class219_0 = new Class219();
			class157_0 = new Class157(this, class306_0, class219_0);
			class157_0.method_0();
			class175_0 = new Class175(method_0(), class306_0);
			class175_0.method_6();
			class323_0 = new Class323(method_0(), class219_0);
			class323_0.method_4();
			bool_3 = true;
		}
		catch (Exception ex)
		{
			bool_3 = false;
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_31()
	{
		if (!bool_3)
		{
			return;
		}
		try
		{
			class167_0.method_4();
			class306_0.method_3();
			class219_0.method_3();
			class157_0.method_1();
			class175_0.method_7();
			class323_0.method_5();
			bool_3 = false;
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_32(int int_1, int int_2)
	{
		try
		{
			if (int_1 == 0)
			{
				int_0++;
				bool_4 = true;
				method_5(GEnum0.Error, string.Empty, Class84.smethod_0(-994105163), Class84.smethod_0(-994105128) + Class249.Class251.smethod_0() + Class84.smethod_0(-994105142));
				method_3(-1, 0);
				if (int_0 == 3)
				{
					class163_0.method_3();
					method_18();
				}
				return;
			}
			if (int_2 == 0)
			{
				int_0 = 0;
				method_3(2, 100);
				if (bool_4)
				{
					bool_4 = false;
					method_5(GEnum0.Info, string.Empty, string.Empty, Class84.smethod_0(-994105128) + Class249.Class251.smethod_0() + Class84.smethod_0(-994105095));
					method_5(GEnum0.Info, string.Empty, string.Empty, string.Format(Class84.smethod_0(-994105097), int_1, int_2));
				}
				return;
			}
			int_0 = 0;
			bool_4 = true;
			float num = int_1 + int_2;
			double num2 = Math.Round((float)(100 * int_1) / num, 0);
			method_3(1, Convert.ToInt32(num2));
			if (num2 >= 70.0)
			{
				method_3(2, 100);
				return;
			}
			Class162.smethod_1(Class84.smethod_0(-994105080), string.Format(Class84.smethod_0(-994105039), num2));
			method_5(GEnum0.Warn, string.Empty, string.Empty, Class84.smethod_0(-994105128) + Class249.Class251.smethod_0() + Class84.smethod_0(-994105005));
			method_5(GEnum0.Warn, string.Empty, string.Empty, string.Format(Class84.smethod_0(-994105097), int_1, int_2));
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_33()
	{
		method_5(GEnum0.Info, string.Empty, string.Empty, Class84.smethod_0(-994104968) + Class249.Class251.smethod_0());
		gclass48_0?.vmethod_0();
	}

	public void method_34()
	{
		method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994104935) + Class249.Class251.smethod_0());
		gclass48_0?.vmethod_1();
	}

	public void method_35()
	{
		try
		{
			class141_0 = new Class141(this, method_32);
			class141_0.method_0();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_36()
	{
		try
		{
			if (bool_5)
			{
				class319_0.vmethod_2();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_37()
	{
		try
		{
			class268_0?.method_11();
			class264_0?.method_1();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_38()
	{
		try
		{
			if (class141_0 != null)
			{
				class141_0.method_2();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_39()
	{
		try
		{
			if (class283_0 != null)
			{
				class283_0.method_1();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_40()
	{
		bool_0 = false;
		class202_0 = null;
	}

	public void method_41()
	{
	}

	private void method_42()
	{
	}
}
