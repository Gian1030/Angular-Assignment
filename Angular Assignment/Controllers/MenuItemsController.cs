using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular_Assignment.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Angular_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemsController : ControllerBase
    {
        // GET: api/<MenuItemsController>
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            List<MenuItem> menuItems = new List<MenuItem>()
            {
                new MenuItem() {Id = 1, Name = "Spaghetti", Price = 14.99},
                new MenuItem() {Id = 2, Name = "Steak", Price = 29.99},
                new MenuItem() {Id = 3, Name = "Nacho Platter", Price = 19.99}
            };
            return menuItems;
        }

        // GET api/<MenuItemsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MenuItemsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MenuItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MenuItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
