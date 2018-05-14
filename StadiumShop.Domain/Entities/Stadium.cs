using System.Collections.Generic;
using System.Linq;

namespace StadiumShop.Domain.Entities
{
    public class Stadium : BaseEntity
    {
        public string Name { get; set; }
        public int Capacity => Areas?.Sum(a => a.Capacity) ?? 0;

        public List<Area> Areas { get; set; }
    }
}