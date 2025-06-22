using MuhtarlikTebgigatSistemi.Model;
using System.Data.SQLite;

namespace MuhtarlikTebgigatSistemi.Repository;

public class StreetRepository
{
    private readonly string _cs;
    public StreetRepository(string connectionString) => _cs = connectionString;

    public int GetOrCreate(string streetName)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = new SQLiteCommand("SELECT Street_Id FROM Street WHERE Street_Name = @s", conn);
        cmd.Parameters.AddWithValue("@s", streetName);
        var result = cmd.ExecuteScalar();
        if (result != null && result != DBNull.Value)
            return Convert.ToInt32(result);

        cmd.Parameters.Clear();
        cmd.CommandText = @"INSERT INTO Street (Street_Name, Register_Date)
                                VALUES (@s, @d);
                                SELECT last_insert_rowid();";
        cmd.Parameters.AddWithValue("@s", streetName);
        cmd.Parameters.AddWithValue("@d", DateTime.UtcNow.ToString("yyyy-MM-dd"));
        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    public IEnumerable<StreetModel> GetAll()
    {
        var list = new List<StreetModel>();
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = new SQLiteCommand("SELECT * FROM Street ORDER BY Street_Id DESC", conn);
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new StreetModel
            {
                StreetId = reader.GetInt32(0),
                Street = reader.GetString(1),
                RegisterDate = reader.GetDateTime(2),
                UpdateDate = reader.IsDBNull(3) ? null : reader.GetDateTime(3)
            });
        }
        return list;
    }

    public void Add(StreetModel model)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = new SQLiteCommand("INSERT INTO Street (Street_Name, Register_Date) VALUES (@name, @date)", conn);
        cmd.Parameters.AddWithValue("@name", model.Street);
        cmd.Parameters.AddWithValue("@date", model.RegisterDate);
        cmd.ExecuteNonQuery();
    }

    public void Update(StreetModel model)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = new SQLiteCommand("UPDATE Street SET Street_Name = @name, Update_Date = @update WHERE Street_Id = @id", conn);
        cmd.Parameters.AddWithValue("@name", model.Street);
        cmd.Parameters.AddWithValue("@update", model.UpdateDate);
        cmd.Parameters.AddWithValue("@id", model.StreetId);
        cmd.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = new SQLiteCommand("DELETE FROM Street WHERE Street_Id = @id", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
    }

    public IEnumerable<StreetModel> Search(string value)
    {
        var list = new List<StreetModel>();
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = new SQLiteCommand(@"SELECT * FROM Street
                                          WHERE CAST(Street_Id AS TEXT) = @v
                                             OR LOWER(Street_Name) LIKE '%' || LOWER(@v) || '%'
                                          ORDER BY Street_Id DESC", conn);
        cmd.Parameters.AddWithValue("@v", value);

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new StreetModel
            {
                StreetId = reader.GetInt32(0),
                Street = reader.GetString(1),
                RegisterDate = reader.GetDateTime(2),
                UpdateDate = reader.IsDBNull(3) ? null : reader.GetDateTime(3)
            });
        }
        return list;
    }

    public StreetModel GetById(int id)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = new SQLiteCommand("SELECT * FROM Street WHERE Street_Id = @id", conn);
        cmd.Parameters.AddWithValue("@id", id);

        using var reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            return new StreetModel
            {
                StreetId = reader.GetInt32(0),
                Street = reader.GetString(1),
                RegisterDate = reader.GetDateTime(2),
                UpdateDate = reader.IsDBNull(3) ? null : reader.GetDateTime(3)
            };
        }
        return null;
    }
}