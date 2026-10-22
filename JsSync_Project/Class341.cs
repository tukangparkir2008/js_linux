using System;
using MySql.Data.MySqlClient;

internal sealed class Class341
{
	public string string_0;

	public string string_1;

	public DateTime dateTime_0;

	public string string_2;

	public string string_3;

	public string string_4;

	public string string_5;

	public string string_6;

	public static Class341 smethod_0(MySqlConnection mySqlConnection_0, string string_7)
	{
		MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994277061) + string_7 + Class84.smethod_0(-994271698), mySqlConnection_0).ExecuteReader();
		if (!mySqlDataReader.Read())
		{
			mySqlDataReader.Close();
			return null;
		}
		Class341 result = new Class341
		{
			string_0 = mySqlDataReader[Class84.smethod_0(-994277056)].ToString(),
			string_1 = mySqlDataReader[Class84.smethod_0(-994276993)].ToString(),
			dateTime_0 = Convert.ToDateTime(mySqlDataReader[Class84.smethod_0(-994277024)]),
			string_2 = mySqlDataReader[Class84.smethod_0(-994276975)].ToString(),
			string_3 = mySqlDataReader[Class84.smethod_0(-994276989)].ToString(),
			string_4 = mySqlDataReader[Class84.smethod_0(-994276939)].ToString(),
			string_5 = string_7,
			string_6 = mySqlDataReader[Class84.smethod_0(-994276954)].ToString()
		};
		mySqlDataReader.Close();
		return result;
	}
}
