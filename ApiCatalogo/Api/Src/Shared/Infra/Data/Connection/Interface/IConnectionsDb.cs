namespace Api.Src.Shared.Infra.Data.Connection.Interface
{
    public interface IConnectionsDb
    {
        public IConnectionFactory ConnectionFactory { get; set; }
    }
}
