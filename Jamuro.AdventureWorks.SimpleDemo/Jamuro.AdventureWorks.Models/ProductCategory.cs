using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamuro.AdventureWorks.Models
{
    public class ProductCategory
    {
        public ProductCategory()
        {

        }

        public int ProductCategoryId { get; set; }

        public int? ProductSubcategoryId { get; set; }

        public string CategoryName { get; set; }

        public string SubcategoryName { get; set; }
    }
}
