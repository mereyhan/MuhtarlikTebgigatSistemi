using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MuhtarlikTebgigatSistemi.Model
{
    public class DocumentModel
    {
        // Fields
        private int id;
        private string type;
        private string personName;
        private string companyName;
        private string streetName;
        private string buildingApt;
        private DateTime registrationDate;
        private DateTime deliveryDate;
        private string deliveredBy;

        // Properties - Validations
        [DisplayName("Evrak Numarası")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Evrak Türü")]
        [Required(ErrorMessage = "Evrak türü zorunludur.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Evrak türü 3 ile 50 karakter uzunluğunda olmalıdır.")]
        public string Type { get => type; set => type = value; }

        [DisplayName("Evrak Sahibi (Kişi)")]
        [StringLength(100, ErrorMessage = "Evrak sahibinin ismi 100 karakteri geçemez.")]
        public string PersonName { get => personName; set => personName = value; }

        [DisplayName("Evrak Sahibi (Firma)")]
        [StringLength(100, ErrorMessage = "Firma adı 100 karakteri geçemez.")]
        public string CompanyName { get => companyName; set => companyName = value; }

        [DisplayName("Sokak İsmi")]
        [StringLength(100, ErrorMessage = "Sokak ismi 100 karakteri geçemez.")]
        public string StreetName { get => streetName; set => streetName = value; }

        [DisplayName("Bina No")]
        [StringLength(100, ErrorMessage = "Adres bilgisi 100 karakteri geçemez.")]
        public string BuildingApt { get => buildingApt; set => buildingApt = value; }

        [DisplayName("Evrak Teslim Tarihi")]
        [DataType(DataType.Date)]
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }

        [DisplayName("Teslim Alan Kişi")]
        [StringLength(100, ErrorMessage = "Teslim alan kişi ismi 100 karakteri geçemez.")]
        public string DeliveredBy { get => deliveredBy; set => deliveredBy = value; }

        [DisplayName("Kayıt Tarihi")]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get => registrationDate; set => registrationDate = value; }

    }

}
