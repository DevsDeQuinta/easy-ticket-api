using System.Collections.Generic;
using StadiumShop.Domain.Entities;

namespace StadiumShop.Domain.Repositories
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        List<Ticket> GetRecents(int count);
    }
}