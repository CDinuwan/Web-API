using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : Controller
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World!");
        }

        [HttpPost]
        public IActionResult Post(JObject payload)
        {
            return Ok(payload);
        }
    }
}
