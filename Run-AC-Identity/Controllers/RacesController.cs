using Microsoft.AspNetCore.Mvc;
using Run_AC_Identity.Interfaces;
using Run_AC_Identity.Models;

namespace Run_AC_Identity.Controllers;


[ApiController]
[Route("api/[controller]")]
public class RacesController : Controller
{

    private readonly IRaceRepository _racesRepository;

    public RacesController(IRaceRepository raceRepository)
    {
        _racesRepository = raceRepository;
    }

    [HttpGet("get-races")]
    public async Task<IEnumerable<RaceEvent>> GetRaces()
    {
        return await _racesRepository.GetAllAsync();
    }

    [HttpGet("get-race-by-id,{raceId}")]
    public async Task<RaceEvent?> GetRaceById(Guid raceId)
    {
        return await _racesRepository.GetAsync(raceId);
    }

    [HttpPost("create-race")]
    public async Task<RaceEvent> CreateRace(RaceEvent raceEvent) {
        return await _racesRepository.AddAsync(raceEvent);
    }
}