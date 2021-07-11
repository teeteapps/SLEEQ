
CREATE PROCEDURE [dbo].[Usp_EditCompanycustomer]
@Custcode BIGINT,
@Firstname VARCHAR(100),
@Lastname  VARCHAR(100),
@Emailadd VARCHAR(100),
@Phoneno  VARCHAR(15),
@Idnumber  VARCHAR(100),
@Custtype BIGINT,
@Createdby BIGINT  
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
		UPDATE Companycustomers SET Firstname=@Firstname,Lastname=@Lastname,Emailadd=@Emailadd,Phoneno=@Phoneno,Idnumber=@Idnumber,Custtype=@Custtype WHERE Custcode=@Custcode
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