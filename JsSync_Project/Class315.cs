using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

internal sealed class Class315
{
	private readonly Class235 class235_0;

	private readonly string string_0;

	private readonly string string_1;

	private readonly string string_2;

	private readonly string string_3;

	public Class315(string string_4, string string_5, string string_6, string string_7, Class235 class235_1)
	{
		string_0 = string_4;
		string_1 = string_5;
		string_2 = string_6;
		string_3 = string_7;
		class235_0 = class235_1;
	}

	public void method_0()
	{
		try
		{
			Task.Run((Action)method_2);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private void method_1()
	{
		int num = 0;
		string format = Class84.smethod_0(-994247548);
		format = string.Format(format, string_0, string_1, string_2, string_3);
		MySqlConnection mySqlConnection = null;
		while (num < 1)
		{
			try
			{
				mySqlConnection = new MySqlConnection(format);
				mySqlConnection.Open();
				MySqlCommand mySqlCommand = new MySqlCommand
				{
					Connection = mySqlConnection,
					CommandText = Class84.smethod_0(-994247438)
				};
				mySqlCommand.ExecuteNonQuery();
				mySqlCommand.CommandText = Class84.smethod_0(-994557772);
				if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
				{
					class235_0.vmethod_1(Class84.smethod_0(-994247276) + string_0 + Class84.smethod_0(-994263069) + string_1);
					break;
				}
				Class160.smethod_2(mySqlCommand);
				Class206.smethod_0();
				class235_0.vmethod_0(Class84.smethod_0(-994247224));
				break;
			}
			catch (Exception ex)
			{
				Class125.smethod_1(Class84.smethod_0(-994557661), ex.Message, ex);
				num++;
				if (num == 1)
				{
					class235_0.vmethod_1(ex.Message);
					break;
				}
				Thread.Sleep(3000);
			}
			finally
			{
				mySqlConnection?.Close();
			}
		}
	}

	private void method_2()
	{
		method_1();
	}
}
