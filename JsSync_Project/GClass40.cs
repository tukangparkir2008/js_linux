using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class GClass40 : IDisposable
{
	private readonly Guid guid_0;

	private IPEndPoint ipendPoint_0;

	private Socket socket_0;

	private long long_0;

	private long long_1;

	private long long_2;

	private long long_3;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private int int_0 = 8192;

	private int int_1 = 8192;

	private SocketAsyncEventArgs socketAsyncEventArgs_0;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private GClass28 gclass28_0;

	private SocketAsyncEventArgs socketAsyncEventArgs_1;

	private readonly object object_0 = new object();

	private bool bool_6;

	private GClass28 gclass28_1;

	private GClass28 gclass28_2;

	private SocketAsyncEventArgs socketAsyncEventArgs_2;

	private long long_4;

	private bool bool_7;

	private bool bool_8 = true;

	public GClass40(IPAddress ipaddress_0, int int_2)
		: this(new IPEndPoint(ipaddress_0, int_2))
	{
	}

	public GClass40(string string_0, int int_2)
		: this(new IPEndPoint(IPAddress.Parse(string_0), int_2))
	{
	}

	public GClass40(IPEndPoint ipendPoint_1)
	{
		guid_0 = Guid.NewGuid();
		method_2(ipendPoint_1);
	}

	public Guid method_0()
	{
		return guid_0;
	}

	public IPEndPoint method_1()
	{
		return ipendPoint_0;
	}

	private void method_2(IPEndPoint ipendPoint_1)
	{
		ipendPoint_0 = ipendPoint_1;
	}

	public Socket method_3()
	{
		return socket_0;
	}

	private void method_4(Socket socket_1)
	{
		socket_0 = socket_1;
	}

	public long method_5()
	{
		return long_0;
	}

	private void method_6(long long_5)
	{
		long_0 = long_5;
	}

	public long method_7()
	{
		return long_1;
	}

	private void method_8(long long_5)
	{
		long_1 = long_5;
	}

	public long method_9()
	{
		return long_2;
	}

	private void method_10(long long_5)
	{
		long_2 = long_5;
	}

	public long method_11()
	{
		return long_3;
	}

	private void method_12(long long_5)
	{
		long_3 = long_5;
	}

	public bool method_13()
	{
		return bool_0;
	}

	public void method_14(bool bool_9)
	{
		bool_0 = bool_9;
	}

	public bool method_15()
	{
		return bool_1;
	}

	public void method_16(bool bool_9)
	{
		bool_1 = bool_9;
	}

	public bool method_17()
	{
		return bool_2;
	}

	public void method_18(bool bool_9)
	{
		bool_2 = bool_9;
	}

	public int method_19()
	{
		return int_0;
	}

	public void method_20(int int_2)
	{
		int_0 = int_2;
	}

	public int method_21()
	{
		return int_1;
	}

	public void method_22(int int_2)
	{
		int_1 = int_2;
	}

	public bool method_23()
	{
		return bool_3;
	}

	private void method_24(bool bool_9)
	{
		bool_3 = bool_9;
	}

	public bool method_25()
	{
		return bool_4;
	}

	private void method_26(bool bool_9)
	{
		bool_4 = bool_9;
	}

	protected virtual Socket vmethod_0()
	{
		return new Socket(method_1().AddressFamily, SocketType.Stream, ProtocolType.Tcp);
	}

	public virtual bool vmethod_1()
	{
		if (!method_25() && !method_23())
		{
			gclass28_0 = new GClass28();
			gclass28_1 = new GClass28();
			gclass28_2 = new GClass28();
			socketAsyncEventArgs_0 = new SocketAsyncEventArgs();
			socketAsyncEventArgs_0.RemoteEndPoint = method_1();
			socketAsyncEventArgs_0.Completed += method_30;
			socketAsyncEventArgs_1 = new SocketAsyncEventArgs();
			socketAsyncEventArgs_1.Completed += method_30;
			socketAsyncEventArgs_2 = new SocketAsyncEventArgs();
			socketAsyncEventArgs_2.Completed += method_30;
			method_4(vmethod_0());
			method_38(bool_9: false);
			if (method_3().AddressFamily == AddressFamily.InterNetworkV6)
			{
				method_3().DualMode = method_13();
			}
			vmethod_17();
			try
			{
				method_3().Connect(method_1());
			}
			catch (SocketException ex)
			{
				method_34(ex.SocketErrorCode);
				socketAsyncEventArgs_0.Completed -= method_30;
				socketAsyncEventArgs_1.Completed -= method_30;
				socketAsyncEventArgs_2.Completed -= method_30;
				vmethod_19();
				method_3().Close();
				method_3().Dispose();
				socketAsyncEventArgs_0.Dispose();
				socketAsyncEventArgs_1.Dispose();
				socketAsyncEventArgs_2.Dispose();
				vmethod_20();
				return false;
			}
			if (method_15())
			{
				method_3().SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, optionValue: true);
			}
			if (method_17())
			{
				method_3().SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Debug, optionValue: true);
			}
			gclass28_0.method_8(method_19());
			gclass28_1.method_8(method_21());
			gclass28_2.method_8(method_21());
			method_6(0L);
			method_8(0L);
			method_10(0L);
			method_12(0L);
			method_26(bool_9: true);
			vmethod_18();
			if (gclass28_1.method_0())
			{
				vmethod_23();
			}
			return true;
		}
		return false;
	}

	public virtual bool vmethod_2()
	{
		if (!method_25() && !method_23())
		{
			return false;
		}
		if (method_23())
		{
			Socket.CancelConnectAsync(socketAsyncEventArgs_0);
		}
		socketAsyncEventArgs_0.Completed -= method_30;
		socketAsyncEventArgs_1.Completed -= method_30;
		socketAsyncEventArgs_2.Completed -= method_30;
		vmethod_19();
		try
		{
			try
			{
				method_3().Shutdown(SocketShutdown.Both);
			}
			catch (SocketException)
			{
			}
			method_3().Close();
			method_3().Dispose();
			socketAsyncEventArgs_0.Dispose();
			socketAsyncEventArgs_1.Dispose();
			socketAsyncEventArgs_2.Dispose();
			method_38(bool_9: true);
		}
		catch (ObjectDisposedException)
		{
		}
		method_26(bool_9: false);
		bool_5 = false;
		bool_6 = false;
		method_29();
		vmethod_20();
		return true;
	}

	public virtual bool vmethod_3()
	{
		if (!vmethod_2())
		{
			return false;
		}
		return vmethod_1();
	}

	public virtual bool vmethod_4()
	{
		if (!method_25() && !method_23())
		{
			gclass28_0 = new GClass28();
			gclass28_1 = new GClass28();
			gclass28_2 = new GClass28();
			socketAsyncEventArgs_0 = new SocketAsyncEventArgs();
			socketAsyncEventArgs_0.RemoteEndPoint = method_1();
			socketAsyncEventArgs_0.Completed += method_30;
			socketAsyncEventArgs_1 = new SocketAsyncEventArgs();
			socketAsyncEventArgs_1.Completed += method_30;
			socketAsyncEventArgs_2 = new SocketAsyncEventArgs();
			socketAsyncEventArgs_2.Completed += method_30;
			method_4(vmethod_0());
			method_38(bool_9: false);
			if (method_3().AddressFamily == AddressFamily.InterNetworkV6)
			{
				method_3().DualMode = method_13();
			}
			method_24(bool_9: true);
			vmethod_17();
			if (!method_3().ConnectAsync(socketAsyncEventArgs_0))
			{
				method_31(socketAsyncEventArgs_0);
			}
			return true;
		}
		return false;
	}

	public virtual bool vmethod_5()
	{
		return vmethod_2();
	}

	public virtual bool vmethod_6()
	{
		if (!vmethod_5())
		{
			return false;
		}
		while (method_25())
		{
			Thread.Yield();
		}
		return vmethod_4();
	}

	public virtual long vmethod_7(byte[] byte_0)
	{
		return vmethod_8(byte_0, 0L, byte_0.Length);
	}

	public virtual long vmethod_8(byte[] byte_0, long long_5, long long_6)
	{
		if (!method_25())
		{
			return 0L;
		}
		if (long_6 == 0L)
		{
			return 0L;
		}
		long num = method_3().Send(byte_0, (int)long_5, (int)long_6, SocketFlags.None, out var errorCode);
		if (num > 0L)
		{
			method_10(method_9() + num);
			vmethod_22(num, method_5() + method_7());
		}
		if (errorCode != SocketError.Success)
		{
			method_34(errorCode);
			vmethod_2();
		}
		return num;
	}

	public virtual long vmethod_9(string string_0)
	{
		return vmethod_7(Encoding.UTF8.GetBytes(string_0));
	}

	public virtual bool vmethod_10(byte[] byte_0)
	{
		return vmethod_11(byte_0, 0L, byte_0.Length);
	}

	public virtual bool vmethod_11(byte[] byte_0, long long_5, long long_6)
	{
		if (!method_25())
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
			method_6(gclass28_1.method_3());
			if (bool_6)
			{
				return true;
			}
			bool_6 = true;
			method_28();
		}
		return true;
	}

	public virtual bool vmethod_12(string string_0)
	{
		return vmethod_10(Encoding.UTF8.GetBytes(string_0));
	}

	public virtual long vmethod_13(byte[] byte_0)
	{
		return vmethod_14(byte_0, 0L, byte_0.Length);
	}

	public virtual long vmethod_14(byte[] byte_0, long long_5, long long_6)
	{
		if (!method_25())
		{
			return 0L;
		}
		if (long_6 == 0L)
		{
			return 0L;
		}
		long num = method_3().Receive(byte_0, (int)long_5, (int)long_6, SocketFlags.None, out var errorCode);
		if (num > 0L)
		{
			method_12(method_11() + num);
			vmethod_21(byte_0, 0L, num);
		}
		if (errorCode != SocketError.Success)
		{
			method_34(errorCode);
			vmethod_2();
		}
		return num;
	}

	public virtual string vmethod_15(long long_5)
	{
		byte[] array = new byte[long_5];
		long num = vmethod_13(array);
		return Encoding.UTF8.GetString(array, 0, (int)num);
	}

	public virtual void vmethod_16()
	{
		method_27();
	}

	private void method_27()
	{
		if (bool_5 || !method_25())
		{
			return;
		}
		bool flag = true;
		while (flag)
		{
			flag = false;
			try
			{
				bool_5 = true;
				socketAsyncEventArgs_1.SetBuffer(gclass28_0.method_1(), 0, (int)gclass28_0.method_2());
				if (!method_3().ReceiveAsync(socketAsyncEventArgs_1))
				{
					flag = method_32(socketAsyncEventArgs_1);
				}
			}
			catch (ObjectDisposedException)
			{
			}
		}
	}

	private void method_28()
	{
		if (!method_25())
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
				method_6(0L);
				method_8(method_7() + gclass28_2.method_3());
				if (gclass28_2.method_0())
				{
					flag = true;
					bool_6 = false;
				}
			}
			if (flag)
			{
				break;
			}
			try
			{
				socketAsyncEventArgs_2.SetBuffer(gclass28_2.method_1(), (int)long_4, (int)(gclass28_2.method_3() - long_4));
				if (!method_3().SendAsync(socketAsyncEventArgs_2))
				{
					flag2 = method_33(socketAsyncEventArgs_2);
				}
			}
			catch (ObjectDisposedException)
			{
			}
		}
		vmethod_23();
	}

	private void method_29()
	{
		lock (object_0)
		{
			gclass28_1.method_5();
			gclass28_2.method_5();
			long_4 = 0L;
			method_6(0L);
			method_8(0L);
		}
	}

	private void method_30(object sender, SocketAsyncEventArgs e)
	{
		if (method_37())
		{
			return;
		}
		switch (e.LastOperation)
		{
		default:
			throw new ArgumentException(Class84.smethod_0(-994212834));
		case SocketAsyncOperation.Send:
			if (method_33(e))
			{
				method_28();
			}
			break;
		case SocketAsyncOperation.Receive:
			if (method_32(e))
			{
				method_27();
			}
			break;
		case SocketAsyncOperation.Connect:
			method_31(e);
			break;
		}
	}

	private void method_31(SocketAsyncEventArgs socketAsyncEventArgs_3)
	{
		method_24(bool_9: false);
		if (socketAsyncEventArgs_3.SocketError == SocketError.Success)
		{
			if (method_15())
			{
				method_3().SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, optionValue: true);
			}
			if (method_17())
			{
				method_3().SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Debug, optionValue: true);
			}
			gclass28_0.method_8(method_19());
			gclass28_1.method_8(method_21());
			gclass28_2.method_8(method_21());
			method_6(0L);
			method_8(0L);
			method_10(0L);
			method_12(0L);
			method_26(bool_9: true);
			method_27();
			if (!method_37())
			{
				vmethod_18();
				if (gclass28_1.method_0())
				{
					vmethod_23();
				}
			}
		}
		else
		{
			method_34(socketAsyncEventArgs_3.SocketError);
			vmethod_20();
		}
	}

	private bool method_32(SocketAsyncEventArgs socketAsyncEventArgs_3)
	{
		if (!method_25())
		{
			return false;
		}
		long num = socketAsyncEventArgs_3.BytesTransferred;
		if (num > 0L)
		{
			method_12(method_11() + num);
			vmethod_21(gclass28_0.method_1(), 0L, num);
			if (gclass28_0.method_2() == num)
			{
				gclass28_0.method_8(2L * num);
			}
		}
		bool_5 = false;
		if (socketAsyncEventArgs_3.SocketError == SocketError.Success)
		{
			if (num > 0L)
			{
				return true;
			}
			vmethod_5();
		}
		else
		{
			method_34(socketAsyncEventArgs_3.SocketError);
			vmethod_5();
		}
		return false;
	}

	private bool method_33(SocketAsyncEventArgs socketAsyncEventArgs_3)
	{
		if (!method_25())
		{
			return false;
		}
		long num = socketAsyncEventArgs_3.BytesTransferred;
		if (num > 0L)
		{
			method_8(method_7() - num);
			method_10(method_9() + num);
			long_4 += num;
			if (long_4 == gclass28_2.method_3())
			{
				gclass28_2.method_5();
				long_4 = 0L;
			}
			vmethod_22(num, method_5() + method_7());
		}
		if (socketAsyncEventArgs_3.SocketError == SocketError.Success)
		{
			return true;
		}
		method_34(socketAsyncEventArgs_3.SocketError);
		vmethod_5();
		return false;
	}

	protected virtual void vmethod_17()
	{
	}

	protected virtual void vmethod_18()
	{
	}

	protected virtual void vmethod_19()
	{
	}

	protected virtual void vmethod_20()
	{
	}

	protected virtual void vmethod_21(byte[] byte_0, long long_5, long long_6)
	{
	}

	protected virtual void vmethod_22(long long_5, long long_6)
	{
	}

	protected virtual void vmethod_23()
	{
	}

	protected virtual void vmethod_24(SocketError socketError_0)
	{
	}

	private void method_34(SocketError socketError_0)
	{
		if (socketError_0 != SocketError.ConnectionAborted && socketError_0 != SocketError.ConnectionRefused && socketError_0 != SocketError.ConnectionReset && socketError_0 != SocketError.OperationAborted && socketError_0 != SocketError.Shutdown)
		{
			vmethod_24(socketError_0);
		}
	}

	public bool method_35()
	{
		return bool_7;
	}

	private void method_36(bool bool_9)
	{
		bool_7 = bool_9;
	}

	public bool method_37()
	{
		return bool_8;
	}

	private void method_38(bool bool_9)
	{
		bool_8 = bool_9;
	}

	public void Dispose()
	{
		vmethod_25(bool_9: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void vmethod_25(bool bool_9)
	{
		if (!method_35())
		{
			if (bool_9)
			{
				vmethod_5();
			}
			method_36(bool_9: true);
		}
	}

	~GClass40()
	{
		vmethod_25(bool_9: false);
	}
}
