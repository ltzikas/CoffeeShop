using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using CoffeeShop.Models;

namespace CoffeeShop.Type
{
    public class SubMenuType : ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Description);
            Field(m => m.ImageUrl);
            Field(m => m.Price);
            Field(m => m.MenuId);
        }
    }
}