using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamuro.AdventureWorks.Data.DAL
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }

        public IEnumerable<string> ErrorMessages { get; set; }
        
        public string NotificationType { get; set; }

        public ValidationResult()
        {
            this.IsValid = true;
        }
    }

    public class ValidationResult<T> : ValidationResult
        where T : class
    {
        public T Data { get; set; }

        public ValidationResult() : base()
        {
        }
    }
}
