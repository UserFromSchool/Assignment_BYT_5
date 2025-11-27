namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType type)
        {
            switch (type)
            {
                case DatabaseType.SqlServer:
                    return new SqlServerDatabase();
                case DatabaseType.Oracle:
                    return new OracleDatabase();
                default:
                    throw new Exception($"Database factory does not support: {type}");
            }
        }
    }
}
