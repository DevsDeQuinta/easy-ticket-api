using System.Collections.Generic;
using StadiumShop.Domain.Entities;
using StadiumShop.Domain.Repositories;
using StadiumShop.Domain.Services;

namespace StadiumShop.Application.Services
{
    public class TicketApplicationService : ITicketApplicationService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketApplicationService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public List<Ticket> GetRecents(int count)
        {
            return _ticketRepository.GetRecents(count);
        }
    }
}