using Run_AC_Identity.Data;
using Run_AC_Identity.Interfaces;
using Run_AC_Identity.Models;

namespace Run_AC_Identity.Repositories;

public class RacesRepository : GenericRepository<RaceEvent>, IRaceRepository
{
    private readonly ApplicationDbContext _dbContext;

    public RacesRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }
}