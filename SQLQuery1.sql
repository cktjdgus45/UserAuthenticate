ALTER PROC UserAdd
@UserId  nvarchar(15),
@Password nvarchar(15),
@UserName nvarchar(15)
AS
	INSERT INTO [User](UserId,Password,UserName)
	VALUES (@UserId,@Password,@UserName)
					 
					 