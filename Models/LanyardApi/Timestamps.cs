using System.Text.Json.Serialization;

namespace PersonalWebsite.Models.LanyardApi;

public class Timestamps
{
	[JsonPropertyName("start")]
	public long? Start { get; set; }

	[JsonPropertyName("end")]
	public long? End { get; set; }
}