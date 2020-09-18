using LiveTestingExemplo.Commands.AddProduct;
using LiveTestingExemplo.Entities;
using LiveTestingExemplo.Repositories;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace LiveTestingExemplo.UnitTests.Commands
{
    public class AddProductCommandTests
    {
        [Fact]
        public async Task CommandIsValid_Executed_Success()
        {
            // Arrange
            var productRepository = new Mock<IProductRepository>();
            var addProductCommand = new AddProductCommand("titulo", "descricao", 1000);

            var product = new Product("", "", 1000);

            // productRepository.Setup(pr => pr.Add(It.IsAny<Product>())).Verifiable();
            productRepository.Setup(pr => pr.Add(It.IsAny<Product>())).Returns(Task.FromResult(product));

            var addProductCommandHandler = new AddProductCommandHandler(productRepository.Object);

            // Act
            var productResult = await addProductCommandHandler.Handle(addProductCommand, new CancellationToken());

            // Assert
            productRepository.Verify(pr => pr.Add(It.IsAny<Product>()), Times.Once);
            Assert.NotNull(productResult);
            Assert.Equal(product.Price, productResult.Price);
            Assert.Equal(product.Title, productResult.Title);
            Assert.Equal(product.Description, productResult.Description);
        }
    }
}
