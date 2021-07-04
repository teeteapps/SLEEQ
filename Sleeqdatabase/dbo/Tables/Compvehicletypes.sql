CREATE TABLE [dbo].[Compvehicletypes] (
    [Idxno]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [Typecode]    BIGINT        NOT NULL,
    [Typename]    VARCHAR (50)  NOT NULL,
    [Capacity]    BIGINT        NOT NULL,
    [Cartype]     BIGINT        NOT NULL,
    [Imagepath]   VARCHAR (100) NOT NULL,
    [Createdby]   BIGINT        DEFAULT ((100)) NOT NULL,
    [Datecreated] DATETIME      DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Idxno] ASC),
    UNIQUE NONCLUSTERED ([Typecode] ASC)
);

