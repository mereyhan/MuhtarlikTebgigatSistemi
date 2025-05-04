using MuhtarlikTebgigatSistemi.Model;
using System.Data.SQLite;

namespace MuhtarlikTebgigatSistemi._Repository
{
    public class DocTypeRepository : BaseRepository, IRepository<DocTypeModel>
    {
        public DocTypeRepository(string connectionString)
        {
            this.sqliteConnectionString = connectionString;
        }

        public void Add(DocTypeModel entity)
        {
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO DocumentType (DocumentType_Name, Register_Date, Update_Date)
                                        VALUES (@type, @registerDate, @updateDate)";
                command.Parameters.AddWithValue("@type", entity.Type);
                command.Parameters.AddWithValue("@registerDate", DateTime.Now);
                command.Parameters.AddWithValue("@updateDate", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM DocumentType WHERE DocumentType_Id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        public void Update(DocTypeModel entity)
        {
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE DocumentType 
                                        SET DocumentType_Name = @type, 
                                            Update_Date = @updateDate
                                        WHERE DocumentType_Id = @id";
                command.Parameters.AddWithValue("@type", entity.Type);
                command.Parameters.AddWithValue("@updateDate", DateTime.Now);
                command.Parameters.AddWithValue("@id", entity.Id);
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<DocTypeModel> GetAll()
        {
            var doctypeList = new List<DocTypeModel>();
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM DocumentType ORDER BY DocumentType_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var doctypeModel = new DocTypeModel
                        {
                            Id = reader.GetInt32(0),
                            Type = reader.GetString(1),
                            RegisterDate = reader.GetDateTime(2),
                            UpdateDate = reader.GetDateTime(3)
                        };
                        doctypeList.Add(doctypeModel);
                    }
                }
            }

            return doctypeList;
        }
        public IEnumerable<DocTypeModel> GetByValue(string searchValue)
        {
            var doctypeList = new List<DocTypeModel>();
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = 
                    "SELECT * FROM DocumentType " +
                    "WHERE CAST(DocumentType_Id AS TEXT) = @searchValue " +
                    "OR LOWER(DocumentType_Name) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "ORDER BY DocumentType_Id DESC";
                command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var doctypeModel = new DocTypeModel
                        {
                            Id = reader.GetInt32(0),
                            Type = reader.GetString(1),
                            RegisterDate = reader.GetDateTime(2),
                            UpdateDate = reader.GetDateTime(3)
                        };
                        doctypeList.Add(doctypeModel);
                    }
                }
            }
            return doctypeList;
        }
        
    }
}
