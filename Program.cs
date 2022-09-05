using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphiQl;
using GraphQL.Types;
using CoffeeShop.Interfaces;
using CoffeeShop.Query;
using CoffeeShop.Schema;
using CoffeeShop.Services;
using CoffeeShop.Type;
using CoffeeShop.Mutations;
using GraphQL.Server;
using CoffeeShop.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services
    .AddTransient<IMenu, MenuService>()
    .AddTransient<ISubMenu, SubMenuService>()
    .AddTransient<IReservation, ReservationService>();
builder.Services
    .AddTransient<MenuType>()
    .AddTransient<SubMenuType>()
    .AddTransient<ReservationType>()
    .AddTransient<MenuInputType>()
    .AddTransient<SubMenuInputType>()
    .AddTransient<ReservationInputType>()
    .AddTransient<MenuQuery>()
    .AddTransient<SubMenuQuery>()
    .AddTransient<ReservationQuery>()
    .AddTransient<RootQuery>()
    .AddTransient<MenuMutation>()
    .AddTransient<SubMenuMutation>()
    .AddTransient<ReservationMutation>()
    .AddTransient<RootMutation>()
    .AddTransient<ISchema, RootSchema>();

builder.Services.AddGraphQL(options => {
    options.EnableMetrics = false;
}).AddSystemTextJson();

builder.Services.AddDbContext<GraphQLDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
    
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.Run();
