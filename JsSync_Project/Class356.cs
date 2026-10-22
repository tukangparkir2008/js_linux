using System;
using System.Drawing;
using System.Runtime.InteropServices;

internal static class Class356
{
	[DllImport("user32.dll")]
	public static extern int SetCursor(int int_0);

	[DllImport("user32.dll")]
	public static extern int LoadCursor(int int_0, int int_1);

	public static IntPtr smethod_0(IntPtr intptr_0, int int_0, int int_1, out IntPtr intptr_1)
	{
		IntPtr intPtr = CreateCompatibleDC(intptr_0);
		SetBkMode(intPtr, 1);
		Struct26 struct26_ = default;
		struct26_.int_0 = Marshal.SizeOf(struct26_);
		struct26_.int_1 = int_0;
		struct26_.int_2 = -int_1;
		struct26_.short_0 = 1;
		struct26_.short_1 = 32;
		struct26_.int_3 = 0;
		intptr_1 = CreateDIBSection(intptr_0, ref struct26_, 0u, out var _, IntPtr.Zero, 0u);
		SelectObject(intPtr, intptr_1);
		return intPtr;
	}

	public static void smethod_1(IntPtr intptr_0, IntPtr intptr_1)
	{
		DeleteObject(intptr_1);
		DeleteDC(intptr_0);
	}

	[DllImport("user32.dll")]
	public static extern bool IsWindowVisible(IntPtr intptr_0);

	[DllImport("user32.dll")]
	public static extern IntPtr WindowFromDC(IntPtr intptr_0);

	[DllImport("User32", SetLastError = true)]
	public static extern int GetWindowRect(IntPtr intptr_0, out Rectangle rectangle_0);

	public static Rectangle smethod_2(IntPtr intptr_0)
	{
		GetWindowRect(intptr_0, out var rectangle_);
		return new Rectangle(rectangle_.Left, rectangle_.Top, rectangle_.Right - rectangle_.Left, rectangle_.Bottom - rectangle_.Top);
	}

	[DllImport("User32.dll")]
	public static extern bool MoveWindow(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3, bool bool_0);

	[DllImport("gdi32.dll")]
	public static extern int SetTextAlign(IntPtr intptr_0, uint uint_0);

	[DllImport("gdi32.dll")]
	public static extern int SetBkMode(IntPtr intptr_0, int int_0);

	[DllImport("gdi32.dll")]
	public static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("gdi32.dll")]
	public static extern uint SetTextColor(IntPtr intptr_0, int int_0);

	[DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
	public static extern bool GetTextMetrics(IntPtr intptr_0, out Struct34 struct34_0);

	[DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
	public static extern int GetTextExtentPoint32W(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0, ref Size size_0);

	[DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
	public static extern bool GetTextExtentExPointW(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0, int int_1, int[] int_2, int[] int_3, ref Size size_0);

	[DllImport("gdi32.dll", CharSet = CharSet.Unicode)]
	public static extern bool TextOutW(IntPtr intptr_0, int int_0, int int_1, [MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_2);

	[DllImport("gdi32.dll")]
	public static extern IntPtr CreateRectRgn(int int_0, int int_1, int int_2, int int_3);

	[DllImport("gdi32.dll")]
	public static extern int GetClipBox(IntPtr intptr_0, out Rectangle rectangle_0);

	[DllImport("gdi32.dll")]
	public static extern int SelectClipRgn(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("gdi32.dll")]
	public static extern bool DeleteObject(IntPtr intptr_0);

	[DllImport("gdi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BitBlt(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3, IntPtr intptr_1, int int_4, int int_5, uint uint_0);

	[DllImport("gdi32.dll")]
	public static extern bool GdiAlphaBlend(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3, IntPtr intptr_1, int int_4, int int_5, int int_6, int int_7, Struct33 struct33_0);

	[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern bool DeleteDC(IntPtr intptr_0);

	[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr CreateCompatibleDC(IntPtr intptr_0);

	[DllImport("gdi32.dll")]
	public static extern IntPtr CreateDIBSection(IntPtr intptr_0, [In] ref Struct26 struct26_0, uint uint_0, out IntPtr intptr_1, IntPtr intptr_2, uint uint_1);
}
