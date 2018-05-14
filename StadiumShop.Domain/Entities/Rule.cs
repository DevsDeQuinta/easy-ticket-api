using System.Collections.Generic;

namespace StadiumShop.Domain.Entities
{
    public class Rule : BaseEntity
    {
        public string Name { get; set; }
        public decimal Percent { get; set; }
        public bool IsApplied { get; set; }
        public bool ItsExclusive { get; set; }

        public List<Rule> AgainstRules { get; set; }
    }
}