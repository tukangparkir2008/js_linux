using System;
using System.Drawing;
using System.Windows.Forms;

public sealed class GClass69 : ListBox
{
	private readonly Font font_0 = new Font(Class84.smethod_0(-994273712), 8f);

	private readonly Font font_1 = new Font(Class84.smethod_0(-994273712), 9f, FontStyle.Bold);

	private readonly Font font_2 = new Font(Class84.smethod_0(-994273712), 8f, FontStyle.Italic);

	private readonly Pen pen_0 = new Pen(Color.FromArgb(240, 240, 240));

	public GClass69()
	{
		DrawMode = DrawMode.OwnerDrawVariable;
	}

	protected override void OnDrawItem(DrawItemEventArgs e)
	{
		try
		{
			e.DrawBackground();
			e.DrawFocusRectangle();
			if (e.Index >= 0)
			{
				GClass57 gClass = (GClass57)Items[e.Index];
				if (gClass.image_0 != null)
				{
					e.Graphics.DrawImage(gClass.image_0, e.Bounds.Left, e.Bounds.Top);
				}
				e.Graphics.DrawString(gClass.string_0, font_0, new SolidBrush(Color.Maroon), e.Bounds.Left + 45, e.Bounds.Top);
				float num = e.Graphics.MeasureString(gClass.string_0, font_0).Height;
				e.Graphics.DrawString(gClass.string_1, font_1, new SolidBrush(Color.Black), e.Bounds.Left + 45, (float)e.Bounds.Top + num);
				num += e.Graphics.MeasureString(gClass.string_1, font_1).Height;
				string s = gClass.string_2 + Class84.smethod_0(-994273716) + gClass.string_3;
				e.Graphics.DrawString(s, font_2, new SolidBrush(Color.DimGray), e.Bounds.Left + 45, (float)e.Bounds.Top + num);
				num += e.Graphics.MeasureString(s, font_2).Height;
				e.Graphics.DrawLine(pen_0, 0f, (float)e.Bounds.Top + num - 1f, 420f, (float)e.Bounds.Top + num - 1f);
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994273722), ex.Message, ex);
		}
	}

	protected override void OnMeasureItem(MeasureItemEventArgs e)
	{
		e.ItemHeight = 46;
		base.OnMeasureItem(e);
	}
}
