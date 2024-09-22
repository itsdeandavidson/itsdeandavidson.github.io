using System.Text.Json.Serialization;

namespace PersonalWebsite.Models.LanyardApi;

public class Activity
{
	[JsonPropertyName("name")]
	public string? Name { get; set; }

	[JsonPropertyName("type")]
	public int? Type { get; set; }

	[JsonPropertyName("timestamps")]
	public Timestamps? Timestamps { get; set; }

	[JsonPropertyName("details")]
	public string? Details { get; set; }

	[JsonPropertyName("state")]
	public string? State { get; set; }

	[JsonPropertyName("application_id")]
	public string? ApplicationId { get; set; }

	[JsonPropertyName("assets")]
	public Dictionary<string, string>? Assets { get; set; }
}