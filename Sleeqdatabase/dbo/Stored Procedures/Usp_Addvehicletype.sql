
CREATE PROCEDURE [dbo].[Usp_Addvehicletype]
@Typename VARCHAR(100),
@Capacity BIGINT,
@Cartype BIGINT,
@Imagepath VARCHAR(100),
@Createdby BIGINT
AS
BEGIN
   BEGIN
	DECLARE 
			@Typecode BIGINT=0,
			@RespStat int = 0,
			@RespMsg varchar(150) = ''
			BEGIN
	
		BEGIN TRY	
		--Validate

		Declare @RunNoTable TABLE (RunNo Varchar(20))
		INSERT INTO @RunNoTable Exec Usp_GenerateRunNo 'CVT'  
		Select @Typecode = RunNo From @RunNoTable
		BEGIN TRANSACTION;
		    INSERT INTO Compvehicletypes(Typecode,Typename,Capacity,Cartype,Imagepath,Createdby)
			VALUES(@Typecode,@Typename,@Capacity,@Cartype,@Imagepath,@Createdby)
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
