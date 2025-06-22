using MuhtarlikTebgigatSistemi.Model;
using System.Data.SQLite;

namespace MuhtarlikTebgigatSistemi.Repository;

public class CompanyRepository
{
    private readonly string _cs;
    public CompanyRepository(string connectionString) => _cs = connectionString;

    public int GetOrCreate(CompanyModel model)
    {
        var existingId = GetByName(model.CompanyName);
        return existingId ?? AddAndReturnId(model);
    }

    public int? GetByName(string name)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();
        var cmd = new SQLiteCommand("SELECT Company_Id FROM Company WHERE Company_Name = @n", conn);
        cmd.Parameters.AddWithValue("@n", name);
        var r = cmd.ExecuteScalar();
        return r == null ? (int?)null : Convert.ToInt32(r);
    }

    public int AddAndReturnId(CompanyModel company)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();
        var cmd = new SQLiteCommand(
            @"INSERT INTO Company 
              (Company_Name, Street_Id, Building_Apt, Phone, Email, Register_Date, Update_Date) 
              VALUES (@n,@s,@a,@p,@e,@rd,@ud);
              SELECT last_insert_rowid();", conn);
        cmd.Parameters.AddWithValue("@n", company.CompanyName);
        cmd.Parameters.AddWithValue("@s", company.StreetId);
        cmd.Parameters.AddWithValue("@a", company.Building);
        cmd.Parameters.AddWithValue("@p", (object)company.Phone ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@e", (object)company.Email ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@rd", DateTime.UtcNow.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@ud", (object)company.UpdateDate ?? DBNull.Value);

        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    public void Update(CompanyModel company)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();
        var cmd = new SQLiteCommand(
            @"UPDATE Company 
                  SET Company_Name = @n, Street_Id = @s, Building_Apt = @a, 
                      Phone = @p, Email = @e, Update_Date = @ud 
                  WHERE Company_Id = @id", conn);
        cmd.Parameters.AddWithValue("@n", company.CompanyName);
        cmd.Parameters.AddWithValue("@s", company.StreetId);
        cmd.Parameters.AddWithValue("@a", company.Building);
        cmd.Parameters.AddWithValue("@p", (object)company.Phone ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@e", (object)company.Email ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@ud", DateTime.UtcNow.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@id", company.CompanyId);

        cmd.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();
        var cmd = new SQLiteCommand("DELETE FROM Company WHERE Company_Id = @id", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
    }
    public IEnumerable<CompanyModel> GetAll()
    {
        var list = new List<CompanyModel>();

        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = new SQLiteCommand("SELECT * FROM Company ORDER BY Company_Id DESC", conn);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new CompanyModel
            {
                CompanyId = reader.GetInt32(0),
                CompanyName = reader.GetString(1),
                StreetId = reader.GetInt32(2),
                Building = reader.GetString(3),
                Phone = reader.IsDBNull(4) ? null : reader.GetString(4),
                Email = reader.IsDBNull(5) ? null : reader.GetString(5),
                RegisterDate = reader.GetDateTime(6),
                UpdateDate = reader.IsDBNull(7) ? null : reader.GetDateTime(7)
            });
        }
        return list;
    }

    public CompanyModel GetById(int id)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM Company WHERE Company_Id = @i";
        cmd.Parameters.AddWithValue("@i", id);

        using var reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            return new CompanyModel
            {
                CompanyId = reader.GetInt32(0),
                CompanyName = reader.GetString(1),
                StreetId = reader.GetInt32(2),
                Building = reader.GetString(3),
                Phone = reader.IsDBNull(4) ? null : reader.GetString(4),
                Email = reader.IsDBNull(5) ? null : reader.GetString(5),
                RegisterDate = reader.GetDateTime(6),
                UpdateDate = reader.IsDBNull(7) ? null : reader.GetDateTime(7)
            };
        }
        return null;
    }
}

public class CompanyOverviewRepository
{
    private readonly string _cs;
    public CompanyOverviewRepository(string connectionString) => _cs = connectionString;

    public IEnumerable<CompanyOverviewModel> GetAll()
    {
        var list = new List<CompanyOverviewModel>();
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            SELECT Company_Id, Company_Name, Company_Street, Company_Apt, Phone, Email, Register_Date, Update_Date 
            FROM CompanyOverview 
            ORDER BY Company_Id DESC";

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new CompanyOverviewModel
            {
                CompanyId = reader.GetInt32(0),
                CompanyName = reader.GetString(1),
                StreetName = reader.GetString(2),
                Building = reader.GetString(3),
                Phone = reader.IsDBNull(4) ? null : reader.GetString(4),
                Email = reader.IsDBNull(5) ? null : reader.GetString(5),
                RegisterDate = reader.GetDateTime(6),
                UpdateDate = reader.IsDBNull(7) ? null : (DateTime?)reader.GetDateTime(7)
            });
        }

        return list;
    }

    public IEnumerable<CompanyOverviewModel> Search(string value)
    {
        var list = new List<CompanyOverviewModel>();
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = @"
        SELECT Company_Id, Company_Name, Company_Street, Company_Apt, Phone, Email, Register_Date, Update_Date 
        FROM CompanyOverview 
        WHERE LOWER(Company_Name) LIKE '%' || LOWER(@v) || '%'
           OR LOWER(Street_Name) LIKE '%' || LOWER(@v) || '%'
           OR LOWER(Phone) LIKE '%' || LOWER(@v) || '%'
           OR LOWER(Email) LIKE '%' || LOWER(@v) || '%'
        ORDER BY Company_Id DESC";

        cmd.Parameters.AddWithValue("@v", value);

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new CompanyOverviewModel
            {
                CompanyId = reader.GetInt32(0),
                CompanyName = reader.GetString(1),
                StreetName = reader.GetString(2),
                Building = reader.GetString(3),
                Phone = reader.IsDBNull(4) ? null : reader.GetString(4),
                Email = reader.IsDBNull(5) ? null : reader.GetString(5),
                RegisterDate = reader.GetDateTime(6),
                UpdateDate = reader.IsDBNull(7) ? null : (DateTime?)reader.GetDateTime(7)
            });
        }

        return list;
    }
}