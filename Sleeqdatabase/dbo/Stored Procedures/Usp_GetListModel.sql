
CREATE PROCEDURE [dbo].[Usp_GetListModel]
@Type int
AS
BEGIN
SET NOCOUNT ON;
If(@Type = 0)
Select VT.Typename as Text, VT.Typecode as Value From Compvehicletypes VT;
If(@Type = 1)
Select r.Relname as Text, r.Relcode as Value From Relationships r;
If(@Type = 2)
Select CV.Regno as Text, Cv.Vehiclecode as Value From Companyvehicles CV WHERE CV.Carstatus=0;
If(@Type = 3)
Select C.Capname as Text, C.Capcode as Value From Capacity C;
END
