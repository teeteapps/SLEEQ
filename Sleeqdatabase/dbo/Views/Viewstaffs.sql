﻿
CREATE VIEW [dbo].[Viewstaffs] AS select SF.Usercode,SF.Firstname+' '+SF.Lastname AS Fullname,SF.Emailadd,CASE WHEN SF.Rolecode=200 THEN 'Staff' ELSE 'Admin' END AS Staffrole,SF.Phonenumber,SF.Datecreated from Staffs SF WHERE SF.Sysgen=0