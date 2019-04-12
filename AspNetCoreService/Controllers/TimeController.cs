using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI1.Controllers
{
    [Route("api/time")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        // GET api/time
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { DateTime.Now.ToString() };
        }
    }
}
