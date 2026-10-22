using System;
using System.Data;
using MySql.Data.MySqlClient;

internal sealed class Class160
{
	private static void smethod_0(MySqlCommand mySqlCommand_0)
	{
		try
		{
			mySqlCommand_0.ExecuteNonQuery();
			Class162.smethod_1(Class84.smethod_0(-994094157), mySqlCommand_0.CommandText);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994094175), ex.Message, ex);
			Class125.smethod_1(Class84.smethod_0(-994094175), mySqlCommand_0.CommandText, null);
		}
	}

	private static void smethod_1(MySqlCommand mySqlCommand_0, string string_0)
	{
		try
		{
			mySqlCommand_0.CommandText = string_0;
			mySqlCommand_0.ExecuteNonQuery();
			Class162.smethod_1(Class84.smethod_0(-994094157), mySqlCommand_0.CommandText);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994094175), ex.Message, ex);
			Class125.smethod_1(Class84.smethod_0(-994094175), mySqlCommand_0.CommandText, null);
		}
	}

	public static void smethod_2(MySqlCommand mySqlCommand_0)
	{
		smethod_20(mySqlCommand_0);
		smethod_10(mySqlCommand_0);
		smethod_11(mySqlCommand_0);
		smethod_12(mySqlCommand_0);
		smethod_19(mySqlCommand_0);
		smethod_17(mySqlCommand_0);
		smethod_18(mySqlCommand_0);
		smethod_3(mySqlCommand_0);
		smethod_9(mySqlCommand_0);
		smethod_8(mySqlCommand_0);
		smethod_7(mySqlCommand_0);
		smethod_6(mySqlCommand_0);
		smethod_4(mySqlCommand_0);
		smethod_5(mySqlCommand_0);
	}

	private static void smethod_3(MySqlCommand mySqlCommand_0)
	{
		if (smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994094094)))
		{
			string string_ = Class84.smethod_0(-994094099);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994094078);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093990);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093955);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093936);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093908);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093885);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093850);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093765);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093732);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093710);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093688);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093663);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093573);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093547);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093527);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093495);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093459);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994093429);
			smethod_1(mySqlCommand_0, string_);
		}
	}

	private static void smethod_4(MySqlCommand mySqlCommand_0)
	{
		if (!smethod_15(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994216691), Class84.smethod_0(-994260111)))
		{
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994093347));
		}
	}

	private static void smethod_5(MySqlCommand mySqlCommand_0)
	{
		string empty = string.Empty;
		if (!smethod_13(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994093231), Class84.smethod_0(-994093191)))
		{
			empty = Class84.smethod_0(-994093212);
			smethod_1(mySqlCommand_0, empty);
		}
		if (!smethod_13(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994093113), Class84.smethod_0(-994093067)))
		{
			empty = Class84.smethod_0(-994093082);
			smethod_1(mySqlCommand_0, empty);
		}
		if (!smethod_13(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994273283), Class84.smethod_0(-994097070)))
		{
			empty = Class84.smethod_0(-994097082);
			smethod_1(mySqlCommand_0, empty);
		}
		if (!smethod_13(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994216691), Class84.smethod_0(-994096980)))
		{
			empty = Class84.smethod_0(-994096935);
			smethod_1(mySqlCommand_0, empty);
		}
		if (!smethod_13(mySqlCommand_0, Class84.smethod_0(-994302257), Class84.smethod_0(-994260157), Class84.smethod_0(-994096879)))
		{
			empty = Class84.smethod_0(-994096894);
			smethod_1(mySqlCommand_0, empty);
		}
		if (!smethod_13(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994096774), Class84.smethod_0(-994096791)))
		{
			empty = Class84.smethod_0(-994096741);
			smethod_1(mySqlCommand_0, empty);
		}
	}

	private static void smethod_6(MySqlCommand mySqlCommand_0)
	{
		if (!smethod_15(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994239993), Class84.smethod_0(-994096699)))
		{
			string string_ = Class84.smethod_0(-994096662);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994096533);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994096345);
			smethod_1(mySqlCommand_0, string_);
		}
	}

	private static void smethod_7(MySqlCommand mySqlCommand_0)
	{
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994302257), Class84.smethod_0(-994096067)))
		{
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994096096));
		}
	}

	private static void smethod_8(MySqlCommand mySqlCommand_0)
	{
		if (!smethod_15(mySqlCommand_0, Class84.smethod_0(-994095503), Class84.smethod_0(-994095506), Class84.smethod_0(-994123023)))
		{
			string string_ = Class84.smethod_0(-994095471);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994095201);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994099199);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994099093);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994098929);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994098636);
			smethod_1(mySqlCommand_0, string_);
			string_ = Class84.smethod_0(-994098457);
			smethod_1(mySqlCommand_0, string_);
		}
	}

	private static void smethod_9(MySqlCommand mySqlCommand_0)
	{
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994302257), Class84.smethod_0(-994098386)))
		{
			mySqlCommand_0.CommandText = Class84.smethod_0(-994098340);
			smethod_0(mySqlCommand_0);
		}
	}

	private static void smethod_10(MySqlCommand mySqlCommand_0)
	{
		string commandText = Class84.smethod_0(-994097971);
		mySqlCommand_0.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			string text = mySqlDataReader[0].ToString();
			mySqlDataReader.Close();
			if (text.Equals(Class84.smethod_0(-994097735)))
			{
				commandText = Class84.smethod_0(-994097742);
				mySqlCommand_0.CommandText = commandText;
				smethod_0(mySqlCommand_0);
			}
		}
		else
		{
			mySqlDataReader.Close();
		}
	}

	private static void smethod_11(MySqlCommand mySqlCommand_0)
	{
		string commandText = Class84.smethod_0(-994097578);
		mySqlCommand_0.CommandText = commandText;
		if (Convert.ToInt32(mySqlCommand_0.ExecuteScalar()) == 0)
		{
			commandText = Class84.smethod_0(-994097385);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994097158);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
	}

	private static void smethod_12(MySqlCommand mySqlCommand_0)
	{
		string commandText = Class84.smethod_0(-994084754);
		mySqlCommand_0.CommandText = commandText;
		if (Convert.ToInt32(mySqlCommand_0.ExecuteScalar()) == 0)
		{
			commandText = Class84.smethod_0(-994084569);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994084338);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
	}

	private static bool smethod_13(MySqlCommand mySqlCommand_0, string string_0, string string_1, string string_2)
	{
		try
		{
			bool result = false;
			string commandText = Class84.smethod_0(-994084199) + string_0 + Class84.smethod_0(-994272055) + string_1 + Class84.smethod_0(-994084224) + string_2 + Class84.smethod_0(-994271698);
			mySqlCommand_0.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				result = true;
			}
			mySqlDataReader.Close();
			return result;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994094175), ex.Message, ex);
			Class125.smethod_1(Class84.smethod_0(-994094175), mySqlCommand_0.CommandText, null);
			return false;
		}
	}

	private static bool smethod_14(MySqlCommand mySqlCommand_0, string string_0, string string_1)
	{
		try
		{
			string commandText = Class84.smethod_0(-994084182) + string_0 + Class84.smethod_0(-994084057) + string_1 + Class84.smethod_0(-994271698);
			mySqlCommand_0.CommandText = commandText;
			return Convert.ToInt32(mySqlCommand_0.ExecuteScalar()) > 0;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994094175), ex.Message, ex);
			Class125.smethod_1(Class84.smethod_0(-994094175), mySqlCommand_0.CommandText, null);
			return false;
		}
	}

	private static bool smethod_15(MySqlCommand mySqlCommand_0, string string_0, string string_1, string string_2)
	{
		try
		{
			string commandText = Class84.smethod_0(-994083996) + string_0 + Class84.smethod_0(-994084057) + string_1 + Class84.smethod_0(-994083822) + string_2 + Class84.smethod_0(-994271698);
			mySqlCommand_0.CommandText = commandText;
			return Convert.ToInt32(mySqlCommand_0.ExecuteScalar()) > 0;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994094175), ex.Message, ex);
			Class125.smethod_1(Class84.smethod_0(-994094175), mySqlCommand_0.CommandText, null);
			return false;
		}
	}

	private static bool smethod_16(MySqlCommand mySqlCommand_0, string string_0, string string_1)
	{
		try
		{
			string commandText = Class84.smethod_0(-994083745) + string_0 + Class84.smethod_0(-994083647) + string_1 + Class84.smethod_0(-994271698);
			mySqlCommand_0.CommandText = commandText;
			return Convert.ToInt32(mySqlCommand_0.ExecuteScalar()) > 0;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994094175), ex.Message, ex);
			Class125.smethod_1(Class84.smethod_0(-994094175), mySqlCommand_0.CommandText, null);
			return false;
		}
	}

	private static void smethod_17(MySqlCommand mySqlCommand_0)
	{
		if (smethod_16(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994083583)))
		{
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994083551));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994083481));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994083363));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994083309));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994083248));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994083171));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994083110));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994083046));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994082982));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994082918));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994082852));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086882));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086832));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086754));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086692));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086630));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086567));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086504));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086489));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086374));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086307));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086256));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086177));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086114));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086051));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086042));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085969));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085912));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085833));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085770));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085707));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085647));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085571));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085511));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085500));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085425));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085366));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085294));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085222));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085214));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085151));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085088));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994085009));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994084956));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088935));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088866));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088814));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088746));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088694));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088620));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088546));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088488));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088417));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088362));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088307));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088246));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088169));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088108));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088043));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087978));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087913));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087860));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087807));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087738));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087666));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087594));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087522));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087514));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087442));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087370));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087307));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087244));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087181));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087119));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994087041));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086979));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994086919));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994091003));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994090943));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994090867));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994090807));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994090731));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994090666));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994090601));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994090552));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994090485));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994090418));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994090367));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994090297));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994090179));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994090125));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994090067));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994090009));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994089903));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994089828));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994089817));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994089758));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994089683));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994089624));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994089549));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994089496));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994089427));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994089374));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994089256));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994089186));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994089132));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994089060));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994089052));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994088980));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535383));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535306));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535245));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535171));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535161));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535103));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535040));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534961));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534898));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534834));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534770));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534706));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534642));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534578));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534514));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534454));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534378));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534318));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534244));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534234));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534176));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534101));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994534026));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994533967));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994533890));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994533829));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994533768));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994533702));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994533636));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994533570));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994533519));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994533452));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994533385));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994537417));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994537353));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994537289));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994537234));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994537179));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994537060));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994536993));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994536942));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994536875));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994536823));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994536755));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994536703));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994536582));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994536525));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994536468));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994536402));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994536352));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994536286));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994536167));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994536112));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994536041));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535979));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535917));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535855));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535790));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535725));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535660));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535586));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535528));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535518));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994535444));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994539466));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994539408));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994539332));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994539272));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994539260));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994539185));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994539126));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994539051));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538977));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538919));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538909));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538846));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538783));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538720));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538656));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538592));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538528));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538453));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538378));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538319));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538242));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538181));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538120));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538109));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994538034));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994537975));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994537901));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994537827));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994537817));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994537759));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994537685));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994537611));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994537548));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994537485));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994541518));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994541442));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994541382));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994541370));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994541307));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994541244));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994541181));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994541119));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994541041));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540979));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540919));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540843));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540783));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540709));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540699));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540625));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540573));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540505));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540389));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540327));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540313));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540251));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540188));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540125));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540062));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994540000));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994539922));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994539860));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994539799));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994539722));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994539661));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994539599));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994539521));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994527171));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994527161));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994527103));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994527029));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994526967));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994526889));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994526827));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994526776));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994526709));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994526642));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994526569));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994526512));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994526439));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994526369));
			smethod_1(mySqlCommand_0, Class84.smethod_0(-994526315));
		}
	}

	private static void smethod_18(MySqlCommand mySqlCommand_0)
	{
		if (smethod_16(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994526261)))
		{
			string commandText = Class84.smethod_0(-994526232);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994526156);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994526096);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994526020)))
		{
			string commandText = Class84.smethod_0(-994525990);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994525664);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994525270);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (smethod_16(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994528970)))
		{
			string commandText = Class84.smethod_0(-994528940);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994528879);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994528802);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994528741)))
		{
			string commandText = Class84.smethod_0(-994528710);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994528383);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994527987);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (smethod_16(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994527606)))
		{
			string commandText = Class84.smethod_0(-994527564);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994527491);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994527482);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994527409)))
		{
			string commandText = Class84.smethod_0(-994527382);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994531076);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994530748);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (smethod_16(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994530354)))
		{
			string commandText = Class84.smethod_0(-994530327);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994530253);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994530179);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994530169)))
		{
			string commandText = Class84.smethod_0(-994530141);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994529739);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994529349);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (smethod_16(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994533116)))
		{
			string commandText = Class84.smethod_0(-994533076);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994533005);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994532934);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994532927)))
		{
			string commandText = Class84.smethod_0(-994532886);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994532486);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994532146);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (smethod_16(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994531755)))
		{
			string commandText = Class84.smethod_0(-994531728);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994531654);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994531644);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994531570)))
		{
			string commandText = Class84.smethod_0(-994531542);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994518851);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994518523);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (smethod_16(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994518172)))
		{
			string commandText = Class84.smethod_0(-994518132);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994518061);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994517990);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994093393), Class84.smethod_0(-994517983)))
		{
			string commandText = Class84.smethod_0(-994517942);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994517542);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994517202);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (smethod_16(mySqlCommand_0, Class84.smethod_0(-994520907), Class84.smethod_0(-994520926)))
		{
			string commandText = Class84.smethod_0(-994520884);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994520812);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994520740);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994520907), Class84.smethod_0(-994520732)))
		{
			string commandText = Class84.smethod_0(-994520689);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994520304);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994519962);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994519569)))
		{
			string commandText = Class84.smethod_0(-994519530);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994519460);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994519454);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994519384)))
		{
			string commandText = Class84.smethod_0(-994519343);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994523103);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994522699);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994522308)))
		{
			string commandText = Class84.smethod_0(-994522280);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994522269);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994522194);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994522135)))
		{
			string commandText = Class84.smethod_0(-994522089);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994521699);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994521320);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994525083)))
		{
			string commandText = Class84.smethod_0(-994525054);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994524978);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994524918);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994524842)))
		{
			string commandText = Class84.smethod_0(-994524811);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994524420);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994524089);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994523708)))
		{
			string commandText = Class84.smethod_0(-994523673);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994523559);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994523493);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994523427)))
		{
			string commandText = Class84.smethod_0(-994523406);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994510722);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994510352);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994509964)))
		{
			string commandText = Class84.smethod_0(-994509929);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994509879);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994509813);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994509747)))
		{
			string commandText = Class84.smethod_0(-994509726);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994509331);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994508948);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994512658)))
		{
			string commandText = Class84.smethod_0(-994512627);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994512565);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994512503);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994512425)))
		{
			string commandText = Class84.smethod_0(-994512408);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994512002);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994511673);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994511293)))
		{
			string commandText = Class84.smethod_0(-994511249);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994510863);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994514619);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994514226)))
		{
			string commandText = Class84.smethod_0(-994514194);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994513804);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994513445);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994513120)))
		{
			string commandText = Class84.smethod_0(-994513085);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994516779)))
		{
			string commandText = Class84.smethod_0(-994513445);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994516746);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994516356);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994516027)))
		{
			string commandText = Class84.smethod_0(-994515999);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994515645);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994515240);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_16(mySqlCommand_0, Class84.smethod_0(-994568144), Class84.smethod_0(-994568146)))
		{
			string commandText = Class84.smethod_0(-994568118);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994567691);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994567277);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
	}

	private static void smethod_19(MySqlCommand mySqlCommand_0)
	{
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994302257), Class84.smethod_0(-994566859)))
		{
			string commandText = Class84.smethod_0(-994566875);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994566400)))
		{
			string commandText = Class84.smethod_0(-994566340);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994569821)))
		{
			string commandText = Class84.smethod_0(-994569769);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994569368)))
		{
			string commandText = Class84.smethod_0(-994569313);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994568909)))
		{
			string commandText = Class84.smethod_0(-994568923);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994572229)))
		{
			string commandText = Class84.smethod_0(-994572253);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994571503)))
		{
			string commandText = Class84.smethod_0(-994571463);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994570706)))
		{
			string commandText = Class84.smethod_0(-994570669);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994570248)))
		{
			string commandText = Class84.smethod_0(-994570270);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994573984)))
		{
			string commandText = Class84.smethod_0(-994573935);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994573527)))
		{
			string commandText = Class84.smethod_0(-994573477);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994572872)))
		{
			string commandText = Class84.smethod_0(-994572884);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994559848)))
		{
			string commandText = Class84.smethod_0(-994559849);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994558987)))
		{
			string commandText = Class84.smethod_0(-994558952);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994558061)))
		{
			string commandText = Class84.smethod_0(-994558075);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994561673)))
		{
			string commandText = Class84.smethod_0(-994561635);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994561227)))
		{
			string commandText = Class84.smethod_0(-994561242);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994560603)))
		{
			string commandText = Class84.smethod_0(-994560568);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994560113)))
		{
			string commandText = Class84.smethod_0(-994560078);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_15(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994563767), Class84.smethod_0(-994563714)))
		{
			string commandText = Class84.smethod_0(-994563732);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994563456)))
		{
			string commandText = Class84.smethod_0(-994563402);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994094140), Class84.smethod_0(-994562979)))
		{
			string commandText = Class84.smethod_0(-994562996);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		if (!smethod_14(mySqlCommand_0, Class84.smethod_0(-994302257), Class84.smethod_0(-994562618)))
		{
			string commandText = Class84.smethod_0(-994562570);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
	}

	private static void smethod_20(MySqlCommand mySqlCommand_0)
	{
		IDataReader dataReader = null;
		try
		{
			string commandText = Class84.smethod_0(-994562272);
			mySqlCommand_0.CommandText = commandText;
			dataReader = mySqlCommand_0.ExecuteReader();
			if (dataReader.Read())
			{
				dataReader.Close();
				return;
			}
			dataReader.Close();
			commandText = Class84.smethod_0(-994562238);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994562208);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994562158);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994565733);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994565136);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994564901);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994564336);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994551548);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994551151);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994550811);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994550553);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994550204);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994549776);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994553280);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994552704);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994552447);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994552170);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994555853);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994555430);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994555259);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994555028);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
			commandText = Class84.smethod_0(-994554277);
			mySqlCommand_0.CommandText = commandText;
			smethod_0(mySqlCommand_0);
		}
		finally
		{
			if (dataReader != null && !dataReader.IsClosed)
			{
				dataReader.Close();
			}
		}
	}
}
