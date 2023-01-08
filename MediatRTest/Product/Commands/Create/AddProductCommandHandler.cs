using MediatR;
using MediatRTest.DTO;

namespace MediatRTest.Product.Commands.Create
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, ProductDto>
    {
        public Task<ProductDto> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
