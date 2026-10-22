internal static class Class47
{
	public static bool smethod_0(int[] int_0, int[] int_1)
	{
		if (int_0 == int_1)
		{
			return true;
		}
		if (int_0 != null && int_1 != null)
		{
			if (int_0.Length != int_1.Length)
			{
				return false;
			}
			int num = 0;
			while (true)
			{
				if (num < int_0.Length)
				{
					if (int_0[num] != int_1[num])
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
	}
}
