using System;

namespace StadiumShop.Domain.Entities
{
    public class Game : BaseEntity
    {
        public Team HomeTeam { get; set; }
        public Team VisitingTeam { get; set; }
        public Stadium Stadium { get; set; }
        public DateTime Date { get; set; }
        public Championship Championship { get; set; }
    }
}