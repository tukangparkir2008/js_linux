using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

public sealed class GClass10
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct13 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GClass10 gclass10_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GClass10 gClass = gclass10_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = Task.Delay(gClass.int_0).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
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
				if (gClass.gdelegate9_0 != null)
				{
					gClass.method_2();
				}
				else
				{
					gClass.method_3(gClass.object_0);
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private readonly int int_0;

	private readonly GDelegate9 gdelegate9_0;

	private readonly GDelegate14 gdelegate14_0;

	private readonly object object_0;

	private readonly Form form_0;

	public GClass10(int int_1, GDelegate9 gdelegate9_1, Form form_1)
	{
		int_0 = int_1;
		gdelegate9_0 = gdelegate9_1;
		gdelegate14_0 = null;
		object_0 = null;
		form_0 = form_1;
	}

	public GClass10(int int_1, GDelegate14 gdelegate14_1, object object_1, Form form_1)
	{
		int_0 = int_1;
		gdelegate9_0 = null;
		gdelegate14_0 = gdelegate14_1;
		object_0 = object_1;
		form_0 = form_1;
	}

	public void method_0()
	{
		Task.Run((Action)method_4);
	}

	private async void method_1()
	{
		await Task.Delay(int_0);
		if (gdelegate9_0 != null)
		{
			method_2();
		}
		else
		{
			method_3(object_0);
		}
	}

	private void method_2()
	{
		if (form_0.InvokeRequired)
		{
			GDelegate9 method = method_2;
			form_0.Invoke(method);
		}
		else
		{
			gdelegate9_0();
		}
	}

	private void method_3(object object_1)
	{
		if (form_0.InvokeRequired)
		{
			GDelegate14 method = method_3;
			form_0.Invoke(method, object_1);
		}
		else
		{
			gdelegate14_0(object_1);
		}
	}

	private void method_4()
	{
		method_1();
	}
}
