using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;

namespace CoffeeShop.Interfaces
{
    public interface ISubMenu
    {
        List<SubMenu> GetSubMenus();
        List<SubMenu> GetSubMenus(int menuId);
        SubMenu AddSubMenu(SubMenu subMenu);
    }
}