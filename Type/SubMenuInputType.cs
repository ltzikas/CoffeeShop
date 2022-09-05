using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace CoffeeShop.Type
{
    public class SubMenuInputType : InputObjectGraphType
    {
        public SubMenuInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("description");
            Field<StringGraphType>("imageurl");
            Field<FloatGraphType>("price");
            Field<IntGraphType>("menuid");
        }
    }
}