using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public sealed class GForm17 : RibbonForm
{
	private sealed class Class236 : Class235
	{
		private readonly GForm17 gform17_0;

		public Class236(GForm17 gform17_1)
		{
			gform17_0 = gform17_1;
		}

		public override void vmethod_0(object object_0)
		{
			if (gform17_0.InvokeRequired)
			{
				GDelegate14 method = vmethod_0;
				gform17_0.Invoke(method, object_0);
			}
			else
			{
				gform17_0.method_2(bool_2: true, object_0.ToString());
			}
		}

		public override void vmethod_1(object object_0)
		{
			if (gform17_0.InvokeRequired)
			{
				GDelegate14 method = vmethod_1;
				gform17_0.Invoke(method, object_0);
			}
			else
			{
				gform17_0.method_2(bool_2: false, object_0.ToString());
			}
		}
	}

	private sealed class Class296 : GClass48
	{
		private readonly GForm3 gform3_0;

		public Class296(GForm3 gform3_1)
		{
			gform3_0 = gform3_1;
		}

		public override void vmethod_0()
		{
			gform3_0.method_12();
		}

		public override void vmethod_1()
		{
			gform3_0.method_13();
		}
	}

	private GClass5 gclass5_0;

	private GForm3 gform3_0;

	private GForm12 gform12_0;

	private GForm35 gform35_0;

	private GForm28 gform28_0;

	private GForm22 gform22_0;

	private GForm23 gform23_0;

	private GForm33 gform33_0;

	private GForm37 gform37_0;

	private GForm32 gform32_0;

	private GForm29 gform29_0;

	private GForm14 gform14_0;

	private GForm8 gform8_0;

	private GForm9 gform9_0;

	private GForm19 gform19_0;

	private GForm20 gform20_0;

	private GForm13 gform13_0;

	private GForm25 gform25_0;

	private GForm15 gform15_0;

	private GForm18 gform18_0;

	private GForm10 gform10_0;

	private GForm34 gform34_0;

	private GForm31 gform31_0;

	private bool bool_0;

	private bool bool_1;

	private IContainer icontainer_0;

	private Ribbon ribbon_0;

	private StatusStrip statusStrip_0;

	private RibbonTab ribbonTab_0;

	private RibbonPanel ribbonPanel_0;

	private RibbonButton ribbonButton_0;

	private RibbonPanel ribbonPanel_1;

	private RibbonButton ribbonButton_1;

	private RibbonButton ribbonButton_2;

	private RibbonTab ribbonTab_1;

	private RibbonButton ribbonButton_3;

	private RibbonPanel ribbonPanel_2;

	private RibbonButton ribbonButton_4;

	private RibbonButton ribbonButton_5;

	private RibbonButton ribbonButton_6;

	private RibbonButton ribbonButton_7;

	private RibbonPanel ribbonPanel_3;

	private RibbonButton ribbonButton_8;

	private RibbonButton ribbonButton_9;

	private ToolStripStatusLabel toolStripStatusLabel_0;

	private ToolStripStatusLabel toolStripStatusLabel_1;

	private ToolStripStatusLabel toolStripStatusLabel_2;

	private ToolStripStatusLabel toolStripStatusLabel_3;

	private ToolStripStatusLabel toolStripStatusLabel_4;

	private RibbonOrbMenuItem ribbonOrbMenuItem_0;

	private RibbonOrbMenuItem ribbonOrbMenuItem_1;

	private RibbonTab ribbonTab_2;

	private RibbonPanel ribbonPanel_4;

	private RibbonButton ribbonButton_10;

	private RibbonButton ribbonButton_11;

	private RibbonPanel ribbonPanel_5;

	private RibbonButton ribbonButton_12;

	private ToolStripStatusLabel toolStripStatusLabel_5;

	private ToolStripStatusLabel toolStripStatusLabel_6;

	private RibbonPanel ribbonPanel_6;

	private RibbonButton ribbonButton_13;

	private RibbonButton ribbonButton_14;

	private RibbonPanel ribbonPanel_7;

	private RibbonButton ribbonButton_15;

	private RibbonButton ribbonButton_16;

	private RibbonPanel ribbonPanel_8;

	private RibbonButton ribbonButton_17;

	private RibbonButton ribbonButton_18;

	private RibbonButton ribbonButton_19;

	private RibbonButton ribbonButton_20;

	private ToolStripStatusLabel toolStripStatusLabel_7;

	private ToolStripStatusLabel toolStripStatusLabel_8;

	private ToolStripStatusLabel toolStripStatusLabel_9;

	private NotifyIcon notifyIcon_0;

	private RibbonButton ribbonButton_21;

	private RibbonButton ribbonButton_22;

	private ToolStripStatusLabel toolStripStatusLabel_10;

	private ToolStripStatusLabel toolStripStatusLabel_11;

	private ToolStripStatusLabel toolStripStatusLabel_12;

	private ToolStripStatusLabel toolStripStatusLabel_13;

	private RibbonButton ribbonButton_23;

	public GForm17()
	{
		method_28();
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
	}

	public GClass5 method_0()
	{
		return gclass5_0;
	}

	private void method_1(GClass5 gclass5_1)
	{
		gclass5_0 = gclass5_1;
	}

	private void GForm17_Load(object sender, EventArgs e)
	{
		try
		{
			Class205.smethod_0();
			method_22();
			Class224.Class232.smethod_1();
			smethod_0();
			if (smethod_1())
			{
				bool_0 = true;
				Class355.smethod_2(Class84.smethod_0(-994212364));
				Close();
			}
			else
			{
				method_1(new GClass5(this));
				new Class315(Class224.Class228.string_0, Class224.Class228.string_1, Class224.Class228.string_2, Class224.Class228.string_3, new Class236(this)).method_0();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private static void smethod_0()
	{
		try
		{
			Class224.Class234.string_0 = Class242.smethod_0(Class224.Class234.int_0, Class242.point_0);
			Class224.Class234.string_1 = Class242.smethod_0(Class224.Class234.int_1, Class242.point_1);
		}
		catch (Exception ex)
		{
			Class162.smethod_2(Class84.smethod_0(-994212264), ex.Message, ex);
		}
	}

	public void method_2(bool bool_2, string string_0)
	{
		if (!bool_2)
		{
			Class348.Class350.bool_0 = false;
			return;
		}
		Class348.Class350.bool_0 = true;
		Class348.Class350.string_0 = Class190.smethod_7();
		Class348.Class350.dateTime_0 = Class190.smethod_10();
		Class224.Class225.smethod_1();
		Class224.Class225.smethod_3();
		Class316.smethod_5();
		method_6();
	}

	private static bool smethod_1()
	{
		Process currentProcess = Process.GetCurrentProcess();
		Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
		int num = 0;
		while (true)
		{
			if (num < processesByName.Length)
			{
				if (processesByName[num].Id != currentProcess.Id)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public void method_3(string string_0)
	{
		gform3_0.method_2(GEnum0.Info, string.Empty, Class84.smethod_0(-994212232), string_0);
	}

	private void method_4()
	{
		try
		{
			if (gform3_0 == null || gform3_0.IsDisposed)
			{
				gform3_0 = new GForm3(this)
				{
					MdiParent = this
				};
			}
			gform3_0.Show();
			gform3_0.Activate();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_5()
	{
		try
		{
			if (gform12_0 == null || gform12_0.IsDisposed)
			{
				gform12_0 = new GForm12(this)
				{
					MdiParent = this
				};
			}
			gform12_0.Show();
			gform12_0.Activate();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void GForm17_Shown(object sender, EventArgs e)
	{
	}

	private void method_6()
	{
		if (!Class224.Class226.bool_0)
		{
			new GForm4(this).ShowDialog();
		}
		else if (Class348.Class352.string_0.Trim().Length != 0 && Class348.Class352.string_5.Trim().Length != 0)
		{
			if (!method_7())
			{
				new GForm4(this).ShowDialog();
				return;
			}
			method_5();
			method_4();
			gform3_0.method_3();
		}
	}

	private bool method_7()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string format = Class84.smethod_0(-994261060);
			format = string.Format(format, Class224.Class226.string_2);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = format
			};
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				return false;
			}
			format = Class84.smethod_0(-994299378);
			mySqlCommand.CommandText = format;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			List<Tuple<int, string>> list = new List<Tuple<int, string>>();
			while (mySqlDataReader.Read())
			{
				list.Add(new Tuple<int, string>(Convert.ToInt32(mySqlDataReader[0]), Convert.ToString(mySqlDataReader[1])));
			}
			mySqlDataReader.Close();
			method_0().method_43(0, Class84.smethod_0(-994299758), Class84.smethod_0(-994299211), 0, Class224.Class226.string_2, list);
			Class348.Class351.bool_0 = false;
			method_16(Class84.smethod_0(-994212237));
			return true;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return false;
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	public void method_8(int int_0, int int_1)
	{
		if (gform3_0 != null && !gform3_0.IsDisposed)
		{
			gform3_0.method_1(int_0, int_1);
		}
	}

	public void method_9(GEnum0 genum0_0, string string_0, string string_1)
	{
		if (gform3_0 != null && !gform3_0.IsDisposed)
		{
			gform3_0.method_2(genum0_0, string.Empty, string_0, string_1);
		}
	}

	public void method_10(GEnum0 genum0_0, string string_0, string string_1, string string_2)
	{
		if (gform3_0 != null && !gform3_0.IsDisposed)
		{
			gform3_0.method_2(genum0_0, string_0, string_1, string_2);
		}
	}

	public void method_11(GEnum0 genum0_0, string string_0, string string_1)
	{
		if (gform12_0 != null && !gform12_0.IsDisposed)
		{
			gform12_0.method_0(genum0_0, string.Empty, string_0, string_1);
		}
	}

	public void method_12()
	{
		method_16(Class84.smethod_0(-994212249));
		method_15();
		Class348.Class351.bool_0 = true;
	}

	public void method_13()
	{
	}

	public void method_14()
	{
	}

	private void method_15()
	{
		ribbonButton_0.Enabled = true;
		ribbonButton_22.Enabled = true;
		ribbonButton_1.Enabled = true;
		ribbonButton_3.Enabled = true;
		ribbonButton_13.Enabled = true;
		ribbonButton_14.Enabled = true;
		ribbonButton_10.Enabled = true;
		ribbonButton_11.Enabled = true;
		ribbonButton_12.Enabled = true;
		ribbonButton_15.Enabled = true;
		ribbonButton_16.Enabled = true;
		ribbonButton_4.Enabled = true;
		ribbonButton_5.Enabled = true;
		ribbonButton_6.Enabled = true;
		ribbonButton_7.Enabled = true;
		ribbonButton_23.Enabled = true;
		ribbonButton_18.Enabled = true;
		ribbonButton_17.Enabled = true;
		ribbonButton_20.Enabled = true;
		ribbonButton_19.Enabled = true;
		if (method_0().gclass6_0.method_6() == 2)
		{
			ribbonButton_0.Enabled = false;
			ribbonButton_22.Enabled = false;
			ribbonButton_1.Enabled = false;
			ribbonButton_3.Enabled = false;
			ribbonButton_12.Enabled = false;
			ribbonButton_15.Enabled = false;
			ribbonButton_16.Enabled = false;
			ribbonButton_4.Enabled = false;
			ribbonButton_5.Enabled = false;
			ribbonButton_7.Enabled = false;
			ribbonButton_23.Enabled = false;
			ribbonButton_18.Enabled = false;
			ribbonButton_17.Enabled = false;
			ribbonButton_20.Enabled = false;
			ribbonButton_19.Enabled = false;
		}
		else if (method_0().gclass6_0.method_6() == 1)
		{
			ribbonButton_5.Enabled = false;
			ribbonButton_7.Enabled = false;
			ribbonButton_23.Enabled = false;
			method_5();
			method_4();
		}
		else if (method_0().gclass6_0.method_6() == 0)
		{
			method_5();
			method_4();
		}
	}

	public void method_16(string string_0)
	{
		if (!(string_0 == Class84.smethod_0(-994212237)))
		{
			if (string_0 == Class84.smethod_0(-994212249))
			{
				toolStripStatusLabel_4.Text = Class84.smethod_0(-994212142) + method_0().gclass6_0.method_4();
				toolStripStatusLabel_12.Text = Class84.smethod_0(-994212219) + Class348.Class352.smethod_6();
				toolStripStatusLabel_6.Text = Class84.smethod_0(-994212171) + Class348.Class352.string_1;
			}
			return;
		}
		ribbonButton_0.Enabled = true;
		ribbonButton_22.Enabled = false;
		ribbonButton_1.Enabled = false;
		ribbonButton_3.Enabled = false;
		ribbonButton_13.Enabled = false;
		ribbonButton_14.Enabled = false;
		ribbonButton_10.Enabled = false;
		ribbonButton_11.Enabled = false;
		ribbonButton_12.Enabled = false;
		ribbonButton_15.Enabled = false;
		ribbonButton_16.Enabled = false;
		ribbonButton_5.Enabled = false;
		ribbonButton_6.Enabled = false;
		ribbonButton_7.Enabled = false;
		ribbonButton_23.Enabled = false;
		ribbonButton_18.Enabled = false;
		ribbonButton_17.Enabled = false;
		ribbonButton_20.Enabled = false;
		ribbonButton_19.Enabled = false;
		toolStripStatusLabel_4.Text = Class84.smethod_0(-994212201);
		toolStripStatusLabel_12.Text = Class84.smethod_0(-994212219) + Class348.Class352.smethod_6();
		toolStripStatusLabel_6.Text = Class84.smethod_0(-994212171) + Class348.Class352.string_1;
		toolStripStatusLabel_9.Text = Class84.smethod_0(-994212187) + Class348.Class352.string_0;
	}

	public void method_17()
	{
		method_16(Class84.smethod_0(-994212145));
		method_0().vmethod_0(null);
		if (gform3_0 != null && !gform3_0.IsDisposed)
		{
			gform3_0.method_0(Class84.smethod_0(-994310698));
		}
	}

	public void method_18()
	{
		try
		{
			method_10(GEnum0.Error, string.Empty, string.Empty, string.Format(Class84.smethod_0(-994212109), Class224.Class226.int_16));
			new GClass10(Class224.Class226.int_16, method_20, this).method_0();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_19()
	{
		try
		{
			if (gform3_0 != null && !gform3_0.IsDisposed)
			{
				gform3_0.method_11();
				new GClass10(Class224.Class226.int_16, method_20, this).method_0();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_20()
	{
		try
		{
			if (gform3_0 != null && !gform3_0.IsDisposed)
			{
				gform3_0.method_3();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_21()
	{
		if (gform3_0 != null && !gform3_0.IsDisposed)
		{
			gform3_0.method_9();
		}
	}

	private void ribbonButton_1_Click(object sender, EventArgs e)
	{
		try
		{
			if (gform35_0 == null || gform35_0.IsDisposed)
			{
				gform35_0 = new GForm35(this)
				{
					MdiParent = this
				};
			}
			gform35_0.Show();
			gform35_0.Activate();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void ribbonButton_3_Click(object sender, EventArgs e)
	{
		try
		{
			if (gform28_0 == null || gform28_0.IsDisposed)
			{
				gform28_0 = new GForm28(this)
				{
					MdiParent = this
				};
			}
			gform28_0.Show();
			gform28_0.Activate();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public void method_22()
	{
		try
		{
			Text = Class224.Class227.smethod_0();
			toolStripStatusLabel_0.Text = Class84.smethod_0(-994212085) + Class224.Class228.string_2 + Class84.smethod_0(-994212034) + Class224.Class228.string_0 + Class84.smethod_0(-994263069) + Class224.Class228.string_1;
			toolStripStatusLabel_11.Text = string.Format(Class84.smethod_0(-994212042), Class224.Class229.string_0, Class224.Class229.int_0);
			toolStripStatusLabel_2.Text = Class84.smethod_0(-994212004) + Class224.Class227.string_1 + Class84.smethod_0(-994272055) + Class224.Class227.string_3 + Class84.smethod_0(-994273716) + Class224.Class227.string_2;
			toolStripStatusLabel_4.Text = Class84.smethod_0(-994212142) + ((method_0()?.gclass6_0 == null) ? Class84.smethod_0(-994278690) : method_0().gclass6_0.method_4());
			toolStripStatusLabel_12.Text = Class84.smethod_0(-994212219) + Class348.Class352.smethod_6();
			toolStripStatusLabel_6.Text = Class84.smethod_0(-994212171) + Class348.Class352.string_1;
			toolStripStatusLabel_9.Text = Class84.smethod_0(-994212187) + Class348.Class352.string_0;
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void ribbonButton_4_Click(object sender, EventArgs e)
	{
		try
		{
			if (gform22_0 == null || gform22_0.IsDisposed)
			{
				gform22_0 = new GForm22(this)
				{
					MdiParent = this
				};
			}
			gform22_0.Show();
			gform22_0.method_1();
			gform22_0.Activate();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void ribbonButton_7_Click(object sender, EventArgs e)
	{
		try
		{
			if (gform23_0 == null || gform23_0.IsDisposed)
			{
				gform23_0 = new GForm23(this)
				{
					MdiParent = this
				};
			}
			gform23_0.Show();
			gform23_0.Activate();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void ribbonButton_5_Click(object sender, EventArgs e)
	{
		try
		{
			if (gform37_0 == null || gform37_0.IsDisposed)
			{
				gform37_0 = new GForm37(this)
				{
					MdiParent = this
				};
			}
			gform37_0.Show();
			gform37_0.method_0();
			gform37_0.Activate();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void ribbonOrbMenuItem_0_Click(object sender, EventArgs e)
	{
		if (!Class348.Class351.bool_0)
		{
			new GForm4(this).ShowDialog();
		}
	}

	private void ribbonOrbMenuItem_1_Click(object sender, EventArgs e)
	{
		if (Class348.Class351.bool_0 && Class355.smethod_1(Class84.smethod_0(-994212022)) != DialogResult.Cancel)
		{
			Class348.Class351.bool_0 = false;
			method_16(Class84.smethod_0(-994212237));
			method_23();
		}
	}

	private void method_23()
	{
		try
		{
			Form[] mdiChildren = MdiChildren;
			foreach (Form form in mdiChildren)
			{
				if (form == gform3_0)
				{
					if (Class348.Class349.bool_0)
					{
						continue;
					}
					form.Close();
				}
				form.Close();
				form.Dispose();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void ribbonButton_8_Click(object sender, EventArgs e)
	{
		try
		{
			if (gform32_0 == null || gform32_0.IsDisposed)
			{
				gform32_0 = new GForm32
				{
					MdiParent = this
				};
			}
			gform32_0.Show();
			gform32_0.Activate();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void ribbonButton_9_Click(object sender, EventArgs e)
	{
		try
		{
			if (gform29_0 == null || gform29_0.IsDisposed)
			{
				gform29_0 = new GForm29
				{
					MdiParent = this
				};
			}
			gform29_0.Show();
			gform29_0.Activate();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void ribbonButton_10_Click(object sender, EventArgs e)
	{
		try
		{
			if (gform14_0 == null || gform14_0.IsDisposed)
			{
				gform14_0 = new GForm14(this)
				{
					MdiParent = this
				};
			}
			gform14_0.Show();
			gform14_0.Activate();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void ribbonButton_11_Click(object sender, EventArgs e)
	{
		if (!Class348.Class351.bool_0)
		{
			return;
		}
		if (Class348.Class352.string_0.Trim().Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994278342));
			return;
		}
		try
		{
			if (gform8_0 == null || gform8_0.IsDisposed)
			{
				gform8_0 = new GForm8(this)
				{
					MdiParent = this
				};
			}
			gform8_0.Show();
			gform8_0.Activate();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void ribbonButton_12_Click(object sender, EventArgs e)
	{
		if (!Class348.Class351.bool_0)
		{
			return;
		}
		if (Class348.Class352.string_0.Trim().Length == 0)
		{
			Class355.smethod_0(Class84.smethod_0(-994278342));
			return;
		}
		try
		{
			if (gform9_0 == null || gform9_0.IsDisposed)
			{
				gform9_0 = new GForm9(this)
				{
					MdiParent = this
				};
			}
			gform9_0.Show();
			gform9_0.Activate();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void ribbonButton_6_Click(object sender, EventArgs e)
	{
		if (gform19_0 == null || gform19_0.IsDisposed)
		{
			gform19_0 = new GForm19(this, method_0())
			{
				MdiParent = this
			};
		}
		gform19_0.method_3();
		gform19_0.Show();
		gform19_0.Activate();
	}

	public void method_24()
	{
		toolStripStatusLabel_12.Text = Class84.smethod_0(-994212219) + Class348.Class352.smethod_6();
		toolStripStatusLabel_6.Text = Class84.smethod_0(-994212171) + Class348.Class352.string_1;
		toolStripStatusLabel_9.Text = Class84.smethod_0(-994212187) + Class348.Class352.string_0;
	}

	public void method_25()
	{
		if (InvokeRequired)
		{
			GDelegate9 method = method_25;
			Invoke(method);
		}
		else
		{
			Class348.Class352.smethod_4();
			method_24();
		}
	}

	private void ribbonButton_0_Click(object sender, EventArgs e)
	{
		method_4();
	}

	private void ribbonButton_13_Click(object sender, EventArgs e)
	{
		if (gform20_0 == null || gform20_0.IsDisposed)
		{
			gform20_0 = new GForm20(this, method_0())
			{
				MdiParent = this
			};
		}
		gform20_0.Show();
		gform20_0.Activate();
	}

	private void ribbonButton_14_Click(object sender, EventArgs e)
	{
		if (gform13_0 == null || gform13_0.IsDisposed)
		{
			gform13_0 = new GForm13(this, method_0())
			{
				MdiParent = this
			};
		}
		gform13_0.Show();
		gform13_0.Activate();
	}

	private void ribbonButton_15_Click(object sender, EventArgs e)
	{
		if (gform25_0 == null || gform25_0.IsDisposed)
		{
			gform25_0 = new GForm25(this, method_0())
			{
				MdiParent = this
			};
		}
		gform25_0.Show();
		gform25_0.Activate();
	}

	private void ribbonButton_16_Click(object sender, EventArgs e)
	{
		if (gform15_0 == null || gform15_0.IsDisposed)
		{
			gform15_0 = new GForm15(this, method_0())
			{
				MdiParent = this
			};
		}
		gform15_0.Show();
		gform15_0.Activate();
	}

	private void method_26(object sender, EventArgs e)
	{
		if (gform18_0 == null || gform18_0.IsDisposed)
		{
			gform18_0 = new GForm18(this, method_0())
			{
				MdiParent = this
			};
		}
		gform18_0.Show();
		gform18_0.Activate();
	}

	private void ribbonButton_17_Click(object sender, EventArgs e)
	{
		if (gform10_0 == null || gform10_0.IsDisposed)
		{
			gform10_0 = new GForm10(this, method_0())
			{
				MdiParent = this
			};
		}
		gform10_0.Show();
		gform10_0.Activate();
	}

	private void ribbonButton_18_Click(object sender, EventArgs e)
	{
		if (gform18_0 == null || gform18_0.IsDisposed)
		{
			gform18_0 = new GForm18(this, method_0())
			{
				MdiParent = this
			};
		}
		gform18_0.Show();
		gform18_0.Activate();
	}

	protected override void WndProc(ref Message m)
	{
		if (m.Msg == 17)
		{
			bool_1 = true;
		}
		base.WndProc(ref m);
	}

	private void GForm17_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (bool_1)
		{
			try
			{
				method_0().vmethod_0(new Class296(gform3_0));
				return;
			}
			catch (Exception)
			{
				return;
			}
		}
		if (Class348.Class349.bool_0 && !Class348.Class351.bool_0)
		{
			Class355.smethod_2(Class84.smethod_0(-994211976));
			e.Cancel = true;
			return;
		}
		if (!bool_0 && Class355.smethod_1(Class84.smethod_0(-994211889)) == DialogResult.Cancel)
		{
			e.Cancel = true;
			return;
		}
		try
		{
			method_0().vmethod_0(new Class296(gform3_0));
		}
		catch (Exception)
		{
		}
	}

	private void ribbonButton_19_Click(object sender, EventArgs e)
	{
		if (gform34_0 == null || gform34_0.IsDisposed)
		{
			gform34_0 = new GForm34(this)
			{
				MdiParent = this
			};
		}
		gform34_0.Show();
		gform34_0.Activate();
	}

	private void ribbonButton_20_Click(object sender, EventArgs e)
	{
		if (gform31_0 == null || gform31_0.IsDisposed)
		{
			gform31_0 = new GForm31(this)
			{
				MdiParent = this
			};
		}
		gform31_0.Show();
		gform31_0.Activate();
	}

	private void GForm17_Resize(object sender, EventArgs e)
	{
	}

	private void notifyIcon_0_DoubleClick(object sender, EventArgs e)
	{
		Show();
		WindowState = FormWindowState.Normal;
		notifyIcon_0.Visible = false;
	}

	private void ribbonButton_21_Click(object sender, EventArgs e)
	{
		Hide();
		notifyIcon_0.Visible = true;
	}

	private void ribbonButton_22_Click(object sender, EventArgs e)
	{
		method_5();
	}

	private void method_27(object sender, EventArgs e)
	{
	}

	private void ribbonButton_23_Click(object sender, EventArgs e)
	{
		try
		{
			if (gform33_0 == null || gform33_0.IsDisposed)
			{
				gform33_0 = new GForm33(this)
				{
					MdiParent = this
				};
			}
			gform33_0.Show();
			gform33_0.Activate();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_28()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm17));
		statusStrip_0 = new StatusStrip();
		toolStripStatusLabel_0 = new ToolStripStatusLabel();
		toolStripStatusLabel_10 = new ToolStripStatusLabel();
		toolStripStatusLabel_11 = new ToolStripStatusLabel();
		toolStripStatusLabel_1 = new ToolStripStatusLabel();
		toolStripStatusLabel_2 = new ToolStripStatusLabel();
		toolStripStatusLabel_3 = new ToolStripStatusLabel();
		toolStripStatusLabel_4 = new ToolStripStatusLabel();
		toolStripStatusLabel_5 = new ToolStripStatusLabel();
		toolStripStatusLabel_12 = new ToolStripStatusLabel();
		toolStripStatusLabel_13 = new ToolStripStatusLabel();
		toolStripStatusLabel_6 = new ToolStripStatusLabel();
		toolStripStatusLabel_7 = new ToolStripStatusLabel();
		toolStripStatusLabel_8 = new ToolStripStatusLabel();
		toolStripStatusLabel_9 = new ToolStripStatusLabel();
		ribbon_0 = new Ribbon();
		ribbonOrbMenuItem_0 = new RibbonOrbMenuItem();
		ribbonOrbMenuItem_1 = new RibbonOrbMenuItem();
		ribbonButton_21 = new RibbonButton();
		ribbonTab_0 = new RibbonTab();
		ribbonPanel_0 = new RibbonPanel();
		ribbonButton_0 = new RibbonButton();
		ribbonButton_22 = new RibbonButton();
		ribbonButton_18 = new RibbonButton();
		ribbonPanel_1 = new RibbonPanel();
		ribbonButton_1 = new RibbonButton();
		ribbonButton_2 = new RibbonButton();
		ribbonButton_3 = new RibbonButton();
		ribbonButton_20 = new RibbonButton();
		ribbonButton_19 = new RibbonButton();
		ribbonPanel_6 = new RibbonPanel();
		ribbonButton_13 = new RibbonButton();
		ribbonButton_14 = new RibbonButton();
		ribbonPanel_8 = new RibbonPanel();
		ribbonButton_17 = new RibbonButton();
		ribbonTab_2 = new RibbonTab();
		ribbonPanel_4 = new RibbonPanel();
		ribbonButton_10 = new RibbonButton();
		ribbonButton_11 = new RibbonButton();
		ribbonPanel_5 = new RibbonPanel();
		ribbonButton_12 = new RibbonButton();
		ribbonPanel_7 = new RibbonPanel();
		ribbonButton_15 = new RibbonButton();
		ribbonButton_16 = new RibbonButton();
		ribbonTab_1 = new RibbonTab();
		ribbonPanel_2 = new RibbonPanel();
		ribbonButton_4 = new RibbonButton();
		ribbonButton_5 = new RibbonButton();
		ribbonButton_6 = new RibbonButton();
		ribbonButton_7 = new RibbonButton();
		ribbonButton_23 = new RibbonButton();
		ribbonPanel_3 = new RibbonPanel();
		ribbonButton_8 = new RibbonButton();
		ribbonButton_9 = new RibbonButton();
		notifyIcon_0 = new NotifyIcon(icontainer_0);
		statusStrip_0.SuspendLayout();
		SuspendLayout();
		statusStrip_0.Items.AddRange(new ToolStripItem[14]
		{
			toolStripStatusLabel_0, toolStripStatusLabel_10, toolStripStatusLabel_11, toolStripStatusLabel_1, toolStripStatusLabel_2, toolStripStatusLabel_3, toolStripStatusLabel_4, toolStripStatusLabel_5, toolStripStatusLabel_12, toolStripStatusLabel_13,
			toolStripStatusLabel_6, toolStripStatusLabel_7, toolStripStatusLabel_8, toolStripStatusLabel_9
		});
		statusStrip_0.Location = new Point(0, 712);
		statusStrip_0.Name = Class84.smethod_0(-994199531);
		statusStrip_0.Size = new Size(1188, 22);
		statusStrip_0.TabIndex = 1;
		statusStrip_0.Text = Class84.smethod_0(-994263061);
		toolStripStatusLabel_0.Name = Class84.smethod_0(-994199496);
		toolStripStatusLabel_0.Size = new Size(22, 17);
		toolStripStatusLabel_0.Text = Class84.smethod_0(-994199511);
		toolStripStatusLabel_10.Name = Class84.smethod_0(-994199518);
		toolStripStatusLabel_10.Size = new Size(10, 17);
		toolStripStatusLabel_10.Text = Class84.smethod_0(-994263061);
		toolStripStatusLabel_11.Name = Class84.smethod_0(-994199474);
		toolStripStatusLabel_11.Size = new Size(27, 17);
		toolStripStatusLabel_11.Text = Class84.smethod_0(-994199439);
		toolStripStatusLabel_1.Name = Class84.smethod_0(-994199445);
		toolStripStatusLabel_1.Size = new Size(10, 17);
		toolStripStatusLabel_1.Text = Class84.smethod_0(-994263061);
		toolStripStatusLabel_2.Name = Class84.smethod_0(-994199401);
		toolStripStatusLabel_2.Size = new Size(27, 17);
		toolStripStatusLabel_2.Text = Class84.smethod_0(-994199417);
		toolStripStatusLabel_3.Name = Class84.smethod_0(-994199375);
		toolStripStatusLabel_3.Size = new Size(10, 17);
		toolStripStatusLabel_3.Text = Class84.smethod_0(-994263061);
		toolStripStatusLabel_4.Name = Class84.smethod_0(-994199331);
		toolStripStatusLabel_4.Size = new Size(34, 17);
		toolStripStatusLabel_4.Text = Class84.smethod_0(-994199345);
		toolStripStatusLabel_5.Name = Class84.smethod_0(-994199302);
		toolStripStatusLabel_5.Size = new Size(10, 17);
		toolStripStatusLabel_5.Text = Class84.smethod_0(-994263061);
		toolStripStatusLabel_12.Name = Class84.smethod_0(-994199322);
		toolStripStatusLabel_12.Size = new Size(24, 17);
		toolStripStatusLabel_12.Text = Class84.smethod_0(-994199274);
		toolStripStatusLabel_13.Name = Class84.smethod_0(-994199296);
		toolStripStatusLabel_13.Size = new Size(10, 17);
		toolStripStatusLabel_13.Text = Class84.smethod_0(-994263061);
		toolStripStatusLabel_6.Name = Class84.smethod_0(-994199252);
		toolStripStatusLabel_6.Size = new Size(28, 17);
		toolStripStatusLabel_6.Text = Class84.smethod_0(-994199204);
		toolStripStatusLabel_7.Name = Class84.smethod_0(-994199210);
		toolStripStatusLabel_7.Size = new Size(0, 17);
		toolStripStatusLabel_8.Name = Class84.smethod_0(-994199182);
		toolStripStatusLabel_8.Size = new Size(10, 17);
		toolStripStatusLabel_8.Text = Class84.smethod_0(-994263061);
		toolStripStatusLabel_9.Name = Class84.smethod_0(-994199138);
		toolStripStatusLabel_9.Size = new Size(18, 17);
		toolStripStatusLabel_9.Text = Class84.smethod_0(-994199153);
		ribbon_0.Font = new Font(Class84.smethod_0(-994292188), 9f);
		ribbon_0.Location = new Point(0, 0);
		ribbon_0.Minimized = false;
		ribbon_0.Name = Class84.smethod_0(-994199112);
		ribbon_0.OrbDropDown.BorderRoundness = 8;
		ribbon_0.OrbDropDown.Location = new Point(0, 0);
		ribbon_0.OrbDropDown.MenuItems.Add(ribbonOrbMenuItem_0);
		ribbon_0.OrbDropDown.MenuItems.Add(ribbonOrbMenuItem_1);
		ribbon_0.OrbDropDown.Name = string.Empty;
		ribbon_0.OrbDropDown.Size = new Size(527, 160);
		ribbon_0.OrbDropDown.TabIndex = 0;
		ribbon_0.OrbImage = Class309.smethod_55();
		ribbon_0.OrbStyle = RibbonOrbStyle.Office_2013;
		ribbon_0.QuickAcessToolbar.Items.Add(ribbonButton_21);
		ribbon_0.RibbonTabFont = new Font(Class84.smethod_0(-994199114), 9f);
		ribbon_0.Size = new Size(1188, 154);
		ribbon_0.TabIndex = 0;
		ribbon_0.Tabs.Add(ribbonTab_0);
		ribbon_0.Tabs.Add(ribbonTab_2);
		ribbon_0.Tabs.Add(ribbonTab_1);
		ribbon_0.TabsMargin = new Padding(12, 26, 20, 0);
		ribbon_0.Text = Class84.smethod_0(-994199112);
		ribbon_0.ThemeColor = RibbonTheme.Blue;
		ribbonOrbMenuItem_0.DropDownArrowDirection = RibbonArrowDirection.Left;
		ribbonOrbMenuItem_0.Image = Class309.smethod_53();
		ribbonOrbMenuItem_0.SmallImage = Class309.smethod_53();
		ribbonOrbMenuItem_0.Text = Class84.smethod_0(-994299056);
		ribbonOrbMenuItem_0.Click += ribbonOrbMenuItem_0_Click;
		ribbonOrbMenuItem_1.DropDownArrowDirection = RibbonArrowDirection.Left;
		ribbonOrbMenuItem_1.Image = Class309.smethod_62();
		ribbonOrbMenuItem_1.SmallImage = Class309.smethod_62();
		ribbonOrbMenuItem_1.Text = Class84.smethod_0(-994199079);
		ribbonOrbMenuItem_1.Click += ribbonOrbMenuItem_1_Click;
		ribbonButton_21.Image = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994199082));
		ribbonButton_21.MaxSizeMode = RibbonElementSizeMode.Compact;
		ribbonButton_21.SmallImage = Class309.smethod_77();
		ribbonButton_21.Text = Class84.smethod_0(-994199043);
		ribbonButton_21.Click += ribbonButton_21_Click;
		ribbonTab_0.Panels.Add(ribbonPanel_0);
		ribbonTab_0.Panels.Add(ribbonPanel_1);
		ribbonTab_0.Panels.Add(ribbonPanel_6);
		ribbonTab_0.Panels.Add(ribbonPanel_8);
		ribbonTab_0.Text = Class84.smethod_0(-994276257);
		ribbonPanel_0.ButtonMoreEnabled = false;
		ribbonPanel_0.ButtonMoreVisible = false;
		ribbonPanel_0.Items.Add(ribbonButton_0);
		ribbonPanel_0.Items.Add(ribbonButton_22);
		ribbonPanel_0.Items.Add(ribbonButton_18);
		ribbonPanel_0.Text = Class84.smethod_0(-994199064);
		ribbonButton_0.Enabled = false;
		ribbonButton_0.Image = Class309.smethod_61();
		ribbonButton_0.MinimumSize = new Size(120, 0);
		ribbonButton_0.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994199066));
		ribbonButton_0.Text = Class84.smethod_0(-994297421);
		ribbonButton_0.Click += ribbonButton_0_Click;
		ribbonButton_22.Enabled = false;
		ribbonButton_22.Image = Class309.smethod_40();
		ribbonButton_22.MinimumSize = new Size(100, 0);
		ribbonButton_22.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994199035));
		ribbonButton_22.Text = Class84.smethod_0(-994308016);
		ribbonButton_22.Click += ribbonButton_22_Click;
		ribbonButton_18.Enabled = false;
		ribbonButton_18.Image = Class309.smethod_16();
		ribbonButton_18.MinimumSize = new Size(100, 0);
		ribbonButton_18.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994199003));
		ribbonButton_18.Text = Class84.smethod_0(-994198918);
		ribbonButton_18.Click += ribbonButton_18_Click;
		ribbonPanel_1.ButtonMoreEnabled = false;
		ribbonPanel_1.ButtonMoreVisible = false;
		ribbonPanel_1.Items.Add(ribbonButton_1);
		ribbonPanel_1.Items.Add(ribbonButton_2);
		ribbonPanel_1.Items.Add(ribbonButton_3);
		ribbonPanel_1.Items.Add(ribbonButton_20);
		ribbonPanel_1.Items.Add(ribbonButton_19);
		ribbonPanel_1.Text = Class84.smethod_0(-994198929);
		ribbonButton_1.Enabled = false;
		ribbonButton_1.Image = Class309.smethod_6();
		ribbonButton_1.MinimumSize = new Size(100, 0);
		ribbonButton_1.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198895));
		ribbonButton_1.Text = Class84.smethod_0(-994198859);
		ribbonButton_1.Click += ribbonButton_1_Click;
		ribbonButton_2.Enabled = false;
		ribbonButton_2.Image = Class309.smethod_4();
		ribbonButton_2.MinimumSize = new Size(100, 0);
		ribbonButton_2.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198832));
		ribbonButton_2.Text = Class84.smethod_0(-994198794);
		ribbonButton_2.Visible = false;
		ribbonButton_3.Enabled = false;
		ribbonButton_3.Image = Class309.smethod_3();
		ribbonButton_3.MinimumSize = new Size(100, 0);
		ribbonButton_3.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198765));
		ribbonButton_3.Text = Class84.smethod_0(-994198730);
		ribbonButton_3.Click += ribbonButton_3_Click;
		ribbonButton_20.Enabled = false;
		ribbonButton_20.Image = Class309.smethod_36();
		ribbonButton_20.MinimumSize = new Size(100, 0);
		ribbonButton_20.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198690));
		ribbonButton_20.Text = Class84.smethod_0(-994198657);
		ribbonButton_20.Click += ribbonButton_20_Click;
		ribbonButton_19.Enabled = false;
		ribbonButton_19.Image = Class309.smethod_37();
		ribbonButton_19.MinimumSize = new Size(100, 0);
		ribbonButton_19.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198682));
		ribbonButton_19.Text = Class84.smethod_0(-994263448);
		ribbonButton_19.Click += ribbonButton_19_Click;
		ribbonPanel_6.ButtonMoreEnabled = false;
		ribbonPanel_6.ButtonMoreVisible = false;
		ribbonPanel_6.Items.Add(ribbonButton_13);
		ribbonPanel_6.Items.Add(ribbonButton_14);
		ribbonPanel_6.Text = Class84.smethod_0(-994198600);
		ribbonButton_13.Enabled = false;
		ribbonButton_13.Image = Class309.smethod_25();
		ribbonButton_13.MinimumSize = new Size(80, 0);
		ribbonButton_13.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198616));
		ribbonButton_13.Text = Class84.smethod_0(-994198582);
		ribbonButton_13.Click += ribbonButton_13_Click;
		ribbonButton_14.Enabled = false;
		ribbonButton_14.Image = Class309.smethod_23();
		ribbonButton_14.MinimumSize = new Size(80, 0);
		ribbonButton_14.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198585));
		ribbonButton_14.Text = Class84.smethod_0(-994312189);
		ribbonButton_14.Click += ribbonButton_14_Click;
		ribbonPanel_8.ButtonMoreEnabled = false;
		ribbonPanel_8.ButtonMoreVisible = false;
		ribbonPanel_8.Items.Add(ribbonButton_17);
		ribbonPanel_8.Text = Class84.smethod_0(-994198502);
		ribbonButton_17.Enabled = false;
		ribbonButton_17.Image = Class309.smethod_75();
		ribbonButton_17.MinimumSize = new Size(100, 0);
		ribbonButton_17.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198520));
		ribbonButton_17.Text = Class84.smethod_0(-994310834);
		ribbonButton_17.Click += ribbonButton_17_Click;
		ribbonTab_2.Panels.Add(ribbonPanel_4);
		ribbonTab_2.Panels.Add(ribbonPanel_5);
		ribbonTab_2.Panels.Add(ribbonPanel_7);
		ribbonTab_2.Text = Class84.smethod_0(-994198495);
		ribbonPanel_4.ButtonMoreEnabled = false;
		ribbonPanel_4.ButtonMoreVisible = false;
		ribbonPanel_4.Items.Add(ribbonButton_10);
		ribbonPanel_4.Items.Add(ribbonButton_11);
		ribbonPanel_4.Text = Class84.smethod_0(-994256048);
		ribbonButton_10.Enabled = false;
		ribbonButton_10.Image = Class309.smethod_52();
		ribbonButton_10.MinimumSize = new Size(100, 0);
		ribbonButton_10.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198442));
		ribbonButton_10.Text = Class84.smethod_0(-994267971);
		ribbonButton_10.Click += ribbonButton_10_Click;
		ribbonButton_11.Enabled = false;
		ribbonButton_11.Image = Class309.smethod_39();
		ribbonButton_11.MinimumSize = new Size(100, 0);
		ribbonButton_11.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198410));
		ribbonButton_11.Text = Class84.smethod_0(-994270650);
		ribbonButton_11.Click += ribbonButton_11_Click;
		ribbonPanel_5.ButtonMoreEnabled = false;
		ribbonPanel_5.ButtonMoreVisible = false;
		ribbonPanel_5.Items.Add(ribbonButton_12);
		ribbonPanel_5.Text = Class84.smethod_0(-994259573);
		ribbonButton_12.Enabled = false;
		ribbonButton_12.Image = Class309.smethod_38();
		ribbonButton_12.MinimumSize = new Size(100, 0);
		ribbonButton_12.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198391));
		ribbonButton_12.Text = Class84.smethod_0(-994259573);
		ribbonButton_12.Click += ribbonButton_12_Click;
		ribbonPanel_7.ButtonMoreEnabled = false;
		ribbonPanel_7.ButtonMoreVisible = false;
		ribbonPanel_7.Items.Add(ribbonButton_15);
		ribbonPanel_7.Items.Add(ribbonButton_16);
		ribbonPanel_7.Text = Class84.smethod_0(-994198360);
		ribbonButton_15.Enabled = false;
		ribbonButton_15.Image = Class309.smethod_27();
		ribbonButton_15.MinimumSize = new Size(100, 0);
		ribbonButton_15.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198312));
		ribbonButton_15.Text = Class84.smethod_0(-994198329);
		ribbonButton_15.Click += ribbonButton_15_Click;
		ribbonButton_16.Enabled = false;
		ribbonButton_16.Image = Class309.smethod_26();
		ribbonButton_16.MinimumSize = new Size(120, 0);
		ribbonButton_16.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198283));
		ribbonButton_16.Text = Class84.smethod_0(-994261452);
		ribbonButton_16.Click += ribbonButton_16_Click;
		ribbonTab_1.Panels.Add(ribbonPanel_2);
		ribbonTab_1.Panels.Add(ribbonPanel_3);
		ribbonTab_1.Text = Class84.smethod_0(-994198249);
		ribbonPanel_2.ButtonMoreEnabled = false;
		ribbonPanel_2.ButtonMoreVisible = false;
		ribbonPanel_2.Items.Add(ribbonButton_4);
		ribbonPanel_2.Items.Add(ribbonButton_5);
		ribbonPanel_2.Items.Add(ribbonButton_6);
		ribbonPanel_2.Items.Add(ribbonButton_7);
		ribbonPanel_2.Items.Add(ribbonButton_23);
		ribbonPanel_2.Text = Class84.smethod_0(-994198249);
		ribbonButton_4.Image = Class309.smethod_42();
		ribbonButton_4.MinimumSize = new Size(100, 0);
		ribbonButton_4.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198215));
		ribbonButton_4.Text = Class84.smethod_0(-994246860);
		ribbonButton_4.Click += ribbonButton_4_Click;
		ribbonButton_5.Enabled = false;
		ribbonButton_5.Image = Class309.smethod_17();
		ribbonButton_5.MinimumSize = new Size(100, 0);
		ribbonButton_5.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198182));
		ribbonButton_5.Text = Class84.smethod_0(-994276257);
		ribbonButton_5.Click += ribbonButton_5_Click;
		ribbonButton_6.Enabled = false;
		ribbonButton_6.Image = Class309.smethod_54();
		ribbonButton_6.MinimumSize = new Size(100, 0);
		ribbonButton_6.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198150));
		ribbonButton_6.Text = Class84.smethod_0(-994254303);
		ribbonButton_6.Click += ribbonButton_6_Click;
		ribbonButton_7.Enabled = false;
		ribbonButton_7.Image = Class309.smethod_79();
		ribbonButton_7.MinimumSize = new Size(100, 0);
		ribbonButton_7.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198119));
		ribbonButton_7.Text = Class84.smethod_0(-994198087);
		ribbonButton_7.Click += ribbonButton_7_Click;
		ribbonButton_23.Enabled = false;
		ribbonButton_23.Image = Class309.smethod_80();
		ribbonButton_23.MinimumSize = new Size(80, 0);
		ribbonButton_23.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198100));
		ribbonButton_23.Text = Class84.smethod_0(-994251296);
		ribbonButton_23.Click += ribbonButton_23_Click;
		ribbonPanel_3.ButtonMoreEnabled = false;
		ribbonPanel_3.ButtonMoreVisible = false;
		ribbonPanel_3.Items.Add(ribbonButton_8);
		ribbonPanel_3.Items.Add(ribbonButton_9);
		ribbonPanel_3.Text = Class84.smethod_0(-994198360);
		ribbonButton_8.Image = Class309.smethod_71();
		ribbonButton_8.MinimumSize = new Size(100, 0);
		ribbonButton_8.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198067));
		ribbonButton_8.Text = Class84.smethod_0(-994198502);
		ribbonButton_8.Click += ribbonButton_8_Click;
		ribbonButton_9.Image = Class309.smethod_56();
		ribbonButton_9.MinimumSize = new Size(100, 0);
		ribbonButton_9.SmallImage = (Image)componentResourceManager.GetObject(Class84.smethod_0(-994198036));
		ribbonButton_9.Text = Class84.smethod_0(-994198005);
		ribbonButton_9.Click += ribbonButton_9_Click;
		notifyIcon_0.Icon = (Icon)componentResourceManager.GetObject(Class84.smethod_0(-994197959));
		notifyIcon_0.Text = Class84.smethod_0(-994197984);
		notifyIcon_0.Visible = true;
		notifyIcon_0.DoubleClick += notifyIcon_0_DoubleClick;
		AutoScaleDimensions = new SizeF(6f, 13f);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1188, 734);
		Controls.Add(statusStrip_0);
		Controls.Add(ribbon_0);
		Icon = (Icon)componentResourceManager.GetObject(Class84.smethod_0(-994278109));
		IsMdiContainer = true;
		Name = Class84.smethod_0(-994197895);
		StartPosition = FormStartPosition.CenterScreen;
		Text = Class84.smethod_0(-994197912);
		FormClosing += GForm17_FormClosing;
		Load += GForm17_Load;
		Shown += GForm17_Shown;
		Resize += GForm17_Resize;
		statusStrip_0.ResumeLayout(performLayout: false);
		statusStrip_0.PerformLayout();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
