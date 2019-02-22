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
        private readonly int m_productCategoryBikes = 1;

        private IRepository<Product> ProductRepository { get { return this.UnitOfWork.GetRepository<Product>(); } }

        private static IEnumerable<Models.Product> GenerateProductModel(IEnumerable<Product> products)
        {
            List<Models.Product> productsModel = new List<Models.Product>();

            foreach (Product p in products)
            {
                Models.Product productModel = new Models.Product();

                #region  Get Basic Information

                productModel.ProductID = p.ProductID;
                productModel.Name = p.Name;
                productModel.ProductNumber = p.ProductNumber;
                productModel.Color = p.Color;
                productModel.ListPrice = p.ListPrice;

                #endregion

                #region Get Photos

                /* If executed without "includes" it generates a new connection per product item querying "ProductProductPhoto" table. */
                /* If executed without "includes" it generates a new connection per product item querying "ProductPhoto" table, if each item has a different photo!
                   Otherwise, use EF cache capabilities to retrieve previously returned photos avoiding hitting database. */
                /* Overload: 1 * N + X (N => number of products, X => number of distinct photos over all products ) */

                foreach (ProductProductPhoto x in p.ProductProductPhoto)
                {
                    Models.ProductPhoto productPhoto = new Models.ProductPhoto();
                    productPhoto.ProductPhotoID = x.ProductPhoto.ProductPhotoID;
                    productPhoto.LargePhoto = x.ProductPhoto.LargePhoto;
                    productModel.ProductPhoto.Add(productPhoto);
                }

                #endregion 

                #region Get Reviews

                /* If executed without "includes" it generates a new connection per product item querying "ProductReview" table. */
                /* Overload: N (N => number of products) */

                foreach (ProductReview x in p.ProductReview)
                {
                    Models.ProductReview productReview = new Models.ProductReview();
                    productReview.ProductReviewID = x.ProductReviewID;
                    productReview.Comments = x.Comments;
                    productReview.Rating = x.Rating;
                    productModel.ProductReview.Add(productReview);
                }


                #endregion

                #region Get Category

                /* Without "includes" it generates a new connection for ProductCategory: Category => Bikes (1) */
                /* Without "includes" it generates three new connections for ProductSubCategory: SubcategoryId => Mountain Bikes (1), Road Bikes (2) and Touring Bikes (3) */
                /* After getting all the required categories and subcategories, EF uses cache capabilities to avoid hitting DB again if previous entities were retrieved */
                /* Overload: 4 */

                Models.ProductCategory category = new Models.ProductCategory();
                if (p.ProductSubcategory != null)
                {
                    category.ProductCategoryId = p.ProductSubcategory.ProductCategoryID;
                    category.CategoryName = p.ProductSubcategory.ProductCategory.Name;
                    category.ProductSubcategoryId = p.ProductSubcategory.ProductSubcategoryID;
                    category.SubcategoryName = p.ProductSubcategory.Name;
                }
                productModel.ProductCategory = category;
                

                #endregion

                productsModel.Add(productModel);
            }

            return productsModel;
        }

        public ProductWorker() : base()
        {
            
        }

        public IEnumerable<Models.Product> GetAllBikes()
        {
            bool checkForExistence = ProductRepository.Exists(x => x.ProductSubcategory != null && x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes);
            return GenerateProductModel(checkForExistence ? ProductRepository.Get(x => x.ProductSubcategory != null && x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes) : m_emptyProductList);
        }

        #region Bad ways of checking the existence of rows before retrieving them

        public IEnumerable<Models.Product> GetAllBikesWithCheckAllCount()
        {
            /* Issues */
            /* ProductRepository.GetAll() select all the products, not only bikes */
            /* This case, lambda expression is generating as many queries as distinct present subcategories */
            /* This way of detecting existence of records is very bad */
            bool checkForExistence = ProductRepository.GetAll().Count(x => x.ProductSubcategory != null && x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes) > 0;

            return GenerateProductModel(checkForExistence ? 
                ProductRepository.Get(x => x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes,
                    false,
                    null,
                    x => x.ProductReview,
                    x => x.ProductSubcategory.ProductCategory,
                    x => x.ProductProductPhoto.Select(y => y.ProductPhoto)) :
                m_emptyProductList);
        }

        public IEnumerable<Models.Product> GetAllBikesWithCheckAllAny()
        {
            /* Issues */
            /* ProductRepository.GetAll() select all the products, not only bikes */
            /* This case, lambda expression is generating as many queries as distinct present subcategories until getting a subcategory that matches "Bikes" category */
            /* This way of detecting existence of records is bad despite the fact of using "Any", but at least it generates fewer connections  */
            bool checkForExistence = ProductRepository.GetAll().Any(x => x.ProductSubcategory != null && x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes);

            return GenerateProductModel(checkForExistence ? 
                ProductRepository.Get(x => x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes,
                    false,
                    null,
                    x => x.ProductReview,
                    x => x.ProductSubcategory.ProductCategory,
                    x => x.ProductProductPhoto.Select(y => y.ProductPhoto)) :
                m_emptyProductList);
        }

        #endregion

        public IEnumerable<Models.Product> GetAllBikesWithCheckOne()
        {
            /* Only one query to check existence */
            /* It is good enough, but there is still scope to improve */
            bool checkForExistence = ProductRepository.GetOne(x => x.ProductSubcategory != null && x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes) != null;

            return GenerateProductModel(checkForExistence ? 
                ProductRepository.Get(x => x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes,
                    false,
                    null,
                    x => x.ProductReview,
                    x => x.ProductSubcategory.ProductCategory,
                    x => x.ProductProductPhoto.Select(y => y.ProductPhoto)) :
                m_emptyProductList);
        }       

        public IEnumerable<Models.Product> GetAllBikesWithCheckExists()
        {
            /* Only one query to check existence */
            /* Best choice so far */
            bool checkForExistence = ProductRepository.Exists(x => x.ProductSubcategory != null && x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes);

            return GenerateProductModel(checkForExistence ?
                ProductRepository.Get(x => x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes,
                    false,
                    null,
                    x => x.ProductReview,
                    x => x.ProductSubcategory.ProductCategory,
                    x => x.ProductProductPhoto.Select(y => y.ProductPhoto)) :
                m_emptyProductList);
        }

        public IEnumerable<Models.Product> GetAllBikesWithIncludes()
        {
            /* Due to "includes", an eager loading is triggered with only one SQL connection/query */
            /* All the SQL fields are returned though */
            return GenerateProductModel(ProductRepository.Exists(x => x.ProductSubcategory != null && x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes) ? 
                ProductRepository.Get(x => x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes,
                    false,
                    null,
                    x => x.ProductReview,
                    x => x.ProductSubcategory.ProductCategory,
                    x => x.ProductProductPhoto.Select(y => y.ProductPhoto)) : 
                m_emptyProductList);
        }

        public IEnumerable<Models.Product> GetAllBikesWithIncludesNoTracking()
        {
            /* Due to "includes", an eager loading is triggered with only one SQL connection/query */
            /* All the SQL fields are returned though */
            return GenerateProductModel(ProductRepository.Exists(x => x.ProductSubcategory != null && x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes) ? 
                ProductRepository.Get(x => x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes,
                    true,
                    null,
                    x =>x.ProductReview, 
                    x=>x.ProductSubcategory.ProductCategory, 
                    x=>x.ProductProductPhoto.Select(y=>y.ProductPhoto)) : 
                m_emptyProductList);
        }

        public IEnumerable<Models.Product> GetAllBikesWithAllImprovements()
        {
            /* Due to "includes", an eager loading is triggered with only one SQL connection/query */
            /* Due to injection of new "select fields" expression, only required SQL fields are retruned from DB */
            var model = ProductRepository.GetWithOutputModel<Models.Product>(x => x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes,
                    true,
                    null,
                    x => new Models.Product() { ProductID = x.ProductID, ListPrice = x.ListPrice, Name = x.Name, ProductNumber = x.ProductNumber, Color = x.Color,
                        ProductCategory = new Models.ProductCategory { CategoryName = x.ProductSubcategory.ProductCategory.Name, SubcategoryName = x.ProductSubcategory.Name, ProductCategoryId = x.ProductSubcategory.ProductCategoryID, ProductSubcategoryId = x.ProductSubcategoryID},
                        ProductPhoto = (from y in x.ProductProductPhoto select new Models.ProductPhoto() { ProductPhotoID = y.ProductPhotoID, LargePhoto = y.ProductPhoto.LargePhoto}).ToList(),
                        ProductReview = (from y in x.ProductReview select new Models.ProductReview() { Comments=y.Comments, Rating=y.Rating, EmailAddress=y.EmailAddress, ReviewerName=y.ReviewerName, ReviewDate=y.ReviewDate, ProductID = y.ProductID, ProductReviewID = y.ProductReviewID}).ToList()
                    },
                    x => x.ProductReview,
                    x => x.ProductSubcategory.ProductCategory,
                    x => x.ProductProductPhoto.Select(y => y.ProductPhoto));
            return model;
        }

        public IEnumerable<Models.Product> GetMostExpensiveBikes(int maxNumber, bool topInjectedInSQL)
        {
            if (topInjectedInSQL)
            {
                #region Top Sentence injected in SQL

                return GenerateProductModel(ProductRepository.Exists(x => x.ProductSubcategory != null && x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes) ?
                   ProductRepository.Get(x => x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes,
                       true,
                       maxNumber,
                       s => s.ListPrice,
                       true,
                       x => x.ProductReview,
                       x => x.ProductSubcategory.ProductCategory,
                       x => x.ProductProductPhoto.Select(y => y.ProductPhoto)) :
                   m_emptyProductList);

                #endregion
            }
            else
            {
                return GenerateProductModel(ProductRepository.Exists(x => x.ProductSubcategory != null && x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes) ?
                    ProductRepository.Get(x => x.ProductSubcategory.ProductCategoryID == m_productCategoryBikes,
                                        true,
                                        null,
                                        x => x.ProductReview,
                                        x => x.ProductSubcategory.ProductCategory,
                                        x => x.ProductProductPhoto.Select(y => y.ProductPhoto))
                                     .OrderByDescending(x => x.ListPrice)
                                     .Take(maxNumber) :
                    m_emptyProductList);
            }
        }
    }
}
