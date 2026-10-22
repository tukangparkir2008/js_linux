using System.Net.NetworkInformation;
using System.Net.Sockets;

internal sealed class Class319 : GClass54
{
	private readonly int int_3;

	private readonly string string_0;

	private readonly Class213 class213_0;

	public Class319(string string_1, int int_4, GClass4 gclass4_0)
		: base(string_1, int_4)
	{
		string_0 = string_1;
		int_3 = int_4;
		class213_0 = new Class213(gclass4_0);
	}

	public int method_43()
	{
		return int_3;
	}

	public string method_44()
	{
		return string_0;
	}

	public Class213 method_45()
	{
		return class213_0;
	}

	protected override GClass44 vmethod_4()
	{
		return new Class292(this);
	}

	protected override void vmethod_17(SocketError socketError_0)
	{
		Class125.smethod_1(Class84.smethod_0(-994201377), socketError_0.ToString(), null);
	}

	public bool method_46()
	{
		TcpConnectionInformation[] activeTcpConnections = IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpConnections();
		bool result = true;
		TcpConnectionInformation[] array = activeTcpConnections;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].LocalEndPoint.Port == method_43())
			{
				result = false;
				break;
			}
		}
		return result;
	}
}
