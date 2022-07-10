using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mpago.Domain.Product;
using Mpago.Service;

namespace MPago.Platform.Controllers
{
    public class StatusController : Controller
    {
        public async Task<ActionResult> fail()
        {
          
            return View();
        }
        public async Task<ActionResult> pending()
        {
          
            return View();
        }
        public async Task<ActionResult> success(string collection_id, string collection)
        {
            return View();
        }
    }
}
