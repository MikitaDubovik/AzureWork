using AzureWork.DbModel;
using AzureWork.Service;
using log4net;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace AzureWork.Controllers
{
    [RoutePrefix("api/Entities")]
    public class EntitiesController : ApiController
    {
        //Log for lof
        private static readonly ILog log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // GET api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {

            try
            {
                ProductService service = new ProductService();

                return service.Get();
            }
            catch (Exception e)
            {
                log.Info(e.Message);
            }

            return null;
        }

        [HttpGet]
        [Route("{id:int}")]
        // GET api/values/5
        public Product GetEntity(int id)
        {
            try
            {
                ProductService service = new ProductService();

                return service.Get(id);
            }
            catch (Exception e)
            {
                log.Info(e.Message);
            }
            return null;
        }

        [HttpPost]
        // POST api/values
        public void Post([FromBody] Product value)
        {
            try
            {
                ProductService service = new ProductService();

                if (!service.Post(value))
                {
                    throw new ArgumentException("Invalid value");
                }
            }
            catch (Exception e)
            {
                log.Info(e.Message);
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        // PUT api/values/5
        public void Put(int id, [FromBody] Product value)
        {
            try
            {
                ProductService service = new ProductService();

                if (!service.Put(id, value))
                {
                    throw new ArgumentException("Invalid value");
                }
            }
            catch (Exception e)
            {
                log.Info(e.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        // DELETE api/values/5
        public void Delete(int id)
        {
            try
            {
                ProductService service = new ProductService();

                if (!service.Delete(id))
                {
                    throw new ArgumentException("Invalid id");
                }
            }
            catch (Exception e)
            {
                log.Info(e.Message);
            }
        }
    }
}
