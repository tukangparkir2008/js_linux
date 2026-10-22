using System;
using System.Collections.Generic;
using System.Text;

public sealed class GClass61
{
	private bool bool_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private List<(string, string)> list_0 = new List<(string, string)>();

	private List<(string, string)> list_1 = new List<(string, string)>();

	private int int_0;

	private int int_1;

	private int int_2;

	private bool bool_1;

	private GClass28 gclass28_0 = new GClass28();

	private int int_3;

	public GClass61()
	{
		method_13();
	}

	public GClass61(string string_3, string string_4, string string_5 = "HTTP/1.1")
	{
		method_14(string_3, string_4, string_5);
	}

	public bool method_0()
	{
		return gclass28_0.method_3() == 0L;
	}

	public bool method_1()
	{
		return bool_0;
	}

	private void method_2(bool bool_2)
	{
		bool_0 = bool_2;
	}

	public string method_3()
	{
		return string_0;
	}

	public string method_4()
	{
		return string_1;
	}

	public string method_5()
	{
		return string_2;
	}

	public long method_6()
	{
		return list_0.Count;
	}

	public (string, string) method_7(int int_4)
	{
		if (int_4 >= list_0.Count)
		{
			return (string.Empty, string.Empty);
		}
		return list_0[int_4];
	}

	public long method_8()
	{
		return list_1.Count;
	}

	public (string, string) method_9(int int_4)
	{
		if (int_4 >= list_1.Count)
		{
			return (string.Empty, string.Empty);
		}
		return list_1[int_4];
	}

	public string method_10()
	{
		return gclass28_0.method_6(int_0, int_1);
	}

	public long method_11()
	{
		return int_2;
	}

	public GClass28 method_12()
	{
		return gclass28_0;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(Class84.smethod_0(-994207998) + method_3());
		stringBuilder.AppendLine(Class84.smethod_0(-994207959) + method_4());
		stringBuilder.AppendLine(Class84.smethod_0(-994207907) + method_5());
		stringBuilder.AppendLine(string.Format(Class84.smethod_0(-994207930), method_6()));
		for (int i = 0; i < method_6(); i++)
		{
			(string, string) tuple = method_7(i);
			stringBuilder.AppendLine(tuple.Item1 + Class84.smethod_0(-994207903) + tuple.Item2);
		}
		stringBuilder.AppendLine(string.Format(Class84.smethod_0(-994207845), method_11()));
		stringBuilder.AppendLine(method_10());
		return stringBuilder.ToString();
	}

	public GClass61 method_13()
	{
		method_2(bool_2: false);
		string_0 = string.Empty;
		string_1 = string.Empty;
		string_2 = string.Empty;
		list_0.Clear();
		list_1.Clear();
		int_0 = 0;
		int_1 = 0;
		int_2 = 0;
		bool_1 = false;
		gclass28_0.method_5();
		int_3 = 0;
		return this;
	}

	public GClass61 method_14(string string_3, string string_4, string string_5)
	{
		method_13();
		gclass28_0.method_14(string_3);
		string_0 = string_3;
		gclass28_0.method_14(Class84.smethod_0(-994263061));
		gclass28_0.method_14(string_4);
		string_1 = string_4;
		gclass28_0.method_14(Class84.smethod_0(-994263061));
		gclass28_0.method_14(string_5);
		string_2 = string_5;
		gclass28_0.method_14(Class84.smethod_0(-994207869));
		return this;
	}

	public GClass61 method_15(string string_3, string string_4)
	{
		gclass28_0.method_14(string_3);
		gclass28_0.method_14(Class84.smethod_0(-994288861));
		gclass28_0.method_14(string_4);
		gclass28_0.method_14(Class84.smethod_0(-994207869));
		list_0.Add((string_3, string_4));
		return this;
	}

	public GClass61 method_16(string string_3, string string_4)
	{
		string item = Class84.smethod_0(-994207812);
		string item2 = string_3 + Class84.smethod_0(-994207831) + string_4;
		gclass28_0.method_14(item);
		gclass28_0.method_14(Class84.smethod_0(-994288861));
		gclass28_0.method_14(item2);
		gclass28_0.method_14(Class84.smethod_0(-994207869));
		list_0.Add((item, item2));
		list_1.Add((string_3, string_4));
		return this;
	}

	public GClass61 method_17(string string_3, string string_4)
	{
		gclass28_0.method_14(Class84.smethod_0(-994207839));
		gclass28_0.method_14(string_3);
		gclass28_0.method_14(Class84.smethod_0(-994207831));
		gclass28_0.method_14(string_4);
		list_1.Add((string_3, string_4));
		return this;
	}

	public GClass61 method_18(string string_3)
	{
		int num = ((!string.IsNullOrEmpty(string_3)) ? Encoding.UTF8.GetByteCount(string_3) : 0);
		method_15(Class84.smethod_0(-994207782), num.ToString());
		gclass28_0.method_14(Class84.smethod_0(-994207869));
		int num2 = (int)gclass28_0.method_3();
		gclass28_0.method_14(string_3);
		int_0 = num2;
		int_1 = num;
		int_2 = num;
		bool_1 = true;
		return this;
	}

	public GClass61 method_19(byte[] byte_0)
	{
		method_15(Class84.smethod_0(-994207782), byte_0.Length.ToString());
		gclass28_0.method_14(Class84.smethod_0(-994207869));
		int num = (int)gclass28_0.method_3();
		gclass28_0.method_12(byte_0);
		int_0 = num;
		int_1 = byte_0.Length;
		int_2 = byte_0.Length;
		bool_1 = true;
		return this;
	}

	public GClass61 method_20(GClass28 gclass28_1)
	{
		method_15(Class84.smethod_0(-994207782), gclass28_1.method_3().ToString());
		gclass28_0.method_14(Class84.smethod_0(-994207869));
		int num = (int)gclass28_0.method_3();
		gclass28_0.method_13(gclass28_1.method_1(), gclass28_1.method_4(), gclass28_1.method_3());
		int_0 = num;
		int_1 = (int)gclass28_1.method_3();
		int_2 = (int)gclass28_1.method_3();
		bool_1 = true;
		return this;
	}

	public GClass61 method_21(int int_4)
	{
		method_15(Class84.smethod_0(-994207782), int_4.ToString());
		gclass28_0.method_14(Class84.smethod_0(-994207869));
		int num = (int)gclass28_0.method_3();
		int_0 = num;
		int_1 = 0;
		int_2 = int_4;
		bool_1 = true;
		return this;
	}

	public GClass61 method_22(string string_3)
	{
		method_13();
		method_14(Class84.smethod_0(-994207793), string_3, Class84.smethod_0(-994207750));
		method_18(string.Empty);
		return this;
	}

	public GClass61 method_23(string string_3)
	{
		method_13();
		method_14(Class84.smethod_0(-994207767), string_3, Class84.smethod_0(-994207750));
		method_18(string.Empty);
		return this;
	}

	public GClass61 method_24(string string_3, string string_4, string string_5)
	{
		method_13();
		method_14(Class84.smethod_0(-994265316), string_3, Class84.smethod_0(-994207750));
		if (!string.IsNullOrEmpty(string_5))
		{
			method_15(Class84.smethod_0(-994286687), string_5);
		}
		method_18(string_4);
		return this;
	}

	public GClass61 method_25(string string_3, byte[] byte_0, string string_4)
	{
		method_13();
		method_14(Class84.smethod_0(-994265316), string_3, Class84.smethod_0(-994207750));
		if (!string.IsNullOrEmpty(string_4))
		{
			method_15(Class84.smethod_0(-994286687), string_4);
		}
		method_19(byte_0);
		return this;
	}

	public GClass61 method_26(string string_3, GClass28 gclass28_1, string string_4)
	{
		method_13();
		method_14(Class84.smethod_0(-994265316), string_3, Class84.smethod_0(-994207750));
		if (!string.IsNullOrEmpty(string_4))
		{
			method_15(Class84.smethod_0(-994286687), string_4);
		}
		method_20(gclass28_1);
		return this;
	}

	public GClass61 method_27(string string_3, string string_4, string string_5)
	{
		method_13();
		method_14(Class84.smethod_0(-994207773), string_3, Class84.smethod_0(-994207750));
		if (!string.IsNullOrEmpty(string_5))
		{
			method_15(Class84.smethod_0(-994286687), string_5);
		}
		method_18(string_4);
		return this;
	}

	public GClass61 method_28(string string_3, byte[] byte_0, string string_4)
	{
		method_13();
		method_14(Class84.smethod_0(-994207773), string_3, Class84.smethod_0(-994207750));
		if (!string.IsNullOrEmpty(string_4))
		{
			method_15(Class84.smethod_0(-994286687), string_4);
		}
		method_19(byte_0);
		return this;
	}

	public GClass61 method_29(string string_3, GClass28 gclass28_1, string string_4)
	{
		method_13();
		method_14(Class84.smethod_0(-994207773), string_3, Class84.smethod_0(-994207750));
		if (!string.IsNullOrEmpty(string_4))
		{
			method_15(Class84.smethod_0(-994286687), string_4);
		}
		method_20(gclass28_1);
		return this;
	}

	public GClass61 method_30(string string_3)
	{
		method_13();
		method_14(Class84.smethod_0(-994211811), string_3, Class84.smethod_0(-994207750));
		method_18(string.Empty);
		return this;
	}

	public GClass61 method_31(string string_3)
	{
		method_13();
		method_14(Class84.smethod_0(-994211830), string_3, Class84.smethod_0(-994207750));
		method_18(string.Empty);
		return this;
	}

	public GClass61 method_32(string string_3)
	{
		method_13();
		method_14(Class84.smethod_0(-994211784), string_3, Class84.smethod_0(-994207750));
		method_18(string.Empty);
		return this;
	}

	internal bool method_33()
	{
		if (!method_1())
		{
			return int_0 == 0;
		}
		return false;
	}

	internal bool method_34()
	{
		if (!method_1() && int_0 > 0)
		{
			return int_1 > 0;
		}
		return false;
	}

	internal bool method_35(byte[] byte_0, int int_4, int int_5)
	{
		gclass28_0.method_13(byte_0, int_4, int_5);
		for (int i = int_3; i < (int)gclass28_0.method_3() && i + 3 < (int)gclass28_0.method_3(); i++)
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
				string_0 = gclass28_0.method_6(num2, num3);
				int num4 = num;
				int num5 = 0;
				do
				{
					if (gclass28_0.get_Item(num) != 32)
					{
						num5++;
						num++;
						continue;
					}
					num++;
					if (num >= (int)gclass28_0.method_3())
					{
						return false;
					}
					string_1 = gclass28_0.method_6(num4, num5);
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
							string_2 = gclass28_0.method_6(num6, num7);
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
												if (string.Compare(text, Class84.smethod_0(-994207782), StringComparison.OrdinalIgnoreCase) == 0)
												{
													int_2 = 0;
													for (int j = num10; j < num10 + num11; j++)
													{
														if (gclass28_0.get_Item(j) >= 48 && gclass28_0.get_Item(j) <= 57)
														{
															int_2 *= 10;
															int_2 += gclass28_0.get_Item(j) - 48;
															bool_1 = true;
															continue;
														}
														return false;
													}
												}
												if (string.Compare(text, Class84.smethod_0(-994207812), StringComparison.OrdinalIgnoreCase) != 0)
												{
													continue;
												}
												bool flag = true;
												bool flag2 = false;
												int num12 = num10;
												int num13 = num;
												int num14 = 0;
												int num15 = num;
												int num16 = 0;
												for (int k = num10; k < num10 + num11; k++)
												{
													if (gclass28_0.get_Item(k) == 32)
													{
														if (flag2)
														{
															if (flag)
															{
																num13 = num12;
																num14 = k - num12;
															}
															else
															{
																num15 = num12;
																num16 = k - num12;
															}
														}
														flag2 = false;
													}
													else if (gclass28_0.get_Item(k) == 61)
													{
														if (flag2)
														{
															if (flag)
															{
																num13 = num12;
																num14 = k - num12;
															}
															else
															{
																num15 = num12;
																num16 = k - num12;
															}
														}
														flag2 = false;
														flag = false;
													}
													else if (gclass28_0.get_Item(k) == 59)
													{
														if (flag2)
														{
															if (flag)
															{
																num13 = num12;
																num14 = k - num12;
															}
															else
															{
																num15 = num12;
																num16 = k - num12;
															}
															if (num14 > 0 && num16 > 0)
															{
																list_1.Add((gclass28_0.method_6(num13, num14), gclass28_0.method_6(num15, num16)));
																num13 = k;
																num14 = 0;
																num15 = k;
																num16 = 0;
															}
														}
														flag2 = false;
														flag = true;
													}
													else if (!flag2)
													{
														num12 = k;
														flag2 = true;
													}
												}
												if (flag2)
												{
													if (flag)
													{
														num13 = num12;
														num14 = num10 + num11 - num12;
													}
													else
													{
														num15 = num12;
														num16 = num10 + num11 - num12;
													}
													if (num14 > 0 && num16 > 0)
													{
														list_1.Add((gclass28_0.method_6(num13, num14), gclass28_0.method_6(num15, num16)));
													}
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
							int_0 = i + 4;
							int_1 = (int)gclass28_0.method_3() - i - 4;
							int_3 = (int)gclass28_0.method_3();
							return true;
						}
						return false;
					}
					while (num < (int)gclass28_0.method_3());
					return false;
				}
				while (num < (int)gclass28_0.method_3());
				return false;
			}
			while (num < (int)gclass28_0.method_3());
			return false;
		}
		int_3 = (((int)gclass28_0.method_3() >= 3) ? ((int)gclass28_0.method_3() - 3) : 0);
		return false;
	}

	internal bool method_36(byte[] byte_0, int int_4, int int_5)
	{
		gclass28_0.method_13(byte_0, int_4, int_5);
		int_3 = (int)gclass28_0.method_3();
		int_1 += int_5;
		if (bool_1)
		{
			if (int_1 >= int_2)
			{
				int_1 = int_2;
				return true;
			}
		}
		else
		{
			if (method_3() == Class84.smethod_0(-994207793) || method_3() == Class84.smethod_0(-994207767) || method_3() == Class84.smethod_0(-994211811) || method_3() == Class84.smethod_0(-994211830) || method_3() == Class84.smethod_0(-994211784))
			{
				int_2 = 0;
				int_1 = 0;
				return true;
			}
			if (int_1 >= 4)
			{
				int num = int_0 + int_1 - 4;
				if (gclass28_0.get_Item(num) == 13 && gclass28_0.get_Item(num + 1) == 10 && gclass28_0.get_Item(num + 2) == 13 && gclass28_0.get_Item(num + 3) == 10)
				{
					int_2 = int_1;
					return true;
				}
			}
		}
		return false;
	}
}
