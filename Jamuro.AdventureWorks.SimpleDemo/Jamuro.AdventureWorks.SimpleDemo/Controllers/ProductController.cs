using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jamuro.AdventureWorks.SimpleDemo.ViewModels;
using Jamuro.AdventureWorks.Services.Workers;
using Jamuro.AdventureWorks.Services.Workers.Interfaces;

namespace Jamuro.AdventureWorks.SimpleDemo.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult GetAllBikes()
        {
            IProductWorker productWorker = new ProductWorker();
            var model = productWorker.GetAllBikes();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllBikes", viewModel);
        }

        public ActionResult GetAllBikesWithIncludes()
        {
            IProductWorker productWorker = new ProductWorker();
            var model = productWorker.GetAllBikesWithIncludes();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllBikesWithIncludes", viewModel);
        }

        public ActionResult GetAllBikesWithIncludesNoTracking()
        {
            IProductWorker productWorker = new ProductWorker();
            var model = productWorker.GetAllBikesWithIncludesNoTracking();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllBikesWithIncludesNoTracking", viewModel);
        }

        public ActionResult GetAllBikesWithCheckAllAny()
        {
            IProductWorker productWorker = new ProductWorker();
            var model = productWorker.GetAllBikesWithCheckAllAny();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllBikesWithCheckAllAny", viewModel);
        }

        public ActionResult GetAllBikesWithCheckAllCount()
        {
            IProductWorker productWorker = new ProductWorker();
            var model = productWorker.GetAllBikesWithCheckAllCount();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllBikesWithCheckAllCount", viewModel);
        }

        public ActionResult GetAllBikesWithCheckOne()
        {
            IProductWorker productWorker = new ProductWorker();
            var model = productWorker.GetAllBikesWithCheckOne();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllBikesWithCheckOne", viewModel);
        }

        public ActionResult GetAllBikesWithCheckExists()
        {
            IProductWorker productWorker = new ProductWorker();
            var model = productWorker.GetAllBikesWithCheckExists();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllBikesWithCheckExists", viewModel);
        }

        
    }
}
