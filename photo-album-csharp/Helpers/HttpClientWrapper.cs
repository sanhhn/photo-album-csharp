using System;
namespace photo_album_csharp.Helpers
{
    public class HttpClientWrapper : IHttpClientWrapper
    {
        private readonly HttpClient httpClient;

        public HttpClientWrapper(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> GetStringAsync(string url)
        {
            return await httpClient.GetStringAsync(url);
        }
    }
}

