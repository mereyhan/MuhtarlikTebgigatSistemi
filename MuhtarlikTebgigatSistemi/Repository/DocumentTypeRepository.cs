using MuhtarlikTebgigatSistemi.Model;
using System.Data.SQLite;

namespace MuhtarlikTebgigatSistemi.Repository;

public class DocumentTypeRepository
{
    private readonly string _cs;
    public DocumentTypeRepository(string connectionString) => _cs = connectionString;

    public int GetOrCreate(string typeName)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT DocumentType_Id FROM DocumentType WHERE DocumentType_Name = @n";
        cmd.Parameters.AddWithValue("@n", typeName);

        var result = cmd.ExecuteScalar();
        if (result != null && result != DBNull.Value)
            return Convert.ToInt32(result);

        cmd.Parameters.Clear();
        cmd.CommandText = @"INSERT INTO DocumentType (DocumentType_Name, Register_Date)
                                VALUES (@n, @r);
                                SELECT last_insert_rowid();";
        cmd.Parameters.AddWithValue("@n", typeName);
        cmd.Parameters.AddWithValue("@r", DateTime.UtcNow.ToString("yyyy-MM-dd"));

        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    public void Add(DocumentTypeModel model)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO DocumentType (DocumentType_Name, Register_Date) VALUES (@n, @r)";
        cmd.Parameters.AddWithValue("@n", model.DocumentType);
        cmd.Parameters.AddWithValue("@r", DateTime.UtcNow.ToString("yyyy-MM-dd"));

        cmd.ExecuteNonQuery();
    }

    public void Update(DocumentTypeModel model)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = "UPDATE DocumentType SET DocumentType_Name = @n, Update_Date = @u WHERE DocumentType_Id = @i";
        cmd.Parameters.AddWithValue("@n", model.DocumentType);
        cmd.Parameters.AddWithValue("@u", model.UpdateDate);
        cmd.Parameters.AddWithValue("@i", model.DocumentTypeId);

        cmd.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = "DELETE FROM DocumentType WHERE DocumentType_Id = @i";
        cmd.Parameters.AddWithValue("@i", id);

        cmd.ExecuteNonQuery();
    }

    public IEnumerable<DocumentTypeModel> GetAll()
    {
        var list = new List<DocumentTypeModel>();
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT * FROM DocumentType ORDER BY DocumentType_Id DESC";

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new DocumentTypeModel
            {
                DocumentTypeId = reader.GetInt32(0),
                DocumentType = reader.GetString(1),
                RegisterDate = reader.GetDateTime(2),
                UpdateDate = reader.IsDBNull(3) ? null : reader.GetDateTime(3)
            });
        }
        return list;
    }

    public IEnumerable<DocumentTypeModel> Search(string value)
    {
        var list = new List<DocumentTypeModel>();
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"SELECT * FROM DocumentType
                                 WHERE CAST(DocumentType_Id AS TEXT) = @value
                                    OR LOWER(DocumentType_Name) LIKE '%' || LOWER(@value) || '%'
                                 ORDER BY DocumentType_Id DESC";
        cmd.Parameters.AddWithValue("@value", value);

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new DocumentTypeModel
            {
                DocumentTypeId = reader.GetInt32(0),
                DocumentType = reader.GetString(1),
                RegisterDate = reader.GetDateTime(2),
                UpdateDate = reader.IsDBNull(3) ? null : reader.GetDateTime(3)
            });
        }
        return list;
    }

    public DocumentTypeModel GetById(int id)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT DocumentType_Id, DocumentType_Name, Register_Date, Update_Date FROM DocumentType WHERE DocumentType_Id = @i";
        cmd.Parameters.AddWithValue("@i", id);

        using var reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            return new DocumentTypeModel
            {
                DocumentTypeId = reader.GetInt32(0),
                DocumentType = reader.GetString(1),
                RegisterDate = reader.GetDateTime(2),
                UpdateDate = reader.IsDBNull(3) ? null : reader.GetDateTime(3)
            };
        }
        return null;
    }
}
