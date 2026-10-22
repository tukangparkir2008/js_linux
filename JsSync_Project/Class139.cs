using System;
using System.Net;

internal sealed class Class139 : WebClient
{
	private readonly CookieContainer cookieContainer_0;

	public Class139(CookieContainer cookieContainer_1)
	{
		cookieContainer_0 = cookieContainer_1;
	}

	protected override WebRequest GetWebRequest(Uri address)
	{
		WebRequest webRequest = base.GetWebRequest(address);
		if (webRequest is HttpWebRequest httpWebRequest)
		{
			httpWebRequest.CookieContainer = cookieContainer_0;
		}
		return webRequest;
	}

	protected override WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
	{
		WebResponse webResponse = base.GetWebResponse(request, result);
		method_0(webResponse);
		return webResponse;
	}

	protected override WebResponse GetWebResponse(WebRequest request)
	{
		try
		{
			WebResponse webResponse = base.GetWebResponse(request);
			method_0(webResponse);
			return webResponse;
		}
		catch (Exception)
		{
			throw;
		}
	}

	private void method_0(WebResponse webResponse_0)
	{
		if (webResponse_0 is HttpWebResponse { Cookies: var cookies })
		{
			cookieContainer_0.Add(cookies);
		}
	}
}
