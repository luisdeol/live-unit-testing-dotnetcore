using LiveTestingExemplo.Entities;
using MediatR;

namespace LiveTestingExemplo.Commands.AddProduct
{
    public class AddProductCommand : IRequest<Product>
    {
        public AddProductCommand(string title, string description, decimal price)
        {
            Title = title;
            Description = description;
            Price = price;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
    }
}
