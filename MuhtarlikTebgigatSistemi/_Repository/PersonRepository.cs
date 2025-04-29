using MuhtarlikTebgigatSistemi.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi._Repository
{
    public class PersonRepository: BaseRepository, IRepository<PersonModel>
    {
        public PersonRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(PersonModel entity)
        {
        }
        public void Delete(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Person WHERE Person_Id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<PersonModel> GetAll()
        {
            var personList = new List<PersonModel>();
            using (var connection = new SQLiteConnection(connectionString))
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
            throw new NotImplementedException();
        }
        public void Update(PersonModel entity)
        {

        }
    }
}
