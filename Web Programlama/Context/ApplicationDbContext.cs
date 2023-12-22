using Microsoft.EntityFrameworkCore;

namespace Web_Programlama.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }


        public DbSet<Models.Route> Routes { get; set; }




    }
}
