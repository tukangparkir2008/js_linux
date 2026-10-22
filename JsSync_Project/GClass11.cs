using System;
using System.Drawing;
using System.Windows.Forms;

public sealed class GClass11 : ListBox
{
	private readonly Font font_0 = new Font(Class84.smethod_0(-994274653), 8f, FontStyle.Regular);

	public GClass11()
	{
		DrawMode = DrawMode.OwnerDrawVariable;
	}

	private static Color smethod_0(GClass33 gclass33_0)
	{
		if (gclass33_0.genum0_0 == GEnum0.Started)
		{
			return Color.Blue;
		}
		if (gclass33_0.genum0_0 == GEnum0.Stopped)
		{
			return Color.DarkBlue;
		}
		if (gclass33_0.genum0_0 == GEnum0.Login)
		{
			return Color.SteelBlue;
		}
		if (gclass33_0.genum0_0 == GEnum0.Logout)
		{
			return Color.Maroon;
		}
		if (gclass33_0.genum0_0 == GEnum0.Warn)
		{
			return Color.Chocolate;
		}
		if (gclass33_0.genum0_0 == GEnum0.Error)
		{
			return Color.Maroon;
		}
		if (gclass33_0.genum0_0 == GEnum0.Info)
		{
			return Color.Purple;
		}
		if (gclass33_0.genum0_0 == GEnum0.Scan)
		{
			return Color.DarkGreen;
		}
		return Color.DarkKhaki;
	}

	private void method_0(DrawItemEventArgs drawItemEventArgs_0, GClass33 gclass33_0)
	{
		string s = gclass33_0.string_1.PadLeft(4, ' ');
		Color color = smethod_0(gclass33_0);
		Color color2 = ((gclass33_0.genum0_0 == GEnum0.Error) ? Color.Yellow : Color.White);
		drawItemEventArgs_0.Graphics.FillRectangle(new SolidBrush(color), drawItemEventArgs_0.Bounds.Left, drawItemEventArgs_0.Bounds.Top, 47, 16);
		drawItemEventArgs_0.Graphics.DrawString(s, font_0, new SolidBrush(color2), drawItemEventArgs_0.Bounds.Left + 2, drawItemEventArgs_0.Bounds.Top);
		int num = 47;
		color = ((gclass33_0.genum0_0 == GEnum0.Error) ? Color.Maroon : Color.LightGray);
		color2 = ((gclass33_0.genum0_0 == GEnum0.Error) ? Color.Yellow : Color.Black);
		drawItemEventArgs_0.Graphics.FillRectangle(new SolidBrush(color), drawItemEventArgs_0.Bounds.Left + num, drawItemEventArgs_0.Bounds.Top, 60, 16);
		drawItemEventArgs_0.Graphics.DrawString(gclass33_0.string_2, font_0, new SolidBrush(color2), drawItemEventArgs_0.Bounds.Left + num, drawItemEventArgs_0.Bounds.Top);
		num += 65;
		color = ((gclass33_0.genum0_0 == GEnum0.Error) ? Color.Maroon : Color.White);
		color2 = ((gclass33_0.genum0_0 == GEnum0.Error) ? Color.Yellow : Color.Black);
		string s2 = gclass33_0.string_3.Replace('\n', ' ');
		SizeF sizeF = drawItemEventArgs_0.Graphics.MeasureString(s2, font_0);
		drawItemEventArgs_0.Graphics.FillRectangle(new SolidBrush(color), drawItemEventArgs_0.Bounds.Left + num - 10, drawItemEventArgs_0.Bounds.Top, sizeF.Width + 20f, 16f);
		drawItemEventArgs_0.Graphics.DrawString(s2, font_0, new SolidBrush(color2), drawItemEventArgs_0.Bounds.Left + num - 4, drawItemEventArgs_0.Bounds.Top);
		drawItemEventArgs_0.DrawFocusRectangle();
	}

	protected override void OnDrawItem(DrawItemEventArgs e)
	{
		try
		{
			if (e.Index >= 0)
			{
				e.DrawBackground();
				method_0(e, (GClass33)Items[e.Index]);
			}
		}
		catch (Exception ex)
		{
			Class162.smethod_2(Class84.smethod_0(-994274603), ex.Message, ex);
		}
	}

	protected override void OnMeasureItem(MeasureItemEventArgs e)
	{
		e.ItemHeight = 16;
		base.OnMeasureItem(e);
	}
}
