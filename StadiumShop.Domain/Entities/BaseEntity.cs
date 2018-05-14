using System;

namespace StadiumShop.Domain.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Key = Guid.NewGuid().ToString();
            Created = DateTime.Now;
            Modified = DateTime.Now;
            IsDeleted = false;
        }

        public string Key { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool IsDeleted { get; set; }
    }
}