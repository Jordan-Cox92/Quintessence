using Quintessence.Models;
using System.Collections.Generic;

namespace Quintessence.Repositories
{
    public interface IPlanetRepository
    {
        List<Planet> GetAllPlanets();
    }
}