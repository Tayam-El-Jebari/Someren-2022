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
                string query = "SELECT productID, drinkName, stock, salesValue, numberOfDrinkSold FROM [Drink]";

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
            string querry = $"INSERT INTO Drink(stock, salesValue, numberOfDrinkSold, drinkName)VALUES({stock}, {salesValue}, {numberOfSales}, '{drinkName}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(querry, sqlParameters);
        }
        public void UpdateRow(int stock, int salesValue, int numberOfSales, string drinkName)
        { 
            string query = $"UPDATE Drink(stock, salesValue, numberOfDrinkSold, drinkName) VALUES({stock}, {salesValue}, {numberOfSales}, '{drinkName}') WHERE orderID = @orderID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);            
        }

        // Delete Row
        public void DeleteRow(int stock, int salesValue, int numberOfSales, string drinkName)
        {
            string query = $"DELETE FROM Drink WHERE productID = '@productID' ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
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
                        ProductID = (int)dr["productID"],
                        DrinkName = (string)dr["drinkName"],
                        StockAmount = (int)dr["stock"],
                        SalesValue = (int)dr["salesValue"],
                        NumberOfDrinksSold = (int)dr["numberOfDrinkSold"],
                    };
                    drinks.Add(drink);
                }
                return drinks;
            }
            catch (Exception e)
            {
                throw new Exception("Data could not be retrieved from the database. Please try again" + e.Message);
            }
        }
    }
}
