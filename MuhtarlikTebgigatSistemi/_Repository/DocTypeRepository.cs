using MuhtarlikTebgigatSistemi.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi._Repository
{
    public class DocTypeRepository : BaseRepository, IRepository<DocTypeModel>
    {
        public DocTypeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(DocTypeModel entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM DocumentType WHERE DocumentType_Id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<DocTypeModel> GetAll()
        {
            var doctypeList = new List<DocTypeModel>();
            using (var connection = new SQLiteConnection(connectionString))
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
                            CreateDate = reader.GetDateTime(2),
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
            throw new NotImplementedException();
        }
        public void Update(DocTypeModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
