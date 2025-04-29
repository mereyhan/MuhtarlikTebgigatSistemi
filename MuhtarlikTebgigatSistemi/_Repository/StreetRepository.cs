using MuhtarlikTebgigatSistemi.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi._Repository
{
    public class StreetRepository : BaseRepository, IRepository<StreetModel>
    {
        public StreetRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(StreetModel entity)
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
                command.CommandText = "DELETE FROM Street WHERE Street_Id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<StreetModel> GetAll()
        {
            var streetList = new List<StreetModel>();
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Street ORDER BY Street_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var streetModel = new StreetModel
                        {
                            Id = reader.GetInt32(0),
                            Street = reader.GetString(1),
                            CreateDate = reader.GetDateTime(2),
                            UpdateDate = reader.GetDateTime(3)
                        };
                        streetList.Add(streetModel);
                    }
                }
            }

            return streetList;
        }
        public IEnumerable<StreetModel> GetByValue(string searchValue)
        {
            throw new NotImplementedException();
        }
        public void Update(StreetModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
