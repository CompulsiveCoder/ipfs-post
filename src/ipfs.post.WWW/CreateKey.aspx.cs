using System;
using System.Web;
using System.Web.UI;

namespace ipfs.post.WWW
{
	
	public partial class CreateKey : System.Web.UI.Page
	{
		public KeySet Keys;

		public void CreateKeyButton_Clicked(object sender, EventArgs e)
		{
			var privateFolder = Server.MapPath (".data/private");
			var publicFolder = Server.MapPath (".data/public");

			var keyManager = new KeyManager (privateFolder);

			Keys = keyManager.CreateKeySet ();

			var folderCreator = new IpfsFolderCreator (publicFolder);
			folderCreator.Create (Keys.IpfsKey);
		}
	}
}

