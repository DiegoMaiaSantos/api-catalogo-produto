using System.Data;

namespace Api.Src.Shared.Infra.Data.Connection.Interface
{
    public interface IConnectionFactory
    {
        public IDbConnection CreateConnection();
        public IDbConnection CreateConnectionOpened();
    }
}
