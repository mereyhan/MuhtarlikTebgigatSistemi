using System.Data.SQLite;

namespace MuhtarlikTebgigatSistemi._Repository
{
    public class LoginRepository: BaseRepository
    {
        public LoginRepository(string connectionString)
        {
            this.sqliteConnectionString = connectionString;
        }

        public bool ValidateUser(string username, string password)
        {
            try
            {
                using (var connection = new SQLiteConnection(sqliteConnectionString))
                using (var command = new SQLiteCommand(connection))
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT COUNT(*) FROM Users 
                                        WHERE Username = @username AND Password = @password";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    
                    var count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Login sorgusu sırasında hata: {ex.Message}");
                return false;
            }
        }
    }
}
