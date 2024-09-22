using System.Text.Json.Serialization;

namespace PersonalWebsite.Models.LanyardApi;

public class User
{
	[JsonPropertyName("id")]
	public string? Id { get; set; }

	[JsonPropertyName("username")]
	public string? Username { get; set; }

	[JsonPropertyName("discriminator")]
	public string? Discriminator { get; set; }

	[JsonPropertyName("avatar")]
	public string? Avatar { get; set; }

	[JsonPropertyName("bot")]
	public bool? Bot { get; set; }

	[JsonPropertyName("global_name")]
	public string? GlobalName { get; set; }

	[JsonPropertyName("display_name")]
	public string? DisplayName { get; set; }

	[JsonPropertyName("public_flags")]
	public int? PublicFlags { get; set; }
}