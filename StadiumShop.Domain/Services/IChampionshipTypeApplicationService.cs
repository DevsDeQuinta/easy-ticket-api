using System;
using System.Collections.Generic;
using StadiumShop.Domain.Entities;

namespace StadiumShop.Domain.Services
{
    public interface IChampionshipTypeApplicationService
	{
		void Create(ChampionshipType championshipType, string logo);
		List<ChampionshipType> GetAll();
    }
}