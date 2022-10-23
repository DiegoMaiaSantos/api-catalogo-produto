using Api.Src.Domain.Interfaces.Repositories;
using Api.Src.Infra.Data.Contexts;
using Api.Src.Infra.Data.Contexts.Interface;
using Api.Src.Infra.Data.Repositories;

namespace Api.Src.Shared.Infra.Ioc.Factorys
{
    public static class RepositoryFactory
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection repositories)
        {
            repositories.AddScoped<IUnitOfWork, UnitOfWork>();
            repositories.AddScoped<ICategoriaRepository, CategoriaRepository>();
            repositories.AddScoped<IProdutoRepository, ProdutoRepository>();

            return repositories;        
        }
    }
}
