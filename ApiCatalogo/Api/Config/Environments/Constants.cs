namespace Api.Src.Config.Environments
{
    public static class Constants
    {
        public static readonly string ENVIRONMENT = Env.Get("ASPNETCORE_ENVIRONMENT");
        public static readonly string APPLICATION_NAME = "APPLICATION_NAME";
        public static readonly string APP_URL = Env.Get("APP_URL");
        public static readonly string HOST = Env.Get("DATABASE_HOST");
        public static readonly string DATABASE = Env.Get("DATABASE_NAME");
        public static readonly string USER = Env.Get("DATABASE_USER");
        public static readonly string PASS = Env.Get("DATABASE_PASS");

        public static readonly string ConnectionStringCatalogo = $@"
            Application Name ={APPLICATION_NAME};
            Server = {HOST};
            Database = {DATABASE}; 
            User Id = {USER};
            Password = {PASS};";
    }
}
