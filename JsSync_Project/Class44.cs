using System;
using System.Security.Cryptography;

internal sealed class Class44 : DeriveBytes
{
	private static bool bool_0;

	private DeriveBytes deriveBytes_0;

	private readonly byte[] byte_0;

	private readonly byte[] byte_1;

	private readonly int int_0;

	public Class44(byte[] byte_2, byte[] byte_3, int int_1)
	{
		byte_0 = byte_2;
		byte_1 = byte_3;
		int_0 = int_1;
		if (!bool_0)
		{
			try
			{
				deriveBytes_0 = new Rfc2898DeriveBytes(byte_2, byte_3, int_1);
			}
			catch
			{
				bool_0 = true;
			}
		}
		if (deriveBytes_0 == null)
		{
			deriveBytes_0 = new Class39(byte_2, byte_3, int_1);
		}
	}

	public override byte[] GetBytes(int cb)
	{
		byte[] array = null;
		if (!bool_0)
		{
			try
			{
				array = deriveBytes_0.GetBytes(cb);
			}
			catch
			{
				bool_0 = true;
			}
		}
		if (array == null)
		{
			deriveBytes_0 = new Class39(byte_0, byte_1, int_0);
			array = deriveBytes_0.GetBytes(cb);
		}
		return array;
	}

	public override void Reset()
	{
		throw new NotSupportedException();
	}
}
