
CREATE PROCEDURE [dbo].[Usp_Changepassword]
@UserCode BIGINT,
@Newpassword VARCHAR(100)
AS
BEGIN
   BEGIN
	DECLARE 
			@RespStat int = 0,
			@RespMsg varchar(150) = ''
			BEGIN
	
		BEGIN TRY	
		--Validate
		BEGIN TRANSACTION;
		     UPDATE Staffs SET Passwordhash=@Newpassword,Datemodified=GETDATE() WHERE Usercode=@UserCode
		Set @RespMsg ='Changed Successfully.'
		Set @RespStat =0; 
		COMMIT TRANSACTION;
		Select @RespStat as RespStatus, @RespMsg as RespMessage,@UserCode as Data1;

		END TRY
		BEGIN CATCH
		ROLLBACK TRANSACTION
		PRINT ''
		PRINT 'Error ' + error_message();
		Select 2 as RespStatus, '0 - Error(s) Occurred' + error_message() as RespMessage
		END CATCH
		Select @RespStat as RespStatus, @RespMsg as RespMessage;
		RETURN; 
		END;
	END
END