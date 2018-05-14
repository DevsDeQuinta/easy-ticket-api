using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using StadiumShop.Domain.Repositories;

namespace StadiumShop.Infra.Mongo.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        private readonly IMongoDatabase _mongoDataBase;
        private readonly IMongoCollection<T> _mongoCollection;

        protected readonly IQueryable<T> Queryable;

        public Repository(IMongoDatabase mongoDatabase)
        {
            _mongoDataBase = mongoDatabase;
            _mongoCollection = mongoDatabase.GetCollection<T>(nameof(T));

            Queryable = _mongoCollection.AsQueryable();
        }

        public void Create(T entity)
        {
            _mongoCollection.InsertOne(entity);
        }

        public void CreateMany(List<T> entities)
        {
            _mongoCollection.InsertMany(entities);
        }

        public void Delete(string key)
        {
            _mongoCollection.DeleteOne(key);
        }

        public void DeleteMany(List<string> keys)
        {
            foreach (var key in keys)
            {
                _mongoCollection.DeleteOne(key);
            }
        }

        public void Update(string key, T entity)
        {
            _mongoCollection.ReplaceOne(key, entity);
        }

        public T Get(string key)
        {
            return _mongoCollection.Find(key).FirstOrDefault();
        }

        public T Get(Func<T, bool> func)
        {
            return _mongoCollection.Find(item => func(item)).FirstOrDefault();
        }

        public List<T> GetAll(Func<T, bool> func)
        {
            return _mongoCollection.Find(item => func(item)).ToList();
        }

        public List<T> GetAll()
        {
            return _mongoCollection.AsQueryable().ToList();
        }
    }
}