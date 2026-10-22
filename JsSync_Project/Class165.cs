using System;
using System.Management;
using System.Net;
using System.Net.Sockets;
using Microsoft.Win32;

internal sealed class Class165
{
	private static bool bool_0;

	private static string string_0 = string.Empty;

	private static string string_1 = string.Empty;

	private static void smethod_0()
	{
		try
		{
			string_0 = string.Empty;
			IPAddress[] hostAddresses = Dns.GetHostAddresses(Dns.GetHostName());
			foreach (IPAddress iPAddress in hostAddresses)
			{
				if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
				{
					if (!string_0.Equals(string.Empty))
					{
						string_0 += Class84.smethod_0(-994271851);
					}
					string_0 += iPAddress.ToString();
				}
			}
			string_1 = Registry.GetValue(Class84.smethod_0(-994542753), Class84.smethod_0(-994542699), string.Empty).ToString();
			string_1 = string_1 + Class84.smethod_0(-994542713) + smethod_2();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994542665), ex.Message, ex);
		}
		finally
		{
			bool_0 = true;
		}
	}

	private static ManagementObject smethod_1(string string_2)
	{
		foreach (ManagementObject instance in new ManagementClass(string_2).GetInstances())
		{
			if (instance != null)
			{
				return instance;
			}
		}
		return null;
	}

	public static string smethod_2()
	{
		try
		{
			ManagementObject managementObject = smethod_1(Class84.smethod_0(-994542635));
			if (managementObject == null)
			{
				return string.Empty;
			}
			return managementObject[Class84.smethod_0(-994542607)] as string;
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public static string smethod_3()
	{
		if (!bool_0)
		{
			smethod_0();
		}
		return string_0;
	}

	public static string smethod_4()
	{
		if (!bool_0)
		{
			smethod_0();
		}
		return string_1;
	}
}
