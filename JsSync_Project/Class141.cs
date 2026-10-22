using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Yim.Jibas.JendelaSekolah.Common.Data;

internal sealed class Class141
{
	internal sealed class Class332 : GClass59
	{
		private readonly Class141 class141_0;

		private readonly Class142 class142_0;

		public Class332(Class141 class141_1, Class142 class142_1)
		{
			class141_0 = class141_1;
			class142_0 = class142_1;
		}

		public override void vmethod_0(GClass41 gclass41_0, JsRequest jsRequest_0, string string_0)
		{
			if (jsRequest_0.ExecCode == 1)
			{
				class141_0.method_5(gclass41_0, class142_0, this);
			}
			else
			{
				class141_0.method_6(gclass41_0, class142_0, this);
			}
		}

		public override void vmethod_1(GClass41 gclass41_0, string string_0)
		{
			class141_0.method_6(gclass41_0, class142_0, this);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct11 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public Class141 class141_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class141 @class = class141_0;
			try
			{
				if (num == 0)
				{
					goto IL_001b;
				}
				@class.bool_0 = true;
				goto IL_0090;
				IL_001b:
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(Class224.Class226.int_3, @class.cancellationTokenSource_0.Token).GetAwaiter();
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
				}
				catch (Exception)
				{
				}
				if (@class.bool_0)
				{
					@class.method_4();
				}
				goto IL_0090;
				IL_0090:
				if (@class.bool_0)
				{
					goto IL_001b;
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

	internal sealed class Class142
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public Class142(int int_3)
		{
			int_2 = int_3;
		}

		public override string ToString()
		{
			return string.Format(Class84.smethod_0(-994102756), int_0, int_1);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct12 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public int int_1;

		public Class141 class141_0;

		public GClass41 gclass41_0;

		public Class332 class332_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class141 @class = class141_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(int_1, @class.cancellationTokenSource_0.Token).GetAwaiter();
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
					gclass41_0.method_52(@class.jsRequest_0, Class224.Class226.int_7, class332_0);
				}
				catch (Exception)
				{
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

	private readonly GClass4 gclass4_0;

	private readonly GDelegate4 gdelegate4_0;

	private readonly JsRequest jsRequest_0;

	private bool bool_0;

	private CancellationTokenSource cancellationTokenSource_0;

	private Class142 class142_0;

	public Class141(GClass4 gclass4_1, GDelegate4 gdelegate4_1)
	{
		gclass4_0 = gclass4_1;
		gdelegate4_0 = gdelegate4_1;
		JsUserRequest userRequest = new JsUserRequest
		{
			SchoolId = Class348.Class352.string_0,
			SchoolName = Class348.Class352.string_1,
			DataId = Class211.smethod_0(10),
			SessionId = string.Empty
		};
		jsRequest_0 = new JsRequest(JsProtocol.PingSchoolToServer, JsDirection.SchoolToServer, userRequest, 0, 0, 0, string.Empty, null, null);
	}

	public void method_0()
	{
		try
		{
			cancellationTokenSource_0 = new CancellationTokenSource();
			Class224.Class226.int_5 = 100;
			method_4();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_1()
	{
		try
		{
			cancellationTokenSource_0 = new CancellationTokenSource();
			method_3();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_2()
	{
		if (!bool_0)
		{
			return;
		}
		try
		{
			bool_0 = false;
			cancellationTokenSource_0.Cancel();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private async Task method_3()
	{
		bool_0 = true;
		while (bool_0)
		{
			try
			{
				await Task.Delay(Class224.Class226.int_3, cancellationTokenSource_0.Token);
			}
			catch (Exception)
			{
			}
			if (bool_0)
			{
				method_4();
			}
		}
	}

	private void method_4()
	{
		try
		{
			if (gclass4_0.method_10() == 0)
			{
				return;
			}
			int num = Class348.Class352.int_1 * Class224.Class226.int_6;
			class142_0 = new Class142(num);
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < Class348.Class352.int_1; i++)
			{
				GClass41 gClass = gclass4_0.method_9(i);
				if (gClass != null && gClass.method_25())
				{
					num2++;
					if (gClass.method_48() < Class224.Class226.int_3)
					{
						num3++;
					}
					else
					{
						gClass.method_52(jsRequest_0, Class224.Class226.int_7, new Class332(this, new Class142(Class224.Class226.int_6)));
					}
				}
			}
			if (num3 == Class348.Class352.int_1)
			{
				method_9(num, 0);
				return;
			}
			if (num2 == 0)
			{
				method_9(0, num);
				return;
			}
			int int_ = num2 * Class224.Class226.int_6;
			int num4 = Class348.Class352.int_1 - num2;
			num4 *= Class224.Class226.int_6;
			method_9(int_, num4);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_5(GClass41 gclass41_0, Class142 class142_1, Class332 class332_0)
	{
		try
		{
			bool flag = false;
			lock (class142_1)
			{
				class142_1.int_0++;
				flag = class142_1.int_0 + class142_1.int_1 >= class142_1.int_2;
			}
			if (flag)
			{
				method_8(class142_1);
			}
			else
			{
				method_7(gclass41_0, class332_0, 1000);
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_6(GClass41 gclass41_0, Class142 class142_1, Class332 class332_0)
	{
		try
		{
			bool flag = false;
			lock (class142_1)
			{
				class142_1.int_1++;
				flag = class142_1.int_0 + class142_1.int_1 >= class142_1.int_2;
			}
			if (flag)
			{
				method_8(class142_1);
			}
			else
			{
				method_7(gclass41_0, class332_0, 1000);
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private async Task method_7(GClass41 gclass41_0, Class332 class332_0, int int_0)
	{
		try
		{
			await Task.Delay(int_0, cancellationTokenSource_0.Token);
			gclass41_0.method_52(jsRequest_0, Class224.Class226.int_7, class332_0);
		}
		catch (Exception)
		{
		}
	}

	private void method_8(Class142 class142_1)
	{
		bool flag = false;
		lock (class142_0)
		{
			class142_0.int_0 += class142_1.int_0;
			class142_0.int_1 += class142_1.int_1;
			flag = class142_0.int_0 + class142_0.int_1 >= class142_0.int_2;
			if (class142_0.int_1 != 0)
			{
				Class162.smethod_1(Class84.smethod_0(-994102723), string.Format(Class84.smethod_0(-994102748), class142_0.int_0, class142_0.int_1));
			}
		}
		if (flag)
		{
			method_9(class142_0.int_0, class142_0.int_1);
		}
	}

	private void method_9(int int_0, int int_1)
	{
		try
		{
			gdelegate4_0(int_0, int_1);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}
}
