CREATE TABLE [dbo].[Companyvehicles] (
    [Idxno]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [Vehiclecode] BIGINT        NOT NULL,
    [Custcode]    BIGINT        NOT NULL,
    [Typecode]    BIGINT        NOT NULL,
    [Regno]       VARCHAR (10)  NOT NULL,
    [Fueltype]    VARCHAR (100) NOT NULL,
    [Chasno]      VARCHAR (100) NOT NULL,
    [Color]       VARCHAR (50)  NOT NULL,
    [Enginesize]  VARCHAR (100) NOT NULL,
    [Carstatus]   BIT           DEFAULT ((1)) NOT NULL,
    [Etra]        VARCHAR (100) NULL,
    [Etra1]       VARCHAR (100) NULL,
    [Etra2]       VARCHAR (100) NULL,
    [Etra3]       VARCHAR (100) NULL,
    [Etra4]       VARCHAR (100) NULL,
    [Etra5]       VARCHAR (100) NULL,
    [Etra6]       VARCHAR (100) NULL,
    [Etra7]       VARCHAR (100) NULL,
    [Etra8]       VARCHAR (100) NULL,
    [Etra9]       VARCHAR (100) NULL,
    [Etra10]      VARCHAR (100) NULL,
    [Createdby]   BIGINT        DEFAULT ((100)) NOT NULL,
    [Datecreated] DATETIME      DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Idxno] ASC),
    UNIQUE NONCLUSTERED ([Vehiclecode] ASC)
);



