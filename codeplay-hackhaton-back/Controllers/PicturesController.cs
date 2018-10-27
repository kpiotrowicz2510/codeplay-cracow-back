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
        public List<Rachunek> Get()
        {
            using(var db = new RachunekContext()){
                return db.Rachunki.ToList();
            }
        }

        [HttpGet("{id}")]
        public Rachunek Get(int id)
        {
            using (var db = new RachunekContext())
            {
                return db.Rachunki.Where(r=>r.Id==id).First();
            }
        }

        [HttpGet("{id}/status")]
        public string GetStatus(int id){
            using (var db = new RachunekContext())
            {
                var rachunek = db.Rachunki.Where(r => r.Id == id).First();
                var status = rachunek.Status;
                if (rachunek.Status < 3)
                {
                    rachunek.Status++;
                    db.SaveChanges();
                }
                switch (status)
                {
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
        }

        // POST api/values
        [HttpPost]
        public Rachunek Post([FromBody]string value)
        {
            using (var db = new RachunekContext())
            {
                var rachunek = new Rachunek();
                rachunek.Image = value;
                rachunek.Status = 0;
                db.Rachunki.Add(rachunek);
                db.SaveChanges();
                return rachunek;
            }
        }
    }
}
