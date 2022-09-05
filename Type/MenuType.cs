using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using CoffeeShop.Models;
using CoffeeShop.Type;
using CoffeeShop.Interfaces;

namespace CoffeeShop.Type
{
    public class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(ISubMenu subMenuService)
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
            Field<ListGraphType<SubMenuType>>("submenus",resolve: context => { return subMenuService.GetSubMenus(context.Source.Id); });
        }
    }
}