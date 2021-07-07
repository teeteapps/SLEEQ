
CREATE PROCEDURE [dbo].[Usp_Checkinvehicle]
@Assigncode BIGINT,
@Vehiclecode BIGINT
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
		     UPDATE Assigncustomercar SET Carstatus=0,Daterecieved=GETDATE() WHERE Assigncode=@Assigncode
			 UPDATE Companyvehicles SET Carstatus=0 WHERE Vehiclecode=@Vehiclecode
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