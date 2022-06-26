using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalEntryAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DigitalEntryAPI.Controllers
{
    [Route("api/[controller]")]
    public class ChildHistoryController : Controller
    {
        // GET: api/values
        [HttpGet]
        public List<EnterHistoryModel> Get()
        {
            var list = new List<EnterHistoryModel>();
            list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-3)));
            list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-3).AddHours(8), true));
            list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-2)));
            list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-2).AddHours(8), true));
            list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-1)));
            list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-1).AddHours(8), true));
            list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-4)));
            list.Add(new EnterHistoryModel(DateTime.Now.AddDays(-4).AddHours(8), true));
            return list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
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

