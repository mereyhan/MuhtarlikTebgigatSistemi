using MuhtarlikTebgigatSistemi.Model;
using System;
using System.Data.SQLite;

namespace MuhtarlikTebgigatSistemi._Repository
{
    public class PersonRepository: BaseRepository, IRepository<PersonModel>
    {
        public PersonRepository(string connectionString)
        {
            this.sqliteConnectionString = connectionString;
        }

        public void Add(PersonModel entity)
        {
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Person (Person_Name, Street_Name, Building_Apt, Company_Name, Phone, Email, Register_Date, Update_Date)
                                        VALUES (@personName, @streetName, @apt, @companyName, @phoneNumber, @email, @registerDate, @updateDate)";
                command.Parameters.AddWithValue("@personName", entity.PersonName);
                command.Parameters.AddWithValue("@streetName", entity.StreetName);
                command.Parameters.AddWithValue("@apt", entity.BuildingApt);
                command.Parameters.AddWithValue("@companyName", entity.CompanyName);
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
                command.CommandText = "DELETE FROM Person WHERE Person_Id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        public void Update(PersonModel entity)
        {
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Person 
                                        SET Person_Name = @personName, 
                                            Street_Name = @streetName, 
                                            Building_Apt = @apt, 
                                            Company_Name = @companyName, 
                                            Phone = @phoneNumber, 
                                            Email = @email, 
                                            Update_Date = @updateDate
                                        WHERE Person_Id = @id";
                command.Parameters.AddWithValue("@id", entity.Id);
                command.Parameters.AddWithValue("@personName", entity.PersonName);
                command.Parameters.AddWithValue("@streetName", entity.StreetName);
                command.Parameters.AddWithValue("@apt", entity.BuildingApt);
                command.Parameters.AddWithValue("@companyName", entity.CompanyName);
                command.Parameters.AddWithValue("@phoneNumber", entity.PhoneNumber);
                command.Parameters.AddWithValue("@email", entity.Email);
                command.Parameters.AddWithValue("@updateDate", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<PersonModel> GetAll()
        {
            var personList = new List<PersonModel>();
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Person ORDER BY Person_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var personModel = new PersonModel
                        {
                            Id = reader.GetInt32(0),
                            PersonName = reader.GetString(1),
                            StreetName = reader.GetString(2),
                            BuildingApt = reader.GetString(3),
                            CompanyName = reader.GetString(4),
                            PhoneNumber = reader.GetString(5),
                            Email = reader.GetString(6),
                            RegisterDate = reader.GetDateTime(7),
                            UpdateDate = reader.GetDateTime(8)
                        };
                        personList.Add(personModel);
                    }
                }
            }

            return personList;
        }
        public IEnumerable<PersonModel> GetByValue(string searchValue)
        {
            var personList = new List<PersonModel>();
            using (var connection = new SQLiteConnection(sqliteConnectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = 
                    "SELECT * FROM Person " +
                    "WHERE CAST(Person_Id AS TEXT) = @searchValue " +
                    "OR LOWER(Person_Name) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "OR LOWER(Company_Name) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "OR LOWER(Street_Name) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "OR LOWER(Phone) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "OR LOWER(Email) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "ORDER BY Person_Id DESC;";
                command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var personModel = new PersonModel
                        {
                            Id = reader.GetInt32(0),
                            PersonName = reader.GetString(1),
                            StreetName = reader.GetString(2),
                            BuildingApt = reader.GetString(3),
                            CompanyName = reader.GetString(4),
                            PhoneNumber = reader.GetString(5),
                            Email = reader.GetString(6),
                            RegisterDate = reader.GetDateTime(7),
                            UpdateDate = reader.GetDateTime(8)
                        };
                        personList.Add(personModel);
                    }
                }
            }
            return personList;
        }
    }
}
