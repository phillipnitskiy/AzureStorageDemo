using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace AzureStorage
{
	public class ImageBlobRepository
	{
		private readonly string connectionString =
			ConfigurationManager.AppSettings["StorageAccount.ConnectionString"];

        private readonly string containerName = "images";

        public async Task<CloudBlobContainer> GetCludBlobContainerAsync()
        {
            // Get the reference to a cloud storage account

            // Create a cloud blob client

            // Get a reference to a blob container

            return (CloudBlobContainer) null;
        }

        public async Task<CloudBlockBlob> GetCloudBlockBlobAsync(string blobName)
        {
            CloudBlobContainer blobContainer = await this.GetCludBlobContainerAsync();

            // Get a reference to a block blob

            return (CloudBlockBlob) null;
        }

        public async Task UploadBlobFromFileAsync(string blobName, string path)
        {
            CloudBlockBlob blob = await GetCloudBlockBlobAsync(blobName);

            // Upload a file to blob storage
            await blob.UploadFromFileAsync(path);
        }

        public async Task UploadBlobFromStramAsync(string blobName, Stream stream)
        {
            CloudBlockBlob blob = await GetCloudBlockBlobAsync(blobName);

            // Upload a file to blob storage using stream
        }

        public async Task UploadBlobTextAsync(string blobName, string content)
        {
            CloudBlockBlob blob = await GetCloudBlockBlobAsync(blobName);

            // Upload text to blob storage
        }

        public async Task UploadBlobWithMetadataAsync(string blobName, string content, string title)
        {
            CloudBlockBlob blob = await GetCloudBlockBlobAsync(blobName);

            // Add metadata to a blob

            // Upload text to blob storage
        }

        public async Task UploadBlobWithContentTypeAsync(string blobName, Stream stream, string contenType)
        {
            CloudBlockBlob blob = await GetCloudBlockBlobAsync(blobName);

            // Set the ContentType of the blob

            // Upload a file to blob storage using stream
        }

        public async Task UploadBlobWithSmallFileAsync(string blobName, Stream stream)
        {
            CloudBlockBlob blob = await GetCloudBlockBlobAsync(blobName);

            // Upload a file to blob storage using stream
        }

        public async Task UploadBlobWithLargeFileAsync(string blobName, Stream stream)
        {
            CloudBlockBlob blob = await GetCloudBlockBlobAsync(blobName);

            // Upload a file to blob storage using stream
        }

        public async Task GetListOfBlobsAsync()
		{
            CloudBlobContainer blobContainer = await this.GetCludBlobContainerAsync();

			// Get a reference to blobs

			foreach (IListBlobItem blobItem in blobItems)
			{
				// Get the blob reference
				CloudBlockBlob blob = (CloudBlockBlob) blobItem;

			}
		}
	}
}
