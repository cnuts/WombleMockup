using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WombleMockup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : Controller
    {
     

        [HttpGet("IsItOkay")]
        public IActionResult Search()
        {
            return Ok("its okay");
        }
    }
}
