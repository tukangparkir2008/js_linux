using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal sealed class Class337
{
	private static Rijndael rijndael_0;

	private static ICryptoTransform icryptoTransform_0;

	private static ICryptoTransform icryptoTransform_1;

	private static bool bool_0;

	private static void smethod_0(string string_0, string string_1)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		rijndael_0 = new RijndaelManaged();
		rijndael_0.Mode = CipherMode.CBC;
		rijndael_0.Padding = PaddingMode.PKCS7;
		rijndael_0.Key = mD.ComputeHash(Encoding.ASCII.GetBytes(string_0));
		rijndael_0.IV = Encoding.ASCII.GetBytes(string_1);
		icryptoTransform_0 = rijndael_0.CreateEncryptor();
		icryptoTransform_1 = rijndael_0.CreateDecryptor();
		bool_0 = false;
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0, string string_1)
	{
		if (!bool_0)
		{
			smethod_0(string_0, string_1);
		}
		return icryptoTransform_0.TransformFinalBlock(byte_0, 0, byte_0.Length);
	}

	public static string smethod_2(string string_0, string string_1, string string_2)
	{
		if (!bool_0)
		{
			smethod_0(string_1, string_2);
		}
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		bytes = icryptoTransform_0.TransformFinalBlock(bytes, 0, bytes.Length);
		return Convert.ToBase64String(bytes);
	}

	public static byte[] smethod_3(byte[] byte_0, string string_0, string string_1)
	{
		if (!bool_0)
		{
			smethod_0(string_0, string_1);
		}
		return icryptoTransform_1.TransformFinalBlock(byte_0, 0, byte_0.Length);
	}

	public static string smethod_4(string string_0, string string_1, string string_2)
	{
		object[] object_ = new object[3] { string_0, string_1, string_2 };
		return (string)Class324.smethod_0().method_101(Class324.smethod_2(), "D/9c$BkV9n", object_);
	}

	public static void smethod_5(string string_0, string string_1, string string_2, string string_3)
	{
		if (!bool_0)
		{
			smethod_0(string_2, string_3);
		}
		FileStream fileStream = null;
		try
		{
			fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
			int num = (int)fileStream.Length;
			byte[] array = new byte[num];
			int num2 = 0;
			int num3;
			while ((num3 = fileStream.Read(array, num2, num - num2)) > 0)
			{
				num2 += num3;
			}
			fileStream.Close();
			byte[] array2 = icryptoTransform_0.TransformFinalBlock(array, 0, array.Length);
			fileStream = new FileStream(string_1, FileMode.Create, FileAccess.Write);
			fileStream.Write(array2, 0, array2.Length);
			fileStream.Close();
		}
		catch (Exception)
		{
			fileStream?.Close();
			throw;
		}
	}

	public static void smethod_6(string string_0, string string_1, string string_2, string string_3)
	{
		if (!bool_0)
		{
			smethod_0(string_2, string_3);
		}
		FileStream fileStream = null;
		try
		{
			fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
			int num = (int)fileStream.Length;
			byte[] array = new byte[num];
			int num2 = 0;
			int num3;
			while ((num3 = fileStream.Read(array, num2, num - num2)) > 0)
			{
				num2 += num3;
			}
			fileStream.Close();
			byte[] array2 = icryptoTransform_1.TransformFinalBlock(array, 0, array.Length);
			fileStream = new FileStream(string_1, FileMode.Create, FileAccess.Write);
			fileStream.Write(array2, 0, array2.Length);
			fileStream.Close();
		}
		catch (Exception)
		{
			fileStream?.Close();
			throw;
		}
	}

	public static string smethod_7(string string_0)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		byte[] array = new MD5CryptoServiceProvider().ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.Append(b.ToString(Class84.smethod_0(-994092488)).ToLower());
		}
		return stringBuilder.ToString();
	}
}
