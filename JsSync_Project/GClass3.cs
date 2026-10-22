using System;
using System.Reflection;
using System.Windows.Forms;

public class GClass3
{
	private sealed class Class130
	{
		public GClass3 gclass3_0;

		public string string_0;

		internal void method_0()
		{
			gclass3_0.method_0().method_3(string_0);
		}
	}

	private sealed class Class131
	{
		public GClass3 gclass3_0;

		public GEnum0 genum0_0;

		public string string_0;

		public string string_1;

		internal void method_0()
		{
			gclass3_0.method_0().method_11(genum0_0, string_0, string_1);
		}
	}

	private sealed class Class132
	{
		public GClass3 gclass3_0;

		public GEnum0 genum0_0;

		public string string_0;

		public string string_1;

		internal void method_0()
		{
			gclass3_0.method_0().method_10(genum0_0, string.Empty, string_0, string_1);
		}
	}

	private sealed class Class133
	{
		public GClass3 gclass3_0;

		public GEnum0 genum0_0;

		public string string_0;

		public string string_1;

		public string string_2;

		internal void method_0()
		{
			gclass3_0.method_0().method_10(genum0_0, string_0, string_1, string_2);
		}
	}

	private sealed class Class134
	{
		public GClass3 gclass3_0;

		public int int_0;

		public int int_1;

		internal void method_0()
		{
			gclass3_0.method_0().method_8(int_0, int_1);
		}
	}

	private GForm17 gform17_0;

	public GClass3(GForm17 gform17_1)
	{
		method_1(gform17_1);
	}

	protected GForm17 method_0()
	{
		return gform17_0;
	}

	private void method_1(GForm17 gform17_1)
	{
		gform17_0 = gform17_1;
	}

	public void method_2(string string_0)
	{
		Class130 @class = new Class130();
		@class.gclass3_0 = this;
		@class.string_0 = string_0;
		try
		{
			if (method_0().InvokeRequired)
			{
				method_0().BeginInvoke(new MethodInvoker(@class.method_0));
			}
			else
			{
				method_0().method_3(@class.string_0);
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_3(int int_0, int int_1)
	{
		Class134 @class = new Class134();
		@class.gclass3_0 = this;
		@class.int_0 = int_0;
		@class.int_1 = int_1;
		try
		{
			if (method_0().InvokeRequired)
			{
				method_0().BeginInvoke(new MethodInvoker(@class.method_0));
			}
			else
			{
				method_0().method_8(@class.int_0, @class.int_1);
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_4(GEnum0 genum0_0, string string_0, string string_1)
	{
		Class132 @class = new Class132();
		@class.gclass3_0 = this;
		@class.genum0_0 = genum0_0;
		@class.string_0 = string_0;
		@class.string_1 = string_1;
		try
		{
			if (@class.string_1.Trim().Length != 0)
			{
				if (method_0().InvokeRequired)
				{
					method_0().BeginInvoke(new MethodInvoker(@class.method_0));
				}
				else
				{
					method_0().method_10(@class.genum0_0, string.Empty, @class.string_0, @class.string_1);
				}
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_5(GEnum0 genum0_0, string string_0, string string_1, string string_2)
	{
		Class133 @class = new Class133();
		@class.gclass3_0 = this;
		@class.genum0_0 = genum0_0;
		@class.string_0 = string_0;
		@class.string_1 = string_1;
		@class.string_2 = string_2;
		try
		{
			if (@class.string_2.Trim().Length != 0)
			{
				if (method_0().InvokeRequired)
				{
					method_0().BeginInvoke(new MethodInvoker(@class.method_0));
				}
				else
				{
					method_0().method_10(@class.genum0_0, @class.string_0, @class.string_1, @class.string_2);
				}
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_6(GEnum0 genum0_0, string string_0, string string_1)
	{
		Class131 @class = new Class131();
		@class.gclass3_0 = this;
		@class.genum0_0 = genum0_0;
		@class.string_0 = string_0;
		@class.string_1 = string_1;
		try
		{
			if (@class.string_1 != null && @class.string_1.Trim().Length != 0)
			{
				if (method_0().InvokeRequired)
				{
					method_0().BeginInvoke(new MethodInvoker(@class.method_0));
				}
				else
				{
					method_0().method_11(@class.genum0_0, @class.string_0, @class.string_1);
				}
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}
}
