IEnumerable<ProductItem> query =
	from p in Product
	select new ProductItem
	{
		Name  = p.Name,
		ListPrice = p.ListPrice,
		Size = p.Size
	};

	var firstResult = query.Where(c => c.ListPrice < 3000);
	var secondResult = firstResult.Where(c => c.Name.Contains("Road"));	
	var finalResult = secondResult.Where(c => c.Size == "52");

finalResult.Dump();
}

class ProductItem
{
	public string Name;     
	public decimal ListPrice;  
	public string Size;  