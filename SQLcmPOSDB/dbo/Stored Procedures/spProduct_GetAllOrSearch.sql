


CREATE procedure [dbo].[spProduct_GetAllOrSearch]
	@txtSearch varchar(100)
as begin
	select *
	from SalesProduct
	where @txtSearch = '' or
		SKU like '%' + @txtSearch + '%'
end