using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.WindowsAzure.Storage;
using StadiumShop.Common.Settings;

namespace StadiumShop.Common.Storage
{
	public class MicrosoftStorageService : IStorageService
    {
		private readonly StorageSettings _storageSettings;

		public MicrosoftStorageService(StorageSettings storageSettings)
		{
			_storageSettings = storageSettings;
		}

		public string UpdloadFile<T>(string name, string type, string path, IDictionary<string, string> metadata, string file)
		{
			var containerName = nameof(T);
			var fileName = $"{name}.{type}";
			var storageAccount = CloudStorageAccount.Parse(_storageSettings.ConnectionString);
            var blobClient = storageAccount.CreateCloudBlobClient();
			var container = blobClient.GetContainerReference(containerName);         
			var blob = container.GetBlockBlobReference(fileName);
			var bytes = Convert.FromBase64String(file);
			var stream = new MemoryStream(bytes);

			blob.UploadFromStreamAsync(stream).Wait();

			return $"{container}/{path}/{fileName}";
		}
	}
}