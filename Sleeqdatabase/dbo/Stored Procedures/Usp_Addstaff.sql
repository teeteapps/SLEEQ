

CREATE PROCEDURE [dbo].[Usp_Addstaff]
@Firstname VARCHAR(100),
@Lastname VARCHAR(100),
@Emailadd VARCHAR(100),
@Phonenumber VARCHAR(15),
@Passwordhash VARCHAR(100),
@Createdby BIGINT,
@Modifiedby BIGINT
AS
BEGIN
   BEGIN
	DECLARE 
			@Usercode BIGINT=0,
			@RespStat int = 0,
			@RespMsg varchar(150) = ''
			BEGIN
	
		BEGIN TRY	
		--Validate

		Declare @RunNoTable TABLE (RunNo Varchar(20))
		INSERT INTO @RunNoTable Exec Usp_GenerateRunNo 'STF'  
		Select @Usercode = RunNo From @RunNoTable
		BEGIN TRANSACTION;
		    INSERT INTO Staffs(Usercode,Firstname,Lastname,Emailadd,Phonenumber,Passwordhash,Createdby,Modifiedby)
			VALUES(@Usercode,@Firstname,@Lastname,@Emailadd,@Phonenumber,@Passwordhash,@Createdby,@Modifiedby)
		Set @RespMsg ='Saved Successfully.'
		Set @RespStat =0; 
		COMMIT TRANSACTION;
		Select @RespStat as RespStatus, @RespMsg as RespMessage,@Firstname+' '+@Lastname AS Data1,@Emailadd AS Data2,@Passwordhash AS Data3;

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