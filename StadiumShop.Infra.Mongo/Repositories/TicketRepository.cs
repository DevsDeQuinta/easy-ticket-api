using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using StadiumShop.Domain.Entities;
using StadiumShop.Domain.Repositories;

namespace StadiumShop.Infra.Mongo.Repositories
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        public TicketRepository(IMongoDatabase mongoDatabase) : base(mongoDatabase)
        {
        }

        public List<Ticket> GetRecents(int count)
        {
            return Queryable.Take(count).ToList();
        }
    }
}