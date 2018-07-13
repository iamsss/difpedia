using difpediaProject.Models;
using Microsoft.EntityFrameworkCore;

namespace difpediaProject.Persistence
{
    public class difpediaProjectDbContext : DbContext
    {
         public difpediaProjectDbContext(DbContextOptions<difpediaProjectDbContext> options)
       : base(options)
       {
           
       }

       public DbSet<User> Users { get; set; }
    }
}