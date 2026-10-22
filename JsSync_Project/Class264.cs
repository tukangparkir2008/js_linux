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

internal sealed class Class264
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct27 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public Class264 class264_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class264 @class = class264_0;
			try
			{
				if (num == 0 || !@class.bool_0)
				{
					try
					{
						if (num == 0)
						{
							goto IL_002c;
						}
						@class.bool_0 = true;
						goto IL_009e;
						IL_002c:
						try
						{
							TaskAwaiter awaiter;
							if (num != 0)
							{
								awaiter = Task.Delay(Class224.Class226.int_2, @class.cancellationTokenSource_0.Token).GetAwaiter();
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
						catch (Exception)
						{
						}
						if (@class.bool_0)
						{
							goto IL_009e;
						}
						goto end_IL_001f;
						IL_009e:
						@class.method_4(null, bool_2: false);
						goto IL_002c;
						end_IL_001f:;
					}
					catch (Exception ex2)
					{
						Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
					}
					finally
					{
						if (num < 0)
						{
							@class.bool_0 = false;
						}
					}
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
	private struct Struct28 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public Class264 class264_0;

		public GDelegate9 gdelegate9_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class264 @class = class264_0;
			try
			{
				if (num == 0 || !Class348.Class354.bool_1)
				{
					try
					{
						if (num == 0)
						{
							goto IL_007e;
						}
						if (@class.method_10() && @class.method_9() != 0)
						{
							Class348.Class354.bool_1 = true;
							GClass70 gClass = @class.method_8();
							if (gClass.Value != 1)
							{
								Class125.smethod_1(Class84.smethod_0(-994102672), gClass.Text, null);
								goto IL_00f0;
							}
							@class.method_5(gClass.Data.ToString());
							goto IL_007e;
						}
						goto end_IL_001e;
						IL_007e:
						try
						{
							TaskAwaiter awaiter;
							if (num != 0)
							{
								awaiter = Task.Delay(1000, @class.cancellationTokenSource_0.Token).GetAwaiter();
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
						catch (Exception)
						{
						}
						goto IL_00f0;
						IL_00f0:
						Class348.Class354.bool_1 = false;
						end_IL_001e:;
					}
					catch (Exception ex2)
					{
						Class348.Class354.bool_1 = false;
						gdelegate9_0?.Invoke();
						Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
					}
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

	private CancellationTokenSource cancellationTokenSource_0;

	private string string_0;

	private bool bool_0;

	private bool bool_1;

	private string string_1;

	private static CookieContainer cookieContainer_0;

	public Class264(GClass4 gclass4_1)
	{
		gclass4_0 = gclass4_1;
	}

	public static CookieContainer smethod_0()
	{
		if (cookieContainer_0 == null)
		{
			cookieContainer_0 = new CookieContainer();
		}
		return cookieContainer_0;
	}

	public void method_0()
	{
		if (bool_0)
		{
			return;
		}
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

	private async void method_2()
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			bool_0 = true;
			do
			{
				method_4(null, bool_2: false);
				try
				{
					await Task.Delay(Class224.Class226.int_2, cancellationTokenSource_0.Token);
				}
				catch (Exception)
				{
				}
			}
			while (bool_0);
		}
		catch (Exception ex2)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
		}
		finally
		{
			bool_0 = false;
		}
	}

	public void method_3(GDelegate9 gdelegate9_0, bool bool_2)
	{
		cancellationTokenSource_0 = new CancellationTokenSource();
		method_4(gdelegate9_0, bool_2);
	}

	private async void method_4(GDelegate9 gdelegate9_0, bool bool_2)
	{
		if (Class348.Class354.bool_1)
		{
			return;
		}
		try
		{
			if (!method_10() || method_9() == 0)
			{
				return;
			}
			Class348.Class354.bool_1 = true;
			GClass70 gClass = method_8();
			if (gClass.Value != 1)
			{
				Class125.smethod_1(Class84.smethod_0(-994102672), gClass.Text, null);
			}
			else
			{
				method_5(gClass.Data.ToString());
				try
				{
					await Task.Delay(1000, cancellationTokenSource_0.Token);
				}
				catch (Exception)
				{
				}
			}
			Class348.Class354.bool_1 = false;
		}
		catch (Exception ex2)
		{
			Class348.Class354.bool_1 = false;
			gdelegate9_0?.Invoke();
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
		}
	}

	public void method_5(string string_2)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			List<List<string>> list = JsonConvert.DeserializeObject<List<List<string>>>(string_2);
			if (list.Count == 0)
			{
				return;
			}
			gclass4_0.method_5(GEnum0.Info, string.Empty, Class84.smethod_0(-994242818), string.Format(Class84.smethod_0(-994102626), list.Count));
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string format = Class84.smethod_0(-994102562);
			string text = string.Empty;
			List<List<string>> list2 = new List<List<string>>();
			for (int i = 0; i < list.Count; i++)
			{
				List<string> list3 = list[i];
				string text2 = list3[0];
				string text3 = list3[1];
				string item = list3[2];
				string text4 = list3[3];
				int num = Convert.ToInt32(text4);
				string text5 = list3[4];
				string item2 = list3[5];
				string item3 = Class282.smethod_8(item2);
				Class260 class260_ = Class260.smethod_0(item3);
				if (!text.Equals(string.Empty))
				{
					text += Class84.smethod_0(-994279022);
				}
				text += text2;
				bool flag = false;
				mySqlCommand.CommandText = string.Format(format, text3);
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					string item4 = mySqlDataReader[Class84.smethod_0(-994102451)].ToString();
					list2.Add(new List<string>
					{
						Class84.smethod_0(-994102416),
						Class84.smethod_0(-994102418),
						text3,
						item,
						text4,
						text5,
						Class84.smethod_0(-994247224),
						item2,
						item4,
						item3
					});
					flag = true;
				}
				mySqlDataReader.Close();
				if (!flag)
				{
					GClass70 gClass = new GClass70(0, string.Empty);
					switch (num)
					{
					case 153:
						gClass = Class173.smethod_1(gclass4_0, string.Empty, class260_);
						break;
					case 163:
						gClass = Class173.smethod_2(gclass4_0, string.Empty, class260_);
						break;
					case 157:
						gClass = Class173.smethod_14(gclass4_0, string.Empty, class260_);
						break;
					case 159:
						gClass = Class173.smethod_10(gclass4_0, string.Empty, class260_);
						break;
					case 162:
						gClass = Class173.smethod_3(gclass4_0, string.Empty, class260_);
						break;
					}
					if (gClass.Value < 0)
					{
						list2.Add(new List<string>
						{
							Class84.smethod_0(-994102374),
							Class84.smethod_0(-994102374),
							text3,
							item,
							text4,
							text5,
							gClass.Text,
							item2,
							string.Empty,
							item3
						});
						gclass4_0.method_5(GEnum0.Warn, string.Empty, Class84.smethod_0(-994242818), Class84.smethod_0(-994102379) + text5 + Class84.smethod_0(-994102343));
					}
					else
					{
						string item5 = Class282.smethod_9(gClass.Data.ToString());
						list2.Add(new List<string>
						{
							Class84.smethod_0(-994102416),
							Class84.smethod_0(-994102346),
							text3,
							item,
							text4,
							text5,
							Class84.smethod_0(-994247224),
							item2,
							item5,
							item3
						});
						gclass4_0.method_5(GEnum0.Info, string.Empty, Class84.smethod_0(-994242818), Class84.smethod_0(-994102379) + text5 + Class84.smethod_0(-994102368));
					}
				}
			}
			method_6(mySqlCommand, list2);
			method_7(mySqlCommand, text);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_6(MySqlCommand mySqlCommand_0, List<List<string>> list_0)
	{
		try
		{
			string format = Class84.smethod_0(-994102320);
			for (int i = 0; i < list_0.Count; i++)
			{
				List<string> list = list_0[i];
				string text = list[5].Replace('\'', '`').Trim();
				string text2 = list[6].Replace('\'', '`').Trim();
				if (list[0] == Class84.smethod_0(-994102416))
				{
					if (list[1] == Class84.smethod_0(-994102346))
					{
						mySqlCommand_0.CommandText = string.Format(format, 1, list[2], list[3], list[4], text, text2, list[7], list[8]);
						mySqlCommand_0.ExecuteNonQuery();
					}
				}
				else
				{
					mySqlCommand_0.CommandText = string.Format(format, -1, list[2], list[3], list[4], text, text2, list[7], list[8]);
					mySqlCommand_0.ExecuteNonQuery();
				}
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_7(MySqlCommand mySqlCommand_0, string string_2)
	{
		try
		{
			string commandText = Class84.smethod_0(-994102099) + string_2 + Class84.smethod_0(-994123101);
			mySqlCommand_0.CommandText = commandText;
			if (Convert.ToInt32(mySqlCommand_0.ExecuteScalar()) == 0)
			{
				commandText = Class84.smethod_0(-994101978) + string_2 + Class84.smethod_0(-994101884) + string_2 + Class84.smethod_0(-994101843);
				mySqlCommand_0.CommandText = commandText;
				mySqlCommand_0.ExecuteNonQuery();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private GClass70 method_8()
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new GClass58
			{
				Op = Class84.smethod_0(-994101803),
				SchoolId = Class348.Class352.string_0
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_15(), Class84.smethod_0(-994265316), data);
				return GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, string.Empty);
		}
	}

	private int method_9()
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new GClass58
			{
				Op = Class84.smethod_0(-994101764),
				SchoolId = Class348.Class352.string_0
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_15(), Class84.smethod_0(-994265316), data);
				return Class159.smethod_0(GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString()).Data.ToString(), 0);
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return 0;
		}
	}

	private bool method_10()
	{
		try
		{
			GClass70 gClass = Class194.smethod_0();
			if (gClass.Value < 0)
			{
				gclass4_0.method_6(GEnum0.Error, string.Empty, Class84.smethod_0(-994108820) + gClass.Text);
				return false;
			}
			GClass70 gClass2 = smethod_1();
			if (gClass2.Value < 0)
			{
				gclass4_0.method_6(GEnum0.Error, string.Empty, Class84.smethod_0(-994108820) + gClass2.Text);
				return false;
			}
			string_0 = gClass2.Data.ToString();
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new GClass58
			{
				Op = Class84.smethod_0(-994108788),
				TransactionId = string_0,
				SchoolId = Class348.Class352.string_0
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 gClass3;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_15(), Class84.smethod_0(-994265316), data);
				gClass3 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			if (gClass3.Value < 0)
			{
				bool_1 = false;
				string_1 = gClass3.Text;
				return false;
			}
			bool_1 = true;
			string_1 = string.Empty;
			return true;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return false;
		}
	}

	private static GClass70 smethod_1()
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new GClass58
			{
				Op = Class84.smethod_0(-994111135)
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 result;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_15(), Class84.smethod_0(-994265316), data);
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

	public GClass70 method_11(GClass58 gclass58_0)
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(gclass58_0), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_15(), Class84.smethod_0(-994265316), data);
				return GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
	}
}
