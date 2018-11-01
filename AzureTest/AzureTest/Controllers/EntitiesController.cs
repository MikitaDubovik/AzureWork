using System.Collections.Generic;
using System.Web.Http;
using AzureWork.DbModel;
using AzureWork.Service;

namespace AzureWork.Controllers
{
    [RoutePrefix("entities")]
    public class EntitiesController : ApiController
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            ProductService service = new ProductService();

            return service.Get();
        }

        [HttpGet]
        [Route("{id:int}")]
        // GET api/values/5
        public Product GetEntity(int id)
        {
            ProductService service = new ProductService();

            return service.Get(id);
        }

        [HttpPost]
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        [HttpPut]
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete]
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
