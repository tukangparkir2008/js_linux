using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

public sealed class GClass41 : GClass40
{
	public delegate void GDelegate0(GClass41 gclass41_0);

	[StructLayout(LayoutKind.Auto)]
	private struct Struct9 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<int> asyncTaskMethodBuilder_0;

		public GClass41 gclass41_0;

		public int int_1;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GClass41 gClass = gclass41_0;
			int result;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						gClass.cancellationTokenSource_0 = new CancellationTokenSource();
						awaiter = Task.Delay(int_1, gClass.cancellationTokenSource_0.Token).GetAwaiter();
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
					result = 1;
				}
				catch (TaskCanceledException)
				{
					result = 0;
				}
				catch (Exception)
				{
					result = -1;
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result);
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

	public delegate void GDelegate1(GClass41 gclass41_0);

	[StructLayout(LayoutKind.Auto)]
	private struct Struct10 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public JsRequest jsRequest_0;

		public GClass41 gclass41_0;

		public int int_1;

		private TaskAwaiter<int> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GClass41 gClass = gclass41_0;
			try
			{
				int num2;
				if (num != 0)
				{
					byte[] byte_ = BinSerializer.ToByteArray(jsRequest_0);
					gClass.vmethod_10(byte_);
					bool flag = false;
					num2 = 0;
					goto IL_0051;
				}
				TaskAwaiter<int> awaiter = taskAwaiter_0;
				taskAwaiter_0 = default;
				num = -1;
				int_0 = -1;
				goto IL_0084;
				IL_0084:
				num2 = awaiter.GetResult();
				if (num2 == 1 && gClass.method_45() <= int_1)
				{
					goto IL_0051;
				}
				switch (num2)
				{
				case 1:
					gClass.gclass59_0.vmethod_1(gClass, string.Format(Class84.smethod_0(-994197916), gClass.method_0(), int_1));
					break;
				case -1:
					gClass.gclass59_0.vmethod_1(gClass, string.Format(Class84.smethod_0(-994197845), gClass.method_0()));
					break;
				}
				goto end_IL_000e;
				IL_0051:
				awaiter = gClass.method_54(int_1).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 0;
					int_0 = 0;
					taskAwaiter_0 = awaiter;
					asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0084;
				end_IL_000e:;
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

	private long long_5;

	private int int_2;

	private bool bool_9 = true;

	private readonly GClass28 gclass28_3 = new GClass28();

	private GDelegate0 gdelegate0_0;

	private GDelegate1 gdelegate1_0;

	private bool bool_10;

	private GClass59 gclass59_0;

	private CancellationTokenSource cancellationTokenSource_0;

	private readonly string string_0;

	private long long_6;

	private readonly object object_1 = new object();

	private long long_7;

	private int int_3;

	public GClass41(GClass4 gclass4_1, int int_4, string string_1, int int_5)
		: base(string_1, int_5)
	{
		gclass4_0 = gclass4_1;
		string_0 = Class84.smethod_0(-994282651) + int_4;
		long_6 = Class120.smethod_30();
	}

	public void method_39(GDelegate0 gdelegate0_1)
	{
		GDelegate0 gDelegate = gdelegate0_0;
		GDelegate0 gDelegate2;
		do
		{
			gDelegate2 = gDelegate;
			GDelegate0 value = (GDelegate0)Delegate.Combine(gDelegate2, gdelegate0_1);
			gDelegate = Interlocked.CompareExchange(ref gdelegate0_0, value, gDelegate2);
		}
		while ((object)gDelegate != gDelegate2);
	}

	public void method_40(GDelegate0 gdelegate0_1)
	{
		GDelegate0 gDelegate = gdelegate0_0;
		GDelegate0 gDelegate2;
		do
		{
			gDelegate2 = gDelegate;
			GDelegate0 value = (GDelegate0)Delegate.Remove(gDelegate2, gdelegate0_1);
			gDelegate = Interlocked.CompareExchange(ref gdelegate0_0, value, gDelegate2);
		}
		while ((object)gDelegate != gDelegate2);
	}

	public void method_41(GDelegate1 gdelegate1_1)
	{
		GDelegate1 gDelegate = gdelegate1_0;
		GDelegate1 gDelegate2;
		do
		{
			gDelegate2 = gDelegate;
			GDelegate1 value = (GDelegate1)Delegate.Combine(gDelegate2, gdelegate1_1);
			gDelegate = Interlocked.CompareExchange(ref gdelegate1_0, value, gDelegate2);
		}
		while ((object)gDelegate != gDelegate2);
	}

	public void method_42(GDelegate1 gdelegate1_1)
	{
		GDelegate1 gDelegate = gdelegate1_0;
		GDelegate1 gDelegate2;
		do
		{
			gDelegate2 = gDelegate;
			GDelegate1 value = (GDelegate1)Delegate.Remove(gDelegate2, gdelegate1_1);
			gDelegate = Interlocked.CompareExchange(ref gdelegate1_0, value, gDelegate2);
		}
		while ((object)gDelegate != gDelegate2);
	}

	public bool method_43()
	{
		return bool_10;
	}

	public void method_44(bool bool_11)
	{
		bool_10 = bool_11;
	}

	public long method_45()
	{
		lock (object_1)
		{
			return Class120.smethod_30() - long_6;
		}
	}

	public string method_46()
	{
		return string_0;
	}

	private void method_47()
	{
		lock (object_1)
		{
			long_6 = Class120.smethod_30();
		}
	}

	public long method_48()
	{
		return Class120.smethod_30() - long_7;
	}

	public void method_49()
	{
		lock (object_1)
		{
			long_7 = Class120.smethod_30();
		}
	}

	public int method_50()
	{
		return int_3;
	}

	protected override void vmethod_18()
	{
		int_3 = 0;
		gdelegate0_0?.Invoke(this);
	}

	protected override void vmethod_20()
	{
		int_3++;
		gdelegate1_0?.Invoke(this);
	}

	protected override void vmethod_21(byte[] byte_0, long long_8, long long_9)
	{
		try
		{
			method_47();
			if (bool_9 && long_9 > 4L)
			{
				byte[] array = new byte[4];
				Array.Copy(byte_0, 0, array, 0, 4);
				int_2 = BitConverter.ToInt32(array, 0);
				if (int_2 >= 0)
				{
					if (int_2 == long_9 - 4L)
					{
						byte[] array2 = new byte[int_2];
						Array.Copy(byte_0, 4, array2, 0, int_2);
						method_55(array2);
						method_51();
					}
					else
					{
						long num = (long_5 = long_9 - 4L);
						gclass28_3.method_13(byte_0, 4L, num);
						bool_9 = false;
					}
				}
			}
			else
			{
				long_5 += long_9;
				if (long_9 < byte_0.Length)
				{
					gclass28_3.method_13(byte_0, 0L, long_9);
				}
				else
				{
					gclass28_3.method_12(byte_0);
				}
				if (long_5 >= int_2)
				{
					byte[] array3 = new byte[int_2];
					Array.Copy(gclass28_3.method_1(), 0, array3, 0, int_2);
					method_55(array3);
					method_51();
				}
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_51()
	{
		try
		{
			gclass28_3.method_5();
			long_5 = 0L;
			int_2 = 0;
			bool_9 = true;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_52(JsRequest jsRequest_0, int int_4, GClass59 gclass59_1)
	{
		if (!method_25())
		{
			gclass59_1.vmethod_1(this, Class84.smethod_0(-994197821));
			return;
		}
		gclass59_0 = gclass59_1;
		method_53(jsRequest_0, int_4);
	}

	private async Task method_53(JsRequest jsRequest_0, int int_4)
	{
		byte[] byte_ = BinSerializer.ToByteArray(jsRequest_0);
		vmethod_10(byte_);
		int num;
		do
		{
			num = await method_54(int_4);
		}
		while (num == 1 && method_45() <= int_4);
		switch (num)
		{
		case 1:
			gclass59_0.vmethod_1(this, string.Format(Class84.smethod_0(-994197916), method_0(), int_4));
			break;
		case -1:
			gclass59_0.vmethod_1(this, string.Format(Class84.smethod_0(-994197845), method_0()));
			break;
		}
	}

	private async Task<int> method_54(int int_4)
	{
		try
		{
			cancellationTokenSource_0 = new CancellationTokenSource();
			await Task.Delay(int_4, cancellationTokenSource_0.Token);
			return 1;
		}
		catch (TaskCanceledException)
		{
			return 0;
		}
		catch (Exception)
		{
			return -1;
		}
	}

	private void method_55(byte[] byte_0)
	{
		try
		{
			JsRequest jsRequest = BinSerializer.ToJsRequest(byte_0);
			if (jsRequest.Protocol != JsProtocol.PingSchoolToServer)
			{
				method_49();
			}
			if (jsRequest.Direction != JsDirection.UserToSchool && jsRequest.Direction != JsDirection.ServerToSchool)
			{
				cancellationTokenSource_0.Cancel();
				gclass59_0?.vmethod_0(this, jsRequest, Class84.smethod_0(-994247224));
			}
			else
			{
				Class303.smethod_0(gclass4_0, this, jsRequest);
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			gclass59_0?.vmethod_1(this, Class84.smethod_0(-994197745) + ex.Message);
		}
	}
}
