namespace photo_album_csharp.Tests;

using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using photo_album_csharp.Helpers;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public async Task GetPhotosAsync_ShouldReturnPhotos()
    {
        // Arrange
        var mockHttpClientWrapper = new Mock<IHttpClientWrapper>();
        mockHttpClientWrapper.Setup(x => x.GetStringAsync(It.IsAny<string>()))
                             .ReturnsAsync("[{ \"AlbumId\": 3, \"Id\": 101, \"Title\": \"incidunt alias vel enim\" }]");

        // Act
        var result = await Program.GetPhotosAsync(mockHttpClientWrapper.Object);


        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Length);
        Assert.AreEqual(3, result[0].AlbumId);
        Assert.AreEqual(101, result[0].Id);
        Assert.AreEqual("incidunt alias vel enim", result[0].Title);
    }
}