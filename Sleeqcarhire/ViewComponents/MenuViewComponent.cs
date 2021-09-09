using DBL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sleeqcarhire.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        BL bl;
        public MenuViewComponent()
        {
            bl = new BL(Util.ShareConnectionString.Value);
        }
        public async Task<IViewComponentResult> InvokeAsync(int profilecode)
        {
            var items = await bl.getMenus(profilecode);
            return View("_Menus", items);
        }
    }
}
