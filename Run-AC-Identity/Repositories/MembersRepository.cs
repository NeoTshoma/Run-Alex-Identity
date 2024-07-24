using Run_AC_Identity.Data;
using Run_AC_Identity.Interfaces;
using Run_AC_Identity.Models;

namespace Run_AC_Identity {
    public class MembersRepository: GenericRepository<Member>, IMembersRepository {
        private readonly ApplicationDbContext _dbContext;

        public MembersRepository(ApplicationDbContext dbContext)
        : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}