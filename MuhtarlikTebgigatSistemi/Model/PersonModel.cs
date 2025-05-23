﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MuhtarlikTebgigatSistemi.Model
{
    public class PersonModel
    {
        private int id;
        private string personName;
        private string streetName;
        private string buildingApt;
        private string companyName;
        private string phoneNumber;
        private string email;
        private DateTime registerDate;
        private DateTime updateDate;

        [DisplayName("Kişi Numarası")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Ad Soyad")]
        [StringLength(100, ErrorMessage = "Evrak sahibinin ismi 100 karakteri geçemez.")]
        public string PersonName { get => personName; set => personName = value; }

        [DisplayName("Sokak İsmi")]
        [StringLength(100, ErrorMessage = "Sokak ismi 100 karakteri geçemez.")]
        public string StreetName { get => streetName; set => streetName = value; }

        [DisplayName("Bina No")]
        [StringLength(100, ErrorMessage = "Adres bilgisi 100 karakteri geçemez.")]
        public string BuildingApt { get => buildingApt; set => buildingApt = value; }

        [DisplayName("Firma")]
        [StringLength(100, ErrorMessage = "Firma adı 100 karakteri geçemez.")]
        public string CompanyName { get => companyName; set => companyName = value; }

        [DisplayName("GSM")]
        [StringLength(100, ErrorMessage = "Firma adı 100 karakteri geçemez.")]
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        [DisplayName("Email")]
        [StringLength(100, ErrorMessage = "Firma adı 100 karakteri geçemez.")]
        public string Email { get => email; set => email = value; }

        [DisplayName("Kayıt Tarihi")]
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get => registerDate; set => registerDate = value; }

        [DisplayName("Güncelleme Tarihi")]
        [DataType(DataType.Date)]
        public DateTime UpdateDate { get => updateDate; set => updateDate = value; }
    }
}
