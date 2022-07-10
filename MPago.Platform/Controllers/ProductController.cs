using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mpago.Domain.Product;
using Mpago.Service;

namespace MPago.Platform.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index(string id)
        {
            if (string.IsNullOrEmpty(id))
                return RedirectToAction("index","home");

            SmartPhoneDTO smartPhone = new SmartPhoneService().GetSmartPhone(id);
            ViewData["Title"] = smartPhone.Name;


            return View(smartPhone);
        }
    }
}
