using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCEgitimi.Areas.Blog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
