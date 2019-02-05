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

                /* Get Photos */
                foreach (ProductProductPhoto x in p.ProductProductPhoto)
                {
                    Models.ProductPhoto productPhoto = new Models.ProductPhoto();
                    productPhoto.ProductPhotoID = x.ProductPhoto.ProductPhotoID;
                    productPhoto.ThumbNailPhoto = x.ProductPhoto.ThumbNailPhoto;
                }

                /* Get Reviews */
                foreach (ProductReview x in p.ProductReview)
                {
                    Models.ProductReview productReview = new Models.ProductReview();
                    productReview.ProductReviewID = x.ProductReviewID;
                    productReview.Comments = x.Comments;
                    productReview.Rating = x.Rating;
                }

                productsModel.Add(productModel);
            }

            return productsModel;
        }

        public ProductWorker() : base()
        {
          
        }

        public IEnumerable<Models.Product> GetAllProducts()
        {
            return GenerateProductModel(ProductRepository.GetAll());
        }

        public IEnumerable<Models.Product> GetAllProductsWithIncludes()
        {
            return GenerateProductModel(ProductRepository.GetAll(false,
                x => x.ProductReview,
                x => x.ProductSubcategory.ProductCategory,
                x => x.ProductProductPhoto.Select(y => y.ProductPhoto)));
        }

        public IEnumerable<Models.Product> GetAllProductsWithIncludesNoTracking()
        {
            return GenerateProductModel(ProductRepository.GetAll(true, 
                x=>x.ProductReview, 
                x=>x.ProductSubcategory.ProductCategory, 
                x=>x.ProductProductPhoto.Select(y=>y.ProductPhoto)));
        }

    }
}
