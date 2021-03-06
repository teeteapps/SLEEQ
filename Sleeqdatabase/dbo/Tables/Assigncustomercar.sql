CREATE TABLE [dbo].[Assigncustomercar] (
    [Idxno]              BIGINT          IDENTITY (1, 1) NOT NULL,
    [Assigncode]         BIGINT          NOT NULL,
    [Custcode]           BIGINT          NOT NULL,
    [Vehiclecode]        BIGINT          NOT NULL,
    [Vehiclereg]         VARCHAR (50)    NOT NULL,
    [Whereto]            VARCHAR (100)   NOT NULL,
    [Wheretodescription] VARCHAR (500)   NOT NULL,
    [Hiredays]           BIGINT          NOT NULL,
    [Hiringdays]         VARCHAR (100)   NOT NULL,
    [Hiringprice]        VARCHAR (100)   NOT NULL,
    [Hireamount]         DECIMAL (10, 2) NOT NULL,
    [Carwash]            DECIMAL (10, 2) NOT NULL,
    [Carstatus]          BIT             DEFAULT ((1)) NOT NULL,
    [Ispaid]             BIT             DEFAULT ((0)) NOT NULL,
    [Isextended]         BIT             DEFAULT ((0)) NOT NULL,
    [Startdate]          DATETIME        NOT NULL,
    [Enddate]            DATETIME        NOT NULL,
    [Hiredby]            BIGINT          NOT NULL,
    [Recievedby]         BIGINT          NOT NULL,
    [Dateissued]         DATETIME        DEFAULT (getdate()) NOT NULL,
    [Daterecieved]       DATETIME        DEFAULT (getdate()) NOT NULL,
    [Datecreated]        DATETIME        DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Idxno] ASC),
    UNIQUE NONCLUSTERED ([Assigncode] ASC)
);







