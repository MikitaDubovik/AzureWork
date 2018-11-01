using AzureWork.DbModel;
using System.Collections.Generic;

namespace AzureWork.Service
{
    public interface IProductService
    {
        IEnumerable<Product> Get();

        Product Get(int id);

        bool Delete(int id);

        bool Put(Product product);

        bool Post(Product product);
    }
}
