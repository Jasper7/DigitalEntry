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
    public class ParentsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<ParentModel> Get()
        {
            var list = new List<ParentModel>();
            list.Add(new ParentModel() { FirstName = "Дмитрий", LastName = "Васильев" });
            list.Add(new ParentModel() { FirstName = "Анна", LastName = "Васильева" });
            list.Add(new ParentModel() { FirstName = "Игнать", LastName = "Смирнов" });
            list.Add(new ParentModel() { FirstName = "Нина", LastName = "Смирнова" });
            list.Add(new ParentModel() { FirstName = "Ольга", LastName = "Пятровна" });
            return list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IEnumerable<ParentModel> Get(int id)
        {
            var list = new List<ParentModel>();
            list.Add(new ParentModel() { FirstName = "Дмитрий", LastName = "Васильев" });
            list.Add(new ParentModel() { FirstName = "Анна", LastName = "Васильева" });
            return list;
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

