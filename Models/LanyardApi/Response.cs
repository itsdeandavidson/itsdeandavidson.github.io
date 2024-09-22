using System.Text.Json.Serialization;


namespace PersonalWebsite.Models.LanyardApi;

public class Response
{
	[JsonPropertyName("success")]
	public bool? Success { get; set; }

	[JsonPropertyName("data")]
	public Lanyard? Data { get; set; }
}