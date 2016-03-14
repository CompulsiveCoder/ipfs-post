using System;
using System.Web;
using System.Web.UI;

namespace ipfs.post.WWW
{
	
	public partial class Echo : System.Web.UI.Page
	{
		public string TextData = "";
		public string FolderName = "";
		public string FileName = "";
		public string DeviceKey = "";
		public bool Overwrite;

		public bool DidPublish;

		public string LocalUrl = "";
		public string IpfsUrl = "";
		public string PostUrl = "";

		string UrlFormat = "{0}/{1}/{2}";

		string LocalUrlStart = "http://localhost:8080";
		string IpfsUrlStart = "https://ipfs.io";

		private void Page_Load(object sender, EventArgs e)
		{
			TextData = Request.QueryString ["text"];

			DeviceKey = Request.QueryString ["key"];

			FolderName = Request.QueryString ["folder"];

			FileName = Request.QueryString ["file"];

			Overwrite = Convert.ToBoolean(Request.QueryString ["overwrite"]);

			if (!String.IsNullOrEmpty (TextData)) {
				if (!IsAuthenticated ())
					Response.Redirect ("InvalidKey.aspx");
				else {
					DidPublish = true;

					var echo = new ipfsEcho ();
					echo.IsVerbose = true;

					CreatePostUrl (TextData, FolderName, FileName, DeviceKey, Overwrite);

					if (String.IsNullOrEmpty (DeviceKey)) {
						var hash = echo.Echo (TextData);

						CreateIpfsUrls (hash);

					} else {
						var peerId = echo.Echo (TextData, FolderName, FileName, Overwrite);

						CreateIpnsUrls (peerId, FolderName, FileName);
					}
				}
			}
		}

		private void CreateIpfsUrls(string hash)
		{
			var protocol = "ipfs";

			LocalUrl = String.Format (UrlFormat, LocalUrlStart, protocol, hash);
			IpfsUrl = String.Format (UrlFormat, IpfsUrlStart, protocol, hash);
		}

		private void CreateIpnsUrls(string peerId, string folderName, string fileName)
		{
			var relativePath = peerId + "/" + folderName + "/" + fileName;

			var protocol = "ipns";

			LocalUrl = String.Format (UrlFormat, LocalUrlStart, protocol, relativePath);
			IpfsUrl = String.Format (UrlFormat, IpfsUrlStart, protocol, relativePath);
		}

		private void CreatePostUrl(string text, string folder, string file, string key, bool overwrite)		
		{
			var url = String.Format ("~/Echo.aspx?folder={0}&file={1}&key={2}&overwrite={3}&text={4}", HttpUtility.UrlEncode(folder), HttpUtility.UrlEncode(file), HttpUtility.UrlDecode(key), overwrite, HttpUtility.UrlEncode(text));

			//PostUrl = Request.Url.ToString().Replace(HttpUtility.UrlEncode(text), HttpUtility.UrlEncode("[texthere]"));
			PostUrl = HttpTool.Absolute (url);
		}


		bool IsAuthenticated()
		{
			var isAuthenticated = new KeyManager (Server.MapPath (".data/private")).CheckDeviceKey (FolderName, DeviceKey);
			return isAuthenticated;
		}
	}
}

