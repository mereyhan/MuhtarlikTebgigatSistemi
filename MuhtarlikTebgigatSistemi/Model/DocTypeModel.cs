using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MuhtarlikTebgigatSistemi.Model
{
    public class DocTypeModel
    {
        private int id;
        private string type;
        private DateTime registerDate;
        private DateTime updateDate;

        [DisplayName("Tür Numarası")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Evrak Türü")]
        [Required(ErrorMessage = "Evrak türü zorunludur.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Evrak türü 3 ile 50 karakter uzunluğunda olmalıdır.")]
        public string Type { get => type; set => type = value; }

        [DisplayName("Oluşturma Tarihi")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get => registerDate; set => registerDate = value; }

        [DisplayName("Kayıt Tarihi")]
        [DataType(DataType.Date)]
        public DateTime UpdateDate { get => updateDate; set => updateDate = value; }
    }
}
