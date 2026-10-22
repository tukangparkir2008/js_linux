using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal sealed class Class269 : GClass42
{
	private readonly ContextMenuStrip contextMenuStrip_0;

	public Class269()
	{
		contextMenuStrip_0 = new ContextMenuStrip();
		contextMenuStrip_0.ShowImageMargin = false;
	}

	[SpecialName]
	public override int vmethod_0()
	{
		return contextMenuStrip_0.Items.Count;
	}

	public override void vmethod_1()
	{
		contextMenuStrip_0.Items.Add(Class84.smethod_0(-994278690));
	}

	public override void vmethod_2(string string_0, bool bool_0, EventHandler eventHandler_0)
	{
		GClass24.smethod_3(string_0, Class84.smethod_0(-994288555));
		GClass24.smethod_1(eventHandler_0, Class84.smethod_0(-994288576));
		contextMenuStrip_0.Items.Add(string_0, null, eventHandler_0).Enabled = bool_0;
	}

	public override void vmethod_3()
	{
		if (contextMenuStrip_0.Items[contextMenuStrip_0.Items.Count - 1].Text == string.Empty)
		{
			contextMenuStrip_0.Items.RemoveAt(contextMenuStrip_0.Items.Count - 1);
		}
	}

	public override void vmethod_4(GClass38 gclass38_0, GStruct2 gstruct2_0)
	{
		contextMenuStrip_0.Show(((Class255)gclass38_0).method_1(), Class237.smethod_3(gstruct2_0));
	}

	public override void Dispose()
	{
		contextMenuStrip_0.Dispose();
	}
}
