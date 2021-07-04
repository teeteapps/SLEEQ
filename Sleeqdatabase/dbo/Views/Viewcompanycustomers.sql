
CREATE VIEW [dbo].[Viewcompanycustomers] AS 
SELECT vo.Custcode,vo.Firstname,vo.Lastname,vo.Emailadd,vo.Phoneno,vo.Idnumber,
vo.Custtype,CASE WHEN vo.Custtype=100 THEN 'Corporate' WHEN vo.Custtype=200 THEN 'Individual' ELSE 'Customer' END AS Custtypename    ,vo.Isactive,vo.Datecreated FROM Companycustomers vo
