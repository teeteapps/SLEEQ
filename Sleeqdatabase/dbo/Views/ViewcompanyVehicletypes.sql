


CREATE VIEW [dbo].[ViewcompanyVehicletypes] AS SELECT VT.Typecode,VT.Typename,
CP.Capname AS Capacity,VT.Imagepath,
HT.Mondayprice,HT.Tuesdayprice,HT.Wednesdayprice,HT.Thursdayprice,
HT.Fridayprice,HT.Saturdayprice,HT.Sundayprice
FROM Compvehicletypes VT 
INNER JOIN Vehicletypehireterms HT ON HT.Typecode=VT.Typecode
INNER JOIN Capacity CP ON CP.Capcode=VT.Capacity