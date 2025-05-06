using MuhtarlikTebgigatSistemi._Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi.Helpers.PreviewProvider
{
    public class PersonPreviewProvider : IForeignKeyPreview
    {
        private readonly PersonRepository _repo;

        public PersonPreviewProvider(string connectionString)
        {
            _repo = new PersonRepository(connectionString);
        }

        //public string GetTooltipText(string id)
        //{
        //    if (!int.TryParse(id, out int personId))
        //    {
        //        return "Geçersiz ID";
        //    }

        //    var person = _repo.GetById(personId);
        //    return person == null ? "Kişi bulunamadı."
        //        : $"Ad: {person.PersonName}\nTelefon: {person.PhoneNumber}\nEmail: {person.Email}";
        //}
    }
}
