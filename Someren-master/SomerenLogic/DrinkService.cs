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
        private DrinkDAO drinksdb;

        public DrinkService()
        {
            drinksdb = new DrinkDAO();
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = drinksdb.GetAllDrinks();
            return drinks;
        }
        public List<Drinks> GetDrinksCR()
        {
            List<Drinks> drinks = drinksdb.GetAllDrinksCR();
            return drinks;
        }
        public void AddRowTable(int stock, int salesValue, int numberOfSales, string drinkName, bool isAlcoholic)
        {
            drinksdb.AddRow(stock, salesValue, numberOfSales, drinkName, isAlcoholic);
        }
        public void UpdateRowTable(int stock, int salesValue, int numberOfSales, string drinkName, bool isAlcoholic)
        {
            drinksdb.UpdateRow(stock, salesValue, numberOfSales, drinkName, isAlcoholic);
        }
        public void DeleteRowTable(string drinkName) 
        {
            drinksdb.DeleteRow(drinkName);
        }
        public List<Drink> ShowSortedList()
        {
            List<Drink>drinks = drinksdb.ShowSortedList();
            return drinks;
        }
    }
}
