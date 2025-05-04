using MuhtarlikTebgigatSistemi.Model;
using System.Data.SQLite;

namespace MuhtarlikTebgigatSistemi._Repository
{
    public class CompanyRepository : BaseRepository, IRepository<CompanyModel>
    {
        public CompanyRepository(string connectionString)
        {
            this.sqliteConnectionString = connectionString;
        }

        public void Add(CompanyModel entity)
        {
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Company (Company_Name, Street_Name, Building_Apt, Person_Name, Phone, Email, Register_Date, Update_Date)
                                        VALUES (@companyName, @streetName, @buildingApt, @personName, @phoneNumber, @email, @registerDate, @updateDate)";
                command.Parameters.AddWithValue("@companyName", entity.CompanyName);
                command.Parameters.AddWithValue("@streetName", entity.StreetName);
                command.Parameters.AddWithValue("@buildingApt", entity.BuildingApt);
                command.Parameters.AddWithValue("@personName", entity.PersonName);
                command.Parameters.AddWithValue("@phoneNumber", entity.PhoneNumber);
                command.Parameters.AddWithValue("@email", entity.Email);
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
                command.CommandText = "DELETE FROM Company WHERE Company_Id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<CompanyModel> GetAll()
        {
            var companyList = new List<CompanyModel>();
            using (var connection = new SQLiteConnection(sqliteConnectionString))
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
            var companyList = new List<CompanyModel>();
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = 
                    "SELECT * FROM Company " +
                    "WHERE CAST(Company_Id AS TEXT) = @searchValue " +
                    "OR LOWER(Person_Name) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "OR LOWER(Company_Name) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "OR LOWER(Street_Name) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "OR LOWER(Phone) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "OR LOWER(Email) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "ORDER BY Company_Id DESC";
                command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
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
        public void Update(CompanyModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
