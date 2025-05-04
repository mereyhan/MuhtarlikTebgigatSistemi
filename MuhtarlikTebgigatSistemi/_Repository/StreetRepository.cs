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
            this.sqliteConnectionString = connectionString;
        }
        public void Add(StreetModel entity)
        {
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Street (Street_Name, Create_Date, Update_Date)
                                        VALUES (@streetName, @createDate, @updateDate)";
                command.Parameters.AddWithValue("@streetName", entity.Street);
                command.Parameters.AddWithValue("@createDate", DateTime.Now);
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
                command.CommandText = "DELETE FROM Street WHERE Street_Id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        public void Update(StreetModel entity)
        {
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Street 
                                        SET Street_Name = @streetName, 
                                            Update_Date = @updateDate
                                        WHERE Street_Id = @id";
                command.Parameters.AddWithValue("@streetName", entity.Street);
                command.Parameters.AddWithValue("@updateDate", DateTime.Now);
                command.Parameters.AddWithValue("@id", entity.Id);
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<StreetModel> GetAll()
        {
            var streetList = new List<StreetModel>();
            using (var connection = new SQLiteConnection(sqliteConnectionString))
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
                            RegisterDate = reader.GetDateTime(2),
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
            var streetList = new List<StreetModel>();
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = 
                    "SELECT * FROM Street " +
                    "WHERE CAST(Street_Id AS TEXT) = @searchValue " +
                    "OR LOWER(Street_Name) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "ORDER BY Street_Id DESC";
                command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var streetModel = new StreetModel
                        {
                            Id = reader.GetInt32(0),
                            Street = reader.GetString(1),
                            RegisterDate = reader.GetDateTime(2),
                            UpdateDate = reader.GetDateTime(3)
                        };
                        streetList.Add(streetModel);
                    }
                }
            }
            return streetList;
        }
    }
}
