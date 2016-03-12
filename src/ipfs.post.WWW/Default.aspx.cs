using System;
using System.Web;
using System.Web.UI;

namespace ipfs.post.WWW
{
	
	public partial class Default : System.Web.UI.Page
	{
		public KeySet Keys;

		public void Page_Load(object sender, EventArgs e)
		{
			TextData.Text = "Hello world it's " + DateTime.Now.ToString ();
		}

		public void GoButton_Click (object sender, EventArgs args)
		{
			var url = String.Format ("Echo.aspx?text={0}&folder={1}&file={2}&key={3}&overwrite={4}", HttpUtility.UrlEncode(TextData.Text), HttpUtility.UrlEncode(Folder.Text), HttpUtility.UrlEncode(File.Text), HttpUtility.UrlDecode(Device.Text), Overwrite.Checked.ToString());

			Response.Redirect (url);
		}

		public void CreateKeyButton_Click (object sender, EventArgs args)
		{
			var privateFolder = Server.MapPath (".data/private");
			var publicFolder = Server.MapPath (".data/public");

			var keyManager = new KeyManager (privateFolder);

			Keys = keyManager.CreateKeySet ();

			var folderCreator = new IpfsFolderCreator (publicFolder);
			folderCreator.Create (Keys.IpfsKey);

			Folder.Text = Keys.IpfsKey;
			Device.Text = Keys.DeviceKey;
		}

	}
}

