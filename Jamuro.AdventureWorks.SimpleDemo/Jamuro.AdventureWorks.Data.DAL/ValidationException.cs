using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamuro.AdventureWorks.Data.DAL
{
    public class ValidationException : Exception
    {
        public ValidationResult ValidationResult { get; set; }

        public ValidationException(ValidationResult validation) : base(string.Join(", ", validation.ErrorMessages))
        {
            this.ValidationResult = validation;
        }
    }
}
