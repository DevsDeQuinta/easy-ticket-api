namespace StadiumShop.Domain.Entities
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string LogoPath { get; set; }
    }
}