using System.Linq;
using difpediaProject.Models;
using difpediaProject.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace difpediaProject.Controllers
{
    [Route("api/[controller]")]
    public class DifferenceController : Controller
    {

        private readonly difpediaProjectDbContext context;
        public DifferenceController(difpediaProjectDbContext context)
        {
            this.context = context;
        }

        [HttpPost("/post")] 
        
        public IActionResult GetDifference([FromBody]GetModel differenceName)
        {

            var difference = context.Differences
           .Where(b => b.Name.Contains(differenceName.Name)).ToList();
            if (difference == null)
            {
                return NotFound();
            }
            return Ok(difference);
        }

        [HttpPost]
        public IActionResult SaveDifference([FromBody]Difference difference)
        {
            try
            {
                context.Differences
               .Add(difference);
                context.SaveChanges();
                return Ok(difference);
            }
            catch
            {
                return BadRequest();
            }
        }
        public class GetModel
        {
            public string Name { get; set; }
        }
    }
}