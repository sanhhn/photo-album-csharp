namespace photo_album_csharp;

public class PhotoModel
{
    public int AlbumId { get; set; }
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Url { get; set; }
    public string? ThumbnailUrl { get; set; }
}