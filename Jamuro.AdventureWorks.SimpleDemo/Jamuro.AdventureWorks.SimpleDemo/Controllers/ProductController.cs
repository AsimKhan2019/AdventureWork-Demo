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
    public class ProductController : BaseController
    {
        public readonly IProductWorker m_productWorker;

        public ProductController(IProductWorker productWorker):base()
        {
            m_productWorker = productWorker;
        }


        public ActionResult GetAllBikes()
        {
            var model = m_productWorker.GetAllBikes();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllBikes", viewModel);
        }

        public ActionResult GetAllBikesWithIncludes()
        {
            var model = m_productWorker.GetAllBikesWithIncludes();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllBikesWithIncludes", viewModel);
        }

        public ActionResult GetAllBikesWithIncludesNoTracking()
        {
            var model = m_productWorker.GetAllBikesWithIncludesNoTracking();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllBikesWithIncludesNoTracking", viewModel);
        }

        public ActionResult GetAllBikesWithCheckAllAny()
        {
            var model = m_productWorker.GetAllBikesWithCheckAllAny();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllBikesWithCheckAllAny", viewModel);
        }

        public ActionResult GetAllBikesWithCheckAllCount()
        {
            var model = m_productWorker.GetAllBikesWithCheckAllCount();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllBikesWithCheckAllCount", viewModel);
        }

        public ActionResult GetAllBikesWithCheckOne()
        {
            var model = m_productWorker.GetAllBikesWithCheckOne();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllBikesWithCheckOne", viewModel);
        }

        public ActionResult GetAllBikesWithCheckExists()
        {
            var model = m_productWorker.GetAllBikesWithCheckExists();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllBikesWithCheckExists", viewModel);
        }

        public ActionResult GetMostExpensiveBikes(int maxNumber=25, bool topInjectedInSQL=true)
        {
            var model = m_productWorker.GetMostExpensiveBikes(maxNumber, topInjectedInSQL);
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            ViewBag.MaxNumber = maxNumber;
            ViewBag.TopInjectedInSQL = topInjectedInSQL;
            return View("MostExpensiveBikes", viewModel);
        }

        public ActionResult GetAllBikesWithAllImprovements()
        {
            var model = m_productWorker.GetAllBikesWithAllImprovements();
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Products = model;
            return View("AllBikesWithAllImprovements", viewModel);
        }
    }
}
