using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using StadiumShop.Application.Services;
using StadiumShop.Common.Settings;
using StadiumShop.Common.Storage;
using StadiumShop.Domain.Repositories;
using StadiumShop.Domain.Services;
using StadiumShop.Infra.Mongo.Repositories;

namespace StadiumShop.API.Settings
{
    public static class ServiceCollectionExtensions
    {
		public static IServiceProvider ConfigureIoc(this IServiceCollection services, IConfiguration configuration)
        {
			services.Configure<ConnectionString>(configuration.GetSection("ConnectionString"));
			services.Configure<StorageSettings>(configuration.GetSection("StorageSettings"));

			services.AddScoped<ITicketApplicationService, TicketApplicationService>();
			services.AddScoped<ITicketRepository, TicketRepository>();

			services.AddScoped<IChampionshipTypeApplicationService, ChampionshipTypeApplicationService>();
			services.AddScoped<IChampionshipTypeRepository, ChampionshipTypeRepository>();

			services.AddScoped<IStorageService, MicrosoftStorageService>();

			services.AddScoped(svcProvider =>
			{
				var connectionString = svcProvider.GetService<IOptions<ConnectionString>>()?.Value;
				var settings = new MongoClientSettings();

				settings.Server = new MongoServerAddress(connectionString.Host, connectionString.Port);

				var client = new MongoClient(settings);
				return client.GetDatabase("StadiumShop");
			});

			services.AddSingleton(svcProvider =>
			{
				var settings = svcProvider.GetService<IOptions<StorageSettings>>()?.Value;

				return settings;
			});

			return services.BuildServiceProvider();
        }
    }
}