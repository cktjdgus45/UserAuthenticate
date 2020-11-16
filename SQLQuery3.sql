CREATE PROC GETUSER
@UserId nvarchar(15),
@Password nvarchar(15),
@UserName nvarchar(15)
AS
	SELECT *  
	FROM [User]