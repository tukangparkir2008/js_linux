using System.Threading;

public sealed class GClass67 : GClass65
{
	public GClass67(ReaderWriterLockSlim readerWriterLockSlim_0)
		: base(readerWriterLockSlim_0.ExitReadLock)
	{
		readerWriterLockSlim_0.EnterReadLock();
	}
}
