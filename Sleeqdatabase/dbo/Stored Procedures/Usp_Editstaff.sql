

CREATE PROCEDURE [dbo].[Usp_Editstaff]
@Usercode BIGINT,
@Firstname VARCHAR(100),
@Lastname VARCHAR(100),
@Emailadd VARCHAR(100),
@Phonenumber VARCHAR(15),
@Modifiedby BIGINT
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
		UPDATE Staffs SET Firstname=@Firstname,Lastname=@Lastname,Emailadd=@Emailadd,Phonenumber=@Phonenumber,Modifiedby=@Modifiedby,Datemodified=GETDATE() WHERE Usercode=@Usercode
		Set @RespMsg ='Updated Successfully.'
		Set @RespStat =0; 
		COMMIT TRANSACTION;
		Select @RespStat as RespStatus, @RespMsg as RespMessage;

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