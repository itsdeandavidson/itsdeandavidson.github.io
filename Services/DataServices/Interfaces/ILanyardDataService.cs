using PersonalWebsite.Models.LanyardApi;

namespace PersonalWebsite.Services.DataServices.Interfaces;

public interface ILanyardDataService
{
	Task<(Status? Status, string? ErrorMessage)> GetDiscordStatus(string usreId);
}
