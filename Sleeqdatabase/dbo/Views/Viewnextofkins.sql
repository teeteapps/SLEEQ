

CREATE VIEW [dbo].[Viewnextofkins] AS SELECT SC.Supcustcode,SC.Custcode,SC.Relation,R.Relname,SC.Fullname,SC.Phonenumber,SC.Idnumber FROM Supportcustomers SC INNER JOIN Relationships R ON SC.Relation=R.Relcode
