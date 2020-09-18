using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TruYam.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TruYam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public static List<Category> CategoryList = new List<Category>
        {
            new Category{Id=1,Name="Starters"},
            new Category{Id=2,Name="Main Course"},
            new Category{Id=3,Name="Dessert"}
        };
        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return CategoryList;
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            Category category = CategoryList.Find(c => c.Id == id);
            return category;
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category update)
        {
            Category category = CategoryList.Find(c => c.Id == id);
            category.Name = update.Name;
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Category category = CategoryList.Find(c => c.Id == id);
            CategoryList.Remove(category);
        }
    }
}
