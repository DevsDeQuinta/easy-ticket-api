using System;

namespace StadiumShop.Domain.Entities
{
    public class UserData : BaseEntity
    {
        public User User { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string ProfileImagePath { get; set; }
    }
}