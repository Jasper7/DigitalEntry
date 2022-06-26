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
    public class ChildsController : Controller
    {
        // GET: api/values
        [HttpGet]
        public List<ChildModel> Get()
        {
            var list = new List<ChildModel>();
            list.Add(new ChildModel(1, "Иванов", "Иван", 7, "Школа №11", "2б класс"));
            list.Add(new ChildModel(1, "Иванов", "Петр", 7, "Школа №11", "1а класс"));
            list.Add(new ChildModel(1, "Петров", "Игорь", 7, "Школа №11", "1б класс"));
            list.Add(new ChildModel(1, "Сидоров", "Василий", 7, "Школа №11", "1а класс"));
            list.Add(new ChildModel(1, "Шумный", "Игнат", 7, "Школа №11", "2г класс"));
            list.Add(new ChildModel(1, "Громкий", "Антон", 7, "Школа №11", "2а класс"));
            list.Add(new ChildModel(1, "Быстрый", "Александр", 7, "Школа №11", "1в класс"));
            list.Add(new ChildModel(1, "Высокий", "Дмитрий", 7, "Школа №11", "1а класс"));
            return list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public List<ChildModel> Get(int id)
        {
            var list = new List<ChildModel>();
            list.Add(new ChildModel(1, "Иванов", "Иван", 7, "Школа №11", "1б класс"));
            list.Add(new ChildModel(1, "Иванов", "Петр", 7, "Детский сад №8", "6 группа"));
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

