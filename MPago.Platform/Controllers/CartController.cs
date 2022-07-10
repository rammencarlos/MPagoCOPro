using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mpago.Domain.Product;
using Mpago.Service;

namespace MPago.Platform.Controllers
{
    public class CartController : Controller
    {
        public async Task<ActionResult> Checkout(string id, int quantity)
        {
            if (string.IsNullOrEmpty(id) || quantity == 0)
                return RedirectToAction("index","home");

            SmartPhoneDTO smartPhone = new SmartPhoneService().GetSmartPhone(id);
            ViewData["Title"] = "Checkout - " + smartPhone.Name;

            ViewData["preferenceId"] = await new MPagoService().CreatePreference(smartPhone);
            if (ViewData["preferenceId"] == null)
            {
                return RedirectToAction("index", "home");
            }
            //ViewData["preferenceId"] = "16763907-43323d57-b23e-4d2e-9440-917c38e2ecac";

            smartPhone.Price = smartPhone.Price * quantity;
            smartPhone.Quantity = quantity;

            return View(smartPhone);
        }
    }
}
