using Api.Src.Shared.Infra.Data.Connection.Interface;

namespace Api.Src.Shared.Infra.Data.Connection
{
    public class ConnectionsDb : IConnectionsDb
    {
        public IConnectionFactory ConnectionFactory { get; set; }
    }
}
