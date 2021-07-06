
CREATE VIEW [dbo].[Viewcompanyvehiclesdashboard] AS SELECT CV.Typecode,CV.Typename,
CP.Capname,
CV.Imagepath,CASE WHEN CV.Cartype=100 THEN 'Salon' ELSE 'Executive' END AS Cartype,HT.Mondayprice,HT.Tuesdayprice,HT.Wednesdayprice,HT.Thursdayprice,
HT.Fridayprice,HT.Saturdayprice,HT.Sundayprice
FROM Compvehicletypes CV 
INNER JOIN Vehicletypehireterms HT ON CV.Typecode=HT.Typecode
INNER JOIN Capacity CP ON CP.Capcode=CV.Capacity