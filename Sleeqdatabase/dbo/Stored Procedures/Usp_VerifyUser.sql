CREATE PROCEDURE [dbo].[Usp_VerifyUser]
	@Emailaddress varchar(100)
AS
BEGIN
	SET NOCOUNT ON;
	Declare @Code int,
			@RespStat int = 0,
			@RespMsg varchar(150) = 'login success',
			@UserCode BIGINT,
			@Parentcode BIGINT,
			@Fullname varchar(100),
			@Phonenumber varchar(15),
			@Pwd varchar(150),
			@Loginstatus INT,
			@Rolecode int,
			@Email varchar(100)

    BEGIN TRY
		----- Get user details
		Select @UserCode = Usercode,@Fullname=Firstname+' '+Lastname,@Phonenumber=Phonenumber, @Pwd = Passwordhash,@Rolecode=Rolecode,@Email=Emailadd,@Loginstatus=Loginstatus,@Parentcode=Usercode From Staffs Where Emailadd = @Emailaddress
		If(@UserCode Is Null)
		Begin
			Select  1 as RespStatus, 'Invalid Username and/or Password!' as RespMessage
			Return
		End
		If(@Rolecode =300)
		Begin
			Select  1 as RespStatus, 'You are not authorized to login to the system. Contact Admin!' as RespMessage
			Return
		End
		If(@Pwd Is Null)
		Begin
			Select  1 as RespStatus, 'Invalid Username and/or Password!' as RespMessage
			Return
		End
		If(@Fullname Is Null)
		Begin
			Select  1 as RespStatus, 'Invalid Username and/or Password!' as RespMessage
			Return
		End
		
		--- Create response
		Select  @RespStat as RespStatus, @RespMsg as RespMessage, @UserCode as Data1,@Fullname as Data2,@Phonenumber as Data3, @Pwd as Data4,@Email as Data5,@Rolecode as Data6,@Loginstatus as Data7,@Parentcode as Data8

	END TRY
	BEGIN CATCH
		SELECT @RespMsg = ERROR_MESSAGE(), @RespStat = 2;
		Select  @RespStat as RespStatus, @RespMsg as RespMessage
	END CATCH

END