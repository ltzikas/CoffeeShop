using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Interfaces;
using CoffeeShop.Type;
using GraphQL;
using GraphQL.Types;

namespace CoffeeShop.Query
{
    public class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(IReservation reservationService)
        {
            Field<ListGraphType<ReservationType>>("reservations",
                resolve : context => { return reservationService.GetReservations(); } 
             );
        }
    }
}