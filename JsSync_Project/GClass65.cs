using System;

public class GClass65 : IDisposable
{
	private readonly Action action_0;

	public GClass65(Action action_1)
	{
		action_0 = action_1;
	}

	public void Dispose()
	{
		action_0();
	}
}
