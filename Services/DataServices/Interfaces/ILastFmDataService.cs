namespace PersonalWebsite.Services.DataServices.Interfaces;

public interface ILastFmDataService
{
	Task<string> GetRecentTracks(string username);
}
