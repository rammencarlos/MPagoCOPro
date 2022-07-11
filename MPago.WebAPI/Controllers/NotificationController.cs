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
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<NotificationController> _logger;

        public NotificationController(ILogger<NotificationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public BoxResponse<object> Get()
        {
            BoxResponse<object> response = new();

            var rng = new Random();
            response.Object = Enumerable.Range(1, 5).Select(index => new
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();

            return response;
        }

        [HttpPost]
        public async Task<BoxResponse<object>> PostAsync([FromBody] dynamic body, [FromQuery(Name = "data.id")] string id, [FromQuery] string type)
        {
            BoxResponse<object> result = new();

            result.Object = new
            {
                id,
                type,
            };
            result.Message = Newtonsoft.Json.JsonConvert.SerializeObject(new { result.Object });
            Random rnd = new Random();
            int num = rnd.Next();

            string name = "h:\\root\\home\\jacknrm-001\\www\\iboxresponsempago\\" + (string.IsNullOrEmpty(id) ? "NOID-" + num.ToString() : id.ToString() )+ ".json";
            using (StreamWriter outputFile = new StreamWriter(name))
            {
                outputFile.WriteLine(body);
            }


            return result;
        }
    }
}
