using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace difpediaProject.Controllers
{
    [Authorize]
    public class AddContentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}