using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class GClass44 : IDisposable
{
	private readonly Guid guid_0;

	private readonly GClass53 gclass53_0;

	private Socket socket_0;

	private long long_0;

	private long long_1;

	private long long_2;

	private long long_3;

	private int int_0 = 8192;

	private int int_1 = 8192;

	private bool bool_0;

	private bool bool_1;

	private GClass28 gclass28_0;

	private SocketAsyncEventArgs socketAsyncEventArgs_0;

	private readonly object object_0 = new object();

	private bool bool_2;

	private GClass28 gclass28_1;

	private GClass28 gclass28_2;

	private SocketAsyncEventArgs socketAsyncEventArgs_1;

	private long long_4;

	private bool bool_3;

	private bool bool_4 = true;

	public GClass44(GClass53 gclass53_1)
	{
		guid_0 = Guid.NewGuid();
		gclass53_0 = gclass53_1;
		method_13(gclass53_1.method_16());
		method_15(gclass53_1.method_18());
	}

	public Guid method_0()
	{
		return guid_0;
	}

	public GClass53 method_1()
	{
		return gclass53_0;
	}

	public Socket method_2()
	{
		return socket_0;
	}

	private void method_3(Socket socket_1)
	{
		socket_0 = socket_1;
	}

	public long method_4()
	{
		return long_0;
	}

	private void method_5(long long_5)
	{
		long_0 = long_5;
	}

	public long method_6()
	{
		return long_1;
	}

	private void method_7(long long_5)
	{
		long_1 = long_5;
	}

	public long method_8()
	{
		return long_2;
	}

	private void method_9(long long_5)
	{
		long_2 = long_5;
	}

	public long method_10()
	{
		return long_3;
	}

	private void method_11(long long_5)
	{
		long_3 = long_5;
	}

	public int method_12()
	{
		return int_0;
	}

	public void method_13(int int_2)
	{
		int_0 = int_2;
	}

	public int method_14()
	{
		return int_1;
	}

	public void method_15(int int_2)
	{
		int_1 = int_2;
	}

	public bool method_16()
	{
		return bool_0;
	}

	private void method_17(bool bool_5)
	{
		bool_0 = bool_5;
	}

	internal void method_18(Socket socket_1)
	{
		method_3(socket_1);
		method_29(bool_5: false);
		gclass28_0 = new GClass28();
		gclass28_1 = new GClass28();
		gclass28_2 = new GClass28();
		socketAsyncEventArgs_0 = new SocketAsyncEventArgs();
		socketAsyncEventArgs_0.Completed += method_22;
		socketAsyncEventArgs_1 = new SocketAsyncEventArgs();
		socketAsyncEventArgs_1.Completed += method_22;
		if (method_1().method_8())
		{
			method_2().SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, optionValue: true);
		}
		if (method_1().method_10())
		{
			method_2().SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Debug, optionValue: true);
		}
		gclass28_0.method_8(method_12());
		gclass28_1.method_8(method_14());
		gclass28_2.method_8(method_14());
		method_5(0L);
		method_7(0L);
		method_9(0L);
		method_11(0L);
		vmethod_11();
		method_1().method_30(this);
		method_17(bool_5: true);
		method_19();
		if (!method_28())
		{
			vmethod_12();
			method_1().method_31(this);
			if (gclass28_1.method_0())
			{
				vmethod_17();
			}
		}
	}

	public virtual bool vmethod_0()
	{
		if (!method_16())
		{
			return false;
		}
		socketAsyncEventArgs_0.Completed -= method_22;
		socketAsyncEventArgs_1.Completed -= method_22;
		vmethod_13();
		method_1().method_32(this);
		try
		{
			try
			{
				method_2().Shutdown(SocketShutdown.Both);
			}
			catch (SocketException)
			{
			}
			method_2().Close();
			method_2().Dispose();
			socketAsyncEventArgs_0.Dispose();
			socketAsyncEventArgs_1.Dispose();
			method_29(bool_5: true);
		}
		catch (ObjectDisposedException)
		{
		}
		method_17(bool_5: false);
		bool_1 = false;
		bool_2 = false;
		method_21();
		vmethod_14();
		method_1().method_33(this);
		method_1().method_29(method_0());
		return true;
	}

	public virtual long vmethod_1(byte[] byte_0)
	{
		return vmethod_2(byte_0, 0L, byte_0.Length);
	}

	public virtual long vmethod_2(byte[] byte_0, long long_5, long long_6)
	{
		if (!method_16())
		{
			return 0L;
		}
		if (long_6 == 0L)
		{
			return 0L;
		}
		long num = method_2().Send(byte_0, (int)long_5, (int)long_6, SocketFlags.None, out var errorCode);
		if (num > 0L)
		{
			method_9(method_8() + num);
			vmethod_16(num, method_4() + method_6());
		}
		if (errorCode != SocketError.Success)
		{
			method_25(errorCode);
			vmethod_0();
		}
		return num;
	}

	public virtual long vmethod_3(string string_0)
	{
		return vmethod_1(Encoding.UTF8.GetBytes(string_0));
	}

	public virtual bool vmethod_4(byte[] byte_0)
	{
		return vmethod_5(byte_0, 0L, byte_0.Length);
	}

	public virtual bool vmethod_5(byte[] byte_0, long long_5, long long_6)
	{
		if (!method_16())
		{
			return false;
		}
		if (long_6 == 0L)
		{
			return true;
		}
		lock (object_0)
		{
			gclass28_1.method_13(byte_0, long_5, long_6);
			method_5(gclass28_1.method_3());
			if (bool_2)
			{
				return true;
			}
			bool_2 = true;
			method_20();
		}
		return true;
	}

	public virtual bool vmethod_6(string string_0)
	{
		return vmethod_4(Encoding.UTF8.GetBytes(string_0));
	}

	public virtual long vmethod_7(byte[] byte_0)
	{
		return vmethod_8(byte_0, 0L, byte_0.Length);
	}

	public virtual long vmethod_8(byte[] byte_0, long long_5, long long_6)
	{
		if (!method_16())
		{
			return 0L;
		}
		if (long_6 == 0L)
		{
			return 0L;
		}
		long num = method_2().Receive(byte_0, (int)long_5, (int)long_6, SocketFlags.None, out var errorCode);
		if (num > 0L)
		{
			method_11(method_10() + num);
			vmethod_15(byte_0, 0L, num);
		}
		if (errorCode != SocketError.Success)
		{
			method_25(errorCode);
			vmethod_0();
		}
		return num;
	}

	public virtual string vmethod_9(long long_5)
	{
		byte[] array = new byte[long_5];
		long num = vmethod_7(array);
		return Encoding.UTF8.GetString(array, 0, (int)num);
	}

	public virtual void vmethod_10()
	{
		method_19();
	}

	private void method_19()
	{
		if (bool_1 || !method_16())
		{
			return;
		}
		bool flag = true;
		while (flag)
		{
			flag = false;
			try
			{
				bool_1 = true;
				socketAsyncEventArgs_0.SetBuffer(gclass28_0.method_1(), 0, (int)gclass28_0.method_2());
				if (!method_2().ReceiveAsync(socketAsyncEventArgs_0))
				{
					flag = method_23(socketAsyncEventArgs_0);
				}
			}
			catch (ObjectDisposedException)
			{
			}
		}
	}

	private void method_20()
	{
		if (!method_16())
		{
			return;
		}
		bool flag = false;
		bool flag2 = true;
		while (true)
		{
			if (!flag2)
			{
				return;
			}
			flag2 = false;
			lock (object_0)
			{
				if (!gclass28_2.method_0())
				{
					return;
				}
				gclass28_2 = Interlocked.Exchange(ref gclass28_1, gclass28_2);
				long_4 = 0L;
				method_5(0L);
				method_7(method_6() + gclass28_2.method_3());
				if (gclass28_2.method_0())
				{
					flag = true;
					bool_2 = false;
				}
			}
			if (flag)
			{
				break;
			}
			try
			{
				socketAsyncEventArgs_1.SetBuffer(gclass28_2.method_1(), (int)long_4, (int)(gclass28_2.method_3() - long_4));
				if (!method_2().SendAsync(socketAsyncEventArgs_1))
				{
					flag2 = method_24(socketAsyncEventArgs_1);
				}
			}
			catch (ObjectDisposedException)
			{
			}
		}
		vmethod_17();
	}

	private void method_21()
	{
		lock (object_0)
		{
			gclass28_1.method_5();
			gclass28_2.method_5();
			long_4 = 0L;
			method_5(0L);
			method_7(0L);
		}
	}

	private void method_22(object sender, SocketAsyncEventArgs e)
	{
		if (method_28())
		{
			return;
		}
		switch (e.LastOperation)
		{
		default:
			throw new ArgumentException(Class84.smethod_0(-994212834));
		case SocketAsyncOperation.Send:
			if (method_24(e))
			{
				method_20();
			}
			break;
		case SocketAsyncOperation.Receive:
			if (method_23(e))
			{
				method_19();
			}
			break;
		}
	}

	private bool method_23(SocketAsyncEventArgs socketAsyncEventArgs_2)
	{
		if (!method_16())
		{
			return false;
		}
		long num = socketAsyncEventArgs_2.BytesTransferred;
		if (num > 0L)
		{
			method_11(method_10() + num);
			vmethod_15(gclass28_0.method_1(), 0L, num);
			if (gclass28_0.method_2() == num)
			{
				gclass28_0.method_8(2L * num);
			}
		}
		bool_1 = false;
		if (socketAsyncEventArgs_2.SocketError == SocketError.Success)
		{
			if (num > 0L)
			{
				return true;
			}
			vmethod_0();
		}
		else
		{
			method_25(socketAsyncEventArgs_2.SocketError);
			vmethod_0();
		}
		return false;
	}

	private bool method_24(SocketAsyncEventArgs socketAsyncEventArgs_2)
	{
		if (!method_16())
		{
			return false;
		}
		long num = socketAsyncEventArgs_2.BytesTransferred;
		if (num > 0L)
		{
			method_7(method_6() - num);
			method_9(method_8() + num);
			long_4 += num;
			if (long_4 == gclass28_2.method_3())
			{
				gclass28_2.method_5();
				long_4 = 0L;
			}
			vmethod_16(num, method_4() + method_6());
		}
		if (socketAsyncEventArgs_2.SocketError == SocketError.Success)
		{
			return true;
		}
		method_25(socketAsyncEventArgs_2.SocketError);
		vmethod_0();
		return false;
	}

	protected virtual void vmethod_11()
	{
	}

	protected virtual void vmethod_12()
	{
	}

	protected virtual void vmethod_13()
	{
	}

	protected virtual void vmethod_14()
	{
	}

	protected virtual void vmethod_15(byte[] byte_0, long long_5, long long_6)
	{
	}

	protected virtual void vmethod_16(long long_5, long long_6)
	{
	}

	protected virtual void vmethod_17()
	{
	}

	protected virtual void vmethod_18(SocketError socketError_0)
	{
	}

	private void method_25(SocketError socketError_0)
	{
		if (socketError_0 != SocketError.ConnectionAborted && socketError_0 != SocketError.ConnectionRefused && socketError_0 != SocketError.ConnectionReset && socketError_0 != SocketError.OperationAborted && socketError_0 != SocketError.Shutdown)
		{
			vmethod_18(socketError_0);
		}
	}

	public bool method_26()
	{
		return bool_3;
	}

	private void method_27(bool bool_5)
	{
		bool_3 = bool_5;
	}

	public bool method_28()
	{
		return bool_4;
	}

	private void method_29(bool bool_5)
	{
		bool_4 = bool_5;
	}

	public void Dispose()
	{
		vmethod_19(bool_5: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void vmethod_19(bool bool_5)
	{
		if (!method_26())
		{
			if (bool_5)
			{
				vmethod_0();
			}
			method_27(bool_5: true);
		}
	}

	~GClass44()
	{
		vmethod_19(bool_5: false);
	}
}
