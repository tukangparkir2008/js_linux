using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

internal sealed class Class323
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct35 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public Class323 class323_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class323 @class = class323_0;
			try
			{
				if (num == 0)
				{
					goto IL_0015;
				}
				goto IL_00de;
				IL_0015:
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						if (Class348.Class349.bool_0)
						{
							Class150 class2 = @class.class219_0.method_1();
							if (class2 != null)
							{
								@class.method_9(class2);
							}
						}
						awaiter = Task.Delay(Class224.Class226.int_12, @class.cancellationTokenSource_0.Token).GetAwaiter();
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
					Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
				}
				goto IL_00de;
				IL_00de:
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
	private struct Struct36 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public Class323 class323_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class323 @class = class323_0;
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
							@class.method_7();
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

	private readonly GForm17 gform17_0;

	private readonly GClass5 gclass5_0;

	private readonly Class219 class219_0;

	private bool bool_0;

	private CancellationTokenSource cancellationTokenSource_0;

	private CancellationTokenSource cancellationTokenSource_1;

	private readonly List<Tuple<string, int>> list_0 = new List<Tuple<string, int>>();

	private bool bool_1;

	private static CookieContainer cookieContainer_0;

	public Class323(GForm17 gform17_1, Class219 class219_1)
	{
		gform17_0 = gform17_1;
		gclass5_0 = gform17_1.method_0();
		class219_0 = class219_1;
	}

	public static CookieContainer smethod_0()
	{
		if (cookieContainer_0 == null)
		{
			cookieContainer_0 = new CookieContainer();
		}
		return cookieContainer_0;
	}

	private void method_0(string string_0, int int_0)
	{
		lock (list_0)
		{
			list_0.Add(new Tuple<string, int>(string_0, int_0));
		}
	}

	private int method_1()
	{
		lock (list_0)
		{
			return list_0.Count;
		}
	}

	private Tuple<string, int> method_2()
	{
		lock (list_0)
		{
			if (list_0.Count == 0)
			{
				return null;
			}
			Tuple<string, int> result = list_0[0];
			list_0.RemoveAt(0);
			return result;
		}
	}

	private GClass70 method_3()
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class248
			{
				Op = Class84.smethod_0(-994265364)
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 result;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_13(), Class84.smethod_0(-994265316), data);
				result = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			return result;
		}
		catch (Exception ex)
		{
			return new GClass70(-99, ex.Message, ex);
		}
	}

	public void method_4()
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			bool_0 = true;
			cancellationTokenSource_0 = new CancellationTokenSource();
			Task.Run((Action)method_10);
			cancellationTokenSource_1 = new CancellationTokenSource();
			Task.Run((Action)method_11);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_5()
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

	private async void method_6()
	{
		while (bool_0)
		{
			try
			{
				if (Class348.Class349.bool_0 && !bool_1)
				{
					method_7();
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

	private void method_7()
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
			string text = Class84.smethod_0(-994102980);
			string text2 = Class84.smethod_0(-994102973);
			int num = method_1();
			int num2 = 0;
			while (true)
			{
				if (num2 < num)
				{
					Tuple<string, int> tuple = method_2();
					if (tuple != null)
					{
						string item = tuple.Item1;
						int item2 = tuple.Item2;
						mySqlCommand.CommandText = string.Format((item2 == 1) ? text : text2, item);
						mySqlCommand.ExecuteNonQuery();
						num2++;
						continue;
					}
					break;
				}
				mySqlCommand.CommandText = Class84.smethod_0(-994102859);
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

	public async void method_8()
	{
		while (bool_0)
		{
			try
			{
				if (Class348.Class349.bool_0)
				{
					Class150 @class = class219_0.method_1();
					if (@class != null)
					{
						method_9(@class);
					}
				}
				await Task.Delay(Class224.Class226.int_12, cancellationTokenSource_0.Token);
			}
			catch (TaskCanceledException)
			{
			}
			catch (Exception ex2)
			{
				Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
			}
		}
	}

	private void method_9(Class150 class150_0)
	{
		string string_ = class150_0.string_0;
		string string_2 = class150_0.string_1;
		try
		{
			GClass70 gClass = method_3();
			if (gClass.Value == 1)
			{
				string transactionId = gClass.Data.ToString();
				var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class248
				{
					SchoolId = Class348.Class352.string_0,
					Op = Class84.smethod_0(-994270626),
					TransactionId = transactionId,
					JsonSyncNotifMessage = string_2
				}), Class320.int_5, 10000);
				NameValueCollection data = new NameValueCollection { { name, value } };
				Class139 @class = new Class139(smethod_0());
				try
				{
					@class.UploadValues(Class272.smethod_13(), Class84.smethod_0(-994265316), data);
				}
				finally
				{
					((IDisposable)@class).Dispose();
				}
				method_0(string_, 1);
			}
		}
		catch (Exception ex)
		{
			method_0(string_, 0);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_10()
	{
		method_8();
	}

	private void method_11()
	{
		method_6();
	}
}
