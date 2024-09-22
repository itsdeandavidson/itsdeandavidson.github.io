using System.Text.Json;
using System.Text.Json.Serialization;

namespace PersonalWebsite.Models.LanyardApi;

public enum Status
{
	Online,
	Idle,
	Dnd,
	Offline
}

public class StatusConverter : JsonConverter<Status>
{
	public override Status Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string? value = reader.GetString()?.ToLower();

		return value switch
		{
			"online" => Status.Online,
			"idle" => Status.Idle,
			"dnd" => Status.Dnd,
			"offline" => Status.Offline,
			_ => Status.Offline
		};
	}

	public override void Write(Utf8JsonWriter writer, Status value, JsonSerializerOptions options) => throw new NotImplementedException();
}