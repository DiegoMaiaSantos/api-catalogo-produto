using Api.Src.Domain.Interfaces.Services;
using Api.Src.Domain.Mappings;
using Api.Src.Services;

namespace Api.Src.Shared.Infra.Ioc.Factorys
{
    public static class ServiceFactory
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DtoToEntityMapping));
            services.AddScoped<ICategoriaService, CategoriaService>();
            return services;        
        }
    }
}
