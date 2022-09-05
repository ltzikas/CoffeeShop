using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using CoffeeShop.Models;

namespace CoffeeShop.Type
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.Phone);
            Field(m => m.Time);
            Field(m => m.TotalPeople);
            Field(m => m.Email);
            Field(m => m.Date);
        }
    }
}