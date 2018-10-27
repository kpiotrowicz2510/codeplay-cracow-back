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

        [HttpGet("status")]
        public string GetStatus(){
            var currentStatus = "end";

            try{
                currentStatus = System.IO.File.ReadAllText("status.txt");
            }
            catch{
                return "";
            }

            if(currentStatus == "start"){
                currentStatus = "0";
            }
            if (currentStatus == "end")
            {
                return "";
            }

            var status = int.Parse(currentStatus);
            var newStatus = status + 1;
            if(newStatus > 4){
                System.IO.File.WriteAllText("status.txt", "end");
                return "";
            }
            System.IO.File.WriteAllText("status.txt", newStatus.ToString());

            switch(status){
                case 0:
                    return "Otrzymano nowy rachunek ...";
                case 1:
                    return "Przetwarzanie rachunku ...";
                case 2:
                    return "Analiza zakupów ...";
                case 3:
                    return "Analiza gotowa";
            }
            return "Przetwarzanie ...";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            System.IO.File.WriteAllText("image.txt", value);
            System.IO.File.WriteAllText("status.txt", "start");
        }
    }
}
