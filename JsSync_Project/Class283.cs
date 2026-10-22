using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal sealed class Class283
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct32 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public Class283 class283_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class283 @class = class283_0;
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
						awaiter = Task.Delay(Class224.Class226.int_4, @class.cancellationTokenSource_0.Token).GetAwaiter();
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
					@class.method_3();
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

	private readonly GClass4 gclass4_0;

	private readonly GDelegate9 gdelegate9_0;

	private bool bool_0;

	private CancellationTokenSource cancellationTokenSource_0;

	public Class283(GClass4 gclass4_1, GDelegate9 gdelegate9_1)
	{
		gclass4_0 = gclass4_1;
		gdelegate9_0 = gdelegate9_1;
	}

	public void method_0()
	{
		try
		{
			cancellationTokenSource_0 = new CancellationTokenSource();
			method_2();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_1()
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

	private async Task method_2()
	{
		bool_0 = true;
		while (bool_0)
		{
			try
			{
				await Task.Delay(Class224.Class226.int_4, cancellationTokenSource_0.Token);
			}
			catch (Exception)
			{
			}
			if (bool_0)
			{
				method_3();
			}
		}
	}

	private void method_3()
	{
		Class348.Class350.dateTime_0 = Class190.smethod_10();
		Class348.Class352.smethod_4();
		gdelegate9_0?.Invoke();
	}
}
