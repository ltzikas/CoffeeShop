using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace CoffeeShop.Query
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Field<MenuQuery>("menuquery", resolve: context => new {});
            Field<SubMenuQuery>("submenuquery", resolve: context => new {});
            Field<ReservationQuery>("reservationquery", resolve: context => new {});
        }
        
    }
}