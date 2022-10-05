namespace Api.Src.Shared.Infra.Ioc.Factorys
{
    public static class RepositoryFactory
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection repositories)
        {
            return repositories;        
        }
    }
}
