select Products.ProductId, Products.Productname, Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID where Products.UnitPrice>10

select * from Products inner join [Order Details]