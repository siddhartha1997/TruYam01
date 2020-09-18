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
    public class MenuItemController : ControllerBase
    {
        public static List<MenuItem> MenuItemList = new List<MenuItem>
        {
            new MenuItem{Id=1,Name="Sandwich",FreeDelivery="Yes",Price=99.00,DateofLaunch="15.03.2017",Category="Main Course",Active="Yes"},
            new MenuItem{Id=2,Name="Burger",FreeDelivery="No",Price=129.00,DateofLaunch="23.12.2017",Category="Main Course",Active="Yes"},
            new MenuItem{Id=3,Name="Pizza",FreeDelivery="No",Price=149.00,DateofLaunch="21.08.2017",Category="Main Course",Active="Yes"},
            new MenuItem{Id=4,Name="French Fries",FreeDelivery="Yes",Price=57.00,DateofLaunch="02.07.2017",Category="Starter",Active="No"},
            new MenuItem{Id=5,Name="Chocolate Brownie",FreeDelivery="Yes",Price=32.00,DateofLaunch="02.11.2017",Category="Desert",Active="Yes"}
        };
        // GET: api/<MenuItemController>
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            return MenuItemList;
        }

        // GET api/<MenuItemController>/5
        [HttpGet("{id}")]
        public MenuItem Get(int id)
        {
            MenuItem menuitem = MenuItemList.Find(m => m.Id == id);
            return menuitem;
        }

        // POST api/<MenuItemController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MenuItemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MenuItem update)
        {
            MenuItem menuItem = MenuItemList.Find(m => m.Id == id);
            menuItem.Name = update.Name;
            menuItem.FreeDelivery = update.FreeDelivery;
            menuItem.Price = update.Price;
            menuItem.DateofLaunch = update.DateofLaunch;
            menuItem.Category = update.Category;
            menuItem.Active = update.Active;
        }

        // DELETE api/<MenuItemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            MenuItem menuItem = MenuItemList.Find(m => m.Id == id);
            MenuItemList.Remove(menuItem);
        }
    }
}
