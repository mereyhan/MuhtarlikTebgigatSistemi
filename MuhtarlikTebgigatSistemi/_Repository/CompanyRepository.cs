using MuhtarlikTebgigatSistemi.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi._Repository
{
    public class CompanyRepository : BaseRepository, IRepository<CompanyModel>
    {
        public CompanyRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CompanyModel entity)
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
                command.CommandText = "DELETE FROM Company WHERE Company_Id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<CompanyModel> GetAll()
        {
            var companyList = new List<CompanyModel>();
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Company ORDER BY Company_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var companyModel = new CompanyModel
                        {
                            Id = reader.GetInt32(0),
                            CompanyName = reader.GetString(1),
                            StreetName = reader.GetString(2),
                            BuildingApt = reader.GetString(3),
                            PersonName = reader.GetString(4),
                            PhoneNumber = reader.GetString(5),
                            Email = reader.GetString(6),
                            RegisterDate = reader.GetDateTime(7),
                            UpdateDate = reader.GetDateTime(8)
                        };
                        companyList.Add(companyModel);
                    }
                }
            }

            return companyList;
        }
        public IEnumerable<CompanyModel> GetByValue(string searchValue)
        {
            throw new NotImplementedException();
        }
        public void Update(CompanyModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
