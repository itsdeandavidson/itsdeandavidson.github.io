using System.Text.Json.Serialization;

namespace PersonalWebsite.Models.LanyardApi;

public class Lanyard
{
	[JsonPropertyName("discord_user")]
	public User? User { get; set; }

	[JsonPropertyName("discord_status")]
	[JsonConverter(typeof(StatusConverter))]
	public Status? Status { get; set; }

	[JsonPropertyName("activities")]
	public Activity[]? Activities { get; set; }

	[JsonPropertyName("kv")]
	public Dictionary<string, string>? Kv { get; set; }

	[JsonPropertyName("active_on_discord_desktop")]
	public bool? ActiveOnDesktop { get; set; }

	[JsonPropertyName("active_on_discord_mobile")]
	public bool? ActiveOnMobile { get; set; }

	[JsonPropertyName("listening_to_spotify")]
	public bool? ListeningToSpotify { get; set; }

	[JsonPropertyName("spotify")]
	public Spotify? Spotify { get; set; }
}