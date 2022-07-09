using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MPago.Platform.Controllers
{
    public class Product : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
