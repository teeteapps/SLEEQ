
CREATE VIEW [dbo].[Viewvehicleowners] AS 
SELECT vo.Custcode,vo.Firstname,vo.Lastname,vo.Emailadd,vo.Phoneno,vo.Idnumber,
vo.Custtype,vo.Isactive,vo.Datecreated FROM Companycustomers vo
