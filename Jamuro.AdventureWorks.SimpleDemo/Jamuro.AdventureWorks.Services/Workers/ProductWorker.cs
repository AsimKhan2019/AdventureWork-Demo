using System;
using System.Collections.Generic;
using System.Linq;
using Jamuro.AdventureWorks.Data.DAL;
using Jamuro.AdventureWorks.Data.DAL.Interfaces;
using Jamuro.AdventureWorks.Data.Entities;
using Jamuro.AdventureWorks.Services.Factories;
using Jamuro.AdventureWorks.Data.Entities.Contexts;
using Jamuro.AdventureWorks.Services.Workers.Interfaces;

namespace Jamuro.AdventureWorks.Services.Workers
{
    public class ProductWorker : WorkerBase, IProductWorker
    {
        private readonly IEnumerable<Product> m_emptyProductList = new List<Product>() { };

        private IRepository<Product> ProductRepository { get { return this.UnitOfWork.GetRepository<Product>(); } }

        private static IEnumerable<Models.Product> GenerateProductModel(IEnumerable<Product> products)
        {
            List<Models.Product> productsModel = new List<Models.Product>();

            foreach (Product p in products)
            {
                Models.Product productModel = new Models.Product();

                /* Get General Information*/
                productModel.ProductID = p.ProductID;
                productModel.Name = p.Name;
                productModel.ProductNumber = p.ProductNumber;
                productModel.ProductLine = p.ProductLine;
                productModel.Style = p.Style;

                /* Get Category */
                Models.ProductCategory category = new Models.ProductCategory();
                if (p.ProductSubcategory != null)
                {
                    category.ProductCategoryId =  p.ProductSubcategory.ProductCategoryID;
                    category.CategoryName = p.ProductSubcategory.ProductCategory.Name;
                    category.ProductSubcategoryId = p.ProductSubcategory.ProductSubcategoryID;
                    category.SubcategoryName = p.ProductSubcategory.Name;
                }
                productModel.ProductCategory = category;

                /* Get Photos */
                foreach (ProductProductPhoto x in p.ProductProductPhoto)
                {
                    Models.ProductPhoto productPhoto = new Models.ProductPhoto();
                    productPhoto.ProductPhotoID = x.ProductPhoto.ProductPhotoID;
                    productPhoto.ThumbNailPhoto = x.ProductPhoto.ThumbNailPhoto;
                    productPhoto.LargePhoto = x.ProductPhoto.LargePhoto;
                    productModel.ProductPhoto.Add(productPhoto);
                }
                
                /* Get Reviews */
                foreach (ProductReview x in p.ProductReview)
                {
                    Models.ProductReview productReview = new Models.ProductReview();
                    productReview.ProductReviewID = x.ProductReviewID;
                    productReview.Comments = x.Comments;
                    productReview.Rating = x.Rating;
                    productModel.ProductReview.Add(productReview);
                }

                productsModel.Add(productModel);
            }

            return productsModel;
        }

        public ProductWorker() : base()
        {
          
        }

        #region Bad ways of checking the existence of rows before retrieving them

        public IEnumerable<Models.Product> GetAllProductsWithCheckAllCount()
        {
            return GenerateProductModel(ProductRepository.GetAll().Count() > 0 ? ProductRepository.GetAll() : m_emptyProductList);
        }

        public IEnumerable<Models.Product> GetAllProductsWithCheckAllAny()
        {
            return GenerateProductModel(ProductRepository.GetAll().Any() ? ProductRepository.GetAll() : m_emptyProductList);
        }

        public IEnumerable<Models.Product> GetAllProductsWithCheckOne()
        {
            return GenerateProductModel(ProductRepository.GetOne(x=>true) != null ? ProductRepository.GetAll() : m_emptyProductList);
        }

        #endregion

        public IEnumerable<Models.Product> GetAllProducts()
        {
            return GenerateProductModel(ProductRepository.Exists() ? ProductRepository.GetAll() : m_emptyProductList);
        }

        public IEnumerable<Models.Product> GetAllProductsWithIncludes()
        {
            return GenerateProductModel(ProductRepository.Exists() ? 
                ProductRepository.GetAll(false,
                    x => x.ProductReview,
                    x => x.ProductSubcategory.ProductCategory,
                    x => x.ProductProductPhoto.Select(y => y.ProductPhoto)) : 
                m_emptyProductList);
        }

        public IEnumerable<Models.Product> GetAllProductsWithIncludesNoTracking()
        {
            return GenerateProductModel(ProductRepository.Exists() ? 
                ProductRepository.GetAll(true, 
                    x=>x.ProductReview, 
                    x=>x.ProductSubcategory.ProductCategory, 
                    x=>x.ProductProductPhoto.Select(y=>y.ProductPhoto)) : 
                m_emptyProductList);
        }

    }
}
