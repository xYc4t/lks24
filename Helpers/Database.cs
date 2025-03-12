using MySql.Data.MySqlClient;

namespace lks24
{
    public static class Database
    {
        private const string ConnectionString = "server=localhost;database=lks24;user=root;password=;";

        /// <summary>
        /// Gets a new MySqlConnection instance.
        /// </summary>
        public static MySqlConnection Connection()
        {
            return new MySqlConnection(ConnectionString);
        }

        /// <summary>
        /// Tests the database connection.
        /// Throws an exception if it fails.
        /// </summary>
        public static async Task TestConnection()
        {
            using (var connection = Connection())
            {
                try
                {
                    await connection.OpenAsync();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Database connection failed: {ex.Message}");
                }
            }
        }
    }
}