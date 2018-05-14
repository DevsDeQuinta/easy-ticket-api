using System;
using StadiumShop.Domain.Entities;

namespace StadiumShop.Domain.Services
{
    public interface ITeamApplicationService
    {
        void CreateTeam(Team team);
    }
}