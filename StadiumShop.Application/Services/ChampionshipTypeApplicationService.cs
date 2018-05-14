using System;
using System.Collections.Generic;
using StadiumShop.Application.Generators;
using StadiumShop.Common.Storage;
using StadiumShop.Domain.Entities;
using StadiumShop.Domain.Repositories;
using StadiumShop.Domain.Services;

namespace StadiumShop.Application.Services
{
	public class ChampionshipTypeApplicationService : IChampionshipTypeApplicationService
	{
		private readonly IChampionshipTypeRepository _championshipTypeRepository;
		private readonly IStorageService _storageService;

		public ChampionshipTypeApplicationService(IChampionshipTypeRepository championshipTypeRepository, IStorageService storageService)
		{
			_championshipTypeRepository = championshipTypeRepository;
			_storageService = storageService;
		}

		public void Create(ChampionshipType championshipType, string logo)
		{
			championshipType.Key = KeyGenerator.Generate();
            
			var metadata = new Dictionary<string, string>();

			metadata.Add(nameof(ChampionshipType), championshipType.Key);
			metadata.Add(nameof(championshipType.Key), championshipType.Key);

			var path = _storageService.UpdloadFile<ChampionshipType>(championshipType.Key, "png", "logo", metadata, logo);

			championshipType.LogoPath = path;

			_championshipTypeRepository.Create(championshipType);
		}

		public List<ChampionshipType> GetAll()
		{
			return _championshipTypeRepository.GetAll();
		}
	}
}
