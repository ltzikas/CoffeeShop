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
    public class ReservationMutation : ObjectGraphType
    {
        public ReservationMutation(IReservation reservationService)
        {
            Field<ReservationType>("CreateReservation",
                                    arguments: new QueryArguments ( new QueryArgument<ReservationInputType> { Name = "reservation"} ),
                                    resolve: context => { return reservationService.AddReservation(context.GetArgument<Reservation>("reservation")); }                            
                                );
        }
    }
}