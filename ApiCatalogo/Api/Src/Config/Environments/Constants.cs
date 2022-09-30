namespace Api.Src.Config.Environments
{
    public static class Constants
    {
        public static readonly string ENVIRONMENT = Env.Get("ASPNETCORE_ENVIRONMENT");
        public static readonly string HOST = Env.Get("DATABASE_HOST");
        public static readonly string DATABASE = Env.Get("DATABASE_NAME");
        public static readonly string USER = Env.Get("DATABASE_USER");
        public static readonly string PASS = Env.Get("DATABASE_PASS");
        public static readonly string ConnectionString = $@"
            Server = {HOST};
            Database = {DATABASE}; 
            User Id  =  {USER}; 
            Password = {PASS};";

        public static readonly string APPLICATION_NAME = "ApiCatalogo";

    }
}
