using System;
using System.Collections.Generic;
using MongoDB.Driver;
using StadiumShop.Domain.Entities;
using StadiumShop.Domain.Repositories;

namespace StadiumShop.Infra.Mongo.Repositories
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        public TeamRepository(IMongoDatabase mongoDatabase) : base(mongoDatabase)
        {

        }
    }
}