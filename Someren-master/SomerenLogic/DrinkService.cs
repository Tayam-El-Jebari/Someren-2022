using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class DrinkService
    {
        private DrinkDAO drinkdb;

        public DrinkService()
        {
            drinkdb = new DrinkDAO();
        }

        public List<Drinks> GetDrinks()
        {
            List<Drinks> drinks = drinkdb.GetAllDrinks();
            return drinks;
        }
    }
}
