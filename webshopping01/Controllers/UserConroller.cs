using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webshopping01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserConroller : ControllerBase
    {
        // GET: api/<UserConroller>
        [HttpGet]
        public IActionResult Get()
        {
            List<Users> user = dbManager.GetUsers();           
            return Ok(user);
        }

        // GET api/<UserConroller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)

        {
            List<Users> user = dbManager.GetUsers();
            return Ok(user[id]);
        }

        // POST api/<UserConroller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserConroller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserConroller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
