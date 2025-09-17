using Npgsql;
using System;

namespace Controle_de_Estoque
{
    internal class DatabaseConnection
    {
        private readonly string connectionString;

        public DatabaseConnection(string host, string database, string user, string password)
        {
            this.connectionString = $"Host={host};Username={user};Password={password};Database={database}";
        }

        public NpgsqlConnection GetConnection()
        {
            try
            {
                var conn = new NpgsqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                // Em um projeto real, você logaria o erro ou mostraria uma mensagem mais amigável.
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                return null;
            }
        }
    }
}