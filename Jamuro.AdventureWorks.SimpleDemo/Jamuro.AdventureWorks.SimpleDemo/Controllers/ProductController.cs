using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jamuro.AdventureWorks.SimpleDemo.ViewModels;
using Jamuro.AdventureWorks.Services.Workers;

namespace Jamuro.AdventureWorks.SimpleDemo.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult GetAllProducts()
        {
            ProductWorker productWorker = new ProductWorker();
            var model = productWorker.GetAllProducts();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllProducts", viewModel);
        }

        public ActionResult GetAllProductsWithIncludes()
        {
            ProductWorker productWorker = new ProductWorker();
            var model = productWorker.GetAllProductsWithIncludes();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllProductsWithIncludes", viewModel);
        }

        public ActionResult GetAllProductsWithIncludesNoTracking()
        {
            ProductWorker productWorker = new ProductWorker();
            var model = productWorker.GetAllProductsWithIncludesNoTracking();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllProductsWithIncludesNoTracking", viewModel);
        }
    }
}
