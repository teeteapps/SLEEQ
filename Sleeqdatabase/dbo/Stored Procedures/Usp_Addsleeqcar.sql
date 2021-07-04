CREATE PROCEDURE [dbo].[Usp_Addsleeqcar]
@Sleeqcar VARCHAR(100),
@Seaters  VARCHAR(100),
@Sleeqcarimage VARCHAR(100),
@Fueltype  VARCHAR(100),
@Enginesize  VARCHAR(100),
@VehicleColor  VARCHAR(100),
@Createdby BIGINT  
AS
BEGIN
   BEGIN
	DECLARE 
			@Sleeqcarcode BIGINT=0,
			@RespStat int = 0,
			@RespMsg varchar(150) = ''
			BEGIN
	
		BEGIN TRY	
		--Validate

		Declare @RunNoTable TABLE (RunNo Varchar(20))
		INSERT INTO @RunNoTable Exec Usp_GenerateRunNo 'CVD'  
		Select @Sleeqcarcode = RunNo From @RunNoTable
		BEGIN TRANSACTION;
		    INSERT INTO Sleeqcars(Sleeqcarcode,Sleeqcar,Seaters,Sleeqcarimage,Fueltype,Enginesize,VehicleColor,Createdby)
			VALUES(@Sleeqcarcode,@Sleeqcar,@Seaters,@Sleeqcarimage,@Fueltype,@Enginesize,@VehicleColor,@Createdby)
		Set @RespMsg ='Vehicle Saved Successfully.'
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
