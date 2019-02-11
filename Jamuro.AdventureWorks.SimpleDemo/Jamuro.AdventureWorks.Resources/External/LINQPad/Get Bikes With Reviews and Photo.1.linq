from P in Product    
join PSC in ProductSubcategory on P.ProductSubcategoryID equals PSC.ProductSubcategoryID 
join PC in ProductCategory on PSC.ProductCategoryID equals PC.ProductCategoryID 
join PReview in ProductReview on P.ProductID equals PReview.ProductID into PReviewLJ
from PR in PReviewLJ.DefaultIfEmpty() 
join PProductPhoto in ProductProductPhoto on P.ProductID equals PProductPhoto.ProductID into PProductPhotoLJ
from PPP in PProductPhotoLJ.DefaultIfEmpty() 
join PP in ProductPhoto on PPP.ProductPhotoID equals PP.ProductPhotoID
where PC.ProductCategoryID == 1 /* Bikes */
select new {P.ProductID, P.Name, P.ProductNumber, P.ListPrice, P.Color,
			SubcategoryName = PSC.Name,
			ProductPhotoID = (int?)PP.ProductPhotoID, PP.LargePhoto,
			ProductReviewID = (int?)PR.ProductReviewID, PR.ReviewerName, ReviewDate = (DateTime?)PR.ReviewDate, PR.EmailAddress, Rating = (int?)PR.Rating, PR.Comments
			}



		
