using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

public sealed class GClass47
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 141)
			{
				gClass = smethod_11(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 142)
			{
				gClass = smethod_1(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 125)
			{
				gClass = smethod_15(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 126)
			{
				gClass = smethod_12(gclass4_0, gclass41_0, jsRequest_0);
			}
			if (gClass.Value < 0)
			{
				gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, gClass.Text);
				jsRequest_0.Data = string.Empty;
				jsRequest_0.Message = gClass.Text;
				jsRequest_0.ServerStatus = -1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.UserRequest.Inflate();
			}
			else
			{
				jsRequest_0.Data = gClass.Data;
				jsRequest_0.Message = gClass.Text;
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = gClass.Value;
				jsRequest_0.UserRequest.Inflate();
			}
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994239857));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			jsRequest_0.Data = string.Empty;
			jsRequest_0.ServerStatus = -1;
			jsRequest_0.ExecCode = -1;
			jsRequest_0.Message = Class309.smethod_73() + ex.Message;
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
	}

	private static GClass70 smethod_1(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			MySqlCommand mySqlCommand_ = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			int int_ = Convert.ToInt32(list[0]);
			int int_2 = Convert.ToInt32(list[1]);
			int int_3 = Convert.ToInt32(list[2]);
			bool bool_ = Convert.ToInt32(list[3]) == 1;
			bool bool_2 = Convert.ToInt32(list[4]) == 1;
			byte[] inArray = GClass18.smethod_9(smethod_2(mySqlCommand_, int_, int_2, int_3, bool_, bool_2));
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994239825));
			return new GClass70(1, Class84.smethod_0(-994247224), Convert.ToBase64String(inArray));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994239799));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static Image smethod_2(MySqlCommand mySqlCommand_0, int int_0, int int_1, int int_2, bool bool_0, bool bool_1)
	{
		switch ((GEnum6)int_2)
		{
		default:
			return null;
		case (GEnum6)0:
		{
			int int_3 = 5;
			return smethod_7(mySqlCommand_0, int_0, int_1, bool_0, bool_1, ref int_3);
		}
		case (GEnum6)1:
			return smethod_8(mySqlCommand_0, int_0, int_1, bool_0, bool_1);
		case (GEnum6)2:
			return smethod_9(mySqlCommand_0, int_0, int_1, bool_0: true, bool_1);
		case (GEnum6)3:
			return smethod_10(mySqlCommand_0, int_0, int_1, bool_0: true, bool_1);
		case (GEnum6)4:
		{
			int int_3 = 10;
			return smethod_6(mySqlCommand_0, int_0, int_1, bool_0, bool_1, ref int_3);
		}
		}
	}

	private static Image smethod_3(Dictionary<string, Image> dictionary_0, bool bool_0, List<string> list_0)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		foreach (string key in dictionary_0.Keys)
		{
			Image image = dictionary_0[key];
			num += image.Height + 10;
			num3 += 25;
			if (num2 < image.Width)
			{
				num2 = image.Width;
			}
		}
		num3 += 15;
		if (num2 < 480)
		{
			num2 = 480;
		}
		num2 += 60;
		num += num3;
		Bitmap bitmap = new Bitmap(num2, num);
		try
		{
			bitmap.SetResolution(96f, 96f);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				graphics.InterpolationMode = InterpolationMode.Low;
				graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;
				graphics.CompositingQuality = CompositingQuality.HighSpeed;
				graphics.FillRectangle(Brushes.White, 0, 0, num2, num);
				Point point = new Point(24, 24);
				int num4 = 5;
				int num5 = 5;
				Image image2 = dictionary_0[Class84.smethod_0(-994239763)];
				graphics.DrawImage(image2, new Point(5, 5));
				num5 = 5 + (image2.Height + 30);
				if (!bool_0)
				{
					Point point2 = new Point(0, 0);
					if (dictionary_0.ContainsKey(Class84.smethod_0(-994239720)))
					{
						image2 = dictionary_0[Class84.smethod_0(-994239720)];
						point2 = new Point(num4 - 1, num5 - 6);
						graphics.FillEllipse(Brushes.SteelBlue, point2.X, point2.Y, point.X, point.Y);
						graphics.DrawString(point: new Point(num4 + 5, num5 - 2), s: list_0[0], font: Class224.Class226.font_0, brush: Brushes.White);
						point2 = new Point(num4 + 35, num5);
						graphics.DrawImage(image2, point2);
						num5 += image2.Height + 20;
					}
					if (dictionary_0.ContainsKey(Class84.smethod_0(-994239728)))
					{
						image2 = dictionary_0[Class84.smethod_0(-994239728)];
						point2 = new Point(num4 - 1, num5 - 6);
						graphics.FillEllipse(Brushes.SteelBlue, point2.X, point2.Y, point.X, point.Y);
						graphics.DrawString(point: new Point(num4 + 5, num5 - 2), s: list_0[1], font: Class224.Class226.font_0, brush: Brushes.White);
						point2 = new Point(num4 + 35, num5);
						graphics.DrawImage(image2, point2);
						num5 += image2.Height + 20;
					}
					if (dictionary_0.ContainsKey(Class84.smethod_0(-994284333)))
					{
						image2 = dictionary_0[Class84.smethod_0(-994284333)];
						point2 = new Point(num4 - 1, num5 - 6);
						graphics.FillEllipse(Brushes.SteelBlue, point2.X, point2.Y, point.X, point.Y);
						graphics.DrawString(point: new Point(num4 + 5, num5 - 2), s: list_0[2], font: Class224.Class226.font_0, brush: Brushes.White);
						point2 = new Point(num4 + 35, num5);
						graphics.DrawImage(image2, point2);
						num5 += image2.Height + 20;
					}
					if (dictionary_0.ContainsKey(Class84.smethod_0(-994284297)))
					{
						image2 = dictionary_0[Class84.smethod_0(-994284297)];
						point2 = new Point(num4 - 1, num5 - 6);
						graphics.FillEllipse(Brushes.SteelBlue, point2.X, point2.Y, point.X, point.Y);
						graphics.DrawString(point: new Point(num4 + 5, num5 - 2), s: list_0[3], font: Class224.Class226.font_0, brush: Brushes.White);
						point2 = new Point(num4 + 35, num5);
						graphics.DrawImage(image2, point2);
						num5 += image2.Height + 20;
					}
					if (dictionary_0.ContainsKey(Class84.smethod_0(-994239736)))
					{
						image2 = dictionary_0[Class84.smethod_0(-994239736)];
						point2 = new Point(num4 - 1, num5 - 6);
						graphics.FillEllipse(Brushes.SteelBlue, point2.X, point2.Y, point.X, point.Y);
						graphics.DrawString(point: new Point(num4 + 5, num5 - 2), s: list_0[4], font: Class224.Class226.font_0, brush: Brushes.White);
						point2 = new Point(num4 + 35, num5);
						graphics.DrawImage(image2, point2);
						num5 += image2.Height + 20;
					}
					if (dictionary_0.ContainsKey(Class84.smethod_0(-994239744)))
					{
						image2 = dictionary_0[Class84.smethod_0(-994239744)];
						point2 = new Point(num4 - 1, num5 - 6);
						graphics.FillEllipse(Brushes.SteelBlue, point2.X, point2.Y, point.X, point.Y);
						graphics.DrawString(point: new Point(num4 + 5, num5 - 2), s: list_0[5], font: Class224.Class226.font_0, brush: Brushes.White);
						point2 = new Point(num4 + 35, num5);
						graphics.DrawImage(image2, point2);
						num5 += image2.Height + 20;
					}
					if (dictionary_0.ContainsKey(Class84.smethod_0(-994239688)))
					{
						image2 = dictionary_0[Class84.smethod_0(-994239688)];
						point2 = new Point(num4 - 1, num5 - 6);
						graphics.FillEllipse(Brushes.SteelBlue, point2.X, point2.Y, point.X, point.Y);
						graphics.DrawString(point: new Point(num4 + 5, num5 - 2), s: list_0[6], font: Class224.Class226.font_0, brush: Brushes.White);
						point2 = new Point(num4 + 35, num5);
						graphics.DrawImage(image2, point2);
						num5 += image2.Height + 20;
					}
					if (dictionary_0.ContainsKey(Class84.smethod_0(-994239696)))
					{
						image2 = dictionary_0[Class84.smethod_0(-994239696)];
						point2 = new Point(num4 - 1, num5 - 6);
						graphics.FillEllipse(Brushes.SteelBlue, point2.X, point2.Y, point.X, point.Y);
						graphics.DrawString(point: new Point(num4 + 5, num5 - 2), s: list_0[7], font: Class224.Class226.font_0, brush: Brushes.White);
						point2 = new Point(num4 + 35, num5);
						graphics.DrawImage(image2, point2);
						num5 += image2.Height + 20;
					}
					if (dictionary_0.ContainsKey(Class84.smethod_0(-994284483)))
					{
						image2 = dictionary_0[Class84.smethod_0(-994284483)];
						point2 = new Point(num4 - 1, num5 - 6);
						graphics.FillEllipse(Brushes.SteelBlue, point2.X, point2.Y, point.X, point.Y);
						graphics.DrawString(point: new Point(num4 + 5, num5 - 2), s: list_0[8], font: Class224.Class226.font_0, brush: Brushes.White);
						point2 = new Point(num4 + 35, num5);
						graphics.DrawImage(image2, point2);
						num5 += image2.Height + 20;
					}
					if (dictionary_0.ContainsKey(Class84.smethod_0(-994239704)))
					{
						image2 = dictionary_0[Class84.smethod_0(-994239704)];
						point2 = new Point(num4 - 1, num5 - 6);
						graphics.FillEllipse(Brushes.SteelBlue, point2.X, point2.Y, point.X, point.Y);
						graphics.DrawString(point: new Point(num4 + 5, num5 - 2), s: list_0[9], font: Class224.Class226.font_0, brush: Brushes.White);
						point2 = new Point(num4 + 35, num5);
						graphics.DrawImage(image2, point2);
						num5 += image2.Height + 20;
					}
				}
				if (dictionary_0.ContainsKey(Class84.smethod_0(-994239712)))
				{
					num5 += 10;
					float[] dashPattern = new float[4] { 5f, 2f, 15f, 4f };
					Pen pen = new Pen(Color.DimGray, 1f)
					{
						DashPattern = dashPattern
					};
					Point point3 = new Point(num4 + 5, num5 - 3);
					Point point4 = new Point(num2 - 5, num5 - 3);
					graphics.DrawLine(pen, point3.X, point3.Y, point4.X, point4.Y);
					num5 += 10;
					image2 = dictionary_0[Class84.smethod_0(-994239712)];
					graphics.DrawString(point: new Point(num4 + 5, num5 - 3), s: Class84.smethod_0(-994239650), font: Class224.Class226.font_0, brush: Brushes.Black);
					Point point5 = new Point(num4 + 20, num5 + 15);
					graphics.DrawImage(image2, point5);
					num5 += image2.Height + 20;
				}
				if (dictionary_0.ContainsKey(Class84.smethod_0(-994239667)))
				{
					num5 += 10;
					float[] dashPattern2 = new float[4] { 5f, 2f, 15f, 4f };
					Pen pen2 = new Pen(Color.DimGray, 1f)
					{
						DashPattern = dashPattern2
					};
					Point point6 = new Point(num4 + 5, num5 - 3);
					Point point7 = new Point(num2 - 5, num5 - 3);
					graphics.DrawLine(pen2, point6.X, point6.Y, point7.X, point7.Y);
					num5 += 10;
					image2 = dictionary_0[Class84.smethod_0(-994239667)];
					graphics.DrawString(point: new Point(num4 + 5, num5 - 3), s: Class84.smethod_0(-994239623), font: Class224.Class226.font_0, brush: Brushes.Black);
					Point point8 = new Point(num4 + 20, num5 + 15);
					graphics.DrawImage(image2, point8);
				}
			}
			return GClass18.smethod_13(GClass18.smethod_22(bitmap, ImageFormat.Gif));
		}
		finally
		{
			((IDisposable)bitmap).Dispose();
		}
	}

	private static Image smethod_4()
	{
		Bitmap bitmap = new Bitmap(150, 50);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, 150, 50);
		graphics.DrawString(Class84.smethod_0(-994239626), new Font(Class84.smethod_0(-994273712), 11f), new SolidBrush(Color.Red), 10f, 25f);
		return bitmap;
	}

	private static byte[] smethod_5()
	{
		Bitmap bitmap = new Bitmap(150, 50);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, 150, 50);
			graphics.DrawString(Class84.smethod_0(-994239626), new Font(Class84.smethod_0(-994273712), 11f), new SolidBrush(Color.Red), 10f, 25f);
		}
		return GClass27.smethod_1(bitmap);
	}

	private static Image smethod_6(MySqlCommand mySqlCommand_0, int int_0, int int_1, bool bool_0, bool bool_1, ref int int_2)
	{
		MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
		mySqlDataAdapter.SelectCommand = mySqlCommand_0;
		string commandText = Class84.smethod_0(-994239585) + int_1;
		mySqlDataAdapter.SelectCommand.CommandText = commandText;
		DataTable dataTable = new DataTable();
		mySqlDataAdapter.Fill(dataTable);
		Dictionary<string, Image> dictionary = new Dictionary<string, Image>();
		if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239431)]))
		{
			byte[] byte_ = (byte[])dataTable.Rows[0][Class84.smethod_0(-994239431)];
			dictionary[Class84.smethod_0(-994239763)] = GClass27.smethod_3(byte_);
		}
		else
		{
			dictionary[Class84.smethod_0(-994239763)] = smethod_4();
		}
		if (!bool_0)
		{
			int_2 = Convert.ToInt32(dataTable.Rows[0][Class84.smethod_0(-994239436)]);
			Dictionary<string, byte[]> dictionary2 = new Dictionary<string, byte[]>();
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994289925)]))
			{
				dictionary2.Add(Class84.smethod_0(-994239720), (byte[])dataTable.Rows[0][Class84.smethod_0(-994289925)]);
			}
			else
			{
				dictionary2.Add(Class84.smethod_0(-994239720), smethod_5());
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239453)]))
			{
				dictionary2.Add(Class84.smethod_0(-994239728), (byte[])dataTable.Rows[0][Class84.smethod_0(-994239453)]);
			}
			else
			{
				dictionary2.Add(Class84.smethod_0(-994239728), smethod_5());
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239397)]))
			{
				dictionary2.Add(Class84.smethod_0(-994284333), (byte[])dataTable.Rows[0][Class84.smethod_0(-994239397)]);
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239405)]))
			{
				dictionary2.Add(Class84.smethod_0(-994284297), (byte[])dataTable.Rows[0][Class84.smethod_0(-994239405)]);
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994282804)]))
			{
				dictionary2.Add(Class84.smethod_0(-994239736), (byte[])dataTable.Rows[0][Class84.smethod_0(-994282804)]);
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239413)]))
			{
				dictionary2.Add(Class84.smethod_0(-994239744), (byte[])dataTable.Rows[0][Class84.smethod_0(-994239413)]);
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994288345)]))
			{
				dictionary2.Add(Class84.smethod_0(-994239688), (byte[])dataTable.Rows[0][Class84.smethod_0(-994288345)]);
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239421)]))
			{
				dictionary2.Add(Class84.smethod_0(-994239696), (byte[])dataTable.Rows[0][Class84.smethod_0(-994239421)]);
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239365)]))
			{
				dictionary2.Add(Class84.smethod_0(-994284483), (byte[])dataTable.Rows[0][Class84.smethod_0(-994239365)]);
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239373)]))
			{
				dictionary2.Add(Class84.smethod_0(-994239704), (byte[])dataTable.Rows[0][Class84.smethod_0(-994239373)]);
			}
			string text = Class84.smethod_0(-994239381);
			commandText = Class84.smethod_0(-994239387);
			commandText = string.Format(commandText, int_0, int_1);
			mySqlCommand_0.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				text = mySqlDataReader[0].ToString();
			}
			mySqlDataReader.Close();
			if (text == Class84.smethod_0(-994239381))
			{
				text = Class84.smethod_0(-994239213);
			}
			int num = 65;
			for (int i = 0; i < text.Length; i++)
			{
				string key = text[i].ToString();
				if (dictionary2.ContainsKey(key))
				{
					byte[] byte_2 = dictionary2[key];
					string key2 = ((char)num).ToString();
					dictionary[key2] = GClass27.smethod_3(byte_2);
					num++;
				}
			}
		}
		else
		{
			int_2 = 10;
		}
		GClass39 gClass = GClass22.smethod_7(mySqlCommand_0, int_0, int_1, 4);
		dictionary[Class84.smethod_0(-994239712)] = GClass18.smethod_0(gClass.object_0.ToString());
		if (bool_1)
		{
			GClass39 gClass2 = GClass22.smethod_6(mySqlCommand_0, int_0, int_1, 4);
			dictionary[Class84.smethod_0(-994239667)] = GClass18.smethod_0(gClass2.object_0.ToString());
		}
		List<string> list_ = new List<string>
		{
			Class84.smethod_0(-994239720),
			Class84.smethod_0(-994239728),
			Class84.smethod_0(-994284333),
			Class84.smethod_0(-994284297),
			Class84.smethod_0(-994239736),
			Class84.smethod_0(-994239744),
			Class84.smethod_0(-994239688),
			Class84.smethod_0(-994239696),
			Class84.smethod_0(-994284483),
			Class84.smethod_0(-994239704)
		};
		return smethod_3(dictionary, bool_0, list_);
	}

	private static Image smethod_7(MySqlCommand mySqlCommand_0, int int_0, int int_1, bool bool_0, bool bool_1, ref int int_2)
	{
		MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
		mySqlDataAdapter.SelectCommand = mySqlCommand_0;
		string commandText = Class84.smethod_0(-994239228) + int_1;
		mySqlDataAdapter.SelectCommand.CommandText = commandText;
		DataTable dataTable = new DataTable();
		mySqlDataAdapter.Fill(dataTable);
		Dictionary<string, Image> dictionary = new Dictionary<string, Image>();
		if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239431)]))
		{
			byte[] byte_ = (byte[])dataTable.Rows[0][Class84.smethod_0(-994239431)];
			dictionary[Class84.smethod_0(-994239763)] = GClass27.smethod_3(byte_);
		}
		else
		{
			dictionary[Class84.smethod_0(-994239763)] = smethod_4();
		}
		if (!bool_0)
		{
			int_2 = Convert.ToInt32(dataTable.Rows[0][Class84.smethod_0(-994239436)]);
			Dictionary<string, byte[]> dictionary2 = new Dictionary<string, byte[]>();
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994289925)]))
			{
				dictionary2.Add(Class84.smethod_0(-994239720), (byte[])dataTable.Rows[0][Class84.smethod_0(-994289925)]);
			}
			else
			{
				dictionary2.Add(Class84.smethod_0(-994239720), smethod_5());
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239453)]))
			{
				dictionary2.Add(Class84.smethod_0(-994239728), (byte[])dataTable.Rows[0][Class84.smethod_0(-994239453)]);
			}
			else
			{
				dictionary2.Add(Class84.smethod_0(-994239728), smethod_5());
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239397)]))
			{
				dictionary2.Add(Class84.smethod_0(-994284333), (byte[])dataTable.Rows[0][Class84.smethod_0(-994239397)]);
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239405)]))
			{
				dictionary2.Add(Class84.smethod_0(-994284297), (byte[])dataTable.Rows[0][Class84.smethod_0(-994239405)]);
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994282804)]))
			{
				dictionary2.Add(Class84.smethod_0(-994239736), (byte[])dataTable.Rows[0][Class84.smethod_0(-994282804)]);
			}
			string text = Class84.smethod_0(-994239381);
			commandText = Class84.smethod_0(-994239387);
			commandText = string.Format(commandText, int_0, int_1);
			mySqlCommand_0.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				text = mySqlDataReader[0].ToString();
			}
			mySqlDataReader.Close();
			if (text == Class84.smethod_0(-994239381))
			{
				text = Class84.smethod_0(-994239046);
			}
			int num = 65;
			for (int i = 0; i < text.Length; i++)
			{
				string key = text[i].ToString();
				if (dictionary2.ContainsKey(key))
				{
					byte[] byte_2 = dictionary2[key];
					string key2 = ((char)num).ToString();
					dictionary[key2] = GClass27.smethod_3(byte_2);
					num++;
				}
			}
		}
		else
		{
			int_2 = 5;
		}
		GClass39 gClass = GClass22.smethod_7(mySqlCommand_0, int_0, int_1, 0);
		dictionary[Class84.smethod_0(-994239712)] = GClass18.smethod_0(gClass.object_0.ToString());
		if (bool_1)
		{
			GClass39 gClass2 = GClass22.smethod_6(mySqlCommand_0, int_0, int_1, 0);
			dictionary[Class84.smethod_0(-994239667)] = GClass18.smethod_0(gClass2.object_0.ToString());
		}
		List<string> list_ = new List<string>
		{
			Class84.smethod_0(-994239720),
			Class84.smethod_0(-994239728),
			Class84.smethod_0(-994284333),
			Class84.smethod_0(-994284297),
			Class84.smethod_0(-994239736)
		};
		return smethod_3(dictionary, bool_0, list_);
	}

	private static Image smethod_8(MySqlCommand mySqlCommand_0, int int_0, int int_1, bool bool_0, bool bool_1)
	{
		MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
		mySqlDataAdapter.SelectCommand = mySqlCommand_0;
		string commandText = Class84.smethod_0(-994239050) + int_1;
		mySqlDataAdapter.SelectCommand.CommandText = commandText;
		DataTable dataTable = new DataTable();
		mySqlDataAdapter.Fill(dataTable);
		Dictionary<string, Image> dictionary = new Dictionary<string, Image>();
		if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239431)]))
		{
			byte[] byte_ = (byte[])dataTable.Rows[0][Class84.smethod_0(-994239431)];
			dictionary[Class84.smethod_0(-994239763)] = GClass27.smethod_3(byte_);
		}
		else
		{
			dictionary[Class84.smethod_0(-994239763)] = smethod_4();
		}
		if (!bool_0)
		{
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994289925)]))
			{
				byte[] byte_2 = (byte[])dataTable.Rows[0][Class84.smethod_0(-994289925)];
				dictionary[Class84.smethod_0(-994239720)] = GClass27.smethod_3(byte_2);
			}
			else
			{
				dictionary[Class84.smethod_0(-994239720)] = smethod_4();
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239453)]))
			{
				byte[] byte_3 = (byte[])dataTable.Rows[0][Class84.smethod_0(-994239453)];
				dictionary[Class84.smethod_0(-994239728)] = GClass27.smethod_3(byte_3);
			}
			else
			{
				dictionary[Class84.smethod_0(-994239728)] = smethod_4();
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239397)]))
			{
				byte[] byte_4 = (byte[])dataTable.Rows[0][Class84.smethod_0(-994239397)];
				dictionary[Class84.smethod_0(-994284333)] = GClass27.smethod_3(byte_4);
			}
			else
			{
				dictionary[Class84.smethod_0(-994284333)] = smethod_4();
			}
			if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239405)]))
			{
				byte[] byte_5 = (byte[])dataTable.Rows[0][Class84.smethod_0(-994239405)];
				dictionary[Class84.smethod_0(-994284297)] = GClass27.smethod_3(byte_5);
			}
			else
			{
				dictionary[Class84.smethod_0(-994284297)] = smethod_4();
			}
		}
		GClass39 gClass = GClass22.smethod_7(mySqlCommand_0, int_0, int_1, 1);
		dictionary[Class84.smethod_0(-994239712)] = GClass18.smethod_0(gClass.object_0.ToString());
		if (bool_1)
		{
			GClass39 gClass2 = GClass22.smethod_6(mySqlCommand_0, int_0, int_1, 1);
			dictionary[Class84.smethod_0(-994239667)] = GClass18.smethod_0(gClass2.object_0.ToString());
		}
		List<string> list_ = new List<string>
		{
			Class84.smethod_0(-994248276),
			Class84.smethod_0(-994248284),
			Class84.smethod_0(-994248228),
			Class84.smethod_0(-994248236)
		};
		return smethod_3(dictionary, bool_0, list_);
	}

	private static Image smethod_9(MySqlCommand mySqlCommand_0, int int_0, int int_1, bool bool_0, bool bool_1)
	{
		MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
		mySqlDataAdapter.SelectCommand = mySqlCommand_0;
		string commandText = Class84.smethod_0(-994238926) + int_1;
		mySqlDataAdapter.SelectCommand.CommandText = commandText;
		DataTable dataTable = new DataTable();
		mySqlDataAdapter.Fill(dataTable);
		Dictionary<string, Image> dictionary = new Dictionary<string, Image>();
		if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239431)]))
		{
			byte[] byte_ = (byte[])dataTable.Rows[0][Class84.smethod_0(-994239431)];
			dictionary[Class84.smethod_0(-994239763)] = GClass27.smethod_3(byte_);
		}
		else
		{
			dictionary[Class84.smethod_0(-994239763)] = smethod_4();
		}
		GClass39 gClass = GClass22.smethod_7(mySqlCommand_0, int_0, int_1, 2);
		dictionary[Class84.smethod_0(-994239712)] = GClass18.smethod_0(gClass.object_0.ToString());
		if (bool_1)
		{
			GClass39 gClass2 = GClass22.smethod_6(mySqlCommand_0, int_0, int_1, 2);
			dictionary[Class84.smethod_0(-994239667)] = GClass18.smethod_0(gClass2.object_0.ToString());
		}
		List<string> list_ = new List<string>();
		return smethod_3(dictionary, bool_0, list_);
	}

	private static Image smethod_10(MySqlCommand mySqlCommand_0, int int_0, int int_1, bool bool_0, bool bool_1)
	{
		MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
		mySqlDataAdapter.SelectCommand = mySqlCommand_0;
		string commandText = Class84.smethod_0(-994238833) + int_1;
		mySqlDataAdapter.SelectCommand.CommandText = commandText;
		DataTable dataTable = new DataTable();
		mySqlDataAdapter.Fill(dataTable);
		Dictionary<string, Image> dictionary = new Dictionary<string, Image>();
		if (!Convert.IsDBNull(dataTable.Rows[0][Class84.smethod_0(-994239431)]))
		{
			byte[] byte_ = (byte[])dataTable.Rows[0][Class84.smethod_0(-994239431)];
			dictionary[Class84.smethod_0(-994239763)] = GClass27.smethod_3(byte_);
		}
		else
		{
			dictionary[Class84.smethod_0(-994239763)] = smethod_4();
		}
		GClass39 gClass = GClass22.smethod_7(mySqlCommand_0, int_0, int_1, 3);
		if (gClass.genum5_0 == (GEnum5)1)
		{
			DataTable dataTable2 = (DataTable)gClass.object_0;
			string text = string.Empty;
			foreach (DataRow row in dataTable2.Rows)
			{
				if (!text.Equals(string.Empty))
				{
					text += Class84.smethod_0(-994263511);
				}
				text += row[Class84.smethod_0(-994238693)];
			}
			dictionary[Class84.smethod_0(-994239712)] = GClass18.smethod_0(text);
		}
		else
		{
			DataTable dataTable3 = (DataTable)gClass.object_0;
			if (dataTable3.Rows.Count > 0)
			{
				dictionary[Class84.smethod_0(-994239712)] = GClass18.smethod_24((byte[])dataTable3.Rows[0][Class84.smethod_0(-994238693)]);
			}
		}
		if (bool_1)
		{
			GClass39 gClass2 = GClass22.smethod_6(mySqlCommand_0, int_0, int_1, 3);
			if (gClass2.genum5_0 == (GEnum5)1)
			{
				DataTable dataTable4 = (DataTable)gClass2.object_0;
				string text2 = string.Empty;
				foreach (DataRow row2 in dataTable4.Rows)
				{
					if (!text2.Equals(string.Empty))
					{
						text2 += Class84.smethod_0(-994263511);
					}
					text2 += row2[Class84.smethod_0(-994238711)];
				}
				dictionary[Class84.smethod_0(-994239667)] = GClass18.smethod_0(text2);
			}
			else
			{
				DataTable dataTable5 = (DataTable)gClass2.object_0;
				if (dataTable5.Rows.Count > 0)
				{
					dictionary[Class84.smethod_0(-994239667)] = GClass18.smethod_24((byte[])dataTable5.Rows[0][Class84.smethod_0(-994238711)]);
				}
			}
		}
		List<string> list_ = new List<string>();
		return smethod_3(dictionary, bool_0, list_);
	}

	private static GClass70 smethod_11(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			int int_ = Convert.ToInt32(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			GClass51 gClass = GClass22.smethod_0(new MySqlCommand
			{
				Connection = mySqlConnection
			}, int_, 0, (GClass22.GEnum2)1);
			List<List<string>> list = new List<List<string>>();
			foreach (int item2 in gClass.list_0)
			{
				if (gClass.dictionary_0.ContainsKey(item2))
				{
					GClass16 gClass2 = gClass.dictionary_0[item2];
					List<string> list2 = new List<string> { item2.ToString() };
					int genum6_ = (int)gClass2.genum6_0;
					list2.Add(genum6_.ToString());
					list2.Add(gClass2.int_0.ToString());
					list2.Add(gClass2.double_2.ToString());
					list2.Add(gClass2.bool_0 ? Class84.smethod_0(-994248276) : Class84.smethod_0(-994274584));
					List<string> item = list2;
					list.Add(item);
				}
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994238715));
			if (list.Count == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994247224), Class84.smethod_0(-994238629));
			}
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994238596));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	private static GClass70 smethod_12(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			string string_ = string.Empty;
			if (!@class.method_1(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string format = Class84.smethod_0(-994238569);
			format = string.Format(format, string_);
			if (!text.Equals(Class84.smethod_0(-994274584)))
			{
				format = format + Class84.smethod_0(-994242328) + text;
			}
			format = format + Class84.smethod_0(-994242284) + text2;
			mySqlCommand.CommandText = format;
			List<List<string>> list2 = new List<List<string>>();
			List<List<string>> list3 = new List<List<string>>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString(),
					mySqlDataReader[3].ToString(),
					mySqlDataReader[4].ToString(),
					mySqlDataReader[5].ToString()
				};
				list3.Add(item);
			}
			mySqlDataReader.Close();
			if (list3.Count == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994247224), Class84.smethod_0(-994242261));
			}
			List<List<string>> list4 = new List<List<string>>();
			foreach (List<string> item15 in list3)
			{
				string arg = item15[0];
				string item2 = item15[1];
				string item3 = item15[2];
				string item4 = item15[3];
				string item5 = item15[4];
				string item6 = item15[5];
				format = Class84.smethod_0(-994242240);
				mySqlCommand.CommandText = string.Format(format, arg);
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					List<string> item7 = new List<string>
					{
						mySqlDataReader[0].ToString(),
						mySqlDataReader[1].ToString(),
						mySqlDataReader[2].ToString(),
						item2,
						item3,
						item4,
						item5,
						item6
					};
					list4.Add(item7);
				}
				mySqlDataReader.Close();
			}
			if (list4.Count == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994247224), Class84.smethod_0(-994242261));
			}
			foreach (List<string> item16 in list4)
			{
				int num = Convert.ToInt32(item16[0]);
				int num2 = Convert.ToInt32(item16[1]);
				string text3 = item16[2];
				string item8 = item16[3];
				_ = item16[4];
				string text4 = item16[5];
				string item9 = item16[6];
				string item10 = item16[7];
				int num3 = ((num2 != 0) ? num2 : num);
				format = Class84.smethod_0(-994242071);
				mySqlCommand.CommandText = string.Format(format, num3, string_);
				bool flag = Convert.ToInt32(mySqlCommand.ExecuteScalar()) > 0;
				format = Class84.smethod_0(-994241918);
				mySqlCommand.CommandText = string.Format(format, num);
				int num4 = 0;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					num4 = Convert.ToInt32(mySqlDataReader[0]);
				}
				mySqlDataReader.Close();
				int int_ = 10;
				int value = 0;
				int num5 = 1;
				int num6 = 1;
				int num7 = 1;
				int num8 = 1;
				int num9 = 0;
				format = Class84.smethod_0(-994241752);
				mySqlCommand.CommandText = string.Format(format, num3);
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					int_ = Convert.ToInt32(mySqlDataReader[0]);
					value = Convert.ToInt32(mySqlDataReader[1]);
					num5 = Convert.ToInt32(mySqlDataReader[2]);
					num6 = Convert.ToInt32(mySqlDataReader[3]);
					num7 = Convert.ToInt32(mySqlDataReader[4]);
					num8 = Convert.ToInt32(mySqlDataReader[5]);
					num9 = Convert.ToInt32(mySqlDataReader[6]);
				}
				mySqlDataReader.Close();
				format = Class84.smethod_0(-994241570);
				if (num4 == 1)
				{
					format = ((num2 == 0) ? (format + Class84.smethod_0(-994241240) + ((!flag) ? 1 : 0)) : (format + Class84.smethod_0(-994241269) + num));
				}
				format += Class84.smethod_0(-994241199);
				mySqlCommand.CommandText = string.Format(format, num3, string_);
				MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
				mySqlDataAdapter.SelectCommand = mySqlCommand;
				DataTable dataTable = new DataTable();
				mySqlDataAdapter.Fill(dataTable);
				if (dataTable.Rows.Count == 0)
				{
					continue;
				}
				foreach (DataRow row in dataTable.Rows)
				{
					double num10 = Convert.ToDouble(row[Class84.smethod_0(-994241168)]);
					int num11 = Convert.ToInt32(row[Class84.smethod_0(-994276441)]);
					int int_2 = ((Convert.ToInt32(row[Class84.smethod_0(-994241172)]) != 0) ? 1 : 0);
					string text5 = smethod_14(num11, int_2);
					string text6 = smethod_13(num10, Convert.ToDouble(value), num11);
					string empty = string.Empty;
					if (num7 == 1)
					{
						if (num11 == 2)
						{
							empty = ((num11 != 2) ? Class84.smethod_0(-994241121) : (num10 + Class84.smethod_0(-994263511)));
							empty = Class84.smethod_0(-994241143) + empty;
							empty = empty + Class84.smethod_0(-994241145) + row[Class84.smethod_0(-994241099)]?.ToString() + Class84.smethod_0(-994263511);
							empty = empty + Class84.smethod_0(-994241118) + row[Class84.smethod_0(-994241072)];
						}
						else
						{
							empty = Class84.smethod_0(-994241075);
						}
					}
					else
					{
						empty = Class84.smethod_0(-994241042);
					}
					string text7 = text3 + Class84.smethod_0(-994263511);
					text7 = text7 + Class84.smethod_0(-994241016) + text4 + Class84.smethod_0(-994263511);
					text7 = text7 + Class84.smethod_0(-994240966) + row[Class84.smethod_0(-994188552)]?.ToString() + Class84.smethod_0(-994263511);
					text7 = text7 + Class84.smethod_0(-994240982) + row[Class84.smethod_0(-994240936)]?.ToString() + Class84.smethod_0(-994240938);
					string item11 = Class84.smethod_0(-994240957);
					string item12 = Class84.smethod_0(-994240901);
					string text8 = Class84.smethod_0(-994240919) + value + Class84.smethod_0(-994263511);
					if (num7 == 1)
					{
						text8 = text8 + Class84.smethod_0(-994240869) + text6 + Class84.smethod_0(-994263511);
						text8 = text8 + Class84.smethod_0(-994240887) + text5;
						if (num11 == 2)
						{
							item12 = ColorTranslator.ToHtml(new GClass26(0, int_, -99).method_2(Convert.ToInt32(num10)));
							item11 = num10.ToString();
						}
					}
					string item13 = JsonConvert.SerializeObject(new List<string>
					{
						text3,
						text4,
						item8,
						item11,
						item12,
						item9,
						num11.ToString(),
						int_2.ToString(),
						num5.ToString(),
						num6.ToString(),
						num7.ToString(),
						num8.ToString(),
						num9.ToString(),
						item10
					});
					List<string> item14 = new List<string> { text7, empty, text8, item13, item12 };
					list2.Add(item14);
				}
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994240840));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994240807));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static string smethod_13(double double_0, double double_1, int int_0)
	{
		if (int_0 != 2)
		{
			return Class84.smethod_0(-994240783);
		}
		if (double_0 >= double_1)
		{
			return Class84.smethod_0(-994240790);
		}
		return Class84.smethod_0(-994240794);
	}

	private static string smethod_14(int int_0, int int_1)
	{
		string text = ((int_1 == 1) ? Class84.smethod_0(-994240749) : string.Empty);
		if (int_0 == -1)
		{
			text += Class84.smethod_0(-994240764);
		}
		if (int_0 == 0)
		{
			text += Class84.smethod_0(-994240718);
		}
		if (int_0 == 1)
		{
			text += Class84.smethod_0(-994240677);
		}
		if (int_0 == 2)
		{
			text += Class84.smethod_0(-994240648);
		}
		return text;
	}

	private static GClass70 smethod_15(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			string string_ = string.Empty;
			if (!@class.method_1(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = string.Format(Class84.smethod_0(-994240650), string_)
			};
			List<List<string>> list = new List<List<string>>();
			List<string> item = new List<string>
			{
				Class84.smethod_0(-994274584),
				Class84.smethod_0(-994244512)
			};
			list.Add(item);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994244472));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}
}
