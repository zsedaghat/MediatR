using MediatR;
using MediatRTest.DTO;

namespace MediatRTest.Product.Commands.Create
{
    //خروجی که میخواهیم داشته باشیم در <> میگذاریم
    public class AddProductCommand:IRequest<ProductDto>
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Discount { get; set; }
    }
}
