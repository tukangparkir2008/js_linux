using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal sealed class Class41 : Interface6, IDisposable
{
	private List<byte> list_0 = new List<byte>();

	[SpecialName]
	public int imethod_0()
	{
		return list_0.Count;
	}

	public void imethod_3()
	{
		list_0.Clear();
	}

	public Interface6 imethod_4()
	{
		return new Class41();
	}

	public void Dispose()
	{
		imethod_3();
		list_0 = null;
	}

	public void imethod_1(int int_0, out byte byte_0)
	{
		byte_0 = method_0(list_0[int_0], int_0);
	}

	public void imethod_2(int int_0, ref byte byte_0)
	{
		int num = list_0.Count;
		while (true)
		{
			if (num <= int_0)
			{
				if (num == int_0)
				{
					break;
				}
				list_0.Add(method_1(0, num));
				num++;
				continue;
			}
			list_0[int_0] = method_1(byte_0, int_0);
			return;
		}
		list_0.Add(method_1(byte_0, num));
	}

	private byte method_0(byte byte_0, int int_0)
	{
		throw new NotImplementedException();
	}

	private byte method_1(byte byte_0, int int_0)
	{
		throw new NotImplementedException();
	}
}
