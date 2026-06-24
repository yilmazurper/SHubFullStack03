using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCEgitimi.Areas.ApiKullanimi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
