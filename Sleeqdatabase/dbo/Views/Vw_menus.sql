
CREATE view [dbo].[Vw_menus] as select m.MenuCode,m.MenuName,m.ActionName,m.Controller,m.IconName,m.OrderBy,m.MenuLevel,m.ParentId,r.ProfileCode from Menus m,Rights r where r.MenuCode=m.MenuCode




