using PersonalWebsite.Services.DataServices.Interfaces;

namespace PersonalWebsite.Services.DataServices.DataServices;

public class LastFmDataService : ILastFmDataService
{
	private readonly HttpClient httpClient;

	public LastFmDataService(IHttpClientFactory httpClientFactory)
	{
		httpClient = httpClientFactory.CreateClient("LastFmApi");
	}

	public async Task<string> GetRecentTracks(string username)
	{
		string url = QueryString("user.getrecenttracks", username, 5);
		var response = await httpClient.GetStringAsync(url);
		return response;
	}

	private string QueryString(string method, string username)
		=> $"?api_key=856f410f0eedf00e13fee946a491903e&format=json&method={method}&user={username}";
	private string QueryString(string method, string username, int limit)
		=> $"?api_key=856f410f0eedf00e13fee946a491903e&format=json&method={method}&user={username}&limit={limit}";
}
