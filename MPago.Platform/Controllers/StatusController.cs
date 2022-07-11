using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mpago.Domain.Product;
using Mpago.Service;

namespace MPago.Platform.Controllers
{
    public class StatusController : Controller
    {
        public async Task<ActionResult> fail(
            string collection_id,
            string collection_status,
            string payment_id,
            string status,
            string external_reference,
            string payment_type,
            string merchant_order_id,
            string preference_id,
            string site_id,
            string processing_mode,
            string merchant_account_id)
        {
          
            return View();
        }
        public async Task<ActionResult> pending(
            string collection_id,
            string collection_status,
            string payment_id,
            string status,
            string external_reference,
            string payment_type,
            string merchant_order_id,
            string preference_id,
            string site_id,
            string processing_mode,
            string merchant_account_id)
        {
          
            return View();
        }
        public async Task<ActionResult> success(
            string collection_id,
            string collection_status,
            string payment_id,
            string status,
            string external_reference,
            string payment_type,
            string merchant_order_id,
            string preference_id,
            string site_id,
            string processing_mode,
            string merchant_account_id)
        {
            ViewData["collection_id"] = collection_id;
            ViewData["collection_status"] = collection_status;
            ViewData["payment_id"] = payment_id;
            ViewData["payment_type"] = payment_type;
            ViewData["external_reference"] = external_reference;

            return View();
        }
    }
}
