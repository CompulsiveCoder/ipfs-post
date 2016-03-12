using System;
using System.Web;

namespace ipfs.post.WWW
{
	public class HttpTool
	{
		public static string Absolute(string relativeUrl)
		{
			var url = HttpContext.Current.Request.Url;

			return string.Format("{0}://{1}{2}{3}",
				url.Scheme,
				url.Host,
				(url.Port != 80 ? (":" + url.Port) : ""),
				VirtualPathUtility.ToAbsolute(relativeUrl));
		}
	}
}

