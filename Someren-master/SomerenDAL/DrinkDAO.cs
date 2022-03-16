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
                // change attributes from Drink, give them the right name. 
                string query = "SELECT productID, drinkName, stock, salesValue, numberOfDrinkSold, alcoholic FROM [Drink]";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception e)
            {
                // within this exception show te user that something went wrong. 
                throw new Exception("Drinks could not be loaded properly. Please try again" + e.Message);
            }

        }
        // Add Row
        public void AddRow(int stock, int salesValue, int numberOfSales, string drinkName, bool isAlcoholic)
        {
            string querry = string.Empty;
            if (isAlcoholic)
            querry = $"INSERT INTO Drink(stock, salesValue, numberOfDrinkSold, drinkName, alcoholic)VALUES({stock}, {salesValue}, {numberOfSales}, '{drinkName}', 1)";
            else
            querry = $"INSERT INTO Drink(stock, salesValue, numberOfDrinkSold, drinkName, alcoholic)VALUES({stock}, {salesValue}, {numberOfSales}, '{drinkName}', 0)";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(querry, sqlParameters);
        }

        // deze werkt nog niet
        public void UpdateRow(int stock, int salesValue, int numberOfSales, string drinkName, bool isAlcoholic)
        { 
            string query = $"UPDATE Drink SET {stock}=@stock, {salesValue}=@salesValue, {numberOfSales}=@numberOfDrinkSold, {drinkName}=@drinkName, {isAlcoholic}=@alcoholic WHERE productID = @productID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);            
        }


        // Delete Row
        public void DeleteRow(string drinkName)
        {
            string query = $"DELETE FROM Drink WHERE drinkName='{drinkName}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<Drink> ShowSortedList() 
        {
            string query = "SELECT [productID], [drinkName], [stock], [salesValue], [numberOfDrinkSold], [alcoholic] FROM Drink WHERE[salesValue] > 1 AND [drinkName] != 'Water' AND [drinkName] != 'Orangeade' AND [drinkName] != 'Cherry juice' ORDER BY[stock] DESC, [salesValue] DESC, [numberOfDrinkSold] DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }

        private bool ConvertBitToBool(byte bit) 
        {
            if (bit == 0)
            {
                return false;
            }
            return true;
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
                        IsAlcoholic = (bool)dr["alcoholic"]
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
