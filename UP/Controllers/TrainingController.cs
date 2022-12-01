using Microsoft.AspNetCore.Mvc;

namespace UP.Controllers
{
    public class TrainingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
