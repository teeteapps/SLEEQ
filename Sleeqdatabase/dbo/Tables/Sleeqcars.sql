CREATE TABLE [dbo].[Sleeqcars] (
    [Idxno]         BIGINT        IDENTITY (1, 1) NOT NULL,
    [Sleeqcarcode]  BIGINT        NOT NULL,
    [Sleeqcar]      VARCHAR (100) NOT NULL,
    [Sleeqcarimage] VARCHAR (100) NOT NULL,
    [Seaters]       VARCHAR (20)  NOT NULL,
    [Fueltype]      VARCHAR (100) NOT NULL,
    [Enginesize]    VARCHAR (100) NOT NULL,
    [VehicleColor]  VARCHAR (100) NOT NULL,
    [Createdby]     BIGINT        DEFAULT ((100)) NOT NULL,
    [Datecreated]   DATETIME      DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Idxno] ASC),
    UNIQUE NONCLUSTERED ([Sleeqcarcode] ASC)
);

