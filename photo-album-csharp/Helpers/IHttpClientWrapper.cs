using System;
namespace photo_album_csharp.Helpers
{
    public interface IHttpClientWrapper
    {
        Task<string> GetStringAsync(string url);
    }
}

