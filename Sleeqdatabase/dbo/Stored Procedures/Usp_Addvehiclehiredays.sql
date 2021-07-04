CREATE PROCEDURE [dbo].[Usp_Addvehiclehiredays]
@Sleeqcarcode BIGINT,
@Hirefrom VARCHAR(100),
@Hireto VARCHAR(100),
@Hireprice DECIMAL(10,2)
AS
BEGIN
   BEGIN
	DECLARE 
			@Sleeqcarhiredayscode BIGINT=0,
			@RespStat int = 0,
			@RespMsg varchar(150) = ''
			BEGIN
	
		BEGIN TRY	
		--Validate

		Declare @RunNoTable TABLE (RunNo Varchar(20))
		INSERT INTO @RunNoTable Exec Usp_GenerateRunNo 'CVHD'  
		Select @Sleeqcarhiredayscode = RunNo From @RunNoTable
		BEGIN TRANSACTION;
		    INSERT INTO Sleeqcarshiredays(Sleeqcarhiredayscode,Sleeqcarcode,Hirefrom,Hireto,Hireprice)
			VALUES(@Sleeqcarhiredayscode,@Sleeqcarcode,@Hirefrom,@Hireto,@Hireprice)
		Set @RespMsg ='Hire Days Added Successfully.'
		Set @RespStat =0; 
		COMMIT TRANSACTION;
		Select @RespStat as RespStatus, @RespMsg as RespMessage,@Sleeqcarcode AS Data1;

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
