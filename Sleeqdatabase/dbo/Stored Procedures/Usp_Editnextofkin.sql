
CREATE PROCEDURE [dbo].[Usp_Editnextofkin]
@Supcustcode BIGINT,
@Custcode BIGINT,
@Fullname VARCHAR(100),
@Phonenumber VARCHAR(15),
@Idnumber VARCHAR(50),
@Relation BIGINT
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
		UPDATE Supportcustomers SET Fullname=@Fullname,Phonenumber=@Phonenumber,Idnumber=@Idnumber,Relation=@Relation WHERE Supcustcode=@Supcustcode
		Set @RespMsg ='Updated Successfully.'
		Set @RespStat =0; 
		COMMIT TRANSACTION;
		Select @RespStat as RespStatus, @RespMsg as RespMessage,@Custcode AS Data1;

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