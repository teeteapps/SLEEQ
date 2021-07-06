





CREATE VIEW [dbo].[Viewcompanyvehicles] AS SELECT CV.Vehiclecode,CV.Custcode,CV.Typecode,VT.Typename,
Regno,CP.Capname AS Capacity,VT.Imagepath,CV.Fueltype,CV.Chasno,CV.Enginesize,
CV.Color,HT.Mondayprice,HT.Tuesdayprice,HT.Wednesdayprice,HT.Thursdayprice,
HT.Fridayprice,HT.Saturdayprice,HT.Sundayprice
FROM Companyvehicles CV 
INNER JOIN Compvehicletypes VT ON CV.Typecode=VT.Typecode
INNER JOIN Vehicletypehireterms HT ON HT.Typecode=CV.Typecode
INNER JOIN Capacity CP ON CP.Capcode=VT.Capacity
