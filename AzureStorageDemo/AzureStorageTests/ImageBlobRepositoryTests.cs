using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Threading.Tasks;

namespace AzureStorage.Tests
{
    [TestClass]
	public class ImageBlobRepositoryTests
	{
        [TestMethod]
        public async Task GetCludBlobContainerAsync()
        {
            var repository = new ImageBlobRepository();

            await repository.GetCludBlobContainerAsync();
        }

        [TestMethod]
        public async Task GetCloudBlockBlobAsync()
        {
            var repository = new ImageBlobRepository();

            await repository.GetCloudBlockBlobAsync("test");
        }

        [TestMethod]
		public async Task UploadBlobFromFileAsync()
		{
			var repository = new ImageBlobRepository();

            await repository.UploadBlobFromFileAsync("from_file", @"D:\epam.jpg");
        }

		[TestMethod]
		public async Task UploadBlobFromStramAsync()
		{
			var repository = new ImageBlobRepository();

            using (var fileStream = new FileStream(@"D:\epam.jpg", FileMode.Open))
            {
                await repository.UploadBlobFromStramAsync("from_stream", fileStream);
            }
        }

        [TestMethod]
        public async Task UploadBlobTextAsync()
        {
            var repository = new ImageBlobRepository();

            var content = "If vegetarians eat vegetables, what do humanitarians eat?";

            await repository.UploadBlobTextAsync("from_text", content);
        }

        [TestMethod]
        public async Task UploadBlobWithMetadataAsync()
        {
            var repository = new ImageBlobRepository();

            var content = "I used to breed rabbits. Then I realized they can handle it themselves.";
            var title = "Dummy title";

            await repository.UploadBlobWithMetadataAsync("with_meta", content, title);
        }

        [TestMethod]
        public async Task UploadBlobWithContentTypeAsync()
        {
            var repository = new ImageBlobRepository();

            var contentType = "image/jpeg";

            using (var fileStream = new FileStream(@"D:\epam.jpg", FileMode.Open))
            {
                await repository.UploadBlobWithContentTypeAsync("with_content_type", fileStream, contentType);
            }
        }

        [TestMethod]
        public async Task UploadBlobWithSmallFileAsync()
        {
            var repository = new ImageBlobRepository();

            using (var fileStream = new FileStream(@"D:\small.jpg", FileMode.Open))
            {
                await repository.UploadBlobWithSmallFileAsync("small", fileStream);
            }
        }

        [TestMethod]
        public async Task UploadBlobWithLargeFileAsync()
        {
            var repository = new ImageBlobRepository();

            using (var fileStream = new FileStream(@"D:\large.jpg", FileMode.Open))
            {
                await repository.UploadBlobWithLargeFileAsync("large", fileStream);
            }
        }

        [TestMethod]
        public async Task GetListOfBlobsAsync()
        {
            var repository = new ImageBlobRepository();

            await repository.GetListOfBlobsAsync();
        }
    }
}