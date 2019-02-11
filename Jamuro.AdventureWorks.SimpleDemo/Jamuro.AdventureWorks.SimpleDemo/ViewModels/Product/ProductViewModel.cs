using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jamuro.AdventureWorks.Resources;

namespace Jamuro.AdventureWorks.SimpleDemo.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public IEnumerable<Models.Product> Products;

        public override string Title()
        {
            return Labels.Bikes;
        }
    }
}