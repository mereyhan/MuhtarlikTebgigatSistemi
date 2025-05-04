using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MuhtarlikTebgigatSistemi.Model
{
    public class StreetModel
    {
        private int id;
        private string street;
        private DateTime registerDate;
        private DateTime updateDate;

        [DisplayName("Sokak No")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Sokak")]
        [Required(ErrorMessage = "Sokak İsmi zorunludur.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Evrak türü 3 ile 50 karakter uzunluğunda olmalıdır.")]
        public string Street { get => street; set => street = value; }

        [DisplayName("Kayıt Tarihi")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get => registerDate; set => registerDate = value; }

        [DisplayName("Güncelleme Tarihi")]
        [DataType(DataType.Date)]
        public DateTime UpdateDate { get => updateDate; set => updateDate = value; }
    }
}
