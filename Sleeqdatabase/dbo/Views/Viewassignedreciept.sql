


CREATE VIEW [dbo].[Viewassignedreciept] AS SELECT AC.Vehiclecode,AC.Assigncode,AC.Custcode, CC.Firstname+' '+CC.Lastname AS Customername,
CC.Emailadd,CC.Phoneno,AC.Vehiclereg,AC.Whereto,AC.Wheretodescription,AC.Hiredays,
AC.Hiringdays,AC.Hiringprice,Ac.Hireamount,AC.Carwash , (Ac.Hireamount + AC.Carwash) AS Totalhireamount,CASE WHEN AC.Carstatus=1 THEN 'Hired' ELSE 'Parked' END AS Carstatus,
AC.Dateissued,AC.Enddate AS Dateexpected,CASE WHEN AC.Carstatus=1 THEN AC.Dateissued ELSE AC.Daterecieved END AS Daterecieved,'' AS Hirername, SF.Displayname AS Recievername 
FROM Assigncustomercar AC INNER JOIN Companycustomers CC ON CC.Custcode=AC.Custcode
INNER JOIN Sleeqcarhirestaffs SF ON AC.Hiredby =SF.Clientcode