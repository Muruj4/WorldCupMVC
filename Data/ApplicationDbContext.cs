using Microsoft.EntityFrameworkCore;
using WorldCup.Models;

namespace WorldCup.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) {
        
        
        }
       

        public DbSet<Categories> categories {  get; set; }

        public DbSet<TransportationCategories> transportationcategoriess { get; set; } //pk
        public  DbSet<Stadiums> stadiums { get; set; }
        public DbSet<TableFootball> tableFootballs { get; set; }
        public DbSet<Hotels> hotels { get; set; }
        public DbSet<Transportation> transportation { get; set; } //fk

    }
}
