using MuhtarlikTebgigatSistemi.Model;
using System.Data.SQLite;

namespace MuhtarlikTebgigatSistemi.Repository;

public class LoginRepository
{
    private readonly string _cs;
    public LoginRepository(string connectionString) => _cs = connectionString;

    public bool ValidateUser(string username, string password)
    {
        try
        {
            using var conn = new SQLiteConnection(_cs);
            conn.Open();

            using var cmd = new SQLiteCommand("SELECT Password FROM Users WHERE Username = @username", conn);
            cmd.Parameters.AddWithValue("@username", username);

            var storedHash = cmd.ExecuteScalar() as string;
            return storedHash != null && BCrypt.Net.BCrypt.Verify(password, storedHash);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Login işlemi sırasında hata: {ex.Message}");
            return false;
        }
    }

    public void Add(LoginModel user)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = new SQLiteCommand("INSERT INTO Users (Username, Password, Role) VALUES (@u, @p, @r)", conn);
        var hashed = BCrypt.Net.BCrypt.HashPassword(user.Password);

        cmd.Parameters.AddWithValue("@u", user.UserName);
        cmd.Parameters.AddWithValue("@p", hashed);
        cmd.Parameters.AddWithValue("@r", user.Role ?? "Admin");

        cmd.ExecuteNonQuery();
    }

    public void Update(LoginModel user)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = new SQLiteCommand("UPDATE Users SET Username = @u, Password = @p, Role = @r WHERE Id = @i", conn);
        var hashed = BCrypt.Net.BCrypt.HashPassword(user.Password);

        cmd.Parameters.AddWithValue("@u", user.UserName);
        cmd.Parameters.AddWithValue("@p", hashed);
        cmd.Parameters.AddWithValue("@r", user.Role);
        cmd.Parameters.AddWithValue("@i", user.UserId);

        cmd.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = new SQLiteCommand("DELETE FROM Users WHERE Id = @i", conn);
        cmd.Parameters.AddWithValue("@i", id);

        cmd.ExecuteNonQuery();
    }

    public IEnumerable<LoginModel> GetAll()
    {
        var list = new List<LoginModel>();
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = new SQLiteCommand("SELECT Id, Username, Role FROM Users ORDER BY Id DESC", conn);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new LoginModel
            {
                UserId = reader.GetInt32(0),
                UserName = reader.GetString(1),
                Role = reader.GetString(2)
            });
        }
        return list;
    }

    public LoginModel GetById(int id)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = new SQLiteCommand("SELECT Id, Username, Role FROM Users WHERE Id = @i", conn);
        cmd.Parameters.AddWithValue("@i", id);

        using var reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            return new LoginModel
            {
                UserId = reader.GetInt32(0),
                UserName = reader.GetString(1),
                Role = reader.GetString(2)
            };
        }
        return null;
    }

    public IEnumerable<LoginModel> Search(string search)
    {
        var list = new List<LoginModel>();
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = new SQLiteCommand(@"SELECT Id, Username, Role FROM Users
                                              WHERE CAST(Id AS TEXT) = @s OR LOWER(Username) LIKE '%' || LOWER(@s) || '%'
                                              ORDER BY Id DESC", conn);
        cmd.Parameters.AddWithValue("@s", search);

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new LoginModel
            {
                UserId = reader.GetInt32(0),
                UserName = reader.GetString(1),
                Role = reader.GetString(2)
            });
        }
        return list;
    }
}