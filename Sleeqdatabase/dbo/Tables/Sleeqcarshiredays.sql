CREATE TABLE [dbo].[Sleeqcarshiredays] (
    [Idxno]                BIGINT          IDENTITY (1, 1) NOT NULL,
    [Sleeqcarhiredayscode] BIGINT          NOT NULL,
    [Sleeqcarcode]         BIGINT          NOT NULL,
    [Hirefrom]             VARCHAR (100)   NOT NULL,
    [Hireto]               VARCHAR (100)   NOT NULL,
    [Hireprice]            DECIMAL (18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Idxno] ASC),
    UNIQUE NONCLUSTERED ([Sleeqcarhiredayscode] ASC)
);

