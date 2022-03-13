using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int ProductID { get; set; } // auto incremented in SQL
        public string DrinkName { get; set; }
        public int StockAmount { get; set; } // how many in stock
        public int SalesValue { get; set; } // price of total drinks
        public int NumberOfDrinksSold { get; set; } // how many of the drinks are sold for each product
        public bool IsAlcoholic { get; set; }
    }
}
