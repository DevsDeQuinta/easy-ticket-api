using System;

namespace StadiumShop.Domain.Entities
{
    public class Championship : BaseEntity
    {
        public int Year { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public ChampionshipType Type { get; set; }
    }
}