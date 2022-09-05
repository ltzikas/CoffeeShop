using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Interfaces;
using CoffeeShop.Models;
using CoffeeShop.Data;

namespace CoffeeShop.Services
{
    public class MenuService : IMenu
    {
        private readonly GraphQLDbContext _dbContext;
        
        public MenuService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
            
        }

        public Menu AddMenu(Menu menu)
        {
            _dbContext.Menus.Add(menu);
            _dbContext.SaveChanges();
            return menu;
        }

        public List<Menu> GetMenus()
        {
            return _dbContext.Menus.ToList();
        }
    }
}