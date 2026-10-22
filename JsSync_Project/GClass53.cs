using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class GClass53 : IDisposable
{
	private readonly Guid guid_0;

	private IPEndPoint ipendPoint_0;

	private int int_0 = 1024;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private int int_1 = 8192;

	private int int_2 = 8192;

	private Socket socket_0;

	private SocketAsyncEventArgs socketAsyncEventArgs_0;

	private bool bool_5;

	private bool bool_6;

	protected readonly ConcurrentDictionary<Guid, GClass44> concurrentDictionary_0 = new ConcurrentDictionary<Guid, GClass44>();

	private bool bool_7;

	private bool bool_8 = true;

	public GClass53(IPAddress ipaddress_0, int int_3)
		: this(new IPEndPoint(ipaddress_0, int_3))
	{
	}

	public GClass53(string string_0, int int_3)
		: this(new IPEndPoint(IPAddress.Parse(string_0), int_3))
	{
	}

	public GClass53(IPEndPoint ipendPoint_1)
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

	public long method_3()
	{
		return concurrentDictionary_0.Count;
	}

	public int method_4()
	{
		return int_0;
	}

	public void method_5(int int_3)
	{
		int_0 = int_3;
	}

	public bool method_6()
	{
		return bool_0;
	}

	public void method_7(bool bool_9)
	{
		bool_0 = bool_9;
	}

	public bool method_8()
	{
		return bool_1;
	}

	public void method_9(bool bool_9)
	{
		bool_1 = bool_9;
	}

	public bool method_10()
	{
		return bool_2;
	}

	public void method_11(bool bool_9)
	{
		bool_2 = bool_9;
	}

	public bool method_12()
	{
		return bool_3;
	}

	public void method_13(bool bool_9)
	{
		bool_3 = bool_9;
	}

	public bool method_14()
	{
		return bool_4;
	}

	public void method_15(bool bool_9)
	{
		bool_4 = bool_9;
	}

	public int method_16()
	{
		return int_1;
	}

	public void method_17(int int_3)
	{
		int_1 = int_3;
	}

	public int method_18()
	{
		return int_2;
	}

	public void method_19(int int_3)
	{
		int_2 = int_3;
	}

	public bool method_20()
	{
		return bool_5;
	}

	private void method_21(bool bool_9)
	{
		bool_5 = bool_9;
	}

	public bool method_22()
	{
		return bool_6;
	}

	private void method_23(bool bool_9)
	{
		bool_6 = bool_9;
	}

	protected virtual Socket vmethod_0()
	{
		return new Socket(method_1().AddressFamily, SocketType.Stream, ProtocolType.Tcp);
	}

	public virtual GClass70 vmethod_1()
	{
		try
		{
			if (method_20())
			{
				return new GClass70(0, Class84.smethod_0(-994212791));
			}
			socketAsyncEventArgs_0 = new SocketAsyncEventArgs();
			socketAsyncEventArgs_0.Completed += method_26;
			socket_0 = vmethod_0();
			method_38(bool_9: false);
			socket_0.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, method_12());
			socket_0.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ExclusiveAddressUse, method_14());
			if (socket_0.AddressFamily == AddressFamily.InterNetworkV6)
			{
				socket_0.DualMode = method_6();
			}
			socket_0.Bind(method_1());
			method_2((IPEndPoint)socket_0.LocalEndPoint);
			vmethod_9();
			socket_0.Listen(method_4());
			method_21(bool_9: true);
			vmethod_10();
			method_23(bool_9: true);
			method_24(socketAsyncEventArgs_0);
			return new GClass70(1, Class84.smethod_0(-994212754));
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994212728), ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
	}

	public virtual GClass70 vmethod_2()
	{
		try
		{
			if (!method_20())
			{
				return new GClass70(0, Class84.smethod_0(-994212674));
			}
			method_23(bool_9: false);
			socketAsyncEventArgs_0.Completed -= method_26;
			vmethod_11();
			try
			{
				socket_0.Close();
				socket_0.Dispose();
				socketAsyncEventArgs_0.Dispose();
				method_38(bool_9: true);
			}
			catch (ObjectDisposedException)
			{
			}
			vmethod_5();
			method_21(bool_9: false);
			vmethod_12();
			return new GClass70(1, Class84.smethod_0(-994212656));
		}
		catch (Exception ex2)
		{
			Class125.smethod_1(Class84.smethod_0(-994212614), ex2.Message, ex2);
			return new GClass70(-1, ex2.Message, ex2);
		}
	}

	public virtual GClass70 vmethod_3()
	{
		if (vmethod_2().Value != 1)
		{
			return new GClass70(-1, Class84.smethod_0(-994212639));
		}
		while (method_20())
		{
			Thread.Yield();
		}
		return vmethod_1();
	}

	private void method_24(SocketAsyncEventArgs socketAsyncEventArgs_1)
	{
		socketAsyncEventArgs_1.AcceptSocket = null;
		if (!socket_0.AcceptAsync(socketAsyncEventArgs_1))
		{
			method_25(socketAsyncEventArgs_1);
		}
	}

	private void method_25(SocketAsyncEventArgs socketAsyncEventArgs_1)
	{
		if (socketAsyncEventArgs_1.SocketError == SocketError.Success)
		{
			GClass44 gClass = vmethod_4();
			method_28(gClass);
			gClass.method_18(socketAsyncEventArgs_1.AcceptSocket);
		}
		else
		{
			method_34(socketAsyncEventArgs_1.SocketError);
		}
		if (method_22())
		{
			method_24(socketAsyncEventArgs_1);
		}
	}

	private void method_26(object sender, SocketAsyncEventArgs e)
	{
		if (!method_37())
		{
			method_25(e);
		}
	}

	protected virtual GClass44 vmethod_4()
	{
		return new GClass44(this);
	}

	public virtual bool vmethod_5()
	{
		if (!method_20())
		{
			return false;
		}
		foreach (GClass44 value in concurrentDictionary_0.Values)
		{
			value.vmethod_0();
		}
		return true;
	}

	public GClass44 method_27(Guid guid_1)
	{
		if (!concurrentDictionary_0.TryGetValue(guid_1, out var value))
		{
			return null;
		}
		return value;
	}

	internal void method_28(GClass44 gclass44_0)
	{
		concurrentDictionary_0.TryAdd(gclass44_0.method_0(), gclass44_0);
	}

	internal void method_29(Guid guid_1)
	{
		concurrentDictionary_0.TryRemove(guid_1, out var _);
	}

	public virtual bool vmethod_6(byte[] byte_0)
	{
		return vmethod_7(byte_0, 0L, byte_0.Length);
	}

	public virtual bool vmethod_7(byte[] byte_0, long long_0, long long_1)
	{
		if (!method_20())
		{
			return false;
		}
		if (long_1 == 0L)
		{
			return true;
		}
		foreach (GClass44 value in concurrentDictionary_0.Values)
		{
			value.vmethod_5(byte_0, long_0, long_1);
		}
		return true;
	}

	public virtual bool vmethod_8(string string_0)
	{
		return vmethod_6(Encoding.UTF8.GetBytes(string_0));
	}

	protected virtual void vmethod_9()
	{
	}

	protected virtual void vmethod_10()
	{
	}

	protected virtual void vmethod_11()
	{
	}

	protected virtual void vmethod_12()
	{
	}

	protected virtual void vmethod_13(GClass44 gclass44_0)
	{
	}

	protected virtual void vmethod_14(GClass44 gclass44_0)
	{
	}

	protected virtual void vmethod_15(GClass44 gclass44_0)
	{
	}

	protected virtual void vmethod_16(GClass44 gclass44_0)
	{
	}

	protected virtual void vmethod_17(SocketError socketError_0)
	{
	}

	internal void method_30(GClass44 gclass44_0)
	{
		vmethod_13(gclass44_0);
	}

	internal void method_31(GClass44 gclass44_0)
	{
		vmethod_14(gclass44_0);
	}

	internal void method_32(GClass44 gclass44_0)
	{
		vmethod_15(gclass44_0);
	}

	internal void method_33(GClass44 gclass44_0)
	{
		vmethod_16(gclass44_0);
	}

	private void method_34(SocketError socketError_0)
	{
		if (socketError_0 != SocketError.ConnectionAborted && socketError_0 != SocketError.ConnectionRefused && socketError_0 != SocketError.ConnectionReset && socketError_0 != SocketError.OperationAborted && socketError_0 != SocketError.Shutdown)
		{
			vmethod_17(socketError_0);
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
		vmethod_18(bool_9: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void vmethod_18(bool bool_9)
	{
		if (!method_35())
		{
			if (bool_9)
			{
				vmethod_2();
			}
			method_36(bool_9: true);
		}
	}

	~GClass53()
	{
		vmethod_18(bool_9: false);
	}
}
