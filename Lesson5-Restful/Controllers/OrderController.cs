using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson5_Restful.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        static int count = 3;
        static List<Order> orders = new List<Order>() { new Order { IdOrder=0, CountProdact= 30,Product=new Product(),DateOrder=new DateTime(2023,12,1)}
        ,  new Order { IdOrder=0, CountProdact= 50,Product=new Product(),DateOrder=new DateTime(2022,10,8)},
           new Order { IdOrder=0, CountProdact= 20,Product=new Product(),DateOrder=new DateTime(2021,11,9)}};
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return orders ;
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return orders.Find(o=>o.IdOrder==id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post([FromBody] Order ordr)
        {
            orders.Add(ordr);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order ordr)
        {
            orders.Find(o=>o.IdOrder==id).IdOrder=ordr.IdOrder;
            orders.Find(o => o.IdOrder == id).Product = ordr.Product;
            orders.Find(o => o.IdOrder == id).CountProdact = ordr.CountProdact;
            orders.Find(o => o.IdOrder == id).DateOrder = ordr.DateOrder;
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            orders.Remove(orders.Find(o => o.IdOrder == id));
        }
    }
}
