CREATE TABLE [dbo].[Staffs] (
    [Idxno]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [Usercode]     BIGINT        NOT NULL,
    [Firstname]    VARCHAR (100) NOT NULL,
    [Lastname]     VARCHAR (100) NOT NULL,
    [Emailadd]     VARCHAR (100) NOT NULL,
    [Phonenumber]  VARCHAR (15)  NOT NULL,
    [Rolecode]     BIGINT        DEFAULT ((200)) NOT NULL,
    [Passwordhash] VARCHAR (100) NOT NULL,
    [Loginstatus]  INT           DEFAULT ((1)) NOT NULL,
    [Sysgen]       BIT           DEFAULT ((0)) NOT NULL,
    [Createdby]    BIGINT        DEFAULT ((100)) NOT NULL,
    [Modifiedby]   BIGINT        DEFAULT ((100)) NOT NULL,
    [Datecreated]  DATETIME      DEFAULT (getdate()) NOT NULL,
    [Datemodified] DATETIME      DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Idxno] ASC),
    UNIQUE NONCLUSTERED ([Emailadd] ASC),
    UNIQUE NONCLUSTERED ([Phonenumber] ASC),
    UNIQUE NONCLUSTERED ([Usercode] ASC)
);



