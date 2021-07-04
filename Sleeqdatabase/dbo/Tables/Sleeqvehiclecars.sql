CREATE TABLE [dbo].[Sleeqvehiclecars] (
    [Idxno]           BIGINT          IDENTITY (1, 1) NOT NULL,
    [Sleeqcarcode]    BIGINT          NOT NULL,
    [Vehiclemodel]    VARCHAR (100)   NOT NULL,
    [Vehiclecapacity] VARCHAR (100)   NOT NULL,
    [Vehicleimage]    VARCHAR (100)   NOT NULL,
    [Fromday]         VARCHAR (50)    NOT NULL,
    [Today]           VARCHAR (50)    NOT NULL,
    [Hireprice]       DECIMAL (10, 2) NOT NULL,
    [Createdby]       BIGINT          DEFAULT ((100)) NOT NULL,
    [Datecreated]     DATETIME        DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Idxno] ASC),
    UNIQUE NONCLUSTERED ([Sleeqcarcode] ASC)
);

