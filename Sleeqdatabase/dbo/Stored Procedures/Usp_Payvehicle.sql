
CREATE PROCEDURE [dbo].[Usp_Payvehicle]
@Assigncode BIGINT,
@Tripbalance DECIMAL(10,2),
@Tripamount DECIMAL(10,2),
@Paymentmode BIGINT,
@Paidamount DECIMAL(10,2),
@Paidby VARCHAR(100),
@Createdby BIGINT
AS
BEGIN
   BEGIN
	DECLARE 
			@Paycode BIGINT=0,
			@RespStat int = 0,
			@RespMsg varchar(150) = ''
			BEGIN
	
		BEGIN TRY	
		--Validate

		Declare @RunNoTable TABLE (RunNo Varchar(20))
		INSERT INTO @RunNoTable Exec Usp_GenerateRunNo 'VPM'  
		Select @Paycode = RunNo From @RunNoTable
		BEGIN TRANSACTION;
		    INSERT INTO Vehiclepayments(Paycode,Assigncode,Tripbalance,Tripamount,Paymentmode,Paidamount,Paidby,Createdby)
			VALUES(@Paycode,@Assigncode,@Tripbalance,@Tripamount,@Paymentmode,@Paidamount,@Paidby,@Createdby)
			IF @Tripbalance=0
			BEGIN
			 Update Assigncustomercar Set Ispaid=1 WHERE Assigncode=@Assigncode
			END
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