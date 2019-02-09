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
        IEnumerable<Models.Product> GetAllBikes();

        IEnumerable<Models.Product> GetAllBikesWithIncludes();

        IEnumerable<Models.Product> GetAllBikesWithIncludesNoTracking();

        IEnumerable<Models.Product> GetAllBikesWithAllImprovements();

        IEnumerable<Models.Product> GetAllBikesWithCheckExists();

        IEnumerable<Models.Product> GetAllBikesWithCheckOne();

        IEnumerable<Models.Product> GetAllBikesWithCheckAllCount();

        IEnumerable<Models.Product> GetAllBikesWithCheckAllAny();

        IEnumerable<Models.Product> GetMostExpensiveBikes(int maxNumber, bool topInjectedInSQL);

    }
}
