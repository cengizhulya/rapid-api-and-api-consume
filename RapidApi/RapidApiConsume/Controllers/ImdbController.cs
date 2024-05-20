using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
	public class ImdbController : Controller
	{
	//	List<ApiMovieViewModel> apiMovieViewModels = new List<ApiMovieViewModel>();
	//	public async Task<IActionResult> Index()
	//	{

	//		var client = new HttpClient();
	//		var request = new HttpRequestMessage
	//		{
	//			Method = HttpMethod.Get,
	//			RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
	//			Headers =
	//{
	//	{ "X-RapidAPI-Key", "f4259e31femshf6d6de2ccd49c8cp1e7ca4jsna79301979855" },
	//	{ "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
	//},
	//		};
	//		using (var response = await client.SendAsync(request))
	//		{
	//			response.EnsureSuccessStatusCode();
	//			var body = await response.Content.ReadAsStringAsync();
	//			apiMovieViewModels = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
	//			return View(apiMovieViewModels);	
	//		}
	//	}
	}
}
