using PersonalWebsite.Models.LanyardApi;
using PersonalWebsite.Services.DataServices.Interfaces;
using System.Net.Http.Json;

namespace PersonalWebsite.Services.DataServices.DataServices;

public class LanyardDataService : ILanyardDataService
{
	private readonly HttpClient httpClient;

	public LanyardDataService(IHttpClientFactory httpClientFactory)
	{
		httpClient = httpClientFactory.CreateClient("LanyardApi");
	}

	public async Task<(Status? Status, string? ErrorMessage)> GetDiscordStatus(string usreId)
	{
		HttpResponseMessage response = await httpClient.GetAsync(usreId);

		if (response.IsSuccessStatusCode)
		{
			Response? lanyardResponse = await response.Content.ReadFromJsonAsync<Response>();
			Lanyard? lanyard = lanyardResponse!.Data as Lanyard;

			return (lanyard?.Status, null);
		}
		else
		{
			return (null, "Unknown Discord User");
		}
	}
}
