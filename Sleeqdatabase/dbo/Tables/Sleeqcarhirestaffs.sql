CREATE TABLE [dbo].[Sleeqcarhirestaffs] (
    [Idxno]          BIGINT        IDENTITY (1, 1) NOT NULL,
    [Clientcode]     BIGINT        NOT NULL,
    [Pagename]       VARCHAR (100) NOT NULL,
    [Displayname]    VARCHAR (100) NOT NULL,
    [Clientphone]    VARCHAR (16)  NOT NULL,
    [Clientemail]    VARCHAR (100) NOT NULL,
    [Clientpassword] VARCHAR (100) NOT NULL,
    [Clientrole]     INT           DEFAULT ((200)) NOT NULL,
    [Parentcode]     BIGINT        NOT NULL,
    [Loginstatus]    INT           DEFAULT ((0)) NOT NULL,
    [Createdby]      BIGINT        DEFAULT ((10)) NOT NULL,
    [Modifiedby]     BIGINT        DEFAULT ((10)) NOT NULL,
    [Datecreated]    DATETIME      DEFAULT (getdate()) NOT NULL,
    [Datemodified]   DATETIME      DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Idxno] ASC),
    UNIQUE NONCLUSTERED ([Clientcode] ASC),
    UNIQUE NONCLUSTERED ([Clientemail] ASC),
    UNIQUE NONCLUSTERED ([Clientphone] ASC),
    UNIQUE NONCLUSTERED ([Displayname] ASC),
    UNIQUE NONCLUSTERED ([Pagename] ASC)
);

