using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Diagnostics;
namespace SampleApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            string folder = @"C:/Program Files (x86)/AllGoVision Technologies/AllGoVision/";
            string fileName = @"C:/Program Files (x86)/AllGoVision Technologies/AllGoVision/AllGoVisionAnalytics.exe";
            Console.WriteLine(folder);
            if (Directory.Exists(folder))
            {
                FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(fileName);
                return new string[] { myFileVersionInfo.FileDescription, myFileVersionInfo.FileVersion,myFileVersionInfo.ProductVersion,myFileVersionInfo. };
            }
            else
            {
                return new string[] { "File not found." };
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
