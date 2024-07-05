Joins

select * from categories

select * from products
where ProductID=1

select ProductID,ProductName,p.CategoryID,CategoryName,p.SupplierID,CompanyName from Products as p inner Join Categories as c
on c.CategoryID=p.CategoryID
inner Join Suppliers s 
on p.SupplierID=s.SupplierID
order by p.CategoryID

select * from  Employees

select o.EmployeeID,o.FirstName,o.ReportsTo,d.FirstName from Employees o, Employees d where
o.ReportsTo=d.EmployeeID or o.ReportsTo is null
order by o.EmployeeID

select * from Customers
select * from Orders
where CustomerID like 'VINET'

select c.customerid,o.orderid from 
customers c full outer join orders o on
o.CustomerID=c.CustomerID
order by o.OrderID










