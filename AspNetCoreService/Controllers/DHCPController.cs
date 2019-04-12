using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DhcpController : ControllerBase
    {
        // GET api/dhcp
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

    }
}
