


CREATE procedure [dbo].[spSalesProduct] (
	@ID int = null,
	@SKU varchar(150) = null,
	@ProductName varchar(100) = null,
	@Price money = null,
	@Action varchar(100) = null
) as begin if @Action = 'Insert' insert into SalesProduct(SKU, ProductName, Price)
values
(@SKU, @ProductName, @Price) if @Action = 'Update'
update
SalesProduct
set
SKU = @SKU,
ProductName = @ProductName,
Price = @Price
where ID = @ID if @Action = 'Delete'
delete from
SalesProduct
where ID = @ID end