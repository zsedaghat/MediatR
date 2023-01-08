using MediatR;


namespace MediatRTest
{
    public static class ServiceRegistery
    {
        public static IServiceCollection AddApplicationServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddMediatR(Assemblies.applicationAssmbelies);
            return builder.Services;
               
        }
    }
}
