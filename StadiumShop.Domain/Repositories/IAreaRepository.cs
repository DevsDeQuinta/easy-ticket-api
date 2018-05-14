using System.Collections.Generic;
using StadiumShop.Domain.Entities;

namespace StadiumShop.Domain.Repositories
{
    public interface IAreaRepository : IRepository<Area>
    {
        List<Area> GetByStadium(string stadiumKey);
    }
}