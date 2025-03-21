using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhtarlikTebgigatSistemi.Presenters.Common
{
    public class ModelDataValidation
    {
        public void Validate(object model)
        {
            string errorMessage = "";
            List<ValidationResult> reults = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, context, reults, true);
            if (!isValid)
            {
                foreach (var result in reults)
                    errorMessage += result.ErrorMessage + "\n";

                throw new Exception(errorMessage);
            }
        }
    }
}
