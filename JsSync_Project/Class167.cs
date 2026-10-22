using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Newtonsoft.Json;

internal sealed class Class167
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct16 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public Class167 class167_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class167 @class = class167_0;
			try
			{
				if (num == 0)
				{
					goto IL_0015;
				}
				goto IL_0164;
				IL_0015:
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(Class224.Class226.int_9, @class.cancellationTokenSource_0.Token).GetAwaiter();
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
				}
				catch (TaskCanceledException)
				{
				}
				catch (Exception ex2)
				{
					Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
				}
				goto IL_0164;
				IL_0164:
				if (@class.bool_0)
				{
					try
					{
						if (@class.bool_1)
						{
							@class.string_1 = smethod_0(@class.string_0).Result;
						}
					}
					catch (Exception ex3)
					{
						@class.gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994100689));
						@class.gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, ex3.Message);
						Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex3.Message, ex3);
					}
					goto IL_0015;
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

	[StructLayout(LayoutKind.Auto)]
	private struct Struct17 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		public string string_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			string result;
			try
			{
				TaskAwaiter<string> awaiter;
				if (num != 0)
				{
					MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(string_0));
					GoogleCredential googleCredential;
					try
					{
						googleCredential = GoogleCredential.FromStream(memoryStream).CreateScoped(Class84.smethod_0(-994100762));
					}
					finally
					{
						if (num < 0)
						{
							((IDisposable)memoryStream)?.Dispose();
						}
					}
					awaiter = googleCredential.UnderlyingCredential.GetAccessTokenForRequestAsync().GetAwaiter();
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
				result = awaiter.GetResult();
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

	private bool bool_0;

	private CancellationTokenSource cancellationTokenSource_0;

	private readonly GClass4 gclass4_0;

	private bool bool_1;

	private string string_0 = string.Empty;

	private string string_1 = string.Empty;

	public Class167(GClass4 gclass4_1)
	{
		gclass4_0 = gclass4_1;
	}

	public string method_0()
	{
		return string_1;
	}

	private void method_1()
	{
		try
		{
			StreamReader streamReader = new StreamReader(Path.Combine(Class224.Class232.string_0, Class84.smethod_0(-994100615)));
			string value = streamReader.ReadToEnd();
			streamReader.Close();
			List<string> list = JsonConvert.DeserializeObject<List<string>>(value);
			bool_1 = true;
			string_0 = Class123.smethod_4(list[0]);
			Class348.Class353.string_3 = Class123.smethod_4(list[1]);
			Console.WriteLine(string_0);
			Console.WriteLine(Class348.Class353.string_3);
		}
		catch (Exception ex)
		{
			bool_1 = false;
			string_0 = string.Empty;
			gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994100628));
			gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_2()
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			bool_0 = true;
			cancellationTokenSource_0 = new CancellationTokenSource();
			method_1();
			Task.Run((Action)method_5);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private static async Task<string> smethod_0(string string_2)
	{
		GoogleCredential googleCredential;
		using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(string_2)))
		{
			googleCredential = GoogleCredential.FromStream(stream).CreateScoped(Class84.smethod_0(-994100762));
		}
		return await googleCredential.UnderlyingCredential.GetAccessTokenForRequestAsync();
	}

	private async void method_3()
	{
		while (bool_0)
		{
			try
			{
				if (bool_1)
				{
					string_1 = smethod_0(string_0).Result;
				}
			}
			catch (Exception ex)
			{
				gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, Class84.smethod_0(-994100689));
				gclass4_0.method_5(GEnum0.Error, string.Empty, string.Empty, ex.Message);
				Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			}
			try
			{
				await Task.Delay(Class224.Class226.int_9, cancellationTokenSource_0.Token);
			}
			catch (TaskCanceledException)
			{
			}
			catch (Exception ex3)
			{
				Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex3.Message, ex3);
			}
		}
	}

	public void method_4()
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

	private void method_5()
	{
		method_3();
	}
}
