using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AdminService.Models;

namespace AdminService.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly AdminDBContext _context;

        public ValuesController(AdminDBContext context)
        {
            _context = context;

            if (_context.Customers.Count() == 0)
            {
                _context.Customers.Add(new Customer { CustomerName = "Axtest" });
                _context.SaveChanges();
            }
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
          return _context.Customers.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = _context.Customers.FirstOrDefault(t => t.CustomerId == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Customer value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            _context.Customers.Add(value);
            _context.SaveChanges();

            return StatusCode(200);
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
