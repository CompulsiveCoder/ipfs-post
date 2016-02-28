using System;

namespace ipfs.post
{
	public class KeyGenerator
	{
		public KeyGenerator ()
		{
		}

		public KeySet Generate()
		{
			var keys = new KeySet ();
			keys.DeviceKey = GenerateKey ();
			keys.PrivateKey = GenerateKey ();
			keys.IpfsKey = GenerateKey ();

			return keys;
		}

		string GenerateKey()
		{
			var key = "";
			using (var e = System.Security.Cryptography.RijndaelManaged.Create())
			{
				e.GenerateKey();
				key = Convert.ToBase64String(e.Key).Replace("/", "").Replace("+", "").Trim('=').Trim('-');
			}
			return key.Substring(0, 10);
		}
	}
}

