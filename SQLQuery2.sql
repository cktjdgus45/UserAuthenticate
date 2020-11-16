CREATE PROC UserUpdate 
@UserId nvarchar(15),    
@Password nvarchar(15),  
@UserName  nvarchar(15)

AS  
        UPDATE [User]
        SET    
              UserId = @UserId, 
              Password = @Password, 
              UserName = @UserName 
        WHERE UserId = @UserId
        