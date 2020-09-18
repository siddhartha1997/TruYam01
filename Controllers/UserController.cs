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
    public class UserController : ControllerBase
    {
        public static List<User> userlist = new List<User>
        {
            new User{Id=1,Username="sb@gmail.com",Password="sb@1234",CartId=1},
            new User{Id=2,Username="by@gmail.com",Password="by@1234",CartId=2},
            new User{Id=3,Username="dd@gmail.com",Password="dd@1234",CartId=3},
        };
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return userlist;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            User user = userlist.Find(u => u.Id == id);
            return user;
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User update)
        {
            User user = userlist.Find(u => u.Id == id);
            user.Username = update.Username;
            user.Password = update.Password;
            user.CartId = update.CartId;
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            User user = userlist.Find(u => u.Id == id);
            userlist.Remove(user);
        }
    }
}
