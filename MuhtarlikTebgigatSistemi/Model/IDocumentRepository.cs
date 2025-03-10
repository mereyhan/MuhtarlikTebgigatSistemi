using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi.Model
{
    public interface IDocumentRepository
    {
        void Add(DocumentModel documentModel);
        void Update(DocumentModel documentModel);
        void Delete(int id);
        IEnumerable<DocumentModel> GetAll();
        IEnumerable<DocumentModel> GetByValue(string searchValue);
    }
}
