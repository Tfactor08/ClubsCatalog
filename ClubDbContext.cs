using System.Data.Entity;

namespace ClubsCatalog
{
    class ClubDbContext : DbContext
    {
        public ClubDbContext() : base("DbClubs") {  }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
