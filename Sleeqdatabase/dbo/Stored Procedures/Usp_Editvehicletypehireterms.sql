

CREATE PROCEDURE [dbo].[Usp_Editvehicletypehireterms]
@Termcode BIGINT,
@Mondayprice DECIMAL(10,2),
@Tuesdayprice DECIMAL(10,2),
@Wednesdayprice DECIMAL(10,2),
@Thursdayprice DECIMAL(10,2),
@Fridayprice DECIMAL(10,2),
@Saturdayprice DECIMAL(10,2),
@Sundayprice DECIMAL(10,2)
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
		UPDATE Vehicletypehireterms SET Mondayprice=@Mondayprice,Tuesdayprice=@Tuesdayprice,
			Wednesdayprice=@Wednesdayprice,Thursdayprice=@Thursdayprice,Fridayprice=@Fridayprice,
			Saturdayprice=@Saturdayprice,Sundayprice=@Sundayprice  WHERE Termcode=@Termcode
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