using MediatRTest.Product.Commands.Create;
using System.Reflection;
using MediatRTest;

namespace MediatRTest
{
    public static class Assemblies
    {
        public static readonly Assembly applicationAssmbelies = typeof(AddProductCommand).Assembly;
    }
}
