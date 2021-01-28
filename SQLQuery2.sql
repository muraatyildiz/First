Select * from Customers
Select  ContactName Adi,CompanyName SirketAdi, City Sehir from Customers
Select * from Customers where City = 'Berlin'

Select * from Products where CategoryID=1 or CategoryID=3
Select * from Products where CategoryID=1 and UnitPrice>=10
Select * from Products order by UnitPrice asc
Select * from Products where CategoryID=1 order by UnitPrice desc
select count(*) Adet from Products
select categoryId,count(*)  from Products group by CategoryID 
select categoryId,count(*)  from Products where UnitPrice >20 group by CategoryID  having count(*) <10