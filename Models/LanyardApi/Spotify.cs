using System.Text.Json.Serialization;

namespace PersonalWebsite.Models.LanyardApi;

public class Spotify
{
	[JsonPropertyName("track_id")]
	public string? TrackId { get; set; }

	[JsonPropertyName("timestamps")]
	public Timestamps? Timestamps { get; set; }

	[JsonPropertyName("song")]
	public string? Song { get; set; }

	[JsonPropertyName("artist")]
	public string? Artist { get; set; }

	[JsonPropertyName("album_art_url")]
	public string? AlbumArtUrl { get; set; }

	[JsonPropertyName("album")]
	public string? Album { get; set; }
}