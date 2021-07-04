CREATE TABLE [dbo].[Rights] (
    [RightId]     INT IDENTITY (1, 1) NOT NULL,
    [MenuCode]    INT NOT NULL,
    [ProfileCode] INT NOT NULL,
    [AllowAccess] BIT NOT NULL,
    [AuthStatus]  INT NOT NULL,
    CONSTRAINT [pk_RightId] PRIMARY KEY CLUSTERED ([RightId] ASC)
);

