CREATE VIEW Viewcompanyvehiclesdashboard AS SELECT CV.Typecode,CV.Typename,
CP.Capname,
CV.Imagepath,CASE WHEN CV.Cartype=100 THEN 'Salon' ELSE 'Executive' END AS Cartype,HT.Hireday,HT.Hireprice
FROM Compvehicletypes CV 
INNER JOIN Vehicletypehireterms HT ON CV.Typecode=HT.Typecode
INNER JOIN Capacity CP ON CP.Capcode=CV.Capacity