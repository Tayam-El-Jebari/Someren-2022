using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class DrinkDAO : BaseDao
    {
        public List<Drink>GetAllDrinks()
        { 
            try
            {
                // change attributes from Room, give them the right name. 
                string query = "SELECT orderID, drinkName, stock, salesValue, numberOfDrinkSold FROM [Drink]";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception e)
            {
                // within this exception show te user that something went wrong. 
                throw new Exception("Drinks could not be loaded properly. Please try again" + e.Message);
            }

        }
        public void AddRow(int stock, int salesValue, int numberOfSales, string drinkName)
        {
            string querry = $"INSERT INTO Drink(stock, salesValue, numberOfDrinkSold, drinkName) VALUES({stock}, {salesValue}, {numberOfSales}, '{drinkName}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(querry, sqlParameters);
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            try
            {
                List<Drink> drinks = new List<Drink>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    Drink drink = new Drink()
                    {
                        OrderID = (int)dr["orderID"],
                        DrinkName = (string)dr["drinkName"],
                        StockAmount = (int)dr["stock"],
                        SalesValue = (double)dr["salesValue"],
                        NumberOfDrinksSold = (int)dr["numberOfDrinkSold"]
                    };
                    drinks.Add(drink);
                }
                return drinks;
            }
            catch (Exception e)
            {

                throw new Exception("Data could not be retrieved from the database. Please try agian" + e.Message);
            }

        }
    }
}
