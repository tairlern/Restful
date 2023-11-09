using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson5_Restful.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static int count = 3;
        static List<Product> products = new List<Product>() { new Product { Id=0, Name= "balons"}
        , new Product { Id=1, Name= "wire"},
           new Product { Id=2, Name= "rod"}};
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products ;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return products.Find(p=>p.Id==id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product prod)
        {
            products.Add(prod);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product prod)
        {
            products.Find(p=>p.Id==id).Id=prod.Id;
            products.Find(p => p.Id == id).Name = prod.Name;
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            products.Remove(products.Find(p => p.Id == id));
        }
    }
}
