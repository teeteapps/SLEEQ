



CREATE VIEW [dbo].[Viewcompanyvehicles] AS SELECT CV.Vehiclecode,CV.Custcode,CV.Typecode,VT.Typename,Regno,VT.Capacity,VT.Imagepath,VT.Cartype,'' AS Cartypename,CV.Fueltype,CV.Chasno,CV.Enginesize,CV.Color 
FROM Companyvehicles CV 
INNER JOIN Compvehicletypes VT ON CV.Typecode=VT.Typecode
