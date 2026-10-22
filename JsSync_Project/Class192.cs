using System.Drawing;

internal sealed class Class192 : GClass25
{
	private readonly Brush brush_0;

	private readonly bool bool_0;

	public Class192(Brush brush_1, bool bool_1)
	{
		brush_0 = brush_1;
		bool_0 = bool_1;
	}

	public Brush method_0()
	{
		return brush_0;
	}

	public override void Dispose()
	{
		if (bool_0)
		{
			brush_0.Dispose();
		}
	}
}
