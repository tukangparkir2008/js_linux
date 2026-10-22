using System.Drawing;
using System.Text;
using System.Windows.Forms;

internal sealed class Class193 : DataGridView
{
	public int int_0;

	public string string_0 = string.Empty;

	protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
	{
		base.OnRowPostPaint(e);
		if (RowHeadersVisible)
		{
			int value = int_0 + e.RowIndex + 1;
			int length = RowCount.ToString().Length;
			StringBuilder stringBuilder = new StringBuilder(length);
			stringBuilder.Append(value);
			while (stringBuilder.Length < length)
			{
				stringBuilder.Insert(0, Class84.smethod_0(-994274584));
			}
			if (string_0 != string.Empty)
			{
				stringBuilder.Insert(0, string_0);
			}
			SizeF sizeF = e.Graphics.MeasureString(stringBuilder.ToString(), Font);
			if (RowHeadersWidth < (int)(sizeF.Width + 20f))
			{
				RowHeadersWidth = (int)(sizeF.Width + 20f);
			}
			e.Graphics.DrawString(stringBuilder.ToString(), Font, SystemBrushes.ControlText, e.RowBounds.Location.X + 15, (float)e.RowBounds.Location.Y + ((float)e.RowBounds.Height - sizeF.Height) / 2f);
		}
	}
}
