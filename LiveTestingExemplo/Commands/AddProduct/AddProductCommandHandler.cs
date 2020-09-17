using LiveTestingExemplo.Context;
using LiveTestingExemplo.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace LiveTestingExemplo.Commands.AddProduct
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Unit>
    {
        private readonly StoreDbContext _storeDbContext;
        public AddProductCommandHandler(StoreDbContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }

        public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Title, request.Description, request.Price);

            await _storeDbContext.Products.AddAsync(product);

            return Unit.Value;
        }
    }
}
