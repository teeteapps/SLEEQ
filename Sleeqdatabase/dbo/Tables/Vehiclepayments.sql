CREATE TABLE [dbo].[Vehiclepayments] (
    [Idxno]       BIGINT          IDENTITY (1, 1) NOT NULL,
    [Paycode]     BIGINT          NOT NULL,
    [Assigncode]  BIGINT          NOT NULL,
    [Tripbalance] DECIMAL (10, 2) NOT NULL,
    [Tripamount]  DECIMAL (10, 2) NOT NULL,
    [Paymentmode] BIGINT          NOT NULL,
    [Paidamount]  DECIMAL (10, 2) NOT NULL,
    [Paidby]      VARCHAR (50)    NOT NULL,
    [Createdby]   BIGINT          DEFAULT ((100)) NOT NULL,
    [Datecreated] DATETIME        DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Idxno] ASC),
    UNIQUE NONCLUSTERED ([Paycode] ASC)
);

