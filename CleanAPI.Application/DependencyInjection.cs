using CleanAPI.Application.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanAPI.Application
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddApplication(this IServiceCollection services)
		{
			services.AddTransient<PrefixRepository>();

			return services;
		}
	}
}
