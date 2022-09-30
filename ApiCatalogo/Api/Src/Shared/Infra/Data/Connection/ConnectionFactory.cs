using Api.Src.Shared.Infra.Data.Connection.Interface;
using System.Data;

namespace Api.Src.Shared.Infra.Data.Connection
{
    public abstract class ConnectionFactory : IConnectionFactory
    {
        protected readonly string application;

        protected readonly string host;

        protected readonly string database;

        protected readonly string user;

        protected readonly string password;

        protected readonly int timeout;

        protected readonly int maxPoolSize;

        protected ConnectionFactory(string application, string host, string database,
            string user, string password, int timeout, int maxPoolSize)
        {
            this.application = application;
            this.host = host;
            this.database = database;
            this.user = user;
            this.password = password;
            this.timeout = timeout;
            this.maxPoolSize = maxPoolSize;

            AssertRequiredVariables();
        }

        public IDbConnection CreateConnectionOpened()
        {
            var connection = CreateConnection();
            connection.Open();

            return connection;
        }

        public abstract IDbConnection CreateConnection();

        protected void AssertRequiredVariables()
        {
            AssertRequiredVariable("Host", host);
            AssertRequiredVariable("Database", database);
            AssertRequiredVariable("User", user);
            AssertRequiredVariable("Password", password);
        }

        protected void AssertRequiredVariable(string name, string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException($"{name} can not be null or empty.");
        }
    }
}
