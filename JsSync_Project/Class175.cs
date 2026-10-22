using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Yim.Jibas.JendelaSekolah.Fcm;

internal sealed class Class175
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct22 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public Class175 class175_0;

		private TaskAwaiter<bool> taskAwaiter_0;

		private TaskAwaiter taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			Class175 @class = class175_0;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_001e;
				}
				@class.method_1();
				goto IL_0146;
				IL_001e:
				try
				{
					TaskAwaiter<bool> awaiter;
					TaskAwaiter awaiter2;
					if (num != 0)
					{
						if (num != 1)
						{
							if (Class348.Class349.bool_0)
							{
								Class345 class2 = @class.class306_0.method_1();
								if (class2 != null)
								{
									awaiter = @class.method_12(class2).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 0;
										int_0 = 0;
										taskAwaiter_0 = awaiter;
										asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_00b2;
								}
							}
							goto IL_00ba;
						}
						awaiter2 = taskAwaiter_1;
						taskAwaiter_1 = default;
						num = -1;
						int_0 = -1;
						goto IL_0100;
					}
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default;
					num = -1;
					int_0 = -1;
					goto IL_00b2;
					IL_00ba:
					awaiter2 = Task.Delay(Class224.Class226.int_11, @class.cancellationTokenSource_0.Token).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_1 = awaiter2;
						asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_0100;
					IL_0100:
					awaiter2.GetResult();
					goto end_IL_001e;
					IL_00b2:
					awaiter.GetResult();
					goto IL_00ba;
					end_IL_001e:;
				}
				catch (TaskCanceledException)
				{
				}
				catch (Exception ex2)
				{
					Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
				}
				goto IL_0146;
				IL_0146:
				if (@class.bool_0)
				{
					goto IL_001e;
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
	private struct Struct23 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public Class345 class345_0;

		public Class175 class175_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private int int_1;

		private List<string>.Enumerator enumerator_0;

		private TaskAwaiter taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			Class175 @class = class175_0;
			bool result;
			try
			{
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						if ((uint)(num - 1) > 1u)
						{
							if (class345_0.string_0.Length > 0)
							{
								string string_ = FcmMessage.PrepareMessageTopic(class345_0.string_0, Class348.Class352.string_2 + Class84.smethod_0(-994273716) + class345_0.string_1, class345_0.string_2);
								awaiter = @class.method_11(string_).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									int_0 = 0;
									taskAwaiter_0 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_024c;
							}
							int_1 = 0;
							enumerator_0 = class345_0.list_0.GetEnumerator();
						}
						try
						{
							TaskAwaiter awaiter2;
							if (num != 1)
							{
								if (num != 2)
								{
									goto IL_011b;
								}
								awaiter2 = taskAwaiter_1;
								taskAwaiter_1 = default;
								num = -1;
								int_0 = -1;
								goto IL_010e;
							}
							awaiter = taskAwaiter_0;
							taskAwaiter_0 = default;
							num = -1;
							int_0 = -1;
							goto IL_018c;
							IL_010e:
							awaiter2.GetResult();
							@class.method_0();
							goto IL_011b;
							IL_011b:
							if (enumerator_0.MoveNext())
							{
								string current = enumerator_0.Current;
								int_1++;
								string string_2 = FcmMessage.PrepareMessageToken(current, Class348.Class352.string_2 + Class84.smethod_0(-994273716) + class345_0.string_1, class345_0.string_2);
								awaiter = @class.method_11(string_2).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 1;
									int_0 = 1;
									taskAwaiter_0 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_018c;
							}
							goto end_IL_00c7;
							IL_018c:
							awaiter.GetResult();
							awaiter2 = Task.Delay(750).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = 2;
								int_0 = 2;
								taskAwaiter_1 = awaiter2;
								asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_010e;
							end_IL_00c7:;
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator_0/*cast due to constrained. prefix*/).Dispose();
							}
						}
						enumerator_0 = default;
						@class.method_3(class345_0.long_0, 1);
						goto IL_026c;
					}
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default;
					num = -1;
					int_0 = -1;
					goto IL_024c;
					IL_024c:
					awaiter.GetResult();
					@class.method_0();
					@class.method_3(class345_0.long_0, 1);
					goto IL_026c;
					IL_026c:
					result = true;
				}
				catch (Exception ex)
				{
					@class.method_3(class345_0.long_0, 0);
					Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
					@class.gclass5_0.method_5(GEnum0.Error, string.Empty, Class84.smethod_0(-994103266), Class84.smethod_0(-994103283) + ex.Message);
					result = false;
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

	[StructLayout(LayoutKind.Auto)]
	private struct Struct24 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public Class175 class175_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class175 @class = class175_0;
			try
			{
				if (num == 0)
				{
					goto IL_0015;
				}
				goto IL_00d3;
				IL_0015:
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (Class348.Class349.bool_0 && !@class.bool_1)
						{
							@class.method_9();
						}
						awaiter = Task.Delay(180000, @class.cancellationTokenSource_1.Token).GetAwaiter();
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
				goto IL_00d3;
				IL_00d3:
				if (@class.bool_0)
				{
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
	private struct Struct25 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<string> asyncTaskMethodBuilder_0;

		public Class175 class175_0;

		public string string_0;

		private HttpClient httpClient_0;

		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		private TaskAwaiter<string> taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			Class175 @class = class175_0;
			string result;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_003c;
				}
				string text = @class.gclass5_0.method_8();
				if (!text.Equals(string.Empty))
				{
					httpClient_0 = new HttpClient();
					goto IL_003c;
				}
				result = Class84.smethod_0(-994099245);
				goto end_IL_000f;
				IL_003c:
				try
				{
					TaskAwaiter<string> awaiter;
					TaskAwaiter<HttpResponseMessage> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = taskAwaiter_1;
							taskAwaiter_1 = default;
							num = -1;
							int_0 = -1;
							goto IL_015c;
						}
						HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, Class348.Class353.string_3)
						{
							Content = new StringContent(string_0, Encoding.UTF8, Class84.smethod_0(-994210170))
						};
						httpRequestMessage.Headers.Add(Class84.smethod_0(-994099204), Class84.smethod_0(-994099232) + text);
						awaiter2 = httpClient_0.SendAsync(httpRequestMessage).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter2;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = taskAwaiter_0;
						taskAwaiter_0 = default;
						num = -1;
						int_0 = -1;
					}
					awaiter = awaiter2.GetResult().Content.ReadAsStringAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 1;
						int_0 = 1;
						taskAwaiter_1 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_015c;
					IL_015c:
					result = awaiter.GetResult();
				}
				finally
				{
					if (num < 0 && httpClient_0 != null)
					{
						((IDisposable)httpClient_0).Dispose();
					}
				}
				end_IL_000f:;
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

	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private readonly Class306 class306_0;

	private bool bool_0;

	private CancellationTokenSource cancellationTokenSource_0;

	private readonly object object_0 = new object();

	private ulong ulong_0;

	private CancellationTokenSource cancellationTokenSource_1;

	private readonly List<Tuple<long, int>> list_0 = new List<Tuple<long, int>>();

	private bool bool_1;

	public Class175(GForm17 gform17_1, Class306 class306_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gform17_1.method_0();
		class306_0 = class306_1;
	}

	private void method_0()
	{
		lock (object_0)
		{
			ulong_0++;
		}
	}

	private void method_1()
	{
		ulong_0 = 0uL;
	}

	public ulong method_2()
	{
		lock (object_0)
		{
			return ulong_0;
		}
	}

	private void method_3(long long_0, int int_0)
	{
		lock (list_0)
		{
			list_0.Add(new Tuple<long, int>(long_0, int_0));
		}
	}

	private int method_4()
	{
		lock (list_0)
		{
			return list_0.Count;
		}
	}

	private Tuple<long, int> method_5()
	{
		lock (list_0)
		{
			if (list_0.Count == 0)
			{
				return null;
			}
			Tuple<long, int> result = list_0[0];
			list_0.RemoveAt(0);
			return result;
		}
	}

	public void method_6()
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			bool_0 = true;
			cancellationTokenSource_0 = new CancellationTokenSource();
			Task.Run((Action)method_14);
			cancellationTokenSource_1 = new CancellationTokenSource();
			Task.Run((Action)method_15);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			gclass5_0.method_5(GEnum0.Error, string.Empty, Class84.smethod_0(-994103266), Class84.smethod_0(-994103262));
			gclass5_0.method_5(GEnum0.Error, string.Empty, Class84.smethod_0(-994103266), Class84.smethod_0(-994258388) + ex.Message);
		}
	}

	public void method_7()
	{
		if (!bool_0)
		{
			return;
		}
		try
		{
			bool_0 = false;
			cancellationTokenSource_0.Cancel();
			cancellationTokenSource_1.Cancel();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private async void method_8()
	{
		while (bool_0)
		{
			try
			{
				if (Class348.Class349.bool_0 && !bool_1)
				{
					method_9();
				}
				await Task.Delay(180000, cancellationTokenSource_1.Token);
			}
			catch (TaskCanceledException)
			{
			}
			catch (Exception ex2)
			{
				Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
			}
		}
	}

	private void method_9()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			bool_1 = true;
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string text = Class84.smethod_0(-994103175);
			string text2 = Class84.smethod_0(-994103146);
			int num = method_4();
			int num2 = 0;
			while (true)
			{
				if (num2 < num)
				{
					Tuple<long, int> tuple = method_5();
					if (tuple != null)
					{
						long item = tuple.Item1;
						int item2 = tuple.Item2;
						mySqlCommand.CommandText = string.Format((item2 == 1) ? text : text2, item);
						mySqlCommand.ExecuteNonQuery();
						num2++;
						continue;
					}
					break;
				}
				mySqlCommand.CommandText = Class84.smethod_0(-994103090);
				mySqlCommand.ExecuteNonQuery();
				break;
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			bool_1 = false;
			mySqlConnection.Close();
		}
	}

	private async void method_10()
	{
		method_1();
		while (bool_0)
		{
			try
			{
				if (Class348.Class349.bool_0)
				{
					Class345 @class = class306_0.method_1();
					if (@class != null)
					{
						await method_12(@class);
					}
				}
				await Task.Delay(Class224.Class226.int_11, cancellationTokenSource_0.Token);
			}
			catch (TaskCanceledException)
			{
			}
			catch (Exception ex2)
			{
				Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
			}
		}
	}

	private async Task<string> method_11(string string_0)
	{
		string text = gclass5_0.method_8();
		if (!text.Equals(string.Empty))
		{
			using (HttpClient httpClient = new HttpClient())
			{
				HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, Class348.Class353.string_3)
				{
					Content = new StringContent(string_0, Encoding.UTF8, Class84.smethod_0(-994210170))
				};
				httpRequestMessage.Headers.Add(Class84.smethod_0(-994099204), Class84.smethod_0(-994099232) + text);
				return await (await httpClient.SendAsync(httpRequestMessage)).Content.ReadAsStringAsync();
			}
		}
		return Class84.smethod_0(-994099245);
	}

	private async Task<bool> method_12(Class345 class345_0)
	{
		try
		{
			if (class345_0.string_0.Length > 0)
			{
				string string_ = FcmMessage.PrepareMessageTopic(class345_0.string_0, Class348.Class352.string_2 + Class84.smethod_0(-994273716) + class345_0.string_1, class345_0.string_2);
				await method_11(string_);
				method_0();
				method_3(class345_0.long_0, 1);
			}
			else
			{
				int num = 0;
				foreach (string item in class345_0.list_0)
				{
					num++;
					string string_2 = FcmMessage.PrepareMessageToken(item, Class348.Class352.string_2 + Class84.smethod_0(-994273716) + class345_0.string_1, class345_0.string_2);
					await method_11(string_2);
					await Task.Delay(750);
					method_0();
				}
				method_3(class345_0.long_0, 1);
			}
			return true;
		}
		catch (Exception ex)
		{
			method_3(class345_0.long_0, 0);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			gclass5_0.method_5(GEnum0.Error, string.Empty, Class84.smethod_0(-994103266), Class84.smethod_0(-994103283) + ex.Message);
			return false;
		}
	}

	private void method_13(int int_0)
	{
	}

	private void method_14()
	{
		method_10();
	}

	private void method_15()
	{
		method_8();
	}
}
