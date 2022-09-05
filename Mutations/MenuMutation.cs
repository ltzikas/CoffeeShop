using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using CoffeeShop.Interfaces;
using CoffeeShop.Type;
using CoffeeShop.Models;
using GraphQL;

namespace CoffeeShop.Mutations
{
    public class MenuMutation : ObjectGraphType
    {
        public MenuMutation(IMenu menuService)
        {
            Field<MenuType>("createMenu",arguments: new QueryArguments(
                                                    new QueryArgument<MenuInputType> {Name = "menu"}
                                                ),
                                                resolve: context => 
                                                    { return menuService.AddMenu( context.GetArgument<Menu>("menu"));}
            );
            
        }
    }
}