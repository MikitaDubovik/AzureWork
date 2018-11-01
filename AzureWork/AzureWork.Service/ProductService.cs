using AzureWork.DbModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
            var query = _entities.Products.FirstOrDefault(p => p.ProductID == id);

            return query;
        }

        public bool Delete(int id)
        {
            var enitie = _entities.Products.FirstOrDefault(p => p.ProductID == id);
            if (enitie == null)
            {
                return false;
            }

            _entities.Products.Remove(enitie);
            _entities.SaveChanges();
            return true;
        }

        public bool Put(int id, Product product)
        {
            var enitie = _entities.Products.FirstOrDefault(p => p.ProductID == id);
            if (enitie == null)
            {
                try
                {
                    _entities.Products.Add(product);
                    _entities.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            try
            {
                _entities.Products.Remove(enitie);
                _entities.Products.Add(product);
                _entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Post(Product product)
        {
            try
            {
                _entities.Products.Add(product);
                _entities.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
