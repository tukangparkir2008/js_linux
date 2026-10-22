internal struct Struct0
{
	private int int_0;

	private readonly byte byte_0;

	public Struct0(int int_1, byte byte_1)
	{
		method_1(int_1);
		byte_0 = byte_1;
	}

	public int method_0()
	{
		return int_0;
	}

	public void method_1(int int_1)
	{
		int_0 = int_1;
	}

	public byte method_2()
	{
		return byte_0;
	}

	public override bool Equals(object obj)
	{
		if (obj is Struct0 struct0_)
		{
			return method_3(struct0_);
		}
		return false;
	}

	public bool method_3(Struct0 struct0_0)
	{
		return struct0_0.method_0() == method_0();
	}

	public static bool operator ==(Struct0 struct0_0, Struct0 struct0_1)
	{
		return struct0_0.method_3(struct0_1);
	}

	public static bool operator !=(Struct0 struct0_0, Struct0 struct0_1)
	{
		return !(struct0_0 == struct0_1);
	}

	public override int GetHashCode()
	{
		return method_0().GetHashCode();
	}

	public override string ToString()
	{
		return method_0().ToString();
	}
}
