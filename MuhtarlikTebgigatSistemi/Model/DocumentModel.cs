using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MuhtarlikTebgigatSistemi.Model
{
    public class DocumentModel
    {
        // Fields
        private int id;
        private string name;
        private string type;
        private string color;

        // Properties - Validations
        [DisplayName("Evrak Numarası")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Evrak İsmi")]
        [Required(ErrorMessage = "Evak ismi zorunludur.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Evrak ismi 3 ile 50 karakter uzunluğunda olmalıdır.")]
        public string Name { get => name; set => name = value; }

        [DisplayName("Evrak Türü")]
        [Required(ErrorMessage = "Evak türü zorunludur.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Evrak türü 3 ile 50 karakter uzunluğunda olmalıdır.")]
        public string Type { get => type; set => type = value; }

        [DisplayName("Evrak Rengi")]
        [Required(ErrorMessage = "Evak rengi zorunludur.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Evrak rengi 3 ile 50 karakter uzunluğunda olmalıdır.")]
        public string Color { get => color; set => color = value; }
    }
}
