using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Run_AC_Identity.Models;

namespace Run_AC_Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }
        public DbSet<Member> Members { get; set; }
        public DbSet<RaceEvent> Races { get; set; }
    }
}