
CREATE PROCEDURE [dbo].[Usp_Addvehicle]
@Custcode BIGINT,
@Regno VARCHAR(50),
@Color VARCHAR(50),
@Fueltype VARCHAR(50),
@Enginesize VARCHAR(50),
@Chasno VARCHAR(50),
@Typecode BIGINT,
@Createdby BIGINT
AS
BEGIN
   BEGIN
	DECLARE 
			@Vehiclecode BIGINT=0,
			@RespStat int = 0,
			@RespMsg varchar(150) = ''
			BEGIN
	
		BEGIN TRY	
		--Validate

		Declare @RunNoTable TABLE (RunNo Varchar(20))
		INSERT INTO @RunNoTable Exec Usp_GenerateRunNo 'CVD'  
		Select @Vehiclecode = RunNo From @RunNoTable
		BEGIN TRANSACTION;
		    INSERT INTO Companyvehicles(Vehiclecode,Custcode,Typecode,Regno,Color,Fueltype,Chasno,Enginesize,Createdby)
			VALUES(@Vehiclecode,@Custcode,@Typecode,@Regno,@Color,@Fueltype,@Chasno,@Enginesize,@Createdby)
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
