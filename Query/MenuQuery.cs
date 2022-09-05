using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using CoffeeShop.Type;
using CoffeeShop.Interfaces;

namespace CoffeeShop.Query
{
    public class MenuQuery : ObjectGraphType
    {        
        public MenuQuery(IMenu menuService)
        {
            Field<ListGraphType<MenuType>>("menus",resolve: context => { return menuService.GetMenus(); });
        }
    }
}