using LiveTestingExemplo.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LiveTestingExemplo.Queries.GetAll
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<GetAllProductsViewModel>>
    {
        private readonly StoreDbContext _storeDbContext;
        public GetAllProductsQueryHandler(StoreDbContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }

        public async Task<List<GetAllProductsViewModel>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _storeDbContext.Products.ToListAsync();

            var productsViewModel = products
                .Select(p => new GetAllProductsViewModel(p.Id, p.Title, p.Description, p.Price))
                .ToList();

            return productsViewModel;
        }
    }
}
