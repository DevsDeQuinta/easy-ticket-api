using StadiumShop.Domain.Entities;
using StadiumShop.Domain.Repositories;
using StadiumShop.Domain.Services;

namespace StadiumShop.Application.Services
{
    public class TeamApplicationService : ITeamApplicationService
    {
        private readonly ITeamRepository _teamRepository;

        public TeamApplicationService(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public void CreateTeam(Team team)
        {
            _teamRepository.Create(team);
        }
    }
}