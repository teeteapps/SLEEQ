CREATE TABLE [dbo].[Capacity] (
    [Idxno]       BIGINT       IDENTITY (1, 1) NOT NULL,
    [Capcode]     BIGINT       NOT NULL,
    [Capname]     VARCHAR (50) NOT NULL,
    [Datecreated] DATETIME     DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Idxno] ASC),
    UNIQUE NONCLUSTERED ([Capcode] ASC)
);

