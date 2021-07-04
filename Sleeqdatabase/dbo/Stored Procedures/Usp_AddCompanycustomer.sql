
CREATE PROCEDURE [dbo].[Usp_AddCompanycustomer]
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
			@Custcode BIGINT=0,
			@RespStat int = 0,
			@RespMsg varchar(150) = ''
			BEGIN
	
		BEGIN TRY	
		--Validate

		Declare @RunNoTable TABLE (RunNo Varchar(20))
		INSERT INTO @RunNoTable Exec Usp_GenerateRunNo 'CVO'  
		Select @Custcode = RunNo From @RunNoTable
		BEGIN TRANSACTION;
		      INSERT INTO Companycustomers(Custcode,Firstname,Lastname,Emailadd,Phoneno,Idnumber,Custtype,Createdby)
			VALUES(@Custcode,@Firstname,@Lastname,@Emailadd,@Phoneno,@Idnumber,@Custtype,@Createdby)
		Set @RespMsg ='Vehicle Owner Saved Successfully.'
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
