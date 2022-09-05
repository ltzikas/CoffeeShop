using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;

namespace CoffeeShop.Interfaces
{
    public interface IMenu
    {
        List<Menu> GetMenus();
        Menu AddMenu(Menu menu);
    }
}