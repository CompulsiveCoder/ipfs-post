using System;
using System.Web;
using System.Web.UI;

namespace ipfs.post.WWW
{
	
	public partial class Default : System.Web.UI.Page
	{
		public void GoButton_Click (object sender, EventArgs args)
		{
			var url = String.Format ("Echo.aspx?text={0}&folder={1}&file={2}&key={3}&overwrite=false", HttpUtility.UrlEncode(TextData.Text), HttpUtility.UrlEncode(Folder.Text), HttpUtility.UrlEncode(File.Text), HttpUtility.UrlDecode(DeviceKey.Text), Overwrite.Checked.ToString());

			Response.Redirect (url);
		}
	}
}

