using MediatR;
using System.Collections.Generic;

namespace LiveTestingExemplo.Queries.GetAll
{
    public class GetAllProductsQuery : IRequest<List<GetAllProductsViewModel>>
    {
    }
}
