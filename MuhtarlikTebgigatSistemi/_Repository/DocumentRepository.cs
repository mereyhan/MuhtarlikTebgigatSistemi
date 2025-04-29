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
        public void Add(DocumentModel documentModel)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Document (DocumentType_Name, Person_Name, Company_Name, Street_Name, Building_Apt, Registration_Date, Delivery_Date, Delivered_By)
                                        VALUES (@type, @personName, @companyName, @streetName, @apt, @registrationDate, @deliveryDate, @deliveredBy)";

                command.Parameters.AddWithValue("@type", documentModel.Type);
                command.Parameters.AddWithValue("@personName", documentModel.PersonName);
                command.Parameters.AddWithValue("@companyName", documentModel.CompanyName);
                command.Parameters.AddWithValue("@streetName", documentModel.StreetName);
                command.Parameters.AddWithValue("@apt", documentModel.BuildingApt);
                command.Parameters.AddWithValue("@registrationDate", documentModel.RegistrationDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@deliveryDate", documentModel.DeliveryDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@deliveredBy", documentModel.DeliveredBy);
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
        public void Update(DocumentModel documentModel)
        {
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Document 
                                        SET DocumentType_Name = @type, Document_Type = @type, 
                                        WHERE Document_Id = @id";
                command.Parameters.AddWithValue("@type", documentModel.Type);
                command.Parameters.AddWithValue("@id", documentModel.Id);
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
                            Type = reader.GetString(1)
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
            int documentId = int.TryParse(searchValue, out _) ? int.Parse(searchValue) : 0;
            string documentName = searchValue;

            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Document 
                                        WHERE Document_Id = @id OR Document_Name LIKE @name || '%'
                                        ORDER BY Document_Id DESC";
                command.Parameters.AddWithValue("@id", documentId);
                command.Parameters.AddWithValue("@name", documentName);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var documentModel = new DocumentModel
                        {
                            Id = reader.GetInt32(0),
                            Type = reader.GetString(1)
                        };
                        documentList.Add(documentModel);
                    }
                }
            }

            return documentList;
        }
    }
}
