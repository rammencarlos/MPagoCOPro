using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mpago.Domain.Product;
using Mpago.Service;

namespace MPago.Platform.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Detail(string id, int quantity)
        {
            if (string.IsNullOrEmpty(id) || quantity == 0)
                return RedirectToAction("index","home");

            return View();
        }
    }
}
