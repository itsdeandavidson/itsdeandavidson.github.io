using System.Reflection;

namespace PersonalWebsite.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddDataServices(this IServiceCollection services, Assembly assembly)
	{
		var types = assembly.GetTypes().Where(t => t.Name.EndsWith("DataService") && t.IsClass);

		foreach (var type in types)
		{
			var interfaceType = type.GetInterfaces().FirstOrDefault(i => i.Name == $"I{type.Name}");
			if (interfaceType != null)
			{
				services.AddTransient(interfaceType, type);
			}
		}

		return services;
	}
}

