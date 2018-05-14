using Microsoft.AspNetCore.Mvc;
using StadiumShop.Domain.Services;

namespace StadiumShop.API.Controllers
{
    [Route("api/tickets")]
    public class TicketsController : Controller
    {
        private readonly ITicketApplicationService _ticketApplicationService;

        public TicketsController(ITicketApplicationService ticketApplicationService)
        {
            _ticketApplicationService = ticketApplicationService;
        }

        [HttpGet("{count}")]
        public IActionResult GetRecents(int count)
        {
            var tickets = _ticketApplicationService.GetRecents(count);

            return Ok(tickets);
        }
    }
}