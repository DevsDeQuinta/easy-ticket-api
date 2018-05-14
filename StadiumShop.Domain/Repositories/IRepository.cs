using System;
using System.Collections.Generic;

namespace StadiumShop.Domain.Repositories
{
    public interface IRepository<T>
    {
        void Create(T entity);
        void CreateMany(List<T> entities);
        void Update(string key, T entity);
        void Delete(string key);
        void DeleteMany(List<string> keys);

        T Get(string key);
        T Get(Func<T, bool> func);
        List<T> GetAll(Func<T, bool> func);
        List<T> GetAll();
    }
}
