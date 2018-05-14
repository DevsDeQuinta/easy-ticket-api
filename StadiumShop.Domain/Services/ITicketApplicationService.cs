using System;
using System.Collections.Generic;
using StadiumShop.Domain.Entities;

namespace StadiumShop.Domain.Services
{
    public interface ITicketApplicationService
    {
        List<Ticket> GetRecents(int count);
    }
}