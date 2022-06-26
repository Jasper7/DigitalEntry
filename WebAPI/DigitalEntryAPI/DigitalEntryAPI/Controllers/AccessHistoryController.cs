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
    public class AccessHistoryController : Controller
    {
        // GET: api/values
        [HttpGet]
        public List<AccessHistoryModel> Get()
        {
            var now = DateTime.Now;
            var list = new List<AccessHistoryModel>();

            list.Add(new AccessHistoryModel("Васильев Дмитрий Николаевич", now.AddDays(-3), "Потерял сменку"));
            list.Add(new AccessHistoryModel("Васильев Дмитрий Николаевич", now.AddDays(-3).AddHours(8), "Потерял сменку"));

            list.Add(new AccessHistoryModel("Смирнова Анна Борисовна", now.AddDays(-2), "Срочно", isEmergencyEntry: true));
            list.Add(new AccessHistoryModel("Смирнова Анна Борисовна", now.AddDays(-2).AddHours(8), "Нужно", isEmergencyEntry: true));

            list.Add(new AccessHistoryModel("Васильев Дмитрий Николаевич", now.AddDays(-1), "Потерял сменку"));
            list.Add(new AccessHistoryModel("Васильев Дмитрий Николаевич", now.AddDays(-1).AddHours(8), "Потерял сменку"));

            list.Add(new AccessHistoryModel("Игнатенко Ольга Витальевна", now.AddDays(-4), "Ударился", true, true));
            list.Add(new AccessHistoryModel("Игнатенко Ольга Витальевна", now.AddDays(-5), "Кружится голова", true, true));

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

