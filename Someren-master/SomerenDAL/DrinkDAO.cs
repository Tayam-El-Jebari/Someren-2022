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
        public List<Drinks> GetAllDrinks()
        {

            string query = "SELECT orderId, productId, studentId, dateOfPurchase FROM [Order]";            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesDrink(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drinks> ReadTablesDrink(DataTable dataTable)
        {
            try 
            { 
            List<Drinks> drinks = new List<Drinks>();
                foreach (DataRow dr in dataTable.Rows)
                {
                    Drinks drink = new Drinks()
                    {
                        OrderId = (int)dr["orderId"],
                        ProductId = (int)dr["productId"],
                        StudentId = (int)dr["studentId"],
                        DateOfPurchase = (DateTime)dr["dateOfPurchase"]
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
