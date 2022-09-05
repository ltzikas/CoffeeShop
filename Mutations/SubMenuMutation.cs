using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQL;
using CoffeeShop.Interfaces;
using CoffeeShop.Type;
using CoffeeShop.Models;

namespace CoffeeShop.Mutations
{
    public class SubMenuMutation : ObjectGraphType
    {
        public SubMenuMutation(ISubMenu subMenuService)
        {
            Field<SubMenuType>("createSubMenu",arguments: new QueryArguments(
                                                            new QueryArgument<SubMenuInputType> { Name = "submenu"}
                                                        ),
                                            resolve: context => 
                                                { return subMenuService.AddSubMenu(context.GetArgument<SubMenu>("submenu"));}
            );
        }
    }
}