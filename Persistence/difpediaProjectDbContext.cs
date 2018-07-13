using Microsoft.EntityFrameworkCore;

namespace difpediaProject.Persistence
{
    public class difpediaProjectDbContext : DbContext
    {
         public difpediaProjectDbContext(DbContextOptions<difpediaProjectDbContext> options)
       : base(options)
       {
           
       }
    }
}