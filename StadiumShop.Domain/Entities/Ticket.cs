using System.Collections.Generic;

namespace StadiumShop.Domain.Entities
{
    public class Ticket : BaseEntity
    {
        public Game Game { get; set; }
        public string Value { get; set; }
        public Area Area { get; set; }
		public bool IsActive { get; set; }

        public List<Rule> Rules { get; set; }
    }
}