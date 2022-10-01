using Api.Src.Config.Environments;
using Api.Src.Shared.Infra.Data.Connection;
using Api.Src.Shared.Infra.Data.Connection.Interface;

namespace Api.Src.Shared.Infra.Ioc.Factorys
{
    public static class ConnectionDbFactory
    {
        public static IServiceCollection RegisterDbConnections(this IServiceCollection connections)
        {
            SqlConnectionFactory _connecionFactory = new(Constants.APPLICATION_NAME, Constants.HOST,
                Constants.DATABASE, Constants.USER, Constants.PASS);

            ConnectionsDb connecionFactory = new()
            {
                ConnectionFactory = _connecionFactory,
            };

            connections.AddTransient<IConnectionsDb>(_ => connecionFactory);

            return connections;
        }
    }
}
