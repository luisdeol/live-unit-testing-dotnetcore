using LiveTestingExemplo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LiveTestingExemplo.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository()
        {

        }
        public Task Add(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
