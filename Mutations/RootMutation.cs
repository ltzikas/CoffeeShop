using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using CoffeeShop.Mutations;

namespace CoffeeShop.Mutations
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation()
        {
            Field<MenuMutation>("menuMutation", resolve: context => new {});
            Field<SubMenuMutation>("subMenuMutation", resolve: context => new {});
            Field<ReservationMutation>("reservationMutation", resolve: context => new {});
        }
    }
}