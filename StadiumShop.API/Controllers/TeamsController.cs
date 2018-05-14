using Microsoft.AspNetCore.Mvc;
using StadiumShop.Domain.Services;

namespace StadiumShop.API.Controllers
{
    [Route("api/teams")]
    public class TeamsController : Controller
    {
        private readonly ITeamApplicationService _teamApplicationService;

        public TeamsController(ITeamApplicationService teamApplicationService)
        {
            _teamApplicationService = teamApplicationService;
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }
    }
}