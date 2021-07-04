
CREATE PROCEDURE [dbo].[Usp_Addnextofkin]
@Custcode BIGINT,
@Fullname VARCHAR(100),
@Phonenumber VARCHAR(15),
@Idnumber VARCHAR(50),
@Relation BIGINT,
@Createdby BIGINT
AS
BEGIN
   BEGIN
	DECLARE 
			@Supcustcode BIGINT=0,
			@RespStat int = 0,
			@RespMsg varchar(150) = ''
			BEGIN
	
		BEGIN TRY	
		--Validate

		Declare @RunNoTable TABLE (RunNo Varchar(20))
		INSERT INTO @RunNoTable Exec Usp_GenerateRunNo 'CNK'  
		Select @Supcustcode = RunNo From @RunNoTable
		BEGIN TRANSACTION;
		    INSERT INTO Supportcustomers(Supcustcode,Custcode,Relation,Fullname,Phonenumber,Idnumber,Createdby)
			VALUES(@Supcustcode,@Custcode,@Relation,@Fullname,@Phonenumber,@Idnumber,@Createdby)
		Set @RespMsg ='Saved Successfully.'
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
