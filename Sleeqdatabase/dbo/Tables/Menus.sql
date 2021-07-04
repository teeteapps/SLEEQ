CREATE TABLE [dbo].[Menus] (
    [MenuId]     INT           IDENTITY (1, 1) NOT NULL,
    [MenuCode]   INT           NOT NULL,
    [MenuName]   VARCHAR (50)  NOT NULL,
    [ActionName] VARCHAR (100) NOT NULL,
    [Controller] VARCHAR (100) NOT NULL,
    [MenuLevel]  INT           NOT NULL,
    [ParentId]   INT           NOT NULL,
    [IconName]   VARCHAR (50)  NOT NULL,
    [StatusId]   INT           NOT NULL,
    [OrderBy]    INT           NOT NULL,
    CONSTRAINT [PK_Menus] PRIMARY KEY CLUSTERED ([MenuCode] ASC)
);

