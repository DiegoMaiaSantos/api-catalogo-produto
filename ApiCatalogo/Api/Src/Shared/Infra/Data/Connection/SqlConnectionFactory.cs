using System.Data;
using System.Data.SqlClient;

namespace Api.Src.Shared.Infra.Data.Connection
{
    public class SqlConnectionFactory : ConnectionFactory
    {
        protected string connectionString;

        public SqlConnectionFactory(string application, string host, string database, string user, string password, int timeout = 15, int maxPoolSize = 250)
            : base(application, host, database, user, password, timeout, maxPoolSize)
        {
        }
        public override IDbConnection CreateConnection() => new SqlConnection(ConnectionString);

        public string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(connectionString))
                {
                    connectionString = $"Application Name={application}; Server={host}; Database={database}; "
                                     + $"User Id={user}; Password={password}; MultipleActiveResultSets=true; "
                                     + $"Connection Timeout={timeout}; Max Pool Size={maxPoolSize};";
                }

                return connectionString;
            }
        }
    }
}
