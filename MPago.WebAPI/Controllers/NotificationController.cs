using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MPago.WebAPI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mpago.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificationController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] dynamic body, [FromQuery(Name = "data.id")] string id, [FromQuery] string type)
        {
            Random rnd = new Random();
            int num = rnd.Next();

            string name = "h:\\root\\home\\jacknrm-001\\www\\iboxresponsempago\\" + (string.IsNullOrEmpty(id) ? "NOID-" + num.ToString() : id.ToString() )+ ".json";
            using (StreamWriter outputFile = new StreamWriter(name))
            {
                outputFile.WriteLine(body);
            }
            HttpContext.Response.Headers.Add("headers", "dev_24c65fb163bf11ea96500242ac130004");
            HttpContext.Response.Headers.Add("Integrator-id", "dev_24c65fb163bf11ea96500242ac130004");

            return Ok(null);
        }

       
    }
}
