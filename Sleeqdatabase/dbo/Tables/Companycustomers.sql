CREATE TABLE [dbo].[Companycustomers] (
    [Idxno]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [Custcode]    BIGINT        NOT NULL,
    [Firstname]   VARCHAR (100) NOT NULL,
    [Lastname]    VARCHAR (100) NOT NULL,
    [Emailadd]    VARCHAR (100) NOT NULL,
    [Phoneno]     VARCHAR (100) NOT NULL,
    [Idnumber]    VARCHAR (100) NOT NULL,
    [Custtype]    BIGINT        NOT NULL,
    [Createdby]   BIGINT        DEFAULT ((100)) NOT NULL,
    [Isactive]    BIT           DEFAULT ((1)) NOT NULL,
    [Isapproved]  INT           DEFAULT ((1)) NOT NULL,
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
    [Datecreated] DATETIME      DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Idxno] ASC),
    UNIQUE NONCLUSTERED ([Custcode] ASC)
);



