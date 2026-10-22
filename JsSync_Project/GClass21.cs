using System;
using System.Collections.Generic;
using System.Text;

public sealed class GClass21
{
	private bool bool_0;

	private int int_0;

	private string string_0;

	private string string_1;

	private List<(string, string)> list_0 = new List<(string, string)>();

	private int int_1;

	private int int_2;

	private int int_3;

	private bool bool_1;

	private GClass28 gclass28_0 = new GClass28();

	private int int_4;

	public GClass21()
	{
		method_12();
	}

	public GClass21(int int_5, string string_2 = "HTTP/1.1")
	{
		method_13(int_5, string_2);
	}

	public GClass21(int int_5, string string_2, string string_3)
	{
		method_14(int_5, string_2, string_3);
	}

	public bool method_0()
	{
		return gclass28_0.method_3() > 0L;
	}

	public bool method_1()
	{
		return bool_0;
	}

	private void method_2(bool bool_2)
	{
		bool_0 = bool_2;
	}

	public int method_3()
	{
		return int_0;
	}

	private void method_4(int int_5)
	{
		int_0 = int_5;
	}

	public string method_5()
	{
		return string_0;
	}

	public string method_6()
	{
		return string_1;
	}

	public long method_7()
	{
		return list_0.Count;
	}

	public (string, string) method_8(int int_5)
	{
		if (int_5 >= list_0.Count)
		{
			return (string.Empty, string.Empty);
		}
		return list_0[int_5];
	}

	public string method_9()
	{
		return gclass28_0.method_6(int_1, int_2);
	}

	public long method_10()
	{
		return int_3;
	}

	public GClass28 method_11()
	{
		return gclass28_0;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(string.Format(Class84.smethod_0(-994211788), method_3()));
		stringBuilder.AppendLine(Class84.smethod_0(-994211802) + method_5());
		stringBuilder.AppendLine(Class84.smethod_0(-994211764) + method_6());
		stringBuilder.AppendLine(string.Format(Class84.smethod_0(-994211715), method_7()));
		for (int i = 0; i < method_7(); i++)
		{
			(string, string) tuple = method_8(i);
			stringBuilder.AppendLine(tuple.Item1 + Class84.smethod_0(-994207903) + tuple.Item2);
		}
		stringBuilder.AppendLine(string.Format(Class84.smethod_0(-994211744), method_10()));
		stringBuilder.AppendLine(method_9());
		return stringBuilder.ToString();
	}

	public GClass21 method_12()
	{
		method_2(bool_2: false);
		method_4(0);
		string_0 = string.Empty;
		string_1 = string.Empty;
		list_0.Clear();
		int_1 = 0;
		int_2 = 0;
		int_3 = 0;
		bool_1 = false;
		gclass28_0.method_5();
		int_4 = 0;
		return this;
	}

	public GClass21 method_13(int int_5, string string_2)
	{
		method_14(int_5, int_5 switch
		{
			226 => Class84.smethod_0(-994211486), 
			200 => Class84.smethod_0(-994247224), 
			201 => Class84.smethod_0(-994211636), 
			202 => Class84.smethod_0(-994211590), 
			203 => Class84.smethod_0(-994211607), 
			204 => Class84.smethod_0(-994211571), 
			205 => Class84.smethod_0(-994211522), 
			206 => Class84.smethod_0(-994211550), 
			207 => Class84.smethod_0(-994211512), 
			208 => Class84.smethod_0(-994211461), 
			100 => Class84.smethod_0(-994211696), 
			101 => Class84.smethod_0(-994211697), 
			102 => Class84.smethod_0(-994211671), 
			103 => Class84.smethod_0(-994211622), 
			500 => Class84.smethod_0(-994210610), 
			501 => Class84.smethod_0(-994210582), 
			502 => Class84.smethod_0(-994210544), 
			503 => Class84.smethod_0(-994210558), 
			504 => Class84.smethod_0(-994210516), 
			505 => Class84.smethod_0(-994210478), 
			506 => Class84.smethod_0(-994210445), 
			507 => Class84.smethod_0(-994210415), 
			508 => Class84.smethod_0(-994210372), 
			510 => Class84.smethod_0(-994210400), 
			511 => Class84.smethod_0(-994210349), 
			400 => Class84.smethod_0(-994211293), 
			401 => Class84.smethod_0(-994211243), 
			402 => Class84.smethod_0(-994211208), 
			403 => Class84.smethod_0(-994211217), 
			404 => Class84.smethod_0(-994211169), 
			405 => Class84.smethod_0(-994211185), 
			406 => Class84.smethod_0(-994211160), 
			407 => Class84.smethod_0(-994211107), 
			408 => Class84.smethod_0(-994211087), 
			409 => Class84.smethod_0(-994211097), 
			410 => Class84.smethod_0(-994211050), 
			411 => Class84.smethod_0(-994211071), 
			412 => Class84.smethod_0(-994211017), 
			413 => Class84.smethod_0(-994210991), 
			414 => Class84.smethod_0(-994210951), 
			415 => Class84.smethod_0(-994210964), 
			416 => Class84.smethod_0(-994210935), 
			417 => Class84.smethod_0(-994210891), 
			421 => Class84.smethod_0(-994210850), 
			422 => Class84.smethod_0(-994210824), 
			423 => Class84.smethod_0(-994210845), 
			424 => Class84.smethod_0(-994210800), 
			425 => Class84.smethod_0(-994210760), 
			426 => Class84.smethod_0(-994210776), 
			427 => Class84.smethod_0(-994210721), 
			428 => Class84.smethod_0(-994210752), 
			429 => Class84.smethod_0(-994210708), 
			431 => Class84.smethod_0(-994210668), 
			451 => Class84.smethod_0(-994210646), 
			300 => Class84.smethod_0(-994211440), 
			301 => Class84.smethod_0(-994211449), 
			302 => Class84.smethod_0(-994211409), 
			303 => Class84.smethod_0(-994211365), 
			304 => Class84.smethod_0(-994211381), 
			305 => Class84.smethod_0(-994211330), 
			306 => Class84.smethod_0(-994211346), 
			307 => Class84.smethod_0(-994211311), 
			308 => Class84.smethod_0(-994211270), 
			_ => Class84.smethod_0(-994210327), 
		}, string_2);
		return this;
	}

	public GClass21 method_14(int int_5, string string_2, string string_3)
	{
		method_12();
		gclass28_0.method_14(string_3);
		string_1 = string_3;
		gclass28_0.method_14(Class84.smethod_0(-994263061));
		gclass28_0.method_14(int_5.ToString());
		method_4(int_5);
		gclass28_0.method_14(Class84.smethod_0(-994263061));
		gclass28_0.method_14(string_2);
		string_0 = string_2;
		gclass28_0.method_14(Class84.smethod_0(-994207869));
		return this;
	}

	public GClass21 method_15(string string_2)
	{
		if (string_2 == Class84.smethod_0(-994210329))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994210285));
		}
		if (string_2 == Class84.smethod_0(-994210301))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994210242));
		}
		if (string_2 == Class84.smethod_0(-994210259))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994210265));
		}
		if (string_2 == Class84.smethod_0(-994210227))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994210184));
		}
		if (string_2 == Class84.smethod_0(-994210185))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994210205));
		}
		if (string_2 == Class84.smethod_0(-994210166))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994210170));
		}
		if (string_2 == Class84.smethod_0(-994210131))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994210170));
		}
		if (string_2 == Class84.smethod_0(-994210088))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994210093));
		}
		if (string_2 == Class84.smethod_0(-994210055))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994210060));
		}
		if (string_2 == Class84.smethod_0(-994210022))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994210027));
		}
		if (string_2 == Class84.smethod_0(-994210042))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994274323));
		}
		if (string_2 == Class84.smethod_0(-994274247))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994274252));
		}
		if (string_2 == Class84.smethod_0(-994274274))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994274295));
		}
		if (string_2 == Class84.smethod_0(-994209999))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994210004));
		}
		if (string_2 == Class84.smethod_0(-994209968))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994209973));
		}
		if (string_2 == Class84.smethod_0(-994209925))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994209929));
		}
		if (string_2 == Class84.smethod_0(-994209902))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994209918));
		}
		if (string_2 == Class84.smethod_0(-994209875))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994209881));
		}
		if (string_2 == Class84.smethod_0(-994209852))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994209808));
		}
		if (string_2 == Class84.smethod_0(-994213861))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213866));
		}
		if (string_2 == Class84.smethod_0(-994213828))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213848));
		}
		if (string_2 == Class84.smethod_0(-994213805))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213809));
		}
		if (string_2 == Class84.smethod_0(-994213770))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213791));
		}
		if (string_2 == Class84.smethod_0(-994213743))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213748));
		}
		if (string_2 == Class84.smethod_0(-994213700))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213705));
		}
		if (string_2 == Class84.smethod_0(-994213721))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213678));
		}
		if (string_2 == Class84.smethod_0(-994274268))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994274209));
		}
		if (string_2 == Class84.smethod_0(-994213695))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213636));
		}
		if (string_2 == Class84.smethod_0(-994213652))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213657));
		}
		if (string_2 == Class84.smethod_0(-994213609))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213630));
		}
		if (string_2 == Class84.smethod_0(-994213582))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213586));
		}
		if (string_2 == Class84.smethod_0(-994213537))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213558));
		}
		if (string_2 == Class84.smethod_0(-994213510))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213515));
		}
		if (string_2 == Class84.smethod_0(-994213531))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213487));
		}
		if (string_2 == Class84.smethod_0(-994213500))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213454));
		}
		if (string_2 == Class84.smethod_0(-994213465))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213421));
		}
		if (string_2 == Class84.smethod_0(-994213436))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213392));
		}
		if (string_2 == Class84.smethod_0(-994213407))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213348));
		}
		if (string_2 == Class84.smethod_0(-994213365))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213320));
		}
		if (string_2 == Class84.smethod_0(-994213335))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213287));
		}
		if (string_2 == Class84.smethod_0(-994213299))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213256));
		}
		if (string_2 == Class84.smethod_0(-994213257))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213278));
		}
		if (string_2 == Class84.smethod_0(-994213231))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213235));
		}
		if (string_2 == Class84.smethod_0(-994213187))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213204));
		}
		if (string_2 == Class84.smethod_0(-994213153))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213174));
		}
		if (string_2 == Class84.smethod_0(-994213122))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213142));
		}
		if (string_2 == Class84.smethod_0(-994213093))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213097));
		}
		if (string_2 == Class84.smethod_0(-994213064))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213068));
		}
		if (string_2 == Class84.smethod_0(-994213083))
		{
			return method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213040));
		}
		return this;
	}

	public GClass21 method_16(string string_2, string string_3)
	{
		gclass28_0.method_14(string_2);
		gclass28_0.method_14(Class84.smethod_0(-994288861));
		gclass28_0.method_14(string_3);
		gclass28_0.method_14(Class84.smethod_0(-994207869));
		list_0.Add((string_2, string_3));
		return this;
	}

	public GClass21 method_17(string string_2, string string_3, int int_5, string string_4, string string_5, bool bool_2, bool bool_3)
	{
		string item = Class84.smethod_0(-994213056);
		gclass28_0.method_14(item);
		gclass28_0.method_14(Class84.smethod_0(-994288861));
		int num = (int)gclass28_0.method_3();
		gclass28_0.method_14(string_2);
		gclass28_0.method_14(Class84.smethod_0(-994207831));
		gclass28_0.method_14(string_3);
		gclass28_0.method_14(Class84.smethod_0(-994213007));
		gclass28_0.method_14(int_5.ToString());
		if (!string.IsNullOrEmpty(string_5))
		{
			gclass28_0.method_14(Class84.smethod_0(-994213022));
			gclass28_0.method_14(string_5);
		}
		if (!string.IsNullOrEmpty(string_4))
		{
			gclass28_0.method_14(Class84.smethod_0(-994212974));
			gclass28_0.method_14(string_4);
		}
		if (bool_2)
		{
			gclass28_0.method_14(Class84.smethod_0(-994212992));
		}
		if (bool_3)
		{
			gclass28_0.method_14(Class84.smethod_0(-994212929));
		}
		int num2 = (int)gclass28_0.method_3() - num;
		string item2 = gclass28_0.method_6(num, num2);
		gclass28_0.method_14(Class84.smethod_0(-994207869));
		list_0.Add((item, item2));
		return this;
	}

	public GClass21 method_18(string string_2)
	{
		int num = ((!string.IsNullOrEmpty(string_2)) ? Encoding.UTF8.GetByteCount(string_2) : 0);
		method_16(Class84.smethod_0(-994207782), num.ToString());
		gclass28_0.method_14(Class84.smethod_0(-994207869));
		int num2 = (int)gclass28_0.method_3();
		gclass28_0.method_14(string_2);
		int_1 = num2;
		int_2 = num;
		int_3 = num;
		bool_1 = true;
		return this;
	}

	public GClass21 method_19(byte[] byte_0)
	{
		method_16(Class84.smethod_0(-994207782), byte_0.Length.ToString());
		gclass28_0.method_14(Class84.smethod_0(-994207869));
		int num = (int)gclass28_0.method_3();
		gclass28_0.method_12(byte_0);
		int_1 = num;
		int_2 = byte_0.Length;
		int_3 = byte_0.Length;
		bool_1 = true;
		return this;
	}

	public GClass21 method_20(GClass28 gclass28_1)
	{
		method_16(Class84.smethod_0(-994207782), gclass28_1.method_3().ToString());
		gclass28_0.method_14(Class84.smethod_0(-994207869));
		int num = (int)gclass28_0.method_3();
		gclass28_0.method_13(gclass28_1.method_1(), gclass28_1.method_4(), gclass28_1.method_3());
		int_1 = num;
		int_2 = (int)gclass28_1.method_3();
		int_3 = (int)gclass28_1.method_3();
		bool_1 = true;
		return this;
	}

	public GClass21 method_21(int int_5)
	{
		method_16(Class84.smethod_0(-994207782), int_5.ToString());
		gclass28_0.method_14(Class84.smethod_0(-994207869));
		int num = (int)gclass28_0.method_3();
		int_1 = num;
		int_2 = 0;
		int_3 = int_5;
		bool_1 = true;
		return this;
	}

	public GClass21 method_22(int int_5)
	{
		method_12();
		method_13(int_5, Class84.smethod_0(-994207750));
		method_18(string.Empty);
		return this;
	}

	public GClass21 method_23(string string_2, string string_3)
	{
		return method_24(500, string_2, string_3);
	}

	public GClass21 method_24(int int_5, string string_2, string string_3)
	{
		method_12();
		method_13(int_5, Class84.smethod_0(-994207750));
		if (!string.IsNullOrEmpty(string_3))
		{
			method_16(Class84.smethod_0(-994286687), string_3);
		}
		method_18(string_2);
		return this;
	}

	public GClass21 method_25()
	{
		method_12();
		method_13(200, Class84.smethod_0(-994207750));
		method_18(string.Empty);
		return this;
	}

	public GClass21 method_26(string string_2, string string_3)
	{
		method_12();
		method_13(200, Class84.smethod_0(-994207750));
		if (!string.IsNullOrEmpty(string_3))
		{
			method_16(Class84.smethod_0(-994286687), string_3);
		}
		method_18(string_2);
		return this;
	}

	public GClass21 method_27(byte[] byte_0, string string_2)
	{
		method_12();
		method_13(200, Class84.smethod_0(-994207750));
		if (!string.IsNullOrEmpty(string_2))
		{
			method_16(Class84.smethod_0(-994286687), string_2);
		}
		method_19(byte_0);
		return this;
	}

	public GClass21 method_28(GClass28 gclass28_1, string string_2)
	{
		method_12();
		method_13(200, Class84.smethod_0(-994207750));
		if (!string.IsNullOrEmpty(string_2))
		{
			method_16(Class84.smethod_0(-994286687), string_2);
		}
		method_20(gclass28_1);
		return this;
	}

	public GClass21 method_29(string string_2)
	{
		method_12();
		method_13(200, Class84.smethod_0(-994207750));
		method_16(Class84.smethod_0(-994212960), string_2);
		method_18(string.Empty);
		return this;
	}

	public GClass21 method_30(string string_2)
	{
		method_12();
		method_13(200, Class84.smethod_0(-994207750));
		method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213487));
		method_18(string_2);
		return this;
	}

	public GClass21 method_31(byte[] byte_0)
	{
		method_12();
		method_13(200, Class84.smethod_0(-994207750));
		method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213487));
		method_19(byte_0);
		return this;
	}

	public GClass21 method_32(GClass28 gclass28_1)
	{
		method_12();
		method_13(200, Class84.smethod_0(-994207750));
		method_16(Class84.smethod_0(-994286687), Class84.smethod_0(-994213487));
		method_20(gclass28_1);
		return this;
	}

	internal bool method_33()
	{
		if (!method_1())
		{
			return int_1 == 0;
		}
		return false;
	}

	internal bool method_34()
	{
		if (!method_1() && int_1 > 0)
		{
			return int_2 > 0;
		}
		return false;
	}

	internal bool method_35(byte[] byte_0, int int_5, int int_6)
	{
		gclass28_0.method_13(byte_0, int_5, int_6);
		for (int i = int_4; i < (int)gclass28_0.method_3() && i + 3 < (int)gclass28_0.method_3(); i++)
		{
			if (gclass28_0.get_Item(i) != 13 || gclass28_0.get_Item(i + 1) != 10 || gclass28_0.get_Item(i + 2) != 13 || gclass28_0.get_Item(i + 3) != 10)
			{
				continue;
			}
			int num = 0;
			method_2(bool_2: true);
			int num2 = 0;
			int num3 = 0;
			do
			{
				if (gclass28_0.get_Item(num) != 32)
				{
					num3++;
					num++;
					continue;
				}
				num++;
				if (num >= (int)gclass28_0.method_3())
				{
					return false;
				}
				string_1 = gclass28_0.method_6(num2, num3);
				int num4 = num;
				int num5 = 0;
				while (true)
				{
					if (gclass28_0.get_Item(num) != 32)
					{
						if (gclass28_0.get_Item(num) < 48 || gclass28_0.get_Item(num) > 57)
						{
							break;
						}
						num5++;
						num++;
						if (num >= (int)gclass28_0.method_3())
						{
							return false;
						}
						continue;
					}
					method_4(0);
					for (int j = num4; j < num4 + num5; j++)
					{
						method_4(method_3() * 10);
						method_4(method_3() + (gclass28_0.get_Item(j) - 48));
					}
					num++;
					if (num >= (int)gclass28_0.method_3())
					{
						return false;
					}
					int num6 = num;
					int num7 = 0;
					do
					{
						if (gclass28_0.get_Item(num) != 13)
						{
							num7++;
							num++;
							continue;
						}
						num++;
						if (num < (int)gclass28_0.method_3() && gclass28_0.get_Item(num) == 10)
						{
							num++;
							if (num >= (int)gclass28_0.method_3())
							{
								return false;
							}
							string_0 = gclass28_0.method_6(num6, num7);
							while (num < (int)gclass28_0.method_3() && num < i)
							{
								int num8 = num;
								int num9 = 0;
								while (gclass28_0.get_Item(num) != 58)
								{
									num9++;
									num++;
									if (num >= i)
									{
										break;
									}
									if (num >= (int)gclass28_0.method_3())
									{
										return false;
									}
								}
								num++;
								if (num >= i)
								{
									break;
								}
								if (num < (int)gclass28_0.method_3())
								{
									while (char.IsWhiteSpace((char)gclass28_0.get_Item(num)))
									{
										num++;
										if (num >= i)
										{
											break;
										}
										if (num >= (int)gclass28_0.method_3())
										{
											return false;
										}
									}
									int num10 = num;
									int num11 = 0;
									while (gclass28_0.get_Item(num) != 13)
									{
										num11++;
										num++;
										if (num >= i)
										{
											break;
										}
										if (num >= (int)gclass28_0.method_3())
										{
											return false;
										}
									}
									num++;
									if (num < (int)gclass28_0.method_3() && gclass28_0.get_Item(num) == 10)
									{
										num++;
										if (num < (int)gclass28_0.method_3())
										{
											if (num9 != 0)
											{
												string text = gclass28_0.method_6(num8, num9);
												string item = gclass28_0.method_6(num10, num11);
												list_0.Add((text, item));
												if (string.Compare(text, Class84.smethod_0(-994207782), StringComparison.OrdinalIgnoreCase) != 0)
												{
													continue;
												}
												int_3 = 0;
												for (int k = num10; k < num10 + num11; k++)
												{
													if (gclass28_0.get_Item(k) >= 48 && gclass28_0.get_Item(k) <= 57)
													{
														int_3 *= 10;
														int_3 += gclass28_0.get_Item(k) - 48;
														bool_1 = true;
														continue;
													}
													return false;
												}
												continue;
											}
											return false;
										}
										return false;
									}
									return false;
								}
								return false;
							}
							method_2(bool_2: false);
							int_1 = i + 4;
							int_2 = (int)gclass28_0.method_3() - i - 4;
							int_4 = (int)gclass28_0.method_3();
							return true;
						}
						return false;
					}
					while (num < (int)gclass28_0.method_3());
					return false;
				}
				return false;
			}
			while (num < (int)gclass28_0.method_3());
			return false;
		}
		int_4 = (((int)gclass28_0.method_3() >= 3) ? ((int)gclass28_0.method_3() - 3) : 0);
		return false;
	}

	internal bool method_36(byte[] byte_0, int int_5, int int_6)
	{
		gclass28_0.method_13(byte_0, int_5, int_6);
		int_4 = (int)gclass28_0.method_3();
		int_2 += int_6;
		if (bool_1)
		{
			if (int_2 >= int_3)
			{
				int_2 = int_3;
				return true;
			}
		}
		else if (int_2 >= 4)
		{
			int num = int_1 + int_2 - 4;
			if (gclass28_0.get_Item(num) == 13 && gclass28_0.get_Item(num + 1) == 10 && gclass28_0.get_Item(num + 2) == 13 && gclass28_0.get_Item(num + 3) == 10)
			{
				int_3 = int_2;
				return true;
			}
		}
		return false;
	}
}
