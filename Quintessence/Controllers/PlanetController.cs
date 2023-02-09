using Quintessence.Models;
using Quintessence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Quintessence.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetController : ControllerBase
    {
        private readonly IPlanetRepository _planetRepository;
        public PlanetController(IPlanetRepository planetRepository)
        {
            _planetRepository = planetRepository;
        }

        [HttpGet]
        public IActionResult GetAllPlanets()
        {
            var planets = _planetRepository.GetAllPlanets();
            { return Ok(planets); }
        }

        



    }
}
