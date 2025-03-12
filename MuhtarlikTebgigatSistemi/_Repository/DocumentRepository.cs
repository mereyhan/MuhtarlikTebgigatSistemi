using MuhtarlikTebgigatSistemi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace MuhtarlikTebgigatSistemi._Repository
{
    public class DocumentRepository : BaseRepository, IDocumentRepository
    {

        // Constructor
        public DocumentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void Add(DocumentModel documentModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Insert into Pet values (@name, @type, @color)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = documentModel.Name;
                command.Parameters.Add("@type", SqlDbType.NVarChar).Value = documentModel.Type;
                command.Parameters.Add("@color", SqlDbType.NVarChar).Value = documentModel.Color;
                command.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Insert into Pet where Pet_Id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }
        public void Update(DocumentModel documentModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Pet 
                                        set Pet_Name=@name,Pet_Type= @type,Pet_Colour= @colour 
                                        where Pet_Id=@id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = documentModel.Name;
                command.Parameters.Add("@type", SqlDbType.NVarChar).Value = documentModel.Type;
                command.Parameters.Add("@color", SqlDbType.NVarChar).Value = documentModel.Color;
                command.Parameters.Add("@id", SqlDbType.Int).Value = documentModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<DocumentModel> GetAll()
        {
            var documentList = new List<DocumentModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Document order by Document_Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var documentModel = new DocumentModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Type = reader.GetString(2),
                            Color = reader.GetString(3)
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

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from Document 
                                        where Document_Id=@id or Document_Name like @name+'%'
                                        order by Document_Id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = documentId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = documentName;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var documentModel = new DocumentModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Type = reader.GetString(2),
                            Color = reader.GetString(3)
                        };
                        documentList.Add(documentModel);
                    }
                }
            }

            return documentList;
        }
    }
}
