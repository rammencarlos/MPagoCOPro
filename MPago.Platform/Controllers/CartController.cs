using MercadoPago.Config;
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
           
            smartPhone.InitPoint = await new MPagoProvider().CreatePreference(smartPhone);
            if (smartPhone.InitPoint == null)
            {
                return RedirectToAction("index", "home");
            }
            ViewData["preferenceId"] = smartPhone.InitPoint;

            smartPhone.Price = smartPhone.Price * quantity;
            smartPhone.Quantity = quantity;

            return View(smartPhone);
        }
    }
}
