using Api.Src.Config.Environments;
using Api.Src.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Api.Src.Shared.Infra.Ioc.Factorys
{
    public static class ConnectionDbFactory
    {
        public static IServiceCollection RegisterDbConnections(this IServiceCollection connections)
        {
            connections.AddDbContext<CatalogoDBContext>(options =>
            {
                options.UseSqlServer(Constants.ConnectionStringCatalogo);
            });

            return connections;
        }
    }
}
