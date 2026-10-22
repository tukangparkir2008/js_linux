using System;

internal abstract class Class67 : IDisposable
{
	public abstract bool vmethod_0();

	public abstract bool vmethod_1();

	public abstract bool vmethod_2();

	public abstract long vmethod_3();

	public abstract long vmethod_4();

	public abstract void vmethod_5(long long_0);

	public virtual void vmethod_6()
	{
		vmethod_7(bool_0: true);
		GC.SuppressFinalize(this);
	}

	public void Dispose()
	{
		vmethod_6();
	}

	protected virtual void vmethod_7(bool bool_0)
	{
	}

	public abstract void vmethod_8();

	public abstract long vmethod_9(long long_0, int int_0);

	public abstract void vmethod_10(long long_0);

	public abstract int vmethod_11(byte[] byte_0, int int_0, int int_1);

	public virtual int vmethod_12()
	{
		byte[] array = new byte[1];
		if (vmethod_11(array, 0, 1) == 0)
		{
			return -1;
		}
		return array[0];
	}

	public abstract void vmethod_13(byte[] byte_0, int int_0, int int_1);

	public virtual void vmethod_14(byte byte_0)
	{
		vmethod_13(new byte[1] { byte_0 }, 0, 1);
	}
}
