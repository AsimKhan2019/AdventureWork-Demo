using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Jamuro.AdventureWorks.Models;
using Jamuro.AdventureWorks.Data.Entities;

namespace Jamuro.AdventureWorks.Services.Workers.Interfaces
{
    public interface IProductWorker
    {
        IEnumerable<Models.Product> GetAllProducts();

        IEnumerable<Models.Product> GetAllProductsWithIncludes();

        IEnumerable<Models.Product> GetAllProductsWithIncludesNoTracking();
    }
}
