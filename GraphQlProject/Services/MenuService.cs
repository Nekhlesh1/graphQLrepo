using GraphQlProject.Data;
using GraphQlProject.Interfaces;
using GraphQlProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlProject.Services
{
    public class MenuService : IMenu
    {
        private GraphQLDbContext _dbcontext;
        public MenuService(GraphQLDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public Menu AddMenu(Menu menu)
        {
            _dbcontext.Add(menu);
            _dbcontext.SaveChanges();
            return menu;
        }

        public List<Menu> GetMenus()
        {
           return _dbcontext.Menus.ToList();
        }
    }
}
