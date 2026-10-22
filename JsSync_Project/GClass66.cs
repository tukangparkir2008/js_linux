using System.Threading;

public sealed class GClass66 : GClass65
{
	public GClass66(ReaderWriterLockSlim readerWriterLockSlim_0)
		: base(readerWriterLockSlim_0.ExitWriteLock)
	{
		readerWriterLockSlim_0.EnterWriteLock();
	}
}
