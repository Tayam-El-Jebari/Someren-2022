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
    public class RevenueReportDAO : BaseDao
    {
        public List<RevenueReport>GetReport()
        {
            try
            {
                // change attributes from Room, give them the right name. 
                string query = "SELECT D.productId, drinkName, numberOfDrinkSold, salesValue, count( DISTINCT S.studentId) AS customersCount FROM " +
                    "Drink AS D JOIN [Order] as O ON d.[productId] = O.productId JOIN Student as S ON S.[studentId] = O.studentId GROUP BY " +
                    "D.productId, drinkName, numberOfDrinkSold, salesvalue, S.studentid";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception e)
            {
                // within this exception show te user that something went wrong. 
                throw new Exception("Rooms could not be loaded properly. Please try again" + e.Message);
            }

        }

        private List<RevenueReport> ReadTables(DataTable dataTable)
        {
            try
            {
                List<RevenueReport> revenues = new List<RevenueReport>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    RevenueReport revenueProduct = new RevenueReport()
                    {
                        productId = (int)dr["productId"],
                        drinkName = (string)dr["drinkName"],
                        sales = (int)dr["numberOfDrinkSold"],
                        price = (int)dr["salesValue"],
                        numberOfCustomers = (int)dr["customersCount"],
                    };
                    revenues.Add(revenueProduct);
                }
                return revenues;
            }
            catch (Exception e)
            {

                throw new Exception("Data could not be retrieved from the database. Please try agian" + e.Message);
            }

        }
    }
}
