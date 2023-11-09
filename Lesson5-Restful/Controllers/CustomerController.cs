using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson5_Restful.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        static int count = 3;
        static List<Customer> customers = new List<Customer>() { new Customer { Id=0, Name= "sari"}
        , new Customer { Id=1, Name= "ruti"},
           new Customer { Id=2, Name= "yafa"}};
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customers ;
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return customers.Find(c=>c.Id==id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer cust)
        {
            customers.Add(cust);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer cust)
        {
            customers.Find(c => c.Id == id).Id = cust.Id;
            customers.Find(c => c.Id == id).Name = cust.Name;

        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            customers.Remove(customers.Find(c => c.Id == id));
        }
    }
}
