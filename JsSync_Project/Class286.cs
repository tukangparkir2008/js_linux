using System.Drawing.Printing;

internal sealed class Class286 : PrintDocument
{
	private int int_0;

	private readonly GClass32 gclass32_0;

	public Class286(GClass32 gclass32_1, string string_0, int int_1, int int_2, int int_3)
	{
		gclass32_0 = gclass32_1;
		if (gclass32_0.method_2().Count != 0)
		{
			if (int_3 == 0)
			{
				DefaultPageSettings.PaperSize = new PaperSize(string_0, int_1, int_2);
			}
			else
			{
				DefaultPageSettings.PaperSize = new PaperSize(string_0, int_2, int_1);
			}
			BeginPrint += Class286_BeginPrint;
			PrintPage += Class286_PrintPage;
		}
	}

	private void Class286_PrintPage(object sender, PrintPageEventArgs e)
	{
		e.Graphics.DrawImage(gclass32_0.method_2()[int_0], 0, 0);
		int_0++;
		if (int_0 < gclass32_0.method_2().Count)
		{
			e.HasMorePages = true;
		}
		else
		{
			e.HasMorePages = false;
		}
	}

	private void Class286_BeginPrint(object sender, PrintEventArgs e)
	{
		int_0 = 0;
	}
}
