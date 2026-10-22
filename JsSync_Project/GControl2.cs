using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;

public sealed class GControl2 : Control
{
	private sealed class Class290
	{
		public GControl2 gcontrol2_0;

		public GEventArgs2 geventArgs2_0;

		internal void method_0()
		{
			gcontrol2_0.vmethod_19(geventArgs2_0);
		}
	}

	private sealed class Class291
	{
		public GControl2 gcontrol2_0;

		public GEventArgs4 geventArgs4_0;

		internal void method_0()
		{
			gcontrol2_0.vmethod_22(geventArgs4_0);
		}
	}

	protected GClass63 gclass63_0;

	protected BorderStyle borderStyle_0;

	protected string string_0;

	protected GClass55 gclass55_0;

	protected string string_1;

	protected bool bool_0;

	protected bool bool_1;

	protected TextRenderingHint textRenderingHint_0;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler<GEventArgs1> eventHandler_2;

	private EventHandler<GEventArgs2> eventHandler_3;

	private EventHandler<GEventArgs0> eventHandler_4;

	private EventHandler<GEventArgs5> eventHandler_5;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Description("Automatically sets the size of the label by content size.")]
	[Browsable(true)]
	[DefaultValue(true)]
	public override bool AutoSize
	{
		get
		{
			return base.AutoSize;
		}
		set
		{
			base.AutoSize = value;
			if (value)
			{
				bool_0 = false;
				PerformLayout();
				Invalidate();
			}
		}
	}

	[Description("If AutoSize or AutoSizeHeightOnly is set this will restrict the max size of the control (0 is not restricted)")]
	public override Size MaximumSize
	{
		get
		{
			return base.MaximumSize;
		}
		set
		{
			base.MaximumSize = value;
			if (gclass63_0 != null)
			{
				gclass63_0.method_33(value);
				PerformLayout();
				Invalidate();
			}
		}
	}

	[Description("If AutoSize or AutoSizeHeightOnly is set this will restrict the min size of the control (0 is not restricted)")]
	public override Size MinimumSize
	{
		get
		{
			return base.MinimumSize;
		}
		set
		{
			base.MinimumSize = value;
		}
	}

	[Description("Sets the html of this control.")]
	public override string Text
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
			base.Text = value;
			if (!IsDisposed)
			{
				gclass63_0.method_39(string_1, gclass55_0);
				PerformLayout();
				Invalidate();
			}
		}
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			switch (borderStyle_0)
			{
			case BorderStyle.Fixed3D:
				createParams.ExStyle |= 512;
				break;
			case BorderStyle.FixedSingle:
				createParams.Style |= 8388608;
				break;
			}
			return createParams;
		}
	}

	[Browsable(false)]
	public override Font Font
	{
		get
		{
			return base.Font;
		}
		set
		{
			base.Font = value;
		}
	}

	[Browsable(false)]
	public override Color ForeColor
	{
		get
		{
			return base.ForeColor;
		}
		set
		{
			base.ForeColor = value;
		}
	}

	[Browsable(false)]
	public override bool AllowDrop
	{
		get
		{
			return base.AllowDrop;
		}
		set
		{
			base.AllowDrop = value;
		}
	}

	[Browsable(false)]
	public override RightToLeft RightToLeft
	{
		get
		{
			return base.RightToLeft;
		}
		set
		{
			base.RightToLeft = value;
		}
	}

	[Browsable(false)]
	public override Cursor Cursor
	{
		get
		{
			return base.Cursor;
		}
		set
		{
			base.Cursor = value;
		}
	}

	public GControl2()
	{
		SuspendLayout();
		AutoSize = true;
		BackColor = SystemColors.Window;
		DoubleBuffered = true;
		SetStyle(ControlStyles.ResizeRedraw, value: true);
		SetStyle(ControlStyles.SupportsTransparentBackColor, value: true);
		SetStyle(ControlStyles.Opaque, value: false);
		gclass63_0 = new GClass63();
		gclass63_0.method_23(bool_1: true);
		gclass63_0.method_33(MaximumSize);
		gclass63_0.method_0(method_19);
		gclass63_0.method_2(method_20);
		gclass63_0.method_8(method_21);
		gclass63_0.method_4(method_24);
		gclass63_0.method_10(method_22);
		gclass63_0.method_12(method_23);
		ResumeLayout(performLayout: false);
	}

	public void method_0(EventHandler eventHandler_6)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_6);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_1(EventHandler eventHandler_6)
	{
		EventHandler eventHandler = eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_6);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_2(EventHandler eventHandler_6)
	{
		EventHandler eventHandler = eventHandler_1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_6);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_3(EventHandler eventHandler_6)
	{
		EventHandler eventHandler = eventHandler_1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_6);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_4(EventHandler<GEventArgs1> eventHandler_6)
	{
		EventHandler<GEventArgs1> eventHandler = eventHandler_2;
		EventHandler<GEventArgs1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs1> value = (EventHandler<GEventArgs1>)Delegate.Combine(eventHandler2, eventHandler_6);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_5(EventHandler<GEventArgs1> eventHandler_6)
	{
		EventHandler<GEventArgs1> eventHandler = eventHandler_2;
		EventHandler<GEventArgs1> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs1> value = (EventHandler<GEventArgs1>)Delegate.Remove(eventHandler2, eventHandler_6);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_6(EventHandler<GEventArgs2> eventHandler_6)
	{
		EventHandler<GEventArgs2> eventHandler = eventHandler_3;
		EventHandler<GEventArgs2> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs2> value = (EventHandler<GEventArgs2>)Delegate.Combine(eventHandler2, eventHandler_6);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_7(EventHandler<GEventArgs2> eventHandler_6)
	{
		EventHandler<GEventArgs2> eventHandler = eventHandler_3;
		EventHandler<GEventArgs2> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs2> value = (EventHandler<GEventArgs2>)Delegate.Remove(eventHandler2, eventHandler_6);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_8(EventHandler<GEventArgs0> eventHandler_6)
	{
		EventHandler<GEventArgs0> eventHandler = eventHandler_4;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Combine(eventHandler2, eventHandler_6);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_9(EventHandler<GEventArgs0> eventHandler_6)
	{
		EventHandler<GEventArgs0> eventHandler = eventHandler_4;
		EventHandler<GEventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs0> value = (EventHandler<GEventArgs0>)Delegate.Remove(eventHandler2, eventHandler_6);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_10(EventHandler<GEventArgs5> eventHandler_6)
	{
		EventHandler<GEventArgs5> eventHandler = eventHandler_5;
		EventHandler<GEventArgs5> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs5> value = (EventHandler<GEventArgs5>)Delegate.Combine(eventHandler2, eventHandler_6);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public void method_11(EventHandler<GEventArgs5> eventHandler_6)
	{
		EventHandler<GEventArgs5> eventHandler = eventHandler_5;
		EventHandler<GEventArgs5> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<GEventArgs5> value = (EventHandler<GEventArgs5>)Delegate.Remove(eventHandler2, eventHandler_6);
			eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public virtual bool vmethod_0()
	{
		return gclass63_0.method_18();
	}

	public virtual void vmethod_1(bool bool_2)
	{
		gclass63_0.method_19(bool_2);
	}

	public bool method_12()
	{
		return gclass63_0.method_15();
	}

	public void method_13(bool bool_2)
	{
		gclass63_0.method_16(bool_2);
	}

	public TextRenderingHint method_14()
	{
		return textRenderingHint_0;
	}

	public void method_15(TextRenderingHint textRenderingHint_1)
	{
		textRenderingHint_0 = textRenderingHint_1;
	}

	public bool method_16()
	{
		return bool_1;
	}

	public void method_17(bool bool_2)
	{
		bool_1 = bool_2;
	}

	public virtual BorderStyle vmethod_2()
	{
		return borderStyle_0;
	}

	public virtual void vmethod_3(BorderStyle borderStyle_1)
	{
		if (vmethod_2() != borderStyle_1)
		{
			borderStyle_0 = borderStyle_1;
			vmethod_16(EventArgs.Empty);
		}
	}

	public virtual bool vmethod_4()
	{
		return gclass63_0.method_24();
	}

	public virtual void vmethod_5(bool bool_2)
	{
		gclass63_0.method_25(bool_2);
	}

	public virtual bool vmethod_6()
	{
		return gclass63_0.method_26();
	}

	public virtual void vmethod_7(bool bool_2)
	{
		gclass63_0.method_27(bool_2);
	}

	public virtual string vmethod_8()
	{
		return string_0;
	}

	public virtual void vmethod_9(string string_2)
	{
		string_0 = string_2;
		gclass55_0 = GClass15.smethod_2(string_2, bool_0: true);
		gclass63_0.method_39(string_1, gclass55_0);
	}

	public virtual bool vmethod_10()
	{
		return bool_0;
	}

	public virtual void vmethod_11(bool bool_2)
	{
		bool_0 = bool_2;
		if (bool_2)
		{
			AutoSize = false;
			PerformLayout();
			Invalidate();
		}
	}

	public virtual string vmethod_12()
	{
		return gclass63_0.method_36();
	}

	public virtual string vmethod_13()
	{
		return gclass63_0.method_37();
	}

	public virtual string vmethod_14()
	{
		if (gclass63_0 == null)
		{
			return null;
		}
		return gclass63_0.method_40((GEnum3)1);
	}

	public virtual RectangleF? vmethod_15(string string_2)
	{
		if (gclass63_0 == null)
		{
			return null;
		}
		return gclass63_0.method_44(string_2);
	}

	public void method_18()
	{
		if (gclass63_0 != null)
		{
			gclass63_0.method_38();
		}
	}

	protected override void OnLayout(LayoutEventArgs e)
	{
		if (gclass63_0 != null)
		{
			Graphics graphics = Class237.smethod_12(this);
			if (graphics != null)
			{
				using (graphics)
				{
					Class149 @class = new Class149(graphics, gclass63_0.method_15());
					try
					{
						GStruct4 gStruct = GClass7.smethod_1(@class, gclass63_0.method_14(), new GStruct4(ClientSize.Width - Padding.Horizontal, ClientSize.Height - Padding.Vertical), new GStruct4(MinimumSize.Width - Padding.Horizontal, MinimumSize.Height - Padding.Vertical), new GStruct4(MaximumSize.Width - Padding.Horizontal, MaximumSize.Height - Padding.Vertical), AutoSize, vmethod_10());
						ClientSize = Class237.smethod_6(new GStruct4(gStruct.method_1() + (double)Padding.Horizontal, gStruct.method_3() + (double)Padding.Vertical));
					}
					finally
					{
						((IDisposable)@class).Dispose();
					}
				}
			}
		}
		base.OnLayout(e);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		base.OnPaint(e);
		if (gclass63_0 != null)
		{
			e.Graphics.TextRenderingHint = textRenderingHint_0;
			gclass63_0.method_31(new PointF(Padding.Left, Padding.Top));
			gclass63_0.method_46(e.Graphics);
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		if (gclass63_0 != null)
		{
			gclass63_0.method_50(this, e);
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		base.OnMouseDown(e);
		if (gclass63_0 != null)
		{
			gclass63_0.method_47(this, e);
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		base.OnMouseLeave(e);
		if (gclass63_0 != null)
		{
			gclass63_0.method_51(this);
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		base.OnMouseUp(e);
		if (gclass63_0 != null)
		{
			gclass63_0.method_48(this, e);
		}
	}

	protected override void OnMouseDoubleClick(MouseEventArgs e)
	{
		base.OnMouseDoubleClick(e);
		if (gclass63_0 != null)
		{
			gclass63_0.method_49(this, e);
		}
	}

	protected virtual void vmethod_16(EventArgs eventArgs_0)
	{
		UpdateStyles();
		eventHandler_0?.Invoke(this, eventArgs_0);
	}

	protected virtual void vmethod_17(EventArgs eventArgs_0)
	{
		eventHandler_1?.Invoke(this, eventArgs_0);
	}

	protected virtual void vmethod_18(GEventArgs1 geventArgs1_0)
	{
		eventHandler_2?.Invoke(this, geventArgs1_0);
	}

	protected virtual void vmethod_19(GEventArgs2 geventArgs2_0)
	{
		eventHandler_3?.Invoke(this, geventArgs2_0);
	}

	protected virtual void vmethod_20(GEventArgs0 geventArgs0_0)
	{
		eventHandler_4?.Invoke(this, geventArgs0_0);
	}

	protected virtual void vmethod_21(GEventArgs5 geventArgs5_0)
	{
		eventHandler_5?.Invoke(this, geventArgs5_0);
	}

	protected virtual void vmethod_22(GEventArgs4 geventArgs4_0)
	{
		if (geventArgs4_0.method_0())
		{
			PerformLayout();
		}
		Invalidate();
	}

	[DebuggerStepThrough]
	protected override void WndProc(ref Message m)
	{
		if (bool_1 && m.Msg == 32 && Cursor == Cursors.Hand)
		{
			try
			{
				Class356.SetCursor(Class356.LoadCursor(0, 32649));
				m.Result = IntPtr.Zero;
				return;
			}
			catch (Exception exception_)
			{
				method_21(this, new GEventArgs2(GEnum7.General, Class84.smethod_0(-994208731), exception_));
			}
		}
		base.WndProc(ref m);
	}

	protected override void Dispose(bool disposing)
	{
		if (gclass63_0 != null)
		{
			gclass63_0.method_1(method_19);
			gclass63_0.method_3(method_20);
			gclass63_0.method_9(method_21);
			gclass63_0.method_5(method_24);
			gclass63_0.method_11(method_22);
			gclass63_0.method_13(method_23);
			gclass63_0.Dispose();
			gclass63_0 = null;
		}
		base.Dispose(disposing);
	}

	private void method_19(object sender, EventArgs e)
	{
		vmethod_17(e);
	}

	private void method_20(object sender, GEventArgs1 e)
	{
		vmethod_18(e);
	}

	private void method_21(object sender, GEventArgs2 e)
	{
		Class290 @class = new Class290();
		@class.gcontrol2_0 = this;
		@class.geventArgs2_0 = e;
		if (InvokeRequired)
		{
			Invoke(new MethodInvoker(@class.method_0));
		}
		else
		{
			vmethod_19(@class.geventArgs2_0);
		}
	}

	private void method_22(object sender, GEventArgs0 e)
	{
		vmethod_20(e);
	}

	private void method_23(object sender, GEventArgs5 e)
	{
		vmethod_21(e);
	}

	private void method_24(object sender, GEventArgs4 e)
	{
		Class291 @class = new Class291();
		@class.gcontrol2_0 = this;
		@class.geventArgs4_0 = e;
		if (InvokeRequired)
		{
			Invoke(new MethodInvoker(@class.method_0));
		}
		else
		{
			vmethod_22(@class.geventArgs4_0);
		}
	}

	public bool method_25()
	{
		return UseWaitCursor;
	}

	public void method_26(bool bool_2)
	{
		UseWaitCursor = bool_2;
	}
}
