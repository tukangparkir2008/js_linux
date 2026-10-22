using System;
using System.Reflection;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Yim.Jibas.JendelaSekolah.Common.Data;

internal sealed class Class303
{
	private sealed class Class304
	{
		public GClass4 gclass4_0;

		public GClass41 gclass41_0;

		public JsRequest jsRequest_0;

		internal void method_0()
		{
			smethod_2(gclass4_0, gclass41_0, jsRequest_0);
		}
	}

	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		Class304 @class = new Class304();
		@class.gclass4_0 = gclass4_0;
		@class.gclass41_0 = gclass41_0;
		@class.jsRequest_0 = jsRequest_0;
		if (@class.jsRequest_0.Protocol == JsProtocol.UserRequestToSchool)
		{
			Parallel.Invoke(@class.method_0);
		}
	}

	private static void smethod_1(int int_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994197706), int_0);
			mySqlCommand.ExecuteNonQuery();
			mySqlCommand.CommandText = Class84.smethod_0(-994197599);
			mySqlCommand.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static void smethod_2(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		smethod_1(jsRequest_0.UserRequest.Protocol);
		gclass4_0.method_11();
		switch (jsRequest_0.UserRequest.Protocol)
		{
		case 115:
		case 116:
		case 117:
		case 118:
		case 119:
		case 120:
		case 121:
		case 122:
		case 123:
		case 124:
			Class310.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 132:
		case 133:
		case 134:
			Class271.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 102:
		case 105:
		case 106:
		case 107:
		case 131:
		case 137:
		case 138:
			Class284.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 125:
		case 126:
		case 141:
		case 142:
			GClass47.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 127:
		case 128:
		case 129:
		case 139:
		case 140:
		case 143:
		case 144:
		case 145:
		case 1533:
			Class177.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 130:
		case 149:
		case 150:
		case 151:
		case 152:
			Class148.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 103:
		case 104:
		case 108:
		case 109:
		case 110:
		case 111:
		case 112:
		case 113:
		case 114:
		case 146:
		case 147:
		case 160:
			Class321.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 153:
		case 154:
		case 155:
		case 156:
		case 158:
		case 161:
		case 163:
			Class274.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 166:
			Class173.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 2500:
			Class331.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 2102:
		case 2105:
		case 2106:
		case 2107:
		case 2131:
			Class261.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 135:
		case 2135:
			Class278.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 101:
		case 136:
		case 148:
		case 165:
		case 2136:
			Class158.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 2111:
		case 2113:
		case 2114:
		case 2147:
		case 2211:
		case 2212:
		case 2213:
		case 2214:
		case 2215:
		case 2216:
		case 2217:
		case 2218:
		case 2219:
		case 2220:
			Class164.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 2221:
		case 2222:
		case 2223:
		case 2224:
		case 2225:
		case 2226:
		case 2227:
			Class161.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 2271:
		case 2272:
		case 2273:
		case 2274:
		case 2275:
		case 2276:
		case 2277:
		case 2278:
			Class126.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 2279:
		case 2280:
		case 2281:
		case 2282:
		case 2283:
		case 2284:
			Class285.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 2155:
		case 2156:
		case 2157:
		case 2200:
		case 2285:
		case 2286:
		case 2287:
		case 2288:
		case 2289:
		case 2290:
		case 2291:
		case 2292:
		case 2293:
		case 2294:
			Class325.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 2228:
		case 2229:
		case 2230:
		case 2295:
		case 2296:
		case 2297:
		case 2298:
		case 2299:
		case 2300:
			Class136.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 2260:
		case 2266:
		case 2301:
			Class203.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 2231:
		case 2232:
		case 2233:
		case 2234:
		case 2235:
		case 2236:
		case 2237:
		case 2238:
		case 2239:
		case 2240:
		case 2241:
		case 2242:
		case 2243:
		case 2244:
		case 2245:
		case 2246:
		case 2247:
		case 2248:
		case 2249:
		case 2250:
		case 2251:
		case 2252:
		case 2253:
		case 2254:
		case 2255:
		case 2256:
		case 2257:
		case 2258:
		case 2259:
		case 2262:
		case 2263:
		case 2264:
		case 2265:
		case 2312:
			Class195.smethod_1(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 2305:
		case 2306:
		case 2307:
		case 2308:
		case 2309:
		case 2310:
		case 2311:
		case 2313:
		case 2314:
		case 2315:
			Class166.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 2127:
		case 2128:
		case 2129:
		case 2139:
		case 2140:
		case 2143:
		case 2144:
		case 2145:
		case 2209:
		case 2210:
		case 2302:
		case 2303:
		case 2304:
		case 2316:
		case 2317:
			Class329.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 2318:
		case 2319:
		case 2320:
		case 2321:
		case 2322:
		case 2323:
		case 2324:
			Class342.smethod_2(gclass4_0, gclass41_0, jsRequest_0);
			break;
		case 2201:
		case 2202:
		case 2203:
		case 2204:
		case 2205:
		case 2206:
		case 2207:
		case 2208:
		case 2267:
		case 2268:
		case 2269:
		case 2270:
		case 2325:
		case 2326:
		case 2327:
		case 2328:
			Class210.smethod_0(gclass4_0, gclass41_0, jsRequest_0);
			break;
		}
	}
}
