using System;
using MongoDB.Driver;
using StadiumShop.Domain.Entities;
using StadiumShop.Domain.Repositories;

namespace StadiumShop.Infra.Mongo.Repositories
{
	public class ChampionshipTypeRepository : Repository<ChampionshipType>, IChampionshipTypeRepository
	{
		public ChampionshipTypeRepository(IMongoDatabase mongoDatabase) : base(mongoDatabase)
		{
		}
	}
}