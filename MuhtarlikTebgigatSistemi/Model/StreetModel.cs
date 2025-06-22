using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MuhtarlikTebgigatSistemi.Model
{
    public class StreetModel
    {
        public int StreetId { get; set; }
        public string Street { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
