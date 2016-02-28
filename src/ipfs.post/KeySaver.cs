using System;
using System.IO;

namespace ipfs.post
{
	public class KeySaver
	{
		public string DataFolder = "";

		public KeySaver (string dataFolder)
		{
			DataFolder = dataFolder;
		}

		public void Save(KeySet keys)
		{
			if (!Directory.Exists (DataFolder))
				Directory.CreateDirectory (DataFolder);

			var output = String.Format ("Device:{0}\nPrivate:{1};\nIpfs:{2}", keys.DeviceKey, keys.PrivateKey, keys.IpfsKey);

			var filePath = GetKeySetFilePath (keys);

			File.WriteAllText (filePath, output);
		}

		public string GetKeySetFilePath(KeySet keys)
		{
			return Path.Combine (DataFolder, keys.IpfsKey);
		}
	}
}

