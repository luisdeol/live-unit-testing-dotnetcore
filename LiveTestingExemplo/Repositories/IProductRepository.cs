using LiveTestingExemplo.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LiveTestingExemplo.Repositories
{
    public interface IProductRepository
    {
        Task Add(Product product);
        List<Product> GetAll();
    }
}
