--Select
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'London'

select * from Products where categoryId=1 and UnitPrice>=10 and UnitPrice<200

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) Adet from Products where CategoryId = 2

select CategoryID,count(*) KategoriAdedi from products where UnitPrice>20 group by CategoryId having count(*)<10

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName 
from products inner join Categories 
on Products.CategoryId = Categories.CategoryId where Products.UnitPrice>10

--DTO Data Transformation Object

select * from Products p left join [Order Details] od 
on p.ProductId = od.ProductId inner join Orders o on o.OrderID = od.OrderID

select * from Customers c right join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null





