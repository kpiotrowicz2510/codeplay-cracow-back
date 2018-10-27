using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace codeplayhackhatonback.Controllers
{
    [Route("api/pictures")]
    public class PicturesController : Controller
    {
        // GET api/values/5
        [HttpGet]
        public string Get()
        {
            return System.IO.File.ReadAllText("image.txt");
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            System.IO.File.WriteAllText("image.txt", value);
        }
    }
}
