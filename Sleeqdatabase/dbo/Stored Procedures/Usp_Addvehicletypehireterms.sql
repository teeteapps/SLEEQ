

CREATE PROCEDURE [dbo].[Usp_Addvehicletypehireterms]
@Typecode BIGINT,
@Hireday VARCHAR(100),
@Hireprice DECIMAL(10,2)
AS
BEGIN
   BEGIN
	DECLARE 
			@Termcode BIGINT=0,
			@RespStat int = 0,
			@RespMsg varchar(150) = ''
			BEGIN
	
		BEGIN TRY	
		--Validate

		Declare @RunNoTable TABLE (RunNo Varchar(20))
		INSERT INTO @RunNoTable Exec Usp_GenerateRunNo 'CVHD'  
		Select @Termcode = RunNo From @RunNoTable
		BEGIN TRANSACTION;
		    INSERT INTO Vehicletypehireterms(Termcode,Typecode,Hireday,Hireprice)
			VALUES(@Termcode,@Typecode,@Hireday,@Hireprice)
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
