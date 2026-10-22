using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

internal sealed class Class157
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct15 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public Class157 class157_0;

		private MySqlConnection mySqlConnection_0;

		private object object_0;

		private int int_1;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class157 @class = class157_0;
			try
			{
				if (num == 0)
				{
					goto IL_003c;
				}
				if (num != 1)
				{
					goto IL_0150;
				}
				TaskAwaiter awaiter = taskAwaiter_0;
				taskAwaiter_0 = default;
				num = -1;
				int_0 = -1;
				goto IL_011e;
				IL_011e:
				awaiter.GetResult();
				object obj = object_0;
				if (obj != null)
				{
					ExceptionDispatchInfo.Capture((obj as Exception) ?? throw obj).Throw();
				}
				object_0 = null;
				mySqlConnection_0 = null;
				goto IL_0150;
				IL_003c:
				try
				{
					try
					{
						if (num != 0)
						{
							if (Class348.Class349.bool_0)
							{
								mySqlConnection_0.Open();
								@class.method_5(mySqlConnection_0);
								@class.method_4(mySqlConnection_0);
							}
							awaiter = Task.Delay(Class224.Class226.int_10, @class.cancellationTokenSource_0.Token).GetAwaiter();
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
				}
				catch (object obj2)
				{
					object_0 = obj2;
				}
				awaiter = mySqlConnection_0.CloseAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 1;
					int_0 = 1;
					taskAwaiter_0 = awaiter;
					asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_011e;
				IL_0150:
				if (@class.bool_0)
				{
					mySqlConnection_0 = new MySqlConnection(Class224.Class228.smethod_0());
					object_0 = null;
					int_1 = 0;
					goto IL_003c;
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

	private readonly GClass4 gclass4_0;

	private readonly Class306 class306_0;

	private readonly Class219 class219_0;

	private bool bool_0;

	private CancellationTokenSource cancellationTokenSource_0;

	public Class157(GClass4 gclass4_1, Class306 class306_1, Class219 class219_1)
	{
		gclass4_0 = gclass4_1;
		class306_0 = class306_1;
		class219_0 = class219_1;
	}

	public void method_0()
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			bool_0 = true;
			cancellationTokenSource_0 = new CancellationTokenSource();
			Task.Run((Action)method_6);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
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

	private async void method_2()
	{
		while (bool_0)
		{
			MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
			object obj = null;
			try
			{
				try
				{
					if (Class348.Class349.bool_0)
					{
						mySqlConnection.Open();
						method_5(mySqlConnection);
						method_4(mySqlConnection);
					}
					await Task.Delay(Class224.Class226.int_10, cancellationTokenSource_0.Token);
				}
				catch (TaskCanceledException)
				{
				}
				catch (Exception ex2)
				{
					Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
				}
			}
			catch (object obj2)
			{
				obj = obj2;
			}
			await mySqlConnection.CloseAsync();
			object obj3 = obj;
			if (obj3 != null)
			{
				ExceptionDispatchInfo.Capture((obj3 as Exception) ?? throw obj3).Throw();
			}
		}
	}

	private bool method_3(string string_0, ref List<string> list_0)
	{
		try
		{
			list_0 = JsonConvert.DeserializeObject<List<string>>(string_0);
			return true;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, string_0 + Class84.smethod_0(-994288861) + ex.Message, ex);
			return false;
		}
	}

	private void method_4(MySqlConnection mySqlConnection_0)
	{
		try
		{
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection_0
			};
			string commandText = Class84.smethod_0(-994100602);
			mySqlCommand.CommandText = commandText;
			List<List<string>> list = new List<List<string>>();
			string text = string.Empty;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				long num = Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994264162)]);
				if (text != string.Empty)
				{
					text += Class84.smethod_0(-994279022);
				}
				text += num;
				string item = mySqlDataReader[Class84.smethod_0(-994100258)].ToString();
				string item2 = mySqlDataReader[Class84.smethod_0(-994310877)].ToString();
				List<string> item3 = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994277136)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994266832)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994270443)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994311267)].ToString(),
					item,
					item2,
					mySqlDataReader[Class84.smethod_0(-994310861)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994310831)].ToString()
				};
				list.Add(item3);
			}
			mySqlDataReader.Close();
			if (!(text == string.Empty))
			{
				class219_0.method_0(text, JsonConvert.SerializeObject(list));
				commandText = Class84.smethod_0(-994100278);
				mySqlCommand.CommandText = string.Format(commandText, text);
				mySqlCommand.ExecuteNonQuery();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_5(MySqlConnection mySqlConnection_0)
	{
		try
		{
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection_0
			};
			string commandText = Class84.smethod_0(-994100210);
			mySqlCommand.CommandText = commandText;
			string text = string.Empty;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				long long_ = Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994264162)]);
				string string_ = mySqlDataReader[Class84.smethod_0(-994311267)].ToString();
				string text2 = mySqlDataReader[Class84.smethod_0(-994100064)].ToString();
				string string_2 = mySqlDataReader[Class84.smethod_0(-994100016)].ToString();
				string string_3 = mySqlDataReader[Class84.smethod_0(-994100017)].ToString();
				List<string> list_ = new List<string>();
				if (text2.Trim().Length > 0 && !method_3(text2, ref list_))
				{
					if (text != string.Empty)
					{
						text += Class84.smethod_0(-994279022);
					}
					text += long_;
					continue;
				}
				Class345 class345_ = new Class345
				{
					long_0 = long_,
					string_0 = string_,
					list_0 = list_,
					string_1 = string_2,
					string_2 = string_3
				};
				class306_0.method_0(class345_);
				if (text != string.Empty)
				{
					text += Class84.smethod_0(-994279022);
				}
				text += long_;
			}
			mySqlDataReader.Close();
			if (!(text == string.Empty))
			{
				commandText = Class84.smethod_0(-994099971);
				mySqlCommand.CommandText = string.Format(commandText, text);
				mySqlCommand.ExecuteNonQuery();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_6()
	{
		method_2();
	}
}
