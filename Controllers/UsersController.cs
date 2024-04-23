using Microsoft.AspNetCore.Mvc;

namespace languageLearning.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
