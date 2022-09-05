using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using CoffeeShop.Interfaces;
using CoffeeShop.Type;

namespace CoffeeShop.Query
{
    public class SubMenuQuery : ObjectGraphType
    {
        public SubMenuQuery(ISubMenu subMenuService)
        {
            Field<ListGraphType<SubMenuType>>("Submenus",resolve: context => { return subMenuService.GetSubMenus(); });
            Field<ListGraphType<SubMenuType>>("SubMenuById", arguments : new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve : context => 
                {
                    return subMenuService.GetSubMenus(context.GetArgument<int>("id"));
                });    
        }
    }
}