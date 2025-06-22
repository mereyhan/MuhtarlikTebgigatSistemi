using MuhtarlikTebgigatSistemi.Model;
using System.Data.SQLite;

namespace MuhtarlikTebgigatSistemi.Repository;

public class PersonRepository
{
    private readonly string _cs;
    public PersonRepository(string connectionString) => _cs = connectionString;

    public int GetOrCreate(PersonModel model)
    {
        var existingId = GetByName(model.PersonName);
        return existingId ?? AddAndReturnId(model);
    }

    public int? GetByName(string name)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = new SQLiteCommand("SELECT Person_Id FROM Person WHERE Person_Name = @name", conn);
        cmd.Parameters.AddWithValue("@name", name);
        var result = cmd.ExecuteScalar();
        return result == null || result == DBNull.Value ? null : Convert.ToInt32(result);
    }

    public int AddAndReturnId(PersonModel model)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = new SQLiteCommand(@"
                INSERT INTO Person (Person_Name, Street_Id, Building_Apt, Phone, Email, Register_Date, Update_Date)
                VALUES (@name, @street, @building, @phone, @email, @reg, @upd);
                SELECT last_insert_rowid();", conn);

        cmd.Parameters.AddWithValue("@name", model.PersonName);
        cmd.Parameters.AddWithValue("@street", model.StreetId);
        cmd.Parameters.AddWithValue("@building", model.Building);
        cmd.Parameters.AddWithValue("@phone", (object)model.Phone ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@email", (object)model.Email ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@reg", DateTime.UtcNow.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@upd", (object)model.UpdateDate ?? DBNull.Value);

        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    public void Update(PersonModel model)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = new SQLiteCommand(@"
                UPDATE Person 
                SET Person_Name = @name, Street_Id = @street, Building_Apt = @building, 
                    Phone = @phone, Email = @email, Update_Date = @update
                WHERE Person_Id = @id", conn);

        cmd.Parameters.AddWithValue("@name", model.PersonName);
        cmd.Parameters.AddWithValue("@street", model.StreetId);
        cmd.Parameters.AddWithValue("@building", model.Building);
        cmd.Parameters.AddWithValue("@phone", (object)model.Phone ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@email", (object)model.Email ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@update", DateTime.UtcNow.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@id", model.PersonId);

        cmd.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = new SQLiteCommand("DELETE FROM Person WHERE Person_Id = @id", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
    }

    public IEnumerable<PersonModel> GetAll()
    {
        var list = new List<PersonModel>();

        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = new SQLiteCommand("SELECT * FROM Person ORDER BY Person_Id DESC", conn);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            list.Add(new PersonModel
            {
                PersonId = reader.GetInt32(0),
                PersonName = reader.GetString(1),
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

    public PersonModel GetById(int id)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM Person WHERE Person_Id = @i";
        cmd.Parameters.AddWithValue("@i", id);

        using var reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            return new PersonModel
            {
                PersonId = reader.GetInt32(0),
                PersonName = reader.GetString(1),
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

public class PersonOverviewRepository
{
    private readonly string _cs;
    public PersonOverviewRepository(string connectionString) => _cs = connectionString;

    public IEnumerable<PersonOverviewModel> GetAll()
    {
        var list = new List<PersonOverviewModel>();
        //MessageBox.Show("1");
        using var conn = new SQLiteConnection(_cs);
        conn.Open();
        //MessageBox.Show("2");
        using var cmd = new SQLiteCommand(@"
                SELECT Person_Id, Person_Name, Phone, Email, Register_Date, Update_Date, Person_Street, Person_Apt
                FROM PersonOverview
                ORDER BY Person_Id DESC", conn);
        //MessageBox.Show("3");
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            MessageBox.Show("4");
            list.Add(new PersonOverviewModel
            {
                PersonId = reader.GetInt32(0),
                PersonName = reader.IsDBNull(1) ? null : reader.GetString(1),
                Phone = reader.IsDBNull(2) ? null : reader.GetString(2),
                Email = reader.IsDBNull(3) ? null : reader.GetString(3),
                RegisterDate = reader.IsDBNull(4) ? null : (DateTime?)reader.GetDateTime(4),
                UpdateDate = reader.IsDBNull(5) ? null : (DateTime?)reader.GetDateTime(5),
                Street = reader.IsDBNull(6) ? null : reader.GetString(6),
                Building = reader.IsDBNull(7) ? null : reader.GetString(7)
            });
            MessageBox.Show("5");
        }
        return list;
    }

    public IEnumerable<PersonOverviewModel> Search(string value)
    {
        var list = new List<PersonOverviewModel>();
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = @"
        SELECT Person_Id, Person_Name, Phone, Email, Register_Date, Update_Date, Person_Street, Person_Apt
        FROM PersonOverview 
        WHERE LOWER(Person_Name) LIKE '%' || LOWER(@v) || '%'
           OR LOWER(Street_Name) LIKE '%' || LOWER(@v) || '%'
           OR LOWER(Phone) LIKE '%' || LOWER(@v) || '%'
           OR LOWER(Email) LIKE '%' || LOWER(@v) || '%'
        ORDER BY Person_Id DESC";

        cmd.Parameters.AddWithValue("@v", value);

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new PersonOverviewModel
            {
                PersonId = reader.GetInt32(0),
                PersonName = reader.IsDBNull(1) ? null : reader.GetString(1),
                Phone = reader.IsDBNull(2) ? null : reader.GetString(2),
                Email = reader.IsDBNull(3) ? null : reader.GetString(3),
                RegisterDate = reader.IsDBNull(4) ? null : (DateTime?)reader.GetDateTime(4),
                UpdateDate = reader.IsDBNull(5) ? null : (DateTime?)reader.GetDateTime(5),
                Street = reader.IsDBNull(6) ? null : reader.GetString(6),
                Building = reader.IsDBNull(7) ? null : reader.GetString(7)
            });
        }

        return list;
    }
}