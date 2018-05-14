using Microsoft.AspNetCore.Mvc;
using StadiumShop.API.Models;
using StadiumShop.Domain.Entities;
using StadiumShop.Domain.Services;

namespace StadiumShop.API.Controllers
{
	[Route("api/championshiptypes")]
	public class ChampionshipTypesController : Controller
    {
		private const string CreateChampionshipType = "CreateChampionshipType";
		private readonly IChampionshipTypeApplicationService _championshipTypeApplicationService;

		public ChampionshipTypesController(IChampionshipTypeApplicationService championshipTypeApplicationService)
        {
			_championshipTypeApplicationService = championshipTypeApplicationService;
        }

		[HttpPost]
		[ActionName(CreateChampionshipType)]
		public IActionResult Create([FromBody] CreateChampionshipTypeModel model)
		{
			var championshipType = new ChampionshipType();

			championshipType.Name = model.Name;

			_championshipTypeApplicationService.Create(championshipType, model.Logo);

			return Created(Url.Link(CreateChampionshipType, model) ,championshipType);
		}
        
		[HttpGet]
		public IActionResult GetAll()
		{
			var list = _championshipTypeApplicationService.GetAll();

			return Ok(list);
		}
    }
}
