using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzureWork.DbModel;

namespace AzureWork.Service
{
    public class ProductService : IProductService
    {
        private readonly DbModel.AdventureWorks2017Entities _entities = new DbModel.AdventureWorks2017Entities();

        public IEnumerable<Product> Get()
        {
            var query = _entities.Products.Select(p => p);

            return query.AsEnumerable();
        }

        public Product Get(int id)
        {
            var query = _entities.Products.FirstOrDefault(p => p.ProductID==id);

            return query;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Put(Product product)
        {
            throw new NotImplementedException();
        }

        public bool Post(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
