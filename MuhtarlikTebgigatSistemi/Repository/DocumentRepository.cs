using MuhtarlikTebgigatSistemi.Model;
using System.Data;
using System.Data.SQLite;

namespace MuhtarlikTebgigatSistemi.Repository;

public class DocumentRepository
{
    private readonly string _cs;
    public DocumentRepository(string connectionString) => _cs = connectionString;

    public int AddAndReturnId(DocumentModel model)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            INSERT INTO Document
            (DocumentType_Id, Person_Id, Company_Id, Receiver_Id, Registration_Date, Delivery_Date)
            VALUES (@type, @person, @company, @receiver, @regDate, @delDate);
            SELECT last_insert_rowid();";

        cmd.Parameters.AddWithValue("@type", model.DocumentTypeId);
        cmd.Parameters.AddWithValue("@person", (object?)model.PersonId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@company", (object?)model.CompanyId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@receiver", (object?)model.ReceiverId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@regDate", DateTime.UtcNow.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@delDate", (object?)model.UpdateDate ?? DBNull.Value);

        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    public void Update(DocumentModel model)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            UPDATE Document
            SET DocumentType_Id = @type,
                Person_Id = @person,
                Company_Id = @company,
                Receiver_Id = @receiver,
                Delivery_Date = @delDate
            WHERE Document_Id = @id;";

        cmd.Parameters.AddWithValue("@type", model.DocumentTypeId);
        cmd.Parameters.AddWithValue("@person", (object?)model.PersonId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@company", (object?)model.CompanyId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@receiver", (object?)model.ReceiverId ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@delDate", (object?)model.UpdateDate ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@id", model.DocumentId);

        cmd.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = "DELETE FROM Document WHERE Document_Id = @id";
        cmd.Parameters.AddWithValue("@id", id);

        cmd.ExecuteNonQuery();
    }

    public DocumentModel? GetById(int id)
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = @"
        SELECT Document_Id, DocumentType_Id, Person_Id, Registration_Date, Delivery_Date, Company_Id, Receiver_Id
        FROM Document
        WHERE Document_Id = @id";

        cmd.Parameters.AddWithValue("@id", id);

        using var reader = cmd.ExecuteReader();
        if (!reader.Read()) return null;

        return new DocumentModel
        {
            DocumentId = reader.GetInt32(0),
            DocumentTypeId = reader.GetInt32(1),
            PersonId = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
            RegistrationDate = reader.GetDateTime(3),
            UpdateDate = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
            CompanyId = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5),
            ReceiverId = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6)
        };
    }

    public IEnumerable<DocumentModel> GetAll()
    {
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = @"
        SELECT Document_Id, DocumentType_Id, Person_Id, Registration_Date, Delivery_Date, Company_Id, Receiver_Id
        FROM Document ORDER BY Document_Id DESC";

        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            yield return new DocumentModel
            {
                DocumentId = reader.GetInt32(0),
                DocumentTypeId = reader.GetInt32(1),
                PersonId = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
                RegistrationDate = reader.GetDateTime(3),
                UpdateDate = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                CompanyId = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5),
                ReceiverId = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6)
            };

        }
    }
}

public class DocumentOverviewRepository
{
    private readonly string _cs;
    public DocumentOverviewRepository(string connectionString) => _cs = connectionString;

    public IEnumerable<DocumentOverviewModel> GetAll()
    {
        var list = new List<DocumentOverviewModel>();
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = @"
                SELECT Document_Id, DocumentType_Name, Name, Street_Name, Apt, Receiver, Registration_Date, Delivery_Date
                FROM DocumentOverview
                ORDER BY Document_Id DESC";

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new DocumentOverviewModel
            {
                DocumentId = reader.GetInt32(0),
                DocumentType = reader.GetString(1),
                Name = reader.IsDBNull(2) ? null : reader.GetString(2),
                Street = reader.IsDBNull(3) ? null : reader.GetString(3),
                Building = reader.IsDBNull(4) ? null : reader.GetString(4),
                ReceiverName = reader.IsDBNull(5) ? null : reader.GetString(5),
                RegistrationDate = reader.IsDBNull(6) ? null : (DateTime?)reader.GetDateTime(6),
                UpdateDate = reader.IsDBNull(7) ? null : (DateTime?)reader.GetDateTime(7),
            });
        }
        return list;
    }

    public IEnumerable<DocumentOverviewModel> Search(string value)
    {
        var list = new List<DocumentOverviewModel>();
        using var conn = new SQLiteConnection(_cs);
        conn.Open();

        var cmd = conn.CreateCommand();
        cmd.CommandText = @"
                SELECT Document_Id, DocumentType_Name, Registration_Date, Name, Street_Name, Apt, Receiver
                FROM DocumentOverview
                WHERE LOWER(DocumentType_Name) LIKE @val
                   OR LOWER(Name) LIKE @val
                   OR LOWER(Street_Name) LIKE @val
                   OR LOWER(Receiver) LIKE @val
                ORDER BY Document_Id DESC";

        cmd.Parameters.AddWithValue("@val", "%" + value.ToLower() + "%");

        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new DocumentOverviewModel
            {
                DocumentId = reader.GetInt32(0),
                DocumentType = reader.GetString(1),
                Name = reader.IsDBNull(2) ? null : reader.GetString(2),
                Street = reader.IsDBNull(3) ? null : reader.GetString(3),
                Building = reader.IsDBNull(4) ? null : reader.GetString(4),
                ReceiverName = reader.IsDBNull(5) ? null : reader.GetString(5),
                RegistrationDate = reader.IsDBNull(6) ? null : (DateTime?)reader.GetDateTime(6),
                UpdateDate = reader.IsDBNull(7) ? null : (DateTime?)reader.GetDateTime(7),
            });
        }
        return list;
    }
}