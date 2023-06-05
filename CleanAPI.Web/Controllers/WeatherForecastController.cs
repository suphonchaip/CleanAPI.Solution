
using CleanAPI.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CleanAPI.Web.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private readonly PrefixRepository _prefixRepository;

		private static readonly string[] Summaries = new[]
		{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(ILogger<WeatherForecastController> logger,PrefixRepository prefixRepository)
		{
			_logger = logger;
			_prefixRepository = prefixRepository;
		}

		[HttpGet("prefix")]
		public IActionResult GetPrefix()
		{
			var data = _prefixRepository.GetAllAsync().Result;

			return Ok(data);
		}

		[HttpGet(Name = "GetWeatherForecast")]
		public IEnumerable<WeatherForecast> Get()
		{
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			})
			.ToArray();
		}
	}
}