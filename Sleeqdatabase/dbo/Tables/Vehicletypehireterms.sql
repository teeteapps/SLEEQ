CREATE TABLE [dbo].[Vehicletypehireterms] (
    [Idxno]          BIGINT          IDENTITY (1, 1) NOT NULL,
    [Termcode]       BIGINT          NOT NULL,
    [Typecode]       BIGINT          NOT NULL,
    [Mondayprice]    DECIMAL (18, 2) NOT NULL,
    [Tuesdayprice]   DECIMAL (18, 2) NOT NULL,
    [Wednesdayprice] DECIMAL (18, 2) NOT NULL,
    [Thursdayprice]  DECIMAL (18, 2) NOT NULL,
    [Fridayprice]    DECIMAL (18, 2) NOT NULL,
    [Saturdayprice]  DECIMAL (18, 2) NOT NULL,
    [Sundayprice]    DECIMAL (18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Idxno] ASC),
    UNIQUE NONCLUSTERED ([Termcode] ASC)
);



