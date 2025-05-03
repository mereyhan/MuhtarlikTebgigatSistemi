using MuhtarlikTebgigatSistemi.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi._Repository
{
    public class DocumentRepository : BaseRepository, IRepository<DocumentModel>
    {

        // Constructor
        public DocumentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(DocumentModel entity)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Document (DocumentType_Name, Person_Name, Company_Name, Street_Name, Building_Apt, Registration_Date, Delivery_Date, Delivered_By)
                                        VALUES (@type, @personName, @companyName, @streetName, @apt, @registrationDate, @deliveryDate, @deliveredBy)";

                command.Parameters.AddWithValue("@type", entity.Type);
                command.Parameters.AddWithValue("@personName", entity.PersonName);
                command.Parameters.AddWithValue("@companyName", entity.CompanyName);
                command.Parameters.AddWithValue("@streetName", entity.StreetName);
                command.Parameters.AddWithValue("@apt", entity.BuildingApt);
                command.Parameters.AddWithValue("@registrationDate", DateTime.Now);
                command.Parameters.AddWithValue("@deliveryDate", DateTime.Now);
                command.Parameters.AddWithValue("@deliveredBy", entity.DeliveredBy);
                command.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Document WHERE Document_Id = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
        public void Update(DocumentModel entity)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Document 
                                        SET DocumentType_Name = @type, 
                                            Person_Name = @personName, 
                                            Company_Name = @companyName, 
                                            Street_Name = @streetName, 
                                            Building_Apt = @apt,
                                            Delivery_Date = @deliveryDate, 
                                            Delivered_By = @deliveredBy
                                        WHERE Document_Id = @id";
                command.Parameters.AddWithValue("@id", entity.Id);
                command.Parameters.AddWithValue("@type", entity.Type);
                command.Parameters.AddWithValue("@personName", entity.PersonName);
                command.Parameters.AddWithValue("@companyName", entity.CompanyName);
                command.Parameters.AddWithValue("@streetName", entity.StreetName);
                command.Parameters.AddWithValue("@apt", entity.BuildingApt);
                command.Parameters.AddWithValue("@deliveryDate", DateTime.Now);
                command.Parameters.AddWithValue("@deliveredBy", entity.DeliveredBy);
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<DocumentModel> GetAll()
        {
            var documentList = new List<DocumentModel>();
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Document ORDER BY Document_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var documentModel = new DocumentModel
                        {
                            Id = reader.GetInt32(0),
                            Type = reader.GetString(1),
                            PersonName = reader.GetString(2),
                            CompanyName = reader.GetString(3),
                            StreetName = reader.GetString(4),
                            BuildingApt = reader.GetString(5),
                            RegistrationDate = reader.GetDateTime(6),
                            DeliveryDate = reader.GetDateTime(7),
                            DeliveredBy = reader.GetString(8)
                        };
                        documentList.Add(documentModel);
                    }
                }
            }

            return documentList;
        }
        public IEnumerable<DocumentModel> GetByValue(string searchValue)
        {
            var documentList = new List<DocumentModel>();
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText =
                    "SELECT * FROM Document " +
                    "WHERE CAST(Document_Id AS TEXT) = @searchValue " +
                    "OR LOWER(DocumentType_Name) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "OR LOWER(Person_Name) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "OR LOWER(Company_Name) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "OR LOWER(Street_Name) LIKE '%' || LOWER(@searchValue) || '%' " +
                    "OR LOWER(Delivered_By) LIKE '%' || LOWER(@searchValue) || '%' " +
                command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var documentModel = new DocumentModel
                        {
                            Id = reader.GetInt32(0),
                            Type = reader.GetString(1),
                            PersonName = reader.GetString(2),
                            CompanyName = reader.GetString(3),
                            StreetName = reader.GetString(4),
                            BuildingApt = reader.GetString(5),
                            RegistrationDate = reader.GetDateTime(6),
                            DeliveryDate = reader.GetDateTime(7),
                            DeliveredBy = reader.GetString(8)
                        };
                        documentList.Add(documentModel);
                    }
                }
            }
            return documentList;
        }
    }
}
