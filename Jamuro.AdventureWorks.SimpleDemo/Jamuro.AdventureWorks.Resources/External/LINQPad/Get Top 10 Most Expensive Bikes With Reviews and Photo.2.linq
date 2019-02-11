var qTop10 = from P in Product 
where P.ProductSubcategory.ProductCategoryID == 1 /* Bikes */
select new {
	P.ProductID, 
	P.Name, 
	P.ProductNumber, 
	P.ListPrice, 
	P.Color,
	ProductSubcategoryName = P.ProductSubcategory.Name,
	ProductCategoryName = P.ProductSubcategory.ProductCategory.Name,
	ProductReview = from PR in P.ProductReview select new {PR.ProductReviewID, PR.ReviewerName, ReviewDate = (DateTime?)PR.ReviewDate, PR.EmailAddress, Rating = (int?)PR.Rating, PR.Comments},
	ProductPhoto = new { ProductPhotoID = P.ProductProductPhoto.FirstOrDefault().ProductPhoto.ProductPhotoID, LargePhoto = P.ProductProductPhoto.FirstOrDefault().ProductPhoto.LargePhoto},	
};

qTop10.OrderByDescending(x=>x.ListPrice).Take(10).Dump();