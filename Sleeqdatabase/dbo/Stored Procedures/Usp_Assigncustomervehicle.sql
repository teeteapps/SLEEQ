
CREATE PROCEDURE [dbo].[Usp_Assigncustomervehicle]
@Vehiclecode BIGINT,
@Custcode BIGINT,
@Vehiclereg VARCHAR(50),
@Whereto VARCHAR(200),
@Wheretodescription VARCHAR(500),
@Hiredays BIGINT,
@Hiringdays VARCHAR(200),
@Hireamount DECIMAL(10,2),
@Hireprice VARCHAR(200),
@Carwash DECIMAL(10,2),
@Startdate DATETIME,
@Enddate DATETIME,
@Hiredby BIGINT,
@Recievedby BIGINT
AS
BEGIN
   BEGIN
	DECLARE 
			@Assigncode BIGINT=0,
			@RespStat int = 0,
			@RespMsg varchar(150) = ''
			BEGIN
	
		BEGIN TRY	
		--Validate

		Declare @RunNoTable TABLE (RunNo Varchar(20))
		INSERT INTO @RunNoTable Exec Usp_GenerateRunNo 'ACV'  
		Select @Assigncode = RunNo From @RunNoTable
		BEGIN TRANSACTION;
		    INSERT INTO Assigncustomercar(Assigncode,Custcode,Vehiclecode,Vehiclereg,Whereto,Wheretodescription,Hiredays,Hiringdays,Hiringprice,Hireamount,Carwash,Startdate,Enddate,Hiredby,Recievedby)
			VALUES(@Assigncode,@Custcode,@Vehiclecode,@Vehiclereg,@Whereto,@Wheretodescription,@Hiredays,@Hiringdays,@Hireprice,@Hireamount,@Carwash,@Startdate,@Enddate,@Hiredby,@Recievedby)
		Set @RespMsg ='Saved Successfully.'
		Set @RespStat =0; 
		COMMIT TRANSACTION;
		Select @RespStat as RespStatus, @RespMsg as RespMessage,@Assigncode AS Data1;

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
