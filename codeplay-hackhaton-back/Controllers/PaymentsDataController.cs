using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace codeplayhackhatonback.Controllers
{
    [Route("api/payments")]
    public class PaymentsDataController : Controller
    {
         // GET: api/values
        [HttpGet]
        public string Get()
        {
            return System.IO.File.ReadAllText("data.txt");
            /*
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhdWQiOlsicmViLWN1c3RvbWVyLXNlcnZpY2UiXSwidXNlcl9uYW1lIjoiTUIxQk1PNVIiLCJpZGVudGl0eSI6eyJvcmdfdW5pdCI6Im91PTk0NixvPVNHQi1CQU5LLGRjPUFDUCxkYz11ZmUsZGM9Y29tIiwicGVyc29uX2lkIjoiMzI4MDcyIiwicm9sZSI6IkNVU1RPTUVSIiwiYWNjZXNzX3Byb2ZpbGVfaWQiOiIyMzA3In0sInNjb3BlIjpbIndyaXRlIiwicmVhZCJdLCJpc3MiOiJpc3N1ZXIiLCJqdGkiOiJlYmY0ZGZmYS00ZWU2LTQ4NGUtODdiMy1hYzc5MDk3ZWRmZjUiLCJjbGllbnRfaWQiOiJyZWJSZXRhaWwiLCJhdXRob3JpdGllcyI6WyJST0xFX1VTRVIiXX0.cQRnONmhv4WR8p3tTSjXZXYo45Xt46R_OptL-2Nj2Mg");

            var stringTask = client.GetStringAsync("https://team1.asseco.pl/retail-banking-swagger/api/account?customerId=328072&accessProfileId=2307&pageNumber=1&pageSize=10");

            var msg = stringTask.Result;

            return msg;
            */
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
