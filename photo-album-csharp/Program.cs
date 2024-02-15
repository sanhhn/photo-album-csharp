namespace photo_album_csharp;

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using photo_album_csharp.Helpers;

public class Program
{
	private static int AlbumId = 3;
    private const string ApiUrl = "https://jsonplaceholder.typicode.com/photos";

	public static async Task Main()
	{
		try
        {
            Console.WriteLine($"Enter Photo Album Id: ");
            var numberString = Console.ReadLine();
            AlbumId = int.Parse(numberString); 
            Console.WriteLine($"Photo Album Id: {AlbumId}");

            var httpClientWrapper = new HttpClientWrapper(new HttpClient());
            var photos = await GetPhotosAsync(httpClientWrapper);

            foreach (var photo in photos)
            {
                Console.WriteLine($"[{photo.Id}] - {photo.Title}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
	}

    public static async Task<PhotoModel[]> GetPhotosAsync(IHttpClientWrapper httpClientWrapper)
    {
        var response = await httpClientWrapper.GetStringAsync($"{ApiUrl}?albumId={AlbumId}");
        return JsonConvert.DeserializeObject<PhotoModel[]>(response);
    }
}


