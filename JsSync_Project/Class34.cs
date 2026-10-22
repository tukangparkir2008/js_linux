using System;
using System.Diagnostics;
using System.Threading;

internal static class Class34
{
	internal sealed class Class35 : Interface0<int>, Interface3<int>, Interface1, Interface2, Interface7
	{
		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		public int int_4;

		[DebuggerHidden]
		public Class35(int int_5)
		{
			int_0 = int_5;
			int_2 = Thread.CurrentThread.ManagedThreadId;
		}

		[DebuggerHidden]
		void Interface2.imethod_0()
		{
		}

		private bool imethod_1()
		{
			switch (int_0)
			{
			default:
				return false;
			case 0:
				int_0 = -1;
				int_1 = 1643726291;
				int_0 = 1;
				return true;
			case 1:
				int_0 = -1;
				int_1 = 226510974;
				int_0 = 2;
				return true;
			case 2:
				int_0 = -1;
				int_1 = int_3 ^ -1469726359;
				int_0 = 3;
				return true;
			case 3:
				int_0 = -1;
				int_1 = 1411151159;
				int_0 = 4;
				return true;
			case 4:
				int_0 = -1;
				int_1 = int_3 ^ 0x213EE68D;
				int_0 = 5;
				return true;
			case 5:
				int_0 = -1;
				int_1 = -334278431;
				int_0 = 6;
				return true;
			case 6:
				int_0 = -1;
				int_1 = 1475782690;
				int_0 = 7;
				return true;
			case 7:
				int_0 = -1;
				return false;
			}
		}

		bool Interface1.imethod_1()
		{
			//ILSpy generated this explicit interface implementation from .override directive in imethod_1
			return this.imethod_1();
		}

		[DebuggerHidden]
		int Interface0<int>.imethod_3()
		{
			return int_1;
		}

		[DebuggerHidden]
		void Interface1.imethod_2()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		object Interface1.imethod_0()
		{
			return int_1;
		}

		[DebuggerHidden]
		Interface0<int> Interface3<int>.GetEnumerator()
		{
			Class35 @class;
			if (int_0 == -2 && int_2 == Thread.CurrentThread.ManagedThreadId)
			{
				int_0 = 0;
				@class = this;
			}
			else
			{
				@class = new Class35(0);
			}
			@class.int_3 = int_4;
			return @class;
		}

		[DebuggerHidden]
		Interface1 Interface7.imethod_0()
		{
			return ((Interface3<int>)this).GetEnumerator();
		}
	}
}
