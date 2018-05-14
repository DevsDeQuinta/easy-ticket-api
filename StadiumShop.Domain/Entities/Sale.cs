using System.Collections.Generic;

namespace StadiumShop.Domain.Entities
{
    public class Sale : BaseEntity
    {
        public Ticket Ticket { get; set; }
        public User User { get; set; }

        public List<Rule> AppliedRules { get; set; }
    }
}