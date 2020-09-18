using LiveTestingExemplo.Context;
using LiveTestingExemplo.Entities;
using LiveTestingExemplo.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LiveTestingExemplo.Commands.AddProduct
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly IProductRepository _productRepository;
        public AddProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Title, request.Description, request.Price);

            var productDb = await _productRepository.Add(product);

            return productDb;
        }
    }
}
