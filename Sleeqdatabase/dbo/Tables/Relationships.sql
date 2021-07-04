CREATE TABLE [dbo].[Relationships] (
    [Idxno]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [Relcode]     BIGINT        NOT NULL,
    [Relname]     VARCHAR (100) NOT NULL,
    [Datecreated] DATETIME      DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Idxno] ASC),
    UNIQUE NONCLUSTERED ([Relcode] ASC)
);

