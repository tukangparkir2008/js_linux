using System;
using System.Drawing;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;

public sealed class GClass56 : ToolTip
{
	protected GClass63 gclass63_0;

	protected string string_0;

	protected GClass55 gclass55_0;

	protected TextRenderingHint textRenderingHint_0;

	private string string_1 = Class84.smethod_0(-994208602);

	private Control control_0;

	private System.Windows.Forms.Timer timer_0;

	private IntPtr intptr_0;

	private bool bool_0 = true;

	private EventHandler<GEventArgs1> eventHandler_0;

	private EventHandler<GEventArgs2> eventHandler_1;

	private EventHandler<GEventArgs0> eventHandler_2;

	private EventHandler<GEventArgs5> eventHandler_3;

	public GClass56()
	{
		OwnerDraw = true;
		gclass63_0 = new GClass63();
		gclass63_0.method_25(bool_1: false);
		gclass63_0.method_27(bool_1: false);
		gclass63_0.method_19(bool_1: true);
		gclass63_0.method_23(bool_1: true);
		gclass63_0.method_8(method_12);
		gclass63_0.method_10(method_13);
		gclass63_0.method_12(method_14);
		Popup += GClass56_Popup;
		Draw += GClass56_Draw;
		Disposed += GClass56_Disposed;
		timer_0 = new System.Windows.Forms.Timer();
		timer_0.Tick += timer_0_Tick;
		timer_0.Interval = 40;
		gclass63_0.method_2(method_15);
	}

	public void method_0(EventHandler<GEventArgs1> eventHandler_4)
	{
		EventHandler<GEventArgs1> eventHandler = eventHandler_0;
		EventHandler<GEventArgs1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs1> value = (EventHandler<GEventArgs1>)Delegate.Combine(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_1(EventHandler<GEventArgs1> eventHandler_4)
	{
		EventHandler<GEventArgs1> eventHandler = eventHandler_0;
		EventHandler<GEventArgs1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs1> value = (EventHandler<GEventArgs1>)Delegate.Remove(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_2(EventHandler<GEventArgs2> eventHandler_4)
	{
		EventHandler<GEventArgs2> eventHandler = eventHandler_1;
		EventHandler<GEventArgs2> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs2> value = (EventHandler<GEventArgs2>)Delegate.Combine(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_3(EventHandler<GEventArgs2> eventHandler_4)
	{
		EventHandler<GEventArgs2> eventHandler = eventHandler_1;
		EventHandler<GEventArgs2> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs2> value = (EventHandler<GEventArgs2>)Delegate.Remove(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_4(EventHandler<GEventArgs0> eventHandler_4)
	{
		EventHandler<GEventArgs0> eventHandler = eventHandler_2;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_5(EventHandler<GEventArgs0> eventHandler_4)
	{
		EventHandler<GEventArgs0> eventHandler = eventHandler_2;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_6(EventHandler<GEventArgs5> eventHandler_4)
	{
		EventHandler<GEventArgs5> eventHandler = eventHandler_3;
		EventHandler<GEventArgs5> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs5> value = (EventHandler<GEventArgs5>)Delegate.Combine(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_7(EventHandler<GEventArgs5> eventHandler_4)
	{
		EventHandler<GEventArgs5> eventHandler = eventHandler_3;
		EventHandler<GEventArgs5> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs5> value = (EventHandler<GEventArgs5>)Delegate.Remove(eventHandler2, eventHandler_4);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public bool method_8()
	{
		return gclass63_0.method_15();
	}

	public void method_9(bool bool_1)
	{
		gclass63_0.method_16(bool_1);
	}

	public TextRenderingHint method_10()
	{
		return textRenderingHint_0;
	}

	public void method_11(TextRenderingHint textRenderingHint_1)
	{
		textRenderingHint_0 = textRenderingHint_1;
	}

	public virtual string vmethod_0()
	{
		return string_0;
	}

	public virtual void vmethod_1(string string_2)
	{
		string_0 = string_2;
		gclass55_0 = GClass15.smethod_2(string_2, bool_0: true);
	}

	public virtual string vmethod_2()
	{
		return string_1;
	}

	public virtual void vmethod_3(string string_2)
	{
		string_1 = string_2;
	}

	public virtual bool vmethod_4()
	{
		return bool_0;
	}

	public virtual void vmethod_5(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public virtual Size vmethod_6()
	{
		return Size.Round(gclass63_0.method_32());
	}

	public virtual void vmethod_7(Size size_0)
	{
		gclass63_0.method_33(size_0);
	}

	protected virtual void vmethod_8(PopupEventArgs popupEventArgs_0)
	{
		string arg = (string.IsNullOrEmpty(string_1) ? null : string.Format(Class84.smethod_0(-994208568), string_1));
		string text = string.Format(Class84.smethod_0(-994208517), arg, GetToolTip(popupEventArgs_0.AssociatedControl));
		gclass63_0.method_39(text, gclass55_0);
		gclass63_0.method_33(vmethod_6());
		using (Graphics graphics = popupEventArgs_0.AssociatedControl.CreateGraphics())
		{
			graphics.TextRenderingHint = textRenderingHint_0;
			gclass63_0.method_45(graphics);
		}
		int width = (int)Math.Ceiling((vmethod_6().Width > 0) ? Math.Min(gclass63_0.method_34().Width, vmethod_6().Width) : gclass63_0.method_34().Width);
		int height = (int)Math.Ceiling((vmethod_6().Height > 0) ? Math.Min(gclass63_0.method_34().Height, vmethod_6().Height) : gclass63_0.method_34().Height);
		popupEventArgs_0.ToolTipSize = new Size(width, height);
		if (bool_0)
		{
			control_0 = popupEventArgs_0.AssociatedControl;
			timer_0.Start();
		}
	}

	protected virtual void vmethod_9(DrawToolTipEventArgs drawToolTipEventArgs_0)
	{
		if (intptr_0 == IntPtr.Zero)
		{
			IntPtr hdc = drawToolTipEventArgs_0.Graphics.GetHdc();
			intptr_0 = Class356.WindowFromDC(hdc);
			drawToolTipEventArgs_0.Graphics.ReleaseHdc(hdc);
			vmethod_10(drawToolTipEventArgs_0.AssociatedControl, drawToolTipEventArgs_0.Bounds.Size);
		}
		drawToolTipEventArgs_0.Graphics.Clear(Color.White);
		drawToolTipEventArgs_0.Graphics.TextRenderingHint = textRenderingHint_0;
		gclass63_0.method_46(drawToolTipEventArgs_0.Graphics);
	}

	protected virtual void vmethod_10(Control control_1, Size size_0)
	{
		Point mousePosition = Control.MousePosition;
		Rectangle workingArea = Screen.FromControl(control_1).WorkingArea;
		if (mousePosition.X + size_0.Width > workingArea.Right)
		{
			mousePosition.X = Math.Max(workingArea.Right - size_0.Width - 5, workingArea.Left + 3);
		}
		if (mousePosition.Y + size_0.Height + 20 > workingArea.Bottom)
		{
			mousePosition.Y = Math.Max(workingArea.Bottom - size_0.Height - 20 - 3, workingArea.Top + 2);
		}
		Class356.MoveWindow(intptr_0, mousePosition.X, mousePosition.Y + 20, size_0.Width, size_0.Height, bool_0: false);
	}

	protected virtual void vmethod_11(GEventArgs1 geventArgs1_0)
	{
		eventHandler_0?.Invoke(this, geventArgs1_0);
	}

	protected virtual void vmethod_12(GEventArgs2 geventArgs2_0)
	{
		eventHandler_1?.Invoke(this, geventArgs2_0);
	}

	protected virtual void vmethod_13(GEventArgs0 geventArgs0_0)
	{
		eventHandler_2?.Invoke(this, geventArgs0_0);
	}

	protected virtual void vmethod_14(GEventArgs5 geventArgs5_0)
	{
		eventHandler_3?.Invoke(this, geventArgs5_0);
	}

	protected virtual void vmethod_15(EventArgs eventArgs_0)
	{
		try
		{
			IntPtr intPtr = intptr_0;
			if (intPtr != IntPtr.Zero && Class356.IsWindowVisible(intPtr))
			{
				Point mousePosition = Control.MousePosition;
				MouseButtons mouseButtons = Control.MouseButtons;
				Rectangle rectangle = Class356.smethod_2(intPtr);
				if (rectangle.Contains(mousePosition))
				{
					gclass63_0.method_50(control_0, new MouseEventArgs(mouseButtons, 0, mousePosition.X - rectangle.X, mousePosition.Y - rectangle.Y, 0));
				}
				return;
			}
			timer_0.Stop();
			intptr_0 = IntPtr.Zero;
			Point mousePosition2 = Control.MousePosition;
			MouseButtons mouseButtons2 = Control.MouseButtons;
			Rectangle rectangle2 = Class356.smethod_2(intPtr);
			if (rectangle2.Contains(mousePosition2) && mouseButtons2 == MouseButtons.Left)
			{
				MouseEventArgs mouseEventArgs_ = new MouseEventArgs(mouseButtons2, 1, mousePosition2.X - rectangle2.X, mousePosition2.Y - rectangle2.Y, 0);
				gclass63_0.method_47(control_0, mouseEventArgs_);
				gclass63_0.method_48(control_0, mouseEventArgs_);
			}
		}
		catch (Exception exception_)
		{
			method_12(this, new GEventArgs2(GEnum7.General, Class84.smethod_0(-994208541), exception_));
		}
	}

	protected virtual void vmethod_16(EventArgs eventArgs_0)
	{
		Popup -= GClass56_Popup;
		Draw -= GClass56_Draw;
		Disposed -= GClass56_Disposed;
		if (gclass63_0 != null)
		{
			gclass63_0.method_9(method_12);
			gclass63_0.method_11(method_13);
			gclass63_0.method_13(method_14);
			gclass63_0.Dispose();
			gclass63_0 = null;
		}
		if (timer_0 != null)
		{
			timer_0.Dispose();
			timer_0 = null;
			if (gclass63_0 != null)
			{
				gclass63_0.method_3(method_15);
			}
		}
	}

	private void GClass56_Popup(object sender, PopupEventArgs e)
	{
		vmethod_8(e);
	}

	private void GClass56_Draw(object sender, DrawToolTipEventArgs e)
	{
		vmethod_9(e);
	}

	private void method_12(object sender, GEventArgs2 e)
	{
		vmethod_12(e);
	}

	private void method_13(object sender, GEventArgs0 e)
	{
		vmethod_13(e);
	}

	private void method_14(object sender, GEventArgs5 e)
	{
		vmethod_14(e);
	}

	private void method_15(object sender, GEventArgs1 e)
	{
		vmethod_11(e);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		vmethod_15(e);
	}

	private void GClass56_Disposed(object sender, EventArgs e)
	{
		vmethod_16(e);
	}
}
