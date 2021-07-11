
CREATE PROCEDURE [dbo].[Usp_Editvehicle]
@Vehiclecode BIGINT,
@Custcode BIGINT,
@Regno VARCHAR(50),
@Color VARCHAR(50),
@Fueltype VARCHAR(50),
@Enginesize VARCHAR(50),
@Chasno VARCHAR(50),
@Typecode BIGINT
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
		UPDATE Companyvehicles SET Typecode=@Typecode,Regno=@Regno,Color=@Color,Fueltype=@Fueltype,Chasno=@Chasno,Enginesize=@Enginesize WHERE Vehiclecode=@Vehiclecode
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