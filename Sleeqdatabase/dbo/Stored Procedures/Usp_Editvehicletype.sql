
CREATE PROCEDURE [dbo].[Usp_Editvehicletype]
@Typecode BIGINT,
@Typename VARCHAR(100),
@Capacity BIGINT,
@Cartype BIGINT,
@Imagepath VARCHAR(100),
@Createdby BIGINT
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
		UPDATE Compvehicletypes SET Typename=@Typename,Capacity=@Capacity,Cartype=@Cartype WHERE Typecode=@Typecode
		Set @RespMsg ='Update Successfully.'
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
