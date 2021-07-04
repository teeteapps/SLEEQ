CREATE TABLE [dbo].[Vehicletypehireterms] (
    [Idxno]     BIGINT          IDENTITY (1, 1) NOT NULL,
    [Termcode]  BIGINT          NOT NULL,
    [Typecode]  BIGINT          NOT NULL,
    [Hireday]   VARCHAR (100)   NOT NULL,
    [Hireprice] DECIMAL (18, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Idxno] ASC),
    UNIQUE NONCLUSTERED ([Termcode] ASC)
);

