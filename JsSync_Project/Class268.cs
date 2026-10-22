using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
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

internal sealed class Class268
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct30 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		public GDelegate9 gdelegate9_0;

		public Class268 class268_0;

		public bool bool_0;

		private MySqlConnection mySqlConnection_0;

		private MySqlCommand mySqlCommand_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class268 @class = class268_0;
			try
			{
				if (num == 0)
				{
					goto IL_003f;
				}
				if (!Class348.Class354.bool_0)
				{
					mySqlConnection_0 = new MySqlConnection(Class224.Class228.smethod_0());
					goto IL_003f;
				}
				gdelegate9_0?.Invoke();
				goto end_IL_000e;
				IL_003f:
				try
				{
					if (num == 0)
					{
						goto IL_00b9;
					}
					Class348.Class354.bool_0 = true;
					if (@class.method_8())
					{
						bool_1 = false;
						mySqlConnection_0.Open();
						mySqlCommand_0 = new MySqlCommand
						{
							Connection = mySqlConnection_0
						};
						goto IL_0184;
					}
					Class348.Class354.bool_0 = false;
					gdelegate9_0?.Invoke();
					if (!@class.bool_2)
					{
						@class.gclass4_0.method_6(GEnum0.Warn, string.Empty, @class.string_3);
					}
					goto end_IL_003f;
					IL_0184:
					if (@class.method_5(mySqlCommand_0))
					{
						@class.method_4(mySqlCommand_0);
					}
					List<List<string>> list = @class.method_7(mySqlCommand_0);
					if (list.Count != 0)
					{
						if (@class.method_9(mySqlCommand_0, list))
						{
							if (bool_3)
							{
								@class.method_6();
							}
							if (bool_1)
							{
								@class.method_10();
								bool_1 = false;
							}
							goto IL_00b9;
						}
						Class348.Class354.bool_0 = false;
						gdelegate9_0?.Invoke();
					}
					else
					{
						if (bool_0)
						{
							@class.gclass4_0.method_6(GEnum0.Info, string.Empty, Class84.smethod_0(-994054185));
						}
						Class348.Class354.bool_0 = false;
						gdelegate9_0?.Invoke();
					}
					if (bool_1)
					{
						@class.method_10();
						bool_1 = false;
					}
					mySqlCommand_0 = null;
					goto end_IL_003f;
					IL_00b9:
					try
					{
						TaskAwaiter awaiter;
						if (num != 0)
						{
							awaiter = Task.Delay(Class224.Class226.int_1, @class.cancellationTokenSource_0.Token).GetAwaiter();
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
					goto IL_0184;
					end_IL_003f:;
				}
				catch (Exception ex2)
				{
					Class348.Class354.bool_0 = false;
					gdelegate9_0?.Invoke();
					Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
				}
				finally
				{
					if (num < 0)
					{
						mySqlConnection_0.Close();
					}
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				int_0 = -2;
				mySqlConnection_0 = null;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			mySqlConnection_0 = null;
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
	private struct Struct31 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public Class268 class268_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			Class268 @class = class268_0;
			try
			{
				if (num == 0)
				{
					goto IL_0026;
				}
				if (num == 1)
				{
					goto IL_00b3;
				}
				if (!@class.bool_0)
				{
					goto IL_0026;
				}
				goto end_IL_000e;
				IL_00b3:
				try
				{
					TaskAwaiter awaiter;
					if (num != 1)
					{
						awaiter = Task.Delay(Class224.Class226.int_0, @class.cancellationTokenSource_0.Token).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 1;
							int_0 = 1;
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
					@class.method_3(null, bool_4: false);
				}
				goto IL_00a7;
				IL_00a7:
				if (@class.bool_0)
				{
					goto IL_00b3;
				}
				goto end_IL_000e;
				IL_0026:
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						awaiter = Task.Delay(3000, @class.cancellationTokenSource_0.Token).GetAwaiter();
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
				@class.method_3(null, bool_4: false);
				@class.bool_0 = true;
				goto IL_00a7;
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

	private CancellationTokenSource cancellationTokenSource_0;

	private static readonly string string_0 = GClass18.smethod_18(Class309.smethod_44());

	private string string_1;

	private bool bool_0;

	private static bool bool_1 = false;

	private static string string_2 = string.Empty;

	private bool bool_2;

	private string string_3;

	private static CookieContainer cookieContainer_0;

	private static bool bool_3;

	public Class268(GClass4 gclass4_1)
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
		try
		{
			cancellationTokenSource_0 = new CancellationTokenSource();
			method_1();
			gclass4_0.method_6(GEnum0.Info, string.Empty, Class84.smethod_0(-994054169));
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private async Task method_1()
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			await Task.Delay(3000, cancellationTokenSource_0.Token);
		}
		catch (Exception)
		{
		}
		method_3(null, bool_4: false);
		bool_0 = true;
		while (bool_0)
		{
			try
			{
				await Task.Delay(Class224.Class226.int_0, cancellationTokenSource_0.Token);
			}
			catch (Exception)
			{
			}
			if (bool_0)
			{
				method_3(null, bool_4: false);
			}
		}
	}

	public void method_2(GDelegate9 gdelegate9_0, bool bool_4)
	{
		cancellationTokenSource_0 = new CancellationTokenSource();
		method_3(gdelegate9_0, bool_4);
	}

	private async void method_3(GDelegate9 gdelegate9_0, bool bool_4)
	{
		if (Class348.Class354.bool_0)
		{
			gdelegate9_0?.Invoke();
			return;
		}
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			Class348.Class354.bool_0 = true;
			if (!method_8())
			{
				Class348.Class354.bool_0 = false;
				gdelegate9_0?.Invoke();
				if (!bool_2)
				{
					gclass4_0.method_6(GEnum0.Warn, string.Empty, string_3);
				}
				return;
			}
			bool_1 = false;
			mySqlConnection.Open();
			MySqlCommand mySqlCommand_ = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			while (true)
			{
				if (method_5(mySqlCommand_))
				{
					method_4(mySqlCommand_);
				}
				List<List<string>> list = method_7(mySqlCommand_);
				if (list.Count != 0)
				{
					if (method_9(mySqlCommand_, list))
					{
						if (bool_3)
						{
							method_6();
						}
						if (bool_1)
						{
							method_10();
							bool_1 = false;
						}
						try
						{
							await Task.Delay(Class224.Class226.int_1, cancellationTokenSource_0.Token);
						}
						catch (Exception)
						{
						}
						continue;
					}
					Class348.Class354.bool_0 = false;
					gdelegate9_0?.Invoke();
					break;
				}
				if (bool_4)
				{
					gclass4_0.method_6(GEnum0.Info, string.Empty, Class84.smethod_0(-994054185));
				}
				Class348.Class354.bool_0 = false;
				gdelegate9_0?.Invoke();
				break;
			}
			if (bool_1)
			{
				method_10();
				bool_1 = false;
			}
		}
		catch (Exception ex2)
		{
			Class348.Class354.bool_0 = false;
			gdelegate9_0?.Invoke();
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private void method_4(MySqlCommand mySqlCommand_0)
	{
		string empty = string.Empty;
		empty = Class84.smethod_0(-994058199);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994058142);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994057982);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994057860);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994057698);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994057644);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994057474);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994057419);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994057263);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994057195);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994057029);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994056974);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994056802);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994056750);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994056552);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994056483);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994056379);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994056260);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994109375);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
		empty = Class84.smethod_0(-994109194);
		mySqlCommand_0.CommandText = empty;
		mySqlCommand_0.ExecuteNonQuery();
	}

	private bool method_5(MySqlCommand mySqlCommand_0)
	{
		mySqlCommand_0.CommandText = Class84.smethod_0(-994109042);
		return Convert.ToInt32(mySqlCommand_0.ExecuteScalar()) == 0;
	}

	private bool method_6()
	{
		try
		{
			gclass4_0.method_6(GEnum0.Info, string.Empty, Class84.smethod_0(-994108916));
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new GClass58
			{
				Op = Class84.smethod_0(-994305067),
				SchoolId = Class348.Class352.string_0
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 gClass;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_15(), Class84.smethod_0(-994265316), data);
				gClass = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			if (gClass.Value == 1)
			{
				List<List<string>> list = JsonConvert.DeserializeObject<List<List<string>>>(gClass.Data.ToString());
				for (int i = 0; i < list.Count; i++)
				{
					_ = list[i][0];
					_ = list[i][1];
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			gclass4_0.method_6(GEnum0.Error, string.Empty, Class84.smethod_0(-994108838));
			gclass4_0.method_6(GEnum0.Error, string.Empty, Class84.smethod_0(-994258388) + ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return false;
		}
	}

	private List<List<string>> method_7(MySqlCommand mySqlCommand_0)
	{
		bool_3 = false;
		List<List<string>> list = smethod_1(mySqlCommand_0, 1, 100);
		if (list.Count == 0)
		{
			list = smethod_1(mySqlCommand_0, 2, 10);
		}
		return list;
	}

	private bool method_8()
	{
		try
		{
			GClass70 gClass = Class194.smethod_0();
			if (gClass.Value < 0)
			{
				gclass4_0.method_6(GEnum0.Error, string.Empty, Class84.smethod_0(-994108820) + gClass.Text);
				return false;
			}
			GClass70 gClass2 = smethod_3();
			if (gClass2.Value < 0)
			{
				gclass4_0.method_6(GEnum0.Error, string.Empty, Class84.smethod_0(-994108820) + gClass2.Text);
				return false;
			}
			string_1 = gClass2.Data.ToString();
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new GClass58
			{
				Op = Class84.smethod_0(-994108788),
				TransactionId = string_1,
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
				bool_2 = false;
				string_3 = gClass3.Text;
				return false;
			}
			bool_2 = true;
			string_3 = string.Empty;
			return true;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return false;
		}
	}

	private bool method_9(MySqlCommand mySqlCommand_0, List<List<string>> list_0)
	{
		try
		{
			gclass4_0.method_6(GEnum0.Info, string.Empty, string.Format(Class84.smethod_0(-994108739), list_0.Count));
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new GClass58
			{
				Op = Class84.smethod_0(-994108714),
				TransactionId = string_1,
				Data = JsonConvert.SerializeObject(list_0)
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 gClass;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_15(), Class84.smethod_0(-994265316), data);
				gClass = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			if (gClass.Value == 1)
			{
				int num = 0;
				int num2 = 0;
				string text3 = string.Empty;
				List<List<string>> list = JsonConvert.DeserializeObject<List<List<string>>>(gClass.Data.ToString());
				for (int i = 0; i < list.Count; i++)
				{
					string text4 = list[i][0];
					string text5 = list[i][1];
					string text6 = list[i][2];
					text6 = text6.Replace('\'', '`').Trim();
					if (text5.Equals(Class84.smethod_0(-994248276)))
					{
						num++;
						if (!text3.Equals(string.Empty))
						{
							text3 += Class84.smethod_0(-994279022);
						}
						text3 += text4;
						continue;
					}
					num2++;
					if (text6.IndexOf(Class84.smethod_0(-994108734), StringComparison.Ordinal) >= 0)
					{
						string commandText = Class84.smethod_0(-994108675) + text4;
						mySqlCommand_0.CommandText = commandText;
						mySqlCommand_0.ExecuteNonQuery();
						gclass4_0.method_6(GEnum0.Error, string.Empty, Class84.smethod_0(-994108601) + text6);
					}
					else
					{
						string commandText = Class84.smethod_0(-994108572) + text6 + Class84.smethod_0(-994108450) + text4;
						mySqlCommand_0.CommandText = commandText;
						mySqlCommand_0.ExecuteNonQuery();
						gclass4_0.method_6(GEnum0.Error, string.Empty, Class84.smethod_0(-994108601) + text6);
					}
				}
				if (!text3.Equals(string.Empty))
				{
					string commandText = Class84.smethod_0(-994108365) + text3 + Class84.smethod_0(-994271866);
					mySqlCommand_0.CommandText = commandText;
					mySqlCommand_0.ExecuteNonQuery();
				}
				if (num2 == 0)
				{
					gclass4_0.method_6(GEnum0.Info, string.Empty, string.Format(Class84.smethod_0(-994108349), num));
				}
				else if (num == 0)
				{
					gclass4_0.method_6(GEnum0.Info, string.Empty, string.Format(Class84.smethod_0(-994108261), num2));
				}
				else
				{
					gclass4_0.method_6(GEnum0.Info, string.Empty, string.Format(Class84.smethod_0(-994108240), num, num2));
				}
				return true;
			}
			gclass4_0.method_6(GEnum0.Error, string.Empty, Class84.smethod_0(-994108221));
			gclass4_0.method_6(GEnum0.Error, string.Empty, gClass.Text);
			return false;
		}
		catch (Exception ex)
		{
			gclass4_0.method_6(GEnum0.Error, string.Empty, Class84.smethod_0(-994108152));
			gclass4_0.method_6(GEnum0.Error, string.Empty, Class84.smethod_0(-994258388) + ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return false;
		}
	}

	private static List<List<string>> smethod_1(MySqlCommand mySqlCommand_0, int int_0, int int_1)
	{
		List<List<string>> list = new List<List<string>>();
		try
		{
			string commandText = string.Format(Class84.smethod_0(-994108127), int_0, int_1);
			mySqlCommand_0.CommandText = commandText;
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand_0);
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			foreach (DataRow row in dataTable.Rows)
			{
				string text = row[Class84.smethod_0(-994264162)].ToString();
				string text2 = row[Class84.smethod_0(-994108060)].ToString();
				string string_ = row[Class84.smethod_0(-994175195)].ToString();
				string text3 = row[Class84.smethod_0(-994108012)].ToString();
				if (text3.IndexOf(Class84.smethod_0(-994284483), StringComparison.Ordinal) >= 0 && text3.IndexOf(Class84.smethod_0(-994284297), StringComparison.Ordinal) >= 0)
				{
					commandText = Class84.smethod_0(-994108032) + text;
					mySqlCommand_0.CommandText = commandText;
					mySqlCommand_0.ExecuteNonQuery();
					continue;
				}
				if (text3.IndexOf(Class84.smethod_0(-994107938), StringComparison.Ordinal) >= 0 && text3.IndexOf(Class84.smethod_0(-994284297), StringComparison.Ordinal) >= 0)
				{
					text3 = Class84.smethod_0(-994284297);
				}
				if (text3.IndexOf(Class84.smethod_0(-994284483), StringComparison.Ordinal) >= 0 && text3.IndexOf(Class84.smethod_0(-994107938), StringComparison.Ordinal) >= 0)
				{
					text3 = Class84.smethod_0(-994284483);
				}
				if (text3.IndexOf(Class84.smethod_0(-994107938), StringComparison.Ordinal) >= 0)
				{
					text3 = Class84.smethod_0(-994107938);
				}
				if (text3.Equals(Class84.smethod_0(-994107946)))
				{
					bool_1 = true;
					Class268.string_2 = row[Class84.smethod_0(-994107953)].ToString();
					commandText = Class84.smethod_0(-994108032) + text;
					mySqlCommand_0.CommandText = commandText;
					mySqlCommand_0.ExecuteNonQuery();
					continue;
				}
				List<string> list2 = new List<string>();
				string string_2 = Class84.smethod_0(-994107907) + Class348.Class352.string_0;
				if (text2.Equals(Class84.smethod_0(-994107927)))
				{
					list2 = smethod_8(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107886)))
				{
					list2 = smethod_10(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107844)))
				{
					list2 = smethod_11(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107870)))
				{
					list2 = smethod_12(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107831)))
				{
					list2 = smethod_14(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107779)))
				{
					list2 = smethod_13(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994257337)))
				{
					list2 = smethod_15(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994257301)))
				{
					list2 = smethod_16(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107804)))
				{
					list2 = smethod_18(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107768)))
				{
					list2 = smethod_17(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107724)))
				{
					list2 = smethod_19(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107683)))
				{
					list2 = smethod_20(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107705)))
				{
					list2 = smethod_21(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107673)))
				{
					list2 = smethod_22(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107641)))
				{
					list2 = smethod_23(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107613)))
				{
					list2 = smethod_9(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107574)))
				{
					list2 = smethod_7(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107535)))
				{
					list2 = smethod_6(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107492)))
				{
					list2 = smethod_5(mySqlCommand_0, string_2, string_, text3);
				}
				else if (text2.Equals(Class84.smethod_0(-994107462)))
				{
					list2 = smethod_2(mySqlCommand_0, string_2, string_, text3);
				}
				if (text2.Equals(Class84.smethod_0(-994107492)))
				{
					bool_3 = true;
				}
				if (list2.Count == 0)
				{
					continue;
				}
				foreach (string item2 in list2)
				{
					List<string> item = new List<string> { text, item2 };
					list.Add(item);
				}
			}
			return list;
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return list;
		}
	}

	private static List<string> smethod_2(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994107436) + string_5);
		}
		else
		{
			string string_7 = Class84.smethod_0(-994107408) + string_5;
			string text = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994111173) + text);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994111173) + text + Class84.smethod_0(-994111138) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994111173) + text + Class84.smethod_0(-994111167) + text);
			}
		}
		return list;
	}

	private static GClass70 smethod_3()
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

	private void method_10()
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new GClass58
			{
				Op = Class84.smethod_0(-994308490),
				SchoolId = Class348.Class352.string_0,
				TransactionId = string_1,
				Data = string_2
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_15(), Class84.smethod_0(-994265316), data);
				Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString();
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private static string smethod_4(MySqlCommand mySqlCommand_0, string string_4, string string_5)
	{
		string text = string.Empty;
		mySqlCommand_0.CommandText = string_4;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			for (int i = 0; i < mySqlDataReader.FieldCount; i++)
			{
				string name = mySqlDataReader.GetName(i);
				string empty = string.Empty;
				if (name.Equals(string_5))
				{
					if (!Convert.IsDBNull(mySqlDataReader[name]))
					{
						byte[] array = (byte[])mySqlDataReader[name];
						if (array.Length != 0)
						{
							string text2 = Convert.ToBase64String(array);
							if (text2.Length >= 65535)
							{
								text2 = string_0;
							}
							empty = text2;
						}
						else
						{
							empty = string_0;
						}
					}
					else
					{
						empty = string_0;
					}
				}
				else
				{
					empty = (Convert.IsDBNull(mySqlDataReader[i]) ? string.Empty : mySqlDataReader[i].ToString());
				}
				if (!text.Equals(string.Empty))
				{
					text += Class84.smethod_0(-994279022);
				}
				text = text + name + Class84.smethod_0(-994111086) + empty + Class84.smethod_0(-994271698);
			}
		}
		mySqlDataReader.Close();
		return text;
	}

	private static List<string> smethod_5(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994111093) + string_5);
		}
		else
		{
			string string_7 = Class84.smethod_0(-994111058) + string_5;
			string text = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994110937) + text);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994110937) + text + Class84.smethod_0(-994111138) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994110937) + text + Class84.smethod_0(-994111167) + text);
			}
		}
		return list;
	}

	private static List<string> smethod_6(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994110909) + string_5);
		}
		else
		{
			string string_7 = Class84.smethod_0(-994110873) + string_5;
			string text = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994110543) + text);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994110543) + text + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994110543) + text + Class84.smethod_0(-994111167) + text);
			}
		}
		return list;
	}

	private static List<string> smethod_7(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994110527) + string_5);
		}
		else
		{
			string string_7 = Class84.smethod_0(-994110495) + string_5;
			string text = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994110073) + text);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994110073) + text + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994110073) + text + Class84.smethod_0(-994111167) + text);
			}
		}
		return list;
	}

	private static List<string> smethod_8(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994110036) + string_5);
		}
		else
		{
			string string_7 = Class84.smethod_0(-994110002) + string_5;
			string text = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994109920) + text);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994109920) + text + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994109920) + text + Class84.smethod_0(-994111167) + text);
			}
		}
		return list;
	}

	private static List<string> smethod_9(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994109865) + string_5);
		}
		else
		{
			string text = Class348.Class352.string_0;
			string string_7 = Class84.smethod_0(-994109848) + text + Class84.smethod_0(-994109815) + string_5;
			string text2 = smethod_4(mySqlCommand_0, string_7, Class84.smethod_0(-994205227));
			if (text2.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994113516) + text2);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994113516) + text2 + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994113516) + text2 + Class84.smethod_0(-994111167) + text2);
			}
		}
		return list;
	}

	private static List<string> smethod_10(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994113478) + string_5);
		}
		else
		{
			string string_7 = Class84.smethod_0(-994113443) + string_5;
			string text = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994113261) + text);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994113261) + text + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994113261) + text + Class84.smethod_0(-994111167) + text);
			}
		}
		return list;
	}

	private static List<string> smethod_11(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994113221) + string_5);
		}
		else
		{
			string string_7 = Class84.smethod_0(-994113190) + string_5;
			string text = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994113007) + text);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994113007) + text + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994113007) + text + Class84.smethod_0(-994111167) + text);
			}
		}
		return list;
	}

	private static List<string> smethod_12(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994113019) + string_5);
		}
		else
		{
			string string_7 = Class84.smethod_0(-994112987) + string_5;
			string text = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994112795) + text);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994112795) + text + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994112795) + text + Class84.smethod_0(-994111167) + text);
			}
		}
		return list;
	}

	private static List<string> smethod_13(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994112758) + string_5);
		}
		else
		{
			string string_7 = Class84.smethod_0(-994112726) + string_5;
			string text = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994112536) + text);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994112536) + text + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994112536) + text + Class84.smethod_0(-994111167) + text);
			}
		}
		return list;
	}

	private static List<string> smethod_14(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994112483) + string_5);
		}
		else
		{
			string string_7 = Class84.smethod_0(-994112454) + string_5;
			string text = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994112359) + text);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994112359) + text + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994112359) + text + Class84.smethod_0(-994111167) + text);
			}
		}
		return list;
	}

	private static List<string> smethod_15(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994112373) + string_5);
		}
		else
		{
			string text = Class348.Class352.string_0;
			string string_7 = Class84.smethod_0(-994112344) + text + Class84.smethod_0(-994112298) + string_5;
			string text2 = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text2.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994111937) + text2);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994111937) + text2 + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994111937) + text2 + Class84.smethod_0(-994111167) + text2);
			}
		}
		return list;
	}

	private static List<string> smethod_16(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994111967) + string_5);
		}
		else
		{
			string text = Class348.Class352.string_0;
			string string_7 = Class84.smethod_0(-994112344) + text + Class84.smethod_0(-994111936) + string_5;
			string text2 = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text2.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994111645) + text2);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994111645) + text2 + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994111645) + text2 + Class84.smethod_0(-994111167) + text2);
			}
		}
		return list;
	}

	private static List<string> smethod_17(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994111593) + string_5);
		}
		else
		{
			string string_7 = Class84.smethod_0(-994111572) + string_5;
			string text = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994115441) + text);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994115441) + text + Class84.smethod_0(-994111138) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994115441) + text + Class84.smethod_0(-994111167) + text);
			}
		}
		return list;
	}

	private static List<string> smethod_18(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994115415) + string_5);
		}
		else
		{
			string string_7 = Class84.smethod_0(-994115370) + string_5;
			string text = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994115076) + text);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994115076) + text + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994115076) + text + Class84.smethod_0(-994111167) + text);
			}
		}
		return list;
	}

	private static List<string> smethod_19(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994115090) + string_5);
		}
		else
		{
			string string_7 = Class84.smethod_0(-994115072) + string_5;
			string text = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994114874) + text);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994114874) + text + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994114874) + text + Class84.smethod_0(-994111167) + text);
			}
		}
		return list;
	}

	private static List<string> smethod_20(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994114835) + string_5);
		}
		else
		{
			string string_7 = Class84.smethod_0(-994114816) + string_5;
			string text = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994114418) + text);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994114418) + text + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994114418) + text + Class84.smethod_0(-994111167) + text);
			}
		}
		return list;
	}

	private static List<string> smethod_21(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994114378) + string_5);
		}
		else
		{
			string text = Class348.Class352.string_0;
			string string_7 = Class84.smethod_0(-994114353) + text + Class84.smethod_0(-994114273) + string_5;
			string text2 = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text2.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994114036) + text2);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994114036) + text2 + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994114036) + text2 + Class84.smethod_0(-994111167) + text2);
			}
		}
		return list;
	}

	private static List<string> smethod_22(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994114006) + string_5);
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994113981) + string_5);
		}
		else
		{
			string text = Class348.Class352.string_0;
			string string_7 = Class84.smethod_0(-994114353) + text + Class84.smethod_0(-994113890) + string_5;
			string text2 = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text2.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994113582) + text2);
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994113552) + text2);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994113582) + text2 + Class84.smethod_0(-994110502) + string_5);
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994113552) + text2 + Class84.smethod_0(-994110502) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994113582) + text2 + Class84.smethod_0(-994111167) + text2);
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994113552) + text2 + Class84.smethod_0(-994111167) + text2);
			}
		}
		return list;
	}

	private static List<string> smethod_23(MySqlCommand mySqlCommand_0, string string_4, string string_5, string string_6)
	{
		List<string> list = new List<string>();
		if (string_6.Equals(Class84.smethod_0(-994284297)))
		{
			list.Add(Class84.smethod_0(-994107487) + string_4 + Class84.smethod_0(-994101232) + string_5);
		}
		else
		{
			string string_7 = Class84.smethod_0(-994101199) + string_5;
			string text = smethod_4(mySqlCommand_0, string_7, string.Empty);
			if (text.Equals(string.Empty))
			{
				return list;
			}
			if (string_6.Equals(Class84.smethod_0(-994284483)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994100740) + text);
			}
			else if (string_6.Equals(Class84.smethod_0(-994107938)))
			{
				list.Add(Class84.smethod_0(-994111200) + string_4 + Class84.smethod_0(-994100740) + text + Class84.smethod_0(-994111138) + string_5);
			}
			else if (string_6.Equals(Class84.smethod_0(-994284333)))
			{
				list.Add(Class84.smethod_0(-994111224) + string_4 + Class84.smethod_0(-994100740) + text + Class84.smethod_0(-994111167) + text);
			}
		}
		return list;
	}

	public void method_11()
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
}
