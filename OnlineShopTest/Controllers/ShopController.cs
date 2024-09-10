using Microsoft.AspNetCore.Mvc;
using OnlineShopTest.DataBase;
using OnlineShopTest.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineShopTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController(DBContext dBContext) : ControllerBase
    {
        [HttpGet]
        public IEnumerable<CustomerModel> Get()
        {
            return dBContext.Customers;
        }

        // GET api/<ShopController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ShopController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ShopController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ShopController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
