using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int StockAmount { get; set; } // how many in stock
        public bool SalesPrice { get; set; }  // greater than 1 token
        public double SalesValue { get; set; } // price of total drinks
        public int NumberOfDrinksSold { get; set; } // how many of the drinks are sold for each prodcut
    }
}
