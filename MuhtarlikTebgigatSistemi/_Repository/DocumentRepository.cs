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
            using (var connection = new SQLiteConnection(connectionString))
            using (var command = new SQLiteCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Document (Document_Name, Document_Type, Document_Color) VALUES (@name, @type, @color)";
                command.Parameters.AddWithValue("@name", documentModel.Name);
                command.Parameters.AddWithValue("@type", documentModel.Type);
                command.Parameters.AddWithValue("@color", documentModel.Color);
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
                                        SET Document_Name = @name, Document_Type = @type, Document_Color = @color 
                                        WHERE Document_Id = @id";
                command.Parameters.AddWithValue("@name", documentModel.Name);
                command.Parameters.AddWithValue("@type", documentModel.Type);
                command.Parameters.AddWithValue("@color", documentModel.Color);
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
