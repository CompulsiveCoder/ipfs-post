using System;
using System.IO;

namespace ipfs.post
{
	public class IpfsFolderCreator
	{
		public string DataFolder = "";

		public IpfsFolderCreator (string dataFolder)
		{
			DataFolder = dataFolder;
		}

		public void Create(string ipfsKey)
		{
			Directory.CreateDirectory (Path.Combine (DataFolder, ipfsKey));
		}
	}
}

