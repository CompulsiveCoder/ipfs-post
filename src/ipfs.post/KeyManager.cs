using System;
using System.IO;

namespace ipfs.post
{
	public class KeyManager
	{
		public string PrivateDataFolder = "";

		public KeyManager (string privateDataFolder)
		{
			PrivateDataFolder = privateDataFolder;
		}

		public KeySet CreateKeySet()
		{
			var generator = new KeyGenerator ();
			var keys = generator.Generate ();

			var saver = new KeySaver (PrivateDataFolder);
			saver.Save (keys);

			return keys;
		}

		public bool CheckDeviceKey(string ipfsKey, string publicKey)
		{
			var filePath = Path.Combine(PrivateDataFolder, ipfsKey);

			if (!File.Exists (filePath))
				return false;

			var content = File.ReadAllText (filePath);

			return content.IndexOf ("Device:" + publicKey) > -1;
		}
	}
}

