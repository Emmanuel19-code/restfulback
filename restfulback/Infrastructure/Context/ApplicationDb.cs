using Microsoft.EntityFrameworkCore;
using restfulback.Domain;
using restfulback.Domain.Entity;

namespace restfulback.Infrastructure
{
    public class ApplicationDb : DbContext
    {
        // Constructor to pass options to the base class DbContext
        public ApplicationDb(DbContextOptions<ApplicationDb> options)
            : base(options)
        {
        }

        // DbSet for DeceasedProfile
        public DbSet<DeceasedProfile> DeceasedProfiles { get; set; }
        public DbSet<Users> Users {get;set;}
    }
}
