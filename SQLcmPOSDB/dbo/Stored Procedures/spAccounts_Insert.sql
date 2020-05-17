


create procedure spAccounts_Insert
	@Username varchar(100),
	@Password varchar(100),
	@AccountID int = 0 output
as begin
	set nocount on;
	
	insert into Accounts (Username, Password)
	values (@Username, @Password);
	
	select @AccountID = SCOPE_IDENTITY();
end