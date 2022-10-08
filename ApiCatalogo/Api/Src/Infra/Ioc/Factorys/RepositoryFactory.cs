using Api.Src.Infra.Data.Contexts;
using Api.Src.Infra.Data.Contexts.Interface;

namespace Api.Src.Shared.Infra.Ioc.Factorys
{
    public static class RepositoryFactory
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection repositories)
        {
            repositories.AddScoped<IUnitOfWork, UnitOfWork>();

            return repositories;        
        }
    }
}
