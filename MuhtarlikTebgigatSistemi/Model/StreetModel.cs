using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi.Model
{
    public class StreetModel
    {
        private int id;
        private string street;
        private DateTime createDate;
        private DateTime updateDate;

        [DisplayName("Tür Numarası")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Evrak Türü")]
        [Required(ErrorMessage = "Evak türü zorunludur.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Evrak türü 3 ile 50 karakter uzunluğunda olmalıdır.")]
        public string Street { get => street; set => street = value; }

        [DisplayName("Oluşturma Tarihi")]
        [DataType(DataType.Date)]
        public DateTime CreateDate { get => createDate; set => createDate = value; }

        [DisplayName("Kayıt Tarihi")]
        [DataType(DataType.Date)]
        public DateTime UpdateDate { get => updateDate; set => updateDate = value; }
    }
}
